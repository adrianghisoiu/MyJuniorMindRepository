﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class List<T> : IList<T>
    {
        T[] listObject = new T[0];
        int count = 0;

        public T this[int index]
        {
            get
            {
                return listObject[index]; 
            }

            set
            {
                listObject[index] = value;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public bool IsReadOnly
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(T item)
        {
            Array.Resize(ref listObject, listObject.Length + 1);
            listObject[count] = item;
            count++;
        }

        public void Clear()
        {
            count = 0;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++) 
                if (listObject[i].Equals(item))
                    return true;
                return false;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int j = arrayIndex;
            for(int i = 0; i < count; i++)
            {
                array.SetValue(listObject[i],j);
                j++;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public int IndexOf(T item)
        {
            throw new NotImplementedException();
        }

        public void Insert(int index, T item)
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            throw new NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
