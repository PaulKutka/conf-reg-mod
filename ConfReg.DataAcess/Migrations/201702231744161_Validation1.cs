namespace ConfReg.DataAcess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Participants", "Name", c => c.String(nullable: false));
            AlterColumn("dbo.Participants", "Surname", c => c.String(nullable: false));
            AlterColumn("dbo.Participants", "Institution", c => c.String(nullable: false));
            AlterColumn("dbo.Participants", "Email", c => c.String(nullable: false));
            //AlterColumn("dbo.Participants", "ConfirmedEmail", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Participants", "PhoneNumber", c => c.String(nullable: false));
            AlterColumn("dbo.Participants", "AnnName", c => c.String(nullable: false));
            AlterColumn("dbo.Participants", "AnnAuthorsAndAff", c => c.String(nullable: false));
            AlterColumn("dbo.Participants", "AnnSummary", c => c.String(nullable: false, maxLength: 400));
            AlterColumn("dbo.Participants", "InvoiceReq", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Participants", "InvoiceReq", c => c.Int(nullable: false));
            AlterColumn("dbo.Participants", "AnnSummary", c => c.String());
            AlterColumn("dbo.Participants", "AnnAuthorsAndAff", c => c.String());
            AlterColumn("dbo.Participants", "AnnName", c => c.String());
            AlterColumn("dbo.Participants", "PhoneNumber", c => c.String());
            AlterColumn("dbo.Participants", "Email", c => c.String());
            //AlterColumn("dbo.Participants", "ConfirmedEmail", c => c.Boolean());
            AlterColumn("dbo.Participants", "Institution", c => c.String());
            AlterColumn("dbo.Participants", "Surname", c => c.String());
            AlterColumn("dbo.Participants", "Name", c => c.String());
        }
    }
}
