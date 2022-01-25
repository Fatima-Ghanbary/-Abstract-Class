using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateShapesInInterface.Concrete
{
    public class Triangle : IShape
    {
        /// <summary>
        /// Name of Shape:Isosceles Triangle
        /// </summary>
        public string Name { get; set; } = "Triangle";
        /// <summary>
        /// base of triangle
        /// </summary>
        public int TriangleBase { get; set; }
        /// <summary>
        /// height of triangle
        /// </summary>
        public int Height { get; set; }
        /// <summary>
        /// calculate Area of Isosceles Triangle
        /// </summary>
        /// <returns></returns>
        public double Area()
        {
            return (Height * TriangleBase) / 2;
        }
        /// <summary>
        /// calculate perimeter of Isosceles Triangle
        /// </summary>
        /// <returns></returns>
        public double Perimeter()
        {
            return 2 * TriangleBase + Height;
        }
    }
}
