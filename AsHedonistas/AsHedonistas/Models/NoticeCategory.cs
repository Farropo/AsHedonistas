using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace AsHedonistas.Models
{
    public class NoticeCategory
    {

        //Construtor, carrega as notices associadas
        public NoticeCategory()
        {
            Notice = new HashSet<Notice>();
        }

        //PrimaryKey
        [Key]
        public int NoticeCategoryID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        //***********************************************************************
        // definição do atributo que será utilizado para exprimir o relacionamento
        // com os objetos da classe CD
        public virtual ICollection<Notice> Notice { get; set; }
        //***********************************************************************
    }
}