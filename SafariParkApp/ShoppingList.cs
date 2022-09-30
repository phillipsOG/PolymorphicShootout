using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    internal class ShoppingList
    {
        public ShoppingList()
        {
        }

        public ShoppingList(int milk, int soap, int lemon)
        {
            Milk = milk;
            Soap = soap;
            Lemon = lemon;
        }

        public ShoppingList(int bread, int milk, int soap, int potato, int lemon)
        {
            Bread = bread;
            Milk = milk;
            Soap = soap;
            Potato = potato;
            Lemon = lemon;
        }

        public int Bread { get; set; }
        public int Milk { get; set; }
        public int Soap { get; set; }
        public int Potato { get; set; }
        public int Lemon { get; set; }
    }
}
