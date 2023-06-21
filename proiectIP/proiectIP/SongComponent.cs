using System;

namespace proiectIP
{
    public abstract class SongComponent : IComparable
    {
        protected string _name;

        public string Name
        {
            get { return _name; }
        }
        public virtual void Add(SongComponent component)
        {
            throw new NotImplementedException();
        }

        public virtual void AddNew(SongComponent component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove(SongComponent component)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            if ((obj == null) || ! GetType().Equals(obj.GetType()))
            {
                return false;
            }
            SongComponent component = (SongComponent) obj;
            return component._name == _name;
        }

        public int CompareTo(object obj)
        {
            if ((obj == null) || ! GetType().Equals(obj.GetType()))
            {
                return 1;
            }
            SongComponent component = (SongComponent) obj;
            return _name.CompareTo(component._name);
        }
    }
}