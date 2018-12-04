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
            this.numGlassHeight = new System.Windows.Forms.NumericUpDown();
            this.numBaseHeight = new System.Windows.Forms.NumericUpDown();
            this.numDiameter = new System.Windows.Forms.NumericUpDown();
            this.numGlassThickness = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labGlassNeeded = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labGlassCapacity = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numGlassHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGlassThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numGlassHeight
            // 
            this.numGlassHeight.DecimalPlaces = 2;
            this.numGlassHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numGlassHeight.Location = new System.Drawing.Point(15, 66);
            this.numGlassHeight.Name = "numGlassHeight";
            this.numGlassHeight.Size = new System.Drawing.Size(60, 20);
            this.numGlassHeight.TabIndex = 0;
            this.numGlassHeight.Value = new decimal(new int[] {
            135,
            0,
            0,
            65536});
            this.numGlassHeight.ValueChanged += new System.EventHandler(this.NumericUpDown1_ValueChanged);
            // 
            // numBaseHeight
            // 
            this.numBaseHeight.DecimalPlaces = 2;
            this.numBaseHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numBaseHeight.Location = new System.Drawing.Point(15, 98);
            this.numBaseHeight.Name = "numBaseHeight";
            this.numBaseHeight.Size = new System.Drawing.Size(60, 20);
            this.numBaseHeight.TabIndex = 1;
            this.numBaseHeight.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            this.numBaseHeight.ValueChanged += new System.EventHandler(this.NumericUpDown3_ValueChanged);
            // 
            // numDiameter
            // 
            this.numDiameter.DecimalPlaces = 2;
            this.numDiameter.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numDiameter.Location = new System.Drawing.Point(15, 130);
            this.numDiameter.Name = "numDiameter";
            this.numDiameter.Size = new System.Drawing.Size(60, 20);
            this.numDiameter.TabIndex = 2;
            this.numDiameter.Value = new decimal(new int[] {
            59,
            0,
            0,
            65536});
            this.numDiameter.ValueChanged += new System.EventHandler(this.NumericUpDown2_ValueChanged);
            // 
            // numGlassThickness
            // 
            this.numGlassThickness.DecimalPlaces = 2;
            this.numGlassThickness.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numGlassThickness.Location = new System.Drawing.Point(15, 162);
            this.numGlassThickness.Name = "numGlassThickness";
            this.numGlassThickness.Size = new System.Drawing.Size(60, 20);
            this.numGlassThickness.TabIndex = 3;
            this.numGlassThickness.Value = new decimal(new int[] {
            11,
            0,
            0,
            131072});
            this.numGlassThickness.ValueChanged += new System.EventHandler(this.NumericUpDown4_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "glass height";
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
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "diameter";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "glass thickness";
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
            // labGlassNeeded
            // 
            this.labGlassNeeded.AutoSize = true;
            this.labGlassNeeded.Location = new System.Drawing.Point(12, 210);
            this.labGlassNeeded.Name = "labGlassNeeded";
            this.labGlassNeeded.Size = new System.Drawing.Size(119, 13);
            this.labGlassNeeded.TabIndex = 10;
            this.labGlassNeeded.Text = "volume of glass needed";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HowMuchGlass.Properties.Resources.Tumbler;
            this.pictureBox1.Location = new System.Drawing.Point(166, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 272);
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
            this.Controls.Add(this.labGlassNeeded);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numGlassThickness);
            this.Controls.Add(this.numDiameter);
            this.Controls.Add(this.numBaseHeight);
            this.Controls.Add(this.numGlassHeight);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "How much glass? ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numGlassHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numBaseHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGlassThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numGlassHeight;
        private System.Windows.Forms.NumericUpDown numBaseHeight;
        private System.Windows.Forms.NumericUpDown numDiameter;
        private System.Windows.Forms.NumericUpDown numGlassThickness;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labGlassNeeded;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labGlassCapacity;
    }
}

