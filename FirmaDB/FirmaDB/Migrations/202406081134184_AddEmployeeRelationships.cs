namespace FirmaDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmployeeRelationships : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Suggestions", "EmployeeId", c => c.Int(nullable: false));
            CreateIndex("dbo.Employees", "AccessLevelId");
            CreateIndex("dbo.HealthChecks", "EmployeeId");
            CreateIndex("dbo.JobTenures", "PositionId");
            CreateIndex("dbo.JobTenures", "EmployeeId");
            CreateIndex("dbo.Loanings", "EmployeeId");
            CreateIndex("dbo.Loanings", "LoanableItemsId");
            CreateIndex("dbo.Requests", "EmployeeId");
            CreateIndex("dbo.SickLeaves", "EmployeeId");
            CreateIndex("dbo.Suggestions", "EmployeeId");
            CreateIndex("dbo.Vacations", "EmployeeId");
            AddForeignKey("dbo.Employees", "AccessLevelId", "dbo.AccessLevels", "Id", cascadeDelete: true);
            AddForeignKey("dbo.HealthChecks", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.JobTenures", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.JobTenures", "PositionId", "dbo.Positions", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Loanings", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Loanings", "LoanableItemsId", "dbo.LoanableItems", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Requests", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.SickLeaves", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Suggestions", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Vacations", "EmployeeId", "dbo.Employees", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vacations", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Suggestions", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.SickLeaves", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Requests", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Loanings", "LoanableItemsId", "dbo.LoanableItems");
            DropForeignKey("dbo.Loanings", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.JobTenures", "PositionId", "dbo.Positions");
            DropForeignKey("dbo.JobTenures", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.HealthChecks", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Employees", "AccessLevelId", "dbo.AccessLevels");
            DropIndex("dbo.Vacations", new[] { "EmployeeId" });
            DropIndex("dbo.Suggestions", new[] { "EmployeeId" });
            DropIndex("dbo.SickLeaves", new[] { "EmployeeId" });
            DropIndex("dbo.Requests", new[] { "EmployeeId" });
            DropIndex("dbo.Loanings", new[] { "LoanableItemsId" });
            DropIndex("dbo.Loanings", new[] { "EmployeeId" });
            DropIndex("dbo.JobTenures", new[] { "EmployeeId" });
            DropIndex("dbo.JobTenures", new[] { "PositionId" });
            DropIndex("dbo.HealthChecks", new[] { "EmployeeId" });
            DropIndex("dbo.Employees", new[] { "AccessLevelId" });
            DropColumn("dbo.Suggestions", "EmployeeId");
        }
    }
}
