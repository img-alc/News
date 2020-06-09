using News.Core.Interfaces;
using System.Collections.Generic;
using System.Text.Json;

namespace News.Infrastructure.Serializer
{
    public class JSONSerializer : ISerializer
    {
        public List<T> Deserialize<T>(string source)
        {
            
            return JsonSerializer.Deserialize<List<T>>(source);
        }

       public string Serialize<T>(List<T> source)
        {
            return JsonSerializer.Serialize(source);
        }
    }
}

