namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Customers ON");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeID, Birthdate) VALUES (4, 'Chris', 'True', 4, 8/24/2016)");
        }
        
        public override void Down()
        {
        }
    }
}
