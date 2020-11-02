using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenPlatesApp.Models.Repositories
{
    public interface IChickenPlateRepository : IDisposable
    {
        ChickenPlate Create(ChickenPlate chickenPlate);
        ChickenPlate Get(long chickenPlateId);
        IEnumerable<ChickenPlate> GetAll();
        void Delete(ChickenPlate chickenPlate);
        ChickenPlate Update(ChickenPlate chickenPlate);
        int SaveChanges();
    }
}
