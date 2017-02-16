using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int cx = pictureBox1.Width;
            Graphics g = pictureBox1.CreateGraphics();
            PointF[] ptf = new PointF[cx];

            int cw = Convert.ToInt32(DataSettings.numericUpDown1);
            g.Clear(pictureBox1.BackColor);

            for (int i = 0; i < cx; i++)
            {
                ptf[i].X = i;
                if (DataSettings.radioButton1)
                {
                    ptf[i].Y = (float)(Convert.ToInt32(DataSettings.numericUpDown2) * (1 - Math.Sin(i * cw * Math.PI / (cx - 1))));
                }
                else if (DataSettings.radioButton2)
                {
                    ptf[i].Y = (float)(Convert.ToInt32(DataSettings.numericUpDown2) * (1 - Math.Cos(i * cw * Math.PI / (cx - 1))));
                }
                else if (DataSettings.radioButton3)
                {
                    ptf[i].Y = (float)(Convert.ToInt32(DataSettings.numericUpDown2) * (1 - Math.Tan(i * cw * Math.PI / cx))+100);
                }
                else if (DataSettings.radioButton4)
                {
                    ptf[i].Y = (float)(Convert.ToInt32(DataSettings.numericUpDown2) * (1 - 1 / (1 + Math.Tan(i * cw * Math.PI / cx)))+100);
                }
            }
            g.DrawLines(Pens.Blue, ptf);
            g.Dispose();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 settings = new Form2();
            settings.ShowDialog();
        }

        private void foneColorToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            pictureBox1.BackColor = Color.FromArgb(255, colorDialog1.Color);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Jpeg);
            saveFileDialog1.Filter = "JPEG изображение | *.jpg";
            saveFileDialog1.DefaultExt = "jpg";
            
        }
    }
}
