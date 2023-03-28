using Microsoft.EntityFrameworkCore;
using ThinkGeo.Core;

namespace Map.Models
{
    public class MappingContext :DbContext
    {
        public MappingContext()
        {

        }
        public MappingContext(DbContextOptions<MappingContext> options): base(options)
        {
            
        }
        
        public virtual DbSet<MapColor> MapColors { get; set; }
        public virtual DbSet<VectorLayer> VectorLayers { get; set; }
        public virtual DbSet<RasterLayer> RasterLayers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MapColor>(entity =>
            {
                entity.ToTable(nameof(MapColor));
            });
            modelBuilder.Entity<VectorLayer>(entity =>
            {
                entity.ToTable(nameof(VectorLayer));
            });
            modelBuilder.Entity<RasterLayer>(entity =>
            {
                entity.ToTable(nameof(RasterLayer));
            });
        }
    }
    
    public class MapGeographyUnit
    {
        public GeographyUnit GeoUnit { get; set; }
        public string Name { get; set; } =null!;
    }
    public class MapColor
    {
        public MapColor(){
            Name = "White";
            Red = 255;
            Green = 255;
            Blue = 255;
            Alpha = 255;
            ValueStr = "ffffffff";
        }
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public byte Red { get; set; }
        public byte Green { get; set; }
        public byte Blue { get; set; }
        public byte Alpha { get; set; }
        public string ValueStr { get; set; } = null!;

    }
    public class VectorLayer
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string LayerType { get; set; } = null!;
        public string LayerDBName { get; set; } = null!;
        public string LayerTableName { get; set; } = null!;
        public int EPSGID { get; set; }
        public bool IsVisible { get; set; }
        public bool BoundaryVisible { get; set; }
        public bool CreateSpatialIdx { get; set; }
        public string LabelingDataField { get; set; } = null!;
        public int TextColor { get; set; }
        public int HighlightTextColor { get; set; }
        public int PenColor { get; set; }
        public int FillColor { get; set; }
        public int SelectedPenColor { get; set; }
        public int SelectedFillColor { get; set; }
        public bool LabelVisible { get; set; }
        public int LabelSize { get; set; }
        public int ZoomLevel { get; set; }
        public double CenterX { get; set; }
        public double CenterY { get; set; }
    }
    public class RasterLayer
    {
        public int ID { get; set; }
        public string Name { get; set; } = null!;
        public string LayerType { get; set; } = null!;
        public string LayerFileName { get; set; } = null!;
        public bool IsVisible { get; set; }
        public int Alpha { get; set; }
        public int RedTranslation { get; set; }
        public int GreenTranslation { get; set; }
        public int BlueTranslation { get; set; }
        public bool Nagative { get; set; }
        public bool GrayScale { get; set; }

    }
}
