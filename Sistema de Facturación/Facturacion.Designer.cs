
namespace Sistema_de_Facturación
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numfactura = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.TextBox();
            this.hora = new System.Windows.Forms.TextBox();
            this.cliente = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.articulo = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.TextBox();
            this.precio = new System.Windows.Forms.TextBox();
            this.cantidad = new System.Windows.Forms.TextBox();
            this.subtot = new System.Windows.Forms.TextBox();
            this.tipodefactura = new System.Windows.Forms.ComboBox();
            this.buscar = new System.Windows.Forms.Button();
            this.bus = new System.Windows.Forms.Button();
            this.busc = new System.Windows.Forms.Button();
            this.Elimart = new System.Windows.Forms.Button();
            this.TDF = new System.Windows.Forms.DataGridView();
            this.codartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.canartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sub_tot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temdetallefacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.factura = new Sistema_de_Facturación.Factura();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.subtotfac = new System.Windows.Forms.TextBox();
            this.pdf = new System.Windows.Forms.TextBox();
            this.daf = new System.Windows.Forms.TextBox();
            this.pitbis = new System.Windows.Forms.TextBox();
            this.itbis = new System.Windows.Forms.TextBox();
            this.totalapagar = new System.Windows.Forms.TextBox();
            this.salir = new System.Windows.Forms.PictureBox();
            this.imprimir = new System.Windows.Forms.PictureBox();
            this.guardar = new System.Windows.Forms.PictureBox();
            this.eliminar = new System.Windows.Forms.PictureBox();
            this.modificar = new System.Windows.Forms.PictureBox();
            this.nuevo = new System.Windows.Forms.PictureBox();
            this.fechahora = new System.Windows.Forms.Timer(this.components);
            this.temdetallefacturaTableAdapter = new Sistema_de_Facturación.FacturaTableAdapters.TemdetallefacturaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TDF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temdetallefacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Factura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(115, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(107, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(100, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Artículo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Descripción";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(114, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 25);
            this.label9.TabIndex = 8;
            this.label9.Text = "Precio";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(88, 346);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Cantidad";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(73, 384);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 25);
            this.label11.TabIndex = 10;
            this.label11.Text = "Sub- Total";
            this.label11.Click += new System.EventHandler(this.subtotal_Click);
            // 
            // numfactura
            // 
            this.numfactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numfactura.Location = new System.Drawing.Point(193, 12);
            this.numfactura.Name = "numfactura";
            this.numfactura.Size = new System.Drawing.Size(147, 30);
            this.numfactura.TabIndex = 0;
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Location = new System.Drawing.Point(193, 48);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(147, 30);
            this.fecha.TabIndex = 1;
            // 
            // hora
            // 
            this.hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hora.Location = new System.Drawing.Point(193, 87);
            this.hora.Name = "hora";
            this.hora.Size = new System.Drawing.Size(147, 30);
            this.hora.TabIndex = 2;
            // 
            // cliente
            // 
            this.cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cliente.Location = new System.Drawing.Point(193, 162);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(147, 30);
            this.cliente.TabIndex = 4;
            this.cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cliente_KeyPress);
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(193, 199);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(272, 30);
            this.nombre.TabIndex = 6;
            // 
            // articulo
            // 
            this.articulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.articulo.Location = new System.Drawing.Point(193, 236);
            this.articulo.Name = "articulo";
            this.articulo.Size = new System.Drawing.Size(147, 30);
            this.articulo.TabIndex = 7;
            this.articulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.articulo_KeyPress);
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(193, 272);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(272, 30);
            this.descripcion.TabIndex = 8;
            // 
            // precio
            // 
            this.precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precio.Location = new System.Drawing.Point(193, 307);
            this.precio.Name = "precio";
            this.precio.Size = new System.Drawing.Size(147, 30);
            this.precio.TabIndex = 9;
            this.precio.TextChanged += new System.EventHandler(this.pre_TextChanged);
            // 
            // cantidad
            // 
            this.cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidad.Location = new System.Drawing.Point(193, 343);
            this.cantidad.Name = "cantidad";
            this.cantidad.Size = new System.Drawing.Size(147, 30);
            this.cantidad.TabIndex = 10;
            this.cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidad_KeyPress);
            // 
            // subtot
            // 
            this.subtot.Enabled = false;
            this.subtot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtot.Location = new System.Drawing.Point(193, 379);
            this.subtot.Name = "subtot";
            this.subtot.Size = new System.Drawing.Size(147, 30);
            this.subtot.TabIndex = 11;
            // 
            // tipodefactura
            // 
            this.tipodefactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipodefactura.FormattingEnabled = true;
            this.tipodefactura.Items.AddRange(new object[] {
            "Efectivo",
            "Crédito",
            "Targeta",
            "Otros"});
            this.tipodefactura.Location = new System.Drawing.Point(193, 123);
            this.tipodefactura.Name = "tipodefactura";
            this.tipodefactura.Size = new System.Drawing.Size(147, 33);
            this.tipodefactura.TabIndex = 3;
            // 
            // buscar
            // 
            this.buscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buscar.Location = new System.Drawing.Point(356, 12);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(88, 30);
            this.buscar.TabIndex = 23;
            this.buscar.Text = "Buscar";
            this.buscar.UseVisualStyleBackColor = false;
            // 
            // bus
            // 
            this.bus.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bus.Location = new System.Drawing.Point(356, 163);
            this.bus.Name = "bus";
            this.bus.Size = new System.Drawing.Size(88, 29);
            this.bus.TabIndex = 24;
            this.bus.Text = "Buscar";
            this.bus.UseVisualStyleBackColor = false;
            this.bus.Click += new System.EventHandler(this.bus_Click);
            // 
            // busc
            // 
            this.busc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.busc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busc.Location = new System.Drawing.Point(356, 235);
            this.busc.Name = "busc";
            this.busc.Size = new System.Drawing.Size(88, 30);
            this.busc.TabIndex = 25;
            this.busc.Text = "Buscar";
            this.busc.UseVisualStyleBackColor = false;
            this.busc.Click += new System.EventHandler(this.busc_Click);
            // 
            // Elimart
            // 
            this.Elimart.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Elimart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Elimart.Location = new System.Drawing.Point(356, 308);
            this.Elimart.Name = "Elimart";
            this.Elimart.Size = new System.Drawing.Size(96, 29);
            this.Elimart.TabIndex = 26;
            this.Elimart.Text = "Elim. Art.";
            this.Elimart.UseVisualStyleBackColor = false;
            // 
            // TDF
            // 
            this.TDF.AutoGenerateColumns = false;
            this.TDF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TDF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codartDataGridViewTextBoxColumn,
            this.desartDataGridViewTextBoxColumn,
            this.preartDataGridViewTextBoxColumn,
            this.canartDataGridViewTextBoxColumn,
            this.sub_tot});
            this.TDF.DataSource = this.temdetallefacturaBindingSource;
            this.TDF.Location = new System.Drawing.Point(480, 12);
            this.TDF.Name = "TDF";
            this.TDF.Size = new System.Drawing.Size(485, 361);
            this.TDF.TabIndex = 27;
            // 
            // codartDataGridViewTextBoxColumn
            // 
            this.codartDataGridViewTextBoxColumn.DataPropertyName = "cod_art";
            this.codartDataGridViewTextBoxColumn.HeaderText = "CODIGO";
            this.codartDataGridViewTextBoxColumn.Name = "codartDataGridViewTextBoxColumn";
            // 
            // desartDataGridViewTextBoxColumn
            // 
            this.desartDataGridViewTextBoxColumn.DataPropertyName = "des_art";
            this.desartDataGridViewTextBoxColumn.HeaderText = "DESCRIPCION";
            this.desartDataGridViewTextBoxColumn.Name = "desartDataGridViewTextBoxColumn";
            // 
            // preartDataGridViewTextBoxColumn
            // 
            this.preartDataGridViewTextBoxColumn.DataPropertyName = "pre_art";
            this.preartDataGridViewTextBoxColumn.HeaderText = "PRECIO";
            this.preartDataGridViewTextBoxColumn.Name = "preartDataGridViewTextBoxColumn";
            // 
            // canartDataGridViewTextBoxColumn
            // 
            this.canartDataGridViewTextBoxColumn.DataPropertyName = "can_art";
            this.canartDataGridViewTextBoxColumn.HeaderText = "CANTIDAD";
            this.canartDataGridViewTextBoxColumn.Name = "canartDataGridViewTextBoxColumn";
            // 
            // sub_tot
            // 
            this.sub_tot.DataPropertyName = "sub_tot";
            this.sub_tot.HeaderText = "SUB-TOTAL";
            this.sub_tot.Name = "sub_tot";
            // 
            // temdetallefacturaBindingSource
            // 
            this.temdetallefacturaBindingSource.DataMember = "Temdetallefactura";
            this.temdetallefacturaBindingSource.DataSource = this.factura;
            // 
            // factura
            // 
            this.factura.DataSetName = "Factura";
            this.factura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(666, 382);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "SUB- TOTAL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(632, 415);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 25);
            this.label13.TabIndex = 29;
            this.label13.Text = "% Desc";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(632, 454);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 25);
            this.label14.TabIndex = 30;
            this.label14.Text = "% ITBIS";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(623, 497);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(185, 25);
            this.label15.TabIndex = 31;
            this.label15.Text = "TOTAL A PAGAR";
            // 
            // subtotfac
            // 
            this.subtotfac.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotfac.Location = new System.Drawing.Point(814, 377);
            this.subtotfac.Name = "subtotfac";
            this.subtotfac.Size = new System.Drawing.Size(129, 30);
            this.subtotfac.TabIndex = 12;
            // 
            // pdf
            // 
            this.pdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pdf.Location = new System.Drawing.Point(724, 415);
            this.pdf.Name = "pdf";
            this.pdf.Size = new System.Drawing.Size(84, 30);
            this.pdf.TabIndex = 13;
            this.pdf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pdf_KeyPress);
            // 
            // daf
            // 
            this.daf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daf.Location = new System.Drawing.Point(814, 413);
            this.daf.Name = "daf";
            this.daf.Size = new System.Drawing.Size(129, 30);
            this.daf.TabIndex = 14;
            // 
            // pitbis
            // 
            this.pitbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitbis.Location = new System.Drawing.Point(724, 454);
            this.pitbis.Name = "pitbis";
            this.pitbis.Size = new System.Drawing.Size(84, 30);
            this.pitbis.TabIndex = 15;
            this.pitbis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pitbis_KeyPress);
            // 
            // itbis
            // 
            this.itbis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itbis.Location = new System.Drawing.Point(814, 454);
            this.itbis.Name = "itbis";
            this.itbis.Size = new System.Drawing.Size(129, 30);
            this.itbis.TabIndex = 16;
            // 
            // totalapagar
            // 
            this.totalapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalapagar.Location = new System.Drawing.Point(814, 494);
            this.totalapagar.Name = "totalapagar";
            this.totalapagar.Size = new System.Drawing.Size(129, 30);
            this.totalapagar.TabIndex = 17;
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(514, 459);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(78, 65);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 43;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // imprimir
            // 
            this.imprimir.Image = ((System.Drawing.Image)(resources.GetObject("imprimir.Image")));
            this.imprimir.Location = new System.Drawing.Point(421, 454);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(87, 81);
            this.imprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imprimir.TabIndex = 42;
            this.imprimir.TabStop = false;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // guardar
            // 
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.Location = new System.Drawing.Point(178, 459);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(78, 65);
            this.guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guardar.TabIndex = 41;
            this.guardar.TabStop = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Location = new System.Drawing.Point(346, 459);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(69, 65);
            this.eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eliminar.TabIndex = 40;
            this.eliminar.TabStop = false;
            // 
            // modificar
            // 
            this.modificar.Image = ((System.Drawing.Image)(resources.GetObject("modificar.Image")));
            this.modificar.Location = new System.Drawing.Point(262, 459);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(78, 65);
            this.modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modificar.TabIndex = 39;
            this.modificar.TabStop = false;
            // 
            // nuevo
            // 
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.Location = new System.Drawing.Point(97, 454);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(86, 70);
            this.nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nuevo.TabIndex = 38;
            this.nuevo.TabStop = false;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // fechahora
            // 
            this.fechahora.Enabled = true;
            this.fechahora.Tick += new System.EventHandler(this.fechahora_Tick);
            // 
            // temdetallefacturaTableAdapter
            // 
            this.temdetallefacturaTableAdapter.ClearBeforeFill = true;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(970, 532);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.totalapagar);
            this.Controls.Add(this.itbis);
            this.Controls.Add(this.pitbis);
            this.Controls.Add(this.daf);
            this.Controls.Add(this.pdf);
            this.Controls.Add(this.subtotfac);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TDF);
            this.Controls.Add(this.Elimart);
            this.Controls.Add(this.busc);
            this.Controls.Add(this.bus);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.tipodefactura);
            this.Controls.Add(this.subtot);
            this.Controls.Add(this.cantidad);
            this.Controls.Add(this.precio);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.articulo);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.hora);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.numfactura);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Load += new System.EventHandler(this.Facturacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TDF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temdetallefacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modificar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuevo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.TextBox hora;
        private System.Windows.Forms.TextBox cliente;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox articulo;
        private System.Windows.Forms.TextBox descripcion;
        private System.Windows.Forms.TextBox precio;
        private System.Windows.Forms.TextBox cantidad;
        private System.Windows.Forms.TextBox subtot;
        private System.Windows.Forms.Button buscar;
        private System.Windows.Forms.Button bus;
        private System.Windows.Forms.Button busc;
        private System.Windows.Forms.Button Elimart;
        private System.Windows.Forms.DataGridView TDF;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox subtotfac;
        private System.Windows.Forms.TextBox pdf;
        private System.Windows.Forms.TextBox daf;
        private System.Windows.Forms.TextBox pitbis;
        private System.Windows.Forms.TextBox itbis;
        private System.Windows.Forms.TextBox totalapagar;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.PictureBox imprimir;
        private System.Windows.Forms.PictureBox guardar;
        private System.Windows.Forms.PictureBox eliminar;
        private System.Windows.Forms.PictureBox modificar;
        private System.Windows.Forms.PictureBox nuevo;
        private System.Windows.Forms.Timer fechahora;
        private Factura factura;
        private System.Windows.Forms.BindingSource temdetallefacturaBindingSource;
        private FacturaTableAdapters.TemdetallefacturaTableAdapter temdetallefacturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn canartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sub_tot;
        public System.Windows.Forms.TextBox numfactura;
        public System.Windows.Forms.ComboBox tipodefactura;
    }
}