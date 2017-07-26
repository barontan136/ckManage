using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ckManage.Models
{
    class BuyModel
    {
        private int buy_id = 0;
        private int goods_id = 0;
        private string goods_name = "";
        private double goods_weight = 0.0;
        private string add_time;
        private string create_datetime = "";
        private string operate_user = "";

        public int Buy_id { get => buy_id; set => buy_id = value; }
        public int Goods_id { get => goods_id; set => goods_id = value; }
        public double Goods_weight { get => goods_weight; set => goods_weight = value; }
        public string Add_time { get => add_time; set => add_time = value; }
        public string Create_datetime { get => create_datetime; set => create_datetime = value; }
        public string Operate_user { get => operate_user; set => operate_user = value; }
        public string Goods_name { get => goods_name; set => goods_name = value; }

        public DataSet getAll()
        {
            string sql = string.Format("select * from ck_buy order by buy_id desc limit 100;");
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        public int  getMaxId()
        {
            string sql = string.Format("select max(goods_id) from ck_buy;");
            return (int)Tools.MySqlHelper.ExecuteScalar(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
        //
        public DataSet getRecordByGoodsId(int goods_id)
        {
            string sql = string.Format("select * from ck_buy where goods_id = {0}  order by buy_id desc;", goods_id);
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        //
        public DataSet getRecord(int buy_id)
        {
            string sql = string.Format("select * from ck_buy where buy_id = {0}", buy_id);
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        // 插入数据
        public int Insert(BuyModel record)
        {
            string sql = string.Format("insert into {0} values('{1}', '{2}', {3}, '{4}', '{5}', '{6}')",
                                                                    "ck_buy(goods_id, goods_name, goods_weight, add_time, create_datetime, operate_user)",
                                                                    record.Goods_id,
                                                                    record.Goods_name,
                                                                    record.Goods_weight,
                                                                    record.Add_time,
                                                                    record.Create_datetime,
                                                                    record.Operate_user);
            return Tools.MySqlHelper.ExecuteNonQuery(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
    }
}
