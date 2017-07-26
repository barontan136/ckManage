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
    public partial class goods_add : Form
    {
        GoodsUnitModel m_unitModel = null;
        public GoodsModel m_goodsModel = null;
        public goods_add()
        {
            InitializeComponent();

            m_unitModel = new GoodsUnitModel();
            if (m_goodsModel == null)
            {
                m_goodsModel = new GoodsModel();
            }
            
        }
        private void goods_add_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            DataSet dsUnit = m_unitModel.getAll();

            combox_goods_unit.DataSource = dsUnit.Tables[0].DefaultView;
            combox_goods_unit.DisplayMember = "name";
            combox_goods_unit.ValueMember = "unit_id";

            if (m_goodsModel.Goods_id != 0)
            {// 更新时
                this.Text = "修改原材料";
                txt_goods_name.Enabled = false;
                if (m_goodsModel.Status != 0) combox_status.Enabled = false;

                txt_goods_name.Text = m_goodsModel.Name;
                txt_goods_company.Text = m_goodsModel.Company;
                combox_goods_unit.Text = m_goodsModel.Unit_name;
                txt_min_weight.Text = m_goodsModel.Min_weight.ToString();
                combox_status.SelectedIndex = m_goodsModel.Status;
            }
            else
            {// 新增时
                combox_status.SelectedIndex = 0;
                combox_status.Enabled = false;
            }
        }

        private void btn_goods_add_ok_Click(object sender, EventArgs e)
        {
            if (txt_goods_name.Text.Trim() == ""
                || combox_goods_unit.SelectedValue.ToString() == ""
                || combox_goods_unit.Text == ""
                || txt_min_weight.Text == ""
                || combox_status.Text == "")
            {
                MessageBox.Show("输入数据错误，请仔细检查！！！");
                return;
            }
            //
            try
            {
                m_goodsModel.Company = txt_goods_company.Text;
                m_goodsModel.Min_weight = int.Parse(txt_min_weight.Text);
                m_goodsModel.Update_datetime = DateTime.Now.ToString();
                m_goodsModel.Status = int.Parse(combox_status.Text.Split(',')[1].ToString());

                if (m_goodsModel.Goods_id != 0)
                {// 修改原材料
                    m_goodsModel.update(m_goodsModel);
                    //
                    if (m_goodsModel.Status > 0)
                    {// 废弃或者删除
                        if (m_goodsModel.Hold_weight > 0)
                        {
                            DialogResult dr = MessageBox.Show("该原料还有库存，确认废弃/删除吗？", "提示", MessageBoxButtons.OKCancel);
                            if (dr == DialogResult.Cancel)
                            {
                                //用户选择取消的操作
                                return;
                            }
                        }
                        // 所有配比中去掉这个原材料的配置
                        MatchModel match_model = new MatchModel();
                        DataTable dtMatch = new DataTable();
                        dtMatch = match_model.getAll().Tables[0];
                        int i = 0;
                        for(i =0; i< dtMatch.Rows.Count; i++)
                        {// 遍历配比数量
                            string[] sMatchArrs = dtMatch.Rows[i]["config"].ToString().Split('&');
                            string sConfigUpdate = "";
                            int j = 0;
                            for(j = 0; j< sMatchArrs.Length; j++)
                            {// 遍历单个配比中的原材料
                                string[] sItemArrs = sMatchArrs[j].Split('#');
                                if (int.Parse(sItemArrs[0]) != m_goodsModel.Goods_id)
                                {// 如果不是本次删除的原材料ID
                                    sConfigUpdate += sMatchArrs[j] + "&";
                                }
                            }
                            sConfigUpdate = sConfigUpdate.Substring(0, sConfigUpdate.Length - 1);
                            match_model.Match_id = int.Parse(dtMatch.Rows[i]["match_id"].ToString());
                            match_model.Config = sConfigUpdate;
                            match_model.update(match_model);
                        }
                    }
                    
                }
                else
                {// 新增原材料
                    m_goodsModel.Unit_id = int.Parse(combox_goods_unit.SelectedValue.ToString());
                    m_goodsModel.Unit_name = combox_goods_unit.Text;
                    m_goodsModel.Name = txt_goods_name.Text;
                    m_goodsModel.Hold_weight = 0;
                    m_goodsModel.Status = 0;
                    m_goodsModel.Create_datetime = DateTime.Now.ToString();
                    //
                    m_goodsModel.Insert(m_goodsModel);
                    // 增加配比中的原材料类型，默认比重为0 
                    MatchModel match_model = new MatchModel();
                    DataTable dtMatch = new DataTable();
                    dtMatch = match_model.getAll().Tables[0];
                    int i = 0;
                    for (i = 0; i < dtMatch.Rows.Count; i++)
                    {// 遍历配比数量
                        string sConfigUpdate = dtMatch.Rows[i]["config"].ToString();
                        sConfigUpdate = String.Format("{0}&{1}#{2}#0", sConfigUpdate, m_goodsModel.getMaxRecordID(), m_goodsModel.Name);
                        match_model.Match_id = int.Parse(dtMatch.Rows[i]["match_id"].ToString());
                        match_model.Config = sConfigUpdate;
                        match_model.update(match_model);
                    }
                }
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
