﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fab5.Engine.Core;
using Microsoft.Xna.Framework.Audio;

namespace Fab5.Engine.Components
{
    public class Fab5SoundEffect : Component
    {
        public Fab5SoundEffect(string file)
        {
            File = file;
            SoundEffect = Fab5_Game.inst().Content.Load<SoundEffect>(file);
        }
        public String File { get; set; }
        public SoundEffect SoundEffect { get; set; }
    }
}