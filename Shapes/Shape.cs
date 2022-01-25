using System;

namespace Shapes
{
    /// <summary>
    /// abstract Class Shape to Calculate Area and Circumference of shapes
    /// </summary>
    public abstract class Shape
    {
        /// <summary>
        /// Unic ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// ShapesName
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        ///Method to Calculate Area
        /// </summary>
        public abstract double Area();
        /// <summary>
        ///Method to Calculate Circumference
        /// </summary>
        /// <returns>Envoirment</returns>
        public abstract double Circumference();

    }
}
