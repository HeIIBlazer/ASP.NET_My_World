using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyWorld.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string Continent { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public ICollection<City> Cities { get; set; }
        public Country()
        {
            Cities = new List<City>();
        }
        public string Capital { get; set; }
    }
}