/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
        public static void DeleteS3BucketWithObjects(IAmazonS3 s3Client, string bucketName)
        {
            var result = BeginDeleteS3BucketWithObjects(s3Client, bucketName, null, null);
            EndDeleteS3BucketWithObjects(result);
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
        public static void DeleteS3BucketWithObjects(IAmazonS3 s3Client, string bucketName, S3DeleteBucketWithObjectsOptions deleteOptions)
        {
            var result = BeginDeleteS3BucketWithObjects(s3Client, bucketName, deleteOptions, null, null);
            EndDeleteS3BucketWithObjects(result);
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
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <returns>An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</returns>
        public static IAsyncCancelableResult BeginDeleteS3BucketWithObjects(IAmazonS3 s3Client,string bucketName, 
            AsyncCallback callback, object state)
        {
            return BeginDeleteS3BucketWithObjects(s3Client, bucketName, 
                new S3DeleteBucketWithObjectsOptions
                {
                    ContinueOnError = false,
                    QuietMode = true,
                },
                callback,
                state);
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
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <returns>An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</returns>
        public static IAsyncCancelableResult BeginDeleteS3BucketWithObjects(IAmazonS3 s3Client, string bucketName, 
             S3DeleteBucketWithObjectsOptions deleteOptions, AsyncCallback callback, object state)
        {
            return BeginDeleteS3BucketWithObjects(s3Client, bucketName, deleteOptions, null, callback, state);
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
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <returns>An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</returns>
        public static IAsyncCancelableResult BeginDeleteS3BucketWithObjects(IAmazonS3 s3Client, string bucketName, 
             S3DeleteBucketWithObjectsOptions deleteOptions, Action<S3DeleteBucketWithObjectsUpdate> updateCallback, AsyncCallback callback, object state)
        {
            var asyncResult = new AsyncCancelableResult(callback, state);

            var request = new S3DeleteBucketWithObjectsRequest
            {
                AsyncCancelableResult = asyncResult,
                BucketName = bucketName,
                DeleteOptions = deleteOptions,
                UpdateCallback = updateCallback,
                S3Client = s3Client
            };

            ThreadPool.QueueUserWorkItem(InvokeDeleteS3BucketWithObjects, request);
            return asyncResult;
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteS3BucketWithObjects operation.
        /// </summary>
        /// <param name="asyncCancelableResult">The IAsyncCancelableResult returned by the call to BeginDeleteS3BucketWithObjects.</param>
        public static void EndDeleteS3BucketWithObjects(IAsyncCancelableResult asyncCancelableResult)
        {
            var asyncResult = asyncCancelableResult as AsyncCancelableResult;

            try
            {
                if (!(asyncResult.IsCompleted || asyncResult.IsCanceled))
                {
                    asyncResult.AsyncWaitHandle.WaitOne();
                }

                if (asyncResult.LastException != null)
                {
                    AWSSDKUtils.PreserveStackTrace(asyncResult.LastException);
                    throw asyncResult.LastException;
                }
            }
            finally
            {
                asyncResult.Dispose();
            }
        }

        /// <summary>
        /// Invokes the DeleteS3BucketWithObjectsInternal method.
        /// </summary>
        /// <param name="state">The Request object that has all the data to complete the operation. </param>
        private static void InvokeDeleteS3BucketWithObjects(object state)
        {
            var request = (S3DeleteBucketWithObjectsRequest)state;

            try
            {
                DeleteS3BucketWithObjectsInternal(
                    request.S3Client,
                    request.BucketName,
                    request.DeleteOptions,
                    request.UpdateCallback,
                    request.AsyncCancelableResult
                    );
            }
            catch (Exception exception)
            {
                // Catch unhandled exception and store it on the async result.
                request.AsyncCancelableResult.LastException = exception;
                request.AsyncCancelableResult.SignalWaitHandleOnCompleted();
            }
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
        /// <param name="asyncCancelableResult">An IAsyncCancelableResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteS3BucketWithObjects. IAsyncCancelableResult can also 
        /// be used to cancel the operation while it's in progress.</param>
        private static void DeleteS3BucketWithObjectsInternal(IAmazonS3 s3Client, string bucketName, 
            S3DeleteBucketWithObjectsOptions deleteOptions, Action<S3DeleteBucketWithObjectsUpdate> updateCallback,
            AsyncCancelableResult asyncCancelableResult)
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

            ListVersionsResponse listVersionsResponse;

            // Iterate through the objects in the bucket and delete them.
            do
            {
                // Check if the operation has been canceled.
                if (asyncCancelableResult.IsCancelRequested)
                {
                    // Signal that the operation is canceled.
                    asyncCancelableResult.SignalWaitHandleOnCanceled();
                    return;
                }

                // List all the versions of all the objects in the bucket.
                listVersionsResponse = s3Client.ListVersions(listVersionsRequest);

                if (listVersionsResponse.Versions.Count == 0)
                {
                    // If the bucket has no objects break the loop.
                    break;
                }

                var keyVersionList = new List<KeyVersion>(listVersionsResponse.Versions.Count);
                for (int index = 0; index < listVersionsResponse.Versions.Count; index++)
                {
                    keyVersionList.Add(new KeyVersion
                    {
                        Key = listVersionsResponse.Versions[index].Key,
                        VersionId = listVersionsResponse.Versions[index].VersionId
                    });
                }

                try
                {
                    // Delete the current set of objects.
                    var deleteObjectsResponse =s3Client.DeleteObjects(new DeleteObjectsRequest
                    {
                        BucketName = bucketName,
                        Objects = keyVersionList,
                        Quiet = deleteOptions.QuietMode
                    });

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
                listVersionsRequest.KeyMarker = listVersionsResponse.NextKeyMarker;
                listVersionsRequest.VersionIdMarker = listVersionsResponse.NextVersionIdMarker;

            }
            // Continue listing objects and deleting them until the bucket is empty.
            while (listVersionsResponse.IsTruncated);

            const int maxRetries = 10;
            for (int retries = 1; retries <= maxRetries; retries++)
            {                
                try
                {
                    // Bucket is empty, delete the bucket.
                    s3Client.DeleteBucket(new DeleteBucketRequest
                    {
                        BucketName = bucketName
                    });
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

            // Signal that the operation is completed.
            asyncCancelableResult.SignalWaitHandleOnCompleted();
        }

        /// <summary>
        /// Invokes the callback which provides updated about the delete operation.
        /// </summary>
        /// <param name="updateCallback">The callback to be invoked.</param>
        /// <param name="update">The data being passed to the callback.</param>
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
