namespace WestSprings.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class directorychanges : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Directories", "email", c => c.String());
            AddColumn("dbo.Directories", "birthday", c => c.String());
            AddColumn("dbo.Directories", "anniversary", c => c.String());
            AddColumn("dbo.Directories", "children", c => c.String());
            AddColumn("dbo.Directories", "childbirthday", c => c.String());
            AlterColumn("dbo.Directories", "firstname", c => c.String(nullable: false));
            AlterColumn("dbo.Directories", "lastname", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Directories", "lastname", c => c.String());
            AlterColumn("dbo.Directories", "firstname", c => c.String());
            DropColumn("dbo.Directories", "childbirthday");
            DropColumn("dbo.Directories", "children");
            DropColumn("dbo.Directories", "anniversary");
            DropColumn("dbo.Directories", "birthday");
            DropColumn("dbo.Directories", "email");
        }
    }
}
