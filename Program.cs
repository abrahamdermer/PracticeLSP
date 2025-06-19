using LSPתרגול.Birds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSPתרגול
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //BirdManager.MakeBirdFly(new Penguin());
            BirdManager.NewMakeBirdFly(new NewNormalBird());
        }
    }
}
