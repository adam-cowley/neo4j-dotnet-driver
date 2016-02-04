﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neo4j.Driver.Internal.Messaging
{
    class DiscardAllMessage:IRequestMessage
    {
        public void Dispatch(IMessageRequestHandler messageRequestHandler)
        {
            messageRequestHandler.HandleDiscardAllMessage();
        }

        public override string ToString()
        {
            return "DISCARDALL";
        }
    }
}