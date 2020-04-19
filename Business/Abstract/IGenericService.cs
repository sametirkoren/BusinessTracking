using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Business.Abstract
{
    public interface IGenericService<TEntity> where TEntity :  class  , IEntity  , new ()
    {
        void Add(TEntity entity);
        void Delete(TEntity entity);
        void Update(TEntity entity);

        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}
