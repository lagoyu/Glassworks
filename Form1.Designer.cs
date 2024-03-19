namespace HowMuchGlass
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nudGlassHeight = new System.Windows.Forms.NumericUpDown();
            this.nudBaseHeight = new System.Windows.Forms.NumericUpDown();
            this.nudDiameter = new System.Windows.Forms.NumericUpDown();
            this.nudGlassThickness = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labVolumeNeeded = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labGlassCapacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlassHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlassThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // nudGlassHeight
            // 
            this.nudGlassHeight.DecimalPlaces = 2;
            this.nudGlassHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudGlassHeight.Location = new System.Drawing.Point(15, 66);
            this.nudGlassHeight.Name = "nudGlassHeight";
            this.nudGlassHeight.Size = new System.Drawing.Size(60, 20);
            this.nudGlassHeight.TabIndex = 0;
            this.nudGlassHeight.Value = new decimal(new int[] {
            115,
            0,
            0,
            65536});
            this.nudGlassHeight.ValueChanged += new System.EventHandler(this.nudParametersChanged);
            // 
            // nudBaseHeight
            // 
            this.nudBaseHeight.DecimalPlaces = 2;
            this.nudBaseHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudBaseHeight.Location = new System.Drawing.Point(15, 98);
            this.nudBaseHeight.Name = "nudBaseHeight";
            this.nudBaseHeight.Size = new System.Drawing.Size(60, 20);
            this.nudBaseHeight.TabIndex = 1;
            this.nudBaseHeight.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.nudBaseHeight.ValueChanged += new System.EventHandler(this.nudParametersChanged);
            // 
            // nudDiameter
            // 
            this.nudDiameter.DecimalPlaces = 2;
            this.nudDiameter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudDiameter.Location = new System.Drawing.Point(15, 130);
            this.nudDiameter.Name = "nudDiameter";
            this.nudDiameter.Size = new System.Drawing.Size(60, 20);
            this.nudDiameter.TabIndex = 2;
            this.nudDiameter.Value = new decimal(new int[] {
            54,
            0,
            0,
            65536});
            this.nudDiameter.ValueChanged += new System.EventHandler(this.nudParametersChanged);
            // 
            // nudGlassThickness
            // 
            this.nudGlassThickness.DecimalPlaces = 2;
            this.nudGlassThickness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudGlassThickness.Location = new System.Drawing.Point(15, 162);
            this.nudGlassThickness.Name = "nudGlassThickness";
            this.nudGlassThickness.Size = new System.Drawing.Size(60, 20);
            this.nudGlassThickness.TabIndex = 3;
            this.nudGlassThickness.Value = new decimal(new int[] {
            2,
            0,
            0,
            65536});
            this.nudGlassThickness.ValueChanged += new System.EventHandler(this.nudParametersChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "whole glass height";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "base height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "outside diameter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "wall thickness";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Enter values in cm";
            // 
            // labVolumeNeeded
            // 
            this.labVolumeNeeded.AutoSize = true;
            this.labVolumeNeeded.Location = new System.Drawing.Point(12, 210);
            this.labVolumeNeeded.Name = "labVolumeNeeded";
            this.labVolumeNeeded.Size = new System.Drawing.Size(119, 13);
            this.labVolumeNeeded.TabIndex = 10;
            this.labVolumeNeeded.Text = "volume of glass needed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HowMuchGlass.Properties.Resources.Tumbler;
            this.pictureBox1.Location = new System.Drawing.Point(195, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 272);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labGlassCapacity
            // 
            this.labGlassCapacity.AutoSize = true;
            this.labGlassCapacity.Location = new System.Drawing.Point(12, 234);
            this.labGlassCapacity.Name = "labGlassCapacity";
            this.labGlassCapacity.Size = new System.Drawing.Size(96, 13);
            this.labGlassCapacity.TabIndex = 12;
            this.labGlassCapacity.Text = "max glass capacity";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 289);
            this.Controls.Add(this.labGlassCapacity);
            this.Controls.Add(this.labVolumeNeeded);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudGlassThickness);
            this.Controls.Add(this.nudDiameter);
            this.Controls.Add(this.nudBaseHeight);
            this.Controls.Add(this.nudGlassHeight);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "How much glass? ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudGlassHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBaseHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGlassThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudGlassHeight;
        private System.Windows.Forms.NumericUpDown nudBaseHeight;
        private System.Windows.Forms.NumericUpDown nudDiameter;
        private System.Windows.Forms.NumericUpDown nudGlassThickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labVolumeNeeded;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labGlassCapacity;
    }
}

