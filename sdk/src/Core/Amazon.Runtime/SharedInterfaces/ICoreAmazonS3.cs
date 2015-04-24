using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif

#if STORAGE_FILE
using Windows.Storage;
#endif

namespace Amazon.Runtime.SharedInterfaces
{
#if STORAGE_FILE
    [CLSCompliant(false)]
#endif
    public interface ICoreAmazonS3
    {
        string GeneratePreSignedURL(string bucketName, string objectKey, DateTime expiration, IDictionary<string, object> additionalProperties);

#if BCL
        IList<string> GetAllObjectKeys(string bucketName, string prefix, IDictionary<string, object> additionalProperties);

        void Delete(string bucketName, string objectKey, IDictionary<string, object> additionalProperties);

        void Deletes(string bucketName, IEnumerable<string> objectKeys, IDictionary<string, object> additionalProperties);


        void UploadObjectFromStream(string bucketName, string objectKey, Stream stream, IDictionary<string, object> additionalProperties);

        void UploadObjectFromFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties);

        void DownloadToFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties);

        Stream GetObjectStream(string bucketName, string objectKey, IDictionary<string, object> additionalProperties);

        void MakeObjectPublic(string bucketName, string objectKey, bool enable);

        void EnsureBucketExists(string bucketName);

        bool DoesS3BucketExist(string bucketName);
#endif

#if AWS_APM_API

        IAsyncResult BeginDelete(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state);

        void EndDelete(IAsyncResult result);

        IAsyncResult BeginUploadObjectFromStream(string bucketName, string objectKey, Stream stream, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state);

        void EndUploadObjectFromStream(IAsyncResult result);

        IAsyncResult BeginUploadObjectFromFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state);

        void EndUploadObjectFromFilePath(IAsyncResult result);

        IAsyncResult BeginDownloadToFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state);

        void EndDownloadToFilePath(IAsyncResult result);

        IAsyncResult BeginGetObjectStream(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state);

        Stream EndGetObjectStream(IAsyncResult result);
#endif
#if AWS_ASYNC_API

        Task UploadObjectFromStreamAsync(string bucketName, string objectKey, Stream stream, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

        Task DeleteAsync(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

        Task<Stream> GetObjectStreamAsync(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

        Task UploadObjectFromFilePathAsync(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

#endif

#if BCL45

        Task DownloadToFilePathAsync(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

#endif

#if STORAGE_FILE

        Task UploadObjectFromStorageAsync(string bucketName, string objectKey, IStorageFile storage, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

        Task DownloadToStorageAsync(string bucketName, string objectKey, IStorageFile storageFile, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

#endif
    }
}
