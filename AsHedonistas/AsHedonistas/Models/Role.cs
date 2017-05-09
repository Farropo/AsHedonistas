using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsHedonistas.Models
{
    public class Role
    {
        //Construtor, carrega os roles associados
        public Role()
        {
            User = new HashSet<User>();
        }

        //PRIMARY KEY
        [Key]
        public int RoleID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }


        //***********************************************************************
        // definição do atributo que será utilizado para exprimir o relacionamento
        // com os objetos da classe User
        public virtual ICollection<User> User { get; set; }
        //***********************************************************************
    }
}