using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaDominio;
using CapaNegocio;

namespace Gestor_eCommerce_WebApp
{
    public partial class ArticuloForm : System.Web.UI.Page
    {
        public string user { get; set; }
        public string password { get; set; }
        public bool ConfirmaEliminacion { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            txtBoxId.Enabled = false;
            ConfirmaEliminacion = false;

            if (Session["user"] != null)
            {
                //Recuperamos los datos de Session
                user = Session["user"].ToString();
                password = Session["pass"].ToString();
            }
            else
            {
                user = "";
                Response.Redirect("Login.aspx", false);
                return;
            }

            try
            {
                //Configuración inicial.
                if (!IsPostBack)
                {
                    MarcaNegocio marcaNegocio = new MarcaNegocio();
                    ddlMarca.DataSource = marcaNegocio.listar(); // Trae la lista de objetos Marca desde la DB
                    ddlMarca.DataTextField = "Descripcion"; // Lo que ve el usuario en pantalla
                    ddlMarca.DataValueField = "Id";         // El ID real que se guarda por detrás
                    ddlMarca.DataBind();

                    CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
                    ddlCategoria.DataSource = categoriaNegocio.listar();
                    ddlCategoria.DataTextField = "Descripcion";
                    ddlCategoria.DataValueField = "Id";
                    ddlCategoria.DataBind();

                    btnAgregar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;

                    //Configuración si estamos modificando.
                    string id = Request.QueryString["id"] != null ? Request.QueryString["id"].ToString() : "";
                    if (id != "") //Valida si viene del Seleccionar(manito indice) o no
                    {
                        ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                        //List<Articulo> lista = articuloNegocio.listar(id);
                        //Articulo seleccionado = lista[0];
                        Articulo seleccionado = (articuloNegocio.listar(id))[0]; //Versión resumida

                        if (seleccionado != null)
                        {
                            txtBoxCodigo.Text = seleccionado.Codigo;
                            txtBoxNombre.Text = seleccionado.Nombre;
                            txtBoxDescripcion.Text = seleccionado.Descripcion;
                            ddlMarca.SelectedValue = seleccionado.marcaArticulo.Descripcion;
                            ddlCategoria.SelectedValue = seleccionado.categoriaArticulo.Descripcion;
                            txtBoxImagen.Text = seleccionado.ImagenUrl;
                            txtBoxPrecio.Text = seleccionado.Precio.ToString();
                            txtBoxId.Text = seleccionado.Id.ToString();
                            txtBoxImagen_TextChanged(sender, e); //Forzamos para recargar la imagen.

                            btnAgregar.Enabled = false;
                            btnModificar.Enabled = true;
                            btnEliminar.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
                //Redirección a pantalla de error.
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                Articulo articuloNuevo = new Articulo();

                //Property Id se generará en DB.
                articuloNuevo.Codigo = txtBoxCodigo.Text;
                articuloNuevo.Nombre = txtBoxNombre.Text;
                articuloNuevo.Descripcion = txtBoxDescripcion.Text;
                articuloNuevo.categoriaArticulo = new Categoria();
                articuloNuevo.categoriaArticulo.Id = int.Parse(ddlCategoria.SelectedValue);
                articuloNuevo.marcaArticulo = new Marca();
                articuloNuevo.marcaArticulo.Id = int.Parse(ddlMarca.SelectedValue);
                articuloNuevo.ImagenUrl = txtBoxImagen.Text;
                if (imagenArticulo == null)
                    articuloNuevo.ImagenUrl = "https://www.neuco.com/assets/img/product-placeholder.webp";

                //articulo.Precio = decimal.Parse(txtBoxPrecio.Text);
                if (decimal.TryParse(txtBoxPrecio.Text, out decimal precioConvertido))
                    articuloNuevo.Precio = precioConvertido;

                articuloNegocio.agregarConSP(articuloNuevo);
                Response.Redirect("ArticulosLista.aspx", false);
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
                //Redirección a pantalla de error.
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxId.Text, out int idBuscado))
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                Articulo seleccionado = articuloNegocio.listar().Find(x => x.Id == idBuscado);

                if (seleccionado != null)
                {
                    // Sobrescribimos las propiedades con lo que el usuario editó en la pantalla
                    seleccionado.Codigo = txtBoxCodigo.Text;
                    seleccionado.Nombre = txtBoxNombre.Text;
                    seleccionado.Descripcion = txtBoxDescripcion.Text;
                    Marca marcaArticulo = new Marca();
                    seleccionado.marcaArticulo.Descripcion = ddlMarca.SelectedValue;
                    Categoria categoriaArticulo = new Categoria();
                    seleccionado.categoriaArticulo.Descripcion = ddlCategoria.SelectedValue;
 
                    seleccionado.ImagenUrl = txtBoxImagen.Text;
                    if (imagenArticulo == null)
                        seleccionado.ImagenUrl = "https://www.neuco.com/assets/img/product-placeholder.webp";

                    if (decimal.TryParse(txtBoxPrecio.Text, out decimal precioConvertido))
                        seleccionado.Precio = precioConvertido;

                    articuloNegocio.modificarConSP(seleccionado);
                }
            }

            Response.Redirect("Default.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            ConfirmaEliminacion = true;
        }

        protected void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkBoxConfirmaEliminar.Checked)
                {
                    ArticuloNegocio negocio = new ArticuloNegocio();
                    negocio.eliminar(int.Parse(txtBoxId.Text));
                    Response.Redirect("ArticulosLista.aspx", false);
                }
                
                
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
            }
        }

        protected void txtBoxImagen_TextChanged(object sender, EventArgs e)
        {
            imagenArticulo.ImageUrl = txtBoxImagen.Text;
        }
    }
}