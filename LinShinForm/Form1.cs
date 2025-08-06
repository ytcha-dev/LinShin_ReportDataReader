using ClosedXML.Excel;
using DocumentFormat.OpenXml.Wordprocessing;
using LinShin.Form.Worker;
using LinShin.Fundation.Interface;
using LinShin.Fundation.Worker;
using System.Data;
using System.Text;

namespace LinShinForm
{
    public partial class Form1 : Form
    {
        private ExcelExporter ExcelExporter { get; set; }
        private IBaseEntityWorker FormWorker { get; set; }
        private Dictionary<string, string> gridHeader { get; set; }
        private List<string> dataSource { get; set; }

        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        public void ckb_CheckedChanged(object sender, EventArgs e)
        {
            string text = string.Empty;
            if (((System.Windows.Forms.CheckBox)sender).Checked)
            {
                foreach (object? chk in ((System.Windows.Forms.CheckBox)sender).Parent.Controls)
                {
                    if (chk is System.Windows.Forms.CheckBox check && check != sender)
                    {
                        check.Checked = false;
                    }
                }
                text = ((System.Windows.Forms.CheckBox)sender).Name;
            }

            if (!string.IsNullOrEmpty(text))
            {
                gridHeader = EntityGridHeader.GetValueOrDefault(text)!;
                if (EntityWorkerFactory.TryGetValue(text, out Func<List<string>, IBaseEntityWorker>? factory))
                {
                    FormWorker = factory(dataSource);
                }
            }
            RenderGridColumn();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FilePath_Label.Text = openFileDialog1.FileName;
            FileName_TextBox.Text = openFileDialog1.SafeFileName;

            dataSource = [.. File.ReadLines(openFileDialog1.FileName, Encoding.GetEncoding("Big5"))];

            Reset_ckb();

            RenderGridColumn();
        }

        private void FileUploader_Button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void ExportDataTableToExcel(DataTable dt, string filePath)
        {
            using (XLWorkbook wb = new XLWorkbook())
            {
                IXLWorksheet ws = wb.Worksheets.Add("Sheet1");

                // 直接把 DataTable 當作 Table 插入
                ws.Cell(1, 1).InsertTable(dt, "ExportedData", true);

                wb.SaveAs(filePath);
            }
        }

        private void Reset_ckb()
        {
            foreach (System.Windows.Forms.CheckBox cb in Controls.OfType<System.Windows.Forms.CheckBox>())
            {
                cb.Checked = false;
            }
        }

        private void RenderGridColumn()
        {
            dataGridView1.Columns.Clear();

            if (gridHeader == null || FormWorker == null || dataSource == null || dataSource.Count <= 0 || gridHeader.Count <= 0) return;

            List<IEntityDrivenBase> entities = FormWorker.GetEntities(dataSource);

            DataTable dt = ToDataTable(entities, dataGridView1);
            dataGridView1.DataSource = dt;

            foreach (KeyValuePair<string, string> header in gridHeader)
            {
                if (dataGridView1.Columns.Contains(header.Key))
                {
                    dataGridView1.Columns[header.Key].HeaderText = header.Value;
                }
            }
        }

        private DataTable ToDataTable(IEnumerable<IEntityDrivenBase> items, DataGridView dataGridView)
        {
            DataTable dt = new DataTable();

            IEntityDrivenBase? first = items.FirstOrDefault();
            if (first == null || gridHeader == null || gridHeader.Count == 0)
                return dt;

            Type type = first.GetType();

            System.Reflection.PropertyInfo[] propInfos = type.GetProperties()
                                .Where(p => gridHeader.ContainsKey(p.Name))
                                .ToArray();

            foreach (KeyValuePair<string, string> header in gridHeader)
            {
                dt.Columns.Add(header.Key, typeof(string));
            }

            foreach (IEntityDrivenBase item in items)
            {
                List<object?> rowValues = new List<object?>();
                foreach (KeyValuePair<string, string> header in gridHeader)
                {
                    System.Reflection.PropertyInfo? prop = propInfos.FirstOrDefault(p => p.Name == header.Key);
                    object? val = prop?.GetValue(item, null);
                    rowValues.Add(val ?? DBNull.Value);
                }

                dt.Rows.Add(rowValues.ToArray());
            }

            return dt;
        }


        private readonly Dictionary<string, Func<List<string>, IBaseEntityWorker>> EntityWorkerFactory = new Dictionary<string, Func<List<string>, IBaseEntityWorker>>()
        {
            {nameof(MaterialRecord), MaterialFormWorker.CreateFormWorker },
            {nameof(SurgeryRecord), SurgeryForm1Worker.CreateFormWorker},
            {nameof(SurgeryRecord2), SurgeryForm2Worker.CreateFormWorker},
        };
        private readonly Dictionary<string, Dictionary<string, string>> EntityGridHeader = new Dictionary<string, Dictionary<string, string>>()
        {
            {nameof(MaterialRecord), LinShin.Form.Entity.MaterialRecord.DataGridHeader },
            {nameof(SurgeryRecord), LinShin.Form.Entity.SurgeryRecord.DataGridHeader },
            {nameof(SurgeryRecord2), LinShin.Form.Entity.SurgeryRecord2.DataGridHeader }
        };

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            using (XLWorkbook wb = new XLWorkbook())
            {
                IXLWorksheet ws = wb.Worksheets.Add("Sheet1");

                for (int col = 0; col < dgv.Columns.Count; col++)
                {
                    ws.Cell(1, col + 1).Value = dgv.Columns[col].HeaderText;
                }

                for (int row = 0; row < dgv.Rows.Count; row++)
                {
                    for (int col = 0; col < dgv.Columns.Count; col++)
                    {
                        ws.Cell(row + 2, col + 1).Value = dgv.Rows[row].Cells[col].Value?.ToString();
                    }
                }

                saveFileDialog1.Title = "請選擇儲存位置";
                saveFileDialog1.Filter = "Excel 檔案 (*.xlsx)|*.xlsx|所有檔案 (*.*)|*.*";
                saveFileDialog1.DefaultExt = "xlsx";
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.FileName = "手術室_" + DateTime.Now.ToString("yyyyMMdd");


                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    using Stream stream = saveFileDialog1.OpenFile();
                    wb.SaveAs(stream);
                }
            }
        }
    }
}
