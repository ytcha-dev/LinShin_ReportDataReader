using ClosedXML.Excel;
using LinShin.Fundation.Interface;

namespace LinShin.Fundation.Worker
{
    public class ExcelExporter
    {
        public string[] headers {  get; set; }
        public ExcelExporter(string[] headers)
        {
            this.headers = headers;
        }

        /// <summary>
        /// 傳入物件清單，轉換成資料表並匯出
        /// </summary>
        /// <typeparam name="Entity">實體型別</typeparam>
        /// <param name="records">實體清單</param>
        /// <param name="sheetName">頁籤名稱</param>
        /// <param name="fieldMappings">欄位資料配對(Delegate)</param>
        /// <returns></returns>
        public XLWorkbook ExportToExcel<Entity>(List<Entity> records, string sheetName, Dictionary<string, Func<Entity, object>> fieldMappings) where Entity : IEntityDrivenBase<Entity>
        {
            XLWorkbook workbook = new XLWorkbook();
            IXLWorksheet worksheet = workbook.Worksheets.Add(sheetName);

            for (int i = 0; i < headers.Length; i++)
            {
                worksheet.Cell(1, i + 1).Value = headers[i];
            }

            for (int row = 0; row < records.Count; row++)
            {
                Entity record = records[row];
                int col = 0;

                foreach (KeyValuePair<string, Func<Entity, object>> field in fieldMappings)
                {
                    worksheet.Cell(row + 2, col + 1).Value = field.Value(record).ToString();
                    col++;
                }
            }
            return workbook;
        }
    }
}
