﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEP.Authentication.Security
{
    public interface IDecrypt
    {
        string Decode(string encodedData);
    }
}
