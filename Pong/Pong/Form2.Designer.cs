namespace Pong
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.ScoreCPU_lbl = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ScorePlayer_lbl = new System.Windows.Forms.Label();
            this.BorderDown_pbx = new System.Windows.Forms.PictureBox();
            this.BorderUp_pbx = new System.Windows.Forms.PictureBox();
            this.Arrow_pbx = new System.Windows.Forms.PictureBox();
            this.CPU_pbx = new System.Windows.Forms.PictureBox();
            this.Player_pbx = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BorderDown_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderUp_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_pbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_pbx)).BeginInit();
            this.SuspendLayout();
            // 
            // ScoreCPU_lbl
            // 
            this.ScoreCPU_lbl.AutoSize = true;
            this.ScoreCPU_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ScoreCPU_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreCPU_lbl.ForeColor = System.Drawing.Color.Firebrick;
            this.ScoreCPU_lbl.Location = new System.Drawing.Point(728, 9);
            this.ScoreCPU_lbl.Name = "ScoreCPU_lbl";
            this.ScoreCPU_lbl.Size = new System.Drawing.Size(55, 37);
            this.ScoreCPU_lbl.TabIndex = 9;
            this.ScoreCPU_lbl.Text = "00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // ScorePlayer_lbl
            // 
            this.ScorePlayer_lbl.AutoSize = true;
            this.ScorePlayer_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ScorePlayer_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScorePlayer_lbl.ForeColor = System.Drawing.Color.RoyalBlue;
            this.ScorePlayer_lbl.Location = new System.Drawing.Point(111, 9);
            this.ScorePlayer_lbl.Name = "ScorePlayer_lbl";
            this.ScorePlayer_lbl.Size = new System.Drawing.Size(55, 37);
            this.ScorePlayer_lbl.TabIndex = 8;
            this.ScorePlayer_lbl.Text = "00";
            // 
            // BorderDown_pbx
            // 
            this.BorderDown_pbx.BackColor = System.Drawing.Color.Transparent;
            this.BorderDown_pbx.Location = new System.Drawing.Point(4, 570);
            this.BorderDown_pbx.Name = "BorderDown_pbx";
            this.BorderDown_pbx.Size = new System.Drawing.Size(920, 19);
            this.BorderDown_pbx.TabIndex = 11;
            this.BorderDown_pbx.TabStop = false;
            // 
            // BorderUp_pbx
            // 
            this.BorderUp_pbx.BackColor = System.Drawing.Color.Transparent;
            this.BorderUp_pbx.Location = new System.Drawing.Point(4, -13);
            this.BorderUp_pbx.Name = "BorderUp_pbx";
            this.BorderUp_pbx.Size = new System.Drawing.Size(920, 19);
            this.BorderUp_pbx.TabIndex = 10;
            this.BorderUp_pbx.TabStop = false;
            // 
            // Arrow_pbx
            // 
            this.Arrow_pbx.BackColor = System.Drawing.Color.Transparent;
            this.Arrow_pbx.BackgroundImage = global::Pong.Properties.Resources.Arrow_Pong2;
            this.Arrow_pbx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Arrow_pbx.Location = new System.Drawing.Point(434, 239);
            this.Arrow_pbx.Name = "Arrow_pbx";
            this.Arrow_pbx.Size = new System.Drawing.Size(26, 27);
            this.Arrow_pbx.TabIndex = 7;
            this.Arrow_pbx.TabStop = false;
            // 
            // CPU_pbx
            // 
            this.CPU_pbx.BackColor = System.Drawing.Color.Firebrick;
            this.CPU_pbx.Location = new System.Drawing.Point(897, 186);
            this.CPU_pbx.Name = "CPU_pbx";
            this.CPU_pbx.Size = new System.Drawing.Size(27, 127);
            this.CPU_pbx.TabIndex = 6;
            this.CPU_pbx.TabStop = false;
            // 
            // Player_pbx
            // 
            this.Player_pbx.BackColor = System.Drawing.Color.RoyalBlue;
            this.Player_pbx.Location = new System.Drawing.Point(4, 186);
            this.Player_pbx.Name = "Player_pbx";
            this.Player_pbx.Size = new System.Drawing.Size(27, 127);
            this.Player_pbx.TabIndex = 5;
            this.Player_pbx.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.BorderDown_pbx);
            this.Controls.Add(this.BorderUp_pbx);
            this.Controls.Add(this.ScoreCPU_lbl);
            this.Controls.Add(this.ScorePlayer_lbl);
            this.Controls.Add(this.Arrow_pbx);
            this.Controls.Add(this.CPU_pbx);
            this.Controls.Add(this.Player_pbx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "PONG";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PressKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PressKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BorderDown_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorderUp_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Arrow_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPU_pbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player_pbx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreCPU_lbl;
        private System.Windows.Forms.PictureBox Arrow_pbx;
        private System.Windows.Forms.PictureBox CPU_pbx;
        private System.Windows.Forms.PictureBox Player_pbx;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label ScorePlayer_lbl;
        private System.Windows.Forms.PictureBox BorderUp_pbx;
        private System.Windows.Forms.PictureBox BorderDown_pbx;
    }
}