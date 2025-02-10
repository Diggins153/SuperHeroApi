using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SuperHeroApi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SuperHeros",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeroName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Abilities = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<double>(type: "float", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SuperHeros", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Villain",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VillainName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Place = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Abilities = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Health = table.Column<int>(type: "int", nullable: false),
                    Speed = table.Column<double>(type: "float", nullable: false),
                    Strength = table.Column<int>(type: "int", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villain", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "SuperHeros",
                columns: new[] { "id", "Abilities", "Description", "FirstName", "Health", "HeroName", "LastName", "Place", "Role", "Speed", "Strength" },
                values: new object[,]
                {
                    { 1, "Web-slinging, Wall-crawling, Spider sense", "A young man with spider-like abilities", "Peter", 100, "Spider-Man", "Parker", "New York", "Offensive", 15.0, 50 },
                    { 2, "Flight, Energy blasts, Genius intellect", "A billionaire inventor and superhero", "Tony", 200, "Iron Man", "Stark", "New York", "Offensive", 10.5, 75 },
                    { 3, "Super strength, Enhanced endurance, Shield", "A super-soldier enhanced by a serum", "Steve", 150, "Captain America", "Rogers", "Brooklyn, New York", "Defensive", 12.0, 80 },
                    { 4, "Super strength, Flight, Lightning control", "The God of Thunder, wielder of Mjolnir", "Thor", 250, "Thor", "Odinson", "Asgard", "Offensive", 11.0, 100 },
                    { 5, "Super strength, Agility, Vibranium suit", "The king of Wakanda with enhanced physical abilities", "T'Challa", 175, "Black Panther", "", "Wakanda", "Offensive", 14.0, 70 }
                });

            migrationBuilder.InsertData(
                table: "Villain",
                columns: new[] { "id", "Abilities", "Description", "FirstName", "Health", "LastName", "Place", "Role", "Speed", "Strength", "VillainName" },
                values: new object[,]
                {
                    { 1, "Glider, Pumpkin bombs, Super strength", "A dangerous foe with high-tech weapons", "Norman", 120, "Osborn", "New York", "Offensive", 10.0, 70, "Green Goblin" },
                    { 2, "Super strength, Immortality, Reality manipulation", "The Mad Titan with a quest for universal power", "Thanos", 250, "", "Titan", "Offensive", 8.5, 95, "Thanos" },
                    { 3, "Illusion casting, Shape-shifting, Magic", "The God of Mischief, brother of Thor", "Loki", 150, "", "Asgard", "Support", 13.0, 50, "Loki" },
                    { 4, "Magic, Super intellect, Energy blasts", "A genius with vast technological and magical powers", "Victor", 175, "Von Doom", "Latveria", "Offensive", 10.0, 80, "Doctor Doom" },
                    { 5, "Artificial intelligence, Super strength, Flight", "A rogue AI bent on global destruction", "Ultron", 200, "", "Unknown", "Offensive", 9.0, 90, "Ultron" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SuperHeros");

            migrationBuilder.DropTable(
                name: "Villain");
        }
    }
}
