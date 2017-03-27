using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Gennemsnit : Form
    {

        public Gennemsnit()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            Int32 dansk ;
            Int32 engelsk ;
            Int32 matematik ;
            Int32 sammenlagt = int.MinValue ;
            Int32 antal = 0;
            double gennemsnit;
            string ectsDansk;
            string ectsEngelsk;
            string ectsMatematik;
            
            bool ECTSSkala = radioButtonECTSSkala.Checked;
            bool trettenSkala = radioButtonTrettenSkala.Checked;
            bool syvTrinSkala = radioButtonSyvTrin.Checked;
            
            //Kontroller alle input
            //kontroller om der er skrevet noget i tekstBoxen
            
            //ECTS Beregner
            if (ECTSSkala)
            {
                if (textBoxDansk.Text != "")
                {
                    ectsDansk = beregnECTS(textBoxDansk.Text);
                    dansk = Convert.ToInt32(ectsDansk);
                    antal++;
                    if (sammenlagt == int.MinValue)
                        sammenlagt = dansk;
                    else
                        sammenlagt += dansk;
                }
                else
                    dansk = int.MinValue;
                
                if (textBoxEngelsk.Text != "")
                {
                    ectsEngelsk = beregnECTS(textBoxEngelsk.Text);
                    engelsk = Convert.ToInt32(ectsEngelsk);
                    antal++;
                    if (sammenlagt == int.MinValue)
                        sammenlagt = engelsk;
                    else
                        sammenlagt += engelsk;
                }

                else
                    engelsk = int.MinValue;

                //kontroller om der er skrevet noget i tekstBoxen
                if (textBoxMatematik.Text != "")
                {
                    ectsMatematik = beregnECTS(textBoxMatematik.Text);
                    matematik = Convert.ToInt32(ectsMatematik);
                    antal++;
                    if (sammenlagt == int.MinValue)
                        sammenlagt = matematik;
                    else
                        sammenlagt += matematik;
                }
                
                String ECTSGennemsnit = "";
                gennemsnit = sammenlagt / (double)antal;

                if (gennemsnit < 2)
                    ECTSGennemsnit = "Fx";
                else if (gennemsnit >= 2 && gennemsnit < 3)
                    ECTSGennemsnit = "F";
                else if (gennemsnit >= 3 && gennemsnit < 4)
                    ECTSGennemsnit = "E";
                else if (gennemsnit >= 4 && gennemsnit < 5)
                    ECTSGennemsnit = "D";
                else if (gennemsnit >= 5 && gennemsnit < 6)
                    ECTSGennemsnit ="C";
                else if (gennemsnit >= 6 && gennemsnit < 7)
                    ECTSGennemsnit = "B";
                else if (gennemsnit >= 7)
                    ECTSGennemsnit ="A";


                labelGennemsnit.Text = ("Gennemsnit er" + " " + ECTSGennemsnit);
            }
            else
            //7 og 13 skala beregnere
            {
                if (textBoxDansk.Text != "")
                {
                    dansk = Convert.ToInt32(textBoxDansk.Text);
                    antal++;
                    if (sammenlagt == int.MinValue)
                        sammenlagt = dansk;
                    else
                        sammenlagt += dansk;
                }
                else
                    dansk = int.MinValue;

                //kontroller om der er skrevet noget i tekstBoxen
                if (textBoxEngelsk.Text != "")
                {
                    engelsk = Convert.ToInt32(textBoxEngelsk.Text);
                    antal++;
                    if (sammenlagt == int.MinValue)
                        sammenlagt = engelsk;
                    else
                        sammenlagt += engelsk;
                }

                else
                    engelsk = int.MinValue;

                //kontroller om der er skrevet noget i tekstBoxen
                if (textBoxMatematik.Text != "")
                {
                    matematik = Convert.ToInt32(textBoxMatematik.Text);
                    antal++;
                    if (sammenlagt == int.MinValue)
                        sammenlagt = matematik;
                    else
                        sammenlagt += matematik;
                }

                else
                    matematik = int.MinValue;


                //Opdater variablen gennemsnit nu hvor vi har kontrolleret alle input og lagt dem sammen
                gennemsnit = sammenlagt / (double)antal;
                labelGennemsnit.Text = ("Gennemsnit er" + " " + gennemsnit.ToString("0.##"));
            }
            if (trettenSkala)
            {
                if (gennemsnit < 6)
                    BackColor = Color.Red;
                else
                {
                    BackColor = Color.Green;
                }
            }
            else if (syvTrinSkala)
            {
                if (gennemsnit < 2)
                    BackColor = Color.Red;
                else
                {
                    BackColor = Color.Green;
                }
            }
            else if (ECTSSkala)
            {
                if (gennemsnit < 2)
                    BackColor = Color.Red;
                else
                {
                    BackColor = Color.Green;
                }
            }
            if (BackColor == Color.Red)
                timer1.Enabled = true;

            else if (BackColor == Color.Green)
                timer1.Enabled = false;
        }

        string beregnECTS(string input)
        {
            int ectsValue = int.MinValue;
            var A = new List<string>() { "A", "a" };
            var B = new List<string>() { "B", "b" };
            var C = new List<string>() { "C", "c" };
            var D = new List<string>() { "D", "d" };
            var E = new List<string>() { "E", "e" };
            var F = new List<string>() { "F", "f" };
            var Fx = new List<string>() { "Fx", "FX", "fx", "fX" };

            if (A.Contains(input))//7
                ectsValue = 7;

            else if (B.Contains(input))//6
                ectsValue = 6;

            else if (C.Contains(input))//5
                ectsValue = 5;

            else if (D.Contains(input))//4
                ectsValue = 4;

            else if (E.Contains(input))//3
                ectsValue = 3;

            else if (F.Contains(input))//2
                ectsValue = 2;

            else if (Fx.Contains(input))//1
                ectsValue = 1;

            string output = Convert.ToString(ectsValue);

            return output;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BackColor == Color.Yellow)
                BackColor = Color.Red;
            else
                BackColor = Color.Yellow;
            


        }

        private void Gennemsnit_Load(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxDansk.Text = "";
            textBoxEngelsk.Text = "";
            textBoxMatematik.Text = "";
            timer1.Enabled = false;
            BackColor = default(Color);
            labelGennemsnit.Text = ("Gennemsnit er");
            radioButtonSyvTrin.Checked = true;
        }
    }
}
