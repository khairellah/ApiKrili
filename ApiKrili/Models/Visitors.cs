using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiKrili.Models
{
    public class Visitors
    {
        public int id_visitor { get; set; }
        public String login { get; set; }
        public String pass { get; set; }
        public String fname { get; set; }
        public String lname { get; set; }
        public String phone_number { get; set; }
        public String city { get; set; }
        public String img_name { get; set; }
        public int deleted { get; set; }

        public Visitors() { }

        public Visitors(int id_visitor, String login, String pass, string fname, string lname, string phone_number, string city, string img_name)
        {
            this.id_visitor = id_visitor;
            this.login = login;
            this.pass = pass;
            this.fname = fname;
            this.lname = lname;
            this.phone_number = phone_number;
            this.city = city;
            this.img_name = img_name;
        }
    }
}
