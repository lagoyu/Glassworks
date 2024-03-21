using System;
namespace HowMuchGlass
{
    class CylindricalGlass
    {
        // We need a decimal version of PI for use when calculating with decimals
        // Math.PI is only 18 bit precision but that is sufficient for this program
        const decimal PI = (decimal) Math.PI;

        // All measurements are in centimetres and volumes in millilitres
        // Range of values could have been constrained to a range in setters but have not been
        public decimal OutsideDiameter { get; set; }
        public decimal TotalHeight { get; set; }
        public decimal WallThickness { get; set; }
        public decimal BaseHeight { get; set; }

        private decimal CircleArea(decimal diameter) 
        {
            decimal radius = diameter / 2.0m;

            // cm squared
            return PI * radius * radius;
        }

        public decimal LiquidCapacity
        {
            // millilitres (cubic centimetres)
            get
            {
                // inside diameter subtracts thickness of two walls
                return CircleArea(OutsideDiameter - 2.0m * WallThickness) * (TotalHeight-BaseHeight);
            }

        }

        public decimal MaterialVolume
        { 
            // millilitres (cubic centimetres)
            get
            {
                decimal solidCylinderVolume = CircleArea(OutsideDiameter) * TotalHeight;
                return solidCylinderVolume - LiquidCapacity;
            }
        }
    }
}
