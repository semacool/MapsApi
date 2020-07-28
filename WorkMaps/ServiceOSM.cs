using System;
using System.Collections.Generic;
using System.Text;

namespace WorkMaps
{
    public class ServiceOSM : IService
    {
        public string BaseUrl => "https://nominatim.openstreetmap.org";

        public string Convert(string address, byte limit=10, float polygons = 0.005f)
        {
            if (polygons > 1 || polygons < 0) throw new Exception("0<=   polygons    <=1");

            string polygonStr = polygons.ToString().Replace(',', '.');
            string limitStr = limit.ToString();

            return $"{BaseUrl}/search?q={address}&limit={limitStr}&polygon_threshold={polygonStr}&format=json";    
        }
       
    }
}
