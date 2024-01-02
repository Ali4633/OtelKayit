using OtelKayit.Business.Abstract;
using OtelKayit.Business.Concrete;
using OtelKayit.DataAccess.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelKayit.WebFormsUI
{
    public partial class Form1 : Form
    {
        public string admin;
        public string password;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadCustomer()
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        Form2 frm2 = new Form2();
        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (admin=="admin" && password == "123") 
            {
                this.Hide();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("yanlış şifre veya ad");
            }


        }

        private void txtAdmin_TextChanged(object sender, EventArgs e)
        {
            admin = txtAdmin.Text;
        }

        private void txtSifre_TextChanged(object sender, EventArgs e)
        {
            password = txtSifre.Text;
        }
    }
}
