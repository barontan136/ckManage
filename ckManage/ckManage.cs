
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using MySql.Data.MySqlClient;.Tables[0].DefaultView
using ckManage.Tools;
using ckManage.Models;

namespace ckManage
{
    public partial class ck_main : Form
    {
        private int m_current_page = 100;

        public ck_main()
        {
            InitializeComponent();
            InitData();

            showtabcontrol(0);
        }


        private void InitData()
        { 

           /* DataSet ds_test = MySqlHelper.GetDataSet(MySqlHelper.Conn, CommandType.Text, "select * from ck_buy", null);
            dgv_buyRecord.DataSource = ds_test.Tables[0].DefaultView;
            */

            InitGoodsData();
            InitBuyRecord();
        }

        // 初始化入库记录
        private void InitBuyRecord()
        {
            updateBuyRecord(0);
        }
        

        // 初始化原材料品名
        private void InitGoodsData()
        {
            try
            {
                GoodsModel goods = new GoodsModel();
                DataSet ds_goods = goods.getAll();
                int iCnt = ds_goods.Tables[0].Rows.Count;
                dgv_goods.RowCount = iCnt;
                for (int i = 0; i < iCnt; i++)
                {
                    dgv_goods.Rows[i].Cells[0].Value = ds_goods.Tables[0].Rows[i]["goods_id"];
                    dgv_goods.Rows[i].Cells[1].Value = ds_goods.Tables[0].Rows[i]["name"];
                    dgv_goods.Rows[i].Cells[2].Value = ds_goods.Tables[0].Rows[i]["company"];
                    dgv_goods.Rows[i].Cells[3].Value = ds_goods.Tables[0].Rows[i]["unit_name"];
                    dgv_goods.Rows[i].Cells[4].Value = ds_goods.Tables[0].Rows[i]["hold_weight"];
                    dgv_goods.Rows[i].Cells[5].Value = ds_goods.Tables[0].Rows[i]["min_weight"];
                    //0:正常 1:废弃 2:删除
                    string sStatus = "正常";
                    if ( int.Parse(ds_goods.Tables[0].Rows[i]["status"].ToString()) == 1)
                    {
                        sStatus = "废弃";
                    }
                    else if (int.Parse(ds_goods.Tables[0].Rows[i]["status"].ToString()) == 2)
                    {
                        sStatus = "删除";
                    }
                    dgv_goods.Rows[i].Cells[6].Value = sStatus;
                    dgv_goods.Rows[i].Cells[7].Value = ds_goods.Tables[0].Rows[i]["update_datetime"];
                    
                } //
                combox_goods.DataSource = ds_goods.Tables[0].DefaultView;
                combox_goods.DisplayMember = "name";
                combox_goods.ValueMember = "goods_id";
            }
            catch(Exception e)
            {
                Console.Write(e.Message);
            }
        }

        // 添加产品
        private void toolsmenu_goodsadd_Click(object sender, EventArgs e)
        {
            goods_add m_goodsadd = new goods_add();
            DialogResult result = m_goodsadd.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitGoodsData();
            }
        }
        // 修改产品
        private void dgv_goods_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GoodsModel goodsModel = new GoodsModel();
            goodsModel.Goods_id = int.Parse(this.dgv_goods.CurrentRow.Cells[0].Value.ToString());
            goodsModel.Name = this.dgv_goods.CurrentRow.Cells[1].Value.ToString();
            goodsModel.Company = this.dgv_goods.CurrentRow.Cells[2].Value.ToString();
            goodsModel.Unit_name = this.dgv_goods.CurrentRow.Cells[3].Value.ToString();
            goodsModel.Min_weight = double.Parse(this.dgv_goods.CurrentRow.Cells[5].Value.ToString());
            goodsModel.Status = 0;
            if (this.dgv_goods.CurrentRow.Cells[6].Value.ToString() == "废弃")
            {
                goodsModel.Status = 1;
            }
            
            goods_add goodsAdd = new goods_add();
            goodsAdd.m_goodsModel = goodsModel;
            DialogResult result = goodsAdd.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitGoodsData();
            }
        }

        private void showtabcontrol(int iPage)
        {
            if (iPage == m_current_page) return;

            // 先清除所以tabpage
            foreach (TabPage tabPage in tabcontrol_main.TabPages)
            {
                tabcontrol_main.TabPages.Remove(tabPage);
            }

            switch (iPage)
            {
                case 0:
                    tabcontrol_main.TabPages.Add(tab_page_in);
                    break;
                case 1:
                    tabcontrol_main.TabPages.Add(tab_page_out);
                    break;
                case 2:
                    tabcontrol_main.TabPages.Add(tab_page_goods);
                    break;
                case 3:
                    tabcontrol_main.TabPages.Add(tab_page_match);
                    break;
                case 4:
                    tabcontrol_main.TabPages.Add(tab_page_table);
                    break;
            }
            m_current_page = iPage;

        }

        private void menu_out_Click(object sender, EventArgs e)
        {
            showtabcontrol(1);
        }
        private void menu_match_Click(object sender, EventArgs e)
        {
            showtabcontrol(3);
        }
        private void menu_goods_Click(object sender, EventArgs e)
        {
            showtabcontrol(2);
            InitGoodsData();
        }
        private void 报表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showtabcontrol(4);
        }
        private void menu_in_Click(object sender, EventArgs e)
        {
            showtabcontrol(0);
        }

        #region 入库操作相
        private void btn_goods_search_Click(object sender, EventArgs e)
        {
            if (combox_goods.Items.Count <= 0) return;
            int goods_id = int.Parse(combox_goods.SelectedValue.ToString());
            updateBuyRecord(1, goods_id); ;
        }
        private void btn_goods_in_Click(object sender, EventArgs e)
        {
            RecordInForm recordeIn = new RecordInForm();
            recordeIn.Owner = this;
            DialogResult result = recordeIn.ShowDialog();
            if (result == DialogResult.OK)
            {// 查询出全部
                updateBuyRecord(0);
            }
        }
        private void btn_goods_all_Click(object sender, EventArgs e)
        {
            updateBuyRecord(0);
        }
        #endregion



        /// <summary>
        /// 更新入库单数据
        /// </summary>
        /// <param name="iType">0 取所有数据  1取goods_id数据</param>
        /// <param name="goods_id">原材料品名ID</param>
        private void updateBuyRecord(int iType, int goods_id = 0)
        {
            BuyModel buy_records = new BuyModel();
            DataSet ds_goods = new DataSet();
            try
            {
                if (iType == 0)
                {// 取所有
                    ds_goods = buy_records.getAll();
                }
                else
                {
                    ds_goods = buy_records.getRecordByGoodsId(goods_id);
                }
                int iCnt = ds_goods.Tables[0].Rows.Count;
                dgv_buyRecord.RowCount = iCnt;
                for (int i = 0; i < iCnt; i++)
                {
                    dgv_buyRecord.Rows[i].Cells[0].Value = ds_goods.Tables[0].Rows[i]["buy_id"];
                    dgv_buyRecord.Rows[i].Cells[1].Value = ds_goods.Tables[0].Rows[i]["goods_name"];
                    dgv_buyRecord.Rows[i].Cells[2].Value = ds_goods.Tables[0].Rows[i]["goods_weight"];
                    dgv_buyRecord.Rows[i].Cells[3].Value = ds_goods.Tables[0].Rows[i]["add_time"];
                    dgv_buyRecord.Rows[i].Cells[4].Value = ds_goods.Tables[0].Rows[i]["operate_user"];
                }
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
            }
        }

        #region 配比管理
        private void btn_match_search_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
