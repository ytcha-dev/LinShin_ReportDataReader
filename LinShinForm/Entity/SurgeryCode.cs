using DocumentFormat.OpenXml.Wordprocessing;
using LinShin.Form.IndexMap;
using LinShin.Fundation.Entity;
using LinShin.Fundation.Helper;
using LinShin.Fundation.Interface;

namespace LinShin.Form.Entity
{
    internal class SurgeryCode : EntityBase, IEntityDrivenBase<SurgeryCode>
    {
        #region Entity Fields

        public string ProcedureCode { get; set; }
        public string NhiCode { get; set; }
        public string InventoryMappingCode { get; set; }
        public string SelfPayment { get; set; }
        public string NhiCovered { get; set; }
        public string ProcedureName { get; set; }
        public string TypeCode { get; set; }
        public string UnitPrice1 { get; set; }
        public string UnitPrice2 { get; set; }
        public string NhiDiffPrice { get; set; }
        public string BillingUnit { get; set; }
        public string ShortCode { get; set; }
        public string StandardType { get; set; }
        public string UsageUnit { get; set; }
        public string Antibiotic { get; set; }
        public string Method { get; set; }
        public string OnlineControl { get; set; }
        public string Restriction1 { get; set; }
        public string Reimbursement1 { get; set; }
        public string Additional1 { get; set; }
        public string Restriction2 { get; set; }
        public string Reimbursement2 { get; set; }
        public string Additional2 { get; set; }

        #endregion

        #region Interface Implement

        public static Dictionary<string, Func<SurgeryCode, object>> ExportFieldMap { get; set; } = new Dictionary<string, Func<SurgeryCode, object>>
        {
            {nameof(ProcedureCode), r=>r.ProcedureCode },
            {nameof(NhiCode), r=>r.NhiCode },
            {nameof(InventoryMappingCode), r=>r.InventoryMappingCode },
            {nameof(ProcedureName), r=>r.ProcedureName },
            {nameof(TypeCode), r=>r.TypeCode },
            {nameof(UnitPrice1), r=>r.UnitPrice1 },
            {nameof(UnitPrice2), r=>r.UnitPrice2 },
            {nameof(NhiDiffPrice), r=>r.NhiDiffPrice },
            {nameof(BillingUnit), r=>r.BillingUnit },
            {nameof(ShortCode), r=>r.ShortCode },
            {nameof(StandardType), r=>r.StandardType },
            {nameof(UsageUnit), r=>r.UsageUnit },
            {nameof(Antibiotic), r=>r.Antibiotic },
            {nameof(Method), r=>r.Method },
            {nameof(OnlineControl), r=>r.OnlineControl },
            {nameof(Restriction1), r=>r.Restriction1 },
            {nameof(Reimbursement1), r=>r.Reimbursement1 },
            {nameof(Additional1), r=>r.Additional1 },
            {nameof(Restriction2), r=>r.Restriction2 },
            {nameof(Reimbursement2), r=>r.Reimbursement2 },
            {nameof(Additional2), r=>r.Additional2 },
        };

        public static bool TryParse(List<string> GroupDataList, out SurgeryCode surgeryCode)
        {
            surgeryCode = new SurgeryCode();

            int lineIndex = 0;
            foreach (KeyValuePair<string, Dictionary<string, int>> lineMap in SurgeryCodeIndexMap.LineMaps)
            {
                string line = GroupDataList[lineIndex];

                if (line.Contains("----"))
                {
                    return false;
                }

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

                    string value = SubStringHelper.Substring(line, currentIndex, fieldInfo.Value);
                    surgeryCode.SetValue(fieldInfo.Key, value.Trim());

                    currentIndex += subLentgh;
                }
                if (string.IsNullOrEmpty(surgeryCode.ProcedureCode))
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
                case "ProcedureCode": ProcedureCode = value; break;
                case "NhiCode": NhiCode = value; break;
                case "InventoryMappingCode": InventoryMappingCode = value; break;
                case "ProcedureName": ProcedureName = value; break;
                case "TypeCode": TypeCode = value; break;
                case "UnitPrice1": UnitPrice1 = value; break;
                case "UnitPrice2": UnitPrice2 = value; break;
                case "NhiDiffPrice": NhiDiffPrice = value; break;
                case "BillingUnit": BillingUnit = value; break;
                case "ShortCode": ShortCode = value; break;
                case "StandardType": StandardType = value; break;
                case "UsageUnit": UsageUnit = value; break;
                case "Antibiotic": Antibiotic = value; break;
                case "Method": Method = value; break;
                case "OnlineControl": OnlineControl = value; break;
                case "Restriction1": Restriction1 = value; break;
                case "Reimbursement1": Reimbursement1 = value; break;
                case "Additional1": Additional1 = value; break;
                case "Restriction2": Restriction2 = value; break;
                case "Reimbursement2": Reimbursement2 = value; break;
                case "Additional2": Additional2 = value; break;
                default: break;
            }
        }

        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(ProcedureCode)) return false;
            if (ProcedureCode.Contains("======") || ProcedureCode.Contains("------")) return false;

            return !string.IsNullOrWhiteSpace(ProcedureName)
                && !string.IsNullOrWhiteSpace(BillingUnit)
                && !string.IsNullOrWhiteSpace(Restriction1)
                && !string.IsNullOrWhiteSpace(Reimbursement1)
                && !string.IsNullOrWhiteSpace(Additional1)
                && !string.IsNullOrWhiteSpace(Restriction2)
                && !string.IsNullOrWhiteSpace(Reimbursement2)
                && !string.IsNullOrWhiteSpace(Additional2);
        }

        #endregion

        #region Excel Sheet Header Field

        public static string[] TableHeaders { get; } = ["處置代碼", "健保代碼", "庫存對照碼", "處置名稱", "類別", "自費單價", "全民健保單價", "全民健保健保差額", "計價單位", "簡碼", "標準別", "服用單位", "抗", "方式", "線上控制", "自費限制", "自費給付", "自費附加", "全民健保限制", "全民健保給付", "全民健保附加"];

        public static Dictionary<string, string> DataGridHeader = new Dictionary<string, string>()
        {
            {nameof(ProcedureCode), "處置代碼"},
            {nameof(NhiCode), "健保代碼"},
            {nameof(InventoryMappingCode), "庫存對照碼"},
            {nameof(ProcedureName), "處置名稱"},
            {nameof(TypeCode), "類別"},
            {nameof(UnitPrice1), "自費單價"},
            {nameof(UnitPrice2), "全民健保單價"},
            {nameof(NhiDiffPrice), "全民健保健保差額"},
            {nameof(BillingUnit), "計價單位"},
            {nameof(ShortCode), "簡碼"},
            {nameof(StandardType), "標準別"},
            {nameof(UsageUnit), "服用單位"},
            {nameof(Antibiotic), "抗"},
            {nameof(Method), "方式"},
            {nameof(OnlineControl), "線上控制"},
            {nameof(Restriction1), "自費限制"},
            {nameof(Reimbursement1), "自費給付"},
            {nameof(Additional1), "自費附加"},
            {nameof(Restriction2), "全民健保限制"},
            {nameof(Reimbursement2), "全民健保給付"},
            {nameof(Additional2), "全民健保附加"},
        };

        #endregion
    }
}
