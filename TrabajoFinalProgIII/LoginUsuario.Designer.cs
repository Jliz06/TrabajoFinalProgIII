namespace TrabajoFinalProgIII
{
    partial class LoginUsuario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUsuario));
            this.Login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxUsuariolg = new System.Windows.Forms.TextBox();
            this.txtBoxContrasenalg = new System.Windows.Forms.TextBox();
            this.btnAccederlg = new System.Windows.Forms.Button();
            this.btnLimpiarlg = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Login.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(192, 41);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(73, 30);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 19);
            this.label2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(221, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 19);
            this.label3.TabIndex = 2;
            // 
            // txtBoxUsuariolg
            // 
            this.txtBoxUsuariolg.Location = new System.Drawing.Point(226, 129);
            this.txtBoxUsuariolg.Multiline = true;
            this.txtBoxUsuariolg.Name = "txtBoxUsuariolg";
            this.txtBoxUsuariolg.Size = new System.Drawing.Size(249, 28);
            this.txtBoxUsuariolg.TabIndex = 4;
            // 
            // txtBoxContrasenalg
            // 
            this.txtBoxContrasenalg.Location = new System.Drawing.Point(226, 212);
            this.txtBoxContrasenalg.Multiline = true;
            this.txtBoxContrasenalg.Name = "txtBoxContrasenalg";
            this.txtBoxContrasenalg.PasswordChar = '*';
            this.txtBoxContrasenalg.Size = new System.Drawing.Size(249, 28);
            this.txtBoxContrasenalg.TabIndex = 5;
            // 
            // btnAccederlg
            // 
            this.btnAccederlg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAccederlg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccederlg.Image = ((System.Drawing.Image)(resources.GetObject("btnAccederlg.Image")));
            this.btnAccederlg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAccederlg.Location = new System.Drawing.Point(250, 285);
            this.btnAccederlg.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccederlg.Name = "btnAccederlg";
            this.btnAccederlg.Size = new System.Drawing.Size(95, 36);
            this.btnAccederlg.TabIndex = 7;
            this.btnAccederlg.Text = "Acceder";
            this.btnAccederlg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccederlg.UseVisualStyleBackColor = true;
            this.btnAccederlg.Click += new System.EventHandler(this.btnAcceder_Click);
            // 
            // btnLimpiarlg
            // 
            this.btnLimpiarlg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnLimpiarlg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarlg.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiarlg.Image")));
            this.btnLimpiarlg.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiarlg.Location = new System.Drawing.Point(349, 285);
            this.btnLimpiarlg.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarlg.Name = "btnLimpiarlg";
            this.btnLimpiarlg.Size = new System.Drawing.Size(90, 36);
            this.btnLimpiarlg.TabIndex = 8;
            this.btnLimpiarlg.Text = "Limpiar";
            this.btnLimpiarlg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiarlg.UseVisualStyleBackColor = true;
            this.btnLimpiarlg.Click += new System.EventHandler(this.btnLimpiarlg_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 37);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(425, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 33);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Ingrese Su Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(270, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(179, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ingrese Su Contrasena";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(408, 242);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "Mostrar";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(482, 361);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnLimpiarlg);
            this.Controls.Add(this.btnAccederlg);
            this.Controls.Add(this.txtBoxContrasenalg);
            this.Controls.Add(this.txtBoxUsuariolg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginUsuario";
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxUsuariolg;
        private System.Windows.Forms.TextBox txtBoxContrasenalg;
        private System.Windows.Forms.Button btnAccederlg;
        private System.Windows.Forms.Button btnLimpiarlg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

