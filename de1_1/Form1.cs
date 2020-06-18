using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace de1_1
{
    public partial class Form1 : Form
    {
        process pr = new process();
        public Form1()
        {
            
            InitializeComponent();
            pr.show(dataGV);
        }
        


        private void add_Click(object sender, EventArgs e)
        {
            khachhang kh=new khachhang();
            kh.chinhanh = chinhanhtxt.Text;
            kh.makh = makhtxt.Text;
            kh.hoten = nametxt.Text;
            kh.sdt = sdttxt.Text;
            kh.diachi = diachitxt.Text;
            pr.add(kh);
            pr.show(dataGV);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void change_Click(object sender, EventArgs e)
        {
            khachhang kh = new khachhang();
            kh.chinhanh = chinhanhtxt.Text;
            kh.makh = makhtxt.Text;
            kh.hoten = nametxt.Text;
            kh.sdt = sdttxt.Text;
            kh.diachi = diachitxt.Text;
            pr.change(kh);
            pr.show(dataGV);
        }

        private void cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGV.SelectedCells[0].RowIndex;
            DataGridViewRow row = dataGV.Rows[index];
            makhtxt.Text = Convert.ToString(row.Cells["chinhanh"].Value);
            chinhanhtxt.Text = Convert.ToString(row.Cells["makh"].Value);
            nametxt.Text = Convert.ToString(row.Cells["hoten"].Value);
            diachitxt.Text = Convert.ToString(row.Cells["diachi"].Value);
            sdttxt.Text = Convert.ToString(row.Cells["sdt"].Value);
            //chinhanhtxt.Text = Convert.ToString(row.Cells["makh"].Value);
        }

        private void delete_Click(object sender, EventArgs e)
        {
            khachhang kh = new khachhang();
            kh.makh = makhtxt.Text;
            pr.deletekh(kh);
            pr.show(dataGV);
        }
    }
}
