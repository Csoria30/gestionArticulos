using System;
using System.Collections.Generic;
using System.Globalization;
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
                        Precio,
	                    A.IdCategoria,
	                    A.IdMarca

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
                    auxiliar.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    
                    auxiliar.Marca = new Marca();
                    auxiliar.Marca.Id = (int)datos.Lector["IdMarca"];
                    auxiliar.Marca.Descripcion = (string)datos.Lector["Marca"];

                    auxiliar.Categoria= new Categoria();
                    auxiliar.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    auxiliar.Categoria.Descripcion = (string)datos.Lector["Categoria"];

                    auxiliar.Precio = Convert.ToDouble(datos.Lector["Precio"]);

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
    
        public void agregarArticulo(Articulo nuevoArticulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = @"
                    INSERT INTO ARTICULOS (	Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) 
                    VALUES(
	                    @Codigo,
	                    @Nombre,
	                    @Descripcion,
	                    @IdMarca,
	                    @IdCategoria,
	                    @ImagenUrl,
	                    @Precio
                    )
                ";

                datos.setearConsulta(consulta);
                datos.setearParametro("@Codigo", nuevoArticulo.CodigoArticulo);
                datos.setearParametro("@Nombre", nuevoArticulo.Nombre);
                datos.setearParametro("@Descripcion", nuevoArticulo.Descripcion);
                datos.setearParametro("@IdMarca", nuevoArticulo.Marca.Id);
                datos.setearParametro("@IdCategoria", nuevoArticulo.Categoria.Id);
                datos.setearParametro("@ImagenUrl", nuevoArticulo.ImagenUrl);
                datos.setearParametro("@Precio", nuevoArticulo.Precio);

                datos.ejecutarAccion();
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

        public void editarArticulo(Articulo articulo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = @"
                    UPDATE ARTICULOS SET 
	                    Codigo = @Codigo,
	                    Nombre = @Nombre,
	                    Descripcion = @Descripcion,
	                    IdMarca = @IdMarca,
	                    IdCategoria = @IdCategoria,
	                    ImagenUrl = @ImagenUrl,
	                    Precio = @Precio
                    WHERE Id = @Id
                ";

                datos.setearConsulta(consulta);
                datos.setearParametro("@Codigo", articulo.CodigoArticulo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.Marca.Id);
                datos.setearParametro("@IdCategoria", articulo.Marca.Id);
                datos.setearParametro("@ImagenUrl", articulo.ImagenUrl);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.setearParametro("@Id", articulo.Id);

                datos.ejecutarAccion();
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

        public void eliminarArticulo(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "DELETE FROM ARTICULOS WHERE Id = @Id";
                datos.setearConsulta(consulta);
                datos.setearParametro("@Id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    
    }
}
