using System;
namespace RicksInventoryWithMandolin
{
    public abstract class InstrumentSpec
    {
        private String model;
        private Builder builder;
        private Type type;
        private Wood backWood;
        private Wood topWood;

        public InstrumentSpec(string model, Builder builder, Type type, Wood backWood, Wood topWood)
        {
            this.model = model;
            this.builder = builder;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }

        public Builder getBuilder() { return builder; }
        public String getModel() { return model; }
        public Type getType() { return type; }
        public Wood getBackWood() { return backWood; }
        public Wood getTopWood() { return topWood; }

        public Boolean matches(InstrumentSpec otherSpec)
        {
            if ((model != null) && (!model.Equals("")) && (!model.Equals(otherSpec.model))) {
                return false;
            }
            if (builder != otherSpec.builder) { return false; }
            if (type != otherSpec.type) { return false; }
            if (backWood != otherSpec.backWood) { return false; }
            if (topWood != otherSpec.topWood) { return false; }
            return true;
        }
    }
}
