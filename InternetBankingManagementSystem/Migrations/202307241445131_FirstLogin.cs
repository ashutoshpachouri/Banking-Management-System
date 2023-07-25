namespace InternetBankingManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstLogin : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserLoginModels",
                c => new
                    {
                        UserID = c.String(nullable: false, maxLength: 128),
                        LoginPassword = c.String(),
                    })
                .PrimaryKey(t => t.UserID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserLoginModels");
        }
    }
}
