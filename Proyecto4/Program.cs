/*
 * Creado por SharpDevelop.
 * Usuario: edgar
 * Fecha: 10/10/2022
 * Hora: 14:48
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Collections;

namespace Proyecto4
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*==================================*/
			Farmacia farmacity = new Farmacia();
			Empleado e1 = new Empleado("Brisa", "Ayala", 1234);
			Empleado e2 = new Empleado("Edgardo", "Vargas", 2345);
			Empleado e3 = new Empleado("Edg", "Var", 123123123);
			
			Venta v1 = new Venta("Jose", "amoxicilina", "particular", 10, 1200);
			Venta v2 = new Venta("Maria", "ibuprofeno", "osde", 11, 200);
			Venta v3 = new Venta("Felipe", "roacutan", "swiss medical", 12, 500);
			Venta v4 = new Venta("Jorge", "amoxicilina", "particular", 11, 1200);
			Venta v5 = new Venta("Jge", "amoxicilina", "osde", 12, 1200);
			Venta v6 = new Venta("rge", "amoxicilina", "particular", 11, 1200);
			
			
			
			farmacity.agregarEmpleado(e1);
			farmacity.agregarEmpleado(e2);
			farmacity.agregarEmpleado(e3);
			
			farmacity.agregarVenta(v1);
			farmacity.agregarVenta(v2);
			farmacity.agregarVenta(v3);
			farmacity.agregarVenta(v4);
			farmacity.agregarVenta(v5);
			farmacity.agregarVenta(v6);
			/*==================================*/
					
			Console.WriteLine("Bienvenidos a Farmacity.");
			char opc;
			
			while(true){
				Console.WriteLine("Elege una opción:");
				Console.WriteLine("a. Realizar una venta.");
				Console.WriteLine("b. Eliminar venta de medicamento por nro de ticket.");
				Console.WriteLine("c. Informar el porcentaje de ventas de la primer quincena por obra social.");
				Console.WriteLine("d. Listar ventas realidazadas por cada vendedor.");
				Console.WriteLine("e. Agregar Empleado.");
				Console.WriteLine("f. Borrar empleado.");
				Console.WriteLine("g. Listado de empleados.");
				Console.WriteLine("h. Listado de medicamentos vendidos sin repeticiones.");
				Console.WriteLine("s. Salir.");
				
				opc = char.Parse(Console.ReadLine());
				Console.Clear();
				if(opc == 's'){
					Console.WriteLine("Saliendo del sistema...");
					break;
				} else {
					switch(opc){
						case 'a':
							agregarVenta(farmacity);
							Console.WriteLine("Venta agregada.");
							Console.ReadKey(true);
							break;
						case 'b':
							eliminarVentaPorTicket(farmacity);
							Console.ReadKey(true);
							break;
						case 'c':
							Console.WriteLine("Informe de ventas de la primer quincena por obra social.");
							porcentajePrimerQuincena(farmacity);
							Console.ReadKey(true);
							break;
						case 'd':
							Console.WriteLine("Listado de ventas de cada vendedor.");
							ventasPorVendedor(farmacity);
							Console.ReadKey(true);
							break;
						case 'e':
							agregarEmpleado(farmacity);
							Console.WriteLine("Empleado agregado.");
							Console.ReadKey(true);
							break;
						case 'f':
							borrarEmpleado(farmacity);
							Console.WriteLine("Empleado eliminado");
							Console.ReadKey(true);
							break;
						case 'g':
							Console.WriteLine("Listado de empleados.");
							listarEmpleados(farmacity, 0);
							Console.WriteLine("Pulse cualquier tecla para volver al menu principal.");
							Console.ReadKey(true);
							break;
						case 'h':
							Console.WriteLine("Listado de medicamentos vendidos sin repeticiones.");
							medicamentosVendidos(farmacity);
							Console.ReadKey(true);
							break;
						case 'i':
							farmacity.imprimir();
							break;
						default:
							Console.WriteLine("Opción incorrecta.");
							Console.ReadKey(true);
							break;
					}
					Console.Clear();
				}
				
			}
			
			Console.Write("Presione cualquier tecla para cerrar . . . ");
			Console.ReadKey(true);
		}
		public static void menu(char opc, Farmacia far){
			switch(opc){
				case 'a':
					agregarVenta(far);
					Console.WriteLine("Venta agregada.");
					Console.ReadKey(true);
					break;
				case 'b':
					eliminarVentaPorTicket(far);
					Console.WriteLine("Ticket de venta eliminado.");
					Console.ReadKey(true);
					break;
				case 'c':
					Console.WriteLine("Informe de ventas de la primer quincena por obra social.");
					porcentajePrimerQuincena(far);
					Console.ReadKey(true);
					break;
				case 'd':
					Console.WriteLine("Listado de ventas de cada vendedor.");
					ventasPorVendedor(far);
					Console.ReadKey(true);
					break;
				case 'e':
					agregarEmpleado(far);
					Console.WriteLine("Empleado agregado.");
					Console.ReadKey(true);
					break;
				case 'f':
					borrarEmpleado(far);
					Console.WriteLine("Empleado eliminado");
					Console.ReadKey(true);
					break;
				case 'g':
					Console.WriteLine("Listado de empleados.");
					listarEmpleados(far, 0);
					Console.WriteLine("Pulse cualquier tecla para volver al menu principal.");
					Console.ReadKey(true);
					break;
				case 'h':
					Console.WriteLine("Listado de medicamentos vendidos sin repeticiones.");
					medicamentosVendidos(far);
					Console.ReadKey(true);
					break;
				case 'i':
					far.imprimir();
					break;
				default:
					Console.WriteLine("Opción incorrecta.");
					Console.ReadKey(true);
					break;
			}
		}
		
		//a - Agregar una venta de medicamento
		public static void agregarVenta(Farmacia f){
			Venta nuevaVenta;
			Console.Write("Ingrese nombre del cliente: ");
			string nom = Console.ReadLine();
			Console.Write("Ingrese droga: ");
			string droga = Console.ReadLine();
			Console.Write("Ingresar obra social o particular en el caso de no tener: ");
			string obSo = Console.ReadLine();
			Console.Write("Ingresar importe: ");
			double importe = double.Parse(Console.ReadLine());
			bool existe = false;
			
			while(!existe){
				Console.Write("Ingresar codigo de vendedor: ");
				int cod = int.Parse(Console.ReadLine());
				foreach(Empleado e in f.ListaEmpleados){
					if(e.CodVendedor == cod){
					   	nuevaVenta = new Venta(nom, droga, obSo, cod, importe);
					   	f.agregarVenta(nuevaVenta);
					   	Console.WriteLine("Venta exitosa.");
					   	existe = true;
					} 
				}
				if(!existe){
					Console.WriteLine("No existe empleado con ese codigo, vuelva a ingresarlo");
				}
			}
						
		}
		
		//b - Eliminar venta de medicamento por nro de Ticket-Factura
		public static void eliminarVentaPorTicket(Farmacia f){			
			while(true){
				Venta ven = null;
				try{
					Console.Write("Ingresar nro de Ticket que desea borrar: ");
					int ticket = int.Parse(Console.ReadLine());
					bool existe = false;
					foreach(Venta v in f.ListaVentas){
						if(v.NroTicket == ticket){
							ven = v;
							existe = true;
							break;
						}
					}
					if(existe){
						f.eliminarVenta(ven);
						Console.WriteLine("Ticket de venta eliminado. Presione cualquier tecla para volver al menu principal.");
						break;
					} else {
						throw new NroDeTicketInvalido();
					}
				} catch(FormatException) {
					Console.WriteLine("haz ingresado formatos incorrectos. vuelva a intentarlo.");
				} catch(NroDeTicketInvalido){
					Console.WriteLine("Codigo inexistente. Vuelva a intentarlo.");
				}
			}
		}
		
		//c - Informar el porcentaje de ventas en la primer quincena que hayan sido por obrasocial.
		public static void porcentajePrimerQuincena(Farmacia f){
			int ventasPrimerQuincena = 0;
			double porcentajeVentas;
			
			foreach(Venta v in f.ListaVentas){
				if(v.Fecha.Day <= 15 && v.ObraSocial != "particular"){
					ventasPrimerQuincena++;
				}
			}
			
			porcentajeVentas = (ventasPrimerQuincena * 100) / f.ListaVentas.Count;
			
			Console.WriteLine("El porcentaje de ventas de la segunda quincena por obra social es {0}%.", porcentajeVentas);
			Console.WriteLine("Presione cualquier tecla para volver al menu principal");
		}
		
		//d - Listar la cantidad de ventas realizadas por cada vendedor.
		public static void ventasPorVendedor(Farmacia f){
			foreach(Empleado e in f.ListaEmpleados){
				int cantVentas = 0;
				foreach(Venta v in f.ListaVentas){
					if(e.CodVendedor == v.CodVendedor)
						cantVentas++;
				}
				Console.WriteLine("El vendedor {0} {1} tuvo {2} ventas.", e.Nombre, e.Apellido, cantVentas);
			}
		}
		
		//e - Agregar Empleado
		public static void agregarEmpleado(Farmacia f){
			Empleado nuevoEmpleado;
			string nombre, apellido;
			int dni;
					
			while(true){
				Console.Write("Ingresar nombre: ");
				nombre = Console.ReadLine();
				Console.Write("Ingresar apellido: ");
				apellido = Console.ReadLine();
				Console.Write("Ingresar dni: ");
				dni = int.Parse(Console.ReadLine());
				bool registrado = false;
				
				foreach(Empleado e in f.ListaEmpleados){
					if(e.Dni == dni){
						registrado = true;
					}
				}
						
				if(registrado){
					Console.WriteLine("Ya hay un empleado registrado con ese dni, vuelva a introducirla.");
				} else {
					nuevoEmpleado = new Empleado(nombre, apellido, dni);
					f.agregarEmpleado(nuevoEmpleado);
					break;
				}
			}
		}
		
		//f - Borrar Empleado
		public static void borrarEmpleado(Farmacia f){
			while(true){
				Console.Write("Ingrese el codigo de vendedor: ");
				int codigo = int.Parse(Console.ReadLine());
				bool existe = false;
				foreach(Empleado e in f.ListaEmpleados){
					if(e.CodVendedor == codigo){
						f.eliminarEmpleado(e);
						existe = true;
						break;
					}
				}
				
				if(existe){
					Console.WriteLine("El empleado con el codigo {0} ha sido borrado.", codigo);
					Console.ReadKey();
					break;
				} else {
					Console.WriteLine("El codigo ingresado es incorrecto. Vuelva a introducir el código...");
					Console.ReadKey();
				}
			}
		}
		
		//g - Listado de Empleados
		public static void listarEmpleados(Farmacia f, int n){
			foreach(Empleado e in f.ListaEmpleados){
				Console.WriteLine("Nombre: {0} {1}. Dni: {2}. Código de vendedor: {3}", e.Nombre, e.Apellido, e.Dni, e.CodVendedor);
			}
		}
		
		//h - Listado de medicamentos vendidos sin repeticiones (se obtiene a partir de las ventas).
		public static void medicamentosVendidos(Farmacia f){
			ArrayList medicamentos = new ArrayList();
			
			foreach(Venta v in f.ListaVentas){
				bool existe = false;
				foreach(string m in medicamentos){
					if(v.Droga == m){
						existe = true;
						break;
					}
				}
				if(!existe){
					medicamentos.Add(v.Droga);
				}
			}
			
			foreach(string m in medicamentos){
				Console.WriteLine(m);
			}
			
			Console.WriteLine("Presiona cualquier tecla para regresar al menu principal...");
		}
	}
}