using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Concrete.EntityFrameworkCore.Repositories;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly EfUserRepository efUserRepository;

        public UserManager()
        {
            efUserRepository = new EfUserRepository();
        }

        public void Add(User entity)
        {
            efUserRepository.Add(entity);
        }

        public void Delete(User entity)
        {
            efUserRepository.Delete(entity);
        }

        public void Update(User entity)
        {
            efUserRepository.Update(entity);
        }

        public User GetById(int id)
        {
            return efUserRepository.GetById(id);
        }

        public List<User> GetAll()
        {
            return efUserRepository.GetAll();
        }
    }
}
