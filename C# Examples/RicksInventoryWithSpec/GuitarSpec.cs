﻿using System;
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

        public GuitarSpec(Builder builder, String model, Type type, Wood backWood, Wood topWood)
        {
            this.builder = builder;
            this.model = model;
            this.type = type;
            this.backWood = backWood;
            this.topWood = topWood;
        }

        public Builder getBuilder() { return builder; }
        public String getModel() { return model; }
        public Type getType() { return type; }
        public Wood getBackWood() { return backWood; }
        public Wood getTopWood() { return topWood; }
    }
}
