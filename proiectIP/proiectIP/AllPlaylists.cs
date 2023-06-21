using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace proiectIP
{
    public class AllPlaylists : SongComponent
    {
        private List<SongComponent> _playlists;

        public List<SongComponent> Playlists
        {
            get
            {
                return _playlists;
            }
        }

        public AllPlaylists()
        {
            _playlists = new List<SongComponent>();
            try
            {
                string filePath = "playlists.dat";
                StreamReader reader = File.OpenText(filePath);
                string line;
                line = reader.ReadLine();
                while ((line = reader.ReadLine()) != null)
                {
                    Add(new Playlist(line));

                    while ((line = reader.ReadLine()) != "" && line != null)
                    {
                        _playlists[_playlists.Count - 1].Add(new Song(line));
                    }
                }
                _playlists.Sort();
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public override void Add(SongComponent component)
        {
            _playlists.Add(component);
        }

        public void AddNew(SongComponent component)
        {
            Add(component);

            string filePath = "playlists.dat";
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine("\n" + component.Name);
            }
            _playlists.Sort();
        }
        


        public override void Remove(SongComponent component)
        {
            _playlists.Remove(component);

            string filePath = "playlists.dat";
            string[] lines = File.ReadAllLines(filePath);
            List<string> modifiedLines = new List<string>(lines);
            int startIndex = 0, count = 1;
            for (int i = 0; i < modifiedLines.Count; i++)
            {
                string line = lines[i];
                if (line == component.Name)
                {
                    startIndex = i;
                    while (i < modifiedLines.Count && modifiedLines[i] != "")
                    {
                        count++;
                        i++;
                    }
                    break;
                }
            }
            modifiedLines.RemoveRange(startIndex - 1, count);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var line in modifiedLines)
                {
                    writer.WriteLine(line);
                }
            }
        }



        public SongComponent GetComponentByName(string name)
        {
            foreach (var playlist in _playlists)
            {
                if (playlist.Name == name)
                    return playlist;
            }

            return null;
        }
    }
}