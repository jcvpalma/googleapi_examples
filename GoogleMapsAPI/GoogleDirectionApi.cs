using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace GoogleMapsAPI
{
    public class GoogleDirectionApi
    {
        private WebClient _http;
        private string UrlDirectionsService = "https://maps.googleapis.com/maps/api/distancematrix/json";
        private string queryString = String.Empty;
        private string strKey;

        public GoogleDirectionApi(string Key)
        {
            try
            {
                if(String.IsNullOrEmpty(Key) == true) 
                {
                    throw new Exception("Chave nao informada");
                }
                strKey = Key;                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public JObject getDirectionsService(Coordenadas _origem, Coordenadas _destino)
        {
            var retorno = String.Empty;

            using(_http = new WebClient())
            {

                setQueryString("origins", String.Format("{0},{1}", _origem.Lat.ToString().Replace(",", "."), _origem.Lng.ToString().Replace(",", ".")));
                setQueryString("destinations", String.Format("{0},{1}", _destino.Lat.ToString().Replace(",", "."), _destino.Lng.ToString().Replace(",",".")));
                
                var UrlFull = String.Format("{0}?{1}", UrlDirectionsService, queryString);

                _http.Encoding = Encoding.UTF8;
                retorno = _http.DownloadString(UrlFull);
            }

            return JObject.Parse(retorno);
        }


        private void setQueryString(string key, string value)
        {
            List<string> _query = new List<string>();

            if (String.IsNullOrEmpty(queryString)==false)
            {
                if (queryString.Contains('&'))
                {
                    var ret = queryString.Split('&');
                    foreach (var t in ret)
                    {
                        var key_value = t.Split('=');
                        _query.Add(String.Format("{0}={1}", key_value[0], key_value[1]));
                    }
                }
                else
                {
                    var key_value = queryString.Split('=');
                    _query.Add(String.Format("{0}={1}", key_value[0], key_value[1]));
                }
            }
            _query.Add(String.Format("{0}={1}", key, value));

            queryString = String.Empty;
            queryString = String.Join("&", _query);
            
        }

    }
}
