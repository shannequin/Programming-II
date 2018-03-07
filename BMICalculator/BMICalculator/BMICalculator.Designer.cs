namespace BMICalculator
{
    partial class BMICalculator
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
            this.groupBoxInputType = new System.Windows.Forms.GroupBox();
            this.radioButtonMetric = new System.Windows.Forms.RadioButton();
            this.radioButtonImperial = new System.Windows.Forms.RadioButton();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.labelWeightUnits = new System.Windows.Forms.Label();
            this.labelHeightUnits = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.groupBoxInputType.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxInputType
            // 
            this.groupBoxInputType.Controls.Add(this.radioButtonMetric);
            this.groupBoxInputType.Controls.Add(this.radioButtonImperial);
            this.groupBoxInputType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxInputType.Location = new System.Drawing.Point(168, 128);
            this.groupBoxInputType.Name = "groupBoxInputType";
            this.groupBoxInputType.Size = new System.Drawing.Size(200, 100);
            this.groupBoxInputType.TabIndex = 0;
            this.groupBoxInputType.TabStop = false;
            this.groupBoxInputType.Text = "Choose Input Type";
            // 
            // radioButtonMetric
            // 
            this.radioButtonMetric.AutoSize = true;
            this.radioButtonMetric.Location = new System.Drawing.Point(32, 62);
            this.radioButtonMetric.Name = "radioButtonMetric";
            this.radioButtonMetric.Size = new System.Drawing.Size(79, 28);
            this.radioButtonMetric.TabIndex = 1;
            this.radioButtonMetric.TabStop = true;
            this.radioButtonMetric.Text = "Metric";
            this.radioButtonMetric.UseVisualStyleBackColor = true;
            // 
            // radioButtonImperial
            // 
            this.radioButtonImperial.AutoSize = true;
            this.radioButtonImperial.Location = new System.Drawing.Point(32, 28);
            this.radioButtonImperial.Name = "radioButtonImperial";
            this.radioButtonImperial.Size = new System.Drawing.Size(94, 28);
            this.radioButtonImperial.TabIndex = 0;
            this.radioButtonImperial.TabStop = true;
            this.radioButtonImperial.Text = "Imperial";
            this.radioButtonImperial.UseVisualStyleBackColor = true;
            this.radioButtonImperial.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeight.Location = new System.Drawing.Point(145, 276);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(79, 24);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Weight: ";
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeight.Location = new System.Drawing.Point(149, 306);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(75, 24);
            this.labelHeight.TabIndex = 2;
            this.labelHeight.Text = "Height: ";
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWeight.Location = new System.Drawing.Point(226, 273);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(100, 29);
            this.textBoxWeight.TabIndex = 0;
            this.textBoxWeight.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHeight.Location = new System.Drawing.Point(226, 303);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 29);
            this.textBoxHeight.TabIndex = 1;
            this.textBoxHeight.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // labelWeightUnits
            // 
            this.labelWeightUnits.AutoSize = true;
            this.labelWeightUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeightUnits.Location = new System.Drawing.Point(332, 276);
            this.labelWeightUnits.Name = "labelWeightUnits";
            this.labelWeightUnits.Size = new System.Drawing.Size(115, 24);
            this.labelWeightUnits.TabIndex = 5;
            this.labelWeightUnits.Text = "Weight Units";
            // 
            // labelHeightUnits
            // 
            this.labelHeightUnits.AutoSize = true;
            this.labelHeightUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeightUnits.Location = new System.Drawing.Point(332, 306);
            this.labelHeightUnits.Name = "labelHeightUnits";
            this.labelHeightUnits.Size = new System.Drawing.Size(111, 24);
            this.labelHeightUnits.TabIndex = 6;
            this.labelHeightUnits.Text = "Height Units";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.Location = new System.Drawing.Point(146, 405);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(100, 50);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClear.Location = new System.Drawing.Point(291, 405);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(100, 50);
            this.buttonClear.TabIndex = 3;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.Location = new System.Drawing.Point(46, 57);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(444, 24);
            this.labelInstructions.TabIndex = 10;
            this.labelInstructions.Text = "Fill out form to calculate your Body Mass Index";
            // 
            // BMICalculator
            // 
            this.AcceptButton = this.buttonCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 516);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.labelHeightUnits);
            this.Controls.Add(this.labelWeightUnits);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.groupBoxInputType);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BMICalculator";
            this.Text = "Body Mass Index Calculator";
            this.groupBoxInputType.ResumeLayout(false);
            this.groupBoxInputType.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxInputType;
        private System.Windows.Forms.RadioButton radioButtonMetric;
        private System.Windows.Forms.RadioButton radioButtonImperial;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.Label labelWeightUnits;
        private System.Windows.Forms.Label labelHeightUnits;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label labelInstructions;
    }
}

