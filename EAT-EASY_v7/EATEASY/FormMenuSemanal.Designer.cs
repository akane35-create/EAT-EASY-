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
            this.cbDia.Location = new System.Drawing.Point(28, 25);
            this.cbDia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbDia.Name = "cbDia";
            this.cbDia.Size = new System.Drawing.Size(168, 21);
            this.cbDia.TabIndex = 0;
            // 
            // lstRecetas
            // 
            this.lstRecetas.FormattingEnabled = true;
            this.lstRecetas.Location = new System.Drawing.Point(28, 63);
            this.lstRecetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstRecetas.Name = "lstRecetas";
            this.lstRecetas.Size = new System.Drawing.Size(168, 69);
            this.lstRecetas.TabIndex = 1;
            // 
            // btnAsignar
            // 
            this.btnAsignar.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignar.Location = new System.Drawing.Point(188, 168);
            this.btnAsignar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(108, 41);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // dgvMenu
            // 
            this.dgvMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMenu.Location = new System.Drawing.Point(416, 13);
            this.dgvMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvMenu.Name = "dgvMenu";
            this.dgvMenu.RowTemplate.Height = 24;
            this.dgvMenu.Size = new System.Drawing.Size(230, 122);
            this.dgvMenu.TabIndex = 3;
            // 
            // btnNuevoMenu
            // 
            this.btnNuevoMenu.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoMenu.Location = new System.Drawing.Point(28, 164);
            this.btnNuevoMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoMenu.Name = "btnNuevoMenu";
            this.btnNuevoMenu.Size = new System.Drawing.Size(126, 78);
            this.btnNuevoMenu.TabIndex = 4;
            this.btnNuevoMenu.Text = "Nuevo Menu";
            this.btnNuevoMenu.UseVisualStyleBackColor = true;
            this.btnNuevoMenu.Click += new System.EventHandler(this.btnNuevoMenu_Click);
            // 
            // cbMenus
            // 
            this.cbMenus.FormattingEnabled = true;
            this.cbMenus.Location = new System.Drawing.Point(416, 181);
            this.cbMenus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMenus.Name = "cbMenus";
            this.cbMenus.Size = new System.Drawing.Size(231, 21);
            this.cbMenus.TabIndex = 5;
            this.cbMenus.SelectedIndexChanged += new System.EventHandler(this.cbMenus_SelectedIndexChanged);
            // 
            // FormMenuSemanal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 253);
            this.Controls.Add(this.cbMenus);
            this.Controls.Add(this.btnNuevoMenu);
            this.Controls.Add(this.dgvMenu);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.lstRecetas);
            this.Controls.Add(this.cbDia);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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