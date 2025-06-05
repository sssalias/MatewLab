using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppLab.Models
{
    internal class Storage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public required DateOnly OrderDate { get; set; }
        public required DateOnly SendDate { get; set; }
        public required int ProductId { get; set; }
        public required Product Product { get; set; }

        public required int ProviderId {  get; set; }
        public required Provider Provider { get; set; }

        public required int CustomerId { get; set; }
        public required Customer Customer { get; set; }

        public required string DeliveryType { get; set; }
        public required int Volume {  get; set; }
        public required int Price { get; set; }

        public required int EmployeeId { get; set; }
        public required Employee Employee { get; set; }
    }
}
