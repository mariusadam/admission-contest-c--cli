using Admission_Contest_Cli.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admission_Contest_Cli.Repository
{
    public class MemoryRepository<IdType, T> : IRepository<IdType, T> where T : Identifiable<IdType>
    {
        private Dictionary<IdType, T> Items;

        public MemoryRepository()
        {
            Items = new Dictionary<IdType, T>();
        }

        public ICollection<T> All()
        {
            return Items.Values;
        }

        public T Delete(IdType id)
        {
            T obj = FindById(id);
            Items.Remove(id);

            return obj;
        }

        public T FindById(IdType id)
        {
            if (!Items.ContainsKey(id))
            {
                throw new IdNotFoundException("Could not find the entity with id " + id + " .");
            }

            return Items[id];
        }

        public void Insert(T obj)
        {
            if (Items.ContainsKey(obj.Id))
            {
                throw new DuplicateIdException("Already exists an entity with id " + obj.Id + " .");
            }

            Items.Add(obj.Id, obj);
        }

        public int Size()
        {
            return Items.Count;
        }

        public void Update(T obj)
        {
            if (!Items.ContainsKey(obj.Id))
            {
                throw new IdNotFoundException("Could not find the entity with id " + obj.Id + " .");
            }

            Items[obj.Id] = obj;
        }
    }
}
