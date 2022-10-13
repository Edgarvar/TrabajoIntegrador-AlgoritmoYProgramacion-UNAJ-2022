using System;

namespace Proyecto4
{
	public class Venta
	{
		//atributos
		private string nomComercial, droga, obraSocial;
		private int codVendedor, nroTicket;
		private double importe;
		private DateTime fecha;
		
		public Venta(string nombre, string droga, string obraSocial, int vendedor, int nroTicket, double importe)
		{
			this.nomComercial = nombre;
			this.droga = droga;
			this.obraSocial = obraSocial;
			this.codVendedor = vendedor;
			this.nroTicket = nroTicket;
			this.importe = importe;
			
		}
	}
}
