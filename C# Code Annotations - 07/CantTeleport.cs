using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class CantTeleport : ITeleports
    {
        public string teleport()
        {
            return "Fails at Teleporting";
        }
    }
}
