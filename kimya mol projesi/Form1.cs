using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text= "İşlem yapmak istediğiniz maddeyi sayı rehberinden seçiniz." +
            "\nSayı rehberi aşağıda verilmiştir.\n"+
            
            "\n1)Verilen mol ve mol atom sayısına karşılık diğer atomun tane sayısını bulma."+
            "\n2)Verilen mol ve mol atoma karşılık diğer atomun mol sayısını bulma."+
            "\n3)Verilen tane ve mol atom sayısına karşılık diğer atomun tane sayısını bulma."+
            "\n4)Verilen mol atom ve tane sayısına karşılık diğer atomun mol sayısını bulma."+
            "\n5)Verilen gaz litre ve mol atom sayısına karşılık diğer atomun gaz litresini bulma"+
            "\n6)Verilen mol atom ve gaz litresine karşılık diğer atomun mol sayısını bulma."+
            "\n7)Verilen mol atom ve gaz litresine karşılık diğer atomun tane sayısını bulma."+
            "\n8)Verilen mol sayısı, mol atom ve diğer atomun mol kütlesi verildiğinde diğer atomun mol kütlesini bulma."+
            "\n9)Verilen mol, mol atom ve diğer atomun atom kütlesine karşılık diğer atomun mol kütlesini bulma.";
            label11.Text = "Not: Küsüratlı sayılarda virgül kullanınız";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button1.Visible = false;
            label9.Visible = false;
            label10.Visible = false;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal y = numericUpDown1.Value;
            int x = Convert.ToInt32(y);
            switch (x)
            {
                case 1:
                    label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                    label3.Text = "Verilen atomun mol sayısı:";
                    label4.Text = "Verilen atomun mol atom sayısı:";
                    label6.Text = "Avogadro sayısı:";
                    label7.Text = "Na";
                    label5.Text = "";
                    label8.Text = "";
                    label12.Text = "";
                    label13.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    button1.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    break;
                case 2:
                    label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                    label3.Text = "Verilen atomun mol sayısı:";
                    label4.Text = "Verilen atomun mol atom sayısı:";
                    label6.Text = "";
                    label7.Text = "";
                    label5.Text = "";
                    label8.Text = "";
                    label12.Text = "";
                    label13.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    button1.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    break;
                case 3:
                    label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                    label3.Text = "Verilen atomun tane sayısı:";
                    label4.Text = "Verilen atomun mol atom sayısı:";
                    label6.Text = "Avogadro Sayısı:";
                    label7.Text = "Na";
                    label5.Text = "";
                    label8.Text = "";
                    label12.Text = "";
                    label13.Text = "Na";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    button1.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    break;
                case 4:
                    label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                    label3.Text = "Verilen atomun tane sayısı sayısı:";
                    label4.Text = "Verilen atomun mol atom sayısı:";
                    label6.Text = "Avogadro sayısı:";
                    label7.Text = "Na";
                    label5.Text = "";
                    label8.Text = "";
                    label12.Text = "";
                    label13.Text = "Na";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    button1.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    break;
                case 5:
                    label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                    label3.Text = "Verilen atomun hacim litresi:";
                    label4.Text = "Verilen atomun mol atom sayısı:";
                    label6.Text = "";
                    label7.Text = "";
                    label5.Text = "";
                    label8.Text = "";
                    label12.Text = "";
                    label13.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    button1.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    break;
                case 6:
                    label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                    label3.Text = "Verilen atomun hacim litresi:";
                    label4.Text = "Verilen atomun mol atom sayısı:";
                    label6.Text = "";
                    label7.Text = "";
                    label5.Text = "Gaz litre:";
                    label8.Text = "22,4";
                    label12.Text = "";
                    label13.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    button1.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    break;
                case 7:
                    label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                    label3.Text = "Verilen atomun hacim litresi:";
                    label4.Text = "Verilen atomun mol atom sayısı:";
                    label6.Text = "Avogadro sayısı:";
                    label7.Text = "Na";
                    label5.Text = "Gaz litre:";
                    label8.Text = "22,4";
                    label12.Text = "";
                    label13.Text = "Na";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    button1.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    break;
                case 8:
                    label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                    label3.Text = "Verilen atomun mol sayısı:";
                    label4.Text = "Verilen atomun mol atom sayısı:";
                    label6.Text = "";
                    label7.Text = "";
                    label5.Text = "";
                    label8.Text = "";
                    label12.Text = "İstenilen atomun mol kütlesi";
                    label13.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    button1.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    break;
                case 9:
                    label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                    label3.Text = "Verilen atomun mol sayısı:";
                    label4.Text = "Verilen atomun mol atom sayısı:";
                    label6.Text = "";
                    label7.Text = "";
                    label5.Text = "";
                    label8.Text = "";
                    label12.Text = "İstenilen atom kütlesi";
                    label13.Text = "";
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    button1.Visible = true;
                    label9.Visible = false;
                    label10.Visible = false;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    break;
                default:
                    label2.Text = "Lütfen sadece sayı listesindeki değerlerden giriş yapınız.";
                    label3.Text = "";
                    label4.Text = "";
                    label6.Text = "";
                    label7.Text = "";
                    label5.Text = "";
                    label8.Text = "";
                    label12.Text = "";
                    label13.Text = "";
                    textBox1.Visible = false;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    button1.Visible = false;
                    label9.Visible = false;
                    label10.Visible = false;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal y = numericUpDown1.Value;
            int x = Convert.ToInt32(y);
            double a, b, c, d,o;
            string t;
            switch (x)
            {
                case 1:
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    d = (a * b) / c;
                    t = Convert.ToString(d);
                    label10.Text = t + " Na tane.";
                    label9.Visible = true;
                    label10.Visible = true;
                    break;
                case 2:
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    d = (a * b) / c;
                    t = Convert.ToString(d);
                    label10.Text = t + " mol.";
                    label9.Visible = true;
                    label10.Visible = true;
                    break;
                case 3:
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    d = (a * b) / c;
                    t = Convert.ToString(d);
                    label10.Text = t + " Na tane.";
                    label9.Visible = true;
                    label10.Visible = true;
                    break;
                case 4:
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    d = (a * b) / c;
                    t = Convert.ToString(d);
                    label10.Text = t + " mol.";
                    label9.Visible = true;
                    label10.Visible = true;
                    break;
                case 5:
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    d = (a * b) / c;
                    t = Convert.ToString(d);
                    label10.Text = t + " litre.";
                    label9.Visible = true;
                    label10.Visible = true;
                    break;
                case 6:
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    o = 22.4;
                    d = (a * b) / (c * o);
                    t = Convert.ToString(d);
                    label10.Text = t + " mol.";
                    label9.Visible = true;
                    label10.Visible = true;
                    break;
                case 7:
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    o = 22.4;
                    d = (a * b) / (c * o);
                    t = Convert.ToString(d);
                    label10.Text = t + " Na tane.";
                    label9.Visible = true;
                    label10.Visible = true;
                    break;
                case 8:
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    o = Convert.ToDouble(textBox4.Text);
                    d = (a * b * o) / c;
                    t = Convert.ToString(d);
                    label10.Text = t + " atom kütle.";
                    label9.Visible = true;
                    label10.Visible = true;
                    break;
                case 9:
                    a = Convert.ToDouble(textBox1.Text);
                    b = Convert.ToDouble(textBox2.Text);
                    c = Convert.ToDouble(textBox3.Text);
                    o = Convert.ToDouble(textBox4.Text);
                    d = (o * c) / (a * b);
                    t = Convert.ToString(d);
                    label10.Text = t + " atom kütle.";
                    label9.Visible = true;
                    label10.Visible = true;
                    break;
            }
        }
    }
}
