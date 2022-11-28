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
    /// EC2 instances, CloudTrail, and other sources. You can then retrieve the associated
    /// log data from CloudWatch Logs using the CloudWatch console. Alternatively, you can
    /// use CloudWatch Logs commands in the Amazon Web Services CLI, CloudWatch Logs API,
    /// or CloudWatch Logs SDK.
    /// 
    ///  
    /// <para>
    /// You can use CloudWatch Logs to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Monitor logs from EC2 instances in real time</b>: You can use CloudWatch Logs
    /// to monitor applications and systems using log data. For example, CloudWatch Logs can
    /// track the number of errors that occur in your application logs. Then, it can send
    /// you a notification whenever the rate of errors exceeds a threshold that you specify.
    /// CloudWatch Logs uses your log data for monitoring so no code changes are required.
    /// For example, you can monitor application logs for specific literal terms (such as
    /// "NullReferenceException"). You can also count the number of occurrences of a literal
    /// term at a particular position in log data (such as "404" status codes in an Apache
    /// access log). When the term you are searching for is found, CloudWatch Logs reports
    /// the data to a CloudWatch metric that you specify.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Monitor CloudTrail logged events</b>: You can create alarms in CloudWatch and
    /// receive notifications of particular API activity as captured by CloudTrail. You can
    /// use the notification to perform troubleshooting.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Archive log data</b>: You can use CloudWatch Logs to store your log data in highly
    /// durable storage. You can change the log retention setting so that any log events earlier
    /// than this setting are automatically deleted. The CloudWatch Logs agent helps to quickly
    /// send both rotated and non-rotated log data off of a host and into the log service.
    /// You can then access the raw log data when you need it.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial interface IAmazonCloudWatchLogs : IAmazonService, IDisposable
    {

        /// <summary>
        /// Paginators for the service
        /// </summary>
        ICloudWatchLogsPaginatorFactory Paginators { get; }

        
        #region  AssociateKmsKey


        /// <summary>
        /// Associates the specified KMS key with the specified log group.
        /// 
        ///  
        /// <para>
        /// Associating a KMS key with a log group overrides any existing associations between
        /// the log group and a KMS key. After a KMS key is associated with a log group, all newly
        /// ingested data for the log group is encrypted using the KMS key. This association is
        /// stored as long as the data encrypted with the KMS keyis still within CloudWatch Logs.
        /// This enables CloudWatch Logs to decrypt this data whenever it is requested.
        /// </para>
        ///  <important> 
        /// <para>
        /// CloudWatch Logs supports only symmetric KMS keys. Do not use an associate an asymmetric
        /// KMS key with your log group. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric Keys</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// It can take up to 5 minutes for this operation to take effect.
        /// </para>
        ///  
        /// <para>
        /// If you attempt to associate a KMS key with a log group but the KMS key does not exist
        /// or the KMS key is disabled, you receive an <code>InvalidParameterException</code>
        /// error. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateKmsKey service method.</param>
        /// 
        /// <returns>The response from the AssociateKmsKey service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/AssociateKmsKey">REST API Reference for AssociateKmsKey Operation</seealso>
        AssociateKmsKeyResponse AssociateKmsKey(AssociateKmsKeyRequest request);



        /// <summary>
        /// Associates the specified KMS key with the specified log group.
        /// 
        ///  
        /// <para>
        /// Associating a KMS key with a log group overrides any existing associations between
        /// the log group and a KMS key. After a KMS key is associated with a log group, all newly
        /// ingested data for the log group is encrypted using the KMS key. This association is
        /// stored as long as the data encrypted with the KMS keyis still within CloudWatch Logs.
        /// This enables CloudWatch Logs to decrypt this data whenever it is requested.
        /// </para>
        ///  <important> 
        /// <para>
        /// CloudWatch Logs supports only symmetric KMS keys. Do not use an associate an asymmetric
        /// KMS key with your log group. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric Keys</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// It can take up to 5 minutes for this operation to take effect.
        /// </para>
        ///  
        /// <para>
        /// If you attempt to associate a KMS key with a log group but the KMS key does not exist
        /// or the KMS key is disabled, you receive an <code>InvalidParameterException</code>
        /// error. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateKmsKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateKmsKey service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/AssociateKmsKey">REST API Reference for AssociateKmsKey Operation</seealso>
        Task<AssociateKmsKeyResponse> AssociateKmsKeyAsync(AssociateKmsKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
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
        /// Cancels the specified export task.
        /// 
        ///  
        /// <para>
        /// The task must be in the <code>PENDING</code> or <code>RUNNING</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateExportTask


        /// <summary>
        /// Creates an export task so that you can efficiently export data from a log group to
        /// an Amazon S3 bucket. When you perform a <code>CreateExportTask</code> operation, you
        /// must use credentials that have permission to write to the S3 bucket that you specify
        /// as the destination.
        /// 
        ///  
        /// <para>
        /// Exporting log data to S3 buckets that are encrypted by KMS is supported. Exporting
        /// log data to Amazon S3 buckets that have S3 Object Lock enabled with a retention period
        /// is also supported.
        /// </para>
        ///  
        /// <para>
        /// Exporting to S3 buckets that are encrypted with AES-256 is supported. 
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous call. If all the required information is provided, this operation
        /// initiates an export task and responds with the ID of the task. After the task has
        /// started, you can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeExportTasks.html">DescribeExportTasks</a>
        /// to get the status of the export task. Each account can only have one active (<code>RUNNING</code>
        /// or <code>PENDING</code>) export task at a time. To cancel an export task, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CancelExportTask.html">CancelExportTask</a>.
        /// </para>
        ///  
        /// <para>
        /// You can export logs from multiple log groups or multiple time ranges to the same S3
        /// bucket. To separate log data for each export task, specify a prefix to be used as
        /// the Amazon S3 key prefix for all exported objects.
        /// </para>
        ///  <note> 
        /// <para>
        /// Time-based sorting on chunks of log data inside an exported file is not guaranteed.
        /// You can sort the exported log field data by using Linux utilities.
        /// </para>
        ///  </note>
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
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Creates an export task so that you can efficiently export data from a log group to
        /// an Amazon S3 bucket. When you perform a <code>CreateExportTask</code> operation, you
        /// must use credentials that have permission to write to the S3 bucket that you specify
        /// as the destination.
        /// 
        ///  
        /// <para>
        /// Exporting log data to S3 buckets that are encrypted by KMS is supported. Exporting
        /// log data to Amazon S3 buckets that have S3 Object Lock enabled with a retention period
        /// is also supported.
        /// </para>
        ///  
        /// <para>
        /// Exporting to S3 buckets that are encrypted with AES-256 is supported. 
        /// </para>
        ///  
        /// <para>
        /// This is an asynchronous call. If all the required information is provided, this operation
        /// initiates an export task and responds with the ID of the task. After the task has
        /// started, you can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeExportTasks.html">DescribeExportTasks</a>
        /// to get the status of the export task. Each account can only have one active (<code>RUNNING</code>
        /// or <code>PENDING</code>) export task at a time. To cancel an export task, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CancelExportTask.html">CancelExportTask</a>.
        /// </para>
        ///  
        /// <para>
        /// You can export logs from multiple log groups or multiple time ranges to the same S3
        /// bucket. To separate log data for each export task, specify a prefix to be used as
        /// the Amazon S3 key prefix for all exported objects.
        /// </para>
        ///  <note> 
        /// <para>
        /// Time-based sorting on chunks of log data inside an exported file is not guaranteed.
        /// You can sort the exported log field data by using Linux utilities.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateExportTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateExportTask service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        Task<CreateExportTaskResponse> CreateExportTaskAsync(CreateExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLogGroup


        /// <summary>
        /// Creates a log group with the specified name. You can create up to 20,000 log groups
        /// per account.
        /// 
        ///  
        /// <para>
        /// You must use the following guidelines when naming a log group:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Log group names must be unique within a Region for an Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Log group names can be between 1 and 512 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Log group names consist of the following characters: a-z, A-Z, 0-9, '_' (underscore),
        /// '-' (hyphen), '/' (forward slash), '.' (period), and '#' (number sign)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you create a log group, by default the log events in the log group do not expire.
        /// To set a retention policy so that events expire and are deleted after a specified
        /// time, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutRetentionPolicy.html">PutRetentionPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If you associate an KMS key with the log group, ingested data is encrypted using the
        /// KMS key. This association is stored as long as the data encrypted with the KMS key
        /// is still within CloudWatch Logs. This enables CloudWatch Logs to decrypt this data
        /// whenever it is requested.
        /// </para>
        ///  
        /// <para>
        /// If you attempt to associate a KMS key with the log group but the KMS keydoes not exist
        /// or the KMS key is disabled, you receive an <code>InvalidParameterException</code>
        /// error. 
        /// </para>
        ///  <important> 
        /// <para>
        /// CloudWatch Logs supports only symmetric KMS keys. Do not associate an asymmetric KMS
        /// key with your log group. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric Keys</a>.
        /// </para>
        ///  </important>
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
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Creates a log group with the specified name. You can create up to 20,000 log groups
        /// per account.
        /// 
        ///  
        /// <para>
        /// You must use the following guidelines when naming a log group:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Log group names must be unique within a Region for an Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Log group names can be between 1 and 512 characters long.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Log group names consist of the following characters: a-z, A-Z, 0-9, '_' (underscore),
        /// '-' (hyphen), '/' (forward slash), '.' (period), and '#' (number sign)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When you create a log group, by default the log events in the log group do not expire.
        /// To set a retention policy so that events expire and are deleted after a specified
        /// time, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutRetentionPolicy.html">PutRetentionPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If you associate an KMS key with the log group, ingested data is encrypted using the
        /// KMS key. This association is stored as long as the data encrypted with the KMS key
        /// is still within CloudWatch Logs. This enables CloudWatch Logs to decrypt this data
        /// whenever it is requested.
        /// </para>
        ///  
        /// <para>
        /// If you attempt to associate a KMS key with the log group but the KMS keydoes not exist
        /// or the KMS key is disabled, you receive an <code>InvalidParameterException</code>
        /// error. 
        /// </para>
        ///  <important> 
        /// <para>
        /// CloudWatch Logs supports only symmetric KMS keys. Do not associate an asymmetric KMS
        /// key with your log group. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric Keys</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceAlreadyExistsException">
        /// The specified resource already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogGroup">REST API Reference for CreateLogGroup Operation</seealso>
        Task<CreateLogGroupResponse> CreateLogGroupAsync(CreateLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLogStream


        /// <summary>
        /// Creates a log stream for the specified log group. A log stream is a sequence of log
        /// events that originate from a single source, such as an application instance or a resource
        /// that is being monitored.
        /// 
        ///  
        /// <para>
        /// There is no limit on the number of log streams that you can create for a log group.
        /// There is a limit of 50 TPS on <code>CreateLogStream</code> operations, after which
        /// transactions are throttled.
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
        /// Don't use ':' (colon) or '*' (asterisk) characters.
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
        /// Creates a log stream for the specified log group. A log stream is a sequence of log
        /// events that originate from a single source, such as an application instance or a resource
        /// that is being monitored.
        /// 
        ///  
        /// <para>
        /// There is no limit on the number of log streams that you can create for a log group.
        /// There is a limit of 50 TPS on <code>CreateLogStream</code> operations, after which
        /// transactions are throttled.
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
        /// Don't use ':' (colon) or '*' (asterisk) characters.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<CreateLogStreamResponse> CreateLogStreamAsync(CreateLogStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDataProtectionPolicy


        /// <summary>
        /// Deletes the data protection policy from the specified log group. 
        /// 
        ///  
        /// <para>
        /// For more information about data protection policies, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDataProtectionPolicy.html">PutDataProtectionPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProtectionPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteDataProtectionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDataProtectionPolicy">REST API Reference for DeleteDataProtectionPolicy Operation</seealso>
        DeleteDataProtectionPolicyResponse DeleteDataProtectionPolicy(DeleteDataProtectionPolicyRequest request);



        /// <summary>
        /// Deletes the data protection policy from the specified log group. 
        /// 
        ///  
        /// <para>
        /// For more information about data protection policies, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDataProtectionPolicy.html">PutDataProtectionPolicy</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProtectionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDataProtectionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDataProtectionPolicy">REST API Reference for DeleteDataProtectionPolicy Operation</seealso>
        Task<DeleteDataProtectionPolicyResponse> DeleteDataProtectionPolicyAsync(DeleteDataProtectionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Deletes the specified destination, and eventually disables all the subscription filters
        /// that publish to it. This operation does not delete the physical resource encapsulated
        /// by the destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
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
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Deletes the specified log group and permanently deletes all the archived log events
        /// associated with the log group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
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
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Deletes the specified log stream and permanently deletes all the archived log events
        /// associated with the log stream.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogStream service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLogStream service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
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
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Deletes the specified metric filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMetricFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteMetricFilter">REST API Reference for DeleteMetricFilter Operation</seealso>
        Task<DeleteMetricFilterResponse> DeleteMetricFilterAsync(DeleteMetricFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteQueryDefinition


        /// <summary>
        /// Deletes a saved CloudWatch Logs Insights query definition. A query definition contains
        /// details about a saved CloudWatch Logs Insights query.
        /// 
        ///  
        /// <para>
        /// Each <code>DeleteQueryDefinition</code> operation can delete one query definition.
        /// </para>
        ///  
        /// <para>
        /// You must have the <code>logs:DeleteQueryDefinition</code> permission to be able to
        /// perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueryDefinition service method.</param>
        /// 
        /// <returns>The response from the DeleteQueryDefinition service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteQueryDefinition">REST API Reference for DeleteQueryDefinition Operation</seealso>
        DeleteQueryDefinitionResponse DeleteQueryDefinition(DeleteQueryDefinitionRequest request);



        /// <summary>
        /// Deletes a saved CloudWatch Logs Insights query definition. A query definition contains
        /// details about a saved CloudWatch Logs Insights query.
        /// 
        ///  
        /// <para>
        /// Each <code>DeleteQueryDefinition</code> operation can delete one query definition.
        /// </para>
        ///  
        /// <para>
        /// You must have the <code>logs:DeleteQueryDefinition</code> permission to be able to
        /// perform this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueryDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueryDefinition service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteQueryDefinition">REST API Reference for DeleteQueryDefinition Operation</seealso>
        Task<DeleteQueryDefinitionResponse> DeleteQueryDefinitionAsync(DeleteQueryDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Deletes a resource policy from this account. This revokes the access of the identities
        /// in that policy to put log events to this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Deletes the specified retention policy.
        /// 
        ///  
        /// <para>
        /// Log events do not expire if they belong to log groups without a retention policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRetentionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
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
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Deletes the specified subscription filter.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSubscriptionFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
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
        /// Lists all your destinations. The results are ASCII-sorted by destination name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDestinations service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
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
        /// Lists the specified export tasks. You can list all your export tasks or filter the
        /// results based on task ID or task status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLogGroups


        /// <summary>
        /// Lists the specified log groups. You can list all your log groups or filter the results
        /// by prefix. The results are ASCII-sorted by log group name.
        /// 
        ///  
        /// <para>
        /// CloudWatch Logs doesn’t support IAM policies that control access to the <code>DescribeLogGroups</code>
        /// action by using the <code>aws:ResourceTag/<i>key-name</i> </code> condition key. Other
        /// CloudWatch Logs actions do support the use of the <code>aws:ResourceTag/<i>key-name</i>
        /// </code> condition key to control access. For more information about using tags to
        /// control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
        /// access to Amazon Web Services resources using tags</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// CloudWatch Logs doesn’t support IAM policies that control access to the <code>DescribeLogGroups</code>
        /// action by using the <code>aws:ResourceTag/<i>key-name</i> </code> condition key. Other
        /// CloudWatch Logs actions do support the use of the <code>aws:ResourceTag/<i>key-name</i>
        /// </code> condition key to control access. For more information about using tags to
        /// control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
        /// access to Amazon Web Services resources using tags</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
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
        /// 
        ///  
        /// <para>
        /// CloudWatch Logs doesn’t support IAM policies that control access to the <code>DescribeLogGroups</code>
        /// action by using the <code>aws:ResourceTag/<i>key-name</i> </code> condition key. Other
        /// CloudWatch Logs actions do support the use of the <code>aws:ResourceTag/<i>key-name</i>
        /// </code> condition key to control access. For more information about using tags to
        /// control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
        /// access to Amazon Web Services resources using tags</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
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
        /// Lists the specified log groups. You can list all your log groups or filter the results
        /// by prefix. The results are ASCII-sorted by log group name.
        /// 
        ///  
        /// <para>
        /// CloudWatch Logs doesn’t support IAM policies that control access to the <code>DescribeLogGroups</code>
        /// action by using the <code>aws:ResourceTag/<i>key-name</i> </code> condition key. Other
        /// CloudWatch Logs actions do support the use of the <code>aws:ResourceTag/<i>key-name</i>
        /// </code> condition key to control access. For more information about using tags to
        /// control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
        /// access to Amazon Web Services resources using tags</a>.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogGroups service method.</param>
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
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
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
        /// Lists the log streams for the specified log group. You can list all the log streams
        /// or filter the results by prefix. You can also control how the results are ordered.
        /// 
        ///  
        /// <para>
        /// This operation has a limit of five transactions per second, after which transactions
        /// are throttled.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogStreams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeLogStreamsResponse> DescribeLogStreamsAsync(DescribeLogStreamsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeMetricFilters


        /// <summary>
        /// Lists the specified metric filters. You can list all of the metric filters or filter
        /// the results by log name, prefix, metric name, or metric namespace. The results are
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
        /// Lists the specified metric filters. You can list all of the metric filters or filter
        /// the results by log name, prefix, metric name, or metric namespace. The results are
        /// ASCII-sorted by filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeMetricFiltersResponse> DescribeMetricFiltersAsync(DescribeMetricFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeQueries


        /// <summary>
        /// Returns a list of CloudWatch Logs Insights queries that are scheduled, running, or
        /// have been run recently in this account. You can request all queries or limit it to
        /// queries of a specific log group or queries with a certain status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueries service method.</param>
        /// 
        /// <returns>The response from the DescribeQueries service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeQueries">REST API Reference for DescribeQueries Operation</seealso>
        DescribeQueriesResponse DescribeQueries(DescribeQueriesRequest request);



        /// <summary>
        /// Returns a list of CloudWatch Logs Insights queries that are scheduled, running, or
        /// have been run recently in this account. You can request all queries or limit it to
        /// queries of a specific log group or queries with a certain status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQueries service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeQueries">REST API Reference for DescribeQueries Operation</seealso>
        Task<DescribeQueriesResponse> DescribeQueriesAsync(DescribeQueriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeQueryDefinitions


        /// <summary>
        /// This operation returns a paginated list of your saved CloudWatch Logs Insights query
        /// definitions.
        /// 
        ///  
        /// <para>
        /// You can use the <code>queryDefinitionNamePrefix</code> parameter to limit the results
        /// to only the query definitions that have names that start with a certain string.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueryDefinitions service method.</param>
        /// 
        /// <returns>The response from the DescribeQueryDefinitions service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeQueryDefinitions">REST API Reference for DescribeQueryDefinitions Operation</seealso>
        DescribeQueryDefinitionsResponse DescribeQueryDefinitions(DescribeQueryDefinitionsRequest request);



        /// <summary>
        /// This operation returns a paginated list of your saved CloudWatch Logs Insights query
        /// definitions.
        /// 
        ///  
        /// <para>
        /// You can use the <code>queryDefinitionNamePrefix</code> parameter to limit the results
        /// to only the query definitions that have names that start with a certain string.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueryDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeQueryDefinitions service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeQueryDefinitions">REST API Reference for DescribeQueryDefinitions Operation</seealso>
        Task<DescribeQueryDefinitionsResponse> DescribeQueryDefinitionsAsync(DescribeQueryDefinitionsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Lists the resource policies in this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeResourcePolicies service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
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
        /// Lists the subscription filters for the specified log group. You can list all the subscription
        /// filters or filter the results by prefix. The results are ASCII-sorted by filter name.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscriptionFilters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<DescribeSubscriptionFiltersResponse> DescribeSubscriptionFiltersAsync(DescribeSubscriptionFiltersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DisassociateKmsKey


        /// <summary>
        /// Disassociates the associated KMS key from the specified log group.
        /// 
        ///  
        /// <para>
        /// After the KMS key is disassociated from the log group, CloudWatch Logs stops encrypting
        /// newly ingested data for the log group. All previously ingested data remains encrypted,
        /// and CloudWatch Logs requires permissions for the KMS key whenever the encrypted data
        /// is requested.
        /// </para>
        ///  
        /// <para>
        /// Note that it can take up to 5 minutes for this operation to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateKmsKey service method.</param>
        /// 
        /// <returns>The response from the DisassociateKmsKey service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DisassociateKmsKey">REST API Reference for DisassociateKmsKey Operation</seealso>
        DisassociateKmsKeyResponse DisassociateKmsKey(DisassociateKmsKeyRequest request);



        /// <summary>
        /// Disassociates the associated KMS key from the specified log group.
        /// 
        ///  
        /// <para>
        /// After the KMS key is disassociated from the log group, CloudWatch Logs stops encrypting
        /// newly ingested data for the log group. All previously ingested data remains encrypted,
        /// and CloudWatch Logs requires permissions for the KMS key whenever the encrypted data
        /// is requested.
        /// </para>
        ///  
        /// <para>
        /// Note that it can take up to 5 minutes for this operation to take effect.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateKmsKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateKmsKey service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DisassociateKmsKey">REST API Reference for DisassociateKmsKey Operation</seealso>
        Task<DisassociateKmsKeyResponse> DisassociateKmsKeyAsync(DisassociateKmsKeyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  FilterLogEvents


        /// <summary>
        /// Lists log events from the specified log group. You can list all the log events or
        /// filter the results using a filter pattern, a time range, and the name of the log stream.
        /// 
        ///  
        /// <para>
        /// You must have the <code>logs;FilterLogEvents</code> permission to perform this operation.
        /// </para>
        ///  
        /// <para>
        /// By default, this operation returns as many log events as can fit in 1 MB (up to 10,000
        /// log events) or all the events found within the specified time range. If the results
        /// include a token, that means there are more log events available. You can get additional
        /// results by specifying the token in a subsequent call. This operation can return empty
        /// results while there are more log events available through the token.
        /// </para>
        ///  
        /// <para>
        /// The returned log events are sorted by event timestamp, the timestamp when the event
        /// was ingested by CloudWatch Logs, and the ID of the <code>PutLogEvents</code> request.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
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
        /// Lists log events from the specified log group. You can list all the log events or
        /// filter the results using a filter pattern, a time range, and the name of the log stream.
        /// 
        ///  
        /// <para>
        /// You must have the <code>logs;FilterLogEvents</code> permission to perform this operation.
        /// </para>
        ///  
        /// <para>
        /// By default, this operation returns as many log events as can fit in 1 MB (up to 10,000
        /// log events) or all the events found within the specified time range. If the results
        /// include a token, that means there are more log events available. You can get additional
        /// results by specifying the token in a subsequent call. This operation can return empty
        /// results while there are more log events available through the token.
        /// </para>
        ///  
        /// <para>
        /// The returned log events are sorted by event timestamp, the timestamp when the event
        /// was ingested by CloudWatch Logs, and the ID of the <code>PutLogEvents</code> request.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the FilterLogEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<FilterLogEventsResponse> FilterLogEventsAsync(FilterLogEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDataProtectionPolicy


        /// <summary>
        /// Returns information about a log group data protection policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataProtectionPolicy service method.</param>
        /// 
        /// <returns>The response from the GetDataProtectionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDataProtectionPolicy">REST API Reference for GetDataProtectionPolicy Operation</seealso>
        GetDataProtectionPolicyResponse GetDataProtectionPolicy(GetDataProtectionPolicyRequest request);



        /// <summary>
        /// Returns information about a log group data protection policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDataProtectionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDataProtectionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDataProtectionPolicy">REST API Reference for GetDataProtectionPolicy Operation</seealso>
        Task<GetDataProtectionPolicyResponse> GetDataProtectionPolicyAsync(GetDataProtectionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLogEvents


        /// <summary>
        /// Lists log events from the specified log stream. You can list all of the log events
        /// or filter using a time range.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns as many log events as can fit in a response size
        /// of 1MB (up to 10,000 log events). You can get additional log events by specifying
        /// one of the tokens in a subsequent call. This operation can return empty results while
        /// there are more log events available through the token.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
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
        /// Lists log events from the specified log stream. You can list all of the log events
        /// or filter using a time range.
        /// 
        ///  
        /// <para>
        /// By default, this operation returns as many log events as can fit in a response size
        /// of 1MB (up to 10,000 log events). You can get additional log events by specifying
        /// one of the tokens in a subsequent call. This operation can return empty results while
        /// there are more log events available through the token.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<GetLogEventsResponse> GetLogEventsAsync(GetLogEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLogGroupFields


        /// <summary>
        /// Returns a list of the fields that are included in log events in the specified log
        /// group. Includes the percentage of log events that contain each field. The search is
        /// limited to a time period that you specify.
        /// 
        ///  
        /// <para>
        /// In the results, fields that start with <code>@</code> are fields generated by CloudWatch
        /// Logs. For example, <code>@timestamp</code> is the timestamp of each log event. For
        /// more information about the fields that are generated by CloudWatch logs, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_AnalyzeLogData-discoverable-fields.html">Supported
        /// Logs and Discovered Fields</a>.
        /// </para>
        ///  
        /// <para>
        /// The response results are sorted by the frequency percentage, starting with the highest
        /// percentage.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogGroupFields service method.</param>
        /// 
        /// <returns>The response from the GetLogGroupFields service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogGroupFields">REST API Reference for GetLogGroupFields Operation</seealso>
        GetLogGroupFieldsResponse GetLogGroupFields(GetLogGroupFieldsRequest request);



        /// <summary>
        /// Returns a list of the fields that are included in log events in the specified log
        /// group. Includes the percentage of log events that contain each field. The search is
        /// limited to a time period that you specify.
        /// 
        ///  
        /// <para>
        /// In the results, fields that start with <code>@</code> are fields generated by CloudWatch
        /// Logs. For example, <code>@timestamp</code> is the timestamp of each log event. For
        /// more information about the fields that are generated by CloudWatch logs, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_AnalyzeLogData-discoverable-fields.html">Supported
        /// Logs and Discovered Fields</a>.
        /// </para>
        ///  
        /// <para>
        /// The response results are sorted by the frequency percentage, starting with the highest
        /// percentage.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogGroupFields service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLogGroupFields service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogGroupFields">REST API Reference for GetLogGroupFields Operation</seealso>
        Task<GetLogGroupFieldsResponse> GetLogGroupFieldsAsync(GetLogGroupFieldsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLogRecord


        /// <summary>
        /// Retrieves all of the fields and values of a single log event. All fields are retrieved,
        /// even if the original query that produced the <code>logRecordPointer</code> retrieved
        /// only a subset of fields. Fields are returned as field name/field value pairs.
        /// 
        ///  
        /// <para>
        /// The full unparsed log event is returned within <code>@message</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogRecord service method.</param>
        /// 
        /// <returns>The response from the GetLogRecord service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogRecord">REST API Reference for GetLogRecord Operation</seealso>
        GetLogRecordResponse GetLogRecord(GetLogRecordRequest request);



        /// <summary>
        /// Retrieves all of the fields and values of a single log event. All fields are retrieved,
        /// even if the original query that produced the <code>logRecordPointer</code> retrieved
        /// only a subset of fields. Fields are returned as field name/field value pairs.
        /// 
        ///  
        /// <para>
        /// The full unparsed log event is returned within <code>@message</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogRecord service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLogRecord service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogRecord">REST API Reference for GetLogRecord Operation</seealso>
        Task<GetLogRecordResponse> GetLogRecordAsync(GetLogRecordRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetQueryResults


        /// <summary>
        /// Returns the results from the specified query.
        /// 
        ///  
        /// <para>
        /// Only the fields requested in the query are returned, along with a <code>@ptr</code>
        /// field, which is the identifier for the log record. You can use the value of <code>@ptr</code>
        /// in a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogRecord.html">GetLogRecord</a>
        /// operation to get the full log record.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetQueryResults</code> does not start running a query. To run a query, use
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>.
        /// </para>
        ///  
        /// <para>
        /// If the value of the <code>Status</code> field in the output is <code>Running</code>,
        /// this operation returns only partial results. If you see a value of <code>Scheduled</code>
        /// or <code>Running</code> for the status, you can retry the operation later to see the
        /// final results. 
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account to start queries in linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        GetQueryResultsResponse GetQueryResults(GetQueryResultsRequest request);



        /// <summary>
        /// Returns the results from the specified query.
        /// 
        ///  
        /// <para>
        /// Only the fields requested in the query are returned, along with a <code>@ptr</code>
        /// field, which is the identifier for the log record. You can use the value of <code>@ptr</code>
        /// in a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogRecord.html">GetLogRecord</a>
        /// operation to get the full log record.
        /// </para>
        ///  
        /// <para>
        ///  <code>GetQueryResults</code> does not start running a query. To run a query, use
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>.
        /// </para>
        ///  
        /// <para>
        /// If the value of the <code>Status</code> field in the output is <code>Running</code>,
        /// this operation returns only partial results. If you see a value of <code>Scheduled</code>
        /// or <code>Running</code> for the status, you can retry the operation later to see the
        /// final results. 
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account to start queries in linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueryResults service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Displays the tags associated with a CloudWatch Logs resource. Currently, log groups
        /// and destinations support tagging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);



        /// <summary>
        /// Displays the tags associated with a CloudWatch Logs resource. Currently, log groups
        /// and destinations support tagging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListTagsLogGroup


        /// <summary>
        /// <important> 
        /// <para>
        /// The ListTagsLogGroup operation is on the path to deprecation. We recommend that you
        /// use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>
        /// instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists the tags for the specified log group.
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
        [Obsolete("Please use the generic tagging API ListTagsForResource")]
        ListTagsLogGroupResponse ListTagsLogGroup(ListTagsLogGroupRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// The ListTagsLogGroup operation is on the path to deprecation. We recommend that you
        /// use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>
        /// instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// Lists the tags for the specified log group.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsLogGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListTagsLogGroup">REST API Reference for ListTagsLogGroup Operation</seealso>
        [Obsolete("Please use the generic tagging API ListTagsForResource")]
        Task<ListTagsLogGroupResponse> ListTagsLogGroupAsync(ListTagsLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDataProtectionPolicy


        /// <summary>
        /// Creates a data protection policy for the specified log group. A data protection policy
        /// can help safeguard sensitive data that's ingested by the log group by auditing and
        /// masking the sensitive log data.
        /// 
        ///  <important> 
        /// <para>
        /// Sensitive data is detected and masked when it is ingested into the log group. When
        /// you set a data protection policy, log events ingested into the log group before that
        /// time are not masked.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, when a user views a log event that includes masked data, the sensitive
        /// data is replaced by asterisks. A user who has the <code>logs:Unmask</code> permission
        /// can use a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_FilterLogEvents.html">FilterLogEvents</a>
        /// operation with the <code>unmask</code> parameter set to <code>true</code> to view
        /// the unmasked log events. Users with the <code>logs:Unmask</code> can also view unmasked
        /// data in the CloudWatch Logs console by running a CloudWatch Logs Insights query with
        /// the <code>unmask</code> query command.
        /// </para>
        ///  
        /// <para>
        /// For more information, including a list of types of data that can be audited and masked,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Protect
        /// sensitive log data with masking</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataProtectionPolicy service method.</param>
        /// 
        /// <returns>The response from the PutDataProtectionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDataProtectionPolicy">REST API Reference for PutDataProtectionPolicy Operation</seealso>
        PutDataProtectionPolicyResponse PutDataProtectionPolicy(PutDataProtectionPolicyRequest request);



        /// <summary>
        /// Creates a data protection policy for the specified log group. A data protection policy
        /// can help safeguard sensitive data that's ingested by the log group by auditing and
        /// masking the sensitive log data.
        /// 
        ///  <important> 
        /// <para>
        /// Sensitive data is detected and masked when it is ingested into the log group. When
        /// you set a data protection policy, log events ingested into the log group before that
        /// time are not masked.
        /// </para>
        ///  </important> 
        /// <para>
        /// By default, when a user views a log event that includes masked data, the sensitive
        /// data is replaced by asterisks. A user who has the <code>logs:Unmask</code> permission
        /// can use a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_FilterLogEvents.html">FilterLogEvents</a>
        /// operation with the <code>unmask</code> parameter set to <code>true</code> to view
        /// the unmasked log events. Users with the <code>logs:Unmask</code> can also view unmasked
        /// data in the CloudWatch Logs console by running a CloudWatch Logs Insights query with
        /// the <code>unmask</code> query command.
        /// </para>
        ///  
        /// <para>
        /// For more information, including a list of types of data that can be audited and masked,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Protect
        /// sensitive log data with masking</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDataProtectionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDataProtectionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDataProtectionPolicy">REST API Reference for PutDataProtectionPolicy Operation</seealso>
        Task<PutDataProtectionPolicyResponse> PutDataProtectionPolicyAsync(PutDataProtectionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDestination


        /// <summary>
        /// Creates or updates a destination. This operation is used only to create destinations
        /// for cross-account subscriptions.
        /// 
        ///  
        /// <para>
        /// A destination encapsulates a physical resource (such as an Amazon Kinesis stream).
        /// With a destination, you can subscribe to a real-time stream of log events for a different
        /// account, ingested using <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutLogEvents.html">PutLogEvents</a>.
        /// </para>
        ///  
        /// <para>
        /// Through an access policy, a destination controls what is written to it. By default,
        /// <code>PutDestination</code> does not set any access policy with the destination, which
        /// means a cross-account user cannot call <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutSubscriptionFilter.html">PutSubscriptionFilter</a>
        /// against this destination. To enable this, the destination owner must call <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestinationPolicy.html">PutDestinationPolicy</a>
        /// after <code>PutDestination</code>.
        /// </para>
        ///  
        /// <para>
        /// To perform a <code>PutDestination</code> operation, you must also have the <code>iam:PassRole</code>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDestination service method.</param>
        /// 
        /// <returns>The response from the PutDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestination">REST API Reference for PutDestination Operation</seealso>
        PutDestinationResponse PutDestination(PutDestinationRequest request);



        /// <summary>
        /// Creates or updates a destination. This operation is used only to create destinations
        /// for cross-account subscriptions.
        /// 
        ///  
        /// <para>
        /// A destination encapsulates a physical resource (such as an Amazon Kinesis stream).
        /// With a destination, you can subscribe to a real-time stream of log events for a different
        /// account, ingested using <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutLogEvents.html">PutLogEvents</a>.
        /// </para>
        ///  
        /// <para>
        /// Through an access policy, a destination controls what is written to it. By default,
        /// <code>PutDestination</code> does not set any access policy with the destination, which
        /// means a cross-account user cannot call <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutSubscriptionFilter.html">PutSubscriptionFilter</a>
        /// against this destination. To enable this, the destination owner must call <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestinationPolicy.html">PutDestinationPolicy</a>
        /// after <code>PutDestination</code>.
        /// </para>
        ///  
        /// <para>
        /// To perform a <code>PutDestination</code> operation, you must also have the <code>iam:PassRole</code>
        /// permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestination">REST API Reference for PutDestination Operation</seealso>
        Task<PutDestinationResponse> PutDestinationAsync(PutDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDestinationPolicy


        /// <summary>
        /// Creates or updates an access policy associated with an existing destination. An access
        /// policy is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies_overview.html">IAM
        /// policy document</a> that is used to authorize claims to register a subscription filter
        /// against a given destination.
        /// 
        ///  
        /// <para>
        /// If multiple Amazon Web Services accounts are sending logs to this destination, each
        /// sender account must be listed separately in the policy. The policy does not support
        /// specifying <code>*</code> as the Principal or the use of the <code>aws:PrincipalOrgId</code>
        /// global key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDestinationPolicy service method.</param>
        /// 
        /// <returns>The response from the PutDestinationPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestinationPolicy">REST API Reference for PutDestinationPolicy Operation</seealso>
        PutDestinationPolicyResponse PutDestinationPolicy(PutDestinationPolicyRequest request);



        /// <summary>
        /// Creates or updates an access policy associated with an existing destination. An access
        /// policy is an <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/policies_overview.html">IAM
        /// policy document</a> that is used to authorize claims to register a subscription filter
        /// against a given destination.
        /// 
        ///  
        /// <para>
        /// If multiple Amazon Web Services accounts are sending logs to this destination, each
        /// sender account must be listed separately in the policy. The policy does not support
        /// specifying <code>*</code> as the Principal or the use of the <code>aws:PrincipalOrgId</code>
        /// global key.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDestinationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDestinationPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
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
        /// also get the sequence token in the <code>expectedSequenceToken</code> field from <code>InvalidSequenceTokenException</code>.
        /// If you call <code>PutLogEvents</code> twice within a narrow time period using the
        /// same value for <code>sequenceToken</code>, both calls might be successful or one might
        /// be rejected.
        /// </para>
        ///  
        /// <para>
        /// The batch of events must satisfy the following constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The maximum batch size is 1,048,576 bytes. This size is calculated as the sum of all
        /// event messages in UTF-8, plus 26 bytes for each log event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None of the log events in the batch can be more than 2 hours in the future.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None of the log events in the batch can be more than 14 days in the past. Also, none
        /// of the log events can be from earlier than the retention period of the log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The log events in the batch must be in chronological order by their timestamp. The
        /// timestamp is the time that the event occurred, expressed as the number of milliseconds
        /// after <code>Jan 1, 1970 00:00:00 UTC</code>. (In Amazon Web Services Tools for PowerShell
        /// and the Amazon Web Services SDK for .NET, the timestamp is specified in .NET format:
        /// <code>yyyy-mm-ddThh:mm:ss</code>. For example, <code>2017-09-15T13:45:30</code>.)
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A batch of log events in a single request cannot span more than 24 hours. Otherwise,
        /// the operation fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum number of log events in a batch is 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a quota of five requests per second per log stream. Additional requests are
        /// throttled. This quota can't be changed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a call to <code>PutLogEvents</code> returns "UnrecognizedClientException" the most
        /// likely cause is a non-valid Amazon Web Services access key ID or secret key. 
        /// </para>
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
        /// The sequence token is not valid. You can get the correct sequence token in the <code>expectedSequenceToken</code>
        /// field in the <code>InvalidSequenceTokenException</code> message.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.UnrecognizedClientException">
        /// The most likely cause is an Amazon Web Services access key ID or secret key that's
        /// not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutLogEvents">REST API Reference for PutLogEvents Operation</seealso>
        PutLogEventsResponse PutLogEvents(PutLogEventsRequest request);



        /// <summary>
        /// Uploads a batch of log events to the specified log stream.
        /// 
        ///  
        /// <para>
        /// You must include the sequence token obtained from the response of the previous call.
        /// An upload in a newly created log stream does not require a sequence token. You can
        /// also get the sequence token in the <code>expectedSequenceToken</code> field from <code>InvalidSequenceTokenException</code>.
        /// If you call <code>PutLogEvents</code> twice within a narrow time period using the
        /// same value for <code>sequenceToken</code>, both calls might be successful or one might
        /// be rejected.
        /// </para>
        ///  
        /// <para>
        /// The batch of events must satisfy the following constraints:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The maximum batch size is 1,048,576 bytes. This size is calculated as the sum of all
        /// event messages in UTF-8, plus 26 bytes for each log event.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None of the log events in the batch can be more than 2 hours in the future.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// None of the log events in the batch can be more than 14 days in the past. Also, none
        /// of the log events can be from earlier than the retention period of the log group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The log events in the batch must be in chronological order by their timestamp. The
        /// timestamp is the time that the event occurred, expressed as the number of milliseconds
        /// after <code>Jan 1, 1970 00:00:00 UTC</code>. (In Amazon Web Services Tools for PowerShell
        /// and the Amazon Web Services SDK for .NET, the timestamp is specified in .NET format:
        /// <code>yyyy-mm-ddThh:mm:ss</code>. For example, <code>2017-09-15T13:45:30</code>.)
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A batch of log events in a single request cannot span more than 24 hours. Otherwise,
        /// the operation fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum number of log events in a batch is 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// There is a quota of five requests per second per log stream. Additional requests are
        /// throttled. This quota can't be changed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If a call to <code>PutLogEvents</code> returns "UnrecognizedClientException" the most
        /// likely cause is a non-valid Amazon Web Services access key ID or secret key. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLogEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutLogEvents service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.DataAlreadyAcceptedException">
        /// The event was already logged.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidSequenceTokenException">
        /// The sequence token is not valid. You can get the correct sequence token in the <code>expectedSequenceToken</code>
        /// field in the <code>InvalidSequenceTokenException</code> message.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.UnrecognizedClientException">
        /// The most likely cause is an Amazon Web Services access key ID or secret key that's
        /// not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutLogEvents">REST API Reference for PutLogEvents Operation</seealso>
        Task<PutLogEventsResponse> PutLogEventsAsync(PutLogEventsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutMetricFilter


        /// <summary>
        /// Creates or updates a metric filter and associates it with the specified log group.
        /// With metric filters, you can configure rules to extract metric data from log events
        /// ingested through <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutLogEvents.html">PutLogEvents</a>.
        /// 
        ///  
        /// <para>
        /// The maximum number of metric filters that can be associated with a log group is 100.
        /// </para>
        ///  
        /// <para>
        /// When you create a metric filter, you can also optionally assign a unit and dimensions
        /// to the metric that is created.
        /// </para>
        ///  <important> 
        /// <para>
        /// Metrics extracted from log events are charged as custom metrics. To prevent unexpected
        /// high charges, do not specify high-cardinality fields such as <code>IPAddress</code>
        /// or <code>requestID</code> as dimensions. Each different value found for a dimension
        /// is treated as a separate metric and accrues charges as a separate custom metric. 
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs disables a metric filter if it generates 1,000 different name/value
        /// pairs for your specified dimensions within a certain amount of time. This helps to
        /// prevent accidental high charges.
        /// </para>
        ///  
        /// <para>
        /// You can also set up a billing alarm to alert you if your charges are higher than expected.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/monitor_estimated_charges_with_cloudwatch.html">
        /// Creating a Billing Alarm to Monitor Your Estimated Amazon Web Services Charges</a>.
        /// 
        /// </para>
        ///  </important>
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
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Creates or updates a metric filter and associates it with the specified log group.
        /// With metric filters, you can configure rules to extract metric data from log events
        /// ingested through <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutLogEvents.html">PutLogEvents</a>.
        /// 
        ///  
        /// <para>
        /// The maximum number of metric filters that can be associated with a log group is 100.
        /// </para>
        ///  
        /// <para>
        /// When you create a metric filter, you can also optionally assign a unit and dimensions
        /// to the metric that is created.
        /// </para>
        ///  <important> 
        /// <para>
        /// Metrics extracted from log events are charged as custom metrics. To prevent unexpected
        /// high charges, do not specify high-cardinality fields such as <code>IPAddress</code>
        /// or <code>requestID</code> as dimensions. Each different value found for a dimension
        /// is treated as a separate metric and accrues charges as a separate custom metric. 
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs disables a metric filter if it generates 1,000 different name/value
        /// pairs for your specified dimensions within a certain amount of time. This helps to
        /// prevent accidental high charges.
        /// </para>
        ///  
        /// <para>
        /// You can also set up a billing alarm to alert you if your charges are higher than expected.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/monitor_estimated_charges_with_cloudwatch.html">
        /// Creating a Billing Alarm to Monitor Your Estimated Amazon Web Services Charges</a>.
        /// 
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMetricFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMetricFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutMetricFilter">REST API Reference for PutMetricFilter Operation</seealso>
        Task<PutMetricFilterResponse> PutMetricFilterAsync(PutMetricFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutQueryDefinition


        /// <summary>
        /// Creates or updates a query definition for CloudWatch Logs Insights. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AnalyzingLogData.html">Analyzing
        /// Log Data with CloudWatch Logs Insights</a>.
        /// 
        ///  
        /// <para>
        /// To update a query definition, specify its <code>queryDefinitionId</code> in your request.
        /// The values of <code>name</code>, <code>queryString</code>, and <code>logGroupNames</code>
        /// are changed to the values that you specify in your update operation. No current values
        /// are retained from the current query definition. For example, imagine updating a current
        /// query definition that includes log groups. If you don't specify the <code>logGroupNames</code>
        /// parameter in your update operation, the query definition changes to contain no log
        /// groups.
        /// </para>
        ///  
        /// <para>
        /// You must have the <code>logs:PutQueryDefinition</code> permission to be able to perform
        /// this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutQueryDefinition service method.</param>
        /// 
        /// <returns>The response from the PutQueryDefinition service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutQueryDefinition">REST API Reference for PutQueryDefinition Operation</seealso>
        PutQueryDefinitionResponse PutQueryDefinition(PutQueryDefinitionRequest request);



        /// <summary>
        /// Creates or updates a query definition for CloudWatch Logs Insights. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AnalyzingLogData.html">Analyzing
        /// Log Data with CloudWatch Logs Insights</a>.
        /// 
        ///  
        /// <para>
        /// To update a query definition, specify its <code>queryDefinitionId</code> in your request.
        /// The values of <code>name</code>, <code>queryString</code>, and <code>logGroupNames</code>
        /// are changed to the values that you specify in your update operation. No current values
        /// are retained from the current query definition. For example, imagine updating a current
        /// query definition that includes log groups. If you don't specify the <code>logGroupNames</code>
        /// parameter in your update operation, the query definition changes to contain no log
        /// groups.
        /// </para>
        ///  
        /// <para>
        /// You must have the <code>logs:PutQueryDefinition</code> permission to be able to perform
        /// this operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutQueryDefinition service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutQueryDefinition service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutQueryDefinition">REST API Reference for PutQueryDefinition Operation</seealso>
        Task<PutQueryDefinitionResponse> PutQueryDefinitionAsync(PutQueryDefinitionRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutResourcePolicy


        /// <summary>
        /// Creates or updates a resource policy allowing other Amazon Web Services services to
        /// put log events to this account, such as Amazon Route 53. An account can have up to
        /// 10 resource policies per Amazon Web Services Region.
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
        /// Creates or updates a resource policy allowing other Amazon Web Services services to
        /// put log events to this account, such as Amazon Route 53. An account can have up to
        /// 10 resource policies per Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutRetentionPolicy


        /// <summary>
        /// Sets the retention of the specified log group. With a retention policy, you can configure
        /// the number of days for which to retain log events in the specified log group.
        /// 
        ///  <note> 
        /// <para>
        /// CloudWatch Logs doesn’t immediately delete log events when they reach their retention
        /// setting. It typically takes up to 72 hours after that before log events are deleted,
        /// but in rare situations might take longer.
        /// </para>
        ///  
        /// <para>
        /// To illustrate, imagine that you change a log group to have a longer retention setting
        /// when it contains log events that are past the expiration date, but haven’t been deleted.
        /// Those log events will take up to 72 hours to be deleted after the new retention date
        /// is reached. To make sure that log data is deleted permanently, keep a log group at
        /// its lower retention setting until 72 hours after the previous retention period ends.
        /// Alternatively, wait to change the retention setting until you confirm that the earlier
        /// log events are deleted. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy service method.</param>
        /// 
        /// <returns>The response from the PutRetentionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Sets the retention of the specified log group. With a retention policy, you can configure
        /// the number of days for which to retain log events in the specified log group.
        /// 
        ///  <note> 
        /// <para>
        /// CloudWatch Logs doesn’t immediately delete log events when they reach their retention
        /// setting. It typically takes up to 72 hours after that before log events are deleted,
        /// but in rare situations might take longer.
        /// </para>
        ///  
        /// <para>
        /// To illustrate, imagine that you change a log group to have a longer retention setting
        /// when it contains log events that are past the expiration date, but haven’t been deleted.
        /// Those log events will take up to 72 hours to be deleted after the new retention date
        /// is reached. To make sure that log data is deleted permanently, keep a log group at
        /// its lower retention setting until 72 hours after the previous retention period ends.
        /// Alternatively, wait to change the retention setting until you confirm that the earlier
        /// log events are deleted. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRetentionPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutRetentionPolicy">REST API Reference for PutRetentionPolicy Operation</seealso>
        Task<PutRetentionPolicyResponse> PutRetentionPolicyAsync(PutRetentionPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutSubscriptionFilter


        /// <summary>
        /// Creates or updates a subscription filter and associates it with the specified log
        /// group. With subscription filters, you can subscribe to a real-time stream of log events
        /// ingested through <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutLogEvents.html">PutLogEvents</a>
        /// and have them delivered to a specific destination. When log events are sent to the
        /// receiving service, they are Base64 encoded and compressed with the GZIP format.
        /// 
        ///  
        /// <para>
        /// The following destinations are supported for subscription filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Kinesis data stream belonging to the same account as the subscription filter,
        /// for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A logical destination that belongs to a different account, for cross-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Kinesis Data Firehose delivery stream that belongs to the same account as
        /// the subscription filter, for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Lambda function that belongs to the same account as the subscription filter, for
        /// same-account delivery.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each log group can have up to two subscription filters associated with it. If you
        /// are updating an existing filter, you must specify the correct name in <code>filterName</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To perform a <code>PutSubscriptionFilter</code> operation, you must also have the
        /// <code>iam:PassRole</code> permission.
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
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// Creates or updates a subscription filter and associates it with the specified log
        /// group. With subscription filters, you can subscribe to a real-time stream of log events
        /// ingested through <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutLogEvents.html">PutLogEvents</a>
        /// and have them delivered to a specific destination. When log events are sent to the
        /// receiving service, they are Base64 encoded and compressed with the GZIP format.
        /// 
        ///  
        /// <para>
        /// The following destinations are supported for subscription filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon Kinesis data stream belonging to the same account as the subscription filter,
        /// for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A logical destination that belongs to a different account, for cross-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon Kinesis Data Firehose delivery stream that belongs to the same account as
        /// the subscription filter, for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Lambda function that belongs to the same account as the subscription filter, for
        /// same-account delivery.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each log group can have up to two subscription filters associated with it. If you
        /// are updating an existing filter, you must specify the correct name in <code>filterName</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To perform a <code>PutSubscriptionFilter</code> operation, you must also have the
        /// <code>iam:PassRole</code> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSubscriptionFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSubscriptionFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutSubscriptionFilter">REST API Reference for PutSubscriptionFilter Operation</seealso>
        Task<PutSubscriptionFilterResponse> PutSubscriptionFilterAsync(PutSubscriptionFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartQuery


        /// <summary>
        /// Schedules a query of a log group using CloudWatch Logs Insights. You specify the log
        /// group and time range to query and the query string to use.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax.html">CloudWatch
        /// Logs Insights Query Syntax</a>.
        /// </para>
        ///  
        /// <para>
        /// Queries time out after 15 minutes of runtime. If your queries are timing out, reduce
        /// the time range being searched or partition your query into a number of queries.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account to start a query in a linked source account. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>. For a cross-account <code>StartQuery</code> operation,
        /// the query definition must be defined in the monitoring account.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 20 concurrent CloudWatch Logs insights queries, including queries
        /// that have been added to dashboards. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQuery service method.</param>
        /// 
        /// <returns>The response from the StartQuery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.MalformedQueryException">
        /// The query string is not valid. Details about this error are displayed in a <code>QueryCompileError</code>
        /// object. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_QueryCompileError.html">QueryCompileError</a>.
        /// 
        ///  
        /// <para>
        /// For more information about valid query syntax, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax.html">CloudWatch
        /// Logs Insights Query Syntax</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StartQuery">REST API Reference for StartQuery Operation</seealso>
        StartQueryResponse StartQuery(StartQueryRequest request);



        /// <summary>
        /// Schedules a query of a log group using CloudWatch Logs Insights. You specify the log
        /// group and time range to query and the query string to use.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax.html">CloudWatch
        /// Logs Insights Query Syntax</a>.
        /// </para>
        ///  
        /// <para>
        /// Queries time out after 15 minutes of runtime. If your queries are timing out, reduce
        /// the time range being searched or partition your query into a number of queries.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account to start a query in a linked source account. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>. For a cross-account <code>StartQuery</code> operation,
        /// the query definition must be defined in the monitoring account.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 20 concurrent CloudWatch Logs insights queries, including queries
        /// that have been added to dashboards. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartQuery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.MalformedQueryException">
        /// The query string is not valid. Details about this error are displayed in a <code>QueryCompileError</code>
        /// object. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_QueryCompileError.html">QueryCompileError</a>.
        /// 
        ///  
        /// <para>
        /// For more information about valid query syntax, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax.html">CloudWatch
        /// Logs Insights Query Syntax</a>.
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StartQuery">REST API Reference for StartQuery Operation</seealso>
        Task<StartQueryResponse> StartQueryAsync(StartQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StopQuery


        /// <summary>
        /// Stops a CloudWatch Logs Insights query that is in progress. If the query has already
        /// ended, the operation returns an error indicating that the specified query is not running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQuery service method.</param>
        /// 
        /// <returns>The response from the StopQuery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StopQuery">REST API Reference for StopQuery Operation</seealso>
        StopQueryResponse StopQuery(StopQueryRequest request);



        /// <summary>
        /// Stops a CloudWatch Logs Insights query that is in progress. If the query has already
        /// ended, the operation returns an error indicating that the specified query is not running.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopQuery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StopQuery">REST API Reference for StopQuery Operation</seealso>
        Task<StopQueryResponse> StopQueryAsync(StopQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagLogGroup


        /// <summary>
        /// <important> 
        /// <para>
        /// The TagLogGroup operation is on the path to deprecation. We recommend that you use
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_TagResource.html">TagResource</a>
        /// instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// Adds or updates the specified tags for the specified log group.
        /// </para>
        ///  
        /// <para>
        /// To list the tags for a log group, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>.
        /// To remove tags, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Working-with-log-groups-and-streams.html#log-group-tagging">Tag
        /// Log Groups in Amazon CloudWatch Logs</a> in the <i>Amazon CloudWatch Logs User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs doesn’t support IAM policies that prevent users from assigning specified
        /// tags to log groups using the <code>aws:Resource/<i>key-name</i> </code> or <code>aws:TagKeys</code>
        /// condition keys. For more information about using tags to control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
        /// access to Amazon Web Services resources using tags</a>.
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
        [Obsolete("Please use the generic tagging API TagResource")]
        TagLogGroupResponse TagLogGroup(TagLogGroupRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// The TagLogGroup operation is on the path to deprecation. We recommend that you use
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_TagResource.html">TagResource</a>
        /// instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// Adds or updates the specified tags for the specified log group.
        /// </para>
        ///  
        /// <para>
        /// To list the tags for a log group, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>.
        /// To remove tags, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Working-with-log-groups-and-streams.html#log-group-tagging">Tag
        /// Log Groups in Amazon CloudWatch Logs</a> in the <i>Amazon CloudWatch Logs User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs doesn’t support IAM policies that prevent users from assigning specified
        /// tags to log groups using the <code>aws:Resource/<i>key-name</i> </code> or <code>aws:TagKeys</code>
        /// condition keys. For more information about using tags to control access, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
        /// access to Amazon Web Services resources using tags</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagLogGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TagLogGroup">REST API Reference for TagLogGroup Operation</seealso>
        [Obsolete("Please use the generic tagging API TagResource")]
        Task<TagLogGroupResponse> TagLogGroupAsync(TagLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch Logs resource.
        /// Currently, the only CloudWatch Logs resources that can be tagged are log groups and
        /// destinations. 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a resource that already has tags.
        /// If you specify a new tag key for the alarm, this tag is appended to the list of tags
        /// associated with the alarm. If you specify a tag key that is already associated with
        /// the alarm, the new tag value that you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a CloudWatch Logs resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.TooManyTagsException">
        /// A resource can have no more than 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);



        /// <summary>
        /// Assigns one or more tags (key-value pairs) to the specified CloudWatch Logs resource.
        /// Currently, the only CloudWatch Logs resources that can be tagged are log groups and
        /// destinations. 
        /// 
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  
        /// <para>
        /// You can use the <code>TagResource</code> action with a resource that already has tags.
        /// If you specify a new tag key for the alarm, this tag is appended to the list of tags
        /// associated with the alarm. If you specify a tag key that is already associated with
        /// the alarm, the new tag value that you specify replaces the previous value for that
        /// tag.
        /// </para>
        ///  
        /// <para>
        /// You can associate as many as 50 tags with a CloudWatch Logs resource.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.TooManyTagsException">
        /// A resource can have no more than 50 tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TagResource">REST API Reference for TagResource Operation</seealso>
        Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Tests the filter pattern of a metric filter against a sample of log event messages.
        /// You can use this operation to validate the correctness of a metric filter pattern.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestMetricFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestMetricFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TestMetricFilter">REST API Reference for TestMetricFilter Operation</seealso>
        Task<TestMetricFilterResponse> TestMetricFilterAsync(TestMetricFilterRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagLogGroup


        /// <summary>
        /// <important> 
        /// <para>
        /// The UntagLogGroup operation is on the path to deprecation. We recommend that you use
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UntagResource.html">UntagResource</a>
        /// instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// Removes the specified tags from the specified log group.
        /// </para>
        ///  
        /// <para>
        /// To list the tags for a log group, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>.
        /// To add tags, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs doesn’t support IAM policies that prevent users from assigning specified
        /// tags to log groups using the <code>aws:Resource/<i>key-name</i> </code> or <code>aws:TagKeys</code>
        /// condition keys. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagLogGroup service method.</param>
        /// 
        /// <returns>The response from the UntagLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagLogGroup">REST API Reference for UntagLogGroup Operation</seealso>
        [Obsolete("Please use the generic tagging API UntagResource")]
        UntagLogGroupResponse UntagLogGroup(UntagLogGroupRequest request);



        /// <summary>
        /// <important> 
        /// <para>
        /// The UntagLogGroup operation is on the path to deprecation. We recommend that you use
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UntagResource.html">UntagResource</a>
        /// instead.
        /// </para>
        ///  </important> 
        /// <para>
        /// Removes the specified tags from the specified log group.
        /// </para>
        ///  
        /// <para>
        /// To list the tags for a log group, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_ListTagsForResource.html">ListTagsForResource</a>.
        /// To add tags, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_TagResource.html">TagResource</a>.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs doesn’t support IAM policies that prevent users from assigning specified
        /// tags to log groups using the <code>aws:Resource/<i>key-name</i> </code> or <code>aws:TagKeys</code>
        /// condition keys. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagLogGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagLogGroup service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagLogGroup">REST API Reference for UntagLogGroup Operation</seealso>
        [Obsolete("Please use the generic tagging API UntagResource")]
        Task<UntagLogGroupResponse> UntagLogGroupAsync(UntagLogGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);



        /// <summary>
        /// Removes one or more tags from the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}