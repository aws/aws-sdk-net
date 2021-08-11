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
 * Do not modify this file. This file is generated from the snow-device-management-2021-08-04.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.SnowDeviceManagement.Model;

namespace Amazon.SnowDeviceManagement
{
    /// <summary>
    /// Interface for accessing SnowDeviceManagement
    ///
    /// Amazon Web Services Snow Device Management documentation.
    /// </summary>
    public partial interface IAmazonSnowDeviceManagement : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        ISnowDeviceManagementPaginatorFactory Paginators { get; }
#endif


        
        #region  CancelTask


        /// <summary>
        /// Sends a cancel request for a specified task. You can cancel a task only if it's still
        /// in a <code>QUEUED</code> state. Tasks that are already running can't be cancelled.
        /// 
        ///  <note> 
        /// <para>
        /// A task might still run if it's processed from the queue before the <code>CancelTask</code>
        /// operation changes the task's state.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelTask service method.</param>
        /// 
        /// <returns>The response from the CancelTask service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/CancelTask">REST API Reference for CancelTask Operation</seealso>
        CancelTaskResponse CancelTask(CancelTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelTask operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/CancelTask">REST API Reference for CancelTask Operation</seealso>
        IAsyncResult BeginCancelTask(CancelTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelTask.</param>
        /// 
        /// <returns>Returns a  CancelTaskResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/CancelTask">REST API Reference for CancelTask Operation</seealso>
        CancelTaskResponse EndCancelTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTask


        /// <summary>
        /// Instructs one or more devices to start a task, such as unlocking or rebooting.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTask service method.</param>
        /// 
        /// <returns>The response from the CreateTask service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/CreateTask">REST API Reference for CreateTask Operation</seealso>
        CreateTaskResponse CreateTask(CreateTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTask operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/CreateTask">REST API Reference for CreateTask Operation</seealso>
        IAsyncResult BeginCreateTask(CreateTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTask.</param>
        /// 
        /// <returns>Returns a  CreateTaskResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/CreateTask">REST API Reference for CreateTask Operation</seealso>
        CreateTaskResponse EndCreateTask(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDevice


        /// <summary>
        /// Checks device-specific information, such as the device type, software version, IP
        /// addresses, and lock status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice service method.</param>
        /// 
        /// <returns>The response from the DescribeDevice service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        DescribeDeviceResponse DescribeDevice(DescribeDeviceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDevice operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        IAsyncResult BeginDescribeDevice(DescribeDeviceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDevice.</param>
        /// 
        /// <returns>Returns a  DescribeDeviceResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeDevice">REST API Reference for DescribeDevice Operation</seealso>
        DescribeDeviceResponse EndDescribeDevice(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDeviceEc2Instances


        /// <summary>
        /// Checks the current state of the Amazon EC2 instances. The output is similar to <code>describeDevice</code>,
        /// but the results are sourced from the device cache in the Amazon Web Services Cloud
        /// and include a subset of the available fields.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceEc2Instances service method.</param>
        /// 
        /// <returns>The response from the DescribeDeviceEc2Instances service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeDeviceEc2Instances">REST API Reference for DescribeDeviceEc2Instances Operation</seealso>
        DescribeDeviceEc2InstancesResponse DescribeDeviceEc2Instances(DescribeDeviceEc2InstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeviceEc2Instances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeviceEc2Instances operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeviceEc2Instances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeDeviceEc2Instances">REST API Reference for DescribeDeviceEc2Instances Operation</seealso>
        IAsyncResult BeginDescribeDeviceEc2Instances(DescribeDeviceEc2InstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeviceEc2Instances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeviceEc2Instances.</param>
        /// 
        /// <returns>Returns a  DescribeDeviceEc2InstancesResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeDeviceEc2Instances">REST API Reference for DescribeDeviceEc2Instances Operation</seealso>
        DescribeDeviceEc2InstancesResponse EndDescribeDeviceEc2Instances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExecution


        /// <summary>
        /// Checks the status of a remote task running on one or more target devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        IAsyncResult BeginDescribeExecution(DescribeExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExecution.</param>
        /// 
        /// <returns>Returns a  DescribeExecutionResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        DescribeExecutionResponse EndDescribeExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTask


        /// <summary>
        /// Checks the metadata for a given task on a device.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask service method.</param>
        /// 
        /// <returns>The response from the DescribeTask service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        DescribeTaskResponse DescribeTask(DescribeTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTask operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        IAsyncResult BeginDescribeTask(DescribeTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTask.</param>
        /// 
        /// <returns>Returns a  DescribeTaskResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/DescribeTask">REST API Reference for DescribeTask Operation</seealso>
        DescribeTaskResponse EndDescribeTask(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDeviceResources


        /// <summary>
        /// Returns a list of the Amazon Web Services resources available for a device. Currently,
        /// Amazon EC2 instances are the only supported resource type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceResources service method.</param>
        /// 
        /// <returns>The response from the ListDeviceResources service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListDeviceResources">REST API Reference for ListDeviceResources Operation</seealso>
        ListDeviceResourcesResponse ListDeviceResources(ListDeviceResourcesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDeviceResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeviceResources operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDeviceResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListDeviceResources">REST API Reference for ListDeviceResources Operation</seealso>
        IAsyncResult BeginListDeviceResources(ListDeviceResourcesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDeviceResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDeviceResources.</param>
        /// 
        /// <returns>Returns a  ListDeviceResourcesResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListDeviceResources">REST API Reference for ListDeviceResources Operation</seealso>
        ListDeviceResourcesResponse EndListDeviceResources(IAsyncResult asyncResult);

        #endregion
        
        #region  ListDevices


        /// <summary>
        /// Returns a list of all devices on your Amazon Web Services account that have Amazon
        /// Web Services Snow Device Management enabled in the Amazon Web Services Region where
        /// the command is run.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDevices service method.</param>
        /// 
        /// <returns>The response from the ListDevices service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse ListDevices(ListDevicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDevices operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListDevices">REST API Reference for ListDevices Operation</seealso>
        IAsyncResult BeginListDevices(ListDevicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListDevices.</param>
        /// 
        /// <returns>Returns a  ListDevicesResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListDevices">REST API Reference for ListDevices Operation</seealso>
        ListDevicesResponse EndListDevices(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExecutions


        /// <summary>
        /// Returns the status of tasks for one or more target devices.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        ListExecutionsResponse ListExecutions(ListExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        IAsyncResult BeginListExecutions(ListExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExecutions.</param>
        /// 
        /// <returns>Returns a  ListExecutionsResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        ListExecutionsResponse EndListExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Returns a list of tags for a managed device or task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTasks


        /// <summary>
        /// Returns a list of tasks that can be filtered by state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTasks service method.</param>
        /// 
        /// <returns>The response from the ListTasks service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.AccessDeniedException">
        /// You don't have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListTasks">REST API Reference for ListTasks Operation</seealso>
        ListTasksResponse ListTasks(ListTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTasks operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListTasks">REST API Reference for ListTasks Operation</seealso>
        IAsyncResult BeginListTasks(ListTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTasks.</param>
        /// 
        /// <returns>Returns a  ListTasksResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/ListTasks">REST API Reference for ListTasks Operation</seealso>
        ListTasksResponse EndListTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Adds or replaces tags on a device or task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes a tag from a device or task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SnowDeviceManagement.</returns>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.InternalServerException">
        /// An unexpected error occurred while processing the request.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ResourceNotFoundException">
        /// The request references a resource that doesn't exist.
        /// </exception>
        /// <exception cref="Amazon.SnowDeviceManagement.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonSnowDeviceManagementClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from SnowDeviceManagement.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/snow-device-management-2021-08-04/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
    }
}