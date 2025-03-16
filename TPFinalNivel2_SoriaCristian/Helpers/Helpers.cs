using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Net.Configuration;
using dominio;

namespace helpers
{
    public static class Helpers
    {
        // Método para cargar una imagen en un PictureBox
        public static void CargarImagen(string rutaImagen, PictureBox pictureBox)
        {
            try
            {
                pictureBox.Load(rutaImagen);
            }
            catch (Exception ex)
            {
                pictureBox.Load("https://archive.org/download/placeholder-image/placeholder-image.jpg");
            }
        }

        //Mensajes 
        public enum EstadoMensaje
        {
            RegistroAgregado,
            RegistroEditado,
            RegistroEliminado
        }

        public static void MostrarMensaje(EstadoMensaje estadoMensaje)
        {
            string titulo = "";
            string mensaje = "";

            switch (estadoMensaje)
            {
                case EstadoMensaje.RegistroAgregado:
                    titulo = "Registro Agregado";
                    mensaje = "Registro agregado correctamente";
                    MessageBox.Show(mensaje, titulo);
                    break;
                case EstadoMensaje.RegistroEditado:
                    titulo = "Registro Editado";
                    mensaje = "Registro editado correctamente";
                    MessageBox.Show(mensaje, titulo);
                    break;
                case EstadoMensaje.RegistroEliminado:
                    titulo = "Registro Eliminado";
                    mensaje = "Registro eliminado correctamente";
                    MessageBox.Show(mensaje, titulo);
                    break;
            }
        }

        //Filtrado de datos
        public static List<Articulo> FiltrarArticulos(List<Articulo> listaArticulos, string filtro)
        {
            if (string.IsNullOrEmpty(filtro) || filtro.Length <= 2)
            {
                return listaArticulos;
            }

            return listaArticulos.FindAll(x =>
                x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) ||
                x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) ||
                x.Nombre.ToUpper().Contains(filtro.ToUpper())
            );
        }
    
        //Validaciones comunes
        public static bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        public static bool ValidarCampos(TextBox[] controles, Form formulario)
        {
            foreach (var control in controles)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    formulario.Invoke(new Action(() =>
                    {
                        MessageBox.Show($"El campo {control.Name} no puede estar vacío.",
                                          "Error",
                                          MessageBoxButtons.OK,
                                          MessageBoxIcon.Error,
                                          MessageBoxDefaultButton.Button1);
                        control.Select();
                        control.Focus();
                    }));
                    return false;
                }
            }
            return true;
        }

    }
}
