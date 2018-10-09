using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_1MejorandoLaClase
{
    public class Universidad
    {
        public void Capturar()
        {
            ArrayList NombreClases = new ArrayList(); //lista para el nombre de la clase
            ArrayList Alumnos = new ArrayList(); //lista para el numero de alumnos
            ArrayList Calif = new ArrayList(); //lista para almacenar las calificaciones de los alumnos

            int Nclases, Nalumnos, Cont, Cont2, calif;
            int calificacion = 0;
            Console.Write("Ingrese Numero de clases: "); //numero de clase
            Nclases = int.Parse(Console.ReadLine());

            for (int i = 0; i < Nclases; i++)  //for para ingresar el nombre de la clase
            {
                Console.WriteLine("Ingrese el nombre de la clase {0}: ", i + 1);
                NombreClases.Add(Console.ReadLine()); //se almacena el nombre de la clase en la lista
            }
            for (Cont = 0; Cont < Nclases; Cont++)  //for para el numero de alumnos por clase
            {
                Console.Write("Clase {0}- ", Cont + 1);
                Console.Write("Ingrese numero de alumnos de esta clase: ");
                Nalumnos = int.Parse(Console.ReadLine());
                Alumnos.Add(Nalumnos); //se almacenan el la lista de alumnos
                for (Cont2 = 0; Cont2 < Nalumnos; Cont2++) //for para las calificaciones de cada alumno
                {
                    Console.Write("Alumno {0}: ", Cont2 + 1);
                    calif = int.Parse(Console.ReadLine());
                    Calif.Add(calif); //se almacenan las calificaciones de cada alumno en la lista
                }
            }
            foreach (object Item in NombreClases) //foreach para imprimir datos
            {
                Console.WriteLine(Item + ":");
                for (int contador = 0; contador < Convert.ToInt16(Alumnos.ToArray().ElementAt(NombreClases.IndexOf(Item))); contador++) //se llama a la clase
                {
                    Console.WriteLine("Alumno {0}: {1}", contador + 1, Calif.ToArray().ElementAt(calificacion)); //se llama a los alumnos y sus calif
                    calificacion++;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool ban = true;
            do
            {
                try
                {
                    Universidad obj = new Universidad(); //objeto de la clase 
                    obj.Capturar();
                    Console.ReadKey();
                    ban = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!!!" + e.Message); //exception
                } 
            } while (ban==true);
            Console.ReadKey();
        }
    }
}
