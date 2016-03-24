namespace ModelLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Date = c.DateTime(nullable: false),
                        Minutes = c.Int(nullable: false),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
            CreateTable(
                "dbo.Sources",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Chapter = c.Int(),
                        StartPage = c.Int(),
                        EndPage = c.Int(),
                        Url = c.String(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                        PageType_Id = c.Int(),
                        Activity_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.PageTypes", t => t.PageType_Id)
                .ForeignKey("dbo.Activities", t => t.Activity_Id)
                .Index(t => t.PageType_Id)
                .Index(t => t.Activity_Id);
            
            CreateTable(
                "dbo.PageTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Deadline = c.DateTime(nullable: false),
                        Comment = c.String(),
                        Client_Id = c.Int(),
                        ProjectType_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clients", t => t.Client_Id)
                .ForeignKey("dbo.ProjectTypes", t => t.ProjectType_Id)
                .Index(t => t.Client_Id)
                .Index(t => t.ProjectType_Id);
            
            CreateTable(
                "dbo.ProjectTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.Projects", "ProjectType_Id", "dbo.ProjectTypes");
            DropForeignKey("dbo.Projects", "Client_Id", "dbo.Clients");
            DropForeignKey("dbo.Activities", "Project_Id", "dbo.Projects");
            DropForeignKey("dbo.Sources", "Activity_Id", "dbo.Activities");
            DropForeignKey("dbo.Sources", "PageType_Id", "dbo.PageTypes");
            DropIndex("dbo.Tags", new[] { "Project_Id" });
            DropIndex("dbo.Projects", new[] { "ProjectType_Id" });
            DropIndex("dbo.Projects", new[] { "Client_Id" });
            DropIndex("dbo.Sources", new[] { "Activity_Id" });
            DropIndex("dbo.Sources", new[] { "PageType_Id" });
            DropIndex("dbo.Activities", new[] { "Project_Id" });
            DropTable("dbo.Tags");
            DropTable("dbo.ProjectTypes");
            DropTable("dbo.Projects");
            DropTable("dbo.Clients");
            DropTable("dbo.PageTypes");
            DropTable("dbo.Sources");
            DropTable("dbo.Activities");
        }
    }
}
