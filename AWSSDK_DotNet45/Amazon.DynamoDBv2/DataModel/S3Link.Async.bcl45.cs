using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

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
            return GetTransferUtility().UploadAsync(sourcePath, this.linker.s3.bucket, this.linker.s3.key, cancellationToken);
        }

        /// <summary>
        /// Downloads the file from the S3Link's specified bucket and key then saves it in the given path. 
        /// Creates directories and the file if they do not already exist.
        /// </summary>
        /// <param name="downloadPath">Path to save the file.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns>An asynchronous task of the request</returns>
        public Task DownloadToAsync(string downloadPath, CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new Amazon.S3.Transfer.TransferUtilityDownloadRequest();
            request.BucketName = this.linker.s3.bucket;
            request.Key = this.linker.s3.key;
            request.FilePath = downloadPath;
            return GetTransferUtility().DownloadAsync(request, cancellationToken);
        }
    }
}
