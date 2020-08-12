using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace GPACalculator
{
    /// <summary>
    /// Generic list that invokes callbacks when the data changes
    /// </summary>
    /// <typeparam name="T">Type of the stored items</typeparam>
    public class DataList<T> : IBindingList, IEnumerable<T>, ICollection<T>, IList<T>
    {
        /// <summary>
        /// Raw list wrapped by this object
        /// </summary>
        public List<T> List { get; }

        public DataList()
        {
            List = new List<T>();
        }

        public DataList(IEnumerable<T> list)
        {
            List = new List<T>(list);
        }

        /// <summary>
        /// Wrapper to the delegate called whenever the data is changed
        /// </summary>
        public event ListChangedEventHandler ListChanged
        {
            add
            {
                onListChanged += value;
            }
            remove
            {
                onListChanged -= value;
            }
        }

        /// <summary>
        /// Delegate that is called whenever the data is changed so that subscribed functions are called
        /// </summary>
        private ListChangedEventHandler onListChanged;

        /// <summary>
        /// Cached event argument for refreshing all of the list. This is the most convenient type, but it requires a
        /// full refresh of the UI and thus has the worst performance.
        /// </summary>
        private readonly ListChangedEventArgs resetEvent = new ListChangedEventArgs(ListChangedType.Reset, -1);

        /// <summary>
        /// Add a single item to the list and notify
        /// </summary>
        /// <param name="item">Item to add</param>
        public void Add(T item)
        {
            List.Add(item);
            onListChanged?.Invoke(this, resetEvent); // same as: if (onListChanged != null) onListChanged.Invoke(..);
        }
        
        /// <summary>
        /// Add all of the given items to the list and notify
        /// </summary>
        /// <param name="items">List of items to add</param>
        public void AddBatch(IEnumerable<T> items)
        {
            List.AddRange(items);
            onListChanged?.Invoke(this, resetEvent);
        }

        /// <summary>
        /// Clear the list, refill with the given items, and notify
        /// </summary>
        /// <param name="items">List of items to add</param>
        public void ResetTo(IEnumerable<T> items)
        {
            List.Clear();
            List.AddRange(items);
            onListChanged?.Invoke(this, resetEvent);
        }

        /// <summary>
        /// Remove a single item from the list and notify
        /// </summary>
        /// <param name="item">Item to remove</param>
        /// <returns>True if the item was found and removed, false if the item was not found</returns>
        public bool Remove(T item)
        {
            if (List.Remove(item))
            {
                onListChanged?.Invoke(this, resetEvent);
                return true;
            }
            return false;
        }

        /// <summary>
        /// Remove all of the given items from the list and notify
        /// </summary>
        /// <param name="items"></param>
        public void RemoveBatch(IEnumerable<T> items)
        {
            foreach (T item in items)
            {
                List.Remove(item);
            }
            onListChanged?.Invoke(this, resetEvent);
        }

        /// <summary>
        /// Insert the given item at the given index and notify
        /// </summary>
        /// <param name="index">Where the new item should be inserted</param>
        /// <param name="item">Item to insert</param>
        public void Insert(int index, T item)
        {
            List.Insert(index, item);
            onListChanged?.Invoke(this, resetEvent);
        }

        /// <summary>
        /// Remove a single item at the given index and notify
        /// </summary>
        /// <param name="index">Index of the item to remove</param>
        public void RemoveAt(int index)
        {
            List.RemoveAt(index);
            onListChanged?.Invoke(this, resetEvent);
        }

        /// <summary>
        /// Clear the list and notify
        /// </summary>
        public void Clear()
        {
            List.Clear();
            onListChanged?.Invoke(this, resetEvent);
        }

        /// <summary>
        /// Sort the inner list
        /// </summary>
        public void Sort()
        {
            List.Sort();
        }

        /// <summary>
        /// Notify of a change in a single item in the list. This is called when one of the items is changed externally.
        /// </summary>
        /// <param name="index">Index of the item that was changed</param>
        public void SendChangedEvent(int index)
        {
            onListChanged?.Invoke(this, new ListChangedEventArgs(ListChangedType.ItemChanged, index));
        }

        // Implementations of interfaces that are common to some of the interfaces
        public T this[int index] { get => ((IList<T>)List)[index]; set => ((IList<T>)List)[index] = value; }
        public int Count => List.Count;
        public bool IsReadOnly => ((ICollection<T>)List).IsReadOnly;
        public IEnumerator<T> GetEnumerator() => ((IEnumerable<T>)List).GetEnumerator();
        public bool Contains(T item) => ((ICollection<T>)List).Contains(item);
        public void CopyTo(T[] array, int arrayIndex) => ((ICollection<T>)List).CopyTo(array, arrayIndex);
        public int IndexOf(T item) => ((IList<T>)List).IndexOf(item);

        // Implementations of specific interfaces

        #region IEnumerable Implementation
        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)List).GetEnumerator();
        #endregion // IEnumerable Implementation

        #region ICollection Implementation
        object ICollection.SyncRoot => ((ICollection)List).SyncRoot;
        bool ICollection.IsSynchronized => ((ICollection)List).IsSynchronized;
        void ICollection.CopyTo(Array array, int index) => ((ICollection)List).CopyTo(array, index);
        #endregion // ICollection Implementation

        #region IList Implementation
        object IList.this[int index] { get => ((IList)List)[index]; set => ((IList)List)[index] = value; }
        bool IList.IsFixedSize => ((IList)List).IsFixedSize;

        public int Add(object value)
        {
            if (value is T)
            {
                return ((IList)List).Add(value);
            }
            throw new Exception($"Expected type {typeof(T)}, but got {value.GetType()} instead");
        }

        bool IList.Contains(object value) => ((IList)List).Contains(value);
        int IList.IndexOf(object value) => ((IList)List).IndexOf(value);

        void IList.Insert(int index, object value)
        {
            if (value is T item)
            {
                Insert(index, item);
            }
            else
            {
                throw new Exception($"Expected type {typeof(T)}, but got {value.GetType()} instead");
            }
        }

        void IList.Remove(object value)
        {
            if (value is T item)
            {
                Remove(item);
            }
            else
            {
                throw new Exception($"Expected type {typeof(T)}, but got {value.GetType()} instead");
            }
        }
        #endregion // IList Implementation

        #region IBindingList Implementation
        bool IBindingList.AllowNew => false;
        bool IBindingList.AllowEdit => false;
        bool IBindingList.AllowRemove => false;
        bool IBindingList.SupportsChangeNotification => false;
        bool IBindingList.SupportsSearching => false;
        bool IBindingList.SupportsSorting => false;
        bool IBindingList.IsSorted => throw new NotSupportedException();
        PropertyDescriptor IBindingList.SortProperty => throw new NotSupportedException();
        ListSortDirection IBindingList.SortDirection => throw new NotSupportedException();

        void IBindingList.AddIndex(PropertyDescriptor property) { }

        object IBindingList.AddNew()
        {
            throw new NotSupportedException();
        }

        void IBindingList.ApplySort(PropertyDescriptor property, ListSortDirection direction)
        {
            throw new NotSupportedException();
        }

        int IBindingList.Find(PropertyDescriptor property, object key)
        {
            throw new NotSupportedException();
        }

        void IBindingList.RemoveIndex(PropertyDescriptor property) { }

        void IBindingList.RemoveSort()
        {
            throw new NotSupportedException();
        }
        #endregion // IBindingList Implementation
    }
}
