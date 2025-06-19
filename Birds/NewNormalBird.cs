using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPתרגול.Birds
{
    internal class NewNormalBird:NewBirdAbs , ICanFly
    {
        public void Fly()
        {
            Console.WriteLine("I fly");
        }
    }
}
