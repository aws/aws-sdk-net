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
using System.Collections.Generic;
using System.Net;

using Amazon.CloudWatchLogs.Model;
using Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations;
using Amazon.CloudWatchLogs.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatchLogs
{
    /// <summary>
    /// Implementation for accessing CloudWatchLogs
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
    public partial class AmazonCloudWatchLogsClient : AmazonServiceClient, IAmazonCloudWatchLogs
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudWatchLogsMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private ICloudWatchLogsPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ICloudWatchLogsPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new CloudWatchLogsPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonCloudWatchLogsClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchLogsConfig()) { }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchLogsClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonCloudWatchLogsConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonCloudWatchLogsClient Configuration Object</param>
        public AmazonCloudWatchLogsClient(AmazonCloudWatchLogsConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonCloudWatchLogsClient(AWSCredentials credentials)
            : this(credentials, new AmazonCloudWatchLogsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchLogsClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonCloudWatchLogsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with AWS Credentials and an
        /// AmazonCloudWatchLogsClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonCloudWatchLogsClient Configuration Object</param>
        public AmazonCloudWatchLogsClient(AWSCredentials credentials, AmazonCloudWatchLogsConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonCloudWatchLogsClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchLogsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchLogsClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonCloudWatchLogsConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchLogsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonCloudWatchLogsClient Configuration Object</param>
        public AmazonCloudWatchLogsClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonCloudWatchLogsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonCloudWatchLogsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchLogsConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonCloudWatchLogsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonCloudWatchLogsConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonCloudWatchLogsClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonCloudWatchLogsClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonCloudWatchLogsClient Configuration Object</param>
        public AmazonCloudWatchLogsClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonCloudWatchLogsConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonCloudWatchLogsEndpointResolver());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


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
        public virtual AssociateKmsKeyResponse AssociateKmsKey(AssociateKmsKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateKmsKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateKmsKeyResponseUnmarshaller.Instance;

            return Invoke<AssociateKmsKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateKmsKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateKmsKey operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateKmsKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/AssociateKmsKey">REST API Reference for AssociateKmsKey Operation</seealso>
        public virtual IAsyncResult BeginAssociateKmsKey(AssociateKmsKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateKmsKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateKmsKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateKmsKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateKmsKey.</param>
        /// 
        /// <returns>Returns a  AssociateKmsKeyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/AssociateKmsKey">REST API Reference for AssociateKmsKey Operation</seealso>
        public virtual AssociateKmsKeyResponse EndAssociateKmsKey(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateKmsKeyResponse>(asyncResult);
        }

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
        public virtual CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelExportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual IAsyncResult BeginCancelExportTask(CancelExportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelExportTask.</param>
        /// 
        /// <returns>Returns a  CancelExportTaskResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual CancelExportTaskResponse EndCancelExportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelExportTaskResponse>(asyncResult);
        }

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
        public virtual CreateExportTaskResponse CreateExportTask(CreateExportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateExportTaskResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateExportTask operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateExportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateExportTask">REST API Reference for CreateExportTask Operation</seealso>
        public virtual IAsyncResult BeginCreateExportTask(CreateExportTaskRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportTaskResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateExportTask.</param>
        /// 
        /// <returns>Returns a  CreateExportTaskResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateExportTask">REST API Reference for CreateExportTask Operation</seealso>
        public virtual CreateExportTaskResponse EndCreateExportTask(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateExportTaskResponse>(asyncResult);
        }

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
        public virtual CreateLogGroupResponse CreateLogGroup(CreateLogGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogGroupResponseUnmarshaller.Instance;

            return Invoke<CreateLogGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLogGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLogGroup operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLogGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogGroup">REST API Reference for CreateLogGroup Operation</seealso>
        public virtual IAsyncResult BeginCreateLogGroup(CreateLogGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLogGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLogGroup.</param>
        /// 
        /// <returns>Returns a  CreateLogGroupResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogGroup">REST API Reference for CreateLogGroup Operation</seealso>
        public virtual CreateLogGroupResponse EndCreateLogGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLogGroupResponse>(asyncResult);
        }

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
        public virtual CreateLogStreamResponse CreateLogStream(CreateLogStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogStreamResponseUnmarshaller.Instance;

            return Invoke<CreateLogStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLogStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLogStream operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLogStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogStream">REST API Reference for CreateLogStream Operation</seealso>
        public virtual IAsyncResult BeginCreateLogStream(CreateLogStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLogStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLogStream.</param>
        /// 
        /// <returns>Returns a  CreateLogStreamResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogStream">REST API Reference for CreateLogStream Operation</seealso>
        public virtual CreateLogStreamResponse EndCreateLogStream(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLogStreamResponse>(asyncResult);
        }

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
        public virtual DeleteDataProtectionPolicyResponse DeleteDataProtectionPolicy(DeleteDataProtectionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataProtectionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProtectionPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteDataProtectionPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDataProtectionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDataProtectionPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDataProtectionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDataProtectionPolicy">REST API Reference for DeleteDataProtectionPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteDataProtectionPolicy(DeleteDataProtectionPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDataProtectionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDataProtectionPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDataProtectionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDataProtectionPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteDataProtectionPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDataProtectionPolicy">REST API Reference for DeleteDataProtectionPolicy Operation</seealso>
        public virtual DeleteDataProtectionPolicyResponse EndDeleteDataProtectionPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDataProtectionPolicyResponse>(asyncResult);
        }

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
        public virtual DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual IAsyncResult BeginDeleteDestination(DeleteDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDestination.</param>
        /// 
        /// <returns>Returns a  DeleteDestinationResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual DeleteDestinationResponse EndDeleteDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDestinationResponse>(asyncResult);
        }

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
        public virtual DeleteLogGroupResponse DeleteLogGroup(DeleteLogGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteLogGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLogGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogGroup operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLogGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogGroup">REST API Reference for DeleteLogGroup Operation</seealso>
        public virtual IAsyncResult BeginDeleteLogGroup(DeleteLogGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLogGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLogGroup.</param>
        /// 
        /// <returns>Returns a  DeleteLogGroupResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogGroup">REST API Reference for DeleteLogGroup Operation</seealso>
        public virtual DeleteLogGroupResponse EndDeleteLogGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLogGroupResponse>(asyncResult);
        }

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
        public virtual DeleteLogStreamResponse DeleteLogStream(DeleteLogStreamRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteLogStreamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLogStream operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogStream operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLogStream
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogStream">REST API Reference for DeleteLogStream Operation</seealso>
        public virtual IAsyncResult BeginDeleteLogStream(DeleteLogStreamRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogStreamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLogStream operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLogStream.</param>
        /// 
        /// <returns>Returns a  DeleteLogStreamResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogStream">REST API Reference for DeleteLogStream Operation</seealso>
        public virtual DeleteLogStreamResponse EndDeleteLogStream(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLogStreamResponse>(asyncResult);
        }

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
        public virtual DeleteMetricFilterResponse DeleteMetricFilter(DeleteMetricFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMetricFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMetricFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteMetricFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMetricFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricFilter operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteMetricFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteMetricFilter">REST API Reference for DeleteMetricFilter Operation</seealso>
        public virtual IAsyncResult BeginDeleteMetricFilter(DeleteMetricFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMetricFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMetricFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteMetricFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMetricFilter.</param>
        /// 
        /// <returns>Returns a  DeleteMetricFilterResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteMetricFilter">REST API Reference for DeleteMetricFilter Operation</seealso>
        public virtual DeleteMetricFilterResponse EndDeleteMetricFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteMetricFilterResponse>(asyncResult);
        }

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
        public virtual DeleteQueryDefinitionResponse DeleteQueryDefinition(DeleteQueryDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueryDefinitionResponseUnmarshaller.Instance;

            return Invoke<DeleteQueryDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueryDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueryDefinition operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteQueryDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteQueryDefinition">REST API Reference for DeleteQueryDefinition Operation</seealso>
        public virtual IAsyncResult BeginDeleteQueryDefinition(DeleteQueryDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueryDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteQueryDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueryDefinition.</param>
        /// 
        /// <returns>Returns a  DeleteQueryDefinitionResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteQueryDefinition">REST API Reference for DeleteQueryDefinition Operation</seealso>
        public virtual DeleteQueryDefinitionResponse EndDeleteQueryDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteQueryDefinitionResponse>(asyncResult);
        }

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
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
        }

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
        public virtual DeleteRetentionPolicyResponse DeleteRetentionPolicy(DeleteRetentionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetentionPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRetentionPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRetentionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteRetentionPolicy">REST API Reference for DeleteRetentionPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteRetentionPolicy(DeleteRetentionPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetentionPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRetentionPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteRetentionPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteRetentionPolicy">REST API Reference for DeleteRetentionPolicy Operation</seealso>
        public virtual DeleteRetentionPolicyResponse EndDeleteRetentionPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRetentionPolicyResponse>(asyncResult);
        }

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
        public virtual DeleteSubscriptionFilterResponse DeleteSubscriptionFilter(DeleteSubscriptionFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubscriptionFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionFilter operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubscriptionFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteSubscriptionFilter">REST API Reference for DeleteSubscriptionFilter Operation</seealso>
        public virtual IAsyncResult BeginDeleteSubscriptionFilter(DeleteSubscriptionFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubscriptionFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubscriptionFilter.</param>
        /// 
        /// <returns>Returns a  DeleteSubscriptionFilterResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteSubscriptionFilter">REST API Reference for DeleteSubscriptionFilter Operation</seealso>
        public virtual DeleteSubscriptionFilterResponse EndDeleteSubscriptionFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSubscriptionFilterResponse>(asyncResult);
        }

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
        public virtual DescribeDestinationsResponse DescribeDestinations(DescribeDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDestinationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDestinationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDestinations operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDestinations">REST API Reference for DescribeDestinations Operation</seealso>
        public virtual IAsyncResult BeginDescribeDestinations(DescribeDestinationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDestinationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDestinations.</param>
        /// 
        /// <returns>Returns a  DescribeDestinationsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDestinations">REST API Reference for DescribeDestinations Operation</seealso>
        public virtual DescribeDestinationsResponse EndDescribeDestinations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDestinationsResponse>(asyncResult);
        }

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
        public virtual DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExportTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual IAsyncResult BeginDescribeExportTasks(DescribeExportTasksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExportTasks.</param>
        /// 
        /// <returns>Returns a  DescribeExportTasksResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual DescribeExportTasksResponse EndDescribeExportTasks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeExportTasksResponse>(asyncResult);
        }

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
        public virtual DescribeLogGroupsResponse DescribeLogGroups()
        {
            return DescribeLogGroups(new DescribeLogGroupsRequest());
        }

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
        public virtual DescribeLogGroupsResponse DescribeLogGroups(DescribeLogGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLogGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeLogGroupsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLogGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogGroups operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLogGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogGroups">REST API Reference for DescribeLogGroups Operation</seealso>
        public virtual IAsyncResult BeginDescribeLogGroups(DescribeLogGroupsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLogGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogGroupsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLogGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLogGroups.</param>
        /// 
        /// <returns>Returns a  DescribeLogGroupsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogGroups">REST API Reference for DescribeLogGroups Operation</seealso>
        public virtual DescribeLogGroupsResponse EndDescribeLogGroups(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLogGroupsResponse>(asyncResult);
        }

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
        public virtual DescribeLogStreamsResponse DescribeLogStreams(DescribeLogStreamsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLogStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogStreamsResponseUnmarshaller.Instance;

            return Invoke<DescribeLogStreamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLogStreams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogStreams operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLogStreams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogStreams">REST API Reference for DescribeLogStreams Operation</seealso>
        public virtual IAsyncResult BeginDescribeLogStreams(DescribeLogStreamsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLogStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogStreamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLogStreams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLogStreams.</param>
        /// 
        /// <returns>Returns a  DescribeLogStreamsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogStreams">REST API Reference for DescribeLogStreams Operation</seealso>
        public virtual DescribeLogStreamsResponse EndDescribeLogStreams(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeLogStreamsResponse>(asyncResult);
        }

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
        public virtual DescribeMetricFiltersResponse DescribeMetricFilters(DescribeMetricFiltersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetricFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricFiltersResponseUnmarshaller.Instance;

            return Invoke<DescribeMetricFiltersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMetricFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricFilters operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMetricFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeMetricFilters">REST API Reference for DescribeMetricFilters Operation</seealso>
        public virtual IAsyncResult BeginDescribeMetricFilters(DescribeMetricFiltersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetricFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricFiltersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMetricFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMetricFilters.</param>
        /// 
        /// <returns>Returns a  DescribeMetricFiltersResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeMetricFilters">REST API Reference for DescribeMetricFilters Operation</seealso>
        public virtual DescribeMetricFiltersResponse EndDescribeMetricFilters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeMetricFiltersResponse>(asyncResult);
        }

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
        public virtual DescribeQueriesResponse DescribeQueries(DescribeQueriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueriesResponseUnmarshaller.Instance;

            return Invoke<DescribeQueriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQueries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueries operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQueries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeQueries">REST API Reference for DescribeQueries Operation</seealso>
        public virtual IAsyncResult BeginDescribeQueries(DescribeQueriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQueries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQueries.</param>
        /// 
        /// <returns>Returns a  DescribeQueriesResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeQueries">REST API Reference for DescribeQueries Operation</seealso>
        public virtual DescribeQueriesResponse EndDescribeQueries(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeQueriesResponse>(asyncResult);
        }

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
        public virtual DescribeQueryDefinitionsResponse DescribeQueryDefinitions(DescribeQueryDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQueryDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueryDefinitionsResponseUnmarshaller.Instance;

            return Invoke<DescribeQueryDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeQueryDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueryDefinitions operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeQueryDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeQueryDefinitions">REST API Reference for DescribeQueryDefinitions Operation</seealso>
        public virtual IAsyncResult BeginDescribeQueryDefinitions(DescribeQueryDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQueryDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueryDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeQueryDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeQueryDefinitions.</param>
        /// 
        /// <returns>Returns a  DescribeQueryDefinitionsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeQueryDefinitions">REST API Reference for DescribeQueryDefinitions Operation</seealso>
        public virtual DescribeQueryDefinitionsResponse EndDescribeQueryDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeQueryDefinitionsResponse>(asyncResult);
        }

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
        public virtual DescribeResourcePoliciesResponse DescribeResourcePolicies(DescribeResourcePoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeResourcePoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicies operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeResourcePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeResourcePolicies">REST API Reference for DescribeResourcePolicies Operation</seealso>
        public virtual IAsyncResult BeginDescribeResourcePolicies(DescribeResourcePoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeResourcePolicies.</param>
        /// 
        /// <returns>Returns a  DescribeResourcePoliciesResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeResourcePolicies">REST API Reference for DescribeResourcePolicies Operation</seealso>
        public virtual DescribeResourcePoliciesResponse EndDescribeResourcePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeResourcePoliciesResponse>(asyncResult);
        }

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
        public virtual DescribeSubscriptionFiltersResponse DescribeSubscriptionFilters(DescribeSubscriptionFiltersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscriptionFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscriptionFiltersResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscriptionFiltersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubscriptionFilters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscriptionFilters operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubscriptionFilters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeSubscriptionFilters">REST API Reference for DescribeSubscriptionFilters Operation</seealso>
        public virtual IAsyncResult BeginDescribeSubscriptionFilters(DescribeSubscriptionFiltersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscriptionFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscriptionFiltersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubscriptionFilters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubscriptionFilters.</param>
        /// 
        /// <returns>Returns a  DescribeSubscriptionFiltersResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeSubscriptionFilters">REST API Reference for DescribeSubscriptionFilters Operation</seealso>
        public virtual DescribeSubscriptionFiltersResponse EndDescribeSubscriptionFilters(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSubscriptionFiltersResponse>(asyncResult);
        }

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
        public virtual DisassociateKmsKeyResponse DisassociateKmsKey(DisassociateKmsKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateKmsKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateKmsKeyResponseUnmarshaller.Instance;

            return Invoke<DisassociateKmsKeyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateKmsKey operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateKmsKey operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateKmsKey
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DisassociateKmsKey">REST API Reference for DisassociateKmsKey Operation</seealso>
        public virtual IAsyncResult BeginDisassociateKmsKey(DisassociateKmsKeyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateKmsKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateKmsKeyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateKmsKey operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateKmsKey.</param>
        /// 
        /// <returns>Returns a  DisassociateKmsKeyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DisassociateKmsKey">REST API Reference for DisassociateKmsKey Operation</seealso>
        public virtual DisassociateKmsKeyResponse EndDisassociateKmsKey(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateKmsKeyResponse>(asyncResult);
        }

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
        public virtual FilterLogEventsResponse FilterLogEvents(FilterLogEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FilterLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FilterLogEventsResponseUnmarshaller.Instance;

            return Invoke<FilterLogEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the FilterLogEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the FilterLogEvents operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndFilterLogEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/FilterLogEvents">REST API Reference for FilterLogEvents Operation</seealso>
        public virtual IAsyncResult BeginFilterLogEvents(FilterLogEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FilterLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FilterLogEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  FilterLogEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginFilterLogEvents.</param>
        /// 
        /// <returns>Returns a  FilterLogEventsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/FilterLogEvents">REST API Reference for FilterLogEvents Operation</seealso>
        public virtual FilterLogEventsResponse EndFilterLogEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<FilterLogEventsResponse>(asyncResult);
        }

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
        public virtual GetDataProtectionPolicyResponse GetDataProtectionPolicy(GetDataProtectionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataProtectionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataProtectionPolicyResponseUnmarshaller.Instance;

            return Invoke<GetDataProtectionPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDataProtectionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDataProtectionPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDataProtectionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDataProtectionPolicy">REST API Reference for GetDataProtectionPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetDataProtectionPolicy(GetDataProtectionPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDataProtectionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDataProtectionPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDataProtectionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDataProtectionPolicy.</param>
        /// 
        /// <returns>Returns a  GetDataProtectionPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDataProtectionPolicy">REST API Reference for GetDataProtectionPolicy Operation</seealso>
        public virtual GetDataProtectionPolicyResponse EndGetDataProtectionPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDataProtectionPolicyResponse>(asyncResult);
        }

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
        public virtual GetLogEventsResponse GetLogEvents(GetLogEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogEventsResponseUnmarshaller.Instance;

            return Invoke<GetLogEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLogEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLogEvents operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLogEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogEvents">REST API Reference for GetLogEvents Operation</seealso>
        public virtual IAsyncResult BeginGetLogEvents(GetLogEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLogEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLogEvents.</param>
        /// 
        /// <returns>Returns a  GetLogEventsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogEvents">REST API Reference for GetLogEvents Operation</seealso>
        public virtual GetLogEventsResponse EndGetLogEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLogEventsResponse>(asyncResult);
        }

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
        public virtual GetLogGroupFieldsResponse GetLogGroupFields(GetLogGroupFieldsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogGroupFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogGroupFieldsResponseUnmarshaller.Instance;

            return Invoke<GetLogGroupFieldsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLogGroupFields operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLogGroupFields operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLogGroupFields
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogGroupFields">REST API Reference for GetLogGroupFields Operation</seealso>
        public virtual IAsyncResult BeginGetLogGroupFields(GetLogGroupFieldsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogGroupFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogGroupFieldsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLogGroupFields operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLogGroupFields.</param>
        /// 
        /// <returns>Returns a  GetLogGroupFieldsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogGroupFields">REST API Reference for GetLogGroupFields Operation</seealso>
        public virtual GetLogGroupFieldsResponse EndGetLogGroupFields(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLogGroupFieldsResponse>(asyncResult);
        }

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
        public virtual GetLogRecordResponse GetLogRecord(GetLogRecordRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogRecordResponseUnmarshaller.Instance;

            return Invoke<GetLogRecordResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLogRecord operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLogRecord operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLogRecord
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogRecord">REST API Reference for GetLogRecord Operation</seealso>
        public virtual IAsyncResult BeginGetLogRecord(GetLogRecordRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogRecordResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLogRecord operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLogRecord.</param>
        /// 
        /// <returns>Returns a  GetLogRecordResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogRecord">REST API Reference for GetLogRecord Operation</seealso>
        public virtual GetLogRecordResponse EndGetLogRecord(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLogRecordResponse>(asyncResult);
        }

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
        public virtual GetQueryResultsResponse GetQueryResults(GetQueryResultsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return Invoke<GetQueryResultsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueryResults operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueryResults
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual IAsyncResult BeginGetQueryResults(GetQueryResultsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetQueryResults operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueryResults.</param>
        /// 
        /// <returns>Returns a  GetQueryResultsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual GetQueryResultsResponse EndGetQueryResults(IAsyncResult asyncResult)
        {
            return EndInvoke<GetQueryResultsResponse>(asyncResult);
        }

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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

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
        public virtual ListTagsLogGroupResponse ListTagsLogGroup(ListTagsLogGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsLogGroupResponseUnmarshaller.Instance;

            return Invoke<ListTagsLogGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsLogGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsLogGroup operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsLogGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListTagsLogGroup">REST API Reference for ListTagsLogGroup Operation</seealso>
        [Obsolete("Please use the generic tagging API ListTagsForResource")]
        public virtual IAsyncResult BeginListTagsLogGroup(ListTagsLogGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsLogGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsLogGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsLogGroup.</param>
        /// 
        /// <returns>Returns a  ListTagsLogGroupResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListTagsLogGroup">REST API Reference for ListTagsLogGroup Operation</seealso>
        [Obsolete("Please use the generic tagging API ListTagsForResource")]
        public virtual ListTagsLogGroupResponse EndListTagsLogGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsLogGroupResponse>(asyncResult);
        }

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
        public virtual PutDataProtectionPolicyResponse PutDataProtectionPolicy(PutDataProtectionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDataProtectionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataProtectionPolicyResponseUnmarshaller.Instance;

            return Invoke<PutDataProtectionPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDataProtectionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDataProtectionPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDataProtectionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDataProtectionPolicy">REST API Reference for PutDataProtectionPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutDataProtectionPolicy(PutDataProtectionPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDataProtectionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDataProtectionPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDataProtectionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDataProtectionPolicy.</param>
        /// 
        /// <returns>Returns a  PutDataProtectionPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDataProtectionPolicy">REST API Reference for PutDataProtectionPolicy Operation</seealso>
        public virtual PutDataProtectionPolicyResponse EndPutDataProtectionPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDataProtectionPolicyResponse>(asyncResult);
        }

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
        public virtual PutDestinationResponse PutDestination(PutDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDestinationResponseUnmarshaller.Instance;

            return Invoke<PutDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDestination operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestination">REST API Reference for PutDestination Operation</seealso>
        public virtual IAsyncResult BeginPutDestination(PutDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDestination.</param>
        /// 
        /// <returns>Returns a  PutDestinationResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestination">REST API Reference for PutDestination Operation</seealso>
        public virtual PutDestinationResponse EndPutDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDestinationResponse>(asyncResult);
        }

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
        public virtual PutDestinationPolicyResponse PutDestinationPolicy(PutDestinationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDestinationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDestinationPolicyResponseUnmarshaller.Instance;

            return Invoke<PutDestinationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDestinationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDestinationPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDestinationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestinationPolicy">REST API Reference for PutDestinationPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutDestinationPolicy(PutDestinationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDestinationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDestinationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDestinationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDestinationPolicy.</param>
        /// 
        /// <returns>Returns a  PutDestinationPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestinationPolicy">REST API Reference for PutDestinationPolicy Operation</seealso>
        public virtual PutDestinationPolicyResponse EndPutDestinationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDestinationPolicyResponse>(asyncResult);
        }

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
        public virtual PutLogEventsResponse PutLogEvents(PutLogEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLogEventsResponseUnmarshaller.Instance;

            return Invoke<PutLogEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutLogEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutLogEvents operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutLogEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutLogEvents">REST API Reference for PutLogEvents Operation</seealso>
        public virtual IAsyncResult BeginPutLogEvents(PutLogEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLogEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutLogEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutLogEvents.</param>
        /// 
        /// <returns>Returns a  PutLogEventsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutLogEvents">REST API Reference for PutLogEvents Operation</seealso>
        public virtual PutLogEventsResponse EndPutLogEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<PutLogEventsResponse>(asyncResult);
        }

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
        public virtual PutMetricFilterResponse PutMetricFilter(PutMetricFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetricFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricFilterResponseUnmarshaller.Instance;

            return Invoke<PutMetricFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutMetricFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutMetricFilter operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutMetricFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutMetricFilter">REST API Reference for PutMetricFilter Operation</seealso>
        public virtual IAsyncResult BeginPutMetricFilter(PutMetricFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetricFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutMetricFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutMetricFilter.</param>
        /// 
        /// <returns>Returns a  PutMetricFilterResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutMetricFilter">REST API Reference for PutMetricFilter Operation</seealso>
        public virtual PutMetricFilterResponse EndPutMetricFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<PutMetricFilterResponse>(asyncResult);
        }

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
        public virtual PutQueryDefinitionResponse PutQueryDefinition(PutQueryDefinitionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutQueryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutQueryDefinitionResponseUnmarshaller.Instance;

            return Invoke<PutQueryDefinitionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutQueryDefinition operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutQueryDefinition operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutQueryDefinition
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutQueryDefinition">REST API Reference for PutQueryDefinition Operation</seealso>
        public virtual IAsyncResult BeginPutQueryDefinition(PutQueryDefinitionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutQueryDefinitionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutQueryDefinitionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutQueryDefinition operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutQueryDefinition.</param>
        /// 
        /// <returns>Returns a  PutQueryDefinitionResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutQueryDefinition">REST API Reference for PutQueryDefinition Operation</seealso>
        public virtual PutQueryDefinitionResponse EndPutQueryDefinition(IAsyncResult asyncResult)
        {
            return EndInvoke<PutQueryDefinitionResponse>(asyncResult);
        }

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
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

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
        public virtual PutRetentionPolicyResponse PutRetentionPolicy(PutRetentionPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionPolicyResponseUnmarshaller.Instance;

            return Invoke<PutRetentionPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutRetentionPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutRetentionPolicy">REST API Reference for PutRetentionPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutRetentionPolicy(PutRetentionPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutRetentionPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutRetentionPolicy.</param>
        /// 
        /// <returns>Returns a  PutRetentionPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutRetentionPolicy">REST API Reference for PutRetentionPolicy Operation</seealso>
        public virtual PutRetentionPolicyResponse EndPutRetentionPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutRetentionPolicyResponse>(asyncResult);
        }

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
        public virtual PutSubscriptionFilterResponse PutSubscriptionFilter(PutSubscriptionFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSubscriptionFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSubscriptionFilterResponseUnmarshaller.Instance;

            return Invoke<PutSubscriptionFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutSubscriptionFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSubscriptionFilter operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutSubscriptionFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutSubscriptionFilter">REST API Reference for PutSubscriptionFilter Operation</seealso>
        public virtual IAsyncResult BeginPutSubscriptionFilter(PutSubscriptionFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSubscriptionFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSubscriptionFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutSubscriptionFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutSubscriptionFilter.</param>
        /// 
        /// <returns>Returns a  PutSubscriptionFilterResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutSubscriptionFilter">REST API Reference for PutSubscriptionFilter Operation</seealso>
        public virtual PutSubscriptionFilterResponse EndPutSubscriptionFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<PutSubscriptionFilterResponse>(asyncResult);
        }

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
        public virtual StartQueryResponse StartQuery(StartQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryResponseUnmarshaller.Instance;

            return Invoke<StartQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartQuery operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StartQuery">REST API Reference for StartQuery Operation</seealso>
        public virtual IAsyncResult BeginStartQuery(StartQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartQuery.</param>
        /// 
        /// <returns>Returns a  StartQueryResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StartQuery">REST API Reference for StartQuery Operation</seealso>
        public virtual StartQueryResponse EndStartQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<StartQueryResponse>(asyncResult);
        }

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
        public virtual StopQueryResponse StopQuery(StopQueryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryResponseUnmarshaller.Instance;

            return Invoke<StopQueryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopQuery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopQuery operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopQuery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StopQuery">REST API Reference for StopQuery Operation</seealso>
        public virtual IAsyncResult BeginStopQuery(StopQueryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StopQuery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopQuery.</param>
        /// 
        /// <returns>Returns a  StopQueryResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StopQuery">REST API Reference for StopQuery Operation</seealso>
        public virtual StopQueryResponse EndStopQuery(IAsyncResult asyncResult)
        {
            return EndInvoke<StopQueryResponse>(asyncResult);
        }

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
        public virtual TagLogGroupResponse TagLogGroup(TagLogGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagLogGroupResponseUnmarshaller.Instance;

            return Invoke<TagLogGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagLogGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagLogGroup operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagLogGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TagLogGroup">REST API Reference for TagLogGroup Operation</seealso>
        [Obsolete("Please use the generic tagging API TagResource")]
        public virtual IAsyncResult BeginTagLogGroup(TagLogGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagLogGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagLogGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagLogGroup.</param>
        /// 
        /// <returns>Returns a  TagLogGroupResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TagLogGroup">REST API Reference for TagLogGroup Operation</seealso>
        [Obsolete("Please use the generic tagging API TagResource")]
        public virtual TagLogGroupResponse EndTagLogGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<TagLogGroupResponse>(asyncResult);
        }

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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

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
        public virtual TestMetricFilterResponse TestMetricFilter(TestMetricFilterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestMetricFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestMetricFilterResponseUnmarshaller.Instance;

            return Invoke<TestMetricFilterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TestMetricFilter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TestMetricFilter operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTestMetricFilter
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TestMetricFilter">REST API Reference for TestMetricFilter Operation</seealso>
        public virtual IAsyncResult BeginTestMetricFilter(TestMetricFilterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestMetricFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestMetricFilterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TestMetricFilter operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTestMetricFilter.</param>
        /// 
        /// <returns>Returns a  TestMetricFilterResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TestMetricFilter">REST API Reference for TestMetricFilter Operation</seealso>
        public virtual TestMetricFilterResponse EndTestMetricFilter(IAsyncResult asyncResult)
        {
            return EndInvoke<TestMetricFilterResponse>(asyncResult);
        }

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
        public virtual UntagLogGroupResponse UntagLogGroup(UntagLogGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagLogGroupResponseUnmarshaller.Instance;

            return Invoke<UntagLogGroupResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagLogGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagLogGroup operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagLogGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagLogGroup">REST API Reference for UntagLogGroup Operation</seealso>
        [Obsolete("Please use the generic tagging API UntagResource")]
        public virtual IAsyncResult BeginUntagLogGroup(UntagLogGroupRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagLogGroupResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagLogGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagLogGroup.</param>
        /// 
        /// <returns>Returns a  UntagLogGroupResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagLogGroup">REST API Reference for UntagLogGroup Operation</seealso>
        [Obsolete("Please use the generic tagging API UntagResource")]
        public virtual UntagLogGroupResponse EndUntagLogGroup(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagLogGroupResponse>(asyncResult);
        }

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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
    }
}