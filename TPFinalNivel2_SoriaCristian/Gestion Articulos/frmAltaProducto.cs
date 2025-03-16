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
    public partial class frmAltaProducto : Form
    {
        private Articulo articulo = null;
        private ArticuloNegocio negocio = new ArticuloNegocio();


        public frmAltaProducto()
        {
            InitializeComponent();
        }

        public frmAltaProducto(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboMarca.ValueMember = "Id";
                cboMarca.DisplayMember = "Descripcion";

                cboCategoria.DataSource = categoriaNegocio.listar();
                cboCategoria.ValueMember = "Id";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.CodigoArticulo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;

                    cboMarca.SelectedValue = articulo.Marca.Id;
                    cboCategoria.SelectedValue = articulo.Categoria.Id;
                    
                    txtImagen.Text = articulo.ImagenUrl;
                    Helpers.CargarImagen(articulo.ImagenUrl, pbxArticulo);

                    txtPrecio.Text = articulo.Precio.ToString();
                    
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAltaCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAltaAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                // Validacion de campos vacios
                var controles = new[] { txtCodigo, txtNombre, txtDescripcion, txtImagen, txtPrecio };

                if (!Helpers.ValidarCampos(controles, this))
                {
                    this.DialogResult = DialogResult.None; // Evita que el formulario se cierre
                    return;
                }
                else
                {
                    
                    articulo.CodigoArticulo = txtCodigo.Text;
                    articulo.Nombre = txtNombre.Text;
                    articulo.Descripcion = txtDescripcion.Text;
                    articulo.ImagenUrl = txtImagen.Text;
                    articulo.Marca = (Marca)cboMarca.SelectedItem;
                    articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                    articulo.Precio = float.Parse(txtPrecio.Text);

                    this.DialogResult = DialogResult.OK; // Cierra el formulario con resultado OK
                }


                if (articulo.Id != 0)
                {
                    negocio.editarArticulo(articulo);
                    Helpers.MostrarMensaje(Helpers.EstadoMensaje.RegistroEditado);
                }
                else
                {
                    negocio.agregarArticulo(articulo);
                    Helpers.MostrarMensaje(Helpers.EstadoMensaje.RegistroAgregado);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                Close();
            }
        }


    }
}
