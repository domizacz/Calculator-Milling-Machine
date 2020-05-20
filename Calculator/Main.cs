using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            double surface1 = Convert.ToDouble(surface.Text);
            double diameter1 = Convert.ToDouble(diameter.Text);

            double pettooth1 = Convert.ToDouble(pet_tooth.Text);
            double flute1 = Convert.ToDouble(flute.Text);
            parametr(surface1, diameter1);
            double speed1 = Convert.ToDouble(rpm.Text);
            par_speed(speed1, pettooth1, flute1);
            if (skok.Text == "")
            {
                skok.Text = "1";
            }
            if (speed_tap.Text == "")
            {
                speed_tap.Text = "50";
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void parametr(double surface, double diamete)
        {

            double pi = 3.82;
            double wynik;
            wynik = surface*pi/diamete;
            wynik = Math.Round(wynik, 0);
            rpm.Text = wynik.ToString();
        }
        public void par_speed (double rpm,  double pettooth, double flute)
        {
            double wynik;
            wynik = rpm * pettooth * flute*10;
            wynik = Math.Round(wynik,0);
            speed.Text = wynik.ToString();
        }

        private void diameter_TextChanged(object sender, EventArgs e)
        {
            if (diameter.Text=="")
            { diameter.Text = "0"; }
            

           double surface1 = Convert.ToDouble(surface.Text);
           double diameter1 = Convert.ToDouble(diameter.Text);
            
            double pettooth1 = Convert.ToDouble(pet_tooth.Text);
            double flute1 = Convert.ToDouble(flute.Text);
           parametr(surface1, diameter1);
            double speed1 = Convert.ToDouble(rpm.Text);
            par_speed(speed1,pettooth1,flute1);
        }

        private void surface_TextChanged(object sender, EventArgs e)
        {
            if (surface.Text == "")
            { surface.Text = "0"; }


            double surface1 = Convert.ToDouble(surface.Text);
            double diameter1 = Convert.ToDouble(diameter.Text);

            double pettooth1 = Convert.ToDouble(pet_tooth.Text);
            double flute1 = Convert.ToDouble(flute.Text);
            parametr(surface1, diameter1);
            double speed1 = Convert.ToDouble(rpm.Text);
            par_speed(speed1, pettooth1, flute1);
        }

        private void pet_tooth_TextChanged(object sender, EventArgs e)
        {
            if (pet_tooth.Text == "")
            { pet_tooth.Text = "0.00"; }

            double surface1 = Convert.ToDouble(surface.Text);
            double diameter1 = Convert.ToDouble(diameter.Text);

            double pettooth1 = Convert.ToDouble(pet_tooth.Text);
            double flute1 = Convert.ToDouble(flute.Text);
            parametr(surface1, diameter1);
            double speed1 = Convert.ToDouble(rpm.Text);
            par_speed(speed1, pettooth1, flute1);
        }

        private void flute_TextChanged(object sender, EventArgs e)
        {

            if (flute.Text == "")
            { flute.Text = "0"; }

            double surface1 = Convert.ToDouble(surface.Text);
            double diameter1 = Convert.ToDouble(diameter.Text);

            double pettooth1 = Convert.ToDouble(pet_tooth.Text);
            double flute1 = Convert.ToDouble(flute.Text);
            parametr(surface1, diameter1);
            double speed1 = Convert.ToDouble(rpm.Text);
            par_speed(speed1, pettooth1, flute1);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (skok.Text == "")
            {
                skok.Text = "1";
            }
            double skok1 = Convert.ToDouble(skok.Text);
            double speed1 = Convert.ToDouble(speed_tap.Text);
            taper(skok1,speed1);
        }

        public void taper(double skok, double speed)
        {
            if(typ.Text== "Metric")
            {
                double incz= 25.4;
                double wyn = ((skok / incz) * speed)*10;
                string swyn = Convert.ToString(Math.Round(wyn, 0));
                feet_speed.Text= "Feed: " + swyn;

            }
            if (typ.Text == "Inches")
            {
                double incz = 25.4;
                double wyn = ((1 / skok) * speed)*10;
                string swyn = Convert.ToString(Math.Round (wyn,0));
                feet_speed.Text = "Feed: "+swyn;
            }

        }

        private void typ_TextChanged(object sender, EventArgs e)
        {
            if (skok.Text == "")
            {
                skok.Text = "1";
            }
            double skok1 = Convert.ToDouble(skok.Text);
            double speed1 = Convert.ToDouble(speed_tap.Text);
            taper(skok1, speed1);
        }

        private void speed_tap_TextChanged(object sender, EventArgs e)
        {
         
            if (speed_tap.Text == "")
            {
                speed_tap.Text = "50";
            }
            double skok1 = Convert.ToDouble(skok.Text);
            double speed1 = Convert.ToDouble(speed_tap.Text);
            taper(skok1, speed1);
        }

        private void diameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
                e.Handled = true;

            // nie pozwala na przecinek na początku
            if (e.KeyChar == ',' && diameter.SelectionStart == 0)
                e.Handled = true;


            if (char.IsDigit(e.KeyChar)|| e.KeyChar == '.' ||  e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }

        private void surface_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar)  || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;

        }

        private void pet_tooth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
                e.Handled = true;

            // nie pozwala na przecinek na początku
            if (e.KeyChar == ',' && pet_tooth.SelectionStart == 0)
                e.Handled = true;
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }

        private void flute_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                base.OnKeyPress(e);
            else
                e.Handled = true;
        }
    }
}
