using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BUS;
using DTO;
using System.Data.SqlClient;

namespace RestaurantApp
{
    public partial class FrmBusinessReport : Form
    {
        SqlCommand cmd;
        public FrmBusinessReport()
        {
            InitializeComponent();
        }

        private void FrmBusinessReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNhaHangDataSet1.HoaDon' table. You can move, or remove it, as needed.

            GetReportAll();
            ReportDataSource rds = new ReportDataSource("DataSet1", GetReportAll().Tables[0]);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
            reportViewer1.LocalReport.ReportPath = @"ReportIncome.rdlc";
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();




        
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.LocalReport.ReportPath = @"ReportIncome.rdlc";
            this.reportViewer2.LocalReport.Refresh();
            this.reportViewer2.RefreshReport();

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private DataSet GetReport()
        {
            cmd = new SqlCommand(" Select ChiTietHoaDon.*,(SoLuong*GiaTien) As Tong  from ChiTietHoaDon   Where CAST(ThoiGian AS DATE)=@ThoiGian");
            cmd.Parameters.AddWithValue("@ThoiGian", Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()));
            return new BUS_Storage().LoadReport(cmd);
        }
        private DataSet GetMonthlyReport()
        {
            cmd = new SqlCommand(" select * from ChiTietHoaDon where DATEPART(month,ThoiGian)=@ThoiGian");
            cmd.Parameters.AddWithValue("@ThoiGian", comboBox1.Text);
            return new BUS_Storage().LoadReport(cmd);
        }
         private DataSet GetReportAll()
        {
            cmd = new SqlCommand(" Select ChiTietHoaDon.* from ChiTietHoaDon   ");
            return new BUS_Storage().LoadReport(cmd);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GetReport();
            ReportDataSource rds =new ReportDataSource("DataSet1",GetReport().Tables[0]);
           
          
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rds);
         
     
            reportViewer1.LocalReport.ReportPath = @"ReportIncome.rdlc";
            this.reportViewer1.RefreshReport();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    GetReportCustomer();
        //    ReportDataSource rds = new ReportDataSource("DataSet1", GetReportCustomer().Tables[0]);
        //    reportViewer2.LocalReport.DataSources.Clear();
        //    reportViewer2.LocalReport.DataSources.Add(rds);

        //    reportViewer2.LocalReport.ReportPath = @"ReportCustomer.rdlc";
        //    this.reportViewer2.RefreshReport();
        //}

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            GetMonthlyReport();
            ReportDataSource rds = new ReportDataSource("DataSet1", GetMonthlyReport().Tables[0]);
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.LocalReport.ReportPath = @"ReportIncome.rdlc";
            reportViewer2.LocalReport.Refresh();
            reportViewer2.RefreshReport();

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
