using System.Reflection;

namespace RicksInventoryWithMandolin
{
    public class MandolinSpec : InstrumentSpec
    {
        private Style style;

        public MandolinSpec(Builder builder, String model, Type type, Style style, int numOfString, Wood backWood, Wood topWood) : base(model, builder, type, backWood, topWood)
        {
            this.style = style;
        }

        public Style getStyle() { return this.style; }
        public Boolean matches(InstrumentSpec otherSpec)
        {
            if (!base.matches(otherSpec)) { return false; }
            if (!(otherSpec is MandolinSpec)) { return false; }
            MandolinSpec spec = (MandolinSpec)otherSpec;
            if (!style.Equals(spec.style)) { return false;  }
            return true;
        }
    }
}
