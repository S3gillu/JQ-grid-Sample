namespace JQGRIDSAMPLE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MEmployeees",
                c => new
                    {
                        ID = c.String(nullable: false, maxLength: 128),
                        NAME = c.String(),
                        GENDER = c.String(),
                        MOBILE = c.String(),
                        LOCATION = c.String(),
                        COUNTRY = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.MEmployeees");
        }
    }
}
