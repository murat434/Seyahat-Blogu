namespace TravelTripProje.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelGuncelleme : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Yorumlars", "KullaniciAdi", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Yorumlars", "Mail", c => c.String(nullable: false));
            AlterColumn("dbo.Yorumlars", "Yorum", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Yorumlars", "Yorum", c => c.String());
            AlterColumn("dbo.Yorumlars", "Mail", c => c.String());
            AlterColumn("dbo.Yorumlars", "KullaniciAdi", c => c.String());
        }
    }
}
