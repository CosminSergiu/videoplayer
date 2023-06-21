namespace proiectIP
{
    public class Song : SongComponent
    {
        private int duration;

        public Song(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}