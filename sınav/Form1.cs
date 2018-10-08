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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int satirSayisi = 6, sütunSayisi = 12;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < sütunSayisi; i++)
            {
                for (int k = 0; k < satirSayisi; k++)
                {
                    Button btn = new Button();
                    btn.Width = 50;
                    btn.Height = 50;
                    btn.Left = 50 + 50 * i;
                    btn.Top = 50 + k * 50;
                    btn.BackgroundImageLayout = ImageLayout.Stretch;

                    btn.BackgroundImage = Image.FromFile("..\\..\\Images\\" + "imagesmavi.jpg");

                    if ((k % 2 == 0) && (i < 2 || i > 9))
                    {
                        continue;
                    }
                    btn.Click += Btn_Click;
                    this.groupBox1.Controls.Add(btn);
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            
            Button tiklananBtn = (Button)sender;
            Form2 frm2 = new Form2(tiklananBtn);
            var customer = (Customer)tiklananBtn.Tag;
            if (customer != null)
            {
                frm2.Tag = customer;
            }

            frm2.ShowDialog();

        }
    }
}
