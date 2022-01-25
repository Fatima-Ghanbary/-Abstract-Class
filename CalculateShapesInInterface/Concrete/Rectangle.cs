using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapesInInterface.Concrete
{
    public class Rectangle : IShape
    {
        /// <summary>
        /// name of  shape
        /// </summary>
        public string Name { get; set; }
        public int  Length { get; set; }
        public int Height { get; set; }
        public double Area()
        {
            return Height * Length;
        }
        public double Perimeter()
        {
            return (Height + Length) * 2;
        }
    }
}
