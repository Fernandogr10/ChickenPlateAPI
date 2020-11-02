using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenPlatesApp.Models.Repositories
{
    public interface ISideDishRepository : IDisposable
    {
        SideDish Create(SideDish sideDish);
        SideDish Get(long sideDishId);
        IEnumerable<SideDish> GetAll();
        void Delete(SideDish sideDish);
        SideDish Update(SideDish sideDish);
        int SaveChanges();
    }
}
