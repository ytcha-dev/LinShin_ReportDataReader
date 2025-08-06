using LinShin.Fundation.Interface;

namespace LinShin.Fundation.Worker
{
    /// <summary>
    /// </summary>
    /// <param name="RowPerdata">資料列數</param>
    /// <param name="staticCount">報表標頭資料列數(非Header)</param>
    /// <param name="footerCount">換頁間隔列數</param>
    public class DataLineWorker(int RowPerdata, int staticCount, int footerCount)
    {
        /// <summary>
        /// 資料列數
        /// </summary>
        private readonly int rowPerData = RowPerdata;
        /// <summary>
        /// 報表標頭資料列數(非Header)
        /// </summary>
        private readonly int staticRowCount = staticCount;
        /// <summary>
        /// 換頁間隔列數
        /// </summary>
        private readonly int pageFooter = footerCount;

        public DataLineWorker(int dataRow, int staticCount)
            : this(dataRow, staticCount, default)
        { }

        /// <summary>
        /// 傳入分組好的字串陣列，並轉型成Entity清單
        /// </summary>
        /// <remarks>報表具有穩定結構，如每頁固定筆數等，才適用此方法</remarks>
        /// <typeparam name="Entity">實作的Entity</typeparam>
        /// <param name="data">分組好的字串陣列</param>
        /// <returns></returns>
        public List<Entity> GetEntityList<Entity>(List<string> data) where Entity : IEntityDrivenBase<Entity>
        {
            if (data == null || data.Count < staticRowCount)
            {
                return null;
            }

            List<Entity> result = [];

            int currentRow = 0;
            int currentPageCount = 0;
            while (currentRow + staticRowCount < data.Count)
            {
                if (data[currentRow].Contains("====") || data[currentRow].Contains("----")
                    || string.IsNullOrWhiteSpace(data[currentRow]) || data[currentRow].Contains("頁數"))
                {
                    currentRow++;
                    continue;
                }

                if (data[currentRow].Contains("小計") || data[currentRow].Contains("頁數"))
                {
                    break;
                }

                currentPageCount++;
                List<string> tRow = [.. data.Skip(currentRow).Take(rowPerData)];
                if (!Entity.TryParse(tRow, out Entity entity))
                {
                    currentRow++;
                    continue;
                }

                result.Add(entity);
                currentRow += staticRowCount;
                if (currentPageCount >= rowPerData)
                {
                    currentRow += pageFooter;
                    currentPageCount = 0;
                }
            }

            return result;
        }

        /// <summary>
        /// 傳入分組好的字串陣列，並轉型成Entity清單
        /// </summary>
        /// <remarks>報表不具有穩定結構，因此每筆遞迴取得，效能較低</remarks>
        /// <typeparam name="Entity"></typeparam>
        /// <param name="data"></param>
        /// <returns></returns>
        public List<Entity> GetEntityByFullScan<Entity>(List<string> data) where Entity : IEntityDrivenBase<Entity>
        {
            if (data == null || data.Count < staticRowCount)
            {
                return null;
            }
            List<Entity> result = [];

            int currentRow = 0;
            int currentPageCount = 0;
            while (currentRow < data.Count)
            {
                if (data[currentRow].Contains("====") || data[currentRow].Contains("----")
                    || string.IsNullOrWhiteSpace(data[currentRow]) || data[currentRow].Contains("頁數"))
                {
                    currentRow++;
                    continue;
                }

                currentPageCount++;
                List<string> tRow = [.. data.Skip(currentRow).Take(rowPerData)];
                if (!Entity.TryParse(tRow, out var entity))
                {
                    currentRow++;
                    continue;
                }

                if (!entity.IsValid())
                {
                    currentRow++;
                    continue;
                }

                currentRow++;
                result.Add(entity);
            }

            return result;
        }
    }
}
