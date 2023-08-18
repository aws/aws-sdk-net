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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.BackupStorage.Model;

namespace Amazon.BackupStorage
{
    /// <summary>
    /// Interface for accessing BackupStorage
    ///
    /// The frontend service for Cryo Storage.
    /// </summary>
    public partial interface IAmazonBackupStorage : IAmazonService, IDisposable
    {
#if AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IBackupStoragePaginatorFactory Paginators { get; }
#endif
                
        #region  DeleteObject



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
        Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetChunk



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
        Task<GetChunkResponse> GetChunkAsync(GetChunkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetObjectMetadata



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
        Task<GetObjectMetadataResponse> GetObjectMetadataAsync(GetObjectMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListChunks



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
        Task<ListChunksResponse> ListChunksAsync(ListChunksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListObjects



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
        Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  NotifyObjectComplete



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
        Task<NotifyObjectCompleteResponse> NotifyObjectCompleteAsync(NotifyObjectCompleteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutChunk



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
        Task<PutChunkResponse> PutChunkAsync(PutChunkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutObject



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
        Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartObject



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
        Task<StartObjectResponse> StartObjectAsync(StartObjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}