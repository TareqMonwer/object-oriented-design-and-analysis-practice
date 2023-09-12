using RicksInventoryWithSpec;
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

        public void addGuitar(String serialNumber, double price, GuitarSpec spec)
        {
            Guitar guitar = new Guitar(serialNumber, price, spec);

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

        public List<Guitar> search(GuitarSpec searchGuitarSpec) 
        {
            List<Guitar> matchingGuitars = new List<Guitar>();

            for (int i = 0; i < guiters.Count; i++)
            {
                Guitar guitar = guiters[i];

                if (searchGuitarSpec.getBuilder() != guitar.spec.getBuilder()) { continue;  }
                
                String model = searchGuitarSpec.getModel();
                if ((model != null) && (!model.Equals("")) && (!model.Equals(guitar.spec.getModel()))) { continue; }

                if (searchGuitarSpec.getType() != guitar.spec.getType()) { continue; }

                if (searchGuitarSpec.getTopWood() != guitar.spec.getTopWood()) { continue; }

                if (searchGuitarSpec.getBackWood() != guitar.spec.getBackWood()) { continue; }

                matchingGuitars.Add(guitar);
            }

            return matchingGuitars;
        }
    }
}
