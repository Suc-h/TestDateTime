using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testdatetime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //78 05 19
        //78 55 11 6363
        public short count = 0;
        public List<string> rodnacislaM = new List<string>();
       public List<string> rodnacislaZ = new List<string>();
        public double tri;
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime narozeni = dateTimePicker1.Value;
            int dny, mesice, roky;
            mesice = narozeni.Month;
            dny = narozeni.Day;
            roky = narozeni.Year;
            

            
            string pred;
           
            // 25.05.2005 00:00:00


            Random rng = new Random();
            
            
            tri = Math.Round(rng.NextDouble()*10000);
            
            
            if (roky < 2000)
            {
                //předpoklad že nikdo nežije od roku 1899
                roky = roky - 1900;
            }
            else
            {
                roky = roky - 2000;
            }
            if (radioButton2.Checked)
            {
                mesice = mesice + 50;

              

                pred = roky.ToString() + mesice.ToString() + dny.ToString() + tri.ToString();

                while (Convert.ToInt64(pred) % 11 != 0)
                {
                    tri = Math.Round(rng.NextDouble() * 10000);
                    while (tri < 1000)
                    {
                        tri = Math.Round(rng.NextDouble() * 10000);
                    }

                    pred = roky.ToString() + "0" + mesice.ToString() + dny.ToString() + tri.ToString();

                }
                count++;
                rodnacislaZ.Add(pred);
                
            }
            else 
                {

                    
                    pred = roky.ToString() + "0" + mesice.ToString() + dny.ToString() + tri.ToString();

                    while (Convert.ToInt64(pred) % 11 != 0)
                    {
                        tri = Math.Round(rng.NextDouble() * 10000);
                        while (tri < 1000)
                        {
                            tri = Math.Round(rng.NextDouble() * 10000);
                        }
                   
                        pred = roky.ToString() + "0" + mesice.ToString() + dny.ToString() + tri.ToString();

                    }
                count++;
                rodnacislaM.Add(pred);
                  
            }
          
            


                maskedTextBox2.Text = pred;
                maskedTextBox1.Text = pred;


           if(count>=2)
            {
                button2.Visible = true; 
            }





            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label5.Text = rodnacislaM.Count.ToString();
            label6.Text = rodnacislaZ.Count.ToString();
            string[] muzi = rodnacislaM.ToArray();
            string[] zeny = rodnacislaZ.ToArray();
            

            /*
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        label6.Visible = true;*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
