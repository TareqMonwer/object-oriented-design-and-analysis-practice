using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksInventory
{
    public class Inventory
    {
        private List<Guitar> guiters;

        public Inventory()
        {
            guiters = new List<Guitar>();
        }

        public void addGuitar(String serialNumber, double price, String builder, String model, String type, String backWood, String topWood)
        {
            Guitar guitar = new Guitar(serialNumber, price, builder, model, type, backWood, topWood);

            guiters.Add(guitar);
        }

        public Guitar? getGuitar(String serialNumber)
        {
            for (int i = 0; i < guiters.Count; i++)
            {
                Guitar guitar = guiters[i];

                if (guitar.getSerialNumber() == serialNumber)
                {
                    return guitar;
                }
            }

            return null;
        }

        public Guitar? search(Guitar searchGuitar) 
        {
            for (int i = 0; i < guiters.Count; i++)
            {
                Guitar guitar = guiters[i];

                String builder = searchGuitar.getBuilder();
                if ((builder != null) && (!builder.Equals("")) && (!builder.Equals(guitar.getBuilder()))) { continue; }
                
                String model = searchGuitar.getModel();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.getModel()))) { continue; }

                String type = searchGuitar.getType();
                if ((type != null) && (!type.Equals("")) && (!type.Equals(guitar.getType()))) { continue; }

                String topWood = searchGuitar.getTopWood();
                if ((topWood != null) && (!topWood.Equals("")) && (!topWood.Equals(guitar.getTopWood()))) { continue; }

                String backWood = searchGuitar.getBackWood();
                if ((backWood != null) && (!backWood.Equals("")) && (!backWood.Equals(guitar.getBackWood()))) { continue; }
            }

            return null;
        }
    }
}
