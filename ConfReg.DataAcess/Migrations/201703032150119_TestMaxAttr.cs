namespace ConfReg.DataAcess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TestMaxAttr : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Participants", "AnnSummary", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Participants", "AnnSummary", c => c.String(nullable: false, maxLength: 400));
        }
    }
}
