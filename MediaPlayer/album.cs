using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPlayer
{
    public class Album
    {
        public List<Track> tracks = new List<Track>();
        int Tracklist;
        public void _Album()
        {


            tracks.Add(new Track("Drama", "TOMORROW X TOGETHER", "3:29"));
            tracks.Add(new Track("1234", "TO1234MORROW X TOGETHER", "3:212349"));
            tracks.Add(new Track("12tre3sdf34", "TO1234MOasedRROW X TOGETaseftgHER", "3:212qawes349"));
            tracks.Add(new Track("1234", "TO1234MORROW X TOGETHER", "49"));
            tracks.Add(new Track("1234", "TO1234MORROW X TOGE", "3:212349"));


            /*tracks[0].name = "Drama";
            tracks[0].artist = "TOMORROW X TOGETHER";
            tracks[0].time = "3:29";
            tracks[1].name = "Can't You See Me?";
            tracks[1].artist = "TOMORROW X TOGETHER";
            tracks[1].time = "3:21";
            tracks[2].name = "Fairy of Shampoo";
            tracks[2].artist = "TOMORROW X TOGETHER";
            tracks[2].time = "4:27";
            tracks[3].name = "Maze in the Mirror";
            tracks[3].artist = "TOMORROW X TOGETHER";
            tracks[3].time = "3:46";
            tracks[4].name = "PUMA";
            tracks[4].artist = "TOMORROW X TOGETHER";
            tracks[4].time = "3:25";
            tracks[5].name = "Eternally";
            tracks[5].artist = "TOMORROW X TOGETHER";
            tracks[5].time = "3:37";*/
            Tracklist = tracks.Count;
        }
        public Track PlayCD(int order)
        {
            Tracklist--;
            return tracks[order];
        }
        public void Addmusic(string name, string artist, string time)
        {
            tracks.Add(new Track(name,artist,time));
        }
        public void Show()
        {
            foreach (var t in tracks)
            {
                Console.WriteLine(t.name);
                Console.WriteLine(t.artist);
                Console.WriteLine(t.time);
            }
        }
    }
}
