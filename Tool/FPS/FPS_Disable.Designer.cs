namespace TCUN
{
    partial class FPS_Disable
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
            this.lbl_Movie = new System.Windows.Forms.Label();
            this.sw_NoFog = new SwitchApple();
            this.label1 = new System.Windows.Forms.Label();
            this.sw_NoGlow = new SwitchApple();
            this.label2 = new System.Windows.Forms.Label();
            this.sw_NoBullet = new SwitchApple();
            this.label3 = new System.Windows.Forms.Label();
            this.sw_NoSkins = new SwitchApple();
            this.label12 = new System.Windows.Forms.Label();
            this.circularpicturebox2 = new circularpicturebox();
            this.Timer_Set_Value = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.circularpicturebox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Movie
            // 
            this.lbl_Movie.AutoSize = true;
            this.lbl_Movie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Movie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbl_Movie.Location = new System.Drawing.Point(114, 68);
            this.lbl_Movie.Name = "lbl_Movie";
            this.lbl_Movie.Size = new System.Drawing.Size(53, 17);
            this.lbl_Movie.TabIndex = 11;
            this.lbl_Movie.Text = "No Fog";
            this.lbl_Movie.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sw_NoFog
            // 
            this.sw_NoFog.BorderColor = System.Drawing.Color.LightGray;
            this.sw_NoFog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_NoFog.IsOn = false;
            this.sw_NoFog.Location = new System.Drawing.Point(185, 66);
            this.sw_NoFog.Name = "sw_NoFog";
            this.sw_NoFog.Size = new System.Drawing.Size(34, 19);
            this.sw_NoFog.TabIndex = 10;
            this.sw_NoFog.Text = "switchApple2";
            this.sw_NoFog.TextEnabled = true;
            this.sw_NoFog.Click += new System.EventHandler(this.Sw_NoFog_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(114, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "No Glow";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sw_NoGlow
            // 
            this.sw_NoGlow.BorderColor = System.Drawing.Color.LightGray;
            this.sw_NoGlow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_NoGlow.IsOn = false;
            this.sw_NoGlow.Location = new System.Drawing.Point(185, 118);
            this.sw_NoGlow.Name = "sw_NoGlow";
            this.sw_NoGlow.Size = new System.Drawing.Size(34, 19);
            this.sw_NoGlow.TabIndex = 12;
            this.sw_NoGlow.Text = "switchApple2";
            this.sw_NoGlow.TextEnabled = true;
            this.sw_NoGlow.Click += new System.EventHandler(this.Sw_NoGlow_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label2.Location = new System.Drawing.Point(114, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "No Bullet";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sw_NoBullet
            // 
            this.sw_NoBullet.BorderColor = System.Drawing.Color.LightGray;
            this.sw_NoBullet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_NoBullet.IsOn = false;
            this.sw_NoBullet.Location = new System.Drawing.Point(185, 166);
            this.sw_NoBullet.Name = "sw_NoBullet";
            this.sw_NoBullet.Size = new System.Drawing.Size(34, 19);
            this.sw_NoBullet.TabIndex = 14;
            this.sw_NoBullet.Text = "switchApple2";
            this.sw_NoBullet.TextEnabled = true;
            this.sw_NoBullet.Click += new System.EventHandler(this.Sw_NoBullet_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label3.Location = new System.Drawing.Point(114, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "No Skins";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // sw_NoSkins
            // 
            this.sw_NoSkins.BorderColor = System.Drawing.Color.LightGray;
            this.sw_NoSkins.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_NoSkins.IsOn = false;
            this.sw_NoSkins.Location = new System.Drawing.Point(185, 216);
            this.sw_NoSkins.Name = "sw_NoSkins";
            this.sw_NoSkins.Size = new System.Drawing.Size(34, 19);
            this.sw_NoSkins.TabIndex = 16;
            this.sw_NoSkins.Text = "switchApple2";
            this.sw_NoSkins.TextEnabled = true;
            this.sw_NoSkins.Click += new System.EventHandler(this.Sw_NoSkins_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.label12.Location = new System.Drawing.Point(41, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "DISABLE";
            // 
            // circularpicturebox2
            // 
            this.circularpicturebox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.circularpicturebox2.Image = global::TCUN.Properties.Resources.disable32;
            this.circularpicturebox2.Location = new System.Drawing.Point(3, 3);
            this.circularpicturebox2.Name = "circularpicturebox2";
            this.circularpicturebox2.Size = new System.Drawing.Size(32, 32);
            this.circularpicturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularpicturebox2.TabIndex = 27;
            this.circularpicturebox2.TabStop = false;
            // 
            // Timer_Set_Value
            // 
            this.Timer_Set_Value.Enabled = true;
            this.Timer_Set_Value.Interval = 1000;
            this.Timer_Set_Value.Tick += new System.EventHandler(this.Timer_Set_Value_Tick);
            // 
            // FPS_Disable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.circularpicturebox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sw_NoSkins);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sw_NoBullet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sw_NoGlow);
            this.Controls.Add(this.lbl_Movie);
            this.Controls.Add(this.sw_NoFog);
            this.Name = "FPS_Disable";
            this.Size = new System.Drawing.Size(340, 310);
            ((System.ComponentModel.ISupportInitialize)(this.circularpicturebox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Movie;
        private SwitchApple sw_NoFog;
        private System.Windows.Forms.Label label1;
        private SwitchApple sw_NoGlow;
        private System.Windows.Forms.Label label2;
        private SwitchApple sw_NoBullet;
        private System.Windows.Forms.Label label3;
        private SwitchApple sw_NoSkins;
        private System.Windows.Forms.Label label12;
        private circularpicturebox circularpicturebox2;
        private System.Windows.Forms.Timer Timer_Set_Value;
    }
}
