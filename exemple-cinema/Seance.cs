using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_cinema
{
    public class Seance
    {
        public int numero;
        public DateTime dat;
        public DateTime heurDebut;
        public DateTime heurFin;
        List<Seance> seances;
        

        public int Numero {
            get
            { return numero; }

            set
            { numero = numero++; }
        }
        public DateTime Dat { get; set; }
        public DateTime HeurDebut { get; set; }
        public DateTime HeurFin { get; set;}
        
    }
}
