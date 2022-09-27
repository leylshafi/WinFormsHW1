namespace WinFormsHW1._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.London = new System.Windows.Forms.Button();
            this.Baku = new System.Windows.Forms.Button();
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // London
            // 
            this.London.Location = new System.Drawing.Point(546, 62);
            this.London.Name = "London";
            this.London.Size = new System.Drawing.Size(132, 46);
            this.London.TabIndex = 0;
            this.London.Text = "London";
            this.London.UseVisualStyleBackColor = true;
            this.London.MouseClick += new System.Windows.Forms.MouseEventHandler(this.London_MouseClick);
            // 
            // Baku
            // 
            this.Baku.Location = new System.Drawing.Point(102, 64);
            this.Baku.Name = "Baku";
            this.Baku.Size = new System.Drawing.Size(132, 44);
            this.Baku.TabIndex = 1;
            this.Baku.Text = "Baku";
            this.Baku.UseVisualStyleBackColor = true;
            this.Baku.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Baku_MouseClick_1);
            // 
            // Time
            // 
            this.Time.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Time.Location = new System.Drawing.Point(620, 405);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(152, 36);
            this.Time.TabIndex = 2;
            this.Time.Text = "Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.Baku);
            this.Controls.Add(this.London);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button London;
        private Button Baku;
        private Label Time;
    }
}