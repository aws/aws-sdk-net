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

using Amazon.S3.Model;

namespace Amazon.S3
{
    /// <summary>
    /// Interface for Amazon S3 Clients.
    /// For more information about Amazon S3, go to <see href="http://aws.amazon.com/s3"/>
    /// </summary>
    public interface AmazonS3 : IDisposable
    {
        #region GetPreSignedURL

        /// <summary>
        /// Create a signed URL allowing access to a resource that would 
        /// usually require authentication.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When using query string authentication you create a query,
        /// specify an expiration time for the query, sign it with your
        /// signature, place the data in an HTTP request, and distribute
        /// the request to a user or embed the request in a web page.
        /// </para>
        /// <para>
        /// A PreSigned URL can be generated for GET, PUT, DELETE and HEAD
        /// operations on your bucket, keys, and versions.
        /// </para>
        /// </remarks>
        /// <param name="request">The GetPreSignedUrlRequest that defines the
        /// parameters of the operation.</param>
        /// <returns>A string that is the signed http request.</returns>
        /// <exception cref="T:System.ArgumentException" />
        /// <exception cref="T:System.ArgumentNullException" />
        string GetPreSignedURL(GetPreSignedUrlRequest request);

        #endregion

        #region ListBuckets

        /// <summary>
        /// Return a list of all of the buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse with the response from S3.</returns>
        ListBucketsResponse ListBuckets();

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListBuckets"/>
        /// </summary>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse with the response from S3.</returns>
        IAsyncResult BeginListBuckets(AsyncCallback callback, object state);

        /// <summary>
        /// Initiates the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListBuckets"/>
        /// </summary>
        /// <param name="request">The ListBucketsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">
        /// A user-defined state object that is passed to the callback procedure. Retrieve this object from 
        /// within the callback procedure using the AsyncState property.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListBuckets.</returns>
        IAsyncResult BeginListBuckets(ListBucketsRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListBuckets operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListBuckets"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListBuckets.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse from S3.</returns>
        ListBucketsResponse EndListBuckets(IAsyncResult asyncResult);

        /// <summary>
        /// Return a list of all of the buckets owned by the authenticated sender of the request.
        /// </summary>
        /// <param name="request">The ListBucketsRequest that defines the parameters
        /// of this operation</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListBucketsResponse with the response from S3.</returns>
        ListBucketsResponse ListBuckets(ListBucketsRequest request);

        #endregion

        #region GetBucketLocation

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLocation operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketLocation"/>
        /// </summary>
        /// <param name="request">The GetBucketLocationRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketLocation.</returns>
        IAsyncResult BeginGetBucketLocation(GetBucketLocationRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketLocation operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketLocation"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLocation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLocationResponse from S3.</returns>
        GetBucketLocationResponse EndGetBucketLocation(IAsyncResult asyncResult);

        /// <summary>
        /// Returns the location of a specified bucket. 
        /// </summary>
        /// <remarks>
        /// The information returned can be used to determine the bucket's geographical location.
        /// To determine the location of a bucket, you must be the bucket owner.
        /// </remarks>
        /// <param name="request">The GetBucketLocationRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLocationResponse from S3.</returns>
        GetBucketLocationResponse GetBucketLocation(GetBucketLocationRequest request);

        #endregion

        #region GetBucketLogging

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketLogging"/>
        /// </summary>
        /// <param name="request">The GetBucketLoggingRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketLogging.</returns>
        IAsyncResult BeginGetBucketLogging(GetBucketLoggingRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketLogging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketLogging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLoggingResponse from S3.</returns>
        GetBucketLoggingResponse EndGetBucketLogging(IAsyncResult asyncResult);

        /// <summary>
        /// Gets the logging status for the specified bucket.
        /// </summary>
        /// <remarks>
        /// For more information about S3Bucket Logging see <see href="http://docs.amazonwebservices.com/AmazonS3/latest/ServerLogs.html" />
        /// </remarks>
        /// <param name="request">The GetBucketLoggingRequest that defines
        /// the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketLoggingResponse from S3.</returns>
        GetBucketLoggingResponse GetBucketLogging(GetBucketLoggingRequest request);

        #endregion

        #region EnableBucketLogging

        /// <summary>
        /// Initiates the asynchronous execution of the EnableBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.EnableBucketLogging"/>
        /// </summary>
        /// <param name="request">The EnableBucketLoggingRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndEnableBucketLogging.</returns>
        IAsyncResult BeginEnableBucketLogging(EnableBucketLoggingRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the EnableBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.EnableBucketLogging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableBucketLogging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a EnableBucketLoggingResponse from S3.</returns>
        EnableBucketLoggingResponse EndEnableBucketLogging(IAsyncResult asyncResult);

        /// <summary>
        /// Turn on bucket logging for a specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// An Amazon S3 bucket can be configured to create access log records for the
        /// requests made against it. An access log record contains details about the
        /// request such as the request type, the resource with which the request worked,
        /// and the time and date that the request was processed. Server access logs are
        /// useful for many applications, because they give bucket owners insight into
        /// the nature of requests made by clients not under their control.
        /// </para>
        /// <para>
        /// Changes to the logging status for a bucket are visible in the configuration API immediately,
        /// but they take time to actually affect the delivery of log files. For example, if you enable
        /// logging for a bucket, some requests made in the following hour might be logged, while others
        /// might not. Or, if you change the target bucket for logging from bucket A to bucket B, some
        /// logs for the next hour might continue to be delivered to bucket A, while others might be delivered
        /// to the new target bucket B. In all cases, the new settings will eventually take effect without any
        /// further action on your part.
        /// </para>
        /// </remarks>
        /// <param name="request">The EnableBucketLoggingRequest that defines the parameters of
        /// the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a EnableBucketLoggingResponse from S3.</returns>
        EnableBucketLoggingResponse EnableBucketLogging(EnableBucketLoggingRequest request);

        #endregion

        #region DisableBucketLogging

        /// <summary>
        /// Initiates the asynchronous execution of the DisableBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DisableBucketLogging"/>
        /// </summary>
        /// <param name="request">The DisableBucketLoggingRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDisableBucketLogging.</returns>
        IAsyncResult BeginDisableBucketLogging(DisableBucketLoggingRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DisableBucketLogging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DisableBucketLogging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableBucketLogging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DisableBucketLoggingResponse from S3.</returns>
        DisableBucketLoggingResponse EndDisableBucketLogging(IAsyncResult asyncResult);
        
        /// <summary>
        /// Turn off logging for a specified bucket.
        /// </summary>
        /// <remarks>
        /// An Amazon S3 bucket can be configured to create access log records for the
        /// requests made against it. An access log record contains details about the
        /// request such as the request type, the resource with which the request worked,
        /// and the time and date that the request was processed. Server access logs are
        /// useful for many applications, because they give bucket owners insight into
        /// the nature of requests made by clients not under their control.
        /// </remarks>
        /// <param name="request">
        /// The DisableBucketLoggingRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DisableBucketLoggingResponse from S3.</returns>
        DisableBucketLoggingResponse DisableBucketLogging(DisableBucketLoggingRequest request);

        #endregion

        #region GetBucketVersioning

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketVersioning operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketVersioning"/>
        /// </summary>
        /// <param name="request">The GetBucketVersioningRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketVersioning.</returns>
        IAsyncResult BeginGetBucketVersioning(GetBucketVersioningRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketVersioning operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketVersioning"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketVersioning.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketVersioningResponse from S3.</returns>
        GetBucketVersioningResponse EndGetBucketVersioning(IAsyncResult asyncResult);

        /// <summary>
        /// Returns the versioning status of a bucket.
        /// </summary>
        /// <param name="request">The GetBucketVersioningRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketVersioningResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3BucketVersioningConfig"/>
        GetBucketVersioningResponse GetBucketVersioning(GetBucketVersioningRequest request);

        #endregion

        #region SetBucketVersioning

        /// <summary>
        /// Initiates the asynchronous execution of the SetBucketVersioning operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetBucketVersioning"/>
        /// </summary>
        /// <param name="request">The SetBucketVersioningRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndSetBucketVersioning.</returns>
        IAsyncResult BeginSetBucketVersioning(SetBucketVersioningRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetBucketVersioning operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetBucketVersioning"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetBucketVersioning.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetBucketVersioningResponse from S3.</returns>
        SetBucketVersioningResponse EndSetBucketVersioning(IAsyncResult asyncResult);

        /// <summary>
        /// Enable or suspend versioning on a bucket.
        /// </summary>
        /// <remarks>
        /// Once versioning has been "Enabled" on a bucket, it can be "Suspended" but cannot be switched "Off".
        /// </remarks>
        /// <param name="request">The SetBucketVersioningRequest that defines the parameters of the operation.</param>
        /// <exception cref="T:System.ArgumentException">
        /// If SetBucketVersioningRequest.VersioningStatus has the value S3BucketVersioningStatus.Off
        /// </exception>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetBucketVersioningResponse from S3.</returns>
        SetBucketVersioningResponse SetBucketVersioning(SetBucketVersioningRequest request);

        #endregion

        #region GetBucketPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketPolicy"/>
        /// </summary>
        /// <param name="request">The GetBucketPolicyRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketPolicy.</returns>
        IAsyncResult BeginGetBucketPolicy(GetBucketPolicyRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketPolicy"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketPolicy.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketPolicyResponse from S3.</returns>
        GetBucketPolicyResponse EndGetBucketPolicy(IAsyncResult asyncResult);

        /// <summary>
        /// Retrieves the policy for a specified bucket. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// Only the owner of the bucket can retrieve the policy. If no policy has been set for the bucket,
        /// then an error will be thrown.
        /// </para>
        /// <para>
        /// Bucket policies provide access control management at the bucket level for
        /// both the bucket resource and contained object resources. Only one policy
        /// can be specified per-bucket.
        /// </para>
        /// <para>
        /// For more information on forming bucket polices, see: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The GetBucketPolicyRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetBucketPolicyResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        GetBucketPolicyResponse GetBucketPolicy(GetBucketPolicyRequest request);

        #endregion

        #region PutBucketPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketPolicy"/>
        /// </summary>
        /// <param name="request">The PutBucketPolicyRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutBucketPolicy.</returns>
        IAsyncResult BeginPutBucketPolicy(PutBucketPolicyRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketPolicy"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketPolicy.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketPolicyResponse from S3.</returns>
        PutBucketPolicyResponse EndPutBucketPolicy(IAsyncResult asyncResult);

        /// <summary>
        /// Set the policy associated with a specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Sets the policy associated with the specified bucket. Only the owner of
        /// the bucket can set a bucket policy. If a policy already exists for the
        /// specified bucket, the new policy will replace the existing policy.
        /// </para>
        /// <para>
        /// Bucket policies provide access control management at the bucket level for
        /// both the bucket resource and contained object resources. Only one policy
        /// may be specified per-bucket.
        /// </para>
        /// <para>
        /// For more information on forming bucket polices, see: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The PutBucketPolicyRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a PutBucketPolicyResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        PutBucketPolicyResponse PutBucketPolicy(PutBucketPolicyRequest request);

        #endregion

        #region DeleteBucketPolicy

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketPolicy"/>
        /// </summary>
        /// <param name="request">The DeleteBucketPolicyRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteBucketPolicy.</returns>
        IAsyncResult BeginDeleteBucketPolicy(DeleteBucketPolicyRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketPolicy operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketPolicy"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketPolicy.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketPolicyResponse from S3.</returns>
        DeleteBucketPolicyResponse EndDeleteBucketPolicy(IAsyncResult asyncResult);

        /// <summary>
        /// Deletes the policy associated with the specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        ///  Only the owner of the bucket can delete the bucket policy. If you delete a policy that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </para>
        /// <para>
        /// Bucket policies provide access control management at the bucket level for
        /// both the bucket resource and contained object resources. Only one policy
        /// may be specified per-bucket.
        /// </para>
        /// <para>
        /// For more information on forming bucket polices, see: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The DeleteBucketPolicyRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a DeleteBucketPolicyResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        DeleteBucketPolicyResponse DeleteBucketPolicy(DeleteBucketPolicyRequest request);

        #endregion

        #region SetNotificationConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the SetNotificationConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetNotificationConfiguration"/>
        /// </summary>
        /// <param name="request">The SetNotificationConfigurationRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndSetNotificationConfiguration.</returns>
        IAsyncResult BeginSetNotificationConfiguration(SetNotificationConfigurationRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetNotificationConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetNotificationConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetNotificationConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetNotificationConfigurationResponse from S3.</returns>
        SetNotificationConfigurationResponse EndSetNotificationConfiguration(IAsyncResult asyncResult);

        /// <summary>
        /// Set or change the configuration of notifications for the specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The notification configuration of a bucket provides near realtime notifications
        /// of events the user is interested in, using SNS as the delivery service.
        /// Notification is turned on by enabling configuration on a bucket, specifying
        /// the events and the SNS topic. This configuration can only be turned
        /// on by the bucket owner. If a notification configuration already exists for the
        /// specified bucket, the new notification configuration will replace the existing
        /// notification configuration.  To remove the notification configuration pass in
        /// an empty request.  Currently, buckets may only have a single event and topic
        /// configuration.
        /// </para>
        /// <para>
        /// S3 is eventually consistent. It may take time for the notification status
        /// of a bucket to be propagated throughout the system.
        /// </para>
        /// </remarks>
        /// <param name="request">The SetNotificationConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a SetNotificationConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        SetNotificationConfigurationResponse SetNotificationConfiguration(SetNotificationConfigurationRequest request);

        #endregion

        #region GetNotificationConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetNotificationConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetNotificationConfiguration"/>
        /// </summary>
        /// <param name="request">The GetNotificationConfigurationRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetNotificationConfiguration.</returns>
        IAsyncResult BeginGetNotificationConfiguration(GetNotificationConfigurationRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetNotificationConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetNotificationConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNotificationConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetNotificationConfigurationResponse from S3.</returns>
        GetNotificationConfigurationResponse EndGetNotificationConfiguration(IAsyncResult asyncResult);

        /// <summary>
        /// Retrieve the notification configuration for the specified bucket.
        /// </summary>
        /// <remarks>
        /// Only the owner of the bucket can retrieve the notification configuration.
        /// </remarks>
        /// <param name="request">The GetNotificationConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetNotificationConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        GetNotificationConfigurationResponse GetNotificationConfiguration(GetNotificationConfigurationRequest request);

        #endregion

        #region ListObjects

        /// <summary>
        /// Initiates the asynchronous execution of the ListObjects operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListObjects"/>
        /// </summary>
        /// <param name="request">The ListObjectsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListObjects.</returns>
        IAsyncResult BeginListObjects(ListObjectsRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListObjects operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListObjects"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListObjects.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListObjectsResponse from S3.</returns>
        ListObjectsResponse EndListObjects(IAsyncResult asyncResult);

        /// <summary>
        /// Return the set of objects/keys in the specified bucket, ordered lexicographically (from a-Z).
        /// </summary>
        /// <remarks>
        /// <para>
        /// Since buckets can contain a virtually unlimited number of objects, the complete
        /// results of a list query can be extremely large. To manage large result sets,
        /// Amazon S3 uses pagination to split them into multiple responses. Callers should
        /// always check the <see cref="P:Amazon.S3.Model.ListObjectsResponse.IsTruncated" />
        /// to see if the returned listing is complete, or if callers need to make additional 
        /// calls to get more results. The marker parameter allows callers to specify where to 
        /// start the object listing.
        /// </para>
        /// <para>
        /// List performance is not substantially affected by the total number of keys in your
        /// bucket, nor by the presence or absence of any additional query parameters.
        /// The list can be filtered via the Marker property of the ListObjectsRequest.
        /// </para>
        /// <para>
        /// In order to List Objects, you must have READ access to the bucket.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The ListObjectsRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListObjectsResponse from S3 with a list of S3Objects,
        /// headers and request parameters used to filter the list.</returns>
        ListObjectsResponse ListObjects(ListObjectsRequest request);

        #endregion

        #region ListVersions

        /// <summary>
        /// Initiates the asynchronous execution of the ListVersions operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListVersions"/>
        /// </summary>
        /// <param name="request">The ListVersionsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListVersions.</returns>
        IAsyncResult BeginListVersions(ListVersionsRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListVersions operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListVersions"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListVersions.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListVersionsResponse from S3.</returns>
        ListVersionsResponse EndListVersions(IAsyncResult asyncResult);

        /// <summary>
        /// Returns the set of versions of objects in the specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Since buckets can contain a virtually unlimited number of objects, the complete
        /// results of a list query can be extremely large. To manage large result sets,
        /// Amazon S3 uses pagination to split them into multiple responses. Callers should
        /// always check the <see cref="P:Amazon.S3.Model.ListVersionsResonse.IsTruncated" />
        /// to see if the returned listing
        /// is complete, or if callers need to make additional calls to get more results.
        /// The KeyMarker and VersionIdMarker parameters of the ListVersionsRequest object
        /// allow callers to specify where to start the version listing. In order to enable
        /// versioning on a bucket, please refer to the <see cref="M:Amazon.S3.AmazonS3Client.SetBucketVersioning">SetBucketVersioning</see>
        /// operation's details.
        /// </para>
        /// <para>
        /// List performance is not substantially affected by the total number of keys in your
        /// bucket, nor by the presence or absence of any additional query parameters.
        /// The ListVersions operation returns a list of object versions in the bucket
        /// specified ordered first by key and then by version. Keys are sorted lexicographically
        /// (i.e. alphabetically from a-Z); versions are sorted from most to least recent.
        /// Both versions with data and delete markers are included in the results.
        /// </para>
        /// <para>
        /// In order to List Versions, you must have READ access to the bucket.
        /// When the list is not filtered by a specific key, only the metadata
        /// associated with the latest version of objects in the bucket is returned.
        /// The use of KeyMarker and VersionIdMarker allow you to filter results.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The ListVersionsRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListVersionsResponse from S3 that contains a list of
        /// versions along with metadata and the original request parameters.</returns>
        ListVersionsResponse ListVersions(ListVersionsRequest request);

        #endregion

        #region GetACL

        /// <summary>
        /// Initiates the asynchronous execution of the GetACL operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetACL"/>
        /// </summary>
        /// <param name="request">The GetACLRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetACL.</returns>
        IAsyncResult BeginGetACL(GetACLRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetACL operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetACL"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetACL.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetACLResponse from S3.</returns>
        GetACLResponse EndGetACL(IAsyncResult asyncResult);

        /// <summary>
        /// Returns the S3AccessControlList for the specified bucket or object.
        /// </summary>
        /// <remarks>
        /// Each bucket and object in Amazon S3 has an ACL that defines its access control
        /// policy, which is a list of grants. A grant consists of one grantee and one permission.
        /// ACLs only grant permissions; they do not deny them.
        /// </remarks>
        /// <param name="request">
        /// The GetACLRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetACLResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3AccessControlList"/>
        GetACLResponse GetACL(GetACLRequest request);

        #endregion

        #region SetACL

        /// <summary>
        /// Initiates the asynchronous execution of the SetACL operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetACL"/>
        /// </summary>
        /// <param name="request">The SetACLRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndSetACL.</returns>
        IAsyncResult BeginSetACL(SetACLRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the SetACL operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.SetACL"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetACL.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetACLResponse from S3.</returns>
        SetACLResponse EndSetACL(IAsyncResult asyncResult);

        /// <summary>
        /// Sets an S3AccessControlList on the specified bucket or object.
        /// </summary>
        /// <remarks>
        /// <para>
        /// Each bucket and object in Amazon S3 has an ACL that defines its access control
        /// policy, which is a list of grants. A grant consists of one grantee and one permission.
        /// ACLs only grant permissions; they do not deny them.
        /// </para>
        /// <para>
        /// Often used ACLs are defined in the S3CannedACL enumeration.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The SetACLRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a SetACLResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3AccessControlList"/>
        SetACLResponse SetACL(SetACLRequest request);

        #endregion

        #region PutBucket

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucket operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucket"/>
        /// </summary>
        /// <param name="request">The PutBucketRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutBucket.</returns>
        IAsyncResult BeginPutBucket(PutBucketRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucket operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucket"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucket.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketResponse from S3.</returns>
        PutBucketResponse EndPutBucket(IAsyncResult asyncResult);

        /// <summary>
        /// Create a new S3 bucket.
        /// <seealso cref="T:Amazon.S3.Model.S3Region"/>
        /// </summary>
        /// <remarks>
        /// <para>
        /// Depending on your latency and legal requirements, you can specify a location
        /// constraint that will affect where your data physically resides.
        /// Every object stored in Amazon S3 is contained in a bucket. Buckets
        /// partition the namespace of objects stored in Amazon S3 at the top level.
        /// Within a bucket, you can use any names for your objects, but bucket names
        /// must be unique across all of Amazon S3.
        /// </para>
        /// <para>
        /// Buckets are similar to Internet domain names. Just as Amazon is the only owner
        /// of the domain name Amazon.com, only one person or organization can own a bucket
        /// within Amazon S3. The similarities between buckets and domain names is not a
        /// coincidence - there is a direct mapping between Amazon S3 buckets and subdomains
        /// of s3.amazonaws.com. Objects stored in Amazon S3 are addressable using the REST API
        /// under the domain bucketname.s3.amazonaws.com. For example, the object homepage.html
        /// stored in the Amazon S3 bucket mybucket can be addressed as
        /// http://mybucket.s3.amazonaws.com/homepage.html.
        /// </para>
        /// <para>
        /// To conform with DNS requirements, the following constraints apply:
        /// <list type="bullet">
        /// <item>Bucket names should not contain underscores (_)</item>
        /// <item>Bucket names should be between 3 and 63 characters long</item>
        /// <item>Bucket names should not end with a dash</item>
        /// <item>Bucket names cannot contain two, adjacent periods</item>
        /// <item>Bucket names cannot contain dashes next to periods
        ///   (e.g., "my-.bucket.com" and "my.-bucket" are invalid)</item>
        /// <item>Bucket names cannot contain uppercase characters</item>
        /// </list>
        /// </para>
        /// <para>
        /// There is no limit to the number of objects that can be stored in a bucket and no
        /// variation in performance when using many buckets or just a few. You can store all
        /// of your objects in a single bucket or organize them across several buckets.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The PutBucketRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketResponse from S3.</returns>
        PutBucketResponse PutBucket(PutBucketRequest request);

        #endregion

        #region DeleteBucket

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucket operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucket"/>
        /// </summary>
        /// <param name="request">The DeleteBucketRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteBucket.</returns>
        IAsyncResult BeginDeleteBucket(DeleteBucketRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucket operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucket"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucket.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketResponse from S3.</returns>
        DeleteBucketResponse EndDeleteBucket(IAsyncResult asyncResult);

        /// <summary>
        /// Deletes an S3 bucket.
        /// </summary>
        /// <remarks>
        /// All objects in the bucket must be deleted before the bucket itself can be deleted.
        /// Only the owner of a bucket can delete it, regardless of the bucket's access control policy.
        /// </remarks>
        /// <param name="request">
        /// The DeleteBucketRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketResponse from S3.</returns>
        DeleteBucketResponse DeleteBucket(DeleteBucketRequest request);

        #endregion

        #region GetObject

        /// <summary>
        /// Initiates the asynchronous execution of the GetObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetObject"/>
        /// </summary>
        /// <param name="request">The GetObjectRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetObject.</returns>
        IAsyncResult BeginGetObject(GetObjectRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetObject"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObject.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectResponse from S3.</returns>
        GetObjectResponse EndGetObject(IAsyncResult asyncResult);

        /// <summary>
        /// Fetches the most recent version of an S3 object.
        /// </summary>
        /// <remarks>
        /// <para>
        /// You must have READ access to the object.
        /// </para>
        /// <para>
        /// If READ access is granted to an anonymous user, an object can be retrieved
        /// without an authorization header. Providing a version-id for the object will
        /// fetch the specific version from S3 instead of the most recent one.
        /// </para>
        /// <para>
        /// You should wrap the response you get from calling GetObject in a using clause.
        /// This ensures that all underlying IO resources allocated for the response
        /// are disposed once the response has been processed. This is one way to
        /// call GetObject:
        /// <code>
        /// using (GetObjectResponse response = s3Client.GetObject(request))
        /// {
        ///     ... Process the response:
        ///     Get the Stream, get the content-length, write contents to disk, etc
        /// }
        /// </code>
        /// To see what resources are cleaned up at the end of the using block, please
        /// see <see cref="M:Amazon.S3.Model.S3Response.Dispose"/>
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The GetObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectResponse from S3.</returns>
        GetObjectResponse GetObject(GetObjectRequest request);

        #endregion

        #region GetObjectMetadata

        /// <summary>
        /// Initiates the asynchronous execution of the GetObjectMetadata operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetObjectMetadata"/>
        /// </summary>
        /// <param name="request">The GetObjectMetadataRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetObjectMetadata.</returns>
        IAsyncResult BeginGetObjectMetadata(GetObjectMetadataRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetObjectMetadata operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetObjectMetadata"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetObjectMetadata.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectMetadataResponse from S3.</returns>
        GetObjectMetadataResponse EndGetObjectMetadata(IAsyncResult asyncResult);

        /// <summary>
        /// Returns information about a specified object.
        /// </summary>
        /// <remarks>
        /// Retrieves information about a specific object or object size, without actually fetching the object itself. 
        /// This is useful if you're only interested in the object metadata, and don't want to waste bandwidth on the object data.
        /// The response is identical to the GetObject response, except that there is no response body.
        /// </remarks>
        /// <param name="request">
        /// The GetObjectMetadataRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetObjectMetadataResponse from S3.</returns>
        GetObjectMetadataResponse GetObjectMetadata(GetObjectMetadataRequest request);

        #endregion

        #region PutObject

        /// <summary>
        /// Initiates the asynchronous execution of the PutObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutObject"/>
        /// </summary>
        /// <param name="request">The PutObjectRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutObject.</returns>
        IAsyncResult BeginPutObject(PutObjectRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutObject"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutObject.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutObjectResponse from S3.</returns>
        PutObjectResponse EndPutObject(IAsyncResult asyncResult);

        /// <summary>
        /// Adds an object to an S3 bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The response indicates that the object has been successfully stored.
        /// Amazon S3 never stores partial objects: if you receive a successful
        /// response, then you can be confident that the entire object was stored.
        /// </para>
        /// <para>
        /// To ensure data is not corrupted over the network, use the Content-MD5
        /// header. When you use the Content-MD5 header, Amazon S3 checks the object
        /// against the provided MD5 value. If they do not match, Amazon S3 returns an error.
        /// Additionally, you can calculate the MD5 while putting an object to
        /// Amazon S3 and compare the returned Etag to the calculated MD5 value.
        /// </para>
        /// <para>
        /// If an object already exists in a bucket, the new object will overwrite
        /// it because Amazon S3 stores the last write request. However, Amazon S3
        /// is a distributed system. If Amazon S3 receives multiple write requests
        /// for the same object nearly simultaneously, all of the objects might be
        /// stored, even though only one wins in the end. Amazon S3 does not provide
        /// object locking; if you need this, make sure to build it into your application
        /// layer.
        /// </para>
        /// <para>
        /// If you specify a location constraint when creating a bucket, all objects
        /// added to the bucket are stored in the bucket's location.
        /// </para>
        /// <para>
        /// You must have WRITE access to the bucket to add an object.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The PutObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentException"></exception>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <exception cref="T:System.IO.FileNotFoundException"></exception>
        /// <returns>Returns a PutObjectResponse from S3.</returns>
        PutObjectResponse PutObject(PutObjectRequest request);

        #endregion

        #region DeleteObject

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObject operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteObject"/>
        /// </summary>
        /// <param name="request">The DeleteObjectRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteObject.</returns>
        IAsyncResult BeginDeleteObject(DeleteObjectRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteObject"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObject.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteObjectResponse from S3.</returns>
        DeleteObjectResponse EndDeleteObject(IAsyncResult asyncResult);

        /// <summary>
        /// Removes the specified object from Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The DeleteObject operation removes the specified object from Amazon S3.
        /// Once deleted, there is no method to restore or undelete an object.
        /// </para>
        /// <para>
        /// If you delete an object that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The DeleteObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteObjectResponse from S3.</returns>
        DeleteObjectResponse DeleteObject(DeleteObjectRequest request);

        #endregion

        #region DeleteObjects

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteObjects operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteObjects"/>
        /// </summary>
        /// <param name="request">The DeleteObjectsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteObjects.</returns>
        IAsyncResult BeginDeleteObjects(DeleteObjectsRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// <para>
        /// Finishes the asynchronous execution of the DeleteObjects operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteObjects"/>
        /// </para>
        /// <para>
        /// DeleteObjectsException will be thrown if any of the deletes fail.
        /// </para>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteObjects.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <exception cref="T:Amazon.S3.Model.DeleteObjectsException">
        /// If any objects are not deleted during the operation.
        /// </exception>
        /// <returns>Returns a DeleteObjectsResponse from S3.</returns>
        DeleteObjectsResponse EndDeleteObjects(IAsyncResult asyncResult);

        /// <summary>
        /// Removes the specified objects from Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The DeleteObjects operation removes the specified object from Amazon S3.
        /// Once deleted, there is no method to restore or undelete the objects.
        /// </para>
        /// <para>
        /// DeleteObjectsException will be thrown if any of the deletes fail.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The DeleteObjectsRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <exception cref="T:Amazon.S3.Model.DeleteObjectsException">
        /// If any objects are not deleted during the operation.
        /// </exception>
        /// <returns>Returns a DeleteObjectsResponse from S3.</returns>
        DeleteObjectsResponse DeleteObjects(DeleteObjectsRequest request);

        #endregion

        #region CopyObject

        /// <summary>
        /// Initiates the asynchronous execution of the CopyObject operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.CopyObject"/>
        /// </summary>
        /// <param name="request">The CopyObjectRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndCopyObject.</returns>
        IAsyncResult BeginCopyObject(CopyObjectRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CopyObject operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.CopyObject"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyObject.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a CopyObjectResponse from S3.</returns>
        CopyObjectResponse EndCopyObject(IAsyncResult asyncResult);

        /// <summary>
        /// Creates a copy of an object that is already stored in Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When copying an object, you can preserve all metadata (default) or specify new metadata.
        /// However, the ACL is not preserved and is set to private for the user making the request.
        /// To override the default ACL setting, specify a new ACL when generating a copy request.
        /// </para>
        /// <para>
        /// If versioning has been enabled on the source bucket, and you want to copy a specific
        /// version of an object, please use
        /// <see cref="P:Amazon.S3.Model.CopyObjectRequest.SourceVersionId" /> to specify the
        /// version. By default, the most recent version of an object is copied to the
        /// destination bucket.
        /// </para>
        /// <para>
        /// If Versioning has been enabled on the target bucket, S3 generates a
        /// unique version ID for the object being copied. This version ID is different
        /// from the version ID of the source object. Additionally, S3 returns the version
        /// ID of the copied object in the x-amz-version-id response header in the response.
        /// If you do not enable Versioning or suspend it on the target bucket, the version ID
        /// S3 generates is always the string literal - "null".
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The CopyObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a CopyObjectResponse from S3.</returns>
        /// <seealso cref="T:Amazon.S3.Model.S3AccessControlList"/>
        CopyObjectResponse CopyObject(CopyObjectRequest request);

        #endregion

        #region InitiateMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the InitiateMultipartUpload operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.InitiateMultipartUpload"/>
        /// </summary>
        /// <param name="request">The InitiateMultipartUploadRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndInitiateMultipartUpload.</returns>
        IAsyncResult BeginInitiateMultipartUpload(InitiateMultipartUploadRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the InitiateMultipartUpload operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.InitiateMultipartUpload"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginInitiateMultipartUpload.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a InitiateMultipartUploadResponse from S3.</returns>
        InitiateMultipartUploadResponse EndInitiateMultipartUpload(IAsyncResult asyncResult);

        /// <summary>
        /// Initiates a multipart upload and returns an InitiateMultipartUploadResponse which contains an upload ID.
        /// </summary>
        /// <remarks>
        /// The upload ID associates all the parts in the specific upload. You specify this upload ID in each of 
        /// your subsequent Upload Part requests. You also include this upload ID in the final request to either 
        /// complete, or abort the multipart upload request.
        /// </remarks>
        /// <param name="request">
        /// The CopyObjectRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a InitiateMultipartUploadResponse from S3.</returns>
        InitiateMultipartUploadResponse InitiateMultipartUpload(InitiateMultipartUploadRequest request);

        #endregion

        #region UploadPart

        /// <summary>
        /// Initiates the asynchronous execution of the UploadPart operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.UploadPart"/>
        /// </summary>
        /// <param name="request">The UploadPartRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndUploadPart.</returns>
        IAsyncResult BeginUploadPart(UploadPartRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UploadPart operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.UploadPart"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadPart.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a UploadPartResponse from S3.</returns>
        UploadPartResponse EndUploadPart(IAsyncResult asyncResult);

        /// <summary>
        /// Uploads a single part in a multipart upload.  
        /// </summary>
        /// <remarks>
        /// <para>
        /// You must initiate a multipart upload before you can upload any part.
        /// </para>
        /// <para>
        /// Your UploadPart request must include an upload ID and a part number. 
        /// The upload ID is the ID returned by Amazon S3 in response to your 
        /// Initiate Multipart Upload request. Part number can be any number between 1 and
        /// 10,000, inclusive. A part number uniquely identifies a part and also 
        /// defines its position within the object being uploaded. If you 
        /// upload a new part using the same part number as an existing
        /// part, that part is overwritten.
        /// </para>
        /// <para>
        /// To ensure data is not corrupted traversing the network, specify the 
        /// Content-MD5 header in the Upload Part request. Amazon S3 checks 
        /// the part data against the provided MD5 value. If they do not match,
        /// Amazon S3 returns an error.
        /// </para>
        /// <para>
        /// When you upload a part, the UploadPartResponse response contains an ETag property.
        /// You should record this ETag property value and the part 
        /// number. After uploading all parts, you must send a CompleteMultipartUpload
        /// request. At that time Amazon S3 constructs a complete object by 
        /// concatenating all the parts you uploaded, in ascending order based on 
        /// the part numbers. The CompleteMultipartUpload request requires you to
        /// send all the part numbers and the corresponding ETag values.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The UploadPartRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a UploadPartResponse from S3.</returns>
        UploadPartResponse UploadPart(UploadPartRequest request);

        #endregion

        #region CopyPart

        /// <summary>
        /// Initiates the asynchronous execution of the CopyPart operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.UploadPart"/>
        /// </summary>
        /// <param name="request">The CopyPartRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndCopyPart.</returns>
        IAsyncResult BeginCopyPart(CopyPartRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CopyPart operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.UploadPart"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyPart.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a CopyPartResponse from S3.</returns>
        CopyPartResponse EndCopyPart(IAsyncResult asyncResult);

        /// <summary>
        /// Creates a part in a multipart upload from an existing Amazon S3 Object.  
        /// </summary>
        /// <remarks>
        /// <para>
        /// You must initiate a multipart upload before you can copy a part.
        /// </para>
        /// <para>
        /// Your CopyPart request must include an upload ID and a part number. 
        /// The upload ID is the ID returned by Amazon S3 in response to your 
        /// Initiate Multipart Upload request. Part number can be any number between 1 and
        /// 10,000, inclusive. A part number uniquely identifies a part and also 
        /// defines its position within the object being uploaded. If you 
        /// copy a part using the same part number as an existing part, that part is overwritten.
        /// </para>
        /// <para>
        /// When you copy a part, the CopyPartResponse response contains an ETag property.
        /// You should record this ETag property value and the part 
        /// number. After uploading all parts, you must send a CompleteMultipartUpload
        /// request. At that time Amazon S3 constructs a complete object by 
        /// concatenating all the parts you uploaded, in ascending order based on 
        /// the part numbers. The CompleteMultipartUpload request requires you to
        /// send all the part numbers and the corresponding ETag values.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The CopyPartRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a CopyPartResponse from S3.</returns>
        CopyPartResponse CopyPart(CopyPartRequest request);

        #endregion

        #region ListParts

        /// <summary>
        /// Initiates the asynchronous execution of the ListParts operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListParts"/>
        /// </summary>
        /// <param name="request">The ListPartsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListParts.</returns>
        IAsyncResult BeginListParts(ListPartsRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListParts operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListParts"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListParts.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListPartsResponse from S3.</returns>
        ListPartsResponse EndListParts(IAsyncResult asyncResult);

        /// <summary>
        /// Lists the parts that have been uploaded for a particular multipart upload.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This method must include the upload ID, returned by 
        /// the InitiateMultipartUpload request. This request 
        /// returns a maximum of 1000 uploaded parts by default. You can
        /// restrict the number of parts returned by specifying the 
        /// MaxParts property on the ListPartsRequest. 
        /// </para>
        /// <para>
        /// If your multipart upload consists of more parts than allowed in the 
        /// ListParts response, the response returns a IsTruncated
        /// field with value true, and a NextPartNumberMarker property. 
        /// In subsequent ListParts request you can include the 
        /// PartNumberMarker property and set its value to the
        /// NextPartNumberMarker property value from the previous response.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The ListPartsRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a ListPartsResponse from S3.</returns>
        ListPartsResponse ListParts(ListPartsRequest request);

        #endregion

        #region AbortMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUpload operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <param name="request">The AbortMultipartUploadRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndAbortMultipartUpload.</returns>
        IAsyncResult BeginAbortMultipartUpload(AbortMultipartUploadRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AbortMultipartUpload operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortMultipartUpload.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a AbortMultipartUploadResponse from S3.</returns>
        AbortMultipartUploadResponse EndAbortMultipartUpload(IAsyncResult asyncResult);

        /// <summary>
        /// Aborts a multipart upload. 
        /// </summary>
        /// <remarks>
        /// After a multipart upload is aborted, no additional parts can be uploaded using 
        /// that upload ID. The storage consumed by any previously uploaded parts will be freed.
        /// However, if any part uploads are currently in progress, those part 
        /// uploads may or may not succeed. As a result, it may be necessary to 
        /// abort a given multipart upload multiple times in order to completely free
        /// all storage consumed by all parts.
        /// </remarks>
        /// <param name="request">
        /// The AbortMultipartUploadRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a AbortMultipartUploadResponse from S3.</returns>
        AbortMultipartUploadResponse AbortMultipartUpload(AbortMultipartUploadRequest request);

        #endregion

        #region CompleteMultipartUpload

        /// <summary>
        /// Initiates the asynchronous execution of the CompleteMultipartUpload operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.CompleteMultipartUpload"/>
        /// </summary>
        /// <param name="request">The CompleteMultipartUploadRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndCompleteMultipartUpload.</returns>
        IAsyncResult BeginCompleteMultipartUpload(CompleteMultipartUploadRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CompleteMultipartUpload operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.CompleteMultipartUpload"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCompleteMultipartUpload.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a CompleteMultipartUploadResponse from S3.</returns>
        CompleteMultipartUploadResponse EndCompleteMultipartUpload(IAsyncResult asyncResult);

        /// <summary>
        /// Completes a multipart upload by assembling previously uploaded parts.
        /// </summary>
        /// <remarks>
        /// <para>
        /// You first upload all parts using the UploadPart method. 
        /// After successfully uploading all relevant parts of an upload, 
        /// you call this operation to complete the upload. Upon receiving
        /// this request, Amazon S3 concatenates all the parts in ascending 
        /// order by part number to create a new object. In the 
        /// CompleteMultipartUpload request, you must provide the 
        /// parts list. For each part in the list, you provide the 
        /// part number and the ETag header value, returned after that 
        /// part was uploaded.
        /// </para>
        /// <para>
        /// Processing of a CompleteMultipartUpload request may take 
        /// several minutes to complete.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The CompleteMultipartUploadRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a CompleteMultipartUploadResponse from S3.</returns>
        CompleteMultipartUploadResponse CompleteMultipartUpload(CompleteMultipartUploadRequest request);

        #endregion

        #region ListMultipartUploads

        /// <summary>
        /// Initiates the asynchronous execution of the ListMultipartUploads operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListMultipartUploads"/>
        /// </summary>
        /// <param name="request">The ListMultipartUploadsRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndListMultipartUploads.</returns>
        IAsyncResult BeginListMultipartUploads(ListMultipartUploadsRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ListMultipartUploads operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.ListMultipartUploads"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMultipartUploads.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a ListMultipartUploadsResponse from S3.</returns>
        ListMultipartUploadsResponse EndListMultipartUploads(IAsyncResult asyncResult);

        /// <summary>
        /// Lists in-progress multipart uploads.
        /// </summary>
        /// <remarks>
        /// <para>
        /// An in-progress multipart upload is a multipart upload that has been initiated, 
        /// using the InitiateMultipartUpload request, but has not yet been completed or 
        /// aborted.
        /// </para>
        /// <para>
        /// This operation returns at most 1,000 multipart uploads in the 
        /// response by default. The number of multipart uploads can be further 
        /// limited using the MaxUploads property on the request parameter. If there are 
        /// additional multipart uploads that satisfy the list criteria, the 
        /// response will contain an IsTruncated property with the value set to true.
        /// To list the additional multipart uploads use the KeyMarker and 
        /// UploadIdMarker properties on the request parameters.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The ListMultipartUploadsRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a ListMultipartUploadsResponse from S3.</returns>
        ListMultipartUploadsResponse ListMultipartUploads(ListMultipartUploadsRequest request);

        #endregion

        #region PutBucketWebsite

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketWebsite operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketWebsite"/>
        /// </summary>
        /// <param name="request">The PutBucketWebsiteRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutBucketWebsite.</returns>
        IAsyncResult BeginPutBucketWebsite(PutBucketWebsiteRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketWebsite operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketWebsite"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketWebsite.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketWebsiteResponse from S3.</returns>
        PutBucketWebsiteResponse EndPutBucketWebsite(IAsyncResult asyncResult);

        /// <summary>
        /// Enables or configures an S3-based website using the corresponding bucket as the content source. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// The website will have one default domain name associated with it, which is the bucket name.
        /// If you attempt to configure an S3 website for a bucket whose name is not compatible with DNS, 
        /// Amazon S3 returns an InvalidBucketName error. For more information on bucket names and DNS, 
        /// refer to Bucket Restrictions and Limitations.
        /// </para>
        /// <para>
        /// To visit the S3 bucket as a website a new endpoint is created in the following pattern 
        /// http://[bucketName].s3-website-[region].amazonaws.com/. This is a sample url for a bucket
        /// called example-bucket in the us-east-1 region. http://example-bucket.s3-website-us-east-1.amazonaws.com/
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// The PutBucketWebsiteRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a PutBucketWebsiteResponse from S3.</returns>
        PutBucketWebsiteResponse PutBucketWebsite(PutBucketWebsiteRequest request);

        #endregion

        #region GetBucketWebsite
        
        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketWebsite operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketWebsite"/>
        /// </summary>
        /// <param name="request">The GetBucketWebsiteRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketWebsite.</returns>
        IAsyncResult BeginGetBucketWebsite(GetBucketWebsiteRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketWebsite operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketWebsite"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketWebsite.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketWebsiteResponse from S3.</returns>
        GetBucketWebsiteResponse EndGetBucketWebsite(IAsyncResult asyncResult);

        /// <summary>
        /// Retrieves the website configuration for a bucket.
        /// </summary>
        /// <remarks>
        /// The contents of this response is identical to the content submitted by the user during the PutBucketWebsite 
        /// operation if it has ever been configured. 
        /// </remarks>
        /// <param name="request">
        /// The GetBucketWebsiteRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a GetBucketWebsiteResponse from S3.</returns>
        GetBucketWebsiteResponse GetBucketWebsite(GetBucketWebsiteRequest request);

        #endregion

        #region DeleteBucketWebsite

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketWebsite operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketWebsite"/>
        /// </summary>
        /// <param name="request">The DeleteBucketWebsiteRequest that defines the parameters of
        /// the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteBucketWebsite.</returns>
        IAsyncResult BeginDeleteBucketWebsite(DeleteBucketWebsiteRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketWebsite operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketWebsite"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketWebsite.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketWebsiteResponse from S3.</returns>
        DeleteBucketWebsiteResponse EndDeleteBucketWebsite(IAsyncResult asyncResult);

        /// <summary>
        /// Removes the website configuration for a bucket. 
        /// </summary>
        /// <param name="request">
        /// The DeleteBucketWebsiteRequest that defines the parameters of the operation.
        /// </param>
        /// <returns>Returns a DeleteBucketWebsiteResponse from S3.</returns>
        DeleteBucketWebsiteResponse DeleteBucketWebsite(DeleteBucketWebsiteRequest request);

        #endregion

        #region PutLifecycleConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutLifecycleConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutLifecycleConfiguration"/>
        /// </summary>
        /// <param name="request">The PutLifecycleConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutLifecycleConfiguration.</returns>
        IAsyncResult BeginPutLifecycleConfiguration(PutLifecycleConfigurationRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutLifecycleConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutLifecycleConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLifecycleConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutLifecycleConfigurationResponse from S3.</returns>
        PutLifecycleConfigurationResponse EndPutLifecycleConfiguration(IAsyncResult asyncResult);

        /// <summary>
        /// Sets the lifecycle configuration that should be applied to a bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If a configuration already exists for the specified bucket, the new
        /// configuration will replace the existing configuration.
        /// </para>
        /// <para>
        /// Lifecycle configuration provides a way to define the lifetime of
        /// objects for a keyspace. Objects are automatically deleted after the
        /// predefined lifetime.
        /// </para>
        /// <para>
        /// For more information on lifecycle configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The PutLifecycleConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a PutLifecycleConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        PutLifecycleConfigurationResponse PutLifecycleConfiguration(PutLifecycleConfigurationRequest request);

        #endregion

        #region GetLifecycleConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetLifecycleConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetLifecycleConfiguration"/>
        /// </summary>
        /// <param name="request">The GetLifecycleConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetLifecycleConfiguration.</returns>
        IAsyncResult BeginGetLifecycleConfiguration(GetLifecycleConfigurationRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetLifecycleConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetLifecycleConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLifecycleConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetLifecycleConfigurationResponse from S3.</returns>
        GetLifecycleConfigurationResponse EndGetLifecycleConfiguration(IAsyncResult asyncResult);

        /// <summary>
        /// Retrieves the lifecycle configuration for the specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If no configuration has been set for the bucket, the Configuration
        /// property of the response will be null.
        /// </para>
        /// <para>
        /// Lifecycle configuration provides a way to define the lifetime of
        /// objects for a keyspace. Objects are automatically deleted after the
        /// predefined lifetime.
        /// </para>
        /// <para>
        /// For more information on lifecycle configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The GetLifecycleConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetLifecycleConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        GetLifecycleConfigurationResponse GetLifecycleConfiguration(GetLifecycleConfigurationRequest request);

        #endregion

        #region DeleteLifecycleConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLifecycleConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteLifecycleConfiguration"/>
        /// </summary>
        /// <param name="request">The DeleteLifecycleConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteLifecycleConfiguration.</returns>
        IAsyncResult BeginDeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteLifecycleConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteLifecycleConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLifecycleConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteLifecycleConfigurationResponse from S3.</returns>
        DeleteLifecycleConfigurationResponse EndDeleteLifecycleConfiguration(IAsyncResult asyncResult);

        /// <summary>
        /// Deletes the lifecycle configuration for the specified bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you delete a configuration that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </para>
        /// <para>
        /// Lifecycle configuration provides a way to define the lifetime of
        /// objects for a keyspace. Objects are automatically deleted after the
        /// predefined lifetime.
        /// </para>
        /// <para>
        /// For more information on lifecycle configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The DeleteLifecycleConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a DeleteLifecycleConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        DeleteLifecycleConfigurationResponse DeleteLifecycleConfiguration(DeleteLifecycleConfigurationRequest request);

        #endregion

        #region PutBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the PutBucketTagging operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketTagging"/>
        /// </summary>
        /// <param name="request">The PutBucketTaggingRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutBucketTagging.</returns>
        IAsyncResult BeginPutBucketTagging(PutBucketTaggingRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutBucketTagging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutBucketTagging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutBucketTagging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutBucketTaggingResponse from S3.</returns>
        PutBucketTaggingResponse EndPutBucketTagging(IAsyncResult asyncResult);

        /// <summary>
        /// Add a set of tags to a bucket.
        /// </summary>
        /// <remarks>
        /// If tagging already exists for the specified bucket, the new
        /// tagging will replace the existing configuration.
        /// </remarks>
        /// <param name="request">The PutBucketTaggingRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a PutBucketTaggingResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        PutBucketTaggingResponse PutBucketTagging(PutBucketTaggingRequest request);

        #endregion

        #region GetBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the GetBucketTagging operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketTagging"/>
        /// </summary>
        /// <param name="request">The GetBucketTaggingRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetBucketTagging.</returns>
        IAsyncResult BeginGetBucketTagging(GetBucketTaggingRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetBucketTagging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetBucketTagging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetBucketTagging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetBucketTaggingResponse from S3.</returns>
        GetBucketTaggingResponse EndGetBucketTagging(IAsyncResult asyncResult);

        /// <summary>
        /// Retrieves the tags that have been applied to a bucket.
        /// </summary>
        /// <remarks>
        /// If no tags have been set for the bucket, an AmazonS3Exception will be thrown.
        /// </remarks>
        /// <param name="request">The GetBucketTaggingRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetBucketTaggingResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        GetBucketTaggingResponse GetBucketTagging(GetBucketTaggingRequest request);

        #endregion

        #region DeleteBucketTagging

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteBucketTagging operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketTagging"/>
        /// </summary>
        /// <param name="request">The DeleteBucketTaggingRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteBucketTagging.</returns>
        IAsyncResult BeginDeleteBucketTagging(DeleteBucketTaggingRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteBucketTagging operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteBucketTagging"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteBucketTagging.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteBucketTaggingResponse from S3.</returns>
        DeleteBucketTaggingResponse EndDeleteBucketTagging(IAsyncResult asyncResult);

        /// <summary>
        /// Deletes the tags set on a bucket.
        /// </summary>
        /// <remarks>
        /// If you delete a tagging that does not exist yet, Amazon S3 will return a
        /// success (not an error message).
        /// </remarks>
        /// <param name="request">The DeleteBucketTaggingRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a DeleteBucketTaggingResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        DeleteBucketTaggingResponse DeleteBucketTagging(DeleteBucketTaggingRequest request);

        #endregion

        #region PutCORSConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the PutCORSConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutCORSConfiguration"/>
        /// </summary>
        /// <param name="request">The PutCORSConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndPutCORSConfiguration.</returns>
        IAsyncResult BeginPutCORSConfiguration(PutCORSConfigurationRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PutCORSConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.PutCORSConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCORSConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a PutCORSConfigurationResponse from S3.</returns>
        PutCORSConfigurationResponse EndPutCORSConfiguration(IAsyncResult asyncResult);

        /// <summary>
        /// Applies a CORS (cross-origin resource sharing) configuration to a bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// You set this configuration on a bucket so that the bucket can service cross-origin requests.
        /// </para>
        /// <para>
        /// If a configuration already exists for the specified bucket, the new
        /// configuration will replace the existing configuration.
        /// </para>
        /// <para>
        /// For more information on CORS configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The PutCORSConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a PutCORSConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        PutCORSConfigurationResponse PutCORSConfiguration(PutCORSConfigurationRequest request);

        #endregion

        #region GetCORSConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the GetCORSConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetCORSConfiguration"/>
        /// </summary>
        /// <param name="request">The GetCORSConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndGetCORSConfiguration.</returns>
        IAsyncResult BeginGetCORSConfiguration(GetCORSConfigurationRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetCORSConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.GetCORSConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCORSConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a GetCORSConfigurationResponse from S3.</returns>
        GetCORSConfigurationResponse EndGetCORSConfiguration(IAsyncResult asyncResult);

        /// <summary>
        /// Retrieves the CORS (cross-origin resource sharing) configuration for a bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If no configuration has been set for the bucket, the Configuration
        /// property of the response will be null.
        /// </para>
        /// <para>
        /// For more information on CORS configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The GetCORSConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a GetCORSConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        GetCORSConfigurationResponse GetCORSConfiguration(GetCORSConfigurationRequest request);

        #endregion

        #region DeleteCORSConfiguration

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCORSConfiguration operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteCORSConfiguration"/>
        /// </summary>
        /// <param name="request">The DeleteCORSConfigurationRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndDeleteCORSConfiguration.</returns>
        IAsyncResult BeginDeleteCORSConfiguration(DeleteCORSConfigurationRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCORSConfiguration operation.
        /// <seealso cref="M:Amazon.S3.AmazonS3.DeleteCORSConfiguration"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCORSConfiguration.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a DeleteCORSConfigurationResponse from S3.</returns>
        DeleteCORSConfigurationResponse EndDeleteCORSConfiguration(IAsyncResult asyncResult);

        /// <summary>
        /// Deletes the CORS (cross-origin resource sharing) configuration for a bucket.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you delete a configuration that does not exist, Amazon S3 will return a
        /// success (not an error message).
        /// </para>
        /// <para>
        /// For more information on CORS configurations, 
        /// refer: <see href="http://docs.amazonwebservices.com/AmazonS3/latest/dev/"/>
        /// </para>
        /// </remarks>
        /// <param name="request">The DeleteCORSConfigurationRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a DeleteCORSConfigurationResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        DeleteCORSConfigurationResponse DeleteCORSConfiguration(DeleteCORSConfigurationRequest request);

        #endregion

        #region
        /// <summary>
        /// Initiates the asynchronous execution of the RestoreObject operation. 
        /// <seealso cref="M:Amazon.S3.AmazonS3.RestoreObject"/>
        /// </summary>
        /// <param name="request">The RestoreObjectRequest that defines
        /// the parameters of the operation.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; 
        /// this value is also needed when invoking EndRestoreObject.</returns>
        IAsyncResult BeginRestoreObject(RestoreObjectRequest request, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RestoreObject operation.
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreObject.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>Returns a RestoreObjectResponse from S3.</returns>
        RestoreObjectResponse EndRestoreObject(IAsyncResult asyncResult);

        /// <summary>
        /// <para>
        /// This operation begins a restore object request for an object that has been 
        /// stored in Amazon Glacier.  The object will stay active in Amazon S3 for the number
        /// of days set on the RestoreObjectRequest object.
        /// </para>
        /// </summary>
        /// <param name="request">The RestoreObjectRequest that defines the parameters of the operation.</param>
        /// <returns>Returns a RestoreObjectResponse from S3.</returns>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        RestoreObjectResponse RestoreObject(RestoreObjectRequest request);
        #endregion
    }
}