﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.Exception {
    public class WebSpeechException : System.Exception {
        public WebSpeechException(string str) : base(str) {

        }
    }
}
