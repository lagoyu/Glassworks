using System;
using System.Windows.Forms;
namespace HowMuchGlass
{
    public partial class GlassForm : Form
    {
        // Must use cast to decimal rather than conversion because constant values cannot include method calls
        private const decimal PI = (decimal) Math.PI;

        public GlassForm()
        {
            InitializeComponent();
        }
        private void GlassForm_Load(object sender, EventArgs e)
        {
            UpdateVolumeOutputs();
        }

        private void UpdateVolumeOutputs()
        {
            decimal radius = numDiameter.Value / 2;
            decimal tubeHeight = numGlassHeight.Value - numBaseHeight.Value;
            const string TWO_DECIMAL_PLACES = "F2";
            
            // Errors fixed to use radius instead of diameter in two places
            decimal glassNeeded = radius * radius * PI * numBaseHeight.Value 
                + tubeHeight * 2 * PI * radius * numGlassThickness.Value;
            labGlassNeeded.Text = glassNeeded.ToString(TWO_DECIMAL_PLACES) + "ml of glass needed.";

            decimal liquidCapacity = tubeHeight * radius * radius * PI;
            labGlassCapacity.Text = liquidCapacity.ToString(TWO_DECIMAL_PLACES) + "ml liquid capacity.";
        }

        private void numGlassHeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateVolumeOutputs();
        }
        private void numBaseHeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateVolumeOutputs();
        }
        private void numDiameter_ValueChanged(object sender, EventArgs e)
        {
            UpdateVolumeOutputs();
        }
        private void numGlassThickness_ValueChanged(object sender, EventArgs e)
        {
            UpdateVolumeOutputs();
        }
    }
}
