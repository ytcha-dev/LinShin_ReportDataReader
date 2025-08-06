using LinShin.Form.IndexMap;
using LinShin.Fundation.Entity;
using LinShin.Fundation.Helper;
using LinShin.Fundation.Interface;
using System.Text.RegularExpressions;

namespace LinShin.Form.Entity
{
    public class SurgeryRecord : EntityBase, IEntityDrivenBase<SurgeryRecord>
    {
        #region Entity Fields

        public string ScheduleDateTime { get; set; }
        public string PatientID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Sex { get; set; }
        public string Department { get; set; }
        public string IdentityType { get; set; }
        public string DiagType { get; set; }
        public string BedNo { get; set; }
        public string ScheduledDatetime { get; set; }
        public string NotifyDatetime { get; set; }
        public string SchedSurgeryRoom { get; set; }
        public string SurgeryRoom { get; set; }
        public string Surgeon { get; set; }
        public string Asistanst1 { get; set; }
        public string Anesthest { get; set; }
        public string AnesthesiaMethod { get; set; }
        public string SurgeryStatus { get; set; }
        public string CancelReason { get; set; }
        public string Diagnosis1 { get; set; }
        public string Procedure1 { get; set; }
        public string Asistanst2 { get; set; }
        public string Procedure2 { get; set; }
        public string Diagnosis2 { get; set; }
        public string Asistanst3 { get; set; }
        public string Note { get; set; }

        #endregion Entity Fields

        #region Interface Implement 

        public static Dictionary<string, Func<SurgeryRecord, object>> ExportFieldMap { get; set; } = new Dictionary<string, Func<SurgeryRecord, object>>
        {
            {nameof(ScheduleDateTime),r => r.ScheduleDateTime },
            {nameof(PatientID),r => r.PatientID },
            {nameof(Name),r => r.Name },
            {nameof(Age),r => r.Age },
            {nameof(Sex),r => r.Sex },
            {nameof(Department),r => r.Department },
            {nameof(IdentityType),r => r.IdentityType },
            {nameof(DiagType),r => r.DiagType },
            {nameof(BedNo),r => r.BedNo },
            {nameof(ScheduledDatetime),r => r.ScheduledDatetime },
            {nameof(NotifyDatetime),r => r.NotifyDatetime },
            {nameof(SchedSurgeryRoom),r => r.SchedSurgeryRoom },
            {nameof(SurgeryRoom),r => r.SurgeryRoom },
            {nameof(Surgeon),r => r.Surgeon },
            {nameof(Asistanst1),r => r.Asistanst1 },
            {nameof(Anesthest),r => r.Anesthest },
            {nameof(AnesthesiaMethod),r => r.AnesthesiaMethod },
            {nameof(SurgeryStatus),r => r.SurgeryStatus },
            {nameof(CancelReason),r => r.CancelReason },
            {nameof(Diagnosis1),r => r.Diagnosis1 },
            {nameof(Procedure1),r => r.Procedure1 },
            {nameof(Asistanst2),r => r.Asistanst2 },
            {nameof(Procedure2),r => r.Procedure2 },
            {nameof(Diagnosis2),r => r.Diagnosis2 },
            {nameof(Asistanst3),r => r.Asistanst3 },
            {nameof(Note),r => r.Note },
        };
        public static bool TryParse(List<string> GroupDataList, out SurgeryRecord surgeryRecord)
        {
            surgeryRecord = new SurgeryRecord();

            int lineIndex = 0;
            foreach (KeyValuePair<string, Dictionary<string, int>> lineMap in SurgeryIndexMap.LineMaps)
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
                    surgeryRecord.SetValue(fieldInfo.Key, value.Trim());

                    currentIndex += subLentgh;
                }
                if (string.IsNullOrEmpty(surgeryRecord.PatientID))
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
                case "ScheduleDateTime": ScheduleDateTime = value; break;
                case "PatientID": PatientID = value; break;
                case "Name": Name = value; break;
                case "Age": Age = value; break;
                case "Sex": Sex = value; break;
                case "Department": Department = value; break;
                case "IdentityType": IdentityType = value; break;
                case "DiagType": DiagType = value; break;
                case "BedNo": BedNo = value; break;
                case "ScheduledDatetime": ScheduledDatetime = value; break;
                case "NotifyDatetime": NotifyDatetime = value; break;
                case "SchedSurgeryRoom": SchedSurgeryRoom = value; break;
                case "SurgeryRoom": SurgeryRoom = value; break;
                case "Surgeon": Surgeon = value; break;
                case "Asistanst1": Asistanst1 = value; break;
                case "Anesthest": Anesthest = value; break;
                case "AnesthesiaMethod": AnesthesiaMethod = value; break;
                case "SurgeryStatus": SurgeryStatus = value; break;
                case "CancelReason": CancelReason = value; break;
                case "Diagnosis1": Diagnosis1 = value; break;
                case "Procedure1": Procedure1 = value; break;
                case "Asistanst2": Asistanst2 = value; break;
                case "Procedure2": Procedure2 = value; break;
                case "Diagnosis2": Diagnosis2 = value; break;
                case "Asistanst3": Asistanst3 = value; break;
                case "Note": Note = value; break;
                default: break;
            }
        }
        public bool IsValid()
        {
            if (string.IsNullOrWhiteSpace(PatientID)) return false;
            if (PatientID.Contains("=====") || PatientID.Contains("-----")) return false;

            if (!int.TryParse(PatientID, out int _)) return false;

            Regex rocDateTimeRegex = new Regex(@"^\d{3}/\d{2}/\d{2} \d{2}:\d{2}$");
            if (!rocDateTimeRegex.IsMatch(ScheduleDateTime)) return false;

            return !string.IsNullOrWhiteSpace(ScheduleDateTime)
                && !string.IsNullOrWhiteSpace(Name)
                && !string.IsNullOrWhiteSpace(Surgeon);
        }


        #endregion

        #region Excel Sheet Header Field

        public static string[] TableHeaders { get; } = ["O.R排定日期時間", "病歷號碼", "姓名", "年齡", "性別", "手術科別", "身份別", "診別", "病床號", "醫師預排日期時間", "通知日期", "預排房間", "手術房間", "手術醫師", "協助醫師1", "麻醉醫師", "麻醉方式", "術後狀態", "取消原因", "診斷名稱1", "手術名稱1", "協助醫師2", "診斷名稱2", "手術名稱2", "協助醫師3", "備註"];

        public static Dictionary<string, string> DataGridHeader = new Dictionary<string, string>()
        {
            {nameof(ScheduleDateTime),"O.R排定日期時間" },
            {nameof(PatientID) , "病歷號碼"},
            {nameof(Name) , "姓名"},
            {nameof(Age), "年齡" },
            {nameof(Sex) , "性別"},
            {nameof(Department) , "手術科別"},
            {nameof(IdentityType),"身份別" },
            {nameof(DiagType) , "診別"},
            {nameof(BedNo), "病床號" },
            {nameof(ScheduledDatetime), "醫師預排日期時間" },
            {nameof(NotifyDatetime) , "通知日期"},
            {nameof(SchedSurgeryRoom),"預排房間" },
            {nameof(SurgeryRoom), "手術房間" },
            {nameof(Surgeon), "手術醫師" },
            {nameof(Asistanst1), "協助醫師1" },
            {nameof(Anesthest) , "麻醉醫師"},
            {nameof(AnesthesiaMethod),"麻醉方式" },
            {nameof(SurgeryStatus), "術後狀態" },
            {nameof(CancelReason) , "取消原因"},
            {nameof(Diagnosis1) , "診斷名稱1"},
            {nameof(Procedure1),"手術名稱1" },
            {nameof(Asistanst2), "協助醫師2" },
            {nameof(Diagnosis2), "診斷名稱2" },
            {nameof(Procedure2), "手術名稱2" },
            {nameof(Asistanst3) , "協助醫師3"},
            {nameof(Note) , "備註"},
        };
        #endregion
    }
}
