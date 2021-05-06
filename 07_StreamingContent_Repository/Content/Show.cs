﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository.Content
{
    public class Show : StreamingContent
    {
        //list as property needs a new list or a list that already exists.
        public List<Episode> Episodes { get; set; } = new List<Episode>(); 
        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageRunTime { get; set; }

    }

    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int EpisodeNumber { get; set; }
        public int SeasonNumber { get; set; }
    }
}