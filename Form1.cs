using System;
using System.Windows.Forms;
namespace HowMuchGlass
{
    public partial class Form1 : Form
    {
        CylindricalGlass myGlass;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            myGlass = new CylindricalGlass();
            UpdateGlassFromInputs(myGlass);

        }

        private void UpdateGlassFromInputs(CylindricalGlass glass)
        {
            glass.Height = nudGlassHeight.Value;
            glass.BaseHeight = nudBaseHeight.Value;
            glass.OutsideDiameter = nudDiameter.Value;
            glass.Thickness = nudGlassThickness.Value;

        }

        private void nudParametersChanged(object sender, EventArgs e)
        {
            UpdateGlassFromInputs(myGlass);
            UpdateOutputsFromGlass(myGlass);
        }

        private void UpdateOutputsFromGlass(CylindricalGlass glass)
        {
            labVolumeNeeded.Text = glass.GlassMaterialVolume.ToString("F2") + "ml of glass needed.";
            labGlassCapacity.Text = glass.MaxDrinkVolume.ToString("F2") + "ml liquid capacity.";
        }
    }
}
