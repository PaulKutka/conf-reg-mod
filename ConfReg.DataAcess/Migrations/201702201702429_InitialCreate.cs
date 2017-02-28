namespace ConfReg.DataAcess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Participants",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Degree = c.Int(nullable: false),
                        Name = c.String(),
                        Surname = c.String(),
                        Institution = c.String(),
                        Email = c.String(),
                        ConfirmedEmail = c.Boolean(),
                        PhoneNumber = c.String(),
                        AnnName = c.String(),
                        AnnAuthorsAndAff = c.String(),
                        AnnSummary = c.String(),
                        RoomType = c.Int(nullable: false),
                        AccPerson = c.Int(nullable: false),
                        InvoiceReq = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Participants");
        }
    }
}
