﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_K_Relay.Networking.Packets.DataObjects
{
    public class LocationRecord : Location
    {
        public int Time;

        public override IDataObject Read(PacketReader r)
        {
            Time = r.ReadInt32();
            base.Read(r);

            return this;
        }

        public override void Write(PacketWriter w)
        {
            w.Write(Time);
            base.Write(w);
        }
    }
}