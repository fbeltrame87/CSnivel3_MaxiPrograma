using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace ejemplo1
{
    public partial class AutoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlColores.Items.Add("Azul");
                ddlColores.Items.Add("Rojo");
                ddlColores.Items.Add("Negro");
            }

            if(Request.QueryString["id"] != null) //Valida si viene del seleccionar o no
            {
                int id = int.Parse(Request.QueryString["id"].ToString());
                List<Auto> temporal = (List<Auto>)Session["listaAutos"];
                Auto seleccionado = temporal.Find(x => x.Id == id);
                txtModelo.Text = seleccionado.Modelo;
                txtDescripcion.Text = seleccionado.Descripcion;
                ddlColores.SelectedItem.Text = seleccionado.Color;
                /*
                DateTime fechaAux;
                if (DateTime.TryParse(txtFecha.Text, out fechaAux))
                        seleccionado.Fecha = fechaAux;
                else
                    seleccionado.Fecha = DateTime.Today;
                //seleccionado.Fecha = Convert.ToDateTime(txtFecha.Text); -- Salta Exception
                */
                txtFecha.Text = seleccionado.Fecha.ToString("yyyy-MM-dd");
                if (checkBoxUsado.Checked)
                    seleccionado.Usado = true;
                else { seleccionado.Usado = false; }
                if (rbImportado.Checked)
                    seleccionado.Importado = true;
                else { seleccionado.Importado = false; }
                txtId.Text = seleccionado.Id.ToString();
                txtId.ReadOnly = true;
            }
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Auto auto = new Auto();
            auto.Id = int.Parse(txtId.Text);
            auto.Modelo = txtModelo.Text;
            auto.Color = ddlColores.SelectedValue;
            auto.Fecha = DateTime.Parse(txtFecha.Text);
            auto.Descripcion = txtDescripcion.Text;
            auto.Usado = checkBoxUsado.Checked;

            if (rbImportado.Checked)
                auto.Importado = true;
            else if (rbNacional.Checked)
                auto.Importado = false;

            //Acá enviaría los datos a DB llamando algún método...

            /*Recupeperación de la grilla actualizada cuando el guardado en es Session
            --------------------------------------------------------------------------
            Opción A
            ((List<Auto>)Session["listaAutos"]).Add(auto);
            Opción B*/
            List<Auto> temporal = (List<Auto>)Session["listaAutos"];
            temporal.Add(auto);

            Response.Redirect("Default.aspx");
        }
    }
}