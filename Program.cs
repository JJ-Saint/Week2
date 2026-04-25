using System;
using System.Collections.Generic;
using System.Linq;

namespace ClinicaVeterinaria
{
    class Program
    {
        static void Main()
        {
            List<Paciente> pacientes = new List<Paciente>();

            Paciente p1 = new Paciente();
            p1.Id = 1;
            p1.Nombre = "Carlos";
            p1.Edad = 45;
            p1.Mascota = new Mascota();
            p1.Mascota.Nombre = "Rex";
            p1.Mascota.Especie = "Perro";
            p1.Mascota.Raza = "Labrador";
            pacientes.Add(p1);

            Paciente p2 = new Paciente();
            p2.Id = 2;
            p2.Nombre = "Maria";
            p2.Edad = 30;
            p2.Mascota = new Mascota();
            p2.Mascota.Nombre = "Misi";
            p2.Mascota.Especie = "Gato";
            p2.Mascota.Raza = "No definida";
            pacientes.Add(p2);

            Paciente p3 = new Paciente();
            p3.Id = 3;
            p3.Nombre = "Luis";
            p3.Edad = 60;
            p3.Mascota = new Mascota();
            p3.Mascota.Nombre = "Bobby";
            p3.Mascota.Especie = "Perro";
            p3.Mascota.Raza = "Golden";
            pacientes.Add(p3);

            // Filtrar solo perros
            var perros = pacientes.Where(p => p.Mascota.Especie == "Perro").ToList();

            // Ordenar por edad
            var ordenados = pacientes.OrderBy(p => p.Edad).ToList();

            // Sacar solo nombres
            var nombres = pacientes.Select(p => p.Nombre).ToList();

            // Agrupar por especie
            var grupos = pacientes.GroupBy(p => p.Mascota.Especie);

            // Contar cuantos perros
            int totalPerros = pacientes.Count(p => p.Mascota.Especie == "Perro");

            // Ver si hay mascota sin raza
            bool haySinRaza = pacientes.Any(p => p.Mascota.Raza == "No definida");

            // El mas joven
            var masJoven = pacientes.OrderBy(p => p.Edad).FirstOrDefault();

            Console.ReadKey();
        }
    }

    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Mascota Mascota { get; set; }
    }

    public class Mascota
    {
        public string Nombre { get; set; }
        public string Especie { get; set; }
        public string Raza { get; set; }
    }
}