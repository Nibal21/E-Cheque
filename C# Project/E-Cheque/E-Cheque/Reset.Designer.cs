
namespace E_Cheque
{
    partial class Reset
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
            this.sendcodepanel = new System.Windows.Forms.Panel();
            this.headlabel = new System.Windows.Forms.Label();
            this.Logolabel = new System.Windows.Forms.Label();
            this.resetbacklinkLabel = new System.Windows.Forms.LinkLabel();
            this.resetbutton = new System.Windows.Forms.Button();
            this.resetconpasstextBox = new System.Windows.Forms.TextBox();
            this.resetconpasslabel = new System.Windows.Forms.Label();
            this.resetnewpasslabel = new System.Windows.Forms.Label();
            this.resetnewpasstextBox = new System.Windows.Forms.TextBox();
            this.sendcodepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendcodepanel
            // 
            this.sendcodepanel.BackColor = System.Drawing.Color.DarkOrange;
            this.sendcodepanel.Controls.Add(this.headlabel);
            this.sendcodepanel.Controls.Add(this.Logolabel);
            this.sendcodepanel.Location = new System.Drawing.Point(-2, 0);
            this.sendcodepanel.Name = "sendcodepanel";
            this.sendcodepanel.Size = new System.Drawing.Size(734, 102);
            this.sendcodepanel.TabIndex = 1;
            // 
            // headlabel
            // 
            this.headlabel.AutoSize = true;
            this.headlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.headlabel.Location = new System.Drawing.Point(12, 54);
            this.headlabel.Name = "headlabel";
            this.headlabel.Size = new System.Drawing.Size(312, 29);
            this.headlabel.TabIndex = 3;
            this.headlabel.Text = "Reset password via email";
            // 
            // Logolabel
            // 
            this.Logolabel.AutoSize = true;
            this.Logolabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logolabel.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logolabel.Location = new System.Drawing.Point(12, 9);
            this.Logolabel.Name = "Logolabel";
            this.Logolabel.Size = new System.Drawing.Size(87, 27);
            this.Logolabel.TabIndex = 2;
            this.Logolabel.Text = "E-Cheque";
            // 
            // resetbacklinkLabel
            // 
            this.resetbacklinkLabel.AutoSize = true;
            this.resetbacklinkLabel.Location = new System.Drawing.Point(16, 432);
            this.resetbacklinkLabel.Name = "resetbacklinkLabel";
            this.resetbacklinkLabel.Size = new System.Drawing.Size(39, 17);
            this.resetbacklinkLabel.TabIndex = 14;
            this.resetbacklinkLabel.TabStop = true;
            this.resetbacklinkLabel.Text = "Back";
            this.resetbacklinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.resetbacklinkLabel_LinkClicked);
            // 
            // resetbutton
            // 
            this.resetbutton.BackColor = System.Drawing.Color.White;
            this.resetbutton.FlatAppearance.BorderSize = 0;
            this.resetbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetbutton.Location = new System.Drawing.Point(143, 274);
            this.resetbutton.Name = "resetbutton";
            this.resetbutton.Size = new System.Drawing.Size(131, 30);
            this.resetbutton.TabIndex = 13;
            this.resetbutton.Text = "Reset";
            this.resetbutton.UseVisualStyleBackColor = false;
            this.resetbutton.Click += new System.EventHandler(this.resetbutton_Click);
            // 
            // resetconpasstextBox
            // 
            this.resetconpasstextBox.Location = new System.Drawing.Point(143, 215);
            this.resetconpasstextBox.Name = "resetconpasstextBox";
            this.resetconpasstextBox.Size = new System.Drawing.Size(185, 22);
            this.resetconpasstextBox.TabIndex = 11;
            // 
            // resetconpasslabel
            // 
            this.resetconpasslabel.AutoSize = true;
            this.resetconpasslabel.Location = new System.Drawing.Point(12, 218);
            this.resetconpasslabel.Name = "resetconpasslabel";
            this.resetconpasslabel.Size = new System.Drawing.Size(121, 17);
            this.resetconpasslabel.TabIndex = 9;
            this.resetconpasslabel.Text = "Confirm Password";
            // 
            // resetnewpasslabel
            // 
            this.resetnewpasslabel.AutoSize = true;
            this.resetnewpasslabel.Location = new System.Drawing.Point(12, 151);
            this.resetnewpasslabel.Name = "resetnewpasslabel";
            this.resetnewpasslabel.Size = new System.Drawing.Size(100, 17);
            this.resetnewpasslabel.TabIndex = 8;
            this.resetnewpasslabel.Text = "New Password";
            // 
            // resetnewpasstextBox
            // 
            this.resetnewpasstextBox.Location = new System.Drawing.Point(143, 148);
            this.resetnewpasstextBox.Name = "resetnewpasstextBox";
            this.resetnewpasstextBox.Size = new System.Drawing.Size(185, 22);
            this.resetnewpasstextBox.TabIndex = 15;
            // 
            // Reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 473);
            this.Controls.Add(this.resetnewpasstextBox);
            this.Controls.Add(this.resetbacklinkLabel);
            this.Controls.Add(this.resetbutton);
            this.Controls.Add(this.resetconpasstextBox);
            this.Controls.Add(this.resetconpasslabel);
            this.Controls.Add(this.resetnewpasslabel);
            this.Controls.Add(this.sendcodepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reset";
            this.Text = "Reset";
            this.sendcodepanel.ResumeLayout(false);
            this.sendcodepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sendcodepanel;
        private System.Windows.Forms.Label headlabel;
        private System.Windows.Forms.Label Logolabel;
        private System.Windows.Forms.LinkLabel resetbacklinkLabel;
        private System.Windows.Forms.Button resetbutton;
        private System.Windows.Forms.TextBox resetconpasstextBox;
        private System.Windows.Forms.Label resetconpasslabel;
        private System.Windows.Forms.Label resetnewpasslabel;
        private System.Windows.Forms.TextBox resetnewpasstextBox;
    }
}