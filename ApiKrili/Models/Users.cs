using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiKrili.Models
{
    public class Users
    {
        public int id_user { get; set; }
        public String login { get; set; }
        public String pass { get; set; }
        public String fname { get; set; }
        public String lname { get; set; }
        public String company_title { get; set; }
        public String phone_number { get; set; }
        public String city { get; set; }
        public String address { get; set; }
        public String img_name { get; set; }
        public String description { get; set; }
        public int sponsor { get; set; }
        public int deleted { get; set; }

        public Users() { }

        public Users(int id_user, String login, String pass, string fname, string lname,string company_title, string phone_number, string city,string address, string img_name, string description)
        {
            this.id_user = id_user;
            this.login = login;
            this.pass = pass;
            this.fname = fname;
            this.lname = lname;
            this.phone_number = phone_number;
            this.city = city;
            this.address = address;
            this.img_name = img_name;
            this.description = description;
        }
    }
}
