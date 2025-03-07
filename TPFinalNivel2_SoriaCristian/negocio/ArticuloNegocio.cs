using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = @"
                    SELECT 
                        A.Id, 
                        Codigo, 
                        Nombre, 
                        A.Descripcion, 
                        ImagenUrl, 
                        M.Descripcion Marca, 
                        C.Descripcion Categoria, 
                        Precio 

                    FROM ARTICULOS A
                        JOIN MARCAS M ON A.IdMarca = M.Id
                        JOIN CATEGORIAS C ON A.IdCategoria = C.Id
                ";

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo auxiliar = new Articulo();
                    auxiliar.Id = (int)datos.Lector["Id"];
                    auxiliar.CodigoArticulo = (string)datos.Lector["Codigo"];
                    auxiliar.Nombre = (string)datos.Lector["Nombre"];
                    auxiliar.Descripcion = (string)datos.Lector["Descripcion"];
                    auxiliar.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    
                    auxiliar.DescripcionMarca = new Marca();
                    auxiliar.DescripcionMarca.Descripcion = (string)datos.Lector["Marca"];

                    auxiliar.CategoriaMarca = new Categoria();
                    auxiliar.CategoriaMarca.Descripcion = (string)datos.Lector["Categoria"];

                    auxiliar.precio = Convert.ToDouble(datos.Lector["Precio"]);

                    listaArticulos.Add(auxiliar);
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
