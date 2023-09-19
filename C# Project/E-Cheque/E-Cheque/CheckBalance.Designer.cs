
namespace E_Cheque
{
    partial class CheckBalance
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkblncbackbtn = new System.Windows.Forms.Button();
            this.chkblncSearchtxtbox = new System.Windows.Forms.TextBox();
            this.checkbalncdataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbalncdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.headlabel);
            this.panel1.Controls.Add(this.Logolabel);
            this.panel1.Location = new System.Drawing.Point(-2, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 115);
            this.panel1.TabIndex = 1;
            // 
            // headlabel
            // 
            this.headlabel.AutoSize = true;
            this.headlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.headlabel.Location = new System.Drawing.Point(13, 53);
            this.headlabel.Name = "headlabel";
            this.headlabel.Size = new System.Drawing.Size(244, 32);
            this.headlabel.TabIndex = 2;
            this.headlabel.Text = "Account Balance";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkbalncdataGridView);
            this.panel2.Controls.Add(this.chkblncSearchtxtbox);
            this.panel2.Location = new System.Drawing.Point(17, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(726, 311);
            this.panel2.TabIndex = 2;
            // 
            // chkblncbackbtn
            // 
            this.chkblncbackbtn.BackColor = System.Drawing.Color.White;
            this.chkblncbackbtn.FlatAppearance.BorderSize = 0;
            this.chkblncbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkblncbackbtn.ForeColor = System.Drawing.Color.Black;
            this.chkblncbackbtn.Location = new System.Drawing.Point(302, 452);
            this.chkblncbackbtn.Name = "chkblncbackbtn";
            this.chkblncbackbtn.Size = new System.Drawing.Size(155, 45);
            this.chkblncbackbtn.TabIndex = 6;
            this.chkblncbackbtn.Text = "Go Back";
            this.chkblncbackbtn.UseVisualStyleBackColor = false;
            this.chkblncbackbtn.Click += new System.EventHandler(this.chkblncbackbtn_Click);
            // 
            // chkblncSearchtxtbox
            // 
            this.chkblncSearchtxtbox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.chkblncSearchtxtbox.Location = new System.Drawing.Point(224, 17);
            this.chkblncSearchtxtbox.Multiline = true;
            this.chkblncSearchtxtbox.Name = "chkblncSearchtxtbox";
            this.chkblncSearchtxtbox.Size = new System.Drawing.Size(479, 43);
            this.chkblncSearchtxtbox.TabIndex = 0;
            this.chkblncSearchtxtbox.TextChanged += new System.EventHandler(this.chkblncSearchbtn_TextChanged);
            // 
            // checkbalncdataGridView
            // 
            this.checkbalncdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.checkbalncdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkbalncdataGridView.Location = new System.Drawing.Point(20, 75);
            this.checkbalncdataGridView.Name = "checkbalncdataGridView";
            this.checkbalncdataGridView.RowHeadersWidth = 51;
            this.checkbalncdataGridView.RowTemplate.Height = 24;
            this.checkbalncdataGridView.Size = new System.Drawing.Size(683, 201);
            this.checkbalncdataGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search with user id:";
            // 
            // CheckBalance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 509);
            this.Controls.Add(this.chkblncbackbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckBalance";
            this.Text = "CheckBalance";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkbalncdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headlabel;
        private System.Windows.Forms.Label Logolabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView checkbalncdataGridView;
        private System.Windows.Forms.TextBox chkblncSearchtxtbox;
        private System.Windows.Forms.Button chkblncbackbtn;
        private System.Windows.Forms.Label label1;
    }
}