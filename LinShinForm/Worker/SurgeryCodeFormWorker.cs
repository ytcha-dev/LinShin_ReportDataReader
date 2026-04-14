using LinShin.Form.Entity;
using LinShin.Fundation.Interface;
using LinShin.Fundation.Worker;

namespace LinShin.Form.Worker
{
    public class SurgeryCodeFormWorker : IBaseEntityWorker<SurgeryCodeFormWorker>
    {
        private static readonly int RowPerData = 3;
        private static readonly int StaticRowCount = 8;
        private static readonly int footerCount = 17;
        private LineViewWorker LineViewWorker;
        private DataLineWorker DataLineWorker;

        public SurgeryCodeFormWorker(List<string> dataSource)
        {
            LineViewWorker = new LineViewWorker(dataSource);
            DataLineWorker = new DataLineWorker(RowPerData, StaticRowCount);
        }

        public static IBaseEntityWorker<SurgeryCodeFormWorker> CreateFormWorker(List<string> dataSource)
        {
            return new SurgeryCodeFormWorker(dataSource);
        }

        public List<IEntityDrivenBase> GetEntities(List<string> dataSource)
        {
            var list = DataLineWorker.GetEntityByFullScan<SurgeryCode>(dataSource);

            return list.Cast<IEntityDrivenBase>().ToList();
        }
    }
}
