namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneSütunuEklendi : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "PhoneNumber", c => c.String(maxLength: 11));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "PhoneNumber");
        }
    }
}
