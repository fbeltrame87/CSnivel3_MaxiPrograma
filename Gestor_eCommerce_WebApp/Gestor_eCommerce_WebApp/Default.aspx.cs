using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace Gestor_eCommerce_WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        public string user { get; set; }
        public string password { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
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

            if(Session["listaArticulos"] == null)
            {
                ArticuloNegocio negocio = new ArticuloNegocio();
                Session.Add("listaArticulos", negocio.listar()); //Guardo en Session la lista de articulos para que permanezca en MEMORIA
            }
            if (!IsPostBack)
            {
                dgvCommerce.DataSource = Session["listaArticulos"];
                dgvCommerce.DataBind();
            }
        }

        protected void dgvCommerce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvCommerce.SelectedDataKey.Value.ToString();
            Response.Redirect("ArticuloForm.aspx?id=" + id);
        }
    }
}