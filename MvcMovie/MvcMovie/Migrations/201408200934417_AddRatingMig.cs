namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRatingMig : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "MovieRating", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "MovieRating");
        }
    }
}
