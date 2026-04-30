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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecetas
            // 
            this.btnRecetas.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecetas.Location = new System.Drawing.Point(54, 24);
            this.btnRecetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(106, 54);
            this.btnRecetas.TabIndex = 0;
            this.btnRecetas.Text = "Recetas ";
            this.btnRecetas.UseVisualStyleBackColor = true;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            // 
            // btnRecetaIngredientes
            // 
            this.btnRecetaIngredientes.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecetaIngredientes.Location = new System.Drawing.Point(9, 121);
            this.btnRecetaIngredientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRecetaIngredientes.Name = "btnRecetaIngredientes";
            this.btnRecetaIngredientes.Size = new System.Drawing.Size(197, 50);
            this.btnRecetaIngredientes.TabIndex = 1;
            this.btnRecetaIngredientes.Text = "Receta Ingredientes";
            this.btnRecetaIngredientes.UseVisualStyleBackColor = true;
            this.btnRecetaIngredientes.Click += new System.EventHandler(this.btnRecetaIngredientes_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngredientes.Location = new System.Drawing.Point(320, 24);
            this.btnIngredientes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(130, 54);
            this.btnIngredientes.TabIndex = 2;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnCostoReceta
            // 
            this.btnCostoReceta.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCostoReceta.Location = new System.Drawing.Point(331, 121);
            this.btnCostoReceta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCostoReceta.Name = "btnCostoReceta";
            this.btnCostoReceta.Size = new System.Drawing.Size(106, 50);
            this.btnCostoReceta.TabIndex = 3;
            this.btnCostoReceta.Text = "Costo";
            this.btnCostoReceta.UseVisualStyleBackColor = true;
            this.btnCostoReceta.Click += new System.EventHandler(this.btnCostoReceta_Click);
            // 
            // btnMenuSemanal
            // 
            this.btnMenuSemanal.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuSemanal.Location = new System.Drawing.Point(54, 211);
            this.btnMenuSemanal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMenuSemanal.Name = "btnMenuSemanal";
            this.btnMenuSemanal.Size = new System.Drawing.Size(106, 45);
            this.btnMenuSemanal.TabIndex = 4;
            this.btnMenuSemanal.Text = "Menu";
            this.btnMenuSemanal.UseVisualStyleBackColor = true;
            this.btnMenuSemanal.Click += new System.EventHandler(this.btnMenuSemanal_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(331, 211);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(106, 45);
            this.btnRegresar.TabIndex = 5;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 267);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnMenuSemanal);
            this.Controls.Add(this.btnCostoReceta);
            this.Controls.Add(this.btnIngredientes);
            this.Controls.Add(this.btnRecetaIngredientes);
            this.Controls.Add(this.btnRecetas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnRecetaIngredientes;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Button btnCostoReceta;
        private System.Windows.Forms.Button btnMenuSemanal;
        private System.Windows.Forms.Button btnRegresar;
    }
}