using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ckManage.Models
{
    class SoldModel
    {
        private int sold_id = 0;
        private int match_id = 0;
        private string match_name = "";
        private double match_weight = 0.0;
        private string sold_config = "";
        private int status = 0;
        private string create_datetime = "";
        private string update_datetime = "";
        private string operate_user = "";

        public int Sold_id { get => sold_id; set => sold_id = value; }
        public int Match_id { get => match_id; set => match_id = value; }
        public string Match_name { get => match_name; set => match_name = value; }
        public double Match_weight { get => match_weight; set => match_weight = value; }
        public string Sold_config { get => sold_config; set => sold_config = value; }
        public string Create_datetime { get => create_datetime; set => create_datetime = value; }
        public string Update_datetime { get => update_datetime; set => update_datetime = value; }
        public int Status { get => status; set => status = value; }
        public string Operate_user { get => operate_user; set => operate_user = value; }

        public DataSet getAll()
        {
            string sql = string.Format("select * from ck_sold order by sold_id desc limit 100;");
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        public int  getMaxId()
        {
            string sql = string.Format("select max(goods_id) from ck_sold;");
            return (int)Tools.MySqlHelper.ExecuteScalar(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
        //
        public DataSet getRecord(int sold_id)
        {
            string sql = string.Format("select * from ck_sold where sold_id = {0}", sold_id);
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
        //
        public DataSet getRecordByMatchId(int match_id)
        {
            string sql = string.Format("select * from ck_sold where match_id = {0}", match_id);
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        // 插入数据
        public int Insert(SoldModel record)
        {
            string sql = string.Format("insert into {0} values('{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', '{8}')",
                                                                    "ck_sold(match_id, match_name, match_weight, sold_config, status, operate_user, create_datetime, update_datetime)",
                                                                    record.Match_id,
                                                                    record.Match_name,
                                                                    record.Match_weight,
                                                                    record.Sold_config,
                                                                    record.Status,
                                                                    record.Operate_user,
                                                                    record.Create_datetime,
                                                                    record.Update_datetime);
            return Tools.MySqlHelper.ExecuteNonQuery(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
    }
}
