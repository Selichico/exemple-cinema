using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_cinema
{
    public class Film
    {
        public string titre;
        public int annéeProd;
        public string nomRealisateur;
        public string synopsis ;
        public double tarif;


        public string Titre {
            get
            {
                return titre;
            }
            set
            {
                titre = value;
            }
        }
        public int AnnéeProd { get; set; }
        public string NomRealisateur { get; set; }
        public string  Synopsis { get; set; }
        public double Tarif { get; set; }

        public void ConsulterListFilm( )
        {    
        }
    }
}
