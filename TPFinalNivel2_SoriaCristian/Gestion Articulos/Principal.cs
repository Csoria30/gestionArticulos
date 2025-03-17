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
        private ArticuloNegocio negocio = new ArticuloNegocio();
        public Presentacion()
        {
            InitializeComponent();
        }

        private void Presentacion_Load(object sender, EventArgs e)
        {
            cargarArticulos();
            cboTipo.Items.Add("Precio");
            cboTipo.Items.Add("Nombre");
            cboTipo.Items.Add("Descripcion");
        }

        private void cargarArticulos()
        {
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
            dgvPrincipal.Columns["Id"].Visible = false;
            dgvPrincipal.Columns["ImagenUrl"].Visible = false;                
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            try
            { 
                string msg = "¿Esta seguro que desea eliminar este articulo?";
                string titulo = "Eliminar Articulo";

                DialogResult respuesta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvPrincipal.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionado.Id);
                    Helpers.MostrarMensaje(Helpers.EstadoMensaje.RegistroEliminado);
                    cargarArticulos();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtFiltroRapido.Text;
            List<Articulo> listaFiltrada = Helpers.FiltrarArticulos(listaArticulos, filtro);

            dgvPrincipal.DataSource = null;
            dgvPrincipal.DataSource = listaFiltrada;
            ocultarColumnas();

        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboTipo.SelectedItem.ToString();

            if(opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private bool  validarFiltro()
        {
            if(cboTipo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un campo para filtrar");
                return true;
            }
            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor seleccione un campo para filtrar");
                return true;
            }
            if(cboTipo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Debe completar el campo buscar");
                    return true;
                }
                if (!(Helpers.soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Debe ingresar solo numeros");
                    return true;
                }
            }
            if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
            {
                MessageBox.Show("El campo filtro no puede estar vacio");
                return true;
            }

            return false;
        }


        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            try
            {
                if (validarFiltro())
                    return;

                string tipo = cboTipo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvPrincipal.DataSource = negocio.filtroAvanzado(tipo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmMarcas marcas = new frmMarcas();
            marcas.ShowDialog();
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            frmCategorias categorias = new frmCategorias();
            categorias.ShowDialog();
        }
    }
}
