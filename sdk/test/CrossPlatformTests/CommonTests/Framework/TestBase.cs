using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using CommonTests.Framework;
using PCLStorage;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonTests.Framework
{
    public abstract class TestBase
    {        
        public TestBase()
        {     
        }

        public static TClient CreateClient<TClient>(AWSCredentials credentials = null, RegionEndpoint endpoint = null)
            where TClient : AmazonServiceClient
        {
            credentials = credentials ?? TestRunner.Credentials;
            endpoint = endpoint ?? TestRunner.RegionEndpoint;

            return (TClient)Activator.CreateInstance(typeof(TClient),
                    new object[] { TestRunner.Credentials,  endpoint});
        }
    }

    public abstract class TestBase<T> : TestBase where T : AmazonServiceClient, IDisposable
    {
        private bool _disposed = false;

        private T _client = null;
        public T Client
        {
            get
            {
                if (_client == null)
                {
                    _client = CreateNewClient();
                }
                return _client;
            }
        }

        public T CreateNewClient()
        {
            return CreateClient<T>(endpoint: ActualEndpoint);
        }

        /// <summary>
        /// Base folder for this test class
        /// </summary>
        public IFolder BaseFolder { get; private set; }

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
                return (AlternateEndpoint ?? TestRunner.RegionEndpoint);
            }
        }

        public TestBase()
        {
            // get hold of the file system
            var rootFolder = FileSystem.Current.LocalStorage;

            RunAsSync(async () =>
            {
                // create a folder, if one does not exist already
                this.BaseFolder = await rootFolder.CreateFolderAsync(
                    Path.Combine("AWSSDK.IntegrationTests", typeof(T).Name), CreationCollisionOption.OpenIfExists);
            });
        }

        public void BaseClean()
        {
            Dispose();
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
                RunAsSync(async () => await BaseFolder.DeleteAsync());
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
