
namespace E_Cheque
{
    partial class Form1
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
            this.tfdataGridView1 = new System.Windows.Forms.DataGridView();
            this.deletebtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.headlabel = new System.Windows.Forms.Label();
            this.Logolabel = new System.Windows.Forms.Label();
            this.gbackbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tfdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tfdataGridView1
            // 
            this.tfdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tfdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tfdataGridView1.Location = new System.Drawing.Point(50, 208);
            this.tfdataGridView1.Name = "tfdataGridView1";
            this.tfdataGridView1.RowHeadersWidth = 51;
            this.tfdataGridView1.RowTemplate.Height = 24;
            this.tfdataGridView1.Size = new System.Drawing.Size(688, 150);
            this.tfdataGridView1.TabIndex = 0;
            this.tfdataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tfdataGridView1_CellContentClick);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.BorderSize = 0;
            this.deletebtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.deletebtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.deletebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebtn.Location = new System.Drawing.Point(50, 143);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(117, 43);
            this.deletebtn.TabIndex = 1;
            this.deletebtn.Text = "Delete";
            this.deletebtn.UseVisualStyleBackColor = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.headlabel);
            this.panel1.Controls.Add(this.Logolabel);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 125);
            this.panel1.TabIndex = 2;
            // 
            // headlabel
            // 
            this.headlabel.AutoSize = true;
            this.headlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.headlabel.Location = new System.Drawing.Point(13, 53);
            this.headlabel.Name = "headlabel";
            this.headlabel.Size = new System.Drawing.Size(278, 32);
            this.headlabel.TabIndex = 2;
            this.headlabel.Text = "Transaction History";
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
            // gbackbtn
            // 
            this.gbackbtn.BackColor = System.Drawing.Color.White;
            this.gbackbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.gbackbtn.FlatAppearance.BorderSize = 0;
            this.gbackbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.gbackbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.gbackbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbackbtn.Location = new System.Drawing.Point(50, 382);
            this.gbackbtn.Name = "gbackbtn";
            this.gbackbtn.Size = new System.Drawing.Size(117, 43);
            this.gbackbtn.TabIndex = 3;
            this.gbackbtn.Text = "Go back";
            this.gbackbtn.UseVisualStyleBackColor = false;
            this.gbackbtn.Click += new System.EventHandler(this.gbackbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbackbtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.tfdataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tfdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tfdataGridView1;
        private System.Windows.Forms.Button deletebtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headlabel;
        private System.Windows.Forms.Label Logolabel;
        private System.Windows.Forms.Button gbackbtn;
    }
}