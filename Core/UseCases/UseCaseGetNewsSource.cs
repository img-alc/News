using News.Core.Entities;
using News.Core.Interfaces;
using System.Collections.Generic;

namespace News.Core.UseCases
{
    public class UseCaseGetNewsSource : IOutUseCase<List<NewsSource>>
    {
        ISerializer _serializer;
        string _newsSource;
        public UseCaseGetNewsSource(string newsSource, ISerializer serializer)
        {
            _newsSource = newsSource;
            _serializer = serializer;
        }
        public List<NewsSource> Execute()
        {
            return _serializer.Deserialize<NewsSource>(_newsSource);
        }
    }
}
