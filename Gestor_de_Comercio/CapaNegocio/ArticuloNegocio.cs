using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDominio;
using CapaDatos;

namespace CapaNegocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where IdMarca = M.Id and IdCategoria = C.Id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.marcaArticulo = new Marca();
                    aux.marcaArticulo.Id = (int)datos.Lector["IdMarca"];
                    aux.marcaArticulo.Descripcion = (string)datos.Lector["Marca"];
                    aux.categoriaArticulo = new Categoria();
                    aux.categoriaArticulo.Id = (int)datos.Lector["IdCategoria"];
                    aux.categoriaArticulo.Descripcion = (string)datos.Lector["Categoria"];

                    if(!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
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

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into ARTICULOS(Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) values('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', @idMarca, @idCategoria, '" + nuevo.ImagenUrl + "', " + nuevo.Precio + ")");
                datos.setearParametro("@idCategoria",  nuevo.categoriaArticulo.Id);
                datos.setearParametro("@idMarca", nuevo.marcaArticulo.Id);
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

        public void modificar(Articulo modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descr, IdMarca = @idMarca, IdCategoria = @idCategoria, ImagenUrl = @img, Precio = @precio where Id = @id");
                datos.setearParametro("@codigo", modificar.Codigo);
                datos.setearParametro("@nombre", modificar.Nombre);
                datos.setearParametro("@descr", modificar.Descripcion);
                datos.setearParametro("@idMarca", modificar.marcaArticulo.Id);
                datos.setearParametro("@idCategoria", modificar.categoriaArticulo.Id);
                datos.setearParametro("@img", modificar.ImagenUrl);
                datos.setearParametro("@precio", modificar.Precio);
                datos.setearParametro("@id", modificar.Id);

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

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("delete from ARTICULOS where Id = @id");
                datos.setearParametro("@id", id);
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

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, Precio, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C where IdMarca = M.Id and IdCategoria = C.Id";

                if (!(string.IsNullOrEmpty(filtro)))
                {
                    consulta += " and ";

                    switch (campo)
                    {
                        case "Precio":
                            switch (criterio)
                            {
                                case "Menor a":
                                    consulta += "Precio < @precio";
                                    datos.setearParametro("@precio", filtro);
                                    break;
                                case "Mayor a":
                                    consulta += "Precio > @precio";
                                    datos.setearParametro("@precio", filtro);
                                    break;
                                case "Igual a":
                                    consulta += "Precio = @filtro";
                                    datos.setearParametro("@precio", filtro);
                                    break;
                                default:
                                    break;
                            }
                            break;

                        case "Categoria":
                            switch (criterio)
                            {
                                case "Comienza con":
                                    consulta += "C.Descripcion like @filtro";
                                    datos.setearParametro("@filtro", filtro + "%");
                                    break;
                                case "Termina con":
                                    consulta += "C.Descripcion like @filtro";
                                    datos.setearParametro("@filtro", "%" + filtro);
                                    break;
                                case "Contiene":
                                    consulta += "C.Descripcion like @filtro";
                                    datos.setearParametro("@filtro", "%" + filtro + "%");
                                    break;
                                default:
                                    break;
                            }
                            break;

                        case "Marca":
                            switch (criterio)
                            {
                                case "Comienza con":
                                    consulta += "M.Descripcion like @filtro";
                                    datos.setearParametro("@filtro", filtro + "%");
                                    break;
                                case "Termina con":
                                    consulta += "M.Descripcion like @filtro";
                                    datos.setearParametro("@filtro", "%" + "%" + filtro);
                                    break;
                                case "Contiene":
                                    consulta += "M.Descripcion like @filtro";
                                    datos.setearParametro("@filtro", "%" + filtro + "%");
                                    break;
                                default:
                                    break;
                            }
                            break;

                        default:
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.marcaArticulo = new Marca();
                    aux.marcaArticulo.Id = (int)datos.Lector["IdMarca"];
                    aux.marcaArticulo.Descripcion = (string)datos.Lector["Marca"];
                    aux.categoriaArticulo = new Categoria();
                    aux.categoriaArticulo.Id = (int)datos.Lector["IdCategoria"];
                    aux.categoriaArticulo.Descripcion = (string)datos.Lector["Categoria"];

                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);
                }

                return lista;
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
