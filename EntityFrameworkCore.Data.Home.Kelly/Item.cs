using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.Home.Kelly
{
    public partial class Item
    {
        public int Id { get; set; }
        public int Barcode { get; set; }
        public string? Title { get; set; }
        public string? Alias { get; set; }
        public string? Description { get; set; }
        public string? Brand { get; set; }
        public string? Manufacturer { get; set; }
        public int? Mpn { get; set; }
        public int? Msrp { get; set; }
        public string? Asin { get; set; }
        public string? Category { get; set; }
        public int? Metadata { get; set; }
        public string? Stores { get; set; }
        public int? Images { get; set; }
        public int? Reviews { get; set; }
        public int? Error { get; set; }
        public string? Location { get; set; }
    }
}
