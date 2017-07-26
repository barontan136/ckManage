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
    public partial class RecordInForm : Form
    {
        public RecordInForm()
        {
            InitializeComponent();

            InitData();
        }

        void InitData()
        {
            try
            {
                GoodsModel goods = new GoodsModel();
                DataSet ds_goods = goods.getAll();
                combox_goods.DataSource = ds_goods.Tables[0].DefaultView;
                combox_goods.DisplayMember = "name";
                combox_goods.ValueMember = "goods_id";
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        private void btn_comfirm_Click(object sender, EventArgs e)
        {
            try
            {
                BuyModel buy_model = new BuyModel();
                buy_model.Goods_id = int.Parse(combox_goods.SelectedValue.ToString());
                buy_model.Goods_name =  combox_goods.Text;
                buy_model.Goods_weight = double.Parse(txt_weight.Text);
                buy_model.Add_time = dt_buy_record.Value.ToString();
                buy_model.Create_datetime = DateTime.Now.ToString();
                buy_model.Operate_user = "系统管理员";

                buy_model.Insert(buy_model);

                // 更新总库存
                GoodsModel goods_model = new GoodsModel();
                DataSet ds_goods = goods_model.getRecord(buy_model.Goods_id);
                goods_model.Hold_weight = double.Parse(ds_goods.Tables[0].Rows[0]["hold_weight"].ToString());
                goods_model.Goods_id = buy_model.Goods_id;
                goods_model.Hold_weight += buy_model.Goods_weight;
                goods_model.updateHoldWeight(goods_model);

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
