
namespace E_Cheque
{
    partial class CheckInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.headlabel = new System.Windows.Forms.Label();
            this.Logolabel = new System.Windows.Forms.Label();
            this.usrnamecombobox = new System.Windows.Forms.ComboBox();
            this.selectnamelabel = new System.Windows.Forms.Label();
            this.Resultbtn = new System.Windows.Forms.Button();
            this.askpwdtxtbox = new System.Windows.Forms.TextBox();
            this.Viewbtn = new System.Windows.Forms.Button();
            this.Labmsg = new System.Windows.Forms.Label();
            this.accntinfodataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbackbtn = new System.Windows.Forms.Button();
            this.Editbtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accntinfodataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.headlabel);
            this.panel1.Controls.Add(this.Logolabel);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 111);
            this.panel1.TabIndex = 1;
            // 
            // headlabel
            // 
            this.headlabel.AutoSize = true;
            this.headlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headlabel.Font = new System.Drawing.Font("Adobe Devanagari", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headlabel.Location = new System.Drawing.Point(3, 56);
            this.headlabel.Name = "headlabel";
            this.headlabel.Size = new System.Drawing.Size(260, 41);
            this.headlabel.TabIndex = 2;
            this.headlabel.Text = "Account Information";
            // 
            // Logolabel
            // 
            this.Logolabel.AutoSize = true;
            this.Logolabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logolabel.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logolabel.Location = new System.Drawing.Point(13, 9);
            this.Logolabel.Name = "Logolabel";
            this.Logolabel.Size = new System.Drawing.Size(87, 27);
            this.Logolabel.TabIndex = 1;
            this.Logolabel.Text = "E-Cheque";
            // 
            // usrnamecombobox
            // 
            this.usrnamecombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usrnamecombobox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.usrnamecombobox.FormattingEnabled = true;
            this.usrnamecombobox.Location = new System.Drawing.Point(148, 149);
            this.usrnamecombobox.Name = "usrnamecombobox";
            this.usrnamecombobox.Size = new System.Drawing.Size(201, 33);
            this.usrnamecombobox.TabIndex = 2;
            // 
            // selectnamelabel
            // 
            this.selectnamelabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selectnamelabel.AutoSize = true;
            this.selectnamelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.selectnamelabel.Location = new System.Drawing.Point(12, 151);
            this.selectnamelabel.Name = "selectnamelabel";
            this.selectnamelabel.Size = new System.Drawing.Size(124, 25);
            this.selectnamelabel.TabIndex = 3;
            this.selectnamelabel.Text = "Select Name";
            // 
            // Resultbtn
            // 
            this.Resultbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Resultbtn.BackColor = System.Drawing.Color.White;
            this.Resultbtn.FlatAppearance.BorderSize = 0;
            this.Resultbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resultbtn.Location = new System.Drawing.Point(364, 149);
            this.Resultbtn.Name = "Resultbtn";
            this.Resultbtn.Size = new System.Drawing.Size(106, 34);
            this.Resultbtn.TabIndex = 4;
            this.Resultbtn.Text = "Result";
            this.Resultbtn.UseVisualStyleBackColor = false;
            this.Resultbtn.Click += new System.EventHandler(this.Resultbtn_Click);
            // 
            // askpwdtxtbox
            // 
            this.askpwdtxtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.askpwdtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.askpwdtxtbox.Location = new System.Drawing.Point(17, 241);
            this.askpwdtxtbox.Multiline = true;
            this.askpwdtxtbox.Name = "askpwdtxtbox";
            this.askpwdtxtbox.Size = new System.Drawing.Size(332, 35);
            this.askpwdtxtbox.TabIndex = 5;
            // 
            // Viewbtn
            // 
            this.Viewbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Viewbtn.BackColor = System.Drawing.Color.White;
            this.Viewbtn.FlatAppearance.BorderSize = 0;
            this.Viewbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Viewbtn.Location = new System.Drawing.Point(364, 243);
            this.Viewbtn.Name = "Viewbtn";
            this.Viewbtn.Size = new System.Drawing.Size(106, 35);
            this.Viewbtn.TabIndex = 6;
            this.Viewbtn.Text = "View";
            this.Viewbtn.UseVisualStyleBackColor = false;
            this.Viewbtn.Click += new System.EventHandler(this.Viewbtn_Click);
            // 
            // Labmsg
            // 
            this.Labmsg.AutoSize = true;
            this.Labmsg.Location = new System.Drawing.Point(14, 205);
            this.Labmsg.Name = "Labmsg";
            this.Labmsg.Size = new System.Drawing.Size(0, 17);
            this.Labmsg.TabIndex = 7;
            // 
            // accntinfodataGridView1
            // 
            this.accntinfodataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accntinfodataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accntinfodataGridView1.Location = new System.Drawing.Point(17, 294);
            this.accntinfodataGridView1.Name = "accntinfodataGridView1";
            this.accntinfodataGridView1.RowHeadersWidth = 51;
            this.accntinfodataGridView1.RowTemplate.Height = 24;
            this.accntinfodataGridView1.Size = new System.Drawing.Size(720, 209);
            this.accntinfodataGridView1.TabIndex = 8;
            // 
            // gbackbtn
            // 
            this.gbackbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbackbtn.BackColor = System.Drawing.Color.White;
            this.gbackbtn.FlatAppearance.BorderSize = 0;
            this.gbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbackbtn.Location = new System.Drawing.Point(17, 509);
            this.gbackbtn.Name = "gbackbtn";
            this.gbackbtn.Size = new System.Drawing.Size(106, 35);
            this.gbackbtn.TabIndex = 9;
            this.gbackbtn.Text = "Go Back";
            this.gbackbtn.UseVisualStyleBackColor = false;
            this.gbackbtn.Click += new System.EventHandler(this.gbackbtn_Click);
            // 
            // Editbtn
            // 
            this.Editbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Editbtn.BackColor = System.Drawing.Color.White;
            this.Editbtn.FlatAppearance.BorderSize = 0;
            this.Editbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Editbtn.Location = new System.Drawing.Point(562, 509);
            this.Editbtn.Name = "Editbtn";
            this.Editbtn.Size = new System.Drawing.Size(175, 35);
            this.Editbtn.TabIndex = 10;
            this.Editbtn.Text = "Edit Information";
            this.Editbtn.UseVisualStyleBackColor = false;
            this.Editbtn.Click += new System.EventHandler(this.Editbtn_Click);
            // 
            // CheckInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(773, 556);
            this.Controls.Add(this.Editbtn);
            this.Controls.Add(this.gbackbtn);
            this.Controls.Add(this.accntinfodataGridView1);
            this.Controls.Add(this.Labmsg);
            this.Controls.Add(this.Viewbtn);
            this.Controls.Add(this.askpwdtxtbox);
            this.Controls.Add(this.Resultbtn);
            this.Controls.Add(this.selectnamelabel);
            this.Controls.Add(this.usrnamecombobox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckInfo";
            this.Text = "CheckInfo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accntinfodataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headlabel;
        private System.Windows.Forms.Label Logolabel;
        private System.Windows.Forms.ComboBox usrnamecombobox;
        private System.Windows.Forms.Label selectnamelabel;
        private System.Windows.Forms.Button Resultbtn;
        private System.Windows.Forms.TextBox askpwdtxtbox;
        private System.Windows.Forms.Button Viewbtn;
        private System.Windows.Forms.Label Labmsg;
        private System.Windows.Forms.DataGridView accntinfodataGridView1;
        private System.Windows.Forms.Button gbackbtn;
        private System.Windows.Forms.Button Editbtn;
    }
}