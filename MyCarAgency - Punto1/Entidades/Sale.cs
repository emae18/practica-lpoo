//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entidades
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public int idSale { get; set; }
        public Nullable<int> idClient { get; set; }
        public string vinVehicle { get; set; }
        public Nullable<int> idEmployee { get; set; }
        public Nullable<System.DateTime> dateSale { get; set; }
        public Nullable<double> priceSale { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
