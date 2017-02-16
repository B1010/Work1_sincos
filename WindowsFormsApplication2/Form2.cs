using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataSettings.numericUpDown1 = numericUpDown1.Value;
            DataSettings.numericUpDown2 = numericUpDown2.Value;
            DataSettings.radioButton1 = radioButton1.Checked;
            DataSettings.radioButton2 = radioButton2.Checked;
            DataSettings.radioButton3 = radioButton3.Checked;
            DataSettings.radioButton4 = radioButton4.Checked;
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = DataSettings.numericUpDown1;
            numericUpDown2.Value = DataSettings.numericUpDown2;
            radioButton1.Checked = DataSettings.radioButton1;
            radioButton2.Checked = DataSettings.radioButton2;
            radioButton3.Checked = DataSettings.radioButton3;
            radioButton4.Checked = DataSettings.radioButton4;
        }
    }
}
