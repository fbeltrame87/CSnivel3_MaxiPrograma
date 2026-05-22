using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;
using CapaNegocio;
using System.Configuration;

namespace Gestor_de_Comercio_App
{
    public partial class FormNuevoArticulo : Form
    {
        private Articulo articulo = null; //Objeto null que pasa a tener contenido solo si recibe uno por parametro.
        OpenFileDialog archivo = null;

        public FormNuevoArticulo()
        {
            InitializeComponent();
        }

        public FormNuevoArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                    articulo = new Articulo();

                articulo.Codigo = txtBoxCodigo.Text;
                articulo.Nombre = txtBoxNombre.Text;
                articulo.Descripcion = txtBoxDescripcion.Text;
                articulo.categoriaArticulo = (Categoria)cboBoxCategoria.SelectedItem;
                articulo.marcaArticulo = (Marca)cboBoxMarca.SelectedItem;

                articulo.ImagenUrl = txtBoxImagenUrl.Text;

                articulo.Precio = decimal.Parse(txtBoxPrecio.Text);

                if(articulo.Id != 0)
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("¡Modificado exitoso!");
                }
                else
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("¡Agregado exitoso!");
                }

                guardarImagenLocal(archivo);
               
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormNuevoArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            MarcaNegocio negocioMarca = new MarcaNegocio();

            try
            {
                cboBoxCategoria.DataSource = negocioCategoria.listar();
                cboBoxCategoria.ValueMember = "Id";
                cboBoxCategoria.DisplayMember = "Descripcion";
                cboBoxMarca.DataSource = negocioMarca.listar();
                cboBoxMarca.ValueMember = "Id";
                cboBoxMarca.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtBoxCodigo.Text = articulo.Codigo;
                    txtBoxNombre.Text = articulo.Nombre;
                    txtBoxDescripcion.Text = articulo.Descripcion;
                    txtBoxImagenUrl.Text = articulo.ImagenUrl;
                    cargarImagen(articulo.ImagenUrl);
                    txtBoxPrecio.Text = articulo.Precio.ToString();
                    cboBoxCategoria.SelectedValue = articulo.categoriaArticulo.Id;
                    cboBoxMarca.SelectedValue = articulo.marcaArticulo.Id;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBoxImagenUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtBoxImagenUrl.Text);
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pBoxNuevaImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pBoxNuevaImagen.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTTFlhSWwrzGBZnqDlW7uLEEJWBhFc8sW_Ruw&s");
            }
        }

        private void guardarImagenLocal(OpenFileDialog archivo)
        {
             if (archivo != null && !(txtBoxImagenUrl.Text.Contains("http")))
             {
                 File.Copy(archivo.FileName, ConfigurationManager.AppSettings["Imagenes_Articulos"] + archivo.SafeFileName);
             }
        }

        private void btnImagen_Click(object sender, EventArgs e)
        {
            try
            {
                archivo = new OpenFileDialog();
                archivo.Filter = "jpg|*.jpg;|png|*.png;";
                if (archivo.ShowDialog() == DialogResult.OK)
                {
                    txtBoxImagenUrl.Text = archivo.FileName;
                    cargarImagen(archivo.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
