namespace asp.net_Auth.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserEmailToCar : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "UserEmail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "UserEmail");
        }
    }
}
