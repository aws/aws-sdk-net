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
    }

    public abstract class TestBase<T> : TestBase where T : AmazonServiceClient, IDisposable
    {
        private bool _disposed = false;

        public static T Client { get; private set; }

        /// <summary>
        /// Base folder for this test class
        /// </summary>
        public IFolder BaseFolder { get; private set; }

        static TestBase()
        {
            Client = (T)Activator.CreateInstance(typeof(T),
                    new object[] { TestRunner.Credentials, TestRunner.RegionEndpoint });
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

        public static ServiceResponseCounter CountServiceResponses()
        {
            return CountServiceResponses(Client);
        }
        public static ServiceResponseCounter CountServiceResponses(AmazonServiceClient client)
        {
            return new ServiceResponseCounter(client);
        }
    }


}
