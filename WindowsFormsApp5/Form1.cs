using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
           
            tbKelvin.Clear();
            tbFahrenheit.Clear();
            tbCelcius.Clear();
            tbKelvin.Enabled = true;
            tbFahrenheit.Enabled = true;
            tbCelcius.Enabled = true;
            rbFahrenheit.Checked = false;
            rbCelcius.Checked = false;
            rbKelvin.Checked = false;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            if (tbCelcius.Text != "" || tbKelvin.Text != "" || tbKelvin.Text != "")
            {
                if (!string.IsNullOrEmpty(tbCelcius.Text))
                {
                    if (rbCelcius.Checked)
                    {
                        tbFahrenheit.Enabled = false;
                        tbKelvin.Enabled = false;

                    }
                    float Ce = float.Parse(tbCelcius.Text);
                    float fa = (Ce * 9f / 5f) + 32;
                    float ke = Ce + 273;
                    tbFahrenheit.Text = fa.ToString();
                    tbKelvin.Text = ke.ToString();

                }
                else if (!string.IsNullOrEmpty(tbFahrenheit.Text))
                {
                    if (rbFahrenheit.Checked)
                    {
                        tbCelcius.Enabled = false;
                        tbKelvin.Enabled = false;
                    }

                    float fa = float.Parse(tbFahrenheit.Text);
                    float ce = (fa - 32) * 5.0f / 9.0f;
                    float ke = ce + 273;
                    tbCelcius.Text = ce.ToString();
                    tbKelvin.Text = ke.ToString();
                }
                else if (!string.IsNullOrEmpty(tbKelvin.Text))
                {
                    if (rbKelvin.Checked)
                    {
                        tbFahrenheit.Enabled = false;
                        tbCelcius.Enabled = false;
                    }
                    float ke = float.Parse(tbKelvin.Text);
                    float ce = ke - 273;
                    float fa = (ce * 9f / 5f) + 32;
                    tbFahrenheit.Text = fa.ToString();
                    tbCelcius.Text = ce.ToString();
                }
            }
            else
            {
                MessageBox.Show("Ingrese valores numericos para el calculo de temperatura", "Error de valores",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
} 