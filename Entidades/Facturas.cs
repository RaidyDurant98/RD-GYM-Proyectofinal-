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
        public string NombreUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public decimal DineroPagado { get; set; }
        public decimal Devuelta { get; set; }
        public string Comentario { get; set; }
        public string FormaPago { get; set; }

        public virtual ICollection<FacturasProductos> Relacion { get; set; }

        public Facturas()
        {
            this.Relacion = new HashSet<FacturasProductos>();
        }
    }
}
