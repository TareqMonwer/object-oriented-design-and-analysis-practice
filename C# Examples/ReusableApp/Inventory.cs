﻿using ReusableApp;
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
                GuitarSpec guiterSpec = guitar.getSpec();
                
                if (guiterSpec.isGuitarSpecMatch(searchGuitarSpec))
                {
                    matchingGuitars.Add(guitar);
                }
            }

            return matchingGuitars;
        }
    }
}
