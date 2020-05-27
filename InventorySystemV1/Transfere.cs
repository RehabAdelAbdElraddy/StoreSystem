namespace InventorySystemV1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transfere")]
    public partial class Transfere
    {
        public int id { get; set; }

        public int? FromInventory { get; set; }

        public int? ToInventory { get; set; }

        [StringLength(50)]
        public string P_Code { get; set; }

        [StringLength(50)]
        public string TransfereDate { get; set; }

        [StringLength(50)]
        public string PDate { get; set; }

        [StringLength(50)]
        public string EDate { get; set; }

        public int? Qnty { get; set; }

        public int? supplierid { get; set; }

        public virtual Customer_Suppliers Customer_Suppliers { get; set; }

        public virtual Inventory Inventory { get; set; }

        public virtual Inventory Inventory1 { get; set; }

        public virtual Product Product { get; set; }
    }
}
