
using Dapper.Contrib.Extensions;
using System;
namespace Product.Database.Models
{
    [Table("Products")]
    public class ProductTable
    {
        [Key]
        public int Id { get; set; }   
        public string ProductName { get; set; }
        public string ProductAlternateName { get; set; }     
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string CreatedBy {get;set;}

    }    
}
