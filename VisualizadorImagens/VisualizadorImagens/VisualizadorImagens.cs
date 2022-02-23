using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualizadorImagens
{
    public partial class VisualizadorImagens : Form
    {
        public VisualizadorImagens()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(openFileDialog1.FileName);
            }
        }

        private void checkBoxEsticar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxEsticar.Checked)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            } else
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBackground_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackColor = colorDialog1.Color;
            }
        }
    }
}
