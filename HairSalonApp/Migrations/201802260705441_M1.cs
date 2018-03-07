namespace HairSalonApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class M1 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Appointments", "customer_ID", "dbo.Customers");
            DropIndex("dbo.Appointments", new[] { "customer_ID" });
            AlterColumn("dbo.Appointments", "customer_ID", c => c.Int());
            CreateIndex("dbo.Appointments", "customer_ID");
            AddForeignKey("dbo.Appointments", "customer_ID", "dbo.Customers", "ID");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Appointments", "customer_ID", "dbo.Customers");
            DropIndex("dbo.Appointments", new[] { "customer_ID" });
            AlterColumn("dbo.Appointments", "customer_ID", c => c.Int(nullable: false));
            CreateIndex("dbo.Appointments", "customer_ID");
            AddForeignKey("dbo.Appointments", "customer_ID", "dbo.Customers", "ID", cascadeDelete: true);
        }
    }
}
