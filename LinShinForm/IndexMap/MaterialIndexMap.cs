namespace LinShin.Form.IndexMap
{
    public class VisualIndexMap
    {
        public static int Category { get; set; } = 2;
        public static int Item { get; set; } = 2;
        public static int SubItem { get; set; } = 2;
        public static int Section { get; set; } = 2;
        public static int AssetNumber { get; set; } = 5;
        public static int SerialNumber { get; set; } = 4;
        public static int AssetName { get; set; } = 40;
        public static int Unit { get; set; } = 8;
        public static int Quantity { get; set; } = 8;
        public static int StorageLocation { get; set; } = 24;

        public static int Brand { get; set; } = 20;
        public static int Model { get; set; } = 20;
        public static int AcquisitionDate { get; set; } = 9;
        public static int WarrantyYears { get; set; } = 4;
        public static int UsefulLifeYears { get; set; } = 4;
        public static int RetirementYear { get; set; } = 4;

        private static readonly Dictionary<string, int> Line1 = new()
        {
            {"space1", 2 },
            {nameof(Category),Category },
            {"space2", 1 },
            {nameof(Item),Item },
            {"space3", 1 },
            {nameof(SubItem),SubItem },
            {"space4", 1 },
            {nameof(Section),Section },
            {"space5", 1 },
            {nameof(AssetNumber),AssetNumber },
            {"space6", 1 },
            {nameof(SerialNumber),SerialNumber },
            {"space7", 2 },
            {nameof(AssetName),AssetName },
            {"space8", 1 },
            {nameof(Unit),Unit },
            {"space9", 2 },
            {nameof(Quantity),Quantity },
            {"space10", 0 },
            {nameof(StorageLocation),StorageLocation },
        };
        private static readonly Dictionary<string, int> Line2 = new()
        {
            {"space1", 26 },
            {nameof(Brand),Brand },
            {nameof(Model),Model },
            {"space3", 1 },
            {nameof(AcquisitionDate),AcquisitionDate },
            {"space4", 2 },
            {nameof(WarrantyYears),WarrantyYears },
            {"space5", 2 },
            {nameof(UsefulLifeYears),UsefulLifeYears },
            {"space6", 2 },
            {nameof(RetirementYear),RetirementYear },
        };
        public readonly static Dictionary<string, Dictionary<string, int>> LineMaps = new()
        {
            {nameof(Line1), Line1 },
            {nameof(Line2), Line2 },
        };
    }
}
