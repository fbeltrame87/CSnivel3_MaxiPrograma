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

        protected void Page_Load(object sender, EventArgs e)
        {
            txtBoxId.Enabled = false;

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

                    btnAceptar.Enabled = true;
                    btnModificar.Enabled = false;
                    btnEliminar.Enabled = false;

                    if (Request.QueryString["id"] != null) //Valida si viene del Seleccionar(manito indice) o no
                    {
                        int id = int.Parse(Request.QueryString["id"]);
                        ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                        Articulo seleccionado = articuloNegocio.listar().Find(x => x.Id == id);

                        //List<Articulo> temporal = (List<Articulo>)Session["listaArticulos"];
                        //Articulo seleccionado = temporal.Find(x => x.Id == id);

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
                            txtBoxId.ReadOnly = true;

                            btnAceptar.Enabled = false;
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

        protected void btnAceptar_Click(object sender, EventArgs e)
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

                    if (decimal.TryParse(txtBoxPrecio.Text, out decimal precioConvertido))
                        seleccionado.Precio = precioConvertido;

                    articuloNegocio.modificar(seleccionado);
                }
            }

            Response.Redirect("Default.aspx", false);
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtBoxId.Text, out int idBuscado))
            {
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                Articulo seleccionado = articuloNegocio.listar().Find(x => x.Id == idBuscado);

                if (seleccionado != null)
                    articuloNegocio.eliminar(idBuscado);
            }

            Response.Redirect("Default.aspx", false);
        }

        protected void txtBoxImagen_TextChanged(object sender, EventArgs e)
        {
            imagenArticulo.ImageUrl = txtBoxImagen.Text;
        }
    }
}