using vc1.Models;

namespace vc1.RepositoryPatterns.Interfaces
{
    public interface IStaff
    {
        public Task<string> AddStaffMember(StaffModel NewEmp);
        public Task<List<StaffModel>> GetAllStaff();
    }

}
