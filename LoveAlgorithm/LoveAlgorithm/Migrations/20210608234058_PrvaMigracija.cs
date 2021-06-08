using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace LoveAlgorithm.Migrations
{
    public partial class PrvaMigracija : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pitanja",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Pitanje = table.Column<string>(nullable: true),
                    Odgovor = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pitanja", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RegistrovaniKorisnik",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    KorisnickoIme = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Lozinka = table.Column<string>(nullable: false),
                    Ime = table.Column<string>(nullable: true),
                    Prezime = table.Column<string>(nullable: true),
                    Grad = table.Column<string>(nullable: true),
                    Drzava = table.Column<string>(nullable: true),
                    DatumRodjenja = table.Column<DateTime>(nullable: false),
                    Opis = table.Column<string>(nullable: true),
                    KorisnickiPodaci = table.Column<string>(nullable: true),
                    Pol = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegistrovaniKorisnik", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Chat",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Korisnik1ID = table.Column<int>(nullable: true),
                    Korisnik2ID = table.Column<int>(nullable: true),
                    PotvrdaAdministratora = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chat", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Chat_RegistrovaniKorisnik_Korisnik1ID",
                        column: x => x.Korisnik1ID,
                        principalTable: "RegistrovaniKorisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Chat_RegistrovaniKorisnik_Korisnik2ID",
                        column: x => x.Korisnik2ID,
                        principalTable: "RegistrovaniKorisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Poruka",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    PrimalacID = table.Column<int>(nullable: true),
                    PosiljalacID = table.Column<int>(nullable: true),
                    PorukaTxt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Poruka", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Poruka_RegistrovaniKorisnik_PosiljalacID",
                        column: x => x.PosiljalacID,
                        principalTable: "RegistrovaniKorisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Poruka_RegistrovaniKorisnik_PrimalacID",
                        column: x => x.PrimalacID,
                        principalTable: "RegistrovaniKorisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Recenzije",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Komentar = table.Column<string>(nullable: true),
                    Ocjena = table.Column<double>(nullable: false),
                    Korisnik1ID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recenzije", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Recenzije_RegistrovaniKorisnik_Korisnik1ID",
                        column: x => x.Korisnik1ID,
                        principalTable: "RegistrovaniKorisnik",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Korisnik1ID",
                table: "Chat",
                column: "Korisnik1ID");

            migrationBuilder.CreateIndex(
                name: "IX_Chat_Korisnik2ID",
                table: "Chat",
                column: "Korisnik2ID");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_PosiljalacID",
                table: "Poruka",
                column: "PosiljalacID");

            migrationBuilder.CreateIndex(
                name: "IX_Poruka_PrimalacID",
                table: "Poruka",
                column: "PrimalacID");

            migrationBuilder.CreateIndex(
                name: "IX_Recenzije_Korisnik1ID",
                table: "Recenzije",
                column: "Korisnik1ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Chat");

            migrationBuilder.DropTable(
                name: "Pitanja");

            migrationBuilder.DropTable(
                name: "Poruka");

            migrationBuilder.DropTable(
                name: "Recenzije");

            migrationBuilder.DropTable(
                name: "RegistrovaniKorisnik");
        }
    }
}
