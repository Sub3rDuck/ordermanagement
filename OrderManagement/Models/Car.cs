using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderManagement.Models
{
    using System.Drawing;

    using OrderManagement.ViewModels;

    public class Car
    {

        public Car(int wheel, string color)
        {
            this.Wheel = wheel;
            this.Color = color;
        }

        public Car(CarCreateViewModel model)
        {
            this.Wheel = model.Wheel;
            this.Color = model.Color;
        }
        
        public int Wheel { get; private set; }

        public string Color { get; private set; }

        public int CarId { get; set; }

    }


}