namespace LinShin.SurgeonSchedule.Entities
{
    public class VisualIndexMap
    {
        public static int ScheduleDateTime { get; set; } = 15;
        public static int PatientID { get; set; } = 9;
        public static int Name { get; set; } = 8;
        public static int Age { get; set; } = 4;
        public static int Sex { get; set; } = 4;
        public static int Department { get; set; } = 10;
        public static int IdentityType { get; set; } = 8;
        public static int DiagType { get; set; } = 8;
        public static int BedNo { get; set; } = 6;
        public static int ScheduledDatetime { get; set; } = 16;
        public static int NotifyDatetime { get; set; } = 15;


        public static int SchedSurgeryRoom { get; set; } = 8;
        public static int SurgeryRoom { get; set; } = 8;
        public static int Surgeon { get; set; } = 8;
        public static int Asistanst1 { get; set; } = 9;
        public static int Anesthest { get; set; } = 8;
        public static int AnesthesiaMethod { get; set; } = 30;
        public static int SurgeryStatus { get; set; } = 11;
        public static int CancelReason { get; set; } = 14;


        public static int Diagnosis1 { get; set; } = 42;
        public static int Procedure1 { get; set; } = 42;
        public static int Asistanst2 { get; set; } = 9;


        public static int Procedure2 { get; set; } = 42;
        public static int Diagnosis2 { get; set; } = 42;
        public static int Asistanst3 { get; set; } = 9;


        public static int Note { get; set; } = 87;

        private readonly static Dictionary<string, int> LineMap1 = new()
        {
            {nameof(ScheduleDateTime),ScheduleDateTime },
            {"space1", 1 },
            {nameof(PatientID),PatientID },
            {"space2", 1 },
            {nameof(Name),Name },
            {"space3", 1 },
            {nameof(Age),Age },
            {"space4", 1 },
            {nameof(Sex),Sex },
            {"space5", 1 },
            {nameof(Department),Department },
            {nameof(IdentityType),IdentityType },
            {nameof(DiagType),DiagType },
            {"space6", 1 },
            {nameof(BedNo),BedNo },
            {"space7", 22 },
            {nameof(ScheduledDatetime),ScheduledDatetime },
            {"space8", 1 },
            {nameof(NotifyDatetime),NotifyDatetime },
        };

        private readonly static Dictionary<string, int> LineMap2 = new()
        {
            {"space1", 10 },
            {nameof(SchedSurgeryRoom),SchedSurgeryRoom },
            {"space2", 1 },
            {nameof(SurgeryRoom),SurgeryRoom },
            {"space3", 1 },
            {nameof(Surgeon),Surgeon },
            {"space4", 1 },
            {nameof(Asistanst1),Asistanst1 },
            {"space5", 1 },
            {nameof(Anesthest),Anesthest },
            {"space6", 1 },
            {nameof(AnesthesiaMethod),AnesthesiaMethod },
            {"space7", 5 },
            {nameof(SurgeryStatus),SurgeryStatus },
            {"space8", 2 },
            {nameof(CancelReason),CancelReason },
        };

        private readonly static Dictionary<string, int> LineMap3 = new()
        {
            {"space1", 10 },
            {nameof(Diagnosis1),Diagnosis1},
            {"space2", 4 },
            {nameof(Procedure1),Procedure1},
            {"space3", 25 },
            {nameof(Asistanst2),Asistanst2 },
        };

        private readonly static Dictionary<string, int> LineMap4 = new()
        {
            {"space1", 10 },
            {nameof(Diagnosis2),Diagnosis1},
            {"space2", 4 },
            {nameof(Procedure2),Procedure1},
            {"space3", 25 },
            {nameof(Asistanst3),Asistanst2 },
        };

        private readonly static Dictionary<string, int> LineMap5 = new()
        {
            {"space1", 10 },
            {nameof(Note),Note},
        };

        public readonly static Dictionary<string, Dictionary<string, int>> LineMaps = new()
        {
            {nameof(LineMap1),LineMap1},
            {nameof(LineMap2),LineMap2},
            {nameof(LineMap3),LineMap3},
            {nameof(LineMap4),LineMap4},
            {nameof(LineMap5),LineMap5},
        };
    }
}