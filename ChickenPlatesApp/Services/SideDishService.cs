using ChickenPlatesApp.Models;
using ChickenPlatesApp.Models.Repositories;
using ChickenPlatesApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChickenPlatesApp.Services
{
    public class SideDishService : ISideDishService
    {
        private readonly ISideDishRepository _repo;

        public SideDishService(ISideDishRepository repo)
        {
            _repo = repo;
        }

        public SideDish Create(SideDish sideDish)
        {
            return _repo.Create(sideDish);
        }

        public void Delete(SideDish sideDish)
        {
            _repo.Delete(sideDish);
        }

        public SideDish Get(long sideDishId)
        {
            return _repo.Get(sideDishId);
        }

        public List<SideDish> GetAll()
        {
            return _repo.GetAll().ToList(); ;
        }

        public void SaveChanges()
        {
            _repo.SaveChanges();
        }

        public SideDish Update(SideDish sideDish)
        {
            return _repo.Update(sideDish);
        }
    }
}
