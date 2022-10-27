using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomilyNETTest.Models
{
    public class PageViewModel
    {
        public string Title { get; set; }
        public List<Image> Images { get; set; }
        public List<Text> Texts { get; set; }

        public class Image
        {
            public string URL { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
        }

        public class Text
        {
            public string Content { get; set; }
            public double X { get; set; }
            public double Y { get; set; }
        }
    }
}