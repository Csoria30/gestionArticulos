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
                cargarImagen(listaArticulos[0].ImagenUrl);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
        private void ocultarColumnas()
        {
            dgvPrincipal.Columns["ImagenUrl"].Visible = false;                
            dgvPrincipal.Columns["DescripcionMarca"].Visible = false;
            dgvPrincipal.Columns["CategoriaMarca"].Visible = false;
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://archive.org/download/placeholder-image/placeholder-image.jpg");
            }
        }

        private void dgvPrincipal_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvPrincipal.CurrentRow != null)
            {
                Articulo articuloSeleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                cargarImagen(articuloSeleccionado.ImagenUrl);
            }
        }
    }
}
