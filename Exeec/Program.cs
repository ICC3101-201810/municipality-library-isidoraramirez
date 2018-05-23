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
                                  "4. Metodos\n" +
                                  "5. Salir\n" +
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
                        i++;
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
                        i++;
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
                else if(opcion_menu == "5")
                {
                    Console.WriteLine("Adios :(");
                    loop = false;
                }
                while(opcion_menu == "4")
                {
                    Console.WriteLine("------------ METODOS ------------");
                    Console.WriteLine("Ingrese que quiere usar los metodos: \n" +
                                      "1. Personas\n" +
                                      "2. Propiedades\n" +
                                      "3. Direcciones\n  " +
                                      "4. Salir");
                    string opcion_ver = Console.ReadLine();
                    if(opcion_ver == "1")
                    {
                        int i = 0;
                        foreach (Person persona in personas)
                        {
                            Console.WriteLine(i + ". " + persona.First_name + " " + persona.Last_name);
                            i++;
                        }
                        Console.WriteLine("Seleccione una persona: ");
                        Person p1 = personas[Convert.ToInt32(Console.ReadLine())];
                        Console.WriteLine("Que Desea hacer?");
                        Console.WriteLine("1. Cambiar nombre\n" +
                                          "2. Cambiar apellido\n" +
                                          "3. Ser adoptado\n" +
                                          "4. Ser Abandonado\n" +
                                          "5. Especificar Educacion\n" +
                                          "6. Salir");
                        string o_persona = Console.ReadLine();
                        if (o_persona== "1")
                        {
                            Console.WriteLine("Ingrese el nuevo nombre: ");
                            string nnombre = Console.ReadLine();
                            p1.changeFirstName(nnombre);
                        }
                        else if (o_persona == "2")
                        {
                            Console.WriteLine("Ingrese el nuevo apellido: ");
                            string napellido = Console.ReadLine();
                            p1.changeLastName(napellido);
                        }
                        else if(o_persona == "5")
                        {
                            Console.WriteLine("Ingrese Alma Mater: ");
                            string almamater;
                            if (p1.Alma_mater == "") { almamater = Console.ReadLine(); }
                            else { almamater = p1.Alma_mater; }
                            Console.WriteLine("Infique el titulo: ");
                            string educacion = Console.ReadLine();
                            p1.setEducation(almamater, educacion);
                        }
                        else if(o_persona == "4")
                        {
                            p1.getAbandoned();
                        }
                        else if (o_persona == "3")
                        {
                            int j = 0;
                            foreach (Person persona in personas)
                            {
                                Console.WriteLine(j + ". " + persona.First_name + " " + persona.Last_name);
                                j++;
                            }
                            Console.WriteLine("Seleccione por quien sera adoptado: ");
                            Person papa = personas[Convert.ToInt32(Console.ReadLine())];
                            p1.getAdopted(papa);
                        }

                    }
                    else if(opcion_ver == "2")
                    {

                    }
                    else if(opcion_ver == "3")
                    {
                        int j = 0;
                        foreach(Car auto in autos)
                        {
                            Console.WriteLine(j + ". "+ auto.Model+ " "+ auto.Brand);
                            j++;
                        }
                        Car cars = autos[Convert.ToInt32(Console.ReadLine())];

                        Console.WriteLine("Ingrese que quiere ver: \n" +
                                          "1. Año\n" +
                                          "2. Patente\n" +
                                          "3. Cinturones\n" +
                                          "4. Diesel\n");
                        string oauto = Console.ReadLine();
                        if (oauto == "1") { Console.WriteLine(cars.Year); }
                        if (oauto == "2") { Console.WriteLine(cars.License_plate); }
                        if (oauto == "3") { Console.WriteLine(cars.Seatbelts); }
                        if (oauto == "4") { Console.WriteLine(cars.Diesel); }
                    }
                    else
                    {
                        opcion_menu = " ";
                    }
                }
            }
        }
    }
}
