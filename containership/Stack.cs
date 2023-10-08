using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containership
{
    public class Stack
    {
        List<Container> containers = new List<Container>();
        public int MaxStackWeight = 120000;
        public int Count()
        {
            return containers.Count;
        }
        
        public Container TopContainer()
        {
            return containers.Last();
        }
    }
}
