namespace EATEASY
{
    partial class FormPrincipal
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
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnRecetaIngredientes = new System.Windows.Forms.Button();
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnCostoReceta = new System.Windows.Forms.Button();
            this.btnMenuSemanal = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecetas
            // 
            this.btnRecetas.Location = new System.Drawing.Point(72, 30);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(75, 23);
            this.btnRecetas.TabIndex = 0;
            this.btnRecetas.Text = "Resetas ";
            this.btnRecetas.UseVisualStyleBackColor = true;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            // 
            // btnRecetaIngredientes
            // 
            this.btnRecetaIngredientes.Location = new System.Drawing.Point(72, 95);
            this.btnRecetaIngredientes.Name = "btnRecetaIngredientes";
            this.btnRecetaIngredientes.Size = new System.Drawing.Size(75, 23);
            this.btnRecetaIngredientes.TabIndex = 1;
            this.btnRecetaIngredientes.Text = "Receta Ingredientes";
            this.btnRecetaIngredientes.UseVisualStyleBackColor = true;
            this.btnRecetaIngredientes.Click += new System.EventHandler(this.btnRecetaIngredientes_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Location = new System.Drawing.Point(239, 30);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(75, 23);
            this.btnIngredientes.TabIndex = 2;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnCostoReceta
            // 
            this.btnCostoReceta.Location = new System.Drawing.Point(239, 95);
            this.btnCostoReceta.Name = "btnCostoReceta";
            this.btnCostoReceta.Size = new System.Drawing.Size(75, 23);
            this.btnCostoReceta.TabIndex = 3;
            this.btnCostoReceta.Text = "Costo";
            this.btnCostoReceta.UseVisualStyleBackColor = true;
            this.btnCostoReceta.Click += new System.EventHandler(this.btnCostoReceta_Click);
            // 
            // btnMenuSemanal
            // 
            this.btnMenuSemanal.Location = new System.Drawing.Point(72, 172);
            this.btnMenuSemanal.Name = "btnMenuSemanal";
            this.btnMenuSemanal.Size = new System.Drawing.Size(75, 23);
            this.btnMenuSemanal.TabIndex = 4;
            this.btnMenuSemanal.Text = "Menu";
            this.btnMenuSemanal.UseVisualStyleBackColor = true;
            this.btnMenuSemanal.Click += new System.EventHandler(this.btnMenuSemanal_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(239, 172);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 241);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnMenuSemanal);
            this.Controls.Add(this.btnCostoReceta);
            this.Controls.Add(this.btnIngredientes);
            this.Controls.Add(this.btnRecetaIngredientes);
            this.Controls.Add(this.btnRecetas);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnRecetaIngredientes;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Button btnCostoReceta;
        private System.Windows.Forms.Button btnMenuSemanal;
        private System.Windows.Forms.Button btnSalir;
    }
}