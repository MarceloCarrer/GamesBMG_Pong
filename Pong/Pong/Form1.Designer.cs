namespace Pong
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Beginner_btn = new System.Windows.Forms.Button();
            this.Medium_btn = new System.Windows.Forms.Button();
            this.Hard_btn = new System.Windows.Forms.Button();
            this.Insane_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(68, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHOOSE THE LEVEL";
            // 
            // Beginner_btn
            // 
            this.Beginner_btn.BackColor = System.Drawing.Color.SeaGreen;
            this.Beginner_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beginner_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Beginner_btn.Location = new System.Drawing.Point(113, 60);
            this.Beginner_btn.Name = "Beginner_btn";
            this.Beginner_btn.Size = new System.Drawing.Size(245, 82);
            this.Beginner_btn.TabIndex = 1;
            this.Beginner_btn.Text = "BEGINNER";
            this.Beginner_btn.UseVisualStyleBackColor = false;
            this.Beginner_btn.Click += new System.EventHandler(this.Beginner_btn_Click);
            // 
            // Medium_btn
            // 
            this.Medium_btn.BackColor = System.Drawing.Color.Khaki;
            this.Medium_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Medium_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Medium_btn.Location = new System.Drawing.Point(113, 173);
            this.Medium_btn.Name = "Medium_btn";
            this.Medium_btn.Size = new System.Drawing.Size(245, 82);
            this.Medium_btn.TabIndex = 2;
            this.Medium_btn.Text = "MEDIUM";
            this.Medium_btn.UseVisualStyleBackColor = false;
            this.Medium_btn.Click += new System.EventHandler(this.Medium_btn_Click);
            // 
            // Hard_btn
            // 
            this.Hard_btn.BackColor = System.Drawing.Color.IndianRed;
            this.Hard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hard_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Hard_btn.Location = new System.Drawing.Point(113, 286);
            this.Hard_btn.Name = "Hard_btn";
            this.Hard_btn.Size = new System.Drawing.Size(245, 82);
            this.Hard_btn.TabIndex = 3;
            this.Hard_btn.Text = "HARD";
            this.Hard_btn.UseVisualStyleBackColor = false;
            this.Hard_btn.Click += new System.EventHandler(this.Hard_btn_Click);
            // 
            // Insane_btn
            // 
            this.Insane_btn.BackColor = System.Drawing.Color.Indigo;
            this.Insane_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Insane_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Insane_btn.Location = new System.Drawing.Point(113, 400);
            this.Insane_btn.Name = "Insane_btn";
            this.Insane_btn.Size = new System.Drawing.Size(245, 82);
            this.Insane_btn.TabIndex = 4;
            this.Insane_btn.Text = "INSANE";
            this.Insane_btn.UseVisualStyleBackColor = false;
            this.Insane_btn.Click += new System.EventHandler(this.Insane_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Pong.Properties.Resources.Key_Arrow;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(110, 502);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 80);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(155, 530);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "PLAYER MOVEMENT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(490, 594);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Insane_btn);
            this.Controls.Add(this.Hard_btn);
            this.Controls.Add(this.Medium_btn);
            this.Controls.Add(this.Beginner_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "PONG";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Beginner_btn;
        private System.Windows.Forms.Button Medium_btn;
        private System.Windows.Forms.Button Hard_btn;
        private System.Windows.Forms.Button Insane_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

