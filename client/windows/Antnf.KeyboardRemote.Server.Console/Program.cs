﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antnf.KeyboardRemote.Server;

namespace Antnf.KeyboardRemote.Server.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new EmbeddedServer(233);
            server.Start();
            System.Console.ReadKey();
        }
    }
}
