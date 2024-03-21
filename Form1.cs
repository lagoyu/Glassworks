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
            // Instantiate the glass which this form is designed to work with
            myGlass = new CylindricalGlass();

            // Initial property values come from the defaults set in the UI
            UpdateGlassFromInputs(myGlass);
            UpdateOutputsFromGlass(myGlass);
        }

        private void nudParametersChanged(object sender, EventArgs e)
        {
            // Glass properties need to be updated and results displayed
            UpdateGlassFromInputs(myGlass);
            UpdateOutputsFromGlass(myGlass);
        }

        private void UpdateGlassFromInputs(CylindricalGlass glass)
        {
            // Called to update the glass properties when the form is initialised
            // and when inputs are changed by the user
            glass.TotalHeight = nudTotalHeight.Value;
            glass.BaseHeight = nudBaseHeight.Value;
            glass.OutsideDiameter = nudDiameter.Value;
            glass.WallThickness = nudWallThickness.Value;
        }

        private void UpdateOutputsFromGlass(CylindricalGlass glass)
        {
            // Display calculated properties used from the glass object
            labMaterialVolume.Text = glass.MaterialVolume.ToString("F2") + "ml of glass needed.";
            labLiquidCapacity.Text = glass.LiquidCapacity.ToString("F2") + "ml liquid capacity.";
        }
    }
}
