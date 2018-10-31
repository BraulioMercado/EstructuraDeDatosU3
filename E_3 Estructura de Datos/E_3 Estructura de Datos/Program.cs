using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Diagnostics;

namespace E_3_Estructura_de_Datos
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            do
            {
                try
                {
                    Console.Clear();
                    Operacion op = new Operacion();
                    int opc;
                    Console.Write("Ingrese el numero de ejercicio que desea ejecutar (1,2,3,4): ");
                    opc = int.Parse(Console.ReadLine());
                    switch (opc)
                    {
                        case 1:
                            {
                                op.Ejercicio1();
                                Console.ReadKey();
                                break;
                            }
                        case 2:
                            {
                                op.Ejercicio2();
                                Console.ReadKey();
                                break;
                            }
                        case 3:
                            {
                                op.Ejercicio3();
                                Console.ReadKey();
                                break;
                            }
                        case 4:
                            {
                                op.Ejercicio4();
                                Console.ReadKey();
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Error");
                                break;
                            }
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error" + e.Message);
                }
                Console.Write("¿Desea repetir el programa? Si=1 || No=Cualquier boton: ");
                opcion = Console.ReadLine();
            }
            while (opcion == "1");
            Console.ReadKey();
        }
    }
    public class Operacion
    {
        public void Ejercicio1()
        {
            Stack Lista = new Stack();
            Lista.Push(5);
            Lista.Push(3);
            Lista.Pop();
            Lista.Push(2);
            Lista.Push(8);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(9);
            Lista.Push(1);
            Lista.Pop();
            Lista.Push(7);
            Lista.Push(6);
            Lista.Pop();
            Lista.Pop();
            Lista.Push(4);
            Lista.Pop();
            Lista.Pop();

            Console.WriteLine("\nLa pila tiene {0} elementos", Lista.Count);
            foreach (var item in Lista)
            {
                Console.WriteLine("La lista tiene estos elementos:\n" + item);
            }
        }

        public void Ejercicio2()
        {
            //Escriba en este metodo un modulo que pueda leer  y almacenar palabras reservadas en una lista enlazada 
            //e identificadores y literales en Otra lista enlazada.
            //Cuando el programa haya terminado de leer la entrada, mostrar
            //Los contenidos de cada lista enlazada.
            //Revise que es un Identificador y que es un literal

            int Npalabras;
            Console.Write("Ingrese numero de palabras: ");
            Npalabras = int.Parse(Console.ReadLine());

            LinkedList<string> Reservadas = new LinkedList<string>();
            LinkedList<string> IdentificadoresYLiterales = new LinkedList<string>();

            string[] valoresKeyWord = new string[107] {"abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked","class", "const",
                                               "continue",  "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit",
                                               "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit",
                                                "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null",
                                                "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref",
                                                "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch",
                                                "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort",
                                                "using", "using", "static", "virtual", "void", "volatile", "while", "add", "alias", "ascending", "async",
                                                "await", "by", "descending", "dynamic", "equals", "from", "get", "global", "groupo", "into", "join", "let",
                                                "nameof", "on", "orderby", "partial", "remove", "select", "set", "value", "var", "when", "where", "yield"};

            for (int contador = 0; contador < Npalabras; contador++)
            {
                Console.Write("Ingrese la palabra: ");
                string palabra = Console.ReadLine();
                if (valoresKeyWord.Contains(palabra))
                {
                    Reservadas.AddFirst(palabra);
                }
                else
                {
                    IdentificadoresYLiterales.AddFirst(palabra);
                }
            }
            Console.WriteLine("\nReservadas: ");
            foreach (var item in Reservadas)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nIdentificadores y literales: ");
            foreach (var item in IdentificadoresYLiterales)
            {
                Console.WriteLine(item);
            }
        }
        public void Ejercicio3()
        {
            const int max = 9876;

            LinkedList<string> Lista = new LinkedList<string>();

            for (int i = 0; i < max; i++)
            {
                Lista.AddFirst("Okey");
            }

            List<string> lista = new List<string>();
            LinkedList<string> listaligada = new LinkedList<string>();

            for (int i = 0; i < max; i++)
            {
                lista.Add("Okey");
                listaligada.AddLast("Okey");
            }
            var m1 = Stopwatch.StartNew();

            for (int i = 0; i < max; i++)
            {
                foreach (string item in lista)
                {
                    if (item.Length != 4)
                    {
                        throw new Exception();
                    }
                }
            }

            m1.Stop();

            var m2 = Stopwatch.StartNew();

            for (int i = 0; i < max; i++)
            {
                foreach (string item in listaligada)
                {
                    if (item.Length != 4)
                    {
                        throw new Exception();
                    }


                }
            }

            m2.Stop();

            Console.WriteLine("Lista: " + ((double)(m1.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));
            Console.WriteLine("Lista ligada: " + ((double)(m2.Elapsed.TotalMilliseconds * 1000000) / max).ToString("0.00 ns"));

        }

        public void Ejercicio4()
        {

            // Diseñar e implementar una clase que le permita a un maestro hacer un seguimiento de las calificaciones
            // en un solo curso.Incluir métodos que calculen la nota media, la
            //calificacion más alto, y el calificacion más bajo. Escribe un programa para poner a prueba tu clase.
            //implementación. Minimo 30 Calificaciones, de 30 alumnos.

            Console.Write("Ingrese cantidad de alumnos: ");
            int cantidad = int.Parse(Console.ReadLine());
            Clase datos;
            List<Clase> alumnos = new List<Clase>();
            for (int i = 0; i < cantidad; i++)
            {
                datos = new Clase();
                datos.Maestro = "Paco";
                datos.NombreClase = "Aprender a Hackear";
                datos.Alumno = i + 1;
                Console.Write("Asignar calificacion del alumno {0}: ", i + 1);
                datos.Calificacion = int.Parse(Console.ReadLine());
                alumnos.Add(datos);
            }
            Console.WriteLine("Lista de Alumnos");
            foreach (var item in alumnos)
            {
                Console.WriteLine("Materia: " + item.NombreClase + "/Maestro: " + item.Maestro + "/La calificacion del alumno" + item.Alumno + " es: " + item.Calificacion);
            }
            int maximo = alumnos.Max(x => x.Calificacion);
            Console.WriteLine("La calificacion mayor es:" + maximo);
            int minimo = alumnos.Min(x => x.Calificacion);
            Console.WriteLine("La calificacion menor es:" + minimo);
            var promedio = alumnos.Average(b => b.Calificacion);
            Console.WriteLine("Promedio es: " + promedio);
        }
    }
    public class Clase
    {
        public string Maestro { get; set; }
        public int Alumno { get; set; }
        public string NombreClase { get; set; }
        public int Calificacion { get; set; }
    }
}