using Admission_Contest_Cli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Repository
{
    public interface IRepository<IdType, T> where T : Identifiable<IdType>
    {
        void Insert(T obj);
        T Delete(IdType id);
        void Update(T obj);
        T FindById(IdType id);
        ICollection<T> All();
        int Size();
    }
}
