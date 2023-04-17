using Hospital.G166.Patient.Data;

namespace Hospital.G166.Patient.Services
{
    public class PatientService : IPatientService
    {
        public List<Model.Patient> GetPatients()
        {
            return PatientMockDataService.patients;
        }

        public Model.Patient? AddPatient(Model.Patient patient)
        {
            PatientMockDataService.patients.Add(patient);
            return patient;
        }

        public Model.Patient? UpdatePatient(Model.Patient patient)
        {
            Model.Patient selectedPatient = PatientMockDataService.patients.FirstOrDefault(x => x.Id == patient.Id);
            if (selectedPatient != null)
            {
                selectedPatient.Name = patient.Name;
                selectedPatient.Age = patient.Age;
                selectedPatient.Disease = patient.Disease;
                selectedPatient.Sex = patient.Sex;
                return selectedPatient;
            }
            return selectedPatient;
        }

        public bool? DeletePatient(int id)
        {
            Model.Patient selectedPatient = PatientMockDataService.patients.FirstOrDefault(x => x.Id == id);
            if (selectedPatient != null)
            {
                PatientMockDataService.patients.Remove(selectedPatient);
                return true;
            }
            return false;
        }

        public Model.Patient? GetPatient(int id)
        {
            return PatientMockDataService.patients.FirstOrDefault(x => x.Id == id);
        }
    }
}
