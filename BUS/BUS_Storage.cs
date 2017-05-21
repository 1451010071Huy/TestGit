using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;
using System.Data.SqlClient;
namespace BUS
{
   public class BUS_Storage
    {
       SqlCommand cmd = new SqlCommand();
       DAO_Storage storage = new DAO_Storage();
       public DataSet LoadStorage()
       {
           string sql = "Select * From NguyenLieu";
           
         return   storage.LoadData(sql);
            
       }
       public DataSet LoadReport(SqlCommand cmd)
       {
           
           return storage.LoadReport(cmd);
       }
     
       public DataSet LoadSupplier()
       {
           string sql = "Select * from NhaCungCap";
          return storage.LoadData(sql);
       }
 
       public DataSet Search2(SqlCommand cmd)
       {

           DAO_Storage store = new DAO_Storage();
           return store.LoadData2(cmd);

       }

       public void InsertStorage(DTO_Storage store)
       {
           string sql = "Insert into NguyenLieu(TenNL,NgayNhap,HanSuDung,MaNhaCungCap,SoLuongTonKho,DonViTinh) Values(@mName,@Date,@Ex,@supID,@numInStore,@unit)";
           cmd.Parameters.Add("@mName",store.TenNL);
           cmd.Parameters.Add("@Date",store.DateIn);
           cmd.Parameters.Add("@Ex",store.ExpirationDay);
           cmd.Parameters.Add("@supID",store.MaNhaCungCap);
           cmd.Parameters.Add("@numInStore",store.SoLuongTonKho);
           cmd.Parameters.Add("@unit",store.DonViTinh);
           storage.Execute(cmd,sql);
       }
       public void InsertSupplier(DTO_Suppliers sup)
       {
           string sql = "Insert into NhaCungCap(TenNhaCungCap,DiaChi,SoDienThoai) values(@supName,@supAddress,@supPhone)";
           cmd.Parameters.AddWithValue("@supName", sup.SupplierName);
           cmd.Parameters.AddWithValue("@supAddress", sup.SupplierAddress);
           cmd.Parameters.AddWithValue("@supPhone", sup.SupplierPhone);
           storage.Execute(cmd, sql);
       }
       public void UpdateStorage(DTO_Storage store)
       {
           string sql = "Update NguyenLieu set TenNL=@mName,NgayNhap=@Date,HanSuDung=@Ex,MaNhaCungCap=@supID,SoLuongTonKho=@numInStore,DonViTinh=@unit where MaNguyenLieu = @mID";
           cmd.Parameters.Add("@mID", store.MaNL);
           cmd.Parameters.Add("@mName", store.TenNL);
           cmd.Parameters.Add("@Date", store.DateIn);
           cmd.Parameters.Add("@Ex", store.ExpirationDay);
           cmd.Parameters.Add("@supID", store.MaNhaCungCap);
           cmd.Parameters.Add("@numInStore", store.SoLuongTonKho);
           cmd.Parameters.Add("@unit", store.DonViTinh);
           storage.Execute(cmd, sql);
       }
       public void UpdateSupplier(DTO_Suppliers sup)
       {
           string sql = " Update NhaCungCap set TenNhaCungCap =@supName,DiaChi=@supAddress,SoDienThoai=@supPhone where MaNhaCungCap=@supID";
           cmd.Parameters.AddWithValue("@supName", sup.SupplierName);
           cmd.Parameters.AddWithValue("@supAddress", sup.SupplierAddress);
           cmd.Parameters.AddWithValue("@supPhone", sup.SupplierPhone);
           cmd.Parameters.AddWithValue("@supID", sup.SupplierID);
           storage.Execute(cmd,sql);
       }
       public void Delete(DTO_Storage store)
       {
           string sql = "Delete from NguyenLieu where MaNguyenLieu=@mID";
           cmd.Parameters.Add("@mID", store.MaNL);
           storage.Execute(cmd, sql);
       }
       public void DeleteSupplier(DTO_Suppliers store)
       {
           string sql = "Delete from NhaCungCap where MaNhaCungCap=@supID";
           cmd.Parameters.Add("@supID", store.SupplierID);
           storage.Execute(cmd, sql);
       }
    }
}
