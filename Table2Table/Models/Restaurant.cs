using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Table2Table.Models
{
    public class Restaurant
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string IsType { get; set; }
        [Range(1,5)]
        public int MichelinStars { get; set; }

        //Thumbnail + ThumbnailAlt
    }
}