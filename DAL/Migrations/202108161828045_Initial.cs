namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buckets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CreationDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Goods",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Single(nullable: false),
                        Shop = c.String(),
                        Quantity = c.Single(nullable: false),
                        Picture = c.String(),
                        Description = c.String(),
                        Name = c.String(),
                        Type = c.Int(nullable: false),
                        BucketId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buckets", t => t.BucketId)
                .Index(t => t.BucketId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Goods", "BucketId", "dbo.Buckets");
            DropIndex("dbo.Goods", new[] { "BucketId" });
            DropTable("dbo.Goods");
            DropTable("dbo.Buckets");
        }
    }
}
