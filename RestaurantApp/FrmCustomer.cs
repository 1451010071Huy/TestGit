using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using DTO;
using System.Data.SqlClient;
namespace RestaurantApp
{
    public partial class FrmCustomer : Form
    {
        public FrmCustomer()
        {
            InitializeComponent();
        }
        private List<DTO_Customer> GetCustomer()
        {
            try
            {
                return new BUS_Customer().GetCustomer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }

        private void FrmCustomer_Load(object sender, EventArgs e)
        {
            dgvDanhSáchKháchHàng.DataSource = GetCustomer();
        }

        private void btnThêm_Click(object sender, EventArgs e)
        {
            int pDiemTichLuy;
            string pHoKH, pTenKH, pSoDienThoaiKH, pNoiSinhKH, pGioiTinhKH, pSoCMNDKH, pDiaChiThuongTru, pEmail;
            DateTime pNgaySinh;

            pHoKH = txtHọKH.Text.Trim();
            pTenKH = txtTênKH.Text.Trim();
            pSoDienThoaiKH = txtSoDienThoai.Text.Trim();
            pNgaySinh = Convert.ToDateTime(dtpNgaySinhKH.Text.ToString());
            pNoiSinhKH = txtNoiSinh.Text.Trim();
            pGioiTinhKH = txtGioiTinh.Text.Trim();
            pSoCMNDKH = txtSoCMND.Text.Trim();
            pDiemTichLuy = Convert.ToInt32(txtDiemTichLuy.Text);
            pDiaChiThuongTru = txtDiaChiThuongTru.Text.Trim();
            pEmail = txtEmail.Text.Trim();

            DTO_Customer emp = new DTO_Customer (pHoKH, pTenKH, pSoDienThoaiKH, pNgaySinh, pNoiSinhKH, pGioiTinhKH, pSoCMNDKH, pDiemTichLuy, pDiaChiThuongTru, pEmail);
            try 
	        {	        
		        int i =  new BUS_Customer().AddCustomer(emp);
                if(i == -2)
                    throw new Exception();
                MessageBox.Show("Đã thêm thành công", "Xác nhận");
	        }
	        catch (SqlException ex)
	        {
		        MessageBox.Show(ex.Message);
	        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvDanhSáchKháchHàng.DataSource = GetCustomer();

        }

        private void btnXoá_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xoá thật không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
            BUS_Customer dl = new BUS_Customer();
            DTO_Customer dt = new DTO_Customer(Convert.ToInt32(txtMãKH.Text));
            dl.DeleteCustomer(dt);
            dgvDanhSáchKháchHàng.DataSource = GetCustomer();
            }

        }

        private void btnSửa_Click(object sender, EventArgs e)
        {
            int pMaKH, pDiemTichLuy;
            string pHoKH, pTenKH, pSoDienThoaiKH, pNoiSinhKH, pGioiTinhKH, pSoCMNDKH, pDiaChiThuongTru, pEmail;
            DateTime pNgaySinh;

            pMaKH = int.Parse(txtMãKH.Text.Trim());
            pHoKH = txtHọKH.Text.Trim();
            pTenKH = txtTênKH.Text.Trim();
            pSoDienThoaiKH = txtSoDienThoai.Text.Trim();
            pNgaySinh = Convert.ToDateTime(dtpNgaySinhKH.Text.ToString());
            pNoiSinhKH = txtNoiSinh.Text.Trim();
            pGioiTinhKH = txtGioiTinh.Text.Trim();
            pSoCMNDKH = txtSoCMND.Text.Trim();
            pDiemTichLuy = Convert.ToInt32(txtDiemTichLuy.Text);
            pDiaChiThuongTru = txtDiaChiThuongTru.Text.Trim();
            pEmail = txtEmail.Text.Trim();

            DTO_Customer emp = new DTO_Customer (pMaKH, pHoKH, pTenKH, pSoDienThoaiKH, pNgaySinh, pNoiSinhKH, pGioiTinhKH, pSoCMNDKH, pDiemTichLuy, pDiaChiThuongTru, pEmail);
            try 
	        {	        
		        int i =  new BUS_Customer().UpdateCustomer(emp);
                if(i == -2)
                    throw new Exception();
                MessageBox.Show("Đã sửa thành công", "Xác nhận");
	        }
	        catch (SqlException ex)
	        {
		        MessageBox.Show(ex.Message);
	        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            dgvDanhSáchKháchHàng.DataSource = GetCustomer();
        }

        private void FrmCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có muốn thoát thật sao :( ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.Cancel)
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void btnThoát_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát khônng ?", "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMãKH.Clear();
            txtHọKH.Clear();
            txtTênKH.Clear();
            txtGioiTinh.Clear();
            dtpNgaySinhKH.ResetText();
            txtNoiSinh.Clear();
            txtSoCMND.Clear();
            txtDiemTichLuy.Clear();
            txtSoDienThoai.Clear();
            txtDiaChiThuongTru.Clear();
            txtEmail.Clear();
        }

        private void dgvDanhSáchKháchHàng_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = this.dgvDanhSáchKháchHàng.Rows[e.RowIndex];
            txtMãKH.Text = row.Cells[0].Value.ToString();
            txtHọKH.Text = row.Cells[1].Value.ToString();
            txtTênKH.Text = row.Cells[2].Value.ToString();
            txtSoDienThoai.Text = row.Cells[3].Value.ToString();
            dtpNgaySinhKH.Text = row.Cells[4].Value.ToString();
            txtNoiSinh.Text = row.Cells[5].Value.ToString();
            txtGioiTinh.Text = row.Cells[6].Value.ToString();
            txtSoCMND.Text = row.Cells[7].Value.ToString();
            txtDiemTichLuy.Text = row.Cells[8].Value.ToString();
            txtDiaChiThuongTru.Text = row.Cells[9].Value.ToString();
            txtEmail.Text = row.Cells[10].Value.ToString();
        }

        

     

    }
}
