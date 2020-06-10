namespace Code_First.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changetypeofcolumn : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Title", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String());
        }
    }
}
