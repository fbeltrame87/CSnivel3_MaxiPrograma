using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Gestor_eCommerce_WebApp
{
    public partial class ArticuloForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMarca.Items.Add("Samsung");
                ddlMarca.Items.Add("Motorola");
                ddlMarca.Items.Add("Sony");
                ddlMarca.Items.Add("Apple");

                ddlCategoria.Items.Add("Celulares");
                ddlCategoria.Items.Add("Media");
                ddlCategoria.Items.Add("Audio");
                ddlCategoria.Items.Add("Tablets");
                ddlCategoria.Items.Add("PCs");
            }

            if (Request.QueryString["id"] != null) //Valida si viene del seleccionar o no
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                List<Articulo> temporal = (List<Articulo>)Session["listaArticulos"];
                Articulo seleccionado = temporal.Find(x => x.Id == id);
                txtBoxCodigo.Text = seleccionado.Codigo;
                txtBoxNombre.Text = seleccionado.Nombre;
                txtBoxDescripcion.Text = seleccionado.Descripcion;
                ddlMarca.SelectedItem.Text = seleccionado.Marca;
                ddlCategoria.SelectedItem.Text = seleccionado.Categoria;
                txtBoxImagen.Text = seleccionado.ImagenUrl;
                txtBoxPrecio.Text = seleccionado.Precio.ToString();
                txtBoxId.Text = seleccionado.Id.ToString();
                txtBoxId.ReadOnly = true;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            articulo.Id = int.Parse(txtBoxId.Text);
            articulo.Codigo = txtBoxCodigo.Text;
            articulo.Nombre = txtBoxNombre.Text;
            articulo.Descripcion = txtBoxDescripcion.Text;
            articulo.Categoria = ddlCategoria.SelectedValue;
            articulo.Marca = ddlMarca.SelectedValue;
            articulo.ImagenUrl = txtBoxImagen.Text;
            articulo.Precio = decimal.Parse(txtBoxPrecio.Text);

            //Acá enviaría los datos a DB llamando algún método...

            /*Recupeperación de la grilla actualizada cuando el guardado en es Session
            --------------------------------------------------------------------------
            Opción A
            ((List<Articulo>)Session["listaArticulos"]).Add(articulo);
            Opción B*/
            List<Articulo> temporal = (List<Articulo>)Session["listaArticulos"];
            temporal.Add(articulo);

            Response.Redirect("Default.aspx");
        }
    }
}