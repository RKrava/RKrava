using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using WindowsFormsApplication3.Tools;

namespace WindowsFormsApplication3.View
{
    public partial class FirstForm : Form
    {
        public double A = 0, A1 = 0, E1 = 0, n = 0, k = 0, V1 = 0, Z1 = 0, Q1 = 0, Q2 = 0, f1 = 0, f2 = 0, f3 = 0, E2 = 0, S = 0, E = 0, N = 0, Q3 = 0;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_avtonom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_avtonom.Checked == true)
            {
                textBox3.Enabled = true;
                textBox4.Enabled = false;
            }
            else
            {
                textBox3.Enabled = false;
                textBox4.Enabled = true;
            }
        }

        public void cin()
        {
            A = Convert.ToDouble(textBox1.Text);
            A1 = Convert.ToDouble(textBox2.Text);
            E1 = abs(A1 - A);
            if (checkBox_otoplenie.Checked == true)
            {
                n = 1;
            }
            else
            {
                n = 6;
                k = 1;
            }
            if (checkBox_avtonom.Checked == true)
            {
                V1 = Convert.ToDouble(textBox3.Text);
                Q1 = q * 0.7168 * V1 * n;
            }
            else
            {
                Z1 = Convert.ToDouble(textBox4.Text);
                Q1 = Z1 * 1163.9;
            }

            N = Convert.ToDouble(textBox5.Text);

            if (checkBoxOffice.Checked == true)
            {
                Q2 = N * 3;
            }
            else
            {
                Q2 = N * (183 / 2) * 0.25;
            }
            f1 = Convert.ToDouble(textBox6.Text);
            f2 = Convert.ToDouble(textBox7.Text);
            f3 = Convert.ToDouble(textBox8.Text);
            Q3 = 1.6 * f1 * f2 * f3;

            E2 = Q1 + Q2 + Q3;
            S = Convert.ToDouble(textBox9.Text);

            E = (E1 + E2) / S; // result

            labelE.Text = Convert.ToString(Convert.ToInt32(E));
            E11.Text = Convert.ToString(E1);
            Q11.Text = Convert.ToString(Q1);
            Q22.Text = Convert.ToString(Q2);
            Q33.Text = Convert.ToString(Q3);
            E22.Text = Convert.ToString(E2);

        }

        public const int q = 4980000, k1 = 1600;

        public FirstForm()
        {
            InitializeComponent();
            bool i = Tools.Tools.t(textBox2);
            
        }

        private double abs(double tmp)
        {
            return tmp > 0 ? tmp : -1 * tmp;
        }

        private void FirstForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tools.Tools.t(textBox2) && Tools.Tools.t(textBox1) && Tools.Tools.t(textBox9) && Tools.Tools.t(textBox5) && Tools.Tools.t(textBox7) && Tools.Tools.t(textBox6))
            {
                if(textBox4.Enabled == true && Tools.Tools.t(textBox4))
                {
                    cin();
                }
                else
                {
                    if (Tools.Tools.t(textBox3))
                    {
                        cin();
                    }
                    else
                    {
                        //ERROR
                    }
                }
            }
            else
            {
                //ERROR
            }
        }
        

    }
}
