using System;
using System.Collections;

namespace Proyecto4
{
	public class Farmacia
	{
		//atributos
		private ArrayList listaVentas;
		private ArrayList listaEmpleados;
		
		//constructor
		public Farmacia()
		{
			listaVentas = new ArrayList();
			listaEmpleados = new ArrayList();
		}
		
		//propiedades
		public ArrayList ListaEmpleados {
			get { return listaEmpleados; }
		}
		public ArrayList ListaVentas {
			get { return listaVentas; }
		}
		
		//metodos
		
	}
}
