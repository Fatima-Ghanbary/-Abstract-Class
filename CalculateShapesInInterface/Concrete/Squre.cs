using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapesInInterface.Concrete
{
    public class Squre : IShape
    {
        /// <summary>
        /// name of shape
        /// </summary>
        public string Name { get; set; } = "Squre";
        /// <summary>
        /// side of squre
        /// </summary>
        public int SideLength { get; set; }
        /// <summary>
        /// area of squre
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return SideLength * SideLength;
        }
        /// <summary>
        /// perimeter of squre
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            return SideLength * 4;
        }
    }
}
