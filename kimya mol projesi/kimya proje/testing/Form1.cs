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
            label1.Text= "İşlem yapmak istediğiniz maddeyi sayı rehberinden seçiniz."+ "" +
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
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            decimal y = numericUpDown1.Value;
            int x = Convert.ToInt32(y);
            if (x == 1)
            {
                label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                label3.Text = "Verilen atomun mol sayısı:";
                label4.Text = "Verilen atomun mol atom sayısı:";
                label6.Text = "Avogadro sayısı:";
                label7.Text = "Na";
                label5.Text = "";
                label8.Text = "";
                label13.Text = "";
            }
            else if (x == 2)
            {
                label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                label3.Text = "Verilen atomun mol sayısı:";
                label4.Text = "Verilen atomun mol atom sayısı:";
                label6.Text = "";
                label7.Text = "";
                label5.Text = "";
                label8.Text = "";
                label13.Text = "";
            }
            else if (x == 3)
            {
                label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                label3.Text = "Verilen atomun tane sayısı:";
                label4.Text = "Verilen atomun mol atom sayısı:";
                label6.Text = "Avogadro Sayısı:";
                label7.Text = "Na";
                label5.Text = "";
                label8.Text = "";
                label13.Text = "Na";
            }
            else if (x == 4)
            {
                label2.Text = "İstenilen atomun mol atom sayısını giriniz:";
                label3.Text = "Verilen atomun tane sayısı sayısı:";
                label4.Text = "Verilen atomun mol atom sayısı:";
                label6.Text = "Avogadro sayısı:";
                label7.Text = "Na";
                label5.Text = "";
                label8.Text = "";
                label13.Text = "Na";
            }
            else if (x == 5)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal y = numericUpDown1.Value;
            int x = Convert.ToInt32(y);
            if (x == 1)
            {
                double a =Convert.ToDouble(textBox1.Text);
                double b =Convert.ToDouble(textBox2.Text);
                double c =Convert.ToDouble(textBox3.Text);
                double d = (a * b) / c;
                string t = Convert.ToString(d);
                label10.Text =t + " Na tane.";
            }
            else if (x == 2)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double d = (a * b) / c;
                string t = Convert.ToString(d);
                label10.Text = t + " mol.";
            }
            else if (x == 3)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double d = (a * b) / c;
                string t = Convert.ToString(d);
                label10.Text = t + " Na tane.";
            }
            else if (x == 4)
            {
                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double c = Convert.ToDouble(textBox3.Text);
                double d = (a * b) / c;
                string t = Convert.ToString(d);
                label10.Text = t + " mol.";
            }
        }
    }
}
