using RicksInventoryWithSpec;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RicksInventory
{
    public class Guitar
    {
        private String serialNumber;
        private double price;
        public GuitarSpec spec;

        public Guitar(String serialNumber, double price, GuitarSpec spec)
        {
            this.serialNumber = serialNumber;
            this.price = price;

            this.spec = spec;
        }

        public String getSerialNumber() { return serialNumber; }
        public double getPrice() { return price; }

        public GuitarSpec getSpec() {  return spec; }
    }
}
