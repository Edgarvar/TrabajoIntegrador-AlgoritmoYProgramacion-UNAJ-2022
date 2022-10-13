using System;

namespace Proyecto4
{
	public class Empleado
	{
		//atributos
		private string nombre, apellido;
		private int dni, codVendedor = 100;
		
		//constructor
		public Empleado(string nom, string ape, int dni)
		{
			nombre = nom;
			apellido = ape;
			this.dni = dni;
			codVendedor = codVendedor + 1;
		}
		
		//propiedades
		public string Nombre {
			set { nombre = value; }
			get { return nombre; }
		}
		
		public string Apellido {
			set { apellido = value; }
			get { return apellido; }
		}
		public int Dni {
			set { dni = value ; }
			get { return dni; }
		}
		public int CodVendedor {
			get { return dni; }
		}
	}
}
