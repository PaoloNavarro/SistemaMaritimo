using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Tecnicas.clases
{
	internal class zonaPesca : puerto
	{
		private string ubicacion,coordenadas,especies;
		private int codigo,id_puerto;
		private DateTime uso;
		public zonaPesca() { }

		public zonaPesca(int codigo, string ubicacion, string coordenadas,
			string especies,int id_puerto, DateTime uso)
		{
			this.codigo = codigo;
			this.ubicacion = ubicacion;
			this.coordenadas = coordenadas;
			this.especies = especies;
			this.uso = uso;
			this.id_puerto = id_puerto;
		}

		//public zonaPesca(string pais, string nombre, string profundidad,
		//	string tipoGrua, double barcoCapacidad, int tipoAgua,double posicion,
  //          string codigo,string ubicacion,string coordenadas,string especies
		//	,DateTime uso): 
		//	base(pais, nombre, profundidad, tipoGrua,barcoCapacidad, tipoAgua,
		//		posicion)
		//{
		//	this.codigo = codigo;
		//	this.ubicacion = ubicacion;
		//	this.coordenadas = coordenadas;
		//	this.especies = especies;
		//	this.uso = uso;
		//}

		//encapsulamiento a modificar
		public DateTime Uso { get => uso; set => uso = value; }
		public int Codigo { get => codigo; set => codigo = value; }
		public string Ubicacion { get => ubicacion; set => ubicacion = value; }
		public string Coordenadas { get => coordenadas; set => coordenadas = value; }
		public string Especies { get => especies; set => especies = value; }
		public int Id_puerto { get => id_puerto; set => id_puerto = value; }
	}
}
