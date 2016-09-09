using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
#if AWS_ASYNC_API
using System.Threading.Tasks;
#endif

namespace Amazon.Runtime.SharedInterfaces
{
    /// <summary>
    /// ICoreAmazonS3 is not meant to use directly. It defines S3 with basic .NET types
    /// and allows other services to be able to use S3 as a runtime dependency. This interface
    /// is implemented by the AmazonS3Client defined in the S3 assembly.
    /// </summary>
    public interface ICoreAmazonS3
    {
        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Generate a presigned URL.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="expiration">The expiration time of the presigned URL.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <returns></returns>
        string GeneratePreSignedURL(string bucketName, string objectKey, DateTime expiration, IDictionary<string, object> additionalProperties);

        //below api's are not supported in unity
#if !UNITY
#if BCL
        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Get all the object keys for the particular bucket and key prefix.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="prefix">The prefix to search for.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <returns></returns>
        IList<string> GetAllObjectKeys(string bucketName, string prefix, IDictionary<string, object> additionalProperties);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Delete the object.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        void Delete(string bucketName, string objectKey, IDictionary<string, object> additionalProperties);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Deletes the objects.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKeys">The keys of the objects.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        void Deletes(string bucketName, IEnumerable<string> objectKeys, IDictionary<string, object> additionalProperties);


        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Upload an object from a stream.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="stream">The stream with the content to upload.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        void UploadObjectFromStream(string bucketName, string objectKey, Stream stream, IDictionary<string, object> additionalProperties);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Upload an object from a file path.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="filepath">The path of the file to upload.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        void UploadObjectFromFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Download object to a file path.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="filepath">The path of the file to download the object to.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        void DownloadToFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Get stream for an object.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <returns></returns>
        Stream GetObjectStream(string bucketName, string objectKey, IDictionary<string, object> additionalProperties);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Set the ACL on the object to public readable.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="enable">Allow the object to be publicly readable.</param>
        void MakeObjectPublic(string bucketName, string objectKey, bool enable);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Check to see if the bucket exists and if it doesn't create the bucket.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        void EnsureBucketExists(string bucketName);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Check to see if the bucket exists.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <returns></returns>
        bool DoesS3BucketExist(string bucketName);
#endif

#if AWS_APM_API

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Start a delete object.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <param name="callback">Callback to be called after the operation is complete.</param>
        /// <param name="state">State specific to this asyncronous call.</param>
        /// <returns></returns>
        IAsyncResult BeginDelete(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Get the results of a delete object.
        /// </summary>
        /// <param name="result">Async result.</param>
        void EndDelete(IAsyncResult result);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Start an upload object from stream.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="stream">The stream with the content to upload.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <param name="callback">Callback to be called after the operation is complete.</param>
        /// <param name="state">State specific to this asyncronous call.</param>
        /// <returns></returns>
        IAsyncResult BeginUploadObjectFromStream(string bucketName, string objectKey, Stream stream, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Get the results of an upload from stream.
        /// </summary>
        /// <param name="result">Async result.</param>
        void EndUploadObjectFromStream(IAsyncResult result);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Start an upload object from file path.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="filepath">The path of the file to upload.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <param name="callback">Callback to be called after the operation is complete.</param>
        /// <param name="state">State specific to this asyncronous call.</param>
        /// <returns></returns>
        IAsyncResult BeginUploadObjectFromFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Get the results of an upload from file path.
        /// </summary>
        /// <param name="result">Async result.</param>
        void EndUploadObjectFromFilePath(IAsyncResult result);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Start a download to a file path.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="filepath">The path of the file to download the object to.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <param name="callback">Callback to be called after the operation is complete.</param>
        /// <param name="state">State specific to this asyncronous call.</param>
        /// <returns></returns>
        IAsyncResult BeginDownloadToFilePath(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Get results of downloading an object to a file path.
        /// </summary>
        /// <param name="result">Async result.</param>
        void EndDownloadToFilePath(IAsyncResult result);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Start opening a stream to an object in S3.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <param name="callback">Callback to be called after the operation is complete.</param>
        /// <param name="state">State specific to this asyncronous call.</param>
        /// <returns></returns>
        IAsyncResult BeginGetObjectStream(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, AsyncCallback callback, object state);

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Get results of opening a stream to an object in S3.
        /// </summary>
        /// <param name="result">Async result.</param>
        /// <returns></returns>
        Stream EndGetObjectStream(IAsyncResult result);
#endif
#if AWS_ASYNC_API

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Upload an object from a stream.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="stream">The stream with the content to upload.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns></returns>
        Task UploadObjectFromStreamAsync(string bucketName, string objectKey, Stream stream, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Delete an object.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns></returns>
        Task DeleteAsync(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Open a stream to an object in S3.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns></returns>
        Task<Stream> GetObjectStreamAsync(string bucketName, string objectKey, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Upload an object from a file path.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="filepath">The path of the file to upload.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns></returns>
        Task UploadObjectFromFilePathAsync(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

#endif

#if BCL45

        /// <summary>
        /// <para>
        /// This method is used internally to access the Amazon S3 service within other service assemblies.
        /// Please use AmazonS3Client to access Amazon S3 instead.
        /// </para>
        /// Download an object in S3 to a file path.
        /// </summary>
        /// <param name="bucketName">The name of the bucket.</param>
        /// <param name="objectKey">The key of the object.</param>
        /// <param name="filepath">The path of the file to download the object to.</param>
        /// <param name="additionalProperties">Additional property names and values to be set on the service request.</param>
        /// <param name="cancellationToken">A cancellation token that can be used by other objects or threads to receive notice of cancellation.</param>
        /// <returns></returns>
        Task DownloadToFilePathAsync(string bucketName, string objectKey, string filepath, IDictionary<string, object> additionalProperties, CancellationToken cancellationToken = default(CancellationToken));

#endif
#endif
    }
}
