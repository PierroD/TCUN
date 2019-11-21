namespace TCUN
{
    partial class FPSUnlocker
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
            this.tb_Fov = new System.Windows.Forms.TrackBar();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fov = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_FPS = new System.Windows.Forms.TrackBar();
            this.lbl_fps = new System.Windows.Forms.Label();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.btn_settings = new CircularButton();
            this.btn_disable = new CircularButton();
            this.btn_visual = new CircularButton();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.lbl_Game = new System.Windows.Forms.Label();
            this.pnl_tekno = new System.Windows.Forms.Panel();
            this.lbl_tekno = new System.Windows.Forms.Label();
            this.sw_tekno = new SwitchApple();
            this.Main_timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Fov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FPS)).BeginInit();
            this.pnl_menu.SuspendLayout();
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
            this.pnl_top.Size = new System.Drawing.Size(400, 40);
            this.pnl_top.TabIndex = 1;
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
            this.btn_close.Location = new System.Drawing.Point(367, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = " X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // tb_Fov
            // 
            this.tb_Fov.Location = new System.Drawing.Point(12, 94);
            this.tb_Fov.Maximum = 140;
            this.tb_Fov.Minimum = 65;
            this.tb_Fov.Name = "tb_Fov";
            this.tb_Fov.Size = new System.Drawing.Size(252, 45);
            this.tb_Fov.TabIndex = 2;
            this.tb_Fov.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_Fov.Value = 65;
            this.tb_Fov.Scroll += new System.EventHandler(this.Tb_Fov_Scroll);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_title.Location = new System.Drawing.Point(139, 43);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(124, 25);
            this.lbl_title.TabIndex = 28;
            this.lbl_title.Text = "FPS Unlocker";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.panel2.Location = new System.Drawing.Point(270, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 2);
            this.panel2.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(270, 105);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(86, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "FieldOfView";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_fov
            // 
            this.lbl_fov.AutoSize = true;
            this.lbl_fov.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fov.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_fov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_fov.Location = new System.Drawing.Point(367, 105);
            this.lbl_fov.Name = "lbl_fov";
            this.lbl_fov.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fov.Size = new System.Drawing.Size(19, 13);
            this.lbl_fov.TabIndex = 31;
            this.lbl_fov.Text = "65";
            this.lbl_fov.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.panel1.Location = new System.Drawing.Point(270, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 2);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(270, 167);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 33;
            this.label1.Text = "Max_FPS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_FPS
            // 
            this.tb_FPS.Location = new System.Drawing.Point(12, 156);
            this.tb_FPS.Maximum = 333;
            this.tb_FPS.Name = "tb_FPS";
            this.tb_FPS.Size = new System.Drawing.Size(252, 45);
            this.tb_FPS.TabIndex = 32;
            this.tb_FPS.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_FPS.Scroll += new System.EventHandler(this.Tb_FPS_Scroll);
            // 
            // lbl_fps
            // 
            this.lbl_fps.AutoSize = true;
            this.lbl_fps.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fps.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_fps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_fps.Location = new System.Drawing.Point(367, 170);
            this.lbl_fps.Name = "lbl_fps";
            this.lbl_fps.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fps.Size = new System.Drawing.Size(13, 13);
            this.lbl_fps.TabIndex = 35;
            this.lbl_fps.Text = "0";
            this.lbl_fps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnl_menu.Controls.Add(this.btn_settings);
            this.pnl_menu.Controls.Add(this.btn_disable);
            this.pnl_menu.Controls.Add(this.btn_visual);
            this.pnl_menu.Location = new System.Drawing.Point(0, 239);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(60, 310);
            this.pnl_menu.TabIndex = 36;
            // 
            // btn_settings
            // 
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Image = global::TCUN.Properties.Resources.save;
            this.btn_settings.Location = new System.Drawing.Point(3, 188);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(55, 55);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.Btn_settings_Click);
            // 
            // btn_disable
            // 
            this.btn_disable.FlatAppearance.BorderSize = 0;
            this.btn_disable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disable.Image = global::TCUN.Properties.Resources.disable32;
            this.btn_disable.Location = new System.Drawing.Point(3, 125);
            this.btn_disable.Name = "btn_disable";
            this.btn_disable.Size = new System.Drawing.Size(55, 55);
            this.btn_disable.TabIndex = 1;
            this.btn_disable.UseVisualStyleBackColor = true;
            this.btn_disable.Click += new System.EventHandler(this.Btn_disable_Click);
            // 
            // btn_visual
            // 
            this.btn_visual.FlatAppearance.BorderSize = 0;
            this.btn_visual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_visual.Image = global::TCUN.Properties.Resources.visual32;
            this.btn_visual.Location = new System.Drawing.Point(3, 62);
            this.btn_visual.Name = "btn_visual";
            this.btn_visual.Size = new System.Drawing.Size(55, 55);
            this.btn_visual.TabIndex = 0;
            this.btn_visual.UseVisualStyleBackColor = true;
            this.btn_visual.Click += new System.EventHandler(this.Btn_visual_Click);
            // 
            // pnl_form
            // 
            this.pnl_form.Location = new System.Drawing.Point(60, 239);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(340, 310);
            this.pnl_form.TabIndex = 37;
            // 
            // lbl_Game
            // 
            this.lbl_Game.AutoSize = true;
            this.lbl_Game.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Game.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_Game.Location = new System.Drawing.Point(9, 219);
            this.lbl_Game.Name = "lbl_Game";
            this.lbl_Game.Size = new System.Drawing.Size(43, 17);
            this.lbl_Game.TabIndex = 38;
            this.lbl_Game.Text = "Game";
            // 
            // pnl_tekno
            // 
            this.pnl_tekno.Controls.Add(this.lbl_tekno);
            this.pnl_tekno.Controls.Add(this.sw_tekno);
            this.pnl_tekno.Location = new System.Drawing.Point(257, 201);
            this.pnl_tekno.Name = "pnl_tekno";
            this.pnl_tekno.Size = new System.Drawing.Size(140, 35);
            this.pnl_tekno.TabIndex = 39;
            this.pnl_tekno.Visible = false;
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
            // Main_timer
            // 
            this.Main_timer.Enabled = true;
            this.Main_timer.Interval = 10;
            this.Main_timer.Tick += new System.EventHandler(this.Main_timer_Tick);
            // 
            // FPSUnlocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 550);
            this.Controls.Add(this.pnl_tekno);
            this.Controls.Add(this.lbl_Game);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.lbl_fps);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_FPS);
            this.Controls.Add(this.lbl_fov);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.tb_Fov);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FPSUnlocker";
            this.Text = "FPSUnlocker";
            this.Load += new System.EventHandler(this.FPSUnlocker_Load);
            this.pnl_top.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tb_Fov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FPS)).EndInit();
            this.pnl_menu.ResumeLayout(false);
            this.pnl_tekno.ResumeLayout(false);
            this.pnl_tekno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private CircularButton btn_close;
        private System.Windows.Forms.TrackBar tb_Fov;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fov;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar tb_FPS;
        private System.Windows.Forms.Label lbl_fps;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_form;
        private CircularButton btn_visual;
        private CircularButton btn_disable;
        private CircularButton btn_settings;
        private System.Windows.Forms.Label lbl_Game;
        private System.Windows.Forms.Panel pnl_tekno;
        private System.Windows.Forms.Label lbl_tekno;
        private SwitchApple sw_tekno;
        private System.Windows.Forms.Timer Main_timer;
    }
}