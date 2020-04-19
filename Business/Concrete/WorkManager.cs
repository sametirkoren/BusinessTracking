using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class WorkManager :  IWorkService
    {
        private readonly EfWorkRepository efWorkRepository;

        public WorkManager()
        {
            efWorkRepository = new EfWorkRepository();
        }

        public void Add(Work entity)
        {
            efWorkRepository.Add(entity);
        }

        public void Delete(Work entity)
        {
            efWorkRepository.Delete(entity);
        }

        public void Update(Work entity)
        {
            efWorkRepository.Update(entity);
        }

        public Work GetById(int id)
        {
            return efWorkRepository.GetById(id);
        }

        public List<Work> GetAll()
        {
            return efWorkRepository.GetAll();
        }
    }
}
