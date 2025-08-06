using LinShin.Fundation.Entity;

namespace LinShin.Fundation.Interface
{
    public interface IEntityDrivenBase<Entity> : IEntityDrivenBase where Entity : IEntityDrivenBase<Entity> // 必定實作此介面類別
    {
        /// <summary>
        /// 靜態的單體轉型物件方法
        /// </summary>
        /// <param name="row">分組好的字串清單</param>
        /// <param name="result">回傳完成的實體</param>
        /// <returns>轉型成功或失敗</returns>
        static abstract bool TryParse(List<string> row, out Entity result);

        /// <summary>
        /// 寫入屬性欄位值
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        void SetValue(string key, string value);

        /// <summary>
        /// 當方法透過 Recursive 時，判斷是否轉型為物件
        /// </summary>
        /// <returns></returns>
        bool IsValid();

        /// <summary>
        /// 資料轉接器，內有Delegate送出資料
        /// </summary>
        static abstract Dictionary<string, Func<Entity, object>> ExportFieldMap { get; set; }
    }

    public interface IEntityDrivenBase { }
}
