//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Librerias
{
    using System;
    using System.Collections.Generic;
    
    public partial class Ventas
    {
        public int VentaID { get; set; }
        public Nullable<int> ClienteID { get; set; }
        public Nullable<int> LibroID { get; set; }
        public Nullable<int> Cantidad { get; set; }
        public Nullable<decimal> ImporteBruto { get; set; }
        public Nullable<decimal> MontoDescuento { get; set; }
        public Nullable<decimal> ImporteNeto { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Libros Libros { get; set; }
    }
}
