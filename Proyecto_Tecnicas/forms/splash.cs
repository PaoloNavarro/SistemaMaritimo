using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Proyecto_Tecnicas.forms
{
    public partial class splash : Form
    {
        public splash()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            principal pr = new principal();
            pr.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 10;
                label1.Text = "CARGANDO EL SISTENA AL " +progressBar1.Value+"%";

            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                this.Close();

            }

        }

        private void splash_FormClosing(object sender, FormClosingEventArgs e)
        {
      
        }

        private void splash_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
