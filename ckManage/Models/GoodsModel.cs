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
    public class GoodsModel
    {
        private int goods_id = 0;
        private string name = "";
        private string company = "";
        private int unit_id = 0;
        private string unit_name = "";
        private double hold_weight = 0.0;
        private double min_weight = 0.0;
        private int status = 0;
        private string create_datetime = "";
        private string update_datetime = "";

        public int Goods_id { get => goods_id; set => goods_id = value; }
        public string Name { get => name; set => name = value; }
        public string Company { get => company; set => company = value; }
        public int Unit_id { get => unit_id; set => unit_id = value; }
        public string Unit_name { get => unit_name; set => unit_name = value; }
        public double Hold_weight { get => hold_weight; set => hold_weight = value; }
        public double Min_weight { get => min_weight; set => min_weight = value; }
        public int Status { get => status; set => status = value; }
        public string Create_datetime { get => create_datetime; set => create_datetime = value; }
        public string Update_datetime { get => update_datetime; set => update_datetime = value; }

        //
        public DataSet getAll()
        {
            string sql = string.Format("select * from ck_goods");
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        //
        public DataSet getRecord(int goods_id)
        {
            string sql = string.Format("select * from ck_goods where goods_id = {0}", goods_id); 
            return Tools.MySqlHelper.GetDataSet(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        public int getMaxRecordID()
        {
            string sql = string.Format("select max(goods_id) from ck_goods;");
            return (int)Tools.MySqlHelper.ExecuteScalar(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        // 插入数据
        public int Insert(GoodsModel goods)
        {
            string sql = string.Format("insert into {0} values('{1}', '{2}', {3}, '{4}', '{5}', '{6}', '{7}', '{8}', '{9}')",
                                                                    "ck_goods(name, company, unit_id, unit_name, hold_weight, min_weight, status, create_datetime, update_datetime)",
                                                                    goods.Name,
                                                                    goods.Company,
                                                                    goods.Unit_id,
                                                                    goods.Unit_name,
                                                                    goods.Hold_weight,
                                                                    goods.Min_weight,
                                                                    goods.Status,
                                                                    goods.Create_datetime,
                                                                    goods.Update_datetime);
            return Tools.MySqlHelper.ExecuteNonQuery(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }

        // 更新数据
        public int updateHoldWeight(GoodsModel goods)
        {
            string sql = string.Format("UPDATE ck_goods SET hold_weight = {0} WHERE goods_id = {1};",
                                                                    goods.Hold_weight,
                                                                    goods.Goods_id);
            return Tools.MySqlHelper.ExecuteNonQuery(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
        public int update(GoodsModel goods)
        {
            string sql = string.Format("UPDATE ck_goods SET min_weight = {0}, update_datetime = '{1}', company = '{2}', status = {3} WHERE goods_id = {4};",
                                                                    goods.Min_weight,
                                                                    goods.update_datetime,
                                                                    goods.Company,
                                                                    goods.Status,
                                                                    goods.Goods_id);
            // 去掉配比中响应的原材料
            // TODO
            return Tools.MySqlHelper.ExecuteNonQuery(Tools.MySqlHelper.Conn, CommandType.Text, sql, null);
        }
    }
}
