using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;
using System.Threading;

namespace Exeec
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            List<Person> personas = new List<Person>();
            List<Car> autos = new List<Car>();
            List<Address> direcciones = new List<Address>();

            while (loop == true)
            {
                menu:
                Console.WriteLine("     Ingrease que desea crear:\n" +
                                  "1. Persona\n" +
                                  "2. Propiedad\n" +
                                  "3. Automovil\n" +
                                  "4. Salir\n" +
                                  "Opcion: ");
                string opcion_menu = Console.ReadLine();
                if (opcion_menu == "1")
                {
                    Console.WriteLine("------------ INGRESAR PERSONA ------------");
                    Console.WriteLine("Ingrese el primer nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el primer apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Ingrese la fecha de nacimiento(formato yyyy-MM-dd): ");
                    string date = Console.ReadLine();
                    DateTime fecha = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    Console.WriteLine("Ingrese el Rut: ");
                    string rut = Console.ReadLine();
                    Console.WriteLine("Ingresando a {0}", nombre);
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".\n");
                    Console.WriteLine("{0} Ingresad@ con exito!", nombre);
                    Person person = new Person(nombre, apellido, fecha, null, rut, null, null);
                    personas.Add(person);
                    goto menu;
                }

                else if (opcion_menu == "2")
                {
                    Console.WriteLine("------------ INGRESAR PROPIEDAD ------------");
                    Console.WriteLine("Ingrese la marca: ");
                    string marca = Console.ReadLine();
                    Console.WriteLine("Ingrese el modelo: ");
                    string modelo = Console.ReadLine();
                    Console.WriteLine("Ingrese el año: ");
                    int anio = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Seleccione al dueño: ");
                    int i = 0; 
                    foreach(Person persona in personas)
                    {
                        Console.WriteLine(i + ". " + persona.First_name + " "+ persona.Last_name);
                    }
                    Person p1 = personas[Convert.ToInt32(Console.ReadLine())];
                    Console.WriteLine("Ingrese la patente: ");
                    string patente = Console.ReadLine();
                    Console.WriteLine("Ingrese la cantidad de cinturones: ");
                    int cinturones = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Es Diesel?\n 1. Si \n2. No");
                    bool diesel = false;
                    if(Console.ReadLine() == "1") { diesel = true; }
                    Car car = new Car(marca, modelo, anio, p1, patente, cinturones, diesel);
                    autos.Add(car);
                    Console.WriteLine("Ingresando a {0}", patente);
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".\n");
                    Console.WriteLine("{0} Ingresad@ con exito!", patente);
                    goto menu;
                }
                else if (opcion_menu == "3")
                {
                    Console.WriteLine("------------ INGRESAR DIRECCION ------------");
                    Console.WriteLine("Ingrese calle: ");
                    string calle = Console.ReadLine();
                    Console.WriteLine("Ingrese el numero: ");
                    int numero = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese cla comuna: ");
                    string comuna = Console.ReadLine();
                    Console.WriteLine("Ingrese ciudad: ");
                    string ciudad = Console.ReadLine();
                    Console.WriteLine("Seleccione al dueño: ");
                    int i = 0;
                    foreach (Person persona in personas)
                    {
                        Console.WriteLine(i + ". " + persona.First_name + " " + persona.Last_name);
                    }
                    Person p1 = personas[Convert.ToInt32(Console.ReadLine())];
                    Console.WriteLine("Ingrese el año de construccion: ");
                    int anioc = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad de piezas: ");
                    int piezas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingrese cantidad de baños: ");
                    int banos = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tiene patio?\n 1. Si \n2. No");
                    bool patio = false;
                    if (Console.ReadLine() == "1") { patio = true; }
                    Console.WriteLine("Tiene piscina?\n 1. Si \n2. No");
                    bool piscina = false;
                    if (Console.ReadLine() == "1") { piscina = true; }
                    Address address = new Address(calle, numero, comuna, ciudad, p1, anioc, piezas, banos, patio, piscina);
                    Console.WriteLine("Ingresando a {0}, {1}", calle, numero);
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".");
                    Thread.Sleep(800);
                    Console.Write(".\n");
                    Console.WriteLine("{0}, {1} Ingresad@ con exito!", calle,numero);
                    direcciones.Add(address);
                    goto menu;

                }
                else if(opcion_menu == "4")
                {
                    Console.WriteLine("Adios :(");
                    loop = false;
                }
            }
        }
    }
}
