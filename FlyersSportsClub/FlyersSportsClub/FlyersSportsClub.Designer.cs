namespace FlyersSportsClub
{
    partial class FlyersSportsClub
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
            this.checkBoxSkis = new System.Windows.Forms.CheckBox();
            this.checkBoxPoles = new System.Windows.Forms.CheckBox();
            this.checkBoxBoots = new System.Windows.Forms.CheckBox();
            this.checkBoxGoggles = new System.Windows.Forms.CheckBox();
            this.checkBoxGloves = new System.Windows.Forms.CheckBox();
            this.checkBoxEarmuffs = new System.Windows.Forms.CheckBox();
            this.listBoxItemize = new System.Windows.Forms.ListBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelInstructions = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fAQToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelMemberNo = new System.Windows.Forms.Label();
            this.checkBoxCharge = new System.Windows.Forms.CheckBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxMemberNo = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxSkis
            // 
            this.checkBoxSkis.AutoSize = true;
            this.checkBoxSkis.Location = new System.Drawing.Point(381, 229);
            this.checkBoxSkis.Name = "checkBoxSkis";
            this.checkBoxSkis.Size = new System.Drawing.Size(65, 24);
            this.checkBoxSkis.TabIndex = 1;
            this.checkBoxSkis.Text = "Skis";
            this.checkBoxSkis.UseVisualStyleBackColor = true;
            this.checkBoxSkis.CheckedChanged += new System.EventHandler(this.AddToListbox_CheckedChanged);
            // 
            // checkBoxPoles
            // 
            this.checkBoxPoles.AutoSize = true;
            this.checkBoxPoles.Location = new System.Drawing.Point(381, 259);
            this.checkBoxPoles.Name = "checkBoxPoles";
            this.checkBoxPoles.Size = new System.Drawing.Size(74, 24);
            this.checkBoxPoles.TabIndex = 2;
            this.checkBoxPoles.Text = "Poles";
            this.checkBoxPoles.UseVisualStyleBackColor = true;
            this.checkBoxPoles.CheckedChanged += new System.EventHandler(this.AddToListbox_CheckedChanged);
            // 
            // checkBoxBoots
            // 
            this.checkBoxBoots.AutoSize = true;
            this.checkBoxBoots.Location = new System.Drawing.Point(381, 289);
            this.checkBoxBoots.Name = "checkBoxBoots";
            this.checkBoxBoots.Size = new System.Drawing.Size(77, 24);
            this.checkBoxBoots.TabIndex = 3;
            this.checkBoxBoots.Text = "Boots";
            this.checkBoxBoots.UseVisualStyleBackColor = true;
            this.checkBoxBoots.CheckedChanged += new System.EventHandler(this.AddToListbox_CheckedChanged);
            // 
            // checkBoxGoggles
            // 
            this.checkBoxGoggles.AutoSize = true;
            this.checkBoxGoggles.Location = new System.Drawing.Point(381, 319);
            this.checkBoxGoggles.Name = "checkBoxGoggles";
            this.checkBoxGoggles.Size = new System.Drawing.Size(95, 24);
            this.checkBoxGoggles.TabIndex = 4;
            this.checkBoxGoggles.Text = "Goggles";
            this.checkBoxGoggles.UseVisualStyleBackColor = true;
            this.checkBoxGoggles.CheckedChanged += new System.EventHandler(this.AddToListbox_CheckedChanged);
            // 
            // checkBoxGloves
            // 
            this.checkBoxGloves.AutoSize = true;
            this.checkBoxGloves.Location = new System.Drawing.Point(381, 352);
            this.checkBoxGloves.Name = "checkBoxGloves";
            this.checkBoxGloves.Size = new System.Drawing.Size(84, 24);
            this.checkBoxGloves.TabIndex = 5;
            this.checkBoxGloves.Text = "Gloves";
            this.checkBoxGloves.UseVisualStyleBackColor = true;
            this.checkBoxGloves.CheckedChanged += new System.EventHandler(this.AddToListbox_CheckedChanged);
            // 
            // checkBoxEarmuffs
            // 
            this.checkBoxEarmuffs.AutoSize = true;
            this.checkBoxEarmuffs.Location = new System.Drawing.Point(381, 382);
            this.checkBoxEarmuffs.Name = "checkBoxEarmuffs";
            this.checkBoxEarmuffs.Size = new System.Drawing.Size(100, 24);
            this.checkBoxEarmuffs.TabIndex = 6;
            this.checkBoxEarmuffs.Text = "Earmuffs";
            this.checkBoxEarmuffs.UseVisualStyleBackColor = true;
            this.checkBoxEarmuffs.CheckedChanged += new System.EventHandler(this.AddToListbox_CheckedChanged);
            // 
            // listBoxItemize
            // 
            this.listBoxItemize.FormattingEnabled = true;
            this.listBoxItemize.ItemHeight = 20;
            this.listBoxItemize.Location = new System.Drawing.Point(516, 232);
            this.listBoxItemize.Name = "listBoxItemize";
            this.listBoxItemize.Size = new System.Drawing.Size(301, 204);
            this.listBoxItemize.TabIndex = 6;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(592, 444);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(150, 100);
            this.buttonSubmit.TabIndex = 7;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(381, 438);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 30);
            this.buttonClear.TabIndex = 8;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Location = new System.Drawing.Point(377, 196);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(267, 20);
            this.labelInstructions.TabIndex = 9;
            this.labelInstructions.Text = "Select rental items for member price.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submitToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // submitToolStripMenuItem
            // 
            this.submitToolStripMenuItem.Name = "submitToolStripMenuItem";
            this.submitToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.submitToolStripMenuItem.Text = "&Submit";
            this.submitToolStripMenuItem.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.clearToolStripMenuItem.Text = "Clea&r";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(153, 30);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fAQToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // fAQToolStripMenuItem
            // 
            this.fAQToolStripMenuItem.Name = "fAQToolStripMenuItem";
            this.fAQToolStripMenuItem.Size = new System.Drawing.Size(130, 30);
            this.fAQToolStripMenuItem.Text = "FA&Q";
            this.fAQToolStripMenuItem.Click += new System.EventHandler(this.fAQToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FlyersSportsClub.Properties.Resources.Sugar_Mountain;
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(435, 132);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(27, 232);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(86, 20);
            this.labelFirstName.TabIndex = 11;
            this.labelFirstName.Text = "First Name";
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(27, 275);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(86, 20);
            this.labelLastName.TabIndex = 12;
            this.labelLastName.Text = "Last Name";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(27, 318);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(55, 20);
            this.labelPhone.TabIndex = 13;
            this.labelPhone.Text = "Phone";
            // 
            // labelMemberNo
            // 
            this.labelMemberNo.AutoSize = true;
            this.labelMemberNo.Location = new System.Drawing.Point(27, 361);
            this.labelMemberNo.Name = "labelMemberNo";
            this.labelMemberNo.Size = new System.Drawing.Size(95, 20);
            this.labelMemberNo.TabIndex = 14;
            this.labelMemberNo.Text = "Member No.";
            // 
            // checkBoxCharge
            // 
            this.checkBoxCharge.AutoSize = true;
            this.checkBoxCharge.Location = new System.Drawing.Point(31, 444);
            this.checkBoxCharge.Name = "checkBoxCharge";
            this.checkBoxCharge.Size = new System.Drawing.Size(168, 24);
            this.checkBoxCharge.TabIndex = 15;
            this.checkBoxCharge.Text = "Charge to Account";
            this.checkBoxCharge.UseVisualStyleBackColor = true;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(168, 229);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 26);
            this.textBoxFirstName.TabIndex = 16;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(168, 272);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 26);
            this.textBoxLastName.TabIndex = 17;
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(168, 315);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 26);
            this.textBoxPhone.TabIndex = 18;
            // 
            // textBoxMemberNo
            // 
            this.textBoxMemberNo.Location = new System.Drawing.Point(168, 358);
            this.textBoxMemberNo.Name = "textBoxMemberNo";
            this.textBoxMemberNo.Size = new System.Drawing.Size(100, 26);
            this.textBoxMemberNo.TabIndex = 19;
            // 
            // FlyersSportsClub
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 644);
            this.Controls.Add(this.textBoxMemberNo);
            this.Controls.Add(this.textBoxPhone);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.checkBoxCharge);
            this.Controls.Add(this.labelMemberNo);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelFirstName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelInstructions);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.listBoxItemize);
            this.Controls.Add(this.checkBoxEarmuffs);
            this.Controls.Add(this.checkBoxGloves);
            this.Controls.Add(this.checkBoxGoggles);
            this.Controls.Add(this.checkBoxBoots);
            this.Controls.Add(this.checkBoxPoles);
            this.Controls.Add(this.checkBoxSkis);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FlyersSportsClub";
            this.Text = "Sign Up Sheet";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxSkis;
        private System.Windows.Forms.CheckBox checkBoxPoles;
        private System.Windows.Forms.CheckBox checkBoxBoots;
        private System.Windows.Forms.CheckBox checkBoxGoggles;
        private System.Windows.Forms.CheckBox checkBoxGloves;
        private System.Windows.Forms.CheckBox checkBoxEarmuffs;
        private System.Windows.Forms.ListBox listBoxItemize;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fAQToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelMemberNo;
        private System.Windows.Forms.CheckBox checkBoxCharge;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxMemberNo;
    }
}

