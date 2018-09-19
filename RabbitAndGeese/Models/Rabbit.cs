﻿using RabbitAndGeese.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitAndGeese.Models

{
    public class Rabbit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int MaxFeetPerSecond { get; set; }
        public Size EarSize { get; set; }
        public Sex Sex { get; set; }
        public List<Goose> OwnedGeese { get; set; } = new List<Goose>();
        public List<Saddle> OwnedSaddles { get; set; } = new List<Saddle>();

    }

}
