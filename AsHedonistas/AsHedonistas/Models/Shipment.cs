using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AsHedonistas.Models
{
    public class Shipment
    {
        // PRIMARY KEY
        [Key]
        [Display(Name = "Identificador do Shipment")]
        public int ShipmentID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime EstimatedDeliveryDate { get; set; }

        //RELAÇÕES:
        // relaciona o objeto Order com um objeto Product
        public Product Product { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Product")]
        public int ProductFK { get; set; }
        // **************************
    }
}