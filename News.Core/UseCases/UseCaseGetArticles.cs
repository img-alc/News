using System;
using System.Collections.Generic;
using News.Core.Entities;
using News.Core.Interfaces;

namespace News.Core.UseCases
{
   public  class UseCaseGetArticles : IOutUseCase<List<Article>>
    {
        string _articles;
        ISerializer _serializer;
        public UseCaseGetArticles(string articles, ISerializer serializer)
        {
            _articles = articles;
            _serializer = serializer;
        }
        public List<Article> Execute()
        {
            return _serializer.Deserialize<Article>(_articles);
        }
    }
}
