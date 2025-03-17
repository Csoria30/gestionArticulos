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
using helpers;
using negocio;

namespace Gestion_Articulos
{
    public partial class frmCategorias: Form
    {
        private List<Categoria> listaCategorias;
        private CategoriaNegocio negocio = new CategoriaNegocio();

        public frmCategorias()
        {
            InitializeComponent();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            cargarCategorias();
        }
        private void ocultarColumnas()
        {
            dgvCategoria.Columns["Id"].Visible = false;
        }

        private void cargarCategorias()
        {
            try
            {
                listaCategorias = negocio.listar();
                dgvCategoria.DataSource = listaCategorias;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnCarAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoria = new Categoria();
                categoria.Descripcion = txtDescripcionCategoria.Text;
                negocio.agregarCategoria(categoria);
                //txtDescripcionCategoria.Clear();

                Helpers.MostrarMensaje(Helpers.EstadoMensaje.RegistroAgregado);
                cargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCatCacelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCatEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCategoria.SelectedRows.Count > 0)
                {
                    Categoria seleccionada = (Categoria)dgvCategoria.SelectedRows[0].DataBoundItem;
                    seleccionada.Descripcion = txtDescripcionCategoria.Text;
                    negocio.editarCategoria(seleccionada);
                    Helpers.MostrarMensaje(Helpers.EstadoMensaje.RegistroEditado);
                    txtDescripcionCategoria.Clear();
                    cargarCategorias();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCategoria.SelectedRows.Count > 0)
            {
                Categoria categoriaSeleccionada = (Categoria)dgvCategoria.SelectedRows[0].DataBoundItem;
                txtDescripcionCategoria.Text = categoriaSeleccionada.Descripcion;
            }
        }

        private void btnCarEliminar_Click(object sender, EventArgs e)
        {
            Categoria seleccionada;
            try
            {
                string msg = "¿Esta seguro que desea eliminar esta categoria?";
                string titulo = "Eliminar Categoria";

                DialogResult respuesta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Categoria)dgvCategoria.CurrentRow.DataBoundItem;
                    negocio.elimiarCategoria(seleccionada.Id);
                    Helpers.MostrarMensaje(Helpers.EstadoMensaje.RegistroEliminado);
                    cargarCategorias();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
