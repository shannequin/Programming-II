namespace CampusEvents2
{
    partial class CampusEvents
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
            this.groupBoxEventButtons = new System.Windows.Forms.GroupBox();
            this.buttonFootball = new System.Windows.Forms.Button();
            this.buttonFairs = new System.Windows.Forms.Button();
            this.buttonPlays = new System.Windows.Forms.Button();
            this.groupBoxEventNames = new System.Windows.Forms.GroupBox();
            this.radioButtonEvent2 = new System.Windows.Forms.RadioButton();
            this.radioButtonEvent1 = new System.Windows.Forms.RadioButton();
            this.groupBoxEventInfo = new System.Windows.Forms.GroupBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.buttonGetTicket = new System.Windows.Forms.Button();
            this.labelSeatSelection = new System.Windows.Forms.Label();
            this.listBoxSeatSelection = new System.Windows.Forms.ListBox();
            this.checkBoxExtra1 = new System.Windows.Forms.CheckBox();
            this.checkBoxExtra2 = new System.Windows.Forms.CheckBox();
            this.labelDateTime = new System.Windows.Forms.Label();
            this.labelEventLocation = new System.Windows.Forms.Label();
            this.labelEventName = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxEventButtons.SuspendLayout();
            this.groupBoxEventNames.SuspendLayout();
            this.groupBoxEventInfo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxEventButtons
            // 
            this.groupBoxEventButtons.Controls.Add(this.buttonFootball);
            this.groupBoxEventButtons.Controls.Add(this.buttonFairs);
            this.groupBoxEventButtons.Controls.Add(this.buttonPlays);
            this.groupBoxEventButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventButtons.Location = new System.Drawing.Point(92, 35);
            this.groupBoxEventButtons.Name = "groupBoxEventButtons";
            this.groupBoxEventButtons.Size = new System.Drawing.Size(800, 100);
            this.groupBoxEventButtons.TabIndex = 0;
            this.groupBoxEventButtons.TabStop = false;
            this.groupBoxEventButtons.Text = "Select Event Type";
            // 
            // buttonFootball
            // 
            this.buttonFootball.Location = new System.Drawing.Point(647, 28);
            this.buttonFootball.Name = "buttonFootball";
            this.buttonFootball.Size = new System.Drawing.Size(100, 50);
            this.buttonFootball.TabIndex = 2;
            this.buttonFootball.Text = "Football";
            this.buttonFootball.UseVisualStyleBackColor = true;
            this.buttonFootball.Click += new System.EventHandler(this.buttonEventType_Click);
            // 
            // buttonFairs
            // 
            this.buttonFairs.Location = new System.Drawing.Point(350, 28);
            this.buttonFairs.Name = "buttonFairs";
            this.buttonFairs.Size = new System.Drawing.Size(100, 50);
            this.buttonFairs.TabIndex = 1;
            this.buttonFairs.Text = "Fairs";
            this.buttonFairs.UseVisualStyleBackColor = true;
            this.buttonFairs.Click += new System.EventHandler(this.buttonEventType_Click);
            // 
            // buttonPlays
            // 
            this.buttonPlays.Location = new System.Drawing.Point(53, 28);
            this.buttonPlays.Name = "buttonPlays";
            this.buttonPlays.Size = new System.Drawing.Size(100, 50);
            this.buttonPlays.TabIndex = 0;
            this.buttonPlays.Text = "Plays";
            this.buttonPlays.UseVisualStyleBackColor = true;
            this.buttonPlays.Click += new System.EventHandler(this.buttonEventType_Click);
            // 
            // groupBoxEventNames
            // 
            this.groupBoxEventNames.Controls.Add(this.radioButtonEvent2);
            this.groupBoxEventNames.Controls.Add(this.radioButtonEvent1);
            this.groupBoxEventNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventNames.Location = new System.Drawing.Point(92, 155);
            this.groupBoxEventNames.Name = "groupBoxEventNames";
            this.groupBoxEventNames.Size = new System.Drawing.Size(800, 100);
            this.groupBoxEventNames.TabIndex = 1;
            this.groupBoxEventNames.TabStop = false;
            this.groupBoxEventNames.Text = "Event Names";
            this.groupBoxEventNames.Visible = false;
            // 
            // radioButtonEvent2
            // 
            this.radioButtonEvent2.AutoSize = true;
            this.radioButtonEvent2.Location = new System.Drawing.Point(459, 42);
            this.radioButtonEvent2.Name = "radioButtonEvent2";
            this.radioButtonEvent2.Size = new System.Drawing.Size(77, 24);
            this.radioButtonEvent2.TabIndex = 1;
            this.radioButtonEvent2.TabStop = true;
            this.radioButtonEvent2.Text = "Event2";
            this.radioButtonEvent2.UseVisualStyleBackColor = true;
            this.radioButtonEvent2.CheckedChanged += new System.EventHandler(this.radioButtonEventName_CheckedChanged);
            // 
            // radioButtonEvent1
            // 
            this.radioButtonEvent1.AutoSize = true;
            this.radioButtonEvent1.Location = new System.Drawing.Point(43, 42);
            this.radioButtonEvent1.Name = "radioButtonEvent1";
            this.radioButtonEvent1.Size = new System.Drawing.Size(77, 24);
            this.radioButtonEvent1.TabIndex = 0;
            this.radioButtonEvent1.TabStop = true;
            this.radioButtonEvent1.Text = "Event1";
            this.radioButtonEvent1.UseVisualStyleBackColor = true;
            this.radioButtonEvent1.CheckedChanged += new System.EventHandler(this.radioButtonEventName_CheckedChanged);
            // 
            // groupBoxEventInfo
            // 
            this.groupBoxEventInfo.Controls.Add(this.labelPrice);
            this.groupBoxEventInfo.Controls.Add(this.buttonGetTicket);
            this.groupBoxEventInfo.Controls.Add(this.labelSeatSelection);
            this.groupBoxEventInfo.Controls.Add(this.listBoxSeatSelection);
            this.groupBoxEventInfo.Controls.Add(this.checkBoxExtra1);
            this.groupBoxEventInfo.Controls.Add(this.checkBoxExtra2);
            this.groupBoxEventInfo.Controls.Add(this.labelDateTime);
            this.groupBoxEventInfo.Controls.Add(this.labelEventLocation);
            this.groupBoxEventInfo.Controls.Add(this.labelEventName);
            this.groupBoxEventInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxEventInfo.Location = new System.Drawing.Point(92, 275);
            this.groupBoxEventInfo.Name = "groupBoxEventInfo";
            this.groupBoxEventInfo.Size = new System.Drawing.Size(800, 450);
            this.groupBoxEventInfo.TabIndex = 2;
            this.groupBoxEventInfo.TabStop = false;
            this.groupBoxEventInfo.Text = "Information";
            this.groupBoxEventInfo.Visible = false;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(33, 170);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(44, 20);
            this.labelPrice.TabIndex = 8;
            this.labelPrice.Text = "Price";
            // 
            // buttonGetTicket
            // 
            this.buttonGetTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGetTicket.Location = new System.Drawing.Point(647, 60);
            this.buttonGetTicket.Name = "buttonGetTicket";
            this.buttonGetTicket.Size = new System.Drawing.Size(100, 300);
            this.buttonGetTicket.TabIndex = 3;
            this.buttonGetTicket.Text = "Get Ticket";
            this.buttonGetTicket.UseVisualStyleBackColor = true;
            this.buttonGetTicket.Click += new System.EventHandler(this.buttonGetTicket_Click);
            // 
            // labelSeatSelection
            // 
            this.labelSeatSelection.AutoSize = true;
            this.labelSeatSelection.Location = new System.Drawing.Point(425, 54);
            this.labelSeatSelection.Name = "labelSeatSelection";
            this.labelSeatSelection.Size = new System.Drawing.Size(113, 20);
            this.labelSeatSelection.TabIndex = 6;
            this.labelSeatSelection.Text = "Seat Selection";
            // 
            // listBoxSeatSelection
            // 
            this.listBoxSeatSelection.FormattingEnabled = true;
            this.listBoxSeatSelection.ItemHeight = 20;
            this.listBoxSeatSelection.Location = new System.Drawing.Point(422, 79);
            this.listBoxSeatSelection.Name = "listBoxSeatSelection";
            this.listBoxSeatSelection.Size = new System.Drawing.Size(120, 264);
            this.listBoxSeatSelection.TabIndex = 2;
            // 
            // checkBoxExtra1
            // 
            this.checkBoxExtra1.AutoSize = true;
            this.checkBoxExtra1.Location = new System.Drawing.Point(33, 280);
            this.checkBoxExtra1.Name = "checkBoxExtra1";
            this.checkBoxExtra1.Size = new System.Drawing.Size(74, 24);
            this.checkBoxExtra1.TabIndex = 0;
            this.checkBoxExtra1.Text = "Extra1";
            this.checkBoxExtra1.UseVisualStyleBackColor = true;
            this.checkBoxExtra1.CheckedChanged += new System.EventHandler(this.checkBoxExtra_CheckedChanged);
            // 
            // checkBoxExtra2
            // 
            this.checkBoxExtra2.AutoSize = true;
            this.checkBoxExtra2.Location = new System.Drawing.Point(33, 339);
            this.checkBoxExtra2.Name = "checkBoxExtra2";
            this.checkBoxExtra2.Size = new System.Drawing.Size(74, 24);
            this.checkBoxExtra2.TabIndex = 1;
            this.checkBoxExtra2.Text = "Extra2";
            this.checkBoxExtra2.UseVisualStyleBackColor = true;
            this.checkBoxExtra2.CheckedChanged += new System.EventHandler(this.checkBoxExtra_CheckedChanged);
            // 
            // labelDateTime
            // 
            this.labelDateTime.AutoSize = true;
            this.labelDateTime.Location = new System.Drawing.Point(33, 225);
            this.labelDateTime.Name = "labelDateTime";
            this.labelDateTime.Size = new System.Drawing.Size(78, 20);
            this.labelDateTime.TabIndex = 2;
            this.labelDateTime.Text = "DateTime";
            // 
            // labelEventLocation
            // 
            this.labelEventLocation.AutoSize = true;
            this.labelEventLocation.Location = new System.Drawing.Point(33, 115);
            this.labelEventLocation.Name = "labelEventLocation";
            this.labelEventLocation.Size = new System.Drawing.Size(111, 20);
            this.labelEventLocation.TabIndex = 1;
            this.labelEventLocation.Text = "EventLocation";
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(33, 60);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(92, 20);
            this.labelEventName.TabIndex = 0;
            this.labelEventName.Text = "EventName";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // CampusEvents
            // 
            this.AcceptButton = this.buttonGetTicket;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.groupBoxEventInfo);
            this.Controls.Add(this.groupBoxEventNames);
            this.Controls.Add(this.groupBoxEventButtons);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CampusEvents";
            this.Text = "On-Campus Events";
            this.groupBoxEventButtons.ResumeLayout(false);
            this.groupBoxEventNames.ResumeLayout(false);
            this.groupBoxEventNames.PerformLayout();
            this.groupBoxEventInfo.ResumeLayout(false);
            this.groupBoxEventInfo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxEventButtons;
        private System.Windows.Forms.GroupBox groupBoxEventNames;
        private System.Windows.Forms.GroupBox groupBoxEventInfo;
        private System.Windows.Forms.Button buttonFootball;
        private System.Windows.Forms.Button buttonFairs;
        private System.Windows.Forms.Button buttonPlays;
        private System.Windows.Forms.RadioButton radioButtonEvent2;
        private System.Windows.Forms.RadioButton radioButtonEvent1;
        private System.Windows.Forms.Label labelDateTime;
        private System.Windows.Forms.Label labelEventLocation;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelSeatSelection;
        private System.Windows.Forms.ListBox listBoxSeatSelection;
        private System.Windows.Forms.CheckBox checkBoxExtra1;
        private System.Windows.Forms.CheckBox checkBoxExtra2;
        private System.Windows.Forms.Button buttonGetTicket;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

