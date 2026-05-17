using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int Id { get; set; }

        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        [DisplayName("Descripción")]
        public string Descripcion { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string ImagenUrl { get; set; }
        public decimal Precio { get; set; }
    }

    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            lista.Add(new Articulo());
            lista.Add(new Articulo());

            lista[0].Id = 1;
            lista[0].Codigo = "A1";
            lista[0].Descripcion = "Nuevo Articulo";
            lista[0].Nombre = "Moto g100";
            lista[0].Marca = "Motorola";
            lista[0].Categoria = "Celulares";
            lista[0].ImagenUrl = "sdfgsfaghh";
            lista[0].Precio = 100000;

            lista[1].Id = 2;
            lista[1].Codigo = "A2";
            lista[1].Descripcion = "Otro Articulo";
            lista[1].Nombre = "E32";
            lista[1].Marca = "Motorola";
            lista[1].Categoria = "Celulares";
            lista[1].ImagenUrl = "sdfgsfaghsfgfh";
            lista[1].Precio = 80000;

            return lista;
        }
    }
}
