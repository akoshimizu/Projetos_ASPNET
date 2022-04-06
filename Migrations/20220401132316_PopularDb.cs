using Microsoft.EntityFrameworkCore.Migrations;

namespace PROJETO.Migrations
{
    public partial class PopularDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql("INSERT INTO ASPNETUSERS (Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount) VALUES ('91e4dc11-e877-401b-91c2-6e500aadc7b9', 'anderson@anderson.com', 'ANDERSON@ANDERSON.COM', 'anderson@anderson.com', 'ANDERSON@ANDERSON.COM', '0', 'AQAAAAEAACcQAAAAEKKy2ZhqcyI7M8677hpCPjIRHMG2PXL1oZmUefdhXl5PVZ5LBPrYqVUWNa4xgXI1Lw==', 'FAEJ5DNKRHQRS7YDNGXGUTBBI22T6KGM', '776bba4b-97ea-49dd-9afd-99b12d59b5ae', NULL, '0', '0', NULL, '1', '0')");
            migrationBuilder.Sql("INSERT INTO ASPNETUSERS (Id, UserName, NormalizedUserName, Email, NormalizedEmail, EmailConfirmed, PasswordHash, SecurityStamp, ConcurrencyStamp, PhoneNumber, PhoneNumberConfirmed, TwoFactorEnabled, LockoutEnd, LockoutEnabled, AccessFailedCount) VALUES ('d30d57a8-fa18-4d68-959c-4afbb23c90fc', 'admin@admin.com', 'ADMIN@ADMIN.COM', 'admin@admin.com', 'ADMIN@ADMIN.COM', '0', 'AQAAAAEAACcQAAAAEElIJ0NdjwuSU9/kRIlTA58AzGFH0O52wLVbJOu5Gt1t5UDcRYuAYW6kvOMbMXdd2w==', '7KREUYTQ4VIGWDU6WELABKYK2ML6CQPH', '6126f2f4-3a11-4b05-8f0a-6bc5fb4a0fc6', NULL, '0', '0', NULL, '1', '0')");

            migrationBuilder.Sql("INSERT INTO categorias(NOMECATEGORIA) VALUES ('Rock')");
            migrationBuilder.Sql("INSERT INTO categorias(NOMECATEGORIA) VALUES ('Pop')");
            migrationBuilder.Sql("INSERT INTO categorias(NOMECATEGORIA) VALUES ('Sertanejo')");
            migrationBuilder.Sql("INSERT INTO categorias(NOMECATEGORIA) VALUES ('Comédia')");
            migrationBuilder.Sql("INSERT INTO categorias(NOMECATEGORIA) VALUES ('MPB')");
            migrationBuilder.Sql("INSERT INTO categorias(NOMECATEGORIA) VALUES ('Samba')");

	        migrationBuilder.Sql("INSERT INTO locais(NOMEDOLOCAL) VALUES ('Allianz Arena')");
            migrationBuilder.Sql("INSERT INTO locais(NOMEDOLOCAL) VALUES ('Espaço das Américas')");
            migrationBuilder.Sql("INSERT INTO locais(NOMEDOLOCAL) VALUES ('Credicard Hall')");
            migrationBuilder.Sql("INSERT INTO locais(NOMEDOLOCAL) VALUES ('Hillarius Comedy Bar')");
            migrationBuilder.Sql("INSERT INTO locais(NOMEDOLOCAL) VALUES ('Vila Country')");
		
            migrationBuilder.Sql("INSERT INTO eventos (Nome, CATEGORIAID, LOCALID, DATA, PRECO, QUANTIDADEINGRESSO,STATUS) VALUES('Iron Maiden', 1, 1, '2022-04-30 00:00:00.000000', 1000, 2000, 1)");
            migrationBuilder.Sql("INSERT INTO eventos (Nome, CATEGORIAID, LOCALID, DATA, PRECO, QUANTIDADEINGRESSO,STATUS) VALUES('Afonso Padilha', 4, 4, '2022-04-23 00:00:00.000000', 100, 500, 1)");
            migrationBuilder.Sql("INSERT INTO eventos (Nome, CATEGORIAID, LOCALID, DATA, PRECO, QUANTIDADEINGRESSO,STATUS) VALUES('Gustavo Lima', 3, 5, '2022-03-26 00:00:00.000000', 300, 1000, 0)");
            migrationBuilder.Sql("INSERT INTO eventos (Nome, CATEGORIAID, LOCALID, DATA, PRECO, QUANTIDADEINGRESSO,STATUS) VALUES('Dua Lipa', 2, 3, '2022-03-26 00:00:00.000000', 1000, 10000, 0)");
            migrationBuilder.Sql("INSERT INTO eventos (Nome, CATEGORIAID, LOCALID, DATA, PRECO, QUANTIDADEINGRESSO,STATUS) VALUES('Pink Floyd', 1, 2, '2022-04-26 00:00:00.000000', 300, 1000, 1)");
            migrationBuilder.Sql("INSERT INTO eventos (Nome, CATEGORIAID, LOCALID, DATA, PRECO, QUANTIDADEINGRESSO,STATUS) VALUES('The Beatles', 1, 3, '2022-04-26 00:00:00.000000', 300, 1000, 1)");
            migrationBuilder.Sql("INSERT INTO eventos (Nome, CATEGORIAID, LOCALID, DATA, PRECO, QUANTIDADEINGRESSO,STATUS) VALUES('Seu Jorge', 5, 2, '2022-04-30 00:00:00.000000', 400, 500, 1)");
            migrationBuilder.Sql("INSERT INTO eventos (Nome, CATEGORIAID, LOCALID, DATA, PRECO, QUANTIDADEINGRESSO,STATUS) VALUES('Bruno Mars', 2, 3, '2022-05-07 00:00:00.000000', 1000, 10000, 1)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE From aspnetusers");
            migrationBuilder.Sql("DELETE From categorias");
            migrationBuilder.Sql("DELETE From locais");
            migrationBuilder.Sql("DELETE From eventos");
        }
    }
}
