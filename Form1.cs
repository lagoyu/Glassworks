using System;
using System.Windows.Forms;
namespace HowMuchGlass
{
    public partial class GlassForm : Form
    {
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
            decimal OUT1 = (numDiameter.Value) * (numDiameter.Value) * 3.1416M * numBaseHeight.Value + (numGlassHeight.Value - numBaseHeight.Value) * 6.2832M * numDiameter.Value * numGlassThickness.Value;
            labGlassNeeded.Text = OUT1.ToString("F2") + "ml of glass needed.";
            decimal OUT2 = (numGlassHeight.Value - numBaseHeight.Value) * (numDiameter.Value / 2) * (numDiameter.Value / 2) * 3.1416M; labGlassCapacity.Text = OUT2.ToString("F2") + "ml liquid capacity.";
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
