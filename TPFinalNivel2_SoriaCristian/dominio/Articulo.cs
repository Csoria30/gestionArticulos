﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public int Id { get; set; }
        public string CodigoArticulo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion {  get; set; }
        public Marca DescripcionMarca {  set; get; }
        public Categoria CategoriaMarca { get; set; }
        public string ImagenUrl {  get; set; }
        public double precio {  get; set; }

    }
}
