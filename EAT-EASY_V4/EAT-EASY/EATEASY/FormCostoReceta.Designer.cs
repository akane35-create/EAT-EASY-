namespace EATEASY
{
    partial class FormCostoReceta
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
            this.lstRecetas = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // lstRecetas
            // 
            this.lstRecetas.FormattingEnabled = true;
            this.lstRecetas.Location = new System.Drawing.Point(34, 41);
            this.lstRecetas.Name = "lstRecetas";
            this.lstRecetas.Size = new System.Drawing.Size(121, 24);
            this.lstRecetas.TabIndex = 0;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(45, 130);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 1;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(42, 96);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(24, 17);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "$0";
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Location = new System.Drawing.Point(243, 22);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.RowTemplate.Height = 24;
            this.dgvDetalle.Size = new System.Drawing.Size(240, 150);
            this.dgvDetalle.TabIndex = 3;
            // 
            // FormCostoReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 337);
            this.Controls.Add(this.dgvDetalle);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lstRecetas);
            this.Name = "FormCostoReceta";
            this.Text = "FormCostoReceta";
            this.Load += new System.EventHandler(this.FormCostoReceta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox lstRecetas;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridView dgvDetalle;
    }
}