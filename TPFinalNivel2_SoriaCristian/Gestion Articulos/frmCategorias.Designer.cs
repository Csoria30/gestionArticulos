namespace Gestion_Articulos
{
    partial class frmCategorias
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
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.txtDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.btnCarAgregar = new System.Windows.Forms.Button();
            this.btnCatEditar = new System.Windows.Forms.Button();
            this.btnCarEliminar = new System.Windows.Forms.Button();
            this.btnCatCacelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoria.Location = new System.Drawing.Point(35, 32);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowHeadersWidth = 51;
            this.dgvCategoria.RowTemplate.Height = 24;
            this.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoria.Size = new System.Drawing.Size(404, 258);
            this.dgvCategoria.TabIndex = 0;
            this.dgvCategoria.SelectionChanged += new System.EventHandler(this.dgvCategoria_SelectionChanged);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(484, 58);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(72, 16);
            this.lblCategorias.TabIndex = 1;
            this.lblCategorias.Text = "Categoria: ";
            // 
            // txtDescripcionCategoria
            // 
            this.txtDescripcionCategoria.Location = new System.Drawing.Point(560, 53);
            this.txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            this.txtDescripcionCategoria.Size = new System.Drawing.Size(283, 22);
            this.txtDescripcionCategoria.TabIndex = 2;
            // 
            // btnCarAgregar
            // 
            this.btnCarAgregar.Location = new System.Drawing.Point(487, 108);
            this.btnCarAgregar.Name = "btnCarAgregar";
            this.btnCarAgregar.Size = new System.Drawing.Size(101, 31);
            this.btnCarAgregar.TabIndex = 3;
            this.btnCarAgregar.Text = "Agregar";
            this.btnCarAgregar.UseVisualStyleBackColor = true;
            this.btnCarAgregar.Click += new System.EventHandler(this.btnCarAgregar_Click);
            // 
            // btnCatEditar
            // 
            this.btnCatEditar.Location = new System.Drawing.Point(618, 108);
            this.btnCatEditar.Name = "btnCatEditar";
            this.btnCatEditar.Size = new System.Drawing.Size(101, 31);
            this.btnCatEditar.TabIndex = 4;
            this.btnCatEditar.Text = "Guardar";
            this.btnCatEditar.UseVisualStyleBackColor = true;
            this.btnCatEditar.Click += new System.EventHandler(this.btnCatEditar_Click);
            // 
            // btnCarEliminar
            // 
            this.btnCarEliminar.Location = new System.Drawing.Point(742, 108);
            this.btnCarEliminar.Name = "btnCarEliminar";
            this.btnCarEliminar.Size = new System.Drawing.Size(101, 31);
            this.btnCarEliminar.TabIndex = 5;
            this.btnCarEliminar.Text = "Eliminar";
            this.btnCarEliminar.UseVisualStyleBackColor = true;
            this.btnCarEliminar.Click += new System.EventHandler(this.btnCarEliminar_Click);
            // 
            // btnCatCacelar
            // 
            this.btnCatCacelar.Location = new System.Drawing.Point(755, 259);
            this.btnCatCacelar.Name = "btnCatCacelar";
            this.btnCatCacelar.Size = new System.Drawing.Size(101, 31);
            this.btnCatCacelar.TabIndex = 6;
            this.btnCatCacelar.Text = "Cancelar";
            this.btnCatCacelar.UseVisualStyleBackColor = true;
            this.btnCatCacelar.Click += new System.EventHandler(this.btnCatCacelar_Click);
            // 
            // frmCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(877, 355);
            this.Controls.Add(this.btnCatCacelar);
            this.Controls.Add(this.btnCarEliminar);
            this.Controls.Add(this.btnCatEditar);
            this.Controls.Add(this.btnCarAgregar);
            this.Controls.Add(this.txtDescripcionCategoria);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.dgvCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categiruas";
            this.Load += new System.EventHandler(this.frmCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.TextBox txtDescripcionCategoria;
        private System.Windows.Forms.Button btnCarAgregar;
        private System.Windows.Forms.Button btnCatEditar;
        private System.Windows.Forms.Button btnCarEliminar;
        private System.Windows.Forms.Button btnCatCacelar;
    }
}