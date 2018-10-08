using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace sınav
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Button _btn;

        public Form2(Button btn)
        {
            InitializeComponent();
            _btn = btn;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            if (this.Tag != null)
            {
                var customer = (Customer)this.Tag;
                txtAdSoyad.Text = customer.AdSoyad;
                txtTCN.Text = customer.TCNK;
                if (customer.Cinsiyet == "Bayan")
                {
                    rdbBayan.Checked = true;
                }
                else
                {
                    rdbBay.Checked = true;
                }
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            Customer cts = new Customer();
            cts.AdSoyad = txtAdSoyad.Text;
            cts.TCNK = txtTCN.Text;
            if (rdbBay.Checked)
            {
                cts.Cinsiyet = "Bay";
            }
            else if (rdbBayan.Checked)
            {
                cts.Cinsiyet = "Bayan";
            }
            else
            {
                MessageBox.Show("Cinsiyet seçiniz");
            }
            _btn.Tag = cts;
            _btn.BackgroundImage = Image.FromFile("..\\..\\Images\\" + "imageskirmizi.jpg");
            this.Visible = false;
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            _btn.Tag = null;
            _btn.BackgroundImage = Image.FromFile("..\\..\\Images\\" + "imagesmavi.jpg");
            this.Visible = false;
        }

       
    }
}
