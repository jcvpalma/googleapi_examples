using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GoogleMapsAPI.src.Directions;

namespace GoogleMapsAPI
{
    class GoogleAPI
    {
        private DirectionService _direction;
        

        public DirectionService direction
        {
            get
            {
                return this._direction;
            }
            set
            {
                this._direction = value;
            }
        }

        public GoogleAPI(string ApiKey)
        {
            
        }

    }
}
