namespace TCUN
{
    partial class FH_Not_Host_Settings
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_fps_name = new System.Windows.Forms.Label();
            this.tb_FPS = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_fov_name = new System.Windows.Forms.Label();
            this.tb_Fov = new System.Windows.Forms.TrackBar();
            this.lbl_fps = new System.Windows.Forms.Label();
            this.lbl_fov = new System.Windows.Forms.Label();
            this.lbl_Fullbright = new System.Windows.Forms.Label();
            this.lbl_Specular = new System.Windows.Forms.Label();
            this.lbl_Movie = new System.Windows.Forms.Label();
            this.sw_Movie = new SwitchApple();
            this.cmb_specular = new System.Windows.Forms.ComboBox();
            this.cmb_fullbright = new System.Windows.Forms.ComboBox();
            this.lbl_NoSkins = new System.Windows.Forms.Label();
            this.sw_NoSkins = new SwitchApple();
            this.lbl_NoBullet = new System.Windows.Forms.Label();
            this.sw_NoBullet = new SwitchApple();
            this.lbl_NoGlow = new System.Windows.Forms.Label();
            this.sw_NoGlow = new SwitchApple();
            this.lnl_NoFog = new System.Windows.Forms.Label();
            this.sw_NoFog = new SwitchApple();
            this.Timer_Set_Value = new System.Windows.Forms.Timer(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.circularpicturebox2 = new circularpicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.tb_FPS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Fov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularpicturebox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.panel1.Location = new System.Drawing.Point(398, 135);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 2);
            this.panel1.TabIndex = 40;
            // 
            // lbl_fps_name
            // 
            this.lbl_fps_name.AutoSize = true;
            this.lbl_fps_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_fps_name.Location = new System.Drawing.Point(398, 117);
            this.lbl_fps_name.Name = "lbl_fps_name";
            this.lbl_fps_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fps_name.Size = new System.Drawing.Size(65, 19);
            this.lbl_fps_name.TabIndex = 39;
            this.lbl_fps_name.Text = "Max_FPS";
            this.lbl_fps_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_FPS
            // 
            this.tb_FPS.Location = new System.Drawing.Point(140, 106);
            this.tb_FPS.Maximum = 333;
            this.tb_FPS.Name = "tb_FPS";
            this.tb_FPS.Size = new System.Drawing.Size(252, 45);
            this.tb_FPS.TabIndex = 38;
            this.tb_FPS.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_FPS.Scroll += new System.EventHandler(this.Tb_FPS_Scroll);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.panel2.Location = new System.Drawing.Point(398, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 2);
            this.panel2.TabIndex = 37;
            // 
            // lbl_fov_name
            // 
            this.lbl_fov_name.AutoSize = true;
            this.lbl_fov_name.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_fov_name.Location = new System.Drawing.Point(398, 55);
            this.lbl_fov_name.Name = "lbl_fov_name";
            this.lbl_fov_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fov_name.Size = new System.Drawing.Size(86, 19);
            this.lbl_fov_name.TabIndex = 36;
            this.lbl_fov_name.Text = "FieldOfView";
            this.lbl_fov_name.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_Fov
            // 
            this.tb_Fov.Location = new System.Drawing.Point(140, 44);
            this.tb_Fov.Maximum = 140;
            this.tb_Fov.Minimum = 65;
            this.tb_Fov.Name = "tb_Fov";
            this.tb_Fov.Size = new System.Drawing.Size(252, 45);
            this.tb_Fov.TabIndex = 35;
            this.tb_Fov.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tb_Fov.Value = 65;
            this.tb_Fov.Scroll += new System.EventHandler(this.Tb_Fov_Scroll);
            // 
            // lbl_fps
            // 
            this.lbl_fps.AutoSize = true;
            this.lbl_fps.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fps.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_fps.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_fps.Location = new System.Drawing.Point(502, 120);
            this.lbl_fps.Name = "lbl_fps";
            this.lbl_fps.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fps.Size = new System.Drawing.Size(13, 13);
            this.lbl_fps.TabIndex = 42;
            this.lbl_fps.Text = "0";
            this.lbl_fps.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_fov
            // 
            this.lbl_fov.AutoSize = true;
            this.lbl_fov.BackColor = System.Drawing.Color.Transparent;
            this.lbl_fov.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_fov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_fov.Location = new System.Drawing.Point(502, 58);
            this.lbl_fov.Name = "lbl_fov";
            this.lbl_fov.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fov.Size = new System.Drawing.Size(19, 13);
            this.lbl_fov.TabIndex = 41;
            this.lbl_fov.Text = "65";
            this.lbl_fov.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Fullbright
            // 
            this.lbl_Fullbright.AutoSize = true;
            this.lbl_Fullbright.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Fullbright.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_Fullbright.Location = new System.Drawing.Point(212, 174);
            this.lbl_Fullbright.Name = "lbl_Fullbright";
            this.lbl_Fullbright.Size = new System.Drawing.Size(66, 17);
            this.lbl_Fullbright.TabIndex = 48;
            this.lbl_Fullbright.Text = "Fullbright";
            this.lbl_Fullbright.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Specular
            // 
            this.lbl_Specular.AutoSize = true;
            this.lbl_Specular.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Specular.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.lbl_Specular.Location = new System.Drawing.Point(421, 174);
            this.lbl_Specular.Name = "lbl_Specular";
            this.lbl_Specular.Size = new System.Drawing.Size(59, 17);
            this.lbl_Specular.TabIndex = 47;
            this.lbl_Specular.Text = "Specular";
            this.lbl_Specular.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbl_Movie
            // 
            this.lbl_Movie.AutoSize = true;
            this.lbl_Movie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Movie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbl_Movie.Location = new System.Drawing.Point(158, 247);
            this.lbl_Movie.Name = "lbl_Movie";
            this.lbl_Movie.Size = new System.Drawing.Size(45, 17);
            this.lbl_Movie.TabIndex = 46;
            this.lbl_Movie.Text = "Movie";
            this.lbl_Movie.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sw_Movie
            // 
            this.sw_Movie.BorderColor = System.Drawing.Color.LightGray;
            this.sw_Movie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_Movie.IsOn = false;
            this.sw_Movie.Location = new System.Drawing.Point(209, 247);
            this.sw_Movie.Name = "sw_Movie";
            this.sw_Movie.Size = new System.Drawing.Size(34, 19);
            this.sw_Movie.TabIndex = 45;
            this.sw_Movie.Text = "switchApple2";
            this.sw_Movie.TextEnabled = true;
            this.sw_Movie.Click += new System.EventHandler(this.Sw_Movie_Click);
            // 
            // cmb_specular
            // 
            this.cmb_specular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_specular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_specular.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_specular.FormattingEnabled = true;
            this.cmb_specular.Location = new System.Drawing.Point(371, 194);
            this.cmb_specular.Name = "cmb_specular";
            this.cmb_specular.Size = new System.Drawing.Size(157, 23);
            this.cmb_specular.TabIndex = 44;
            this.cmb_specular.TextChanged += new System.EventHandler(this.Cmb_specular_TextChanged);
            // 
            // cmb_fullbright
            // 
            this.cmb_fullbright.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fullbright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_fullbright.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_fullbright.FormattingEnabled = true;
            this.cmb_fullbright.Location = new System.Drawing.Point(161, 194);
            this.cmb_fullbright.Name = "cmb_fullbright";
            this.cmb_fullbright.Size = new System.Drawing.Size(157, 23);
            this.cmb_fullbright.TabIndex = 43;
            this.cmb_fullbright.TextChanged += new System.EventHandler(this.Cmb_fullbright_TextChanged);
            // 
            // lbl_NoSkins
            // 
            this.lbl_NoSkins.AutoSize = true;
            this.lbl_NoSkins.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoSkins.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbl_NoSkins.Location = new System.Drawing.Point(423, 299);
            this.lbl_NoSkins.Name = "lbl_NoSkins";
            this.lbl_NoSkins.Size = new System.Drawing.Size(61, 17);
            this.lbl_NoSkins.TabIndex = 56;
            this.lbl_NoSkins.Text = "No Skins";
            this.lbl_NoSkins.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sw_NoSkins
            // 
            this.sw_NoSkins.BorderColor = System.Drawing.Color.LightGray;
            this.sw_NoSkins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_NoSkins.IsOn = false;
            this.sw_NoSkins.Location = new System.Drawing.Point(494, 297);
            this.sw_NoSkins.Name = "sw_NoSkins";
            this.sw_NoSkins.Size = new System.Drawing.Size(34, 19);
            this.sw_NoSkins.TabIndex = 55;
            this.sw_NoSkins.Text = "switchApple2";
            this.sw_NoSkins.TextEnabled = true;
            this.sw_NoSkins.Click += new System.EventHandler(this.Sw_NoSkins_Click);
            // 
            // lbl_NoBullet
            // 
            this.lbl_NoBullet.AutoSize = true;
            this.lbl_NoBullet.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoBullet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbl_NoBullet.Location = new System.Drawing.Point(423, 249);
            this.lbl_NoBullet.Name = "lbl_NoBullet";
            this.lbl_NoBullet.Size = new System.Drawing.Size(64, 17);
            this.lbl_NoBullet.TabIndex = 54;
            this.lbl_NoBullet.Text = "No Bullet";
            this.lbl_NoBullet.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sw_NoBullet
            // 
            this.sw_NoBullet.BorderColor = System.Drawing.Color.LightGray;
            this.sw_NoBullet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_NoBullet.IsOn = false;
            this.sw_NoBullet.Location = new System.Drawing.Point(494, 247);
            this.sw_NoBullet.Name = "sw_NoBullet";
            this.sw_NoBullet.Size = new System.Drawing.Size(34, 19);
            this.sw_NoBullet.TabIndex = 53;
            this.sw_NoBullet.Text = "switchApple2";
            this.sw_NoBullet.TextEnabled = true;
            this.sw_NoBullet.Click += new System.EventHandler(this.Sw_NoBullet_Click);
            // 
            // lbl_NoGlow
            // 
            this.lbl_NoGlow.AutoSize = true;
            this.lbl_NoGlow.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NoGlow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbl_NoGlow.Location = new System.Drawing.Point(273, 299);
            this.lbl_NoGlow.Name = "lbl_NoGlow";
            this.lbl_NoGlow.Size = new System.Drawing.Size(60, 17);
            this.lbl_NoGlow.TabIndex = 52;
            this.lbl_NoGlow.Text = "No Glow";
            this.lbl_NoGlow.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sw_NoGlow
            // 
            this.sw_NoGlow.BorderColor = System.Drawing.Color.LightGray;
            this.sw_NoGlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_NoGlow.IsOn = false;
            this.sw_NoGlow.Location = new System.Drawing.Point(344, 299);
            this.sw_NoGlow.Name = "sw_NoGlow";
            this.sw_NoGlow.Size = new System.Drawing.Size(34, 19);
            this.sw_NoGlow.TabIndex = 51;
            this.sw_NoGlow.Text = "switchApple2";
            this.sw_NoGlow.TextEnabled = true;
            this.sw_NoGlow.Click += new System.EventHandler(this.Sw_NoGlow_Click);
            // 
            // lnl_NoFog
            // 
            this.lnl_NoFog.AutoSize = true;
            this.lnl_NoFog.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnl_NoFog.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lnl_NoFog.Location = new System.Drawing.Point(273, 249);
            this.lnl_NoFog.Name = "lnl_NoFog";
            this.lnl_NoFog.Size = new System.Drawing.Size(53, 17);
            this.lnl_NoFog.TabIndex = 50;
            this.lnl_NoFog.Text = "No Fog";
            this.lnl_NoFog.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sw_NoFog
            // 
            this.sw_NoFog.BorderColor = System.Drawing.Color.LightGray;
            this.sw_NoFog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_NoFog.IsOn = false;
            this.sw_NoFog.Location = new System.Drawing.Point(344, 247);
            this.sw_NoFog.Name = "sw_NoFog";
            this.sw_NoFog.Size = new System.Drawing.Size(34, 19);
            this.sw_NoFog.TabIndex = 49;
            this.sw_NoFog.Text = "switchApple2";
            this.sw_NoFog.TextEnabled = true;
            this.sw_NoFog.Click += new System.EventHandler(this.Sw_NoFog_Click);
            // 
            // Timer_Set_Value
            // 
            this.Timer_Set_Value.Interval = 1000;
            this.Timer_Set_Value.Tick += new System.EventHandler(this.Timer_Set_Value_Tick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.label12.Location = new System.Drawing.Point(45, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 21);
            this.label12.TabIndex = 58;
            this.label12.Text = "Not Host";
            // 
            // circularpicturebox2
            // 
            this.circularpicturebox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.circularpicturebox2.Image = global::TCUN.Properties.Resources.visual32;
            this.circularpicturebox2.Location = new System.Drawing.Point(7, 6);
            this.circularpicturebox2.Name = "circularpicturebox2";
            this.circularpicturebox2.Size = new System.Drawing.Size(32, 32);
            this.circularpicturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularpicturebox2.TabIndex = 57;
            this.circularpicturebox2.TabStop = false;
            // 
            // FH_Not_Host_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.circularpicturebox2);
            this.Controls.Add(this.lbl_NoSkins);
            this.Controls.Add(this.sw_NoSkins);
            this.Controls.Add(this.lbl_NoBullet);
            this.Controls.Add(this.sw_NoBullet);
            this.Controls.Add(this.lbl_NoGlow);
            this.Controls.Add(this.sw_NoGlow);
            this.Controls.Add(this.lnl_NoFog);
            this.Controls.Add(this.sw_NoFog);
            this.Controls.Add(this.lbl_Fullbright);
            this.Controls.Add(this.lbl_Specular);
            this.Controls.Add(this.lbl_Movie);
            this.Controls.Add(this.sw_Movie);
            this.Controls.Add(this.cmb_specular);
            this.Controls.Add(this.cmb_fullbright);
            this.Controls.Add(this.lbl_fps);
            this.Controls.Add(this.lbl_fov);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_fps_name);
            this.Controls.Add(this.tb_FPS);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lbl_fov_name);
            this.Controls.Add(this.tb_Fov);
            this.Name = "FH_Not_Host_Settings";
            this.Size = new System.Drawing.Size(740, 389);
            ((System.ComponentModel.ISupportInitialize)(this.tb_FPS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_Fov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularpicturebox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_fps_name;
        private System.Windows.Forms.TrackBar tb_FPS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_fov_name;
        private System.Windows.Forms.TrackBar tb_Fov;
        private System.Windows.Forms.Label lbl_fps;
        private System.Windows.Forms.Label lbl_fov;
        private System.Windows.Forms.Label lbl_Fullbright;
        private System.Windows.Forms.Label lbl_Specular;
        private System.Windows.Forms.Label lbl_Movie;
        private SwitchApple sw_Movie;
        private System.Windows.Forms.ComboBox cmb_specular;
        private System.Windows.Forms.ComboBox cmb_fullbright;
        private System.Windows.Forms.Label lbl_NoSkins;
        private SwitchApple sw_NoSkins;
        private System.Windows.Forms.Label lbl_NoBullet;
        private SwitchApple sw_NoBullet;
        private System.Windows.Forms.Label lbl_NoGlow;
        private SwitchApple sw_NoGlow;
        private System.Windows.Forms.Label lnl_NoFog;
        private SwitchApple sw_NoFog;
        private System.Windows.Forms.Timer Timer_Set_Value;
        private System.Windows.Forms.Label label12;
        private circularpicturebox circularpicturebox2;
    }
}
