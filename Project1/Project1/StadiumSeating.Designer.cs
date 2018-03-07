namespace Project1
{
    partial class StadiumSeating
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
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpTicketsSold = new System.Windows.Forms.GroupBox();
            this.txtClassCTickets = new System.Windows.Forms.TextBox();
            this.lblClassCTickets = new System.Windows.Forms.Label();
            this.txtClassBTickets = new System.Windows.Forms.TextBox();
            this.lblClassBTickets = new System.Windows.Forms.Label();
            this.txtClassATickets = new System.Windows.Forms.TextBox();
            this.lblClassATickets = new System.Windows.Forms.Label();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.grpRevenueGenerated = new System.Windows.Forms.GroupBox();
            this.txtTotalRevenue = new System.Windows.Forms.TextBox();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.txtClassCRevenue = new System.Windows.Forms.TextBox();
            this.lblClassCRevenue = new System.Windows.Forms.Label();
            this.txtClassBRevenue = new System.Windows.Forms.TextBox();
            this.lblClassBRevenue = new System.Windows.Forms.Label();
            this.txtClassARevenue = new System.Windows.Forms.TextBox();
            this.lblClassARevenue = new System.Windows.Forms.Label();
            this.grpTicketsSold.SuspendLayout();
            this.grpRevenueGenerated.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(76, 418);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(100, 50);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate Revenue";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(387, 418);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 50);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(699, 418);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpTicketsSold
            // 
            this.grpTicketsSold.Controls.Add(this.txtClassCTickets);
            this.grpTicketsSold.Controls.Add(this.lblClassCTickets);
            this.grpTicketsSold.Controls.Add(this.txtClassBTickets);
            this.grpTicketsSold.Controls.Add(this.lblClassBTickets);
            this.grpTicketsSold.Controls.Add(this.txtClassATickets);
            this.grpTicketsSold.Controls.Add(this.lblClassATickets);
            this.grpTicketsSold.Controls.Add(this.lblInstructions);
            this.grpTicketsSold.Location = new System.Drawing.Point(22, 12);
            this.grpTicketsSold.Name = "grpTicketsSold";
            this.grpTicketsSold.Size = new System.Drawing.Size(400, 400);
            this.grpTicketsSold.TabIndex = 3;
            this.grpTicketsSold.TabStop = false;
            this.grpTicketsSold.Text = "Ticket Sold";
            // 
            // txtClassCTickets
            // 
            this.txtClassCTickets.Location = new System.Drawing.Point(201, 286);
            this.txtClassCTickets.Name = "txtClassCTickets";
            this.txtClassCTickets.Size = new System.Drawing.Size(100, 26);
            this.txtClassCTickets.TabIndex = 6;
            this.txtClassCTickets.Text = "0";
            // 
            // lblClassCTickets
            // 
            this.lblClassCTickets.AutoSize = true;
            this.lblClassCTickets.Location = new System.Drawing.Point(80, 289);
            this.lblClassCTickets.Name = "lblClassCTickets";
            this.lblClassCTickets.Size = new System.Drawing.Size(67, 20);
            this.lblClassCTickets.TabIndex = 5;
            this.lblClassCTickets.Text = "Class C:";
            // 
            // txtClassBTickets
            // 
            this.txtClassBTickets.Location = new System.Drawing.Point(201, 221);
            this.txtClassBTickets.Name = "txtClassBTickets";
            this.txtClassBTickets.Size = new System.Drawing.Size(100, 26);
            this.txtClassBTickets.TabIndex = 4;
            this.txtClassBTickets.Text = "0";
            // 
            // lblClassBTickets
            // 
            this.lblClassBTickets.AutoSize = true;
            this.lblClassBTickets.Location = new System.Drawing.Point(80, 224);
            this.lblClassBTickets.Name = "lblClassBTickets";
            this.lblClassBTickets.Size = new System.Drawing.Size(67, 20);
            this.lblClassBTickets.TabIndex = 3;
            this.lblClassBTickets.Text = "Class B:";
            // 
            // txtClassATickets
            // 
            this.txtClassATickets.Location = new System.Drawing.Point(201, 156);
            this.txtClassATickets.Name = "txtClassATickets";
            this.txtClassATickets.Size = new System.Drawing.Size(100, 26);
            this.txtClassATickets.TabIndex = 2;
            this.txtClassATickets.Text = "0";
            // 
            // lblClassATickets
            // 
            this.lblClassATickets.AutoSize = true;
            this.lblClassATickets.Location = new System.Drawing.Point(80, 159);
            this.lblClassATickets.Name = "lblClassATickets";
            this.lblClassATickets.Size = new System.Drawing.Size(67, 20);
            this.lblClassATickets.TabIndex = 1;
            this.lblClassATickets.Text = "Class A:";
            // 
            // lblInstructions
            // 
            this.lblInstructions.Location = new System.Drawing.Point(50, 43);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(300, 40);
            this.lblInstructions.TabIndex = 0;
            this.lblInstructions.Text = "Enter the number of tickets sold for each class of seats.";
            // 
            // grpRevenueGenerated
            // 
            this.grpRevenueGenerated.Controls.Add(this.txtTotalRevenue);
            this.grpRevenueGenerated.Controls.Add(this.lblTotalRevenue);
            this.grpRevenueGenerated.Controls.Add(this.txtClassCRevenue);
            this.grpRevenueGenerated.Controls.Add(this.lblClassCRevenue);
            this.grpRevenueGenerated.Controls.Add(this.txtClassBRevenue);
            this.grpRevenueGenerated.Controls.Add(this.lblClassBRevenue);
            this.grpRevenueGenerated.Controls.Add(this.txtClassARevenue);
            this.grpRevenueGenerated.Controls.Add(this.lblClassARevenue);
            this.grpRevenueGenerated.Location = new System.Drawing.Point(457, 12);
            this.grpRevenueGenerated.Name = "grpRevenueGenerated";
            this.grpRevenueGenerated.Size = new System.Drawing.Size(400, 400);
            this.grpRevenueGenerated.TabIndex = 4;
            this.grpRevenueGenerated.TabStop = false;
            this.grpRevenueGenerated.Text = "Revenue Generated";
            // 
            // txtTotalRevenue
            // 
            this.txtTotalRevenue.Location = new System.Drawing.Point(203, 310);
            this.txtTotalRevenue.Name = "txtTotalRevenue";
            this.txtTotalRevenue.Size = new System.Drawing.Size(100, 26);
            this.txtTotalRevenue.TabIndex = 7;
            this.txtTotalRevenue.Text = "$0.00";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Location = new System.Drawing.Point(95, 313);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(48, 20);
            this.lblTotalRevenue.TabIndex = 6;
            this.lblTotalRevenue.Text = "Total:";
            // 
            // txtClassCRevenue
            // 
            this.txtClassCRevenue.Location = new System.Drawing.Point(203, 228);
            this.txtClassCRevenue.Name = "txtClassCRevenue";
            this.txtClassCRevenue.Size = new System.Drawing.Size(100, 26);
            this.txtClassCRevenue.TabIndex = 5;
            this.txtClassCRevenue.Text = "$0.00";
            // 
            // lblClassCRevenue
            // 
            this.lblClassCRevenue.AutoSize = true;
            this.lblClassCRevenue.Location = new System.Drawing.Point(76, 231);
            this.lblClassCRevenue.Name = "lblClassCRevenue";
            this.lblClassCRevenue.Size = new System.Drawing.Size(67, 20);
            this.lblClassCRevenue.TabIndex = 4;
            this.lblClassCRevenue.Text = "Class C:";
            // 
            // txtClassBRevenue
            // 
            this.txtClassBRevenue.Location = new System.Drawing.Point(203, 146);
            this.txtClassBRevenue.Name = "txtClassBRevenue";
            this.txtClassBRevenue.Size = new System.Drawing.Size(100, 26);
            this.txtClassBRevenue.TabIndex = 3;
            this.txtClassBRevenue.Text = "$0.00";
            // 
            // lblClassBRevenue
            // 
            this.lblClassBRevenue.AutoSize = true;
            this.lblClassBRevenue.Location = new System.Drawing.Point(76, 149);
            this.lblClassBRevenue.Name = "lblClassBRevenue";
            this.lblClassBRevenue.Size = new System.Drawing.Size(67, 20);
            this.lblClassBRevenue.TabIndex = 2;
            this.lblClassBRevenue.Text = "Class B:";
            // 
            // txtClassARevenue
            // 
            this.txtClassARevenue.Location = new System.Drawing.Point(203, 64);
            this.txtClassARevenue.Name = "txtClassARevenue";
            this.txtClassARevenue.Size = new System.Drawing.Size(100, 26);
            this.txtClassARevenue.TabIndex = 1;
            this.txtClassARevenue.Text = "$0.00";
            // 
            // lblClassARevenue
            // 
            this.lblClassARevenue.AutoSize = true;
            this.lblClassARevenue.Location = new System.Drawing.Point(76, 67);
            this.lblClassARevenue.Name = "lblClassARevenue";
            this.lblClassARevenue.Size = new System.Drawing.Size(67, 20);
            this.lblClassARevenue.TabIndex = 0;
            this.lblClassARevenue.Text = "Class A:";
            // 
            // StadiumSeating
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 544);
            this.Controls.Add(this.grpRevenueGenerated);
            this.Controls.Add(this.grpTicketsSold);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalc);
            this.Name = "StadiumSeating";
            this.Text = "Stadium Seating";
            this.Load += new System.EventHandler(this.StadiumSeating_Load);
            this.grpTicketsSold.ResumeLayout(false);
            this.grpTicketsSold.PerformLayout();
            this.grpRevenueGenerated.ResumeLayout(false);
            this.grpRevenueGenerated.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpTicketsSold;
        private System.Windows.Forms.Label lblClassATickets;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.GroupBox grpRevenueGenerated;
        private System.Windows.Forms.TextBox txtClassATickets;
        private System.Windows.Forms.TextBox txtClassCTickets;
        private System.Windows.Forms.Label lblClassCTickets;
        private System.Windows.Forms.TextBox txtClassBTickets;
        private System.Windows.Forms.Label lblClassBTickets;
        private System.Windows.Forms.Label lblClassCRevenue;
        private System.Windows.Forms.TextBox txtClassBRevenue;
        private System.Windows.Forms.Label lblClassBRevenue;
        private System.Windows.Forms.TextBox txtClassARevenue;
        private System.Windows.Forms.Label lblClassARevenue;
        private System.Windows.Forms.TextBox txtClassCRevenue;
        private System.Windows.Forms.TextBox txtTotalRevenue;
        private System.Windows.Forms.Label lblTotalRevenue;
    }
}

