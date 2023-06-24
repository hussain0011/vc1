using Microsoft.EntityFrameworkCore;
using vc1.Data;
using vc1.Models;
using vc1.RepositoryPatterns.Interfaces;

namespace vc1.RepositoryPatterns.Repositories
{
    public class StaffRepo : IStaff
    {

        private ApplicationDbContext Db;

        public StaffRepo(ApplicationDbContext db)
        {
            Db = db;
        }

        public async Task<string> AddStaffMember(StaffModel NewEmp)
        {
            Db.StaffTable.Add(NewEmp);
            Db.SaveChanges();
            return "The Emp Has Been Added";
        }

        public async Task<List<StaffModel>> GetAllStaff()
        {
            var ListOfAllStaff = await Db.StaffTable.ToListAsync();
            return ListOfAllStaff;

        }
    }
}
