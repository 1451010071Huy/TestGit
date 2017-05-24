using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class MonAnvaBan_DTO
    {
        public int MaBan { get; set; }
        public int MaMonAn { get; set; }
        public DateTime ThoiGian { get; set; }
        public MonAnvaBan_DTO(int maban, int mamonan, DateTime thoigian)
        {
            this.MaBan = maban;
            this.MaMonAn = mamonan;
            this.ThoiGian = thoigian;
        }
        public MonAnvaBan_DTO(int mamonan)
        {
            this.MaMonAn = mamonan;
        }
    }
}
