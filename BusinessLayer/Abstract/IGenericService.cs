using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        public void Add<T> (T item);
        public void Remove<T> (T item);
        public void Update<T> (T item);
        public List<T> GetAll<T> ();
        public T Get<T> (int id);  
    }
}
