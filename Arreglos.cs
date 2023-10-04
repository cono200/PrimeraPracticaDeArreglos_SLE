using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraPracticaDeArreglos_SLE
{
    internal class Arreglos
    {

        public void PrimerEjercicio()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);
            Console.WriteLine(a[3]);
            Console.WriteLine(a[4]);


        }



        public void SegundoEjercicio()
        {
            int[] b = new int[5];

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Escribe el  numero");
                b[i] = Convert.ToInt32(Console.ReadLine());



            }

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Los numeros son  " + b[i]);
            }

        }


        public void TercerEjercicio()
        {
            int[] b = new int[10];

            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine("Escribe los   numero");
                b[i] = Convert.ToInt32(Console.ReadLine());



            }
            int suma = 0;
            for (int i = 0; i < b.Length; i++)
            {
                suma += b[i];
            }
            int promedio = suma / b.Length;
            Console.WriteLine("El promedio es  " + promedio);
        }


        public void CuatroEjercicio()
        {
            Console.WriteLine("Que longitud quieres");
            int longitud = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introducce con cual multiplo kieres");
            int multiplo = Convert.ToInt32(Console.ReadLine());

            int[] b = new int[longitud];

            for (int i = 0; i < longitud; i++)
            {
                b[i] = multiplo * (i + 1);


            }

            for (int i = 0; i < longitud; i++)
            {
                Console.WriteLine(b[i]);
            }




        }


        public void QuintoEjercicio()
        {
            Console.WriteLine("De que longitud quieres mi rey");
            int longitudNombres = Convert.ToInt32(Console.ReadLine());
            string[] nombres =  new string[longitudNombres];
            int[] nombresLongitud = new int[longitudNombres];

            for (int i = 0; i < longitudNombres; i++)
            {
                Console.WriteLine("Escribe el nombre");
                nombres[i] = Convert.ToString(Console.ReadLine());
                nombresLongitud[i] = nombres[i].Length;
            }

            for (int i = 0; i < longitudNombres; i++)
            {
                Console.WriteLine("Los nombres son  " + nombres[i]);

            }

            for (int i = 0; i < nombresLongitud.Length; i++)
            {
                Console.WriteLine(nombresLongitud[i]);
            }



            


        }

        

    }
}
