
namespace Sistema_de_Facturación
{
    partial class Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.Sector = new System.Windows.Forms.TextBox();
            this.Contacto = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.ac = new System.Windows.Forms.DataGridView();
            this.codcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomcliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apecliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seccliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concliDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura = new Sistema_de_Facturación.Factura();
            this.label9 = new System.Windows.Forms.Label();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.tota = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.salir = new System.Windows.Forms.PictureBox();
            this.imprimir = new System.Windows.Forms.PictureBox();
            this.guardar = new System.Windows.Forms.PictureBox();
            this.eliminar = new System.Windows.Forms.PictureBox();
            this.modificar = new System.Windows.Forms.PictureBox();
            this.nuevo = new System.Windows.Forms.PictureBox();
            this.Provincia = new System.Windows.Forms.ComboBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.facturacionDataSet = new Sistema_de_Facturación.FacturacionDataSet();
            this.facturacionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new Sistema_de_Facturación.FacturaTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            this.label1.Click += new System.EventHandler(this.codigo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(92, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Sector";
            this.label5.Click += new System.EventHandler(this.sector_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(66, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Provincia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(86, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(89, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 6;
            this.label8.Text = "Correo";
            // 
            // Codigo
            // 
            this.Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(162, 19);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(151, 30);
            this.Codigo.TabIndex = 0;
            this.Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Codigo_KeyPress);
            // 
            // Nombres
            // 
            this.Nombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Nombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombres.Location = new System.Drawing.Point(162, 58);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(281, 30);
            this.Nombres.TabIndex = 1;
            this.Nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombres_KeyPress);
            // 
            // Direccion
            // 
            this.Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Direccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Direccion.Location = new System.Drawing.Point(162, 136);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(281, 30);
            this.Direccion.TabIndex = 3;
            this.Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Direccion_KeyPress);
            // 
            // Sector
            // 
            this.Sector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Sector.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sector.Location = new System.Drawing.Point(162, 177);
            this.Sector.Name = "Sector";
            this.Sector.Size = new System.Drawing.Size(281, 30);
            this.Sector.TabIndex = 4;
            this.Sector.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Sector_KeyPress);
            // 
            // Contacto
            // 
            this.Contacto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Contacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contacto.Location = new System.Drawing.Point(162, 262);
            this.Contacto.Name = "Contacto";
            this.Contacto.Size = new System.Drawing.Size(151, 30);
            this.Contacto.TabIndex = 6;
            this.Contacto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Contacto_KeyPress);
            // 
            // Correo
            // 
            this.Correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(162, 302);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(281, 30);
            this.Correo.TabIndex = 7;
            this.Correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Correo_KeyPress);
            // 
            // ac
            // 
            this.ac.AutoGenerateColumns = false;
            this.ac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.ac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcliDataGridViewTextBoxColumn,
            this.nomcliDataGridViewTextBoxColumn,
            this.apecliDataGridViewTextBoxColumn,
            this.seccliDataGridViewTextBoxColumn,
            this.procliDataGridViewTextBoxColumn,
            this.concliDataGridViewTextBoxColumn});
            this.ac.DataSource = this.clienteBindingSource;
            this.ac.Location = new System.Drawing.Point(462, 58);
            this.ac.Name = "ac";
            this.ac.RowHeadersVisible = false;
            this.ac.Size = new System.Drawing.Size(425, 277);
            this.ac.TabIndex = 14;
            this.ac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ac_CellContentClick);
            // 
            // codcliDataGridViewTextBoxColumn
            // 
            this.codcliDataGridViewTextBoxColumn.DataPropertyName = "cod_cli";
            this.codcliDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codcliDataGridViewTextBoxColumn.Name = "codcliDataGridViewTextBoxColumn";
            this.codcliDataGridViewTextBoxColumn.Width = 65;
            // 
            // nomcliDataGridViewTextBoxColumn
            // 
            this.nomcliDataGridViewTextBoxColumn.DataPropertyName = "nom_cli";
            this.nomcliDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nomcliDataGridViewTextBoxColumn.Name = "nomcliDataGridViewTextBoxColumn";
            this.nomcliDataGridViewTextBoxColumn.Width = 74;
            // 
            // apecliDataGridViewTextBoxColumn
            // 
            this.apecliDataGridViewTextBoxColumn.DataPropertyName = "ape_cli";
            this.apecliDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apecliDataGridViewTextBoxColumn.Name = "apecliDataGridViewTextBoxColumn";
            this.apecliDataGridViewTextBoxColumn.Width = 74;
            // 
            // seccliDataGridViewTextBoxColumn
            // 
            this.seccliDataGridViewTextBoxColumn.DataPropertyName = "sec_cli";
            this.seccliDataGridViewTextBoxColumn.HeaderText = "Sector";
            this.seccliDataGridViewTextBoxColumn.Name = "seccliDataGridViewTextBoxColumn";
            this.seccliDataGridViewTextBoxColumn.Width = 63;
            // 
            // procliDataGridViewTextBoxColumn
            // 
            this.procliDataGridViewTextBoxColumn.DataPropertyName = "pro_cli";
            this.procliDataGridViewTextBoxColumn.HeaderText = "Provincia";
            this.procliDataGridViewTextBoxColumn.Name = "procliDataGridViewTextBoxColumn";
            this.procliDataGridViewTextBoxColumn.Width = 76;
            // 
            // concliDataGridViewTextBoxColumn
            // 
            this.concliDataGridViewTextBoxColumn.DataPropertyName = "con_cli";
            this.concliDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.concliDataGridViewTextBoxColumn.Name = "concliDataGridViewTextBoxColumn";
            this.concliDataGridViewTextBoxColumn.Width = 75;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.factura;
            // 
            // factura
            // 
            this.factura.DataSetName = "Factura";
            this.factura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(492, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 25);
            this.label9.TabIndex = 15;
            this.label9.Text = "Buscar";
            // 
            // busqueda
            // 
            this.busqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busqueda.Location = new System.Drawing.Point(577, 16);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(310, 30);
            this.busqueda.TabIndex = 8;
            this.busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Busqueda_KeyPress);
            // 
            // tota
            // 
            this.tota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tota.Location = new System.Drawing.Point(470, 338);
            this.tota.Name = "tota";
            this.tota.Size = new System.Drawing.Size(129, 30);
            this.tota.TabIndex = 9;
            this.tota.TextChanged += new System.EventHandler(this.Total_TextChanged);
            this.tota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Total_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(403, 338);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 25);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total";
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(576, 393);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(78, 65);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 28;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // imprimir
            // 
            this.imprimir.Image = ((System.Drawing.Image)(resources.GetObject("imprimir.Image")));
            this.imprimir.Location = new System.Drawing.Point(483, 388);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(87, 81);
            this.imprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imprimir.TabIndex = 27;
            this.imprimir.TabStop = false;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // guardar
            // 
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.Location = new System.Drawing.Point(240, 393);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(78, 65);
            this.guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guardar.TabIndex = 26;
            this.guardar.TabStop = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Location = new System.Drawing.Point(408, 393);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(69, 65);
            this.eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eliminar.TabIndex = 25;
            this.eliminar.TabStop = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // modificar
            // 
            this.modificar.Image = ((System.Drawing.Image)(resources.GetObject("modificar.Image")));
            this.modificar.Location = new System.Drawing.Point(324, 393);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(78, 65);
            this.modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modificar.TabIndex = 24;
            this.modificar.TabStop = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // nuevo
            // 
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.Location = new System.Drawing.Point(159, 388);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(86, 70);
            this.nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nuevo.TabIndex = 23;
            this.nuevo.TabStop = false;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // Provincia
            // 
            this.Provincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Provincia.FormattingEnabled = true;
            this.Provincia.Items.AddRange(new object[] {
            "PUERTO PLATA",
            "SANTIAGO",
            "BONAO",
            "LA VEGA",
            "MAO"});
            this.Provincia.Location = new System.Drawing.Point(162, 218);
            this.Provincia.Name = "Provincia";
            this.Provincia.Size = new System.Drawing.Size(281, 33);
            this.Provincia.TabIndex = 5;
            this.Provincia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Provincia_KeyPress);
            // 
            // Apellidos
            // 
            this.Apellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Apellidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellidos.Location = new System.Drawing.Point(162, 100);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(281, 30);
            this.Apellidos.TabIndex = 2;
            this.Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Apellidos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Apellidos";
            // 
            // facturacionDataSet
            // 
            this.facturacionDataSet.DataSetName = "FacturacionDataSet";
            this.facturacionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturacionDataSetBindingSource
            // 
            this.facturacionDataSetBindingSource.DataSource = this.facturacionDataSet;
            this.facturacionDataSetBindingSource.Position = 0;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(912, 460);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Provincia);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tota);
            this.Controls.Add(this.busqueda);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ac);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Contacto);
            this.Controls.Add(this.Sector);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Clientes";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturacionDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.TextBox Sector;
        private System.Windows.Forms.TextBox Contacto;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.DataGridView ac;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox busqueda;
        private System.Windows.Forms.TextBox tota;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.PictureBox imprimir;
        private System.Windows.Forms.PictureBox guardar;
        private System.Windows.Forms.PictureBox eliminar;
        private System.Windows.Forms.PictureBox modificar;
        private System.Windows.Forms.PictureBox nuevo;
        private System.Windows.Forms.ComboBox Provincia;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource facturacionDataSetBindingSource;
        private FacturacionDataSet facturacionDataSet;
        private Factura factura;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private FacturaTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomcliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apecliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seccliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procliDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concliDataGridViewTextBoxColumn;
    }
}