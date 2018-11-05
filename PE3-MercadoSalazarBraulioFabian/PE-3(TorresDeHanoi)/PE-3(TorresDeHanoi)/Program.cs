using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3_TorresDeHanoi_
{
    class Hanoi
    {
        Stack<int> pila1 = new Stack<int>(); //creamos los 3 palos
        Stack<int> pila2 = new Stack<int>();
        Stack<int> pila3 = new Stack<int>();
        public int n;
        public int contador = 0;
        public Hanoi(int n) //recibimos el valor de n de la otra clase
        {
            this.n = n;
        }
        public void Discos() //generamos discos
        {
            for (int i = 1; i <= n; i++)
            {
                pila1.Push(i);
            }
        }

        public void Resolver() //usamos este metodo para poder llamarlo desde la otra clase, porque si llamamos movimientos directamente, las pilas no estan declaradas en la otra clase.
        {
            Imprimir();
            Movimientos(n, pila1, pila2, pila3);
        }

        public void Movimientos(int n, Stack<int> pila1, Stack<int> pila2, Stack<int> pila3) //donde se hace todo el algoritmo para los movimientos necesarios
        {
            if (n == 1)
            {
                pila2.Push(pila1.Pop());
                Imprimir();
                contador++;
                return;
            }
            else
            {
                Movimientos(n - 1, pila1, pila3, pila2);

                pila2.Push(pila1.Pop());
                Imprimir();
                contador++;
                Movimientos(n - 1, pila3, pila2, pila1);
            }
        }

        public void Imprimir()
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
            Stack<int>[] PilasJuntas = new Stack<int>[] { pila1, pila3, pila2 }; //creamos un stack como vector con los 3 palos
            for (int i = 0; i < 3; i++) //for para indicar que son 3 palos, por ende 3 renglones
            {
                foreach (var item in PilasJuntas[i])
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            int n;
            Console.Write("Ingrese numero de discos: "); //ingresamos numero de discos
            n = int.Parse(Console.ReadLine());

            Console.Clear();

            Hanoi hanoi = new Hanoi(n); //mandamos el valor de n a la otra clase y tambien llamamos a la clase
            hanoi.Discos(); //metodo de añadir discos
            hanoi.Resolver(); //metodo donde se hace todo el proceso
            Console.WriteLine("Numero de movimientos:{0}", hanoi.contador); //contador para ver cuantos movimientos

            Console.ReadKey();
        }
    }
}