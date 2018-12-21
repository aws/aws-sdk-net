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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
    public partial class AmazonCloudWatchLogsClient : AmazonServiceClient, IAmazonCloudWatchLogs
    {
        private static IServiceMetadata serviceMetadata = new AmazonCloudWatchLogsMetadata();
        
        #region Constructors

#if CORECLR
    
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

#endif

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

        internal virtual AssociateKmsKeyResponse AssociateKmsKey(AssociateKmsKeyRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the AssociateKmsKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/AssociateKmsKey">REST API Reference for AssociateKmsKey Operation</seealso>
        public virtual Task<AssociateKmsKeyResponse> AssociateKmsKeyAsync(AssociateKmsKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateKmsKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateKmsKeyResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateKmsKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelExportTask

        internal virtual CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelExportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateExportTask

        internal virtual CreateExportTaskResponse CreateExportTask(CreateExportTaskRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateExportTask">REST API Reference for CreateExportTask Operation</seealso>
        public virtual Task<CreateExportTaskResponse> CreateExportTaskAsync(CreateExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLogGroup

        internal virtual CreateLogGroupResponse CreateLogGroup(CreateLogGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateLogGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogGroup">REST API Reference for CreateLogGroup Operation</seealso>
        public virtual Task<CreateLogGroupResponse> CreateLogGroupAsync(CreateLogGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLogGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLogStream

        internal virtual CreateLogStreamResponse CreateLogStream(CreateLogStreamRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateLogStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/CreateLogStream">REST API Reference for CreateLogStream Operation</seealso>
        public virtual Task<CreateLogStreamResponse> CreateLogStreamAsync(CreateLogStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLogStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLogStreamResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLogStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDestination

        internal virtual DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteDestination">REST API Reference for DeleteDestination Operation</seealso>
        public virtual Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLogGroup

        internal virtual DeleteLogGroupResponse DeleteLogGroup(DeleteLogGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogGroup">REST API Reference for DeleteLogGroup Operation</seealso>
        public virtual Task<DeleteLogGroupResponse> DeleteLogGroupAsync(DeleteLogGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLogGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLogStream

        internal virtual DeleteLogStreamResponse DeleteLogStream(DeleteLogStreamRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteLogStream operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteLogStream">REST API Reference for DeleteLogStream Operation</seealso>
        public virtual Task<DeleteLogStreamResponse> DeleteLogStreamAsync(DeleteLogStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLogStreamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLogStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLogStreamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMetricFilter

        internal virtual DeleteMetricFilterResponse DeleteMetricFilter(DeleteMetricFilterRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteMetricFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteMetricFilter">REST API Reference for DeleteMetricFilter Operation</seealso>
        public virtual Task<DeleteMetricFilterResponse> DeleteMetricFilterAsync(DeleteMetricFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMetricFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMetricFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMetricFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRetentionPolicy

        internal virtual DeleteRetentionPolicyResponse DeleteRetentionPolicy(DeleteRetentionPolicyRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteRetentionPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteRetentionPolicy">REST API Reference for DeleteRetentionPolicy Operation</seealso>
        public virtual Task<DeleteRetentionPolicyResponse> DeleteRetentionPolicyAsync(DeleteRetentionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRetentionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRetentionPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubscriptionFilter

        internal virtual DeleteSubscriptionFilterResponse DeleteSubscriptionFilter(DeleteSubscriptionFilterRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubscriptionFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DeleteSubscriptionFilter">REST API Reference for DeleteSubscriptionFilter Operation</seealso>
        public virtual Task<DeleteSubscriptionFilterResponse> DeleteSubscriptionFilterAsync(DeleteSubscriptionFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubscriptionFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubscriptionFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubscriptionFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDestinations

        internal virtual DescribeDestinationsResponse DescribeDestinations(DescribeDestinationsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeDestinations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeDestinations">REST API Reference for DescribeDestinations Operation</seealso>
        public virtual Task<DescribeDestinationsResponse> DescribeDestinationsAsync(DescribeDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDestinationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDestinationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportTasks

        internal virtual DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLogGroups

        internal virtual DescribeLogGroupsResponse DescribeLogGroups()
        {
            return DescribeLogGroups(new DescribeLogGroupsRequest());
        }
        internal virtual DescribeLogGroupsResponse DescribeLogGroups(DescribeLogGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLogGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeLogGroupsResponse>(request, options);
        }


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
        public virtual Task<DescribeLogGroupsResponse> DescribeLogGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLogGroupsAsync(new DescribeLogGroupsRequest(), cancellationToken);
        }


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
        public virtual Task<DescribeLogGroupsResponse> DescribeLogGroupsAsync(DescribeLogGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLogGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLogGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLogStreams

        internal virtual DescribeLogStreamsResponse DescribeLogStreams(DescribeLogStreamsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeLogStreams operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeLogStreams">REST API Reference for DescribeLogStreams Operation</seealso>
        public virtual Task<DescribeLogStreamsResponse> DescribeLogStreamsAsync(DescribeLogStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLogStreamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLogStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLogStreamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMetricFilters

        internal virtual DescribeMetricFiltersResponse DescribeMetricFilters(DescribeMetricFiltersRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeMetricFilters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeMetricFilters">REST API Reference for DescribeMetricFilters Operation</seealso>
        public virtual Task<DescribeMetricFiltersResponse> DescribeMetricFiltersAsync(DescribeMetricFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMetricFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMetricFiltersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMetricFiltersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeQueries

        internal virtual DescribeQueriesResponse DescribeQueries(DescribeQueriesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeQueries operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeQueries">REST API Reference for DescribeQueries Operation</seealso>
        public virtual Task<DescribeQueriesResponse> DescribeQueriesAsync(DescribeQueriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeQueriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeQueriesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeQueriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeResourcePolicies

        internal virtual DescribeResourcePoliciesResponse DescribeResourcePolicies(DescribeResourcePoliciesRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeResourcePolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeResourcePolicies">REST API Reference for DescribeResourcePolicies Operation</seealso>
        public virtual Task<DescribeResourcePoliciesResponse> DescribeResourcePoliciesAsync(DescribeResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeResourcePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeResourcePoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubscriptionFilters

        internal virtual DescribeSubscriptionFiltersResponse DescribeSubscriptionFilters(DescribeSubscriptionFiltersRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubscriptionFilters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DescribeSubscriptionFilters">REST API Reference for DescribeSubscriptionFilters Operation</seealso>
        public virtual Task<DescribeSubscriptionFiltersResponse> DescribeSubscriptionFiltersAsync(DescribeSubscriptionFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubscriptionFiltersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubscriptionFiltersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubscriptionFiltersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateKmsKey

        internal virtual DisassociateKmsKeyResponse DisassociateKmsKey(DisassociateKmsKeyRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DisassociateKmsKey operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/DisassociateKmsKey">REST API Reference for DisassociateKmsKey Operation</seealso>
        public virtual Task<DisassociateKmsKeyResponse> DisassociateKmsKeyAsync(DisassociateKmsKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateKmsKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateKmsKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateKmsKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  FilterLogEvents

        internal virtual FilterLogEventsResponse FilterLogEvents(FilterLogEventsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the FilterLogEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/FilterLogEvents">REST API Reference for FilterLogEvents Operation</seealso>
        public virtual Task<FilterLogEventsResponse> FilterLogEventsAsync(FilterLogEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = FilterLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = FilterLogEventsResponseUnmarshaller.Instance;

            return InvokeAsync<FilterLogEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLogEvents

        internal virtual GetLogEventsResponse GetLogEvents(GetLogEventsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetLogEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogEvents">REST API Reference for GetLogEvents Operation</seealso>
        public virtual Task<GetLogEventsResponse> GetLogEventsAsync(GetLogEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogEventsResponseUnmarshaller.Instance;

            return InvokeAsync<GetLogEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLogGroupFields

        internal virtual GetLogGroupFieldsResponse GetLogGroupFields(GetLogGroupFieldsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetLogGroupFields operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogGroupFields">REST API Reference for GetLogGroupFields Operation</seealso>
        public virtual Task<GetLogGroupFieldsResponse> GetLogGroupFieldsAsync(GetLogGroupFieldsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogGroupFieldsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogGroupFieldsResponseUnmarshaller.Instance;

            return InvokeAsync<GetLogGroupFieldsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLogRecord

        internal virtual GetLogRecordResponse GetLogRecord(GetLogRecordRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetLogRecord operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetLogRecord">REST API Reference for GetLogRecord Operation</seealso>
        public virtual Task<GetLogRecordResponse> GetLogRecordAsync(GetLogRecordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLogRecordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLogRecordResponseUnmarshaller.Instance;

            return InvokeAsync<GetLogRecordResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueryResults

        internal virtual GetQueryResultsResponse GetQueryResults(GetQueryResultsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the GetQueryResults operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/GetQueryResults">REST API Reference for GetQueryResults Operation</seealso>
        public virtual Task<GetQueryResultsResponse> GetQueryResultsAsync(GetQueryResultsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueryResultsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueryResultsResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueryResultsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsLogGroup

        internal virtual ListTagsLogGroupResponse ListTagsLogGroup(ListTagsLogGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsLogGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/ListTagsLogGroup">REST API Reference for ListTagsLogGroup Operation</seealso>
        public virtual Task<ListTagsLogGroupResponse> ListTagsLogGroupAsync(ListTagsLogGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsLogGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsLogGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDestination

        internal virtual PutDestinationResponse PutDestination(PutDestinationRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutDestination operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestination">REST API Reference for PutDestination Operation</seealso>
        public virtual Task<PutDestinationResponse> PutDestinationAsync(PutDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<PutDestinationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutDestinationPolicy

        internal virtual PutDestinationPolicyResponse PutDestinationPolicy(PutDestinationPolicyRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutDestinationPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutDestinationPolicy">REST API Reference for PutDestinationPolicy Operation</seealso>
        public virtual Task<PutDestinationPolicyResponse> PutDestinationPolicyAsync(PutDestinationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutDestinationPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutDestinationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutDestinationPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutLogEvents

        internal virtual PutLogEventsResponse PutLogEvents(PutLogEventsRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutLogEvents operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutLogEvents">REST API Reference for PutLogEvents Operation</seealso>
        public virtual Task<PutLogEventsResponse> PutLogEventsAsync(PutLogEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutLogEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutLogEventsResponseUnmarshaller.Instance;

            return InvokeAsync<PutLogEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutMetricFilter

        internal virtual PutMetricFilterResponse PutMetricFilter(PutMetricFilterRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutMetricFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutMetricFilter">REST API Reference for PutMetricFilter Operation</seealso>
        public virtual Task<PutMetricFilterResponse> PutMetricFilterAsync(PutMetricFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutMetricFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMetricFilterResponseUnmarshaller.Instance;

            return InvokeAsync<PutMetricFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutRetentionPolicy

        internal virtual PutRetentionPolicyResponse PutRetentionPolicy(PutRetentionPolicyRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutRetentionPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutRetentionPolicy">REST API Reference for PutRetentionPolicy Operation</seealso>
        public virtual Task<PutRetentionPolicyResponse> PutRetentionPolicyAsync(PutRetentionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutRetentionPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRetentionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutRetentionPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSubscriptionFilter

        internal virtual PutSubscriptionFilterResponse PutSubscriptionFilter(PutSubscriptionFilterRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the PutSubscriptionFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/PutSubscriptionFilter">REST API Reference for PutSubscriptionFilter Operation</seealso>
        public virtual Task<PutSubscriptionFilterResponse> PutSubscriptionFilterAsync(PutSubscriptionFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSubscriptionFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSubscriptionFilterResponseUnmarshaller.Instance;

            return InvokeAsync<PutSubscriptionFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartQuery

        internal virtual StartQueryResponse StartQuery(StartQueryRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the StartQuery operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StartQuery">REST API Reference for StartQuery Operation</seealso>
        public virtual Task<StartQueryResponse> StartQueryAsync(StartQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartQueryResponseUnmarshaller.Instance;

            return InvokeAsync<StartQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopQuery

        internal virtual StopQueryResponse StopQuery(StopQueryRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the StopQuery operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/StopQuery">REST API Reference for StopQuery Operation</seealso>
        public virtual Task<StopQueryResponse> StopQueryAsync(StopQueryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopQueryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopQueryResponseUnmarshaller.Instance;

            return InvokeAsync<StopQueryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagLogGroup

        internal virtual TagLogGroupResponse TagLogGroup(TagLogGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the TagLogGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TagLogGroup">REST API Reference for TagLogGroup Operation</seealso>
        public virtual Task<TagLogGroupResponse> TagLogGroupAsync(TagLogGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagLogGroupResponseUnmarshaller.Instance;

            return InvokeAsync<TagLogGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TestMetricFilter

        internal virtual TestMetricFilterResponse TestMetricFilter(TestMetricFilterRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the TestMetricFilter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/TestMetricFilter">REST API Reference for TestMetricFilter Operation</seealso>
        public virtual Task<TestMetricFilterResponse> TestMetricFilterAsync(TestMetricFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TestMetricFilterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TestMetricFilterResponseUnmarshaller.Instance;

            return InvokeAsync<TestMetricFilterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagLogGroup

        internal virtual UntagLogGroupResponse UntagLogGroup(UntagLogGroupRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UntagLogGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/logs-2014-03-28/UntagLogGroup">REST API Reference for UntagLogGroup Operation</seealso>
        public virtual Task<UntagLogGroupResponse> UntagLogGroupAsync(UntagLogGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagLogGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagLogGroupResponseUnmarshaller.Instance;

            return InvokeAsync<UntagLogGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}