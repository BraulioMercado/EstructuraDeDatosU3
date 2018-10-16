using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3_2_InvestigarmétodosdelaclaseQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ban = true;
            do
            {
                try
                {
                    string opc;
                    Console.Clear();
                    Console.Write("Ingrese el numero del tipo de coleccion que desea usar. \n1-Pila(Stack: Estilo LIFO-último en entrar, primero en salir) \n2-Cola(Queue: Estilo FIFO-primero en entrar, primero en salir) \nNumero:"); //menu
                    opc = (Console.ReadLine());
                    if (opc == "1")
                    {
                        int valor = 0;
                        int NValores;
                        int buscar;

                        Console.Clear();
                        Stack miPila = new Stack(); // Creamos el stack(pila)

                        Console.Write("Cuantos valores desea agregar:"); //Ingresamos numero de valores que meteremos en la pila
                        NValores = int.Parse(Console.ReadLine());
                        for (int cont = 0; cont < NValores; cont++)  //for para ingresar el numero de elementos que se van a introducir
                        {
                            Console.Write("Ingrese el valor {0}: ", cont + 1);
                            miPila.Push(valor = int.Parse(Console.ReadLine())); //ingresamos valores en el stack
                        }

                        Console.Write("\nQue valor desea encontrar: ");
                        buscar = int.Parse(Console.ReadLine()); // Vemos si el elemento esta
                        Console.WriteLine("Encontrado - {0}", miPila.Contains(buscar)); //Se usa .contains ya que indica si un cierto elemento está en la pila.

                        Console.WriteLine("\nLa pila tiene {0} elementos", miPila.Count);
                        foreach (var item in miPila)
                        {
                            Console.WriteLine("{0} que es una variable tipo {1}", item, item.GetType()); //usamos .GetType para ver que tipo de variable son los valores de la pila
                        }
                        IEnumerator mover = miPila.GetEnumerator(); //usamos .GetEnumerator para crear un  enumerador para recorrer la pila.
                        mover.MoveNext(); //movemos el enumerador
                        mover.MoveNext(); //movemos el enumerador (si ponemos 5 valores en orden ascendente, el valor que nos arrojara sera el 3, ya que se movio 3 veces en la pila (5,4,3)
                        mover.MoveNext(); //movemos el enumarador
                        Console.WriteLine("\nAl movel el enumerador 3 veces, el valor que tenemos posicionado para este es {0}.", mover.Current); //usamos .Current para ver el valor en el que se quedo el enumerador

                        object[] miPilaArreglo = miPila.ToArray(); //transformamos la pila en un arreglo, para eso usamos .ToArray ya que devuelve toda la pila convertida en un array.

                        Console.WriteLine("\nImprimimos la pila convertida en Array");
                        foreach (int i in miPilaArreglo) //Imprimimos el arreglo convertido.
                        {
                            Console.Write("{0} ", i);
                        }


                        Console.WriteLine("\n\nImprimimos la pila pero con su variables convertidas en string, para luego usar el metodo .GetType y ver si se cambio.");
                        foreach (var item2 in miPila)
                        {
                            Console.WriteLine("{0} que es una variable tipo {1}", item2, item2.ToString().GetType());
                        }   //usamos.Tostring para convertir las variables de nuestra pila en string, y luego usamos .GetType para ver que si funciono 
                        Console.WriteLine("\nEl elemento mas antiguo es {0}.", miPila.Peek()); //.Peek devuelve el elemento mas antiguo sin eliminarlo.
                        miPila.Pop(); //se quita el ultimo elemento que introdujimos

                        Console.WriteLine("\nImprimimos la cola quitando el ultimo elemento introducido");
                        foreach (var item in miPila)
                        {
                            Console.WriteLine(item); //imprimimos otravez para ver que se elimino el ultimo valor ingresado.
                        }
                        Console.ReadKey();
                    }
                    else if (opc == "2")
                    {
                        int valor = 0;
                        int NValores;
                        int buscar;

                        Console.Clear();
                        Queue Cola = new Queue();
                        Console.Write("Cuantos valores desea agregar: "); //Ingresamos numero de valores que meteremos en la Cola
                        NValores = int.Parse(Console.ReadLine());
                        for (int cont = 0; cont < NValores; cont++)  //for para ingresar el numero de elementos que se van a introducir
                        {
                            Console.Write("Ingrese el valor {0}: ", cont + 1);
                            Cola.Enqueue(valor = int.Parse(Console.ReadLine())); //ingresamos valores en el Queue
                        }
                        Cola.TrimToSize(); // restringe la capacidad de la cola al número actual de elementos en la cola, si agregamos 5 valores a la cola, esta tendra una capacidad de 5, esto para reducir el gasto de memoria.
                                           //Esto se puede comprobar en listas con el metodo .Capacity, pero no esta implementado para su utilizacion en Queue.
                        Console.Write("\nQue valor desea encontrar: ");
                        buscar = int.Parse(Console.ReadLine()); // Vemos si el elemento esta
                        Console.WriteLine("Encontrado - {0}", Cola.Contains(buscar)); //Se usa .contains ya que indica si un cierto elemento está en la Cola.

                        Console.WriteLine("\nLa pila tiene {0} elementos", Cola.Count);
                        foreach (var item in Cola)
                        {
                            Console.WriteLine("{0} que es una variable tipo {1}", item, item.GetType()); //usamos .GetType para ver que tipo de variable son los valores de la Cola
                        }
                        IEnumerator mover = Cola.GetEnumerator(); //usamos .GetEnumerator para crear un  enumerador para recorrer la Cola
                        mover.MoveNext(); //movemos el enumerador
                        mover.MoveNext(); //movemos el enumerador (si ponemos 5 valores en orden ascendente, el valor que nos arrojara sera el 3, ya que se movio 3 veces en la Cola (1,2,3)
                        mover.MoveNext(); //movemos el enumarador
                        Console.WriteLine("\nAl movel el enumerador 3 veces, el valor que tenemos posicionado para este es {0}.", mover.Current); //usamos .Current para ver el valor en el que se quedo el enumerador

                        object[] miColaArreglo = Cola.ToArray(); //transformamos la cola en un arreglo, para eso usamos .ToArray ya que devuelve toda la cola convertida en un array.

                        Console.WriteLine("\nImprimimos la cola convertida en Array");
                        foreach (int i in miColaArreglo) //Imprimimos el arreglo convertido.
                        {
                            Console.Write("{0} ", i);
                        }

                        Console.WriteLine("\n\nImprimimos la pila pero con su variables convertidas en string, para luego usar el metodo .GetType y ver si se cambio.");
                        foreach (var item2 in Cola)
                        {
                            Console.WriteLine("{0} que es una variable tipo {1}", item2, item2.ToString().GetType());
                        }   //usamos.Tostring para convertir las variables de nuestra cola en string, y luego usamos .GetType para ver que si funciono 
                        Console.WriteLine("\nEl elemento mas antiguo es {0}.", Cola.Peek()); //.Peek devuelve el elemento mas antiguo sin eliminarlo.
                        Cola.Dequeue(); //se quita el primer elemento que introdujimos

                        Console.WriteLine("\nImprimimos la cola quitando el primer elemento introducido");
                        foreach (var item in Cola)
                        {
                            Console.WriteLine(item); //imprimimos otravez para ver que se elimino el primer valor
                        }
                        Console.WriteLine("\nComo vemos con este programa, los metodos que se pueden usar en la pila y la cola son los mismos a excepcion de que:");
                        Console.WriteLine("(Usado en Pilas)Push=Enqueue(Usado en Colas) \n(Usado en Pilas)Pop=Dequeue(Usado en Colas) \nEn colas tenemos otro metodo llamado TrimToSize \nTodos los demas metodos son los mismos.");
                        Console.ReadKey();
                        ban = false;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error!!-" + e.Message);
                    Console.ReadKey();
                }
            }
            while (ban == true);
            Console.ReadKey();
        }
    }
}
