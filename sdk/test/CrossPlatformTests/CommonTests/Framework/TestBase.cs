using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
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

        public static T Client
        {
            get;
            private set;
        }

        static TestBase()
        {
            Client = (T)Activator.CreateInstance(typeof(T),
                    new object[] { TestRunner.Credentials, TestRunner.RegionEndpoint });   
        }

        protected static void RunSync(Func<Task> asyncFunc)
        {
            Task.Run(asyncFunc).RunSynchronously();
        }
    }


}
