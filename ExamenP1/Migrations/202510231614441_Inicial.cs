namespace ExamenP1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entrenadors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreEntrenador = c.String(),
                        Region = c.String(),
                        Edad = c.Int(nullable: false),
                        PokemonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Pokemons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Tipo = c.String(),
                        NivelPoder = c.Int(nullable: false),
                        Habilidad = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Pokemons");
            DropTable("dbo.Entrenadors");
        }
    }
}
