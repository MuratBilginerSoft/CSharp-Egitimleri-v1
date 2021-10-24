using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_25_Form_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ToString() Bu Herhangi bir türü String Türüne Dönüştürür.

            //int a;
            //string b;

            //b = "ABC";

            //a = Convert.ToInt32(textBox1.Text);
            //a = int.Parse(textBox1.Text);

            //// Parse Dönüşümü Yapılabilmesi için gelen değerin mutlaka string olması gerekir.

            //label1.Text = a.ToString();

            //b = string.Empty;
            //b = "";
            //b = null;

            //label1.Text = b;

            //label1.Text = textBox1.Text;

            //string a, b;
            //int c;

            //a = textBox1.Text;
            //c = int.Parse(textBox2.Text);

            //label1.Text = a +" "+ c;
            //label1.Text = c + " " + a;

//            label1.Text = "Industryolog Akademinin Eylül Eğitim Başvuruları Başladı.\n\'Be Industryolog Engineer\'";
//            label1.Text = @"Industryolog Akademinin Eylül Eğitim Başvuruları Başladı.
//\'Be Industryolog Engineer\'
//DNA Yazıları Yazılacak 
//Site Düzenlendi";

            //sbyte x = 127;
            //sbyte y = -128;

            //byte x2 = 0;
            //byte x3 = 255;

            byte z1; // 0 255

            int z2 = 260;

            z1 = (byte)z2; // 256%256=0 

            label1.Text = z1.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //char karakter = char.Parse(textBox1.Text); // A - C A - B 65
            //byte a;

            //a = (byte)karakter;

            //label1.Text = a.ToString();
            //label2.Text = karakter.ToString();

            //short x1; // -32 768 +32 767 Int16
            //ushort x2; // 0 65 535

            //float x3 = 4.3f; // Double  

            int x1 = 0;
            decimal x2 = 5.3m;
            decimal toplam = 0;

            toplam = x1 + x2; //  

            label1.Text = toplam.ToString();
            
        }
    }
}
