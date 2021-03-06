﻿using RotMG_Net_Lib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotMG_Net_Lib.Networking.Packets.Incoming
{
    public class TradeStartPacket : IncomingPacket
    {
        public TradeItem[] ClientItems;

        public string PartnerName;

        public TradeItem[] PartnerItems;

        public override PacketType GetPacketType() => PacketType.TradeStart;

        public override void Read(PacketInput input)
        {
            ClientItems = new TradeItem[input.ReadInt16()];
            for (int i = 0; i < ClientItems.Length; i++)
                (ClientItems[i] = new TradeItem()).Read(input);
            PartnerName = input.ReadUTF();
            PartnerItems = new TradeItem[input.ReadInt16()];
            for (int i = 0; i < PartnerItems.Length; i++)
                (PartnerItems[i] = new TradeItem()).Read(input);
        }
    }
}
