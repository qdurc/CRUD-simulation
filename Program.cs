using System;
using edu;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Empleado> empleados = new List<Empleado>();

        while (true)
        {
            Console.WriteLine("------Bienvenido al menú de INTEC------");
            Console.WriteLine("Opcion 1: Agregar un empleado");
            Console.WriteLine("Opcion 2: Modificar los datos del empleado");
            Console.WriteLine("Opcion 3: Eliminar a un empleado");
            Console.WriteLine("Opcion 4: Mostrar Empleados");
            Console.WriteLine("Opcion 5: Cerrar menu");

            Console.Write("Cual es tu opcion? ");
            int ans = int.Parse(Console.ReadLine());

            if (ans == 1)
            {
                Console.WriteLine("\nDatos del empleado");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Salario: ");
                float tasaSalarial = float.Parse(Console.ReadLine());

                Console.Write("Horas: ");
                int numMaxHoras = int.Parse(Console.ReadLine());

                Empleado nuevoEmpleado = new Empleado(nombre, id, tasaSalarial, numMaxHoras);
                empleados.Add(nuevoEmpleado);

                Console.WriteLine("Empleado agregado correctamente!!\n");
            }

            else if (ans == 2)
            {
                Console.Write("ID de empleado a modificar: ");
                int id = int.Parse(Console.ReadLine());

                Empleado empleado = null;
                foreach (Empleado emp in empleados)
                {
                    if (emp.ID == id)
                    {
                        empleado = emp;
                        break;
                    }
                }

                if (empleado != null)
                {
                    Console.WriteLine("\nDatos actuales del empleado:");
                    Console.WriteLine(
                        "Nombre: " + empleado.Nombre + "\n"
                        + "ID: " + empleado.ID + "\n" +
                        "Salario: " + empleado.Salario + "\n" +
                        "Horas: " + empleado.Horas + "\n");

                    Console.WriteLine("Ingrese los nuevos datos para el empleado:");
                    Console.Write("Nombre nuevo: ");
                    string nombre = Console.ReadLine();

                    Console.Write("ID nuevo: ");
                    int idAct = int.Parse(Console.ReadLine());

                    Console.Write("Salario nuevo: ");
                    float tasaSalarial = float.Parse(Console.ReadLine());

                    Console.Write("Horas nuevas: ");
                    int numMaxHoras = int.Parse(Console.ReadLine());

                    empleado.Nombre = nombre;
                    empleado.ID = idAct;
                    empleado.Salario = tasaSalarial;
                    empleado.Horas = numMaxHoras;

                    Console.WriteLine("Datos actualizados correctamente!!\n");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún empleado con el ID ingresado.\n");
                }
            }

            else if (ans == 3)
            {
                Console.Write("\nID de empleado a eliminar: ");
                int idDel = int.Parse(Console.ReadLine());

                Empleado empleado = null;
                foreach (Empleado emp in empleados)
                {
                    if (emp.ID == idDel)
                    {
                        empleado = emp;
                        break;
                    }
                }

                if (empleado != null)
                {
                    empleados.Remove(empleado);
                    Console.WriteLine("Empleado elimiado correctamente!!\n");
                }
                else
                {
                    Console.WriteLine("No se encontró ningún empleado con el ID ingresado.\n");
                }
            }

            else if (ans == 4)
            {
                if (empleados.Count == 0)
                {
                    Console.WriteLine("La lista de empleados está vacía.\n");
                }
                else
                {
                    Console.WriteLine("Su lista de Empleados es: ");
                    foreach (Empleado empleado in empleados)
                    {
                        Console.WriteLine(
                            "\n" +
                            "Nombre: " + empleado.Nombre + "\n" +
                            "ID: " + empleado.ID + "\n" +
                            "Salario: " + empleado.Salario + "\n" +
                            "Horas: " + empleado.Horas + "\n");
                    }
                }
            }

            else if (ans == 5)
            {
                Console.Write("\nCerrando menu...");
                break;
            }

            else
            {
                Console.WriteLine("Valor fuera de rango\n");
            }
        }
        Console.ReadKey();
    }
}