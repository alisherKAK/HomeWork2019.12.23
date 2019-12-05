namespace asp.net_Auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LinkCarsToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "UserId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "UserId");
        }
    }
}
