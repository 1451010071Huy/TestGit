using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Storage
    {
        public int MaNL { get; set; }
        public string TenNL { get; set; }
        public DateTime DateIn { get; set; }
        public int ExpirationDay { get; set; }
        public int MaNhaCungCap { get; set; }
        public string DonViTinh { get; set; }
        public int SoLuongTonKho { get; set; }
        public DTO_Storage()
        {

        }
        public DTO_Storage(string mName, DateTime date, int exDay, int supID, string unit, int inStore)
        {

            TenNL = mName;
            DateIn = date;
            ExpirationDay = exDay;
            MaNhaCungCap = supID;
            DonViTinh = unit;
            SoLuongTonKho = inStore;
        }

    }
}
