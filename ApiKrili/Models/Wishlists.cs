using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiKrili.Models
{
    public class Wishlists
    {
        public int id_wishlist { get; set; }
        public int id_visitor { get; set; }
        public int id_car { get; set; }
        public int deleted { get; set; }
        public Wishlists() { }

        public Wishlists(int id_wishlist, int id_visitor, int id_car)
        {
            this.id_wishlist = id_wishlist;
            this.id_visitor = id_visitor;
            this.id_car = id_car;
        }
    }
}
