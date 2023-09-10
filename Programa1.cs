using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Programa1
    {

        public static void Main(String[] args)
        {

            //inmuearble 
            int id, area, precio, direccion;


            //Vivienda
            int numeroHabitaciones, numerosbaños, opciones, opciones1;

            // Casa
            int numeroPiso, tipoCasa;
            // rual
            int valorArea, altura, distanciaCabecera;


            Inmueble inmueble = new Inmueble();
            Console.Write("Ingrese el idMobiliario: ");
            id = Convert.ToInt32(Console.Read());
            Console.Write("Ingrese el area: ");
            area = Convert.ToInt32(Console.Read());
            Console.Write("Ingrese el precio de venta: ");
            precio = Convert.ToInt32(Console.Read());
            Convert.ToInt32(precio);
            Console.Write("Ingrese la direccion: ");
            direccion = Convert.ToInt32(Console.Read());

            while (true)
            {
                Console.Write("Ingrese 1) casa o 2) apartameno: ");
                int opcion = Convert.ToInt32(Console.Read());

                if (opcion == 1)
                {
                    Console.Write("Ingrese el numero de piso: ");
                    numeroPiso = Convert.ToInt32(Console.Read());

                    Console.Write("Tipo de casa 1) rural 2) Urbana: ");
                    tipoCasa = Convert.ToInt32(Console.Read());




                }
                else if (opcion == 2)
                {

                }
                else
                {
                    Console.WriteLine("F");
                }
            }





        }

    }
}
