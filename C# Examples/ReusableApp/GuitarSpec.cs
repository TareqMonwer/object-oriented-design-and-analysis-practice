using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusableApp
{
    public class GuitarSpec
    {
        private String model;
        private Builder builder;
        private Type type;
        private Wood backWood;
        private Wood topWood;
        private int numStrings;

        public GuitarSpec(Builder builder, String model, int numStrings, Type type, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
            this.numStrings = numStrings;
        }

        public Builder getBuilder() { return builder; }
        public String getModel() { return model; }
        public int getNumStrings() { return numStrings; }
        public Type getType() { return type; }
        public Wood getBackWood() { return backWood; }
        public Wood getTopWood() { return topWood; }
        public bool isGuitarSpecMatch(GuitarSpec searchSpec)
        {
            if (searchSpec == null) return false;
            if (searchSpec.getBuilder() != this.getBuilder()) return false;
            if (searchSpec.getType() != this.getType()) return false;
            if (searchSpec.getTopWood() != this.getTopWood()) return false;
            if (searchSpec.getBackWood() != this.getBackWood()) return false;
            if (searchSpec.getNumStrings() != this.getNumStrings()) return false;

            String model = searchSpec.getModel();
            if ((model != null) && (!model.Equals("")) && (!model.Equals(this.getModel()))) return false;

            return true;
        }
    }
}
