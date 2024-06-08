namespace FirmaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRelationships : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Children", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Children", "EmployeeId");
            AddForeignKey("dbo.Children", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Children", "EmployeeId", "dbo.Employees");
            DropIndex("dbo.Children", new[] { "EmployeeId" });
            AlterColumn("dbo.Children", "EmployeeId", c => c.String());
        }
    }
}
