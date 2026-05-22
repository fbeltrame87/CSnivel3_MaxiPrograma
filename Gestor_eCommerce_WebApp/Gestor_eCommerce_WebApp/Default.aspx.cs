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
    public partial class Default : System.Web.UI.Page
    {
        public string user { get; set; }
        public string password { get; set; }
        public List<Articulo> ListaArticulo { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

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

            if (!IsPostBack)
            {
                //Si guardamos en Session:
                //dgvCommerce.DataSource = Session["listaArticulos"];
                //dgvCommerce.DataBind();

                // Llamamos directo al método que hace el SELECT en tu DB con Stored Procedure
                ListaArticulo = negocio.listarConSP();

                repetidor.DataSource = ListaArticulo;
                repetidor.DataBind();
            }
        }

        protected void btnEjemplo_Click(object sender, EventArgs e)
        {
            string valor = ((Button)sender).CommandArgument; //Sender es el objeto que lanzó el evento.
        }
    }
}