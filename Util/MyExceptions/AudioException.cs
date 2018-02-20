using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.MyExceptions {
    public class AudioException : System.Exception {
        public AudioException(string str) : base(str) {

        }
    }
}
