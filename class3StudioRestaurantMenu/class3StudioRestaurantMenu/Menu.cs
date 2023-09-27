using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class3StudioRestaurantMenu
{
    public class Menu
    {
        private string Item { get; set; }
        private bool IsNew { get; set; } = false;
        //string bc i want it printed to the screen, but would date time match menu item better?
        //changed it to datetime to try it out
        private DateTime LastUpdated { get; set; }
        //instantiating the list
        public List<MenuItem> RestaurantMenu { get; set; }

        public Menu(string item, List<MenuItem> restaurantMenu)
        {
            this.Item = item;
            this.LastUpdated = DateTime.Now;
            this.RestaurantMenu = restaurantMenu;
        }

        public void AddNew(MenuItem item)
        {
            if (this.IsNew)
            {
                RestaurantMenu.Add(item);
            }

            /*
             * publci List<MEnuItem> AddItem(MenuITem item){
             * if(){
             * 
             * 
             * 
             * 
             * }
             * 
             * 
             * */
        }

        public void Remove(MenuItem item)
        {
            RestaurantMenu.Remove(item);
        }

        //changed name from IsNew to new because error message warning that isnew is already defined in menu. see line 12
        public void New()
        {
            foreach (MenuItem item in RestaurantMenu)
            {
                if (item.IsNew)
                {
                    //probable should rename this variable so its not confusing. item.item is not descriptive enough when referring to the name of the dish. and dont want things with the same name, confusing...
                    Console.WriteLine(item.Item);
                }
                else
                {
                    Console.WriteLine("This item is already on the menu!";
                }
            }
        }

        //using expression line per vs recommendation
        public void PrintItem(MenuItem item) => Console.WriteLine(
                item.Item +
                "\n Price: " + item.Price +
                "\n Description: " + item.Description
                );

        //NOT WORKING????? WHYYYYY WHYYYYY WHYYYY :(
        public void PrintMenu(MenuItem item)
        {
            //why cant item be declared in this scope, doesnt make sense... changed to items with an s
            foreach (MenuItem items in RestaurantMenu)
            {
                Console.WriteLine(item.Item);
            }
        }

        //generated both methods through vs
        public override bool Equals(object? obj)
        {
            return obj is Menu menu &&
                   Item == menu.Item &&
                   IsNew == menu.IsNew &&
                   LastUpdated == menu.LastUpdated &&
                   EqualityComparer<List<MenuItem>>.Default.Equals(RestaurantMenu, menu.RestaurantMenu);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Item, IsNew, LastUpdated, RestaurantMenu);
        }
    }
}
