//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTIDAD
{
    using System;
    using System.Collections.Generic;
    
    public partial class vehiculo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public vehiculo()
        {
            this.arsenalSoldado = new HashSet<arsenalSoldado>();
            this.paisVehiculo = new HashSet<paisVehiculo>();
        }
    
        public long id_vehiculo { get; set; }
        public string nombre { get; set; }
        public Nullable<int> cilindraje { get; set; }
        public Nullable<int> capacidadCargaMunicion { get; set; }
        public Nullable<long> idTipoVehiculo_Fk { get; set; }
        public Nullable<long> idMarca_Fk { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<arsenalSoldado> arsenalSoldado { get; set; }
        public virtual marca marca { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<paisVehiculo> paisVehiculo { get; set; }
        public virtual tipoVehiculo tipoVehiculo { get; set; }
    }
}
