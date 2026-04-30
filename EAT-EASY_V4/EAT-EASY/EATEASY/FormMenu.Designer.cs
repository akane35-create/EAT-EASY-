namespace EATEASY
{
    partial class FormMenu
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
            this.btnIngredientes = new System.Windows.Forms.Button();
            this.btnRelacion = new System.Windows.Forms.Button();
            this.btnCosto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRecetas
            // 
            this.btnRecetas.Location = new System.Drawing.Point(8, 12);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(75, 23);
            this.btnRecetas.TabIndex = 0;
            this.btnRecetas.Text = "Recetas";
            this.btnRecetas.UseVisualStyleBackColor = true;
            this.btnRecetas.Click += new System.EventHandler(this.btnRecetas_Click);
            // 
            // btnIngredientes
            // 
            this.btnIngredientes.Location = new System.Drawing.Point(8, 49);
            this.btnIngredientes.Name = "btnIngredientes";
            this.btnIngredientes.Size = new System.Drawing.Size(75, 23);
            this.btnIngredientes.TabIndex = 1;
            this.btnIngredientes.Text = "Ingredientes";
            this.btnIngredientes.UseVisualStyleBackColor = true;
            this.btnIngredientes.Click += new System.EventHandler(this.btnIngredientes_Click);
            // 
            // btnRelacion
            // 
            this.btnRelacion.Location = new System.Drawing.Point(8, 103);
            this.btnRelacion.Name = "btnRelacion";
            this.btnRelacion.Size = new System.Drawing.Size(75, 23);
            this.btnRelacion.TabIndex = 2;
            this.btnRelacion.Text = "Relacion";
            this.btnRelacion.UseVisualStyleBackColor = true;
            this.btnRelacion.Click += new System.EventHandler(this.btnRelacion_Click);
            // 
            // btnCosto
            // 
            this.btnCosto.Location = new System.Drawing.Point(12, 160);
            this.btnCosto.Name = "btnCosto";
            this.btnCosto.Size = new System.Drawing.Size(75, 23);
            this.btnCosto.TabIndex = 3;
            this.btnCosto.Text = "Costo";
            this.btnCosto.UseVisualStyleBackColor = true;
            this.btnCosto.Click += new System.EventHandler(this.btnCosto_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.btnCosto);
            this.Controls.Add(this.btnRelacion);
            this.Controls.Add(this.btnIngredientes);
            this.Controls.Add(this.btnRecetas);
            this.Name = "FormMenu";
            this.Text = "FormMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnIngredientes;
        private System.Windows.Forms.Button btnRelacion;
        private System.Windows.Forms.Button btnCosto;
    }
}