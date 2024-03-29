//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDMYPE_API2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.ManoDeObra = new HashSet<ManoDeObra>();
            this.Materiales = new HashSet<Materiales>();
        }
    
        public int ID_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal CU_Produccion { get; set; }
        public int FK_ID_Empresa { get; set; }
    
        public virtual Empresas Empresas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManoDeObra> ManoDeObra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Materiales> Materiales { get; set; }
    }
}
