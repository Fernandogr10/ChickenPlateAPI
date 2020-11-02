using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenPlatesApp.Models.Repositories
{
    public interface IChickenPartRepository : IDisposable
    {
        ChickenPart Create(ChickenPart chickenPart);
        ChickenPart Get(long chickenPartId);
        IEnumerable<ChickenPart> GetAll();
        void Delete(ChickenPart chickenPart);
        ChickenPart Update(ChickenPart chickenPart);
        int SaveChanges();
    }
}
