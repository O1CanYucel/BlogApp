using BusinessLayer.Abstract;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    internal class GenericManager<T> : IGenericService<T> where T : class
    {
        GenericRepository<T> repository = new GenericRepository<T>();
        public void Add<T1>(T1 item)
        {
            throw new NotImplementedException();
        }

        public T1 Get<T1>(int id)
        {
            throw new NotImplementedException();
        }

        public List<T1> GetAll<T1>()
        {
            throw new NotImplementedException();
        }

        public void Remove<T1>(T1 item)
        {
            throw new NotImplementedException();
        }

        public void Update<T1>(T1 item)
        {
            throw new NotImplementedException();
        }
    }
}
