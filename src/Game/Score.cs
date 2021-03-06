﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game
{
    [Serializable]
    public class Score : IComparable<Score>
    {
        public string Name { get; set; }
        public DateTime Time { get; set; }
        public int Points { get; set; }
        private Score()
        {
        }
        public Score(string name, int points)
        {
            Name = name;
            Points = points;
            Time = DateTime.Now.Date;
        }
        public int CompareTo(Score other)
        {
            if (other == null)
            {
                return 1;
            }
            if (Points == other.Points)
            {
                return Name.CompareTo(other.Name);
            }
            return Points.CompareTo(other.Points);
        }
    }
}
