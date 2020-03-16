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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.S3Control.Model;

namespace Amazon.S3Control
{
    /// <summary>
    /// Interface for accessing S3Control
    ///
    /// AWS S3 Control provides access to Amazon S3 control plane operations.
    /// </summary>
    public partial interface IAmazonS3Control : IAmazonService, IDisposable
    {

        
        #region  CreateAccessPoint


        /// <summary>
        /// Creates an access point and associates it with the specified bucket.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPoint service method.</param>
        /// 
        /// <returns>The response from the CreateAccessPoint service method, as returned by S3Control.</returns>
        CreateAccessPointResponse CreateAccessPoint(CreateAccessPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAccessPoint operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateAccessPoint
        ///         operation.</returns>
        IAsyncResult BeginCreateAccessPoint(CreateAccessPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateAccessPoint.</param>
        /// 
        /// <returns>Returns a  CreateAccessPointResult from S3Control.</returns>
        CreateAccessPointResponse EndCreateAccessPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateJob


        /// <summary>
        /// Creates an Amazon S3 batch operations job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateJob service method.</param>
        /// 
        /// <returns>The response from the CreateJob service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.IdempotencyException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        CreateJobResponse CreateJob(CreateJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateJob operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateJob
        ///         operation.</returns>
        IAsyncResult BeginCreateJob(CreateJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateJob.</param>
        /// 
        /// <returns>Returns a  CreateJobResult from S3Control.</returns>
        CreateJobResponse EndCreateJob(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessPoint


        /// <summary>
        /// Deletes the specified access point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPoint service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPoint service method, as returned by S3Control.</returns>
        DeleteAccessPointResponse DeleteAccessPoint(DeleteAccessPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPoint operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessPoint
        ///         operation.</returns>
        IAsyncResult BeginDeleteAccessPoint(DeleteAccessPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessPoint.</param>
        /// 
        /// <returns>Returns a  DeleteAccessPointResult from S3Control.</returns>
        DeleteAccessPointResponse EndDeleteAccessPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteAccessPointPolicy


        /// <summary>
        /// Deletes the access point policy for the specified access point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccessPointPolicy service method, as returned by S3Control.</returns>
        DeleteAccessPointPolicyResponse DeleteAccessPointPolicy(DeleteAccessPointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccessPointPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccessPointPolicy
        ///         operation.</returns>
        IAsyncResult BeginDeleteAccessPointPolicy(DeleteAccessPointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccessPointPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAccessPointPolicyResult from S3Control.</returns>
        DeleteAccessPointPolicyResponse EndDeleteAccessPointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteJobTagging


        /// <summary>
        /// Delete the tags on a Amazon S3 batch operations job, if any.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTagging service method.</param>
        /// 
        /// <returns>The response from the DeleteJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        DeleteJobTaggingResponse DeleteJobTagging(DeleteJobTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteJobTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteJobTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteJobTagging
        ///         operation.</returns>
        IAsyncResult BeginDeleteJobTagging(DeleteJobTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteJobTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteJobTagging.</param>
        /// 
        /// <returns>Returns a  DeleteJobTaggingResult from S3Control.</returns>
        DeleteJobTaggingResponse EndDeleteJobTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePublicAccessBlock


        /// <summary>
        /// Removes the <code>PublicAccessBlock</code> configuration for an Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the DeletePublicAccessBlock service method, as returned by S3Control.</returns>
        DeletePublicAccessBlockResponse DeletePublicAccessBlock(DeletePublicAccessBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePublicAccessBlock operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePublicAccessBlock
        ///         operation.</returns>
        IAsyncResult BeginDeletePublicAccessBlock(DeletePublicAccessBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePublicAccessBlock.</param>
        /// 
        /// <returns>Returns a  DeletePublicAccessBlockResult from S3Control.</returns>
        DeletePublicAccessBlockResponse EndDeletePublicAccessBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeJob


        /// <summary>
        /// Retrieves the configuration parameters and status for a batch operations job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob service method.</param>
        /// 
        /// <returns>The response from the DescribeJob service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        DescribeJobResponse DescribeJob(DescribeJobRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeJob operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeJob
        ///         operation.</returns>
        IAsyncResult BeginDescribeJob(DescribeJobRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeJob operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeJob.</param>
        /// 
        /// <returns>Returns a  DescribeJobResult from S3Control.</returns>
        DescribeJobResponse EndDescribeJob(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPoint


        /// <summary>
        /// Returns configuration information about the specified access point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPoint service method.</param>
        /// 
        /// <returns>The response from the GetAccessPoint service method, as returned by S3Control.</returns>
        GetAccessPointResponse GetAccessPoint(GetAccessPointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPoint operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPoint
        ///         operation.</returns>
        IAsyncResult BeginGetAccessPoint(GetAccessPointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPoint.</param>
        /// 
        /// <returns>Returns a  GetAccessPointResult from S3Control.</returns>
        GetAccessPointResponse EndGetAccessPoint(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPointPolicy


        /// <summary>
        /// Returns the access point policy associated with the specified access point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointPolicy service method, as returned by S3Control.</returns>
        GetAccessPointPolicyResponse GetAccessPointPolicy(GetAccessPointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPointPolicy
        ///         operation.</returns>
        IAsyncResult BeginGetAccessPointPolicy(GetAccessPointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPointPolicy.</param>
        /// 
        /// <returns>Returns a  GetAccessPointPolicyResult from S3Control.</returns>
        GetAccessPointPolicyResponse EndGetAccessPointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  GetAccessPointPolicyStatus


        /// <summary>
        /// Indicates whether the specified access point currently has a policy that allows public
        /// access. For more information about public access through access points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-points.html">Managing
        /// Data Access with Amazon S3 Access Points</a> in the <i>Amazon Simple Storage Service
        /// Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyStatus service method.</param>
        /// 
        /// <returns>The response from the GetAccessPointPolicyStatus service method, as returned by S3Control.</returns>
        GetAccessPointPolicyStatusResponse GetAccessPointPolicyStatus(GetAccessPointPolicyStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccessPointPolicyStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccessPointPolicyStatus operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccessPointPolicyStatus
        ///         operation.</returns>
        IAsyncResult BeginGetAccessPointPolicyStatus(GetAccessPointPolicyStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccessPointPolicyStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccessPointPolicyStatus.</param>
        /// 
        /// <returns>Returns a  GetAccessPointPolicyStatusResult from S3Control.</returns>
        GetAccessPointPolicyStatusResponse EndGetAccessPointPolicyStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  GetJobTagging


        /// <summary>
        /// Retrieve the tags on a Amazon S3 batch operations job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJobTagging service method.</param>
        /// 
        /// <returns>The response from the GetJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        GetJobTaggingResponse GetJobTagging(GetJobTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetJobTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetJobTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetJobTagging
        ///         operation.</returns>
        IAsyncResult BeginGetJobTagging(GetJobTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetJobTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetJobTagging.</param>
        /// 
        /// <returns>Returns a  GetJobTaggingResult from S3Control.</returns>
        GetJobTaggingResponse EndGetJobTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPublicAccessBlock


        /// <summary>
        /// Retrieves the <code>PublicAccessBlock</code> configuration for an Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the GetPublicAccessBlock service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.NoSuchPublicAccessBlockConfigurationException">
        /// Amazon S3 throws this exception if you make a <code>GetPublicAccessBlock</code> request
        /// against an account that doesn't have a <code>PublicAccessBlockConfiguration</code>
        /// set.
        /// </exception>
        GetPublicAccessBlockResponse GetPublicAccessBlock(GetPublicAccessBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPublicAccessBlock operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPublicAccessBlock
        ///         operation.</returns>
        IAsyncResult BeginGetPublicAccessBlock(GetPublicAccessBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPublicAccessBlock.</param>
        /// 
        /// <returns>Returns a  GetPublicAccessBlockResult from S3Control.</returns>
        GetPublicAccessBlockResponse EndGetPublicAccessBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  ListAccessPoints


        /// <summary>
        /// Returns a list of the access points currently associated with the specified bucket.
        /// You can retrieve up to 1000 access points per call. If the specified bucket has more
        /// than 1000 access points (or the number specified in <code>maxResults</code>, whichever
        /// is less), then the response will include a continuation token that you can use to
        /// list the additional access points.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPoints service method.</param>
        /// 
        /// <returns>The response from the ListAccessPoints service method, as returned by S3Control.</returns>
        ListAccessPointsResponse ListAccessPoints(ListAccessPointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListAccessPoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAccessPoints operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAccessPoints
        ///         operation.</returns>
        IAsyncResult BeginListAccessPoints(ListAccessPointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListAccessPoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAccessPoints.</param>
        /// 
        /// <returns>Returns a  ListAccessPointsResult from S3Control.</returns>
        ListAccessPointsResponse EndListAccessPoints(IAsyncResult asyncResult);

        #endregion
        
        #region  ListJobs


        /// <summary>
        /// Lists current jobs and jobs that have ended within the last 30 days for the AWS account
        /// making the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InvalidNextTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InvalidRequestException">
        /// 
        /// </exception>
        ListJobsResponse ListJobs(ListJobsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListJobs operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListJobs
        ///         operation.</returns>
        IAsyncResult BeginListJobs(ListJobsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListJobs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListJobs.</param>
        /// 
        /// <returns>Returns a  ListJobsResult from S3Control.</returns>
        ListJobsResponse EndListJobs(IAsyncResult asyncResult);

        #endregion
        
        #region  PutAccessPointPolicy


        /// <summary>
        /// Associates an access policy with the specified access point. Each access point can
        /// have only one policy, so a request made to this API replaces any existing policy associated
        /// with the specified access point.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointPolicy service method.</param>
        /// 
        /// <returns>The response from the PutAccessPointPolicy service method, as returned by S3Control.</returns>
        PutAccessPointPolicyResponse PutAccessPointPolicy(PutAccessPointPolicyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccessPointPolicy operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccessPointPolicy
        ///         operation.</returns>
        IAsyncResult BeginPutAccessPointPolicy(PutAccessPointPolicyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccessPointPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccessPointPolicy.</param>
        /// 
        /// <returns>Returns a  PutAccessPointPolicyResult from S3Control.</returns>
        PutAccessPointPolicyResponse EndPutAccessPointPolicy(IAsyncResult asyncResult);

        #endregion
        
        #region  PutJobTagging


        /// <summary>
        /// Replace the set of tags on a Amazon S3 batch operations job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutJobTagging service method.</param>
        /// 
        /// <returns>The response from the PutJobTagging service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyTagsException">
        /// 
        /// </exception>
        PutJobTaggingResponse PutJobTagging(PutJobTaggingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutJobTagging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutJobTagging operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutJobTagging
        ///         operation.</returns>
        IAsyncResult BeginPutJobTagging(PutJobTaggingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutJobTagging operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutJobTagging.</param>
        /// 
        /// <returns>Returns a  PutJobTaggingResult from S3Control.</returns>
        PutJobTaggingResponse EndPutJobTagging(IAsyncResult asyncResult);

        #endregion
        
        #region  PutPublicAccessBlock


        /// <summary>
        /// Creates or modifies the <code>PublicAccessBlock</code> configuration for an Amazon
        /// Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock service method.</param>
        /// 
        /// <returns>The response from the PutPublicAccessBlock service method, as returned by S3Control.</returns>
        PutPublicAccessBlockResponse PutPublicAccessBlock(PutPublicAccessBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PutPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutPublicAccessBlock operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutPublicAccessBlock
        ///         operation.</returns>
        IAsyncResult BeginPutPublicAccessBlock(PutPublicAccessBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PutPublicAccessBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutPublicAccessBlock.</param>
        /// 
        /// <returns>Returns a  PutPublicAccessBlockResult from S3Control.</returns>
        PutPublicAccessBlockResponse EndPutPublicAccessBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateJobPriority


        /// <summary>
        /// Updates an existing job's priority.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobPriority service method.</param>
        /// 
        /// <returns>The response from the UpdateJobPriority service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        UpdateJobPriorityResponse UpdateJobPriority(UpdateJobPriorityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJobPriority operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobPriority operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJobPriority
        ///         operation.</returns>
        IAsyncResult BeginUpdateJobPriority(UpdateJobPriorityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJobPriority operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJobPriority.</param>
        /// 
        /// <returns>Returns a  UpdateJobPriorityResult from S3Control.</returns>
        UpdateJobPriorityResponse EndUpdateJobPriority(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateJobStatus


        /// <summary>
        /// Updates the status for the specified job. Use this operation to confirm that you want
        /// to run a job or to cancel an existing job.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobStatus service method.</param>
        /// 
        /// <returns>The response from the UpdateJobStatus service method, as returned by S3Control.</returns>
        /// <exception cref="Amazon.S3Control.Model.BadRequestException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.InternalServiceException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.JobStatusException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.NotFoundException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.S3Control.Model.TooManyRequestsException">
        /// 
        /// </exception>
        UpdateJobStatusResponse UpdateJobStatus(UpdateJobStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateJobStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateJobStatus operation on AmazonS3ControlClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateJobStatus
        ///         operation.</returns>
        IAsyncResult BeginUpdateJobStatus(UpdateJobStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateJobStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateJobStatus.</param>
        /// 
        /// <returns>Returns a  UpdateJobStatusResult from S3Control.</returns>
        UpdateJobStatusResponse EndUpdateJobStatus(IAsyncResult asyncResult);

        #endregion
        
    }
}