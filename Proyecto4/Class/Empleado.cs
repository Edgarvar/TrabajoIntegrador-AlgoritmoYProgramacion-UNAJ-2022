using System;

namespace Proyecto4
{
	public class Empleado
	{
		//atributos
		private string nombre, apellido;
		private int dni, codVendedor;
		private static int contadorDeCodigo = 10;
		
		//constructor
		public Empleado(string nom, string ape, int dni)
		{
			nombre = nom;
			apellido = ape;
			this.dni = dni;
			this.codVendedor = contadorDeCodigo;
			contadorDeCodigo++;
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
			get { return codVendedor; }
		}
	}
}
