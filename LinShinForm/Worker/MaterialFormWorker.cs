using LinShin.Form.Entity;
using LinShin.Fundation.Interface;
using LinShin.Fundation.Worker;

namespace LinShin.Form.Worker
{
    public class MaterialFormWorker: IBaseEntityWorker<MaterialFormWorker>
    {
        private static readonly int RowPerData = 2;
        private static readonly int StaticRowCount = 10;
        private static readonly int footerCount = 17;
        private LineViewWorker LineViewWorker;
        private DataLineWorker DataLineWorker;

        public MaterialFormWorker(List<string> dataSource)
        {
            LineViewWorker = new LineViewWorker(dataSource);
            DataLineWorker = new DataLineWorker(RowPerData, StaticRowCount);
        }

        public static IBaseEntityWorker<MaterialFormWorker> CreateFormWorker(List<string> dataSource)
        {
            return new MaterialFormWorker(dataSource);
        }

        public List<IEntityDrivenBase> GetEntities(List<string> dataSource)
        {
            var list = DataLineWorker.GetEntityByFullScan<MaterialRecord>(dataSource);

            return list.Cast<IEntityDrivenBase>().ToList();
        }

    }
}
