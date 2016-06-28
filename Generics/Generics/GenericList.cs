
namespace Generics
{
    public class GenericList<T>
    {
        private T[] array;
        private int currIndex;
        private static readonly int SIZE = 10;

        public GenericList() : this(SIZE) { }

        public GenericList(int size)
        {
            array = new T[size];
            currIndex = 0;
        }

        public int GetSize()
        {
            return array.Length;
        }
         
        public void Add(T value)
        {
            array[currIndex++] = value;
        }

        public T Get(int index)
        {
            return array[index];
        }

        //Indexer
        public T this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }
    }
}
