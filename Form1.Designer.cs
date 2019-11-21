namespace TCUN
{
    partial class TCUN
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnl_top = new System.Windows.Forms.Panel();
            this.btn_close = new CircularButton();
            this.btn_minimize = new System.Windows.Forms.Button();
            this.pnl_side = new System.Windows.Forms.Panel();
            this.pnl_select = new System.Windows.Forms.Panel();
            this.txt_version = new System.Windows.Forms.Label();
            this.btn_account = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.window_timer = new System.Windows.Forms.Timer(this.components);
            this.pnl_top.SuspendLayout();
            this.pnl_side.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_top
            // 
            this.pnl_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.pnl_top.Controls.Add(this.btn_close);
            this.pnl_top.Controls.Add(this.btn_minimize);
            this.pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_top.Location = new System.Drawing.Point(0, 0);
            this.pnl_top.Name = "pnl_top";
            this.pnl_top.Size = new System.Drawing.Size(880, 40);
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
            this.btn_close.Location = new System.Drawing.Point(847, 3);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(30, 30);
            this.btn_close.TabIndex = 0;
            this.btn_close.Text = " X";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_minimize
            // 
            this.btn_minimize.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimize.FlatAppearance.BorderSize = 0;
            this.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(105)))), ((int)(((byte)(240)))));
            this.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minimize.ForeColor = System.Drawing.Color.White;
            this.btn_minimize.Location = new System.Drawing.Point(811, 3);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(30, 30);
            this.btn_minimize.TabIndex = 2;
            this.btn_minimize.Text = "_";
            this.btn_minimize.UseVisualStyleBackColor = false;
            this.btn_minimize.Click += new System.EventHandler(this.Btn_minimize_Click);
            // 
            // pnl_side
            // 
            this.pnl_side.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.pnl_side.Controls.Add(this.pnl_select);
            this.pnl_side.Controls.Add(this.txt_version);
            this.pnl_side.Controls.Add(this.btn_account);
            this.pnl_side.Controls.Add(this.btn_settings);
            this.pnl_side.Controls.Add(this.btn_home);
            this.pnl_side.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_side.Location = new System.Drawing.Point(0, 40);
            this.pnl_side.Name = "pnl_side";
            this.pnl_side.Size = new System.Drawing.Size(180, 540);
            this.pnl_side.TabIndex = 1;
            // 
            // pnl_select
            // 
            this.pnl_select.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.pnl_select.Location = new System.Drawing.Point(3, 138);
            this.pnl_select.Name = "pnl_select";
            this.pnl_select.Size = new System.Drawing.Size(10, 40);
            this.pnl_select.TabIndex = 0;
            // 
            // txt_version
            // 
            this.txt_version.AutoSize = true;
            this.txt_version.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_version.ForeColor = System.Drawing.Color.White;
            this.txt_version.Location = new System.Drawing.Point(35, 513);
            this.txt_version.Name = "txt_version";
            this.txt_version.Size = new System.Drawing.Size(108, 17);
            this.txt_version.TabIndex = 3;
            this.txt_version.Text = "Version : V 1.1.3";
            // 
            // btn_account
            // 
            this.btn_account.FlatAppearance.BorderSize = 0;
            this.btn_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_account.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_account.ForeColor = System.Drawing.Color.White;
            this.btn_account.Image = global::TCUN.Properties.Resources.user;
            this.btn_account.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_account.Location = new System.Drawing.Point(12, 300);
            this.btn_account.Name = "btn_account";
            this.btn_account.Size = new System.Drawing.Size(155, 36);
            this.btn_account.TabIndex = 2;
            this.btn_account.Text = "    ACCOUNT";
            this.btn_account.UseVisualStyleBackColor = true;
            this.btn_account.Click += new System.EventHandler(this.Btn_account_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.FlatAppearance.BorderSize = 0;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_settings.ForeColor = System.Drawing.Color.White;
            this.btn_settings.Image = global::TCUN.Properties.Resources.cogs;
            this.btn_settings.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_settings.Location = new System.Drawing.Point(12, 220);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(155, 36);
            this.btn_settings.TabIndex = 1;
            this.btn_settings.Text = "    SETTINGS";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.Btn_settings_Click);
            // 
            // btn_home
            // 
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = global::TCUN.Properties.Resources.home;
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_home.Location = new System.Drawing.Point(12, 140);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(155, 36);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "HOME";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.Btn_home_Click);
            // 
            // Main_Panel
            // 
            this.Main_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Main_Panel.Location = new System.Drawing.Point(180, 40);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(700, 540);
            this.Main_Panel.TabIndex = 2;
            // 
            // window_timer
            // 
            this.window_timer.Enabled = true;
            this.window_timer.Interval = 1000;
            this.window_timer.Tick += new System.EventHandler(this.Window_timer_Tick);
            // 
            // TCUN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 580);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.pnl_side);
            this.Controls.Add(this.pnl_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TCUN";
            this.Text = "TCUN Menu";
            this.Load += new System.EventHandler(this.TCUN_Load);
            this.pnl_top.ResumeLayout(false);
            this.pnl_side.ResumeLayout(false);
            this.pnl_side.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_top;
        private System.Windows.Forms.Button btn_minimize;
        private System.Windows.Forms.Panel pnl_side;
        private System.Windows.Forms.Button btn_account;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Label txt_version;
        private System.Windows.Forms.Panel Main_Panel;
        private CircularButton btn_close;
        private System.Windows.Forms.Panel pnl_select;
        private System.Windows.Forms.Timer window_timer;
    }
}

