using Map.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Map.Data
{
    public class MappingService
    {
        private MappingContext _context;
        public MappingService(MappingContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<MapColor>> GetMapColorsAsync()
        {
            return await _context.MapColors.ToListAsync();
        }
        public async Task<IEnumerable<VectorLayer>> GetMapVectorLayers()
        {
            return await _context.VectorLayers.ToListAsync();
        }
        public async Task<IEnumerable<RasterLayer>> GetMapRasterLayers()
        {
            return await _context.RasterLayers.ToListAsync();
        }
        
    }
}
