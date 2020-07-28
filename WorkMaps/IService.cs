using System;
using System.Collections.Generic;

namespace WorkMaps
{
    public interface IService
    {
        string BaseUrl { get; }
        string Convert(string address,byte limit,float polygons);
    }
}
