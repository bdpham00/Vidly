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
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeID, Birthdate) VALUES (4, 'Bao', 'True', 4, 8/24/2016)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeID, Birthdate) VALUES (4, 'John', 'True', 4, 8/24/2016)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeID, Birthdate) VALUES (4, 'Steve', 'True', 4, 8/24/2016)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeID, Birthdate) VALUES (4, 'Jake', 'True', 4, 8/24/2016)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeID, Birthdate) VALUES (4, 'Andrew', 'True', 4, 8/24/2016)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeID, Birthdate) VALUES (4, 'Jayden', 'True', 4, 8/24/2016)");
            Sql("INSERT INTO Customers (Id, Name, IsSubscribedToNewsLetter, MembershipTypeID, Birthdate) VALUES (4, 'Mary', 'True', 4, 8/24/2016)");
        }
        
        public override void Down()
        {
        }
    }
}
