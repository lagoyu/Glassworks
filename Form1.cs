using System;
using System.Windows.Forms;
namespace HowMuchGlass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateVolumeOutputs();
        }

        private void UpdateVolumeOutputs()
        {
            decimal OUT1 = (numDiameter.Value) * (numDiameter.Value) * 3.1416M * numBaseHeight.Value + (numGlassHeight.Value - numBaseHeight.Value) * 6.2832M * numDiameter.Value * numGlassThickness.Value;
            labGlassNeeded.Text = OUT1.ToString("F2") + "ml of glass needed.";
            decimal OUT2 = (numGlassHeight.Value - numBaseHeight.Value) * (numDiameter.Value / 2) * (numDiameter.Value / 2) * 3.1416M; labGlassCapacity.Text = OUT2.ToString("F2") + "ml liquid capacity.";
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            UpdateVolumeOutputs();
        }
        private void NumericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            UpdateVolumeOutputs();
        }
        private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            UpdateVolumeOutputs();
        }
        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            UpdateVolumeOutputs();
        }
    }
}
