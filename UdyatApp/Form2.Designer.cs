namespace UdyatApp
{
    partial class Form2
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
            this.gBLocation = new System.Windows.Forms.GroupBox();
            this.lbLocation_info = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gBLocation.SuspendLayout();
            this.Description.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBLocation
            // 
            this.gBLocation.Controls.Add(this.lbLocation_info);
            this.gBLocation.Font = new System.Drawing.Font("Arial", 14F);
            this.gBLocation.Location = new System.Drawing.Point(22, 28);
            this.gBLocation.Name = "gBLocation";
            this.gBLocation.Size = new System.Drawing.Size(416, 178);
            this.gBLocation.TabIndex = 0;
            this.gBLocation.TabStop = false;
            this.gBLocation.Text = "Ubicación:";
            // 
            // lbLocation_info
            // 
            this.lbLocation_info.AutoSize = true;
            this.lbLocation_info.Location = new System.Drawing.Point(27, 38);
            this.lbLocation_info.MaximumSize = new System.Drawing.Size(350, 150);
            this.lbLocation_info.Name = "lbLocation_info";
            this.lbLocation_info.Size = new System.Drawing.Size(61, 22);
            this.lbLocation_info.TabIndex = 0;
            this.lbLocation_info.Text = "label1";
            // 
            // Description
            // 
            this.Description.Controls.Add(this.label2);
            this.Description.Font = new System.Drawing.Font("Arial", 14F);
            this.Description.Location = new System.Drawing.Point(22, 253);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(416, 178);
            this.Description.TabIndex = 1;
            this.Description.TabStop = false;
            this.Description.Text = "Descripción:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.MaximumSize = new System.Drawing.Size(350, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(828, 450);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.gBLocation);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gBLocation.ResumeLayout(false);
            this.gBLocation.PerformLayout();
            this.Description.ResumeLayout(false);
            this.Description.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBLocation;
        private System.Windows.Forms.GroupBox Description;
        private System.Windows.Forms.Label lbLocation_info;
        private System.Windows.Forms.Label label2;
    }
}