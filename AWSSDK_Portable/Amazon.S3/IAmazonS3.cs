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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.S3.Model;

namespace Amazon.S3
{
    /// <summary>
    /// Interface for accessing S3
    ///
    /// 
    /// </summary>
    public partial interface IAmazonS3 : IDisposable
    {
                
        #region  AbortMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CompleteMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyObject

        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CopyPart

        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CopyPartResponse> CopyPartAsync(CopyPartRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBucket

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBucketPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(DeleteBucketPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(DeleteBucketTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteBucketWebsite

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteCORSConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(DeleteCORSConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteLifecycleConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(DeleteLifecycleConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteObject

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteObjects

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteObjectsResponse> DeleteObjectsAsync(DeleteObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetACL

        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetACLResponse> GetACLAsync(GetACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBucketLocation

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBucketLocationResponse> GetBucketLocationAsync(GetBucketLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBucketLogging

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBucketLoggingResponse> GetBucketLoggingAsync(GetBucketLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBucketNotification

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBucketNotificationResponse> GetBucketNotificationAsync(GetBucketNotificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBucketPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBucketPolicyResponse> GetBucketPolicyAsync(GetBucketPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBucketRequestPayment

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBucketTaggingResponse> GetBucketTaggingAsync(GetBucketTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBucketVersioning

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBucketVersioningResponse> GetBucketVersioningAsync(GetBucketVersioningRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetBucketWebsite

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(GetBucketWebsiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetCORSConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(GetCORSConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetLifecycleConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(GetLifecycleConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetObject

        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetObjectMetadata

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetObjectMetadataResponse> GetObjectMetadataAsync(GetObjectMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetObjectTorrent

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTorrent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetObjectTorrentResponse> GetObjectTorrentAsync(GetObjectTorrentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  InitiateMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListBuckets

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListBucketsResponse> ListBucketsAsync(ListBucketsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListMultipartUploads

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListObjects

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListParts

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListVersions

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutACL

        /// <summary>
        /// Initiates the asynchronous execution of the PutACL operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutACLResponse> PutACLAsync(PutACLRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBucket

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutBucketResponse> PutBucketAsync(PutBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBucketLogging

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutBucketLoggingResponse> PutBucketLoggingAsync(PutBucketLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBucketNotification

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutBucketNotificationResponse> PutBucketNotificationAsync(PutBucketNotificationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBucketPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutBucketPolicyResponse> PutBucketPolicyAsync(PutBucketPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBucketRequestPayment

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketRequestPayment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutBucketTaggingResponse> PutBucketTaggingAsync(PutBucketTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBucketVersioning

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutBucketVersioningResponse> PutBucketVersioningAsync(PutBucketVersioningRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutBucketWebsite

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(PutBucketWebsiteRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutCORSConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(PutCORSConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutLifecycleConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  PutObject

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RestoreObject

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RestoreObjectResponse> RestoreObjectAsync(RestoreObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UploadPart

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UploadPartResponse> UploadPartAsync(UploadPartRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}