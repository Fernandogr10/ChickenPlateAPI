using ChickenPlatesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenPlatesApp.Services.Interfaces
{
    public interface ISideDishService
    {
        SideDish Create(SideDish sideDish);
        SideDish Get(long sideDishId);
        List<SideDish> GetAll();
        void Delete(SideDish sideDish);
        SideDish Update(SideDish sideDish);
        void SaveChanges();
    }
}
