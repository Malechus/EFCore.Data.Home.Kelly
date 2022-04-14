using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.Home.Kelly
{
    public partial class Metadatum
    {
        public int Id { get; set; }
        public int? Item { get; set; }
        public string? Size { get; set; }
        public string? Color { get; set; }
        public string? Gender { get; set; }
        public string? Age { get; set; }
        public string? Length { get; set; }
        public string? Unit { get; set; }
        public string? Width { get; set; }
        public string? Weight { get; set; }
        public int? Quantity { get; set; }
        public string? Publisher { get; set; }
        public string? Genre { get; set; }
        public string? Author { get; set; }
        public DateOnly? Releasedate { get; set; }
    }
}
