namespace Hospital.G166.Patient.Services
{
    public interface IPatientService
    {
        List<Model.Patient> GetPatient();
        Model.Patient? GetPatient(int id);
        Model.Patient? AddPatient(Model.Patient patient);
        Model.Patient? UpdatePatient(Model.Patient patient);
        bool? DeletePatient(int id);
    }
}
