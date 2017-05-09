using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AsHedonistas.Models
{
    // Esta tabela tem participação obrigatória em user e product
    public class Order
    {
        //Primary Key
        [Key]
        [Display(Name = "Identificador de Order")]
        public int OrderID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime OrderDate { get; set; }

        //RELAÇÕES:
        // relaciona o objeto Order com um objeto Product
        public Product Product { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Product")]
        public int ProductFK { get; set; }
        // **************************

        // relaciona o objeto Order com um objeto User
        public User User { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("User")]
        public int UserFK { get; set; }
        // **************************

    }
}