namespace Hospital.G166.Doctor.Services
{
    public interface IDoctorService
    {
        List<Model.Doctor> GetDoctors();
        Model.Doctor? GetDoctors(int id);
        Model.Doctor? AddDoctor(Model.Doctor doctor);
        Model.Doctor? UpdateDoctor(Model.Doctor doctor);
        bool? DeleteDoctor(int id);
    }
}
