
namespace Gestor_de_compras.UI
{
    partial class frmGanancias
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblInversion1 = new System.Windows.Forms.Label();
            this.lblInversionAnual = new System.Windows.Forms.Label();
            this.lblInversion = new System.Windows.Forms.Label();
            this.lblInversionTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ganancias ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inversion del ultimo mes :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(606, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inversion Total :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblInversion1
            // 
            this.lblInversion1.AutoSize = true;
            this.lblInversion1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInversion1.Location = new System.Drawing.Point(366, 158);
            this.lblInversion1.Name = "lblInversion1";
            this.lblInversion1.Size = new System.Drawing.Size(21, 23);
            this.lblInversion1.TabIndex = 3;
            this.lblInversion1.Text = "$";
            // 
            // lblInversionAnual
            // 
            this.lblInversionAnual.AutoSize = true;
            this.lblInversionAnual.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInversionAnual.Location = new System.Drawing.Point(776, 158);
            this.lblInversionAnual.Name = "lblInversionAnual";
            this.lblInversionAnual.Size = new System.Drawing.Size(21, 23);
            this.lblInversionAnual.TabIndex = 4;
            this.lblInversionAnual.Text = "$";
            this.lblInversionAnual.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblInversion
            // 
            this.lblInversion.AutoSize = true;
            this.lblInversion.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInversion.Location = new System.Drawing.Point(393, 160);
            this.lblInversion.Name = "lblInversion";
            this.lblInversion.Size = new System.Drawing.Size(57, 21);
            this.lblInversion.TabIndex = 11;
            this.lblInversion.Text = "label4";
            // 
            // lblInversionTotal
            // 
            this.lblInversionTotal.AutoSize = true;
            this.lblInversionTotal.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInversionTotal.Location = new System.Drawing.Point(803, 161);
            this.lblInversionTotal.Name = "lblInversionTotal";
            this.lblInversionTotal.Size = new System.Drawing.Size(57, 21);
            this.lblInversionTotal.TabIndex = 12;
            this.lblInversionTotal.Text = "label4";
            this.lblInversionTotal.Click += new System.EventHandler(this.lblInversionTotal_Click);
            // 
            // frmGanancias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1020, 439);
            this.Controls.Add(this.lblInversionTotal);
            this.Controls.Add(this.lblInversion);
            this.Controls.Add(this.lblInversionAnual);
            this.Controls.Add(this.lblInversion1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGanancias";
            this.Text = "frmGanancias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblInversion1;
        private System.Windows.Forms.Label lblInversionAnual;
        private System.Windows.Forms.Label lblInversion;
        private System.Windows.Forms.Label lblInversionTotal;
    }
}