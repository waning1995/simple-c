﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleC.Types.Tokens
{
    abstract class BraceToken : Token
    {
        public BraceToken(string content)
            : base(content)
        { }
    }
}
