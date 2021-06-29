using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IndianInvestor.Contract
{
     public interface IRepositoryBase<t> where t :class
    {
        ICollection<t> Findall();
        t Findbyid(int id);
        bool isexist(int id);
        bool Create(t entity);
        bool Update(t entity);
        bool Delete(t entity);
        bool save();
    }
}
