using System;
namespace edu
{
	public class Empleado
    {
        //Atributos
        private string nombre;
        private int id;
        private float tasaSalarial;
        private int numMaxHoras;

        //Propiedades
        public string Nombre { get; set; }
        public int ID { get; set; }
        public float Salario { get; set; }
        public int Horas { get; set; }

        //Methods Constructores
        public Empleado(string nombre, int id, float tasaSalarial, int numMaxHoras) {
            Nombre = nombre;
            ID = id;
            Salario = tasaSalarial;
            Horas = numMaxHoras;
        }
	}
}

