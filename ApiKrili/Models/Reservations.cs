using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiKrili.Models
{
    public class Reservations
    {
        public int id_reservation { get; set; }
        public int id_car { get; set; }
        public int id_visitor { get; set; }
        public int id_user { get; set; }
        public String visitor_phone_number { get; set; }
        public String visitor_img_name { get; set; }
        public String visitor_lname { get; set; }
        public int nbr_days { get; set; }
        public DateTime date_reservation { get; set; }
        public String review { get; set; }    

        public Reservations() { }

        public Reservations(int id_reservation, int id_car, int id_visitor, int id_user, string visitor_phone_number, string visitor_img_name, string visitor_lname, int nbr_days,DateTime date_reservation, string review)
        {
            this.id_reservation = id_reservation;
            this.id_car = id_car;
            this.id_user = id_user;
            this.id_visitor = id_visitor;
            this.date_reservation = date_reservation;
            this.visitor_img_name = visitor_img_name;
            this.visitor_lname = visitor_lname;
            this.visitor_phone_number = visitor_phone_number;
            this.review = review;
            this.nbr_days = nbr_days;
        }
    }
}
