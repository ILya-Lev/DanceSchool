namespace DanceSchool.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aboniments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Prise = c.Decimal(nullable: false, precision: 18, scale: 2),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DanceId = c.Int(nullable: false),
                        Level = c.Byte(nullable: false),
                        Aboniment_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dances", t => t.DanceId, cascadeDelete: true)
                .ForeignKey("dbo.Aboniments", t => t.Aboniment_Id)
                .Index(t => t.DanceId)
                .Index(t => t.Aboniment_Id);
            
            CreateTable(
                "dbo.Dances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Trainer_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trainers", t => t.Trainer_Id)
                .Index(t => t.Trainer_Id);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        CameToSchoolDate = c.DateTime(nullable: false),
                        PrizeId = c.Int(),
                        AbonimentId = c.Int(nullable: false),
                        Group_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Aboniments", t => t.AbonimentId, cascadeDelete: true)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.Prizes", t => t.PrizeId)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .Index(t => t.PersonId)
                .Index(t => t.PrizeId)
                .Index(t => t.AbonimentId)
                .Index(t => t.Group_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prizes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ContestName = c.String(),
                        WasGranted = c.DateTime(nullable: false),
                        Place = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Trainers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PersonId = c.Int(nullable: false),
                        Experience = c.Int(nullable: false),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PrizeId = c.Int(),
                        Group_Id = c.Int(),
                        Show_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.PersonId, cascadeDelete: true)
                .ForeignKey("dbo.Prizes", t => t.PrizeId)
                .ForeignKey("dbo.Groups", t => t.Group_Id)
                .ForeignKey("dbo.Shows", t => t.Show_Id)
                .Index(t => t.PersonId)
                .Index(t => t.PrizeId)
                .Index(t => t.Group_Id)
                .Index(t => t.Show_Id);
            
            CreateTable(
                "dbo.Shows",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IsActive = c.Boolean(nullable: false),
                        Name = c.String(),
                        DateOfShowing = c.DateTime(nullable: false),
                        PrizeId = c.Int(),
                        Dance_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Dances", t => t.Dance_Id)
                .ForeignKey("dbo.Prizes", t => t.PrizeId)
                .Index(t => t.PrizeId)
                .Index(t => t.Dance_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shows", "PrizeId", "dbo.Prizes");
            DropForeignKey("dbo.Trainers", "Show_Id", "dbo.Shows");
            DropForeignKey("dbo.Shows", "Dance_Id", "dbo.Dances");
            DropForeignKey("dbo.Groups", "Aboniment_Id", "dbo.Aboniments");
            DropForeignKey("dbo.Trainers", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Trainers", "PrizeId", "dbo.Prizes");
            DropForeignKey("dbo.Trainers", "PersonId", "dbo.People");
            DropForeignKey("dbo.Dances", "Trainer_Id", "dbo.Trainers");
            DropForeignKey("dbo.Students", "Group_Id", "dbo.Groups");
            DropForeignKey("dbo.Students", "PrizeId", "dbo.Prizes");
            DropForeignKey("dbo.Students", "PersonId", "dbo.People");
            DropForeignKey("dbo.Students", "AbonimentId", "dbo.Aboniments");
            DropForeignKey("dbo.Groups", "DanceId", "dbo.Dances");
            DropIndex("dbo.Shows", new[] { "Dance_Id" });
            DropIndex("dbo.Shows", new[] { "PrizeId" });
            DropIndex("dbo.Trainers", new[] { "Show_Id" });
            DropIndex("dbo.Trainers", new[] { "Group_Id" });
            DropIndex("dbo.Trainers", new[] { "PrizeId" });
            DropIndex("dbo.Trainers", new[] { "PersonId" });
            DropIndex("dbo.Students", new[] { "Group_Id" });
            DropIndex("dbo.Students", new[] { "AbonimentId" });
            DropIndex("dbo.Students", new[] { "PrizeId" });
            DropIndex("dbo.Students", new[] { "PersonId" });
            DropIndex("dbo.Dances", new[] { "Trainer_Id" });
            DropIndex("dbo.Groups", new[] { "Aboniment_Id" });
            DropIndex("dbo.Groups", new[] { "DanceId" });
            DropTable("dbo.Shows");
            DropTable("dbo.Trainers");
            DropTable("dbo.Prizes");
            DropTable("dbo.People");
            DropTable("dbo.Students");
            DropTable("dbo.Dances");
            DropTable("dbo.Groups");
            DropTable("dbo.Aboniments");
        }
    }
}
