using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;
using CapaNegocio;

namespace Gestor_de_Comercio_App
{
    public partial class FormGestorComercio : Form
    {
        private List<Articulo> listaArticulo;

        public FormGestorComercio()
        {
            InitializeComponent();
        }

        private void FormGestorComercio_Load(object sender, EventArgs e)
        {
            cargar();
            cboBoxCampo.Items.Add("Categoria");
            cboBoxCampo.Items.Add("Marca");
            cboBoxCampo.Items.Add("Precio");
        }

        //Método privado para cargar o recargar la grilla
        private void cargar()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                listaArticulo = articuloNegocio.listar();
                dgvGestorComercio.DataSource = listaArticulo;
                dgvGestorComercio.Columns["Precio"].DefaultCellStyle.Format = "0.00";
                cargarImagen(listaArticulo[0].ImagenUrl);
                ocultarColumnas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvGestorComercio_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvGestorComercio.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvGestorComercio.CurrentRow.DataBoundItem;
                cargarImagen(seleccionado.ImagenUrl);
            }
        }

        //Botones
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FormNuevoArticulo nuevo = new FormNuevoArticulo();
            nuevo.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvGestorComercio.CurrentRow == null)
            {
                MessageBox.Show("Debes seleccionar un artículo de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Articulo seleccionado = (Articulo)dgvGestorComercio.CurrentRow.DataBoundItem;

            if (seleccionado == null)
            {
                MessageBox.Show("No se pudo recuperar el artículo seleccionado.");
                return;
            }

            FormNuevoArticulo modificar = new FormNuevoArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminarExistencia_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            if (dgvGestorComercio.CurrentRow == null)
            {
                MessageBox.Show("Debes seleccionar un artículo de la lista.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Articulo seleccionado = (Articulo)dgvGestorComercio.CurrentRow.DataBoundItem;

            if (seleccionado == null)
            {
                MessageBox.Show("No se pudo recuperar el artículo seleccionado.");
                return;
            }

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Confirmas que quieres eliminarlo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if(respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvGestorComercio.CurrentRow.DataBoundItem;
                    negocio.eliminar(seleccionado.Id);
                    cargar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFiltroAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltro())
                    return;

                string campo = cboBoxCampo.SelectedItem.ToString();
                string criterio = cboBoxCriterio.SelectedItem.ToString();
                string filtro = txtBoxFiltroAvanzado.Text;
                dgvGestorComercio.DataSource = negocio.filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Métodos manipulación de texto filtrado, campo y criterio
        private void txtBoxFiltroRapido_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBoxFiltroRapido.Text;

            if (filtro.Length >= 3)
                listaFiltrada = listaArticulo.FindAll(x => x.Nombre.ToLower().Contains(filtro.ToLower()) || x.marcaArticulo.Descripcion.ToLower().Contains(filtro.ToLower()));
            else
                listaFiltrada = listaArticulo;

            dgvGestorComercio.DataSource = null;
            dgvGestorComercio.DataSource = listaFiltrada;
            ocultarColumnas();
        }

        private void cboBoxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboBoxCampo.SelectedItem.ToString();

            if(opcion == "Precio")
            {
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Menor a");
                cboBoxCriterio.Items.Add("Igual a");
                cboBoxCriterio.Items.Add("Mayor a");
            }
            else
            {
                cboBoxCriterio.Items.Clear();
                cboBoxCriterio.Items.Add("Comienza con");
                cboBoxCriterio.Items.Add("Termina con");
                cboBoxCriterio.Items.Add("Contiene");
            }
        }

        //Métodos para posible clase Helper
        private void cargarImagen(string imagen)
        {
            try
            {
                pBoxImagenArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pBoxImagenArticulo.Load("https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTTFlhSWwrzGBZnqDlW7uLEEJWBhFc8sW_Ruw&s");
            }
        }

        private void ocultarColumnas()
        {
            dgvGestorComercio.Columns["ImagenUrl"].Visible = false;
            dgvGestorComercio.Columns["Id"].Visible = false;
        }

        //Métodos de validación/clase Helper
        private bool validarFiltro()
        {
            if (cboBoxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, antes seleccione el campo para filtrar.");
                return true;
            }

            if (cboBoxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Por favor, antes seleccione el criterio para filtrar.");
                return true;
            }

            if (cboBoxCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(txtBoxFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Ingrese solo números como Precio, por favor.");
                    return true;
                }
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }
    }
}
