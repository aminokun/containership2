using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containership
{
    public class Container
    {
        int Weight { get; set; }
        Type ContainerType { get; set; }
        public Container(int weight, Type containerType)
        {
            Weight = weight;
            ContainerType = containerType;
        }
        public enum Type
        {
            Valuable = 1,
            Normal = 2,
            Cooled = 3,
            CooledValuable = 4
        }
        public override string ToString()
        {
            return "Container:\n    " + this.Weight.ToString() + "Kg, " + this.ContainerType.ToString();
        }
    }
}
