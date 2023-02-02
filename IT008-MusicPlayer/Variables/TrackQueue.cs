using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT008_MusicPlayer.Variables
{
    class TrackQueue
    {
        private static List<string> trackList = new List<string>();
        public static List<string> TrackList
        {
            get
            {
                return trackList;
            }
        }
    }
}
