using System;
namespace News.Core.Interfaces
{
    public interface IOutUseCase<T>
    {
        public T Execute();
    }
}
