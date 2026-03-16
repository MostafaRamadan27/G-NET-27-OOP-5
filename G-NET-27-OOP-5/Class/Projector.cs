using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_27_OOP_5
{
    internal class Projector
    {
        private bool _isOn;

        public void Start()
        {
            if (!_isOn)
            {
                _isOn = true;
                Console.WriteLine("Projector is on");
            }
            else
            {
                Console.WriteLine("Projector is already on");
            }
        }
        public void Stop()
        {
            if (_isOn)
            {
                _isOn = false;
                Console.WriteLine("Projector is off");
            }
            else
            {
                Console.WriteLine("Projector is already stopped");
            }
        }
    }
}
