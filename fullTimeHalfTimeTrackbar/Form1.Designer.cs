namespace fullTimeHalfTimeTrackbar
{
    partial class form
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trkCredits = new System.Windows.Forms.TrackBar();
            this.lblCredits = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkCredits)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(84, 127);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(178, 23);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status shown here";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Number of credits";
            // 
            // trkCredits
            // 
            this.trkCredits.Location = new System.Drawing.Point(72, 78);
            this.trkCredits.Maximum = 24;
            this.trkCredits.Name = "trkCredits";
            this.trkCredits.Size = new System.Drawing.Size(213, 45);
            this.trkCredits.TabIndex = 8;
            this.trkCredits.Scroll += new System.EventHandler(this.trkCredits_Scroll);
            // 
            // lblCredits
            // 
            this.lblCredits.AutoSize = true;
            this.lblCredits.Location = new System.Drawing.Point(291, 78);
            this.lblCredits.Name = "lblCredits";
            this.lblCredits.Size = new System.Drawing.Size(13, 13);
            this.lblCredits.TabIndex = 9;
            this.lblCredits.Text = "0";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 193);
            this.Controls.Add(this.lblCredits);
            this.Controls.Add(this.trkCredits);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label1);
            this.Name = "form";
            this.Text = "Full time, half time?";
            ((System.ComponentModel.ISupportInitialize)(this.trkCredits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trkCredits;
        private System.Windows.Forms.Label lblCredits;
    }
}

