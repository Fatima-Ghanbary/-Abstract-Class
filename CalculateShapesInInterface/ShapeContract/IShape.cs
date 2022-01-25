using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapesInInterface
{
    interface IShape
    {
        string Name { get; set; }
        double Area();
        double Perimeter();
    }

}
