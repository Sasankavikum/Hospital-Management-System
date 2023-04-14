namespace Hospital.G166.Doctor.Data
{
    public static class DoctorMockDataService
    {
        public static List<Model.Doctor> doctors = new List<Model.Doctor>()
        {
            new Model.Doctor{Id = 1, Name = "Sasanka", Specialization = "sp1", Description = "ds1", Time = "8-16"},
            new Model.Doctor{Id = 2, Name = "Sasanka", Specialization = "sp2", Description = "ds2", Time = "8-16"},
            new Model.Doctor{Id = 3, Name = "Sasanka", Specialization = "sp3", Description = "ds3", Time = "16-24"},
            new Model.Doctor{Id = 4, Name = "Sasanka", Specialization = "sp4", Description = "ds4", Time = "24-8"},
            new Model.Doctor{Id = 5, Name = "Sasanka", Specialization = "sp5", Description = "ds5", Time = "16-24"}
        };
    }
}
