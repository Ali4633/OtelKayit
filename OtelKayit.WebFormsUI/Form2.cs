using OtelKayit.Business.Abstract;
using OtelKayit.Business.Concrete;
using OtelKayit.DataAccess.Concrete.EntityFramework;
using OtelKayit.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelKayit.WebFormsUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }
        ICustomerService _customerService = new CustomerManager(new EfCustomerDal());
        private void Form2_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            CheckRoomm();

        }

        private void LoadCustomer()
        {
            dgwCustomers.DataSource = _customerService.GetAll();
        }

        private void tbxCustomerSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tbxCustomerSearch.Text))
                {
                    dgwCustomers.DataSource = _customerService.GetCustomersByCustomerName(tbxCustomerSearch.Text);
                }
                else
                {
                    LoadCustomer();
                }
            }
            catch
            {

               
            }
            
            
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            _customerService.Add(new Customer
            {
                CustomerName = tboxCustomerName.Text,
                CustomerSurname = tboxCustomerSurname.Text,
                CustomerTC = tboxCustomerTc.Text,
                Price = Convert.ToInt16(tboxPrice.Text),
                OdaNo = Convert.ToInt16(tboxOdaNo.Text),
                GirisTarihi = dateTimeGirisTarihi.Value,
                CikisTarihi = dateTimeCikisTarihi.Value
            });
            MessageBox.Show("Müşteri kaydı oluşturuldu");
            LoadCustomer();
            CheckRoomm();
        }

        private void btnCustomerUpdate_Click(object sender, EventArgs e)
        {
            _customerService.Update(new Customer
            {
                CustomerId = Convert.ToInt32(dgwCustomers.CurrentRow.Cells[0].Value),
                CustomerName = tboxCustomerName.Text,
                CustomerSurname = tboxCustomerSurname.Text,
                CustomerTC = tboxCustomerTc.Text,
                Price = Convert.ToInt16(tboxPrice.Text),
                OdaNo = Convert.ToInt16(tboxOdaNo.Text),
                GirisTarihi = dateTimeGirisTarihi.Value,
                CikisTarihi = dateTimeCikisTarihi.Value

            });
            MessageBox.Show("Müşteri kaydı Güncellendi !!");
            LoadCustomer();
            CheckRoomm();
        }

        private void dgwCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgwCustomers.CurrentRow;
            tboxCustomerName.Text = row.Cells[1].Value.ToString();
            tboxCustomerSurname.Text = row.Cells[2].Value.ToString();
            tboxCustomerTc.Text = row.Cells[3].Value.ToString();
            tboxPrice.Text = row.Cells[4].Value.ToString();
            tboxOdaNo.Text = row.Cells[5].Value.ToString();
            dateTimeGirisTarihi.Value = (DateTime)row.Cells[6].Value;
            dateTimeCikisTarihi.Value = (DateTime)row.Cells[7].Value;
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            if(dgwCustomers.CurrentRow != null)
            {
                try
                {
                    _customerService.Delete(new Customer
                    {
                        CustomerId = Convert.ToInt32(dgwCustomers.CurrentRow.Cells[0].Value)
                    });
                    MessageBox.Show("Müşteri kaydı Silindi !!!");
                    LoadCustomer();
                    CheckRoomm();
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.InnerException.InnerException.Message);
                    
                }
                
            }
            
            
        }

        private void dateTimeCikisTarihi_ValueChanged(object sender, EventArgs e)
        {
            int ucret;

            DateTime GirisTarihi = Convert.ToDateTime(dateTimeGirisTarihi.Text);
            DateTime CikisTarihi = Convert.ToDateTime(dateTimeCikisTarihi.Text);

            TimeSpan sonuc = CikisTarihi - GirisTarihi;

            lblGun.Text = sonuc.TotalDays.ToString();

            ucret = Convert.ToInt32(lblGun.Text) * 50;
            tboxPrice.Text = ucret.ToString();

        }

        
        
        
        private void CheckRoom()
        {
            //object hucresiDegeri = dgwCustomers.Rows[0].Cells[5].Value;
            //object hucresiDegeri2 = dgwCustomers.Rows[1].Cells[5].Value;
            //object hucresiDegeri3 = dgwCustomers.Rows[2].Cells[5].Value;
            //object hucresiDegeri4 = dgwCustomers.Rows[3].Cells[5].Value;
            //object hucresiDegeri5 = dgwCustomers.Rows[4].Cells[5].Value;
            //object hucresiDegeri6 = dgwCustomers.Rows[5].Cells[5].Value;
            

            //if (hucresiDegeri.ToString() == button1.Text || hucresiDegeri2.ToString() == button1.Text || hucresiDegeri3.ToString() == button1.Text ||
            //    hucresiDegeri4.ToString() == button1.Text || hucresiDegeri5.ToString() == button1.Text || hucresiDegeri6.ToString() == button1.Text 
            //   )
            //{
            //    button1.BackColor = System.Drawing.Color.Red;
            //}
            //if (hucresiDegeri.ToString() == btnOdaNo2.Text || hucresiDegeri2.ToString() == btnOdaNo2.Text || hucresiDegeri3.ToString() == btnOdaNo2.Text ||
            //    hucresiDegeri4.ToString() == btnOdaNo2.Text || hucresiDegeri5.ToString() == btnOdaNo2.Text || hucresiDegeri6.ToString() == btnOdaNo2.Text
            //   )
            //{
            //    btnOdaNo2.BackColor  = System.Drawing.Color.Red;
            //}
            //if (hucresiDegeri.ToString() == btnOdaNo10.Text || hucresiDegeri2.ToString() == btnOdaNo10.Text || hucresiDegeri3.ToString() == btnOdaNo10.Text ||
            //    hucresiDegeri4.ToString() == btnOdaNo10.Text || hucresiDegeri5.ToString() == btnOdaNo10.Text || hucresiDegeri6.ToString() == btnOdaNo10.Text
            //   )
            //{
            //    btnOdaNo10.BackColor = System.Drawing.Color.Red;
            //}
            //else
            //{
            //    btnOdaNo10.BackColor= System.Drawing.Color.Green;
            //}
        }

        private void CheckRoomm()
        {
            foreach (Control control in groupBox2.Controls)
            {
                if (control is Button)
                {
                    // Button'ın arka plan rengini varsayılana ayarla
                    ((Button)control).BackColor = SystemColors.Control;
                }
            }
            for (int i = 0; i < dgwCustomers.Rows.Count; i++)
            {
                string deger = dgwCustomers.Rows[i].Cells[5].Value.ToString();
               

                // Formdaki butonları kontrol ederek eşleşenleri bul
                var matchingButtons = groupBox2.Controls.OfType<Button>()
                                        .Where(button => button.Text == deger);

                var nonMatchingButtons = groupBox2.Controls.OfType<Button>()
                           .Where(button => button.Text != deger);

                // Eşleşen butonların arka planını kırmızı yap
                foreach (Button button in matchingButtons)
                {
                    button.BackColor = System.Drawing.Color.Red;
                }

              

            }

        }



        private void button1_Click(object sender, EventArgs e)
        {
            tboxOdaNo.Text = "101";
        }

        private void btnOdaNo2_Click(object sender, EventArgs e)
        {
            tboxOdaNo.Text = "102";
        }

        private void btnOdaNo3_Click(object sender, EventArgs e)
        {
            tboxOdaNo.Text = "103";
        }

        private void btnOdaNo4_Click(object sender, EventArgs e)
        {
            tboxOdaNo.Text = "104";
        }

        private void btnOdaNo5_Click(object sender, EventArgs e)
        {
            tboxOdaNo.Text = "105";
        }

        private void btnOdaNo6_Click(object sender, EventArgs e)
        {
            tboxOdaNo.Text = "106";
        }

        private void btnOdaNo7_Click(object sender, EventArgs e)
        {
            tboxOdaNo.Text = "107";
        }

        private void btnOdaNo8_Click(object sender, EventArgs e)
        {
            tboxOdaNo.Text = "108";
        }

        private void btnOdaNo9_Click(object sender, EventArgs e)
        {
            tboxOdaNo.Text = "109";
        }

        private void btnOdaNo10_Click(object sender, EventArgs e)
        {
            tboxOdaNo.Text = "110";
        }
    }
}
