using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksInventory
{
    public class FindGuitarTester
    {
        public static void testErin()
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            Guitar whatErinLikes = new Guitar("", 0, "fender", "Stratocastor", "electric", "Alder", "Alder");

            Guitar guitar = inventory.search(whatErinLikes);

            if (guitar != null)
            {
                Console.WriteLine("Erin, you might like this " +
                    guitar.getBuilder() + " " + guitar.getModel() + " " + guitar.getType() + " " + 
                    guitar.getBackWood() + " back and sides, \n" +
                    guitar.getTopWood() + " top.\n" + 
                    "You can have it only for $" + guitar.getPrice() + "!"
                );
            } else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void initializeInventory(Inventory inventory)
        {
            inventory.addGuitar("V95693", 1430.50, "Fender", "Stratocastor", "electric", "Alder", "Alder");
        }
    }
}
