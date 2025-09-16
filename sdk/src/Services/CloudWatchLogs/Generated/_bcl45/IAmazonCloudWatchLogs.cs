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

#pragma warning disable CS1570
namespace Amazon.CloudWatchLogs
{
    /// <summary>
    /// <para>Interface for accessing CloudWatchLogs</para>
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
        /// Associates the specified KMS key with either one log group in the account, or with
        /// all stored CloudWatch Logs query insights results in the account.
        /// 
        ///  
        /// <para>
        /// When you use <c>AssociateKmsKey</c>, you specify either the <c>logGroupName</c> parameter
        /// or the <c>resourceIdentifier</c> parameter. You can't specify both of those parameters
        /// in the same operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>logGroupName</c> parameter to cause log events ingested into that log
        /// group to be encrypted with that key. Only the log events ingested after the key is
        /// associated are encrypted with that key.
        /// </para>
        ///  
        /// <para>
        /// Associating a KMS key with a log group overrides any existing associations between
        /// the log group and a KMS key. After a KMS key is associated with a log group, all newly
        /// ingested data for the log group is encrypted using the KMS key. This association is
        /// stored as long as the data encrypted with the KMS key is still within CloudWatch Logs.
        /// This enables CloudWatch Logs to decrypt this data whenever it is requested.
        /// </para>
        ///  
        /// <para>
        /// Associating a key with a log group does not cause the results of queries of that log
        /// group to be encrypted with that key. To have query results encrypted with a KMS key,
        /// you must use an <c>AssociateKmsKey</c> operation with the <c>resourceIdentifier</c>
        /// parameter that specifies a <c>query-result</c> resource. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the <c>resourceIdentifier</c> parameter with a <c>query-result</c> resource,
        /// to use that key to encrypt the stored results of all future <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
        /// operations in the account. The response from a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetQueryResults.html">GetQueryResults</a>
        /// operation will still return the query results in plain text.
        /// </para>
        ///  
        /// <para>
        /// Even if you have not associated a key with your query results, the query results are
        /// encrypted when stored, using the default CloudWatch Logs method.
        /// </para>
        ///  
        /// <para>
        /// If you run a query from a monitoring account that queries logs in a source account,
        /// the query results key from the monitoring account, if any, is used.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If you delete the key that is used to encrypt log events or log group query results,
        /// then all the associated stored log events or query results that were encrypted with
        /// that key will be unencryptable and unusable.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// CloudWatch Logs supports only symmetric KMS keys. Do not associate an asymmetric KMS
        /// key with your log group or query results. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric Keys</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// It can take up to 5 minutes for this operation to take effect.
        /// </para>
        ///  
        /// <para>
        /// If you attempt to associate a KMS key with a log group but the KMS key does not exist
        /// or the KMS key is disabled, you receive an <c>InvalidParameterException</c> error.
        /// 
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
        /// Associates the specified KMS key with either one log group in the account, or with
        /// all stored CloudWatch Logs query insights results in the account.
        /// 
        ///  
        /// <para>
        /// When you use <c>AssociateKmsKey</c>, you specify either the <c>logGroupName</c> parameter
        /// or the <c>resourceIdentifier</c> parameter. You can't specify both of those parameters
        /// in the same operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>logGroupName</c> parameter to cause log events ingested into that log
        /// group to be encrypted with that key. Only the log events ingested after the key is
        /// associated are encrypted with that key.
        /// </para>
        ///  
        /// <para>
        /// Associating a KMS key with a log group overrides any existing associations between
        /// the log group and a KMS key. After a KMS key is associated with a log group, all newly
        /// ingested data for the log group is encrypted using the KMS key. This association is
        /// stored as long as the data encrypted with the KMS key is still within CloudWatch Logs.
        /// This enables CloudWatch Logs to decrypt this data whenever it is requested.
        /// </para>
        ///  
        /// <para>
        /// Associating a key with a log group does not cause the results of queries of that log
        /// group to be encrypted with that key. To have query results encrypted with a KMS key,
        /// you must use an <c>AssociateKmsKey</c> operation with the <c>resourceIdentifier</c>
        /// parameter that specifies a <c>query-result</c> resource. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the <c>resourceIdentifier</c> parameter with a <c>query-result</c> resource,
        /// to use that key to encrypt the stored results of all future <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
        /// operations in the account. The response from a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetQueryResults.html">GetQueryResults</a>
        /// operation will still return the query results in plain text.
        /// </para>
        ///  
        /// <para>
        /// Even if you have not associated a key with your query results, the query results are
        /// encrypted when stored, using the default CloudWatch Logs method.
        /// </para>
        ///  
        /// <para>
        /// If you run a query from a monitoring account that queries logs in a source account,
        /// the query results key from the monitoring account, if any, is used.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If you delete the key that is used to encrypt log events or log group query results,
        /// then all the associated stored log events or query results that were encrypted with
        /// that key will be unencryptable and unusable.
        /// </para>
        ///  </important> <note> 
        /// <para>
        /// CloudWatch Logs supports only symmetric KMS keys. Do not associate an asymmetric KMS
        /// key with your log group or query results. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
        /// Symmetric and Asymmetric Keys</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// It can take up to 5 minutes for this operation to take effect.
        /// </para>
        ///  
        /// <para>
        /// If you attempt to associate a KMS key with a log group but the KMS key does not exist
        /// or the KMS key is disabled, you receive an <c>InvalidParameterException</c> error.
        /// 
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
        /// The task must be in the <c>PENDING</c> or <c>RUNNING</c> state.
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
        /// The task must be in the <c>PENDING</c> or <c>RUNNING</c> state.
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
        
        #region  CreateDelivery


        /// <summary>
        /// Creates a <i>delivery</i>. A delivery is a connection between a logical <i>delivery
        /// source</i> and a logical <i>delivery destination</i> that you have already created.
        /// 
        ///  
        /// <para>
        /// Only some Amazon Web Services services support being configured as a delivery source
        /// using this operation. These services are listed as <b>Supported [V2 Permissions]</b>
        /// in the table at <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        ///  
        /// <para>
        /// A delivery destination can represent a log group in CloudWatch Logs, an Amazon S3
        /// bucket, a delivery stream in Firehose, or X-Ray.
        /// </para>
        ///  
        /// <para>
        /// To configure logs delivery between a supported Amazon Web Services service and a destination,
        /// you must do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a delivery source, which is a logical object that represents the resource that
        /// is actually sending the logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <i>delivery destination</i>, which is a logical object that represents the
        /// actual delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">PutDeliveryDestination</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are delivering logs cross-account, you must use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>
        /// in the destination account to assign an IAM policy to the destination. This policy
        /// allows delivery to that destination. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>CreateDelivery</c> to create a <i>delivery</i> by pairing exactly one delivery
        /// source and one delivery destination. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can configure a single delivery source to send logs to multiple destinations by
        /// creating multiple deliveries. You can also create multiple deliveries to configure
        /// multiple delivery sources to send logs to the same delivery destination.
        /// </para>
        ///  
        /// <para>
        /// To update an existing delivery configuration, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateDeliveryConfiguration.html">UpdateDeliveryConfiguration</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDelivery service method.</param>
        /// 
        /// <returns>The response from the CreateDelivery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateDelivery">REST API Reference for CreateDelivery Operation</seealso>
        CreateDeliveryResponse CreateDelivery(CreateDeliveryRequest request);



        /// <summary>
        /// Creates a <i>delivery</i>. A delivery is a connection between a logical <i>delivery
        /// source</i> and a logical <i>delivery destination</i> that you have already created.
        /// 
        ///  
        /// <para>
        /// Only some Amazon Web Services services support being configured as a delivery source
        /// using this operation. These services are listed as <b>Supported [V2 Permissions]</b>
        /// in the table at <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        ///  
        /// <para>
        /// A delivery destination can represent a log group in CloudWatch Logs, an Amazon S3
        /// bucket, a delivery stream in Firehose, or X-Ray.
        /// </para>
        ///  
        /// <para>
        /// To configure logs delivery between a supported Amazon Web Services service and a destination,
        /// you must do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a delivery source, which is a logical object that represents the resource that
        /// is actually sending the logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <i>delivery destination</i>, which is a logical object that represents the
        /// actual delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">PutDeliveryDestination</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are delivering logs cross-account, you must use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>
        /// in the destination account to assign an IAM policy to the destination. This policy
        /// allows delivery to that destination. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>CreateDelivery</c> to create a <i>delivery</i> by pairing exactly one delivery
        /// source and one delivery destination. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can configure a single delivery source to send logs to multiple destinations by
        /// creating multiple deliveries. You can also create multiple deliveries to configure
        /// multiple delivery sources to send logs to the same delivery destination.
        /// </para>
        ///  
        /// <para>
        /// To update an existing delivery configuration, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_UpdateDeliveryConfiguration.html">UpdateDeliveryConfiguration</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDelivery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDelivery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateDelivery">REST API Reference for CreateDelivery Operation</seealso>
        Task<CreateDeliveryResponse> CreateDeliveryAsync(CreateDeliveryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateExportTask


        /// <summary>
        /// Creates an export task so that you can efficiently export data from a log group to
        /// an Amazon S3 bucket. When you perform a <c>CreateExportTask</c> operation, you must
        /// use credentials that have permission to write to the S3 bucket that you specify as
        /// the destination.
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
        /// to get the status of the export task. Each account can only have one active (<c>RUNNING</c>
        /// or <c>PENDING</c>) export task at a time. To cancel an export task, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CancelExportTask.html">CancelExportTask</a>.
        /// </para>
        ///  
        /// <para>
        /// You can export logs from multiple log groups or multiple time ranges to the same S3
        /// bucket. To separate log data for each export task, specify a prefix to be used as
        /// the Amazon S3 key prefix for all exported objects.
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend that you don't regularly export to Amazon S3 as a way to continuously
        /// archive your logs. For that use case, we instead recommend that you use subscriptions.
        /// For more information about subscriptions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Subscriptions.html">Real-time
        /// processing of log data with subscriptions</a>.
        /// </para>
        ///  </note> <note> 
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
        /// an Amazon S3 bucket. When you perform a <c>CreateExportTask</c> operation, you must
        /// use credentials that have permission to write to the S3 bucket that you specify as
        /// the destination.
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
        /// to get the status of the export task. Each account can only have one active (<c>RUNNING</c>
        /// or <c>PENDING</c>) export task at a time. To cancel an export task, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CancelExportTask.html">CancelExportTask</a>.
        /// </para>
        ///  
        /// <para>
        /// You can export logs from multiple log groups or multiple time ranges to the same S3
        /// bucket. To separate log data for each export task, specify a prefix to be used as
        /// the Amazon S3 key prefix for all exported objects.
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend that you don't regularly export to Amazon S3 as a way to continuously
        /// archive your logs. For that use case, we instead recommend that you use subscriptions.
        /// For more information about subscriptions, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/Subscriptions.html">Real-time
        /// processing of log data with subscriptions</a>.
        /// </para>
        ///  </note> <note> 
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
        
        #region  CreateLogAnomalyDetector


        /// <summary>
        /// Creates an <i>anomaly detector</i> that regularly scans one or more log groups and
        /// look for patterns and anomalies in the logs.
        /// 
        ///  
        /// <para>
        /// An anomaly detector can help surface issues by automatically discovering anomalies
        /// in your log event traffic. An anomaly detector uses machine learning algorithms to
        /// scan log events and find <i>patterns</i>. A pattern is a shared text structure that
        /// recurs among your log fields. Patterns provide a useful tool for analyzing large sets
        /// of logs because a large number of log events can often be compressed into a few patterns.
        /// </para>
        ///  
        /// <para>
        /// The anomaly detector uses pattern recognition to find <c>anomalies</c>, which are
        /// unusual log events. It uses the <c>evaluationFrequency</c> to compare current log
        /// events and patterns with trained baselines. 
        /// </para>
        ///  
        /// <para>
        /// Fields within a pattern are called <i>tokens</i>. Fields that vary within a pattern,
        /// such as a request ID or timestamp, are referred to as <i>dynamic tokens</i> and represented
        /// by <c>&lt;*&gt;</c>. 
        /// </para>
        ///  
        /// <para>
        /// The following is an example of a pattern:
        /// </para>
        ///  
        /// <para>
        ///  <c>[INFO] Request time: &lt;*&gt; ms</c> 
        /// </para>
        ///  
        /// <para>
        /// This pattern represents log events like <c>[INFO] Request time: 327 ms</c> and other
        /// similar log events that differ only by the number, in this csse 327. When the pattern
        /// is displayed, the different numbers are replaced by <c>&lt;*&gt;</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Any parts of log events that are masked as sensitive data are not scanned for anomalies.
        /// For more information about masking sensitive data, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Help
        /// protect sensitive log data with masking</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogAnomalyDetector service method.</param>
        /// 
        /// <returns>The response from the CreateLogAnomalyDetector service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogAnomalyDetector">REST API Reference for CreateLogAnomalyDetector Operation</seealso>
        CreateLogAnomalyDetectorResponse CreateLogAnomalyDetector(CreateLogAnomalyDetectorRequest request);



        /// <summary>
        /// Creates an <i>anomaly detector</i> that regularly scans one or more log groups and
        /// look for patterns and anomalies in the logs.
        /// 
        ///  
        /// <para>
        /// An anomaly detector can help surface issues by automatically discovering anomalies
        /// in your log event traffic. An anomaly detector uses machine learning algorithms to
        /// scan log events and find <i>patterns</i>. A pattern is a shared text structure that
        /// recurs among your log fields. Patterns provide a useful tool for analyzing large sets
        /// of logs because a large number of log events can often be compressed into a few patterns.
        /// </para>
        ///  
        /// <para>
        /// The anomaly detector uses pattern recognition to find <c>anomalies</c>, which are
        /// unusual log events. It uses the <c>evaluationFrequency</c> to compare current log
        /// events and patterns with trained baselines. 
        /// </para>
        ///  
        /// <para>
        /// Fields within a pattern are called <i>tokens</i>. Fields that vary within a pattern,
        /// such as a request ID or timestamp, are referred to as <i>dynamic tokens</i> and represented
        /// by <c>&lt;*&gt;</c>. 
        /// </para>
        ///  
        /// <para>
        /// The following is an example of a pattern:
        /// </para>
        ///  
        /// <para>
        ///  <c>[INFO] Request time: &lt;*&gt; ms</c> 
        /// </para>
        ///  
        /// <para>
        /// This pattern represents log events like <c>[INFO] Request time: 327 ms</c> and other
        /// similar log events that differ only by the number, in this csse 327. When the pattern
        /// is displayed, the different numbers are replaced by <c>&lt;*&gt;</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// Any parts of log events that are masked as sensitive data are not scanned for anomalies.
        /// For more information about masking sensitive data, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Help
        /// protect sensitive log data with masking</a>. 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLogAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLogAnomalyDetector service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogAnomalyDetector">REST API Reference for CreateLogAnomalyDetector Operation</seealso>
        Task<CreateLogAnomalyDetectorResponse> CreateLogAnomalyDetectorAsync(CreateLogAnomalyDetectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLogGroup


        /// <summary>
        /// Creates a log group with the specified name. You can create up to 1,000,000 log groups
        /// per Region per account.
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
        ///  </li> <li> 
        /// <para>
        /// Log group names can't start with the string <c>aws/</c> 
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
        /// If you attempt to associate a KMS key with the log group but the KMS key does not
        /// exist or the KMS key is disabled, you receive an <c>InvalidParameterException</c>
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
        /// Creates a log group with the specified name. You can create up to 1,000,000 log groups
        /// per Region per account.
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
        ///  </li> <li> 
        /// <para>
        /// Log group names can't start with the string <c>aws/</c> 
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
        /// If you attempt to associate a KMS key with the log group but the KMS key does not
        /// exist or the KMS key is disabled, you receive an <c>InvalidParameterException</c>
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
        /// There is a limit of 50 TPS on <c>CreateLogStream</c> operations, after which transactions
        /// are throttled.
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
        /// There is a limit of 50 TPS on <c>CreateLogStream</c> operations, after which transactions
        /// are throttled.
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
        
        #region  DeleteAccountPolicy


        /// <summary>
        /// Deletes a CloudWatch Logs account policy. This stops the account-wide policy from
        /// applying to log groups in the account. If you delete a data protection policy or subscription
        /// filter policy, any log-group level policies of those types remain in effect.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must be signed on with the correct permissions depending
        /// on the type of policy that you are deleting.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To delete a data protection policy, you must have the <c>logs:DeleteDataProtectionPolicy</c>
        /// and <c>logs:DeleteAccountPolicy</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a subscription filter policy, you must have the <c>logs:DeleteSubscriptionFilter</c>
        /// and <c>logs:DeleteAccountPolicy</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a transformer policy, you must have the <c>logs:DeleteTransformer</c> and
        /// <c>logs:DeleteAccountPolicy</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a field index policy, you must have the <c>logs:DeleteIndexPolicy</c> and
        /// <c>logs:DeleteAccountPolicy</c> permissions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you delete a field index policy, the indexing of the log events that happened before
        /// you deleted the policy will still be used for up to 30 days to improve CloudWatch
        /// Logs Insights queries.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteAccountPolicy service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteAccountPolicy">REST API Reference for DeleteAccountPolicy Operation</seealso>
        DeleteAccountPolicyResponse DeleteAccountPolicy(DeleteAccountPolicyRequest request);



        /// <summary>
        /// Deletes a CloudWatch Logs account policy. This stops the account-wide policy from
        /// applying to log groups in the account. If you delete a data protection policy or subscription
        /// filter policy, any log-group level policies of those types remain in effect.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must be signed on with the correct permissions depending
        /// on the type of policy that you are deleting.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To delete a data protection policy, you must have the <c>logs:DeleteDataProtectionPolicy</c>
        /// and <c>logs:DeleteAccountPolicy</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a subscription filter policy, you must have the <c>logs:DeleteSubscriptionFilter</c>
        /// and <c>logs:DeleteAccountPolicy</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a transformer policy, you must have the <c>logs:DeleteTransformer</c> and
        /// <c>logs:DeleteAccountPolicy</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To delete a field index policy, you must have the <c>logs:DeleteIndexPolicy</c> and
        /// <c>logs:DeleteAccountPolicy</c> permissions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you delete a field index policy, the indexing of the log events that happened before
        /// you deleted the policy will still be used for up to 30 days to improve CloudWatch
        /// Logs Insights queries.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountPolicy service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteAccountPolicy">REST API Reference for DeleteAccountPolicy Operation</seealso>
        Task<DeleteAccountPolicyResponse> DeleteAccountPolicyAsync(DeleteAccountPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        
        #region  DeleteDelivery


        /// <summary>
        /// Deletes a <i>delivery</i>. A delivery is a connection between a logical <i>delivery
        /// source</i> and a logical <i>delivery destination</i>. Deleting a delivery only deletes
        /// the connection between the delivery source and delivery destination. It does not delete
        /// the delivery destination or the delivery source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDelivery service method.</param>
        /// 
        /// <returns>The response from the DeleteDelivery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDelivery">REST API Reference for DeleteDelivery Operation</seealso>
        DeleteDeliveryResponse DeleteDelivery(DeleteDeliveryRequest request);



        /// <summary>
        /// Deletes a <i>delivery</i>. A delivery is a connection between a logical <i>delivery
        /// source</i> and a logical <i>delivery destination</i>. Deleting a delivery only deletes
        /// the connection between the delivery source and delivery destination. It does not delete
        /// the delivery destination or the delivery source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDelivery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDelivery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDelivery">REST API Reference for DeleteDelivery Operation</seealso>
        Task<DeleteDeliveryResponse> DeleteDeliveryAsync(DeleteDeliveryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDeliveryDestination


        /// <summary>
        /// Deletes a <i>delivery destination</i>. A delivery is a connection between a logical
        /// <i>delivery source</i> and a logical <i>delivery destination</i>.
        /// 
        ///  
        /// <para>
        /// You can't delete a delivery destination if any current deliveries are associated with
        /// it. To find whether any deliveries are associated with this delivery destination,
        /// use the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeDeliveries.html">DescribeDeliveries</a>
        /// operation and check the <c>deliveryDestinationArn</c> field in the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryDestination service method.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliveryDestination">REST API Reference for DeleteDeliveryDestination Operation</seealso>
        DeleteDeliveryDestinationResponse DeleteDeliveryDestination(DeleteDeliveryDestinationRequest request);



        /// <summary>
        /// Deletes a <i>delivery destination</i>. A delivery is a connection between a logical
        /// <i>delivery source</i> and a logical <i>delivery destination</i>.
        /// 
        ///  
        /// <para>
        /// You can't delete a delivery destination if any current deliveries are associated with
        /// it. To find whether any deliveries are associated with this delivery destination,
        /// use the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeDeliveries.html">DescribeDeliveries</a>
        /// operation and check the <c>deliveryDestinationArn</c> field in the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeliveryDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliveryDestination">REST API Reference for DeleteDeliveryDestination Operation</seealso>
        Task<DeleteDeliveryDestinationResponse> DeleteDeliveryDestinationAsync(DeleteDeliveryDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDeliveryDestinationPolicy


        /// <summary>
        /// Deletes a delivery destination policy. For more information about these policies,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryDestinationPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteDeliveryDestinationPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliveryDestinationPolicy">REST API Reference for DeleteDeliveryDestinationPolicy Operation</seealso>
        DeleteDeliveryDestinationPolicyResponse DeleteDeliveryDestinationPolicy(DeleteDeliveryDestinationPolicyRequest request);



        /// <summary>
        /// Deletes a delivery destination policy. For more information about these policies,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryDestinationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeliveryDestinationPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliveryDestinationPolicy">REST API Reference for DeleteDeliveryDestinationPolicy Operation</seealso>
        Task<DeleteDeliveryDestinationPolicyResponse> DeleteDeliveryDestinationPolicyAsync(DeleteDeliveryDestinationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteDeliverySource


        /// <summary>
        /// Deletes a <i>delivery source</i>. A delivery is a connection between a logical <i>delivery
        /// source</i> and a logical <i>delivery destination</i>.
        /// 
        ///  
        /// <para>
        /// You can't delete a delivery source if any current deliveries are associated with it.
        /// To find whether any deliveries are associated with this delivery source, use the <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeDeliveries.html">DescribeDeliveries</a>
        /// operation and check the <c>deliverySourceName</c> field in the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliverySource service method.</param>
        /// 
        /// <returns>The response from the DeleteDeliverySource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliverySource">REST API Reference for DeleteDeliverySource Operation</seealso>
        DeleteDeliverySourceResponse DeleteDeliverySource(DeleteDeliverySourceRequest request);



        /// <summary>
        /// Deletes a <i>delivery source</i>. A delivery is a connection between a logical <i>delivery
        /// source</i> and a logical <i>delivery destination</i>.
        /// 
        ///  
        /// <para>
        /// You can't delete a delivery source if any current deliveries are associated with it.
        /// To find whether any deliveries are associated with this delivery source, use the <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeDeliveries.html">DescribeDeliveries</a>
        /// operation and check the <c>deliverySourceName</c> field in the results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliverySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDeliverySource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliverySource">REST API Reference for DeleteDeliverySource Operation</seealso>
        Task<DeleteDeliverySourceResponse> DeleteDeliverySourceAsync(DeleteDeliverySourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        
        #region  DeleteIndexPolicy


        /// <summary>
        /// Deletes a log-group level field index policy that was applied to a single log group.
        /// The indexing of the log events that happened before you delete the policy will still
        /// be used for as many as 30 days to improve CloudWatch Logs Insights queries.
        /// 
        ///  
        /// <para>
        /// You can't use this operation to delete an account-level index policy. Instead, use
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DeleteAccountPolicy.html">DeletAccountPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If you delete a log-group level field index policy and there is an account-level field
        /// index policy, in a few minutes the log group begins using that account-wide policy
        /// to index new incoming log events. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteIndexPolicy service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteIndexPolicy">REST API Reference for DeleteIndexPolicy Operation</seealso>
        DeleteIndexPolicyResponse DeleteIndexPolicy(DeleteIndexPolicyRequest request);



        /// <summary>
        /// Deletes a log-group level field index policy that was applied to a single log group.
        /// The indexing of the log events that happened before you delete the policy will still
        /// be used for as many as 30 days to improve CloudWatch Logs Insights queries.
        /// 
        ///  
        /// <para>
        /// You can't use this operation to delete an account-level index policy. Instead, use
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DeleteAccountPolicy.html">DeletAccountPolicy</a>.
        /// </para>
        ///  
        /// <para>
        /// If you delete a log-group level field index policy and there is an account-level field
        /// index policy, in a few minutes the log group begins using that account-wide policy
        /// to index new incoming log events. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIndexPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIndexPolicy service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteIndexPolicy">REST API Reference for DeleteIndexPolicy Operation</seealso>
        Task<DeleteIndexPolicyResponse> DeleteIndexPolicyAsync(DeleteIndexPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteIntegration


        /// <summary>
        /// Deletes the integration between CloudWatch Logs and OpenSearch Service. If your integration
        /// has active vended logs dashboards, you must specify <c>true</c> for the <c>force</c>
        /// parameter, otherwise the operation will fail. If you delete the integration by setting
        /// <c>force</c> to <c>true</c>, all your vended logs dashboards powered by OpenSearch
        /// Service will be deleted and the data that was on them will no longer be accessible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        DeleteIntegrationResponse DeleteIntegration(DeleteIntegrationRequest request);



        /// <summary>
        /// Deletes the integration between CloudWatch Logs and OpenSearch Service. If your integration
        /// has active vended logs dashboards, you must specify <c>true</c> for the <c>force</c>
        /// parameter, otherwise the operation will fail. If you delete the integration by setting
        /// <c>force</c> to <c>true</c>, all your vended logs dashboards powered by OpenSearch
        /// Service will be deleted and the data that was on them will no longer be accessible.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIntegration service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteIntegration">REST API Reference for DeleteIntegration Operation</seealso>
        Task<DeleteIntegrationResponse> DeleteIntegrationAsync(DeleteIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLogAnomalyDetector


        /// <summary>
        /// Deletes the specified CloudWatch Logs anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogAnomalyDetector service method.</param>
        /// 
        /// <returns>The response from the DeleteLogAnomalyDetector service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogAnomalyDetector">REST API Reference for DeleteLogAnomalyDetector Operation</seealso>
        DeleteLogAnomalyDetectorResponse DeleteLogAnomalyDetector(DeleteLogAnomalyDetectorRequest request);



        /// <summary>
        /// Deletes the specified CloudWatch Logs anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLogAnomalyDetector service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogAnomalyDetector">REST API Reference for DeleteLogAnomalyDetector Operation</seealso>
        Task<DeleteLogAnomalyDetectorResponse> DeleteLogAnomalyDetectorAsync(DeleteLogAnomalyDetectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// Each <c>DeleteQueryDefinition</c> operation can delete one query definition.
        /// </para>
        ///  
        /// <para>
        /// You must have the <c>logs:DeleteQueryDefinition</c> permission to be able to perform
        /// this operation.
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
        /// Each <c>DeleteQueryDefinition</c> operation can delete one query definition.
        /// </para>
        ///  
        /// <para>
        /// You must have the <c>logs:DeleteQueryDefinition</c> permission to be able to perform
        /// this operation.
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
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
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
        
        #region  DeleteTransformer


        /// <summary>
        /// Deletes the log transformer for the specified log group. As soon as you do this, the
        /// transformation of incoming log events according to that transformer stops. If this
        /// account has an account-level transformer that applies to this log group, the log group
        /// begins using that account-level transformer when this log-group level transformer
        /// is deleted.
        /// 
        ///  
        /// <para>
        /// After you delete a transformer, be sure to edit any metric filters or subscription
        /// filters that relied on the transformed versions of the log events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransformer service method.</param>
        /// 
        /// <returns>The response from the DeleteTransformer service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteTransformer">REST API Reference for DeleteTransformer Operation</seealso>
        DeleteTransformerResponse DeleteTransformer(DeleteTransformerRequest request);



        /// <summary>
        /// Deletes the log transformer for the specified log group. As soon as you do this, the
        /// transformation of incoming log events according to that transformer stops. If this
        /// account has an account-level transformer that applies to this log group, the log group
        /// begins using that account-level transformer when this log-group level transformer
        /// is deleted.
        /// 
        ///  
        /// <para>
        /// After you delete a transformer, be sure to edit any metric filters or subscription
        /// filters that relied on the transformed versions of the log events.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransformer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTransformer service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteTransformer">REST API Reference for DeleteTransformer Operation</seealso>
        Task<DeleteTransformerResponse> DeleteTransformerAsync(DeleteTransformerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeAccountPolicies


        /// <summary>
        /// Returns a list of all CloudWatch Logs account policies in the account.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must be signed on with the correct permissions depending
        /// on the type of policy that you are retrieving information for.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To see data protection policies, you must have the <c>logs:GetDataProtectionPolicy</c>
        /// and <c>logs:DescribeAccountPolicies</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To see subscription filter policies, you must have the <c>logs:DescribeSubscriptionFilters</c>
        /// and <c>logs:DescribeAccountPolicies</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To see transformer policies, you must have the <c>logs:GetTransformer</c> and <c>logs:DescribeAccountPolicies</c>
        /// permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To see field index policies, you must have the <c>logs:DescribeIndexPolicies</c> and
        /// <c>logs:DescribeAccountPolicies</c> permissions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountPolicies service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeAccountPolicies">REST API Reference for DescribeAccountPolicies Operation</seealso>
        DescribeAccountPoliciesResponse DescribeAccountPolicies(DescribeAccountPoliciesRequest request);



        /// <summary>
        /// Returns a list of all CloudWatch Logs account policies in the account.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must be signed on with the correct permissions depending
        /// on the type of policy that you are retrieving information for.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To see data protection policies, you must have the <c>logs:GetDataProtectionPolicy</c>
        /// and <c>logs:DescribeAccountPolicies</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To see subscription filter policies, you must have the <c>logs:DescribeSubscriptionFilters</c>
        /// and <c>logs:DescribeAccountPolicies</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To see transformer policies, you must have the <c>logs:GetTransformer</c> and <c>logs:DescribeAccountPolicies</c>
        /// permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To see field index policies, you must have the <c>logs:DescribeIndexPolicies</c> and
        /// <c>logs:DescribeAccountPolicies</c> permissions.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountPolicies service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeAccountPolicies">REST API Reference for DescribeAccountPolicies Operation</seealso>
        Task<DescribeAccountPoliciesResponse> DescribeAccountPoliciesAsync(DescribeAccountPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeConfigurationTemplates


        /// <summary>
        /// Use this operation to return the valid and default values that are used when creating
        /// delivery sources, delivery destinations, and deliveries. For more information about
        /// deliveries, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationTemplates service method.</param>
        /// 
        /// <returns>The response from the DescribeConfigurationTemplates service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeConfigurationTemplates">REST API Reference for DescribeConfigurationTemplates Operation</seealso>
        DescribeConfigurationTemplatesResponse DescribeConfigurationTemplates(DescribeConfigurationTemplatesRequest request);



        /// <summary>
        /// Use this operation to return the valid and default values that are used when creating
        /// delivery sources, delivery destinations, and deliveries. For more information about
        /// deliveries, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationTemplates service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeConfigurationTemplates">REST API Reference for DescribeConfigurationTemplates Operation</seealso>
        Task<DescribeConfigurationTemplatesResponse> DescribeConfigurationTemplatesAsync(DescribeConfigurationTemplatesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDeliveries


        /// <summary>
        /// Retrieves a list of the deliveries that have been created in the account.
        /// 
        ///  
        /// <para>
        /// A <i>delivery</i> is a connection between a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">
        /// <i>delivery source</i> </a> and a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">
        /// <i>delivery destination</i> </a>.
        /// </para>
        ///  
        /// <para>
        /// A delivery source represents an Amazon Web Services resource that sends logs to an
        /// logs delivery destination. The destination can be CloudWatch Logs, Amazon S3, Firehose
        /// or X-Ray. Only some Amazon Web Services services support being configured as a delivery
        /// source. These services are listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enable
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveries service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliveries service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliveries">REST API Reference for DescribeDeliveries Operation</seealso>
        DescribeDeliveriesResponse DescribeDeliveries(DescribeDeliveriesRequest request);



        /// <summary>
        /// Retrieves a list of the deliveries that have been created in the account.
        /// 
        ///  
        /// <para>
        /// A <i>delivery</i> is a connection between a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">
        /// <i>delivery source</i> </a> and a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">
        /// <i>delivery destination</i> </a>.
        /// </para>
        ///  
        /// <para>
        /// A delivery source represents an Amazon Web Services resource that sends logs to an
        /// logs delivery destination. The destination can be CloudWatch Logs, Amazon S3, Firehose
        /// or X-Ray. Only some Amazon Web Services services support being configured as a delivery
        /// source. These services are listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enable
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveries service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeliveries service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliveries">REST API Reference for DescribeDeliveries Operation</seealso>
        Task<DescribeDeliveriesResponse> DescribeDeliveriesAsync(DescribeDeliveriesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDeliveryDestinations


        /// <summary>
        /// Retrieves a list of the delivery destinations that have been created in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryDestinations service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliveryDestinations service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliveryDestinations">REST API Reference for DescribeDeliveryDestinations Operation</seealso>
        DescribeDeliveryDestinationsResponse DescribeDeliveryDestinations(DescribeDeliveryDestinationsRequest request);



        /// <summary>
        /// Retrieves a list of the delivery destinations that have been created in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeliveryDestinations service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliveryDestinations">REST API Reference for DescribeDeliveryDestinations Operation</seealso>
        Task<DescribeDeliveryDestinationsResponse> DescribeDeliveryDestinationsAsync(DescribeDeliveryDestinationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeDeliverySources


        /// <summary>
        /// Retrieves a list of the delivery sources that have been created in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliverySources service method.</param>
        /// 
        /// <returns>The response from the DescribeDeliverySources service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliverySources">REST API Reference for DescribeDeliverySources Operation</seealso>
        DescribeDeliverySourcesResponse DescribeDeliverySources(DescribeDeliverySourcesRequest request);



        /// <summary>
        /// Retrieves a list of the delivery sources that have been created in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliverySources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDeliverySources service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliverySources">REST API Reference for DescribeDeliverySources Operation</seealso>
        Task<DescribeDeliverySourcesResponse> DescribeDeliverySourcesAsync(DescribeDeliverySourcesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        
        #region  DescribeFieldIndexes


        /// <summary>
        /// Returns a list of custom and default field indexes which are discovered in log data.
        /// For more information about field index policies, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutIndexPolicy.html">PutIndexPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFieldIndexes service method.</param>
        /// 
        /// <returns>The response from the DescribeFieldIndexes service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeFieldIndexes">REST API Reference for DescribeFieldIndexes Operation</seealso>
        DescribeFieldIndexesResponse DescribeFieldIndexes(DescribeFieldIndexesRequest request);



        /// <summary>
        /// Returns a list of custom and default field indexes which are discovered in log data.
        /// For more information about field index policies, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutIndexPolicy.html">PutIndexPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFieldIndexes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeFieldIndexes service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeFieldIndexes">REST API Reference for DescribeFieldIndexes Operation</seealso>
        Task<DescribeFieldIndexesResponse> DescribeFieldIndexesAsync(DescribeFieldIndexesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeIndexPolicies


        /// <summary>
        /// Returns the field index policies of the specified log group. For more information
        /// about field index policies, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutIndexPolicy.html">PutIndexPolicy</a>.
        /// 
        ///  
        /// <para>
        /// If a specified log group has a log-group level index policy, that policy is returned
        /// by this operation.
        /// </para>
        ///  
        /// <para>
        /// If a specified log group doesn't have a log-group level index policy, but an account-wide
        /// index policy applies to it, that account-wide policy is returned by this operation.
        /// </para>
        ///  
        /// <para>
        /// To find information about only account-level policies, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeAccountPolicies.html">DescribeAccountPolicies</a>
        /// instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeIndexPolicies service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeIndexPolicies">REST API Reference for DescribeIndexPolicies Operation</seealso>
        DescribeIndexPoliciesResponse DescribeIndexPolicies(DescribeIndexPoliciesRequest request);



        /// <summary>
        /// Returns the field index policies of the specified log group. For more information
        /// about field index policies, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutIndexPolicy.html">PutIndexPolicy</a>.
        /// 
        ///  
        /// <para>
        /// If a specified log group has a log-group level index policy, that policy is returned
        /// by this operation.
        /// </para>
        ///  
        /// <para>
        /// If a specified log group doesn't have a log-group level index policy, but an account-wide
        /// index policy applies to it, that account-wide policy is returned by this operation.
        /// </para>
        ///  
        /// <para>
        /// To find information about only account-level policies, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeAccountPolicies.html">DescribeAccountPolicies</a>
        /// instead.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIndexPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeIndexPolicies service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeIndexPolicies">REST API Reference for DescribeIndexPolicies Operation</seealso>
        Task<DescribeIndexPoliciesResponse> DescribeIndexPoliciesAsync(DescribeIndexPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLogGroups


        /// <summary>
        /// Returns information about log groups. You can return all your log groups or filter
        /// the results by prefix. The results are ASCII-sorted by log group name.
        /// 
        ///  
        /// <para>
        /// CloudWatch Logs doesn't support IAM policies that control access to the <c>DescribeLogGroups</c>
        /// action by using the <c>aws:ResourceTag/<i>key-name</i> </c> condition key. Other CloudWatch
        /// Logs actions do support the use of the <c>aws:ResourceTag/<i>key-name</i> </c> condition
        /// key to control access. For more information about using tags to control access, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
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
        /// Returns information about log groups. You can return all your log groups or filter
        /// the results by prefix. The results are ASCII-sorted by log group name.
        /// 
        ///  
        /// <para>
        /// CloudWatch Logs doesn't support IAM policies that control access to the <c>DescribeLogGroups</c>
        /// action by using the <c>aws:ResourceTag/<i>key-name</i> </c> condition key. Other CloudWatch
        /// Logs actions do support the use of the <c>aws:ResourceTag/<i>key-name</i> </c> condition
        /// key to control access. For more information about using tags to control access, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
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
        /// Returns information about log groups. You can return all your log groups or filter
        /// the results by prefix. The results are ASCII-sorted by log group name.
        /// 
        ///  
        /// <para>
        /// CloudWatch Logs doesn't support IAM policies that control access to the <c>DescribeLogGroups</c>
        /// action by using the <c>aws:ResourceTag/<i>key-name</i> </c> condition key. Other CloudWatch
        /// Logs actions do support the use of the <c>aws:ResourceTag/<i>key-name</i> </c> condition
        /// key to control access. For more information about using tags to control access, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
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
        /// Returns information about log groups. You can return all your log groups or filter
        /// the results by prefix. The results are ASCII-sorted by log group name.
        /// 
        ///  
        /// <para>
        /// CloudWatch Logs doesn't support IAM policies that control access to the <c>DescribeLogGroups</c>
        /// action by using the <c>aws:ResourceTag/<i>key-name</i> </c> condition key. Other CloudWatch
        /// Logs actions do support the use of the <c>aws:ResourceTag/<i>key-name</i> </c> condition
        /// key to control access. For more information about using tags to control access, see
        /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_tags.html">Controlling
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
        /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
        /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
        /// include both. 
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of 25 transactions per second, after which transactions
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
        /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
        /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
        /// include both. 
        /// </para>
        ///  
        /// <para>
        /// This operation has a limit of 25 transactions per second, after which transactions
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
        /// definitions. You can retrieve query definitions from the current account or from a
        /// source account that is linked to the current account.
        /// 
        ///  
        /// <para>
        /// You can use the <c>queryDefinitionNamePrefix</c> parameter to limit the results to
        /// only the query definitions that have names that start with a certain string.
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
        /// definitions. You can retrieve query definitions from the current account or from a
        /// source account that is linked to the current account.
        /// 
        ///  
        /// <para>
        /// You can use the <c>queryDefinitionNamePrefix</c> parameter to limit the results to
        /// only the query definitions that have names that start with a certain string.
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
        /// Disassociates the specified KMS key from the specified log group or from all CloudWatch
        /// Logs Insights query results in the account.
        /// 
        ///  
        /// <para>
        /// When you use <c>DisassociateKmsKey</c>, you specify either the <c>logGroupName</c>
        /// parameter or the <c>resourceIdentifier</c> parameter. You can't specify both of those
        /// parameters in the same operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>logGroupName</c> parameter to stop using the KMS key to encrypt future
        /// log events ingested and stored in the log group. Instead, they will be encrypted with
        /// the default CloudWatch Logs method. The log events that were ingested while the key
        /// was associated with the log group are still encrypted with that key. Therefore, CloudWatch
        /// Logs will need permissions for the key whenever that data is accessed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the <c>resourceIdentifier</c> parameter with the <c>query-result</c> resource
        /// to stop using the KMS key to encrypt the results of all future <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
        /// operations in the account. They will instead be encrypted with the default CloudWatch
        /// Logs method. The results from queries that ran while the key was associated with the
        /// account are still encrypted with that key. Therefore, CloudWatch Logs will need permissions
        /// for the key whenever that data is accessed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// It can take up to 5 minutes for this operation to take effect.
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
        /// Disassociates the specified KMS key from the specified log group or from all CloudWatch
        /// Logs Insights query results in the account.
        /// 
        ///  
        /// <para>
        /// When you use <c>DisassociateKmsKey</c>, you specify either the <c>logGroupName</c>
        /// parameter or the <c>resourceIdentifier</c> parameter. You can't specify both of those
        /// parameters in the same operation.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Specify the <c>logGroupName</c> parameter to stop using the KMS key to encrypt future
        /// log events ingested and stored in the log group. Instead, they will be encrypted with
        /// the default CloudWatch Logs method. The log events that were ingested while the key
        /// was associated with the log group are still encrypted with that key. Therefore, CloudWatch
        /// Logs will need permissions for the key whenever that data is accessed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Specify the <c>resourceIdentifier</c> parameter with the <c>query-result</c> resource
        /// to stop using the KMS key to encrypt the results of all future <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
        /// operations in the account. They will instead be encrypted with the default CloudWatch
        /// Logs method. The results from queries that ran while the key was associated with the
        /// account are still encrypted with that key. Therefore, CloudWatch Logs will need permissions
        /// for the key whenever that data is accessed.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// It can take up to 5 minutes for this operation to take effect.
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
        /// filter the results using one or more of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A filter pattern
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A time range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The log stream name, or a log stream name prefix that matches multiple log streams
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must have the <c>logs:FilterLogEvents</c> permission to perform this operation.
        /// </para>
        ///  
        /// <para>
        /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
        /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
        /// include both. 
        /// </para>
        ///  
        /// <para>
        ///  <c>FilterLogEvents</c> is a paginated operation. Each page returned can contain up
        /// to 1 MB of log events or up to 10,000 log events. A returned page might only be partially
        /// full, or even empty. For example, if the result of a query would return 15,000 log
        /// events, the first page isn't guaranteed to have 10,000 log events even if they all
        /// fit into 1 MB.
        /// </para>
        ///  
        /// <para>
        /// Partially full or empty pages don't necessarily mean that pagination is finished.
        /// If the results include a <c>nextToken</c>, there might be more log events available.
        /// You can return these additional log events by providing the nextToken in a subsequent
        /// <c>FilterLogEvents</c> operation. If the results don't include a <c>nextToken</c>,
        /// then pagination is finished. 
        /// </para>
        ///  
        /// <para>
        /// Specifying the <c>limit</c> parameter only guarantees that a single page doesn't return
        /// more log events than the specified limit, but it might return fewer events than the
        /// limit. This is the expected API behavior.
        /// </para>
        ///  
        /// <para>
        /// The returned log events are sorted by event timestamp, the timestamp when the event
        /// was ingested by CloudWatch Logs, and the ID of the <c>PutLogEvents</c> request.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html">log
        /// transformation</a>, the <c>FilterLogEvents</c> operation returns only the original
        /// versions of log events, before they were transformed. To view the transformed versions,
        /// you must use a <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AnalyzingLogData.html">CloudWatch
        /// Logs query.</a> 
        /// </para>
        ///  </note>
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
        /// filter the results using one or more of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A filter pattern
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A time range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The log stream name, or a log stream name prefix that matches multiple log streams
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You must have the <c>logs:FilterLogEvents</c> permission to perform this operation.
        /// </para>
        ///  
        /// <para>
        /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
        /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
        /// include both. 
        /// </para>
        ///  
        /// <para>
        ///  <c>FilterLogEvents</c> is a paginated operation. Each page returned can contain up
        /// to 1 MB of log events or up to 10,000 log events. A returned page might only be partially
        /// full, or even empty. For example, if the result of a query would return 15,000 log
        /// events, the first page isn't guaranteed to have 10,000 log events even if they all
        /// fit into 1 MB.
        /// </para>
        ///  
        /// <para>
        /// Partially full or empty pages don't necessarily mean that pagination is finished.
        /// If the results include a <c>nextToken</c>, there might be more log events available.
        /// You can return these additional log events by providing the nextToken in a subsequent
        /// <c>FilterLogEvents</c> operation. If the results don't include a <c>nextToken</c>,
        /// then pagination is finished. 
        /// </para>
        ///  
        /// <para>
        /// Specifying the <c>limit</c> parameter only guarantees that a single page doesn't return
        /// more log events than the specified limit, but it might return fewer events than the
        /// limit. This is the expected API behavior.
        /// </para>
        ///  
        /// <para>
        /// The returned log events are sorted by event timestamp, the timestamp when the event
        /// was ingested by CloudWatch Logs, and the ID of the <c>PutLogEvents</c> request.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html">log
        /// transformation</a>, the <c>FilterLogEvents</c> operation returns only the original
        /// versions of log events, before they were transformed. To view the transformed versions,
        /// you must use a <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AnalyzingLogData.html">CloudWatch
        /// Logs query.</a> 
        /// </para>
        ///  </note>
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
        
        #region  GetDelivery


        /// <summary>
        /// Returns complete information about one logical <i>delivery</i>. A delivery is a connection
        /// between a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">
        /// <i>delivery source</i> </a> and a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">
        /// <i>delivery destination</i> </a>.
        /// 
        ///  
        /// <para>
        /// A delivery source represents an Amazon Web Services resource that sends logs to an
        /// logs delivery destination. The destination can be CloudWatch Logs, Amazon S3, or Firehose.
        /// Only some Amazon Web Services services support being configured as a delivery source.
        /// These services are listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enable
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        ///  
        /// <para>
        /// You need to specify the delivery <c>id</c> in this operation. You can find the IDs
        /// of the deliveries in your account with the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeDeliveries.html">DescribeDeliveries</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelivery service method.</param>
        /// 
        /// <returns>The response from the GetDelivery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDelivery">REST API Reference for GetDelivery Operation</seealso>
        GetDeliveryResponse GetDelivery(GetDeliveryRequest request);



        /// <summary>
        /// Returns complete information about one logical <i>delivery</i>. A delivery is a connection
        /// between a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">
        /// <i>delivery source</i> </a> and a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">
        /// <i>delivery destination</i> </a>.
        /// 
        ///  
        /// <para>
        /// A delivery source represents an Amazon Web Services resource that sends logs to an
        /// logs delivery destination. The destination can be CloudWatch Logs, Amazon S3, or Firehose.
        /// Only some Amazon Web Services services support being configured as a delivery source.
        /// These services are listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enable
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        ///  
        /// <para>
        /// You need to specify the delivery <c>id</c> in this operation. You can find the IDs
        /// of the deliveries in your account with the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeDeliveries.html">DescribeDeliveries</a>
        /// operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDelivery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDelivery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDelivery">REST API Reference for GetDelivery Operation</seealso>
        Task<GetDeliveryResponse> GetDeliveryAsync(GetDeliveryRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeliveryDestination


        /// <summary>
        /// Retrieves complete information about one delivery destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliveryDestination service method.</param>
        /// 
        /// <returns>The response from the GetDeliveryDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliveryDestination">REST API Reference for GetDeliveryDestination Operation</seealso>
        GetDeliveryDestinationResponse GetDeliveryDestination(GetDeliveryDestinationRequest request);



        /// <summary>
        /// Retrieves complete information about one delivery destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliveryDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeliveryDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliveryDestination">REST API Reference for GetDeliveryDestination Operation</seealso>
        Task<GetDeliveryDestinationResponse> GetDeliveryDestinationAsync(GetDeliveryDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeliveryDestinationPolicy


        /// <summary>
        /// Retrieves the delivery destination policy assigned to the delivery destination that
        /// you specify. For more information about delivery destinations and their policies,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliveryDestinationPolicy service method.</param>
        /// 
        /// <returns>The response from the GetDeliveryDestinationPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliveryDestinationPolicy">REST API Reference for GetDeliveryDestinationPolicy Operation</seealso>
        GetDeliveryDestinationPolicyResponse GetDeliveryDestinationPolicy(GetDeliveryDestinationPolicyRequest request);



        /// <summary>
        /// Retrieves the delivery destination policy assigned to the delivery destination that
        /// you specify. For more information about delivery destinations and their policies,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliveryDestinationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeliveryDestinationPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliveryDestinationPolicy">REST API Reference for GetDeliveryDestinationPolicy Operation</seealso>
        Task<GetDeliveryDestinationPolicyResponse> GetDeliveryDestinationPolicyAsync(GetDeliveryDestinationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetDeliverySource


        /// <summary>
        /// Retrieves complete information about one delivery source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverySource service method.</param>
        /// 
        /// <returns>The response from the GetDeliverySource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliverySource">REST API Reference for GetDeliverySource Operation</seealso>
        GetDeliverySourceResponse GetDeliverySource(GetDeliverySourceRequest request);



        /// <summary>
        /// Retrieves complete information about one delivery source.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDeliverySource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliverySource">REST API Reference for GetDeliverySource Operation</seealso>
        Task<GetDeliverySourceResponse> GetDeliverySourceAsync(GetDeliverySourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetIntegration


        /// <summary>
        /// Returns information about one integration between CloudWatch Logs and OpenSearch Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        GetIntegrationResponse GetIntegration(GetIntegrationRequest request);



        /// <summary>
        /// Returns information about one integration between CloudWatch Logs and OpenSearch Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIntegration service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetIntegration">REST API Reference for GetIntegration Operation</seealso>
        Task<GetIntegrationResponse> GetIntegrationAsync(GetIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLogAnomalyDetector


        /// <summary>
        /// Retrieves information about the log anomaly detector that you specify. The KMS key
        /// ARN detected is valid.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogAnomalyDetector service method.</param>
        /// 
        /// <returns>The response from the GetLogAnomalyDetector service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogAnomalyDetector">REST API Reference for GetLogAnomalyDetector Operation</seealso>
        GetLogAnomalyDetectorResponse GetLogAnomalyDetector(GetLogAnomalyDetectorRequest request);



        /// <summary>
        /// Retrieves information about the log anomaly detector that you specify. The KMS key
        /// ARN detected is valid.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLogAnomalyDetector service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogAnomalyDetector">REST API Reference for GetLogAnomalyDetector Operation</seealso>
        Task<GetLogAnomalyDetectorResponse> GetLogAnomalyDetectorAsync(GetLogAnomalyDetectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLogEvents


        /// <summary>
        /// Lists log events from the specified log stream. You can list all of the log events
        /// or filter using a time range.
        /// 
        ///  
        /// <para>
        ///  <c>GetLogEvents</c> is a paginated operation. Each page returned can contain up to
        /// 1 MB of log events or up to 10,000 log events. A returned page might only be partially
        /// full, or even empty. For example, if the result of a query would return 15,000 log
        /// events, the first page isn't guaranteed to have 10,000 log events even if they all
        /// fit into 1 MB.
        /// </para>
        ///  
        /// <para>
        /// Partially full or empty pages don't necessarily mean that pagination is finished.
        /// As long as the <c>nextBackwardToken</c> or <c>nextForwardToken</c> returned is NOT
        /// equal to the <c>nextToken</c> that you passed into the API call, there might be more
        /// log events available. The token that you use depends on the direction you want to
        /// move in along the log stream. The returned tokens are never null.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set <c>startFromHead</c> to <c>true</c> and you don’t include <c>endTime</c>
        /// in your request, you can end up in a situation where the pagination doesn't terminate.
        /// This can happen when the new log events are being added to the target log streams
        /// faster than they are being read. This situation is a good use case for the CloudWatch
        /// Logs <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs_LiveTail.html">Live
        /// Tail</a> feature.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
        /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
        /// include both. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html">log
        /// transformation</a>, the <c>GetLogEvents</c> operation returns only the original versions
        /// of log events, before they were transformed. To view the transformed versions, you
        /// must use a <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AnalyzingLogData.html">CloudWatch
        /// Logs query.</a> 
        /// </para>
        ///  </note>
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
        ///  <c>GetLogEvents</c> is a paginated operation. Each page returned can contain up to
        /// 1 MB of log events or up to 10,000 log events. A returned page might only be partially
        /// full, or even empty. For example, if the result of a query would return 15,000 log
        /// events, the first page isn't guaranteed to have 10,000 log events even if they all
        /// fit into 1 MB.
        /// </para>
        ///  
        /// <para>
        /// Partially full or empty pages don't necessarily mean that pagination is finished.
        /// As long as the <c>nextBackwardToken</c> or <c>nextForwardToken</c> returned is NOT
        /// equal to the <c>nextToken</c> that you passed into the API call, there might be more
        /// log events available. The token that you use depends on the direction you want to
        /// move in along the log stream. The returned tokens are never null.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you set <c>startFromHead</c> to <c>true</c> and you don’t include <c>endTime</c>
        /// in your request, you can end up in a situation where the pagination doesn't terminate.
        /// This can happen when the new log events are being added to the target log streams
        /// faster than they are being read. This situation is a good use case for the CloudWatch
        /// Logs <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs_LiveTail.html">Live
        /// Tail</a> feature.
        /// </para>
        ///  </note> 
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account and view data from the linked source accounts. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
        /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
        /// include both. 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you are using <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html">log
        /// transformation</a>, the <c>GetLogEvents</c> operation returns only the original versions
        /// of log events, before they were transformed. To view the transformed versions, you
        /// must use a <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AnalyzingLogData.html">CloudWatch
        /// Logs query.</a> 
        /// </para>
        ///  </note>
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
        /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
        /// or <c>logGroupName</c>. You must specify one of these parameters, but you can't specify
        /// both. 
        /// </para>
        ///  
        /// <para>
        /// In the results, fields that start with <c>@</c> are fields generated by CloudWatch
        /// Logs. For example, <c>@timestamp</c> is the timestamp of each log event. For more
        /// information about the fields that are generated by CloudWatch logs, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_AnalyzeLogData-discoverable-fields.html">Supported
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
        /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
        /// or <c>logGroupName</c>. You must specify one of these parameters, but you can't specify
        /// both. 
        /// </para>
        ///  
        /// <para>
        /// In the results, fields that start with <c>@</c> are fields generated by CloudWatch
        /// Logs. For example, <c>@timestamp</c> is the timestamp of each log event. For more
        /// information about the fields that are generated by CloudWatch logs, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_AnalyzeLogData-discoverable-fields.html">Supported
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
        
        #region  GetLogObject


        /// <summary>
        /// Retrieves a large logging object (LLO) and streams it back. This API is used to fetch
        /// the content of large portions of log events that have been ingested through the PutOpenTelemetryLogs
        /// API. When log events contain fields that would cause the total event size to exceed
        /// 1MB, CloudWatch Logs automatically processes up to 10 fields, starting with the largest
        /// fields. Each field is truncated as needed to keep the total event size as close to
        /// 1MB as possible. The excess portions are stored as Large Log Objects (LLOs) and these
        /// fields are processed separately and LLO reference system fields (in the format <c>@ptr.$[path.to.field]</c>)
        /// are added. The path in the reference field reflects the original JSON structure where
        /// the large field was located. For example, this could be <c>@ptr.$['input']['message']</c>,
        /// <c>@ptr.$['AAA']['BBB']['CCC']['DDD']</c>, <c>@ptr.$['AAA']</c>, or any other path
        /// matching your log structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogObject service method.</param>
        /// 
        /// <returns>The response from the GetLogObject service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogObject">REST API Reference for GetLogObject Operation</seealso>
        GetLogObjectResponse GetLogObject(GetLogObjectRequest request);



        /// <summary>
        /// Retrieves a large logging object (LLO) and streams it back. This API is used to fetch
        /// the content of large portions of log events that have been ingested through the PutOpenTelemetryLogs
        /// API. When log events contain fields that would cause the total event size to exceed
        /// 1MB, CloudWatch Logs automatically processes up to 10 fields, starting with the largest
        /// fields. Each field is truncated as needed to keep the total event size as close to
        /// 1MB as possible. The excess portions are stored as Large Log Objects (LLOs) and these
        /// fields are processed separately and LLO reference system fields (in the format <c>@ptr.$[path.to.field]</c>)
        /// are added. The path in the reference field reflects the original JSON structure where
        /// the large field was located. For example, this could be <c>@ptr.$['input']['message']</c>,
        /// <c>@ptr.$['AAA']['BBB']['CCC']['DDD']</c>, <c>@ptr.$['AAA']</c>, or any other path
        /// matching your log structure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLogObject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLogObject service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogObject">REST API Reference for GetLogObject Operation</seealso>
        Task<GetLogObjectResponse> GetLogObjectAsync(GetLogObjectRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  GetLogRecord


        /// <summary>
        /// Retrieves all of the fields and values of a single log event. All fields are retrieved,
        /// even if the original query that produced the <c>logRecordPointer</c> retrieved only
        /// a subset of fields. Fields are returned as field name/field value pairs.
        /// 
        ///  
        /// <para>
        /// The full unparsed log event is returned within <c>@message</c>.
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
        /// even if the original query that produced the <c>logRecordPointer</c> retrieved only
        /// a subset of fields. Fields are returned as field name/field value pairs.
        /// 
        ///  
        /// <para>
        /// The full unparsed log event is returned within <c>@message</c>.
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
        /// Only the fields requested in the query are returned, along with a <c>@ptr</c> field,
        /// which is the identifier for the log record. You can use the value of <c>@ptr</c> in
        /// a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogRecord.html">GetLogRecord</a>
        /// operation to get the full log record.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetQueryResults</c> does not start running a query. To run a query, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>.
        /// For more information about how long results of previous queries are available, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/cloudwatch_limits_cwl.html">CloudWatch
        /// Logs quotas</a>.
        /// </para>
        ///  
        /// <para>
        /// If the value of the <c>Status</c> field in the output is <c>Running</c>, this operation
        /// returns only partial results. If you see a value of <c>Scheduled</c> or <c>Running</c>
        /// for the status, you can retry the operation later to see the final results. 
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
        /// Only the fields requested in the query are returned, along with a <c>@ptr</c> field,
        /// which is the identifier for the log record. You can use the value of <c>@ptr</c> in
        /// a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogRecord.html">GetLogRecord</a>
        /// operation to get the full log record.
        /// </para>
        ///  
        /// <para>
        ///  <c>GetQueryResults</c> does not start running a query. To run a query, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>.
        /// For more information about how long results of previous queries are available, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/cloudwatch_limits_cwl.html">CloudWatch
        /// Logs quotas</a>.
        /// </para>
        ///  
        /// <para>
        /// If the value of the <c>Status</c> field in the output is <c>Running</c>, this operation
        /// returns only partial results. If you see a value of <c>Scheduled</c> or <c>Running</c>
        /// for the status, you can retry the operation later to see the final results. 
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
        
        #region  GetTransformer


        /// <summary>
        /// Returns the information about the log transformer associated with this log group.
        /// 
        ///  
        /// <para>
        /// This operation returns data only for transformers created at the log group level.
        /// To get information for an account-level transformer, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeAccountPolicies.html">DescribeAccountPolicies</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransformer service method.</param>
        /// 
        /// <returns>The response from the GetTransformer service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetTransformer">REST API Reference for GetTransformer Operation</seealso>
        GetTransformerResponse GetTransformer(GetTransformerRequest request);



        /// <summary>
        /// Returns the information about the log transformer associated with this log group.
        /// 
        ///  
        /// <para>
        /// This operation returns data only for transformers created at the log group level.
        /// To get information for an account-level transformer, use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_DescribeAccountPolicies.html">DescribeAccountPolicies</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransformer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransformer service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetTransformer">REST API Reference for GetTransformer Operation</seealso>
        Task<GetTransformerResponse> GetTransformerAsync(GetTransformerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListAnomalies


        /// <summary>
        /// Returns a list of anomalies that log anomaly detectors have found. For details about
        /// the structure format of each anomaly object that is returned, see the example in this
        /// section.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalies service method.</param>
        /// 
        /// <returns>The response from the ListAnomalies service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListAnomalies">REST API Reference for ListAnomalies Operation</seealso>
        ListAnomaliesResponse ListAnomalies(ListAnomaliesRequest request);



        /// <summary>
        /// Returns a list of anomalies that log anomaly detectors have found. For details about
        /// the structure format of each anomaly object that is returned, see the example in this
        /// section.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAnomalies service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListAnomalies">REST API Reference for ListAnomalies Operation</seealso>
        Task<ListAnomaliesResponse> ListAnomaliesAsync(ListAnomaliesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListIntegrations


        /// <summary>
        /// Returns a list of integrations between CloudWatch Logs and other services in this
        /// account. Currently, only one integration can be created in an account, and this integration
        /// must be with OpenSearch Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        ListIntegrationsResponse ListIntegrations(ListIntegrationsRequest request);



        /// <summary>
        /// Returns a list of integrations between CloudWatch Logs and other services in this
        /// account. Currently, only one integration can be created in an account, and this integration
        /// must be with OpenSearch Service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIntegrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIntegrations service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListIntegrations">REST API Reference for ListIntegrations Operation</seealso>
        Task<ListIntegrationsResponse> ListIntegrationsAsync(ListIntegrationsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLogAnomalyDetectors


        /// <summary>
        /// Retrieves a list of the log anomaly detectors in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogAnomalyDetectors service method.</param>
        /// 
        /// <returns>The response from the ListLogAnomalyDetectors service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListLogAnomalyDetectors">REST API Reference for ListLogAnomalyDetectors Operation</seealso>
        ListLogAnomalyDetectorsResponse ListLogAnomalyDetectors(ListLogAnomalyDetectorsRequest request);



        /// <summary>
        /// Retrieves a list of the log anomaly detectors in the account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogAnomalyDetectors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLogAnomalyDetectors service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListLogAnomalyDetectors">REST API Reference for ListLogAnomalyDetectors Operation</seealso>
        Task<ListLogAnomalyDetectorsResponse> ListLogAnomalyDetectorsAsync(ListLogAnomalyDetectorsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLogGroups


        /// <summary>
        /// Returns a list of log groups in the Region in your account. If you are performing
        /// this action in a monitoring account, you can choose to also return log groups from
        /// source accounts that are linked to the monitoring account. For more information about
        /// using cross-account observability to set up monitoring accounts and source accounts,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">
        /// CloudWatch cross-account observability</a>.
        /// 
        ///  
        /// <para>
        /// You can optionally filter the list by log group class and by using regular expressions
        /// in your request to match strings in the log group names.
        /// </para>
        ///  
        /// <para>
        /// This operation is paginated. By default, your first use of this operation returns
        /// 50 results, and includes a token to use in a subsequent operation to return more results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogGroups service method.</param>
        /// 
        /// <returns>The response from the ListLogGroups service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListLogGroups">REST API Reference for ListLogGroups Operation</seealso>
        ListLogGroupsResponse ListLogGroups(ListLogGroupsRequest request);



        /// <summary>
        /// Returns a list of log groups in the Region in your account. If you are performing
        /// this action in a monitoring account, you can choose to also return log groups from
        /// source accounts that are linked to the monitoring account. For more information about
        /// using cross-account observability to set up monitoring accounts and source accounts,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">
        /// CloudWatch cross-account observability</a>.
        /// 
        ///  
        /// <para>
        /// You can optionally filter the list by log group class and by using regular expressions
        /// in your request to match strings in the log group names.
        /// </para>
        ///  
        /// <para>
        /// This operation is paginated. By default, your first use of this operation returns
        /// 50 results, and includes a token to use in a subsequent operation to return more results.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLogGroups service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListLogGroups">REST API Reference for ListLogGroups Operation</seealso>
        Task<ListLogGroupsResponse> ListLogGroupsAsync(ListLogGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ListLogGroupsForQuery


        /// <summary>
        /// Returns a list of the log groups that were analyzed during a single CloudWatch Logs
        /// Insights query. This can be useful for queries that use log group name prefixes or
        /// the <c>filterIndex</c> command, because the log groups are dynamically selected in
        /// these cases.
        /// 
        ///  
        /// <para>
        /// For more information about field indexes, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing.html">Create
        /// field indexes to improve query performance and reduce costs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogGroupsForQuery service method.</param>
        /// 
        /// <returns>The response from the ListLogGroupsForQuery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListLogGroupsForQuery">REST API Reference for ListLogGroupsForQuery Operation</seealso>
        ListLogGroupsForQueryResponse ListLogGroupsForQuery(ListLogGroupsForQueryRequest request);



        /// <summary>
        /// Returns a list of the log groups that were analyzed during a single CloudWatch Logs
        /// Insights query. This can be useful for queries that use log group name prefixes or
        /// the <c>filterIndex</c> command, because the log groups are dynamically selected in
        /// these cases.
        /// 
        ///  
        /// <para>
        /// For more information about field indexes, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing.html">Create
        /// field indexes to improve query performance and reduce costs</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLogGroupsForQuery service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLogGroupsForQuery service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListLogGroupsForQuery">REST API Reference for ListLogGroupsForQuery Operation</seealso>
        Task<ListLogGroupsForQueryResponse> ListLogGroupsForQueryAsync(ListLogGroupsForQueryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        
        #region  PutAccountPolicy


        /// <summary>
        /// Creates an account-level data protection policy, subscription filter policy, field
        /// index policy, transformer policy, or metric extraction policy that applies to all
        /// log groups or a subset of log groups in the account.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must be signed on with the correct permissions depending
        /// on the type of policy that you are creating.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a data protection policy, you must have the <c>logs:PutDataProtectionPolicy</c>
        /// and <c>logs:PutAccountPolicy</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a subscription filter policy, you must have the <c>logs:PutSubscriptionFilter</c>
        /// and <c>logs:PutAccountPolicy</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a transformer policy, you must have the <c>logs:PutTransformer</c> and <c>logs:PutAccountPolicy</c>
        /// permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a field index policy, you must have the <c>logs:PutIndexPolicy</c> and <c>logs:PutAccountPolicy</c>
        /// permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a metric extraction policy, you must have the <c>logs:PutMetricExtractionPolicy</c>
        /// and <c>logs:PutAccountPolicy</c> permissions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Data protection policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A data protection policy can help safeguard sensitive data that's ingested by your
        /// log groups by auditing and masking the sensitive log data. Each account can have only
        /// one account-level data protection policy.
        /// </para>
        ///  <important> 
        /// <para>
        /// Sensitive data is detected and masked when it is ingested into a log group. When you
        /// set a data protection policy, log events ingested into the log groups before that
        /// time are not masked.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you use <c>PutAccountPolicy</c> to create a data protection policy for your whole
        /// account, it applies to both existing log groups and all log groups that are created
        /// later in this account. The account-level policy is applied to existing log groups
        /// with eventual consistency. It might take up to 5 minutes before sensitive data in
        /// existing log groups begins to be masked.
        /// </para>
        ///  
        /// <para>
        /// By default, when a user views a log event that includes masked data, the sensitive
        /// data is replaced by asterisks. A user who has the <c>logs:Unmask</c> permission can
        /// use a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_FilterLogEvents.html">FilterLogEvents</a>
        /// operation with the <c>unmask</c> parameter set to <c>true</c> to view the unmasked
        /// log events. Users with the <c>logs:Unmask</c> can also view unmasked data in the CloudWatch
        /// Logs console by running a CloudWatch Logs Insights query with the <c>unmask</c> query
        /// command.
        /// </para>
        ///  
        /// <para>
        /// For more information, including a list of types of data that can be audited and masked,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Protect
        /// sensitive log data with masking</a>.
        /// </para>
        ///  
        /// <para>
        /// To use the <c>PutAccountPolicy</c> operation for a data protection policy, you must
        /// be signed on with the <c>logs:PutDataProtectionPolicy</c> and <c>logs:PutAccountPolicy</c>
        /// permissions.
        /// </para>
        ///  
        /// <para>
        /// The <c>PutAccountPolicy</c> operation applies to all log groups in the account. You
        /// can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDataProtectionPolicy.html">PutDataProtectionPolicy</a>
        /// to create a data protection policy that applies to just one log group. If a log group
        /// has its own data protection policy and the account also has an account-level data
        /// protection policy, then the two policies are cumulative. Any sensitive term specified
        /// in either policy is masked.
        /// </para>
        ///  
        /// <para>
        ///  <b>Subscription filter policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A subscription filter policy sets up a real-time feed of log events from CloudWatch
        /// Logs to other Amazon Web Services services. Account-level subscription filter policies
        /// apply to both existing log groups and log groups that are created later in this account.
        /// Supported destinations are Kinesis Data Streams, Firehose, and Lambda. When log events
        /// are sent to the receiving service, they are Base64 encoded and compressed with the
        /// GZIP format.
        /// </para>
        ///  
        /// <para>
        /// The following destinations are supported for subscription filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Kinesis Data Streams data stream in the same account as the subscription policy,
        /// for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Firehose data stream in the same account as the subscription policy, for same-account
        /// delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Lambda function in the same account as the subscription policy, for same-account
        /// delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A logical destination in a different account created with <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestination.html">PutDestination</a>,
        /// for cross-account delivery. Kinesis Data Streams and Firehose are supported as logical
        /// destinations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each account can have one account-level subscription filter policy per Region. If
        /// you are updating an existing filter, you must specify the correct name in <c>PolicyName</c>.
        /// To perform a <c>PutAccountPolicy</c> subscription filter operation for any destination
        /// except a Lambda function, you must also have the <c>iam:PassRole</c> permission.
        /// </para>
        ///  
        /// <para>
        ///  <b>Transformer policy</b> 
        /// </para>
        ///  
        /// <para>
        /// Creates or updates a <i>log transformer policy</i> for your account. You use log transformers
        /// to transform log events into a different format, making them easier for you to process
        /// and analyze. You can also transform logs from different sources into standardized
        /// formats that contain relevant, source-specific information. After you have created
        /// a transformer, CloudWatch Logs performs this transformation at the time of log ingestion.
        /// You can then refer to the transformed versions of the logs during operations such
        /// as querying with CloudWatch Logs Insights or creating metric filters or subscription
        /// filters.
        /// </para>
        ///  
        /// <para>
        /// You can also use a transformer to copy metadata from metadata keys into the log events
        /// themselves. This metadata can include log group name, log stream name, account ID
        /// and Region.
        /// </para>
        ///  
        /// <para>
        /// A transformer for a log group is a series of processors, where each processor applies
        /// one type of transformation to the log events ingested into this log group. For more
        /// information about the available processors to use in a transformer, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-Processors">
        /// Processors that you can use</a>.
        /// </para>
        ///  
        /// <para>
        /// Having log events in standardized format enables visibility across your applications
        /// for your log analysis, reporting, and alarming needs. CloudWatch Logs provides transformation
        /// for common log types with out-of-the-box transformation templates for major Amazon
        /// Web Services log sources such as VPC flow logs, Lambda, and Amazon RDS. You can use
        /// pre-built transformation templates or create custom transformation policies.
        /// </para>
        ///  
        /// <para>
        /// You can create transformers only for the log groups in the Standard log class.
        /// </para>
        ///  
        /// <para>
        /// You can have one account-level transformer policy that applies to all log groups in
        /// the account. Or you can create as many as 20 account-level transformer policies that
        /// are each scoped to a subset of log groups with the <c>selectionCriteria</c> parameter.
        /// If you have multiple account-level transformer policies with selection criteria, no
        /// two of them can use the same or overlapping log group name prefixes. For example,
        /// if you have one policy filtered to log groups that start with <c>my-log</c>, you can't
        /// have another field index policy filtered to <c>my-logpprod</c> or <c>my-logging</c>.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs provides default field indexes for all log groups in the Standard
        /// log class. Default field indexes are automatically available for the following fields:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>@aws.region</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>@aws.account</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>@source.log</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>traceId</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default field indexes are in addition to any custom field indexes you define within
        /// your policy. Default field indexes are not counted towards your field index quota.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can also set up a transformer at the log-group level. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutTransformer.html">PutTransformer</a>.
        /// If there is both a log-group level transformer created with <c>PutTransformer</c>
        /// and an account-level transformer that could apply to the same log group, the log group
        /// uses only the log-group level transformer. It ignores the account-level transformer.
        /// </para>
        ///  
        /// <para>
        ///  <b>Field index policy</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use field index policies to create indexes on fields found in log events in
        /// the log group. Creating field indexes can help lower the scan volume for CloudWatch
        /// Logs Insights queries that reference those fields, because these queries attempt to
        /// skip the processing of log events that are known to not match the indexed field. Good
        /// fields to index are fields that you often need to query for and fields or values that
        /// match only a small fraction of the total log events. Common examples of indexes include
        /// request ID, session ID, user IDs, or instance IDs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing.html">Create
        /// field indexes to improve query performance and reduce costs</a> 
        /// </para>
        ///  
        /// <para>
        /// To find the fields that are in your log group events, use the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogGroupFields.html">GetLogGroupFields</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose you have created a field index for <c>requestId</c>. Then, any
        /// CloudWatch Logs Insights query on that log group that includes <c>requestId = <i>value</i>
        /// </c> or <c>requestId in [<i>value</i>, <i>value</i>, ...]</c> will attempt to process
        /// only the log events where the indexed field matches the specified value.
        /// </para>
        ///  
        /// <para>
        /// Matches of log events to the names of indexed fields are case-sensitive. For example,
        /// an indexed field of <c>RequestId</c> won't match a log event containing <c>requestId</c>.
        /// </para>
        ///  
        /// <para>
        /// You can have one account-level field index policy that applies to all log groups in
        /// the account. Or you can create as many as 20 account-level field index policies that
        /// are each scoped to a subset of log groups with the <c>selectionCriteria</c> parameter.
        /// If you have multiple account-level index policies with selection criteria, no two
        /// of them can use the same or overlapping log group name prefixes. For example, if you
        /// have one policy filtered to log groups that start with <c>my-log</c>, you can't have
        /// another field index policy filtered to <c>my-logpprod</c> or <c>my-logging</c>.
        /// </para>
        ///  
        /// <para>
        /// If you create an account-level field index policy in a monitoring account in cross-account
        /// observability, the policy is applied only to the monitoring account and not to any
        /// source accounts.
        /// </para>
        ///  
        /// <para>
        /// If you want to create a field index policy for a single log group, you can use <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutIndexPolicy.html">PutIndexPolicy</a>
        /// instead of <c>PutAccountPolicy</c>. If you do so, that log group will use only that
        /// log-group level policy, and will ignore the account-level policy that you create with
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Metric extraction policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A metric extraction policy controls whether CloudWatch Metrics can be created through
        /// the Embedded Metrics Format (EMF) for log groups in your account. By default, EMF
        /// metric creation is enabled for all log groups. You can use metric extraction policies
        /// to disable EMF metric creation for your entire account or specific log groups.
        /// </para>
        ///  
        /// <para>
        /// When a policy disables EMF metric creation for a log group, log events in the EMF
        /// format are still ingested, but no CloudWatch Metrics are created from them.
        /// </para>
        ///  <important> 
        /// <para>
        /// Creating a policy disables metrics for AWS features that use EMF to create metrics,
        /// such as CloudWatch Container Insights and CloudWatch Application Signals. To prevent
        /// turning off those features by accident, we recommend that you exclude the underlying
        /// log-groups through a selection-criteria such as <c>LogGroupNamePrefix NOT IN ["/aws/containerinsights",
        /// "/aws/ecs/containerinsights", "/aws/application-signals/data"]</c>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Each account can have either one account-level metric extraction policy that applies
        /// to all log groups, or up to 5 policies that are each scoped to a subset of log groups
        /// with the <c>selectionCriteria</c> parameter. The selection criteria supports filtering
        /// by <c>LogGroupName</c> and <c>LogGroupNamePrefix</c> using the operators <c>IN</c>
        /// and <c>NOT IN</c>. You can specify up to 50 values in each <c>IN</c> or <c>NOT IN</c>
        /// list.
        /// </para>
        ///  
        /// <para>
        /// The selection criteria can be specified in these formats:
        /// </para>
        ///  
        /// <para>
        ///  <c>LogGroupName IN ["log-group-1", "log-group-2"]</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>LogGroupNamePrefix NOT IN ["/aws/prefix1", "/aws/prefix2"]</c> 
        /// </para>
        ///  
        /// <para>
        /// If you have multiple account-level metric extraction policies with selection criteria,
        /// no two of them can have overlapping criteria. For example, if you have one policy
        /// with selection criteria <c>LogGroupNamePrefix IN ["my-log"]</c>, you can't have another
        /// metric extraction policy with selection criteria <c>LogGroupNamePrefix IN ["/my-log-prod"]</c>
        /// or <c>LogGroupNamePrefix IN ["/my-logging"]</c>, as the set of log groups matching
        /// these prefixes would be a subset of the log groups matching the first policy's prefix,
        /// creating an overlap.
        /// </para>
        ///  
        /// <para>
        /// When using <c>NOT IN</c>, only one policy with this operator is allowed per account.
        /// </para>
        ///  
        /// <para>
        /// When combining policies with <c>IN</c> and <c>NOT IN</c> operators, the overlap check
        /// ensures that policies don't have conflicting effects. Two policies with <c>IN</c>
        /// and <c>NOT IN</c> operators do not overlap if and only if every value in the <c>IN
        /// </c>policy is completely contained within some value in the <c>NOT IN</c> policy.
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have a <c>NOT IN</c> policy for prefix <c>"/aws/lambda"</c>, you can create
        /// an <c>IN</c> policy for the exact log group name <c>"/aws/lambda/function1"</c> because
        /// the set of log groups matching <c>"/aws/lambda/function1"</c> is a subset of the log
        /// groups matching <c>"/aws/lambda"</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have a <c>NOT IN</c> policy for prefix <c>"/aws/lambda"</c>, you cannot create
        /// an <c>IN</c> policy for prefix <c>"/aws"</c> because the set of log groups matching
        /// <c>"/aws"</c> is not a subset of the log groups matching <c>"/aws/lambda"</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountPolicy service method.</param>
        /// 
        /// <returns>The response from the PutAccountPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutAccountPolicy">REST API Reference for PutAccountPolicy Operation</seealso>
        PutAccountPolicyResponse PutAccountPolicy(PutAccountPolicyRequest request);



        /// <summary>
        /// Creates an account-level data protection policy, subscription filter policy, field
        /// index policy, transformer policy, or metric extraction policy that applies to all
        /// log groups or a subset of log groups in the account.
        /// 
        ///  
        /// <para>
        /// To use this operation, you must be signed on with the correct permissions depending
        /// on the type of policy that you are creating.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To create a data protection policy, you must have the <c>logs:PutDataProtectionPolicy</c>
        /// and <c>logs:PutAccountPolicy</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a subscription filter policy, you must have the <c>logs:PutSubscriptionFilter</c>
        /// and <c>logs:PutAccountPolicy</c> permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a transformer policy, you must have the <c>logs:PutTransformer</c> and <c>logs:PutAccountPolicy</c>
        /// permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a field index policy, you must have the <c>logs:PutIndexPolicy</c> and <c>logs:PutAccountPolicy</c>
        /// permissions.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To create a metric extraction policy, you must have the <c>logs:PutMetricExtractionPolicy</c>
        /// and <c>logs:PutAccountPolicy</c> permissions.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Data protection policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A data protection policy can help safeguard sensitive data that's ingested by your
        /// log groups by auditing and masking the sensitive log data. Each account can have only
        /// one account-level data protection policy.
        /// </para>
        ///  <important> 
        /// <para>
        /// Sensitive data is detected and masked when it is ingested into a log group. When you
        /// set a data protection policy, log events ingested into the log groups before that
        /// time are not masked.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you use <c>PutAccountPolicy</c> to create a data protection policy for your whole
        /// account, it applies to both existing log groups and all log groups that are created
        /// later in this account. The account-level policy is applied to existing log groups
        /// with eventual consistency. It might take up to 5 minutes before sensitive data in
        /// existing log groups begins to be masked.
        /// </para>
        ///  
        /// <para>
        /// By default, when a user views a log event that includes masked data, the sensitive
        /// data is replaced by asterisks. A user who has the <c>logs:Unmask</c> permission can
        /// use a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_FilterLogEvents.html">FilterLogEvents</a>
        /// operation with the <c>unmask</c> parameter set to <c>true</c> to view the unmasked
        /// log events. Users with the <c>logs:Unmask</c> can also view unmasked data in the CloudWatch
        /// Logs console by running a CloudWatch Logs Insights query with the <c>unmask</c> query
        /// command.
        /// </para>
        ///  
        /// <para>
        /// For more information, including a list of types of data that can be audited and masked,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Protect
        /// sensitive log data with masking</a>.
        /// </para>
        ///  
        /// <para>
        /// To use the <c>PutAccountPolicy</c> operation for a data protection policy, you must
        /// be signed on with the <c>logs:PutDataProtectionPolicy</c> and <c>logs:PutAccountPolicy</c>
        /// permissions.
        /// </para>
        ///  
        /// <para>
        /// The <c>PutAccountPolicy</c> operation applies to all log groups in the account. You
        /// can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDataProtectionPolicy.html">PutDataProtectionPolicy</a>
        /// to create a data protection policy that applies to just one log group. If a log group
        /// has its own data protection policy and the account also has an account-level data
        /// protection policy, then the two policies are cumulative. Any sensitive term specified
        /// in either policy is masked.
        /// </para>
        ///  
        /// <para>
        ///  <b>Subscription filter policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A subscription filter policy sets up a real-time feed of log events from CloudWatch
        /// Logs to other Amazon Web Services services. Account-level subscription filter policies
        /// apply to both existing log groups and log groups that are created later in this account.
        /// Supported destinations are Kinesis Data Streams, Firehose, and Lambda. When log events
        /// are sent to the receiving service, they are Base64 encoded and compressed with the
        /// GZIP format.
        /// </para>
        ///  
        /// <para>
        /// The following destinations are supported for subscription filters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Kinesis Data Streams data stream in the same account as the subscription policy,
        /// for same-account delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Firehose data stream in the same account as the subscription policy, for same-account
        /// delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Lambda function in the same account as the subscription policy, for same-account
        /// delivery.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A logical destination in a different account created with <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestination.html">PutDestination</a>,
        /// for cross-account delivery. Kinesis Data Streams and Firehose are supported as logical
        /// destinations.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Each account can have one account-level subscription filter policy per Region. If
        /// you are updating an existing filter, you must specify the correct name in <c>PolicyName</c>.
        /// To perform a <c>PutAccountPolicy</c> subscription filter operation for any destination
        /// except a Lambda function, you must also have the <c>iam:PassRole</c> permission.
        /// </para>
        ///  
        /// <para>
        ///  <b>Transformer policy</b> 
        /// </para>
        ///  
        /// <para>
        /// Creates or updates a <i>log transformer policy</i> for your account. You use log transformers
        /// to transform log events into a different format, making them easier for you to process
        /// and analyze. You can also transform logs from different sources into standardized
        /// formats that contain relevant, source-specific information. After you have created
        /// a transformer, CloudWatch Logs performs this transformation at the time of log ingestion.
        /// You can then refer to the transformed versions of the logs during operations such
        /// as querying with CloudWatch Logs Insights or creating metric filters or subscription
        /// filters.
        /// </para>
        ///  
        /// <para>
        /// You can also use a transformer to copy metadata from metadata keys into the log events
        /// themselves. This metadata can include log group name, log stream name, account ID
        /// and Region.
        /// </para>
        ///  
        /// <para>
        /// A transformer for a log group is a series of processors, where each processor applies
        /// one type of transformation to the log events ingested into this log group. For more
        /// information about the available processors to use in a transformer, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-Processors">
        /// Processors that you can use</a>.
        /// </para>
        ///  
        /// <para>
        /// Having log events in standardized format enables visibility across your applications
        /// for your log analysis, reporting, and alarming needs. CloudWatch Logs provides transformation
        /// for common log types with out-of-the-box transformation templates for major Amazon
        /// Web Services log sources such as VPC flow logs, Lambda, and Amazon RDS. You can use
        /// pre-built transformation templates or create custom transformation policies.
        /// </para>
        ///  
        /// <para>
        /// You can create transformers only for the log groups in the Standard log class.
        /// </para>
        ///  
        /// <para>
        /// You can have one account-level transformer policy that applies to all log groups in
        /// the account. Or you can create as many as 20 account-level transformer policies that
        /// are each scoped to a subset of log groups with the <c>selectionCriteria</c> parameter.
        /// If you have multiple account-level transformer policies with selection criteria, no
        /// two of them can use the same or overlapping log group name prefixes. For example,
        /// if you have one policy filtered to log groups that start with <c>my-log</c>, you can't
        /// have another field index policy filtered to <c>my-logpprod</c> or <c>my-logging</c>.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs provides default field indexes for all log groups in the Standard
        /// log class. Default field indexes are automatically available for the following fields:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>@aws.region</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>@aws.account</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>@source.log</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>traceId</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default field indexes are in addition to any custom field indexes you define within
        /// your policy. Default field indexes are not counted towards your field index quota.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can also set up a transformer at the log-group level. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutTransformer.html">PutTransformer</a>.
        /// If there is both a log-group level transformer created with <c>PutTransformer</c>
        /// and an account-level transformer that could apply to the same log group, the log group
        /// uses only the log-group level transformer. It ignores the account-level transformer.
        /// </para>
        ///  
        /// <para>
        ///  <b>Field index policy</b> 
        /// </para>
        ///  
        /// <para>
        /// You can use field index policies to create indexes on fields found in log events in
        /// the log group. Creating field indexes can help lower the scan volume for CloudWatch
        /// Logs Insights queries that reference those fields, because these queries attempt to
        /// skip the processing of log events that are known to not match the indexed field. Good
        /// fields to index are fields that you often need to query for and fields or values that
        /// match only a small fraction of the total log events. Common examples of indexes include
        /// request ID, session ID, user IDs, or instance IDs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing.html">Create
        /// field indexes to improve query performance and reduce costs</a> 
        /// </para>
        ///  
        /// <para>
        /// To find the fields that are in your log group events, use the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogGroupFields.html">GetLogGroupFields</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose you have created a field index for <c>requestId</c>. Then, any
        /// CloudWatch Logs Insights query on that log group that includes <c>requestId = <i>value</i>
        /// </c> or <c>requestId in [<i>value</i>, <i>value</i>, ...]</c> will attempt to process
        /// only the log events where the indexed field matches the specified value.
        /// </para>
        ///  
        /// <para>
        /// Matches of log events to the names of indexed fields are case-sensitive. For example,
        /// an indexed field of <c>RequestId</c> won't match a log event containing <c>requestId</c>.
        /// </para>
        ///  
        /// <para>
        /// You can have one account-level field index policy that applies to all log groups in
        /// the account. Or you can create as many as 20 account-level field index policies that
        /// are each scoped to a subset of log groups with the <c>selectionCriteria</c> parameter.
        /// If you have multiple account-level index policies with selection criteria, no two
        /// of them can use the same or overlapping log group name prefixes. For example, if you
        /// have one policy filtered to log groups that start with <c>my-log</c>, you can't have
        /// another field index policy filtered to <c>my-logpprod</c> or <c>my-logging</c>.
        /// </para>
        ///  
        /// <para>
        /// If you create an account-level field index policy in a monitoring account in cross-account
        /// observability, the policy is applied only to the monitoring account and not to any
        /// source accounts.
        /// </para>
        ///  
        /// <para>
        /// If you want to create a field index policy for a single log group, you can use <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutIndexPolicy.html">PutIndexPolicy</a>
        /// instead of <c>PutAccountPolicy</c>. If you do so, that log group will use only that
        /// log-group level policy, and will ignore the account-level policy that you create with
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Metric extraction policy</b> 
        /// </para>
        ///  
        /// <para>
        /// A metric extraction policy controls whether CloudWatch Metrics can be created through
        /// the Embedded Metrics Format (EMF) for log groups in your account. By default, EMF
        /// metric creation is enabled for all log groups. You can use metric extraction policies
        /// to disable EMF metric creation for your entire account or specific log groups.
        /// </para>
        ///  
        /// <para>
        /// When a policy disables EMF metric creation for a log group, log events in the EMF
        /// format are still ingested, but no CloudWatch Metrics are created from them.
        /// </para>
        ///  <important> 
        /// <para>
        /// Creating a policy disables metrics for AWS features that use EMF to create metrics,
        /// such as CloudWatch Container Insights and CloudWatch Application Signals. To prevent
        /// turning off those features by accident, we recommend that you exclude the underlying
        /// log-groups through a selection-criteria such as <c>LogGroupNamePrefix NOT IN ["/aws/containerinsights",
        /// "/aws/ecs/containerinsights", "/aws/application-signals/data"]</c>.
        /// </para>
        ///  </important> 
        /// <para>
        /// Each account can have either one account-level metric extraction policy that applies
        /// to all log groups, or up to 5 policies that are each scoped to a subset of log groups
        /// with the <c>selectionCriteria</c> parameter. The selection criteria supports filtering
        /// by <c>LogGroupName</c> and <c>LogGroupNamePrefix</c> using the operators <c>IN</c>
        /// and <c>NOT IN</c>. You can specify up to 50 values in each <c>IN</c> or <c>NOT IN</c>
        /// list.
        /// </para>
        ///  
        /// <para>
        /// The selection criteria can be specified in these formats:
        /// </para>
        ///  
        /// <para>
        ///  <c>LogGroupName IN ["log-group-1", "log-group-2"]</c> 
        /// </para>
        ///  
        /// <para>
        ///  <c>LogGroupNamePrefix NOT IN ["/aws/prefix1", "/aws/prefix2"]</c> 
        /// </para>
        ///  
        /// <para>
        /// If you have multiple account-level metric extraction policies with selection criteria,
        /// no two of them can have overlapping criteria. For example, if you have one policy
        /// with selection criteria <c>LogGroupNamePrefix IN ["my-log"]</c>, you can't have another
        /// metric extraction policy with selection criteria <c>LogGroupNamePrefix IN ["/my-log-prod"]</c>
        /// or <c>LogGroupNamePrefix IN ["/my-logging"]</c>, as the set of log groups matching
        /// these prefixes would be a subset of the log groups matching the first policy's prefix,
        /// creating an overlap.
        /// </para>
        ///  
        /// <para>
        /// When using <c>NOT IN</c>, only one policy with this operator is allowed per account.
        /// </para>
        ///  
        /// <para>
        /// When combining policies with <c>IN</c> and <c>NOT IN</c> operators, the overlap check
        /// ensures that policies don't have conflicting effects. Two policies with <c>IN</c>
        /// and <c>NOT IN</c> operators do not overlap if and only if every value in the <c>IN
        /// </c>policy is completely contained within some value in the <c>NOT IN</c> policy.
        /// For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you have a <c>NOT IN</c> policy for prefix <c>"/aws/lambda"</c>, you can create
        /// an <c>IN</c> policy for the exact log group name <c>"/aws/lambda/function1"</c> because
        /// the set of log groups matching <c>"/aws/lambda/function1"</c> is a subset of the log
        /// groups matching <c>"/aws/lambda"</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you have a <c>NOT IN</c> policy for prefix <c>"/aws/lambda"</c>, you cannot create
        /// an <c>IN</c> policy for prefix <c>"/aws"</c> because the set of log groups matching
        /// <c>"/aws"</c> is not a subset of the log groups matching <c>"/aws/lambda"</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAccountPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAccountPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutAccountPolicy">REST API Reference for PutAccountPolicy Operation</seealso>
        Task<PutAccountPolicyResponse> PutAccountPolicyAsync(PutAccountPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// data is replaced by asterisks. A user who has the <c>logs:Unmask</c> permission can
        /// use a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_FilterLogEvents.html">FilterLogEvents</a>
        /// operation with the <c>unmask</c> parameter set to <c>true</c> to view the unmasked
        /// log events. Users with the <c>logs:Unmask</c> can also view unmasked data in the CloudWatch
        /// Logs console by running a CloudWatch Logs Insights query with the <c>unmask</c> query
        /// command.
        /// </para>
        ///  
        /// <para>
        /// For more information, including a list of types of data that can be audited and masked,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Protect
        /// sensitive log data with masking</a>.
        /// </para>
        ///  
        /// <para>
        /// The <c>PutDataProtectionPolicy</c> operation applies to only the specified log group.
        /// You can also use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>
        /// to create an account-level data protection policy that applies to all log groups in
        /// the account, including both existing log groups and log groups that are created level.
        /// If a log group has its own data protection policy and the account also has an account-level
        /// data protection policy, then the two policies are cumulative. Any sensitive term specified
        /// in either policy is masked.
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
        /// data is replaced by asterisks. A user who has the <c>logs:Unmask</c> permission can
        /// use a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogEvents.html">GetLogEvents</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_FilterLogEvents.html">FilterLogEvents</a>
        /// operation with the <c>unmask</c> parameter set to <c>true</c> to view the unmasked
        /// log events. Users with the <c>logs:Unmask</c> can also view unmasked data in the CloudWatch
        /// Logs console by running a CloudWatch Logs Insights query with the <c>unmask</c> query
        /// command.
        /// </para>
        ///  
        /// <para>
        /// For more information, including a list of types of data that can be audited and masked,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/mask-sensitive-log-data.html">Protect
        /// sensitive log data with masking</a>.
        /// </para>
        ///  
        /// <para>
        /// The <c>PutDataProtectionPolicy</c> operation applies to only the specified log group.
        /// You can also use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>
        /// to create an account-level data protection policy that applies to all log groups in
        /// the account, including both existing log groups and log groups that are created level.
        /// If a log group has its own data protection policy and the account also has an account-level
        /// data protection policy, then the two policies are cumulative. Any sensitive term specified
        /// in either policy is masked.
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
        
        #region  PutDeliveryDestination


        /// <summary>
        /// Creates or updates a logical <i>delivery destination</i>. A delivery destination is
        /// an Amazon Web Services resource that represents an Amazon Web Services service that
        /// logs can be sent to. CloudWatch Logs, Amazon S3, and Firehose are supported as logs
        /// delivery destinations and X-Ray as the trace delivery destination.
        /// 
        ///  
        /// <para>
        /// To configure logs delivery between a supported Amazon Web Services service and a destination,
        /// you must do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a delivery source, which is a logical object that represents the resource that
        /// is actually sending the logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>PutDeliveryDestination</c> to create a <i>delivery destination</i> in the same
        /// account of the actual delivery destination. The delivery destination that you create
        /// is a logical object that represents the actual delivery destination. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are delivering logs cross-account, you must use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>
        /// in the destination account to assign an IAM policy to the destination. This policy
        /// allows delivery to that destination. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>CreateDelivery</c> to create a <i>delivery</i> by pairing exactly one delivery
        /// source and one delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can configure a single delivery source to send logs to multiple destinations by
        /// creating multiple deliveries. You can also create multiple deliveries to configure
        /// multiple delivery sources to send logs to the same delivery destination.
        /// </para>
        ///  
        /// <para>
        /// Only some Amazon Web Services services support being configured as a delivery source.
        /// These services are listed as <b>Supported [V2 Permissions]</b> in the table at <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        ///  
        /// <para>
        /// If you use this operation to update an existing delivery destination, all the current
        /// delivery destination parameters are overwritten with the new parameter values that
        /// you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryDestination service method.</param>
        /// 
        /// <returns>The response from the PutDeliveryDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliveryDestination">REST API Reference for PutDeliveryDestination Operation</seealso>
        PutDeliveryDestinationResponse PutDeliveryDestination(PutDeliveryDestinationRequest request);



        /// <summary>
        /// Creates or updates a logical <i>delivery destination</i>. A delivery destination is
        /// an Amazon Web Services resource that represents an Amazon Web Services service that
        /// logs can be sent to. CloudWatch Logs, Amazon S3, and Firehose are supported as logs
        /// delivery destinations and X-Ray as the trace delivery destination.
        /// 
        ///  
        /// <para>
        /// To configure logs delivery between a supported Amazon Web Services service and a destination,
        /// you must do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Create a delivery source, which is a logical object that represents the resource that
        /// is actually sending the logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>PutDeliveryDestination</c> to create a <i>delivery destination</i> in the same
        /// account of the actual delivery destination. The delivery destination that you create
        /// is a logical object that represents the actual delivery destination. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are delivering logs cross-account, you must use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>
        /// in the destination account to assign an IAM policy to the destination. This policy
        /// allows delivery to that destination. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>CreateDelivery</c> to create a <i>delivery</i> by pairing exactly one delivery
        /// source and one delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can configure a single delivery source to send logs to multiple destinations by
        /// creating multiple deliveries. You can also create multiple deliveries to configure
        /// multiple delivery sources to send logs to the same delivery destination.
        /// </para>
        ///  
        /// <para>
        /// Only some Amazon Web Services services support being configured as a delivery source.
        /// These services are listed as <b>Supported [V2 Permissions]</b> in the table at <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        ///  
        /// <para>
        /// If you use this operation to update an existing delivery destination, all the current
        /// delivery destination parameters are overwritten with the new parameter values that
        /// you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDeliveryDestination service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliveryDestination">REST API Reference for PutDeliveryDestination Operation</seealso>
        Task<PutDeliveryDestinationResponse> PutDeliveryDestinationAsync(PutDeliveryDestinationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDeliveryDestinationPolicy


        /// <summary>
        /// Creates and assigns an IAM policy that grants permissions to CloudWatch Logs to deliver
        /// logs cross-account to a specified destination in this account. To configure the delivery
        /// of logs from an Amazon Web Services service in another account to a logs delivery
        /// destination in the current account, you must do the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Create a delivery source, which is a logical object that represents the resource that
        /// is actually sending the logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <i>delivery destination</i>, which is a logical object that represents the
        /// actual delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">PutDeliveryDestination</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use this operation in the destination account to assign an IAM policy to the destination.
        /// This policy allows delivery to that destination. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <i>delivery</i> by pairing exactly one delivery source and one delivery destination.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only some Amazon Web Services services support being configured as a delivery source.
        /// These services are listed as <b>Supported [V2 Permissions]</b> in the table at <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        ///  
        /// <para>
        /// The contents of the policy must include two statements. One statement enables general
        /// logs delivery, and the other allows delivery to the chosen destination. See the examples
        /// for the needed policies.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryDestinationPolicy service method.</param>
        /// 
        /// <returns>The response from the PutDeliveryDestinationPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliveryDestinationPolicy">REST API Reference for PutDeliveryDestinationPolicy Operation</seealso>
        PutDeliveryDestinationPolicyResponse PutDeliveryDestinationPolicy(PutDeliveryDestinationPolicyRequest request);



        /// <summary>
        /// Creates and assigns an IAM policy that grants permissions to CloudWatch Logs to deliver
        /// logs cross-account to a specified destination in this account. To configure the delivery
        /// of logs from an Amazon Web Services service in another account to a logs delivery
        /// destination in the current account, you must do the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Create a delivery source, which is a logical object that represents the resource that
        /// is actually sending the logs. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliverySource.html">PutDeliverySource</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <i>delivery destination</i>, which is a logical object that represents the
        /// actual delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">PutDeliveryDestination</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use this operation in the destination account to assign an IAM policy to the destination.
        /// This policy allows delivery to that destination. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Create a <i>delivery</i> by pairing exactly one delivery source and one delivery destination.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Only some Amazon Web Services services support being configured as a delivery source.
        /// These services are listed as <b>Supported [V2 Permissions]</b> in the table at <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        ///  
        /// <para>
        /// The contents of the policy must include two statements. One statement enables general
        /// logs delivery, and the other allows delivery to the chosen destination. See the examples
        /// for the needed policies.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryDestinationPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDeliveryDestinationPolicy service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliveryDestinationPolicy">REST API Reference for PutDeliveryDestinationPolicy Operation</seealso>
        Task<PutDeliveryDestinationPolicyResponse> PutDeliveryDestinationPolicyAsync(PutDeliveryDestinationPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutDeliverySource


        /// <summary>
        /// Creates or updates a logical <i>delivery source</i>. A delivery source represents
        /// an Amazon Web Services resource that sends logs to an logs delivery destination. The
        /// destination can be CloudWatch Logs, Amazon S3, Firehose or X-Ray for sending traces.
        /// 
        ///  
        /// <para>
        /// To configure logs delivery between a delivery destination and an Amazon Web Services
        /// service that is supported as a delivery source, you must do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>PutDeliverySource</c> to create a delivery source, which is a logical object
        /// that represents the resource that is actually sending the logs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>PutDeliveryDestination</c> to create a <i>delivery destination</i>, which is
        /// a logical object that represents the actual delivery destination. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">PutDeliveryDestination</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are delivering logs cross-account, you must use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>
        /// in the destination account to assign an IAM policy to the destination. This policy
        /// allows delivery to that destination. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>CreateDelivery</c> to create a <i>delivery</i> by pairing exactly one delivery
        /// source and one delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can configure a single delivery source to send logs to multiple destinations by
        /// creating multiple deliveries. You can also create multiple deliveries to configure
        /// multiple delivery sources to send logs to the same delivery destination.
        /// </para>
        ///  
        /// <para>
        /// Only some Amazon Web Services services support being configured as a delivery source.
        /// These services are listed as <b>Supported [V2 Permissions]</b> in the table at <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        ///  
        /// <para>
        /// If you use this operation to update an existing delivery source, all the current delivery
        /// source parameters are overwritten with the new parameter values that you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverySource service method.</param>
        /// 
        /// <returns>The response from the PutDeliverySource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliverySource">REST API Reference for PutDeliverySource Operation</seealso>
        PutDeliverySourceResponse PutDeliverySource(PutDeliverySourceRequest request);



        /// <summary>
        /// Creates or updates a logical <i>delivery source</i>. A delivery source represents
        /// an Amazon Web Services resource that sends logs to an logs delivery destination. The
        /// destination can be CloudWatch Logs, Amazon S3, Firehose or X-Ray for sending traces.
        /// 
        ///  
        /// <para>
        /// To configure logs delivery between a delivery destination and an Amazon Web Services
        /// service that is supported as a delivery source, you must do the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Use <c>PutDeliverySource</c> to create a delivery source, which is a logical object
        /// that represents the resource that is actually sending the logs. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>PutDeliveryDestination</c> to create a <i>delivery destination</i>, which is
        /// a logical object that represents the actual delivery destination. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestination.html">PutDeliveryDestination</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you are delivering logs cross-account, you must use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDeliveryDestinationPolicy.html">PutDeliveryDestinationPolicy</a>
        /// in the destination account to assign an IAM policy to the destination. This policy
        /// allows delivery to that destination. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Use <c>CreateDelivery</c> to create a <i>delivery</i> by pairing exactly one delivery
        /// source and one delivery destination. For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_CreateDelivery.html">CreateDelivery</a>.
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can configure a single delivery source to send logs to multiple destinations by
        /// creating multiple deliveries. You can also create multiple deliveries to configure
        /// multiple delivery sources to send logs to the same delivery destination.
        /// </para>
        ///  
        /// <para>
        /// Only some Amazon Web Services services support being configured as a delivery source.
        /// These services are listed as <b>Supported [V2 Permissions]</b> in the table at <a
        /// href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enabling
        /// logging from Amazon Web Services services.</a> 
        /// </para>
        ///  
        /// <para>
        /// If you use this operation to update an existing delivery source, all the current delivery
        /// source parameters are overwritten with the new parameter values that you specify.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutDeliverySource service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceQuotaExceededException">
        /// This request exceeds a service quota.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliverySource">REST API Reference for PutDeliverySource Operation</seealso>
        Task<PutDeliverySourceResponse> PutDeliverySourceAsync(PutDeliverySourceRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// <c>PutDestination</c> does not set any access policy with the destination, which means
        /// a cross-account user cannot call <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutSubscriptionFilter.html">PutSubscriptionFilter</a>
        /// against this destination. To enable this, the destination owner must call <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestinationPolicy.html">PutDestinationPolicy</a>
        /// after <c>PutDestination</c>.
        /// </para>
        ///  
        /// <para>
        /// To perform a <c>PutDestination</c> operation, you must also have the <c>iam:PassRole</c>
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
        /// <c>PutDestination</c> does not set any access policy with the destination, which means
        /// a cross-account user cannot call <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutSubscriptionFilter.html">PutSubscriptionFilter</a>
        /// against this destination. To enable this, the destination owner must call <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestinationPolicy.html">PutDestinationPolicy</a>
        /// after <c>PutDestination</c>.
        /// </para>
        ///  
        /// <para>
        /// To perform a <c>PutDestination</c> operation, you must also have the <c>iam:PassRole</c>
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
        
        #region  PutIndexPolicy


        /// <summary>
        /// Creates or updates a <i>field index policy</i> for the specified log group. Only log
        /// groups in the Standard log class support field index policies. For more information
        /// about log classes, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch_Logs_Log_Classes.html">Log
        /// classes</a>.
        /// 
        ///  
        /// <para>
        /// You can use field index policies to create <i>field indexes</i> on fields found in
        /// log events in the log group. Creating field indexes speeds up and lowers the costs
        /// for CloudWatch Logs Insights queries that reference those field indexes, because these
        /// queries attempt to skip the processing of log events that are known to not match the
        /// indexed field. Good fields to index are fields that you often need to query for and
        /// fields or values that match only a small fraction of the total log events. Common
        /// examples of indexes include request ID, session ID, userID, and instance IDs. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing.html">Create
        /// field indexes to improve query performance and reduce costs</a>.
        /// </para>
        ///  
        /// <para>
        /// To find the fields that are in your log group events, use the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogGroupFields.html">GetLogGroupFields</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose you have created a field index for <c>requestId</c>. Then, any
        /// CloudWatch Logs Insights query on that log group that includes <c>requestId = <i>value</i>
        /// </c> or <c>requestId IN [<i>value</i>, <i>value</i>, ...]</c> will process fewer log
        /// events to reduce costs, and have improved performance.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs provides default field indexes for all log groups in the Standard
        /// log class. Default field indexes are automatically available for the following fields:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>@aws.region</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>@aws.account</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>@source.log</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>traceId</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default field indexes are in addition to any custom field indexes you define within
        /// your policy. Default field indexes are not counted towards your field index quota.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Each index policy has the following quotas and restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// As many as 20 fields can be included in the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each field name can include as many as 100 characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Matches of log events to the names of indexed fields are case-sensitive. For example,
        /// a field index of <c>RequestId</c> won't match a log event containing <c>requestId</c>.
        /// </para>
        ///  
        /// <para>
        /// Log group-level field index policies created with <c>PutIndexPolicy</c> override account-level
        /// field index policies created with <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>.
        /// If you use <c>PutIndexPolicy</c> to create a field index policy for a log group, that
        /// log group uses only that policy. The log group ignores any account-wide field index
        /// policy that you might have created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIndexPolicy service method.</param>
        /// 
        /// <returns>The response from the PutIndexPolicy service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutIndexPolicy">REST API Reference for PutIndexPolicy Operation</seealso>
        PutIndexPolicyResponse PutIndexPolicy(PutIndexPolicyRequest request);



        /// <summary>
        /// Creates or updates a <i>field index policy</i> for the specified log group. Only log
        /// groups in the Standard log class support field index policies. For more information
        /// about log classes, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch_Logs_Log_Classes.html">Log
        /// classes</a>.
        /// 
        ///  
        /// <para>
        /// You can use field index policies to create <i>field indexes</i> on fields found in
        /// log events in the log group. Creating field indexes speeds up and lowers the costs
        /// for CloudWatch Logs Insights queries that reference those field indexes, because these
        /// queries attempt to skip the processing of log events that are known to not match the
        /// indexed field. Good fields to index are fields that you often need to query for and
        /// fields or values that match only a small fraction of the total log events. Common
        /// examples of indexes include request ID, session ID, userID, and instance IDs. For
        /// more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-Field-Indexing.html">Create
        /// field indexes to improve query performance and reduce costs</a>.
        /// </para>
        ///  
        /// <para>
        /// To find the fields that are in your log group events, use the <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetLogGroupFields.html">GetLogGroupFields</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For example, suppose you have created a field index for <c>requestId</c>. Then, any
        /// CloudWatch Logs Insights query on that log group that includes <c>requestId = <i>value</i>
        /// </c> or <c>requestId IN [<i>value</i>, <i>value</i>, ...]</c> will process fewer log
        /// events to reduce costs, and have improved performance.
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs provides default field indexes for all log groups in the Standard
        /// log class. Default field indexes are automatically available for the following fields:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>@aws.region</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>@aws.account</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>@source.log</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>traceId</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Default field indexes are in addition to any custom field indexes you define within
        /// your policy. Default field indexes are not counted towards your field index quota.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Each index policy has the following quotas and restrictions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// As many as 20 fields can be included in the policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each field name can include as many as 100 characters.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Matches of log events to the names of indexed fields are case-sensitive. For example,
        /// a field index of <c>RequestId</c> won't match a log event containing <c>requestId</c>.
        /// </para>
        ///  
        /// <para>
        /// Log group-level field index policies created with <c>PutIndexPolicy</c> override account-level
        /// field index policies created with <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>.
        /// If you use <c>PutIndexPolicy</c> to create a field index policy for a log group, that
        /// log group uses only that policy. The log group ignores any account-wide field index
        /// policy that you might have created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIndexPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutIndexPolicy service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutIndexPolicy">REST API Reference for PutIndexPolicy Operation</seealso>
        Task<PutIndexPolicyResponse> PutIndexPolicyAsync(PutIndexPolicyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutIntegration


        /// <summary>
        /// Creates an integration between CloudWatch Logs and another service in this account.
        /// Currently, only integrations with OpenSearch Service are supported, and currently
        /// you can have only one integration in your account.
        /// 
        ///  
        /// <para>
        /// Integrating with OpenSearch Service makes it possible for you to create curated vended
        /// logs dashboards, powered by OpenSearch Service analytics. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-OpenSearch-Dashboards.html">Vended
        /// log dashboards powered by Amazon OpenSearch Service</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use this operation only to create a new integration. You can't modify an existing
        /// integration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration service method.</param>
        /// 
        /// <returns>The response from the PutIntegration service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        PutIntegrationResponse PutIntegration(PutIntegrationRequest request);



        /// <summary>
        /// Creates an integration between CloudWatch Logs and another service in this account.
        /// Currently, only integrations with OpenSearch Service are supported, and currently
        /// you can have only one integration in your account.
        /// 
        ///  
        /// <para>
        /// Integrating with OpenSearch Service makes it possible for you to create curated vended
        /// logs dashboards, powered by OpenSearch Service analytics. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs-OpenSearch-Dashboards.html">Vended
        /// log dashboards powered by Amazon OpenSearch Service</a>.
        /// </para>
        ///  
        /// <para>
        /// You can use this operation only to create a new integration. You can't modify an existing
        /// integration.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutIntegration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutIntegration service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutIntegration">REST API Reference for PutIntegration Operation</seealso>
        Task<PutIntegrationResponse> PutIntegrationAsync(PutIntegrationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  PutLogEvents


        /// <summary>
        /// Uploads a batch of log events to the specified log stream.
        /// 
        ///  <important> 
        /// <para>
        /// The sequence token is now ignored in <c>PutLogEvents</c> actions. <c>PutLogEvents</c>
        /// actions are always accepted and never return <c>InvalidSequenceTokenException</c>
        /// or <c>DataAlreadyAcceptedException</c> even if the sequence token is not valid. You
        /// can use parallel <c>PutLogEvents</c> actions on the same log stream. 
        /// </para>
        ///  </important> 
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
        /// Events more than 2 hours in the future are rejected while processing remaining valid
        /// events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Events older than 14 days or preceding the log group's retention period are rejected
        /// while processing remaining valid events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The log events in the batch must be in chronological order by their timestamp. The
        /// timestamp is the time that the event occurred, expressed as the number of milliseconds
        /// after <c>Jan 1, 1970 00:00:00 UTC</c>. (In Amazon Web Services Tools for PowerShell
        /// and the Amazon Web Services SDK for .NET, the timestamp is specified in .NET format:
        /// <c>yyyy-mm-ddThh:mm:ss</c>. For example, <c>2017-09-15T13:45:30</c>.) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  A batch of log events in a single request must be in a chronological order. Otherwise,
        /// the operation fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each log event can be no larger than 1 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum number of log events in a batch is 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For valid events (within 14 days in the past to 2 hours in future), the time span
        /// in a single batch cannot exceed 24 hours. Otherwise, the operation fails.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// The quota of five requests per second per log stream has been removed. Instead, <c>PutLogEvents</c>
        /// actions are throttled based on a per-second per-account quota. You can request an
        /// increase to the per-second throttling quota by using the Service Quotas service.
        /// </para>
        ///  </important> 
        /// <para>
        /// If a call to <c>PutLogEvents</c> returns "UnrecognizedClientException" the most likely
        /// cause is a non-valid Amazon Web Services access key ID or secret key. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutLogEvents service method.</param>
        /// 
        /// <returns>The response from the PutLogEvents service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.DataAlreadyAcceptedException">
        /// The event was already logged.
        /// 
        ///  <important> 
        /// <para>
        ///  <c>PutLogEvents</c> actions are now always accepted and never return <c>DataAlreadyAcceptedException</c>
        /// regardless of whether a given batch of log events has already been accepted. 
        /// </para>
        ///  </important>
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidSequenceTokenException">
        /// The sequence token is not valid. You can get the correct sequence token in the <c>expectedSequenceToken</c>
        /// field in the <c>InvalidSequenceTokenException</c> message. 
        /// 
        ///  <important> 
        /// <para>
        ///  <c>PutLogEvents</c> actions are now always accepted and never return <c>InvalidSequenceTokenException</c>
        /// regardless of receiving an invalid sequence token. 
        /// </para>
        ///  </important>
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
        ///  <important> 
        /// <para>
        /// The sequence token is now ignored in <c>PutLogEvents</c> actions. <c>PutLogEvents</c>
        /// actions are always accepted and never return <c>InvalidSequenceTokenException</c>
        /// or <c>DataAlreadyAcceptedException</c> even if the sequence token is not valid. You
        /// can use parallel <c>PutLogEvents</c> actions on the same log stream. 
        /// </para>
        ///  </important> 
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
        /// Events more than 2 hours in the future are rejected while processing remaining valid
        /// events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Events older than 14 days or preceding the log group's retention period are rejected
        /// while processing remaining valid events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The log events in the batch must be in chronological order by their timestamp. The
        /// timestamp is the time that the event occurred, expressed as the number of milliseconds
        /// after <c>Jan 1, 1970 00:00:00 UTC</c>. (In Amazon Web Services Tools for PowerShell
        /// and the Amazon Web Services SDK for .NET, the timestamp is specified in .NET format:
        /// <c>yyyy-mm-ddThh:mm:ss</c>. For example, <c>2017-09-15T13:45:30</c>.) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  A batch of log events in a single request must be in a chronological order. Otherwise,
        /// the operation fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each log event can be no larger than 1 MB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum number of log events in a batch is 10,000.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For valid events (within 14 days in the past to 2 hours in future), the time span
        /// in a single batch cannot exceed 24 hours. Otherwise, the operation fails.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// The quota of five requests per second per log stream has been removed. Instead, <c>PutLogEvents</c>
        /// actions are throttled based on a per-second per-account quota. You can request an
        /// increase to the per-second throttling quota by using the Service Quotas service.
        /// </para>
        ///  </important> 
        /// <para>
        /// If a call to <c>PutLogEvents</c> returns "UnrecognizedClientException" the most likely
        /// cause is a non-valid Amazon Web Services access key ID or secret key. 
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
        /// 
        ///  <important> 
        /// <para>
        ///  <c>PutLogEvents</c> actions are now always accepted and never return <c>DataAlreadyAcceptedException</c>
        /// regardless of whether a given batch of log events has already been accepted. 
        /// </para>
        ///  </important>
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidSequenceTokenException">
        /// The sequence token is not valid. You can get the correct sequence token in the <c>expectedSequenceToken</c>
        /// field in the <c>InvalidSequenceTokenException</c> message. 
        /// 
        ///  <important> 
        /// <para>
        ///  <c>PutLogEvents</c> actions are now always accepted and never return <c>InvalidSequenceTokenException</c>
        /// regardless of receiving an invalid sequence token. 
        /// </para>
        ///  </important>
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
        /// Using regular expressions in filter patterns is supported. For these filters, there
        /// is a quota of two regular expression patterns within a single filter pattern. There
        /// is also a quota of five regular expression patterns per log group. For more information
        /// about using regular expressions in filter patterns, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">
        /// Filter pattern syntax for metric filters, subscription filters, filter log events,
        /// and Live Tail</a>.
        /// </para>
        ///  
        /// <para>
        /// When you create a metric filter, you can also optionally assign a unit and dimensions
        /// to the metric that is created.
        /// </para>
        ///  <important> 
        /// <para>
        /// Metrics extracted from log events are charged as custom metrics. To prevent unexpected
        /// high charges, do not specify high-cardinality fields such as <c>IPAddress</c> or <c>requestID</c>
        /// as dimensions. Each different value found for a dimension is treated as a separate
        /// metric and accrues charges as a separate custom metric. 
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs might disable a metric filter if it generates 1,000 different name/value
        /// pairs for your specified dimensions within one hour.
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
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
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
        /// Using regular expressions in filter patterns is supported. For these filters, there
        /// is a quota of two regular expression patterns within a single filter pattern. There
        /// is also a quota of five regular expression patterns per log group. For more information
        /// about using regular expressions in filter patterns, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">
        /// Filter pattern syntax for metric filters, subscription filters, filter log events,
        /// and Live Tail</a>.
        /// </para>
        ///  
        /// <para>
        /// When you create a metric filter, you can also optionally assign a unit and dimensions
        /// to the metric that is created.
        /// </para>
        ///  <important> 
        /// <para>
        /// Metrics extracted from log events are charged as custom metrics. To prevent unexpected
        /// high charges, do not specify high-cardinality fields such as <c>IPAddress</c> or <c>requestID</c>
        /// as dimensions. Each different value found for a dimension is treated as a separate
        /// metric and accrues charges as a separate custom metric. 
        /// </para>
        ///  
        /// <para>
        /// CloudWatch Logs might disable a metric filter if it generates 1,000 different name/value
        /// pairs for your specified dimensions within one hour.
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
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
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
        /// To update a query definition, specify its <c>queryDefinitionId</c> in your request.
        /// The values of <c>name</c>, <c>queryString</c>, and <c>logGroupNames</c> are changed
        /// to the values that you specify in your update operation. No current values are retained
        /// from the current query definition. For example, imagine updating a current query definition
        /// that includes log groups. If you don't specify the <c>logGroupNames</c> parameter
        /// in your update operation, the query definition changes to contain no log groups.
        /// </para>
        ///  
        /// <para>
        /// You must have the <c>logs:PutQueryDefinition</c> permission to be able to perform
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
        /// To update a query definition, specify its <c>queryDefinitionId</c> in your request.
        /// The values of <c>name</c>, <c>queryString</c>, and <c>logGroupNames</c> are changed
        /// to the values that you specify in your update operation. No current values are retained
        /// from the current query definition. For example, imagine updating a current query definition
        /// that includes log groups. If you don't specify the <c>logGroupNames</c> parameter
        /// in your update operation, the query definition changes to contain no log groups.
        /// </para>
        ///  
        /// <para>
        /// You must have the <c>logs:PutQueryDefinition</c> permission to be able to perform
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
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
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
        /// <exception cref="Amazon.CloudWatchLogs.Model.OperationAbortedException">
        /// Multiple concurrent requests to update the same resource were in conflict.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
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
        /// CloudWatch Logs doesn't immediately delete log events when they reach their retention
        /// setting. It typically takes up to 72 hours after that before log events are deleted,
        /// but in rare situations might take longer.
        /// </para>
        ///  
        /// <para>
        /// To illustrate, imagine that you change a log group to have a longer retention setting
        /// when it contains log events that are past the expiration date, but haven't been deleted.
        /// Those log events will take up to 72 hours to be deleted after the new retention date
        /// is reached. To make sure that log data is deleted permanently, keep a log group at
        /// its lower retention setting until 72 hours after the previous retention period ends.
        /// Alternatively, wait to change the retention setting until you confirm that the earlier
        /// log events are deleted. 
        /// </para>
        ///  
        /// <para>
        /// When log events reach their retention setting they are marked for deletion. After
        /// they are marked for deletion, they do not add to your archival storage costs anymore,
        /// even if they are not actually deleted until later. These log events marked for deletion
        /// are also not included when you use an API to retrieve the <c>storedBytes</c> value
        /// to see how many bytes a log group is storing.
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
        /// CloudWatch Logs doesn't immediately delete log events when they reach their retention
        /// setting. It typically takes up to 72 hours after that before log events are deleted,
        /// but in rare situations might take longer.
        /// </para>
        ///  
        /// <para>
        /// To illustrate, imagine that you change a log group to have a longer retention setting
        /// when it contains log events that are past the expiration date, but haven't been deleted.
        /// Those log events will take up to 72 hours to be deleted after the new retention date
        /// is reached. To make sure that log data is deleted permanently, keep a log group at
        /// its lower retention setting until 72 hours after the previous retention period ends.
        /// Alternatively, wait to change the retention setting until you confirm that the earlier
        /// log events are deleted. 
        /// </para>
        ///  
        /// <para>
        /// When log events reach their retention setting they are marked for deletion. After
        /// they are marked for deletion, they do not add to your archival storage costs anymore,
        /// even if they are not actually deleted until later. These log events marked for deletion
        /// are also not included when you use an API to retrieve the <c>storedBytes</c> value
        /// to see how many bytes a log group is storing.
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
        /// A logical destination created with <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestination.html">PutDestination</a>
        /// that belongs to a different account, for cross-account delivery. We currently support
        /// Kinesis Data Streams and Firehose as logical destinations.
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
        /// are updating an existing filter, you must specify the correct name in <c>filterName</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Using regular expressions in filter patterns is supported. For these filters, there
        /// is a quotas of quota of two regular expression patterns within a single filter pattern.
        /// There is also a quota of five regular expression patterns per log group. For more
        /// information about using regular expressions in filter patterns, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">
        /// Filter pattern syntax for metric filters, subscription filters, filter log events,
        /// and Live Tail</a>.
        /// </para>
        ///  
        /// <para>
        /// To perform a <c>PutSubscriptionFilter</c> operation for any destination except a Lambda
        /// function, you must also have the <c>iam:PassRole</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSubscriptionFilter service method.</param>
        /// 
        /// <returns>The response from the PutSubscriptionFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
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
        /// A logical destination created with <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutDestination.html">PutDestination</a>
        /// that belongs to a different account, for cross-account delivery. We currently support
        /// Kinesis Data Streams and Firehose as logical destinations.
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
        /// are updating an existing filter, you must specify the correct name in <c>filterName</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Using regular expressions in filter patterns is supported. For these filters, there
        /// is a quotas of quota of two regular expression patterns within a single filter pattern.
        /// There is also a quota of five regular expression patterns per log group. For more
        /// information about using regular expressions in filter patterns, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/FilterAndPatternSyntax.html">
        /// Filter pattern syntax for metric filters, subscription filters, filter log events,
        /// and Live Tail</a>.
        /// </para>
        ///  
        /// <para>
        /// To perform a <c>PutSubscriptionFilter</c> operation for any destination except a Lambda
        /// function, you must also have the <c>iam:PassRole</c> permission.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutSubscriptionFilter service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutSubscriptionFilter service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
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
        
        #region  PutTransformer


        /// <summary>
        /// Creates or updates a <i>log transformer</i> for a single log group. You use log transformers
        /// to transform log events into a different format, making them easier for you to process
        /// and analyze. You can also transform logs from different sources into standardized
        /// formats that contains relevant, source-specific information.
        /// 
        ///  
        /// <para>
        /// After you have created a transformer, CloudWatch Logs performs the transformations
        /// at the time of log ingestion. You can then refer to the transformed versions of the
        /// logs during operations such as querying with CloudWatch Logs Insights or creating
        /// metric filters or subscription filers.
        /// </para>
        ///  
        /// <para>
        /// You can also use a transformer to copy metadata from metadata keys into the log events
        /// themselves. This metadata can include log group name, log stream name, account ID
        /// and Region.
        /// </para>
        ///  
        /// <para>
        /// A transformer for a log group is a series of processors, where each processor applies
        /// one type of transformation to the log events ingested into this log group. The processors
        /// work one after another, in the order that you list them, like a pipeline. For more
        /// information about the available processors to use in a transformer, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-Processors">
        /// Processors that you can use</a>.
        /// </para>
        ///  
        /// <para>
        /// Having log events in standardized format enables visibility across your applications
        /// for your log analysis, reporting, and alarming needs. CloudWatch Logs provides transformation
        /// for common log types with out-of-the-box transformation templates for major Amazon
        /// Web Services log sources such as VPC flow logs, Lambda, and Amazon RDS. You can use
        /// pre-built transformation templates or create custom transformation policies.
        /// </para>
        ///  
        /// <para>
        /// You can create transformers only for the log groups in the Standard log class.
        /// </para>
        ///  
        /// <para>
        /// You can also set up a transformer at the account level. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>.
        /// If there is both a log-group level transformer created with <c>PutTransformer</c>
        /// and an account-level transformer that could apply to the same log group, the log group
        /// uses only the log-group level transformer. It ignores the account-level transformer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTransformer service method.</param>
        /// 
        /// <returns>The response from the PutTransformer service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutTransformer">REST API Reference for PutTransformer Operation</seealso>
        PutTransformerResponse PutTransformer(PutTransformerRequest request);



        /// <summary>
        /// Creates or updates a <i>log transformer</i> for a single log group. You use log transformers
        /// to transform log events into a different format, making them easier for you to process
        /// and analyze. You can also transform logs from different sources into standardized
        /// formats that contains relevant, source-specific information.
        /// 
        ///  
        /// <para>
        /// After you have created a transformer, CloudWatch Logs performs the transformations
        /// at the time of log ingestion. You can then refer to the transformed versions of the
        /// logs during operations such as querying with CloudWatch Logs Insights or creating
        /// metric filters or subscription filers.
        /// </para>
        ///  
        /// <para>
        /// You can also use a transformer to copy metadata from metadata keys into the log events
        /// themselves. This metadata can include log group name, log stream name, account ID
        /// and Region.
        /// </para>
        ///  
        /// <para>
        /// A transformer for a log group is a series of processors, where each processor applies
        /// one type of transformation to the log events ingested into this log group. The processors
        /// work one after another, in the order that you list them, like a pipeline. For more
        /// information about the available processors to use in a transformer, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatch-Logs-Transformation.html#CloudWatch-Logs-Transformation-Processors">
        /// Processors that you can use</a>.
        /// </para>
        ///  
        /// <para>
        /// Having log events in standardized format enables visibility across your applications
        /// for your log analysis, reporting, and alarming needs. CloudWatch Logs provides transformation
        /// for common log types with out-of-the-box transformation templates for major Amazon
        /// Web Services log sources such as VPC flow logs, Lambda, and Amazon RDS. You can use
        /// pre-built transformation templates or create custom transformation policies.
        /// </para>
        ///  
        /// <para>
        /// You can create transformers only for the log groups in the Standard log class.
        /// </para>
        ///  
        /// <para>
        /// You can also set up a transformer at the account level. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_PutAccountPolicy.html">PutAccountPolicy</a>.
        /// If there is both a log-group level transformer created with <c>PutTransformer</c>
        /// and an account-level transformer that could apply to the same log group, the log group
        /// uses only the log-group level transformer. It ignores the account-level transformer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutTransformer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutTransformer service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutTransformer">REST API Reference for PutTransformer Operation</seealso>
        Task<PutTransformerResponse> PutTransformerAsync(PutTransformerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartLiveTail


        /// <summary>
        /// Starts a Live Tail streaming session for one or more log groups. A Live Tail session
        /// returns a stream of log events that have been recently ingested in the log groups.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs_LiveTail.html">Use
        /// Live Tail to view logs in near real time</a>. 
        /// 
        ///  
        /// <para>
        /// The response to this operation is a response stream, over which the server sends live
        /// log events and the client receives them.
        /// </para>
        ///  
        /// <para>
        /// The following objects are sent over the stream:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A single <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_LiveTailSessionStart.html">LiveTailSessionStart</a>
        /// object is sent at the start of the session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Every second, a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_LiveTailSessionUpdate.html">LiveTailSessionUpdate</a>
        /// object is sent. Each of these objects contains an array of the actual log events.
        /// </para>
        ///  
        /// <para>
        /// If no new log events were ingested in the past second, the <c>LiveTailSessionUpdate</c>
        /// object will contain an empty array.
        /// </para>
        ///  
        /// <para>
        /// The array of log events contained in a <c>LiveTailSessionUpdate</c> can include as
        /// many as 500 log events. If the number of log events matching the request exceeds 500
        /// per second, the log events are sampled down to 500 log events to be included in each
        /// <c>LiveTailSessionUpdate</c> object.
        /// </para>
        ///  
        /// <para>
        /// If your client consumes the log events slower than the server produces them, CloudWatch
        /// Logs buffers up to 10 <c>LiveTailSessionUpdate</c> events or 5000 log events, after
        /// which it starts dropping the oldest events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartLiveTailResponseStream.html#CWL-Type-StartLiveTailResponseStream-SessionStreamingException">SessionStreamingException</a>
        /// object is returned if an unknown error occurs on the server side.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartLiveTailResponseStream.html#CWL-Type-StartLiveTailResponseStream-SessionTimeoutException">SessionTimeoutException</a>
        /// object is returned when the session times out, after it has been kept open for three
        /// hours.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>StartLiveTail</c> API routes requests to <c>streaming-logs.<i>Region</i>.amazonaws.com</c>
        /// using SDK host prefix injection. VPC endpoint support is not available for this API.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You can end a session before it times out by closing the session stream or by closing
        /// the client that is receiving the stream. The session also ends if the established
        /// connection between the client and the server breaks.
        /// </para>
        ///  </important> 
        /// <para>
        /// For examples of using an SDK to start a Live Tail session, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/example_cloudwatch-logs_StartLiveTail_section.html">
        /// Start a Live Tail session using an Amazon Web Services SDK</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLiveTail service method.</param>
        /// 
        /// <returns>The response from the StartLiveTail service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StartLiveTail">REST API Reference for StartLiveTail Operation</seealso>
        StartLiveTailResponse StartLiveTail(StartLiveTailRequest request);



        /// <summary>
        /// Starts a Live Tail streaming session for one or more log groups. A Live Tail session
        /// returns a stream of log events that have been recently ingested in the log groups.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CloudWatchLogs_LiveTail.html">Use
        /// Live Tail to view logs in near real time</a>. 
        /// 
        ///  
        /// <para>
        /// The response to this operation is a response stream, over which the server sends live
        /// log events and the client receives them.
        /// </para>
        ///  
        /// <para>
        /// The following objects are sent over the stream:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// A single <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_LiveTailSessionStart.html">LiveTailSessionStart</a>
        /// object is sent at the start of the session.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Every second, a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_LiveTailSessionUpdate.html">LiveTailSessionUpdate</a>
        /// object is sent. Each of these objects contains an array of the actual log events.
        /// </para>
        ///  
        /// <para>
        /// If no new log events were ingested in the past second, the <c>LiveTailSessionUpdate</c>
        /// object will contain an empty array.
        /// </para>
        ///  
        /// <para>
        /// The array of log events contained in a <c>LiveTailSessionUpdate</c> can include as
        /// many as 500 log events. If the number of log events matching the request exceeds 500
        /// per second, the log events are sampled down to 500 log events to be included in each
        /// <c>LiveTailSessionUpdate</c> object.
        /// </para>
        ///  
        /// <para>
        /// If your client consumes the log events slower than the server produces them, CloudWatch
        /// Logs buffers up to 10 <c>LiveTailSessionUpdate</c> events or 5000 log events, after
        /// which it starts dropping the oldest events.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartLiveTailResponseStream.html#CWL-Type-StartLiveTailResponseStream-SessionStreamingException">SessionStreamingException</a>
        /// object is returned if an unknown error occurs on the server side.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartLiveTailResponseStream.html#CWL-Type-StartLiveTailResponseStream-SessionTimeoutException">SessionTimeoutException</a>
        /// object is returned when the session times out, after it has been kept open for three
        /// hours.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>StartLiveTail</c> API routes requests to <c>streaming-logs.<i>Region</i>.amazonaws.com</c>
        /// using SDK host prefix injection. VPC endpoint support is not available for this API.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// You can end a session before it times out by closing the session stream or by closing
        /// the client that is receiving the stream. The session also ends if the established
        /// connection between the client and the server breaks.
        /// </para>
        ///  </important> 
        /// <para>
        /// For examples of using an SDK to start a Live Tail session, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/example_cloudwatch-logs_StartLiveTail_section.html">
        /// Start a Live Tail session using an Amazon Web Services SDK</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartLiveTail service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartLiveTail service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.LimitExceededException">
        /// You have reached the maximum number of resources that can be created.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StartLiveTail">REST API Reference for StartLiveTail Operation</seealso>
        Task<StartLiveTailResponse> StartLiveTailAsync(StartLiveTailRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  StartQuery


        /// <summary>
        /// Starts a query of one or more log groups using CloudWatch Logs Insights. You specify
        /// the log groups and time range to query and the query string to use.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax.html">CloudWatch
        /// Logs Insights Query Syntax</a>.
        /// </para>
        ///  
        /// <para>
        /// After you run a query using <c>StartQuery</c>, the query results are stored by CloudWatch
        /// Logs. You can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetQueryResults.html">GetQueryResults</a>
        /// to retrieve the results of a query, using the <c>queryId</c> that <c>StartQuery</c>
        /// returns. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To specify the log groups to query, a <c>StartQuery</c> operation must include one
        /// of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Either exactly one of the following parameters: <c>logGroupName</c>, <c>logGroupNames</c>,
        /// or <c>logGroupIdentifiers</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Or the <c>queryString</c> must include a <c>SOURCE</c> command to select log groups
        /// for the query. The <c>SOURCE</c> command can select log groups based on log group
        /// name prefix, account ID, and log class. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>SOURCE</c> command, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax-Source.html">SOURCE</a>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// If you have associated a KMS key with the query results in this account, then <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
        /// uses that key to encrypt the results when it stores them. If no key is associated
        /// with query results, the query results are encrypted with the default CloudWatch Logs
        /// encryption method.
        /// </para>
        ///  
        /// <para>
        /// Queries time out after 60 minutes of runtime. If your queries are timing out, reduce
        /// the time range being searched or partition your query into a number of queries.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account to start a query in a linked source account. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>. For a cross-account <c>StartQuery</c> operation,
        /// the query definition must be defined in the monitoring account.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 30 concurrent CloudWatch Logs insights queries, including queries
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
        /// The query string is not valid. Details about this error are displayed in a <c>QueryCompileError</c>
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
        /// Starts a query of one or more log groups using CloudWatch Logs Insights. You specify
        /// the log groups and time range to query and the query string to use.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax.html">CloudWatch
        /// Logs Insights Query Syntax</a>.
        /// </para>
        ///  
        /// <para>
        /// After you run a query using <c>StartQuery</c>, the query results are stored by CloudWatch
        /// Logs. You can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetQueryResults.html">GetQueryResults</a>
        /// to retrieve the results of a query, using the <c>queryId</c> that <c>StartQuery</c>
        /// returns. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To specify the log groups to query, a <c>StartQuery</c> operation must include one
        /// of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Either exactly one of the following parameters: <c>logGroupName</c>, <c>logGroupNames</c>,
        /// or <c>logGroupIdentifiers</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Or the <c>queryString</c> must include a <c>SOURCE</c> command to select log groups
        /// for the query. The <c>SOURCE</c> command can select log groups based on log group
        /// name prefix, account ID, and log class. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the <c>SOURCE</c> command, see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/CWL_QuerySyntax-Source.html">SOURCE</a>.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// If you have associated a KMS key with the query results in this account, then <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_StartQuery.html">StartQuery</a>
        /// uses that key to encrypt the results when it stores them. If no key is associated
        /// with query results, the query results are encrypted with the default CloudWatch Logs
        /// encryption method.
        /// </para>
        ///  
        /// <para>
        /// Queries time out after 60 minutes of runtime. If your queries are timing out, reduce
        /// the time range being searched or partition your query into a number of queries.
        /// </para>
        ///  
        /// <para>
        /// If you are using CloudWatch cross-account observability, you can use this operation
        /// in a monitoring account to start a query in a linked source account. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-Unified-Cross-Account.html">CloudWatch
        /// cross-account observability</a>. For a cross-account <c>StartQuery</c> operation,
        /// the query definition must be defined in the monitoring account.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 30 concurrent CloudWatch Logs insights queries, including queries
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
        /// The query string is not valid. Details about this error are displayed in a <c>QueryCompileError</c>
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
        /// CloudWatch Logs doesn't support IAM policies that prevent users from assigning specified
        /// tags to log groups using the <c>aws:Resource/<i>key-name</i> </c> or <c>aws:TagKeys</c>
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
        /// CloudWatch Logs doesn't support IAM policies that prevent users from assigning specified
        /// tags to log groups using the <c>aws:Resource/<i>key-name</i> </c> or <c>aws:TagKeys</c>
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
        /// You can use the <c>TagResource</c> action with a resource that already has tags. If
        /// you specify a new tag key for the alarm, this tag is appended to the list of tags
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
        /// You can use the <c>TagResource</c> action with a resource that already has tags. If
        /// you specify a new tag key for the alarm, this tag is appended to the list of tags
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
        
        #region  TestTransformer


        /// <summary>
        /// Use this operation to test a log transformer. You enter the transformer configuration
        /// and a set of log events to test with. The operation responds with an array that includes
        /// the original log events and the transformed versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestTransformer service method.</param>
        /// 
        /// <returns>The response from the TestTransformer service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TestTransformer">REST API Reference for TestTransformer Operation</seealso>
        TestTransformerResponse TestTransformer(TestTransformerRequest request);



        /// <summary>
        /// Use this operation to test a log transformer. You enter the transformer configuration
        /// and a set of log events to test with. The operation responds with an array that includes
        /// the original log events and the transformed versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TestTransformer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TestTransformer service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidOperationException">
        /// The operation is not valid on the specified resource.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.InvalidParameterException">
        /// A parameter is specified incorrectly.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TestTransformer">REST API Reference for TestTransformer Operation</seealso>
        Task<TestTransformerResponse> TestTransformerAsync(TestTransformerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// When using IAM policies to control tag management for CloudWatch Logs log groups,
        /// the condition keys <c>aws:Resource/key-name</c> and <c>aws:TagKeys</c> cannot be used
        /// to restrict which tags users can assign. 
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
        /// When using IAM policies to control tag management for CloudWatch Logs log groups,
        /// the condition keys <c>aws:Resource/key-name</c> and <c>aws:TagKeys</c> cannot be used
        /// to restrict which tags users can assign. 
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
        
        #region  UpdateAnomaly


        /// <summary>
        /// Use this operation to <i>suppress</i> anomaly detection for a specified anomaly or
        /// pattern. If you suppress an anomaly, CloudWatch Logs won't report new occurrences
        /// of that anomaly and won't update that anomaly with new data. If you suppress a pattern,
        /// CloudWatch Logs won't report any anomalies related to that pattern.
        /// 
        ///  
        /// <para>
        /// You must specify either <c>anomalyId</c> or <c>patternId</c>, but you can't specify
        /// both parameters in the same operation.
        /// </para>
        ///  
        /// <para>
        /// If you have previously used this operation to suppress detection of a pattern or anomaly,
        /// you can use it again to cause CloudWatch Logs to end the suppression. To do this,
        /// use this operation and specify the anomaly or pattern to stop suppressing, and omit
        /// the <c>suppressionType</c> and <c>suppressionPeriod</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomaly service method.</param>
        /// 
        /// <returns>The response from the UpdateAnomaly service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UpdateAnomaly">REST API Reference for UpdateAnomaly Operation</seealso>
        UpdateAnomalyResponse UpdateAnomaly(UpdateAnomalyRequest request);



        /// <summary>
        /// Use this operation to <i>suppress</i> anomaly detection for a specified anomaly or
        /// pattern. If you suppress an anomaly, CloudWatch Logs won't report new occurrences
        /// of that anomaly and won't update that anomaly with new data. If you suppress a pattern,
        /// CloudWatch Logs won't report any anomalies related to that pattern.
        /// 
        ///  
        /// <para>
        /// You must specify either <c>anomalyId</c> or <c>patternId</c>, but you can't specify
        /// both parameters in the same operation.
        /// </para>
        ///  
        /// <para>
        /// If you have previously used this operation to suppress detection of a pattern or anomaly,
        /// you can use it again to cause CloudWatch Logs to end the suppression. To do this,
        /// use this operation and specify the anomaly or pattern to stop suppressing, and omit
        /// the <c>suppressionType</c> and <c>suppressionPeriod</c> parameters.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomaly service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAnomaly service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UpdateAnomaly">REST API Reference for UpdateAnomaly Operation</seealso>
        Task<UpdateAnomalyResponse> UpdateAnomalyAsync(UpdateAnomalyRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateDeliveryConfiguration


        /// <summary>
        /// Use this operation to update the configuration of a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_Delivery.html">delivery</a>
        /// to change either the S3 path pattern or the format of the delivered logs. You can't
        /// use this operation to change the source or destination of the delivery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeliveryConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateDeliveryConfiguration service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UpdateDeliveryConfiguration">REST API Reference for UpdateDeliveryConfiguration Operation</seealso>
        UpdateDeliveryConfigurationResponse UpdateDeliveryConfiguration(UpdateDeliveryConfigurationRequest request);



        /// <summary>
        /// Use this operation to update the configuration of a <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_Delivery.html">delivery</a>
        /// to change either the S3 path pattern or the format of the delivered logs. You can't
        /// use this operation to change the source or destination of the delivery.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDeliveryConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDeliveryConfiguration service method, as returned by CloudWatchLogs.</returns>
        /// <exception cref="Amazon.CloudWatchLogs.Model.AccessDeniedException">
        /// You don't have sufficient permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ConflictException">
        /// This operation attempted to create a resource that already exists.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ResourceNotFoundException">
        /// The specified resource does not exist.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// The service cannot complete the request.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ThrottlingException">
        /// The request was throttled because of quota limits.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ValidationException">
        /// One of the parameters for the request is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UpdateDeliveryConfiguration">REST API Reference for UpdateDeliveryConfiguration Operation</seealso>
        Task<UpdateDeliveryConfigurationResponse> UpdateDeliveryConfigurationAsync(UpdateDeliveryConfigurationRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  UpdateLogAnomalyDetector


        /// <summary>
        /// Updates an existing log anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogAnomalyDetector service method.</param>
        /// 
        /// <returns>The response from the UpdateLogAnomalyDetector service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UpdateLogAnomalyDetector">REST API Reference for UpdateLogAnomalyDetector Operation</seealso>
        UpdateLogAnomalyDetectorResponse UpdateLogAnomalyDetector(UpdateLogAnomalyDetectorRequest request);



        /// <summary>
        /// Updates an existing log anomaly detector.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogAnomalyDetector service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLogAnomalyDetector service method, as returned by CloudWatchLogs.</returns>
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UpdateLogAnomalyDetector">REST API Reference for UpdateLogAnomalyDetector Operation</seealso>
        Task<UpdateLogAnomalyDetectorResponse> UpdateLogAnomalyDetectorAsync(UpdateLogAnomalyDetectorRequest request, CancellationToken cancellationToken = default(CancellationToken));

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