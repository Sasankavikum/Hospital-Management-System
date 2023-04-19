using Hospital.G166.Patient.Data;
using Hospital.G166.Patient.Model;

namespace Hospital.G166.Patient.Services
{
    public class PatientService:IPatientService
    {
        public List<Model.Patient> GetPatient()
        {
            return PatientMockDataService.patient;
        }

        public Model.Patient? GetPatient(int id)
        {
            return PatientMockDataService.patient.FirstOrDefault(x => x.Id == id);
        }

        public Model.Patient? AddPatient(Model.Patient patient)
        {
            PatientMockDataService.patient.Add(patient);
            return patient;
        }

        public Model.Patient? UpdatePatient(Model.Patient patient)
        {
            Model.Patient selectedPatient = PatientMockDataService.patient.FirstOrDefault(x => x.Id == patient.Id);
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
            Model.Patient selectedPatient = PatientMockDataService.patient.FirstOrDefault(x => x.Id == id);
            if (selectedPatient != null)
            {
                PatientMockDataService.patient.Remove(selectedPatient);
                return true;
            }
            return false;
        }
    }
}
