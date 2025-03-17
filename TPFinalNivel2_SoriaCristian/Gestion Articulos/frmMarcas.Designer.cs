namespace Gestion_Articulos
{
    partial class frmMarcas
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
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnMarcaAgregar = new System.Windows.Forms.Button();
            this.btnMarcaEditar = new System.Windows.Forms.Button();
            this.btnMarcaEliminar = new System.Windows.Forms.Button();
            this.btnMarcaCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvMarcas.Location = new System.Drawing.Point(25, 22);
            this.dgvMarcas.MultiSelect = false;
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMarcas.Size = new System.Drawing.Size(428, 280);
            this.dgvMarcas.TabIndex = 0;
            this.dgvMarcas.SelectionChanged += new System.EventHandler(this.dgvMarcas_SelectionChanged);
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(515, 43);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(51, 16);
            this.lblMarca.TabIndex = 1;
            this.lblMarca.Text = "Marca: ";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(570, 40);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(260, 22);
            this.txtDescripcion.TabIndex = 2;
            // 
            // btnMarcaAgregar
            // 
            this.btnMarcaAgregar.Location = new System.Drawing.Point(518, 114);
            this.btnMarcaAgregar.Name = "btnMarcaAgregar";
            this.btnMarcaAgregar.Size = new System.Drawing.Size(105, 32);
            this.btnMarcaAgregar.TabIndex = 3;
            this.btnMarcaAgregar.Text = "Agregar";
            this.btnMarcaAgregar.UseVisualStyleBackColor = true;
            this.btnMarcaAgregar.Click += new System.EventHandler(this.btnMarcaAgregar_Click);
            // 
            // btnMarcaEditar
            // 
            this.btnMarcaEditar.Location = new System.Drawing.Point(629, 114);
            this.btnMarcaEditar.Name = "btnMarcaEditar";
            this.btnMarcaEditar.Size = new System.Drawing.Size(105, 32);
            this.btnMarcaEditar.TabIndex = 4;
            this.btnMarcaEditar.Text = "Guardar";
            this.btnMarcaEditar.UseVisualStyleBackColor = true;
            this.btnMarcaEditar.Click += new System.EventHandler(this.btnMarcaEditar_Click);
            // 
            // btnMarcaEliminar
            // 
            this.btnMarcaEliminar.Location = new System.Drawing.Point(740, 114);
            this.btnMarcaEliminar.Name = "btnMarcaEliminar";
            this.btnMarcaEliminar.Size = new System.Drawing.Size(105, 32);
            this.btnMarcaEliminar.TabIndex = 5;
            this.btnMarcaEliminar.Text = "Eliminar";
            this.btnMarcaEliminar.UseVisualStyleBackColor = true;
            this.btnMarcaEliminar.Click += new System.EventHandler(this.btnMarcaEliminar_Click);
            // 
            // btnMarcaCancelar
            // 
            this.btnMarcaCancelar.Location = new System.Drawing.Point(725, 270);
            this.btnMarcaCancelar.Name = "btnMarcaCancelar";
            this.btnMarcaCancelar.Size = new System.Drawing.Size(105, 32);
            this.btnMarcaCancelar.TabIndex = 6;
            this.btnMarcaCancelar.Text = "Cancelar";
            this.btnMarcaCancelar.UseVisualStyleBackColor = true;
            this.btnMarcaCancelar.Click += new System.EventHandler(this.btnMarcaCancelar_Click);
            // 
            // frmMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(865, 384);
            this.Controls.Add(this.btnMarcaCancelar);
            this.Controls.Add(this.btnMarcaEliminar);
            this.Controls.Add(this.btnMarcaEditar);
            this.Controls.Add(this.btnMarcaAgregar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.dgvMarcas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marcas";
            this.Load += new System.EventHandler(this.frmMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMarcas;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnMarcaAgregar;
        private System.Windows.Forms.Button btnMarcaEditar;
        private System.Windows.Forms.Button btnMarcaEliminar;
        private System.Windows.Forms.Button btnMarcaCancelar;
    }
}