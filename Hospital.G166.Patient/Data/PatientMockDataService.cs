namespace Hospital.G166.Patient.Data
{
    public static class PatientMockDataService
    {
        public static List<Model.Patient> patient = new List<Model.Patient>()
        {
            new Model.Patient {Id = 1, Name = "Sasanka", Age = 25, Disease = "Cyclosporiasis", Sex = "Male"},
            new Model.Patient {Id = 2, Name = "Sachini", Age = 25, Disease = "Head ach", Sex = "Female"},
            new Model.Patient {Id = 3, Name = "Kamal", Age = 21, Disease = "Tetanus", Sex = "Male"},
            new Model.Patient {Id = 4, Name = "Nimali", Age = 32, Disease = "Shingles", Sex = "Female"},
            new Model.Patient {Id = 5, Name = "Sunil", Age = 29, Disease = "Cholera", Sex = "Male"}
        };
    }
}
