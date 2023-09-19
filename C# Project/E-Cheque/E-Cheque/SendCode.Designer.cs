
namespace E_Cheque
{
    partial class SendCode
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
            this.emaillabel = new System.Windows.Forms.Label();
            this.entercodelabel = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.endtercodetextBox = new System.Windows.Forms.TextBox();
            this.sendcodebutton = new System.Windows.Forms.Button();
            this.verifybutton = new System.Windows.Forms.Button();
            this.sendcodebacklinkLabel = new System.Windows.Forms.LinkLabel();
            this.sendcodepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sendcodepanel
            // 
            this.sendcodepanel.BackColor = System.Drawing.Color.DarkOrange;
            this.sendcodepanel.Controls.Add(this.headlabel);
            this.sendcodepanel.Controls.Add(this.Logolabel);
            this.sendcodepanel.Location = new System.Drawing.Point(0, 0);
            this.sendcodepanel.Name = "sendcodepanel";
            this.sendcodepanel.Size = new System.Drawing.Size(731, 102);
            this.sendcodepanel.TabIndex = 0;
            // 
            // headlabel
            // 
            this.headlabel.AutoSize = true;
            this.headlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.headlabel.Location = new System.Drawing.Point(12, 54);
            this.headlabel.Name = "headlabel";
            this.headlabel.Size = new System.Drawing.Size(250, 29);
            this.headlabel.TabIndex = 3;
            this.headlabel.Text = "Send code via email";
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
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Location = new System.Drawing.Point(14, 150);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(42, 17);
            this.emaillabel.TabIndex = 1;
            this.emaillabel.Text = "Email";
            // 
            // entercodelabel
            // 
            this.entercodelabel.AutoSize = true;
            this.entercodelabel.Location = new System.Drawing.Point(14, 281);
            this.entercodelabel.Name = "entercodelabel";
            this.entercodelabel.Size = new System.Drawing.Size(79, 17);
            this.entercodelabel.TabIndex = 2;
            this.entercodelabel.Text = "Enter Code";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(131, 147);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(537, 22);
            this.emailtextBox.TabIndex = 3;
            // 
            // endtercodetextBox
            // 
            this.endtercodetextBox.Location = new System.Drawing.Point(130, 278);
            this.endtercodetextBox.Name = "endtercodetextBox";
            this.endtercodetextBox.Size = new System.Drawing.Size(185, 22);
            this.endtercodetextBox.TabIndex = 4;
            // 
            // sendcodebutton
            // 
            this.sendcodebutton.BackColor = System.Drawing.Color.White;
            this.sendcodebutton.FlatAppearance.BorderSize = 0;
            this.sendcodebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendcodebutton.Location = new System.Drawing.Point(131, 206);
            this.sendcodebutton.Name = "sendcodebutton";
            this.sendcodebutton.Size = new System.Drawing.Size(131, 30);
            this.sendcodebutton.TabIndex = 5;
            this.sendcodebutton.Text = "Send Code";
            this.sendcodebutton.UseVisualStyleBackColor = false;
            this.sendcodebutton.Click += new System.EventHandler(this.sendcodebutton_Click);
            // 
            // verifybutton
            // 
            this.verifybutton.BackColor = System.Drawing.Color.White;
            this.verifybutton.FlatAppearance.BorderSize = 0;
            this.verifybutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifybutton.Location = new System.Drawing.Point(131, 335);
            this.verifybutton.Name = "verifybutton";
            this.verifybutton.Size = new System.Drawing.Size(131, 30);
            this.verifybutton.TabIndex = 6;
            this.verifybutton.Text = "Verify";
            this.verifybutton.UseVisualStyleBackColor = false;
            this.verifybutton.Click += new System.EventHandler(this.verifybutton_Click);
            // 
            // sendcodebacklinkLabel
            // 
            this.sendcodebacklinkLabel.AutoSize = true;
            this.sendcodebacklinkLabel.Location = new System.Drawing.Point(14, 427);
            this.sendcodebacklinkLabel.Name = "sendcodebacklinkLabel";
            this.sendcodebacklinkLabel.Size = new System.Drawing.Size(39, 17);
            this.sendcodebacklinkLabel.TabIndex = 7;
            this.sendcodebacklinkLabel.TabStop = true;
            this.sendcodebacklinkLabel.Text = "Back";
            this.sendcodebacklinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sendcodebacklinkLabel_LinkClicked);
            // 
            // SendCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 473);
            this.Controls.Add(this.sendcodebacklinkLabel);
            this.Controls.Add(this.verifybutton);
            this.Controls.Add(this.sendcodebutton);
            this.Controls.Add(this.endtercodetextBox);
            this.Controls.Add(this.emailtextBox);
            this.Controls.Add(this.entercodelabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.sendcodepanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SendCode";
            this.Text = "SendCode";
            this.sendcodepanel.ResumeLayout(false);
            this.sendcodepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sendcodepanel;
        private System.Windows.Forms.Label Logolabel;
        private System.Windows.Forms.Label headlabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label entercodelabel;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox endtercodetextBox;
        private System.Windows.Forms.Button sendcodebutton;
        private System.Windows.Forms.Button verifybutton;
        private System.Windows.Forms.LinkLabel sendcodebacklinkLabel;
    }
}