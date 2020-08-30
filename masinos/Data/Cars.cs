using System;
using System.Collections.Generic;

namespace masinos.Data
{
    public class Cars
    {
        public List<Car> ListedCars { get; set; }
    }
    public class Car
    {
        public string Size { get; set; }
        public string Form { get; set; }
        public string Usage { get; set; }
        public string ImagePath { get; set; }
    }
}
