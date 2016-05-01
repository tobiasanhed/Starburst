﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fab5.Engine.Components {
    public class Secondary_Weapon : Weapon {
        public Secondary_Weapon() {
            this.damage = 90;
            this.fire_rate = 1.0f;
            this.sound = "LaserBlaster2";
            this.energy_cost = 50.0f;
        }
    }
}
