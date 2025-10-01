
namespace Sistema_de_Facturación
{
    partial class Menu
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
            this.rm = new System.Windows.Forms.GroupBox();
            this.Us = new System.Windows.Forms.RadioButton();
            this.Cli = new System.Windows.Forms.RadioButton();
            this.art = new System.Windows.Forms.RadioButton();
            this.Procesos = new System.Windows.Forms.GroupBox();
            this.fac = new System.Windows.Forms.RadioButton();
            this.Consultas = new System.Windows.Forms.GroupBox();
            this.ven = new System.Windows.Forms.RadioButton();
            this.Reportes = new System.Windows.Forms.GroupBox();
            this.clie = new System.Windows.Forms.RadioButton();
            this.arti = new System.Windows.Forms.RadioButton();
            this.salir = new System.Windows.Forms.Button();
            this.rm.SuspendLayout();
            this.Procesos.SuspendLayout();
            this.Consultas.SuspendLayout();
            this.Reportes.SuspendLayout();
            this.SuspendLayout();
            // 
            // rm
            // 
            this.rm.BackColor = System.Drawing.Color.Plum;
            this.rm.Controls.Add(this.Us);
            this.rm.Controls.Add(this.Cli);
            this.rm.Controls.Add(this.art);
            this.rm.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rm.Location = new System.Drawing.Point(22, 25);
            this.rm.Name = "rm";
            this.rm.Size = new System.Drawing.Size(296, 188);
            this.rm.TabIndex = 0;
            this.rm.TabStop = false;
            this.rm.Text = "Registros Y Mantenimientos";
            this.rm.Enter += new System.EventHandler(this.rm_Enter);
            // 
            // Us
            // 
            this.Us.AutoSize = true;
            this.Us.Location = new System.Drawing.Point(17, 128);
            this.Us.Name = "Us";
            this.Us.Size = new System.Drawing.Size(104, 29);
            this.Us.TabIndex = 2;
            this.Us.Text = "Usuario";
            this.Us.UseVisualStyleBackColor = true;
            this.Us.Click += new System.EventHandler(this.Us_Click);
            // 
            // Cli
            // 
            this.Cli.AutoSize = true;
            this.Cli.Location = new System.Drawing.Point(17, 93);
            this.Cli.Name = "Cli";
            this.Cli.Size = new System.Drawing.Size(98, 29);
            this.Cli.TabIndex = 1;
            this.Cli.Text = "Cliente";
            this.Cli.UseVisualStyleBackColor = true;
            this.Cli.Click += new System.EventHandler(this.Cli_Click);
            // 
            // art
            // 
            this.art.AutoSize = true;
            this.art.Location = new System.Drawing.Point(17, 58);
            this.art.Name = "art";
            this.art.Size = new System.Drawing.Size(103, 29);
            this.art.TabIndex = 0;
            this.art.Text = "Articulo";
            this.art.UseVisualStyleBackColor = true;
            this.art.Click += new System.EventHandler(this.art_Click);
            // 
            // Procesos
            // 
            this.Procesos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Procesos.Controls.Add(this.fac);
            this.Procesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Procesos.Location = new System.Drawing.Point(389, 25);
            this.Procesos.Name = "Procesos";
            this.Procesos.Size = new System.Drawing.Size(296, 188);
            this.Procesos.TabIndex = 1;
            this.Procesos.TabStop = false;
            this.Procesos.Text = "Procesos";
            // 
            // fac
            // 
            this.fac.AutoSize = true;
            this.fac.Location = new System.Drawing.Point(22, 58);
            this.fac.Name = "fac";
            this.fac.Size = new System.Drawing.Size(143, 29);
            this.fac.TabIndex = 0;
            this.fac.Text = "Facturación";
            this.fac.UseVisualStyleBackColor = true;
            this.fac.Click += new System.EventHandler(this.fac_Click);
            // 
            // Consultas
            // 
            this.Consultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Consultas.Controls.Add(this.ven);
            this.Consultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consultas.Location = new System.Drawing.Point(22, 240);
            this.Consultas.Name = "Consultas";
            this.Consultas.Size = new System.Drawing.Size(296, 178);
            this.Consultas.TabIndex = 2;
            this.Consultas.TabStop = false;
            this.Consultas.Text = "Consultas";
            // 
            // ven
            // 
            this.ven.AutoSize = true;
            this.ven.Location = new System.Drawing.Point(17, 49);
            this.ven.Name = "ven";
            this.ven.Size = new System.Drawing.Size(98, 29);
            this.ven.TabIndex = 0;
            this.ven.Text = "Ventas";
            this.ven.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.Reportes.BackColor = System.Drawing.Color.MediumPurple;
            this.Reportes.Controls.Add(this.clie);
            this.Reportes.Controls.Add(this.arti);
            this.Reportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportes.Location = new System.Drawing.Point(389, 240);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(296, 178);
            this.Reportes.TabIndex = 3;
            this.Reportes.TabStop = false;
            this.Reportes.Text = "Reportes";
            // 
            // clie
            // 
            this.clie.AutoSize = true;
            this.clie.Location = new System.Drawing.Point(22, 88);
            this.clie.Name = "clie";
            this.clie.Size = new System.Drawing.Size(109, 29);
            this.clie.TabIndex = 1;
            this.clie.Text = "Clientes";
            this.clie.UseVisualStyleBackColor = true;
            // 
            // arti
            // 
            this.arti.AutoSize = true;
            this.arti.Location = new System.Drawing.Point(22, 53);
            this.arti.Name = "arti";
            this.arti.Size = new System.Drawing.Size(114, 29);
            this.arti.TabIndex = 0;
            this.arti.Text = "Articulos";
            this.arti.UseVisualStyleBackColor = true;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.Color.Pink;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(184, 438);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(370, 52);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir Del Sistema";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 512);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.Consultas);
            this.Controls.Add(this.Procesos);
            this.Controls.Add(this.Reportes);
            this.Controls.Add(this.rm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.rm.ResumeLayout(false);
            this.rm.PerformLayout();
            this.Procesos.ResumeLayout(false);
            this.Procesos.PerformLayout();
            this.Consultas.ResumeLayout(false);
            this.Consultas.PerformLayout();
            this.Reportes.ResumeLayout(false);
            this.Reportes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox rm;
        private System.Windows.Forms.RadioButton Us;
        private System.Windows.Forms.RadioButton Cli;
        private System.Windows.Forms.RadioButton art;
        private System.Windows.Forms.GroupBox Procesos;
        private System.Windows.Forms.RadioButton fac;
        private System.Windows.Forms.GroupBox Consultas;
        private System.Windows.Forms.RadioButton ven;
        private System.Windows.Forms.GroupBox Reportes;
        private System.Windows.Forms.RadioButton clie;
        private System.Windows.Forms.RadioButton arti;
        private System.Windows.Forms.Button salir;
    }
}