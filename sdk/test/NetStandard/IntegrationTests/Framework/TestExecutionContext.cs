using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Amazon.DNXCore.IntegrationTests
{
    public sealed class TestExecutionContext : IDisposable
    {
        private Action _teardown;

        public TestExecutionContext(Action setup, Action teardown)
        {
            _teardown = teardown;

            if (setup !=null)            
                setup();
        }

        public TestExecutionContext(Action setup) 
            : this(setup, null)
        {
        }

        public void Dispose()
        {
            if(_teardown !=null)
                _teardown();
        }
    }
}
