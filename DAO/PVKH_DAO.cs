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
    public class PVKH_DAO
    {
        private DataProvider dp;

        public PVKH_DAO()
        {
            dp = new DataProvider();
        }

        public List<PVKH_DTO> GetPVKH_DAO(string sql)
        {
            List<PVKH_DTO> list = new List<PVKH_DTO>();
            SqlCommand cmd = new SqlCommand(sql, dp.cnn);
            SqlDataReader dr;
            string TenMonAn, DonViTinh;
            int MaMonAn, MaDanhMuc;
            string phuong;
            double GiaTien;
            dp.Connect();
            try
            {
                //SqlDataReader dr = dp.ExecuteReader(sql);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    MaMonAn = dr.GetInt32(0);
                    TenMonAn = dr.GetString(1);
                    phuong = Convert.ToString(dr["GiaTien"]);
                    GiaTien = Convert.ToDouble(phuong);
                    MaDanhMuc = dr.GetInt32(3);
                    DonViTinh = dr.GetString(4);

                    PVKH_DTO prod = new PVKH_DTO(MaMonAn, TenMonAn, GiaTien, MaDanhMuc, DonViTinh);
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
    }
}
