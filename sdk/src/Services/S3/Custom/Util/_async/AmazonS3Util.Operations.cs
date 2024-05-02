/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.S3.Model;
using Amazon.Util;
using System.Threading.Tasks;


namespace Amazon.S3.Util
{
    /// <summary>
    /// Provides utilities used by the Amazon S3 client implementation.
    /// These utilities might be useful to consumers of the Amazon S3
    /// library.
    /// </summary>
    public static partial class AmazonS3Util
    {
        /// <summary>
        /// Deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static Task DeleteS3BucketWithObjectsAsync(IAmazonS3 s3Client, string bucketName)
        {
            var cancelSource = new CancellationTokenSource();
            return DeleteS3BucketWithObjectsAsync(s3Client, bucketName, cancelSource.Token);
        }

        /// <summary>
        /// Deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="deleteOptions">Options to control the behavior of the delete operation.</param>
        public static  Task DeleteS3BucketWithObjectsAsync(IAmazonS3 s3Client, string bucketName, S3DeleteBucketWithObjectsOptions deleteOptions)
        {
            var cancelSource = new CancellationTokenSource();
            return  DeleteS3BucketWithObjectsAsync(s3Client, bucketName, deleteOptions, cancelSource.Token);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteS3BucketWithObjects operation. 
        /// DeleteS3BucketWithObjects deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="token">token to check if the operation has been request to cancel.</param>
        /// <returns>An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</returns>
        public static Task DeleteS3BucketWithObjectsAsync(IAmazonS3 s3Client, string bucketName,
            CancellationToken token)
        {
            return DeleteS3BucketWithObjectsAsync(s3Client, bucketName,
                new S3DeleteBucketWithObjectsOptions
                {
                    ContinueOnError = false,
                    QuietMode = true,
                },
                token);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteS3BucketWithObjects operation. 
        /// DeleteS3BucketWithObjects deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="deleteOptions">Options to control the behavior of the delete operation.</param>
        /// <param name="token">token to check if the operation has been request to cancel.</param>
        /// <returns>An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</returns>
        public static Task DeleteS3BucketWithObjectsAsync(IAmazonS3 s3Client, string bucketName,
             S3DeleteBucketWithObjectsOptions deleteOptions, CancellationToken token)
        {
            return DeleteS3BucketWithObjectsAsync(s3Client, bucketName, deleteOptions, null, token);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteS3BucketWithObjects operation. 
        /// DeleteS3BucketWithObjects deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. This method deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="deleteOptions">>Options to control the behavior of the delete operation.</param>
        /// <param name="updateCallback">An callback that is invoked to send updates while delete operation is in progress.</param>
        /// <param name="token">token to check if the operation has been request to cancel.</param>
        /// <returns>An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</returns>
        public static  Task DeleteS3BucketWithObjectsAsync(IAmazonS3 s3Client, string bucketName,
             S3DeleteBucketWithObjectsOptions deleteOptions, Action<S3DeleteBucketWithObjectsUpdate> updateCallback, CancellationToken token)
        {
            var request = new S3DeleteBucketWithObjectsRequest
            {
                BucketName = bucketName,
                DeleteOptions = deleteOptions,
                UpdateCallback = updateCallback,
                S3Client = s3Client
            };
            return InvokeDeleteS3BucketWithObjects(request, token);
        }

        /// <summary>
        /// Invokes the DeleteS3BucketWithObjectsInternal method.
        /// </summary>
        /// <param name="state">The Request object that has all the data to complete the operation. </param>
        /// <param name="token">token to request the operation to be cancelled.</param>
        private static  Task InvokeDeleteS3BucketWithObjects(object state,CancellationToken token)
        {
            var request = (S3DeleteBucketWithObjectsRequest)state;
                return DeleteS3BucketWithObjectsInternalAsync(
                    request.S3Client,
                    request.BucketName,
                    request.DeleteOptions,
                    request.UpdateCallback,
                    token
                    );
        }

        /// <summary>
        /// Deletes an S3 bucket which contains objects.
        /// An S3 bucket which contains objects cannot be deleted until all the objects 
        /// in it are deleted. The function deletes all the objects in the specified 
        /// bucket and then deletes the bucket itself.
        /// </summary>
        /// <param name="bucketName">The bucket to be deleted.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <param name="deleteOptions">Options to control the behavior of the delete operation.</param>
        /// <param name="updateCallback">The callback which is used to send updates about the delete operation.</param>
        /// <param name="token">token to check if the operation has been request to cancel.</param>
        private static async Task DeleteS3BucketWithObjectsInternalAsync(IAmazonS3 s3Client, string bucketName,
            S3DeleteBucketWithObjectsOptions deleteOptions, Action<S3DeleteBucketWithObjectsUpdate> updateCallback,
            CancellationToken token)
        {
            // Validations.
            if (s3Client == null)
            {
                throw new ArgumentNullException("s3Client", "The s3Client cannot be null!");
            }

            if (string.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentNullException("bucketName", "The bucketName cannot be null or empty string!");
            }

            var listVersionsRequest = new ListVersionsRequest
            {
                BucketName = bucketName
            };
            var listObjectsV2Request = new ListObjectsV2Request
            {
                BucketName = bucketName
            };

            ListVersionsResponse listVersionsResponse = null;
            ListObjectsV2Response listObjectsV2Response = null;
            bool isTruncated = false;
            // Iterate through the objects in the bucket and delete them.
            do
            {
                // Check if the operation has been canceled.
                if (token.IsCancellationRequested)
                {
                    // Signal that the operation is canceled.
                    return;
                }

                List<KeyVersion> keyVersionList;
                // List all the versions of all the objects in the bucket.
                try
                {
                    listVersionsResponse = await s3Client.ListVersionsAsync(listVersionsRequest, token).ConfigureAwait(false);
                    if (listVersionsResponse.Versions == null || listVersionsResponse.Versions.Count == 0)
                    {
                        // If the bucket has no objects break the loop.
                        break;
                    }

                    keyVersionList = new List<KeyVersion>(listVersionsResponse.Versions.Count);
                    for (int index = 0; index < listVersionsResponse.Versions.Count; index++)
                    {
                        keyVersionList.Add(new KeyVersion
                        {
                            Key = listVersionsResponse.Versions[index].Key,
                            VersionId = listVersionsResponse.Versions[index].VersionId
                        });
                    }
                }
                catch (AmazonS3Exception ex)
                {
                    if (ex.StatusCode != HttpStatusCode.NotImplemented)
                        throw;
                    listObjectsV2Response = await s3Client.ListObjectsV2Async(listObjectsV2Request).ConfigureAwait(false);
                    if (listObjectsV2Response.S3Objects == null || listObjectsV2Response.S3Objects.Count == 0)
                    {
                        // If the bucket has no objects break the loop.
                        break;
                    }
                    keyVersionList = new List<KeyVersion>(listObjectsV2Response.S3Objects.Count);
                    for (int index = 0; index < listObjectsV2Response.S3Objects.Count; index++)
                    {
                        keyVersionList.Add(new KeyVersion
                        {
                            Key = listObjectsV2Response.S3Objects[index].Key,
                        });
                    }
                }
                try
                {
                    // Delete the current set of objects.
                    var deleteObjectsResponse = await s3Client.DeleteObjectsAsync(new DeleteObjectsRequest
                    {
                        BucketName = bucketName,
                        Objects = keyVersionList,
                        Quiet = deleteOptions.QuietMode
                    }, token).ConfigureAwait(false);

                    if (!deleteOptions.QuietMode)
                    {
                        // If quiet mode is not set, update the client with list of deleted objects.
                        InvokeS3DeleteBucketWithObjectsUpdateCallback(
                                        updateCallback,
                                        new S3DeleteBucketWithObjectsUpdate
                                        {
                                            DeletedObjects = deleteObjectsResponse.DeletedObjects
                                        }
                                    );
                    }
                }
                catch (DeleteObjectsException deleteObjectsException)
                {
                    if (deleteOptions.ContinueOnError)
                    {
                        // Continue the delete operation if an error was encountered.
                        // Update the client with the list of objects that were deleted and the 
                        // list of objects on which the delete failed.
                        InvokeS3DeleteBucketWithObjectsUpdateCallback(
                                updateCallback,
                                new S3DeleteBucketWithObjectsUpdate
                                {
                                    DeletedObjects = deleteObjectsException.Response.DeletedObjects,
                                    DeleteErrors = deleteObjectsException.Response.DeleteErrors
                                }
                            );
                    }
                    else
                    {
                        // Re-throw the exception if an error was encountered.
                        throw;
                    }
                }
                // Set the markers to get next set of objects from the bucket.
                if (listVersionsResponse != null)
                {
                    listVersionsRequest.KeyMarker = listVersionsResponse.NextKeyMarker;
                    listVersionsRequest.VersionIdMarker = listVersionsResponse.NextVersionIdMarker;
                    isTruncated = listVersionsResponse.IsTruncated.GetValueOrDefault();
                }
                if(listObjectsV2Response != null)
                {
                    listObjectsV2Request.ContinuationToken = listObjectsV2Response.NextContinuationToken;
                    isTruncated = listObjectsV2Response.IsTruncated.GetValueOrDefault();
                }

            }
            // Continue listing objects and deleting them until the bucket is empty.
            while (isTruncated);

            const int maxRetries = 10;
            for (int retries = 1; retries <= maxRetries; retries++)
            {
                try
                {
                    // Bucket is empty, delete the bucket.
                    await s3Client.DeleteBucketAsync(new DeleteBucketRequest
                    {
                        BucketName = bucketName
                    }, token).ConfigureAwait(false);
                    break;
                }
                catch (AmazonS3Exception e)
                {
                    if (e.StatusCode != HttpStatusCode.Conflict || retries == maxRetries)
                        throw;
                    else
                        DefaultRetryPolicy.WaitBeforeRetry(retries, 5000);
                }
            }
        }

        /// <summary>
        /// Invokes the callback which provides updated about the delete operation.
        /// </summary>
        /// <param name="updateCallback">The callback to be invoked.</param>
        /// <param name="update">The data being passed to the callback.</param>
        /// 8
        private static void InvokeS3DeleteBucketWithObjectsUpdateCallback(
            Action<S3DeleteBucketWithObjectsUpdate> updateCallback, S3DeleteBucketWithObjectsUpdate update)
        {
            if (updateCallback != null)
            {
                updateCallback(update);
            }
        }
    }
}
