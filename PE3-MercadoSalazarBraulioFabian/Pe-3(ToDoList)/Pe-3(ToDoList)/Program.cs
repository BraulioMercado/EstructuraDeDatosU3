using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pe_3_ToDoList_
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ban = true;
            ToDoList op = new ToDoList(); //lamamos a la clase TODOLIST
            do
            {
                Console.Clear();
                Console.Write("Ingrese la accion que desea realizar 1.Agregar tarea 2.Iniciar tarea 3.Terminar tarea 4.Ver Tareas 5.Salir: "); //menu
                int opc = int.Parse(Console.ReadLine());

                switch (opc) //llamamos a los diferentes metodos
                {
                    case 1:
                        op.Agregar(); 
                        break;
                    case 2:
                        op.IniciarTarea(); 
                        break;
                    case 3:
                        op.TerminarTarea(); 
                        break;
                    case 4:
                        op.VerTareas(); 
                        break;
                    case 5:
                        ban = false;
                        break;
                }
            } while (ban==true);
        }
    }
    class ToDoList
    { //listas dependiendo del status de la tarea
        List<Propiedades> TareasGlobal = new List<Propiedades>(); 
        List<Propiedades> TareasPendiente = new List<Propiedades>();
        List<Propiedades> TareasProceso = new List<Propiedades>();
        List<Propiedades> TareasTerminada = new List<Propiedades>();
        int id = 0;

        public void Agregar() //metodo donde agregaremos las tareas
        {
            Propiedades tareitas = new Propiedades();
            id++; //contador para el id
            tareitas.Id = id;
            Console.Write("Ingresar Nombre: "); 
            tareitas.Nombre = Console.ReadLine();
            Console.Write("Ingresar descripcion: "); //ingreamos datos de la tarea
            tareitas.Descripcion = Console.ReadLine();
            Console.Write("Ingresar fecha de inicio: ");
            tareitas.FechaInicio = Console.ReadLine();
            TareasPendiente.Add(tareitas);
            TareasGlobal.Add(tareitas);
        }
        public void IniciarTarea()
        {
            string tareaelegida;
            Console.WriteLine("Tareas Disponibles: "); //tarea disponibles
            foreach (Propiedades item in TareasPendiente)
            {
                Console.WriteLine("ID: " + item.Id);
                Console.WriteLine("Nombre: " + item.Nombre); //datos de las tareas disponibles
            }
            Console.Write("Ingrese el nombre de la tarea a inciar");
            tareaelegida = Console.ReadLine();

            var selec = (from c in TareasPendiente
                         where c.Nombre == tareaelegida //linq para buscar el nombre de una tarea
                         select c).ToList();

            foreach (var item in selec) 
            {
                TareasProceso.Add(item); //la agregamos a tareas en proceso
                TareasPendiente.Remove(item); //la quitamos de tareas pendientes
            }
            selec.Clear();
        }

        public void TerminarTarea()
        {
            string tareaelegida;
            string fecha;
            Console.WriteLine("Tareas Disponibles: "); //tareas disponibles
            foreach (Propiedades item in TareasProceso)
            {
                Console.WriteLine("ID: " + item.Id);
                Console.WriteLine("Nombre: " + item.Nombre);
            }
            Console.Write("Ingrese el nombre de la tarea para finalizar"); //Ingresamos el nombre a buscar
            tareaelegida = Console.ReadLine();

            var selec = (from c in TareasProceso
                         where c.Nombre == tareaelegida //Linq
                         select c).ToList();

            foreach (var item in selec)
            {
                Console.Write("Ingresar fecha actual:"); //ingresamos la fecha de cuando se termino
                fecha = Console.ReadLine();
                item.FechaFin = fecha;
                TareasTerminada.Add(item);
                TareasProceso.Remove(item);
            }           
        }
        public void VerTareas()
        {
            int opc;
            Console.Write("Ingrese numero de la lista que desea ver: 1.- Globales 2.- Pendientes 3.- En Proceso 4.-Terminadas: "); //menu para ver las listas
            opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    foreach (var item in TareasGlobal) //imprimimos todas las tareas
                    {
                        Console.WriteLine("Id: {0} ", item.Id);
                        Console.WriteLine("Nombre: {0}", item.Nombre);
                        Console.WriteLine("Descripcion: {0}", item.Descripcion);
                        Console.WriteLine("Fecha inicial: {0}", item.FechaInicio);
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    foreach (var item in TareasPendiente) //imprimimos tareas pendientes
                    {
                        Console.WriteLine("Id: {0} ", item.Id);
                        Console.WriteLine("Nombre: {0}", item.Nombre);
                        Console.WriteLine("Descripcion: {0}", item.Descripcion);
                        Console.WriteLine("Fecha inicial: {0}", item.FechaInicio);
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    foreach (var item in TareasProceso) //imprimimos tareas en proceso
                    {
                        Console.WriteLine("Id: {0} ", item.Id);
                        Console.WriteLine("Nombre: {0}", item.Nombre);
                        Console.WriteLine("Descripcion: {0}", item.Descripcion);
                        Console.WriteLine("Fecha inicial: {0}", item.FechaInicio);
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    foreach (var item in TareasTerminada) //imprimimos tareas terminadas
                    {
                        Console.WriteLine("Id: {0} ", item.Id);
                        Console.WriteLine("Nombre: {0}", item.Nombre);
                        Console.WriteLine("Descripcion: {0}",item.Descripcion);
                        Console.WriteLine("Fecha inicial: {0}",item.FechaInicio);
                        Console.WriteLine("Fecha final: {0}", item.FechaFin);
                    }
                    Console.ReadKey();
                    break;
            }
        }
    }
    class Propiedades //propiedades del objeto 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string FechaInicio { get; set; }
        public string FechaFin { get; set; }
    }
}
