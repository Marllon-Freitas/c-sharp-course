using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class VolumeControlButton
    {
        IElectronicDevice device;
        public VolumeControlButton(IElectronicDevice device)
        {
            this.device = device;
        }

        public void Execute()
        {
            device.VolumeUp();
        }

        // You can provide a way to undo an action just like the power button does on a remote
        public void Undo()
        {
            device.VolumeDown();
        }
    }
}
