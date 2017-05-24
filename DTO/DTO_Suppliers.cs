using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Suppliers
    {
        public DTO_Suppliers()
        {

        }
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public string SupplierPhone { get; set; }
        
       
        public DTO_Suppliers(string supName, string supAddress, string supPhone)
        {
          
            SupplierName = supName;
            SupplierPhone = supPhone;
            SupplierAddress = supAddress;
        }
    }
}
