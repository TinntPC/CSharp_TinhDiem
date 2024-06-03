using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TinhDiem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void txtTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTTBinh_Click(object sender, EventArgs e)
        {
            if (txtToan.Text == "" || txtVan.Text == "")
            {
                MessageBox.Show("Phải nhập tên, toán, văn");
                return;
            }
            Double toan, van, TB,XL ;
            toan=Convert.ToDouble(txtToan.Text);
            van = Convert.ToDouble(txtVan.Text);
            TB = (toan + van) / 2 ; 
            txtTB.Text=TB.ToString();
            if (TB < 5)
            {
                txtXepLoai.Text = "yếu";
            }else if ( TB < 6)
            {
                txtXepLoai.Text = "Trung bình";
            }else if ( TB <8)
            {
                txtXepLoai.Text = "Khá";
            }
            else
            {
                txtXepLoai.Text = "Giỏi";
            }
        }

        private void txtXepLoai_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label6_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}
