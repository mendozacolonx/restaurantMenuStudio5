using class3StudioRestaurantMenu;
using System.IO;

//instance variable (list)
var menuItem = new List<MenuItem>();

//new instance of the list
Menu menuProgram = new Menu("Menu", menuItem);

//declaring an item
//1. Create several items and add them to a menu.
MenuItem Pasta = new MenuItem("Pasta", 20, "penne in a spicy tomato sauce", "Main Course", true);
MenuItem toastedRav = new MenuItem("toasted ravioli", 10, "stl classic, fried t-ravs", "appetizer", false);
MenuItem icecream = new MenuItem("icecream", 1, "sweet ol' vanailla", "dessert", true);

//adding items
menuProgram.AddNew(Pasta);
menuProgram.AddNew(toastedRav);
menuProgram.AddNew(icecream);

//2. Print the entire, updated menu to the screen.
menuProgram.PrintMenu();

//3. Print an individual menu item to the screen.
menuProgram.PrintItem(Pasta);

//4. Delete an item from a menu, then reprint the menu.
menuProgram.Remove(Pasta);
menuItem.PrintMenu();


//BONUS: If a user tries to add an item that is already on the menu, print a message that warns the user about the duplicate. Also, prevent the duplicate from being added to the menu.
menuProgram.AddNew(toastedRav);

menuProgram.PrintMenu();




///still working on displaying whether an item is new, displaying last update, and printing the entire menu out...