using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace HotelManagementSystem
{
    class DBHelper
    {
        public SqlConnection connection = new SqlConnection("Server=192.168.133.148;Database=Virgo;uid=sa;pwd=123456");
        public DBHelper()
        {
            connection.Open();
        }
        public SqlDataReader GetResult(string sql) => new SqlCommand(sql, connection).ExecuteReader();
        //适用于执行查询语句并获取查询结果的多行数据。
        public int GetSqlResult(string sql) => Convert.ToInt32(new SqlCommand(sql, connection).ExecuteScalar());
        //适用于执行查询语句并返回单一结果的查询。
        public int GetDsqlResult(string sql) => new SqlCommand(sql, connection).ExecuteNonQuery();
        //适用于执行非查询语句（插入、更新、删除等）并返回受影响的行数。
    }
}
