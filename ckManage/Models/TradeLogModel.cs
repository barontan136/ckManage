using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ckManage.Models
{
    class TradeLogModel
    {
        private int log_id = 0;
        private int goods_id = 0;
        private string goods_name = "";
        private int trade_id = 0;
        private int trade_type = 0;
        private double trade_weight = 0.0;
        private double after_weight = 0.0;
        private string operate_user = "";
        private string create_datetime = "";

        public int Log_id { get => log_id; set => log_id = value; }
        public int Goods_id { get => goods_id; set => goods_id = value; }
        public string Goods_name { get => goods_name; set => goods_name = value; }
        public int Trade_id { get => trade_id; set => trade_id = value; }
        public int Trade_type { get => trade_type; set => trade_type = value; }
        public double Trade_weight { get => trade_weight; set => trade_weight = value; }
        public double After_weight { get => after_weight; set => after_weight = value; }
        public string Operate_user { get => operate_user; set => operate_user = value; }
        public string Create_datetime { get => create_datetime; set => create_datetime = value; }

        public DataSet getAll()
        {
            string sql = string.Format("select * from ck_trade_log order by trade_id DESC;");
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        // 插入数据
        public int Insert(TradeLogModel record)
        {
            string sql = string.Format("insert into {0} values('{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', '{8}')",
                                                                    "ck_trade_log(goods_id, goods_name, trade_id, trade_type,trade_weight, after_weight,create_datetime, operate_user)",
                                                                    record.Goods_id,
                                                                    record.Goods_name,
                                                                    record.Trade_id,
                                                                    record.Trade_type,
                                                                    record.Trade_weight,
                                                                    record.After_weight,
                                                                    DateTime.Now.ToString(),
                                                                    "系统管理员"
                                                                    );
            return Tools.MySqlHelper.ExecuteNonQuery(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
    }
}
