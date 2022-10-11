using Npgsql;
using Proyecto_Tecnicas.clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Tecnicas.forms
{
	public partial class fPuerto : Form
	{
        private conec conec;
        puerto puerto = new puerto();
        public fPuerto()
		{
			InitializeComponent();
            conec = new clases.conec();
            llenarCB();
            llenaTabala();

        }
        void llenarCB()
        {


            NpgsqlCommand cmd = new NpgsqlCommand("select tipo_agua from tipoAgua;",
                conec.establecerConexion());
            this.tablaPuertos.ReadOnly = true;

            NpgsqlDataReader consulta = cmd.ExecuteReader();
            var Valores = new List<String>();


            while (consulta.Read())
            {
                // Console.Write("{0}\n", dr[1]);
                Valores.Add((String)consulta[0]);
            }
            cbAgua.DataSource = Valores;
            cbAgua.DropDownStyle = ComboBoxStyle.DropDownList;


            conec.establecerConexion().Close();
        }
       void llenaTabala()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select pt.pais,pt.nombre_puerto,pt.profundidad,pt.tipogrua,pt.barcocapacidad,p.tipo_agua,pt.posicion\r\nfrom puerto as pt\r\njoin tipoAgua as  p on p.id_tipo_agua=pt.tagua;;",
            conec.establecerConexion());
            this.tablaPuertos.ReadOnly = true;

            NpgsqlDataReader consulta = cmd.ExecuteReader();

            while (consulta.Read())
            {
                // Console.Write("{0}\n", dr[1]);
                tablaPuertos.Rows.Add(consulta[0], consulta[1], consulta[2],
                    consulta[3], consulta[4], consulta[5], consulta[6]);
            }




            conec.establecerConexion().Close();
        }
        void insertar()
        {
            NpgsqlCommand newcmd = new NpgsqlCommand("select id_puerto from puerto order by id_puerto DESC LIMIT 1;",
                conec.establecerConexion());
            NpgsqlDataReader consulta = newcmd.ExecuteReader();
            int id = 0;
       
            while (consulta.Read())
            {
                id = ((int)consulta[0])+1;
            }

            puerto objpuerto = new puerto();
            objpuerto.Nombre = pnombre.Text;
            objpuerto.Pais = ppais.Text;
            objpuerto.Profundidad = pprofunidad.Text;
            
            if (cbAgua.Text == "dulce")
            {
                objpuerto.TipoAgua = 1;

            }
            else
            {
                objpuerto.TipoAgua = 2;
            }
            objpuerto.TipoGrua = cbGrua.Text;
            objpuerto.BarcoCapacidad = Convert.ToDouble(cpcapacidad.Text);
            objpuerto.Posicion = Convert.ToDouble(pposcion.Text);
            string qury= "Insert into \"puerto\"(id_puerto,pais,nombre_puerto,profundidad,tipoGrua,barcoCapacidad,tAgua,posicion) values ("+ id +",'" + objpuerto.Pais + "','"+
                objpuerto.Nombre+"','" + objpuerto.Profundidad+"','"+ objpuerto.TipoGrua+"','"+ objpuerto.BarcoCapacidad +"',"+
              objpuerto.TipoAgua +",'" + objpuerto.Posicion + "')";
            MessageBox.Show(qury);
            pnombre.Text = qury;

            NpgsqlCommand ejecutar = new NpgsqlCommand(qury, conec.establecerConexion());
            ejecutar.ExecuteNonQuery();
            limpiar();
            llenaTabala();

        }

        private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

		private void label7_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            insertar();

        }

        private void select(object sender, EventArgs e)
        {

        }
        void limpiar()
        {

            tablaPuertos.Rows.Clear();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
