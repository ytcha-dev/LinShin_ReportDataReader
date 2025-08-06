using LinShin.Form.Entity;
using LinShin.Fundation.Interface;
using LinShin.Fundation.Worker;

namespace LinShin.Form.Worker
{
    public class SurgeryForm1Worker : IBaseEntityWorker<SurgeryForm1Worker>
    {
        private static readonly int RowPerData = 5;
        private static readonly int StaticRowCount = 10;
        private static readonly int footerCount = 17;
        private LineViewWorker LineViewWorker;
        private DataLineWorker DataLineWorker;

        public SurgeryForm1Worker(List<string> dataSource)
        {
            LineViewWorker = new LineViewWorker(dataSource);
            DataLineWorker = new DataLineWorker(RowPerData, StaticRowCount);
        }

        public static IBaseEntityWorker<SurgeryForm1Worker> CreateFormWorker(List<string> dataSource)
        {
            return new SurgeryForm1Worker(dataSource);
        }

        public List<IEntityDrivenBase> GetEntities(List<string> dataSource)
        {
            var list = DataLineWorker.GetEntityByFullScan<SurgeryRecord>(dataSource);

            return list.Cast<IEntityDrivenBase>().ToList();
        }
    }
}
