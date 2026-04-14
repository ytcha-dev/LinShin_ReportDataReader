namespace LinShin.Form.IndexMap
{
    public class SurgeryCodeIndexMap
    {
        public static int ProcedureCode { get; set; } = 8;
        public static int NhiCode { get; set; } = 16;
        public static int InventoryMappingCode { get; set; } = 14;
        public static int SelfPayment { get; set; } = 14;
        public static int NhiCovered { get; set; } = 18;
        
        public static int ProcedureName { get; set; } = 40;
        public static int TypeCode { get; set; } = 4;
        public static int UnitPrice1 { get; set; } = 14;
        public static int UnitPrice2 { get; set; } = 10;
        public static int NhiDiffPrice { get; set; } = 8;
        
        public static int BillingUnit { get; set; } = 8;
        public static int ShortCode { get; set; } = 4;
        public static int StandardType { get; set; } = 6;
        public static int UsageUnit { get; set; } = 8;
        public static int Antibiotic { get; set; } = 2;
        public static int Method { get; set; } = 4;
        public static int OnlineControl { get; set; } = 8;
        public static int Restriction1 { get; set; } = 4;
        public static int Reimbursement1 { get; set; } = 4;
        public static int Additional1 { get; set; } = 4;
        public static int Restriction2 { get; set; } = 4;
        public static int Reimbursement2 { get; set; } = 4;
        public static int Additional2 { get; set; } = 4;

        private readonly static Dictionary<string, int> LineMap1 = new()
        {
            {"space0", 1},
            {nameof(ProcedureCode), ProcedureCode },
            {"space1", 1},
            {"space2", 3},
            {nameof(NhiCode), NhiCode },
            {"space3", 2},
            {nameof(InventoryMappingCode), InventoryMappingCode },
        };

        private readonly static Dictionary<string, int> LineMap2 = new()
        {
            {"space0", 1 },
            {nameof(ProcedureName), ProcedureName },
            {"space1", 2 },
            {nameof(TypeCode), TypeCode },
            {"space2", 4 },
            {nameof(UnitPrice1), UnitPrice1 },
            {"space3", 1 },
            {nameof(UnitPrice2), UnitPrice2 },
            {"space4", 1 },
            {nameof(NhiDiffPrice), NhiDiffPrice },
        };

        private readonly static Dictionary<string, int> LineMap3 = new()
        {
            {"space0", 1 },
            {nameof(BillingUnit), BillingUnit },
            {"space1", 1 },
            {nameof(ShortCode), ShortCode },
            {"space2", 1 },
            {nameof(StandardType), StandardType },
            {"space3", 1 },
            {nameof(UsageUnit), UsageUnit },
            {nameof(Antibiotic), Antibiotic },
            {"space4", 1 },
            {nameof(Method), Method },
            {"space5", 1 },
            {nameof(OnlineControl), OnlineControl },
            {"space6", 1 },
            {nameof(Restriction1), Restriction1 },
            {"space7", 1 },
            {nameof(Reimbursement1), Reimbursement1 },
            {"space8", 1 },
            {nameof(Additional1), Additional1 },
            {"space9", 1 },
            {nameof(Restriction2), Restriction2 },
            {"space10", 1 },
            {nameof(Reimbursement2), Reimbursement2 },
            {"space11", 1 },
            {nameof(Additional2), Additional2 },
        };

        public readonly static Dictionary<string, Dictionary<string, int>> LineMaps = new()
        {
            {nameof(LineMap1),LineMap1},
            {nameof(LineMap2),LineMap2},
            {nameof(LineMap3),LineMap3},
        };
    }
}