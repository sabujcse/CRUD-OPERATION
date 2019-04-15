namespace FirstEFApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Customer_Name_required_Product_New1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Shops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Products", "ShopId", c => c.Int(nullable: false));
            CreateIndex("dbo.Products", "ShopId");
            AddForeignKey("dbo.Products", "ShopId", "dbo.Shops", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "ShopId", "dbo.Shops");
            DropIndex("dbo.Products", new[] { "ShopId" });
            DropColumn("dbo.Products", "ShopId");
            DropTable("dbo.Shops");
        }
    }
}
