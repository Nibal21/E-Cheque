
namespace E_Cheque
{
    partial class Loading_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loading_page));
            this.loadpanel1 = new System.Windows.Forms.Panel();
            this.loadPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.loadinglabel = new System.Windows.Forms.Label();
            this.loadtimer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // loadpanel1
            // 
            this.loadpanel1.BackColor = System.Drawing.Color.DarkOrange;
            this.loadpanel1.ForeColor = System.Drawing.Color.Black;
            this.loadpanel1.Location = new System.Drawing.Point(0, 285);
            this.loadpanel1.Name = "loadpanel1";
            this.loadpanel1.Size = new System.Drawing.Size(107, 16);
            this.loadpanel1.TabIndex = 0;
            this.loadpanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.loadpanel1_Paint);
            // 
            // loadPanel2
            // 
            this.loadPanel2.Location = new System.Drawing.Point(0, 285);
            this.loadPanel2.Name = "loadPanel2";
            this.loadPanel2.Size = new System.Drawing.Size(751, 16);
            this.loadPanel2.TabIndex = 1;
            // 
            // loadinglabel
            // 
            this.loadinglabel.AutoSize = true;
            this.loadinglabel.BackColor = System.Drawing.Color.Transparent;
            this.loadinglabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.loadinglabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loadinglabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.loadinglabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loadinglabel.Location = new System.Drawing.Point(12, 262);
            this.loadinglabel.Name = "loadinglabel";
            this.loadinglabel.Size = new System.Drawing.Size(95, 20);
            this.loadinglabel.TabIndex = 2;
            this.loadinglabel.Text = "Loading....";
            // 
            // loadtimer1
            // 
            this.loadtimer1.Enabled = true;
            this.loadtimer1.Interval = 15;
            this.loadtimer1.Tick += new System.EventHandler(this.loadtimer1_Tick);
            // 
            // Loading_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(750, 300);
            this.Controls.Add(this.loadpanel1);
            this.Controls.Add(this.loadinglabel);
            this.Controls.Add(this.loadPanel2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Coral;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loading_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loading_page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loadpanel1;
        private System.Windows.Forms.FlowLayoutPanel loadPanel2;
        private System.Windows.Forms.Label loadinglabel;
        private System.Windows.Forms.Timer loadtimer1;
    }
}

