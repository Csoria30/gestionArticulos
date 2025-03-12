namespace Gestion_Articulos
{
    partial class frmDetallesProducto
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
            this.pbxDetalleImagen = new System.Windows.Forms.PictureBox();
            this.lblDetalleCodigo = new System.Windows.Forms.Label();
            this.gpbDetalleProducto = new System.Windows.Forms.GroupBox();
            this.lblDetallePrecio = new System.Windows.Forms.Label();
            this.lblDetalleCategoria = new System.Windows.Forms.Label();
            this.lblDetalleMarca = new System.Windows.Forms.Label();
            this.lblDetalleNombre = new System.Windows.Forms.Label();
            this.gpbDetalle = new System.Windows.Forms.GroupBox();
            this.btnDetalleCerrar = new System.Windows.Forms.Button();
            this.lblTextDetalleCodigo = new System.Windows.Forms.Label();
            this.lblTextDetalleNombre = new System.Windows.Forms.Label();
            this.lblTextDetalleMarca = new System.Windows.Forms.Label();
            this.lblTextDetalleCategoria = new System.Windows.Forms.Label();
            this.lblTextDetallePrecio = new System.Windows.Forms.Label();
            this.lblTextDetalleDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalleImagen)).BeginInit();
            this.gpbDetalleProducto.SuspendLayout();
            this.gpbDetalle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxDetalleImagen
            // 
            this.pbxDetalleImagen.Location = new System.Drawing.Point(443, 44);
            this.pbxDetalleImagen.Name = "pbxDetalleImagen";
            this.pbxDetalleImagen.Size = new System.Drawing.Size(339, 299);
            this.pbxDetalleImagen.TabIndex = 0;
            this.pbxDetalleImagen.TabStop = false;
            // 
            // lblDetalleCodigo
            // 
            this.lblDetalleCodigo.AutoSize = true;
            this.lblDetalleCodigo.Location = new System.Drawing.Point(16, 39);
            this.lblDetalleCodigo.Name = "lblDetalleCodigo";
            this.lblDetalleCodigo.Size = new System.Drawing.Size(57, 16);
            this.lblDetalleCodigo.TabIndex = 1;
            this.lblDetalleCodigo.Text = "Codigo: ";
            // 
            // gpbDetalleProducto
            // 
            this.gpbDetalleProducto.Controls.Add(this.lblTextDetallePrecio);
            this.gpbDetalleProducto.Controls.Add(this.lblTextDetalleCategoria);
            this.gpbDetalleProducto.Controls.Add(this.lblTextDetalleMarca);
            this.gpbDetalleProducto.Controls.Add(this.lblTextDetalleNombre);
            this.gpbDetalleProducto.Controls.Add(this.lblTextDetalleCodigo);
            this.gpbDetalleProducto.Controls.Add(this.lblDetallePrecio);
            this.gpbDetalleProducto.Controls.Add(this.lblDetalleCategoria);
            this.gpbDetalleProducto.Controls.Add(this.lblDetalleMarca);
            this.gpbDetalleProducto.Controls.Add(this.lblDetalleNombre);
            this.gpbDetalleProducto.Controls.Add(this.lblDetalleCodigo);
            this.gpbDetalleProducto.Location = new System.Drawing.Point(19, 44);
            this.gpbDetalleProducto.Name = "gpbDetalleProducto";
            this.gpbDetalleProducto.Size = new System.Drawing.Size(390, 482);
            this.gpbDetalleProducto.TabIndex = 2;
            this.gpbDetalleProducto.TabStop = false;
            this.gpbDetalleProducto.Text = "Informacion del Producto";
            // 
            // lblDetallePrecio
            // 
            this.lblDetallePrecio.AutoSize = true;
            this.lblDetallePrecio.Location = new System.Drawing.Point(16, 194);
            this.lblDetallePrecio.Name = "lblDetallePrecio";
            this.lblDetallePrecio.Size = new System.Drawing.Size(52, 16);
            this.lblDetallePrecio.TabIndex = 5;
            this.lblDetallePrecio.Text = "Precio: ";
            // 
            // lblDetalleCategoria
            // 
            this.lblDetalleCategoria.AutoSize = true;
            this.lblDetalleCategoria.Location = new System.Drawing.Point(16, 151);
            this.lblDetalleCategoria.Name = "lblDetalleCategoria";
            this.lblDetalleCategoria.Size = new System.Drawing.Size(72, 16);
            this.lblDetalleCategoria.TabIndex = 4;
            this.lblDetalleCategoria.Text = "Categoria: ";
            // 
            // lblDetalleMarca
            // 
            this.lblDetalleMarca.AutoSize = true;
            this.lblDetalleMarca.Location = new System.Drawing.Point(16, 112);
            this.lblDetalleMarca.Name = "lblDetalleMarca";
            this.lblDetalleMarca.Size = new System.Drawing.Size(51, 16);
            this.lblDetalleMarca.TabIndex = 3;
            this.lblDetalleMarca.Text = "Marca: ";
            // 
            // lblDetalleNombre
            // 
            this.lblDetalleNombre.AutoSize = true;
            this.lblDetalleNombre.Location = new System.Drawing.Point(16, 73);
            this.lblDetalleNombre.Name = "lblDetalleNombre";
            this.lblDetalleNombre.Size = new System.Drawing.Size(62, 16);
            this.lblDetalleNombre.TabIndex = 2;
            this.lblDetalleNombre.Text = "Nombre: ";
            // 
            // gpbDetalle
            // 
            this.gpbDetalle.Controls.Add(this.lblTextDetalleDescripcion);
            this.gpbDetalle.Location = new System.Drawing.Point(443, 370);
            this.gpbDetalle.Name = "gpbDetalle";
            this.gpbDetalle.Size = new System.Drawing.Size(339, 156);
            this.gpbDetalle.TabIndex = 3;
            this.gpbDetalle.TabStop = false;
            this.gpbDetalle.Text = "Detalles";
            // 
            // btnDetalleCerrar
            // 
            this.btnDetalleCerrar.Location = new System.Drawing.Point(651, 553);
            this.btnDetalleCerrar.Name = "btnDetalleCerrar";
            this.btnDetalleCerrar.Size = new System.Drawing.Size(131, 47);
            this.btnDetalleCerrar.TabIndex = 4;
            this.btnDetalleCerrar.Text = "Cerrar";
            this.btnDetalleCerrar.UseVisualStyleBackColor = true;
            this.btnDetalleCerrar.Click += new System.EventHandler(this.btnDetalleCerrar_Click);
            // 
            // lblTextDetalleCodigo
            // 
            this.lblTextDetalleCodigo.AutoSize = true;
            this.lblTextDetalleCodigo.Location = new System.Drawing.Point(128, 39);
            this.lblTextDetalleCodigo.Name = "lblTextDetalleCodigo";
            this.lblTextDetalleCodigo.Size = new System.Drawing.Size(0, 16);
            this.lblTextDetalleCodigo.TabIndex = 6;
            // 
            // lblTextDetalleNombre
            // 
            this.lblTextDetalleNombre.AutoSize = true;
            this.lblTextDetalleNombre.Location = new System.Drawing.Point(128, 71);
            this.lblTextDetalleNombre.Name = "lblTextDetalleNombre";
            this.lblTextDetalleNombre.Size = new System.Drawing.Size(0, 16);
            this.lblTextDetalleNombre.TabIndex = 7;
            // 
            // lblTextDetalleMarca
            // 
            this.lblTextDetalleMarca.AutoSize = true;
            this.lblTextDetalleMarca.Location = new System.Drawing.Point(128, 111);
            this.lblTextDetalleMarca.Name = "lblTextDetalleMarca";
            this.lblTextDetalleMarca.Size = new System.Drawing.Size(0, 16);
            this.lblTextDetalleMarca.TabIndex = 8;
            // 
            // lblTextDetalleCategoria
            // 
            this.lblTextDetalleCategoria.AutoSize = true;
            this.lblTextDetalleCategoria.Location = new System.Drawing.Point(128, 149);
            this.lblTextDetalleCategoria.Name = "lblTextDetalleCategoria";
            this.lblTextDetalleCategoria.Size = new System.Drawing.Size(0, 16);
            this.lblTextDetalleCategoria.TabIndex = 9;
            // 
            // lblTextDetallePrecio
            // 
            this.lblTextDetallePrecio.AutoSize = true;
            this.lblTextDetallePrecio.Location = new System.Drawing.Point(128, 194);
            this.lblTextDetallePrecio.Name = "lblTextDetallePrecio";
            this.lblTextDetallePrecio.Size = new System.Drawing.Size(0, 16);
            this.lblTextDetallePrecio.TabIndex = 10;
            // 
            // lblTextDetalleDescripcion
            // 
            this.lblTextDetalleDescripcion.AutoSize = true;
            this.lblTextDetalleDescripcion.Location = new System.Drawing.Point(17, 25);
            this.lblTextDetalleDescripcion.Name = "lblTextDetalleDescripcion";
            this.lblTextDetalleDescripcion.Size = new System.Drawing.Size(0, 16);
            this.lblTextDetalleDescripcion.TabIndex = 11;
            // 
            // frmDetallesProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 612);
            this.Controls.Add(this.btnDetalleCerrar);
            this.Controls.Add(this.gpbDetalle);
            this.Controls.Add(this.gpbDetalleProducto);
            this.Controls.Add(this.pbxDetalleImagen);
            this.Name = "frmDetallesProducto";
            this.Text = "DetallesProducto";
            this.Load += new System.EventHandler(this.frmDetallesProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalleImagen)).EndInit();
            this.gpbDetalleProducto.ResumeLayout(false);
            this.gpbDetalleProducto.PerformLayout();
            this.gpbDetalle.ResumeLayout(false);
            this.gpbDetalle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDetalleImagen;
        private System.Windows.Forms.Label lblDetalleCodigo;
        private System.Windows.Forms.GroupBox gpbDetalleProducto;
        private System.Windows.Forms.Label lblDetalleNombre;
        private System.Windows.Forms.GroupBox gpbDetalle;
        private System.Windows.Forms.Label lblDetalleCategoria;
        private System.Windows.Forms.Label lblDetalleMarca;
        private System.Windows.Forms.Label lblDetallePrecio;
        private System.Windows.Forms.Button btnDetalleCerrar;
        private System.Windows.Forms.Label lblTextDetalleCodigo;
        private System.Windows.Forms.Label lblTextDetalleNombre;
        private System.Windows.Forms.Label lblTextDetallePrecio;
        private System.Windows.Forms.Label lblTextDetalleCategoria;
        private System.Windows.Forms.Label lblTextDetalleMarca;
        private System.Windows.Forms.Label lblTextDetalleDescripcion;
    }
}