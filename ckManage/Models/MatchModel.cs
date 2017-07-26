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
    class MatchModel
    {
        private int match_id = 0;
        private string name = "";
        private string config = "";
        private int status = 0;
        private string create_datetime = "";
        private string update_datetime = "";

        public int Match_id { get => match_id; set => match_id = value; }
        public string Name { get => name; set => name = value; }
        public string Config { get => config; set => config = value; }
        public int Status { get => status; set => status = value; }
        public string Create_datetime { get => create_datetime; set => create_datetime = value; }
        public string Update_datetime { get => update_datetime; set => update_datetime = value; }


        //
        public DataSet getAll()
        {
            string sql = string.Format("select * from ck_match");
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
        //
        public DataSet getOne(int match_id)
        {
            string sql = string.Format("select * from ck_match where match_id = {0};", match_id);
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }


        public int update(MatchModel model)
        {
            string sql = string.Format("update ck_match set config = '{0}', update_datetime = '{1}' where match_id = {2} ",
                                        model.Config, DateTime.Now.ToString(), model.Match_id);
            return Tools.MySqlHelper.ExecuteNonQuery(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        public int insert(MatchModel model)
        {
            string sql = string.Format("insert into ck_match(name, config, status, create_datetime, update_datetime) values('{0}','{1}','{2}','{3}', '{4}')",
                                        model.Name, model.Config, model.Status, model.Create_datetime, model.Update_datetime);
            return Tools.MySqlHelper.ExecuteNonQuery(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
    }
}
