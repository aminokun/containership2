using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace containership
{
    public class ContainerSorter
    {
        public ContainerSorter(List<Container> containers) 
        {
            List<Container> sortedContainers = containers.OrderBy(type => type.ContainerType).ToList(); ;
        }
    }
}
