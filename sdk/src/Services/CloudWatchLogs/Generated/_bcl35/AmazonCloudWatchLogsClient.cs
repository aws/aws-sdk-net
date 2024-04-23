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
    /// <para>Implementation for accessing CloudWatchLogs</para>
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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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
        /// Specify the <c>logGroupName</c> parameter to cause all log events stored in the log
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
        /// CloudWatch Logs supports only symmetric KMS keys. Do not use an associate an asymmetric
        /// KMS key with your log group or query results. For more information, see <a href="https://docs.aws.amazon.com/kms/latest/developerguide/symmetric-asymmetric.html">Using
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
        /// bucket, or a delivery stream in Firehose.
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
        /// You can't update an existing delivery. You can only create and delete deliveries.
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
        public virtual CreateDeliveryResponse CreateDelivery(CreateDeliveryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeliveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeliveryResponseUnmarshaller.Instance;

            return Invoke<CreateDeliveryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDelivery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDelivery operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDelivery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateDelivery">REST API Reference for CreateDelivery Operation</seealso>
        public virtual IAsyncResult BeginCreateDelivery(CreateDeliveryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeliveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeliveryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDelivery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDelivery.</param>
        /// 
        /// <returns>Returns a  CreateDeliveryResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateDelivery">REST API Reference for CreateDelivery Operation</seealso>
        public virtual CreateDeliveryResponse EndCreateDelivery(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeliveryResponse>(asyncResult);
        }

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
        public virtual CreateLogAnomalyDetectorResponse CreateLogAnomalyDetector(CreateLogAnomalyDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<CreateLogAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLogAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLogAnomalyDetector operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLogAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogAnomalyDetector">REST API Reference for CreateLogAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginCreateLogAnomalyDetector(CreateLogAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLogAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLogAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  CreateLogAnomalyDetectorResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogAnomalyDetector">REST API Reference for CreateLogAnomalyDetector Operation</seealso>
        public virtual CreateLogAnomalyDetectorResponse EndCreateLogAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLogAnomalyDetectorResponse>(asyncResult);
        }

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
        
        #region  DeleteAccountPolicy

        /// <summary>
        /// Deletes a CloudWatch Logs account policy. This stops the policy from applying to all
        /// log groups or a subset of log groups in the account. Log-group level policies will
        /// still be in effect.
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
        ///  </li> </ul>
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
        public virtual DeleteAccountPolicyResponse DeleteAccountPolicy(DeleteAccountPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAccountPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAccountPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteAccountPolicy">REST API Reference for DeleteAccountPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteAccountPolicy(DeleteAccountPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAccountPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAccountPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAccountPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteAccountPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteAccountPolicy">REST API Reference for DeleteAccountPolicy Operation</seealso>
        public virtual DeleteAccountPolicyResponse EndDeleteAccountPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAccountPolicyResponse>(asyncResult);
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
        
        #region  DeleteDelivery

        /// <summary>
        /// Deletes s <i>delivery</i>. A delivery is a connection between a logical <i>delivery
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
        public virtual DeleteDeliveryResponse DeleteDelivery(DeleteDeliveryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliveryResponseUnmarshaller.Instance;

            return Invoke<DeleteDeliveryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDelivery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDelivery operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDelivery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDelivery">REST API Reference for DeleteDelivery Operation</seealso>
        public virtual IAsyncResult BeginDeleteDelivery(DeleteDeliveryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliveryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDelivery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDelivery.</param>
        /// 
        /// <returns>Returns a  DeleteDeliveryResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDelivery">REST API Reference for DeleteDelivery Operation</seealso>
        public virtual DeleteDeliveryResponse EndDeleteDelivery(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeliveryResponse>(asyncResult);
        }

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
        public virtual DeleteDeliveryDestinationResponse DeleteDeliveryDestination(DeleteDeliveryDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliveryDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliveryDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteDeliveryDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeliveryDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryDestination operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeliveryDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliveryDestination">REST API Reference for DeleteDeliveryDestination Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeliveryDestination(DeleteDeliveryDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliveryDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliveryDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeliveryDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeliveryDestination.</param>
        /// 
        /// <returns>Returns a  DeleteDeliveryDestinationResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliveryDestination">REST API Reference for DeleteDeliveryDestination Operation</seealso>
        public virtual DeleteDeliveryDestinationResponse EndDeleteDeliveryDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeliveryDestinationResponse>(asyncResult);
        }

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
        public virtual DeleteDeliveryDestinationPolicyResponse DeleteDeliveryDestinationPolicy(DeleteDeliveryDestinationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliveryDestinationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliveryDestinationPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteDeliveryDestinationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeliveryDestinationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliveryDestinationPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeliveryDestinationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliveryDestinationPolicy">REST API Reference for DeleteDeliveryDestinationPolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeliveryDestinationPolicy(DeleteDeliveryDestinationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliveryDestinationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliveryDestinationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeliveryDestinationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeliveryDestinationPolicy.</param>
        /// 
        /// <returns>Returns a  DeleteDeliveryDestinationPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliveryDestinationPolicy">REST API Reference for DeleteDeliveryDestinationPolicy Operation</seealso>
        public virtual DeleteDeliveryDestinationPolicyResponse EndDeleteDeliveryDestinationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeliveryDestinationPolicyResponse>(asyncResult);
        }

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
        public virtual DeleteDeliverySourceResponse DeleteDeliverySource(DeleteDeliverySourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliverySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliverySourceResponseUnmarshaller.Instance;

            return Invoke<DeleteDeliverySourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDeliverySource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDeliverySource operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDeliverySource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliverySource">REST API Reference for DeleteDeliverySource Operation</seealso>
        public virtual IAsyncResult BeginDeleteDeliverySource(DeleteDeliverySourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeliverySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeliverySourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDeliverySource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDeliverySource.</param>
        /// 
        /// <returns>Returns a  DeleteDeliverySourceResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDeliverySource">REST API Reference for DeleteDeliverySource Operation</seealso>
        public virtual DeleteDeliverySourceResponse EndDeleteDeliverySource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeliverySourceResponse>(asyncResult);
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
        public virtual DeleteLogAnomalyDetectorResponse DeleteLogAnomalyDetector(DeleteLogAnomalyDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<DeleteLogAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLogAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogAnomalyDetector operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLogAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogAnomalyDetector">REST API Reference for DeleteLogAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginDeleteLogAnomalyDetector(DeleteLogAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLogAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLogAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  DeleteLogAnomalyDetectorResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogAnomalyDetector">REST API Reference for DeleteLogAnomalyDetector Operation</seealso>
        public virtual DeleteLogAnomalyDetectorResponse EndDeleteLogAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLogAnomalyDetectorResponse>(asyncResult);
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
        
        #region  DescribeAccountPolicies

        /// <summary>
        /// Returns a list of all CloudWatch Logs account policies in the account.
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
        public virtual DescribeAccountPoliciesResponse DescribeAccountPolicies(DescribeAccountPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountPolicies operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeAccountPolicies">REST API Reference for DescribeAccountPolicies Operation</seealso>
        public virtual IAsyncResult BeginDescribeAccountPolicies(DescribeAccountPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountPolicies.</param>
        /// 
        /// <returns>Returns a  DescribeAccountPoliciesResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeAccountPolicies">REST API Reference for DescribeAccountPolicies Operation</seealso>
        public virtual DescribeAccountPoliciesResponse EndDescribeAccountPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeAccountPoliciesResponse>(asyncResult);
        }

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
        /// logs delivery destination. The destination can be CloudWatch Logs, Amazon S3, or Firehose.
        /// Only some Amazon Web Services services support being configured as a delivery source.
        /// These services are listed in <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/logs/AWS-logs-and-resource-policy.html">Enable
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
        public virtual DescribeDeliveriesResponse DescribeDeliveries(DescribeDeliveriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveriesResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliveriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveries operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveries operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeliveries
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliveries">REST API Reference for DescribeDeliveries Operation</seealso>
        public virtual IAsyncResult BeginDescribeDeliveries(DescribeDeliveriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeliveries operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeliveries.</param>
        /// 
        /// <returns>Returns a  DescribeDeliveriesResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliveries">REST API Reference for DescribeDeliveries Operation</seealso>
        public virtual DescribeDeliveriesResponse EndDescribeDeliveries(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeliveriesResponse>(asyncResult);
        }

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
        public virtual DescribeDeliveryDestinationsResponse DescribeDeliveryDestinations(DescribeDeliveryDestinationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveryDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveryDestinationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliveryDestinationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliveryDestinations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliveryDestinations operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeliveryDestinations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliveryDestinations">REST API Reference for DescribeDeliveryDestinations Operation</seealso>
        public virtual IAsyncResult BeginDescribeDeliveryDestinations(DescribeDeliveryDestinationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliveryDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliveryDestinationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeliveryDestinations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeliveryDestinations.</param>
        /// 
        /// <returns>Returns a  DescribeDeliveryDestinationsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliveryDestinations">REST API Reference for DescribeDeliveryDestinations Operation</seealso>
        public virtual DescribeDeliveryDestinationsResponse EndDescribeDeliveryDestinations(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeliveryDestinationsResponse>(asyncResult);
        }

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
        public virtual DescribeDeliverySourcesResponse DescribeDeliverySources(DescribeDeliverySourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliverySourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliverySourcesResponseUnmarshaller.Instance;

            return Invoke<DescribeDeliverySourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDeliverySources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDeliverySources operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDeliverySources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliverySources">REST API Reference for DescribeDeliverySources Operation</seealso>
        public virtual IAsyncResult BeginDescribeDeliverySources(DescribeDeliverySourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDeliverySourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDeliverySourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDeliverySources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDeliverySources.</param>
        /// 
        /// <returns>Returns a  DescribeDeliverySourcesResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDeliverySources">REST API Reference for DescribeDeliverySources Operation</seealso>
        public virtual DescribeDeliverySourcesResponse EndDescribeDeliverySources(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeDeliverySourcesResponse>(asyncResult);
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
        /// CloudWatch Logs doesn’t support IAM policies that control access to the <c>DescribeLogGroups</c>
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
        /// CloudWatch Logs doesn’t support IAM policies that control access to the <c>DescribeLogGroups</c>
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
        /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
        /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
        /// include both. 
        /// </para>
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
        /// By default, this operation returns as many log events as can fit in 1 MB (up to 10,000
        /// log events) or all the events found within the specified time range. If the results
        /// include a token, that means there are more log events available. You can get additional
        /// results by specifying the token in a subsequent call. This operation can return empty
        /// results while there are more log events available through the token.
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
        public virtual GetDeliveryResponse GetDelivery(GetDeliveryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliveryResponseUnmarshaller.Instance;

            return Invoke<GetDeliveryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDelivery operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDelivery operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDelivery
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDelivery">REST API Reference for GetDelivery Operation</seealso>
        public virtual IAsyncResult BeginGetDelivery(GetDeliveryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliveryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliveryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDelivery operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDelivery.</param>
        /// 
        /// <returns>Returns a  GetDeliveryResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDelivery">REST API Reference for GetDelivery Operation</seealso>
        public virtual GetDeliveryResponse EndGetDelivery(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeliveryResponse>(asyncResult);
        }

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
        public virtual GetDeliveryDestinationResponse GetDeliveryDestination(GetDeliveryDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliveryDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliveryDestinationResponseUnmarshaller.Instance;

            return Invoke<GetDeliveryDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliveryDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliveryDestination operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeliveryDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliveryDestination">REST API Reference for GetDeliveryDestination Operation</seealso>
        public virtual IAsyncResult BeginGetDeliveryDestination(GetDeliveryDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliveryDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliveryDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeliveryDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeliveryDestination.</param>
        /// 
        /// <returns>Returns a  GetDeliveryDestinationResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliveryDestination">REST API Reference for GetDeliveryDestination Operation</seealso>
        public virtual GetDeliveryDestinationResponse EndGetDeliveryDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeliveryDestinationResponse>(asyncResult);
        }

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
        public virtual GetDeliveryDestinationPolicyResponse GetDeliveryDestinationPolicy(GetDeliveryDestinationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliveryDestinationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliveryDestinationPolicyResponseUnmarshaller.Instance;

            return Invoke<GetDeliveryDestinationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliveryDestinationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliveryDestinationPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeliveryDestinationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliveryDestinationPolicy">REST API Reference for GetDeliveryDestinationPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetDeliveryDestinationPolicy(GetDeliveryDestinationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliveryDestinationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliveryDestinationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeliveryDestinationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeliveryDestinationPolicy.</param>
        /// 
        /// <returns>Returns a  GetDeliveryDestinationPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliveryDestinationPolicy">REST API Reference for GetDeliveryDestinationPolicy Operation</seealso>
        public virtual GetDeliveryDestinationPolicyResponse EndGetDeliveryDestinationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeliveryDestinationPolicyResponse>(asyncResult);
        }

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
        public virtual GetDeliverySourceResponse GetDeliverySource(GetDeliverySourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliverySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverySourceResponseUnmarshaller.Instance;

            return Invoke<GetDeliverySourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDeliverySource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDeliverySource operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDeliverySource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliverySource">REST API Reference for GetDeliverySource Operation</seealso>
        public virtual IAsyncResult BeginGetDeliverySource(GetDeliverySourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDeliverySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDeliverySourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDeliverySource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDeliverySource.</param>
        /// 
        /// <returns>Returns a  GetDeliverySourceResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetDeliverySource">REST API Reference for GetDeliverySource Operation</seealso>
        public virtual GetDeliverySourceResponse EndGetDeliverySource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDeliverySourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLogAnomalyDetector

        /// <summary>
        /// Retrieves information about the log anomaly detector that you specify.
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
        public virtual GetLogAnomalyDetectorResponse GetLogAnomalyDetector(GetLogAnomalyDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<GetLogAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLogAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLogAnomalyDetector operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLogAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogAnomalyDetector">REST API Reference for GetLogAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginGetLogAnomalyDetector(GetLogAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLogAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLogAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  GetLogAnomalyDetectorResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogAnomalyDetector">REST API Reference for GetLogAnomalyDetector Operation</seealso>
        public virtual GetLogAnomalyDetectorResponse EndGetLogAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLogAnomalyDetectorResponse>(asyncResult);
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
        ///  
        /// <para>
        /// You can specify the log group to search by using either <c>logGroupIdentifier</c>
        /// or <c>logGroupName</c>. You must include one of these two parameters, but you can't
        /// include both. 
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
        public virtual ListAnomaliesResponse ListAnomalies(ListAnomaliesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnomaliesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomaliesResponseUnmarshaller.Instance;

            return Invoke<ListAnomaliesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAnomalies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAnomalies operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAnomalies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListAnomalies">REST API Reference for ListAnomalies Operation</seealso>
        public virtual IAsyncResult BeginListAnomalies(ListAnomaliesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAnomaliesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAnomaliesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAnomalies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAnomalies.</param>
        /// 
        /// <returns>Returns a  ListAnomaliesResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListAnomalies">REST API Reference for ListAnomalies Operation</seealso>
        public virtual ListAnomaliesResponse EndListAnomalies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAnomaliesResponse>(asyncResult);
        }

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
        public virtual ListLogAnomalyDetectorsResponse ListLogAnomalyDetectors(ListLogAnomalyDetectorsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLogAnomalyDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogAnomalyDetectorsResponseUnmarshaller.Instance;

            return Invoke<ListLogAnomalyDetectorsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListLogAnomalyDetectors operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListLogAnomalyDetectors operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListLogAnomalyDetectors
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListLogAnomalyDetectors">REST API Reference for ListLogAnomalyDetectors Operation</seealso>
        public virtual IAsyncResult BeginListLogAnomalyDetectors(ListLogAnomalyDetectorsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListLogAnomalyDetectorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLogAnomalyDetectorsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListLogAnomalyDetectors operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListLogAnomalyDetectors.</param>
        /// 
        /// <returns>Returns a  ListLogAnomalyDetectorsResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListLogAnomalyDetectors">REST API Reference for ListLogAnomalyDetectors Operation</seealso>
        public virtual ListLogAnomalyDetectorsResponse EndListLogAnomalyDetectors(IAsyncResult asyncResult)
        {
            return EndInvoke<ListLogAnomalyDetectorsResponse>(asyncResult);
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
        
        #region  PutAccountPolicy

        /// <summary>
        /// Creates an account-level data protection policy or subscription filter policy that
        /// applies to all log groups or a subset of log groups in the account.
        /// 
        ///  
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
        /// Each account can have one account-level subscription filter policy. If you are updating
        /// an existing filter, you must specify the correct name in <c>PolicyName</c>. To perform
        /// a <c>PutAccountPolicy</c> subscription filter operation for any destination except
        /// a Lambda function, you must also have the <c>iam:PassRole</c> permission.
        /// </para>
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
        public virtual PutAccountPolicyResponse PutAccountPolicy(PutAccountPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountPolicyResponseUnmarshaller.Instance;

            return Invoke<PutAccountPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutAccountPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutAccountPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutAccountPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutAccountPolicy">REST API Reference for PutAccountPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutAccountPolicy(PutAccountPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutAccountPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAccountPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutAccountPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutAccountPolicy.</param>
        /// 
        /// <returns>Returns a  PutAccountPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutAccountPolicy">REST API Reference for PutAccountPolicy Operation</seealso>
        public virtual PutAccountPolicyResponse EndPutAccountPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutAccountPolicyResponse>(asyncResult);
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
        
        #region  PutDeliveryDestination

        /// <summary>
        /// Creates or updates a logical <i>delivery destination</i>. A delivery destination is
        /// an Amazon Web Services resource that represents an Amazon Web Services service that
        /// logs can be sent to. CloudWatch Logs, Amazon S3, and Firehose are supported as logs
        /// delivery destinations.
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
        /// Use <c>PutDeliveryDestination</c> to create a <i>delivery destination</i>, which is
        /// a logical object that represents the actual delivery destination. 
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
        public virtual PutDeliveryDestinationResponse PutDeliveryDestination(PutDeliveryDestinationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliveryDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliveryDestinationResponseUnmarshaller.Instance;

            return Invoke<PutDeliveryDestinationResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliveryDestination operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryDestination operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDeliveryDestination
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliveryDestination">REST API Reference for PutDeliveryDestination Operation</seealso>
        public virtual IAsyncResult BeginPutDeliveryDestination(PutDeliveryDestinationRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliveryDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliveryDestinationResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDeliveryDestination operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDeliveryDestination.</param>
        /// 
        /// <returns>Returns a  PutDeliveryDestinationResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliveryDestination">REST API Reference for PutDeliveryDestination Operation</seealso>
        public virtual PutDeliveryDestinationResponse EndPutDeliveryDestination(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDeliveryDestinationResponse>(asyncResult);
        }

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
        public virtual PutDeliveryDestinationPolicyResponse PutDeliveryDestinationPolicy(PutDeliveryDestinationPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliveryDestinationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliveryDestinationPolicyResponseUnmarshaller.Instance;

            return Invoke<PutDeliveryDestinationPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliveryDestinationPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliveryDestinationPolicy operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDeliveryDestinationPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliveryDestinationPolicy">REST API Reference for PutDeliveryDestinationPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutDeliveryDestinationPolicy(PutDeliveryDestinationPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliveryDestinationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliveryDestinationPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDeliveryDestinationPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDeliveryDestinationPolicy.</param>
        /// 
        /// <returns>Returns a  PutDeliveryDestinationPolicyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliveryDestinationPolicy">REST API Reference for PutDeliveryDestinationPolicy Operation</seealso>
        public virtual PutDeliveryDestinationPolicyResponse EndPutDeliveryDestinationPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDeliveryDestinationPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutDeliverySource

        /// <summary>
        /// Creates or updates a logical <i>delivery source</i>. A delivery source represents
        /// an Amazon Web Services resource that sends logs to an logs delivery destination. The
        /// destination can be CloudWatch Logs, Amazon S3, or Firehose.
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
        public virtual PutDeliverySourceResponse PutDeliverySource(PutDeliverySourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliverySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliverySourceResponseUnmarshaller.Instance;

            return Invoke<PutDeliverySourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutDeliverySource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutDeliverySource operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutDeliverySource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliverySource">REST API Reference for PutDeliverySource Operation</seealso>
        public virtual IAsyncResult BeginPutDeliverySource(PutDeliverySourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDeliverySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDeliverySourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutDeliverySource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutDeliverySource.</param>
        /// 
        /// <returns>Returns a  PutDeliverySourceResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDeliverySource">REST API Reference for PutDeliverySource Operation</seealso>
        public virtual PutDeliverySourceResponse EndPutDeliverySource(IAsyncResult asyncResult)
        {
            return EndInvoke<PutDeliverySourceResponse>(asyncResult);
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
        /// after <c>Jan 1, 1970 00:00:00 UTC</c>. (In Amazon Web Services Tools for PowerShell
        /// and the Amazon Web Services SDK for .NET, the timestamp is specified in .NET format:
        /// <c>yyyy-mm-ddThh:mm:ss</c>. For example, <c>2017-09-15T13:45:30</c>.) 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A batch of log events in a single request cannot span more than 24 hours. Otherwise,
        /// the operation fails.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Each log event can be no larger than 256 KB.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The maximum number of log events in a batch is 10,000.
        /// </para>
        ///  </li> <li> <important> 
        /// <para>
        /// The quota of five requests per second per log stream has been removed. Instead, <c>PutLogEvents</c>
        /// actions are throttled based on a per-second per-account quota. You can request an
        /// increase to the per-second throttling quota by using the Service Quotas service.
        /// </para>
        ///  </important> </li> </ul> 
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
        /// To perform a <c>PutSubscriptionFilter</c> operation for any destination except a Lambda
        /// function, you must also have the <c>iam:PassRole</c> permission.
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
        /// A <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_SessionStreamingException.html">SessionStreamingException</a>
        /// object is returned if an unknown error occurs on the server side.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_SessionTimeoutException.html">SessionTimeoutException</a>
        /// object is returned when the session times out, after it has been kept open for three
        /// hours.
        /// </para>
        ///  </li> </ul> <important> 
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
        public virtual StartLiveTailResponse StartLiveTail(StartLiveTailRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLiveTailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLiveTailResponseUnmarshaller.Instance;

            return Invoke<StartLiveTailResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartLiveTail operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartLiveTail operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartLiveTail
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StartLiveTail">REST API Reference for StartLiveTail Operation</seealso>
        public virtual IAsyncResult BeginStartLiveTail(StartLiveTailRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartLiveTailRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartLiveTailResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartLiveTail operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartLiveTail.</param>
        /// 
        /// <returns>Returns a  StartLiveTailResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StartLiveTail">REST API Reference for StartLiveTail Operation</seealso>
        public virtual StartLiveTailResponse EndStartLiveTail(IAsyncResult asyncResult)
        {
            return EndInvoke<StartLiveTailResponse>(asyncResult);
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
        /// After you run a query using <c>StartQuery</c>, the query results are stored by CloudWatch
        /// Logs. You can use <a href="https://docs.aws.amazon.com/AmazonCloudWatchLogs/latest/APIReference/API_GetQueryResults.html">GetQueryResults</a>
        /// to retrieve the results of a query, using the <c>queryId</c> that <c>StartQuery</c>
        /// returns. 
        /// </para>
        ///  
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
        /// tags to log groups using the <c>aws:Resource/<i>key-name</i> </c> or <c>aws:TagKeys</c>
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
        
        #region  UpdateAnomaly

        /// <summary>
        /// Use this operation to <i>suppress</i> anomaly detection for a specified anomaly or
        /// pattern. If you suppress an anomaly, CloudWatch Logs won’t report new occurrences
        /// of that anomaly and won't update that anomaly with new data. If you suppress a pattern,
        /// CloudWatch Logs won’t report any anomalies related to that pattern.
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
        public virtual UpdateAnomalyResponse UpdateAnomaly(UpdateAnomalyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnomalyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnomalyResponseUnmarshaller.Instance;

            return Invoke<UpdateAnomalyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAnomaly operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAnomaly operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAnomaly
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UpdateAnomaly">REST API Reference for UpdateAnomaly Operation</seealso>
        public virtual IAsyncResult BeginUpdateAnomaly(UpdateAnomalyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAnomalyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAnomalyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAnomaly operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAnomaly.</param>
        /// 
        /// <returns>Returns a  UpdateAnomalyResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UpdateAnomaly">REST API Reference for UpdateAnomaly Operation</seealso>
        public virtual UpdateAnomalyResponse EndUpdateAnomaly(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAnomalyResponse>(asyncResult);
        }

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
        public virtual UpdateLogAnomalyDetectorResponse UpdateLogAnomalyDetector(UpdateLogAnomalyDetectorRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLogAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLogAnomalyDetectorResponseUnmarshaller.Instance;

            return Invoke<UpdateLogAnomalyDetectorResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLogAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLogAnomalyDetector operation on AmazonCloudWatchLogsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLogAnomalyDetector
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UpdateLogAnomalyDetector">REST API Reference for UpdateLogAnomalyDetector Operation</seealso>
        public virtual IAsyncResult BeginUpdateLogAnomalyDetector(UpdateLogAnomalyDetectorRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLogAnomalyDetectorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLogAnomalyDetectorResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLogAnomalyDetector operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLogAnomalyDetector.</param>
        /// 
        /// <returns>Returns a  UpdateLogAnomalyDetectorResult from CloudWatchLogs.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UpdateLogAnomalyDetector">REST API Reference for UpdateLogAnomalyDetector Operation</seealso>
        public virtual UpdateLogAnomalyDetectorResponse EndUpdateLogAnomalyDetector(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLogAnomalyDetectorResponse>(asyncResult);
        }

        #endregion
        
        #region DetermineServiceOperationEndpoint

        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="request">Request for the desired service operation.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public Amazon.Runtime.Endpoints.Endpoint DetermineServiceOperationEndpoint(AmazonWebServiceRequest request)
        {
            var requestContext = new RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonCloudWatchLogsEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}