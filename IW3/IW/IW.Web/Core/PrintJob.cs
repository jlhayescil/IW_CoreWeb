﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IW.Web.Core
{
    public class PrintJob
    {
        public string JobName { get; set; }
        public string JobType { get; set; }
        public decimal JobCost { get; set; }

        public PrintItem[] PrintItems { get; set; }
    }
}
