﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sheng.WeixinConstruction.Infrastructure
{
    public class ResetPasswordArgs
    {
        public string Account
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }
    }
}
