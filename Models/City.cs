using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MyWorld.Models
{
    public class City
    {
        public int Id {  get; set; }
        public int? CountryId { get; set; }
        public Country Country { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
    }
}