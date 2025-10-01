
namespace Sistema_de_Facturación
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Codigo = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Clave = new System.Windows.Forms.TextBox();
            this.ConfirmarClave = new System.Windows.Forms.TextBox();
            this.Celular = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.busqueda = new System.Windows.Forms.TextBox();
            this.tota = new System.Windows.Forms.TextBox();
            this.au = new System.Windows.Forms.DataGridView();
            this.codusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clausuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corusuDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cor_usu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.factura = new Sistema_de_Facturación.Factura();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.salir = new System.Windows.Forms.PictureBox();
            this.imprimir = new System.Windows.Forms.PictureBox();
            this.guardar = new System.Windows.Forms.PictureBox();
            this.eliminar = new System.Windows.Forms.PictureBox();
            this.modificar = new System.Windows.Forms.PictureBox();
            this.nuevo = new System.Windows.Forms.PictureBox();
            this.usuarioTableAdapter = new Sistema_de_Facturación.FacturaTableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.au)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
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
            this.label1.Location = new System.Drawing.Point(91, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre(*)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(79, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave(*)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirmar Clave";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(91, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Celular";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(94, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(513, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Buscar";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(451, 263);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Total";
            // 
            // Codigo
            // 
            this.Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Codigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.Location = new System.Drawing.Point(178, 28);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(134, 30);
            this.Codigo.TabIndex = 0;
            this.Codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Codigo_KeyPress);
            // 
            // Nombre
            // 
            this.Nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(178, 73);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(334, 30);
            this.Nombre.TabIndex = 1;
            this.Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Nombre_KeyPress);
            // 
            // Clave
            // 
            this.Clave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clave.Location = new System.Drawing.Point(178, 113);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(134, 30);
            this.Clave.TabIndex = 2;
            this.Clave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Clave_KeyPress);
            // 
            // ConfirmarClave
            // 
            this.ConfirmarClave.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ConfirmarClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmarClave.Location = new System.Drawing.Point(178, 150);
            this.ConfirmarClave.Name = "ConfirmarClave";
            this.ConfirmarClave.Size = new System.Drawing.Size(134, 30);
            this.ConfirmarClave.TabIndex = 3;
            this.ConfirmarClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ConfirmarClave_KeyPress);
            // 
            // Celular
            // 
            this.Celular.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Celular.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Celular.Location = new System.Drawing.Point(178, 186);
            this.Celular.Name = "Celular";
            this.Celular.Size = new System.Drawing.Size(134, 30);
            this.Celular.TabIndex = 4;
            this.Celular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Celular_KeyPress);
            // 
            // Correo
            // 
            this.Correo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Correo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Correo.Location = new System.Drawing.Point(178, 222);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(334, 30);
            this.Correo.TabIndex = 5;
            this.Correo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Correo_KeyPress);
            // 
            // busqueda
            // 
            this.busqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.busqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busqueda.Location = new System.Drawing.Point(598, 25);
            this.busqueda.Name = "busqueda";
            this.busqueda.Size = new System.Drawing.Size(241, 30);
            this.busqueda.TabIndex = 6;
            this.busqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Buscar_KeyPress);
            // 
            // tota
            // 
            this.tota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tota.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tota.Location = new System.Drawing.Point(518, 258);
            this.tota.Name = "tota";
            this.tota.Size = new System.Drawing.Size(117, 30);
            this.tota.TabIndex = 7;
            this.tota.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Total_KeyPress);
            // 
            // au
            // 
            this.au.AutoGenerateColumns = false;
            this.au.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.au.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.au.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codusuDataGridViewTextBoxColumn,
            this.nomusuDataGridViewTextBoxColumn,
            this.clausuDataGridViewTextBoxColumn,
            this.celusuDataGridViewTextBoxColumn,
            this.corusuDataGridViewTextBoxColumn,
            this.cor_usu});
            this.au.DataSource = this.usuarioBindingSource1;
            this.au.Location = new System.Drawing.Point(518, 57);
            this.au.Name = "au";
            this.au.RowHeadersVisible = false;
            this.au.Size = new System.Drawing.Size(321, 195);
            this.au.TabIndex = 16;
            this.au.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.au_CellContentClick);
            // 
            // codusuDataGridViewTextBoxColumn
            // 
            this.codusuDataGridViewTextBoxColumn.DataPropertyName = "cod_usu";
            this.codusuDataGridViewTextBoxColumn.HeaderText = "Código";
            this.codusuDataGridViewTextBoxColumn.Name = "codusuDataGridViewTextBoxColumn";
            this.codusuDataGridViewTextBoxColumn.Width = 65;
            // 
            // nomusuDataGridViewTextBoxColumn
            // 
            this.nomusuDataGridViewTextBoxColumn.DataPropertyName = "nom_usu";
            this.nomusuDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nomusuDataGridViewTextBoxColumn.Name = "nomusuDataGridViewTextBoxColumn";
            this.nomusuDataGridViewTextBoxColumn.Width = 69;
            // 
            // clausuDataGridViewTextBoxColumn
            // 
            this.clausuDataGridViewTextBoxColumn.DataPropertyName = "cla_usu";
            this.clausuDataGridViewTextBoxColumn.HeaderText = "Clave";
            this.clausuDataGridViewTextBoxColumn.Name = "clausuDataGridViewTextBoxColumn";
            this.clausuDataGridViewTextBoxColumn.Width = 59;
            // 
            // celusuDataGridViewTextBoxColumn
            // 
            this.celusuDataGridViewTextBoxColumn.DataPropertyName = "cel_usu";
            this.celusuDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celusuDataGridViewTextBoxColumn.Name = "celusuDataGridViewTextBoxColumn";
            this.celusuDataGridViewTextBoxColumn.Width = 64;
            // 
            // corusuDataGridViewTextBoxColumn
            // 
            this.corusuDataGridViewTextBoxColumn.DataPropertyName = "cor_usu";
            this.corusuDataGridViewTextBoxColumn.HeaderText = "Correo";
            this.corusuDataGridViewTextBoxColumn.Name = "corusuDataGridViewTextBoxColumn";
            this.corusuDataGridViewTextBoxColumn.Width = 63;
            // 
            // cor_usu
            // 
            this.cor_usu.DataPropertyName = "cor_usu";
            this.cor_usu.HeaderText = "cor_usu";
            this.cor_usu.Name = "cor_usu";
            this.cor_usu.Width = 70;
            // 
            // usuarioBindingSource1
            // 
            this.usuarioBindingSource1.DataMember = "Usuario";
            this.usuarioBindingSource1.DataSource = this.factura;
            // 
            // factura
            // 
            this.factura.DataSetName = "Factura";
            this.factura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.factura;
            // 
            // salir
            // 
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(598, 346);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(78, 65);
            this.salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salir.TabIndex = 49;
            this.salir.TabStop = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // imprimir
            // 
            this.imprimir.Image = ((System.Drawing.Image)(resources.GetObject("imprimir.Image")));
            this.imprimir.Location = new System.Drawing.Point(505, 341);
            this.imprimir.Name = "imprimir";
            this.imprimir.Size = new System.Drawing.Size(87, 81);
            this.imprimir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imprimir.TabIndex = 48;
            this.imprimir.TabStop = false;
            this.imprimir.Click += new System.EventHandler(this.imprimir_Click);
            // 
            // guardar
            // 
            this.guardar.Image = ((System.Drawing.Image)(resources.GetObject("guardar.Image")));
            this.guardar.Location = new System.Drawing.Point(262, 346);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(78, 65);
            this.guardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guardar.TabIndex = 47;
            this.guardar.TabStop = false;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Image = ((System.Drawing.Image)(resources.GetObject("eliminar.Image")));
            this.eliminar.Location = new System.Drawing.Point(430, 346);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(69, 65);
            this.eliminar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.eliminar.TabIndex = 46;
            this.eliminar.TabStop = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // modificar
            // 
            this.modificar.Image = ((System.Drawing.Image)(resources.GetObject("modificar.Image")));
            this.modificar.Location = new System.Drawing.Point(346, 346);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(78, 65);
            this.modificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.modificar.TabIndex = 45;
            this.modificar.TabStop = false;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // nuevo
            // 
            this.nuevo.Image = ((System.Drawing.Image)(resources.GetObject("nuevo.Image")));
            this.nuevo.Location = new System.Drawing.Point(181, 341);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(86, 70);
            this.nuevo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.nuevo.TabIndex = 44;
            this.nuevo.TabStop = false;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(905, 413);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.imprimir);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.au);
            this.Controls.Add(this.tota);
            this.Controls.Add(this.busqueda);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Celular);
            this.Controls.Add(this.ConfirmarClave);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Codigo);
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
            this.Name = "Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Usuarios";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.au)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
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
        private System.Windows.Forms.TextBox Codigo;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Clave;
        private System.Windows.Forms.TextBox ConfirmarClave;
        private System.Windows.Forms.TextBox Celular;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox busqueda;
        private System.Windows.Forms.TextBox tota;
        private System.Windows.Forms.DataGridView au;
        private System.Windows.Forms.PictureBox salir;
        private System.Windows.Forms.PictureBox imprimir;
        private System.Windows.Forms.PictureBox guardar;
        private System.Windows.Forms.PictureBox eliminar;
        private System.Windows.Forms.PictureBox modificar;
        private System.Windows.Forms.PictureBox nuevo;
        private Factura factura;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private FacturaTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn codusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clausuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corusuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cor_usu;
        private System.Windows.Forms.BindingSource usuarioBindingSource1;
    }
}