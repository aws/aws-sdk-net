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
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.Scheduler.Model;

namespace Amazon.Scheduler
{
    /// <summary>
    /// Interface for accessing Scheduler
    ///
    /// Amazon EventBridge Scheduler is a serverless scheduler that allows you to create,
    /// run, and manage tasks from one central, managed service. EventBridge Scheduler delivers
    /// your tasks reliably, with built-in mechanisms that adjust your schedules based on
    /// the availability of downstream targets. The following reference lists the available
    /// API actions, and data types for EventBridge Scheduler.
    /// </summary>
    public partial interface IAmazonScheduler : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISchedulerPaginatorFactory Paginators { get; }
#endif


        
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
        /// Initiates the asynchronous execution of the CreateSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSchedule operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/CreateSchedule">REST API Reference for CreateSchedule Operation</seealso>
        IAsyncResult BeginCreateSchedule(CreateScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSchedule.</param>
        /// 
        /// <returns>Returns a  CreateScheduleResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/CreateSchedule">REST API Reference for CreateSchedule Operation</seealso>
        CreateScheduleResponse EndCreateSchedule(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the CreateScheduleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateScheduleGroup operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateScheduleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/CreateScheduleGroup">REST API Reference for CreateScheduleGroup Operation</seealso>
        IAsyncResult BeginCreateScheduleGroup(CreateScheduleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateScheduleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateScheduleGroup.</param>
        /// 
        /// <returns>Returns a  CreateScheduleGroupResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/CreateScheduleGroup">REST API Reference for CreateScheduleGroup Operation</seealso>
        CreateScheduleGroupResponse EndCreateScheduleGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the DeleteSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSchedule operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        IAsyncResult BeginDeleteSchedule(DeleteScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSchedule.</param>
        /// 
        /// <returns>Returns a  DeleteScheduleResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/DeleteSchedule">REST API Reference for DeleteSchedule Operation</seealso>
        DeleteScheduleResponse EndDeleteSchedule(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteScheduleGroup


        /// <summary>
        /// Deletes the specified schedule group. Deleting a schedule group results in EventBridge
        /// Scheduler deleting all schedules associated with the group. When you delete a group,
        /// it remains in a <code>DELETING</code> state until all of its associated schedules
        /// are deleted. Schedules associated with the group that are set to run while the schedule
        /// group is in the process of being deleted might continue to invoke their targets until
        /// the schedule group and its associated schedules are deleted.
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
        /// Initiates the asynchronous execution of the DeleteScheduleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteScheduleGroup operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteScheduleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/DeleteScheduleGroup">REST API Reference for DeleteScheduleGroup Operation</seealso>
        IAsyncResult BeginDeleteScheduleGroup(DeleteScheduleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteScheduleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteScheduleGroup.</param>
        /// 
        /// <returns>Returns a  DeleteScheduleGroupResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/DeleteScheduleGroup">REST API Reference for DeleteScheduleGroup Operation</seealso>
        DeleteScheduleGroupResponse EndDeleteScheduleGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSchedule operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/GetSchedule">REST API Reference for GetSchedule Operation</seealso>
        IAsyncResult BeginGetSchedule(GetScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSchedule.</param>
        /// 
        /// <returns>Returns a  GetScheduleResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/GetSchedule">REST API Reference for GetSchedule Operation</seealso>
        GetScheduleResponse EndGetSchedule(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the GetScheduleGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetScheduleGroup operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetScheduleGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/GetScheduleGroup">REST API Reference for GetScheduleGroup Operation</seealso>
        IAsyncResult BeginGetScheduleGroup(GetScheduleGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetScheduleGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetScheduleGroup.</param>
        /// 
        /// <returns>Returns a  GetScheduleGroupResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/GetScheduleGroup">REST API Reference for GetScheduleGroup Operation</seealso>
        GetScheduleGroupResponse EndGetScheduleGroup(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListScheduleGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListScheduleGroups operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListScheduleGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListScheduleGroups">REST API Reference for ListScheduleGroups Operation</seealso>
        IAsyncResult BeginListScheduleGroups(ListScheduleGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListScheduleGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListScheduleGroups.</param>
        /// 
        /// <returns>Returns a  ListScheduleGroupsResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListScheduleGroups">REST API Reference for ListScheduleGroups Operation</seealso>
        ListScheduleGroupsResponse EndListScheduleGroups(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListSchedules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSchedules operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSchedules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListSchedules">REST API Reference for ListSchedules Operation</seealso>
        IAsyncResult BeginListSchedules(ListSchedulesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListSchedules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSchedules.</param>
        /// 
        /// <returns>Returns a  ListSchedulesResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListSchedules">REST API Reference for ListSchedules Operation</seealso>
        ListSchedulesResponse EndListSchedules(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSchedule


        /// <summary>
        /// Updates the specified schedule. When you call <code>UpdateSchedule</code>, EventBridge
        /// Scheduler uses all values, including empty values, specified in the request and overrides
        /// the existing schedule. This is by design. This means that if you do not set an optional
        /// field in your request, that field will be set to its system-default value after the
        /// update. 
        /// 
        ///  
        /// <para>
        ///  Before calling this operation, we recommend that you call the <code>GetSchedule</code>
        /// API operation and make a note of all optional parameters for your <code>UpdateSchedule</code>
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
        /// Initiates the asynchronous execution of the UpdateSchedule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSchedule operation on AmazonSchedulerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSchedule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/UpdateSchedule">REST API Reference for UpdateSchedule Operation</seealso>
        IAsyncResult BeginUpdateSchedule(UpdateScheduleRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSchedule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSchedule.</param>
        /// 
        /// <returns>Returns a  UpdateScheduleResult from Scheduler.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/scheduler-2021-06-30/UpdateSchedule">REST API Reference for UpdateSchedule Operation</seealso>
        UpdateScheduleResponse EndUpdateSchedule(IAsyncResult asyncResult);

        #endregion
        
    }
}