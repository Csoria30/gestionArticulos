using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;
using helpers;

namespace Gestion_Articulos
{
    public partial class Presentacion : Form
    {
        private List<Articulo> listaArticulos;
        public Presentacion()
        {
            InitializeComponent();
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
            cargarArticulos();
        }

        private void cargarArticulos()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvPrincipal.DataSource = listaArticulos;
                ocultarColumnas();
                Helpers.CargarImagen(listaArticulos[0].ImagenUrl, pbxArticulo);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
        private void ocultarColumnas()
        {
            dgvPrincipal.Columns["ImagenUrl"].Visible = false;                
            dgvPrincipal.Columns["Marca"].Visible = false;
            dgvPrincipal.Columns["Categoria"].Visible = false;
        }


        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPrincipal.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                Helpers.CargarImagen(articuloSeleccionado.ImagenUrl, pbxArticulo);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaProducto altaArticulo = new frmAltaProducto();
            altaArticulo.ShowDialog();
            cargarArticulos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;

            frmAltaProducto modificar = new frmAltaProducto(seleccionado);
            modificar.ShowDialog();
            cargarArticulos();
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;

            frmDetallesProducto detalles = new frmDetallesProducto(seleccionado);
            detalles.ShowDialog();
        }
    }
}
