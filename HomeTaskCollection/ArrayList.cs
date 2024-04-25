using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTaskCollection
{
    internal class ArrayList : IEnumerable
    {
        public object[] _arr=new object[0];
        public int Capacity { get; set; } 
        public int Count { get; set; }
        public ArrayList()
        {
            Capacity = 4;
        }
        public void Add(object value) 
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = value;
            Count++;
            if (Capacity < Count) Capacity *= 2;
        }
        public void Remove(object value)
        {
            int indexRemove=Array.IndexOf(_arr, value);
            RemoveAt(indexRemove);
        }
        public void RemoveAt(int index)
        {
            if(index >0 || index <= Count)
            {
                for (int i = index; i < _arr.Length - 1; i++)
                {
                    _arr[i] = _arr[i + 1];
                }
                Array.Resize(ref _arr, _arr.Length - 1);
               Count--;
                if(Capacity/2>=Count ) Capacity /= 2;
            }

        }
        public void TrimToSize()
        {
            if (Capacity > Count)
                Array.Resize(ref _arr, Capacity = Count);
        }

        public void AddRange(ICollection collection) 
        {
            foreach (var item in collection)
            {
                Add(item);
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var item in _arr)
            {
                yield return item;
            }
        }
    }
}
