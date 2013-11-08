/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.S3.Model;

namespace Amazon.S3
{
    /// <summary>
    /// Interface for Amazon S3 Clients.
    /// For more information about Amazon S3, go to <see href="http://aws.amazon.com/s3" />
    /// </summary>
    /// <summary>
    /// Interface for accessing AmazonS3.
    /// 
    /// 
    /// </summary>
	public partial interface IAmazonS3 : IDisposable
    {
 
        /// <summary>
        /// <para>Aborts a multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="abortMultipartUploadRequest">Container for the necessary parameters to execute the AbortMultipartUpload service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest abortMultipartUploadRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Completes a multipart upload by assembling previously uploaded parts.</para>
        /// </summary>
        /// 
        /// <param name="completeMultipartUploadRequest">Container for the necessary parameters to execute the CompleteMultipartUpload service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest completeMultipartUploadRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Creates a copy of an object that is already stored in Amazon S3.</para>
        /// </summary>
        /// 
        /// <param name="copyObjectRequest">Container for the necessary parameters to execute the CopyObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest copyObjectRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Uploads a part by copying data from an existing object as data source.</para>
        /// </summary>
        /// 
        /// <param name="copyPartRequest">Container for the necessary parameters to execute the CopyPart service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CopyPartResponse> CopyPartAsync(CopyPartRequest copyPartRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes the bucket. All objects (including all object versions and Delete Markers) in the bucket must be deleted before the bucket
        /// itself can be deleted.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketRequest">Container for the necessary parameters to execute the DeleteBucket service method on AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest deleteBucketRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes the policy from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketPolicyRequest">Container for the necessary parameters to execute the DeleteBucketPolicy service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(DeleteBucketPolicyRequest deleteBucketPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes the tags from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketTaggingRequest">Container for the necessary parameters to execute the DeleteBucketTagging service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(DeleteBucketTaggingRequest deleteBucketTaggingRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation removes the website configuration from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketWebsiteRequest">Container for the necessary parameters to execute the DeleteBucketWebsite service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest deleteBucketWebsiteRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes the cors configuration information set for the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteCORSConfigurationRequest">Container for the necessary parameters to execute the DeleteCORSConfiguration service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(DeleteCORSConfigurationRequest deleteCORSConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Deletes the lifecycle configuration from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteLifecycleConfigurationRequest">Container for the necessary parameters to execute the DeleteLifecycleConfiguration service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(DeleteLifecycleConfigurationRequest deleteLifecycleConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Removes the null version (if there is one) of an object and inserts a delete marker, which becomes the latest version of the object.
        /// If there isn''t a null version, Amazon S3 does not remove any objects.</para>
        /// </summary>
        /// 
        /// <param name="deleteObjectRequest">Container for the necessary parameters to execute the DeleteObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest deleteObjectRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation enables you to delete multiple objects from a bucket using a single HTTP request. You may specify up to 1000
        /// keys.</para>
        /// </summary>
        /// 
        /// <param name="deleteObjectsRequest">Container for the necessary parameters to execute the DeleteObjects service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the DeleteObjects service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteObjectsResponse> DeleteObjectsAsync(DeleteObjectsRequest deleteObjectsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the access control list (ACL) of an object.</para>
        /// </summary>
        /// 
        /// <param name="getACLRequest">Container for the necessary parameters to execute the GetACL service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetACLResponse> GetACLAsync(GetACLRequest getACLRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the region the bucket resides in.</para>
        /// </summary>
        /// 
        /// <param name="getBucketLocationRequest">Container for the necessary parameters to execute the GetBucketLocation service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetBucketLocationResponse> GetBucketLocationAsync(GetBucketLocationRequest getBucketLocationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the logging status of a bucket and the permissions users have to view and modify that status. To use GET, you must be the
        /// bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="getBucketLoggingRequest">Container for the necessary parameters to execute the GetBucketLogging service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetBucketLoggingResponse> GetBucketLoggingAsync(GetBucketLoggingRequest getBucketLoggingRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Return the notification configuration of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketNotificationRequest">Container for the necessary parameters to execute the GetBucketNotification service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetBucketNotificationResponse> GetBucketNotificationAsync(GetBucketNotificationRequest getBucketNotificationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the policy of a specified bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketPolicyRequest">Container for the necessary parameters to execute the GetBucketPolicy service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetBucketPolicyResponse> GetBucketPolicyAsync(GetBucketPolicyRequest getBucketPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the request payment configuration of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketRequestPaymentRequest">Container for the necessary parameters to execute the GetBucketRequestPayment service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest getBucketRequestPaymentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the tag set associated with the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketTaggingRequest">Container for the necessary parameters to execute the GetBucketTagging service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetBucketTaggingResponse> GetBucketTaggingAsync(GetBucketTaggingRequest getBucketTaggingRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the versioning state of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketVersioningRequest">Container for the necessary parameters to execute the GetBucketVersioning service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetBucketVersioningResponse> GetBucketVersioningAsync(GetBucketVersioningRequest getBucketVersioningRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the website configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketWebsiteRequest">Container for the necessary parameters to execute the GetBucketWebsite service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(GetBucketWebsiteRequest getBucketWebsiteRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the cors configuration for the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getCORSConfigurationRequest">Container for the necessary parameters to execute the GetCORSConfiguration service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(GetCORSConfigurationRequest getCORSConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns the lifecycle configuration information set on the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getLifecycleConfigurationRequest">Container for the necessary parameters to execute the GetLifecycleConfiguration service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(GetLifecycleConfigurationRequest getLifecycleConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Retrieves objects from Amazon S3.</para>
        /// </summary>
        /// 
        /// <param name="getObjectRequest">Container for the necessary parameters to execute the GetObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetObjectResponse> GetObjectAsync(GetObjectRequest getObjectRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// Returns information about a specified object.
        /// </summary>
        /// <remarks>
        /// Retrieves information about a specific object or object size, without actually fetching the object itself.
        /// This is useful if you're only interested in the object metadata, and don't want to waste bandwidth on the object data.
        /// The response is identical to the GetObject response, except that there is no response body.
        /// </remarks>
        /// <param name="getObjectMetadataRequest">Container for the necessary parameters to execute the GetObjectMetadata service method on AmazonS3.</param>
        /// <returns>The response from the HeadObject service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetObjectMetadataResponse> GetObjectMetadataAsync(GetObjectMetadataRequest getObjectMetadataRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Return torrent files from a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getObjectTorrentRequest">Container for the necessary parameters to execute the GetObjectTorrent service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<GetObjectTorrentResponse> GetObjectTorrentAsync(GetObjectTorrentRequest getObjectTorrentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Initiates a multipart upload and returns an upload ID.</para>
        /// </summary>
        /// 
        /// <param name="initiateMultipartUploadRequest">Container for the necessary parameters to execute the InitiateMultipartUpload service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest initiateMultipartUploadRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns a list of all buckets owned by the authenticated sender of the request.</para>
        /// </summary>
        /// 
        /// <param name="listBucketsRequest">Container for the necessary parameters to execute the ListBuckets service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListBucketsResponse> ListBucketsAsync(ListBucketsRequest listBucketsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>This operation lists in-progress multipart uploads.</para>
        /// </summary>
        /// 
        /// <param name="listMultipartUploadsRequest">Container for the necessary parameters to execute the ListMultipartUploads service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest listMultipartUploadsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns some or all (up to 1000) of the objects in a bucket. You can use the request parameters as selection criteria to return a
        /// subset of the objects in a bucket.</para>
        /// </summary>
        /// 
        /// <param name="listObjectsRequest">Container for the necessary parameters to execute the ListObjects service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest listObjectsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Lists the parts that have been uploaded for a specific multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="listPartsRequest">Container for the necessary parameters to execute the ListParts service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListPartsResponse> ListPartsAsync(ListPartsRequest listPartsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns metadata about all of the versions of objects in a bucket.</para>
        /// </summary>
        /// 
        /// <param name="listVersionsRequest">Container for the necessary parameters to execute the ListVersions service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest listVersionsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>uses the acl subresource to set the access control list (ACL) permissions for an object that already exists in a bucket</para>
        /// </summary>
        /// 
        /// <param name="putACLRequest">Container for the necessary parameters to execute the PutObjectAcl service method on AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutACLResponse> PutACLAsync(PutACLRequest putACLRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Creates a new bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketRequest">Container for the necessary parameters to execute the PutBucket service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutBucketResponse> PutBucketAsync(PutBucketRequest putBucketRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Set the logging parameters for a bucket and to specify permissions for who can view and modify the logging parameters. To set the
        /// logging status of a bucket, you must be the bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="putBucketLoggingRequest">Container for the necessary parameters to execute the PutBucketLogging service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutBucketLoggingResponse> PutBucketLoggingAsync(PutBucketLoggingRequest putBucketLoggingRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Enables notifications of specified events for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketNotificationRequest">Container for the necessary parameters to execute the PutBucketNotification service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutBucketNotificationResponse> PutBucketNotificationAsync(PutBucketNotificationRequest putBucketNotificationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Replaces a policy on a bucket. If the bucket already has a policy, the one in this request completely replaces it.</para>
        /// </summary>
        /// 
        /// <param name="putBucketPolicyRequest">Container for the necessary parameters to execute the PutBucketPolicy service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutBucketPolicyResponse> PutBucketPolicyAsync(PutBucketPolicyRequest putBucketPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Sets the request payment configuration for a bucket. By default, the bucket owner pays for downloads from the bucket. This
        /// configuration parameter enables the bucket owner (only) to specify that the person requesting the download will be charged for the
        /// download.</para>
        /// </summary>
        /// 
        /// <param name="putBucketRequestPaymentRequest">Container for the necessary parameters to execute the PutBucketRequestPayment service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest putBucketRequestPaymentRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Sets the tags for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketTaggingRequest">Container for the necessary parameters to execute the PutBucketTagging service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutBucketTaggingResponse> PutBucketTaggingAsync(PutBucketTaggingRequest putBucketTaggingRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Puts the versioning state of an existing bucket. To set the versioning state, you must be the bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="putBucketVersioningRequest">Container for the necessary parameters to execute the PutBucketVersioning service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutBucketVersioningResponse> PutBucketVersioningAsync(PutBucketVersioningRequest putBucketVersioningRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Set the website configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketWebsiteRequest">Container for the necessary parameters to execute the PutBucketWebsite service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(PutBucketWebsiteRequest putBucketWebsiteRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Sets the cors configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putCORSConfigurationRequest">Container for the necessary parameters to execute the PutCORSConfiguration service method on AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(PutCORSConfigurationRequest putCORSConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Sets lifecycle configuration for your bucket. If a lifecycle configuration exists, it replaces it.</para>
        /// </summary>
        /// 
        /// <param name="putLifecycleConfigurationRequest">Container for the necessary parameters to execute the PutLifecycleConfiguration service method on
        /// AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest putLifecycleConfigurationRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Adds an object to a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putObjectRequest">Container for the necessary parameters to execute the PutObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<PutObjectResponse> PutObjectAsync(PutObjectRequest putObjectRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Restores an archived copy of an object back into Amazon S3</para>
        /// </summary>
        /// 
        /// <param name="restoreObjectRequest">Container for the necessary parameters to execute the RestoreObject service method on AmazonS3.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RestoreObjectResponse> RestoreObjectAsync(RestoreObjectRequest restoreObjectRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Uploads a part in a multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="uploadPartRequest">Container for the necessary parameters to execute the UploadPart service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the UploadPart service method, as returned by AmazonS3.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<UploadPartResponse> UploadPartAsync(UploadPartRequest uploadPartRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
