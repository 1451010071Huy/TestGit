using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace RestaurantApp
{
    public partial class Supplier : Form
    {
        BUS_Storage busStore = new BUS_Storage();
        public Supplier()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataSet LoadSupplier ()
        {
            return new BUS_Storage().LoadSupplier();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadSupplier().Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Suppliers sup = new DTO_Suppliers( txtsupName.Text, txtsupAddress.Text, txtsupPhone.Text);

                busStore.InsertSupplier(sup);
                dataGridView1.DataSource = busStore.LoadSupplier().Tables[0];
            }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Suppliers newstore = new DTO_Suppliers()
                {
                    SupplierID = Convert.ToInt32(txtsupID.Text)
                };
                busStore.DeleteSupplier(newstore);
                dataGridView1.DataSource = LoadSupplier().Tables[0];
            }
            catch (SqlException )
            {

                MessageBox.Show("Lỗi tồn tại SupplierID ở bản nguyện liệu nên không thể xóa", "Lỗi", MessageBoxButtons.OK);
            }
            catch(FormatException )
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DTO_Suppliers sup = new DTO_Suppliers()
            {
                SupplierID = Convert.ToInt32(txtsupID.Text),
                SupplierName = txtsupName.Text,
                SupplierAddress = txtsupAddress.Text,
                SupplierPhone = txtsupPhone.Text
            };
            busStore.UpdateSupplier(sup);
            dataGridView1.DataSource = LoadSupplier().Tables[0];
        }
    }
}
