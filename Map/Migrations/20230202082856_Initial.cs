using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Map.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MapColor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Red = table.Column<byte>(type: "tinyint", nullable: false),
                    Green = table.Column<byte>(type: "tinyint", nullable: false),
                    Blue = table.Column<byte>(type: "tinyint", nullable: false),
                    Alpha = table.Column<byte>(type: "tinyint", nullable: false),
                    ValueStr = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MapColor", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "RasterLayer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LayerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LayerFileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    Alpha = table.Column<int>(type: "int", nullable: false),
                    RedTranslation = table.Column<int>(type: "int", nullable: false),
                    GreenTranslation = table.Column<int>(type: "int", nullable: false),
                    BlueTranslation = table.Column<int>(type: "int", nullable: false),
                    Nagative = table.Column<bool>(type: "bit", nullable: false),
                    GrayScale = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RasterLayer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VectorLayer",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LayerType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LayerDBName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LayerTableName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EPSGID = table.Column<int>(type: "int", nullable: false),
                    IsVisible = table.Column<bool>(type: "bit", nullable: false),
                    BoundaryVisible = table.Column<bool>(type: "bit", nullable: false),
                    CreateSpatialIdx = table.Column<bool>(type: "bit", nullable: false),
                    LabelingDataField = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TextColor = table.Column<int>(type: "int", nullable: false),
                    HighlightTextColor = table.Column<int>(type: "int", nullable: false),
                    PenColor = table.Column<int>(type: "int", nullable: false),
                    FillColor = table.Column<int>(type: "int", nullable: false),
                    SelectedPenColor = table.Column<int>(type: "int", nullable: false),
                    SelectedFillColor = table.Column<int>(type: "int", nullable: false),
                    LabelVisible = table.Column<bool>(type: "bit", nullable: false),
                    LabelSize = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VectorLayer", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MapColor");

            migrationBuilder.DropTable(
                name: "RasterLayer");

            migrationBuilder.DropTable(
                name: "VectorLayer");
        }
    }
}
