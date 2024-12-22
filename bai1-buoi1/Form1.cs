using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai1_buoi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            if (!char.IsDigit(control.Text[control.Text.Length - 1]))
                this.err.SetError(control, "This is now valid Numner");
            else
                this.err.Clear();
        }

        private void btnadd1_Click(object sender, EventArgs e)
        {
            try
            {
                int sum;
                sum = int.Parse(txtNum1.Text.ToString()) + int.Parse(txtNum2.Text.ToString());

                txtKQ.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("chua nhap so");               
            }
            

          
           

 
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            try
            {
                int sum;
                sum = int.Parse(txtNum1.Text.ToString()) - int.Parse(txtNum2.Text.ToString());

                txtKQ.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("chua nhap so");
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            try
            {
                int sum;
                sum = int.Parse(txtNum1.Text.ToString()) * int.Parse(txtNum2.Text.ToString());

                txtKQ.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("chua nhap so");
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            try
            {
                int sum;
                sum = int.Parse(txtNum1.Text.ToString()) / int.Parse(txtNum2.Text.ToString());

                txtKQ.Text = sum.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("chua nhap so");
            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
