namespace EATEASY
{
    partial class FormMenuSemanal
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
            this.cbDia = new System.Windows.Forms.ComboBox();
            this.lstRecetas = new System.Windows.Forms.ListBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.dgvMenu = new System.Windows.Forms.DataGridView();
            this.btnNuevoMenu = new System.Windows.Forms.Button();
            this.cbMenus = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDia
            // 
            this.cbDia.FormattingEnabled = true;
            this.cbDia.Location = new System.Drawing.Point(38, 31);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(121, 24);
            this.cbDia.TabIndex = 0;
            // 
            // lstRecetas
            // 
            this.lstRecetas.FormattingEnabled = true;
            this.lstRecetas.ItemHeight = 16;
            this.lstRecetas.Location = new System.Drawing.Point(38, 78);
            this.lstRecetas.Name = "lstRecetas";
            this.lstRecetas.Size = new System.Drawing.Size(120, 84);
            this.lstRecetas.TabIndex = 1;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(38, 212);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(75, 23);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(232, 12);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(240, 150);
            this.dgvMenu.TabIndex = 3;
            // 
            // btnNuevoMenu
            // 
            this.btnNuevoMenu.Location = new System.Drawing.Point(156, 212);
            this.btnNuevoMenu.Name = "btnNuevoMenu";
            this.btnNuevoMenu.Size = new System.Drawing.Size(133, 45);
            this.btnNuevoMenu.TabIndex = 4;
            this.btnNuevoMenu.Text = "Nuevo Menu";
            this.btnNuevoMenu.UseVisualStyleBackColor = true;
            this.btnNuevoMenu.Click += new System.EventHandler(this.btnNuevoMenu_Click);
            // 
            // cbMenus
            // 
            this.cbMenus.FormattingEnabled = true;
            this.cbMenus.Location = new System.Drawing.Point(312, 177);
            this.cbMenus.Name = "cbMenus";
            this.cbMenus.Size = new System.Drawing.Size(121, 24);
            this.cbMenus.TabIndex = 5;
            this.cbMenus.SelectedIndexChanged += new System.EventHandler(this.cbMenus_SelectedIndexChanged);
            // 
            // FormMenuSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 287);
            this.Controls.Add(this.cbMenus);
            this.Controls.Add(this.btnNuevoMenu);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lstRecetas);
            this.Controls.Add(this.cbDia);
            this.Name = "FormMenuSemanal";
            this.Text = "FormMenuSemanal";
            this.Load += new System.EventHandler(this.FormMenuSemanal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbDia;
        private System.Windows.Forms.ListBox lstRecetas;
        private System.Windows.Forms.Button btnAsignar;
        private System.Windows.Forms.DataGridView dgvMenu;
        private System.Windows.Forms.Button btnNuevoMenu;
        private System.Windows.Forms.ComboBox cbMenus;
    }
}