using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E.C._MercadoSalazarBraulioFabian
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int NValores;
            int buscar;

            Stack miPila = new Stack(); // Creamos el stack(pila)

            Console.WriteLine("Cuantos valores desea agregar:"); //Ingresamos numero de valores que meteremos en la pila
            NValores = int.Parse(Console.ReadLine());
            for (int cont = 0; cont < NValores; cont++)  //for para ingresar el numero de elementos que se van a introducir
            {
                Console.WriteLine("Ingrese el valor {0}: ", cont + 1);
                miPila.Push(valor = int.Parse(Console.ReadLine())); //ingresamos valores en el stack
            }

            Console.WriteLine("Que valor desea encontrar: ");
            buscar = int.Parse(Console.ReadLine()); // Vemos si el elemento esta
            Console.WriteLine("Encontrado - {0}", miPila.Contains(buscar)); //Se usa .contains ya que indica si un cierto elemento está en la pila.

            Console.WriteLine("La pila tiene {0} elementos", miPila.Count); 
            foreach (var item in miPila)
            {
                Console.WriteLine("{0} que es una variable tipo {1}", item, item.GetType()); //usamos .GetType para ver que tipo de variable son los valores de la pila
            }
            IEnumerator mover = miPila.GetEnumerator(); //usamos .GetEnumerator para crear un  enumerador para recorrer la pila.
            mover.MoveNext(); //movemos el enumerador
            mover.MoveNext(); //movemos el enumerador (si ponemos 5 valores en orden ascendente, el valor que nos arrojara sera el 3, ya que se movio 3 veces en la pila (5,4,3)
            mover.MoveNext(); //movemos el enumarador
            Console.WriteLine(mover.Current); //usamos .Current para ver el valor en el que se quedo el enumerador

            object[] miPilaArreglo = miPila.ToArray(); //transformamos la pila en un arreglo, para eso usamos .ToArray ya que devuelve toda la pila convertida en un array.

            foreach (int i in miPilaArreglo) //Imprimimos el arreglo convertido.
            {
                Console.Write("{0} ", i);
            }

            Console.WriteLine();

            foreach (var item2 in miPila)
            {
                Console.WriteLine("{0} que es una variable tipo {1}", item2, item2.ToString().GetType());
            }   //usamos.Tostring para convertir las variables de nuestra pila en string, y luego usamos .GetType para ver que si funciono
            Console.ReadKey();
        }
    }
}