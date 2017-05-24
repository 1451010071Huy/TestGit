using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using DAO;
using DTO;

namespace BUS
{
    public class PVKH_BUS
    {
        public List<PVKH_DTO> GetPVKH_BUS(string sql)
        {
            
            try
            {
                return new PVKH_DAO().GetPVKH_DAO(sql);
            }
            catch (SqlException ex)
            {

                throw ex;
            }
        }
    }
}
