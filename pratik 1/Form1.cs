using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pratik_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name=textBox1.Text;
            string surname=textBox2.Text;
            string city=textBox3.Text;//burada butona basıldığında textboxlara girilen verileri değişkenlere atıyoruz

            ogrenci1 ogr = new ogrenci1(name,surname,city);//burada da ogrenci1 sınıfından bir nesne oluşturup constructor yardımıyla verileri atıyoruz

            label7.Text = ogr.Ad;
            label8.Text = ogr.soyad;
            label9.Text = ogr.sehir;//son olarak da label'lara atadığımız verileri yazdırıyoruz
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Text = "";
            label8.Text = "";
            label9.Text = "";//burada da temizle butonuna basıldığında label'ların içini boşaltıyoruz

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

