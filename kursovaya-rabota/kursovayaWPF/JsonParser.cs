using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace kursovayaWPF
{
    class JsonParser
    {
        public List<Detail> Parsedata(string apiresult)
        {
            List<Root> myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(apiresult);
            //MessageBox.Show(myDeserializedClass[1].venue.latitude, myDeserializedClass.Count.ToString());

            List<Detail> returnlist = new List<Detail>();

            foreach (Root dataset in myDeserializedClass)
            {
                Detail returndata = new Detail(artist: myDeserializedClass[0].artist, venue: dataset.venue, description: dataset.description, date: dataset.datetime);

                returnlist.Add(returndata);
            }

            return returnlist;
        }
    }
}
