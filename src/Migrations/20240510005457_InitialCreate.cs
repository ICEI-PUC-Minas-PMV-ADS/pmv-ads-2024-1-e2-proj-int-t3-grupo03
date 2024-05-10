using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kippa.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id_Usuario = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Nome = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Profissao = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Objetivo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DataCadastro = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuario__63C76BE2788B1FD5", x => x.Id_Usuario);
                });

            migrationBuilder.CreateTable(
                name: "Lembrete",
                columns: table => new
                {
                    Id_Lembrete = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario_Id = table.Column<int>(type: "int", nullable: true),
                    Nome_Lembrete = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    DataLembrete = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Hora_Lembrete = table.Column<TimeOnly>(type: "time", nullable: true),
                    Notificacoes = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Lembrete__6A2A398C3F7414E0", x => x.Id_Lembrete);
                    table.ForeignKey(
                        name: "fk_Lembrete_Usuario_1",
                        column: x => x.Usuario_Id,
                        principalTable: "Usuario",
                        principalColumn: "Id_Usuario");
                });

            migrationBuilder.CreateTable(
                name: "Tarefa",
                columns: table => new
                {
                    Id_Tarefa = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario_Id = table.Column<int>(type: "int", nullable: true),
                    Data_Tarefa = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Hora_Tarefa = table.Column<TimeOnly>(type: "time", nullable: true),
                    Tipo_Tarefa = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Tarefa__0F2013DB955AFE74", x => x.Id_Tarefa);
                    table.ForeignKey(
                        name: "fk_Tarefa_Usuario_1",
                        column: x => x.Usuario_Id,
                        principalTable: "Usuario",
                        principalColumn: "Id_Usuario");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Lembrete_Usuario_Id",
                table: "Lembrete",
                column: "Usuario_Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tarefa_Usuario_Id",
                table: "Tarefa",
                column: "Usuario_Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Lembrete");

            migrationBuilder.DropTable(
                name: "Tarefa");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
