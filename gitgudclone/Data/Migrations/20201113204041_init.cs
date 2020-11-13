using Microsoft.EntityFrameworkCore.Migrations;

namespace gitgudclone.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "adminList",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    adminEmail = table.Column<string>(type: "TEXT", nullable: true),
                    adminScreenName = table.Column<string>(type: "TEXT", nullable: true),
                    adminPost = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_adminList", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "postsList",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    postBody = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postsList", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "userList",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userEmail = table.Column<string>(type: "TEXT", nullable: true),
                    userScreenName = table.Column<string>(type: "TEXT", nullable: true),
                    userPost = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userList", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "favoriteList",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userEmail = table.Column<string>(type: "TEXT", nullable: true),
                    userFav = table.Column<bool>(type: "INTEGER", nullable: false),
                    AdminModelid = table.Column<int>(type: "INTEGER", nullable: true),
                    UserModelid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_favoriteList", x => x.id);
                    table.ForeignKey(
                        name: "FK_favoriteList_adminList_AdminModelid",
                        column: x => x.AdminModelid,
                        principalTable: "adminList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_favoriteList_userList_UserModelid",
                        column: x => x.UserModelid,
                        principalTable: "userList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "messagesList",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userEmail = table.Column<string>(type: "TEXT", nullable: true),
                    recipientEmail = table.Column<string>(type: "TEXT", nullable: true),
                    textBody = table.Column<string>(type: "TEXT", nullable: true),
                    AdminModelid = table.Column<int>(type: "INTEGER", nullable: true),
                    UserModelid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_messagesList", x => x.id);
                    table.ForeignKey(
                        name: "FK_messagesList_adminList_AdminModelid",
                        column: x => x.AdminModelid,
                        principalTable: "adminList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_messagesList_userList_UserModelid",
                        column: x => x.UserModelid,
                        principalTable: "userList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "notificationsList",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    userEmail = table.Column<string>(type: "TEXT", nullable: true),
                    isUrgent = table.Column<bool>(type: "INTEGER", nullable: false),
                    notificationText = table.Column<string>(type: "TEXT", nullable: true),
                    AdminModelid = table.Column<int>(type: "INTEGER", nullable: true),
                    UserModelid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_notificationsList", x => x.id);
                    table.ForeignKey(
                        name: "FK_notificationsList_adminList_AdminModelid",
                        column: x => x.AdminModelid,
                        principalTable: "adminList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_notificationsList_userList_UserModelid",
                        column: x => x.UserModelid,
                        principalTable: "userList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "postQueueList",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    authorEmail = table.Column<string>(type: "TEXT", nullable: true),
                    postBody = table.Column<string>(type: "TEXT", nullable: true),
                    AdminModelid = table.Column<int>(type: "INTEGER", nullable: true),
                    UserModelid = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_postQueueList", x => x.id);
                    table.ForeignKey(
                        name: "FK_postQueueList_adminList_AdminModelid",
                        column: x => x.AdminModelid,
                        principalTable: "adminList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_postQueueList_userList_UserModelid",
                        column: x => x.UserModelid,
                        principalTable: "userList",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_favoriteList_AdminModelid",
                table: "favoriteList",
                column: "AdminModelid");

            migrationBuilder.CreateIndex(
                name: "IX_favoriteList_UserModelid",
                table: "favoriteList",
                column: "UserModelid");

            migrationBuilder.CreateIndex(
                name: "IX_messagesList_AdminModelid",
                table: "messagesList",
                column: "AdminModelid");

            migrationBuilder.CreateIndex(
                name: "IX_messagesList_UserModelid",
                table: "messagesList",
                column: "UserModelid");

            migrationBuilder.CreateIndex(
                name: "IX_notificationsList_AdminModelid",
                table: "notificationsList",
                column: "AdminModelid");

            migrationBuilder.CreateIndex(
                name: "IX_notificationsList_UserModelid",
                table: "notificationsList",
                column: "UserModelid");

            migrationBuilder.CreateIndex(
                name: "IX_postQueueList_AdminModelid",
                table: "postQueueList",
                column: "AdminModelid");

            migrationBuilder.CreateIndex(
                name: "IX_postQueueList_UserModelid",
                table: "postQueueList",
                column: "UserModelid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "favoriteList");

            migrationBuilder.DropTable(
                name: "messagesList");

            migrationBuilder.DropTable(
                name: "notificationsList");

            migrationBuilder.DropTable(
                name: "postQueueList");

            migrationBuilder.DropTable(
                name: "postsList");

            migrationBuilder.DropTable(
                name: "adminList");

            migrationBuilder.DropTable(
                name: "userList");
        }
    }
}
