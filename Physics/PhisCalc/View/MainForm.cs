using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using PhisCalc.Tools;

namespace PhisCalc.View
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void checkBox_avtonom_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Enabled = checkBox_avtonom.Checked;
            textBox4.Enabled = !checkBox_avtonom.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ToolOperaion.checkInput(textBox1) && ToolOperaion.checkInput(textBox2) && ToolOperaion.checkInput(textBox5)
                && ToolOperaion.checkInput(textBox6) && ToolOperaion.checkInput(textBox7) && ToolOperaion.checkInput(textBox9)
                && ((textBox4.Enabled == true && ToolOperaion.checkInput(textBox4))
                || (textBox3.Enabled == true && ToolOperaion.checkInput(textBox3))))
            {
                List<string> inputList = new List<string>()
                {
                    textBox1.Text,
                    textBox2.Text,
                    textBox3.Text,
                    textBox4.Text,
                    textBox5.Text,
                    textBox6.Text,
                    textBox7.Text,
                    textBox8.Text,
                    textBox9.Text
                };
                List<double> result = ToolOperaion.getResult(inputList,checkBox_otoplenie.Checked,
                    checkBox_avtonom.Checked, checkBoxOffice.Checked);

                Q11.Text = result[0].ToString();
                Q22.Text = result[1].ToString();
                Q33.Text = result[2].ToString();
                labelE.Text = result[3].ToString();
                E11.Text = result[4].ToString();
                E22.Text = result[5].ToString();
            }
            else
            {
                MessageBox.Show("Incorrect input");
            }
        }
    }
}
