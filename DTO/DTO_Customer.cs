using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Customer
    {
        private int maKH;

        public int MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        private string hoKH;

        public string HoKH
        {
            get { return hoKH; }
            set { hoKH = value; }
        }
        private string tenKH;

        public string TenKH
        {
            get { return tenKH; }
            set { tenKH = value; }
        }
        private string sodienthoai;

        public string SoDienThoai
        {
            get { return sodienthoai; }
            set { sodienthoai = value; }
        }
        private DateTime ngaysinh;

        public DateTime NgaySinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        private string noisinh;

        public string NoiSinh
        {
            get { return noisinh; }
            set { noisinh = value; }
        }
        private string gioitinh;

        public string GioiTinh
        {
            get { return gioitinh; }
            set { gioitinh = value; }
        }
        private string soCMND;

        public string SoCMND
        {
            get { return soCMND; }
            set { soCMND = value; }
        }
        private int diemtichluy;

        public int DiemTichLuy
        {
            get { return diemtichluy; }
            set { diemtichluy = value; }
        }
        private string diachithuongtru;

        public string DiaChiThuongTru
        {
            get { return diachithuongtru; }
            set { diachithuongtru = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public DTO_Customer(int pMaKH, string pHoKH, string pTenKH, string pSoDienThoaiKH, DateTime pNgaySinhKH, string pNoiSinhKH, string pGioiTinhKH, string pSoCMNDKH, int pDiemTichLuy, string pDiaChiThuongTru, string pEmail)
        {
            MaKH = pMaKH;
            HoKH = pHoKH;
            TenKH = pTenKH;
            SoDienThoai = pSoDienThoaiKH;
            NgaySinh = pNgaySinhKH;
            NoiSinh = pNoiSinhKH;
            GioiTinh = pGioiTinhKH;
            SoCMND = pSoCMNDKH;
            DiemTichLuy = pDiemTichLuy;
            DiaChiThuongTru = pDiaChiThuongTru;
            Email = pEmail;
        }
        public DTO_Customer(string pHoKH,string pTenKH,string pSoDienThoaiKH,DateTime pNgaySinhKH,string pNoiSinhKH,string pGioiTinhKH,string pSoCMNDKH,int pDiemTichLuy,string pDiaChiThuongTru,string pEmail)
        {
            HoKH = pHoKH;
            TenKH = pTenKH;
            SoDienThoai = pSoDienThoaiKH;
            NgaySinh = pNgaySinhKH;
            NoiSinh = pNoiSinhKH;
            GioiTinh = pGioiTinhKH;
            SoCMND = pSoCMNDKH;
            DiemTichLuy = pDiemTichLuy;
            DiaChiThuongTru = pDiaChiThuongTru;
            Email = pEmail;
        }
        public DTO_Customer(int pMaKH)
        {
            MaKH = pMaKH;
        }
        
        
        
        
        
    }
}
