namespace ExamenP1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.Entrenadors", "PokemonId");
            AddForeignKey("dbo.Entrenadors", "PokemonId", "dbo.Pokemons", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Entrenadors", "PokemonId", "dbo.Pokemons");
            DropIndex("dbo.Entrenadors", new[] { "PokemonId" });
        }
    }
}
