using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS4
{
    public class MyStack<T>
    {
        List<T> Stack = new List<T>();
        public int Count()
        {
            return Stack.Count;
        }
        public T Pop()
        {
            T stackItem = Stack.Last();
            Stack.RemoveAt(Stack.Count - 1);
            return stackItem;
        }
        public void Push(T newItem)
        {
            Stack.Add(newItem);
        }
    }
    public class MyList<T>
    {
        List<T> List = new List<T>();
        public void Add(T element)
        {
            List.Add(element);
        }
        public T Remove(int index)
        {
            T listEntry = List[index];
            List.RemoveAt(index);
            return listEntry;
        }
        public bool Contains(T element)
        {
            return List.Contains(element);
        }
        public void Clear()
        {
            List.Clear();
        }
        public void InsertAt(T element, int index)
        {
            List.Insert(index, element);
        }
        public void DeleteAt(int index)
        {
            List.RemoveAt(index);
        }
        public T Find(int index)
        {
            return List[index];
        }
    }

    public class GenericRepository<TEntity> where TEntity : class, Entity
    {
        List<TEntity> EntityList = new List<TEntity>();
        public void Add(TEntity item)
        {
            EntityList.Add(item);
        }
        public void Remove(TEntity item)
        {
            EntityList.Remove(item);
        }
        public void Save()
        {

        }
        public IEnumerable<TEntity> GetAll()
        {
            return EntityList;
        }
        public TEntity GetById(int id)
        {
            for (int i=0; i<EntityList.Count; i++)
            {
                if (EntityList[i].id == id)
                {
                    return EntityList[i];
                }
            }
            return null;
        }
    }
}
