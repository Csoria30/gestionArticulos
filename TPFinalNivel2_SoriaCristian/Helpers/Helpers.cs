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

        public static void MostrarMensaje(EstadoMensaje estadoMensaje, Articulo articulo = null)
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

    }
}
