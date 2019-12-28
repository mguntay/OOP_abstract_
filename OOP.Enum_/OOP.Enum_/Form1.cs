using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP.Enum_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(Enum.GetNames(typeof(Departman)));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Personel personel = new Personel();
            //personel.SacRengi = Color.Aqua;
            // personel.Departman = Departman.Yazılım;
            personel.Adi = textBox1.Text;
            personel.Soyadi = textBox2.Text;
            personel.Departman = (Departman)Enum.Parse(typeof(Departman),comboBox1.Text);
            MessageBox.Show($"Personel Adi :{personel.Adi}\nPersonel SoyAdı :{personel.Soyadi}\nDepartmanı :{personel.Departman}");
            switch (personel.Departman)
            {
                case Departman.Yazılım:
                    break;
                case Departman.Sistem:
                    break;
                case Departman.TeknikCizim:
                    break;
                case Departman.Ofis:
                    break;
                case Departman.Muhasebe:
                    break;
                default:
                    break;
            }
        }
    }
}


//Ödev
//design patter nedir?
//SOLID Prensipleri nedir?
