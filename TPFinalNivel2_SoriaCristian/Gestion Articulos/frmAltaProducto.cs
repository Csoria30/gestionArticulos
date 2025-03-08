﻿using System;
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

        private void frmAltaProducto_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();

            try
            {
                cboMarca.DataSource = marcaNegocio.listar();
                cboCategoria.DataSource = categoriaNegocio.listar();
                
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

                articulo.CodigoArticulo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.ImagenUrl = txtImagen.Text;
                articulo.Marca = (Marca)cboMarca.SelectedItem;
                articulo.Categoria = (Categoria)cboCategoria.SelectedItem;
                articulo.precio = float.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                {

                }
                else
                {
                    negocio.agregarArticulo(articulo);
                    MessageBox.Show("Articulo agregado exitosamente!");
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
