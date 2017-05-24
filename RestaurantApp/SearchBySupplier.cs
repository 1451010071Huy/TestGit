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
    public partial class SearchBySupplier : Form
    {
        
        BUS_Storage busStore = new BUS_Storage();
        SqlCommand cmd =new SqlCommand();
        mID frm = new mID();
        public SearchBySupplier()
        {
            InitializeComponent();
        }
     
        public DataSet Search2()
        {
            cmd = new SqlCommand("Select NguyenLieu.* , NhaCungCap.TenNhaCungCap from NguyenLieu , NhaCungCap where NguyenLieu.MaNhaCungCap=NhaCungCap.MaNhaCungCap and TenNhaCungCap= @sName");
            cmd.Parameters.AddWithValue("@sName", comboBox1.Text);
            return busStore.Search2(cmd);
           
        }
        public DataSet LoadSupplier()
        {
            return busStore.LoadSupplier();
        }
        private void SearchBySupplier_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = LoadSupplier().Tables[0];
            comboBox1.DisplayMember = "TenNhaCungCap";
            comboBox1.ValueMember = "MaNhaCungCap";
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Search2().Tables[0];
            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }
    }
}
