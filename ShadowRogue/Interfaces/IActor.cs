﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShadowRogue.Interfaces
{
    public interface IActor
    {
        string Name { get; set; }
        int Awareness { get; set; }
        int AttackChance { get; set; }
        int Defense { get; set; }
        int DefenseChance { get; set; }
        int Gold { get; set; }
        int Health { get; set; }
        int MaxHealth { get; set; }
        int Speed { get; set; }
    }
}
