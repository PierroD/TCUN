namespace TCUN
{
    partial class ForceHost
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
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_close = new CircularButton();
            this.pnl_size = new System.Windows.Forms.Panel();
            this.btn_save = new CircularButton();
            this.btn_NotHost = new CircularButton();
            this.btn_ForceHost = new CircularButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.gbox_status = new System.Windows.Forms.GroupBox();
            this.lbl_host_status = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_host = new System.Windows.Forms.Label();
            this.lbl_ingame_satus = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_ingame = new System.Windows.Forms.Label();
            this.pnl_form = new System.Windows.Forms.Panel();
            this.pnl_top.SuspendLayout();
            this.pnl_size.SuspendLayout();
            this.gbox_status.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(800, 40);
            this.pnl_top.TabIndex = 2;
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
            this.btn_close.Location = new System.Drawing.Point(767, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = " X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // pnl_size
            // 
            this.pnl_size.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnl_size.Controls.Add(this.btn_save);
            this.pnl_size.Controls.Add(this.btn_NotHost);
            this.pnl_size.Controls.Add(this.btn_ForceHost);
            this.pnl_size.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_size.Location = new System.Drawing.Point(0, 40);
            this.pnl_size.Name = "pnl_size";
            this.pnl_size.Size = new System.Drawing.Size(60, 510);
            this.pnl_size.TabIndex = 3;
            // 
            // btn_save
            // 
            this.btn_save.FlatAppearance.BorderSize = 0;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Image = global::TCUN.Properties.Resources.save;
            this.btn_save.Location = new System.Drawing.Point(3, 342);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(55, 55);
            this.btn_save.TabIndex = 2;
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_NotHost
            // 
            this.btn_NotHost.FlatAppearance.BorderSize = 0;
            this.btn_NotHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NotHost.Image = global::TCUN.Properties.Resources.visual32;
            this.btn_NotHost.Location = new System.Drawing.Point(3, 281);
            this.btn_NotHost.Name = "btn_NotHost";
            this.btn_NotHost.Size = new System.Drawing.Size(55, 55);
            this.btn_NotHost.TabIndex = 1;
            this.btn_NotHost.UseVisualStyleBackColor = true;
            this.btn_NotHost.Click += new System.EventHandler(this.Btn_NotHost_Click);
            // 
            // btn_ForceHost
            // 
            this.btn_ForceHost.FlatAppearance.BorderSize = 0;
            this.btn_ForceHost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ForceHost.Image = global::TCUN.Properties.Resources.disable32;
            this.btn_ForceHost.Location = new System.Drawing.Point(3, 220);
            this.btn_ForceHost.Name = "btn_ForceHost";
            this.btn_ForceHost.Size = new System.Drawing.Size(55, 55);
            this.btn_ForceHost.TabIndex = 0;
            this.btn_ForceHost.UseVisualStyleBackColor = true;
            this.btn_ForceHost.Click += new System.EventHandler(this.Btn_ForceHost_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_title.Location = new System.Drawing.Point(365, 43);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(104, 25);
            this.lbl_title.TabIndex = 29;
            this.lbl_title.Text = "Force Host";
            // 
            // gbox_status
            // 
            this.gbox_status.BackColor = System.Drawing.Color.White;
            this.gbox_status.Controls.Add(this.lbl_host_status);
            this.gbox_status.Controls.Add(this.panel3);
            this.gbox_status.Controls.Add(this.lbl_host);
            this.gbox_status.Controls.Add(this.lbl_ingame_satus);
            this.gbox_status.Controls.Add(this.panel2);
            this.gbox_status.Controls.Add(this.lbl_ingame);
            this.gbox_status.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.gbox_status.Location = new System.Drawing.Point(69, 88);
            this.gbox_status.Name = "gbox_status";
            this.gbox_status.Size = new System.Drawing.Size(727, 67);
            this.gbox_status.TabIndex = 30;
            this.gbox_status.TabStop = false;
            this.gbox_status.Text = "Status";
            // 
            // lbl_host_status
            // 
            this.lbl_host_status.AutoSize = true;
            this.lbl_host_status.BackColor = System.Drawing.Color.Transparent;
            this.lbl_host_status.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_host_status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_host_status.Location = new System.Drawing.Point(476, 28);
            this.lbl_host_status.Name = "lbl_host_status";
            this.lbl_host_status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_host_status.Size = new System.Drawing.Size(54, 13);
            this.lbl_host_status.TabIndex = 37;
            this.lbl_host_status.Text = "Unknown";
            this.lbl_host_status.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.panel3.Location = new System.Drawing.Point(383, 43);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 2);
            this.panel3.TabIndex = 36;
            // 
            // lbl_host
            // 
            this.lbl_host.AutoSize = true;
            this.lbl_host.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_host.Location = new System.Drawing.Point(383, 25);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(87, 17);
            this.lbl_host.TabIndex = 35;
            this.lbl_host.Text = "Host Status :";
            this.lbl_host.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_ingame_satus
            // 
            this.lbl_ingame_satus.AutoSize = true;
            this.lbl_ingame_satus.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ingame_satus.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_ingame_satus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_ingame_satus.Location = new System.Drawing.Point(225, 26);
            this.lbl_ingame_satus.Name = "lbl_ingame_satus";
            this.lbl_ingame_satus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_ingame_satus.Size = new System.Drawing.Size(72, 13);
            this.lbl_ingame_satus.TabIndex = 34;
            this.lbl_ingame_satus.Text = "Not In-Game";
            this.lbl_ingame_satus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.panel2.Location = new System.Drawing.Point(149, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 2);
            this.panel2.TabIndex = 33;
            // 
            // lbl_ingame
            // 
            this.lbl_ingame.AutoSize = true;
            this.lbl_ingame.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ingame.Location = new System.Drawing.Point(149, 22);
            this.lbl_ingame.Name = "lbl_ingame";
            this.lbl_ingame.Size = new System.Drawing.Size(68, 17);
            this.lbl_ingame.TabIndex = 32;
            this.lbl_ingame.Text = "In-Game :";
            this.lbl_ingame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnl_form
            // 
            this.pnl_form.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_form.Location = new System.Drawing.Point(60, 161);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(740, 389);
            this.pnl_form.TabIndex = 31;
            // 
            // ForceHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 550);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.gbox_status);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pnl_size);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForceHost";
            this.Text = "ForceHost";
            this.Load += new System.EventHandler(this.ForceHost_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_size.ResumeLayout(false);
            this.gbox_status.ResumeLayout(false);
            this.gbox_status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private CircularButton btn_close;
        private System.Windows.Forms.Panel pnl_size;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox gbox_status;
        private System.Windows.Forms.Label lbl_host_status;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_host;
        private System.Windows.Forms.Label lbl_ingame_satus;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_ingame;
        private System.Windows.Forms.Panel pnl_form;
        private CircularButton btn_ForceHost;
        private CircularButton btn_save;
        private CircularButton btn_NotHost;
    }
}