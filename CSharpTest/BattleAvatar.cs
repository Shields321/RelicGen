using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace CSharpTest
{
    internal class BattleAvatar
    {
        public int CharacterId { get; set; }
        public int Level { get; set; }
        public int Eidelon { get; set; }
        public int Ascention { get; set; }
        public int hp { get; set; }
        public int worldLevel { get; set; }

        public override string ToString()
        {
            return $"CharacterId: {CharacterId}, Level: {Level}, Eidelon: {Eidelon}, Ascention: {Ascention}, Health: {hp}, World Level: {worldLevel}";
        }
    }
}
