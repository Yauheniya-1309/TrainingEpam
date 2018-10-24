using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tas11_FireStation
{
    class FireEventArgs:EventArgs
    {
        public string Message
        {
            get;
            set;
        }

        public FireEventArgs()
            : base()
        {

        }
    }
}
