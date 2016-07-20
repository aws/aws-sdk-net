using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon.DNXCore.IntegrationTests
{
    public abstract class TestBase
    {
        public const string CategoryAttribute = "Category";        

        static TestBase()
        {
            AWSConfigs.RegionEndpoint = RegionEndpoint.USEast1;
        }

        public TestBase()
        {                 
        }

        public static TClient CreateClient<TClient>(AWSCredentials credentials = null,
            RegionEndpoint endpoint = null) where TClient : AmazonServiceClient
        {            
            endpoint = endpoint ?? AWSConfigs.RegionEndpoint;
            if (credentials!=null)
            {
                return (TClient)Activator.CreateInstance(typeof(TClient),
                    new object[] { credentials, endpoint });
            }
            else
            {
                return (TClient)Activator.CreateInstance(typeof(TClient),
                    new object[] { endpoint });
            }            
        }
    }

    public abstract class TestBase<T> : TestBase, IDisposable
        where T : AmazonServiceClient, IDisposable
    {
        private bool _disposed = false;

        private T _client = null;
        public T Client
        {
            get
            {
                if (_client == null)
                {
                    _client = CreateClient<T>(endpoint: ActualEndpoint);
                }
                return _client;
            }
        }


        public static string BaseDirectoryPath { get; set; }

        protected virtual RegionEndpoint AlternateEndpoint
        {
            get
            {
                return null;
            }
        }

        protected RegionEndpoint ActualEndpoint
        {
            get
            {
                return (AlternateEndpoint ?? AWSConfigs.RegionEndpoint);
            }
        }

        static TestBase()
        {
            BaseDirectoryPath = Directory.GetCurrentDirectory();            
        }

        public TestBase()
        {           

        }
                
        protected static void RunAsSync(Func<Task> asyncFunc)
        {
            UtilityMethods.RunAsSync(asyncFunc);
        }

        #region IDispose implementation

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                //RunAsSync(async () => await BaseFolder.DeleteAsync());  

                this.Client.Dispose();              
                _disposed = true;
            }
        }

        #endregion

        public ServiceResponseCounter CountServiceResponses()
        {
            return CountServiceResponses(Client);
        }
        public static ServiceResponseCounter CountServiceResponses(AmazonServiceClient client)
        {
            return new ServiceResponseCounter(client);
        }
    }


}
