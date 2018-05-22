using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Exeec
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly;
            assembly = Assembly.LoadFrom(@"ClassLibrary1.dll");

            Type[] tipos = assembly.GetTypes();

            foreach(Type tipo in tipos)
            {
                
                PropertyInfo[] propertyinfo = tipo.GetProperties();
                String nombre = tipo.Name;
                MethodInfo[] metodosinfo = tipo.GetMethods();
                ConstructorInfo[] constructorinfo = tipo.GetConstructors();

                Console.WriteLine(nombre);
                Console.WriteLine("Popiedades");

                foreach (PropertyInfo propiedad in propertyinfo)
                {
                    Console.WriteLine("Propiedades: " + propiedad);

                }
                Console.WriteLine("-----------------------\nMetodos:");
                foreach(MethodInfo metodo in metodosinfo)
                {
                    Console.WriteLine("Metodos: " + metodo + "Tipo: "+metodo.Attributes);

                }
                Console.WriteLine("------------------------\nConstructor");
                foreach(ConstructorInfo constructor in constructorinfo)
                {
                    Console.WriteLine("Constructor: " + constructor + ""+ constructor.CustomAttributes);

                }
                Console.WriteLine(  "---------------------------------\n");


            }


            Console.ReadLine();
        }
    }
}
