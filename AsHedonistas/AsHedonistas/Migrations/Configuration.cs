namespace AsHedonistas.Migrations
{
    using AsHedonistas.Models;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<AsHedonistas.Models.AsHedonistasDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AsHedonistas.Models.AsHedonistasDB context)
        {
            //  This method will be called after migrating to the latest version.

            //#############################################################
            // criação das classes para projeto asHedonistas
            //#############################################################


            // Configuration --- SEED
            //=============================================================

            // ############################################################################################
            // Registos User(s)
            var users = new List<User> {
            new User  {UserID=1, Name = "Bruno Farrôpo" },
            new User  {UserID=2, Name = "Mara Jorge"  },
            new User  {UserID=3, Name = "Ana Avelino"},
            new User  {UserID=4, Name = "Cliente Registado" },
            new User  {UserID=5, Name = "Couve Lombarda" },
         };

            users.ForEach(dd => context.User.AddOrUpdate(d => d.UserID, dd));
            context.SaveChanges(); // commit

            // ############################################################################################
            // Registos Notice(s)
            var notices = new List<Notice> {
            new Notice  {NoticeID=1, Name = "Noticia 1, User 1", UserFK=1 },
            new Notice  {NoticeID=2, Name = "Noticia 2, User 2", UserFK=2  },
            new Notice  {NoticeID=3, Name = "Noticia 3, User 3", UserFK=3},
            new Notice  {NoticeID=4, Name = "Noticia 4, User 4", UserFK=4 },
            new Notice  {NoticeID=5, Name = "Noticia 5, User 5", UserFK=5 },
            new Notice  {NoticeID=6, Name = "Noticia 6, User 1", UserFK=1 },
            new Notice  {NoticeID=7, Name = "Noticia 7, User 1", UserFK=1},
            new Notice  {NoticeID=8, Name = "Noticia 8, User 2", UserFK=2 },
            new Notice  {NoticeID=9, Name = "Noticia 9, User 3", UserFK=3 },
            new Notice  {NoticeID=10, Name = "Noticia 10, User 4", UserFK=4},

         };

            notices.ForEach(dd => context.Notice.AddOrUpdate(d => d.NoticeID, dd));
            context.SaveChanges(); // commit


            // ############################################################################################
            // Registos NoticeDetail(s)
            var noticeDetails = new List<NoticeDetail> {
            new NoticeDetail  {NoticeDetailID=1, Name = "Noticia Detalhe 1, Noticia 1", NoticeFK=1},
            new NoticeDetail  {NoticeDetailID=2, Name = "Noticia Detalhe 2, Noticia 1", NoticeFK=1},
            new NoticeDetail  {NoticeDetailID=3, Name = "Noticia Detalhe 3, Noticia 3", NoticeFK=3},
            new NoticeDetail  {NoticeDetailID=4, Name = "Noticia Detalhe 4, Noticia 4", NoticeFK=4},
            new NoticeDetail  {NoticeDetailID=5, Name = "Noticia Detalhe 5, Noticia 5", NoticeFK=5},
            new NoticeDetail  {NoticeDetailID=6, Name = "Noticia Detalhe 6, Noticia 6", NoticeFK=6},
            new NoticeDetail  {NoticeDetailID=7, Name = "Noticia Detalhe 7, Noticia 7", NoticeFK=7},
            new NoticeDetail  {NoticeDetailID=8, Name = "Noticia Detalhe 8, Noticia 8", NoticeFK=8},
            new NoticeDetail  {NoticeDetailID=9, Name = "Noticia Detalhe 9, Noticia 9" ,NoticeFK=9},
            new NoticeDetail  {NoticeDetailID=10, Name = "Noticia Detalhe 10, Noticia 10", NoticeFK=10},

         };

            noticeDetails.ForEach(dd => context.NoticeDetail.AddOrUpdate(d => d.NoticeDetailID, dd));
            context.SaveChanges(); // commit

            // ############################################################################################
            // Registos NoticeComments(s)
            var noticeComments = new List<NoticeComment> {
            new NoticeComment   {NoticeCommentID=1, Name = "Noticia Comentario 1, Noticia 1", NoticeFK=1},
            new NoticeComment   {NoticeCommentID=2, Name = "Noticia Comentario 2, Noticia 1",NoticeFK=1},
            new NoticeComment   {NoticeCommentID=3, Name = "Noticia Comentario 3, Noticia 3",NoticeFK=3},
            new NoticeComment   {NoticeCommentID=4, Name = "Noticia Comentario 4, Noticia 4",NoticeFK=4},
            new NoticeComment   {NoticeCommentID=5, Name = "Noticia Comentario 5, Noticia 5",NoticeFK=5},
            new NoticeComment   {NoticeCommentID=6, Name = "Noticia Comentario 6, Noticia 6",NoticeFK=6},
            new NoticeComment   {NoticeCommentID=7, Name = "Noticia Comentario 7, Noticia 7",NoticeFK=7},
            new NoticeComment   {NoticeCommentID=8, Name = "Noticia Comentario 8, Noticia 8",NoticeFK=8},
            new NoticeComment   {NoticeCommentID=9, Name = "Noticia Comentario 9, Noticia 9",NoticeFK=9},
            new NoticeComment   {NoticeCommentID=10, Name = "Noticia Comentario 10, Noticia 10",NoticeFK=10},

         };

            noticeComments.ForEach(dd => context.NoticeComment.AddOrUpdate(d => d.NoticeCommentID, dd));
            context.SaveChanges(); // commit

            // ############################################################################################
            // Registos NoticeCategory(s)
            var noticeCategories = new List<NoticeCategory> {
            new NoticeCategory   {NoticeCategoryID=1, Name = "Noticia Categoria 1"},
            new NoticeCategory   {NoticeCategoryID=2, Name = "Noticia Categoria 2"},
            new NoticeCategory   {NoticeCategoryID=3, Name = "Noticia Categoria 3"},
            new NoticeCategory   {NoticeCategoryID=4, Name = "Noticia Categoria 4"},
            new NoticeCategory   {NoticeCategoryID=5, Name = "Noticia Categoria 5"},
            new NoticeCategory   {NoticeCategoryID=6, Name = "Noticia Categoria 6"},
            new NoticeCategory   {NoticeCategoryID=7, Name = "Noticia Categoria 7"},
            new NoticeCategory   {NoticeCategoryID=8, Name = "Noticia Categoria 8"},
            new NoticeCategory   {NoticeCategoryID=9, Name = "Noticia Categoria 9"},
            new NoticeCategory   {NoticeCategoryID=10, Name = "Noticia Categoria 10"},

         };

            noticeCategories.ForEach(dd => context.NoticeCategory.AddOrUpdate(d => d.NoticeCategoryID, dd));
            context.SaveChanges(); // commit


            // ############################################################################################
            // Registos Product(s)
            var products = new List<Product> {
            new Product   {ProductID=1, Name = "Produto 1"},
            new Product   {ProductID=2, Name = "Produto 2"},
            new Product   {ProductID=3, Name = "Produto 3"},
            new Product   {ProductID=4, Name = "Produto 4"},
            new Product   {ProductID=5, Name = "Produto 5"},
            new Product   {ProductID=6, Name = "Produto 6"},
            new Product   {ProductID=7, Name = "Produto 7"},
            new Product   {ProductID=8, Name = "Produto 8"},
            new Product   {ProductID=9, Name = "Produto 9"},
            new Product   {ProductID=10, Name = "Produto 10"},

         };

            products.ForEach(dd => context.Product.AddOrUpdate(d => d.ProductID, dd));
            context.SaveChanges(); // commit

            // ############################################################################################
            // Registos ProductCategory(s)
            var productCategories = new List<ProductCategory> {
            new ProductCategory   {ProductCategoryID=1, Name = "Product Categoria 1"},
            new ProductCategory   {ProductCategoryID=2, Name = "Product Categoria 2"},
            new ProductCategory   {ProductCategoryID=3, Name = "Product Categoria 3"},
            new ProductCategory   {ProductCategoryID=4, Name = "Product Categoria 4"},
            new ProductCategory   {ProductCategoryID=5, Name = "Product Categoria 5"},
            new ProductCategory   {ProductCategoryID=6, Name = "Product Categoria 6"},
            new ProductCategory   {ProductCategoryID=7, Name = "Product Categoria 7"},
            new ProductCategory   {ProductCategoryID=8, Name = "Product Categoria 8"},
            new ProductCategory   {ProductCategoryID=9, Name = "Product Categoria 9"},
            new ProductCategory   {ProductCategoryID=10, Name = "Product Categoria 10"},

         };

            productCategories.ForEach(dd => context.ProductCategory.AddOrUpdate(d => d.ProductCategoryID, dd));
            context.SaveChanges(); // commit


            // ############################################################################################
            // Registos Order(s)
            var orders = new List<Order> {
            new Order   {OrderID=1, Name = "Order 1, Produto 1 User 1",ProductFK=1, UserFK = 1},
            new Order   {OrderID=2, Name = "Order 2 Produto 1 User 1",ProductFK=1, UserFK = 1},
            new Order   {OrderID=3, Name = "Order 3 Produto 3 User 3",ProductFK=3, UserFK = 3},
            new Order   {OrderID=4, Name = "Order 4 Produto 4 User 4",ProductFK=4, UserFK = 4},
            new Order   {OrderID=5, Name = "Order 5 Produto 5 User 5",ProductFK=5, UserFK = 5},
            new Order   {OrderID=6, Name = "Order 6 Produto 6 User 1",ProductFK=6, UserFK = 1},
            new Order   {OrderID=7, Name = "Order 7 Produto 7 User 2",ProductFK=7, UserFK = 2},
            new Order   {OrderID=8, Name = "Order 8 Produto 8 User 3",ProductFK=8, UserFK = 3},
            new Order   {OrderID=9, Name = "Order 9 Produto 9 User 4",ProductFK=9, UserFK = 4},
            new Order   {OrderID=10, Name = "Order 10 Produto 10 User 5",ProductFK=10, UserFK = 5},

         };

            orders.ForEach(dd => context.Order.AddOrUpdate(d => d.OrderID, dd));
            context.SaveChanges(); // commit


            // ############################################################################################
            // Registos Shipment(s)
            var shipments = new List<Shipment> {
            new Shipment   {ShipmentID=1, Name = "Shipment 1 Produto 1", ProductFK=1},
            new Shipment   {ShipmentID=2, Name = "Shipment 2 Produto 1",ProductFK=1},
            new Shipment   {ShipmentID=3, Name = "Shipment 3 Produto 2",ProductFK=3},
            new Shipment   {ShipmentID=4, Name = "Shipment 4 Produto 4",ProductFK=4},
            new Shipment   {ShipmentID=5, Name = "Shipment 5 Produto 5",ProductFK=5},
            new Shipment   {ShipmentID=6, Name = "Shipment 6 Produto 6",ProductFK=6},
            new Shipment   {ShipmentID=7, Name = "Shipment 7 Produto 7",ProductFK=7},
            new Shipment   {ShipmentID=8, Name = "Shipment 8 Produto 8",ProductFK=8},
            new Shipment   {ShipmentID=9, Name = "Shipment 9 Produto 9",ProductFK=9},
            new Shipment   {ShipmentID=10, Name = "Shipment 10 Produto 10",ProductFK=10},

         };

            noticeComments.ForEach(dd => context.NoticeComment.AddOrUpdate(d => d.NoticeCommentID, dd));
            context.SaveChanges(); // commit
 

             // ############################################################################################
             // Registos Role(s)
             var roles = new List<Role> {
             new Role   {RoleID=1, Name = "NormalUser"},
             new Role   {RoleID=2, Name = "ContentAdmin"},
             new Role   {RoleID=3, Name = "StoreAdmin"},
             new Role   {RoleID=4, Name = "Admin"},
 
         };

        roles.ForEach(dd => context.Role.AddOrUpdate(d => d.RoleID, dd));
            context.SaveChanges(); // commit
        }

}
}

