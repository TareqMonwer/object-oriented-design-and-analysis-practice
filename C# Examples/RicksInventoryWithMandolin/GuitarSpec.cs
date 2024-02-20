using System.Reflection;

namespace RicksInventoryWithMandolin
{
    public class GuitarSpec : InstrumentSpec
    {
        private int numOfStrings;

        public GuitarSpec(Builder builder, String model, Type type, int numOfString, Wood backWood, Wood topWood) : base(model, builder, type, backWood, topWood)
        {
            this.numOfStrings = numOfString;
        }

        public int getNumOfStrings() { return numOfStrings; }
        public Boolean matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec)) { return false; }
            if (!(otherSpec is GuitarSpec)) { return false; }
            GuitarSpec spec = (GuitarSpec)otherSpec;
            if (numOfStrings == spec.numOfStrings) { return false; }
            return true;
        }
    }
}
