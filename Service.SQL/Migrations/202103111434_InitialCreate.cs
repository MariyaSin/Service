using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Service.ModeldsDB;
using System;

namespace Service.SQL.Migrations
{
    [DbContext(typeof(ServiceDBContext))]
    [Migration("202103111434_InitialCreate")]
    public class InitialCreate : Migration
    {
        public void CreateTableService(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: DbUser.TableName,
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<String>(nullable: false),
                    Nickname = table.Column<String>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserKey", x => x.Id);
                });
        }
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            CreateTableService(migrationBuilder);
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(DbUser.TableName);
        }
    }
}
