using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ckManage.Tools;
using System.Data;
using MySql.Data.MySqlClient;

namespace ckManage.Models
{
    class GoodsUnitModel
    {
        private int unit_id = 0;
        private string name = "";
        private string short_name = "";
        private string create_datetime = "";

        public int Unit_id { get => unit_id; set => unit_id = value; }
        public string Name { get => name; set => name = value; }
        public string Short_name { get => short_name; set => short_name = value; }
        public string Create_datetime { get => create_datetime; set => create_datetime = value; }

        //
        public DataSet getAll()
        {
            string sql = string.Format("select * from ck_goods_unit");
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
    }
}
