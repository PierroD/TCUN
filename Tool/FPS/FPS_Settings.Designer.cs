namespace TCUN
{
    partial class FPS_Settings
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
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_config = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtb_config = new System.Windows.Forms.TextBox();
            this.btn_save_config = new RoundedButton();
            this.btn_load_config = new RoundedButton();
            this.label12 = new System.Windows.Forms.Label();
            this.circularpicturebox2 = new circularpicturebox();
            ((System.ComponentModel.ISupportInitialize)(this.circularpicturebox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(59, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "LOAD Configs";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmb_config
            // 
            this.cmb_config.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_config.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_config.FormattingEnabled = true;
            this.cmb_config.Location = new System.Drawing.Point(62, 103);
            this.cmb_config.Name = "cmb_config";
            this.cmb_config.Size = new System.Drawing.Size(157, 23);
            this.cmb_config.TabIndex = 12;
            this.cmb_config.Click += new System.EventHandler(this.Cmb_config_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Location = new System.Drawing.Point(59, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "SAVE Configs";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtb_config
            // 
            this.txtb_config.Location = new System.Drawing.Point(62, 195);
            this.txtb_config.Name = "txtb_config";
            this.txtb_config.Size = new System.Drawing.Size(157, 20);
            this.txtb_config.TabIndex = 15;
            this.txtb_config.Text = "Config Name...";
            this.txtb_config.Click += new System.EventHandler(this.Txtb_config_Click);
            // 
            // btn_save_config
            // 
            this.btn_save_config.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btn_save_config.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btn_save_config.FlatAppearance.BorderSize = 0;
            this.btn_save_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save_config.Location = new System.Drawing.Point(236, 188);
            this.btn_save_config.Name = "btn_save_config";
            this.btn_save_config.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_save_config.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btn_save_config.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_save_config.Size = new System.Drawing.Size(72, 33);
            this.btn_save_config.TabIndex = 16;
            this.btn_save_config.Text = "Save";
            this.btn_save_config.TextColor = System.Drawing.Color.White;
            this.btn_save_config.UseVisualStyleBackColor = true;
            this.btn_save_config.Click += new System.EventHandler(this.Btn_save_config_Click);
            // 
            // btn_load_config
            // 
            this.btn_load_config.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btn_load_config.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btn_load_config.FlatAppearance.BorderSize = 0;
            this.btn_load_config.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_load_config.Location = new System.Drawing.Point(236, 97);
            this.btn_load_config.Name = "btn_load_config";
            this.btn_load_config.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_load_config.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btn_load_config.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_load_config.Size = new System.Drawing.Size(72, 33);
            this.btn_load_config.TabIndex = 17;
            this.btn_load_config.Text = "Load";
            this.btn_load_config.TextColor = System.Drawing.Color.White;
            this.btn_load_config.UseVisualStyleBackColor = true;
            this.btn_load_config.Click += new System.EventHandler(this.Btn_load_config_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.label12.Location = new System.Drawing.Point(41, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 21);
            this.label12.TabIndex = 30;
            this.label12.Text = "SETTINGS";
            // 
            // circularpicturebox2
            // 
            this.circularpicturebox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.circularpicturebox2.Image = global::TCUN.Properties.Resources.save;
            this.circularpicturebox2.Location = new System.Drawing.Point(3, 4);
            this.circularpicturebox2.Name = "circularpicturebox2";
            this.circularpicturebox2.Size = new System.Drawing.Size(32, 32);
            this.circularpicturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularpicturebox2.TabIndex = 29;
            this.circularpicturebox2.TabStop = false;
            // 
            // FPS_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.circularpicturebox2);
            this.Controls.Add(this.btn_load_config);
            this.Controls.Add(this.btn_save_config);
            this.Controls.Add(this.txtb_config);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_config);
            this.Name = "FPS_Settings";
            this.Size = new System.Drawing.Size(340, 310);
            ((System.ComponentModel.ISupportInitialize)(this.circularpicturebox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_config;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtb_config;
        private RoundedButton btn_save_config;
        private RoundedButton btn_load_config;
        private System.Windows.Forms.Label label12;
        private circularpicturebox circularpicturebox2;
    }
}
