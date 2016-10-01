using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab1.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public decimal Occupation { get; set; }
    }
}