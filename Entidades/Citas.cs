using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Citas
    {
        Int64 ID_Cita;
        string Servicio;
        DateTime Fecha_Cita;
        Int64 Cliente;
        string Nombre; 

        public Int64 idcita { get => ID_Cita; set => ID_Cita = value; }
        public string servicio { get => Servicio; set => Servicio = value; }
        public DateTime fechacita { get => Fecha_Cita; set => Fecha_Cita = value; }
        public Int64 cliente { get => Cliente; set => Cliente = value; }
        public string nombre { get => Nombre; set => Nombre = value; }
    }
}
