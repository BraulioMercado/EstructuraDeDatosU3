using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace E3._3_BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode; //Se usa para que la consola pueda desplegar unicode (simbolos)
            Operaciones op = new Operaciones(); //Objeto de la clase Operaciones
            string opc;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("~~~Juego BlackJack 1-Jugador~~~");
                    Console.WriteLine("Juegos Ganados: {0} , Juegos Perdidos: {1}", op.Victorias, op.Perdidas); //Contador de Victorias y derrotas
                    op.Jugar(); //metodo jugar

                }
                catch (Exception e) //error
                {
                    Console.WriteLine("Error" + e.Message);
                }
                Console.Write("¿Desea jugar otra vez? Si=1 || No=Cualquier boton: ");
                opc = Console.ReadLine();
            }
            while (opc == "1");
            Console.ReadKey();
        }
    }
    public class Operaciones
    {
        int victorias, perdidas; //auxiliar de la propiedades victorias y perdidas
        public int Victorias { get { return victorias; } set { victorias = value; } }
        public int Perdidas { get { return perdidas; } set { perdidas = value; } }
        public List<Carta> CrearCartas() //Lista que contiene la clase carta y donde se generan las cartas
        {
            List<Carta> cartas = new List<Carta>(); //Una segunda lista donde se guardaran todas las cartas
            Carta carta = new Carta();
            for (int i = 0; i < 10; i++) //for para generar del 1 al 10
            {
                carta = new Carta(); //se usa para poder usar las propiedades
                carta.Id = i + 1;
                carta.Numero = Convert.ToString(i + 1);
                carta.figura = "♥";
                carta.Valor = i + 1;
                cartas.Add(carta); //guardamamos en la lista
            }
            for (int i = 0; i < 10; i++)
            {
                carta = new Carta();
                carta.Id = i + 11;
                carta.Numero = Convert.ToString(i + 1);
                carta.figura = "♦";
                carta.Valor = i + 1;
                cartas.Add(carta); //guardamamos en la lista
            }
            for (int i = 0; i < 10; i++)
            {
                carta = new Carta(); //se usa para poder usar las propiedades
                carta.Id = i + 21;
                carta.Numero = Convert.ToString(i + 1);
                carta.figura = "♠";
                carta.Valor = i + 1;
                cartas.Add(carta); //guardamamos en la lista
            }
            for (int i = 0; i < 10; i++)
            {
                carta = new Carta(); //se usa para poder usar las propiedades
                carta.Id = i + 31;
                carta.Numero = Convert.ToString(i + 1);
                carta.figura = "♣";
                carta.Valor = i + 1;
                cartas.Add(carta); //guardamamos en la lista
            }
            carta.Id = 41; //de aqui en adelante se generan todas las letras con sus puntos
            carta.Numero = "J";
            carta.figura = "♣";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 42;
            carta.Numero = "Q";
            carta.figura = "♣";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 43;
            carta.Numero = "K";
            carta.figura = "♣";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 44;
            carta.Numero = "J";
            carta.figura = "♠";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 45;
            carta.Numero = "Q";
            carta.figura = "♠";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 46;
            carta.Numero = "K";
            carta.figura = "♠";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 47;
            carta.Numero = "J";
            carta.figura = "♦";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 48;
            carta.Numero = "Q";
            carta.figura = "♦";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 49;
            carta.Numero = "K";
            carta.figura = "♦";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 50;
            carta.Numero = "J";
            carta.figura = "♥";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 51;
            carta.Numero = "Q";
            carta.figura = "♥";
            carta.Valor = 10;
            cartas.Add(carta);
            carta.Id = 52;
            carta.Numero = "K";
            carta.figura = "♥";
            carta.Valor = 10;
            cartas.Add(carta);

            return cartas; //devolvemos la lista con todas las cartas
        }
        private Stack<Carta> Revolver() //pila para almacenar la baraja revuelta
        {
            List<Carta> MazoNuevo = CrearCartas(); //lista auxiliar ligada a la clase
            Stack<Carta> CartasRandom = new Stack<Carta>(); //se almacenan aqui la baraja revuelta 
            Random rnd = new Random(); //Objeto Random
            int Random;
            for (int Indice = 0; Indice < 52; Indice++) //cantidad de cartas
            {
                Random = rnd.Next(MazoNuevo.Count); //igualamos al tamaño de la lista
                CartasRandom.Push(MazoNuevo[Random]); //agrega a la pila el elemento seleccionado
                MazoNuevo.RemoveAt(Random); //se elimina de la lista de Mazo Nuevo
            }
            return CartasRandom; //regresa a la pila el elemento
        }
        public void Jugar() //metodo donde se ejecutara todo el juego
        {
            Stack<Carta> Cartas = Revolver(); //llamamos a la pila
            int Puntos = 0;
            bool condicion = true;
            int CartasSacadas = 1; //se inicia en 1 contando la primera vez

            Carta Carta = Cartas.Pop();//Se quita la carta seleccionada de la Pila
            Puntos = Carta.Valor + Puntos;//a la variable puntos se le suma el valor de la carta
            Console.WriteLine("\nCarta {0} es: {1}\tPuntos:{2}", CartasSacadas, Carta.Numero + Carta.figura, Puntos);
            ++CartasSacadas;//Contador cartas Sacadas +1

            Carta Carta2 = Cartas.Pop();//Se quita la carta seleccionada de la Pila
            Puntos = Carta2.Valor + Puntos;//a la variable puntos se le suma el valor de la carta
            Console.WriteLine("\nCarta {0} es: {1}\tPuntos:{2}", CartasSacadas, Carta2.Numero + Carta2.figura, Puntos);
            do
            {
                if (CartasSacadas >= 5 || Puntos > 21 || Puntos == 21) //condiciones para que siga el juego
                {
                    condicion = false; //se acaba el do
                }
                else //si no cumple las condiciones anteriores se pide una carta mas
                {
                    Console.Write("\n1) Hit o 2) Stay: ");
                    string opcion = Console.ReadLine();

                    switch (opcion)
                    {
                        case "1": //si desea añadir otra mas
                            Carta CartaExtra = Cartas.Pop();//cartaExtra
                            ++CartasSacadas;//Contador cartas Sacadas +1

                            Puntos = CartaExtra.Valor + Puntos;//a la variable puntos se le suma el valor de la carta
                            Console.WriteLine("\nCarta {0} es: {1}\tPuntos:{2}", CartasSacadas, CartaExtra.Numero + CartaExtra.figura, Puntos); //imprimimos

                            Console.WriteLine("\nLa suma es de: {0} ", Puntos);
                            // se calcula la suma de puntos al momento
                            break;
                        case "2": //si ya no quiere añadir mas
                            condicion = false;
                            break;
                        default:
                            Console.WriteLine("ERROR");
                            break;
                    }
                }
            }
            while (condicion == true);
            if (CartasSacadas < 6)//Si las cartas sacadas son menor que 6
            {
                if (Puntos == 21)//Si los puntos son igual a 21 Gana
                {
                    Console.WriteLine("\nFelicidades has ganado!!!");
                    Victorias++;//Contador +1
                    Console.ReadKey(true);
                }
                else if (CartasSacadas == 5 && Puntos < 21) //si no se paso de 21 y tiene 5 cartas gana
                {
                    Console.WriteLine("\n Sacaste 5 cartas y no te pasaste. Felicidades has ganado!!!");
                    Victorias++;// Contador +1
                    Console.ReadKey(true);
                }
                else if (Puntos > 21) //si se paso de 21 pierde
                {
                    Console.WriteLine("Has perdido");
                    Perdidas++;// Contador +1
                    Console.ReadKey(true);
                }
            }
            else
            {
                Console.WriteLine("Has Perdido"); //cualquier otro, pierde
                Perdidas++;// Contador +1
                Console.ReadKey(true);
            }
        }
    }
    public class Carta //clase para las propiedades
    {
        public int Id { get; set; }
        public string figura { get; set; } //propiedad figura
        public string Numero { get; set; } //propiedad Numero
        private int valor;
        public int Valor { get { return valor; } set { valor = value; } } //propiedad valor que recibe y devuelve un valor
    }
}