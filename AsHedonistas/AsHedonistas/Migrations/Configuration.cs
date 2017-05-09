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
            new User  {UserID=1, Name = "Bruno Farrôpo", NIF="123456789",RegistrationDate=System.DateTime.Now },
            new User  {UserID=2, Name = "Mara Jorge", NIF="123456789",RegistrationDate=System.DateTime.Now   },
            new User  {UserID=3, Name = "Ana Avelino", NIF="123456789",RegistrationDate=System.DateTime.Now },
            new User  {UserID=4, Name = "Cliente Registado", NIF="123456789",RegistrationDate=System.DateTime.Now  },
            new User  {UserID=5, Name = "Couve Lombarda", NIF="123456789",RegistrationDate=System.DateTime.Now  },
         };

            users.ForEach(dd => context.User.AddOrUpdate(d => d.UserID, dd));
            context.SaveChanges(); // commit

            // ############################################################################################
            // Registos Notice(s)
            var notices = new List<Notice> {
            new Notice  {NoticeID=1, Title = "Noticia 1, User 1",PublishDate=System.DateTime.Now,ShortContent="Short Content Noticia 1 user 1", UserFK=1 },
            new Notice  {NoticeID=2, Title = "Noticia 2, User 2",PublishDate=System.DateTime.Now,ShortContent="Short Content Noticia 2 user 2", UserFK=2  },
            new Notice  {NoticeID=3, Title = "Noticia 3, User 3",PublishDate=System.DateTime.Now,ShortContent="Short Content Noticia 3 user 3", UserFK=3},
            new Notice  {NoticeID=4, Title = "Noticia 4, User 4",PublishDate=System.DateTime.Now,ShortContent="Short Content Noticia 4 user 4", UserFK=4 },
            new Notice  {NoticeID=5, Title = "Noticia 5, User 5",PublishDate=System.DateTime.Now,ShortContent="Short Content Noticia 5 user 5", UserFK=5 },
            new Notice  {NoticeID=6, Title = "Noticia 6, User 1",PublishDate=System.DateTime.Now,ShortContent="Short Content Noticia 6 user 1", UserFK=1 },
            new Notice  {NoticeID=7, Title = "Noticia 7, User 1",PublishDate=System.DateTime.Now,ShortContent="Short Content Noticia 7 user 2", UserFK=1},
            new Notice  {NoticeID=8, Title = "Noticia 8, User 2",PublishDate=System.DateTime.Now,ShortContent="Short Content Noticia 8 user 3", UserFK=2 },
            new Notice  {NoticeID=9, Title = "Noticia 9, User 3",PublishDate=System.DateTime.Now,ShortContent="Short Content Noticia 9 user 4", UserFK=3 },
            new Notice  {NoticeID=10, Title = "Noticia 10, User 4",PublishDate=System.DateTime.Now,ShortContent="Short Content Noticia 10 user 5", UserFK=4},

         };

            notices.ForEach(dd => context.Notice.AddOrUpdate(d => d.NoticeID, dd));
            context.SaveChanges(); // commit


            // ############################################################################################
            // Registos NoticeDetail(s)
            var noticeDetails = new List<NoticeDetail> {
            new NoticeDetail  {NoticeDetailID=1, Title = "Noticia Detalhe 1, Noticia 1",Content="Content Noticia Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now, NoticeFK=1},
            new NoticeDetail  {NoticeDetailID=2, Title = "Noticia Detalhe 2, Noticia 1",Content="Content Noticia Detalhe 2, Noticia 1", PublishDate=System.DateTime.Now, NoticeFK=1},
            new NoticeDetail  {NoticeDetailID=3, Title = "Noticia Detalhe 3, Noticia 3",Content="Content Noticia Detalhe 3, Noticia 3", PublishDate=System.DateTime.Now, NoticeFK=3},
            new NoticeDetail  {NoticeDetailID=4, Title = "Noticia Detalhe 4, Noticia 4",Content="Content Noticia Detalhe 4, Noticia 4", PublishDate=System.DateTime.Now, NoticeFK=4},
            new NoticeDetail  {NoticeDetailID=5, Title = "Noticia Detalhe 5, Noticia 5",Content="Content Noticia Detalhe 5, Noticia 5", PublishDate=System.DateTime.Now, NoticeFK=5},
            new NoticeDetail  {NoticeDetailID=6, Title = "Noticia Detalhe 6, Noticia 6",Content="Content Noticia Detalhe 6, Noticia 6", PublishDate=System.DateTime.Now, NoticeFK=6},
            new NoticeDetail  {NoticeDetailID=7, Title = "Noticia Detalhe 7, Noticia 7",Content="Content Noticia Detalhe 7, Noticia 7", PublishDate=System.DateTime.Now, NoticeFK=7},
            new NoticeDetail  {NoticeDetailID=8, Title = "Noticia Detalhe 8, Noticia 8",Content="Content Noticia Detalhe 8, Noticia 8", PublishDate=System.DateTime.Now, NoticeFK=8},
            new NoticeDetail  {NoticeDetailID=9, Title = "Noticia Detalhe 9, Noticia 9",Content="Content Noticia Detalhe 9, Noticia 9", PublishDate=System.DateTime.Now,NoticeFK=9},
            new NoticeDetail  {NoticeDetailID=10, Title = "Noticia Detalhe 10, Noticia 10",Content="Content Noticia Detalhe 10, Noticia 10", PublishDate=System.DateTime.Now, NoticeFK=10},

         };

            noticeDetails.ForEach(dd => context.NoticeDetail.AddOrUpdate(d => d.NoticeDetailID, dd));
            context.SaveChanges(); // commit

            // ############################################################################################
            // Registos NoticeComments(s)
            var noticeComments = new List<NoticeComment> {
            new NoticeComment   {NoticeCommentID=1, Title = "Noticia Comentario 1, Noticia 1",Content="Content Comentario Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now, NoticeFK=1},
            new NoticeComment   {NoticeCommentID=2, Title = "Noticia Comentario 2, Noticia 1",Content="Content Comentario Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now,NoticeFK=1},
            new NoticeComment   {NoticeCommentID=3, Title = "Noticia Comentario 3, Noticia 3",Content="Content Comentario Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now,NoticeFK=3},
            new NoticeComment   {NoticeCommentID=4, Title = "Noticia Comentario 4, Noticia 4",Content="Content Comentario Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now,NoticeFK=4},
            new NoticeComment   {NoticeCommentID=5, Title = "Noticia Comentario 5, Noticia 5",Content="Content Comentario Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now,NoticeFK=5},
            new NoticeComment   {NoticeCommentID=6, Title = "Noticia Comentario 6, Noticia 6",Content="Content Comentario Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now,NoticeFK=6},
            new NoticeComment   {NoticeCommentID=7, Title = "Noticia Comentario 7, Noticia 7",Content="Content Comentario Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now,NoticeFK=7},
            new NoticeComment   {NoticeCommentID=8, Title = "Noticia Comentario 8, Noticia 8",Content="Content Comentario Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now,NoticeFK=8},
            new NoticeComment   {NoticeCommentID=9, Title = "Noticia Comentario 9, Noticia 9",Content="Content Comentario Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now,NoticeFK=9},
            new NoticeComment   {NoticeCommentID=10, Title = "Noticia Comentario 10, Noticia 10",Content="Content Comentario Detalhe 1, Noticia 1", PublishDate=System.DateTime.Now,NoticeFK=10},

         };

            noticeComments.ForEach(dd => context.NoticeComment.AddOrUpdate(d => d.NoticeCommentID, dd));
            context.SaveChanges(); // commit

            // ############################################################################################
            // Registos NoticeCategory(s)
            var noticeCategories = new List<NoticeCategory> {
            new NoticeCategory   {NoticeCategoryID=1, Name = "Noticia Categoria 1", Description="Decriçao Noticia Categoria 1"},
            new NoticeCategory   {NoticeCategoryID=2, Name = "Noticia Categoria 2", Description="Decriçao Noticia Categoria 1"},
            new NoticeCategory   {NoticeCategoryID=3, Name = "Noticia Categoria 3", Description="Decriçao Noticia Categoria 1"},
            new NoticeCategory   {NoticeCategoryID=4, Name = "Noticia Categoria 4", Description="Decriçao Noticia Categoria 1"},
            new NoticeCategory   {NoticeCategoryID=5, Name = "Noticia Categoria 5", Description="Decriçao Noticia Categoria 1"},
            new NoticeCategory   {NoticeCategoryID=6, Name = "Noticia Categoria 6", Description="DecriçaoNoticia Categoria 1"},
            new NoticeCategory   {NoticeCategoryID=7, Name = "Noticia Categoria 7", Description="Decriçao Noticia Categoria 1"},
            new NoticeCategory   {NoticeCategoryID=8, Name = "Noticia Categoria 8", Description="Decriçao Noticia Categoria 1"},
            new NoticeCategory   {NoticeCategoryID=9, Name = "Noticia Categoria 9", Description="Decriçao Noticia Categoria 1"},
            new NoticeCategory   {NoticeCategoryID=10, Name = "Noticia Categoria 10", Description="Decriçao Noticia Categoria 1"},

         };

            noticeCategories.ForEach(dd => context.NoticeCategory.AddOrUpdate(d => d.NoticeCategoryID, dd));
            context.SaveChanges(); // commit


            // ############################################################################################
            // Registos Product(s)
            var products = new List<Product> {
            new Product   {ProductID=1, Name = "Produto 1",Description="Description Produto 1",EntryDate=System.DateTime.Now},
            new Product   {ProductID=2, Name = "Produto 2",Description="Description Produto 2",EntryDate=System.DateTime.Now},
            new Product   {ProductID=3, Name = "Produto 3",Description="Description Produto 3",EntryDate=System.DateTime.Now},
            new Product   {ProductID=4, Name = "Produto 4",Description="Description Produto 4",EntryDate=System.DateTime.Now},
            new Product   {ProductID=5, Name = "Produto 5",Description="Description Produto 5",EntryDate=System.DateTime.Now},
            new Product   {ProductID=6, Name = "Produto 6",Description="Description Produto 6",EntryDate=System.DateTime.Now},
            new Product   {ProductID=7, Name = "Produto 7",Description="Description Produto 7",EntryDate=System.DateTime.Now},
            new Product   {ProductID=8, Name = "Produto 8",Description="Description Produto 8",EntryDate=System.DateTime.Now},
            new Product   {ProductID=9, Name = "Produto 9",Description="Description Produto 9",EntryDate=System.DateTime.Now},
            new Product   {ProductID=10, Name = "Produto 10",Description="Description Produto 10",EntryDate=System.DateTime.Now},

         };

            products.ForEach(dd => context.Product.AddOrUpdate(d => d.ProductID, dd));
            context.SaveChanges(); // commit

            // ############################################################################################
            // Registos ProductCategory(s)
            var productCategories = new List<ProductCategory> {
            new ProductCategory   {ProductCategoryID=1, Name = "Product Categoria 1", Description="Product Categoria 1"},
            new ProductCategory   {ProductCategoryID=2, Name = "Product Categoria 2", Description="Product Categoria 2"},
            new ProductCategory   {ProductCategoryID=3, Name = "Product Categoria 3", Description="Product Categoria 3"},
            new ProductCategory   {ProductCategoryID=4, Name = "Product Categoria 4", Description="Product Categoria 4"},
            new ProductCategory   {ProductCategoryID=5, Name = "Product Categoria 5", Description="Product Categoria 5"},
            new ProductCategory   {ProductCategoryID=6, Name = "Product Categoria 6", Description="Product Categoria 6"},
            new ProductCategory   {ProductCategoryID=7, Name = "Product Categoria 7", Description="Product Categoria 7"},
            new ProductCategory   {ProductCategoryID=8, Name = "Product Categoria 8", Description="Product Categoria 8"},
            new ProductCategory   {ProductCategoryID=9, Name = "Product Categoria 9", Description="Product Categoria 9"},
            new ProductCategory   {ProductCategoryID=10, Name = "Product Categoria 10", Description="Product Categoria 10"},

         };

            productCategories.ForEach(dd => context.ProductCategory.AddOrUpdate(d => d.ProductCategoryID, dd));
            context.SaveChanges(); // commit


            // ############################################################################################
            // Registos Order(s)
            var orders = new List<Order> {
            new Order   {OrderID=1, Name = "Order 1, Produto 1 User 1",OrderDate=System.DateTime.Now, ProductFK=1, UserFK = 1},
            new Order   {OrderID=2, Name = "Order 2 Produto 1 User 1",OrderDate=System.DateTime.Now,ProductFK=1, UserFK = 1},
            new Order   {OrderID=3, Name = "Order 3 Produto 3 User 3",OrderDate=System.DateTime.Now,ProductFK=3, UserFK = 3},
            new Order   {OrderID=4, Name = "Order 4 Produto 4 User 4",OrderDate=System.DateTime.Now,ProductFK=4, UserFK = 4},
            new Order   {OrderID=5, Name = "Order 5 Produto 5 User 5",OrderDate=System.DateTime.Now,ProductFK=5, UserFK = 5},
            new Order   {OrderID=6, Name = "Order 6 Produto 6 User 1",OrderDate=System.DateTime.Now,ProductFK=6, UserFK = 1},
            new Order   {OrderID=7, Name = "Order 7 Produto 7 User 2",OrderDate=System.DateTime.Now,ProductFK=7, UserFK = 2},
            new Order   {OrderID=8, Name = "Order 8 Produto 8 User 3",OrderDate=System.DateTime.Now,ProductFK=8, UserFK = 3},
            new Order   {OrderID=9, Name = "Order 9 Produto 9 User 4",OrderDate=System.DateTime.Now,ProductFK=9, UserFK = 4},
            new Order   {OrderID=10, Name = "Order 10 Produto 10 User 5",OrderDate=System.DateTime.Now,ProductFK=10, UserFK = 5},

         };

            orders.ForEach(dd => context.Order.AddOrUpdate(d => d.OrderID, dd));
            context.SaveChanges(); // commit


            // ############################################################################################
            // Registos Shipment(s)
            var shipments = new List<Shipment> {
            new Shipment   {ShipmentID=1, Name = "Shipment 1 Produto 1",Description="Shipment 1 Produto 1",EstimatedDeliveryDate=System.DateTime.Now, ProductFK=1},
            new Shipment   {ShipmentID=2, Name = "Shipment 2 Produto 1",Description="Shipment 2 Produto 1",EstimatedDeliveryDate=System.DateTime.Now,ProductFK=1},
            new Shipment   {ShipmentID=3, Name = "Shipment 3 Produto 3",Description="Shipment 3 Produto 3",EstimatedDeliveryDate=System.DateTime.Now,ProductFK=3},
            new Shipment   {ShipmentID=4, Name = "Shipment 4 Produto 4",Description="Shipment 4 Produto 4",EstimatedDeliveryDate=System.DateTime.Now,ProductFK=4},
            new Shipment   {ShipmentID=5, Name = "Shipment 5 Produto 5",Description="Shipment 5 Produto 5",EstimatedDeliveryDate=System.DateTime.Now,ProductFK=5},
            new Shipment   {ShipmentID=6, Name = "Shipment 6 Produto 6",Description="Shipment 6 Produto 6",EstimatedDeliveryDate=System.DateTime.Now,ProductFK=6},
            new Shipment   {ShipmentID=7, Name = "Shipment 7 Produto 7",Description="Shipment 7 Produto 7",EstimatedDeliveryDate=System.DateTime.Now,ProductFK=7},
            new Shipment   {ShipmentID=8, Name = "Shipment 8 Produto 8",Description="Shipment 8 Produto 8",EstimatedDeliveryDate=System.DateTime.Now,ProductFK=8},
            new Shipment   {ShipmentID=9, Name = "Shipment 9 Produto 9",Description="Shipment 9 Produto 9",EstimatedDeliveryDate=System.DateTime.Now,ProductFK=9},
            new Shipment   {ShipmentID=10, Name = "Shipment 10 Produto 10",Description="Shipment 10 Produto 10",EstimatedDeliveryDate=System.DateTime.Now,ProductFK=10},

         };

            noticeComments.ForEach(dd => context.NoticeComment.AddOrUpdate(d => d.NoticeCommentID, dd));
            context.SaveChanges(); // commit
 

             // ############################################################################################
             // Registos Role(s)
             var roles = new List<Role> {
             new Role   {RoleID=1, Name = "NormalUser", Description="NormalUser Description"},
             new Role   {RoleID=2, Name = "ContentAdmin", Description="Content Description"},
             new Role   {RoleID=3, Name = "StoreAdmin", Description="StoreAdmin Description"},
             new Role   {RoleID=4, Name = "Admin", Description="Admin Description"},
 
         };

        roles.ForEach(dd => context.Role.AddOrUpdate(d => d.RoleID, dd));
            context.SaveChanges(); // commit
        }

}
}

