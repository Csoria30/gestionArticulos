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
    public partial class frmMarcas: Form
    {
        //private Marca marca = null;
        private List<Marca> listaMarcas;
        private MarcaNegocio negocio = new MarcaNegocio();

        public frmMarcas()
        {
            InitializeComponent();
        }

        private void frmMarcas_Load(object sender, EventArgs e)
        {
            cargarMarcas();
        }

        private void cargarMarcas()
        {
            try
            {
                listaMarcas = negocio.listar();
                dgvMarcas.DataSource = listaMarcas;
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void ocultarColumnas()
        {
            dgvMarcas.Columns["Id"].Visible = false;
        }

        private void btnMarcaAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Marca marca = new Marca();
                marca.Descripcion = txtDescripcion.Text;
                negocio.agregarMarca(marca);
                txtDescripcion.Clear();

                Helpers.MostrarMensaje(Helpers.EstadoMensaje.RegistroAgregado);
                cargarMarcas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMarcaEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvMarcas.SelectedRows.Count > 0)
                {
                    Marca seleccionada = (Marca)dgvMarcas.SelectedRows[0].DataBoundItem;
                    seleccionada.Descripcion = txtDescripcion.Text;
                    negocio.editarMarca(seleccionada);
                    Helpers.MostrarMensaje(Helpers.EstadoMensaje.RegistroEditado);
                    cargarMarcas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnMarcaEliminar_Click(object sender, EventArgs e)
        {
            Marca seleccionada;
            try
            {
                string msg = "¿Esta seguro que desea eliminar esta marca?";
                string titulo = "Eliminar Marca";

                DialogResult respuesta = MessageBox.Show(msg, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (respuesta == DialogResult.Yes)
                {
                    seleccionada = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
                    negocio.eliminarMarca(seleccionada.Id);
                    Helpers.MostrarMensaje(Helpers.EstadoMensaje.RegistroEliminado);
                    cargarMarcas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvMarcas_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMarcas.SelectedRows.Count > 0)
            {
                Marca marcaSeleccionada = (Marca)dgvMarcas.SelectedRows[0].DataBoundItem;
                txtDescripcion.Text = marcaSeleccionada.Descripcion;
            }
        }

        private void btnMarcaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
