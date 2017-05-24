using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

using DAO;
using DTO;

namespace BUS
{
    public class MonAnvaBan_BUS
    {
        public List<MonAnvaBan_DTO> GetMonAnvaBan_BUS(string sql)
        {
            try
            {
                return new MonAnvaBan_DAO().GetMonAnvaBan_DAO(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
        public void XoaMonAn(MonAnvaBan_DTO ma, int maban)
        {
            
            MonAnvaBan_DAO mon = new MonAnvaBan_DAO();
            mon.XoaMonAn(ma, maban);
        }
        public void Add_Monan(int maban, int mamonan, DateTime thoigian)
        {
            MonAnvaBan_DAO mon = new MonAnvaBan_DAO();
            mon.Add_Monan(maban, mamonan, thoigian);
        }
        public void Add_ThongTinHoaDon(string khuvuc, int maban, string hinhthucthanhtoan)
        {
            MonAnvaBan_DAO mon = new MonAnvaBan_DAO();
            mon.Add_ThongTinHoaDon(khuvuc, maban, hinhthucthanhtoan);
        }
        public DataTable GetTheoSoBan(string sql)
        {
            MonAnvaBan_DAO mon = new MonAnvaBan_DAO();
            return mon.GetTheoSoBan(sql);
        }
    }
}
