using Hospital.G166.Nurse.Data;
using Hospital.G166.Nurse.Model;

namespace Hospital.G166.Nurse.Services
{
    public class NurseService: INurseService
    {
        public List<Model.Nurse> GetNurses()
        {
            return NurseMockDataService.nurses;
        }

        public Model.Nurse? GetNurse(int id)
        {
            return NurseMockDataService.nurses.FirstOrDefault(x => x.Id == id);
        }

        public Model.Nurse? AddNurse(Model.Nurse nurse)
        {
            NurseMockDataService.nurses.Add(nurse);
            return nurse;
        }

        public Model.Nurse? UpdateNurse(Model.Nurse nurse) 
        {
            Model.Nurse selectedNurse = NurseMockDataService.nurses.FirstOrDefault(x => x.Id == nurse.Id);
            if (selectedNurse != null)
            {
                selectedNurse.Name = nurse.Name;
                selectedNurse.WordNo = nurse.WordNo;
                selectedNurse.Time = nurse.Time;
                return selectedNurse;
            }
            return nurse;
        }

        public bool? DeleteNurse(int id)
        {
            Model.Nurse selectedNurse = NurseMockDataService.nurses.FirstOrDefault(x => x.Id == id);
            if (selectedNurse != null)
            {
                NurseMockDataService.nurses.Remove(selectedNurse);
                return true;
            }
            return false;
        }
    }
}
