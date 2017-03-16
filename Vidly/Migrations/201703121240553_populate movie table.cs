namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populatemovietable : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, NumberInStock, DateAdded, GenreId) VALUES (1, 'Hangover',  '06/10/2009',  3, GETDATE(), 1)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, NumberInStock, DateAdded, GenreId) VALUES (2, 'Die Hard',  '09/30/1988',  2, GETDATE(), 2)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, NumberInStock, DateAdded, GenreId) VALUES (3, 'The Terminator',  '02/08/1985',  5, GETDATE(), 2)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, NumberInStock, DateAdded, GenreId) VALUES (4, 'Titanic',  '11/18/1997',  3, GETDATE(), 4)");
            Sql("SET IDENTITY_INSERT Movies OFF");
        }
        
        public override void Down()
        {
        }
    }
}
