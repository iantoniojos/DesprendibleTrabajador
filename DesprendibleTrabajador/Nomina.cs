using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesprendibleTrabajador
{
    class Nomina
    {
        public string Nombre { get; set; }
        public int Identificacion { get; set; }
        public string Cargo { get; set; }
        public string Genero { get; set; }
        public int DiasLaborados { get; set; }
        public decimal AsignacionDias { get; set; }

        public decimal CalcularNomina(int diasLab, decimal valorDia)
        {
            decimal valorDevengado = 0;
            decimal bono = 4000;
            if (diasLab >= 15)
            {
                valorDevengado = (diasLab * valorDia) + bono;
            }
            else
            {
                valorDevengado = (diasLab * valorDia);
            }
            
            return valorDevengado;

        }
    }
}
