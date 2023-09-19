
namespace E_Cheque
{
    partial class Writecheque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.headlabel = new System.Windows.Forms.Label();
            this.Logolabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.paytextBox = new System.Windows.Forms.TextBox();
            this.sumoftakatextBox = new System.Windows.Forms.TextBox();
            this.amounttextBox = new System.Windows.Forms.TextBox();
            this.signtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkdonebtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.headlabel);
            this.panel1.Controls.Add(this.Logolabel);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 119);
            this.panel1.TabIndex = 2;
            // 
            // headlabel
            // 
            this.headlabel.AutoSize = true;
            this.headlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.headlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.headlabel.Location = new System.Drawing.Point(13, 53);
            this.headlabel.Name = "headlabel";
            this.headlabel.Size = new System.Drawing.Size(240, 32);
            this.headlabel.TabIndex = 2;
            this.headlabel.Text = "Write your check";
            // 
            // Logolabel
            // 
            this.Logolabel.AutoSize = true;
            this.Logolabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logolabel.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logolabel.Location = new System.Drawing.Point(13, 10);
            this.Logolabel.Name = "Logolabel";
            this.Logolabel.Size = new System.Drawing.Size(87, 27);
            this.Logolabel.TabIndex = 1;
            this.Logolabel.Text = "E-Cheque";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.paytextBox);
            this.panel2.Controls.Add(this.sumoftakatextBox);
            this.panel2.Controls.Add(this.amounttextBox);
            this.panel2.Controls.Add(this.signtextBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(18, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 238);
            this.panel2.TabIndex = 3;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(136, 184);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            this.comboBox1.Leave += new System.EventHandler(this.comboBox1_Leave);
            // 
            // paytextBox
            // 
            this.paytextBox.Location = new System.Drawing.Point(136, 24);
            this.paytextBox.Name = "paytextBox";
            this.paytextBox.Size = new System.Drawing.Size(152, 22);
            this.paytextBox.TabIndex = 4;
            this.paytextBox.Leave += new System.EventHandler(this.paytextBox_Leave);
            // 
            // sumoftakatextBox
            // 
            this.sumoftakatextBox.Location = new System.Drawing.Point(136, 64);
            this.sumoftakatextBox.Name = "sumoftakatextBox";
            this.sumoftakatextBox.Size = new System.Drawing.Size(523, 22);
            this.sumoftakatextBox.TabIndex = 5;
            this.sumoftakatextBox.Leave += new System.EventHandler(this.sumoftakatextBox_Leave);
            // 
            // amounttextBox
            // 
            this.amounttextBox.Location = new System.Drawing.Point(136, 103);
            this.amounttextBox.Name = "amounttextBox";
            this.amounttextBox.Size = new System.Drawing.Size(152, 22);
            this.amounttextBox.TabIndex = 6;
            this.amounttextBox.Leave += new System.EventHandler(this.amounttextBox_Leave);
            // 
            // signtextBox
            // 
            this.signtextBox.Location = new System.Drawing.Point(136, 144);
            this.signtextBox.Name = "signtextBox";
            this.signtextBox.Size = new System.Drawing.Size(152, 22);
            this.signtextBox.TabIndex = 7;
            this.signtextBox.TextChanged += new System.EventHandler(this.signaturetxtbox);
            this.signtextBox.Leave += new System.EventHandler(this.signtextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Bank:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Signature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "The sum of taka:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pay to:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // checkdonebtn
            // 
            this.checkdonebtn.BackColor = System.Drawing.SystemColors.Control;
            this.checkdonebtn.FlatAppearance.BorderSize = 0;
            this.checkdonebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkdonebtn.Location = new System.Drawing.Point(432, 405);
            this.checkdonebtn.Name = "checkdonebtn";
            this.checkdonebtn.Size = new System.Drawing.Size(161, 35);
            this.checkdonebtn.TabIndex = 30;
            this.checkdonebtn.Text = "Done";
            this.checkdonebtn.UseVisualStyleBackColor = false;
            this.checkdonebtn.Click += new System.EventHandler(this.checkdonebtn_Click);
            // 
            // Writecheque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(746, 462);
            this.Controls.Add(this.checkdonebtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Writecheque";
            this.Text = "Writecheque";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label headlabel;
        private System.Windows.Forms.Label Logolabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox signtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox paytextBox;
        private System.Windows.Forms.TextBox sumoftakatextBox;
        private System.Windows.Forms.TextBox amounttextBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button checkdonebtn;
    }
}