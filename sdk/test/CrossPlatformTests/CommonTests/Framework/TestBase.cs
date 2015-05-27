using Amazon.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests
{
    public abstract class TestBase
    {        
        public TestBase()
        {     
        }
    }

    public abstract class TestBase<T> : TestBase where T : AmazonServiceClient
    {
        public T Client { get; private set; }

        public TestBase()
        {
            this.Client = (T)Activator.CreateInstance(typeof(T),
                new object[] { TestRunner.Credentials, TestRunner.RegionEndpoint });
        }
    }


}
