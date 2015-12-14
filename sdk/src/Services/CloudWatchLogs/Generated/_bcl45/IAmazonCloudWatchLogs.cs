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
 * Do not modify this file. This file is generated from the logs-2014-03-28.normal.json service model.
 */


using System;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.CloudWatchLogs.Model;

namespace Amazon.CloudWatchLogs
{
    /// <summary>
    /// Interface for accessing CloudWatchLogs
    ///
    /// Amazon CloudWatch Logs API Reference 
    /// <para>
    /// This is the <i>Amazon CloudWatch Logs API Reference</i>. Amazon CloudWatch Logs enables
    /// you to monitor, store, and access your system, application, and custom log files.
    /// This guide provides detailed information about Amazon CloudWatch Logs actions, data
    /// types, parameters, and errors. For detailed information about Amazon CloudWatch Logs
    /// features and their associated API calls, go to the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide">Amazon
    /// CloudWatch Developer Guide</a>. 
    /// </para>
    ///  
    /// <para>
    /// Use the following links to get started using the <i>Amazon CloudWatch Logs API Reference</i>:
    /// </para>
    ///  <ul> <li><a href="http://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_Operations.html">Actions</a>:
    /// An alphabetical list of all Amazon CloudWatch Logs actions.</li> <li><a href="http://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_Types.html">Data
    /// Types</a>: An alphabetical list of all Amazon CloudWatch Logs data types.</li> <li><a
    /// href="http://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/CommonParameters.html">Common
    /// Parameters</a>: Parameters that all Query actions can use.</li> <li><a href="http://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/CommonErrors.html">Common
    /// Errors</a>: Client and server errors that all actions can return.</li> <li><a href="http://docs.aws.amazon.com/general/latest/gr/index.html?rande.html">Regions
    /// and Endpoints</a>: Itemized regions and endpoints for all AWS products.</li> </ul>
    /// 
    /// <para>
    /// In addition to using the Amazon CloudWatch Logs API, you can also use the following
    /// SDKs and third-party libraries to access Amazon CloudWatch Logs programmatically.
    /// </para>
    ///  <ul> <li><a href="http://aws.amazon.com/documentation/sdkforjava/">AWS SDK for Java
    /// Documentation</a></li> <li><a href="http://aws.amazon.com/documentation/sdkfornet/">AWS
    /// SDK for .NET Documentation</a></li> <li><a href="http://aws.amazon.com/documentation/sdkforphp/">AWS
    /// SDK for PHP Documentation</a></li> <li><a href="http://aws.amazon.com/documentation/sdkforruby/">AWS
    /// SDK for Ruby Documentation</a></li> </ul> 
    /// <para>
    /// Developers in the AWS developer community also provide their own libraries, which
    /// you can find at the following AWS developer centers:
    /// </para>
    ///  <ul> <li><a href="http://aws.amazon.com/java/">AWS Java Developer Center</a></li>
    /// <li><a href="http://aws.amazon.com/php/">AWS PHP Developer Center</a></li> <li><a
    /// href="http://aws.amazon.com/python/">AWS Python Developer Center</a></li> <li><a href="http://aws.amazon.com/ruby/">AWS
    /// Ruby Developer Center</a></li> <li><a href="http://aws.amazon.com/net/">AWS Windows
    /// and .NET Developer Center</a></li> </ul>
    /// </summary>
    public partial interface IAmazonCloudWatchLogs : IDisposable
    {

        
        #region  CancelExportTask


        /// <summary>
        /// Cancels an export task if it is in <code>PENDING</code> or <code>RUNNING</code> state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// Returned if the operation is not valid on the specified resource
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateExportTask


        /// <summary>
        /// Creates an <code>ExportTask</code> which allows you to efficiently export data from
        /// a Log Group to your Amazon S3 bucket. 
        /// 
        ///  
        /// <para>
        ///  This is an asynchronous call. If all the required information is provided, this API
        /// will initiate an export task and respond with the task Id. Once started, <code>DescribeExportTasks</code>
        /// can be used to get the status of an export task. 
        /// </para>
        ///  
        /// <para>
        ///  You can export logs from multiple log groups or multiple time ranges to the same
        /// Amazon S3 bucket. To separate out log data for each export task, you can specify a
        /// prefix that will be used as the Amazon S3 key prefix for all exported objects. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExportTask service method.</param>
        /// 
        /// <returns>The response from the CreateExportTask service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// Returned if you have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceAlreadyExistsException">
        /// Returned if the specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        CreateExportTaskResponse CreateExportTask(CreateExportTaskRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateExportTaskResponse> CreateExportTaskAsync(CreateExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLogGroup


        /// <summary>
        /// Creates a new log group with the specified name. The name of the log group must be
        /// unique within a region for an AWS account. You can create up to 500 log groups per
        /// account. 
        /// 
        ///  
        /// <para>
        ///  You must use the following guidelines when naming a log group: <ul> <li>Log group
        /// names can be between 1 and 512 characters long.</li> <li>Allowed characters are a-z,
        /// A-Z, 0-9, '_' (underscore), '-' (hyphen), '/' (forward slash), and '.' (period).</li>
        /// </ul> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogGroup service method.</param>
        /// 
        /// <returns>The response from the CreateLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// Returned if you have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceAlreadyExistsException">
        /// Returned if the specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        CreateLogGroupResponse CreateLogGroup(CreateLogGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLogGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLogGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLogGroupResponse> CreateLogGroupAsync(CreateLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLogStream


        /// <summary>
        /// Creates a new log stream in the specified log group. The name of the log stream must
        /// be unique within the log group. There is no limit on the number of log streams that
        /// can exist in a log group. 
        /// 
        ///  
        /// <para>
        ///  You must use the following guidelines when naming a log stream: <ul> <li>Log stream
        /// names can be between 1 and 512 characters long.</li> <li>The ':' colon character is
        /// not allowed.</li> </ul> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogStream service method.</param>
        /// 
        /// <returns>The response from the CreateLogStream service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceAlreadyExistsException">
        /// Returned if the specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        CreateLogStreamResponse CreateLogStream(CreateLogStreamRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLogStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLogStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLogStreamResponse> CreateLogStreamAsync(CreateLogStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDestination


        /// <summary>
        /// Deletes the destination with the specified name and eventually disables all the subscription
        /// filters that publish to it. This will not delete the physical resource encapsulated
        /// by the destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLogGroup


        /// <summary>
        /// Deletes the log group with the specified name and permanently deletes all the archived
        /// log events associated with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DeleteLogGroupResponse DeleteLogGroup(DeleteLogGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLogGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLogGroupResponse> DeleteLogGroupAsync(DeleteLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLogStream


        /// <summary>
        /// Deletes a log stream and permanently deletes all the archived log events associated
        /// with it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogStream service method.</param>
        /// 
        /// <returns>The response from the DeleteLogStream service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DeleteLogStreamResponse DeleteLogStream(DeleteLogStreamRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLogStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLogStreamResponse> DeleteLogStreamAsync(DeleteLogStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMetricFilter


        /// <summary>
        /// Deletes a metric filter associated with the specified log group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteMetricFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DeleteMetricFilterResponse DeleteMetricFilter(DeleteMetricFilterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMetricFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteMetricFilterResponse> DeleteMetricFilterAsync(DeleteMetricFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRetentionPolicy


        /// <summary>
        /// Deletes the retention policy of the specified log group. Log events would not expire
        /// if they belong to log groups without a retention policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRetentionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DeleteRetentionPolicyResponse DeleteRetentionPolicy(DeleteRetentionPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteRetentionPolicyResponse> DeleteRetentionPolicyAsync(DeleteRetentionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSubscriptionFilter


        /// <summary>
        /// Deletes a subscription filter associated with the specified log group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DeleteSubscriptionFilterResponse DeleteSubscriptionFilter(DeleteSubscriptionFilterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriptionFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteSubscriptionFilterResponse> DeleteSubscriptionFilterAsync(DeleteSubscriptionFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDestinations


        /// <summary>
        /// Returns all the destinations that are associated with the AWS account making the
        /// request. The list returned in the response is ASCII-sorted by destination name. 
        /// 
        ///  
        /// <para>
        ///  By default, this operation returns up to 50 destinations. If there are more destinations
        /// to list, the response would contain a <code class="code">nextToken</code> value in
        /// the response body. You can also limit the number of destinations returned in the response
        /// by specifying the <code class="code">limit</code> parameter in the request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDestinations service method.</param>
        /// 
        /// <returns>The response from the DescribeDestinations service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DescribeDestinationsResponse DescribeDestinations(DescribeDestinationsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDestinations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeDestinationsResponse> DescribeDestinationsAsync(DescribeDestinationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeExportTasks


        /// <summary>
        /// Returns all the export tasks that are associated with the AWS account making the
        /// request. The export tasks can be filtered based on <code>TaskId</code> or <code>TaskStatus</code>.
        /// 
        /// 
        ///  
        /// <para>
        ///  By default, this operation returns up to 50 export tasks that satisfy the specified
        /// filters. If there are more export tasks to list, the response would contain a <code
        /// class="code">nextToken</code> value in the response body. You can also limit the number
        /// of export tasks returned in the response by specifying the <code class="code">limit</code>
        /// parameter in the request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLogGroups


        /// <summary>
        /// Returns all the log groups that are associated with the AWS account making the request.
        /// The list returned in the response is ASCII-sorted by log group name. 
        /// 
        ///  
        /// <para>
        ///  By default, this operation returns up to 50 log groups. If there are more log groups
        /// to list, the response would contain a <code class="code">nextToken</code> value in
        /// the response body. You can also limit the number of log groups returned in the response
        /// by specifying the <code class="code">limit</code> parameter in the request. 
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLogGroups service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DescribeLogGroupsResponse DescribeLogGroups();


        /// <summary>
        /// Returns all the log groups that are associated with the AWS account making the request.
        /// The list returned in the response is ASCII-sorted by log group name. 
        /// 
        ///  
        /// <para>
        ///  By default, this operation returns up to 50 log groups. If there are more log groups
        /// to list, the response would contain a <code class="code">nextToken</code> value in
        /// the response body. You can also limit the number of log groups returned in the response
        /// by specifying the <code class="code">limit</code> parameter in the request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeLogGroups service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DescribeLogGroupsResponse DescribeLogGroups(DescribeLogGroupsRequest request);


        /// <summary>
        /// Returns all the log groups that are associated with the AWS account making the request.
        /// The list returned in the response is ASCII-sorted by log group name. 
        /// 
        ///  
        /// <para>
        ///  By default, this operation returns up to 50 log groups. If there are more log groups
        /// to list, the response would contain a <code class="code">nextToken</code> value in
        /// the response body. You can also limit the number of log groups returned in the response
        /// by specifying the <code class="code">limit</code> parameter in the request. 
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLogGroups service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        Task<DescribeLogGroupsResponse> DescribeLogGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken));


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLogGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLogGroupsResponse> DescribeLogGroupsAsync(DescribeLogGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLogStreams


        /// <summary>
        /// Returns all the log streams that are associated with the specified log group. The
        /// list returned in the response is ASCII-sorted by log stream name. 
        /// 
        ///  
        /// <para>
        ///  By default, this operation returns up to 50 log streams. If there are more log streams
        /// to list, the response would contain a <code class="code">nextToken</code> value in
        /// the response body. You can also limit the number of log streams returned in the response
        /// by specifying the <code class="code">limit</code> parameter in the request. This operation
        /// has a limit of five transactions per second, after which transactions are throttled.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogStreams service method.</param>
        /// 
        /// <returns>The response from the DescribeLogStreams service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DescribeLogStreamsResponse DescribeLogStreams(DescribeLogStreamsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLogStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogStreams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLogStreamsResponse> DescribeLogStreamsAsync(DescribeLogStreamsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMetricFilters


        /// <summary>
        /// Returns all the metrics filters associated with the specified log group. The list
        /// returned in the response is ASCII-sorted by filter name. 
        /// 
        ///  
        /// <para>
        ///  By default, this operation returns up to 50 metric filters. If there are more metric
        /// filters to list, the response would contain a <code class="code">nextToken</code>
        /// value in the response body. You can also limit the number of metric filters returned
        /// in the response by specifying the <code class="code">limit</code> parameter in the
        /// request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricFilters service method.</param>
        /// 
        /// <returns>The response from the DescribeMetricFilters service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DescribeMetricFiltersResponse DescribeMetricFilters(DescribeMetricFiltersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricFilters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeMetricFiltersResponse> DescribeMetricFiltersAsync(DescribeMetricFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSubscriptionFilters


        /// <summary>
        /// Returns all the subscription filters associated with the specified log group. The
        /// list returned in the response is ASCII-sorted by filter name. 
        /// 
        ///  
        /// <para>
        ///  By default, this operation returns up to 50 subscription filters. If there are more
        /// subscription filters to list, the response would contain a <code class="code">nextToken</code>
        /// value in the response body. You can also limit the number of subscription filters
        /// returned in the response by specifying the <code class="code">limit</code> parameter
        /// in the request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscriptionFilters service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscriptionFilters service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        DescribeSubscriptionFiltersResponse DescribeSubscriptionFilters(DescribeSubscriptionFiltersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscriptionFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscriptionFilters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSubscriptionFiltersResponse> DescribeSubscriptionFiltersAsync(DescribeSubscriptionFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  FilterLogEvents


        /// <summary>
        /// Retrieves log events, optionally filtered by a filter pattern from the specified
        /// log group. You can provide an optional time range to filter the results on the event
        /// <code class="code">timestamp</code>. You can limit the streams searched to an explicit
        /// list of <code class="code">logStreamNames</code>. 
        /// 
        ///  
        /// <para>
        ///  By default, this operation returns as much matching log events as can fit in a response
        /// size of 1MB, up to 10,000 log events, or all the events found within a time-bounded
        /// scan window. If the response includes a <code class="code">nextToken</code>, then
        /// there is more data to search, and the search can be resumed with a new request providing
        /// the nextToken. The response will contain a list of <code class="code">searchedLogStreams</code>
        /// that contains information about which streams were searched in the request and whether
        /// they have been searched completely or require further pagination. The <code class="code">limit</code>
        /// parameter in the request. can be used to specify the maximum number of events to return
        /// in a page. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FilterLogEvents service method.</param>
        /// 
        /// <returns>The response from the FilterLogEvents service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        FilterLogEventsResponse FilterLogEvents(FilterLogEventsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the FilterLogEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FilterLogEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<FilterLogEventsResponse> FilterLogEventsAsync(FilterLogEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLogEvents


        /// <summary>
        /// Retrieves log events from the specified log stream. You can provide an optional time
        /// range to filter the results on the event <code class="code">timestamp</code>. 
        /// 
        ///  
        /// <para>
        ///  By default, this operation returns as much log events as can fit in a response size
        /// of 1MB, up to 10,000 log events. The response will always include a <code class="code">nextForwardToken</code>
        /// and a <code class="code">nextBackwardToken</code> in the response body. You can use
        /// any of these tokens in subsequent <code class="code">GetLogEvents</code> requests
        /// to paginate through events in either forward or backward direction. You can also limit
        /// the number of log events returned in the response by specifying the <code class="code">limit</code>
        /// parameter in the request. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogEvents service method.</param>
        /// 
        /// <returns>The response from the GetLogEvents service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        GetLogEventsResponse GetLogEvents(GetLogEventsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the GetLogEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLogEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<GetLogEventsResponse> GetLogEventsAsync(GetLogEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDestination


        /// <summary>
        /// Creates or updates a <code>Destination</code>. A destination encapsulates a physical
        /// resource (such as a Kinesis stream) and allows you to subscribe to a real-time stream
        /// of log events of a different account, ingested through <code class="code">PutLogEvents</code>
        /// requests. Currently, the only supported physical resource is a Amazon Kinesis stream
        /// belonging to the same account as the destination. 
        /// 
        ///  
        /// <para>
        ///  A destination controls what is written to its Amazon Kinesis stream through an access
        /// policy. By default, PutDestination does not set any access policy with the destination,
        /// which means a cross-account user will not be able to call <code>PutSubscriptionFilter</code>
        /// against this destination. To enable that, the destination owner must call <code>PutDestinationPolicy</code>
        /// after PutDestination. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDestination service method.</param>
        /// 
        /// <returns>The response from the PutDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        PutDestinationResponse PutDestination(PutDestinationRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutDestinationResponse> PutDestinationAsync(PutDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDestinationPolicy


        /// <summary>
        /// Creates or updates an access policy associated with an existing <code>Destination</code>.
        /// An access policy is an <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies_overview.html">IAM
        /// policy document</a> that is used to authorize claims to register a subscription filter
        /// against a given destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDestinationPolicy service method.</param>
        /// 
        /// <returns>The response from the PutDestinationPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        PutDestinationPolicyResponse PutDestinationPolicy(PutDestinationPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutDestinationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDestinationPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutDestinationPolicyResponse> PutDestinationPolicyAsync(PutDestinationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLogEvents


        /// <summary>
        /// Uploads a batch of log events to the specified log stream. 
        /// 
        ///  
        /// <para>
        ///  Every PutLogEvents request must include the <code class="code">sequenceToken</code>
        /// obtained from the response of the previous request. An upload in a newly created log
        /// stream does not require a <code class="code">sequenceToken</code>. 
        /// </para>
        ///  
        /// <para>
        ///  The batch of events must satisfy the following constraints: <ul> <li>The maximum
        /// batch size is 1,048,576 bytes, and this size is calculated as the sum of all event
        /// messages in UTF-8, plus 26 bytes for each log event.</li> <li>None of the log events
        /// in the batch can be more than 2 hours in the future.</li> <li>None of the log events
        /// in the batch can be older than 14 days or the retention period of the log group.</li>
        /// <li>The log events in the batch must be in chronological ordered by their <code class="code">timestamp</code>.</li>
        /// <li>The maximum number of log events in a batch is 10,000.</li> </ul> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLogEvents service method.</param>
        /// 
        /// <returns>The response from the PutLogEvents service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.DataAlreadyAcceptedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidSequenceTokenException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        PutLogEventsResponse PutLogEvents(PutLogEventsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutLogEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLogEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutLogEventsResponse> PutLogEventsAsync(PutLogEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutMetricFilter


        /// <summary>
        /// Creates or updates a metric filter and associates it with the specified log group.
        /// Metric filters allow you to configure rules to extract metric data from log events
        /// ingested through <code class="code">PutLogEvents</code> requests. 
        /// 
        ///  
        /// <para>
        ///  The maximum number of metric filters that can be associated with a log group is 100.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricFilter service method.</param>
        /// 
        /// <returns>The response from the PutMetricFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// Returned if you have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        PutMetricFilterResponse PutMetricFilter(PutMetricFilterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutMetricFilterResponse> PutMetricFilterAsync(PutMetricFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRetentionPolicy


        /// <summary>
        /// Sets the retention of the specified log group. A retention policy allows you to configure
        /// the number of days you want to retain log events in the specified log group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy service method.</param>
        /// 
        /// <returns>The response from the PutRetentionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        PutRetentionPolicyResponse PutRetentionPolicy(PutRetentionPolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutRetentionPolicyResponse> PutRetentionPolicyAsync(PutRetentionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutSubscriptionFilter


        /// <summary>
        /// Creates or updates a subscription filter and associates it with the specified log
        /// group. Subscription filters allow you to subscribe to a real-time stream of log events
        /// ingested through <code class="code">PutLogEvents</code> requests and have them delivered
        /// to a specific destination. Currently, the supported destinations are: <ul> <li> A
        /// Amazon Kinesis stream belonging to the same account as the subscription filter, for
        /// same-account delivery. </li> <li> A logical destination (used via an ARN of <code>Destination</code>)
        /// belonging to a different account, for cross-account delivery. </li> </ul> 
        /// 
        ///  
        /// <para>
        ///  Currently there can only be one subscription filter associated with a log group.
        /// 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSubscriptionFilter service method.</param>
        /// 
        /// <returns>The response from the PutSubscriptionFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// Returned if you have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Returned if multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// Returned if the specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        PutSubscriptionFilterResponse PutSubscriptionFilter(PutSubscriptionFilterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutSubscriptionFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSubscriptionFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<PutSubscriptionFilterResponse> PutSubscriptionFilterAsync(PutSubscriptionFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TestMetricFilter


        /// <summary>
        /// Tests the filter pattern of a metric filter against a sample of log event messages.
        /// You can use this operation to validate the correctness of a metric filter pattern.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestMetricFilter service method.</param>
        /// 
        /// <returns>The response from the TestMetricFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        TestMetricFilterResponse TestMetricFilter(TestMetricFilterRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TestMetricFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestMetricFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<TestMetricFilterResponse> TestMetricFilterAsync(TestMetricFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}