using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //string adi = textBox1.Text;
            //string soyadi = textBox2.Text;
            //string dogumYeri = textBox3.Text;




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




            List<Kisiler> kisiler = new List<Kisiler>()
            {new Kisiler()
            {

                Adi = textBox1.Text,
                Soyadi=textBox2.Text,
                DogumiYeri=textBox3.Text,
            }
            };
            foreach (Kisiler item in kisiler)
            {
                listBox1.Items.Add(item);
            }





            Favoriler[] sevdiklerim = new Favoriler[]
            {
                new Favoriler()
                {
                    Meyve=textBox1.Text,
                    Sebze=textBox2.Text,
                    Sayi=int.Parse (textBox3.Text),
                }
            };

            foreach (Favoriler item11 in sevdiklerim)
            {

                listBox1.Items.Add(item11);

            }


        }
    }

}

