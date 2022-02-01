namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migdateupdate : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Data", "DataName");
            DropColumn("dbo.Data", "DataTime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Data", "DataTime", c => c.DateTime(nullable: false));
            AddColumn("dbo.Data", "DataName", c => c.String());
        }
    }
}
