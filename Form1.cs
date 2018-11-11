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
private void Form1_Load(object sender, EventArgs e){   decimal OUT1 = (NumericUpDown2.Value) * (NumericUpDown2.Value) * 3.1416M * NumericUpDown3.Value + (NumericUpDown1.Value - NumericUpDown3.Value) * 6.2832M * NumericUpDown2.Value * NumericUpDown4.Value;
Label6.Text = OUT1.ToString("F2") + "ml of glass needed.";  
decimal OUT2 = (NumericUpDown1.Value - NumericUpDown3.Value) * (NumericUpDown2.Value/2) * (NumericUpDown2.Value/2) * 3.1416M; Label7.Text = OUT2.ToString("F2") + "ml liquid capacity.";    
}
private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

            decimal OUT1 = (NumericUpDown2.Value) * (NumericUpDown2.Value) * 3.1416M * NumericUpDown3.Value + (NumericUpDown1.Value - NumericUpDown3.Value) * 6.2832M * NumericUpDown2.Value * NumericUpDown4.Value;
Label6.Text = OUT1.ToString("F2") + "ml of glass needed.";
decimal OUT2 = (NumericUpDown1.Value - NumericUpDown3.Value) * (NumericUpDown2.Value/2) * (NumericUpDown2.Value/2) * 3.1416M; Label7.Text = OUT2.ToString("F2") + "ml liquid capacity.";
}
        private void NumericUpDown3_ValueChanged(object sender, EventArgs e){
             decimal OUT1 = (NumericUpDown2.Value) * (NumericUpDown2.Value) * 3.1416M * NumericUpDown3.Value + (NumericUpDown1.Value - NumericUpDown3.Value) * 6.2832M * NumericUpDown2.Value * NumericUpDown4.Value;
                Label6.Text = OUT1.ToString("F2") + "ml of glass needed.";
                decimal OUT2 = (NumericUpDown1.Value - NumericUpDown3.Value) * (NumericUpDown2.Value/2) * (NumericUpDown2.Value/2) * 3.1416M; Label7.Text = OUT2.ToString("F2") + "ml liquid capacity.";
            }
private void NumericUpDown2_ValueChanged(object sender, EventArgs e)
{
decimal OUT1 = (NumericUpDown2.Value) * (NumericUpDown2.Value) * 3.1416M * NumericUpDown3.Value + (NumericUpDown1.Value - NumericUpDown3.Value) * 6.2832M * NumericUpDown2.Value * NumericUpDown4.Value;
Label6.Text = OUT1.ToString("F2") + "ml of glass needed.";
decimal OUT2 = (NumericUpDown1.Value - NumericUpDown3.Value) * (NumericUpDown2.Value/2) * (NumericUpDown2.Value/2) * 3.1416M;Label7.Text = OUT2.ToString("F2") + "ml liquid capacity.";
}
        private void NumericUpDown4_ValueChanged(object sender, EventArgs e)
        {
        decimal OUT1 = (NumericUpDown2.Value) * (NumericUpDown2.Value) * 3.1416M * NumericUpDown3.Value + (NumericUpDown1.Value - NumericUpDown3.Value) * 6.2832M * NumericUpDown2.Value * NumericUpDown4.Value;
        Label6.Text = OUT1.ToString("F2") + "ml of glass needed.";
        decimal OUT2 = (NumericUpDown1.Value - NumericUpDown3.Value) * (NumericUpDown2.Value/2) * (NumericUpDown2.Value/2) * 3.1416M;Label7.Text = OUT2.ToString("F2") + "ml liquid capacity.";
        }
}}
