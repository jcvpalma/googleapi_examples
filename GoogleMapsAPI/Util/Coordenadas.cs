using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsAPI
{
    public class Coordenadas
    {
        public double Lat { get; set; }
        public double Lng { get; set; }

        public Coordenadas()
        {

        }

        public Coordenadas(double lat, double lng)
        {
            this.Lat = lat;
            this.Lng = lng;
        }

    }
}
