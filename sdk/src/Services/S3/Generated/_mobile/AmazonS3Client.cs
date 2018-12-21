/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.S3
{
    /// <summary>
    /// Implementation for accessing S3
    ///
    /// 
    /// </summary>
    public partial class AmazonS3Client : AmazonServiceClient, IAmazonS3
    {
        private static IServiceMetadata serviceMetadata = new AmazonS3Metadata();
        
        #region Constructors

#if CORECLR
    
        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonS3Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config()) { }

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonS3Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonS3Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AmazonS3Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonS3Client(AWSCredentials credentials)
            : this(credentials, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonS3Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Credentials and an
        /// AmazonS3Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(AWSCredentials credentials, AmazonS3Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonS3Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config())
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonS3Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonS3Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonS3Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonS3Client Configuration Object</param>
        public AmazonS3Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonS3Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new Amazon.S3.Internal.S3Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PreMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.S3.Internal.AmazonS3PostMarshallHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.EndpointResolver>(new Amazon.S3.Internal.AmazonS3KmsHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3ResponseHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.ErrorCallbackHandler>(new Amazon.S3.Internal.AmazonS3ExceptionHandler());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.S3.Internal.AmazonS3RedirectHandler());
            pipeline.ReplaceHandler<Amazon.Runtime.Internal.RetryHandler>(new Amazon.Runtime.Internal.RetryHandler(new Amazon.S3.Internal.AmazonS3RetryPolicy(this.Config)));
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AbortMultipartUpload

        internal virtual AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<AbortMultipartUploadResponse>(request, options);
        }


        /// <summary>
        /// Aborts a multipart upload.
        /// 
        ///  
        /// <para>
        /// To verify that all parts have been removed, so you don't get charged for the part
        /// storage, you should call the List Parts operation and ensure the parts list is empty.
        /// </para>
        /// </summary>
        /// <param name="bucketName">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="key">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="uploadId">A property of AbortMultipartUploadRequest used to execute the AbortMultipartUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AbortMultipartUpload service method, as returned by S3.</returns>
        public virtual Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(string bucketName, string key, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AbortMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            return AbortMultipartUploadAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AbortMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AbortMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<AbortMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CompleteMultipartUpload

        internal virtual CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<CompleteMultipartUploadResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CompleteMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CompleteMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<CompleteMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyObject

        internal virtual CopyObjectResponse CopyObject(CopyObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return Invoke<CopyObjectResponse>(request, options);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public virtual Task<CopyObjectResponse> CopyObjectAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            return CopyObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="sourceVersionId">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationBucket">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="destinationKey">A property of CopyObjectRequest used to execute the CopyObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by S3.</returns>
        public virtual Task<CopyObjectResponse> CopyObjectAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyObjectRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            return CopyObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyObjectResponseUnmarshaller.Instance;

            return InvokeAsync<CopyObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyPart

        internal virtual CopyPartResponse CopyPart(CopyPartRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyPartResponseUnmarshaller.Instance;

            return Invoke<CopyPartResponse>(request, options);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public virtual Task<CopyPartResponse> CopyPartAsync(string sourceBucket, string sourceKey, string destinationBucket, string destinationKey, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            return CopyPartAsync(request, cancellationToken);
        }


        /// <summary>
        /// Uploads a part by copying data from an existing object as data source.
        /// </summary>
        /// <param name="sourceBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="sourceVersionId">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationBucket">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="destinationKey">A property of CopyPartRequest used to execute the CopyPart service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose part is being copied.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by S3.</returns>
        public virtual Task<CopyPartResponse> CopyPartAsync(string sourceBucket, string sourceKey, string sourceVersionId, string destinationBucket, string destinationKey, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CopyPartRequest();
            request.SourceBucket = sourceBucket;
            request.SourceKey = sourceKey;
            request.SourceVersionId = sourceVersionId;
            request.DestinationBucket = destinationBucket;
            request.DestinationKey = destinationKey;
            request.UploadId = uploadId;
            return CopyPartAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<CopyPartResponse> CopyPartAsync(CopyPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyPartResponseUnmarshaller.Instance;

            return InvokeAsync<CopyPartResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucket

        internal virtual DeleteBucketResponse DeleteBucket(DeleteBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketResponse>(request, options);
        }


        /// <summary>
        /// Deletes the bucket. All objects (including all object versions and Delete Markers)
        /// in the bucket must be deleted before the bucket itself can be deleted.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketRequest used to execute the DeleteBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucket service method, as returned by S3.</returns>
        public virtual Task<DeleteBucketResponse> DeleteBucketAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketRequest();
            request.BucketName = bucketName;
            return DeleteBucketAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketAnalyticsConfiguration

        internal virtual DeleteBucketAnalyticsConfigurationResponse DeleteBucketAnalyticsConfiguration(DeleteBucketAnalyticsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketAnalyticsConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketAnalyticsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketAnalyticsConfigurationResponse> DeleteBucketAnalyticsConfigurationAsync(DeleteBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketAnalyticsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketEncryption

        internal virtual DeleteBucketEncryptionResponse DeleteBucketEncryption(DeleteBucketEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketEncryptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketEncryption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketEncryptionResponse> DeleteBucketEncryptionAsync(DeleteBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketInventoryConfiguration

        internal virtual DeleteBucketInventoryConfigurationResponse DeleteBucketInventoryConfiguration(DeleteBucketInventoryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketInventoryConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketInventoryConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketInventoryConfigurationResponse> DeleteBucketInventoryConfigurationAsync(DeleteBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketInventoryConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketMetricsConfiguration

        internal virtual DeleteBucketMetricsConfigurationResponse DeleteBucketMetricsConfiguration(DeleteBucketMetricsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketMetricsConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketMetricsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketMetricsConfigurationResponse> DeleteBucketMetricsConfigurationAsync(DeleteBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketMetricsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketPolicy

        internal virtual DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketPolicyResponse>(request, options);
        }


        /// <summary>
        /// Deletes the policy from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketPolicyRequest used to execute the DeleteBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketPolicy service method, as returned by S3.</returns>
        public virtual Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketPolicyRequest();
            request.BucketName = bucketName;
            return DeleteBucketPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(DeleteBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketReplication

        internal virtual DeleteBucketReplicationResponse DeleteBucketReplication(DeleteBucketReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketReplicationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketReplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketReplicationResponse> DeleteBucketReplicationAsync(DeleteBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketTagging

        internal virtual DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketTaggingResponse>(request, options);
        }


        /// <summary>
        /// Deletes the tags from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketTaggingRequest used to execute the DeleteBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketTagging service method, as returned by S3.</returns>
        public virtual Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketTaggingRequest();
            request.BucketName = bucketName;
            return DeleteBucketTaggingAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(DeleteBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBucketWebsite

        internal virtual DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<DeleteBucketWebsiteResponse>(request, options);
        }


        /// <summary>
        /// This operation removes the website configuration from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteBucketWebsiteRequest used to execute the DeleteBucketWebsite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBucketWebsite service method, as returned by S3.</returns>
        public virtual Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteBucketWebsiteRequest();
            request.BucketName = bucketName;
            return DeleteBucketWebsiteAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBucketWebsiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCORSConfiguration

        internal virtual DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteCORSConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the CORS configuration information set for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteCORSConfigurationRequest used to execute the DeleteCORSConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCORSConfiguration service method, as returned by S3.</returns>
        public virtual Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteCORSConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteCORSConfigurationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(DeleteCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCORSConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLifecycleConfiguration

        internal virtual DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the lifecycle configuration from the bucket.
        /// </summary>
        /// <param name="bucketName">A property of DeleteLifecycleConfigurationRequest used to execute the DeleteLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            return DeleteLifecycleConfigurationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(DeleteLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteObject

        internal virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectResponse>(request, options);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// </summary>
        /// <param name="bucketName">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="key">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return DeleteObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Removes the null version (if there is one) of an object and inserts a delete marker,
        /// which becomes the latest version of the object. If there isn't a null version, Amazon
        /// S3 does not remove any objects.
        /// </summary>
        /// <param name="bucketName">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="key">A property of DeleteObjectRequest used to execute the DeleteObject service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by S3.</returns>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return DeleteObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteObjects

        internal virtual DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteObjectsResponse> DeleteObjectsAsync(DeleteObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteObjectTagging

        internal virtual DeleteObjectTaggingResponse DeleteObjectTagging(DeleteObjectTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectTaggingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjectTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeleteObjectTaggingResponse> DeleteObjectTaggingAsync(DeleteObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteObjectTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePublicAccessBlock

        internal virtual DeletePublicAccessBlockResponse DeletePublicAccessBlock(DeletePublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<DeletePublicAccessBlockResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<DeletePublicAccessBlockResponse> DeletePublicAccessBlockAsync(DeletePublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePublicAccessBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePublicAccessBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetACL

        internal virtual GetACLResponse GetACL(GetACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetACLResponseUnmarshaller.Instance;

            return Invoke<GetACLResponse>(request, options);
        }


        /// <summary>
        /// Gets the access control policy for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetACLRequest used to execute the GetACL service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by S3.</returns>
        public virtual Task<GetACLResponse> GetACLAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetACLRequest();
            request.BucketName = bucketName;
            return GetACLAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetACLResponse> GetACLAsync(GetACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetACLResponseUnmarshaller.Instance;

            return InvokeAsync<GetACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketAccelerateConfiguration

        internal virtual GetBucketAccelerateConfigurationResponse GetBucketAccelerateConfiguration(GetBucketAccelerateConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketAccelerateConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns the accelerate configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket for which the accelerate configuration is retrieved.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketAccelerateConfiguration service method, as returned by S3.</returns>
        public virtual Task<GetBucketAccelerateConfigurationResponse> GetBucketAccelerateConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketAccelerateConfigurationRequest();
            request.BucketName = bucketName;
            return GetBucketAccelerateConfigurationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAccelerateConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketAccelerateConfigurationResponse> GetBucketAccelerateConfigurationAsync(GetBucketAccelerateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketAccelerateConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketAnalyticsConfiguration

        internal virtual GetBucketAnalyticsConfigurationResponse GetBucketAnalyticsConfiguration(GetBucketAnalyticsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketAnalyticsConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketAnalyticsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketAnalyticsConfigurationResponse> GetBucketAnalyticsConfigurationAsync(GetBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketAnalyticsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketEncryption

        internal virtual GetBucketEncryptionResponse GetBucketEncryption(GetBucketEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<GetBucketEncryptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketEncryption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketEncryptionResponse> GetBucketEncryptionAsync(GetBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketInventoryConfiguration

        internal virtual GetBucketInventoryConfigurationResponse GetBucketInventoryConfiguration(GetBucketInventoryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketInventoryConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketInventoryConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketInventoryConfigurationResponse> GetBucketInventoryConfigurationAsync(GetBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketInventoryConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketLocation

        internal virtual GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return Invoke<GetBucketLocationResponse>(request, options);
        }


        /// <summary>
        /// Returns the region the bucket resides in.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLocationRequest used to execute the GetBucketLocation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by S3.</returns>
        public virtual Task<GetBucketLocationResponse> GetBucketLocationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketLocationRequest();
            request.BucketName = bucketName;
            return GetBucketLocationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketLocationResponse> GetBucketLocationAsync(GetBucketLocationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLocationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLocationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketLocationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketLogging

        internal virtual GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketLoggingResponse>(request, options);
        }


        /// <summary>
        /// Returns the logging status of a bucket and the permissions users have to view and
        /// modify that status. To use GET, you must be the bucket owner.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketLoggingRequest used to execute the GetBucketLogging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by S3.</returns>
        public virtual Task<GetBucketLoggingResponse> GetBucketLoggingAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketLoggingRequest();
            request.BucketName = bucketName;
            return GetBucketLoggingAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketLoggingResponse> GetBucketLoggingAsync(GetBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketMetricsConfiguration

        internal virtual GetBucketMetricsConfigurationResponse GetBucketMetricsConfiguration(GetBucketMetricsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetBucketMetricsConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketMetricsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketMetricsConfigurationResponse> GetBucketMetricsConfigurationAsync(GetBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketMetricsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketNotification

        internal virtual GetBucketNotificationResponse GetBucketNotification(GetBucketNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<GetBucketNotificationResponse>(request, options);
        }


        /// <summary>
        /// Returns the notification configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">Name of the bucket to get the notification configuration for.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by S3.</returns>
        public virtual Task<GetBucketNotificationResponse> GetBucketNotificationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketNotificationRequest();
            request.BucketName = bucketName;
            return GetBucketNotificationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketNotificationResponse> GetBucketNotificationAsync(GetBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketPolicy

        internal virtual GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<GetBucketPolicyResponse>(request, options);
        }


        /// <summary>
        /// Returns the policy of a specified bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketPolicyRequest used to execute the GetBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by S3.</returns>
        public virtual Task<GetBucketPolicyResponse> GetBucketPolicyAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketPolicyRequest();
            request.BucketName = bucketName;
            return GetBucketPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketPolicyResponse> GetBucketPolicyAsync(GetBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketPolicyStatus

        internal virtual GetBucketPolicyStatusResponse GetBucketPolicyStatus(GetBucketPolicyStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyStatusResponseUnmarshaller.Instance;

            return Invoke<GetBucketPolicyStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicyStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicyStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketPolicyStatusResponse> GetBucketPolicyStatusAsync(GetBucketPolicyStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketPolicyStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketPolicyStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketPolicyStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketReplication

        internal virtual GetBucketReplicationResponse GetBucketReplication(GetBucketReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<GetBucketReplicationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketReplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketReplicationResponse> GetBucketReplicationAsync(GetBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketRequestPayment

        internal virtual GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<GetBucketRequestPaymentResponse>(request, options);
        }


        /// <summary>
        /// Returns the request payment configuration of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketRequestPaymentRequest used to execute the GetBucketRequestPayment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by S3.</returns>
        public virtual Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            return GetBucketRequestPaymentAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketRequestPaymentResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketRequestPaymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketTagging

        internal virtual GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<GetBucketTaggingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketTaggingResponse> GetBucketTaggingAsync(GetBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketVersioning

        internal virtual GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<GetBucketVersioningResponse>(request, options);
        }


        /// <summary>
        /// Returns the versioning state of a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketVersioningRequest used to execute the GetBucketVersioning service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by S3.</returns>
        public virtual Task<GetBucketVersioningResponse> GetBucketVersioningAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketVersioningRequest();
            request.BucketName = bucketName;
            return GetBucketVersioningAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketVersioningResponse> GetBucketVersioningAsync(GetBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketVersioningResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketVersioningResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetBucketWebsite

        internal virtual GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<GetBucketWebsiteResponse>(request, options);
        }


        /// <summary>
        /// Returns the website configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetBucketWebsiteRequest used to execute the GetBucketWebsite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by S3.</returns>
        public virtual Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetBucketWebsiteRequest();
            request.BucketName = bucketName;
            return GetBucketWebsiteAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(GetBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<GetBucketWebsiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCORSConfiguration

        internal virtual GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetCORSConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns the CORS configuration for the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetCORSConfigurationRequest used to execute the GetCORSConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by S3.</returns>
        public virtual Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetCORSConfigurationRequest();
            request.BucketName = bucketName;
            return GetCORSConfigurationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(GetCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetCORSConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLifecycleConfiguration

        internal virtual GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns the lifecycle configuration information set on the bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetLifecycleConfigurationRequest used to execute the GetLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            return GetLifecycleConfigurationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(GetLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObject

        internal virtual GetObjectResponse GetObject(GetObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;

            return Invoke<GetObjectResponse>(request, options);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="key">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public virtual Task<GetObjectResponse> GetObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Retrieves objects from Amazon S3.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="key">A property of GetObjectRequest used to execute the GetObject service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by S3.</returns>
        public virtual Task<GetObjectResponse> GetObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return GetObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectLegalHold

        internal virtual GetObjectLegalHoldResponse GetObjectLegalHold(GetObjectLegalHoldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLegalHoldResponseUnmarshaller.Instance;

            return Invoke<GetObjectLegalHoldResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectLegalHold operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectLegalHold operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectLegalHoldResponse> GetObjectLegalHoldAsync(GetObjectLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLegalHoldResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectLegalHoldResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectLockConfiguration

        internal virtual GetObjectLockConfigurationResponse GetObjectLockConfiguration(GetObjectLockConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLockConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetObjectLockConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectLockConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectLockConfigurationResponse> GetObjectLockConfigurationAsync(GetObjectLockConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectLockConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectLockConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectMetadata

        internal virtual GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return Invoke<GetObjectMetadataResponse>(request, options);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="key">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public virtual Task<GetObjectMetadataResponse> GetObjectMetadataAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectMetadataAsync(request, cancellationToken);
        }


        /// <summary>
        /// The HEAD operation retrieves metadata from an object without returning the object
        /// itself. This operation is useful if you're only interested in an object's metadata.
        /// To use HEAD, you must have READ access to the object.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="key">A property of GetObjectMetadataRequest used to execute the GetObjectMetadata service method.</param>
        /// <param name="versionId">VersionId used to reference a specific version of the object.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by S3.</returns>
        public virtual Task<GetObjectMetadataResponse> GetObjectMetadataAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectMetadataRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return GetObjectMetadataAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectMetadataResponse> GetObjectMetadataAsync(GetObjectMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectRetention

        internal virtual GetObjectRetentionResponse GetObjectRetention(GetObjectRetentionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectRetentionResponseUnmarshaller.Instance;

            return Invoke<GetObjectRetentionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectRetention operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectRetention operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectRetentionResponse> GetObjectRetentionAsync(GetObjectRetentionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectRetentionResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectRetentionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectTagging

        internal virtual GetObjectTaggingResponse GetObjectTagging(GetObjectTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<GetObjectTaggingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectTaggingResponse> GetObjectTaggingAsync(GetObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectTorrent

        internal virtual GetObjectTorrentResponse GetObjectTorrent(GetObjectTorrentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTorrentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return Invoke<GetObjectTorrentResponse>(request, options);
        }


        /// <summary>
        /// Return torrent files from a bucket.
        /// </summary>
        /// <param name="bucketName">A property of GetObjectTorrentRequest used to execute the GetObjectTorrent service method.</param>
        /// <param name="key">A property of GetObjectTorrentRequest used to execute the GetObjectTorrent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by S3.</returns>
        public virtual Task<GetObjectTorrentResponse> GetObjectTorrentAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetObjectTorrentRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return GetObjectTorrentAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTorrent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetObjectTorrentResponse> GetObjectTorrentAsync(GetObjectTorrentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectTorrentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectTorrentResponseUnmarshaller.Instance;

            return InvokeAsync<GetObjectTorrentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPublicAccessBlock

        internal virtual GetPublicAccessBlockResponse GetPublicAccessBlock(GetPublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<GetPublicAccessBlockResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<GetPublicAccessBlockResponse> GetPublicAccessBlockAsync(GetPublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPublicAccessBlockResponseUnmarshaller.Instance;

            return InvokeAsync<GetPublicAccessBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  HeadBucket

        internal virtual HeadBucketResponse HeadBucket(HeadBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HeadBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return Invoke<HeadBucketResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the HeadBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the HeadBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        internal virtual Task<HeadBucketResponse> HeadBucketAsync(HeadBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = HeadBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = HeadBucketResponseUnmarshaller.Instance;

            return InvokeAsync<HeadBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  InitiateMultipartUpload

        internal virtual InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return Invoke<InitiateMultipartUploadResponse>(request, options);
        }


        /// <summary>
        /// Initiates a multipart upload and returns an upload ID.
        /// 
        ///  
        /// <para>
        ///  <b>Note:</b> After you initiate multipart upload and upload one or more parts, you
        /// must either complete or abort multipart upload in order to stop getting charged for
        /// storage of the uploaded parts. Only after you either complete or abort multipart upload,
        /// Amazon S3 frees up the parts storage and stops charging you for the parts storage.
        /// </para>
        /// </summary>
        /// <param name="bucketName">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// <param name="key">A property of InitiateMultipartUploadRequest used to execute the InitiateMultipartUpload service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by S3.</returns>
        public virtual Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new InitiateMultipartUploadRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return InitiateMultipartUploadAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = InitiateMultipartUploadRequestMarshaller.Instance;
            options.ResponseUnmarshaller = InitiateMultipartUploadResponseUnmarshaller.Instance;

            return InvokeAsync<InitiateMultipartUploadResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBucketAnalyticsConfigurations

        internal virtual ListBucketAnalyticsConfigurationsResponse ListBucketAnalyticsConfigurations(ListBucketAnalyticsConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketAnalyticsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketAnalyticsConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketAnalyticsConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketAnalyticsConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketAnalyticsConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListBucketAnalyticsConfigurationsResponse> ListBucketAnalyticsConfigurationsAsync(ListBucketAnalyticsConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketAnalyticsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketAnalyticsConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketAnalyticsConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBucketInventoryConfigurations

        internal virtual ListBucketInventoryConfigurationsResponse ListBucketInventoryConfigurations(ListBucketInventoryConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketInventoryConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketInventoryConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketInventoryConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketInventoryConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketInventoryConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListBucketInventoryConfigurationsResponse> ListBucketInventoryConfigurationsAsync(ListBucketInventoryConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketInventoryConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketInventoryConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketInventoryConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBucketMetricsConfigurations

        internal virtual ListBucketMetricsConfigurationsResponse ListBucketMetricsConfigurations(ListBucketMetricsConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketMetricsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketMetricsConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListBucketMetricsConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBucketMetricsConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBucketMetricsConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListBucketMetricsConfigurationsResponse> ListBucketMetricsConfigurationsAsync(ListBucketMetricsConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketMetricsConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketMetricsConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketMetricsConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListBuckets

        internal virtual ListBucketsResponse ListBuckets()
        {
            return ListBuckets(new ListBucketsRequest());
        }
        internal virtual ListBucketsResponse ListBuckets(ListBucketsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return Invoke<ListBucketsResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of all buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by S3.</returns>
        public virtual Task<ListBucketsResponse> ListBucketsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return ListBucketsAsync(new ListBucketsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListBucketsResponse> ListBucketsAsync(ListBucketsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListBucketsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBucketsResponseUnmarshaller.Instance;

            return InvokeAsync<ListBucketsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMultipartUploads

        internal virtual ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return Invoke<ListMultipartUploadsResponse>(request, options);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// </summary>
        /// <param name="bucketName">A property of ListMultipartUploadsRequest used to execute the ListMultipartUploads service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            return ListMultipartUploadsAsync(request, cancellationToken);
        }


        /// <summary>
        /// This operation lists in-progress multipart uploads.
        /// </summary>
        /// <param name="bucketName">A property of ListMultipartUploadsRequest used to execute the ListMultipartUploads service method.</param>
        /// <param name="prefix">Lists in-progress uploads only for those keys that begin with the specified prefix.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by S3.</returns>
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListMultipartUploadsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListMultipartUploadsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMultipartUploadsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMultipartUploadsResponseUnmarshaller.Instance;

            return InvokeAsync<ListMultipartUploadsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjects

        internal virtual ListObjectsResponse ListObjects(ListObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return Invoke<ListObjectsResponse>(request, options);
        }


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListObjectsRequest used to execute the ListObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public virtual Task<ListObjectsResponse> ListObjectsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            return ListObjectsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns some or all (up to 1000) of the objects in a bucket. You can use the request
        /// parameters as selection criteria to return a subset of the objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListObjectsRequest used to execute the ListObjects service method.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by S3.</returns>
        public virtual Task<ListObjectsResponse> ListObjectsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListObjectsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListObjectsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjectsV2

        internal virtual ListObjectsV2Response ListObjectsV2(ListObjectsV2Request request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;

            return Invoke<ListObjectsV2Response>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListObjectsV2 operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjectsV2 operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListObjectsV2Response> ListObjectsV2Async(ListObjectsV2Request request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsV2RequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsV2ResponseUnmarshaller.Instance;

            return InvokeAsync<ListObjectsV2Response>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListParts

        internal virtual ListPartsResponse ListParts(ListPartsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;

            return Invoke<ListPartsResponse>(request, options);
        }


        /// <summary>
        /// Lists the parts that have been uploaded for a specific multipart upload.
        /// </summary>
        /// <param name="bucketName">A property of ListPartsRequest used to execute the ListParts service method.</param>
        /// <param name="key">A property of ListPartsRequest used to execute the ListParts service method.</param>
        /// <param name="uploadId">Upload ID identifying the multipart upload whose parts are being listed.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by S3.</returns>
        public virtual Task<ListPartsResponse> ListPartsAsync(string bucketName, string key, string uploadId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListPartsRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.UploadId = uploadId;
            return ListPartsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPartsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPartsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPartsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVersions

        internal virtual ListVersionsResponse ListVersions(ListVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return Invoke<ListVersionsResponse>(request, options);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListVersionsRequest used to execute the ListVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public virtual Task<ListVersionsResponse> ListVersionsAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            return ListVersionsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Returns metadata about all of the versions of objects in a bucket.
        /// </summary>
        /// <param name="bucketName">A property of ListVersionsRequest used to execute the ListVersions service method.</param>
        /// <param name="prefix">Limits the response to keys that begin with the specified prefix.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by S3.</returns>
        public virtual Task<ListVersionsResponse> ListVersionsAsync(string bucketName, string prefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListVersionsRequest();
            request.BucketName = bucketName;
            request.Prefix = prefix;
            return ListVersionsAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutACL

        internal virtual PutACLResponse PutACL(PutACLRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutACLResponseUnmarshaller.Instance;

            return Invoke<PutACLResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutACLResponse> PutACLAsync(PutACLRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutACLRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutACLResponseUnmarshaller.Instance;

            return InvokeAsync<PutACLResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucket

        internal virtual PutBucketResponse PutBucket(PutBucketRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketResponseUnmarshaller.Instance;

            return Invoke<PutBucketResponse>(request, options);
        }


        /// <summary>
        /// Creates a new bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketRequest used to execute the PutBucket service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by S3.</returns>
        public virtual Task<PutBucketResponse> PutBucketAsync(string bucketName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketRequest();
            request.BucketName = bucketName;
            return PutBucketAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketResponse> PutBucketAsync(PutBucketRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketAccelerateConfiguration

        internal virtual PutBucketAccelerateConfigurationResponse PutBucketAccelerateConfiguration(PutBucketAccelerateConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketAccelerateConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketAccelerateConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAccelerateConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketAccelerateConfigurationResponse> PutBucketAccelerateConfigurationAsync(PutBucketAccelerateConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAccelerateConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAccelerateConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketAccelerateConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketAnalyticsConfiguration

        internal virtual PutBucketAnalyticsConfigurationResponse PutBucketAnalyticsConfiguration(PutBucketAnalyticsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketAnalyticsConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketAnalyticsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketAnalyticsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketAnalyticsConfigurationResponse> PutBucketAnalyticsConfigurationAsync(PutBucketAnalyticsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketAnalyticsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketAnalyticsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketAnalyticsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketEncryption

        internal virtual PutBucketEncryptionResponse PutBucketEncryption(PutBucketEncryptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketEncryptionResponseUnmarshaller.Instance;

            return Invoke<PutBucketEncryptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketEncryption operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketEncryption operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketEncryptionResponse> PutBucketEncryptionAsync(PutBucketEncryptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketEncryptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketEncryptionResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketEncryptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketInventoryConfiguration

        internal virtual PutBucketInventoryConfigurationResponse PutBucketInventoryConfiguration(PutBucketInventoryConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketInventoryConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketInventoryConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketInventoryConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketInventoryConfigurationResponse> PutBucketInventoryConfigurationAsync(PutBucketInventoryConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketInventoryConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketInventoryConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketInventoryConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketLogging

        internal virtual PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketLoggingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketLoggingResponse> PutBucketLoggingAsync(PutBucketLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketLoggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketLoggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketLoggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketMetricsConfiguration

        internal virtual PutBucketMetricsConfigurationResponse PutBucketMetricsConfiguration(PutBucketMetricsConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutBucketMetricsConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketMetricsConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketMetricsConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketMetricsConfigurationResponse> PutBucketMetricsConfigurationAsync(PutBucketMetricsConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketMetricsConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketMetricsConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketMetricsConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketNotification

        internal virtual PutBucketNotificationResponse PutBucketNotification(PutBucketNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return Invoke<PutBucketNotificationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketNotificationResponse> PutBucketNotificationAsync(PutBucketNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketPolicy

        internal virtual PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return Invoke<PutBucketPolicyResponse>(request, options);
        }


        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public virtual Task<PutBucketPolicyResponse> PutBucketPolicyAsync(string bucketName, string policy, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            return PutBucketPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Replaces a policy on a bucket. If the bucket already has a policy, the one in this
        /// request completely replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="policy">The bucket policy as a JSON document.</param>
        /// <param name="contentMD5">A property of PutBucketPolicyRequest used to execute the PutBucketPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketPolicy service method, as returned by S3.</returns>
        public virtual Task<PutBucketPolicyResponse> PutBucketPolicyAsync(string bucketName, string policy, string contentMD5, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketPolicyRequest();
            request.BucketName = bucketName;
            request.Policy = policy;
            request.ContentMD5 = contentMD5;
            return PutBucketPolicyAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketPolicyResponse> PutBucketPolicyAsync(PutBucketPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketReplication

        internal virtual PutBucketReplicationResponse PutBucketReplication(PutBucketReplicationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;

            return Invoke<PutBucketReplicationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketReplication operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketReplication operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketReplicationResponse> PutBucketReplicationAsync(PutBucketReplicationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketReplicationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketReplicationResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketReplicationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketRequestPayment

        internal virtual PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return Invoke<PutBucketRequestPaymentResponse>(request, options);
        }


        /// <summary>
        /// Sets the request payment configuration for a bucket. By default, the bucket owner
        /// pays for downloads from the bucket. This configuration parameter enables the bucket
        /// owner (only) to specify that the person requesting the download will be charged for
        /// the download. Documentation on requester pays buckets can be found at http://docs.aws.amazon.com/AmazonS3/latest/dev/RequesterPaysBuckets.html
        /// </summary>
        /// <param name="bucketName">A property of PutBucketRequestPaymentRequest used to execute the PutBucketRequestPayment service method.</param>
        /// <param name="requestPaymentConfiguration">A property of PutBucketRequestPaymentRequest used to execute the PutBucketRequestPayment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketRequestPayment service method, as returned by S3.</returns>
        public virtual Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(string bucketName, RequestPaymentConfiguration requestPaymentConfiguration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketRequestPaymentRequest();
            request.BucketName = bucketName;
            request.RequestPaymentConfiguration = requestPaymentConfiguration;
            return PutBucketRequestPaymentAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketRequestPaymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketRequestPaymentResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketRequestPaymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketTagging

        internal virtual PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return Invoke<PutBucketTaggingResponse>(request, options);
        }


        /// <summary>
        /// Sets the tags for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// <param name="tagSet">A property of PutBucketTaggingRequest used to execute the PutBucketTagging service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketTagging service method, as returned by S3.</returns>
        public virtual Task<PutBucketTaggingResponse> PutBucketTaggingAsync(string bucketName, List<Tag> tagSet, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketTaggingRequest();
            request.BucketName = bucketName;
            request.TagSet = tagSet;
            return PutBucketTaggingAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketTaggingResponse> PutBucketTaggingAsync(PutBucketTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketVersioning

        internal virtual PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return Invoke<PutBucketVersioningResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketVersioningResponse> PutBucketVersioningAsync(PutBucketVersioningRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketVersioningRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketVersioningResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketVersioningResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutBucketWebsite

        internal virtual PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return Invoke<PutBucketWebsiteResponse>(request, options);
        }


        /// <summary>
        /// Set the website configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutBucketWebsiteRequest used to execute the PutBucketWebsite service method.</param>
        /// <param name="websiteConfiguration">A property of PutBucketWebsiteRequest used to execute the PutBucketWebsite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutBucketWebsite service method, as returned by S3.</returns>
        public virtual Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(string bucketName, WebsiteConfiguration websiteConfiguration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutBucketWebsiteRequest();
            request.BucketName = bucketName;
            request.WebsiteConfiguration = websiteConfiguration;
            return PutBucketWebsiteAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(PutBucketWebsiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutBucketWebsiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutBucketWebsiteResponseUnmarshaller.Instance;

            return InvokeAsync<PutBucketWebsiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutCORSConfiguration

        internal virtual PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutCORSConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Sets the CORS configuration for a bucket.
        /// </summary>
        /// <param name="bucketName">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// <param name="configuration">A property of PutCORSConfigurationRequest used to execute the PutCORSConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCORSConfiguration service method, as returned by S3.</returns>
        public virtual Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(string bucketName, CORSConfiguration configuration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutCORSConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutCORSConfigurationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(PutCORSConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCORSConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCORSConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutCORSConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLifecycleConfiguration

        internal virtual PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutLifecycleConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Sets lifecycle configuration for your bucket. If a lifecycle configuration exists,
        /// it replaces it.
        /// </summary>
        /// <param name="bucketName">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="configuration">A property of PutLifecycleConfigurationRequest used to execute the PutLifecycleConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLifecycleConfiguration service method, as returned by S3.</returns>
        public virtual Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(string bucketName, LifecycleConfiguration configuration, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PutLifecycleConfigurationRequest();
            request.BucketName = bucketName;
            request.Configuration = configuration;
            return PutLifecycleConfigurationAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLifecycleConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLifecycleConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutLifecycleConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObject

        internal virtual PutObjectResponse PutObject(PutObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return Invoke<PutObjectResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObjectLegalHold

        internal virtual PutObjectLegalHoldResponse PutObjectLegalHold(PutObjectLegalHoldRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLegalHoldResponseUnmarshaller.Instance;

            return Invoke<PutObjectLegalHoldResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectLegalHold operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectLegalHold operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutObjectLegalHoldResponse> PutObjectLegalHoldAsync(PutObjectLegalHoldRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLegalHoldRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLegalHoldResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectLegalHoldResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObjectLockConfiguration

        internal virtual PutObjectLockConfigurationResponse PutObjectLockConfiguration(PutObjectLockConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLockConfigurationResponseUnmarshaller.Instance;

            return Invoke<PutObjectLockConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectLockConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectLockConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutObjectLockConfigurationResponse> PutObjectLockConfigurationAsync(PutObjectLockConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectLockConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectLockConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectLockConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObjectRetention

        internal virtual PutObjectRetentionResponse PutObjectRetention(PutObjectRetentionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectRetentionResponseUnmarshaller.Instance;

            return Invoke<PutObjectRetentionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectRetention operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectRetention operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutObjectRetentionResponse> PutObjectRetentionAsync(PutObjectRetentionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRetentionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectRetentionResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectRetentionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObjectTagging

        internal virtual PutObjectTaggingResponse PutObjectTagging(PutObjectTaggingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectTaggingResponseUnmarshaller.Instance;

            return Invoke<PutObjectTaggingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutObjectTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutObjectTaggingResponse> PutObjectTaggingAsync(PutObjectTaggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectTaggingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectTaggingResponseUnmarshaller.Instance;

            return InvokeAsync<PutObjectTaggingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutPublicAccessBlock

        internal virtual PutPublicAccessBlockResponse PutPublicAccessBlock(PutPublicAccessBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPublicAccessBlockResponseUnmarshaller.Instance;

            return Invoke<PutPublicAccessBlockResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<PutPublicAccessBlockResponse> PutPublicAccessBlockAsync(PutPublicAccessBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutPublicAccessBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutPublicAccessBlockResponseUnmarshaller.Instance;

            return InvokeAsync<PutPublicAccessBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreObject

        internal virtual RestoreObjectResponse RestoreObject(RestoreObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return Invoke<RestoreObjectResponse>(request, options);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            return RestoreObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, int days, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.Days = days;
            return RestoreObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="versionId">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, string versionId, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            return RestoreObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Restores an archived copy of an object back into Amazon S3
        /// </summary>
        /// <param name="bucketName">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="key">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="versionId">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="days">A property of RestoreObjectRequest used to execute the RestoreObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreObject service method, as returned by S3.</returns>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(string bucketName, string key, string versionId, int days, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RestoreObjectRequest();
            request.BucketName = bucketName;
            request.Key = key;
            request.VersionId = versionId;
            request.Days = days;
            return RestoreObjectAsync(request, cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<RestoreObjectResponse> RestoreObjectAsync(RestoreObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreObjectResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SelectObjectContent

        internal virtual SelectObjectContentResponse SelectObjectContent(SelectObjectContentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SelectObjectContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SelectObjectContentResponseUnmarshaller.Instance;

            return Invoke<SelectObjectContentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SelectObjectContent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SelectObjectContent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<SelectObjectContentResponse> SelectObjectContentAsync(SelectObjectContentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SelectObjectContentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SelectObjectContentResponseUnmarshaller.Instance;

            return InvokeAsync<SelectObjectContentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UploadPart

        internal virtual UploadPartResponse UploadPart(UploadPartRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadPartResponseUnmarshaller.Instance;

            return Invoke<UploadPartResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public virtual Task<UploadPartResponse> UploadPartAsync(UploadPartRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UploadPartRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UploadPartResponseUnmarshaller.Instance;

            return InvokeAsync<UploadPartResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}