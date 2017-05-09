using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AsHedonistas.Models
{

    //Vai representar a tabela Users
    public class User {

        // criar o construtor desta classe
        // e carregar a lista de noticias, orders e o role do utilizador
        public User()
        {
            Notices = new HashSet<Notice>();
            Orders = new HashSet<Order>();

            Role = new HashSet<Role>();
        }

        //PRIMARYKEY
        [Key]
        [Display(Name = "Identificador do User")]
        public int UserID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public DateTime RegistrationDate { get; set; }

        [Required]
        [StringLength(9)]
        [RegularExpression("[0-9]{9}",
        ErrorMessage = "o {0} tem 9 algarismos")]
        public string NIF { get; set; }


        // Objectos Notice & Order
        public ICollection<Notice> Notices { get; set; }
        public ICollection<Order> Orders { get; set; }
        
        //***********************************************************************
        // definição do atributo que será utilizado para exprimir o relacionamento
        // com os objetos da classe Role
        public virtual ICollection<Role> Role { get; set; }
        //***********************************************************************

    }
}