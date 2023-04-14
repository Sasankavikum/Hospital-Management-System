namespace Hospital.G166.Nurse.Data
{
    public static class NurseMockDataService
    {
        public static List<Model.Nurse> nurses = new List<Model.Nurse>()
        {
            new Model.Nurse{Id = 1, Name = "Supun", WordNo = 12, Time = "8-16"},
            new Model.Nurse{Id = 2, Name = "Supun", WordNo = 2, Time = "16-24"},
            new Model.Nurse{Id = 3, Name = "Supun", WordNo = 8, Time = "24-8"},
            new Model.Nurse{Id = 4, Name = "Supun", WordNo = 6, Time = "24-8"},
            new Model.Nurse{Id = 5, Name = "Supun", WordNo = 16, Time = "16-24"}
        };
    }
}
