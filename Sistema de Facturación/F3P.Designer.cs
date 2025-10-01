
namespace Sistema_de_Facturación
{
    partial class F3P
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.CRV3P = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.V33P1 = new Sistema_de_Facturación.V33P();
            this.numero = new System.Windows.Forms.TextBox();
            this.CRV = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(800, 450);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // CRV3P
            // 
            this.CRV3P.ActiveViewIndex = 0;
            this.CRV3P.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV3P.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV3P.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV3P.Location = new System.Drawing.Point(0, 0);
            this.CRV3P.Name = "CRV3P";
            this.CRV3P.ReportSource = this.V33P1;
            this.CRV3P.Size = new System.Drawing.Size(800, 450);
            this.CRV3P.TabIndex = 1;
            this.CRV3P.Load += new System.EventHandler(this.crystalReportViewer2_Load);
            // 
            // numero
            // 
            this.numero.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numero.Location = new System.Drawing.Point(300, 26);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(100, 30);
            this.numero.TabIndex = 1;
            // 
            // CRV
            // 
            this.CRV.ActiveViewIndex = 0;
            this.CRV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV.Location = new System.Drawing.Point(0, 0);
            this.CRV.Name = "CRV";
            this.CRV.ReportSource = this.V33P1;
            this.CRV.Size = new System.Drawing.Size(800, 450);
            this.CRV.TabIndex = 1;
            this.CRV.Load += new System.EventHandler(this.crystalReportViewer2_Load);
            // 
            // F3P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.CRV3P);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "F3P";
            this.Text = "F3P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV3P;
        private V33P V33P1;
        public System.Windows.Forms.TextBox numero;
        private Sistema_de_Facturación.V33P V33PP1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV;
    }
}