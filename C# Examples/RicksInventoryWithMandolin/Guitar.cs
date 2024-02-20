using RicksInventoryWithMandolin;

namespace RicksInventory
{
    public class Guitar : Instrument
    {
        public Guitar(String serialNumber, double price, GuitarSpec spec) : base(serialNumber, price, spec)
        {
        }
    }
}
