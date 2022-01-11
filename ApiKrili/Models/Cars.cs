using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiKrili.Models
{
    public class Cars
    {
        public int id_car { get; set; }
        public int id_user { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public int year { get; set; }
        public char fuel_type { get; set; }
        public string car_description { get; set; }
        public int mileage { get; set; }
        public int price { get; set; }
        public int nbr_seats { get; set; }
        public String img_name { get; set; }
        public char gear_box { get; set; }
        public string color { get; set; }    
        public int active { get; set; }
        public int deleted { get; set; }

        public Cars() { }

        public Cars(int id_car, int id_user, string brand, string model, int year, char fuel_type, string car_description, int mileage, int price,int nbr_seats, String img_name,   char gear_box, string color)
        {
            this.id_car = id_car;
            this.id_user = id_user;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.fuel_type = fuel_type;
            this.car_description = car_description;
            this.mileage = mileage;
            this.price = price;
            this.nbr_seats = nbr_seats;
            this.img_name = img_name;
            this.gear_box = gear_box;
            this.color = color;
        }
    }
}
