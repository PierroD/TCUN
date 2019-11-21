namespace TCUN
{
    partial class Login
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
            this.txtbox_Name = new System.Windows.Forms.TextBox();
            this.txtbox_password = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.circularpicturebox1 = new circularpicturebox();
            this.btn_login = new RoundedButton();
            this.pic_show_hide = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularpicturebox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show_hide)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_Name
            // 
            this.txtbox_Name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.txtbox_Name.Location = new System.Drawing.Point(166, 198);
            this.txtbox_Name.Multiline = true;
            this.txtbox_Name.Name = "txtbox_Name";
            this.txtbox_Name.Size = new System.Drawing.Size(348, 37);
            this.txtbox_Name.TabIndex = 0;
            this.txtbox_Name.Text = "Mail / Community Name....";
            this.txtbox_Name.Click += new System.EventHandler(this.Txtbox_Name_Click);
            // 
            // txtbox_password
            // 
            this.txtbox_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(147)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.txtbox_password.Location = new System.Drawing.Point(166, 273);
            this.txtbox_password.Multiline = true;
            this.txtbox_password.Name = "txtbox_password";
            this.txtbox_password.Size = new System.Drawing.Size(348, 37);
            this.txtbox_password.TabIndex = 1;
            this.txtbox_password.Text = "Password...";
            this.txtbox_password.UseSystemPasswordChar = true;
            this.txtbox_password.Click += new System.EventHandler(this.Txtbox_password_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TCUN.Properties.Resources.mail;
            this.pictureBox1.Location = new System.Drawing.Point(123, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TCUN.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(123, 273);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(294, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "LOGIN";
            // 
            // circularpicturebox1
            // 
            this.circularpicturebox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.circularpicturebox1.Image = global::TCUN.Properties.Resources.user;
            this.circularpicturebox1.Location = new System.Drawing.Point(297, 90);
            this.circularpicturebox1.Name = "circularpicturebox1";
            this.circularpicturebox1.Size = new System.Drawing.Size(86, 86);
            this.circularpicturebox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.circularpicturebox1.TabIndex = 7;
            this.circularpicturebox1.TabStop = false;
            // 
            // btn_login
            // 
            this.btn_login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btn_login.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_login.ForeColor = System.Drawing.Color.White;
            this.btn_login.Location = new System.Drawing.Point(254, 361);
            this.btn_login.Name = "btn_login";
            this.btn_login.OnHoverBorderColor = System.Drawing.Color.White;
            this.btn_login.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(135)))), ((int)(((byte)(240)))));
            this.btn_login.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_login.Size = new System.Drawing.Size(172, 47);
            this.btn_login.TabIndex = 8;
            this.btn_login.Text = "LOGIN";
            this.btn_login.TextColor = System.Drawing.Color.White;
            this.btn_login.UseVisualStyleBackColor = true;
            // 
            // pic_show_hide
            // 
            this.pic_show_hide.Image = global::TCUN.Properties.Resources.show;
            this.pic_show_hide.Location = new System.Drawing.Point(520, 273);
            this.pic_show_hide.Name = "pic_show_hide";
            this.pic_show_hide.Size = new System.Drawing.Size(37, 37);
            this.pic_show_hide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_show_hide.TabIndex = 9;
            this.pic_show_hide.TabStop = false;
            this.pic_show_hide.Click += new System.EventHandler(this.Pic_show_hide_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pic_show_hide);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.circularpicturebox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbox_password);
            this.Controls.Add(this.txtbox_Name);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(700, 540);
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circularpicturebox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_show_hide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_Name;
        private System.Windows.Forms.TextBox txtbox_password;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private circularpicturebox circularpicturebox1;
        private RoundedButton btn_login;
        private System.Windows.Forms.PictureBox pic_show_hide;
    }
}
