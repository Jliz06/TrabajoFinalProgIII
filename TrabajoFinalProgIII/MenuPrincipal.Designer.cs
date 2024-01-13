namespace TrabajoFinalProgIII
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrarMenu = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.lblhora = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.Menuviwe = new System.Windows.Forms.Panel();
            this.btnregistroveh = new System.Windows.Forms.Button();
            this.btnregistrarnu = new System.Windows.Forms.Button();
            this.btnreportes = new System.Windows.Forms.Button();
            this.btnclientes = new System.Windows.Forms.Button();
            this.btnconsulta = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Menuviwe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btncerrarMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 24);
            this.panel1.TabIndex = 10;
            // 
            // btncerrarMenu
            // 
            this.btncerrarMenu.BackColor = System.Drawing.Color.IndianRed;
            this.btncerrarMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncerrarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btncerrarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btncerrarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarMenu.Image = ((System.Drawing.Image)(resources.GetObject("btncerrarMenu.Image")));
            this.btncerrarMenu.Location = new System.Drawing.Point(704, 2);
            this.btncerrarMenu.Name = "btncerrarMenu";
            this.btncerrarMenu.Size = new System.Drawing.Size(53, 21);
            this.btncerrarMenu.TabIndex = 0;
            this.btncerrarMenu.UseVisualStyleBackColor = false;
            this.btncerrarMenu.Click += new System.EventHandler(this.btncerrarMenu_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.IndianRed;
            this.panel7.Location = new System.Drawing.Point(6, 226);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(5, 32);
            this.panel7.TabIndex = 39;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.IndianRed;
            this.panel5.Location = new System.Drawing.Point(6, 188);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 37;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.IndianRed;
            this.panel3.Location = new System.Drawing.Point(6, 150);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 35;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.IndianRed;
            this.panel8.Location = new System.Drawing.Point(6, 111);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(5, 32);
            this.panel8.TabIndex = 33;
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.Location = new System.Drawing.Point(138, 24);
            this.lblhora.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(105, 44);
            this.lblhora.TabIndex = 41;
            this.lblhora.Text = "Hora";
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfecha.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblfecha.Location = new System.Drawing.Point(152, 67);
            this.lblfecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(102, 36);
            this.lblfecha.TabIndex = 42;
            this.lblfecha.Text = "Fecha";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menuviwe
            // 
            this.Menuviwe.BackColor = System.Drawing.Color.DarkGray;
            this.Menuviwe.Controls.Add(this.button1);
            this.Menuviwe.Controls.Add(this.btnregistroveh);
            this.Menuviwe.Controls.Add(this.btnregistrarnu);
            this.Menuviwe.Controls.Add(this.btnreportes);
            this.Menuviwe.Controls.Add(this.btnclientes);
            this.Menuviwe.Controls.Add(this.btnconsulta);
            this.Menuviwe.Controls.Add(this.pictureBox2);
            this.Menuviwe.Controls.Add(this.flowLayoutPanel1);
            this.Menuviwe.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menuviwe.Location = new System.Drawing.Point(0, 24);
            this.Menuviwe.Margin = new System.Windows.Forms.Padding(2);
            this.Menuviwe.Name = "Menuviwe";
            this.Menuviwe.Size = new System.Drawing.Size(136, 433);
            this.Menuviwe.TabIndex = 48;
            // 
            // btnregistroveh
            // 
            this.btnregistroveh.BackColor = System.Drawing.Color.Transparent;
            this.btnregistroveh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnregistroveh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregistroveh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistroveh.Image = ((System.Drawing.Image)(resources.GetObject("btnregistroveh.Image")));
            this.btnregistroveh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregistroveh.Location = new System.Drawing.Point(8, 332);
            this.btnregistroveh.Margin = new System.Windows.Forms.Padding(2);
            this.btnregistroveh.Name = "btnregistroveh";
            this.btnregistroveh.Size = new System.Drawing.Size(124, 44);
            this.btnregistroveh.TabIndex = 49;
            this.btnregistroveh.Text = "REGISTRO DE VEHICULO";
            this.btnregistroveh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistroveh.UseVisualStyleBackColor = false;
            // 
            // btnregistrarnu
            // 
            this.btnregistrarnu.BackColor = System.Drawing.Color.Transparent;
            this.btnregistrarnu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnregistrarnu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnregistrarnu.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnregistrarnu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnregistrarnu.Image = ((System.Drawing.Image)(resources.GetObject("btnregistrarnu.Image")));
            this.btnregistrarnu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnregistrarnu.Location = new System.Drawing.Point(8, 221);
            this.btnregistrarnu.Margin = new System.Windows.Forms.Padding(2);
            this.btnregistrarnu.Name = "btnregistrarnu";
            this.btnregistrarnu.Size = new System.Drawing.Size(124, 37);
            this.btnregistrarnu.TabIndex = 12;
            this.btnregistrarnu.Text = "Registrar Usuario";
            this.btnregistrarnu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnregistrarnu.UseVisualStyleBackColor = false;
            this.btnregistrarnu.Click += new System.EventHandler(this.btnregistrarnu_Click);
            // 
            // btnreportes
            // 
            this.btnreportes.BackColor = System.Drawing.Color.Transparent;
            this.btnreportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnreportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreportes.Image = ((System.Drawing.Image)(resources.GetObject("btnreportes.Image")));
            this.btnreportes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnreportes.Location = new System.Drawing.Point(8, 273);
            this.btnreportes.Margin = new System.Windows.Forms.Padding(2);
            this.btnreportes.Name = "btnreportes";
            this.btnreportes.Size = new System.Drawing.Size(124, 37);
            this.btnreportes.TabIndex = 4;
            this.btnreportes.Text = "REPORTES";
            this.btnreportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnreportes.UseVisualStyleBackColor = false;
            this.btnreportes.Click += new System.EventHandler(this.btnreportes_Click);
            // 
            // btnclientes
            // 
            this.btnclientes.BackColor = System.Drawing.Color.Transparent;
            this.btnclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.Image = ((System.Drawing.Image)(resources.GetObject("btnclientes.Image")));
            this.btnclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnclientes.Location = new System.Drawing.Point(8, 161);
            this.btnclientes.Margin = new System.Windows.Forms.Padding(2);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Size = new System.Drawing.Size(124, 36);
            this.btnclientes.TabIndex = 3;
            this.btnclientes.Text = "CLIENTES";
            this.btnclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.UseVisualStyleBackColor = false;
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // btnconsulta
            // 
            this.btnconsulta.BackColor = System.Drawing.Color.Transparent;
            this.btnconsulta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnconsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconsulta.Image = ((System.Drawing.Image)(resources.GetObject("btnconsulta.Image")));
            this.btnconsulta.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnconsulta.Location = new System.Drawing.Point(8, 102);
            this.btnconsulta.Margin = new System.Windows.Forms.Padding(2);
            this.btnconsulta.Name = "btnconsulta";
            this.btnconsulta.Size = new System.Drawing.Size(124, 37);
            this.btnconsulta.TabIndex = 2;
            this.btnconsulta.Text = "CONSULTAS";
            this.btnconsulta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnconsulta.UseVisualStyleBackColor = false;
            this.btnconsulta.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(8, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(118, 75);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(184, 49);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(32, 65);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 223);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 39);
            this.label1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 39);
            this.label2.TabIndex = 46;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(8, 385);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 37);
            this.button1.TabIndex = 49;
            this.button1.Text = "Registrar Usuario";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(761, 457);
            this.Controls.Add(this.Menuviwe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblhora);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.panel1.ResumeLayout(false);
            this.Menuviwe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncerrarMenu;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Timer horafecha;
        private System.Windows.Forms.Panel Menuviwe;
        private System.Windows.Forms.Button btnreportes;
        private System.Windows.Forms.Button btnclientes;
        private System.Windows.Forms.Button btnconsulta;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnregistrarnu;
        private System.Windows.Forms.Button btnregistroveh;
        private System.Windows.Forms.Button button1;
    }
}