using System;
using System.Collections.Generic;
using System.Text;

namespace News.Core.Interfaces
{
    public interface ISerializer
    {
        public string Serialize<T>(List<T> source);
        public List<T> Deserialize<T>(string source);
    }
}
