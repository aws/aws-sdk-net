using CommonTests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp
{
    public class WindowsAppRunner : TestRunner
    {
        public WindowsAppRunner(Stream credentials) : base(credentials)
        {

        }
    }
}
