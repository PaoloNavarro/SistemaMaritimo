namespace Proyecto_Tecnicas.forms
{
	partial class fPuerto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fPuerto));
            this.pnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ppais = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pprofunidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbGrua = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbAgua = new System.Windows.Forms.ComboBox();
            this.pposcion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tablaPuertos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cpcapacidad = new System.Windows.Forms.NumericUpDown();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapacidaddeBarco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPuertos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpcapacidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pnombre
            // 
            this.pnombre.Location = new System.Drawing.Point(12, 53);
            this.pnombre.Name = "pnombre";
            this.pnombre.Size = new System.Drawing.Size(118, 20);
            this.pnombre.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Nombre de puerto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Pais";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ppais
            // 
            this.ppais.Location = new System.Drawing.Point(12, 118);
            this.ppais.Name = "ppais";
            this.ppais.Size = new System.Drawing.Size(118, 20);
            this.ppais.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Profundidad";
            // 
            // pprofunidad
            // 
            this.pprofunidad.Location = new System.Drawing.Point(194, 52);
            this.pprofunidad.Name = "pprofunidad";
            this.pprofunidad.Size = new System.Drawing.Size(118, 20);
            this.pprofunidad.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(264, 192);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(351, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo de grua";
            // 
            // cbGrua
            // 
            this.cbGrua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGrua.FormattingEnabled = true;
            this.cbGrua.Items.AddRange(new object[] {
            "Compuesta",
            "Simple",
            "Doble"});
            this.cbGrua.Location = new System.Drawing.Point(355, 53);
            this.cbGrua.Margin = new System.Windows.Forms.Padding(2);
            this.cbGrua.Name = "cbGrua";
            this.cbGrua.Size = new System.Drawing.Size(101, 27);
            this.cbGrua.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 21;
            this.label6.Text = "Tipo de agua";
            // 
            // cbAgua
            // 
            this.cbAgua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAgua.FormattingEnabled = true;
            this.cbAgua.Location = new System.Drawing.Point(481, 53);
            this.cbAgua.Margin = new System.Windows.Forms.Padding(2);
            this.cbAgua.Name = "cbAgua";
            this.cbAgua.Size = new System.Drawing.Size(103, 27);
            this.cbAgua.TabIndex = 20;
            this.cbAgua.SelectedIndexChanged += new System.EventHandler(this.select);
            // 
            // pposcion
            // 
            this.pposcion.Location = new System.Drawing.Point(203, 118);
            this.pposcion.Name = "pposcion";
            this.pposcion.Size = new System.Drawing.Size(84, 20);
            this.pposcion.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(199, 85);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "Posicion";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tablaPuertos
            // 
            this.tablaPuertos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPuertos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.CapacidaddeBarco,
            this.Column5,
            this.Column6});
            this.tablaPuertos.Location = new System.Drawing.Point(15, 158);
            this.tablaPuertos.Name = "tablaPuertos";
            this.tablaPuertos.RowHeadersWidth = 51;
            this.tablaPuertos.Size = new System.Drawing.Size(875, 280);
            this.tablaPuertos.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(663, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Añador Puerto";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(341, 85);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(161, 21);
            this.label8.TabIndex = 27;
            this.label8.Text = "Capacidad de barco";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // cpcapacidad
            // 
            this.cpcapacidad.Location = new System.Drawing.Point(345, 118);
            this.cpcapacidad.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cpcapacidad.Name = "cpcapacidad";
            this.cpcapacidad.Size = new System.Drawing.Size(120, 20);
            this.cpcapacidad.TabIndex = 28;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre de puerto";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pais";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Profundidad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tipo de grua";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // CapacidaddeBarco
            // 
            this.CapacidaddeBarco.HeaderText = "Capacidad de barco";
            this.CapacidaddeBarco.Name = "CapacidaddeBarco";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Tipo de agua";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Distancia";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // fPuerto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.cpcapacidad);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tablaPuertos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pposcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbAgua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pprofunidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ppais);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGrua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fPuerto";
            this.Text = "Puertos";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPuertos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpcapacidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox pnombre;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ppais;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pprofunidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGrua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbAgua;
        private System.Windows.Forms.TextBox pposcion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView tablaPuertos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown cpcapacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapacidaddeBarco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}