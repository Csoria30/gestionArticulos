using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;
using helpers;

namespace Gestion_Articulos
{
    public partial class frmDetallesProducto: Form
    {
        private Articulo articulo = null;
        private ArticuloNegocio negocio = new ArticuloNegocio();

        public frmDetallesProducto()
        {
            InitializeComponent();
        }

        public frmDetallesProducto(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalles del producto";
        }

        private void btnDetalleCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDetallesProducto_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                lblTextDetalleCodigo.Text = articulo.CodigoArticulo;
                lblTextDetalleNombre.Text = articulo.Nombre;
                lblTextDetalleMarca.Text = articulo.Marca.Descripcion;
                lblTextDetalleCategoria.Text = articulo.Categoria.Descripcion;
                lblTextDetallePrecio.Text = articulo.Precio.ToString();
                lblTextDetalleDescripcion.Text = articulo.Descripcion;

                Helpers.CargarImagen(articulo.ImagenUrl, pbxDetalleImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
