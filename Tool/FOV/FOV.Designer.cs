namespace TCUN
{
    partial class FOV
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_close = new CircularButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tb_Fov = new System.Windows.Forms.TrackBar();
            this.lbl_fov = new System.Windows.Forms.Label();
            this.lbl_Game = new System.Windows.Forms.Label();
            this.fov_timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_tekno = new System.Windows.Forms.Label();
            this.sw_tekno = new SwitchApple();
            this.pnl_tekno = new System.Windows.Forms.Panel();
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Fov)).BeginInit();
            this.pnl_tekno.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(300, 40);
            this.pnl_top.TabIndex = 0;
            this.pnl_top.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pnl_top_MouseDown);
            this.pnl_top.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pnl_top_MouseMove);
            this.pnl_top.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pnl_top_MouseUp);
            // 
            // btn_close
            // 
            this.btn_close.FlatAppearance.BorderSize = 0;
            this.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.ForeColor = System.Drawing.Color.White;
            this.btn_close.Location = new System.Drawing.Point(267, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = " X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_title.Location = new System.Drawing.Point(87, 43);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(125, 25);
            this.lbl_title.TabIndex = 27;
            this.lbl_title.Text = "Field Of View";
            // 
            // tb_Fov
            // 
            this.tb_Fov.Location = new System.Drawing.Point(12, 130);
            this.tb_Fov.Maximum = 140;
            this.tb_Fov.Minimum = 65;
            this.tb_Fov.Name = "tb_Fov";
            this.tb_Fov.Size = new System.Drawing.Size(276, 45);
            this.tb_Fov.TabIndex = 1;
            this.tb_Fov.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_Fov.Value = 65;
            this.tb_Fov.Scroll += new System.EventHandler(this.Tb_Fov_Scroll);
            // 
            // lbl_fov
            // 
            this.lbl_fov.AutoSize = true;
            this.lbl_fov.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_fov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbl_fov.Location = new System.Drawing.Point(134, 102);
            this.lbl_fov.Name = "lbl_fov";
            this.lbl_fov.Size = new System.Drawing.Size(34, 25);
            this.lbl_fov.TabIndex = 28;
            this.lbl_fov.Text = "65";
            // 
            // lbl_Game
            // 
            this.lbl_Game.AutoSize = true;
            this.lbl_Game.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_Game.Location = new System.Drawing.Point(19, 269);
            this.lbl_Game.Name = "lbl_Game";
            this.lbl_Game.Size = new System.Drawing.Size(43, 17);
            this.lbl_Game.TabIndex = 29;
            this.lbl_Game.Text = "Game";
            // 
            // fov_timer
            // 
            this.fov_timer.Enabled = true;
            this.fov_timer.Interval = 10;
            this.fov_timer.Tick += new System.EventHandler(this.Fov_timer_Tick);
            // 
            // lbl_tekno
            // 
            this.lbl_tekno.AutoSize = true;
            this.lbl_tekno.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tekno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbl_tekno.Location = new System.Drawing.Point(7, 11);
            this.lbl_tekno.Name = "lbl_tekno";
            this.lbl_tekno.Size = new System.Drawing.Size(81, 17);
            this.lbl_tekno.TabIndex = 30;
            this.lbl_tekno.Text = "TeknoMW3 ";
            // 
            // sw_tekno
            // 
            this.sw_tekno.BorderColor = System.Drawing.Color.LightGray;
            this.sw_tekno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_tekno.IsOn = false;
            this.sw_tekno.Location = new System.Drawing.Point(94, 9);
            this.sw_tekno.Name = "sw_tekno";
            this.sw_tekno.Size = new System.Drawing.Size(34, 19);
            this.sw_tekno.TabIndex = 31;
            this.sw_tekno.Text = "switchApple3";
            this.sw_tekno.TextEnabled = true;
            // 
            // pnl_tekno
            // 
            this.pnl_tekno.Controls.Add(this.lbl_tekno);
            this.pnl_tekno.Controls.Add(this.sw_tekno);
            this.pnl_tekno.Location = new System.Drawing.Point(12, 222);
            this.pnl_tekno.Name = "pnl_tekno";
            this.pnl_tekno.Size = new System.Drawing.Size(140, 35);
            this.pnl_tekno.TabIndex = 32;
            this.pnl_tekno.Visible = false;
            // 
            // FOV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Controls.Add(this.pnl_tekno);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.lbl_Game);
            this.Controls.Add(this.lbl_fov);
            this.Controls.Add(this.tb_Fov);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FOV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FOV";
            this.pnl_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Fov)).EndInit();
            this.pnl_tekno.ResumeLayout(false);
            this.pnl_tekno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private CircularButton btn_close;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TrackBar tb_Fov;
        private System.Windows.Forms.Label lbl_fov;
        private System.Windows.Forms.Label lbl_Game;
        private System.Windows.Forms.Timer fov_timer;
        private System.Windows.Forms.Label lbl_tekno;
        private SwitchApple sw_tekno;
        private System.Windows.Forms.Panel pnl_tekno;
    }
}