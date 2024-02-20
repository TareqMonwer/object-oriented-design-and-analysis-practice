using RicksInventoryWithMandolin;

namespace RicksInventory
{
    public class FindGuitarTester
    {
        public static void testErin()
        {
            Inventory inventory = new Inventory();
            initializeInventory(inventory);

            // Guitar Search
            var whatErinLikes = new GuitarSpec(
                Builder.fender,
                "Stratocastor",
                Type.electric,
                4,
                Wood.alder,
                Wood.alder
            );

            List<Instrument> guitars = inventory.search(whatErinLikes);

            if ( guitars.Count > 0 )
            {
                foreach (var guitar in guitars)
                {
                    GuitarSpec guiterSpec = (GuitarSpec)guitar.getSpec();
                    Console.WriteLine("Erin, you might like this " +
                        guiterSpec.getBuilder() + " " +
                        guiterSpec.getModel() + " " + 
                        guiterSpec.getType() + " " +
                        guiterSpec.getBackWood() + " back and sides." +
                        guiterSpec.getTopWood() + " top.\n" + "You can have it only for $" + 
                        guitar.getPrice() + "!"
                    );
                }
            }
            else
            {
                Console.WriteLine("Sorry, Erin, we have nothing for you.");
            }

            Console.WriteLine("==============================================================");

            // Mandolin Search
            var whatBobLikes = new MandolinSpec(
                Builder.martin,
                "ABC",
                Type.electric,
                Style.A,
                6,
                Wood.alder,
                Wood.alder
            );

            List<Instrument> mandolins = inventory.search(whatBobLikes);

            if (mandolins.Count > 0)
            {
                foreach (var mandolin in mandolins)
                {
                    MandolinSpec mandolinSpec = (MandolinSpec)mandolin.getSpec();
                    Console.WriteLine("Bob, you might like this " +
                        mandolinSpec.getBuilder() + " " +
                        mandolinSpec.getModel() + " " +
                        mandolinSpec.getStyle() + " " +
                        mandolinSpec.getType() + " " +
                        mandolinSpec.getBackWood() + " back and sides." +
                        mandolinSpec.getTopWood() + " top.\n" + "You can have it only for $" +
                        mandolin.getPrice() + "!"
                    );
                }
            }
            else
            {
                Console.WriteLine("Sorry, Bob, we have nothing for you.");
            }
        }

        private static void initializeInventory(Inventory inventory)
        {
            var guitarSpec = new GuitarSpec(
                Builder.fender,
                "Stratocastor",
                Type.electric,
                4,
                Wood.alder,
                Wood.alder
            );
            var mandolinSpec = new MandolinSpec(
                Builder.martin,
                "ABC",
                Type.electric,
                Style.A,
                6,
                Wood.alder,
                Wood.alder
            );
            var mandolinSpec2 = new MandolinSpec(
                Builder.martin,
                "ABC",
                Type.acustic,
                Style.F,
                6,
                Wood.alder,
                Wood.alder
            );

            // Add Mandolins
            inventory.addInstrument(
                "00001",
                1000.00,
                mandolinSpec
            );
            inventory.addInstrument(
                "00002",
                2000.00,
                mandolinSpec2
            );

            // Add Guitars
            inventory.addInstrument(
                "V95693", 
                1430.50,
                guitarSpec
            );
            inventory.addInstrument(
                "V95694",
                1530.50,
                guitarSpec
            );
        }
    }
}
