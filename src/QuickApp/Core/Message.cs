﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core
{
    public class Message
    {
        public string Type { get; set; }

        public string Payload { get; set; }

        public string OrgId { get; set; }

        public string CallerId { get; set; }
    }
}
