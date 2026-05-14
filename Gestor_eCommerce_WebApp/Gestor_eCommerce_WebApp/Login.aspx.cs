using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Gestor_eCommerce_WebApp
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                txtBoxUser.Text = "";
        }
        
        protected void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBoxUser.Text) && !string.IsNullOrEmpty(txtBoxPassword.Text))
            {
                string nombre = txtBoxUser.Text;
                string password = txtBoxPassword.Text;
                // Redirigimos pasando el nombre por URL
                //Response.Redirect("Default.aspx?user=" + nombre, false);

                //Redirigimos usando Session(Objeto tipo clave-valor que genera una instancia para cada user al conectarse a servidor.)
                Session.Add("user", nombre);
                Session.Add("pass", password);
                Response.Redirect("Default.aspx", false);
            }
            else
            {
                lblSaludo.Text = "Debes completar ambos campos.";
                lblSaludo.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}