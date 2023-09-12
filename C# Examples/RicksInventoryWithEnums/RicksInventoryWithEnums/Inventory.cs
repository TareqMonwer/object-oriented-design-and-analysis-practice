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

        public void addGuitar(String serialNumber, double price, Builder builder, 
            String model, Type type, Wood backWood, Wood topWood
        )
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

        public List<Guitar> search(Guitar searchGuitar) 
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            for (int i = 0; i < guiters.Count; i++)
            {
                Guitar guitar = guiters[i];

                if (searchGuitar.getBuilder() != guitar.getBuilder()) { continue;  }
                
                String model = searchGuitar.getModel();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.getModel()))) { continue; }

                if (searchGuitar.getType() != guitar.getType()) { continue; }

                if (searchGuitar.getTopWood() != guitar.getTopWood()) { continue; }

                if (searchGuitar.getBackWood() != guitar.getBackWood()) { continue; }

                matchingGuitars.Add(guitar);
            }

            return matchingGuitars;
        }
    }
}
