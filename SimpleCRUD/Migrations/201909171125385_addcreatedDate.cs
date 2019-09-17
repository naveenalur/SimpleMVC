namespace SimpleCRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcreatedDate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "CreateDateTime", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "CreateDateTime");
        }
    }
}
