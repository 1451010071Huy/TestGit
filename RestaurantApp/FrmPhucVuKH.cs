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
    public partial class FrmPVKH : Form
    {
        private int maban;
        private int khuvuc;
        private int x;
        private string tenmon;
        private double giatien;
        string hinhthucthanhtoan;
        public FrmPVKH()
        {
            InitializeComponent();           
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            FrmLogin FrmLogin = new FrmLogin();
            FrmLogin.ShowDialog();
        }

        private void FrmPhucVuKH_Load(object sender, EventArgs e)
        {
            dgvMenu.DataSource = GetPVKH_GUI();
            dgvMonAnvaBan.DataSource = GetMonAnvaBan_GUI();
        }

        private List<PVKH_DTO> GetPVKH_GUI()
        {
            string sql = "SELECT * FROM MonAn";
            List<PVKH_DTO> list = new PVKH_BUS().GetPVKH_BUS(sql);
            return list;     
        }

        private List<MonAnvaBan_DTO> GetMonAnvaBan_GUI()
        {
            string sql = "SELECT * FROM MonAnvaBan";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }

        private List<MonAnvaBan_DTO> GetMaBan_GUI1(int maban)
        {
            //string sql = "SELECT ChiTietHoaDon.* ,MonAn.TenMonAn FROM ChiTietHoaDon,MonAn Where ChiTietHoaDon.MaMonAn = MonAn.MaMonAn  and  MaBan = N'1001'";
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = " + maban;
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }

        private List<MonAnvaBan_DTO> GetMaBan_GUI2()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'2'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI3()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'3'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI4()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'4'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI5()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'5'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }

        private List<MonAnvaBan_DTO> GetMaBan_GUI21()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'6'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI22()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'7'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI23()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'8'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI24()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'9'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI25()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'10'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }

        private List<MonAnvaBan_DTO> GetMaBan_GUI31()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'11'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI32()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'12'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI33()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'13'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI34()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'14'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUI35()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'15'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUIVIP1()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'16'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUIVIP2()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'17'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUIVIP3()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'18'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUIVIP4()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'19'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private List<MonAnvaBan_DTO> GetMaBan_GUIVIP5()
        {
            string sql = "SELECT * FROM MonAnvaBan WHERE MaBan = N'20'";
            return new MonAnvaBan_BUS().GetMonAnvaBan_BUS(sql);
        }
        private void btHuyMon_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvMonAnvaBan.CurrentRow.Index;
                int maban = Convert.ToInt32(dgvMonAnvaBan.Rows[index].Cells[0].Value.ToString().Trim());
                MonAnvaBan_DTO monan = new MonAnvaBan_DTO(Convert.ToInt32(txtbHuyMonAn.Text));
                MonAnvaBan_BUS ma = new MonAnvaBan_BUS();
                ma.XoaMonAn(monan, maban);

              //  dgvMonAnvaBan.DataSource = GetMonAnvaBan_GUI();
                dgvMonAnvaBan.DataSource = GetMaBan_GUI1(maban);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        private void btInHoaDon_Click(object sender, EventArgs e)
        {
            //FrmInHoaDonPVKH FrmInHoaDon = new FrmInHoaDonPVKH();
            //if (rdbtTienMat.Checked == true)
            //{
            //    MessageBox.Show("Bạn vừa chọn hình thức thanh toán là:" + rdbtTienMat.Text);
            //    //FrmInHoaDon.ShowDialog();
            //    return;
            //}
            //else if (rdbtCard.Checked == true)
            //{
            //    MessageBox.Show("Bạn vừa chọn hình thức thanh toán là:" + rdbtCard.Text);
            //    FrmInHoaDon.ShowDialog();
            //    return;
            //}   
            //else
            //{
            //    MessageBox.Show("Bạn chưa chọn hình thức thanh toán!");
            //}
            
        }
        private void btHuy_Click(object sender, EventArgs e)
        {
            
            txtbKhuVuc.Text = "";
            txtbBan.Text = "";
            rdbtCard.Checked = false;
            rdbtTienMat.Checked = false;
        }  

        private void khuvuc1()
        {
            khuvuc = 1;
        }

        private void bt1Ban1_Click(object sender, EventArgs e)
        {
            //int index = dgvMenu.CurrentCell.RowIndex;
            //int maban = Convert.ToInt32(dgvMonAnvaBan.Rows[index].Cells[0].Value.ToString().Trim());
            txtbBan.Text = bt1Ban1.Text;
            txtbKhuVuc.Text = tabPage1.Text;
            maban = 1;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI1(maban);
            khuvuc1();
        }

        private void bt1Ban2_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt1Ban2.Text;
            txtbKhuVuc.Text = tabPage1.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI2();
            maban = 2;
            khuvuc1();
        }

        private void bt1Ban3_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt1Ban3.Text;
            txtbKhuVuc.Text = tabPage1.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI3();
            maban = 3;
            khuvuc1();
        }

        private void bt1Ban4_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt1Ban4.Text;
            txtbKhuVuc.Text = tabPage1.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI4();
            maban = 4;
            khuvuc1();
        }

        private void bt1Ban5_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt1Ban5.Text;
            txtbKhuVuc.Text = tabPage1.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI5();
            maban = 5;
            khuvuc1();
        }

        private void bt2Ban1_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt2Ban1.Text;
            txtbKhuVuc.Text = tabPage2.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI21();
            maban = 6;
        }

        private void bt2Ban2_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt2Ban2.Text;
            txtbKhuVuc.Text = tabPage2.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI22();
            maban = 7;
        }

        private void bt2Ban3_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt2Ban3.Text;
            txtbKhuVuc.Text = tabPage2.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI23();
            maban = 8;
        }

        private void bt2Ban4_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt2Ban4.Text;
            txtbKhuVuc.Text = tabPage2.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI24();
            maban = 9;
        }

        private void bt2Ban5_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt2Ban5.Text;
            txtbKhuVuc.Text = tabPage2.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI25();
            maban = 10;
        }      

        private void bt3Ban1_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt3Ban1.Text;
            txtbKhuVuc.Text = tabPage5.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI31();
            maban = 11;
        }

        private void bt3Ban2_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt3Ban2.Text;
            txtbKhuVuc.Text = tabPage5.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI32();
            maban = 12;
        }

        private void bt3Ban3_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt3Ban3.Text;
            txtbKhuVuc.Text = tabPage5.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI33();
            maban = 13;
        }

        private void bt3Ban4_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt3Ban4.Text;
            txtbKhuVuc.Text = tabPage5.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI34();
            maban = 14;
        }

        private void bt3Ban5_Click(object sender, EventArgs e)
        {
            txtbBan.Text = bt3Ban5.Text;
            txtbKhuVuc.Text = tabPage5.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUI35();
            maban = 15;
        }    

        private void btVIPBan1_Click(object sender, EventArgs e)
        {
            txtbBan.Text = btVIPBan1.Text;
            txtbKhuVuc.Text = tabPage7.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUIVIP1();
            maban = 16;
        }

        private void btVIPBan2_Click(object sender, EventArgs e)
        {
            txtbBan.Text = btVIPBan2.Text;
            txtbKhuVuc.Text = tabPage7.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUIVIP2();
            maban = 17;
        }

        private void btVIPBan3_Click(object sender, EventArgs e)
        {
            txtbBan.Text = btVIPBan3.Text;
            txtbKhuVuc.Text = tabPage7.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUIVIP3();
            maban = 18;
        }

        private void btVIPBan4_Click(object sender, EventArgs e)
        {
            txtbBan.Text = btVIPBan4.Text;
            txtbKhuVuc.Text = tabPage7.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUIVIP4();
             maban = 19;
        }

        private void btVIPBan5_Click(object sender, EventArgs e)
        {
            txtbBan.Text = btVIPBan5.Text;
            txtbKhuVuc.Text = tabPage7.Text;
            dgvMonAnvaBan.DataSource = GetMaBan_GUIVIP5();
             maban = 20;
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
                int index = dgvMenu.CurrentCell.RowIndex;
                x = Convert.ToInt32(dgvMenu.Rows[index].Cells[0].Value.ToString().Trim()); // Ma4 mon1 an
                
                
                tenmon = dgvMenu.Rows[index].Cells[1].Value.ToString().Trim();
                MessageBox.Show(tenmon);
                //int name = Convert.ToInt32(tenmon);
                //giatien = Convert.ToDouble(dgvMenu.Rows[index].Cells[3].Value.ToString().Trim());
                BUS.MonAnvaBan_BUS AddMonAn = new MonAnvaBan_BUS();
                //int maban = Convert.ToInt32(dgvMonAnvaBan.Rows[index].Cells[0].Value.ToString().Trim());
                DateTime realtime = System.DateTime.Now;
                AddMonAn.Add_Monan(maban, x, realtime);

                DataTable dt = new DataTable();
                MonAnvaBan_BUS mon = new MonAnvaBan_BUS();
                string sql = "select * from MonAnVaBan where MaBan = " + maban;
                dt = mon.GetTheoSoBan(sql);
                dgvMonAnvaBan.DataSource = dt;
              //  MessageBox.Show(x.ToString() + tenmon + giatien.ToString());
               // dgvMonAnvaBan.DataSource = GetMaBan_GUI3();
            //}
            //catch
            //{
            //    MessageBox.Show("Loi");
            //}
        }

        private void dgvMonAnvaBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvMonAnvaBan.CurrentCell.RowIndex;
            txtbHuyMonAn.Text = dgvMonAnvaBan.Rows[index].Cells[1].Value.ToString().Trim();
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            //FrmInHoaDonPVKH FrmInHoaDon = new FrmInHoaDonPVKH();
            
                    if (rdbtCard.Checked != false || rdbtTienMat.Checked != false)
                    {
                        try
                        {
                            if (rdbtTienMat.Checked)
                            {
                                hinhthucthanhtoan = "Tiền mặt";
                            }
                            if (rdbtCard.Checked)
                            {
                                hinhthucthanhtoan = "Master Card";
                            }
                            BUS.MonAnvaBan_BUS LuuThongTinHoaDon = new MonAnvaBan_BUS();
                            LuuThongTinHoaDon.Add_ThongTinHoaDon( txtbKhuVuc.Text, maban, hinhthucthanhtoan);
                            MessageBox.Show("Thêm thành công");
                        }
                        catch
                        {
                            MessageBox.Show("Loi");
                        }                
                   }            
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn hình thức thanh toán!");
                    }         
        }    
    }
}

