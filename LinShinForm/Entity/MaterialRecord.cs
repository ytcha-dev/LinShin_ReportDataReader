using LinShin.Form.IndexMap;
using LinShin.Fundation.Entity;
using LinShin.Fundation.Helper;
using LinShin.Fundation.Interface;

namespace LinShin.Form.Entity
{
    public class MaterialRecord : EntityBase, IEntityDrivenBase<MaterialRecord>
    {
        #region Entity Fields

        public string Category { get; set; }
        public string Item { get; set; }
        public string SubItem { get; set; }
        public string Section { get; set; }
        public string AssetNumber { get; set; }
        public string SerialNumber { get; set; }
        public string AssetName { get; set; }
        public string Unit { get; set; }
        public string Quantity { get; set; }
        public string StorageLocation { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string AcquisitionDate { get; set; }
        public string WarrantyYears { get; set; }
        public string UsefulLifeYears { get; set; }
        public string RetirementYear { get; set; }

        #endregion Entity Fields

        #region Interface Implement 

        public static Dictionary<string, Func<MaterialRecord, object>> ExportFieldMap { get; set; } = new Dictionary<string, Func<MaterialRecord, object>>
        {
            {nameof(Category),r=>r.Category },
            {nameof(Item),r=>r.Item },
            {nameof(SubItem),r=>r.SubItem },
            {nameof(Section),r=>r.Section },
            {nameof(AssetNumber),r=>r.AssetNumber },
            {nameof(SerialNumber),r=>r.SerialNumber },
            {nameof(AssetName),r=>r.AssetName },
            {nameof(Unit),r=>r.Unit },
            {nameof(Quantity),r=>r.Quantity },
            {nameof(StorageLocation),r=>r.StorageLocation },
            {nameof(Brand),r=>r.Brand },
            {nameof(Model),r=>r.Model },
            {nameof(AcquisitionDate),r=>r.AcquisitionDate },
            {nameof(WarrantyYears),r=>r.WarrantyYears },
            {nameof(UsefulLifeYears),r=>r.UsefulLifeYears },
            {nameof(RetirementYear),r=>r.RetirementYear },
        };
        public static bool TryParse(List<string> GroupDataList, out MaterialRecord materialRecord)
        {
            materialRecord = new MaterialRecord();

            int lineIndex = 0;
            foreach (KeyValuePair<string, Dictionary<string, int>> lineMap in VisualIndexMap.LineMaps)
            {
                string line = GroupDataList[lineIndex];
                int currentIndex = 0;
                int totalIndex = line.Length - 1;
                foreach (KeyValuePair<string, int> fieldInfo in lineMap.Value)
                {
                    int subLentgh = fieldInfo.Value;

                    if (fieldInfo.Key.Contains("space"))
                    {
                        currentIndex += subLentgh;
                        continue;
                    }

                    string value = string.Empty;
                    if (fieldInfo.Key == nameof(StorageLocation) || fieldInfo.Key == nameof(RetirementYear))
                    {
                        value = SubStringHelper.SubstringEndField(line, currentIndex);
                    }
                    else
                    {
                        value = SubStringHelper.Substring(line, currentIndex, fieldInfo.Value);
                    }
                    materialRecord.SetValue(fieldInfo.Key, value.Trim());

                    currentIndex += subLentgh;
                }
                if (string.IsNullOrEmpty(materialRecord.AssetNumber))
                {
                    return false;
                }
                lineIndex++;
            }
            return true;
        }

        public void SetValue(string key, string value)
        {
            switch (key)
            {
                case "Category": Category = value; break;
                case "Item": Item = value; break;
                case "SubItem": SubItem = value; break;
                case "Section": Section = value; break;
                case "AssetNumber": AssetNumber = value; break;
                case "SerialNumber": SerialNumber = value; break;
                case "AssetName": AssetName = value; break;
                case "Unit": Unit = value; break;
                case "Quantity": Quantity = value; break;
                case "StorageLocation": StorageLocation = value; break;
                case "Brand": Brand = value; break;
                case "Model": Model = value; break;
                case "AcquisitionDate": AcquisitionDate = value; break;
                case "WarrantyYears": WarrantyYears = value; break;
                case "UsefulLifeYears": UsefulLifeYears = value; break;
                case "RetirementYear": RetirementYear = value; break;
                default: break;
            }
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(AssetName)) return false;
            if (AssetName.Contains("=====") || AssetName.Contains("-----")) return false;

            if (!int.TryParse(AssetNumber, out int _)) return false;
            if (!int.TryParse(SerialNumber, out int _)) return false;

            return !string.IsNullOrWhiteSpace(Quantity);
        }

        #endregion

        #region Excel Sheet Header Field

        public static string[] TableHeaders { get; } = ["類", "項", "目", "節", "編號", "序號", "財產名稱", "單位", "數量", "存放地點", "廠牌", "型式", "取得日期", "保固年限", "使用年限", "報廢年限"];

        public static Dictionary<string, string> DataGridHeader = new Dictionary<string, string>()
        {
            {nameof(Category) , "類"},
            {nameof(Item) , "項"},
            {nameof(SubItem) , "目"},
            {nameof(Section) , "節"},
            {nameof(AssetNumber) , "編號"},
            {nameof(SerialNumber) , "序號"},
            {nameof(AssetName) , "財產名稱"},
            {nameof(Unit) , "單位"},
            {nameof(Quantity) , "數量"},
            {nameof(StorageLocation) , "存放地點"},
            {nameof(Brand) , "廠牌"},
            {nameof(Model) , "型式"},
            {nameof(AcquisitionDate) , "取得日期"},
            {nameof(WarrantyYears) , "保固年限"},
            {nameof(UsefulLifeYears) , "使用年限"},
            {nameof(RetirementYear) , "報廢年限"}
        };

        #endregion
    }
}
