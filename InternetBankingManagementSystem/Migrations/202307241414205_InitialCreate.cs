namespace InternetBankingManagementSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UserRegistrationModels",
                c => new
                    {
                        AccountNumber = c.String(nullable: false, maxLength: 128),
                        LoginPassword = c.String(nullable: false),
                        ConfirmLoginPassword = c.String(),
                        TransactionPassword = c.String(nullable: false),
                        ConfirmTransactionPassword = c.String(),
                        OTP = c.String(),
                    })
                .PrimaryKey(t => t.AccountNumber);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UserRegistrationModels");
        }
    }
}
