using System;

namespace ClinicaVeterinaria.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Sintoma { get; set; }
        public Mascota Mascota { get; set; }

        public Paciente(int id, string nombre, int edad, string telefono, string sintoma, Mascota mascota)
        {
            Id = id;
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            Sintoma = sintoma;
            Mascota = mascota;
        }
    }
}