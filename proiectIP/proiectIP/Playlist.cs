using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace proiectIP
{
    public class Playlist : SongComponent
    {
        private List<SongComponent> _songs;

        public Playlist(string name)
        {
            _name = name;
            _songs = new List<SongComponent>();
        }

        public List<SongComponent> Songs
        {
            get
            {
                return _songs;
            }
        }

        public override void AddNew(SongComponent component)
        {
            string filePath = "playlists.dat";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            int index = lines.FindIndex(line => line.Contains(_name));
            // Adăugăm noul rând sub titlul playlistului
            lines.Insert(index + 1, component.Name);

            // Salvăm modificările în fișier
            File.WriteAllLines(filePath, lines);
            Add(component);
        }
        public override void Add(SongComponent component)
        {
            _songs.Add(component);
            /*string filePath = "playlists.dat";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            int index = lines.FindIndex(line => line.Contains(_name));
            if (index != -1)
            {
                // Adăugăm noul rând după rândul găsit
                lines.Insert(index + 1, component.Name);

                // Salvăm modificările în fișier
                File.WriteAllLines(filePath, lines);
            }*/
        }

        public override void Remove(SongComponent component)
        {
            string filePath = "playlists.dat";
            string[] lines = File.ReadAllLines(filePath);
            List<string> modifiedLines = new List<string>(lines);
            int startIndex = 0, count = 1;
            for (int i = 0; i < modifiedLines.Count; i++)
            {
                string line = lines[i];
                if (line == component.Name)
                {
                    modifiedLines.Remove(line);
                }
            }

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var line in modifiedLines)
                {
                    writer.WriteLine(line);
                }
            }
            _songs.Remove(component);
        }
        
        public void ChangeName(string name)
        {
            _name = name;
        }
    }
}