using RicksInventoryWithMandolin;

namespace RicksInventory
{
    public class Inventory
    {
        private List<Instrument> inventory;

        public Inventory()
        {
            inventory = new List<Instrument>();
        }

        public void addInstrument(String serialNumber, double price, InstrumentSpec spec)
        {
            Instrument instrument = null;
            if (spec is GuitarSpec)
            {
                instrument = new Guitar(serialNumber, price, (GuitarSpec)spec);
            } else if (spec is MandolinSpec)
            {
                instrument = new Mandolin(serialNumber, price, (MandolinSpec)spec);
            }

            inventory.Add(instrument);
        }

        public Instrument? get(String serialNumber)
        {
            for (int i = 0; i < inventory.Count; i++)
            {
                Instrument instrument = inventory[i];

                if (instrument.getSerialNumber() == serialNumber)
                {
                    return instrument;
                }
            }

            return null;
        }

        public List<Instrument> search(InstrumentSpec searchGuitarSpec) 
        {
            List<Instrument> matchingGuitars = new List<Instrument>();

            for (int i = 0; i < inventory.Count; i++)
            {
                Instrument instrument = inventory[i];

                if (instrument.getSpec().matches(searchGuitarSpec))
                {
                    matchingGuitars.Add(instrument);
                }
            }

            return matchingGuitars;
        }

        //public List<Mandolin> search(MandolinSpec searchMandolinSpec)
        //{
        //    List<Mandolin> matchingMandolins = new List<Mandolin>();

        //    for (int i = 0; i < inventory.Count; i++)
        //    {
        //        var instrument = inventory[i];
        //        if (instrument is null) continue;
        //        if (instrument is Mandolin mandolin && mandolin.getSpec().matches(searchMandolinSpec))
        //        {
        //            matchingMandolins.Add(mandolin);
        //        }
        //    }
        //    return matchingMandolins;
        //}
    }
}
