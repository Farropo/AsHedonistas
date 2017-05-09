using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsHedonistas.Models
{
    public class ProductCategory
    {

        //Construtor, carrega os produtos associadas
        public ProductCategory()
        {
            Product = new HashSet<Product>();
        }


        //PRIMARY KEY
        [Key]
        [Display(Name = "Identificador do Produto")]
        public int ProductCategoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        //***********************************************************************
        // definição do atributo que será utilizado para exprimir o relacionamento
        // com os objetos da classe NoticeCategory
        public virtual ICollection<Product> Product { get; set; }
        //***********************************************************************

    }
}