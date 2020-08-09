using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_saludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola Mundo", "Mensaje de saludo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            MessageBox.Show("Hola " + txt_nombre.Text, "Saludo a usuario", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
