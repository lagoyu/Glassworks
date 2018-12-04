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
            decimal glassNeeded = (numDiameter.Value) * (numDiameter.Value) * PI * numBaseHeight.Value 
                + (numGlassHeight.Value - numBaseHeight.Value) * 2 * PI * numDiameter.Value * numGlassThickness.Value;
            labGlassNeeded.Text = glassNeeded.ToString("F2") + "ml of glass needed.";
            decimal liquidCapacity = (numGlassHeight.Value - numBaseHeight.Value) * 
                (numDiameter.Value / 2) * (numDiameter.Value / 2) * PI;
            labGlassCapacity.Text = liquidCapacity.ToString("F2") + "ml liquid capacity.";
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
