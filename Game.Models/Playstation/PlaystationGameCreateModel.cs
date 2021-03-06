﻿namespace Game.Models.Playstation
{
    public class PlaystationGameCreateModel
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public double Rating { get; set; }
        public string MaturityRating { get; set; }
        public decimal Price { get; set; }
        public int PublisherId { get; set; }
        public int DeveloperId { get; set; }
    }
}
