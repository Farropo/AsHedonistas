using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace AsHedonistas.Models
{
    public class Product
    {

        //Construtor, carrega as categorias do produto associadas
        public Product()
        {
            ProductCategory = new HashSet<ProductCategory>();
        }

        //PRIMARY KEY
        [Key]
        [Display(Name = "Identificador do Produto")]
        public int ProductID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime EntryDate { get; set; }

        //***********************************************************************
        // definição do atributo que será utilizado para exprimir o relacionamento
        // com os objetos da classe NoticeCategory
        public virtual ICollection<ProductCategory> ProductCategory { get; set; }
        //***********************************************************************
    }
}