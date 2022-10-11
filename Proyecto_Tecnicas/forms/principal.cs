using Proyecto_Tecnicas.clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tecnicas.forms
{
	public partial class principal : Form
	{
		public principal()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
            insertZonaPesca inp = new insertZonaPesca();
            inp.Show();
        }

		private void button1_Click_1(object sender, EventArgs e)
		{
			
		}

		private void button2_Click(object sender, EventArgs e)
		{


		}

		private void principal_FormClosing(object sender, FormClosingEventArgs e)
		{
           
        }

		private void cargarFPuerto(object sender, EventArgs e)
		{
            fPuerto pt = new fPuerto();
            pt.Show();
        }

		private void btnPuertoEntrar(object sender, EventArgs e)
		{
            

        }

		private void btnNuevoP_MouseLeave(object sender, EventArgs e)
		{
        }

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void panel4_MouseMove(object sender, MouseEventArgs e)
		{
		}

		private void btnNuevoP_MouseMove(object sender, MouseEventArgs e)
		{

		}

		private void label2_Click(object sender, EventArgs e)
		{
            insertZonaPesca ZNP = new insertZonaPesca();
            ZNP.Show();
        }

		private void pictureBox4_Click(object sender, EventArgs e)
		{
            ConusltaBarcos cbarcos = new ConusltaBarcos();
            cbarcos.Show();
        }
	}
}
