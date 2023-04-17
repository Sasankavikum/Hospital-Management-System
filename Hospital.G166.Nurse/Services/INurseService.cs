namespace Hospital.G166.Nurse.Services
{
    public interface INurseService
    {
        List<Model.Nurse> GetNurses();
        Model.Nurse? GetNurse(int id);
        Model.Nurse? AddNurse(Model.Nurse nurse);
        Model.Nurse? UpdateNurse(Model.Nurse nurse);
        bool? DeleteNurse(int id);
    }
}
