namespace COMP229_F2016_Assignment2_Part3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Cricket")]
    public partial class Cricket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Rankings { get; set; }

        [Column(TypeName = "text")]
        public string Teams { get; set; }

        public int? points { get; set; }

        [Column(TypeName = "text")]
        public string Result { get; set; }
    }
}
