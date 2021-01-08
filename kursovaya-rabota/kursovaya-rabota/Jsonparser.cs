using System.Collections.Generic;
using Newtonsoft.Json;

namespace kursovaya_rabota
{
    class Jsonparser
    {
        public List<Data> Parsedata(string data)
        {
            List<Root> myDeserializedClass = JsonConvert.DeserializeObject<List<Root>>(data);
            return new List<Data>();
        }
    }
}
