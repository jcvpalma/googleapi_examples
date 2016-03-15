using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsAPI.Util
{
    class GoogleMapsAPIKey
    {
        private string apiKey { get; set; }

        public GoogleMapsAPIKey(string ApiKey)
        {
            this.apiKey = ApiKey;
        }
    }
}
