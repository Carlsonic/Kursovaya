using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace kursovaya_rabota
{
    class Client
    {
        const string url = "https://rest.bandsintown.com";
        const string artinfo = "v4/artists/{0}/?app_id=680fa1fdd5376382ae7efea0076bb7ff";
        const string eventinfo = "v4/artists/{0}/events/?app_id=680fa1fdd5376382ae7efea0076bb7ff";

        RestClient client = null;
        Jsonparser Jsonparser = new Jsonparser();

        public Client()
        {
            client = new RestClient(url);
            client.Timeout = -1;
        }

        public List<Detail> LoadEventData(string artist = "Grandson")
        {

            string uri = string.Format(eventinfo, artist);

            var request = new RestRequest(uri, Method.GET);
            var response = client.Execute(request);
            string apiresult = response.Content;

            return Jsonparser.Parsedata(apiresult);
           
        }
    }
}
