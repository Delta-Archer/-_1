using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Car
    {
        public int Id { get; set; }
        // назва книги public 
        public string Model { get; set; }
        public string Corporation { get; set; }
        public int Price { get; set; }
    }
}