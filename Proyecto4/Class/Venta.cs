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
		private static int contTicket = 100;
		
		public Venta(string nombre, string droga, string obraSocial, int vendedor, double importe)
		{
			this.nomComercial = nombre;
			this.droga = droga;
			this.obraSocial = obraSocial;
			this.codVendedor = vendedor;
			this.nroTicket = contTicket;
			this.importe = importe;
			fecha = DateTime.Now;
			
			contTicket++;
		}
		public int NroTicket{
			get { return nroTicket; }
		}
		public int CodVendedor{
			get { return codVendedor; }
		}
		public string Droga{
			get { return droga; }
		} 
		public DateTime Fecha{
			get { return fecha; }
		}
		public string ObraSocial {
			get { return obraSocial; }
		}
	}
}
