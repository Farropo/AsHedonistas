using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace AsHedonistas.Models
{
    public class AsHedonistasDB : DbContext
    {

        //Tabelas (1 - 0,...,M), Optional lado 1
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Notice> Notice { get; set; }
        public virtual DbSet<NoticeComment> NoticeComment { get; set; }
        public virtual DbSet<NoticeDetail> NoticeDetail { get; set; }

        //Tabelas (1- 1,...,M), Optional lado M
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Shipment> Shipment { get; set; }

        //Tabelas M-N, Optional de um lado
        public virtual DbSet<NoticeCategory> NoticeCategory { get; set; }
        public virtual DbSet<ProductCategory> ProductCategory { get; set; }
        public virtual DbSet<Role> Role { get; set; }



        //  Onde criar e de que tipo será a Base de Dados
        public AsHedonistasDB() : base("AsHedonistas") { }

        // formatar a configuração das FKs
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // não podemos usar a chave seguinte, nesta geração de tabelas
            // por causa das tabelas do Identity (gestão de utilizadores)
            // modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);                      
            }
    }
}