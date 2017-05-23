using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PVKH_DTO
    {
        public int MaMonAn { get; set; }
        public string TenMonAn { get; set; }

        public double GiaTien { get; set; }
        public int MaDanhMuc { get; set; }
       
        public string DonViTinh { get; set; }

        public PVKH_DTO(int mamonan, string tenmonan, double giatien, int madanhmuc, string donvitinh)
        {
            this.MaMonAn = mamonan;
            this.TenMonAn = tenmonan;
            this.MaDanhMuc = madanhmuc;
            this.GiaTien = giatien;
            this.DonViTinh = donvitinh;
        }
    }
}
