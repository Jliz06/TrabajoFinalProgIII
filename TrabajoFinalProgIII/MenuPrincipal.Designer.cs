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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btncerrarmenu = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.btncerrarmenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1042, 37);
            this.panel1.TabIndex = 10;
            // 
            // btncerrarmenu
            // 
            this.btncerrarmenu.BackColor = System.Drawing.Color.IndianRed;
            this.btncerrarmenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncerrarmenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btncerrarmenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btncerrarmenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarmenu.Image = ((System.Drawing.Image)(resources.GetObject("btncerrarmenu.Image")));
            this.btncerrarmenu.Location = new System.Drawing.Point(963, 0);
            this.btncerrarmenu.Margin = new System.Windows.Forms.Padding(4);
            this.btncerrarmenu.Name = "btncerrarmenu";
            this.btncerrarmenu.Size = new System.Drawing.Size(79, 33);
            this.btncerrarmenu.TabIndex = 0;
            this.btncerrarmenu.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TrabajoFinalProgIII.Properties.Resources.Logo_progr;
            this.pictureBox1.Location = new System.Drawing.Point(0, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1042, 650);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncerrarmenu;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}