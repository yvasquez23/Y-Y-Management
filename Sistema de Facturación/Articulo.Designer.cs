
namespace Sistema_de_Facturación
{
    partial class Articulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulo));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Descripcion = new System.Windows.Forms.TextBox();
            this.Costo = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.TextBox();
            this.Existencia = new System.Windows.Forms.TextBox();
            this.CanMinima = new System.Windows.Forms.TextBox();
            this.aa = new System.Windows.Forms.DataGridView();
            this.codartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cosartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exiartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canminDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.articuloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.factura = new Sistema_de_Facturación.Factura();
            this.articuloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.tota = new System.Windows.Forms.TextBox();
            this.nuevo = new System.Windows.Forms.PictureBox();
            this.modificar = new System.Windows.Forms.PictureBox();
            this.eliminar = new System.Windows.Forms.PictureBox();
            this.guardar = new System.Windows.Forms.PictureBox();
            this.imprimir = new System.Windows.Forms.PictureBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.buscar = new System.Windows.Forms.PictureBox();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.articuloTableAdapter = new Sistema_de_Facturación.FacturaTableAdapters.ArticuloTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Costo(*)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Descripción(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio(*)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(64, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cantidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Existencia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Can. Minima";
            // 
            // Codigo
            // 
            this.Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(182, 21);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(172, 30);
            this.Codigo.TabIndex = 0;
            this.Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Codigo_KeyPress);
            // 
            // Descripcion
            // 
            this.Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descripcion.Location = new System.Drawing.Point(182, 58);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(216, 30);
            this.Descripcion.TabIndex = 1;
            this.Descripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Descripcion_KeyPress);
            // 
            // Costo
            // 
            this.Costo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Costo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Costo.Location = new System.Drawing.Point(182, 99);
            this.Costo.Name = "Costo";
            this.Costo.Size = new System.Drawing.Size(135, 30);
            this.Costo.TabIndex = 2;
            this.Costo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Costo_KeyPress);
            // 
            // Precio
            // 
            this.Precio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Precio.Location = new System.Drawing.Point(182, 143);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(135, 30);
            this.Precio.TabIndex = 3;
            this.Precio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Precio_KeyPress);
            // 
            // Cantidad
            // 
            this.Cantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cantidad.Location = new System.Drawing.Point(182, 186);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(135, 30);
            this.Cantidad.TabIndex = 4;
            this.Cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cantidad_KeyPress);
            // 
            // Existencia
            // 
            this.Existencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Existencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Existencia.Location = new System.Drawing.Point(182, 237);
            this.Existencia.Name = "Existencia";
            this.Existencia.Size = new System.Drawing.Size(135, 30);
            this.Existencia.TabIndex = 5;
            this.Existencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Existencia_KeyPress);
            // 
            // CanMinima
            // 
            this.CanMinima.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.CanMinima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CanMinima.Location = new System.Drawing.Point(182, 283);
            this.CanMinima.Name = "CanMinima";
            this.CanMinima.Size = new System.Drawing.Size(135, 30);
            this.CanMinima.TabIndex = 6;
            this.CanMinima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CanMinima_KeyPress);
            // 
            // aa
            // 
            this.aa.AutoGenerateColumns = false;
            this.aa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.aa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codartDataGridViewTextBoxColumn,
            this.desartDataGridViewTextBoxColumn,
            this.cosartDataGridViewTextBoxColumn,
            this.preartDataGridViewTextBoxColumn,
            this.exiartDataGridViewTextBoxColumn,
            this.canminDataGridViewTextBoxColumn});
            this.aa.DataSource = this.articuloBindingSource1;
            this.aa.Location = new System.Drawing.Point(419, 53);
            this.aa.Name = "aa";
            this.aa.RowHeadersVisible = false;
            this.aa.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.aa.Size = new System.Drawing.Size(446, 286);
            this.aa.TabIndex = 14;
            // 
            // codartDataGridViewTextBoxColumn
            // 
            this.codartDataGridViewTextBoxColumn.DataPropertyName = "cod_art";
            this.codartDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codartDataGridViewTextBoxColumn.Name = "codartDataGridViewTextBoxColumn";
            this.codartDataGridViewTextBoxColumn.Width = 65;
            // 
            // desartDataGridViewTextBoxColumn
            // 
            this.desartDataGridViewTextBoxColumn.DataPropertyName = "des_art";
            this.desartDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.desartDataGridViewTextBoxColumn.Name = "desartDataGridViewTextBoxColumn";
            this.desartDataGridViewTextBoxColumn.Width = 88;
            // 
            // cosartDataGridViewTextBoxColumn
            // 
            this.cosartDataGridViewTextBoxColumn.DataPropertyName = "cos_art";
            this.cosartDataGridViewTextBoxColumn.HeaderText = "Costo";
            this.cosartDataGridViewTextBoxColumn.Name = "cosartDataGridViewTextBoxColumn";
            this.cosartDataGridViewTextBoxColumn.Width = 59;
            // 
            // preartDataGridViewTextBoxColumn
            // 
            this.preartDataGridViewTextBoxColumn.DataPropertyName = "pre_art";
            this.preartDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.preartDataGridViewTextBoxColumn.Name = "preartDataGridViewTextBoxColumn";
            this.preartDataGridViewTextBoxColumn.Width = 62;
            // 
            // exiartDataGridViewTextBoxColumn
            // 
            this.exiartDataGridViewTextBoxColumn.DataPropertyName = "exi_art";
            this.exiartDataGridViewTextBoxColumn.HeaderText = "Existencia";
            this.exiartDataGridViewTextBoxColumn.Name = "exiartDataGridViewTextBoxColumn";
            this.exiartDataGridViewTextBoxColumn.Width = 80;
            // 
            // canminDataGridViewTextBoxColumn
            // 
            this.canminDataGridViewTextBoxColumn.DataPropertyName = "can_min";
            this.canminDataGridViewTextBoxColumn.HeaderText = "Can. Minima";
            this.canminDataGridViewTextBoxColumn.Name = "canminDataGridViewTextBoxColumn";
            this.canminDataGridViewTextBoxColumn.Width = 90;
            // 
            // articuloBindingSource1
            // 
            this.articuloBindingSource1.DataMember = "Articulo";
            this.articuloBindingSource1.DataSource = this.factura;
            // 
            // factura
            // 
            this.factura.DataSetName = "Factura";
            this.factura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // articuloBindingSource
            // 
            this.articuloBindingSource.DataMember = "Articulo";
            this.articuloBindingSource.DataSource = this.factura;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(352, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // tota
            // 
            this.tota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tota.Location = new System.Drawing.Point(419, 335);
            this.tota.Name = "tota";
            this.tota.Size = new System.Drawing.Size(100, 30);
            this.tota.TabIndex = 8;
            this.tota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.to_KeyPress);
            // 
            // nuevo
            // 
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.Location = new System.Drawing.Point(206, 401);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(86, 70);
            this.nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nuevo.TabIndex = 17;
            this.nuevo.TabStop = false;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // modificar
            // 
            this.modificar.Image = ((System.Drawing.Image)(resources.GetObject("modificar.Image")));
            this.modificar.Location = new System.Drawing.Point(371, 406);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(78, 65);
            this.modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modificar.TabIndex = 18;
            this.modificar.TabStop = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Location = new System.Drawing.Point(455, 406);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(69, 65);
            this.eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eliminar.TabIndex = 19;
            this.eliminar.TabStop = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // guardar
            // 
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.Location = new System.Drawing.Point(287, 406);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(78, 65);
            this.guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guardar.TabIndex = 20;
            this.guardar.TabStop = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // imprimir
            // 
            this.imprimir.Image = ((System.Drawing.Image)(resources.GetObject("imprimir.Image")));
            this.imprimir.Location = new System.Drawing.Point(530, 401);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(87, 81);
            this.imprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imprimir.TabIndex = 21;
            this.imprimir.TabStop = false;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(623, 406);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(78, 65);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 22;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // buscar
            // 
            this.buscar.Image = ((System.Drawing.Image)(resources.GetObject("buscar.Image")));
            this.buscar.Location = new System.Drawing.Point(419, 6);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(45, 40);
            this.buscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.buscar.TabIndex = 23;
            this.buscar.TabStop = false;
            // 
            // busqueda
            // 
            this.busqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busqueda.Location = new System.Drawing.Point(470, 16);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(337, 30);
            this.busqueda.TabIndex = 7;
            this.busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // articuloTableAdapter
            // 
            this.articuloTableAdapter.ClearBeforeFill = true;
            // 
            // Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(902, 478);
            this.Controls.Add(this.busqueda);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.tota);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.aa);
            this.Controls.Add(this.CanMinima);
            this.Controls.Add(this.Existencia);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Costo);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Articulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Articulos";
            this.Load += new System.EventHandler(this.Articulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articuloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Descripcion;
        private System.Windows.Forms.TextBox Costo;
        private System.Windows.Forms.TextBox Precio;
        private System.Windows.Forms.TextBox Cantidad;
        private System.Windows.Forms.TextBox Existencia;
        private System.Windows.Forms.TextBox CanMinima;
        private System.Windows.Forms.DataGridView aa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tota;
        private System.Windows.Forms.PictureBox nuevo;
        private System.Windows.Forms.PictureBox modificar;
        private System.Windows.Forms.PictureBox eliminar;
        private System.Windows.Forms.PictureBox guardar;
        private System.Windows.Forms.PictureBox imprimir;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.PictureBox buscar;
        private System.Windows.Forms.TextBox busqueda;
        private Factura factura;
        private System.Windows.Forms.BindingSource articuloBindingSource;
        private FacturaTableAdapters.ArticuloTableAdapter articuloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cosartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exiartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canminDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource articuloBindingSource1;
    }
}