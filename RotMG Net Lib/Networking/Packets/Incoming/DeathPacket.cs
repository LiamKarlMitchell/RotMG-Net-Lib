﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class DeathPacket : IncomingPacket
    {
        public string AccountId;
        public int CharId;
        public string KilledBy;
        public int ZombieId;
        public int ZombieType;
        public bool IsZombie;

        public override PacketType GetPacketType() => PacketType.Death;

        public override void Read(PacketInput input)
        {
            AccountId = input.ReadUTF();
            CharId = input.ReadInt32();
            KilledBy = input.ReadUTF();
            ZombieType = input.ReadInt32();
            ZombieId = input.ReadInt32();
            IsZombie = ZombieId != -1;
        }
    }
}
