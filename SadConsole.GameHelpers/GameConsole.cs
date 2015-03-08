﻿using SadConsole.Consoles;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SadConsole.GameHelpers
{
    [DataContract]

    public class GameConsoleMetadata : Consoles.LayeredConsoleMetadata
    {
        [DataMember]
        public GameObjectCollection GameObjects = new GameObjectCollection();
    }

    [DataContract]

    public class GameConsole : Consoles.LayeredConsole<GameConsoleMetadata>
    {
        public GameConsole(int layers, int width, int height) :base(layers, width, height) { }
    }
}
