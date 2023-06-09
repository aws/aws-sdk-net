/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the backupstorage-2018-04-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.BackupStorage.Model;
using Amazon.BackupStorage.Model.Internal.MarshallTransformations;
using Amazon.BackupStorage.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.BackupStorage
{
    /// <summary>
    /// Implementation for accessing BackupStorage
    ///
    /// The frontend service for Cryo Storage.
    /// </summary>
    public partial class AmazonBackupStorageClient : AmazonServiceClient, IAmazonBackupStorage
    {
        private static IServiceMetadata serviceMetadata = new AmazonBackupStorageMetadata();
        private IBackupStoragePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IBackupStoragePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new BackupStoragePaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonBackupStorageClient with the credentials loaded from the application's
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
        public AmazonBackupStorageClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBackupStorageConfig()) { }

        /// <summary>
        /// Constructs AmazonBackupStorageClient with the credentials loaded from the application's
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
        public AmazonBackupStorageClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonBackupStorageConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonBackupStorageClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonBackupStorageClient Configuration Object</param>
        public AmazonBackupStorageClient(AmazonBackupStorageConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}

        /// <summary>
        /// Constructs AmazonBackupStorageClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonBackupStorageClient(AWSCredentials credentials)
            : this(credentials, new AmazonBackupStorageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupStorageClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupStorageClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonBackupStorageConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupStorageClient with AWS Credentials and an
        /// AmazonBackupStorageClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonBackupStorageClient Configuration Object</param>
        public AmazonBackupStorageClient(AWSCredentials credentials, AmazonBackupStorageConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBackupStorageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonBackupStorageClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBackupStorageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupStorageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupStorageClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonBackupStorageConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupStorageClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBackupStorageClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonBackupStorageClient Configuration Object</param>
        public AmazonBackupStorageClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonBackupStorageConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonBackupStorageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonBackupStorageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBackupStorageConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonBackupStorageClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonBackupStorageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonBackupStorageConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonBackupStorageClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonBackupStorageClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonBackupStorageClient Configuration Object</param>
        public AmazonBackupStorageClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonBackupStorageConfig clientConfig)
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
            return new AWS4Signer();
        }    

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonBackupStorageEndpointResolver());
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


        #region  DeleteObject


        /// <summary>
        /// Delete Object from the incremental base Backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual DeleteObjectResponse DeleteObject(DeleteObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;

            return Invoke<DeleteObjectResponse>(request, options);
        }


        /// <summary>
        /// Delete Object from the incremental base Backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/DeleteObject">REST API Reference for DeleteObject Operation</seealso>
        public virtual Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteObjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetChunk


        /// <summary>
        /// Gets the specified object's chunk.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChunk service method.</param>
        /// 
        /// <returns>The response from the GetChunk service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/GetChunk">REST API Reference for GetChunk Operation</seealso>
        public virtual GetChunkResponse GetChunk(GetChunkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChunkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChunkResponseUnmarshaller.Instance;

            return Invoke<GetChunkResponse>(request, options);
        }


        /// <summary>
        /// Gets the specified object's chunk.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetChunk service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetChunk service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/GetChunk">REST API Reference for GetChunk Operation</seealso>
        public virtual Task<GetChunkResponse> GetChunkAsync(GetChunkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetChunkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetChunkResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetChunkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetObjectMetadata


        /// <summary>
        /// Get metadata associated with an Object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata service method.</param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/GetObjectMetadata">REST API Reference for GetObjectMetadata Operation</seealso>
        public virtual GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;

            return Invoke<GetObjectMetadataResponse>(request, options);
        }


        /// <summary>
        /// Get metadata associated with an Object.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetObjectMetadata service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/GetObjectMetadata">REST API Reference for GetObjectMetadata Operation</seealso>
        public virtual Task<GetObjectMetadataResponse> GetObjectMetadataAsync(GetObjectMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetObjectMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetObjectMetadataResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetObjectMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListChunks


        /// <summary>
        /// List chunks in a given Object
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChunks service method.</param>
        /// 
        /// <returns>The response from the ListChunks service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/ListChunks">REST API Reference for ListChunks Operation</seealso>
        public virtual ListChunksResponse ListChunks(ListChunksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChunksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChunksResponseUnmarshaller.Instance;

            return Invoke<ListChunksResponse>(request, options);
        }


        /// <summary>
        /// List chunks in a given Object
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListChunks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListChunks service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/ListChunks">REST API Reference for ListChunks Operation</seealso>
        public virtual Task<ListChunksResponse> ListChunksAsync(ListChunksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListChunksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListChunksResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListChunksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListObjects


        /// <summary>
        /// List all Objects in a given Backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjects service method.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/ListObjects">REST API Reference for ListObjects Operation</seealso>
        public virtual ListObjectsResponse ListObjects(ListObjectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsResponseUnmarshaller.Instance;

            return Invoke<ListObjectsResponse>(request, options);
        }


        /// <summary>
        /// List all Objects in a given Backup.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListObjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/ListObjects">REST API Reference for ListObjects Operation</seealso>
        public virtual Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListObjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListObjectsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListObjectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NotifyObjectComplete


        /// <summary>
        /// Complete upload
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyObjectComplete service method.</param>
        /// 
        /// <returns>The response from the NotifyObjectComplete service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.NotReadableInputStreamException">
        /// Retryalble exception. Indicated issues while reading an input stream due to the networking
        /// issues or connection drop on the client side.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/NotifyObjectComplete">REST API Reference for NotifyObjectComplete Operation</seealso>
        public virtual NotifyObjectCompleteResponse NotifyObjectComplete(NotifyObjectCompleteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyObjectCompleteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyObjectCompleteResponseUnmarshaller.Instance;

            return Invoke<NotifyObjectCompleteResponse>(request, options);
        }


        /// <summary>
        /// Complete upload
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyObjectComplete service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the NotifyObjectComplete service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.NotReadableInputStreamException">
        /// Retryalble exception. Indicated issues while reading an input stream due to the networking
        /// issues or connection drop on the client side.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/NotifyObjectComplete">REST API Reference for NotifyObjectComplete Operation</seealso>
        public virtual Task<NotifyObjectCompleteResponse> NotifyObjectCompleteAsync(NotifyObjectCompleteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyObjectCompleteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyObjectCompleteResponseUnmarshaller.Instance;
            
            return InvokeAsync<NotifyObjectCompleteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutChunk


        /// <summary>
        /// Upload chunk.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChunk service method.</param>
        /// 
        /// <returns>The response from the PutChunk service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.NotReadableInputStreamException">
        /// Retryalble exception. Indicated issues while reading an input stream due to the networking
        /// issues or connection drop on the client side.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/PutChunk">REST API Reference for PutChunk Operation</seealso>
        public virtual PutChunkResponse PutChunk(PutChunkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutChunkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutChunkResponseUnmarshaller.Instance;

            return Invoke<PutChunkResponse>(request, options);
        }


        /// <summary>
        /// Upload chunk.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutChunk service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutChunk service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.NotReadableInputStreamException">
        /// Retryalble exception. Indicated issues while reading an input stream due to the networking
        /// issues or connection drop on the client side.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/PutChunk">REST API Reference for PutChunk Operation</seealso>
        public virtual Task<PutChunkResponse> PutChunkAsync(PutChunkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutChunkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutChunkResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutChunkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutObject


        /// <summary>
        /// Upload object that can store object metadata String and data blob in single API call
        /// using inline chunk field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method.</param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.NotReadableInputStreamException">
        /// Retryalble exception. Indicated issues while reading an input stream due to the networking
        /// issues or connection drop on the client side.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/PutObject">REST API Reference for PutObject Operation</seealso>
        public virtual PutObjectResponse PutObject(PutObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;

            return Invoke<PutObjectResponse>(request, options);
        }


        /// <summary>
        /// Upload object that can store object metadata String and data blob in single API call
        /// using inline chunk field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.KMSInvalidKeyUsageException">
        /// Non-retryable exception. Indicates the KMS key usage is incorrect. See exception message
        /// for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.NotReadableInputStreamException">
        /// Retryalble exception. Indicated issues while reading an input stream due to the networking
        /// issues or connection drop on the client side.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/PutObject">REST API Reference for PutObject Operation</seealso>
        public virtual Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutObjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<PutObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartObject


        /// <summary>
        /// Start upload containing one or many chunks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartObject service method.</param>
        /// 
        /// <returns>The response from the StartObject service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.DataAlreadyExistsException">
        /// Non-retryable exception. Attempted to create already existing object or chunk. This
        /// message contains a checksum of already presented data.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/StartObject">REST API Reference for StartObject Operation</seealso>
        public virtual StartObjectResponse StartObject(StartObjectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartObjectResponseUnmarshaller.Instance;

            return Invoke<StartObjectResponse>(request, options);
        }


        /// <summary>
        /// Start upload containing one or many chunks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartObject service method, as returned by BackupStorage.</returns>
        /// <exception cref="Amazon.BackupStorage.Model.AccessDeniedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.DataAlreadyExistsException">
        /// Non-retryable exception. Attempted to create already existing object or chunk. This
        /// message contains a checksum of already presented data.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.IllegalArgumentException">
        /// Non-retryable exception, indicates client error (wrong argument passed to API). See
        /// exception message for details.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ResourceNotFoundException">
        /// Non-retryable exception. Attempted to make an operation on non-existing or expired
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.RetryableException">
        /// Retryable exception. In general indicates internal failure that can be fixed by retry.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceInternalException">
        /// Deprecated. To be removed from the model.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ServiceUnavailableException">
        /// Retryable exception, indicates internal server error.
        /// </exception>
        /// <exception cref="Amazon.BackupStorage.Model.ThrottlingException">
        /// Increased rate over throttling limits. Can be retried with exponential backoff.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/backupstorage-2018-04-10/StartObject">REST API Reference for StartObject Operation</seealso>
        public virtual Task<StartObjectResponse> StartObjectAsync(StartObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartObjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartObjectResponseUnmarshaller.Instance;
            
            return InvokeAsync<StartObjectResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}