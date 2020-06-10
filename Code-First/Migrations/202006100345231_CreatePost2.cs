namespace Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreatePost2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "newProperty", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "newProperty");
        }
    }
}
