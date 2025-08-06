namespace LinShin.Fundation.Worker
{
    public class LineViewWorker(List<string> lines)
    {
        private readonly List<string> OriginalLines = lines;
        private int headerSet = 10;
        private int TopOffset = 0;

        public List<string> GetData()
        {
            return [.. OriginalLines.Skip(TopOffset).Skip(headerSet)];
        }

        public string GetCurrentStrContent()
        {
            return string.Join(Environment.NewLine, OriginalLines.Skip(TopOffset).Skip(10));
        }


        #region 控制 Methods

        public void SetHeaderRowCount(int headerSet)
        {
            this.headerSet = headerSet;
        }

        public void TrimTopLine()
        {
            if (TopOffset < OriginalLines.Count)
                TopOffset++;
        }

        public void UndoTrimTopLine()
        {
            if (TopOffset > 0)
                TopOffset--;
        }

        public void Reset()
        {
            TopOffset = 0;
        }

        public int GetTopOffset()
        {
            return TopOffset;
        }

        #endregion

    }
}
