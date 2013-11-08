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

using Amazon.S3;
using Amazon.S3.Model;

namespace Amazon.S3
{
    /// <summary>
    /// Interface for accessing AmazonS3.
    ///  
    ///  
    /// </summary>
    public partial interface IAmazonS3 : IDisposable
    {

        #region GetCORSConfiguration

        /// <summary>
        /// <para>Returns the cors configuration for the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getCORSConfigurationRequest">Container for the necessary parameters to execute the GetCORSConfiguration service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetCORSConfiguration service method, as returned by AmazonS3.</returns>
        /// 
        GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest getCORSConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="getCORSConfigurationRequest">Container for the necessary parameters to execute the GetCORSConfiguration operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCORSConfiguration
        ///         operation.</returns>
        IAsyncResult BeginGetCORSConfiguration(GetCORSConfigurationRequest getCORSConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCORSConfiguration.</param>
        /// 
        /// <returns>Returns a GetCORSConfigurationResult from AmazonS3.</returns>
        GetCORSConfigurationResponse EndGetCORSConfiguration(IAsyncResult asyncResult);
        
        #endregion

        #region GetObjectTorrent

        /// <summary>
        /// <para>Return torrent files from a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getObjectTorrentRequest">Container for the necessary parameters to execute the GetObjectTorrent service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetObjectTorrent service method, as returned by AmazonS3.</returns>
        /// 
        GetObjectTorrentResponse GetObjectTorrent(GetObjectTorrentRequest getObjectTorrentRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectTorrent operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObjectTorrent"/>
        /// </summary>
        /// 
        /// <param name="getObjectTorrentRequest">Container for the necessary parameters to execute the GetObjectTorrent operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectTorrent
        ///         operation.</returns>
        IAsyncResult BeginGetObjectTorrent(GetObjectTorrentRequest getObjectTorrentRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetObjectTorrent operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObjectTorrent"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectTorrent.</param>
        /// 
        /// <returns>Returns a GetObjectTorrentResult from AmazonS3.</returns>
        GetObjectTorrentResponse EndGetObjectTorrent(IAsyncResult asyncResult);
        
        #endregion

        #region PutObject

        /// <summary>
        /// <para>Adds an object to a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putObjectRequest">Container for the necessary parameters to execute the PutObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the PutObject service method, as returned by AmazonS3.</returns>
        /// 
        PutObjectResponse PutObject(PutObjectRequest putObjectRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutObject"/>
        /// </summary>
        /// 
        /// <param name="putObjectRequest">Container for the necessary parameters to execute the PutObject operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutObject
        ///         operation.</returns>
        IAsyncResult BeginPutObject(PutObjectRequest putObjectRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutObject"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutObject.</param>
        /// 
        /// <returns>Returns a PutObjectResult from AmazonS3.</returns>
        PutObjectResponse EndPutObject(IAsyncResult asyncResult);
        
        #endregion


        #region PutLifecycleConfiguration

        /// <summary>
        /// <para>Sets lifecycle configuration for your bucket. If a lifecycle configuration exists, it replaces it.</para>
        /// </summary>
        /// 
        /// <param name="putLifecycleConfigurationRequest">Container for the necessary parameters to execute the PutLifecycleConfiguration service method on
        ///          AmazonS3.</param>
        /// 
        PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest putLifecycleConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="putLifecycleConfigurationRequest">Container for the necessary parameters to execute the PutLifecycleConfiguration operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutLifecycleConfiguration(PutLifecycleConfigurationRequest putLifecycleConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLifecycleConfiguration.</param>
        PutLifecycleConfigurationResponse EndPutLifecycleConfiguration(IAsyncResult asyncResult);
        
        #endregion


        #region PutCORSConfiguration

        /// <summary>
        /// <para>Sets the cors configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putCORSConfigurationRequest">Container for the necessary parameters to execute the PutCORSConfiguration service method on AmazonS3.</param>
        /// 
        PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest putCORSConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="putCORSConfigurationRequest">Container for the necessary parameters to execute the PutCORSConfiguration operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutCORSConfiguration(PutCORSConfigurationRequest putCORSConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCORSConfiguration.</param>
        PutCORSConfigurationResponse EndPutCORSConfiguration(IAsyncResult asyncResult);
        
        #endregion

        #region PutBucketTagging

        /// <summary>
        /// <para>Sets the tags for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketTaggingRequest">Container for the necessary parameters to execute the PutBucketTagging service method on
        ///          AmazonS3.</param>
        /// 
        PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest putBucketTaggingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="putBucketTaggingRequest">Container for the necessary parameters to execute the PutBucketTagging operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutBucketTagging(PutBucketTaggingRequest putBucketTaggingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketTagging.</param>
        PutBucketTaggingResponse EndPutBucketTagging(IAsyncResult asyncResult);
        
        #endregion

        #region PutBucket

        /// <summary>
        /// <para>Creates a new bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketRequest">Container for the necessary parameters to execute the PutBucket service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the PutBucket service method, as returned by AmazonS3.</returns>
        /// 
        PutBucketResponse PutBucket(PutBucketRequest putBucketRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucket"/>
        /// </summary>
        /// 
        /// <param name="putBucketRequest">Container for the necessary parameters to execute the PutBucket operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutBucket
        ///         operation.</returns>
        IAsyncResult BeginPutBucket(PutBucketRequest putBucketRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucket operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucket"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucket.</param>
        /// 
        /// <returns>Returns a PutBucketResult from AmazonS3.</returns>
        PutBucketResponse EndPutBucket(IAsyncResult asyncResult);
        
        #endregion

        #region ListVersions

        /// <summary>
        /// <para>Returns metadata about all of the versions of objects in a bucket.</para>
        /// </summary>
        /// 
        /// <param name="listVersionsRequest">Container for the necessary parameters to execute the ListVersions service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the ListVersions service method, as returned by AmazonS3.</returns>
        /// 
        ListVersionsResponse ListVersions(ListVersionsRequest listVersionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListVersions"/>
        /// </summary>
        /// 
        /// <param name="listVersionsRequest">Container for the necessary parameters to execute the ListVersions operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListVersions operation.</returns>
        IAsyncResult BeginListVersions(ListVersionsRequest listVersionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListVersions operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListVersions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// 
        /// <returns>Returns a ListVersionsResult from AmazonS3.</returns>
        ListVersionsResponse EndListVersions(IAsyncResult asyncResult);
        
        #endregion

        #region DeleteObjects

        /// <summary>
        /// <para>This operation enables you to delete multiple objects from a bucket using a single HTTP request. You may specify up to 1000
        /// keys.</para>
        /// </summary>
        /// 
        /// <param name="deleteObjectsRequest">Container for the necessary parameters to execute the DeleteObjects service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the DeleteObjects service method, as returned by AmazonS3.</returns>
        /// 
        DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest deleteObjectsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteObjects"/>
        /// </summary>
        /// 
        /// <param name="deleteObjectsRequest">Container for the necessary parameters to execute the DeleteObjects operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObjects
        ///         operation.</returns>
        IAsyncResult BeginDeleteObjects(DeleteObjectsRequest deleteObjectsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteObjects operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteObjects"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObjects.</param>
        /// 
        /// <returns>Returns a DeleteObjectsResult from AmazonS3.</returns>
        DeleteObjectsResponse EndDeleteObjects(IAsyncResult asyncResult);
        
        #endregion

        #region GetBucketTagging

        /// <summary>
        /// <para>Returns the tag set associated with the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketTaggingRequest">Container for the necessary parameters to execute the GetBucketTagging service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketTagging service method, as returned by AmazonS3.</returns>
        /// 
        GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest getBucketTaggingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="getBucketTaggingRequest">Container for the necessary parameters to execute the GetBucketTagging operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketTagging
        ///         operation.</returns>
        IAsyncResult BeginGetBucketTagging(GetBucketTaggingRequest getBucketTaggingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketTagging.</param>
        /// 
        /// <returns>Returns a GetBucketTaggingResult from AmazonS3.</returns>
        GetBucketTaggingResponse EndGetBucketTagging(IAsyncResult asyncResult);
        
        #endregion

        #region GetBucketLocation

        /// <summary>
        /// <para>Returns the region the bucket resides in.</para>
        /// </summary>
        /// 
        /// <param name="getBucketLocationRequest">Container for the necessary parameters to execute the GetBucketLocation service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketLocation service method, as returned by AmazonS3.</returns>
        /// 
        GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest getBucketLocationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketLocation"/>
        /// </summary>
        /// 
        /// <param name="getBucketLocationRequest">Container for the necessary parameters to execute the GetBucketLocation operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketLocation
        ///         operation.</returns>
        IAsyncResult BeginGetBucketLocation(GetBucketLocationRequest getBucketLocationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketLocation operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketLocation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLocation.</param>
        /// 
        /// <returns>Returns a GetBucketLocationResult from AmazonS3.</returns>
        GetBucketLocationResponse EndGetBucketLocation(IAsyncResult asyncResult);
        
        #endregion

        #region PutBucketPolicy

        /// <summary>
        /// <para>Replaces a policy on a bucket. If the bucket already has a policy, the one in this request completely replaces it.</para>
        /// </summary>
        /// 
        /// <param name="putBucketPolicyRequest">Container for the necessary parameters to execute the PutBucketPolicy service method on
        ///          AmazonS3.</param>
        /// 
        PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest putBucketPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="putBucketPolicyRequest">Container for the necessary parameters to execute the PutBucketPolicy operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutBucketPolicy(PutBucketPolicyRequest putBucketPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketPolicy.</param>
        PutBucketPolicyResponse EndPutBucketPolicy(IAsyncResult asyncResult);
        
        #endregion



        #region PutBucketLogging

        /// <summary>
        /// <para>Set the logging parameters for a bucket and to specify permissions for who can view and modify the logging parameters. To set the
        /// logging status of a bucket, you must be the bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="putBucketLoggingRequest">Container for the necessary parameters to execute the PutBucketLogging service method on
        ///          AmazonS3.</param>
        /// 
        PutBucketLoggingResponse PutBucketLogging(PutBucketLoggingRequest putBucketLoggingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketLogging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketLogging"/>
        /// </summary>
        /// 
        /// <param name="putBucketLoggingRequest">Container for the necessary parameters to execute the PutBucketLogging operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutBucketLogging(PutBucketLoggingRequest putBucketLoggingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketLogging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketLogging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketLogging.</param>
        PutBucketLoggingResponse EndPutBucketLogging(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PutBucketNotification

        /// <summary>
        /// <para>Enables notifications of specified events for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketNotificationRequest">Container for the necessary parameters to execute the PutBucketNotification service method on
        ///          AmazonS3.</param>
        /// 
        PutBucketNotificationResponse PutBucketNotification(PutBucketNotificationRequest putBucketNotificationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketNotification operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketNotification"/>
        /// </summary>
        /// 
        /// <param name="putBucketNotificationRequest">Container for the necessary parameters to execute the PutBucketNotification operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutBucketNotification(PutBucketNotificationRequest putBucketNotificationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketNotification operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketNotification"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketNotification.</param>
        PutBucketNotificationResponse EndPutBucketNotification(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteBucket

        /// <summary>
        /// <para>Deletes the bucket. All objects (including all object versions and Delete Markers) in the bucket must be deleted before the bucket
        /// itself can be deleted.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketRequest">Container for the necessary parameters to execute the DeleteBucket service method on AmazonS3.</param>
        /// 
        DeleteBucketResponse DeleteBucket(DeleteBucketRequest deleteBucketRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucket"/>
        /// </summary>
        /// 
        /// <param name="deleteBucketRequest">Container for the necessary parameters to execute the DeleteBucket operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteBucket(DeleteBucketRequest deleteBucketRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucket operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucket"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucket.</param>
        DeleteBucketResponse EndDeleteBucket(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListMultipartUploads

        /// <summary>
        /// <para>This operation lists in-progress multipart uploads.</para>
        /// </summary>
        /// 
        /// <param name="listMultipartUploadsRequest">Container for the necessary parameters to execute the ListMultipartUploads service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the ListMultipartUploads service method, as returned by AmazonS3.</returns>
        /// 
        ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest listMultipartUploadsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListMultipartUploads"/>
        /// </summary>
        /// 
        /// <param name="listMultipartUploadsRequest">Container for the necessary parameters to execute the ListMultipartUploads operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndListMultipartUploads operation.</returns>
        IAsyncResult BeginListMultipartUploads(ListMultipartUploadsRequest listMultipartUploadsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListMultipartUploads operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListMultipartUploads"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultipartUploads.</param>
        /// 
        /// <returns>Returns a ListMultipartUploadsResult from AmazonS3.</returns>
        ListMultipartUploadsResponse EndListMultipartUploads(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteBucketTagging

        /// <summary>
        /// <para>Deletes the tags from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketTaggingRequest">Container for the necessary parameters to execute the DeleteBucketTagging service method on
        ///          AmazonS3.</param>
        /// 
        DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest deleteBucketTaggingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="deleteBucketTaggingRequest">Container for the necessary parameters to execute the DeleteBucketTagging operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteBucketTagging(DeleteBucketTaggingRequest deleteBucketTaggingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketTagging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketTagging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketTagging.</param>
        DeleteBucketTaggingResponse EndDeleteBucketTagging(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CompleteMultipartUpload

        /// <summary>
        /// <para>Completes a multipart upload by assembling previously uploaded parts.</para>
        /// </summary>
        /// 
        /// <param name="completeMultipartUploadRequest">Container for the necessary parameters to execute the CompleteMultipartUpload service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the CompleteMultipartUpload service method, as returned by AmazonS3.</returns>
        /// 
        CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest completeMultipartUploadRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CompleteMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="completeMultipartUploadRequest">Container for the necessary parameters to execute the CompleteMultipartUpload operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCompleteMultipartUpload operation.</returns>
        IAsyncResult BeginCompleteMultipartUpload(CompleteMultipartUploadRequest completeMultipartUploadRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CompleteMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CompleteMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteMultipartUpload.</param>
        /// 
        /// <returns>Returns a CompleteMultipartUploadResult from AmazonS3.</returns>
        CompleteMultipartUploadResponse EndCompleteMultipartUpload(IAsyncResult asyncResult);
        
        #endregion



        #region GetLifecycleConfiguration

        /// <summary>
        /// <para>Returns the lifecycle configuration information set on the bucket.</para>
        /// </summary>
        /// 
        /// <param name="getLifecycleConfigurationRequest">Container for the necessary parameters to execute the GetLifecycleConfiguration service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetLifecycleConfiguration service method, as returned by AmazonS3.</returns>
        /// 
        GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest getLifecycleConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="getLifecycleConfigurationRequest">Container for the necessary parameters to execute the GetLifecycleConfiguration operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetLifecycleConfiguration operation.</returns>
        IAsyncResult BeginGetLifecycleConfiguration(GetLifecycleConfigurationRequest getLifecycleConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to GetLifecycleConfiguration.</param>
        /// 
        /// <returns>Returns a GetLifecycleConfigurationResult from AmazonS3.</returns>
        GetLifecycleConfigurationResponse EndGetLifecycleConfiguration(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetACL

        /// <summary>
        /// <para>Returns the access control list (ACL) of an object or bucket.</para>
        /// </summary>
        /// 
        /// <param name="getACLRequest">Container for the necessary parameters to execute the GetACL service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetACL service method, as returned by AmazonS3.</returns>
        /// 
        GetACLResponse GetACL(GetACLRequest getACLRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetACL"/>
        /// </summary>
        /// 
        /// <param name="getAclRequest">Container for the necessary parameters to execute the GetACL operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectAcl
        ///         operation.</returns>
        IAsyncResult BeginGetACL(GetACLRequest getAclRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetACL operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetACL"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetACL.</param>
        /// 
        /// <returns>Returns a GetACLResult from AmazonS3.</returns>
        GetACLResponse EndGetACL(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CopyObject

        /// <summary>
        /// <para>Creates a copy of an object that is already stored in Amazon S3.</para>
        /// </summary>
        /// 
        /// <param name="copyObjectRequest">Container for the necessary parameters to execute the CopyObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the CopyObject service method, as returned by AmazonS3.</returns>
        /// 
        CopyObjectResponse CopyObject(CopyObjectRequest copyObjectRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CopyObject"/>
        /// </summary>
        /// 
        /// <param name="copyObjectRequest">Container for the necessary parameters to execute the CopyObject operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyObject
        ///         operation.</returns>
        IAsyncResult BeginCopyObject(CopyObjectRequest copyObjectRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CopyObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CopyObject"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyObject.</param>
        /// 
        /// <returns>Returns a CopyObjectResult from AmazonS3.</returns>
        CopyObjectResponse EndCopyObject(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteBucketPolicy

        /// <summary>
        /// <para>Deletes the policy from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketPolicyRequest">Container for the necessary parameters to execute the DeleteBucketPolicy service method on
        ///          AmazonS3.</param>
        /// 
        DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest deleteBucketPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="deleteBucketPolicyRequest">Container for the necessary parameters to execute the DeleteBucketPolicy operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteBucketPolicy(DeleteBucketPolicyRequest deleteBucketPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketPolicy.</param>
        DeleteBucketPolicyResponse EndDeleteBucketPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetObject

        /// <summary>
        /// <para>Retrieves objects from Amazon S3.</para>
        /// </summary>
        /// 
        /// <param name="getObjectRequest">Container for the necessary parameters to execute the GetObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the GetObject service method, as returned by AmazonS3.</returns>
        /// 
        GetObjectResponse GetObject(GetObjectRequest getObjectRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObject"/>
        /// </summary>
        /// 
        /// <param name="getObjectRequest">Container for the necessary parameters to execute the GetObject operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObject
        ///         operation.</returns>
        IAsyncResult BeginGetObject(GetObjectRequest getObjectRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObject"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObject.</param>
        /// 
        /// <returns>Returns a GetObjectResult from AmazonS3.</returns>
        GetObjectResponse EndGetObject(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AbortMultipartUpload

        /// <summary>
        /// <para>Aborts a multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="abortMultipartUploadRequest">Container for the necessary parameters to execute the AbortMultipartUpload service method on
        ///          AmazonS3.</param>
        /// 
        AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest abortMultipartUploadRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="abortMultipartUploadRequest">Container for the necessary parameters to execute the AbortMultipartUpload operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAbortMultipartUpload(AbortMultipartUploadRequest abortMultipartUploadRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AbortMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortMultipartUpload.</param>
        AbortMultipartUploadResponse EndAbortMultipartUpload(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UploadPart

        /// <summary>
        /// <para>Uploads a part in a multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="uploadPartRequest">Container for the necessary parameters to execute the UploadPart service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the UploadPart service method, as returned by AmazonS3.</returns>
        /// 
        UploadPartResponse UploadPart(UploadPartRequest uploadPartRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.UploadPart"/>
        /// </summary>
        /// 
        /// <param name="uploadPartRequest">Container for the necessary parameters to execute the UploadPart operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUploadPart
        ///         operation.</returns>
        IAsyncResult BeginUploadPart(UploadPartRequest uploadPartRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UploadPart operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.UploadPart"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadPart.</param>
        /// 
        /// <returns>Returns a UploadPartResult from AmazonS3.</returns>
        UploadPartResponse EndUploadPart(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RestoreObject

        /// <summary>
        /// <para>Restores an archived copy of an object back into Amazon S3</para>
        /// </summary>
        /// 
        /// <param name="restoreObjectRequest">Container for the necessary parameters to execute the RestoreObject service method on AmazonS3.</param>
        /// 
        RestoreObjectResponse RestoreObject(RestoreObjectRequest restoreObjectRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.RestoreObject"/>
        /// </summary>
        /// 
        /// <param name="restoreObjectRequest">Container for the necessary parameters to execute the RestoreObject operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginRestoreObject(RestoreObjectRequest restoreObjectRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RestoreObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.RestoreObject"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreObject.</param>
        RestoreObjectResponse EndRestoreObject(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetBucketPolicy

        /// <summary>
        /// <para>Returns the policy of a specified bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketPolicyRequest">Container for the necessary parameters to execute the GetBucketPolicy service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketPolicy service method, as returned by AmazonS3.</returns>
        /// 
        GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest getBucketPolicyRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="getBucketPolicyRequest">Container for the necessary parameters to execute the GetBucketPolicy operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetBucketPolicy(GetBucketPolicyRequest getBucketPolicyRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketPolicy operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketPolicy"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketPolicy.</param>
        /// 
        /// <returns>Returns a GetBucketPolicyResult from AmazonS3.</returns>
        GetBucketPolicyResponse EndGetBucketPolicy(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetBucketLogging

        /// <summary>
        /// <para>Returns the logging status of a bucket and the permissions users have to view and modify that status. To use GET, you must be the
        /// bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="getBucketLoggingRequest">Container for the necessary parameters to execute the GetBucketLogging service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketLogging service method, as returned by AmazonS3.</returns>
        /// 
        GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest getBucketLoggingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketLogging"/>
        /// </summary>
        /// 
        /// <param name="getBucketLoggingRequest">Container for the necessary parameters to execute the GetBucketLogging operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketLogging
        ///         operation.</returns>
        IAsyncResult BeginGetBucketLogging(GetBucketLoggingRequest getBucketLoggingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketLogging operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketLogging"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLogging.</param>
        /// 
        /// <returns>Returns a GetBucketLoggingResult from AmazonS3.</returns>
        GetBucketLoggingResponse EndGetBucketLogging(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteObject

        /// <summary>
        /// <para>Removes the null version (if there is one) of an object and inserts a delete marker, which becomes the latest version of the object.
        /// If there isn''t a null version, Amazon S3 does not remove any objects.</para>
        /// </summary>
        /// 
        /// <param name="deleteObjectRequest">Container for the necessary parameters to execute the DeleteObject service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the DeleteObject service method, as returned by AmazonS3.</returns>
        /// 
        DeleteObjectResponse DeleteObject(DeleteObjectRequest deleteObjectRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteObject"/>
        /// </summary>
        /// 
        /// <param name="deleteObjectRequest">Container for the necessary parameters to execute the DeleteObject operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteObject
        ///         operation.</returns>
        IAsyncResult BeginDeleteObject(DeleteObjectRequest deleteObjectRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteObject operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteObject"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObject.</param>
        /// 
        /// <returns>Returns a DeleteObjectResult from AmazonS3.</returns>
        DeleteObjectResponse EndDeleteObject(IAsyncResult asyncResult);
        
        #endregion



        #region InitiateMultipartUpload

        /// <summary>
        /// <para>Initiates a multipart upload and returns an upload ID.</para>
        /// </summary>
        /// 
        /// <param name="initiateMultipartUploadRequest">Container for the necessary parameters to execute the InitiateMultipartUpload service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the InitiateMultipartUpload service method, as returned by AmazonS3.</returns>
        /// 
        InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest initiateMultipartUploadRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.InitiateMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="initiateMultipartUploadRequest">Container for the necessary parameters to execute the InitiateMultipartUpload operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndInitiateMultipartUpload operation.</returns>
        IAsyncResult BeginInitiateMultipartUpload(InitiateMultipartUploadRequest initiateMultipartUploadRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the InitiateMultipartUpload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.InitiateMultipartUpload"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateMultipartUpload.</param>
        /// 
        /// <returns>Returns a InitiateMultipartUploadResult from AmazonS3.</returns>
        InitiateMultipartUploadResponse EndInitiateMultipartUpload(IAsyncResult asyncResult);
        
        #endregion



        #region DeleteCORSConfiguration

        /// <summary>
        /// <para>Deletes the cors configuration information set for the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteCORSConfigurationRequest">Container for the necessary parameters to execute the DeleteCORSConfiguration service method on
        ///          AmazonS3.</param>
        /// 
        DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest deleteCORSConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteCORSConfigurationRequest">Container for the necessary parameters to execute the DeleteCORSConfiguration operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteCORSConfiguration(DeleteCORSConfigurationRequest deleteCORSConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCORSConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteCORSConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCORSConfiguration.</param>
        DeleteCORSConfigurationResponse EndDeleteCORSConfiguration(IAsyncResult asyncResult);
        
        #endregion



        #region PutBucketVersioning

        /// <summary>
        /// <para>Sets the versioning state of an existing bucket. To set the versioning state, you must be the bucket owner.</para>
        /// </summary>
        /// 
        /// <param name="putBucketVersioningRequest">Container for the necessary parameters to execute the PutBucketVersioning service method on
        ///          AmazonS3.</param>
        /// 
        PutBucketVersioningResponse PutBucketVersioning(PutBucketVersioningRequest putBucketVersioningRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketVersioning operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketVersioning"/>
        /// </summary>
        /// 
        /// <param name="putBucketVersioningRequest">Container for the necessary parameters to execute the PutBucketVersioning operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutBucketVersioning(PutBucketVersioningRequest putBucketVersioningRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketVersioning operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketVersioning"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketVersioning.</param>
        PutBucketVersioningResponse EndPutBucketVersioning(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CopyPart

        /// <summary>
        /// <para>Uploads a part by copying data from an existing object as data source.</para>
        /// </summary>
        /// 
        /// <param name="copyPartRequest">Container for the necessary parameters to execute the CopyPart service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the CopyPart service method, as returned by AmazonS3.</returns>
        /// 
        CopyPartResponse CopyPart(CopyPartRequest copyPartRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CopyPart"/>
        /// </summary>
        /// 
        /// <param name="copyPartRequest">Container for the necessary parameters to execute the CopyPart operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyPart
        ///         operation.</returns>
        IAsyncResult BeginCopyPart(CopyPartRequest copyPartRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CopyPart operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.CopyPart"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyPart.</param>
        /// 
        /// <returns>Returns a CopyPartResult from AmazonS3.</returns>
        CopyPartResponse EndCopyPart(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PutBucketWebsite

        /// <summary>
        /// <para>Set the website configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="putBucketWebsiteRequest">Container for the necessary parameters to execute the PutBucketWebsite service method on
        ///          AmazonS3.</param>
        /// 
        PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest putBucketWebsiteRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="putBucketWebsiteRequest">Container for the necessary parameters to execute the PutBucketWebsite operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutBucketWebsite(PutBucketWebsiteRequest putBucketWebsiteRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketWebsite.</param>
        PutBucketWebsiteResponse EndPutBucketWebsite(IAsyncResult asyncResult);
        
        #endregion



        #region DeleteLifecycleConfiguration

        /// <summary>
        /// <para>Deletes the lifecycle configuration from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteLifecycleConfigurationRequest">Container for the necessary parameters to execute the DeleteBucketLifecycle service method on
        ///          AmazonS3.</param>
        /// 
        DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest deleteLifecycleConfigurationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="deleteLifecycleConfigurationRequest">Container for the necessary parameters to execute the DeleteBucketLifecycle operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest deleteLifecycleConfigurationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteLifecycleConfiguration"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLifecycleConfiguration.</param>
        DeleteLifecycleConfigurationResponse EndDeleteLifecycleConfiguration(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PutBucketRequestPayment

        /// <summary>
        /// <para>Sets the request payment configuration for a bucket. By default, the bucket owner pays for downloads from the bucket. This
        /// configuration parameter enables the bucket owner (only) to specify that the person requesting the download will be charged for the
        /// download.</para>
        /// </summary>
        /// 
        /// <param name="putBucketRequestPaymentRequest">Container for the necessary parameters to execute the PutBucketRequestPayment service method on
        ///          AmazonS3.</param>
        /// 
        PutBucketRequestPaymentResponse PutBucketRequestPayment(PutBucketRequestPaymentRequest putBucketRequestPaymentRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketRequestPayment operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketRequestPayment"/>
        /// </summary>
        /// 
        /// <param name="putBucketRequestPaymentRequest">Container for the necessary parameters to execute the PutBucketRequestPayment operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutBucketRequestPayment(PutBucketRequestPaymentRequest putBucketRequestPaymentRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketRequestPayment operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutBucketRequestPayment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketRequestPayment.</param>
        PutBucketRequestPaymentResponse EndPutBucketRequestPayment(IAsyncResult asyncResult);
        
        #endregion



        #region PutACL

        /// <summary>
        /// <para>uses the acl subresource to set the access control list (ACL) permissions for an object that already exists in a bucket</para>
        /// </summary>
        /// 
        /// <param name="putACLRequest">Container for the necessary parameters to execute the PutACL service method on AmazonS3.</param>
        /// 
        PutACLResponse PutACL(PutACLRequest putACLRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PutACL operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutACL"/>
        /// </summary>
        /// 
        /// <param name="putACLRequest">Container for the necessary parameters to execute the PutACL operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginPutACL(PutACLRequest putACLRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutACL operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.PutACL"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutACL.</param>
        PutACLResponse EndPutACL(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetBucketWebsite

        /// <summary>
        /// <para>Returns the website configuration for a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketWebsiteRequest">Container for the necessary parameters to execute the GetBucketWebsite service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketWebsite service method, as returned by AmazonS3.</returns>
        /// 
        GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest getBucketWebsiteRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="getBucketWebsiteRequest">Container for the necessary parameters to execute the GetBucketWebsite operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetBucketWebsite
        ///         operation.</returns>
        IAsyncResult BeginGetBucketWebsite(GetBucketWebsiteRequest getBucketWebsiteRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketWebsite.</param>
        /// 
        /// <returns>Returns a GetBucketWebsiteResult from AmazonS3.</returns>
        GetBucketWebsiteResponse EndGetBucketWebsite(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteBucketWebsite

        /// <summary>
        /// <para>This operation removes the website configuration from the bucket.</para>
        /// </summary>
        /// 
        /// <param name="deleteBucketWebsiteRequest">Container for the necessary parameters to execute the DeleteBucketWebsite service method on
        ///          AmazonS3.</param>
        /// 
        DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest deleteBucketWebsiteRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="deleteBucketWebsiteRequest">Container for the necessary parameters to execute the DeleteBucketWebsite operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteBucketWebsite(DeleteBucketWebsiteRequest deleteBucketWebsiteRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketWebsite operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.DeleteBucketWebsite"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketWebsite.</param>
        DeleteBucketWebsiteResponse EndDeleteBucketWebsite(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetBucketRequestPayment

        /// <summary>
        /// <para>Returns the request payment configuration of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketRequestPaymentRequest">Container for the necessary parameters to execute the GetBucketRequestPayment service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketRequestPayment service method, as returned by AmazonS3.</returns>
        /// 
        GetBucketRequestPaymentResponse GetBucketRequestPayment(GetBucketRequestPaymentRequest getBucketRequestPaymentRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketRequestPayment operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketRequestPayment"/>
        /// </summary>
        /// 
        /// <param name="getBucketRequestPaymentRequest">Container for the necessary parameters to execute the GetBucketRequestPayment operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetBucketRequestPayment operation.</returns>
        IAsyncResult BeginGetBucketRequestPayment(GetBucketRequestPaymentRequest getBucketRequestPaymentRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketRequestPayment operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketRequestPayment"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketRequestPayment.</param>
        /// 
        /// <returns>Returns a GetBucketRequestPaymentResult from AmazonS3.</returns>
        GetBucketRequestPaymentResponse EndGetBucketRequestPayment(IAsyncResult asyncResult);
        
        #endregion



        #region GetObjectMetadata

        /// <summary>
        /// Returns information about a specified object.
        /// </summary>
        /// <remarks>
        /// Retrieves information about a specific object or object size, without actually fetching the object itself. 
        /// This is useful if you're only interested in the object metadata, and don't want to waste bandwidth on the object data.
        /// The response is identical to the GetObject response, except that there is no response body.
        /// </remarks>
        /// <param name="getObjectMetadataRequest">Container for the necessary parameters to execute the GetObjectMetadata service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the HeadObject service method, as returned by AmazonS3.</returns>
        /// 
        GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest getObjectMetadataRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObjectMetadata"/>
        /// </summary>
        /// 
        /// <param name="getObjectMetadataRequest">Container for the necessary parameters to execute the GetObjectMetadata operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetObjectMetadata
        ///         operation.</returns>
        IAsyncResult BeginGetObjectMetadata(GetObjectMetadataRequest getObjectMetadataRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetObjectMetadata operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetObjectMetadata"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectMetadata.</param>
        /// 
        /// <returns>Returns a HeadObjectResult from AmazonS3.</returns>
        GetObjectMetadataResponse EndGetObjectMetadata(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListObjects

        /// <summary>
        /// <para>Returns some or all (up to 1000) of the objects in a bucket. You can use the request parameters as selection criteria to return a
        /// subset of the objects in a bucket.</para>
        /// </summary>
        /// 
        /// <param name="listObjectsRequest">Container for the necessary parameters to execute the ListObjects service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListObjects service method, as returned by AmazonS3.</returns>
        /// 
        ListObjectsResponse ListObjects(ListObjectsRequest listObjectsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListObjects"/>
        /// </summary>
        /// 
        /// <param name="listObjectsRequest">Container for the necessary parameters to execute the ListObjects operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListObjects
        ///         operation.</returns>
        IAsyncResult BeginListObjects(ListObjectsRequest listObjectsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListObjects operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListObjects"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjects.</param>
        /// 
        /// <returns>Returns a ListObjectsResult from AmazonS3.</returns>
        ListObjectsResponse EndListObjects(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetBucketNotification

        /// <summary>
        /// <para>Return the notification configuration of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketNotificationRequest">Container for the necessary parameters to execute the GetBucketNotification service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketNotification service method, as returned by AmazonS3.</returns>
        /// 
        GetBucketNotificationResponse GetBucketNotification(GetBucketNotificationRequest getBucketNotificationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketNotification operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketNotification"/>
        /// </summary>
        /// 
        /// <param name="getBucketNotificationRequest">Container for the necessary parameters to execute the GetBucketNotification operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetBucketNotification operation.</returns>
        IAsyncResult BeginGetBucketNotification(GetBucketNotificationRequest getBucketNotificationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketNotification operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketNotification"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketNotification.</param>
        /// 
        /// <returns>Returns a GetBucketNotificationResult from AmazonS3.</returns>
        GetBucketNotificationResponse EndGetBucketNotification(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetBucketVersioning

        /// <summary>
        /// <para>Returns the versioning state of a bucket.</para>
        /// </summary>
        /// 
        /// <param name="getBucketVersioningRequest">Container for the necessary parameters to execute the GetBucketVersioning service method on
        ///          AmazonS3.</param>
        /// 
        /// <returns>The response from the GetBucketVersioning service method, as returned by AmazonS3.</returns>
        /// 
        GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest getBucketVersioningRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketVersioning"/>
        /// </summary>
        /// 
        /// <param name="getBucketVersioningRequest">Container for the necessary parameters to execute the GetBucketVersioning operation on
        ///          AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetBucketVersioning operation.</returns>
        IAsyncResult BeginGetBucketVersioning(GetBucketVersioningRequest getBucketVersioningRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketVersioning operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.GetBucketVersioning"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketVersioning.</param>
        /// 
        /// <returns>Returns a GetBucketVersioningResult from AmazonS3.</returns>
        GetBucketVersioningResponse EndGetBucketVersioning(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ListBuckets

        /// <summary>
        /// <para>Returns a list of all buckets owned by the authenticated sender of the request.</para>
        /// </summary>
        /// 
        /// <param name="listBucketsRequest">Container for the necessary parameters to execute the ListBuckets service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by AmazonS3.</returns>
        /// 
        ListBucketsResponse ListBuckets(ListBucketsRequest listBucketsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListBuckets"/>
        /// </summary>
        /// 
        /// <param name="listBucketsRequest">Container for the necessary parameters to execute the ListBuckets operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListBuckets
        ///         operation.</returns>
        IAsyncResult BeginListBuckets(ListBucketsRequest listBucketsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListBuckets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuckets.</param>
        /// 
        /// <returns>Returns a ListBucketsResult from AmazonS3.</returns>
        ListBucketsResponse EndListBuckets(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Returns a list of all buckets owned by the authenticated sender of the request.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListBuckets service method, as returned by AmazonS3.</returns>
        /// 
        ListBucketsResponse ListBuckets();
        
        #endregion
        
    

        #region ListParts

        /// <summary>
        /// <para>Lists the parts that have been uploaded for a specific multipart upload.</para>
        /// </summary>
        /// 
        /// <param name="listPartsRequest">Container for the necessary parameters to execute the ListParts service method on AmazonS3.</param>
        /// 
        /// <returns>The response from the ListParts service method, as returned by AmazonS3.</returns>
        /// 
        ListPartsResponse ListParts(ListPartsRequest listPartsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListParts"/>
        /// </summary>
        /// 
        /// <param name="listPartsRequest">Container for the necessary parameters to execute the ListParts operation on AmazonS3.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListParts
        ///         operation.</returns>
        IAsyncResult BeginListParts(ListPartsRequest listPartsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListParts operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.ListParts"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParts.</param>
        /// 
        /// <returns>Returns a ListPartsResult from AmazonS3.</returns>
        ListPartsResponse EndListParts(IAsyncResult asyncResult);
        
        #endregion

    }
}
    
