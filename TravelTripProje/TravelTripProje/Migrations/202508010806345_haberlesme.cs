namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class haberlesme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
           "dbo.haberlesmes",
           c => new
           {
               ID = c.Int(nullable: false, identity: true),
               AdSoyad = c.String(nullable: false),
               Mail = c.String(nullable: false),
               Konu = c.String(nullable: false),
               Mesaj = c.String(nullable: false),
           })
           .PrimaryKey(t => t.ID);


             //AlterColumn("dbo.haberlesmes", "AdSoyad", c => c.String(nullable: false, maxLength: 100));
            //AlterColumn("dbo.haberlesmes", "Mail", c => c.String(nullable: false));
            //AlterColumn("dbo.haberlesmes", "Konu", c => c.String(nullable: false, maxLength: 100));
           //AlterColumn("dbo.haberlesmes", "Mesaj", c => c.String(nullable: false, maxLength: 1000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.haberlesmes", "Mesaj", c => c.String());
            AlterColumn("dbo.haberlesmes", "Konu", c => c.String());
            AlterColumn("dbo.haberlesmes", "Mail", c => c.String());
            AlterColumn("dbo.haberlesmes", "AdSoyad", c => c.String());
            RenameTable(name: "dbo.haberlesmes", newName: "iletisims");
        }
    }
}
