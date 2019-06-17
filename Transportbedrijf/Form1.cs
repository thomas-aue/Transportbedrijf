using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Transportbedrijf
{
    public partial class Form1 : Form
    {        
        double volume = 0;
        double gewicht = 0;        
        double kmBinnen = 0;
        double kmBuiten = 0;
        double perKilometer = 0;
        double totaalBinnen = 0;
        double totaalBuiten = 0;
        double waarde = 0;
        double toeslag = 0;
        double totaal = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            volume = double.Parse(textBox1.Text);
            gewicht = double.Parse(textBox2.Text);
            kmBinnen = double.Parse(textBox3.Text);
            kmBuiten = double.Parse(textBox4.Text);
            waarde = double.Parse(textBox5.Text);

            if (!checkBox1.Checked)
            {
                perKilometer = (volume * 0.8) + (gewicht * 0.55);
            }
            if (checkBox1.Checked)
            {
                perKilometer = (volume * 1.25) + (gewicht * 0.45);
            }
            label8.Text = perKilometer.ToString();

            totaalBinnen = kmBinnen * perKilometer;
            totaalBuiten = kmBuiten * perKilometer * 1.45;

            totaal = totaalBinnen + totaalBuiten;

            if (kmBuiten > 0)
            {
                toeslag = 0.035 * waarde;

                if (toeslag < 45)
                {
                    toeslag = 45;
                }
                totaal += toeslag;
            }

            label4.Text = "€" + totaal.ToString();
        }
    }
}
