namespace Assignment_1_200413629_AmbujBhog.Models.ApplicationModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrderId { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderName { get; set; }

        public int OrderNumber { get; set; }

        [Required]
        public string OrderDetails { get; set; }

        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
