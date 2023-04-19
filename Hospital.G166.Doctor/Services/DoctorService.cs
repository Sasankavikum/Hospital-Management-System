using Hospital.G166.Doctor.Data;
using Hospital.G166.Doctor.Model;

namespace Hospital.G166.Doctor.Services
{
    public class DoctorService:IDoctorService
    {
        public List<Model.Doctor> GetDoctors()
        {
            return DoctorMockDataService.doctors;
        }

        public Model.Doctor? AddDoctor(Model.Doctor doctor)
        {
            DoctorMockDataService.doctors.Add(doctor);
            return doctor;
        }

        public Model.Doctor? UpdateDoctor(Model.Doctor doctor)
        {
            Model.Doctor selectedDoctor = DoctorMockDataService.doctors.FirstOrDefault(x => x.Id ==  doctor.Id);
            if (selectedDoctor != null)
            {
                selectedDoctor.Description = doctor.Description;
                selectedDoctor.Time = doctor.Time;
                selectedDoctor.Name = doctor.Name;  
                selectedDoctor.Specialization = doctor.Specialization;  
                return selectedDoctor;
            }
            return selectedDoctor;
        }

        public bool? DeleteDoctor(int id)
        {
            Model.Doctor selectedDoctor = DoctorMockDataService.doctors.FirstOrDefault(x => x.Id == id);
            if(selectedDoctor != null)
            {
                DoctorMockDataService.doctors.Remove(selectedDoctor);
                return true;
            }
            return false;
        }

        public Model.Doctor? GetDoctors(int id)
        {
            return DoctorMockDataService.doctors.FirstOrDefault(x => x.Id == id);
        }
    }
}
