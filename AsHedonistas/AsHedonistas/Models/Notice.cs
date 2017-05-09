using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AsHedonistas.Models
{
    public class Notice
    {
        // Construtor da tabela notice, carrega as notice details, comments e categories
        public Notice()
        {
            NoticeDetails = new HashSet<NoticeDetail>();
            NoticeComments = new HashSet<NoticeComment>();

            NoticeCategory = new HashSet<NoticeCategory>();
        }

        //Primary Key
        [Key]
        public int NoticeID { get; set; }

        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string ShortContent { get; set; }

        public DateTime PublishDate { get; set; }

        //RELAÇÕES:
        // relaciona o objeto Noticia com um objeto USER
        public User User { get; set; }
        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("User")]
        public int UserFK { get; set; }
        // **************************

        
        // Posso usar virtual? Virtual = lazyloading?
        public ICollection<NoticeDetail> NoticeDetails { get; set; }
        public ICollection<NoticeComment> NoticeComments { get; set; }

        //***********************************************************************
        // definição do atributo que será utilizado para exprimir o relacionamento
        // com os objetos da classe NoticeCategory
        public virtual ICollection<NoticeCategory> NoticeCategory { get; set; }
        //***********************************************************************
    }
}
