namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieTable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (1,'Hangover', 'Comedy', 02/23/2006, 07/05/2016, 2)");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (2,'Die Hard', 'Action', 05/13/2001, 07/05/2016, 5)");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (3,'The Terminator', 'Action', 12/23/1992, 07/05/2016, 6)");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (4,'Toy Story', 'Family', 11/2/2015, 07/05/2016, 3)");
            Sql("INSERT INTO Movies (Id, Name, Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (5,'Titanic', 'Romance', 03/15/1995, 07/05/2016, 12)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
