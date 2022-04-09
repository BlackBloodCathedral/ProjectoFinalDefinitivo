using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Mascotas
    {
        int ID_Mascota;
        string Nombre_Mascota;
        string Especie;
        string Raza;
        int Edad;
        string Genero;
        int Dueño;

        public int idmascota { get => ID_Mascota; set => ID_Mascota = value; }
        public string nombremascota { get => Nombre_Mascota; set => Nombre_Mascota = value; }
        public string especie { get => Especie; set => Especie = value; }
        public string raza { get => Raza; set => Raza = value; }
        public int edad { get => Edad; set => Edad = value; }
        public string genero { get => Genero; set => Genero = value; }
        public int idusuario { get => Dueño; set => Dueño = value; } 
    }
}
