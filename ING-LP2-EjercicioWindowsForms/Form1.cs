using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ING_LP2_EjercicioWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxRadio.Enabled = false;
            textBoxAltura.Enabled = false;
            textBoxBase.Enabled = false;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            double area = 0;

            if (radioButtonRectangulo.Checked)
            {
                try
                {
                    area = Convert.ToDouble(textBoxBase.Text) * Convert.ToDouble(textBoxAltura.Text);
                }
                catch { return; }
            }
            if (radioButtonTriangulo.Checked)
            {
                try
                {
                    area = (Convert.ToDouble(textBoxBase.Text) * Convert.ToDouble(textBoxAltura.Text)) / Convert.ToDouble(2);
                }
                catch { return; }
            }
            if (radioButtonCirculo.Checked)
            {
                try
                {
                    area = Convert.ToDouble(Math.PI) * Math.Pow(Convert.ToDouble(textBoxRadio.Text), 2);
                }
                catch { return; }
            }

            textBoxArea.Text = Convert.ToString(area);
        }

        private void radioButtonRectangulo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxArea.ResetText();
            textBoxRadio.ResetText();

            textBoxRadio.Enabled = false;
            textBoxAltura.Enabled = true;
            textBoxBase.Enabled = true;
        }

        private void radioButtonTriangulo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxArea.ResetText();
            textBoxRadio.ResetText();

            textBoxRadio.Enabled = false;
            textBoxAltura.Enabled = true;
            textBoxBase.Enabled = true;
        }

        private void radioButtonCirculo_CheckedChanged(object sender, EventArgs e)
        {
            textBoxArea.ResetText();
            textBoxBase.ResetText();
            textBoxAltura.ResetText();

            textBoxRadio.Enabled = true;
            textBoxAltura.Enabled = false;
            textBoxBase.Enabled = false;
        }
    }
}
