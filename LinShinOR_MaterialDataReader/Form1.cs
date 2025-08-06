using LinShin.Fundation.Worker;
using LinShinOR.MaterialsForm.Entity;
using System.Text;

namespace LinShinOR_MaterialDataReader
{
    public partial class Form1 : Form
    {
        private LineViewWorker LineWorker { get; set; }
        private ExcelExporter ExcelExporter { get; set; }
        private readonly int rowCountPerData = 2;
        private readonly int staticCount = 10;
        private readonly int footerCount = 17;

        public Form1()
        {
            InitializeComponent();
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            FilePath_Label.Text = openFileDialog1.FileName;
            FileName_TextBox.Text = openFileDialog1.SafeFileName;

            this.LineWorker = new([.. File.ReadLines(openFileDialog1.FileName, Encoding.GetEncoding("Big5"))]);

            ReRender_AnchorView();
        }

        private void SaveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void Click_UploadFile(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void Click_CkeckDoneAndSave(object sender, EventArgs e)
        {
            if (!int.TryParse(DataRowCount_Box.Text, out int dataRowCount))
            {
                MessageBox.Show("�п�J�C����Ƶ���", "��J���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataLineWorker dataLineWorker = new(dataRowCount, rowCountPerData);

            var surgeryRecords = dataLineWorker.GetEntityByFullScan<MaterialRecord>(LineWorker.GetData());
            if (surgeryRecords == null)
            {
                MessageBox.Show("�Ьd�ݹw�������A�öפJ���T�ɮ�", "��J���~", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ExcelExporter = new ExcelExporter(MaterialRecord.TableHeaders);
            var workbook = ExcelExporter.ExportToExcel(surgeryRecords, "��N�Ǹ����", MaterialRecord.ExportFieldMap);


            saveFileDialog1.Title = "�п���x�s��m";
            saveFileDialog1.Filter = "Excel �ɮ� (*.xlsx)|*.xlsx|�Ҧ��ɮ� (*.*)|*.*";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.FileName = "��N�Ǹ��_" + DateTime.Now.ToString("yyyyMMdd");


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using var stream = saveFileDialog1.OpenFile();
                workbook.SaveAs(stream);
            }
        }

        private void Click_AnchorUp(object sender, EventArgs e)
        {
            LineWorker.UndoTrimTopLine();
            ReRender_AnchorView();
        }

        private void Ckick_AnchorDown(object sender, EventArgs e)
        {
            LineWorker.TrimTopLine();
            ReRender_AnchorView();
        }

        #region Methods

        private void ReRender_AnchorView()
        {
            Anchor_TextBox.Text = LineWorker.GetCurrentStrContent();
        }

        #endregion
    }
}
