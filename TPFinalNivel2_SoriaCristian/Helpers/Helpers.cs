using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
