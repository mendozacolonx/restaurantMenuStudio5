using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3StudioRestaurantMenu
{
    public class MenuItem
    {
        //removed bc using prop instead of fields
        ////fields
        ////these dont need get set
        //private string item { get; set; }
        //private decimal price { get; set; }
        //private string description { get; set; }
        //private string category { get; set; }
        //private bool isNew { get; set; }
        //private DateTime lastUpdated { get; set; }

        //properties
        public string Item { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public bool IsNew { get; private set; }
   //     public DateTime LastUpdated { get; private set; } // TODO: think about case when you want this updated.


        //why not working? looks just like example in constructors section
        public MenuItem(string item, decimal price, string description, string category, bool isNew) //, bool isNew, DateTime lastUpdated)
        {
            Item = item;
            Price = price;
            Description = description;
            Category = category;
            IsNew = true;
//            LastUpdated = DateTime.Today; //at what point do i need to make this a to string?


            //List<string> individualItem = new List<string>();
            //individualItem.Add("");
            //individualItem.Add("");
            //individualItem.Add("");
            //individualItem.Add("");
            //individualItem.Add("");
            //individualItem.Add("");
        }
    }

    
}
