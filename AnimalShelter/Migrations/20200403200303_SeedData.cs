using Microsoft.EntityFrameworkCore.Migrations;

namespace AnimalShelter.Solution.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "CatId", "Age", "Gender", "Name", "Traits" },
                values: new object[,]
                {
                    { 1, 3, "Female", "Maddie", "noisey" },
                    { 2, 11, "Female", "Juno", "playful" },
                    { 3, 12, "Female", "Dano", "bossy" },
                    { 4, 4, "Male", "Baby", "sleepy" },
                    { 5, 8, "Male", "Lion", "feisty" }
                });

            migrationBuilder.InsertData(
                table: "Dogs",
                columns: new[] { "DogId", "Age", "Gender", "Name", "Traits" },
                values: new object[,]
                {
                    { 1, 3, "Female", "Rilo", "Maddie" },
                    { 2, 11, "Female", "Mogley", "playful" },
                    { 3, 12, "Female", "Patricia", "bossy" },
                    { 4, 4, "Male", "Brownie", "sleepy" },
                    { 5, 8, "Male", "Rolf", "feisty" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "CatId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Dogs",
                keyColumn: "DogId",
                keyValue: 5);
        }
    }
}
