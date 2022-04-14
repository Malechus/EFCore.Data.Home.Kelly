using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.Home.Kelly
{
    public partial class Store
    {
        public int Id { get; set; }
        public int? Item { get; set; }
        public string? Name { get; set; }
        public int? Price { get; set; }
        public string? Url { get; set; }
    }
}
