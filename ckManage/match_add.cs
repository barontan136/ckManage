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
    public partial class match_add : Form
    {
        public string m_match_config = "";

        public match_add()
        {
            InitializeComponent();
        }

        private void btn_match_add_confirm_Click(object sender, EventArgs e)
        {
            if (txt_match_name.Text == "")
            {
                return;
            }

            MatchModel matchModel = new MatchModel();

            try
            {
                matchModel.Name = txt_match_name.Text;
                matchModel.Config = m_match_config;
                matchModel.Status = 0;
                matchModel.Create_datetime = DateTime.Now.ToString();
                matchModel.Update_datetime = DateTime.Now.ToString();

                if (matchModel.insert(matchModel) > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("添加失败" + ex.Message);
            }
        }
    }
}
