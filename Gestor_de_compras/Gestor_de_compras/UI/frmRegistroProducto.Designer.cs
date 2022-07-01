
namespace Gestor_de_compras.UI
{
    partial class frmRegistroProducto
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
            this.listCompras = new System.Windows.Forms.ListView();
            this.colFecha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInversion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidadProductos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listCompras
            // 
            this.listCompras.BackColor = System.Drawing.Color.DarkSalmon;
            this.listCompras.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listCompras.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colFecha,
            this.colInversion,
            this.colCantidadProductos});
            this.listCompras.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCompras.FullRowSelect = true;
            this.listCompras.GridLines = true;
            this.listCompras.HideSelection = false;
            this.listCompras.Location = new System.Drawing.Point(248, 72);
            this.listCompras.Name = "listCompras";
            this.listCompras.Size = new System.Drawing.Size(521, 318);
            this.listCompras.TabIndex = 0;
            this.listCompras.UseCompatibleStateImageBehavior = false;
            this.listCompras.View = System.Windows.Forms.View.Details;
            this.listCompras.SelectedIndexChanged += new System.EventHandler(this.listCompras_SelectedIndexChanged);
            // 
            // colFecha
            // 
            this.colFecha.Text = "Fecha";
            this.colFecha.Width = 182;
            // 
            // colInversion
            // 
            this.colInversion.Text = "Inversion";
            this.colInversion.Width = 134;
            // 
            // colCantidadProductos
            // 
            this.colCantidadProductos.Text = "Cantidad de Productos";
            this.colCantidadProductos.Width = 203;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(343, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Compras";
            // 
            // frmRegistroProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1020, 439);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCompras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroProducto";
            this.Text = "frmRegistroProducto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader colFecha;
        private System.Windows.Forms.ColumnHeader colInversion;
        private System.Windows.Forms.ColumnHeader colCantidadProductos;
    }
}