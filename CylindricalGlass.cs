using System;
namespace HowMuchGlass
{
    class CylindricalGlass
    {
        const decimal PI = (decimal) Math.PI;

        public decimal OutsideDiameter { get; set; }
        public decimal Height { get; set; }
        public decimal Thickness { get; set; }
        public decimal BaseHeight { get; set; }

        private decimal CircleArea(decimal diameter) 
        {
            decimal radius = diameter / 2.0m;
            return PI * radius * radius;
        }

        public decimal MaxDrinkVolume
        {
            get 
            {
                return CircleArea(OutsideDiameter - 2.0m * Thickness) * (Height-BaseHeight);
            }

        }

        public decimal GlassMaterialVolume
        { 
            get
            {
                decimal solidCylinderVolume = CircleArea(OutsideDiameter) * Height;
                return solidCylinderVolume - MaxDrinkVolume;
            }
        }
    }
}
