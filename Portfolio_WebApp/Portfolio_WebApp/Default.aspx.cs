using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Portfolio_WebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void BtnRegistro_Click(object sender, EventArgs e)
        {
            string nombre = txtBoxNombre.Text;
            lblSaludo.Text = "Hola " + nombre + ", ¡gracias por pasar por mi portfolio!";
        }
    }
}