namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeGenreRequirement : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
        }
    }
}
