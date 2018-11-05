using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_3_Vacas_
{
    class Program
    {
        static void Main(string[] args)
        {
            Procedimiento op = new Procedimiento(); //lamamos a la otra clase
            op.Proceso();
        }
    }
    public class Procedimiento
    {
        List<string> lista1 = new List<string>(); //cremamos listas de los lados
        List<string> lista2 = new List<string>();

        public void Proceso()
        {
            lista1.Add("Mazie");
            lista1.Add("Daisy");
            lista1.Add("Crazy"); //agregamos a las vaquitas
            lista1.Add("Lazy");

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            int suma2 = 0;
            Console.WriteLine("TIEMPO: {0} ", suma2); //tiempo
            foreach (var item in lista1)
            {
                Console.WriteLine(item);
            }
            lista1.Remove("Mazie");
            lista1.Remove("Daisy"); //quitamos vacas del lado 1 y las ponemos en el lado 2
            lista2.Add("Mazie");
            lista2.Add("Daisy");
            suma2 += 4; //sumamos 4 al tiempo

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("TIEMPO: {0} ", suma2);
            foreach (var item in lista1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n~~~Puente 2~~~\n");
            foreach (var item in lista2)
            {

                Console.WriteLine(item);
            }
            lista2.Remove("Mazie"); //quitamos vacas del lado 1 y las ponemos en el lado 2
            lista1.Add("Mazie");
            suma2 += 2;//sumamos 2 al tiempo

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("TIEMPO: {0} ", suma2);
            foreach (var item in lista1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n~~~Puente 2~~~\n");
            foreach (var item in lista2)
            {

                Console.WriteLine(item);
            }
            lista1.Remove("Crazy"); //quitamos vacas del lado 1 y las ponemos en el lado 2
            lista1.Remove("Lazy");
            lista2.Add("Crazy");
            lista2.Add("Lazy");
            suma2 += 20; //sumamos 20 al tiempo

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("-TIEMPO: {0} ", suma2);
            foreach (var item in lista1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n~~~Puente 2~~~\n");
            foreach (var item in lista2)
            {

                Console.WriteLine(item);
            }
            lista2.Remove("Daisy");//quitamos vacas del lado 1 y las ponemos en el lado 2
            lista1.Add("Daisy");
            suma2 += 4; //sumamos 4 al tiempo

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("TIEMPO: {0} ", suma2);
            foreach (var item in lista1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n~~~Puente 2~~~\n");
            foreach (var item in lista2)
            {

                Console.WriteLine(item);
            }
            lista1.Remove("Mazie");
            lista1.Remove("Daisy"); //quitamos vacas del lado 1 y las ponemos en el lado 2
            lista2.Add("Mazie");
            lista2.Add("Daisy");
            suma2 += 4; //sumamos 4 al tiempo

            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.Write("TIEMPO: {0} ", suma2);
            foreach (var item in lista1)
            {
                Console.WriteLine(item); //imprimimos la lista del lado1
            }
            Console.WriteLine("\n~~~Puente 2~~~\n");
            foreach (var item in lista2)
            {

                Console.WriteLine(item); //Imprimimos la lista del lado2
            }
            Console.ReadKey();
        }
    }
}
