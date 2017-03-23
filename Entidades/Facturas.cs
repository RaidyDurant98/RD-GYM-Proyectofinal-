﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Facturas
    {
        [Key]
        public int FacturaId { get; set; }
        public string NombreCliente { get; set; }
        public int ProductoId { get; set; }
        public DateTime Fecha { get; set; }
        public double SubTotal { get; set; }
        public double Total { get; set; }

        public virtual ICollection<FacturasProductos> Relacion { get; set; }

        public Facturas()
        {
            this.Relacion = new HashSet<FacturasProductos>();
        }

        public void AgregarDetalle(Productos producto, decimal cantidad)
        {
            this.Relacion.Add(new FacturasProductos(producto.ProductoId, producto.Precio, cantidad, producto.Descripcion));
        }
    }
}