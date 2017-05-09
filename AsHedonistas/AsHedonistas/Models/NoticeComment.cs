using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AsHedonistas.Models
{
    public class NoticeComment
    {

        //PrimaryKey
        [Key]
        public int NoticeCommentID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        //RELAÇÕES:
        // relaciona o objeto Noticia com um objeto Notice
        public Notice Notice { get; set; }

        // cria um atributo para funcionar como FK, na BD
        // e relaciona-o com o atributo anterior
        [ForeignKey("Notice")]
        public int NoticeFK { get; set; }
        // **************************
    }
}