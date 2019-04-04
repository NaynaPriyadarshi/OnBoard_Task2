namespace MVC_CRUDE_API_TASK2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class clr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Address", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Address", c => c.String());
        }
    }
}
