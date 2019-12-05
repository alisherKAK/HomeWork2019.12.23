namespace asp.net_Auth.MigrationsOwn
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAsdfsf : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Asdfs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Brand = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Asdfs");
        }
    }
}
