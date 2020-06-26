namespace NET_Lab_1
{
    partial class frmUnitAverage
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
            this.components = new System.ComponentModel.Container();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblUnitPrompt = new System.Windows.Forms.Label();
            this.lblDay = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtUnits = new System.Windows.Forms.TextBox();
            this.txtDailyUnits = new System.Windows.Forms.TextBox();
            this.lblResults = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(389, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(159, 47);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "E&xit";
            this.toolTip1.SetToolTip(this.btnExit, "Exit the application.");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReset.Location = new System.Drawing.Point(221, 357);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(146, 48);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "&Reset";
            this.toolTip1.SetToolTip(this.btnReset, "Clear all inputs from the form.");
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(55, 356);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(147, 49);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "&Enter";
            this.toolTip1.SetToolTip(this.btnEnter, "Input your unit amounts.");
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblUnitPrompt
            // 
            this.lblUnitPrompt.AutoSize = true;
            this.lblUnitPrompt.Location = new System.Drawing.Point(158, 43);
            this.lblUnitPrompt.Name = "lblUnitPrompt";
            this.lblUnitPrompt.Size = new System.Drawing.Size(44, 17);
            this.lblUnitPrompt.TabIndex = 0;
            this.lblUnitPrompt.Text = "&Units:";
            this.lblUnitPrompt.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(367, 43);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(41, 17);
            this.lblDay.TabIndex = 2;
            this.lblDay.Text = "Day: ";
            this.toolTip1.SetToolTip(this.lblDay, "Next entry is for this day.");
            // 
            // txtUnits
            // 
            this.txtUnits.Location = new System.Drawing.Point(221, 40);
            this.txtUnits.Name = "txtUnits";
            this.txtUnits.Size = new System.Drawing.Size(100, 22);
            this.txtUnits.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtUnits, "Enter your unit amounts here.");
            // 
            // txtDailyUnits
            // 
            this.txtDailyUnits.Location = new System.Drawing.Point(118, 89);
            this.txtDailyUnits.MaximumSize = new System.Drawing.Size(354, 169);
            this.txtDailyUnits.MinimumSize = new System.Drawing.Size(354, 169);
            this.txtDailyUnits.Multiline = true;
            this.txtDailyUnits.Name = "txtDailyUnits";
            this.txtDailyUnits.ReadOnly = true;
            this.txtDailyUnits.Size = new System.Drawing.Size(354, 169);
            this.txtDailyUnits.TabIndex = 3;
            this.toolTip1.SetToolTip(this.txtDailyUnits, "Entries that you\'ve inputted");
            // 
            // lblResults
            // 
            this.lblResults.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResults.Location = new System.Drawing.Point(118, 265);
            this.lblResults.Name = "lblResults";
            this.lblResults.Size = new System.Drawing.Size(354, 75);
            this.lblResults.TabIndex = 4;
            this.lblResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.lblResults, "Results");
            // 
            // frmUnitAverage
            // 
            this.AcceptButton = this.btnEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnReset;
            this.ClientSize = new System.Drawing.Size(598, 438);
            this.Controls.Add(this.lblResults);
            this.Controls.Add(this.txtDailyUnits);
            this.Controls.Add(this.txtUnits);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.lblUnitPrompt);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnEnter);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(616, 485);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(616, 485);
            this.Name = "frmUnitAverage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average of Units Shipped";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnReset;
        internal System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblUnitPrompt;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtUnits;
        private System.Windows.Forms.TextBox txtDailyUnits;
        private System.Windows.Forms.Label lblResults;
    }
}

