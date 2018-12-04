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
            // There are two errors in this calculation
            decimal glassNeeded = (numDiameter.Value) * (numDiameter.Value) * PI * numBaseHeight.Value 
                + (numGlassHeight.Value - numBaseHeight.Value) * 2 * PI * numDiameter.Value * numGlassThickness.Value;
            const string TWO_DECIMAL_PLACES = "F2";
            labGlassNeeded.Text = glassNeeded.ToString(TWO_DECIMAL_PLACES) + "ml of glass needed.";
            // This calculation appears to be correct
            decimal liquidCapacity = (numGlassHeight.Value - numBaseHeight.Value) * 
                (numDiameter.Value / 2) * (numDiameter.Value / 2) * PI;
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
