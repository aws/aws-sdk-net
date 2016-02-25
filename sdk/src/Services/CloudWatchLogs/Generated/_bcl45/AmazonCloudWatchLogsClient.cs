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

using Amazon.CloudWatchLogs.Model;
using Amazon.CloudWatchLogs.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.CloudWatchLogs
{
    /// <summary>
    /// Implementation for accessing CloudWatchLogs
    ///
    /// Amazon CloudWatch Logs API Reference 
    /// <para>
    /// You can use Amazon CloudWatch Logs to monitor, store, and access your log files from
    /// Amazon Elastic Compute Cloud (Amazon EC2) instances, Amazon CloudTrail, or other sources.
    /// You can then retrieve the associated log data from CloudWatch Logs using the Amazon
    /// CloudWatch console, the CloudWatch Logs commands in the AWS CLI, the CloudWatch Logs
    /// API, or the CloudWatch Logs SDK.
    /// </para>
    ///  
    /// <para>
    /// You can use CloudWatch Logs to:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// <b>Monitor Logs from Amazon EC2 Instances in Real-time</b>: You can use CloudWatch
    /// Logs to monitor applications and systems using log data. For example, CloudWatch Logs
    /// can track the number of errors that occur in your application logs and send you a
    /// notification whenever the rate of errors exceeds a threshold you specify. CloudWatch
    /// Logs uses your log data for monitoring; so, no code changes are required. For example,
    /// you can monitor application logs for specific literal terms (such as "NullReferenceException")
    /// or count the number of occurrences of a literal term at a particular position in log
    /// data (such as "404" status codes in an Apache access log). When the term you are searching
    /// for is found, CloudWatch Logs reports the data to a Amazon CloudWatch metric that
    /// you specify.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <b>Monitor Amazon CloudTrail Logged Events</b>: You can create alarms in Amazon CloudWatch
    /// and receive notifications of particular API activity as captured by CloudTrail and
    /// use the notification to perform troubleshooting.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// <b>Archive Log Data</b>: You can use CloudWatch Logs to store your log data in highly
    /// durable storage. You can change the log retention setting so that any log events older
    /// than this setting are automatically deleted. The CloudWatch Logs agent makes it easy
    /// to quickly send both rotated and non-rotated log data off of a host and into the log
    /// service. You can then access the raw log data when you need it.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonCloudWatchLogsClient : AmazonServiceClient, IAmazonCloudWatchLogs
    {
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
        public CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var marshaller = new CancelExportTaskRequestMarshaller();
            var unmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskRequest,CancelExportTaskResponse>(request, marshaller, unmarshaller);
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
        public Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelExportTaskRequestMarshaller();
            var unmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelExportTaskRequest,CancelExportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// can be used to get the status of an export task. You can only have one active (<code>RUNNING</code>
        /// or <code>PENDING</code>) export task at a time, per account. 
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
        public CreateExportTaskResponse CreateExportTask(CreateExportTaskRequest request)
        {
            var marshaller = new CreateExportTaskRequestMarshaller();
            var unmarshaller = CreateExportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateExportTaskRequest,CreateExportTaskResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateExportTaskResponse> CreateExportTaskAsync(CreateExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateExportTaskRequestMarshaller();
            var unmarshaller = CreateExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateExportTaskRequest,CreateExportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateLogGroupResponse CreateLogGroup(CreateLogGroupRequest request)
        {
            var marshaller = new CreateLogGroupRequestMarshaller();
            var unmarshaller = CreateLogGroupResponseUnmarshaller.Instance;

            return Invoke<CreateLogGroupRequest,CreateLogGroupResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateLogGroupResponse> CreateLogGroupAsync(CreateLogGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLogGroupRequestMarshaller();
            var unmarshaller = CreateLogGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLogGroupRequest,CreateLogGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateLogStreamResponse CreateLogStream(CreateLogStreamRequest request)
        {
            var marshaller = new CreateLogStreamRequestMarshaller();
            var unmarshaller = CreateLogStreamResponseUnmarshaller.Instance;

            return Invoke<CreateLogStreamRequest,CreateLogStreamResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateLogStreamResponse> CreateLogStreamAsync(CreateLogStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLogStreamRequestMarshaller();
            var unmarshaller = CreateLogStreamResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLogStreamRequest,CreateLogStreamResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteDestinationResponse DeleteDestination(DeleteDestinationRequest request)
        {
            var marshaller = new DeleteDestinationRequestMarshaller();
            var unmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteDestinationRequest,DeleteDestinationResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteDestinationResponse> DeleteDestinationAsync(DeleteDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDestinationRequestMarshaller();
            var unmarshaller = DeleteDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDestinationRequest,DeleteDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteLogGroupResponse DeleteLogGroup(DeleteLogGroupRequest request)
        {
            var marshaller = new DeleteLogGroupRequestMarshaller();
            var unmarshaller = DeleteLogGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteLogGroupRequest,DeleteLogGroupResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteLogGroupResponse> DeleteLogGroupAsync(DeleteLogGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLogGroupRequestMarshaller();
            var unmarshaller = DeleteLogGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLogGroupRequest,DeleteLogGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteLogStreamResponse DeleteLogStream(DeleteLogStreamRequest request)
        {
            var marshaller = new DeleteLogStreamRequestMarshaller();
            var unmarshaller = DeleteLogStreamResponseUnmarshaller.Instance;

            return Invoke<DeleteLogStreamRequest,DeleteLogStreamResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteLogStreamResponse> DeleteLogStreamAsync(DeleteLogStreamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLogStreamRequestMarshaller();
            var unmarshaller = DeleteLogStreamResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLogStreamRequest,DeleteLogStreamResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteMetricFilterResponse DeleteMetricFilter(DeleteMetricFilterRequest request)
        {
            var marshaller = new DeleteMetricFilterRequestMarshaller();
            var unmarshaller = DeleteMetricFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteMetricFilterRequest,DeleteMetricFilterResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteMetricFilterResponse> DeleteMetricFilterAsync(DeleteMetricFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMetricFilterRequestMarshaller();
            var unmarshaller = DeleteMetricFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMetricFilterRequest,DeleteMetricFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteRetentionPolicyResponse DeleteRetentionPolicy(DeleteRetentionPolicyRequest request)
        {
            var marshaller = new DeleteRetentionPolicyRequestMarshaller();
            var unmarshaller = DeleteRetentionPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteRetentionPolicyRequest,DeleteRetentionPolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteRetentionPolicyResponse> DeleteRetentionPolicyAsync(DeleteRetentionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRetentionPolicyRequestMarshaller();
            var unmarshaller = DeleteRetentionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRetentionPolicyRequest,DeleteRetentionPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteSubscriptionFilterResponse DeleteSubscriptionFilter(DeleteSubscriptionFilterRequest request)
        {
            var marshaller = new DeleteSubscriptionFilterRequestMarshaller();
            var unmarshaller = DeleteSubscriptionFilterResponseUnmarshaller.Instance;

            return Invoke<DeleteSubscriptionFilterRequest,DeleteSubscriptionFilterResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteSubscriptionFilterResponse> DeleteSubscriptionFilterAsync(DeleteSubscriptionFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSubscriptionFilterRequestMarshaller();
            var unmarshaller = DeleteSubscriptionFilterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubscriptionFilterRequest,DeleteSubscriptionFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeDestinationsResponse DescribeDestinations(DescribeDestinationsRequest request)
        {
            var marshaller = new DescribeDestinationsRequestMarshaller();
            var unmarshaller = DescribeDestinationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDestinationsRequest,DescribeDestinationsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeDestinationsResponse> DescribeDestinationsAsync(DescribeDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDestinationsRequestMarshaller();
            var unmarshaller = DescribeDestinationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDestinationsRequest,DescribeDestinationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeLogGroupsResponse DescribeLogGroups()
        {
            return DescribeLogGroups(new DescribeLogGroupsRequest());
        }


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
        public DescribeLogGroupsResponse DescribeLogGroups(DescribeLogGroupsRequest request)
        {
            var marshaller = new DescribeLogGroupsRequestMarshaller();
            var unmarshaller = DescribeLogGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeLogGroupsRequest,DescribeLogGroupsResponse>(request, marshaller, unmarshaller);
        }


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
        /// <param name="cancellationToken">
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
        public Task<DescribeLogGroupsResponse> DescribeLogGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeLogGroupsResponse> DescribeLogGroupsAsync(DescribeLogGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLogGroupsRequestMarshaller();
            var unmarshaller = DescribeLogGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLogGroupsRequest,DescribeLogGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeLogStreamsResponse DescribeLogStreams(DescribeLogStreamsRequest request)
        {
            var marshaller = new DescribeLogStreamsRequestMarshaller();
            var unmarshaller = DescribeLogStreamsResponseUnmarshaller.Instance;

            return Invoke<DescribeLogStreamsRequest,DescribeLogStreamsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeLogStreamsResponse> DescribeLogStreamsAsync(DescribeLogStreamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLogStreamsRequestMarshaller();
            var unmarshaller = DescribeLogStreamsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLogStreamsRequest,DescribeLogStreamsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeMetricFiltersResponse DescribeMetricFilters(DescribeMetricFiltersRequest request)
        {
            var marshaller = new DescribeMetricFiltersRequestMarshaller();
            var unmarshaller = DescribeMetricFiltersResponseUnmarshaller.Instance;

            return Invoke<DescribeMetricFiltersRequest,DescribeMetricFiltersResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeMetricFiltersResponse> DescribeMetricFiltersAsync(DescribeMetricFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMetricFiltersRequestMarshaller();
            var unmarshaller = DescribeMetricFiltersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMetricFiltersRequest,DescribeMetricFiltersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeSubscriptionFiltersResponse DescribeSubscriptionFilters(DescribeSubscriptionFiltersRequest request)
        {
            var marshaller = new DescribeSubscriptionFiltersRequestMarshaller();
            var unmarshaller = DescribeSubscriptionFiltersResponseUnmarshaller.Instance;

            return Invoke<DescribeSubscriptionFiltersRequest,DescribeSubscriptionFiltersResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeSubscriptionFiltersResponse> DescribeSubscriptionFiltersAsync(DescribeSubscriptionFiltersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSubscriptionFiltersRequestMarshaller();
            var unmarshaller = DescribeSubscriptionFiltersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubscriptionFiltersRequest,DescribeSubscriptionFiltersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public FilterLogEventsResponse FilterLogEvents(FilterLogEventsRequest request)
        {
            var marshaller = new FilterLogEventsRequestMarshaller();
            var unmarshaller = FilterLogEventsResponseUnmarshaller.Instance;

            return Invoke<FilterLogEventsRequest,FilterLogEventsResponse>(request, marshaller, unmarshaller);
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
        public Task<FilterLogEventsResponse> FilterLogEventsAsync(FilterLogEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new FilterLogEventsRequestMarshaller();
            var unmarshaller = FilterLogEventsResponseUnmarshaller.Instance;

            return InvokeAsync<FilterLogEventsRequest,FilterLogEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public GetLogEventsResponse GetLogEvents(GetLogEventsRequest request)
        {
            var marshaller = new GetLogEventsRequestMarshaller();
            var unmarshaller = GetLogEventsResponseUnmarshaller.Instance;

            return Invoke<GetLogEventsRequest,GetLogEventsResponse>(request, marshaller, unmarshaller);
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
        public Task<GetLogEventsResponse> GetLogEventsAsync(GetLogEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetLogEventsRequestMarshaller();
            var unmarshaller = GetLogEventsResponseUnmarshaller.Instance;

            return InvokeAsync<GetLogEventsRequest,GetLogEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public PutDestinationResponse PutDestination(PutDestinationRequest request)
        {
            var marshaller = new PutDestinationRequestMarshaller();
            var unmarshaller = PutDestinationResponseUnmarshaller.Instance;

            return Invoke<PutDestinationRequest,PutDestinationResponse>(request, marshaller, unmarshaller);
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
        public Task<PutDestinationResponse> PutDestinationAsync(PutDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutDestinationRequestMarshaller();
            var unmarshaller = PutDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<PutDestinationRequest,PutDestinationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public PutDestinationPolicyResponse PutDestinationPolicy(PutDestinationPolicyRequest request)
        {
            var marshaller = new PutDestinationPolicyRequestMarshaller();
            var unmarshaller = PutDestinationPolicyResponseUnmarshaller.Instance;

            return Invoke<PutDestinationPolicyRequest,PutDestinationPolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<PutDestinationPolicyResponse> PutDestinationPolicyAsync(PutDestinationPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutDestinationPolicyRequestMarshaller();
            var unmarshaller = PutDestinationPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutDestinationPolicyRequest,PutDestinationPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// <li>The maximum number of log events in a batch is 10,000.</li> <li>A batch of log
        /// events in a single PutLogEvents request cannot span more than 24 hours. Otherwise,
        /// the PutLogEvents operation will fail.</li> </ul> 
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
        public PutLogEventsResponse PutLogEvents(PutLogEventsRequest request)
        {
            var marshaller = new PutLogEventsRequestMarshaller();
            var unmarshaller = PutLogEventsResponseUnmarshaller.Instance;

            return Invoke<PutLogEventsRequest,PutLogEventsResponse>(request, marshaller, unmarshaller);
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
        public Task<PutLogEventsResponse> PutLogEventsAsync(PutLogEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutLogEventsRequestMarshaller();
            var unmarshaller = PutLogEventsResponseUnmarshaller.Instance;

            return InvokeAsync<PutLogEventsRequest,PutLogEventsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public PutMetricFilterResponse PutMetricFilter(PutMetricFilterRequest request)
        {
            var marshaller = new PutMetricFilterRequestMarshaller();
            var unmarshaller = PutMetricFilterResponseUnmarshaller.Instance;

            return Invoke<PutMetricFilterRequest,PutMetricFilterResponse>(request, marshaller, unmarshaller);
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
        public Task<PutMetricFilterResponse> PutMetricFilterAsync(PutMetricFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutMetricFilterRequestMarshaller();
            var unmarshaller = PutMetricFilterResponseUnmarshaller.Instance;

            return InvokeAsync<PutMetricFilterRequest,PutMetricFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public PutRetentionPolicyResponse PutRetentionPolicy(PutRetentionPolicyRequest request)
        {
            var marshaller = new PutRetentionPolicyRequestMarshaller();
            var unmarshaller = PutRetentionPolicyResponseUnmarshaller.Instance;

            return Invoke<PutRetentionPolicyRequest,PutRetentionPolicyResponse>(request, marshaller, unmarshaller);
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
        public Task<PutRetentionPolicyResponse> PutRetentionPolicyAsync(PutRetentionPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutRetentionPolicyRequestMarshaller();
            var unmarshaller = PutRetentionPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutRetentionPolicyRequest,PutRetentionPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PutSubscriptionFilter


        /// <summary>
        /// Creates or updates a subscription filter and associates it with the specified log
        /// group. Subscription filters allow you to subscribe to a real-time stream of log events
        /// ingested through <code class="code">PutLogEvents</code> requests and have them delivered
        /// to a specific destination. Currently, the supported destinations are: <ul> <li> An
        /// Amazon Kinesis stream belonging to the same account as the subscription filter, for
        /// same-account delivery. </li> <li> A logical destination (used via an ARN of <code>Destination</code>)
        /// belonging to a different account, for cross-account delivery. </li> <li> An Amazon
        /// Kinesis Firehose stream belonging to the same account as the subscription filter,
        /// for same-account delivery. </li> <li> An AWS Lambda function belonging to the same
        /// account as the subscription filter, for same-account delivery. </li> </ul> 
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
        public PutSubscriptionFilterResponse PutSubscriptionFilter(PutSubscriptionFilterRequest request)
        {
            var marshaller = new PutSubscriptionFilterRequestMarshaller();
            var unmarshaller = PutSubscriptionFilterResponseUnmarshaller.Instance;

            return Invoke<PutSubscriptionFilterRequest,PutSubscriptionFilterResponse>(request, marshaller, unmarshaller);
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
        public Task<PutSubscriptionFilterResponse> PutSubscriptionFilterAsync(PutSubscriptionFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PutSubscriptionFilterRequestMarshaller();
            var unmarshaller = PutSubscriptionFilterResponseUnmarshaller.Instance;

            return InvokeAsync<PutSubscriptionFilterRequest,PutSubscriptionFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
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
        /// Returned if a parameter of the request is incorrectly specified.
        /// </exception>
        /// <exception cref="Amazon.CloudWatchLogs.Model.ServiceUnavailableException">
        /// Returned if the service cannot complete the request.
        /// </exception>
        public TestMetricFilterResponse TestMetricFilter(TestMetricFilterRequest request)
        {
            var marshaller = new TestMetricFilterRequestMarshaller();
            var unmarshaller = TestMetricFilterResponseUnmarshaller.Instance;

            return Invoke<TestMetricFilterRequest,TestMetricFilterResponse>(request, marshaller, unmarshaller);
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
        public Task<TestMetricFilterResponse> TestMetricFilterAsync(TestMetricFilterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TestMetricFilterRequestMarshaller();
            var unmarshaller = TestMetricFilterResponseUnmarshaller.Instance;

            return InvokeAsync<TestMetricFilterRequest,TestMetricFilterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}