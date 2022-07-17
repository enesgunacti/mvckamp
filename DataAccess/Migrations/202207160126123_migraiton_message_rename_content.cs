namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migraiton_message_rename_content : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "MessageContent", c => c.String());
            DropColumn("dbo.Messages", "MessageContect");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Messages", "MessageContect", c => c.String());
            DropColumn("dbo.Messages", "MessageContent");
        }
    }
}
