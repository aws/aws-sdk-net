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
        /// Determines whether an S3 bucket exists or not.
        /// This is done by:
        /// 1. Creating a PreSigned Url for the bucket. To work with Signature V4 only regions, as
        /// well as Signature V4-optional regions, we keep the expiry to within the maximum for V4 
        /// (which is one week).
        /// 2. Making a HEAD request to the Url
        /// </summary>
        /// <param name="bucketName">The name of the bucket to check.</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <returns></returns>
        public static bool DoesS3BucketExist(IAmazonS3 s3Client, string bucketName)
        {
            if (s3Client == null)
            {
                throw new ArgumentNullException("s3Client", "The s3Client cannot be null!");
            }

            if (String.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentNullException("bucketName", "The bucketName cannot be null or the empty string!");
            }

            var request = new GetPreSignedUrlRequest
            {
                BucketName = bucketName, 
                Expires = DateTime.Now.AddDays(1), 
                Verb = HttpVerb.HEAD, 
                Protocol = Protocol.HTTP
            };

            var url = s3Client.GetPreSignedURL(request);
            var uri = new Uri(url);

            var httpRequest = WebRequest.Create(uri) as HttpWebRequest;
            httpRequest.Method = "HEAD";
            var concreteClient = s3Client as AmazonS3Client;
            if (concreteClient != null)
            {
                concreteClient.ConfigureProxy(httpRequest);
            }

            try
            {
                using (var httpResponse = httpRequest.GetResponse() as HttpWebResponse)
                {
                    // If all went well, the bucket was found!
                    return true;
                }
            }
            catch (WebException we)
            {
                using (var errorResponse = we.Response as HttpWebResponse)
                {
                    if (errorResponse != null)
                    {
                        var code = errorResponse.StatusCode;
                        return code != HttpStatusCode.NotFound &&
                            code != HttpStatusCode.BadRequest;
                    }

                    // The Error Response is null which is indicative of either
                    // a bad request or some other problem
                    return false;
                }
            }
        }

        ///// <summary>
        ///// Sets the storage class for the S3 Object to the value
        ///// specified.
        ///// </summary>
        ///// <param name="s3Object">The S3 Object whose storage class needs changing</param>
        ///// <param name="sClass">The new Storage Class for the object</param>
        ///// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        ///// <seealso cref="T:Amazon.S3.S3StorageClass"/>
        //public static void SetObjectStorageClass(S3Object s3Object, S3StorageClass sClass, IAmazonS3 s3Client)
        //{
        //    SetObjectStorageClass(s3Object.BucketName, s3Object.Key, sClass, s3Client);
        //}

        /// <summary>
        /// Sets the storage class for the S3 Object to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object whose storage class needs changing</param>
        /// <param name="sClass">The new Storage Class for the object</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <seealso cref="T:Amazon.S3.S3StorageClass"/>
        public static void SetObjectStorageClass(IAmazonS3 s3Client, string bucketName, string key, S3StorageClass sClass)
        {
            SetObjectStorageClass(s3Client, bucketName, key, null, sClass);
        }

        /// <summary>
        /// Sets the storage class for the S3 Object's Version to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object whose storage class needs changing</param>
        /// <param name="version">The version of the S3 Object whose storage class needs changing</param>
        /// <param name="sClass">The new Storage Class for the object</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        /// <seealso cref="T:Amazon.S3.S3StorageClass"/>
        public static void SetObjectStorageClass(IAmazonS3 s3Client, string bucketName, string key, string version, S3StorageClass sClass)
        {
            CopyObjectRequest copyRequest;
            PutACLRequest putACLRequest;

            SetupForObjectModification(s3Client, bucketName, key, version, out copyRequest, out putACLRequest);

            copyRequest.StorageClass = sClass;
            CopyObjectResponse copyResponse = s3Client.CopyObject(copyRequest);

            if (!string.IsNullOrEmpty(copyResponse.SourceVersionId))
                putACLRequest.VersionId = copyResponse.SourceVersionId;

            s3Client.PutACL(putACLRequest);
        }

        ///// <summary>
        ///// Sets the server side encryption method for the S3 Object to the value
        ///// specified.
        ///// </summary>
        ///// <param name="s3Object">The S3 Object</param>
        ///// <param name="method">The server side encryption method</param>
        ///// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        //public static void SetServerSideEncryption(S3Object s3Object, ServerSideEncryptionMethod method, IAmazonS3 s3Client)
        //{
        //    SetServerSideEncryption(s3Object.BucketName, s3Object.Key, method, s3Client);
        //}

        /// <summary>
        /// Sets the server side encryption method for the S3 Object to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object</param>
        /// <param name="method">The server side encryption method</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetServerSideEncryption(IAmazonS3 s3Client, string bucketName, string key, ServerSideEncryptionMethod method)
        {
            SetServerSideEncryption(s3Client, bucketName, key, null, method);
        }

        ///// <summary>
        ///// Sets the server side encryption method for the S3 Object Version to the value
        ///// specified.
        ///// </summary>
        ///// <param name="s3ObjectVer">The S3 Object Version</param>
        ///// <param name="method">The server side encryption method</param>
        ///// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        //public static void SetServerSideEncryption(S3ObjectVersion s3ObjectVer, ServerSideEncryptionMethod method, IAmazonS3 s3Client)
        //{
        //    SetServerSideEncryption(s3ObjectVer.BucketName, s3ObjectVer.Key, s3ObjectVer.VersionId, method, s3Client);
        //}

        /// <summary>
        /// Sets the server side encryption method for the S3 Object's Version to the value
        /// specified.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object</param>
        /// <param name="version">The version of the S3 Object</param>
        /// <param name="method">The server side encryption method</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetServerSideEncryption(IAmazonS3 s3Client, string bucketName, string key, string version, ServerSideEncryptionMethod method)
        {
            CopyObjectRequest copyRequest;
            PutACLRequest putACLRequest;

            SetupForObjectModification(s3Client, bucketName, key, version, out copyRequest, out putACLRequest);

            copyRequest.ServerSideEncryptionMethod = method;
            CopyObjectResponse copyResponse = s3Client.CopyObject(copyRequest);

            if (!string.IsNullOrEmpty(copyResponse.SourceVersionId))
                putACLRequest.VersionId = copyResponse.SourceVersionId;

            s3Client.PutACL(putACLRequest);
        }

        ///// <summary>
        ///// Sets the redirect location for the S3 Object's when being accessed through the S3 website endpoint.
        ///// </summary>
        ///// <param name="s3Object">The S3 Object</param>
        ///// <param name="websiteRedirectLocation">The redirect location</param>
        ///// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        //public static void SetWebsiteRedirectLocation(S3Object s3Object, string websiteRedirectLocation, IAmazonS3 s3Client)
        //{
        //    SetWebsiteRedirectLocation(s3Object.BucketName, s3Object.Key, websiteRedirectLocation, s3Client);
        //}

        /// <summary>
        /// Sets the redirect location for the S3 Object's when being accessed through the S3 website endpoint.
        /// </summary>
        /// <param name="bucketName">The name of the bucket in which the key is stored</param>
        /// <param name="key">The key of the S3 Object</param>
        /// <param name="websiteRedirectLocation">The redirect location</param>
        /// <param name="s3Client">The Amazon S3 Client to use for S3 specific operations.</param>
        public static void SetWebsiteRedirectLocation(IAmazonS3 s3Client, string bucketName, string key, string websiteRedirectLocation)
        {
            CopyObjectRequest copyRequest;
            PutACLRequest putACLRequest;

            SetupForObjectModification(s3Client, bucketName, key, null, out copyRequest, out putACLRequest);

            copyRequest.WebsiteRedirectLocation = websiteRedirectLocation;
            CopyObjectResponse copyResponse = s3Client.CopyObject(copyRequest);

            if (!string.IsNullOrEmpty(copyResponse.SourceVersionId))
                putACLRequest.VersionId = copyResponse.SourceVersionId;

            s3Client.PutACL(putACLRequest);
        }

        /// <summary>
        /// Sets up the request needed to make an exact copy of the object leaving the parent method
        /// the ability to change just the attribute being requested to change.
        /// </summary>
        /// <param name="bucketName"></param>
        /// <param name="key"></param>
        /// <param name="version"></param>
        /// <param name="s3Client"></param>
        /// <param name="copyRequest"></param>
        /// <param name="putACLRequest"></param>
        static void SetupForObjectModification(IAmazonS3 s3Client, string bucketName, string key, string version, 
            out CopyObjectRequest copyRequest, out PutACLRequest putACLRequest)
        {
            // Get the existing ACL of the object
            GetACLRequest getACLRequest = new GetACLRequest();
            getACLRequest.BucketName = bucketName;
            getACLRequest.Key = key;
            if (version != null)
                getACLRequest.VersionId = version;
            GetACLResponse getACLResponse = s3Client.GetACL(getACLRequest);


            // Set the object's original ACL back onto it because a COPY
            // operation resets the ACL on the destination object.
            putACLRequest = new PutACLRequest();
            putACLRequest.BucketName = bucketName;
            putACLRequest.Key = key;
            putACLRequest.AccessControlList = getACLResponse.AccessControlList;


            ListObjectsResponse listObjectResponse = s3Client.ListObjects(new ListObjectsRequest
            {
                BucketName = bucketName,
                Prefix = key,
                MaxKeys = 1
            });

            if (listObjectResponse.S3Objects.Count != 1)
            {
                throw new InvalidOperationException("No object exists with this bucket name and key.");
            }

            GetObjectMetadataRequest getMetaRequest = new GetObjectMetadataRequest()
            {
                BucketName = bucketName,
                Key = key
            };
            GetObjectMetadataResponse getMetaResponse = s3Client.GetObjectMetadata(getMetaRequest);

            // Set the storage class on the object
            copyRequest = new CopyObjectRequest();
            copyRequest.SourceBucket = copyRequest.DestinationBucket = bucketName;
            copyRequest.SourceKey = copyRequest.DestinationKey = key;
            copyRequest.StorageClass = listObjectResponse.S3Objects[0].StorageClass == "STANDARD" ? S3StorageClass.Standard : S3StorageClass.ReducedRedundancy;
            if (version != null)
                copyRequest.SourceVersionId = version;

            copyRequest.WebsiteRedirectLocation = getMetaResponse.WebsiteRedirectLocation;
            copyRequest.ServerSideEncryptionMethod = getMetaResponse.ServerSideEncryptionMethod;
        }

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

        /// <summary>
        /// Converts the string representing a storage class that would come back from a ListObjects request
        /// to the S3StorageClass enumeration.
        /// </summary>
        /// <param name="value">Amazon S3 string values for storage class</param>
        /// <returns>The converted S3StorageClass enumeration</returns>
        public static S3StorageClass ConvertToS3StorageClass(string value)
        {
            switch (value)
            {
                case "REDUCED_REDUNDANCY":
                    return S3StorageClass.ReducedRedundancy;
                case "GLACIER":
                    return S3StorageClass.Glacier;
                default:
                    return S3StorageClass.Standard;
            }
        }

        /// <summary>
        /// Upload data to Amazon S3 using HTTP POST.
        /// </summary>
        /// <remarks>
        /// For more information, <see href="http://docs.aws.amazon.com/AmazonS3/latest/dev/UsingHTTPPOST.html"/>
        /// </remarks>
        /// <param name="request">Request object which describes the data to POST</param>
        /// <exception cref="S3PostUploadException">Thrown if the service returns an error</exception>
        public static S3PostUploadResponse PostUpload(S3PostUploadRequest request)
        {
            string url;
            string subdomain = request.Region.Equals(RegionEndpoint.USEast1) ? "s3" : "s3-" + request.Region.SystemName;

            if (request.Bucket.IndexOf('.') > -1)
                url = string.Format(CultureInfo.InvariantCulture, "https://{0}.amazonaws.com/{1}/", subdomain, request.Bucket);
            else
                url = string.Format(CultureInfo.InvariantCulture, "https://{0}.{1}.amazonaws.com", request.Bucket, subdomain);
            Uri uri = new Uri(url);

            HttpWebRequest webRequest = WebRequest.Create(uri) as HttpWebRequest;

            var boundary = Convert.ToBase64String(Guid.NewGuid().ToByteArray()).Replace('=', 'z');

            webRequest.ContentType = string.Format(CultureInfo.InvariantCulture, "multipart/form-data; boundary={0}", boundary);
            webRequest.Method = "POST";

            using (var reqStream = webRequest.GetRequestStream())
            {
                request.WriteFormData(boundary, reqStream);

                byte[] boundaryBytes = Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "--{0}\r\nContent-Disposition: form-data; name=\"file\"\r\n\r\n", boundary));

                reqStream.Write(boundaryBytes, 0, boundaryBytes.Length);

                using (var inputStream = null == request.Path ? request.InputStream : File.OpenRead(request.Path))
                {
                    byte[] buf = new byte[1024];
                    int bytesRead;
                    while ((bytesRead = inputStream.Read(buf, 0, 1024)) > 0)
                    {
                        reqStream.Write(buf, 0, bytesRead);
                    }
                }

                byte[] endBoundaryBytes = Encoding.UTF8.GetBytes(string.Format(CultureInfo.InvariantCulture, "\r\n--{0}--", boundary));

                reqStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            }

            HttpWebResponse response = null;
            try
            {
                response = webRequest.GetResponse() as HttpWebResponse;
            }
            catch (WebException ex)
            {
                throw S3PostUploadException.FromResponse((HttpWebResponse)ex.Response);
            }

            return S3PostUploadResponse.FromWebResponse(response);
        }
    }
}
