namespace MVCBLOG_PROJE.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YeniSutunlarUyeTablosuna : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uyes", "Yazar", c => c.Boolean(nullable: false));
            AddColumn("dbo.Uyes", "Onaylandimi", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Uyes", "Onaylandimi");
            DropColumn("dbo.Uyes", "Yazar");
        }
    }
}
