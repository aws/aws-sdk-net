using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
#if (WIN_RT || WINDOWS_PHONE)
using Windows.Storage;
#endif

namespace Amazon.DynamoDBv2.DataModel
{
    public partial class S3Link
    {
        /// <summary>
        /// Uploads the specified file and stores it in the specified bucket with the provided key from construction.
        /// </summary>
        /// <param name="sourcePath">Path of the file to be uploaded.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>An asynchronous task of the request</returns>
        public Task UploadFromAsync(string sourcePath, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.s3ClientCache.GetClient(this.RegionAsEndpoint).UploadObjectFromFilePathAsync(
                this.linker.s3.bucket, this.linker.s3.key, sourcePath, null, cancellationToken);
        }

#if !PCL
        /// <summary>
        /// Uploads the specified file and stores it in the specified bucket with the provided key from construction.
        /// </summary>
        /// <param name="sourceFile">Path of the file to be uploaded.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>An asynchronous task of the request</returns>
        [System.CLSCompliant(false)]
        public Task UploadFromAsync(IStorageFile sourceFile, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.s3ClientCache.GetClient(this.RegionAsEndpoint).UploadObjectFromStorageAsync(
                this.linker.s3.bucket, this.linker.s3.key, sourceFile, null, cancellationToken);
        }

        /// <summary>
        /// Downloads the file from the S3Link's specified bucket and key then saves it in the given path. 
        /// Creates directories and the file if they do not already exist.
        /// </summary>
        /// <param name="storageFile">Storage file to download to.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>An asynchronous task of the request</returns>
        [System.CLSCompliant(false)]
        public Task DownloadToAsync(IStorageFile storageFile, CancellationToken cancellationToken = default(CancellationToken))
        {
            return this.s3ClientCache.GetClient(this.RegionAsEndpoint).DownloadToStorageAsync(
                this.linker.s3.bucket, this.linker.s3.key, storageFile, null, cancellationToken);
        }
#endif
    }
}
