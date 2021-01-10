using GMap.NET;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace kursovayaWPF
{
    class Detail
    {
        public Artist Artist { get; set; }
        public Venue Venue { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string EventName { get; set; }
        public PointLatLng MarkerCoord { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

        public Detail(Artist artist, Venue venue, string description, DateTime date)
        {
            this.Artist = artist;
            this.Venue = venue;
            this.City = venue.city;
            this.Country = venue.country;
            this.EventName = venue.name;
            this.MarkerCoord = new PointLatLng(Convert.ToDouble(venue.latitude, CultureInfo.InvariantCulture), Convert.ToDouble(venue.longitude, CultureInfo.InvariantCulture));
            this.Description  = (description == "") ? "нет описания" : description;
            this.Date = date;
        }
    }
}
