using System;
using System.Collections.Generic;
using System.Text;

namespace GeoRestApi
{
    class MapObject
    {
        public string Title { get; set; }
        public MapObject(string Title) 
        {
            this.Title = Title;
        }
    }
}
