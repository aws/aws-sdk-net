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

using Amazon.Runtime;
using Amazon.CloudWatchLogs.Model;

namespace Amazon.CloudWatchLogs
{
    /// <summary>
    /// Interface for accessing CloudWatchLogs
    ///
    /// You can use Amazon CloudWatch Logs to monitor, store, and access your log files from
    /// Amazon EC2 instances, AWS CloudTrail, or other sources. You can then retrieve the
    /// associated log data from CloudWatch Logs using the CloudWatch console, CloudWatch
    /// Logs commands in the AWS CLI, CloudWatch Logs API, or CloudWatch Logs SDK.
    /// 
    ///  
    /// <para>
    /// You can use CloudWatch Logs to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Monitor logs from EC2 instances in real-time</b>: You can use CloudWatch Logs
    /// to monitor applications and systems using log data. For example, CloudWatch Logs can
    /// track the number of errors that occur in your application logs and send you a notification
    /// whenever the rate of errors exceeds a threshold that you specify. CloudWatch Logs
    /// uses your log data for monitoring; so, no code changes are required. For example,
    /// you can monitor application logs for specific literal terms (such as "NullReferenceException")
    /// or count the number of occurrences of a literal term at a particular position in log
    /// data (such as "404" status codes in an Apache access log). When the term you are searching
    /// for is found, CloudWatch Logs reports the data to a CloudWatch metric that you specify.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Monitor AWS CloudTrail logged events</b>: You can create alarms in CloudWatch
    /// and receive notifications of particular API activity as captured by CloudTrail and
    /// use the notification to perform troubleshooting.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Archive log data</b>: You can use CloudWatch Logs to store your log data in highly
    /// durable storage. You can change the log retention setting so that any log events older
    /// than this setting are automatically deleted. The CloudWatch Logs agent makes it easy
    /// to quickly send both rotated and non-rotated log data off of a host and into the log
    /// service. You can then access the raw log data when you need it.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCloudWatchLogs : IAmazonService, IDisposable
    {

        
        #region  CancelExportTask


        /// <summary>
        /// Cancels the specified export task.
        /// 
        ///  
        /// <para>
        /// The task must be in the <code>PENDING</code> or <code>RUNNING</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateExportTask


        /// <summary>
        /// Creates an export task, which allows you to efficiently export data from a log group
        /// to an Amazon S3 bucket.
        /// 
        ///  
        /// <para>
        /// This is an asynchronous call. If all the required information is provided, this operation
        /// initiates an export task and responds with the ID of the task. After the task has
        /// started, you can use <a>DescribeExportTasks</a> to get the status of the export task.
        /// Each account can only have one active (<code>RUNNING</code> or <code>PENDING</code>)
        /// export task at a time. To cancel an export task, use <a>CancelExportTask</a>.
        /// </para>
        ///  
        /// <para>
        /// You can export logs from multiple log groups or multiple time ranges to the same S3
        /// bucket. To separate out log data for each export task, you can specify a prefix to
        /// be used as the Amazon S3 key prefix for all exported objects.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExportTask service method.</param>
        /// 
        /// <returns>The response from the CreateExportTask service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateExportTask">REST API Reference for CreateExportTask Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateExportTask">REST API Reference for CreateExportTask Operation</seealso>
        Task<CreateExportTaskResponse> CreateExportTaskAsync(CreateExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLogGroup


        /// <summary>
        /// Creates a log group with the specified name.
        /// 
        ///  
        /// <para>
        /// You can create up to 5000 log groups per account.
        /// </para>
        ///  
        /// <para>
        /// You must use the following guidelines when naming a log group:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Log group names must be unique within a region for an AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Log group names can be between 1 and 512 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Log group names consist of the following characters: a-z, A-Z, 0-9, '_' (underscore),
        /// '-' (hyphen), '/' (forward slash), and '.' (period).
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogGroup service method.</param>
        /// 
        /// <returns>The response from the CreateLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogGroup">REST API Reference for CreateLogGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogGroup">REST API Reference for CreateLogGroup Operation</seealso>
        Task<CreateLogGroupResponse> CreateLogGroupAsync(CreateLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLogStream


        /// <summary>
        /// Creates a log stream for the specified log group.
        /// 
        ///  
        /// <para>
        /// There is no limit on the number of log streams that you can create for a log group.
        /// </para>
        ///  
        /// <para>
        /// You must use the following guidelines when naming a log stream:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Log stream names must be unique within the log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Log stream names can be between 1 and 512 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The ':' (colon) and '*' (asterisk) characters are not allowed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogStream service method.</param>
        /// 
        /// <returns>The response from the CreateLogStream service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogStream">REST API Reference for CreateLogStream Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogStream">REST API Reference for CreateLogStream Operation</seealso>
        Task<CreateLogStreamResponse> CreateLogStreamAsync(CreateLogStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDestination


        /// <summary>
        /// Deletes the specified destination, and eventually disables all the subscription filters
        /// that publish to it. This operation does not delete the physical resource encapsulated
        /// by the destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLogGroup


        /// <summary>
        /// Deletes the specified log group and permanently deletes all the archived log events
        /// associated with the log group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogGroup">REST API Reference for DeleteLogGroup Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogGroup">REST API Reference for DeleteLogGroup Operation</seealso>
        Task<DeleteLogGroupResponse> DeleteLogGroupAsync(DeleteLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLogStream


        /// <summary>
        /// Deletes the specified log stream and permanently deletes all the archived log events
        /// associated with the log stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogStream service method.</param>
        /// 
        /// <returns>The response from the DeleteLogStream service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogStream">REST API Reference for DeleteLogStream Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogStream">REST API Reference for DeleteLogStream Operation</seealso>
        Task<DeleteLogStreamResponse> DeleteLogStreamAsync(DeleteLogStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteMetricFilter


        /// <summary>
        /// Deletes the specified metric filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteMetricFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteMetricFilter">REST API Reference for DeleteMetricFilter Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteMetricFilter">REST API Reference for DeleteMetricFilter Operation</seealso>
        Task<DeleteMetricFilterResponse> DeleteMetricFilterAsync(DeleteMetricFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteResourcePolicy


        /// <summary>
        /// Deletes a resource policy from this account. This revokes the access of the identities
        /// in that policy to put log events to this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteRetentionPolicy


        /// <summary>
        /// Deletes the specified retention policy.
        /// 
        ///  
        /// <para>
        /// Log events do not expire if they belong to log groups without a retention policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteRetentionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteRetentionPolicy">REST API Reference for DeleteRetentionPolicy Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteRetentionPolicy">REST API Reference for DeleteRetentionPolicy Operation</seealso>
        Task<DeleteRetentionPolicyResponse> DeleteRetentionPolicyAsync(DeleteRetentionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteSubscriptionFilter


        /// <summary>
        /// Deletes the specified subscription filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionFilter service method.</param>
        /// 
        /// <returns>The response from the DeleteSubscriptionFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteSubscriptionFilter">REST API Reference for DeleteSubscriptionFilter Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteSubscriptionFilter">REST API Reference for DeleteSubscriptionFilter Operation</seealso>
        Task<DeleteSubscriptionFilterResponse> DeleteSubscriptionFilterAsync(DeleteSubscriptionFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDestinations


        /// <summary>
        /// Lists all your destinations. The results are ASCII-sorted by destination name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDestinations service method.</param>
        /// 
        /// <returns>The response from the DescribeDestinations service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDestinations">REST API Reference for DescribeDestinations Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDestinations">REST API Reference for DescribeDestinations Operation</seealso>
        Task<DescribeDestinationsResponse> DescribeDestinationsAsync(DescribeDestinationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeExportTasks


        /// <summary>
        /// Lists the specified export tasks. You can list all your export tasks or filter the
        /// results based on task ID or task status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLogGroups


        /// <summary>
        /// Lists the specified log groups. You can list all your log groups or filter the results
        /// by prefix. The results are ASCII-sorted by log group name.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLogGroups service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogGroups">REST API Reference for DescribeLogGroups Operation</seealso>
        DescribeLogGroupsResponse DescribeLogGroups();


        /// <summary>
        /// Lists the specified log groups. You can list all your log groups or filter the results
        /// by prefix. The results are ASCII-sorted by log group name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeLogGroups service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogGroups">REST API Reference for DescribeLogGroups Operation</seealso>
        DescribeLogGroupsResponse DescribeLogGroups(DescribeLogGroupsRequest request);


        /// <summary>
        /// Lists the specified log groups. You can list all your log groups or filter the results
        /// by prefix. The results are ASCII-sorted by log group name.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLogGroups service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogGroups">REST API Reference for DescribeLogGroups Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogGroups">REST API Reference for DescribeLogGroups Operation</seealso>
        Task<DescribeLogGroupsResponse> DescribeLogGroupsAsync(DescribeLogGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLogStreams


        /// <summary>
        /// Lists the log streams for the specified log group. You can list all the log streams
        /// or filter the results by prefix. You can also control how the results are ordered.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of five transactions per second, after which transactions
        /// are throttled.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogStreams service method.</param>
        /// 
        /// <returns>The response from the DescribeLogStreams service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogStreams">REST API Reference for DescribeLogStreams Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogStreams">REST API Reference for DescribeLogStreams Operation</seealso>
        Task<DescribeLogStreamsResponse> DescribeLogStreamsAsync(DescribeLogStreamsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMetricFilters


        /// <summary>
        /// Lists the specified metric filters. You can list all the metric filters or filter
        /// the results by log name, prefix, metric name, and metric namespace. The results are
        /// ASCII-sorted by filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricFilters service method.</param>
        /// 
        /// <returns>The response from the DescribeMetricFilters service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeMetricFilters">REST API Reference for DescribeMetricFilters Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeMetricFilters">REST API Reference for DescribeMetricFilters Operation</seealso>
        Task<DescribeMetricFiltersResponse> DescribeMetricFiltersAsync(DescribeMetricFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeResourcePolicies


        /// <summary>
        /// Lists the resource policies in this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeResourcePolicies service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeResourcePolicies">REST API Reference for DescribeResourcePolicies Operation</seealso>
        DescribeResourcePoliciesResponse DescribeResourcePolicies(DescribeResourcePoliciesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeResourcePolicies">REST API Reference for DescribeResourcePolicies Operation</seealso>
        Task<DescribeResourcePoliciesResponse> DescribeResourcePoliciesAsync(DescribeResourcePoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSubscriptionFilters


        /// <summary>
        /// Lists the subscription filters for the specified log group. You can list all the subscription
        /// filters or filter the results by prefix. The results are ASCII-sorted by filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscriptionFilters service method.</param>
        /// 
        /// <returns>The response from the DescribeSubscriptionFilters service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeSubscriptionFilters">REST API Reference for DescribeSubscriptionFilters Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeSubscriptionFilters">REST API Reference for DescribeSubscriptionFilters Operation</seealso>
        Task<DescribeSubscriptionFiltersResponse> DescribeSubscriptionFiltersAsync(DescribeSubscriptionFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  FilterLogEvents


        /// <summary>
        /// Lists log events from the specified log group. You can list all the log events or
        /// filter the results using a filter pattern, a time range, and the name of the log stream.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns as many log events as can fit in 1 MB (up to 10,000
        /// log events), or all the events found within the time range that you specify. If the
        /// results include a token, then there are more log events available, and you can get
        /// additional results by specifying the token in a subsequent call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FilterLogEvents service method.</param>
        /// 
        /// <returns>The response from the FilterLogEvents service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/FilterLogEvents">REST API Reference for FilterLogEvents Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/FilterLogEvents">REST API Reference for FilterLogEvents Operation</seealso>
        Task<FilterLogEventsResponse> FilterLogEventsAsync(FilterLogEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLogEvents


        /// <summary>
        /// Lists log events from the specified log stream. You can list all the log events or
        /// filter using a time range.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns as many log events as can fit in a response size
        /// of 1 MB (up to 10,000 log events). You can get additional log events by specifying
        /// one of the tokens in a subsequent call.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogEvents service method.</param>
        /// 
        /// <returns>The response from the GetLogEvents service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogEvents">REST API Reference for GetLogEvents Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogEvents">REST API Reference for GetLogEvents Operation</seealso>
        Task<GetLogEventsResponse> GetLogEventsAsync(GetLogEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsLogGroup


        /// <summary>
        /// Lists the tags for the specified log group.
        /// 
        ///  
        /// <para>
        /// To add tags, use <a>TagLogGroup</a>. To remove tags, use <a>UntagLogGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsLogGroup service method.</param>
        /// 
        /// <returns>The response from the ListTagsLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListTagsLogGroup">REST API Reference for ListTagsLogGroup Operation</seealso>
        ListTagsLogGroupResponse ListTagsLogGroup(ListTagsLogGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsLogGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsLogGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListTagsLogGroup">REST API Reference for ListTagsLogGroup Operation</seealso>
        Task<ListTagsLogGroupResponse> ListTagsLogGroupAsync(ListTagsLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDestination


        /// <summary>
        /// Creates or updates a destination. A destination encapsulates a physical resource (such
        /// as an Amazon Kinesis stream) and enables you to subscribe to a real-time stream of
        /// log events for a different account, ingested using <a>PutLogEvents</a>. Currently,
        /// the only supported physical resource is a Kinesis stream belonging to the same account
        /// as the destination.
        /// 
        ///  
        /// <para>
        /// Through an access policy, a destination controls what is written to its Kinesis stream.
        /// By default, <code>PutDestination</code> does not set any access policy with the destination,
        /// which means a cross-account user cannot call <a>PutSubscriptionFilter</a> against
        /// this destination. To enable this, the destination owner must call <a>PutDestinationPolicy</a>
        /// after <code>PutDestination</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDestination service method.</param>
        /// 
        /// <returns>The response from the PutDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestination">REST API Reference for PutDestination Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestination">REST API Reference for PutDestination Operation</seealso>
        Task<PutDestinationResponse> PutDestinationAsync(PutDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDestinationPolicy


        /// <summary>
        /// Creates or updates an access policy associated with an existing destination. An access
        /// policy is an <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies_overview.html">IAM
        /// policy document</a> that is used to authorize claims to register a subscription filter
        /// against a given destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDestinationPolicy service method.</param>
        /// 
        /// <returns>The response from the PutDestinationPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestinationPolicy">REST API Reference for PutDestinationPolicy Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestinationPolicy">REST API Reference for PutDestinationPolicy Operation</seealso>
        Task<PutDestinationPolicyResponse> PutDestinationPolicyAsync(PutDestinationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLogEvents


        /// <summary>
        /// Uploads a batch of log events to the specified log stream.
        /// 
        ///  
        /// <para>
        /// You must include the sequence token obtained from the response of the previous call.
        /// An upload in a newly created log stream does not require a sequence token. You can
        /// also get the sequence token using <a>DescribeLogStreams</a>. If you call <code>PutLogEvents</code>
        /// twice within a narrow time period using the same value for <code>sequenceToken</code>,
        /// both calls may be successful, or one may be rejected.
        /// </para>
        ///  
        /// <para>
        /// The batch of events must satisfy the following constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The maximum batch size is 1,048,576 bytes, and this size is calculated as the sum
        /// of all event messages in UTF-8, plus 26 bytes for each log event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None of the log events in the batch can be more than 2 hours in the future.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None of the log events in the batch can be older than 14 days or the retention period
        /// of the log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The log events in the batch must be in chronological ordered by their time stamp (the
        /// time the event occurred, expressed as the number of milliseconds after Jan 1, 1970
        /// 00:00:00 UTC).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum number of log events in a batch is 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A batch of log events in a single request cannot span more than 24 hours. Otherwise,
        /// the operation fails.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLogEvents service method.</param>
        /// 
        /// <returns>The response from the PutLogEvents service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.DataAlreadyAcceptedException">
        /// The event was already logged.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidSequenceTokenException">
        /// The sequence token is not valid.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutLogEvents">REST API Reference for PutLogEvents Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutLogEvents">REST API Reference for PutLogEvents Operation</seealso>
        Task<PutLogEventsResponse> PutLogEventsAsync(PutLogEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutMetricFilter


        /// <summary>
        /// Creates or updates a metric filter and associates it with the specified log group.
        /// Metric filters allow you to configure rules to extract metric data from log events
        /// ingested through <a>PutLogEvents</a>.
        /// 
        ///  
        /// <para>
        /// The maximum number of metric filters that can be associated with a log group is 100.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricFilter service method.</param>
        /// 
        /// <returns>The response from the PutMetricFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutMetricFilter">REST API Reference for PutMetricFilter Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutMetricFilter">REST API Reference for PutMetricFilter Operation</seealso>
        Task<PutMetricFilterResponse> PutMetricFilterAsync(PutMetricFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates or updates a resource policy allowing other AWS services to put log events
        /// to this account, such as Amazon Route 53. An account can have up to 50 resource policies
        /// per region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRetentionPolicy


        /// <summary>
        /// Sets the retention of the specified log group. A retention policy allows you to configure
        /// the number of days for which to retain log events in the specified log group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy service method.</param>
        /// 
        /// <returns>The response from the PutRetentionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutRetentionPolicy">REST API Reference for PutRetentionPolicy Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutRetentionPolicy">REST API Reference for PutRetentionPolicy Operation</seealso>
        Task<PutRetentionPolicyResponse> PutRetentionPolicyAsync(PutRetentionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutSubscriptionFilter


        /// <summary>
        /// Creates or updates a subscription filter and associates it with the specified log
        /// group. Subscription filters allow you to subscribe to a real-time stream of log events
        /// ingested through <a>PutLogEvents</a> and have them delivered to a specific destination.
        /// Currently, the supported destinations are:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Kinesis stream belonging to the same account as the subscription filter,
        /// for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A logical destination that belongs to a different account, for cross-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Kinesis Firehose delivery stream that belongs to the same account as the
        /// subscription filter, for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An AWS Lambda function that belongs to the same account as the subscription filter,
        /// for same-account delivery.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// There can only be one subscription filter associated with a log group. If you are
        /// updating an existing filter, you must specify the correct name in <code>filterName</code>.
        /// Otherwise, the call fails because you cannot associate a second filter with a log
        /// group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSubscriptionFilter service method.</param>
        /// 
        /// <returns>The response from the PutSubscriptionFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutSubscriptionFilter">REST API Reference for PutSubscriptionFilter Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutSubscriptionFilter">REST API Reference for PutSubscriptionFilter Operation</seealso>
        Task<PutSubscriptionFilterResponse> PutSubscriptionFilterAsync(PutSubscriptionFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagLogGroup


        /// <summary>
        /// Adds or updates the specified tags for the specified log group.
        /// 
        ///  
        /// <para>
        /// To list the tags for a log group, use <a>ListTagsLogGroup</a>. To remove tags, use
        /// <a>UntagLogGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/log-group-tagging.html">Tag
        /// Log Groups in Amazon CloudWatch Logs</a> in the <i>Amazon CloudWatch Logs User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagLogGroup service method.</param>
        /// 
        /// <returns>The response from the TagLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TagLogGroup">REST API Reference for TagLogGroup Operation</seealso>
        TagLogGroupResponse TagLogGroup(TagLogGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the TagLogGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagLogGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TagLogGroup">REST API Reference for TagLogGroup Operation</seealso>
        Task<TagLogGroupResponse> TagLogGroupAsync(TagLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TestMetricFilter">REST API Reference for TestMetricFilter Operation</seealso>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TestMetricFilter">REST API Reference for TestMetricFilter Operation</seealso>
        Task<TestMetricFilterResponse> TestMetricFilterAsync(TestMetricFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagLogGroup


        /// <summary>
        /// Removes the specified tags from the specified log group.
        /// 
        ///  
        /// <para>
        /// To list the tags for a log group, use <a>ListTagsLogGroup</a>. To add tags, use <a>UntagLogGroup</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagLogGroup service method.</param>
        /// 
        /// <returns>The response from the UntagLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagLogGroup">REST API Reference for UntagLogGroup Operation</seealso>
        UntagLogGroupResponse UntagLogGroup(UntagLogGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the UntagLogGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagLogGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagLogGroup">REST API Reference for UntagLogGroup Operation</seealso>
        Task<UntagLogGroupResponse> UntagLogGroupAsync(UntagLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}