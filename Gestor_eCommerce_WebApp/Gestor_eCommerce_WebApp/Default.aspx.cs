using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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
                lblUser.Text = user;
            }
            else
            {
                user = "";
                Response.Redirect("Login.aspx", false);
            }
            
        }
    }
}