using System;
using System.Collections.Generic;

namespace EntityFrameworkCore.Data.Home.Kelly
{
    public partial class Review
    {
        public int Id { get; set; }
        public int? Item { get; set; }
        public int? Thumbsup { get; set; }
        public int? Thumbsdown { get; set; }
    }
}
