//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CDMYPE_DataAcces
{
    using System;
    using System.Collections.Generic;
    
    public partial class GastosFijosVariable
    {
        public int ID_Gasto { get; set; }
        public string TipoF_V { get; set; }
        public string DescripcionGasto { get; set; }
        public decimal Costo { get; set; }
        public int FK_ID_Empresa { get; set; }
    
        public virtual Empresa Empresa { get; set; }
    }
}
