/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the scheduler-2021-06-30.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Scheduler.Model;

#pragma warning disable CS1570
namespace Amazon.Scheduler
{
    /// <summary>
    /// <para>Interface for accessing Scheduler</para>
    ///
    /// Amazon EventBridge Scheduler is a serverless scheduler that allows you to create,
    /// run, and manage tasks from one central, managed service. EventBridge Scheduler delivers
    /// your tasks reliably, with built-in mechanisms that adjust your schedules based on
    /// the availability of downstream targets. The following reference lists the available
    /// API actions, and data types for EventBridge Scheduler.
    /// </summary>
    public partial interface IAmazonScheduler : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISchedulerPaginatorFactory Paginators { get; }

        
        #region  CreateSchedule


        /// <summary>
        /// Creates the specified schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedule service method.</param>
        /// 
        /// <returns>The response from the CreateSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/CreateSchedule">REST API Reference for CreateSchedule Operation</seealso>
        CreateScheduleResponse CreateSchedule(CreateScheduleRequest request);



        /// <summary>
        /// Creates the specified schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/CreateSchedule">REST API Reference for CreateSchedule Operation</seealso>
        Task<CreateScheduleResponse> CreateScheduleAsync(CreateScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateScheduleGroup


        /// <summary>
        /// Creates the specified schedule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduleGroup service method.</param>
        /// 
        /// <returns>The response from the CreateScheduleGroup service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/CreateScheduleGroup">REST API Reference for CreateScheduleGroup Operation</seealso>
        CreateScheduleGroupResponse CreateScheduleGroup(CreateScheduleGroupRequest request);



        /// <summary>
        /// Creates the specified schedule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateScheduleGroup service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ServiceQuotaExceededException">
        /// The request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/CreateScheduleGroup">REST API Reference for CreateScheduleGroup Operation</seealso>
        Task<CreateScheduleGroupResponse> CreateScheduleGroupAsync(CreateScheduleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSchedule


        /// <summary>
        /// Deletes the specified schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule service method.</param>
        /// 
        /// <returns>The response from the DeleteSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        DeleteScheduleResponse DeleteSchedule(DeleteScheduleRequest request);



        /// <summary>
        /// Deletes the specified schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        Task<DeleteScheduleResponse> DeleteScheduleAsync(DeleteScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteScheduleGroup


        /// <summary>
        /// Deletes the specified schedule group. Deleting a schedule group results in EventBridge
        /// Scheduler deleting all schedules associated with the group. When you delete a group,
        /// it remains in a <c>DELETING</c> state until all of its associated schedules are deleted.
        /// Schedules associated with the group that are set to run while the schedule group is
        /// in the process of being deleted might continue to invoke their targets until the schedule
        /// group and its associated schedules are deleted.
        /// 
        ///  <note> 
        /// <para>
        ///  This operation is eventually consistent. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduleGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteScheduleGroup service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/DeleteScheduleGroup">REST API Reference for DeleteScheduleGroup Operation</seealso>
        DeleteScheduleGroupResponse DeleteScheduleGroup(DeleteScheduleGroupRequest request);



        /// <summary>
        /// Deletes the specified schedule group. Deleting a schedule group results in EventBridge
        /// Scheduler deleting all schedules associated with the group. When you delete a group,
        /// it remains in a <c>DELETING</c> state until all of its associated schedules are deleted.
        /// Schedules associated with the group that are set to run while the schedule group is
        /// in the process of being deleted might continue to invoke their targets until the schedule
        /// group and its associated schedules are deleted.
        /// 
        ///  <note> 
        /// <para>
        ///  This operation is eventually consistent. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteScheduleGroup service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/DeleteScheduleGroup">REST API Reference for DeleteScheduleGroup Operation</seealso>
        Task<DeleteScheduleGroupResponse> DeleteScheduleGroupAsync(DeleteScheduleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetSchedule


        /// <summary>
        /// Retrieves the specified schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchedule service method.</param>
        /// 
        /// <returns>The response from the GetSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/GetSchedule">REST API Reference for GetSchedule Operation</seealso>
        GetScheduleResponse GetSchedule(GetScheduleRequest request);



        /// <summary>
        /// Retrieves the specified schedule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/GetSchedule">REST API Reference for GetSchedule Operation</seealso>
        Task<GetScheduleResponse> GetScheduleAsync(GetScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetScheduleGroup


        /// <summary>
        /// Retrieves the specified schedule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScheduleGroup service method.</param>
        /// 
        /// <returns>The response from the GetScheduleGroup service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/GetScheduleGroup">REST API Reference for GetScheduleGroup Operation</seealso>
        GetScheduleGroupResponse GetScheduleGroup(GetScheduleGroupRequest request);



        /// <summary>
        /// Retrieves the specified schedule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetScheduleGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetScheduleGroup service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/GetScheduleGroup">REST API Reference for GetScheduleGroup Operation</seealso>
        Task<GetScheduleGroupResponse> GetScheduleGroupAsync(GetScheduleGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListScheduleGroups


        /// <summary>
        /// Returns a paginated list of your schedule groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduleGroups service method.</param>
        /// 
        /// <returns>The response from the ListScheduleGroups service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListScheduleGroups">REST API Reference for ListScheduleGroups Operation</seealso>
        ListScheduleGroupsResponse ListScheduleGroups(ListScheduleGroupsRequest request);



        /// <summary>
        /// Returns a paginated list of your schedule groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListScheduleGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListScheduleGroups service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListScheduleGroups">REST API Reference for ListScheduleGroups Operation</seealso>
        Task<ListScheduleGroupsResponse> ListScheduleGroupsAsync(ListScheduleGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListSchedules


        /// <summary>
        /// Returns a paginated list of your EventBridge Scheduler schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchedules service method.</param>
        /// 
        /// <returns>The response from the ListSchedules service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListSchedules">REST API Reference for ListSchedules Operation</seealso>
        ListSchedulesResponse ListSchedules(ListSchedulesRequest request);



        /// <summary>
        /// Returns a paginated list of your EventBridge Scheduler schedules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSchedules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSchedules service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListSchedules">REST API Reference for ListSchedules Operation</seealso>
        Task<ListSchedulesResponse> ListSchedulesAsync(ListSchedulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists the tags associated with the Scheduler resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Lists the tags associated with the Scheduler resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified EventBridge Scheduler
        /// resource. You can only assign tags to schedule groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified EventBridge Scheduler
        /// resource. You can only assign tags to schedule groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified EventBridge Scheduler schedule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from the specified EventBridge Scheduler schedule group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateSchedule


        /// <summary>
        /// Updates the specified schedule. When you call <c>UpdateSchedule</c>, EventBridge
        /// Scheduler uses all values, including empty values, specified in the request and overrides
        /// the existing schedule. This is by design. This means that if you do not set an optional
        /// field in your request, that field will be set to its system-default value after the
        /// update. 
        /// 
        ///  
        /// <para>
        ///  Before calling this operation, we recommend that you call the <c>GetSchedule</c>
        /// API operation and make a note of all optional parameters for your <c>UpdateSchedule</c>
        /// call. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedule service method.</param>
        /// 
        /// <returns>The response from the UpdateSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/UpdateSchedule">REST API Reference for UpdateSchedule Operation</seealso>
        UpdateScheduleResponse UpdateSchedule(UpdateScheduleRequest request);



        /// <summary>
        /// Updates the specified schedule. When you call <c>UpdateSchedule</c>, EventBridge
        /// Scheduler uses all values, including empty values, specified in the request and overrides
        /// the existing schedule. This is by design. This means that if you do not set an optional
        /// field in your request, that field will be set to its system-default value after the
        /// update. 
        /// 
        ///  
        /// <para>
        ///  Before calling this operation, we recommend that you call the <c>GetSchedule</c>
        /// API operation and make a note of all optional parameters for your <c>UpdateSchedule</c>
        /// call. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSchedule service method, as returned by Scheduler.</returns>
        /// <exception cref="Amazon.Scheduler.Model.ConflictException">
        /// Updating or deleting the resource can cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.InternalServerException">
        /// Unexpected error encountered while processing the request.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ResourceNotFoundException">
        /// The request references a resource which does not exist.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Scheduler.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an AWS service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/UpdateSchedule">REST API Reference for UpdateSchedule Operation</seealso>
        Task<UpdateScheduleResponse> UpdateScheduleAsync(UpdateScheduleRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
                
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request);
        
        #endregion

    }
}