
namespace Generics
{
    class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetNullOrDefault()
        {
            if (HasValue)
                return (T)_value;

            return default(T);
        }
    }
}
