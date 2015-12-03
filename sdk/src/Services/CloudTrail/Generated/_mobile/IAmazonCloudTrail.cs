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
 * Do not modify this file. This file is generated from the cloudtrail-2013-11-01.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudTrail.Model;

namespace Amazon.CloudTrail
{
    /// <summary>
    /// Interface for accessing CloudTrail
    ///
    /// AWS CloudTrail 
    /// <para>
    /// This is the CloudTrail API Reference. It provides descriptions of actions, data types,
    /// common parameters, and common errors for CloudTrail.
    /// </para>
    ///  
    /// <para>
    /// CloudTrail is a web service that records AWS API calls for your AWS account and delivers
    /// log files to an Amazon S3 bucket. The recorded information includes the identity of
    /// the user, the start time of the AWS API call, the source IP address, the request parameters,
    /// and the response elements returned by the service.
    /// </para>
    ///  <note> As an alternative to using the API, you can use one of the AWS SDKs, which
    /// consist of libraries and sample code for various programming languages and platforms
    /// (Java, Ruby, .NET, iOS, Android, etc.). The SDKs provide a convenient way to create
    /// programmatic access to AWSCloudTrail. For example, the SDKs take care of cryptographically
    /// signing requests, managing errors, and retrying requests automatically. For information
    /// about the AWS SDKs, including how to download and install them, see the <a href="http://aws.amazon.com/tools/">Tools
    /// for Amazon Web Services page</a>. </note> 
    /// <para>
    /// See the CloudTrail User Guide for information about the data that is included with
    /// each AWS API call listed in the log files.
    /// </para>
    /// </summary>
    public partial interface IAmazonCloudTrail : IDisposable
    {
                
        #region  AddTags


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  CreateTrail


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTrail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTrailResponse> CreateTrailAsync(CreateTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DeleteTrail


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTrailResponse> DeleteTrailAsync(DeleteTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  DescribeTrails


        /// <summary>
        /// Retrieves settings for the trail associated with the current region for your account.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTrails service method, as returned by CloudTrail.</returns>
        /// <exception cref="Amazon.CloudTrail.Model.OperationNotPermittedException">
        /// This exception is thrown when the requested operation is not permitted.
        /// </exception>
        /// <exception cref="Amazon.CloudTrail.Model.UnsupportedOperationException">
        /// This exception is thrown when the requested operation is not supported. For example,
        /// this exception will occur if an attempt is made to tag a trail and tagging is not
        /// supported in the current region.
        /// </exception>
        Task<DescribeTrailsResponse> DescribeTrailsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTrails operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTrails operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTrailsResponse> DescribeTrailsAsync(DescribeTrailsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  GetTrailStatus


        /// <summary>
        /// Initiates the asynchronous execution of the GetTrailStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTrailStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetTrailStatusResponse> GetTrailStatusAsync(GetTrailStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListPublicKeys


        /// <summary>
        /// Initiates the asynchronous execution of the ListPublicKeys operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPublicKeys operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListPublicKeysResponse> ListPublicKeysAsync(ListPublicKeysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  ListTags


        /// <summary>
        /// Initiates the asynchronous execution of the ListTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ListTagsResponse> ListTagsAsync(ListTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  LookupEvents


        /// <summary>
        /// Initiates the asynchronous execution of the LookupEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the LookupEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<LookupEventsResponse> LookupEventsAsync(LookupEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  RemoveTags


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StartLogging


        /// <summary>
        /// Initiates the asynchronous execution of the StartLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StartLoggingResponse> StartLoggingAsync(StartLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  StopLogging


        /// <summary>
        /// Initiates the asynchronous execution of the StopLogging operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopLogging operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<StopLoggingResponse> StopLoggingAsync(StopLoggingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region  UpdateTrail


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTrail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrail operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<UpdateTrailResponse> UpdateTrailAsync(UpdateTrailRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}