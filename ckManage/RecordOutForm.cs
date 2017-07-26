using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ckManage.Models;

namespace ckManage
{
    public partial class RecordOutForm : Form
    {
        public RecordOutForm()
        {
            InitializeComponent();
            InitData();
        }

        private void InitData()
        {
            try
            {
                MatchModel matchModel = new MatchModel();
                DataSet dsMatch = matchModel.getAll();

                combox_match.DataSource = dsMatch.Tables[0].DefaultView;
                combox_match.DisplayMember = "name";
                combox_match.ValueMember = "match_id";
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_comfirm_Click(object sender, EventArgs e)
        {
            if (combox_match.Text == ""
                || txt_weight.Text == "")
            {
                return;
            }

            try
            {
                MatchModel match_model = new MatchModel();
                DataSet dsMatch = match_model.getOne(int.Parse(combox_match.SelectedValue.ToString()));
                string sold_config = dsMatch.Tables[0].Rows[0]["config"].ToString();
                if (sold_config == "") return;

                SoldModel model = new SoldModel();
                model.Match_id = int.Parse(combox_match.SelectedValue.ToString());
                model.Match_name = combox_match.Text;
                model.Match_weight = int.Parse(txt_weight.Text);
                model.Sold_config = sold_config;
                model.Status = 0;
                model.Create_datetime = dt_sold.Value.ToString();
                model.Update_datetime = DateTime.Now.ToString();
                model.Operate_user = "系统管理员";

                string[] sMatchArr = model.Sold_config.Split('&');
                List<GoodsModel> goodsModels = new List<GoodsModel>();
                List<TradeLogModel> tradeModels = new List<TradeLogModel>();
                int i = 0;
                for (;i < sMatchArr.Length; i++)
                {
                    string[] sGoodsArr = sMatchArr[i].Split('#');
                    if (sGoodsArr.Length != 3) continue;

                    int goods_id = int.Parse(sGoodsArr[0]);
                    string goods_name = sGoodsArr[1];
                    double goods_inc_weight = int.Parse(sGoodsArr[2]) * model.Match_weight;
                    if (goods_inc_weight <= 0) continue;
                    // 更新原材料最新库存
                    GoodsModel goods_model = new GoodsModel();
                    DataSet ds_goods = goods_model.getRecord(goods_id);
                    goods_model.Hold_weight = double.Parse(ds_goods.Tables[0].Rows[0]["hold_weight"].ToString());
                    if (goods_model.Hold_weight < goods_inc_weight)
                    {// 库存不够，请重新检查后出库
                        break;
                    }
                    goods_model.Goods_id = goods_id;
                    goods_model.Name = goods_name;
                    goods_model.Hold_weight -= goods_inc_weight;
                    goods_model.Dummy = goods_inc_weight.ToString();    // 操作克重
                    goodsModels.Add(goods_model);
                }
                if (i < sMatchArr.Length)
                {// 库存不够
                    MessageBox.Show(sMatchArr[i] + "  库存不够，请重新检查库存！！！");
                    return;
                }

                // 插入出库记录
                model.Insert(model);
                // 减去库存,插入log记录
                foreach (GoodsModel gModel in goodsModels)
                {
                    // 减库存
                    gModel.updateHoldWeight(gModel);
                    // 插入Log记录
                    TradeLogModel trade_model = new TradeLogModel();
                    trade_model.Goods_id = gModel.Goods_id;
                    trade_model.Goods_name = gModel.Name;
                    trade_model.Trade_id = model.getMaxId();
                    trade_model.Trade_type = 1; // 0入库 1出库
                    trade_model.Trade_weight = double.Parse(gModel.Dummy);
                    trade_model.After_weight = gModel.Hold_weight;
                    trade_model.Insert(trade_model);
                }
                
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception err)
            {
                Console.Write(err.Message);
                return;
            }
        }
    }
}
