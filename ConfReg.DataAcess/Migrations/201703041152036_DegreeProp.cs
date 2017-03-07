namespace ConfReg.DataAcess.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DegreeProp : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Participants", "Degree", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Participants", "Degree", c => c.Int(nullable: false));
        }
    }
}
