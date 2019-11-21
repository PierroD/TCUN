namespace TCUN
{
    partial class FPS_Visuals
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
            this.cmb_fullbright = new System.Windows.Forms.ComboBox();
            this.cmb_specular = new System.Windows.Forms.ComboBox();
            this.lbl_Movie = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.circularpicturebox2 = new circularpicturebox();
            this.sw_Movie = new SwitchApple();
            this.Timer_Set_Value = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.circularpicturebox2)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_fullbright
            // 
            this.cmb_fullbright.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_fullbright.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_fullbright.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_fullbright.FormattingEnabled = true;
            this.cmb_fullbright.Location = new System.Drawing.Point(84, 74);
            this.cmb_fullbright.Name = "cmb_fullbright";
            this.cmb_fullbright.Size = new System.Drawing.Size(157, 23);
            this.cmb_fullbright.TabIndex = 0;
            this.cmb_fullbright.TextChanged += new System.EventHandler(this.Cmb_fullbright_TextChanged);
            // 
            // cmb_specular
            // 
            this.cmb_specular.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_specular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_specular.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_specular.FormattingEnabled = true;
            this.cmb_specular.Location = new System.Drawing.Point(85, 146);
            this.cmb_specular.Name = "cmb_specular";
            this.cmb_specular.Size = new System.Drawing.Size(157, 23);
            this.cmb_specular.TabIndex = 1;
            this.cmb_specular.TextChanged += new System.EventHandler(this.Cmb_specular_TextChanged);
            // 
            // lbl_Movie
            // 
            this.lbl_Movie.AutoSize = true;
            this.lbl_Movie.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Movie.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lbl_Movie.Location = new System.Drawing.Point(122, 216);
            this.lbl_Movie.Name = "lbl_Movie";
            this.lbl_Movie.Size = new System.Drawing.Size(45, 17);
            this.lbl_Movie.TabIndex = 9;
            this.lbl_Movie.Text = "Movie";
            this.lbl_Movie.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.label1.Location = new System.Drawing.Point(135, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Specular";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.label2.Location = new System.Drawing.Point(135, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Fullbright";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.label12.Location = new System.Drawing.Point(41, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 21);
            this.label12.TabIndex = 32;
            this.label12.Text = "VISUALS";
            // 
            // circularpicturebox2
            // 
            this.circularpicturebox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.circularpicturebox2.Image = global::TCUN.Properties.Resources.visual32;
            this.circularpicturebox2.Location = new System.Drawing.Point(3, 3);
            this.circularpicturebox2.Name = "circularpicturebox2";
            this.circularpicturebox2.Size = new System.Drawing.Size(32, 32);
            this.circularpicturebox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularpicturebox2.TabIndex = 31;
            this.circularpicturebox2.TabStop = false;
            // 
            // sw_Movie
            // 
            this.sw_Movie.BorderColor = System.Drawing.Color.LightGray;
            this.sw_Movie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sw_Movie.IsOn = false;
            this.sw_Movie.Location = new System.Drawing.Point(173, 216);
            this.sw_Movie.Name = "sw_Movie";
            this.sw_Movie.Size = new System.Drawing.Size(34, 19);
            this.sw_Movie.TabIndex = 8;
            this.sw_Movie.Text = "switchApple2";
            this.sw_Movie.TextEnabled = true;
            this.sw_Movie.Click += new System.EventHandler(this.Sw_Movie_Click);
            // 
            // Timer_Set_Value
            // 
            this.Timer_Set_Value.Enabled = true;
            this.Timer_Set_Value.Interval = 1000;
            this.Timer_Set_Value.Tick += new System.EventHandler(this.Timer_Set_Value_Tick);
            // 
            // FPS_Visuals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.circularpicturebox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Movie);
            this.Controls.Add(this.sw_Movie);
            this.Controls.Add(this.cmb_specular);
            this.Controls.Add(this.cmb_fullbright);
            this.Name = "FPS_Visuals";
            this.Size = new System.Drawing.Size(340, 310);
            ((System.ComponentModel.ISupportInitialize)(this.circularpicturebox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_fullbright;
        private System.Windows.Forms.ComboBox cmb_specular;
        private SwitchApple sw_Movie;
        private System.Windows.Forms.Label lbl_Movie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private circularpicturebox circularpicturebox2;
        private System.Windows.Forms.Timer Timer_Set_Value;
    }
}
