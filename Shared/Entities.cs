﻿namespace Hanser.AB.Shared
{
    public struct Monster
    {
        public float Health;
        public float Power;
        public string Version = "A";

        public Monster()
        {
            Health = 0;
            Power = 0;
        }
    }

    public struct User
    {
        public string Name;
        public Power Power;
        public string Group = "A";

        public User()
        {
            Name = string.Empty;
            Power = new Power();
        }
    }

    public struct Power
    {
        public int Magic;
        public int Attack;
        public string Group;

        public Power()
        {
            Magic = 0;
            Attack = 0;
            Group = "A";
        }
    }
}