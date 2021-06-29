using IndianInvestor.Contract;
using IndianInvestor.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianInvestor.Repository
{
    public class AdminRepository : IAdminRepository
    {
        private readonly ApplicationDbContext _db;
        public AdminRepository(ApplicationDbContext db)
        {
            _db = db;

        }
        public bool Create(Admin entity)
        {
            _db.Admins.Add(entity);
            return save();
        }

        public bool Delete(Admin entity)
        {
            _db.Admins.Remove(entity);
                return save();
        }

        public ICollection<Admin> Findall()
        {
            var admins = _db.Admins.ToList();
            return admins;
        }

        public Admin Findbyid(int id)
        {
            throw new NotImplementedException();
        }

        public bool isexist(int id)
        {
            var exists = _db.Admins.Any();
            return exists;
        }

        public bool save()
        {
            var change = _db.SaveChanges();
            return change > 0;
        }

        public bool Update(Admin entity)
        {
            _db.Admins.Update(entity);
            return save();
        }
    }
}
