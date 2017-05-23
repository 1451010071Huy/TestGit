using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomMsBox;
using System.Data.SqlClient;
using BUS;
using DTO;

#pragma warning disable 414, 3021
namespace RestaurantApp
{
    public partial class FrmQuanLyThucDon : Form
    {
        BUS_DanhMuc Dm = new BUS_DanhMuc();
        BUS_MonAn Ma = new BUS_MonAn();
        BUS_ChiTietMonAn Ct = new BUS_ChiTietMonAn();
        BUS_NguyenLieu Nl = new BUS_NguyenLieu();

        public FrmQuanLyThucDon()
        {
            MaximizeBox = false;
            InitializeComponent();
        }

        private void FrmQuanLyThucDon_Load(object sender, EventArgs e)
        {
            btnXoaNhom.Enabled = false;//an button
            btnSuaNhom.Enabled = false;

            btnSuaMon.Enabled = false;
            btnXoaMon.Enabled = false;

            btnXoaCongThuc.Enabled = false;

            lblMaMonAn.Enabled = false;
            lblMaNguyenLieu.Enabled = false;

            getDanhMuc();
            getMonAn();
            getChiTietMonAn();
            getCombobox();
            this.dgvCongThuc.ClearSelection();//ClearSelection() : Xoa focus khi hien datagridview
            this.dgvDanhMuc.ClearSelection();
            this.dgvMonAn.ClearSelection();
        }
        private void getDanhMuc() //Ham nay de hien thi bang len datagrid view
        {
            DataSet ds = Dm.getDanhMuc();
            dgvDanhMuc.DataSource = ds.Tables[0];// bang ao nay duoc do vao dgvDanhMuc
        }
        private void getMonAn()
        {
            DataSet ds = Ma.getMonAn();
            dgvMonAn.DataSource = ds.Tables[0];// bang ao nay duoc do vao dgvMonAn
            dgvMonAn.Columns[2].DefaultCellStyle.Format = "#,0.# VNÐ";// dinh dang lai tien hien thi tren gridviewMonAn
        }
        private void getChiTietMonAn()
        {

            DataSet ds = Ct.getChiTietMonAn();
            dgvCongThuc.DataSource = ds.Tables[0];

            dgvCongThuc.Columns[3].Visible = false;//ẩn cột MaMonAn
            dgvCongThuc.Columns[4].Visible = false;//ẩn cột MaNguyenLieu
        }
        private void getCombobox()
        {
            //combobox mon an
            DataSet ds = Ma.getMonAn();
            cbbTenMonAn.DataSource = ds.Tables[0];
            cbbTenMonAn.DisplayMember = "TenMonAn";
            cbbTenMonAn.ValueMember = "MaMonAn";
            ds = null;
            //combobox nguyen lieu
            ds = Nl.getNguyenLieu();
            cbbTenNguyenLieu.DataSource = ds.Tables[0];
            cbbTenNguyenLieu.DisplayMember = "TenNL";
            cbbTenNguyenLieu.ValueMember = "MaNguyenLieu";
        }
        private void btnThemNhom_Click(object sender, EventArgs e)
        {

            try
            {
                DTO_DanhMuc dm = new DTO_DanhMuc(txtTenDanhMuc.Text, txtMoTa.Text);
                if (Dm.ThemDanhMuc(dm) == 1)
                {
                    getDanhMuc();

                    MsgBox.Show("Thêm danh mục [" + txtTenDanhMuc.Text + "] thành công!", "Thông báo", MsgBox.Buttons.OK);
                }
                else
                {
                    MsgBox.Show("Tên danh mục không được để trống!Thêm không thành công!","Thông báo",MsgBox.Buttons.OK);
                }

            }
            catch (SqlException ex)
            {
                MsgBox.Show(ex.Message);
            }
        }
        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            try
            {
                if (MsgBox.Show("Bạn có chăc chắn xóa món này không!", "Thông báo", MsgBox.Buttons.YesNo, MsgBox.Icon.Question) == DialogResult.Yes)
                {
                    BUS_DanhMuc busDanhMuc = new BUS_DanhMuc();
                    DTO_DanhMuc dm = new DTO_DanhMuc(int.Parse(txtMaDanhMuc.Text));
                    busDanhMuc.XoaDanhMuc(dm);
                    getDanhMuc();//refresh lai bang danh muc       
                    if (txtTenDanhMuc.Text == txtTenDanhMuc.Text)
                        MsgBox.Show("Xóa danh mục [" + txtTenDanhMuc.Text + "] " + "thành công!", "Thông báo", MsgBox.Buttons.OK);
                }
            }
            catch (SqlException)
            {
                MsgBox.Show("Danh mục đang được sử dụng, Xóa danh mục không thành công!", "Thông báo", MsgBox.Buttons.OK);
            }
        }
        private void btnSuaNhom_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDanhMuc.Text != "")
                {
                    DTO_DanhMuc dm = new DTO_DanhMuc(int.Parse(txtMaDanhMuc.Text), txtTenDanhMuc.Text, txtMoTa.Text);
                    Dm.SuaDanhMuc(dm);
                    getDanhMuc();//refresh lai Danh Muc
                    MsgBox.Show("Sửa danh mục [" + txtMaDanhMuc.Text + "] thành công!", "Thông báo", MsgBox.Buttons.OK);
                }
                else
                {
                    MsgBox.Show("Bạn chưa chọn hàng danh mục để sửa!", "Thông báo", MsgBox.Buttons.OK);
                }
            }

            catch (SqlException ex)
            {

                throw ex;
            }
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaDanhMuc.Text != "")
                {
                    if (txtTenMonAn.Text == "" || txtGiaTien.Text == "" || txtDonViTinhtd.Text == "")
                    {
                        MsgBox.Show("Phải nhập đủ tên món ăn, giá và đơn vị tính!", "Thông báo", MsgBox.Buttons.OK);
                    }
                    else if (txtTenMonAn.Text != "" && txtGiaTien.Text != "" && txtDonViTinhtd.Text != "")
                    {
                        DTO_MonAn ma = new DTO_MonAn(txtTenMonAn.Text, int.Parse(txtGiaTien.Text), int.Parse(txtMaDanhMuc.Text), txtDonViTinhtd.Text);
                        BUS_MonAn busMonAn = new BUS_MonAn();
                        busMonAn.ThemMonAn(ma);
                        getMonAn();
                        MsgBox.Show("Thêm món [" + txtTenMonAn.Text + "] thành công!", "Thông báo", MsgBox.Buttons.OK);
                    }
                    getCombobox();//load lai combobox MonAn
                }
                else
                {
                    MsgBox.Show("Bạn phải xếp món ăn vào 1 danh mục có sẵn!", "Thông báo", MsgBox.Buttons.OK);
                }
            }
            catch (SqlException ex)
            {
                MsgBox.Show(ex.Message);
            }
        }
        private void btnSuaMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMonAn.Text != "")
                {
                    BUS_MonAn ma = new BUS_MonAn();
                    DTO_MonAn dm = new DTO_MonAn(int.Parse(txtMaMonAn.Text), txtTenMonAn.Text, int.Parse(txtGiaTien.Text), int.Parse(txtMaDanhMuc.Text), txtDonViTinhtd.Text);
                    ma.SuaMonAn(dm);
                    getMonAn();//refresh lai Danh Muc
                    MsgBox.Show("Sửa món [" + txtMaMonAn.Text + "] thành công!", "Thông báo",MsgBox.Buttons.OK);
                }
                else
                {
                    MsgBox.Show("Bạn chưa chọn hàng món ăn để sửa!", "Thông báo", MsgBox.Buttons.OK);
                }

            }
            catch (SqlException ex)
            {

                MsgBox.Show(ex.Message);
            }
        }
        private void btnXoaMon_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaMonAn.Text != "")
                {
                    if (MsgBox.Show("Bạn có chăc chắn xóa món này không!", "Thông báo", MsgBox.Buttons.YesNo, MsgBox.Icon.Question) == DialogResult.Yes)
                    {
                        BUS_MonAn ma = new BUS_MonAn();
                        DTO_MonAn dm = new DTO_MonAn(int.Parse(txtMaMonAn.Text));
                        ma.XoaMonAn(dm);
                        getMonAn();
                        MsgBox.Show("Xóa món [" + txtTenMonAn.Text + "] thành công!", "Thông báo", MsgBox.Buttons.OK);
                    }
                }
            }
            catch (SqlException)
            {
                MsgBox.Show("Món đang được sử dụng, Xóa không thành công!", "Thông báo", MsgBox.Buttons.OK);
            }

        }
        private void btnThemCongThuc_Click(object sender, EventArgs e)
        {
            try
            {
                string maMonAn = cbbTenMonAn.SelectedValue.ToString().Trim();
                string maNguyenLieu = cbbTenNguyenLieu.SelectedValue.ToString().Trim();
                //lay ma mon an trong bang mon an
                string ghiChu = txtGhiChu.Text;
                DTO_ChiTietMonAn ct = new DTO_ChiTietMonAn(Convert.ToInt32(maMonAn), Convert.ToInt32(maNguyenLieu), ghiChu);
                Ct.ThemCongThuc(ct);
                MsgBox.Show("Thêm nguyên liệu " + cbbTenNguyenLieu.GetItemText(cbbTenNguyenLieu.SelectedItem).Trim() + " vào " + cbbTenMonAn.GetItemText(cbbTenMonAn.SelectedItem).Trim() + " thành công!", "Thông báo", MsgBox.Buttons.OK);

                getChiTietMonAn();
            }

            catch (SqlException)
            {
                MsgBox.Show("Công thức món ăn đã tồn tại!", "Thông báo",MsgBox.Buttons.OK);
            }
            catch (NullReferenceException)// NullReferenceException kiem tra gia tri co bi null hay ko
            {
                MsgBox.Show("Vui lòng chọn tên món ăn và nguyên liệu!", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Question);
            }
        }
        private void btnXoaCongThuc_Click(object sender, EventArgs e)
        {
            try
            {
                string a = dgvCongThuc.Rows[index].Cells[0].Value.ToString().Trim();
                string b = dgvCongThuc.Rows[index].Cells[1].Value.ToString().Trim();

                if (lblMaNguyenLieu.Text != "")
                {
                    if (MsgBox.Show("Bạn có chăc chắn xóa công thức này không!", "Thông báo", MsgBox.Buttons.YesNo, MsgBox.Icon.Question) == DialogResult.Yes)
                    {
                        BUS_ChiTietMonAn chitiet = new BUS_ChiTietMonAn();
                        DTO_ChiTietMonAn dm = new DTO_ChiTietMonAn(int.Parse(lblMaMonAn.Text), int.Parse(lblMaNguyenLieu.Text));
                        chitiet.XoaCongThuc(dm);
                        getChiTietMonAn();
                        MsgBox.Show("Xóa công thức " + a + "[" + b + "] thành công!", "Thông báo", MsgBox.Buttons.OK);
                    }
                }
            }
            catch (SqlException ex)
            {
                MsgBox.Show(ex.Message);
            }
            catch (Exception)
            {
                MsgBox.Show("Không có dữ liệu để xóa!", "Thông báo", MsgBox.Buttons.OK, MsgBox.Icon.Question);
            }
        }
        int index;
        private void dgvDanhMuc_Click(object sender, EventArgs e)
        {
            try
            {
                index = dgvDanhMuc.CurrentRow.Index;
                txtMaDanhMuc.Text = dgvDanhMuc.Rows[index].Cells[0].Value.ToString().Trim();
                txtTenDanhMuc.Text = dgvDanhMuc.Rows[index].Cells[1].Value.ToString().Trim();
                txtMoTa.Text = dgvDanhMuc.Rows[index].Cells[2].Value.ToString().Trim();
                btnXoaNhom.Enabled = true;
                btnSuaNhom.Enabled = true;
                if (txtMaDanhMuc.Text.ToString() == "")
                {
                    btnXoaNhom.Enabled = false;
                    btnSuaNhom.Enabled = false;
                }
            }
            catch (Exception)
            {
                // ko hien thi loi j het khi click vao ngoai vung row
            }
        }
        private void dgvMonAn_Click(object sender, EventArgs e)
        {
            try
            {
                index = dgvMonAn.CurrentRow.Index;
                txtMaMonAn.Text = dgvMonAn.Rows[index].Cells[0].Value.ToString().Trim();
                txtTenMonAn.Text = dgvMonAn.Rows[index].Cells[1].Value.ToString().Trim();
                txtGiaTien.Text = String.Format("{0:0}", dgvMonAn.Rows[index].Cells[2].Value);
                txtDonViTinhtd.Text = dgvMonAn.Rows[index].Cells[3].Value.ToString().Trim();
                txtTenDanhMuc.Text = dgvMonAn.Rows[index].Cells[4].Value.ToString().Trim();
                txtMaDanhMuc.Text = dgvMonAn.Rows[index].Cells[5].Value.ToString().Trim();
                txtMoTa.Text = "";
                btnXoaMon.Enabled = true;
                btnSuaMon.Enabled = true;
                if (txtMaMonAn.Text.ToString() == "")
                {
                    btnXoaMon.Enabled = false;
                    btnSuaMon.Enabled = false;
                }
            }
            catch (Exception)
            {
                // ko hien thi loi j het khi click vao ngoai vung row
            }

        }

        private void dgvCongThuc_Click(object sender, EventArgs e)
        {

            try
            {
                index = dgvCongThuc.CurrentRow.Index;
                if (index == 0)
                {
                    lblMaMonAn.Text = dgvCongThuc.Rows[index].Cells[3].Value.ToString().Trim();
                    lblMaNguyenLieu.Text = dgvCongThuc.Rows[index].Cells[4].Value.ToString().Trim();
                }
                btnXoaCongThuc.Enabled = true;
                if (lblMaNguyenLieu.Text.ToString() == "")
                {
                    btnXoaCongThuc.Enabled = false;
                }
            }
            catch (Exception)
            {
                // ko hien thi loi j het khi click vao ngoai vung row
            }

        }
        //ham nay de rang buot nhap chi nhap so vao o gia tien
        private void txtGiaTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MsgBox.Show("Giá tiền là kí tự số!", "Thông Báo ", MsgBox.Buttons.OK);
            }
        }
    }
}
