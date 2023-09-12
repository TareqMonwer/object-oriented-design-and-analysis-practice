﻿using RicksInventoryWithSpec;
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

            var whatErinLikes = new GuitarSpec(
                Builder.fender, 
                "Stratocastor", 
                Type.electric,
                Wood.alder,
                Wood.alder
            );

            List<Guitar> guitars = inventory.search(whatErinLikes);

            if ( guitars.Count > 0 )
            {
                foreach (var guitar in guitars)
                {
                    Console.WriteLine("Erin, you might like this " +
                        guitar.spec.getBuilder() + " " +
                        guitar.spec.getModel() + " " + 
                        guitar.spec.getType() + " " +
                        guitar.spec.getBackWood() + " back and sides." +
                        guitar.spec.getTopWood() + " top.\n" + "You can have it only for $" + 
                        guitar.getPrice() + "!"
                    );
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }
        }

        private static void initializeInventory(Inventory inventory)
        {
            var guitarSpec = new GuitarSpec(
                Builder.fender,
                "Stratocastor",
                Type.electric,
                Wood.alder,
                Wood.alder
            );
            inventory.addGuitar(
                "V95693", 
                1430.50,
                guitarSpec
            );
            inventory.addGuitar(
                "V95694",
                1530.50,
                guitarSpec
            );
        }
    }
}
