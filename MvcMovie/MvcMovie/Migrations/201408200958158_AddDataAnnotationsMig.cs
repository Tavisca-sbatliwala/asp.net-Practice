namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataAnnotationsMig : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Movies", "MovieTitle", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "Genre", c => c.String(nullable: false));
            AlterColumn("dbo.Movies", "MovieRating", c => c.String(maxLength: 3));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Movies", "MovieRating", c => c.String());
            AlterColumn("dbo.Movies", "Genre", c => c.String());
            AlterColumn("dbo.Movies", "MovieTitle", c => c.String());
        }
    }
}
