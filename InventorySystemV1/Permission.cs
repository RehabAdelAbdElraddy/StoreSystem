namespace InventorySystemV1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permission
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Permission()
        {
            Permission_Products = new HashSet<Permission_Products>();
        }

        [Key]
        public int P_Number { get; set; }

        public DateTime? P_Date { get; set; }

        public int? Inventory_ID { get; set; }

        [StringLength(50)]
        public string Type { get; set; }

        public virtual Inventory Inventory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Permission_Products> Permission_Products { get; set; }
    }
}
