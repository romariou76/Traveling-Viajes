using SQLite;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Traveling.Models
{
    public class TravelInfo
    {
        [PrimaryKey, AutoIncrement]
        public int TravelId { get; set; }
        public string TravelName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
