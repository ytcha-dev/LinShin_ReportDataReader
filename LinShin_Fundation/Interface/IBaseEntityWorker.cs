using LinShin.Fundation.Entity;

namespace LinShin.Fundation.Interface
{
    public interface IBaseEntityWorker<T> : IBaseEntityWorker where T : class
    {
        public static abstract IBaseEntityWorker<T> CreateFormWorker(List<string> dataSource);
    }
    public interface IBaseEntityWorker
    {
        public List<IEntityDrivenBase> GetEntities(List<string> dataSource);
    }
}
