namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddValuesToGenreIdColumn : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET GenreId = 5 WHERE Genre = 'Comedy'");
            Sql("UPDATE Movies SET GenreId = 1 WHERE Genre = 'Action'");
            Sql("UPDATE Movies SET GenreId = 3 WHERE Genre = 'Family'");
            Sql("UPDATE Movies SET GenreId = 4 WHERE Genre = 'Romance'");
        }
        
        public override void Down()
        {
            
        }
    }
}
