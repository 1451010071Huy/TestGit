using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace DAO
{
    public class DAO_Storage
    {
      static string cnStr = ConfigurationManager.ConnectionStrings["cnstr"].ConnectionString;
         SqlConnection   cn = new SqlConnection(cnStr);
         SqlDataAdapter sda;
         DataSet ds;
         SqlDataAdapter sda2;
         DataSet ds2;
       
         SqlCommandBuilder cb;

        private DataProvider dp ; 
        public DAO_Storage()
        {
            dp = new DataProvider ();
        }
        public DataSet LoadData(string sql)
        {

            sda = new SqlDataAdapter(sql, cn);
            ds = new DataSet();
            cb = new SqlCommandBuilder(sda);
            sda.Fill(ds);
            return ds;   
            
        }
        public DataSet LoadReport(SqlCommand cmd)
        {
            sda = new SqlDataAdapter();
         DataSet ds = new DataSet();
         cmd.Connection = cn;
         sda.SelectCommand = cmd;
            sda.Fill(ds);
            return ds;
        }
 
        public DataSet LoadData2(SqlCommand cmd)
        {
            sda2 = new SqlDataAdapter();
            
            ds2 = new DataSet();
            cb = new SqlCommandBuilder(sda2);
            
            cmd.Connection = cn;
            sda2.SelectCommand = cmd;
            sda2.Fill(ds2);
           
            return ds2;

        }
        public void Execute(SqlCommand cmd,string sql )
        {
            cn.Open();
            cmd.Connection = cn;
            cmd.CommandText = sql;
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            cmd.Parameters.Clear();
            cn.Close();
        }

       
    }
}
