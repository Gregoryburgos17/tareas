using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consoletareas
{
    class Program
    {
        static void HolaEstudiante(string nombre)
        {

            Console.WriteLine($"Hola, estudiante {nombre}. Bienvenido a programación I");
        }
        static void numeros()
        {
            int x;
            x = 1;
            while (x <= 50)
            {
                Console.WriteLine(x);
                Console.WriteLine(" - ");
                x = x + 1;
            }
            Console.ReadKey();
        }
        static void Intertar()
        {
            Random n = new Random();
            int num = n.Next(100),conINT=0,nu;
            do
            {
            Numero:
                Console.Clear();
                Console.WriteLine("introduce tu numero ");
                try
                {
                    nu = int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Clear();
                    Console.WriteLine("Mi loco, ponga un numero entero!");
                    Console.ReadKey();
                    goto Numero;
                }
                conINT++;
                if(nu != num)
                {
                    Console.Clear();
                    Console.WriteLine($"sigue intentando: {conINT}");
                    Console.ReadKey();
                }



            } while (conINT !=6);
        }
        static void carrovisual()
        {
            string vh = "";
            vh = "    ┌────────┐\n";
            vh += "   |ΠΠ  ΠΠΠ |\n";
            vh += "┌───────────────┐";
            vh += "└─┘  ───────  └─┘";
        }

        static void Main(string[] args)
        {
             string nombre="",opciones;
             Console.Write("introduce tu nombre ");
             nombre = Console.ReadLine();
            
            do
            {
                Console.Clear();
                HolaEstudiante(nombre);
                Console.WriteLine("tienes varias desmostraciones de poo y metodos\n[1]numeros hasta el 50\n[2]adivina el numero\n[3]vehiculo\n[4]producto\n[5]salir");
                opciones = Console.ReadLine();
                Console.ReadKey();
                switch (opciones)
                {
                    case "1": numeros();
                        break;
                    case "2": Intertar();
                        Console.ReadKey(); 
                        break;
                    case "3":
                        Vehiculo carro = new Vehiculo();
                        Console.Write("introduce la marca del vehiculo");
                        carro.marca= Console.ReadLine();
                        Console.Write("introduce el modelo del vehiculo");
                        carro.modelo = Console.ReadLine();
                        Console.Write("introduce el color del vehiculo");
                        carro.color = Console.ReadLine();
                        Console.Write("introduce el año del vehiculo ");
                        carro.año =int.Parse(Console.ReadLine());
                        break;
                    case "4": break;
                    case "5": break;
                    default:Console.Write("opciones invalidadas....");
                        Console.ReadKey();
                        break;
                        

                }
                

                
            } while (opciones != "5");

            
            
        }
    }
    class Vehiculo 
    { 
        public string marca { get; set; }
        public string modelo { get; set; }
        public  string color { get; set; }
        public  int año{ get; set; }

    }
    class Producto { }
}
