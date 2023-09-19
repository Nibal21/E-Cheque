
namespace E_Cheque
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.headerlogoBox1 = new System.Windows.Forms.PictureBox();
            this.loginpanel1 = new System.Windows.Forms.Panel();
            this.passwordcheckbox = new System.Windows.Forms.CheckBox();
            this.forgotpassbutton = new System.Windows.Forms.Button();
            this.signinbutton = new System.Windows.Forms.Button();
            this.singupbutton = new System.Windows.Forms.Button();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.checkerrorprovider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.headerlogoBox1)).BeginInit();
            this.loginpanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkerrorprovider)).BeginInit();
            this.SuspendLayout();
            // 
            // headerlogoBox1
            // 
            this.headerlogoBox1.BackColor = System.Drawing.Color.Transparent;
            this.headerlogoBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("headerlogoBox1.BackgroundImage")));
            this.headerlogoBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.headerlogoBox1.Location = new System.Drawing.Point(-1, -43);
            this.headerlogoBox1.Name = "headerlogoBox1";
            this.headerlogoBox1.Size = new System.Drawing.Size(734, 212);
            this.headerlogoBox1.TabIndex = 0;
            this.headerlogoBox1.TabStop = false;
            // 
            // loginpanel1
            // 
            this.loginpanel1.BackColor = System.Drawing.Color.DarkOrange;
            this.loginpanel1.Controls.Add(this.passwordcheckbox);
            this.loginpanel1.Controls.Add(this.forgotpassbutton);
            this.loginpanel1.Controls.Add(this.signinbutton);
            this.loginpanel1.Controls.Add(this.singupbutton);
            this.loginpanel1.Controls.Add(this.passwordlabel);
            this.loginpanel1.Controls.Add(this.usernamelabel);
            this.loginpanel1.Controls.Add(this.passwordtextBox);
            this.loginpanel1.Controls.Add(this.usernametextBox);
            this.loginpanel1.Location = new System.Drawing.Point(52, 134);
            this.loginpanel1.Name = "loginpanel1";
            this.loginpanel1.Size = new System.Drawing.Size(630, 295);
            this.loginpanel1.TabIndex = 1;
            // 
            // passwordcheckbox
            // 
            this.passwordcheckbox.AutoSize = true;
            this.passwordcheckbox.Location = new System.Drawing.Point(324, 163);
            this.passwordcheckbox.Name = "passwordcheckbox";
            this.passwordcheckbox.Size = new System.Drawing.Size(129, 21);
            this.passwordcheckbox.TabIndex = 8;
            this.passwordcheckbox.Text = "Show Password";
            this.passwordcheckbox.UseVisualStyleBackColor = true;
            this.passwordcheckbox.CheckedChanged += new System.EventHandler(this.passwordcheckbox_CheckedChanged);
            // 
            // forgotpassbutton
            // 
            this.forgotpassbutton.BackColor = System.Drawing.Color.White;
            this.forgotpassbutton.FlatAppearance.BorderSize = 0;
            this.forgotpassbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotpassbutton.ForeColor = System.Drawing.Color.Black;
            this.forgotpassbutton.Location = new System.Drawing.Point(358, 209);
            this.forgotpassbutton.Name = "forgotpassbutton";
            this.forgotpassbutton.Size = new System.Drawing.Size(95, 45);
            this.forgotpassbutton.TabIndex = 7;
            this.forgotpassbutton.Text = "Forgot Password";
            this.forgotpassbutton.UseVisualStyleBackColor = false;
            this.forgotpassbutton.Click += new System.EventHandler(this.forgotpassbutton_Click);
            // 
            // signinbutton
            // 
            this.signinbutton.BackColor = System.Drawing.Color.White;
            this.signinbutton.FlatAppearance.BorderSize = 0;
            this.signinbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signinbutton.ForeColor = System.Drawing.Color.Black;
            this.signinbutton.Location = new System.Drawing.Point(257, 209);
            this.signinbutton.Name = "signinbutton";
            this.signinbutton.Size = new System.Drawing.Size(95, 45);
            this.signinbutton.TabIndex = 6;
            this.signinbutton.Text = "Sign In";
            this.signinbutton.UseVisualStyleBackColor = false;
            this.signinbutton.Click += new System.EventHandler(this.signinbutton_Click);
            // 
            // singupbutton
            // 
            this.singupbutton.BackColor = System.Drawing.Color.White;
            this.singupbutton.FlatAppearance.BorderSize = 0;
            this.singupbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.singupbutton.ForeColor = System.Drawing.Color.Black;
            this.singupbutton.Location = new System.Drawing.Point(156, 209);
            this.singupbutton.Name = "singupbutton";
            this.singupbutton.Size = new System.Drawing.Size(95, 45);
            this.singupbutton.TabIndex = 5;
            this.singupbutton.Text = "Sign Up";
            this.singupbutton.UseVisualStyleBackColor = false;
            this.singupbutton.Click += new System.EventHandler(this.singupbutton_Click);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.ForeColor = System.Drawing.Color.Black;
            this.passwordlabel.Location = new System.Drawing.Point(155, 120);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(84, 27);
            this.passwordlabel.TabIndex = 4;
            this.passwordlabel.Text = "Password";
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.BackColor = System.Drawing.Color.Transparent;
            this.usernamelabel.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.ForeColor = System.Drawing.Color.Black;
            this.usernamelabel.Location = new System.Drawing.Point(151, 61);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(88, 27);
            this.usernamelabel.TabIndex = 3;
            this.usernamelabel.Text = "Username";
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.BackColor = System.Drawing.Color.White;
            this.passwordtextBox.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(245, 117);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(208, 35);
            this.passwordtextBox.TabIndex = 2;
            this.passwordtextBox.UseSystemPasswordChar = true;
            // 
            // usernametextBox
            // 
            this.usernametextBox.BackColor = System.Drawing.Color.White;
            this.usernametextBox.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextBox.Location = new System.Drawing.Point(245, 58);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(208, 35);
            this.usernametextBox.TabIndex = 1;
            // 
            // checkerrorprovider
            // 
            this.checkerrorprovider.ContainerControl = this;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(732, 463);
            this.Controls.Add(this.loginpanel1);
            this.Controls.Add(this.headerlogoBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.headerlogoBox1)).EndInit();
            this.loginpanel1.ResumeLayout(false);
            this.loginpanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkerrorprovider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headerlogoBox1;
        private System.Windows.Forms.Panel loginpanel1;
        private System.Windows.Forms.Button forgotpassbutton;
        private System.Windows.Forms.Button signinbutton;
        private System.Windows.Forms.Button singupbutton;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.CheckBox passwordcheckbox;
        private System.Windows.Forms.ErrorProvider checkerrorprovider;
    }
}