using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

using DTO;

namespace DAO
{
    public class MonAnvaBan_DAO
    {
        private DataProvider dp;
        
        public MonAnvaBan_DAO()
        {
            dp = new DataProvider();
        }

        public void XoaMonAn(MonAnvaBan_DTO dm, int maban)
        {
            
            SqlConnection cnn = dp.getConnect();
            dp.Connect();//ham nay de ket noi thay thi cnn.open();
            string xoaMonAn = "DELETE FROM MonAnvaBan WHERE MaMonAn = '" + dm.MaMonAn + "'" +"and MaBan ='" + maban +"'";
            SqlCommand cmd = new SqlCommand(xoaMonAn, cnn);
            cmd.ExecuteNonQuery();
        }
        public DataTable GetTheoSoBan(string sql)
        {
            SqlDataAdapter adap = new SqlDataAdapter(sql, dp.cnn);
            DataTable dt = new DataTable();
            adap.Fill(dt);
            return dt;
        }

        public List<MonAnvaBan_DTO> GetMonAnvaBan_DAO(string sql)
        {
            List<MonAnvaBan_DTO> list = new List<MonAnvaBan_DTO>();
            SqlCommand cmd = new SqlCommand(sql, dp.cnn);
            SqlDataReader dr;
            int MaBan;
            int MaMonAn;
            DateTime ThoiGian;
            dp.Connect(); 
            //SqlConnection cnn = dp.getConnect();
            //cnn.Open();
            try
            {
                dr = cmd.ExecuteReader();
                //SqlDataReader dr = dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    MaBan = dr.GetInt32(0);
                    MaMonAn = dr.GetInt32(1);
                    ThoiGian = dr.GetDateTime(2);
                    MonAnvaBan_DTO prod = new MonAnvaBan_DTO(MaBan, MaMonAn, ThoiGian);
                    list.Add(prod);
                }
                return list;                
            }
            catch (SqlException ex)
            {
                return null;
                throw ex;
            }       
            finally
            {
                dp.DisConnect();
            }
        }
        public void Add_Monan(int maban, int mamonan, DateTime thoigian)
        {         
            try
            {
                dp.Connect();
                string query = "Insert into MonAnvaBan (MaBan, MaMonAn, ThoiGian) values ('" + maban + "','" + mamonan + "','" + thoigian + "')";
                SqlCommand cmd = new SqlCommand(query, dp.cnn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {                
                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
        }
        public void Add_ThongTinHoaDon(string khuvuc, int maban, string hinhthucthanhtoan)
        {
            try
            {
                dp.Connect();
                string query = "Insert into ThongTinHoaDon (KhuVuc, MaBan, HinhThucThanhToan ) values (N'" + khuvuc + "','" + maban + "',N'" + hinhthucthanhtoan + "')";
                SqlCommand cmd = new SqlCommand(query);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                dp.DisConnect();
            }
        }
    }
}
