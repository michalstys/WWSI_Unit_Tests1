﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WWSI_App1.Lib
{
    public interface IValidator
    {
        bool IsValid(string inputString);
    }
}
