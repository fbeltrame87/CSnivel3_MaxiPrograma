using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapaNegocio;

namespace Gestor_eCommerce_WebApp
{
    public partial class ArticulosLista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (!IsPostBack)
            {
                dgvCommerce.DataSource = negocio.listarConSP();
                dgvCommerce.DataBind();
            }
        }

        protected void dgvCommerce_SelectedIndexChanged(object sender, EventArgs e)
        {
            var id = dgvCommerce.SelectedDataKey.Value.ToString();
            Response.Redirect("ArticuloForm.aspx?id=" + id);
        }

        protected void dgvCommerce_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            dgvCommerce.PageIndex = e.NewPageIndex;
            ArticuloNegocio negocio = new ArticuloNegocio();
            dgvCommerce.DataSource = negocio.listar();
            dgvCommerce.DataBind();
        }
    }
}