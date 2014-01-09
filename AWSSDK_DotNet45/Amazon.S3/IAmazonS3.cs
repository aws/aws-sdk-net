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
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload service method on
        /// AmazonS3.</param>
		AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AbortMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AbortMultipartUploadResponse> AbortMultipartUploadAsync(AbortMultipartUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Completes a multipart upload by assembling previously uploaded parts.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by AmazonS3.</returns>
		CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CompleteMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CompleteMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CompleteMultipartUploadResponse> CompleteMultipartUploadAsync(CompleteMultipartUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a copy of an object that is already stored in Amazon S3.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by AmazonS3.</returns>
		CopyObjectResponse CopyObject(CopyObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CopyObject"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CopyObjectResponse> CopyObjectAsync(CopyObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Uploads a part by copying data from an existing object as data source.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyPart service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by AmazonS3.</returns>
		CopyPartResponse CopyPart(CopyPartRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CopyPart"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CopyPartResponse> CopyPartAsync(CopyPartRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the bucket. All objects (including all object versions and Delete Markers) in the bucket must be deleted before the bucket
        /// itself can be deleted.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket service method on AmazonS3.</param>
		DeleteBucketResponse DeleteBucket(DeleteBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucket"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteBucketResponse> DeleteBucketAsync(DeleteBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the policy from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy service method on
        /// AmazonS3.</param>
		DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteBucketPolicyResponse> DeleteBucketPolicyAsync(DeleteBucketPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the tags from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging service method on
        /// AmazonS3.</param>
		DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteBucketTaggingResponse> DeleteBucketTaggingAsync(DeleteBucketTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation removes the website configuration from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite service method on
        /// AmazonS3.</param>
		DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteBucketWebsiteResponse> DeleteBucketWebsiteAsync(DeleteBucketWebsiteRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the cors configuration information set for the bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration service method on
        /// AmazonS3.</param>
		DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteCORSConfigurationResponse> DeleteCORSConfigurationAsync(DeleteCORSConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Deletes the lifecycle configuration from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration service method on
        /// AmazonS3.</param>
		DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteLifecycleConfigurationResponse> DeleteLifecycleConfigurationAsync(DeleteLifecycleConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Removes the null version (if there is one) of an object and inserts a delete marker, which becomes the latest version of the object.
        /// If there isn''t a null version, Amazon S3 does not remove any objects.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by AmazonS3.</returns>
		DeleteObjectResponse DeleteObject(DeleteObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteObject"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteObjectResponse> DeleteObjectAsync(DeleteObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>This operation enables you to delete multiple objects from a bucket using a single HTTP request. You may specify up to 1000
        /// keys.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the DeleteObjects service method, as returned by AmazonS3.</returns>
		DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteObjects"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteObjectsResponse> DeleteObjectsAsync(DeleteObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the access control list (ACL) of an object.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetACL service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by AmazonS3.</returns>
		GetACLResponse GetACL(GetACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetACL"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetACLResponse> GetACLAsync(GetACLRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the region the bucket resides in.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by AmazonS3.</returns>
		GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketLocation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLocation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetBucketLocationResponse> GetBucketLocationAsync(GetBucketLocationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the logging status of a bucket and the permissions users have to view and modify that status. To use GET, you must be the
        /// bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by AmazonS3.</returns>
		GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketLogging"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetBucketLoggingResponse> GetBucketLoggingAsync(GetBucketLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Return the notification configuration of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by AmazonS3.</returns>
		GetBucketNotificationResponse GetBucketNotification(GetBucketNotificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketNotification operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketNotification"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetBucketNotificationResponse> GetBucketNotificationAsync(GetBucketNotificationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the policy of a specified bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by AmazonS3.</returns>
		GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetBucketPolicyResponse> GetBucketPolicyAsync(GetBucketPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the request payment configuration of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by AmazonS3.</returns>
		GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketRequestPayment operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketRequestPayment"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketRequestPayment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetBucketRequestPaymentResponse> GetBucketRequestPaymentAsync(GetBucketRequestPaymentRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the tag set associated with the bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by AmazonS3.</returns>
		GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetBucketTaggingResponse> GetBucketTaggingAsync(GetBucketTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the versioning state of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by AmazonS3.</returns>
		GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketVersioning"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketVersioning operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetBucketVersioningResponse> GetBucketVersioningAsync(GetBucketVersioningRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the website configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by AmazonS3.</returns>
		GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetBucketWebsiteResponse> GetBucketWebsiteAsync(GetBucketWebsiteRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the cors configuration for the bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by AmazonS3.</returns>
		GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetCORSConfigurationResponse> GetCORSConfigurationAsync(GetCORSConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns the lifecycle configuration information set on the bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by AmazonS3.</returns>
		GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetLifecycleConfigurationResponse> GetLifecycleConfigurationAsync(GetLifecycleConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Retrieves objects from Amazon S3.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by AmazonS3.</returns>
		GetObjectResponse GetObject(GetObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObject"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetObjectResponse> GetObjectAsync(GetObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// Returns information about a specified object.
        /// </summary>
        /// <remarks>
        /// Retrieves information about a specific object or object size, without actually fetching the object itself.
        /// This is useful if you're only interested in the object metadata, and don't want to waste bandwidth on the object data.
        /// The response is identical to the GetObject response, except that there is no response body.
        /// </remarks>
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata service method on AmazonS3.</param>
        /// <returns>The response from the HeadObject service method, as returned by AmazonS3.</returns>
		GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObjectMetadata"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectMetadata operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetObjectMetadataResponse> GetObjectMetadataAsync(GetObjectMetadataRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Return torrent files from a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by AmazonS3.</returns>
		GetObjectTorrentResponse GetObjectTorrent(GetObjectTorrentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTorrent operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObjectTorrent"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetObjectTorrent operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetObjectTorrentResponse> GetObjectTorrentAsync(GetObjectTorrentRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Initiates a multipart upload and returns an upload ID.</para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// After you initiate a multipart upload and upload one or more parts, you must either complete or abort
        /// the multipart upload in order to stop getting charged for storage of the uploaded parts. Once you
        /// complete or abort the multipart upload, Amazon S3 will release the stored parts and stop charging you
        /// for their storage.
        /// </para>
        /// </remarks>
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by AmazonS3.</returns>
		InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.InitiateMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the InitiateMultipartUpload operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<InitiateMultipartUploadResponse> InitiateMultipartUploadAsync(InitiateMultipartUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns a list of all buckets owned by the authenticated sender of the request.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by AmazonS3.</returns>
		ListBucketsResponse ListBuckets(ListBucketsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListBuckets"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListBuckets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListBucketsResponse> ListBucketsAsync(ListBucketsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns a list of all buckets owned by the authenticated sender of the request.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by AmazonS3.</returns>
		ListBucketsResponse ListBuckets();
 

        /// <summary>
        /// <para>This operation lists in-progress multipart uploads.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by AmazonS3.</returns>
		ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListMultipartUploads"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMultipartUploads operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListMultipartUploadsResponse> ListMultipartUploadsAsync(ListMultipartUploadsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns some or all (up to 1000) of the objects in a bucket. You can use the request parameters as selection criteria to return a
        /// subset of the objects in a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjects service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by AmazonS3.</returns>
		ListObjectsResponse ListObjects(ListObjectsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListObjects"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListObjects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListObjectsResponse> ListObjectsAsync(ListObjectsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Lists the parts that have been uploaded for a specific multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by AmazonS3.</returns>
		ListPartsResponse ListParts(ListPartsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListParts"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListParts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListPartsResponse> ListPartsAsync(ListPartsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Returns metadata about all of the versions of objects in a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions service method on
        /// AmazonS3.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by AmazonS3.</returns>
		ListVersionsResponse ListVersions(ListVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListVersions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ListVersionsResponse> ListVersionsAsync(ListVersionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>uses the acl subresource to set the access control list (ACL) permissions for an object that already exists in a bucket</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObjectAcl service method on AmazonS3.</param>
		PutACLResponse PutACL(PutACLRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutACL operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutACL"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutACL operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutACLResponse> PutACLAsync(PutACLRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Creates a new bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucket service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by AmazonS3.</returns>
		PutBucketResponse PutBucket(PutBucketRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucket"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucket operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutBucketResponse> PutBucketAsync(PutBucketRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Set the logging parameters for a bucket and to specify permissions for who can view and modify the logging parameters. To set the
        /// logging status of a bucket, you must be the bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging service method on
        /// AmazonS3.</param>
		PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLogging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketLogging"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutBucketLoggingResponse> PutBucketLoggingAsync(PutBucketLoggingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Enables notifications of specified events for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification service method on
        /// AmazonS3.</param>
		PutBucketNotificationResponse PutBucketNotification(PutBucketNotificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketNotification operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketNotification"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutBucketNotificationResponse> PutBucketNotificationAsync(PutBucketNotificationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Replaces a policy on a bucket. If the bucket already has a policy, the one in this request completely replaces it.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy service method on
        /// AmazonS3.</param>
		PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutBucketPolicyResponse> PutBucketPolicyAsync(PutBucketPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Sets the request payment configuration for a bucket. By default, the bucket owner pays for downloads from the bucket. This
        /// configuration parameter enables the bucket owner (only) to specify that the person requesting the download will be charged for the
        /// download.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment service method on
        /// AmazonS3.</param>
		PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketRequestPayment operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketRequestPayment"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketRequestPayment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutBucketRequestPaymentResponse> PutBucketRequestPaymentAsync(PutBucketRequestPaymentRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Sets the tags for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging service method on
        /// AmazonS3.</param>
		PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketTagging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutBucketTaggingResponse> PutBucketTaggingAsync(PutBucketTaggingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Puts the versioning state of an existing bucket. To set the versioning state, you must be the bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning service method on
        /// AmazonS3.</param>
		PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketVersioning"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketVersioning operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutBucketVersioningResponse> PutBucketVersioningAsync(PutBucketVersioningRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Set the website configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite service method on
        /// AmazonS3.</param>
		PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutBucketWebsite operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutBucketWebsiteResponse> PutBucketWebsiteAsync(PutBucketWebsiteRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Sets the cors configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration service method on AmazonS3.</param>
		PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCORSConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutCORSConfigurationResponse> PutCORSConfigurationAsync(PutCORSConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Sets lifecycle configuration for your bucket. If a lifecycle configuration exists, it replaces it.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration service method on
        /// AmazonS3.</param>
		PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLifecycleConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutLifecycleConfigurationResponse> PutLifecycleConfigurationAsync(PutLifecycleConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Adds an object to a bucket.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by AmazonS3.</returns>
		PutObjectResponse PutObject(PutObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutObject"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PutObjectResponse> PutObjectAsync(PutObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Restores an archived copy of an object back into Amazon S3</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject service method on AmazonS3.</param>
		RestoreObjectResponse RestoreObject(RestoreObjectRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.RestoreObject"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreObject operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RestoreObjectResponse> RestoreObjectAsync(RestoreObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para>Uploads a part in a multipart upload.</para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// After you initiate a multipart upload and upload one or more parts, you must either complete or abort
        /// the multipart upload in order to stop getting charged for storage of the uploaded parts. Once you
        /// complete or abort the multipart upload, Amazon S3 will release the stored parts and stop charging you
        /// for their storage.
        /// </para>
        /// </remarks>
        /// <param name="request">Container for the necessary parameters to execute the UploadPart service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the UploadPart service method, as returned by AmazonS3.</returns>
		UploadPartResponse UploadPart(UploadPartRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.UploadPart"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UploadPart operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UploadPartResponse> UploadPartAsync(UploadPartRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
