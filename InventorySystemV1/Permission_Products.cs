namespace InventorySystemV1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permission_Products
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int P_Number { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string P_Code { get; set; }

        public int? Quantity { get; set; }

        public int? Supplier_ID { get; set; }

        public string ProductionDate { get; set; }

        public string ExperationDate { get; set; }
       

        public virtual Customer_Suppliers Customer_Suppliers { get; set; }

        public virtual Permission Permission { get; set; }

        public virtual Product Product { get; set; }
    }
}
