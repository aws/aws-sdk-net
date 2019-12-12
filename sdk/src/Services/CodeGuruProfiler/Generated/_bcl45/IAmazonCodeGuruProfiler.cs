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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.CodeGuruProfiler.Model;

namespace Amazon.CodeGuruProfiler
{
    /// <summary>
    /// Interface for accessing CodeGuruProfiler
    ///
    /// Example service documentation.
    /// </summary>
    public partial interface IAmazonCodeGuruProfiler : IAmazonService, IDisposable
    {

        
        #region  ConfigureAgent


        /// <summary>
        /// Provides the configuration to use for an agent of the profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAgent service method.</param>
        /// 
        /// <returns>The response from the ConfigureAgent service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ConfigureAgent">REST API Reference for ConfigureAgent Operation</seealso>
        ConfigureAgentResponse ConfigureAgent(ConfigureAgentRequest request);



        /// <summary>
        /// Provides the configuration to use for an agent of the profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureAgent service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfigureAgent service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ConfigureAgent">REST API Reference for ConfigureAgent Operation</seealso>
        Task<ConfigureAgentResponse> ConfigureAgentAsync(ConfigureAgentRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateProfilingGroup


        /// <summary>
        /// Create a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the CreateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// Request can can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/CreateProfilingGroup">REST API Reference for CreateProfilingGroup Operation</seealso>
        CreateProfilingGroupResponse CreateProfilingGroup(CreateProfilingGroupRequest request);



        /// <summary>
        /// Create a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfilingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// Request can can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ServiceQuotaExceededException">
        /// Request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/CreateProfilingGroup">REST API Reference for CreateProfilingGroup Operation</seealso>
        Task<CreateProfilingGroupResponse> CreateProfilingGroupAsync(CreateProfilingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteProfilingGroup


        /// <summary>
        /// Delete a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DeleteProfilingGroup">REST API Reference for DeleteProfilingGroup Operation</seealso>
        DeleteProfilingGroupResponse DeleteProfilingGroup(DeleteProfilingGroupRequest request);



        /// <summary>
        /// Delete a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfilingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DeleteProfilingGroup">REST API Reference for DeleteProfilingGroup Operation</seealso>
        Task<DeleteProfilingGroupResponse> DeleteProfilingGroupAsync(DeleteProfilingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeProfilingGroup


        /// <summary>
        /// Describe a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the DescribeProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DescribeProfilingGroup">REST API Reference for DescribeProfilingGroup Operation</seealso>
        DescribeProfilingGroupResponse DescribeProfilingGroup(DescribeProfilingGroupRequest request);



        /// <summary>
        /// Describe a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProfilingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/DescribeProfilingGroup">REST API Reference for DescribeProfilingGroup Operation</seealso>
        Task<DescribeProfilingGroupResponse> DescribeProfilingGroupAsync(DescribeProfilingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetProfile


        /// <summary>
        /// Get the aggregated profile of a profiling group for the specified time range. If the
        /// requested time range does not align with the available aggregated profiles, it will
        /// be expanded to attain alignment. If aggregated profiles are available only for part
        /// of the period requested, the profile is returned from the earliest available to the
        /// latest within the requested time range. For instance, if the requested time range
        /// is from 00:00 to 00:20 and the available profiles are from 00:15 to 00:25, then the
        /// returned profile will be from 00:15 to 00:20.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetProfile">REST API Reference for GetProfile Operation</seealso>
        GetProfileResponse GetProfile(GetProfileRequest request);



        /// <summary>
        /// Get the aggregated profile of a profiling group for the specified time range. If the
        /// requested time range does not align with the available aggregated profiles, it will
        /// be expanded to attain alignment. If aggregated profiles are available only for part
        /// of the period requested, the profile is returned from the earliest available to the
        /// latest within the requested time range. For instance, if the requested time range
        /// is from 00:00 to 00:20 and the available profiles are from 00:15 to 00:25, then the
        /// returned profile will be from 00:15 to 00:20.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/GetProfile">REST API Reference for GetProfile Operation</seealso>
        Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProfileTimes


        /// <summary>
        /// List the start times of the available aggregated profiles of a profiling group for
        /// an aggregation period within the specified time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileTimes service method.</param>
        /// 
        /// <returns>The response from the ListProfileTimes service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfileTimes">REST API Reference for ListProfileTimes Operation</seealso>
        ListProfileTimesResponse ListProfileTimes(ListProfileTimesRequest request);



        /// <summary>
        /// List the start times of the available aggregated profiles of a profiling group for
        /// an aggregation period within the specified time range.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileTimes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfileTimes service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfileTimes">REST API Reference for ListProfileTimes Operation</seealso>
        Task<ListProfileTimesResponse> ListProfileTimesAsync(ListProfileTimesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListProfilingGroups


        /// <summary>
        /// List profiling groups in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfilingGroups service method.</param>
        /// 
        /// <returns>The response from the ListProfilingGroups service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfilingGroups">REST API Reference for ListProfilingGroups Operation</seealso>
        ListProfilingGroupsResponse ListProfilingGroups(ListProfilingGroupsRequest request);



        /// <summary>
        /// List profiling groups in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfilingGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfilingGroups service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/ListProfilingGroups">REST API Reference for ListProfilingGroups Operation</seealso>
        Task<ListProfilingGroupsResponse> ListProfilingGroupsAsync(ListProfilingGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PostAgentProfile


        /// <summary>
        /// Submit profile collected by an agent belonging to a profiling group for aggregation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostAgentProfile service method.</param>
        /// 
        /// <returns>The response from the PostAgentProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PostAgentProfile">REST API Reference for PostAgentProfile Operation</seealso>
        PostAgentProfileResponse PostAgentProfile(PostAgentProfileRequest request);



        /// <summary>
        /// Submit profile collected by an agent belonging to a profiling group for aggregation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostAgentProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostAgentProfile service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/PostAgentProfile">REST API Reference for PostAgentProfile Operation</seealso>
        Task<PostAgentProfileResponse> PostAgentProfileAsync(PostAgentProfileRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateProfilingGroup


        /// <summary>
        /// Update a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfilingGroup service method.</param>
        /// 
        /// <returns>The response from the UpdateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// Request can can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UpdateProfilingGroup">REST API Reference for UpdateProfilingGroup Operation</seealso>
        UpdateProfilingGroupResponse UpdateProfilingGroup(UpdateProfilingGroupRequest request);



        /// <summary>
        /// Update a profiling group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfilingGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProfilingGroup service method, as returned by CodeGuruProfiler.</returns>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ConflictException">
        /// Request can can cause an inconsistent state for the resource.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.InternalServerException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ResourceNotFoundException">
        /// Request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ThrottlingException">
        /// Request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.CodeGuruProfiler.Model.ValidationException">
        /// The input fails to satisfy the constraints of the API.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/codeguruprofiler-2019-07-18/UpdateProfilingGroup">REST API Reference for UpdateProfilingGroup Operation</seealso>
        Task<UpdateProfilingGroupResponse> UpdateProfilingGroupAsync(UpdateProfilingGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}