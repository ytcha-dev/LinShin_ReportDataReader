using LinShin.Form.Entity;
using LinShin.Fundation.Interface;
using LinShin.Fundation.Worker;

namespace LinShin.Form.Worker
{
    public class SurgeryForm2Worker : IBaseEntityWorker<SurgeryForm2Worker>
    {
        private static readonly int RowPerData = 4;
        private static readonly int StaticRowCount = 10;
        private static readonly int footerCount = 17;
        private LineViewWorker LineViewWorker;
        private DataLineWorker DataLineWorker;

        public SurgeryForm2Worker(List<string> dataSource)
        {
            LineViewWorker = new LineViewWorker(dataSource);
            DataLineWorker = new DataLineWorker(RowPerData, StaticRowCount);
        }

        public static IBaseEntityWorker<SurgeryForm2Worker> CreateFormWorker(List<string> dataSource)
        {
            return new SurgeryForm2Worker(dataSource);
        }

        public List<IEntityDrivenBase> GetEntities(List<string> dataSource)
        {
            var list = DataLineWorker.GetEntityByFullScan<SurgeryRecord2>(dataSource);

            return list.Cast<IEntityDrivenBase>().ToList();
        }
    }
}
