using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSU_JSON_Creator
{
    class tracks
    {
    }
    public class SubTrack
    {
        public string file { get; set; }
        public int trim_start { get; set; }
        public int trim_end { get; set; }
    }

    public class Track
    {
        public int track_number { get; set; }
        public string title { get; set; }
        public string file { get; set; }
        public int trim_start { get; set; }
        public int trim_end { get; set; }
        public int loop { get; set; }
        public List<SubTrack> sub_tracks { get; set; }
    }

    public class Root
    {
        [JsonProperty("$schema")]
        public string Schema { get; set; }
        public string game { get; set; }
        public string pack { get; set; }
        public string artist { get; set; }
        public int normalization { get; set; }
        public string output_prefix { get; set; }
        public List<Track> tracks { get; set; }
    }
}
