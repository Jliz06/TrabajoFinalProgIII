namespace TrabajoFinalProgIII
{
    partial class RegistroVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroVehiculo));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtObservacionesveh = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BTNreportarveh = new System.Windows.Forms.Button();
            this.BTNEDITARveh = new System.Windows.Forms.Button();
            this.txtidcliveh = new System.Windows.Forms.TextBox();
            this.BTNBORRAveh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1222, 75);
            this.panel1.TabIndex = 28;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.IndianRed;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1065, 5);
            this.button5.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(64, 63);
            this.button5.TabIndex = 28;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1144, 5);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(64, 62);
            this.btnCerrar.TabIndex = 1;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(597, 154);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(374, 44);
            this.label5.TabIndex = 29;
            this.label5.Text = "REPORTAR VEHICULO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 306);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 27);
            this.label7.TabIndex = 36;
            this.label7.Text = "ID CLIENTE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 415);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 27);
            this.label1.TabIndex = 44;
            this.label1.Text = "Observaciones";
            // 
            // txtObservacionesveh
            // 
            this.txtObservacionesveh.Location = new System.Drawing.Point(18, 469);
            this.txtObservacionesveh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservacionesveh.Multiline = true;
            this.txtObservacionesveh.Name = "txtObservacionesveh";
            this.txtObservacionesveh.Size = new System.Drawing.Size(324, 206);
            this.txtObservacionesveh.TabIndex = 45;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 306);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(820, 398);
            this.dataGridView1.TabIndex = 46;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // BTNreportarveh
            // 
            this.BTNreportarveh.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNreportarveh.Image = ((System.Drawing.Image)(resources.GetObject("BTNreportarveh.Image")));
            this.BTNreportarveh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNreportarveh.Location = new System.Drawing.Point(388, 715);
            this.BTNreportarveh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTNreportarveh.Name = "BTNreportarveh";
            this.BTNreportarveh.Size = new System.Drawing.Size(176, 60);
            this.BTNreportarveh.TabIndex = 48;
            this.BTNreportarveh.Text = "REPORTAR";
            this.BTNreportarveh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNreportarveh.UseVisualStyleBackColor = true;
            this.BTNreportarveh.Click += new System.EventHandler(this.BTNAGREGARCLI_Click);
            // 
            // BTNEDITARveh
            // 
            this.BTNEDITARveh.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNEDITARveh.Image = ((System.Drawing.Image)(resources.GetObject("BTNEDITARveh.Image")));
            this.BTNEDITARveh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNEDITARveh.Location = new System.Drawing.Point(848, 715);
            this.BTNEDITARveh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTNEDITARveh.Name = "BTNEDITARveh";
            this.BTNEDITARveh.Size = new System.Drawing.Size(153, 60);
            this.BTNEDITARveh.TabIndex = 50;
            this.BTNEDITARveh.Text = "Editar";
            this.BTNEDITARveh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNEDITARveh.UseVisualStyleBackColor = true;
            // 
            // txtidcliveh
            // 
            this.txtidcliveh.Location = new System.Drawing.Point(147, 297);
            this.txtidcliveh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtidcliveh.Multiline = true;
            this.txtidcliveh.Name = "txtidcliveh";
            this.txtidcliveh.Size = new System.Drawing.Size(112, 39);
            this.txtidcliveh.TabIndex = 52;
            // 
            // BTNBORRAveh
            // 
            this.BTNBORRAveh.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNBORRAveh.Image = ((System.Drawing.Image)(resources.GetObject("BTNBORRAveh.Image")));
            this.BTNBORRAveh.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNBORRAveh.Location = new System.Drawing.Point(620, 715);
            this.BTNBORRAveh.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.BTNBORRAveh.Name = "BTNBORRAveh";
            this.BTNBORRAveh.Size = new System.Drawing.Size(153, 60);
            this.BTNBORRAveh.TabIndex = 49;
            this.BTNBORRAveh.Text = "Borrar";
            this.BTNBORRAveh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNBORRAveh.UseVisualStyleBackColor = true;
            this.BTNBORRAveh.Click += new System.EventHandler(this.BTNBORRAveh_Click);
            // 
            // RegistroVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1222, 792);
            this.Controls.Add(this.txtidcliveh);
            this.Controls.Add(this.BTNEDITARveh);
            this.Controls.Add(this.BTNBORRAveh);
            this.Controls.Add(this.BTNreportarveh);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtObservacionesveh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RegistroVehiculo";
            this.Text = "RegistroVehiculo";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtObservacionesveh;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BTNreportarveh;
        private System.Windows.Forms.Button BTNEDITARveh;
        private System.Windows.Forms.TextBox txtidcliveh;
        private System.Windows.Forms.Button BTNBORRAveh;
    }
}