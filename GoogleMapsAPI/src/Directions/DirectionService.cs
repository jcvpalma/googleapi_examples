using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsAPI.src.Directions
{
    public class DirectionService : IDisposable
    {
        public string ApiKey { get; set; }
        public string HttpUri { get; set; }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
