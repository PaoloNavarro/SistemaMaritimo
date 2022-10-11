using Npgsql;
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
	public partial class insertZonaPesca : Form
	{
        private conec conec;
        puerto puerto = new puerto();

        public insertZonaPesca()
		{
			InitializeComponent();
            conec = new clases.conec();
            LlenarTablaa();
            cPuertos();
            cEspecies();
        }

        public void cPuertos()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select nombre_puerto from puerto;",
               conec.establecerConexion());
            var Valores = new List<String>();

            NpgsqlDataReader consulta = cmd.ExecuteReader();

            while (consulta.Read())
            {
                // Console.Write("{0}\n", dr[1]);
                Valores.Add(consulta.GetString(0));
            }
            ListPuertos.DataSource = Valores;
            ListPuertos.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public void cEspecies()
        {
            NpgsqlCommand cmd = new NpgsqlCommand("select especies from zonapesca;",
               conec.establecerConexion());
            
            var Valores = new List<String>();
            
            NpgsqlDataReader consulta = cmd.ExecuteReader();

            while (consulta.Read())
            {
                // Console.Write("{0}\n", dr[1]);
                Valores.Add(consulta.GetString(0));
            }
            cbx_especies.DataSource = Valores;
            cbx_especies.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        internal void Show(bool v)
        {
            throw new NotImplementedException();
        }

        private void ListPuertos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Insertar();
            LlenarTablaa();
        }

        public void Insertar()
        {
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            String nombreP;
            nombreP = Convert.ToString(ListPuertos.SelectedItem);
            NpgsqlCommand cmd = new NpgsqlCommand("select id_puerto from puerto " + //OBTIENE SLOLO EL ID DE PUERTO
                    "where nombre_puerto = @nombrePuerto;",
            conec.establecerConexion());
            cmd.Parameters.AddWithValue("@nombrePuerto", nombreP);

            int id_puerto2 = 0;
            id_puerto2 = Convert.ToInt32(cmd.ExecuteScalar()); //envia el # del id de puerto
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            zonaPesca zp = new zonaPesca();  //SE AGREGGO ID PUERTO A LA CLASE 

            zp.Ubicacion = txbUbi.Text;
            zp.Coordenadas = txb_coordenadas.Text;
            zp.Especies = cbx_especies.Text;
            zp.Id_puerto = id_puerto2;
            string consulta = "insert into zonapesca (codigo,ubicacion,coordenadas,especies,id_puerto)" +
                  "values (nextval('sq_codigo'),'" + zp.Ubicacion + "','" + zp.Coordenadas + "','" + zp.Especies + "'," + id_puerto2 + ");";

            NpgsqlCommand ejecutar = new NpgsqlCommand(consulta, conec.establecerConexion());
            ejecutar.ExecuteNonQuery();


            LlenarTablaa();

            LlenarTablaa();
        }


        public void LlenarTablaa(){
            NpgsqlCommand cmd = new NpgsqlCommand("select zona.codigo, zona.ubicacion,zona.coordenadas,zona.especies,zona.id_puerto, " +
                "p.nombre_puerto from zonapesca as zona join puerto as p on zona.id_puerto = p.id_puerto;",
            conec.establecerConexion());
            this.TablePesca.ReadOnly = true;
            NpgsqlDataReader consulta = cmd.ExecuteReader();

            while (consulta.Read())
            {
                // Console.Write("{0}\n", dr[1]);
                TablePesca.Rows.Add(consulta[0], consulta[1], consulta[2],
                    consulta[3],consulta[4], consulta[5]);
            }
            conec.establecerConexion().Close();
        }

        private void insertZonaPesca_Load(object sender, EventArgs e)
        {
  
        }
    }
}
