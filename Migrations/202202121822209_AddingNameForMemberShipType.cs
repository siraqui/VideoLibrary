namespace Vidlib_v2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingNameForMemberShipType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.MemberShipTypes", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.MemberShipTypes", "Name");
        }
    }
}
