using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace ArtPon
{
    internal class Singleton
    {
        public static Entities1 DB { get; } = new Entities1();
    }
}
