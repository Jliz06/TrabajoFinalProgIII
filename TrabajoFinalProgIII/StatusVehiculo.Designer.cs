namespace TrabajoFinalProgIII
{
    partial class StatusVehiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatusVehiculo));
            this.BTNVERSTATUS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.MARCAVEHICULO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPOV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PLACA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DESCRIPCION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btncerrarMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BTNVERSTATUS
            // 
            this.BTNVERSTATUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVERSTATUS.Location = new System.Drawing.Point(236, 263);
            this.BTNVERSTATUS.Name = "BTNVERSTATUS";
            this.BTNVERSTATUS.Size = new System.Drawing.Size(116, 34);
            this.BTNVERSTATUS.TabIndex = 0;
            this.BTNVERSTATUS.Text = "Verificar status";
            this.BTNVERSTATUS.UseVisualStyleBackColor = true;
            this.BTNVERSTATUS.Click += new System.EventHandler(this.BTNVERSTATUS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "CONULTAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MARCAVEHICULO,
            this.TIPOV,
            this.PLACA,
            this.ESTADO,
            this.DESCRIPCION});
            this.dataGridView1.Location = new System.Drawing.Point(26, 100);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(508, 160);
            this.dataGridView1.TabIndex = 4;
            // 
            // MARCAVEHICULO
            // 
            this.MARCAVEHICULO.HeaderText = "MARCA";
            this.MARCAVEHICULO.MinimumWidth = 6;
            this.MARCAVEHICULO.Name = "MARCAVEHICULO";
            this.MARCAVEHICULO.ReadOnly = true;
            this.MARCAVEHICULO.Width = 125;
            // 
            // TIPOV
            // 
            this.TIPOV.HeaderText = "TIPO";
            this.TIPOV.MinimumWidth = 6;
            this.TIPOV.Name = "TIPOV";
            this.TIPOV.ReadOnly = true;
            this.TIPOV.Width = 125;
            // 
            // PLACA
            // 
            this.PLACA.HeaderText = "PLACA";
            this.PLACA.MinimumWidth = 6;
            this.PLACA.Name = "PLACA";
            this.PLACA.ReadOnly = true;
            this.PLACA.Width = 125;
            // 
            // ESTADO
            // 
            this.ESTADO.HeaderText = "ESTADO";
            this.ESTADO.MinimumWidth = 6;
            this.ESTADO.Name = "ESTADO";
            this.ESTADO.ReadOnly = true;
            this.ESTADO.Width = 125;
            // 
            // DESCRIPCION
            // 
            this.DESCRIPCION.HeaderText = "DESCRIPCION";
            this.DESCRIPCION.MinimumWidth = 6;
            this.DESCRIPCION.Name = "DESCRIPCION";
            this.DESCRIPCION.ReadOnly = true;
            this.DESCRIPCION.Width = 125;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.IndianRed;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btncerrarMenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 32);
            this.panel1.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(451, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 30);
            this.button2.TabIndex = 12;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btncerrarMenu
            // 
            this.btncerrarMenu.BackColor = System.Drawing.Color.IndianRed;
            this.btncerrarMenu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btncerrarMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btncerrarMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btncerrarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrarMenu.Image = ((System.Drawing.Image)(resources.GetObject("btncerrarMenu.Image")));
            this.btncerrarMenu.Location = new System.Drawing.Point(510, 1);
            this.btncerrarMenu.Name = "btncerrarMenu";
            this.btncerrarMenu.Size = new System.Drawing.Size(53, 31);
            this.btncerrarMenu.TabIndex = 0;
            this.btncerrarMenu.UseVisualStyleBackColor = false;
            this.btncerrarMenu.Click += new System.EventHandler(this.btncerrarMenu_Click);
            // 
            // StatusVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(570, 302);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNVERSTATUS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusVehiculo";
            this.Text = "StatusVehiculo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNVERSTATUS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MARCAVEHICULO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPOV;
        private System.Windows.Forms.DataGridViewTextBoxColumn PLACA;
        private System.Windows.Forms.DataGridViewTextBoxColumn ESTADO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DESCRIPCION;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncerrarMenu;
        private System.Windows.Forms.Button button2;
    }
}