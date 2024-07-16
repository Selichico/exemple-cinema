using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_cinema
{
    public class Salle
    {
        public int numero;
        public const int nombrePlace = 20;
        public int placeOccuped;
        
        List<Film> film;
        
        public int Numero { get; set; }
        public int PlaceOccuped
        {
            get
            {
                return placeOccuped;
            }
            set { placeOccuped = placeOccuped - 1; }
        }

        public int PlaceDispo()
        {
            return nombrePlace - placeOccuped;  
        }
       

       public void AfficheListSeance() { }

    }
}
