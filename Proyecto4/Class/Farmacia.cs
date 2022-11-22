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
		//agregar elemento
		public void agregarVenta(Venta venta){
			listaVentas.Add(venta);
		}
		public void agregarEmpleado(Empleado empleado){
			listaEmpleados.Add(empleado);
		}
		//eliminar elemento
		public void eliminarEmpleado(Empleado empleado){
			listaEmpleados.Remove(empleado);
		}
		public void eliminarVenta(Venta venta){
			listaVentas.Remove(venta);
		}
		//cantidad de elementos
		public int cantidadEmpleados(){
			return listaEmpleados.Count;
		}
		public int cantidadVentas(){
			return listaVentas.Count;
		}
		//existe elemento
		public bool existeEmpleado(Empleado e){
			return listaEmpleados.Contains(e);
		}
		public bool existeEmpleado(Venta v){
			return listaVentas.Contains(v);
		}
		//recuperar elemento en 'x' posicion
		public Empleado recuperarEmpleado(int x){
			return (Empleado)listaEmpleados[x];
		}
		public Venta recuperarVenta(int x){
			return (Venta)listaVentas[x];
		}

		public void imprimir(){
			Console.WriteLine("Funcion imprimir");
			Console.WriteLine("=======================================");
			foreach(Venta e in listaVentas){
				Console.WriteLine("Venta: {0} ", e.NroTicket);
				Console.WriteLine("Fecha: {0}/{1}/{2}", e.Fecha.Day, e.Fecha.Month, e.Fecha.Year);
			}
			Console.ReadKey();
		}
	}
}
