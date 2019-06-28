namespace Dragon.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Dragon", newName: "DragonEntity");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.DragonEntity", newName: "Dragon");
        }
    }
}
