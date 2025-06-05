using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLab.Models
{
    internal class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ProductTypeId { get; set; }
        public ProductType? ProductType { get; set; }
        public required string Name { get; set; }
        public required string Producer {  get; set; }
        public required string StorageConditios { get; set; }
        public required string Package { get; set; }
        public required int ShelfLife {  get; set; }
    }
}
