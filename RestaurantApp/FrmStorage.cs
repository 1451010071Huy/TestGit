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
using BUS;
using DTO;

namespace RestaurantApp
{
    public partial class mID : Form
    {
        BUS_Storage busStore = new BUS_Storage();
        public mID()
        {
            InitializeComponent();
        }
        public DataSet LoadSupplier()
        {
            return busStore.LoadSupplier();
        }

        private void FrmStorage_Load(object sender, EventArgs e)
        {
            
            comboBox1.DataSource = LoadSupplier().Tables[0];
            comboBox1.DisplayMember = "MaNhaCungCap";
            comboBox1.ValueMember = "MaNhaCungCap";
      
            dataGridView1.DataSource = LoadStorage().Tables[0];

        }
        public DataSet LoadStorage()
        {
            return new BUS_Storage().LoadStorage();
           
        }
      
      
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Storage newstore = new DTO_Storage(txtmName.Text, Convert.ToDateTime(dateTimePicker1.Text), Convert.ToInt32(txtboxExDay.Text), Convert.ToInt32(comboBox1.Text), txtboxUnit.Text, Convert.ToInt32(txtboxUnitInStore.Text));
                busStore.InsertStorage(newstore);
                dataGridView1.DataSource = busStore.LoadStorage().Tables[0];
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

   

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Storage newstore = new DTO_Storage()
                {
                    MaNL = Convert.ToInt32(txtID.Text),
                    TenNL = txtmName.Text,
                    DateIn = Convert.ToDateTime(dateTimePicker1.Text),
                    ExpirationDay = Convert.ToInt32(txtboxExDay.Text),
                    DonViTinh = txtboxUnit.Text,
                    MaNhaCungCap = Convert.ToInt32(comboBox1.Text),
                    SoLuongTonKho = Convert.ToInt32(txtboxUnitInStore.Text)
                };
                busStore.UpdateStorage(newstore);
                dataGridView1.DataSource = busStore.LoadStorage().Tables[0];
            }
            catch (FormatException )
            {
         
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK);
            
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DTO_Storage newstore = new DTO_Storage()
                {
                    MaNL = Convert.ToInt32(txtID.Text)
                };
                busStore.Delete(newstore);
                dataGridView1.DataSource = LoadStorage().Tables[0];
            }
            catch (FormatException)
            {
                
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin", "Lỗi", MessageBoxButtons.OK);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
    
      

        private void button3_Click(object sender, EventArgs e)
        {
            SearchBySupplier frm = new SearchBySupplier();
            frm.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Supplier frm = new Supplier();
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtID.Text = row.Cells[0].Value.ToString();
                txtmName.Text = row.Cells[1].Value.ToString();
                dateTimePicker1.Text = row.Cells[2].Value.ToString();
                txtboxExDay.Text = row.Cells[3].Value.ToString();
                comboBox1.Text = row.Cells[4].Value.ToString();
                txtboxUnitInStore.Text = row.Cells[5].Value.ToString();
                txtboxUnit.Text = row.Cells[6].Value.ToString();
            }
          
        }



    }
}
