﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entity
{
    [Serializable]
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public Room()
        { }

        public Room(int id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}
