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
 * Do not modify this file. This file is generated from the sqs-2012-11-05.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SQS.Model;
using Amazon.SQS.Model.Internal.MarshallTransformations;
using Amazon.SQS.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SQS
{
    /// <summary>
    /// Implementation for accessing SQS
    ///
    /// Welcome to the <i>Amazon SQS API Reference</i>.
    /// 
    ///  
    /// <para>
    /// Amazon SQS is a reliable, highly-scalable hosted queue for storing messages as they
    /// travel between applications or microservices. Amazon SQS moves data between distributed
    /// application components and helps you decouple these components.
    /// </para>
    ///  
    /// <para>
    /// For information on the permissions you need to use this API, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-authentication-and-access-control.html">Identity
    /// and access management</a> in the <i>Amazon SQS Developer Guide.</i> 
    /// </para>
    ///  
    /// <para>
    /// You can use <a href="http://aws.amazon.com/tools/#sdk">Amazon Web Services SDKs</a>
    /// to access Amazon SQS using your favorite programming language. The SDKs perform tasks
    /// such as the following automatically:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Cryptographically sign your service requests
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Retry requests
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Handle error responses
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Additional information</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/sqs/">Amazon SQS Product Page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Amazon SQS Developer Guide</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-making-api-requests.html">Making
    /// API Requests</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-message-metadata.html#sqs-message-attributes">Amazon
    /// SQS Message Attributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Amazon
    /// SQS Dead-Letter Queues</a> 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <a href="http://docs.aws.amazon.com/cli/latest/reference/sqs/index.html">Amazon SQS
    /// in the <i>Command Line Interface</i> </a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <i>Amazon Web Services General Reference</i> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#sqs_region">Regions
    /// and Endpoints</a> 
    /// </para>
    ///  </li> </ul> </li> </ul>
    /// </summary>
    public partial class AmazonSQSClient : AmazonServiceClient, IAmazonSQS
    {
        private static IServiceMetadata serviceMetadata = new AmazonSQSMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSQSClient with the credentials loaded from the application's
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
        public AmazonSQSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSQSConfig()) { }

        /// <summary>
        /// Constructs AmazonSQSClient with the credentials loaded from the application's
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
        public AmazonSQSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSQSConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSQSClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(AmazonSQSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonSQSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSQSClient(AWSCredentials credentials)
            : this(credentials, new AmazonSQSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSQSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSQSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Credentials and an
        /// AmazonSQSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(AWSCredentials credentials, AmazonSQSConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSQSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSQSConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSQSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSQSConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSQSConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQSClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSQSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISQSPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISQSPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SQSPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.SQS.Internal.ProcessRequestHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.SQS.Internal.ValidationResponseHandler());
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSQSEndpointResolver());
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


        #region  AddPermission

        internal virtual AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return Invoke<AddPermissionResponse>(request, options);
        }


        /// <summary>
        /// Adds a permission to a queue for a specific <a href="https://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a>.
        /// This allows sharing access to the queue.
        /// 
        ///  
        /// <para>
        /// When you create a queue, you have full control access rights for the queue. Only you,
        /// the owner of the queue, can grant or deny permissions to the queue. For more information
        /// about these permissions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-writing-an-sqs-policy.html#write-messages-to-shared-queue">Allow
        /// Developers to Write Messages to a Shared Queue</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <code>AddPermission</code> generates a policy for you. You can use <code> <a>SetQueueAttributes</a>
        /// </code> to upload your policy. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-creating-custom-policies.html">Using
        /// Custom Policies with the Amazon SQS Access Policy Language</a> in the <i>Amazon SQS
        /// Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon SQS policy can have a maximum of seven actions per statement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetQueueAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SQS <code>AddPermission</code> does not support adding a non-account principal.
        /// </para>
        ///  </li> </ul> </note> <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to which permissions are added. Queue URLs and names are case-sensitive.</param>
        /// <param name="label">The unique identification of the permission you're setting (for example, <code>AliceSendMessage</code>). Maximum 80 characters. Allowed characters include alphanumeric characters, hyphens (<code>-</code>), and underscores (<code>_</code>).</param>
        /// <param name="awsAccountIds">The Amazon Web Services account numbers of the <a href="https://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principals</a> who are to receive permission. For information about locating the Amazon Web Services account identification, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-making-api-requests.html#sqs-api-request-authentication">Your Amazon Web Services Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.</param>
        /// <param name="actions">The action the client wants to allow for the specified principal. Valid values: the name of any action or <code>*</code>. For more information about these actions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-overview-of-managing-access.html">Overview of Managing Access Permissions to Your Amazon Simple Queue Service Resource</a> in the <i>Amazon SQS Developer Guide</i>. Specifying <code>SendMessage</code>, <code>DeleteMessage</code>, or <code>ChangeMessageVisibility</code> for <code>ActionName.n</code> also grants permissions for the corresponding batch versions of those actions: <code>SendMessageBatch</code>, <code>DeleteMessageBatch</code>, and <code>ChangeMessageVisibilityBatch</code>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.OverLimitException">
        /// The specified action violates a limit. For example, <code>ReceiveMessage</code> returns
        /// this error if the maximum number of in flight messages is reached and <code>AddPermission</code>
        /// returns this error if the maximum number of permissions for the queue is reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual Task<AddPermissionResponse> AddPermissionAsync(string queueUrl, string label, List<string> awsAccountIds, List<string> actions, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new AddPermissionRequest();
            request.QueueUrl = queueUrl;
            request.Label = label;
            request.AWSAccountIds = awsAccountIds;
            request.Actions = actions;
            return AddPermissionAsync(request, cancellationToken);
        }



        /// <summary>
        /// Adds a permission to a queue for a specific <a href="https://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a>.
        /// This allows sharing access to the queue.
        /// 
        ///  
        /// <para>
        /// When you create a queue, you have full control access rights for the queue. Only you,
        /// the owner of the queue, can grant or deny permissions to the queue. For more information
        /// about these permissions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-writing-an-sqs-policy.html#write-messages-to-shared-queue">Allow
        /// Developers to Write Messages to a Shared Queue</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <code>AddPermission</code> generates a policy for you. You can use <code> <a>SetQueueAttributes</a>
        /// </code> to upload your policy. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-creating-custom-policies.html">Using
        /// Custom Policies with the Amazon SQS Access Policy Language</a> in the <i>Amazon SQS
        /// Developer Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An Amazon SQS policy can have a maximum of seven actions per statement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetQueueAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon SQS <code>AddPermission</code> does not support adding a non-account principal.
        /// </para>
        ///  </li> </ul> </note> <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddPermission service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.OverLimitException">
        /// The specified action violates a limit. For example, <code>ReceiveMessage</code> returns
        /// this error if the maximum number of in flight messages is reached and <code>AddPermission</code>
        /// returns this error if the maximum number of permissions for the queue is reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/AddPermission">REST API Reference for AddPermission Operation</seealso>
        public virtual Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddPermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddPermissionResponseUnmarshaller.Instance;

            return InvokeAsync<AddPermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelMessageMoveTask

        internal virtual CancelMessageMoveTaskResponse CancelMessageMoveTask(CancelMessageMoveTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMessageMoveTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMessageMoveTaskResponseUnmarshaller.Instance;

            return Invoke<CancelMessageMoveTaskResponse>(request, options);
        }



        /// <summary>
        /// Cancels a specified message movement task.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// A message movement can only be cancelled when the current status is RUNNING.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cancelling a message movement task does not revert the messages that have already
        /// been moved. It can only stop the messages that have not been moved yet.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelMessageMoveTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelMessageMoveTask service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.ResourceNotFoundException">
        /// One or more specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/CancelMessageMoveTask">REST API Reference for CancelMessageMoveTask Operation</seealso>
        public virtual Task<CancelMessageMoveTaskResponse> CancelMessageMoveTaskAsync(CancelMessageMoveTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelMessageMoveTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelMessageMoveTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelMessageMoveTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ChangeMessageVisibility

        internal virtual ChangeMessageVisibilityResponse ChangeMessageVisibility(ChangeMessageVisibilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeMessageVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeMessageVisibilityResponseUnmarshaller.Instance;

            return Invoke<ChangeMessageVisibilityResponse>(request, options);
        }


        /// <summary>
        /// Changes the visibility timeout of a specified message in a queue to a new value. The
        /// default visibility timeout for a message is 30 seconds. The minimum is 0 seconds.
        /// The maximum is 12 hours. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// For example, if the default timeout for a queue is 60 seconds, 15 seconds have elapsed
        /// since you received the message, and you send a ChangeMessageVisibility call with <code>VisibilityTimeout</code>
        /// set to 10 seconds, the 10 seconds begin to count from the time that you make the <code>ChangeMessageVisibility</code>
        /// call. Thus, any attempt to change the visibility timeout or to delete that message
        /// 10 seconds after you initially change the visibility timeout (a total of 25 seconds)
        /// might result in an error.
        /// </para>
        ///  
        /// <para>
        /// An Amazon SQS message has three basic states:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Sent to a queue by a producer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Received from the queue by a consumer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted from the queue.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// A message is considered to be <i>stored</i> after it is sent to a queue by a producer,
        /// but not yet received from the queue by a consumer (that is, between states 1 and 2).
        /// There is no limit to the number of stored messages. A message is considered to be
        /// <i>in flight</i> after it is received from a queue by a consumer, but not yet deleted
        /// from the queue (that is, between states 2 and 3). There is a limit to the number of
        /// in flight messages.
        /// </para>
        ///  
        /// <para>
        /// Limits that apply to in flight messages are unrelated to the <i>unlimited</i> number
        /// of stored messages.
        /// </para>
        ///  
        /// <para>
        /// For most standard queues (depending on queue traffic and message backlog), there can
        /// be a maximum of approximately 120,000 in flight messages (received from a queue by
        /// a consumer, but not yet deleted from the queue). If you reach this limit, Amazon SQS
        /// returns the <code>OverLimit</code> error message. To avoid reaching the limit, you
        /// should delete messages from the queue after they're processed. You can also increase
        /// the number of queues you use to process your messages. To request a limit increase,
        /// <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-sqs">file
        /// a support request</a>.
        /// </para>
        ///  
        /// <para>
        /// For FIFO queues, there can be a maximum of 20,000 in flight messages (received from
        /// a queue by a consumer, but not yet deleted from the queue). If you reach this limit,
        /// Amazon SQS returns no error messages.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you attempt to set the <code>VisibilityTimeout</code> to a value greater than the
        /// maximum time left, Amazon SQS returns an error. Amazon SQS doesn't automatically recalculate
        /// and increase the timeout to the maximum remaining time.
        /// </para>
        ///  
        /// <para>
        /// Unlike with a queue, when you change the visibility timeout for a specific message
        /// the timeout value is applied immediately but isn't saved in memory for that message.
        /// If you don't delete a message after it is received, the visibility timeout for the
        /// message reverts to the original timeout value (not to the value you set using the
        /// <code>ChangeMessageVisibility</code> action) the next time the message is received.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose message's visibility is changed. Queue URLs and names are case-sensitive.</param>
        /// <param name="receiptHandle">The receipt handle associated with the message, whose visibility timeout is changed. This parameter is returned by the <code> <a>ReceiveMessage</a> </code> action.</param>
        /// <param name="visibilityTimeout">The new value for the message's visibility timeout (in seconds). Values range: <code>0</code> to <code>43200</code>. Maximum: 12 hours.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeMessageVisibility service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.MessageNotInflightException">
        /// The specified message isn't in flight.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ReceiptHandleIsInvalidException">
        /// The specified receipt handle isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ChangeMessageVisibility">REST API Reference for ChangeMessageVisibility Operation</seealso>
        public virtual Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(string queueUrl, string receiptHandle, int visibilityTimeout, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ChangeMessageVisibilityRequest();
            request.QueueUrl = queueUrl;
            request.ReceiptHandle = receiptHandle;
            request.VisibilityTimeout = visibilityTimeout;
            return ChangeMessageVisibilityAsync(request, cancellationToken);
        }



        /// <summary>
        /// Changes the visibility timeout of a specified message in a queue to a new value. The
        /// default visibility timeout for a message is 30 seconds. The minimum is 0 seconds.
        /// The maximum is 12 hours. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// For example, if the default timeout for a queue is 60 seconds, 15 seconds have elapsed
        /// since you received the message, and you send a ChangeMessageVisibility call with <code>VisibilityTimeout</code>
        /// set to 10 seconds, the 10 seconds begin to count from the time that you make the <code>ChangeMessageVisibility</code>
        /// call. Thus, any attempt to change the visibility timeout or to delete that message
        /// 10 seconds after you initially change the visibility timeout (a total of 25 seconds)
        /// might result in an error.
        /// </para>
        ///  
        /// <para>
        /// An Amazon SQS message has three basic states:
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// Sent to a queue by a producer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Received from the queue by a consumer.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Deleted from the queue.
        /// </para>
        ///  </li> </ol> 
        /// <para>
        /// A message is considered to be <i>stored</i> after it is sent to a queue by a producer,
        /// but not yet received from the queue by a consumer (that is, between states 1 and 2).
        /// There is no limit to the number of stored messages. A message is considered to be
        /// <i>in flight</i> after it is received from a queue by a consumer, but not yet deleted
        /// from the queue (that is, between states 2 and 3). There is a limit to the number of
        /// in flight messages.
        /// </para>
        ///  
        /// <para>
        /// Limits that apply to in flight messages are unrelated to the <i>unlimited</i> number
        /// of stored messages.
        /// </para>
        ///  
        /// <para>
        /// For most standard queues (depending on queue traffic and message backlog), there can
        /// be a maximum of approximately 120,000 in flight messages (received from a queue by
        /// a consumer, but not yet deleted from the queue). If you reach this limit, Amazon SQS
        /// returns the <code>OverLimit</code> error message. To avoid reaching the limit, you
        /// should delete messages from the queue after they're processed. You can also increase
        /// the number of queues you use to process your messages. To request a limit increase,
        /// <a href="https://console.aws.amazon.com/support/home#/case/create?issueType=service-limit-increase&amp;limitType=service-code-sqs">file
        /// a support request</a>.
        /// </para>
        ///  
        /// <para>
        /// For FIFO queues, there can be a maximum of 20,000 in flight messages (received from
        /// a queue by a consumer, but not yet deleted from the queue). If you reach this limit,
        /// Amazon SQS returns no error messages.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you attempt to set the <code>VisibilityTimeout</code> to a value greater than the
        /// maximum time left, Amazon SQS returns an error. Amazon SQS doesn't automatically recalculate
        /// and increase the timeout to the maximum remaining time.
        /// </para>
        ///  
        /// <para>
        /// Unlike with a queue, when you change the visibility timeout for a specific message
        /// the timeout value is applied immediately but isn't saved in memory for that message.
        /// If you don't delete a message after it is received, the visibility timeout for the
        /// message reverts to the original timeout value (not to the value you set using the
        /// <code>ChangeMessageVisibility</code> action) the next time the message is received.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibility service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeMessageVisibility service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.MessageNotInflightException">
        /// The specified message isn't in flight.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ReceiptHandleIsInvalidException">
        /// The specified receipt handle isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ChangeMessageVisibility">REST API Reference for ChangeMessageVisibility Operation</seealso>
        public virtual Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(ChangeMessageVisibilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeMessageVisibilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeMessageVisibilityResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeMessageVisibilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ChangeMessageVisibilityBatch

        internal virtual ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeMessageVisibilityBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeMessageVisibilityBatchResponseUnmarshaller.Instance;

            return Invoke<ChangeMessageVisibilityBatchResponse>(request, options);
        }


        /// <summary>
        /// Changes the visibility timeout of multiple messages. This is a batch version of <code>
        /// <a>ChangeMessageVisibility</a>.</code> The result of the action on each message is
        /// reported individually in the response. You can send up to 10 <code> <a>ChangeMessageVisibility</a>
        /// </code> requests with each <code>ChangeMessageVisibilityBatch</code> action.
        /// 
        ///  <important> 
        /// <para>
        /// Because the batch request can result in a combination of successful and unsuccessful
        /// actions, you should check for batch errors even when the call returns an HTTP status
        /// code of <code>200</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose messages' visibility is changed. Queue URLs and names are case-sensitive.</param>
        /// <param name="entries">Lists the receipt handles of the messages for which the visibility timeout must be changed.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeMessageVisibilityBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <code>Id</code>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ChangeMessageVisibilityBatch">REST API Reference for ChangeMessageVisibilityBatch Operation</seealso>
        public virtual Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(string queueUrl, List<ChangeMessageVisibilityBatchRequestEntry> entries, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ChangeMessageVisibilityBatchRequest();
            request.QueueUrl = queueUrl;
            request.Entries = entries;
            return ChangeMessageVisibilityBatchAsync(request, cancellationToken);
        }



        /// <summary>
        /// Changes the visibility timeout of multiple messages. This is a batch version of <code>
        /// <a>ChangeMessageVisibility</a>.</code> The result of the action on each message is
        /// reported individually in the response. You can send up to 10 <code> <a>ChangeMessageVisibility</a>
        /// </code> requests with each <code>ChangeMessageVisibilityBatch</code> action.
        /// 
        ///  <important> 
        /// <para>
        /// Because the batch request can result in a combination of successful and unsuccessful
        /// actions, you should check for batch errors even when the call returns an HTTP status
        /// code of <code>200</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ChangeMessageVisibilityBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <code>Id</code>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ChangeMessageVisibilityBatch">REST API Reference for ChangeMessageVisibilityBatch Operation</seealso>
        public virtual Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(ChangeMessageVisibilityBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ChangeMessageVisibilityBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ChangeMessageVisibilityBatchResponseUnmarshaller.Instance;

            return InvokeAsync<ChangeMessageVisibilityBatchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateQueue

        internal virtual CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return Invoke<CreateQueueResponse>(request, options);
        }


        /// <summary>
        /// Creates a new standard or FIFO queue. You can pass one or more attributes in the request.
        /// Keep the following in mind:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If you don't specify the <code>FifoQueue</code> attribute, Amazon SQS creates a standard
        /// queue.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't change the queue type after you create it and you can't convert an existing
        /// standard queue into a FIFO queue. You must either create a new FIFO queue for your
        /// application or delete your existing standard queue and recreate it as a FIFO queue.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-moving">Moving
        /// From a Standard Queue to a FIFO Queue</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// If you don't provide a value for an attribute, the queue is created with the default
        /// value for the attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you delete a queue, you must wait at least 60 seconds before creating a queue with
        /// the same name.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To successfully create a new queue, you must provide a queue name that adheres to
        /// the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/limits-queues.html">limits
        /// related to queues</a> and is unique within the scope of your queues.
        /// </para>
        ///  <note> 
        /// <para>
        /// After you create a queue, you must wait at least one second after the queue is created
        /// to be able to use the queue.
        /// </para>
        ///  </note> 
        /// <para>
        /// To get the queue URL, use the <code> <a>GetQueueUrl</a> </code> action. <code> <a>GetQueueUrl</a>
        /// </code> requires only the <code>QueueName</code> parameter. be aware of existing queue
        /// names:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you provide the name of an existing queue along with the exact names and values
        /// of all the queue's attributes, <code>CreateQueue</code> returns the queue URL for
        /// the existing queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the queue name, attribute names, or attribute values don't match an existing queue,
        /// <code>CreateQueue</code> returns an error.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueName">The name of the new queue. The following limits apply to this name: <ul> <li> A queue name can have up to 80 characters. </li> <li> Valid values: alphanumeric characters, hyphens (<code>-</code>), and underscores (<code>_</code>). </li> <li> A FIFO queue name must end with the <code>.fifo</code> suffix. </li> </ul> Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.QueueDeletedRecentlyException">
        /// You must wait 60 seconds after deleting a queue before you can create another queue
        /// with the same name.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueNameExistsException">
        /// A queue with this name already exists. Amazon SQS returns this error only if the request
        /// includes attributes whose values differ from those of the existing queue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual Task<CreateQueueResponse> CreateQueueAsync(string queueName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new CreateQueueRequest();
            request.QueueName = queueName;
            return CreateQueueAsync(request, cancellationToken);
        }



        /// <summary>
        /// Creates a new standard or FIFO queue. You can pass one or more attributes in the request.
        /// Keep the following in mind:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// If you don't specify the <code>FifoQueue</code> attribute, Amazon SQS creates a standard
        /// queue.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't change the queue type after you create it and you can't convert an existing
        /// standard queue into a FIFO queue. You must either create a new FIFO queue for your
        /// application or delete your existing standard queue and recreate it as a FIFO queue.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html#FIFO-queues-moving">Moving
        /// From a Standard Queue to a FIFO Queue</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// If you don't provide a value for an attribute, the queue is created with the default
        /// value for the attribute.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you delete a queue, you must wait at least 60 seconds before creating a queue with
        /// the same name.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To successfully create a new queue, you must provide a queue name that adheres to
        /// the <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/limits-queues.html">limits
        /// related to queues</a> and is unique within the scope of your queues.
        /// </para>
        ///  <note> 
        /// <para>
        /// After you create a queue, you must wait at least one second after the queue is created
        /// to be able to use the queue.
        /// </para>
        ///  </note> 
        /// <para>
        /// To get the queue URL, use the <code> <a>GetQueueUrl</a> </code> action. <code> <a>GetQueueUrl</a>
        /// </code> requires only the <code>QueueName</code> parameter. be aware of existing queue
        /// names:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If you provide the name of an existing queue along with the exact names and values
        /// of all the queue's attributes, <code>CreateQueue</code> returns the queue URL for
        /// the existing queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the queue name, attribute names, or attribute values don't match an existing queue,
        /// <code>CreateQueue</code> returns an error.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.QueueDeletedRecentlyException">
        /// You must wait 60 seconds after deleting a queue before you can create another queue
        /// with the same name.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueNameExistsException">
        /// A queue with this name already exists. Amazon SQS returns this error only if the request
        /// includes attributes whose values differ from those of the existing queue.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/CreateQueue">REST API Reference for CreateQueue Operation</seealso>
        public virtual Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateQueueResponseUnmarshaller.Instance;

            return InvokeAsync<CreateQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMessage

        internal virtual DeleteMessageResponse DeleteMessage(DeleteMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageResponseUnmarshaller.Instance;

            return Invoke<DeleteMessageResponse>(request, options);
        }


        /// <summary>
        /// Deletes the specified message from the specified queue. To select the message to delete,
        /// use the <code>ReceiptHandle</code> of the message (<i>not</i> the <code>MessageId</code>
        /// which you receive when you send the message). Amazon SQS can delete a message from
        /// a queue even if a visibility timeout setting causes the message to be locked by another
        /// consumer. Amazon SQS automatically deletes messages left in a queue longer than the
        /// retention period configured for the queue. 
        /// 
        ///  <note> 
        /// <para>
        /// The <code>ReceiptHandle</code> is associated with a <i>specific instance</i> of receiving
        /// a message. If you receive a message more than once, the <code>ReceiptHandle</code>
        /// is different each time you receive a message. When you use the <code>DeleteMessage</code>
        /// action, you must provide the most recently received <code>ReceiptHandle</code> for
        /// the message (otherwise, the request succeeds, but the message will not be deleted).
        /// </para>
        ///  
        /// <para>
        /// For standard queues, it is possible to receive a message even after you delete it.
        /// This might happen on rare occasions if one of the servers which stores a copy of the
        /// message is unavailable when you send the request to delete the message. The copy remains
        /// on the server and might be returned to you during a subsequent receive request. You
        /// should ensure that your application is idempotent, so that receiving a message more
        /// than once does not cause issues.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which messages are deleted. Queue URLs and names are case-sensitive.</param>
        /// <param name="receiptHandle">The receipt handle associated with the message to delete.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidIdFormatException">
        /// The specified receipt handle isn't valid for the current version.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ReceiptHandleIsInvalidException">
        /// The specified receipt handle isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteMessage">REST API Reference for DeleteMessage Operation</seealso>
        public virtual Task<DeleteMessageResponse> DeleteMessageAsync(string queueUrl, string receiptHandle, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteMessageRequest();
            request.QueueUrl = queueUrl;
            request.ReceiptHandle = receiptHandle;
            return DeleteMessageAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes the specified message from the specified queue. To select the message to delete,
        /// use the <code>ReceiptHandle</code> of the message (<i>not</i> the <code>MessageId</code>
        /// which you receive when you send the message). Amazon SQS can delete a message from
        /// a queue even if a visibility timeout setting causes the message to be locked by another
        /// consumer. Amazon SQS automatically deletes messages left in a queue longer than the
        /// retention period configured for the queue. 
        /// 
        ///  <note> 
        /// <para>
        /// The <code>ReceiptHandle</code> is associated with a <i>specific instance</i> of receiving
        /// a message. If you receive a message more than once, the <code>ReceiptHandle</code>
        /// is different each time you receive a message. When you use the <code>DeleteMessage</code>
        /// action, you must provide the most recently received <code>ReceiptHandle</code> for
        /// the message (otherwise, the request succeeds, but the message will not be deleted).
        /// </para>
        ///  
        /// <para>
        /// For standard queues, it is possible to receive a message even after you delete it.
        /// This might happen on rare occasions if one of the servers which stores a copy of the
        /// message is unavailable when you send the request to delete the message. The copy remains
        /// on the server and might be returned to you during a subsequent receive request. You
        /// should ensure that your application is idempotent, so that receiving a message more
        /// than once does not cause issues.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidIdFormatException">
        /// The specified receipt handle isn't valid for the current version.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.ReceiptHandleIsInvalidException">
        /// The specified receipt handle isn't valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteMessage">REST API Reference for DeleteMessage Operation</seealso>
        public virtual Task<DeleteMessageResponse> DeleteMessageAsync(DeleteMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMessageBatch

        internal virtual DeleteMessageBatchResponse DeleteMessageBatch(DeleteMessageBatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMessageBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageBatchResponseUnmarshaller.Instance;

            return Invoke<DeleteMessageBatchResponse>(request, options);
        }


        /// <summary>
        /// Deletes up to ten messages from the specified queue. This is a batch version of <code>
        /// <a>DeleteMessage</a>.</code> The result of the action on each message is reported
        /// individually in the response.
        /// 
        ///  <important> 
        /// <para>
        /// Because the batch request can result in a combination of successful and unsuccessful
        /// actions, you should check for batch errors even when the call returns an HTTP status
        /// code of <code>200</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which messages are deleted. Queue URLs and names are case-sensitive.</param>
        /// <param name="entries">Lists the receipt handles for the messages to be deleted.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <code>Id</code>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteMessageBatch">REST API Reference for DeleteMessageBatch Operation</seealso>
        public virtual Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(string queueUrl, List<DeleteMessageBatchRequestEntry> entries, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteMessageBatchRequest();
            request.QueueUrl = queueUrl;
            request.Entries = entries;
            return DeleteMessageBatchAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes up to ten messages from the specified queue. This is a batch version of <code>
        /// <a>DeleteMessage</a>.</code> The result of the action on each message is reported
        /// individually in the response.
        /// 
        ///  <important> 
        /// <para>
        /// Because the batch request can result in a combination of successful and unsuccessful
        /// actions, you should check for batch errors even when the call returns an HTTP status
        /// code of <code>200</code>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <code>Id</code>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteMessageBatch">REST API Reference for DeleteMessageBatch Operation</seealso>
        public virtual Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(DeleteMessageBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteMessageBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMessageBatchResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMessageBatchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteQueue

        internal virtual DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return Invoke<DeleteQueueResponse>(request, options);
        }


        /// <summary>
        /// Deletes the queue specified by the <code>QueueUrl</code>, regardless of the queue's
        /// contents.
        /// 
        ///  <important> 
        /// <para>
        /// Be careful with the <code>DeleteQueue</code> action: When you delete a queue, any
        /// messages in the queue are no longer available. 
        /// </para>
        ///  </important> 
        /// <para>
        /// When you delete a queue, the deletion process takes up to 60 seconds. Requests you
        /// send involving that queue during the 60 seconds might succeed. For example, a <code>
        /// <a>SendMessage</a> </code> request might succeed, but after 60 seconds the queue and
        /// the message you sent no longer exist.
        /// </para>
        ///  
        /// <para>
        /// When you delete a queue, you must wait at least 60 seconds before creating a queue
        /// with the same name.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The delete operation uses the HTTP <code>GET</code> verb.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to delete. Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by SQS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        public virtual Task<DeleteQueueResponse> DeleteQueueAsync(string queueUrl, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new DeleteQueueRequest();
            request.QueueUrl = queueUrl;
            return DeleteQueueAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes the queue specified by the <code>QueueUrl</code>, regardless of the queue's
        /// contents.
        /// 
        ///  <important> 
        /// <para>
        /// Be careful with the <code>DeleteQueue</code> action: When you delete a queue, any
        /// messages in the queue are no longer available. 
        /// </para>
        ///  </important> 
        /// <para>
        /// When you delete a queue, the deletion process takes up to 60 seconds. Requests you
        /// send involving that queue during the 60 seconds might succeed. For example, a <code>
        /// <a>SendMessage</a> </code> request might succeed, but after 60 seconds the queue and
        /// the message you sent no longer exist.
        /// </para>
        ///  
        /// <para>
        /// When you delete a queue, you must wait at least 60 seconds before creating a queue
        /// with the same name.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The delete operation uses the HTTP <code>GET</code> verb.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteQueue service method, as returned by SQS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/DeleteQueue">REST API Reference for DeleteQueue Operation</seealso>
        public virtual Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteQueueResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueueAttributes

        internal virtual GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueueAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueAttributesResponseUnmarshaller.Instance;

            return Invoke<GetQueueAttributesResponse>(request, options);
        }


        /// <summary>
        /// Gets attributes for the specified queue.
        /// 
        ///  <note> 
        /// <para>
        /// To determine whether a queue is <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>,
        /// you can check whether <code>QueueName</code> ends with the <code>.fifo</code> suffix.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose attribute information is retrieved. Queue URLs and names are case-sensitive.</param>
        /// <param name="attributeNames">A list of attributes for which to retrieve information. The <code>AttributeNames</code> parameter is optional, but if you don't specify values for this parameter, the request returns empty results. <note> In the future, new attributes might be added. If you write code that calls this action, we recommend that you structure your code so that it can handle new attributes gracefully. </note> The following attributes are supported: <important> The <code>ApproximateNumberOfMessagesDelayed</code>, <code>ApproximateNumberOfMessagesNotVisible</code>, and <code>ApproximateNumberOfMessages</code> metrics may not achieve consistency until at least 1 minute after the producers stop sending messages. This period is required for the queue metadata to reach eventual consistency.  </important> <ul> <li>  <code>All</code> – Returns all values.  </li> <li>  <code>ApproximateNumberOfMessages</code> – Returns the approximate number of messages available for retrieval from the queue. </li> <li>  <code>ApproximateNumberOfMessagesDelayed</code> – Returns the approximate number of messages in the queue that are delayed and not available for reading immediately. This can happen when the queue is configured as a delay queue or when a message has been sent with a delay parameter. </li> <li>  <code>ApproximateNumberOfMessagesNotVisible</code> – Returns the approximate number of messages that are in flight. Messages are considered to be <i>in flight</i> if they have been sent to a client but have not yet been deleted or have not yet reached the end of their visibility window.  </li> <li>  <code>CreatedTimestamp</code> – Returns the time when the queue was created in seconds (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>). </li> <li>  <code>DelaySeconds</code> – Returns the default delay on the queue in seconds. </li> <li>  <code>LastModifiedTimestamp</code> – Returns the time when the queue was last changed in seconds (<a href="http://en.wikipedia.org/wiki/Unix_time">epoch time</a>). </li> <li>  <code>MaximumMessageSize</code> – Returns the limit of how many bytes a message can contain before Amazon SQS rejects it. </li> <li>  <code>MessageRetentionPeriod</code> – Returns the length of time, in seconds, for which Amazon SQS retains a message. When you change a queue's attributes, the change can take up to 60 seconds for most of the attributes to propagate throughout the Amazon SQS system. Changes made to the <code>MessageRetentionPeriod</code> attribute can take up to 15 minutes and will impact existing messages in the queue potentially causing them to be expired and deleted if the <code>MessageRetentionPeriod</code> is reduced below the age of existing messages. </li> <li>  <code>Policy</code> – Returns the policy of the queue. </li> <li>  <code>QueueArn</code> – Returns the Amazon resource name (ARN) of the queue. </li> <li>  <code>ReceiveMessageWaitTimeSeconds</code> – Returns the length of time, in seconds, for which the <code>ReceiveMessage</code> action waits for a message to arrive.  </li> <li>  <code>VisibilityTimeout</code> – Returns the visibility timeout for the queue. For more information about the visibility timeout, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility Timeout</a> in the <i>Amazon SQS Developer Guide</i>.  </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter queues:</a>  <ul> <li>  <code>RedrivePolicy</code> – The string that includes the parameters for the dead-letter queue functionality of the source queue as a JSON object. The parameters are as follows: <ul> <li>  <code>deadLetterTargetArn</code> – The Amazon Resource Name (ARN) of the dead-letter queue to which Amazon SQS moves messages after the value of <code>maxReceiveCount</code> is exceeded. </li> <li>  <code>maxReceiveCount</code> – The number of times a message is delivered to the source queue before being moved to the dead-letter queue. Default: 10. When the <code>ReceiveCount</code> for a message exceeds the <code>maxReceiveCount</code> for a queue, Amazon SQS moves the message to the dead-letter-queue. </li> </ul> </li> <li>  <code>RedriveAllowPolicy</code> – The string that includes the parameters for the permissions for the dead-letter queue redrive permission and which source queues can specify dead-letter queues as a JSON object. The parameters are as follows: <ul> <li>  <code>redrivePermission</code> – The permission type that defines which source queues can specify the current queue as the dead-letter queue. Valid values are: <ul> <li>  <code>allowAll</code> – (Default) Any source queues in this Amazon Web Services account in the same Region can specify this queue as the dead-letter queue. </li> <li>  <code>denyAll</code> – No source queues can specify this queue as the dead-letter queue. </li> <li>  <code>byQueue</code> – Only queues specified by the <code>sourceQueueArns</code> parameter can specify this queue as the dead-letter queue. </li> </ul> </li> <li>  <code>sourceQueueArns</code> – The Amazon Resource Names (ARN)s of the source queues that can specify this queue as the dead-letter queue and redrive messages. You can specify this parameter only when the <code>redrivePermission</code> parameter is set to <code>byQueue</code>. You can specify up to 10 source queue ARNs. To allow more than 10 source queues to specify dead-letter queues, set the <code>redrivePermission</code> parameter to <code>allowAll</code>. </li> </ul> </li> </ul> <note> The dead-letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead-letter queue of a standard queue must also be a standard queue. </note> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html">server-side-encryption</a>: <ul> <li>  <code>KmsMasterKeyId</code> – Returns the ID of an Amazon Web Services managed customer master key (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key Terms</a>.  </li> <li>  <code>KmsDataKeyReusePeriodSeconds</code> – Returns the length of time, in seconds, for which Amazon SQS can reuse a data key to encrypt or decrypt messages before calling KMS again. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How Does the Data Key Reuse Period Work?</a>.  </li> <li>  <code>SqsManagedSseEnabled</code> – Returns information about whether the queue is using SSE-SQS encryption using SQS owned encryption keys. Only one server-side encryption option is supported per queue (for example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a> or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>). </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO (first-in-first-out) queues</a>: <ul> <li>  <code>FifoQueue</code> – Returns information about whether the queue is FIFO. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-understanding-logic.html">FIFO queue logic</a> in the <i>Amazon SQS Developer Guide</i>. <note> To determine whether a queue is <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>, you can check whether <code>QueueName</code> ends with the <code>.fifo</code> suffix. </note> </li> <li>  <code>ContentBasedDeduplication</code> – Returns whether content-based deduplication is enabled for the queue. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-exactly-once-processing.html">Exactly-once processing</a> in the <i>Amazon SQS Developer Guide</i>.  </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/high-throughput-fifo.html">high throughput for FIFO queues</a>: <ul> <li>  <code>DeduplicationScope</code> – Specifies whether message deduplication occurs at the message group or queue level. Valid values are <code>messageGroup</code> and <code>queue</code>. </li> <li>  <code>FifoThroughputLimit</code> – Specifies whether the FIFO queue throughput quota applies to the entire queue or per message group. Valid values are <code>perQueue</code> and <code>perMessageGroupId</code>. The <code>perMessageGroupId</code> value is allowed only when the value for <code>DeduplicationScope</code> is <code>messageGroup</code>. </li> </ul> To enable high throughput for FIFO queues, do the following: <ul> <li> Set <code>DeduplicationScope</code> to <code>messageGroup</code>. </li> <li> Set <code>FifoThroughputLimit</code> to <code>perMessageGroupId</code>. </li> </ul> If you set these attributes to anything other than the values shown for enabling high throughput, normal throughput is in effect and deduplication occurs as specified. For information on throughput quotas, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/quotas-messages.html">Quotas related to messages</a> in the <i>Amazon SQS Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeNameException">
        /// The specified attribute doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/GetQueueAttributes">REST API Reference for GetQueueAttributes Operation</seealso>
        public virtual Task<GetQueueAttributesResponse> GetQueueAttributesAsync(string queueUrl, List<string> attributeNames, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetQueueAttributesRequest();
            request.QueueUrl = queueUrl;
            request.AttributeNames = attributeNames;
            return GetQueueAttributesAsync(request, cancellationToken);
        }



        /// <summary>
        /// Gets attributes for the specified queue.
        /// 
        ///  <note> 
        /// <para>
        /// To determine whether a queue is <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO</a>,
        /// you can check whether <code>QueueName</code> ends with the <code>.fifo</code> suffix.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeNameException">
        /// The specified attribute doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/GetQueueAttributes">REST API Reference for GetQueueAttributes Operation</seealso>
        public virtual Task<GetQueueAttributesResponse> GetQueueAttributesAsync(GetQueueAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueueAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueueAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetQueueUrl

        internal virtual GetQueueUrlResponse GetQueueUrl(GetQueueUrlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueueUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueUrlResponseUnmarshaller.Instance;

            return Invoke<GetQueueUrlResponse>(request, options);
        }


        /// <summary>
        /// Returns the URL of an existing Amazon SQS queue.
        /// 
        ///  
        /// <para>
        /// To access a queue that belongs to another AWS account, use the <code>QueueOwnerAWSAccountId</code>
        /// parameter to specify the account ID of the queue's owner. The queue's owner must grant
        /// you permission to access the queue. For more information about shared queue access,
        /// see <code> <a>AddPermission</a> </code> or see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-writing-an-sqs-policy.html#write-messages-to-shared-queue">Allow
        /// Developers to Write Messages to a Shared Queue</a> in the <i>Amazon SQS Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="queueName">The name of the queue whose URL must be fetched. Maximum 80 characters. Valid values: alphanumeric characters, hyphens (<code>-</code>), and underscores (<code>_</code>). Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueUrl service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// The specified queue doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/GetQueueUrl">REST API Reference for GetQueueUrl Operation</seealso>
        public virtual Task<GetQueueUrlResponse> GetQueueUrlAsync(string queueName, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new GetQueueUrlRequest();
            request.QueueName = queueName;
            return GetQueueUrlAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns the URL of an existing Amazon SQS queue.
        /// 
        ///  
        /// <para>
        /// To access a queue that belongs to another AWS account, use the <code>QueueOwnerAWSAccountId</code>
        /// parameter to specify the account ID of the queue's owner. The queue's owner must grant
        /// you permission to access the queue. For more information about shared queue access,
        /// see <code> <a>AddPermission</a> </code> or see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-writing-an-sqs-policy.html#write-messages-to-shared-queue">Allow
        /// Developers to Write Messages to a Shared Queue</a> in the <i>Amazon SQS Developer
        /// Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetQueueUrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetQueueUrl service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// The specified queue doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/GetQueueUrl">REST API Reference for GetQueueUrl Operation</seealso>
        public virtual Task<GetQueueUrlResponse> GetQueueUrlAsync(GetQueueUrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetQueueUrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetQueueUrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetQueueUrlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListDeadLetterSourceQueues

        internal virtual ListDeadLetterSourceQueuesResponse ListDeadLetterSourceQueues(ListDeadLetterSourceQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeadLetterSourceQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeadLetterSourceQueuesResponseUnmarshaller.Instance;

            return Invoke<ListDeadLetterSourceQueuesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of your queues that have the <code>RedrivePolicy</code> queue attribute
        /// configured with a dead-letter queue.
        /// 
        ///  
        /// <para>
        ///  The <code>ListDeadLetterSourceQueues</code> methods supports pagination. Set parameter
        /// <code>MaxResults</code> in the request to specify the maximum number of results to
        /// be returned in the response. If you do not set <code>MaxResults</code>, the response
        /// includes a maximum of 1,000 results. If you set <code>MaxResults</code> and there
        /// are additional results to display, the response includes a value for <code>NextToken</code>.
        /// Use <code>NextToken</code> as a parameter in your next request to <code>ListDeadLetterSourceQueues</code>
        /// to receive the next page of results. 
        /// </para>
        ///  
        /// <para>
        /// For more information about using dead-letter queues, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">Using
        /// Amazon SQS Dead-Letter Queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListDeadLetterSourceQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListDeadLetterSourceQueues service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// The specified queue doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ListDeadLetterSourceQueues">REST API Reference for ListDeadLetterSourceQueues Operation</seealso>
        public virtual Task<ListDeadLetterSourceQueuesResponse> ListDeadLetterSourceQueuesAsync(ListDeadLetterSourceQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListDeadLetterSourceQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListDeadLetterSourceQueuesResponseUnmarshaller.Instance;

            return InvokeAsync<ListDeadLetterSourceQueuesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMessageMoveTasks

        internal virtual ListMessageMoveTasksResponse ListMessageMoveTasks(ListMessageMoveTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMessageMoveTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessageMoveTasksResponseUnmarshaller.Instance;

            return Invoke<ListMessageMoveTasksResponse>(request, options);
        }



        /// <summary>
        /// Gets the most recent message movement tasks (up to 10) under a specific source queue.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMessageMoveTasks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMessageMoveTasks service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.ResourceNotFoundException">
        /// One or more specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ListMessageMoveTasks">REST API Reference for ListMessageMoveTasks Operation</seealso>
        public virtual Task<ListMessageMoveTasksResponse> ListMessageMoveTasksAsync(ListMessageMoveTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListMessageMoveTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMessageMoveTasksResponseUnmarshaller.Instance;

            return InvokeAsync<ListMessageMoveTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQueues

        internal virtual ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return Invoke<ListQueuesResponse>(request, options);
        }


        /// <summary>
        /// Returns a list of your queues in the current region. The response includes a maximum
        /// of 1,000 results. If you specify a value for the optional <code>QueueNamePrefix</code>
        /// parameter, only queues with a name that begins with the specified value are returned.
        /// 
        ///  
        /// <para>
        ///  The <code>listQueues</code> methods supports pagination. Set parameter <code>MaxResults</code>
        /// in the request to specify the maximum number of results to be returned in the response.
        /// If you do not set <code>MaxResults</code>, the response includes a maximum of 1,000
        /// results. If you set <code>MaxResults</code> and there are additional results to display,
        /// the response includes a value for <code>NextToken</code>. Use <code>NextToken</code>
        /// as a parameter in your next request to <code>listQueues</code> to receive the next
        /// page of results. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueNamePrefix">A string to use for filtering the list results. Only those queues whose name begins with the specified string are returned. Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by SQS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual Task<ListQueuesResponse> ListQueuesAsync(string queueNamePrefix, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ListQueuesRequest();
            request.QueueNamePrefix = queueNamePrefix;
            return ListQueuesAsync(request, cancellationToken);
        }



        /// <summary>
        /// Returns a list of your queues in the current region. The response includes a maximum
        /// of 1,000 results. If you specify a value for the optional <code>QueueNamePrefix</code>
        /// parameter, only queues with a name that begins with the specified value are returned.
        /// 
        ///  
        /// <para>
        ///  The <code>listQueues</code> methods supports pagination. Set parameter <code>MaxResults</code>
        /// in the request to specify the maximum number of results to be returned in the response.
        /// If you do not set <code>MaxResults</code>, the response includes a maximum of 1,000
        /// results. If you set <code>MaxResults</code> and there are additional results to display,
        /// the response includes a value for <code>NextToken</code>. Use <code>NextToken</code>
        /// as a parameter in your next request to <code>listQueues</code> to receive the next
        /// page of results. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by SQS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ListQueues">REST API Reference for ListQueues Operation</seealso>
        public virtual Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueuesResponseUnmarshaller.Instance;

            return InvokeAsync<ListQueuesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListQueueTags

        internal virtual ListQueueTagsResponse ListQueueTags(ListQueueTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueueTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueTagsResponseUnmarshaller.Instance;

            return Invoke<ListQueueTagsResponse>(request, options);
        }



        /// <summary>
        /// List all cost allocation tags added to the specified Amazon SQS queue. For an overview,
        /// see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-tags.html">Tagging
        /// Your Amazon SQS Queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListQueueTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListQueueTags service method, as returned by SQS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ListQueueTags">REST API Reference for ListQueueTags Operation</seealso>
        public virtual Task<ListQueueTagsResponse> ListQueueTagsAsync(ListQueueTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListQueueTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListQueueTagsResponseUnmarshaller.Instance;

            return InvokeAsync<ListQueueTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurgeQueue

        internal virtual PurgeQueueResponse PurgeQueue(PurgeQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurgeQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurgeQueueResponseUnmarshaller.Instance;

            return Invoke<PurgeQueueResponse>(request, options);
        }


        /// <summary>
        /// Deletes the messages in a queue specified by the <code>QueueURL</code> parameter.
        /// 
        ///  <important> 
        /// <para>
        /// When you use the <code>PurgeQueue</code> action, you can't retrieve any messages deleted
        /// from a queue.
        /// </para>
        ///  
        /// <para>
        /// The message deletion process takes up to 60 seconds. We recommend waiting for 60 seconds
        /// regardless of your queue's size. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Messages sent to the queue <i>before</i> you call <code>PurgeQueue</code> might be
        /// received but are deleted within the next minute.
        /// </para>
        ///  
        /// <para>
        /// Messages sent to the queue <i>after</i> you call <code>PurgeQueue</code> might be
        /// deleted while the queue is being purged.
        /// </para>
        /// </summary>
        /// <param name="queueUrl">The URL of the queue from which the <code>PurgeQueue</code> action deletes messages. Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurgeQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.PurgeQueueInProgressException">
        /// Indicates that the specified queue previously received a <code>PurgeQueue</code> request
        /// within the last 60 seconds (the time it can take to delete the messages in the queue).
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// The specified queue doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/PurgeQueue">REST API Reference for PurgeQueue Operation</seealso>
        public virtual Task<PurgeQueueResponse> PurgeQueueAsync(string queueUrl, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new PurgeQueueRequest();
            request.QueueUrl = queueUrl;
            return PurgeQueueAsync(request, cancellationToken);
        }



        /// <summary>
        /// Deletes the messages in a queue specified by the <code>QueueURL</code> parameter.
        /// 
        ///  <important> 
        /// <para>
        /// When you use the <code>PurgeQueue</code> action, you can't retrieve any messages deleted
        /// from a queue.
        /// </para>
        ///  
        /// <para>
        /// The message deletion process takes up to 60 seconds. We recommend waiting for 60 seconds
        /// regardless of your queue's size. 
        /// </para>
        ///  </important> 
        /// <para>
        /// Messages sent to the queue <i>before</i> you call <code>PurgeQueue</code> might be
        /// received but are deleted within the next minute.
        /// </para>
        ///  
        /// <para>
        /// Messages sent to the queue <i>after</i> you call <code>PurgeQueue</code> might be
        /// deleted while the queue is being purged.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurgeQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PurgeQueue service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.PurgeQueueInProgressException">
        /// Indicates that the specified queue previously received a <code>PurgeQueue</code> request
        /// within the last 60 seconds (the time it can take to delete the messages in the queue).
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.QueueDoesNotExistException">
        /// The specified queue doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/PurgeQueue">REST API Reference for PurgeQueue Operation</seealso>
        public virtual Task<PurgeQueueResponse> PurgeQueueAsync(PurgeQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurgeQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurgeQueueResponseUnmarshaller.Instance;

            return InvokeAsync<PurgeQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReceiveMessage

        internal virtual ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReceiveMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReceiveMessageResponseUnmarshaller.Instance;

            return Invoke<ReceiveMessageResponse>(request, options);
        }


        /// <summary>
        /// Retrieves one or more messages (up to 10), from the specified queue. Using the <code>WaitTimeSeconds</code>
        /// parameter enables long-poll support. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-long-polling.html">Amazon
        /// SQS Long Polling</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// 
        ///  
        /// <para>
        /// Short poll is the default behavior where a weighted random set of machines is sampled
        /// on a <code>ReceiveMessage</code> call. Thus, only the messages on the sampled machines
        /// are returned. If the number of messages in the queue is small (fewer than 1,000),
        /// you most likely get fewer messages than you requested per <code>ReceiveMessage</code>
        /// call. If the number of messages in the queue is extremely small, you might not receive
        /// any messages in a particular <code>ReceiveMessage</code> response. If this happens,
        /// repeat the request. 
        /// </para>
        ///  
        /// <para>
        /// For each message returned, the response includes the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The message body.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An MD5 digest of the message body. For information about MD5, see <a href="https://www.ietf.org/rfc/rfc1321.txt">RFC1321</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>MessageId</code> you received when you sent the message to the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The receipt handle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An MD5 digest of the message attributes.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The receipt handle is the identifier you must provide when deleting the message. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-message-identifiers.html">Queue
        /// and Message Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can provide the <code>VisibilityTimeout</code> parameter in your request. The
        /// parameter is applied to the messages that Amazon SQS returns in the response. If you
        /// don't include the parameter, the overall visibility timeout for the queue is used
        /// for the returned messages. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A message that isn't deleted or a message whose visibility isn't extended before the
        /// visibility timeout expires counts as a failed receive. Depending on the configuration
        /// of the queue, the message might be sent to the dead-letter queue.
        /// </para>
        ///  <note> 
        /// <para>
        /// In the future, new attributes might be added. If you write code that calls this action,
        /// we recommend that you structure your code so that it can handle new attributes gracefully.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which messages are received. Queue URLs and names are case-sensitive.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReceiveMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.OverLimitException">
        /// The specified action violates a limit. For example, <code>ReceiveMessage</code> returns
        /// this error if the maximum number of in flight messages is reached and <code>AddPermission</code>
        /// returns this error if the maximum number of permissions for the queue is reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ReceiveMessage">REST API Reference for ReceiveMessage Operation</seealso>
        public virtual Task<ReceiveMessageResponse> ReceiveMessageAsync(string queueUrl, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new ReceiveMessageRequest();
            request.QueueUrl = queueUrl;
            return ReceiveMessageAsync(request, cancellationToken);
        }



        /// <summary>
        /// Retrieves one or more messages (up to 10), from the specified queue. Using the <code>WaitTimeSeconds</code>
        /// parameter enables long-poll support. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-long-polling.html">Amazon
        /// SQS Long Polling</a> in the <i>Amazon SQS Developer Guide</i>. 
        /// 
        ///  
        /// <para>
        /// Short poll is the default behavior where a weighted random set of machines is sampled
        /// on a <code>ReceiveMessage</code> call. Thus, only the messages on the sampled machines
        /// are returned. If the number of messages in the queue is small (fewer than 1,000),
        /// you most likely get fewer messages than you requested per <code>ReceiveMessage</code>
        /// call. If the number of messages in the queue is extremely small, you might not receive
        /// any messages in a particular <code>ReceiveMessage</code> response. If this happens,
        /// repeat the request. 
        /// </para>
        ///  
        /// <para>
        /// For each message returned, the response includes the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The message body.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An MD5 digest of the message body. For information about MD5, see <a href="https://www.ietf.org/rfc/rfc1321.txt">RFC1321</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>MessageId</code> you received when you sent the message to the queue.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The receipt handle.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The message attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An MD5 digest of the message attributes.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The receipt handle is the identifier you must provide when deleting the message. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-message-identifiers.html">Queue
        /// and Message Identifiers</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can provide the <code>VisibilityTimeout</code> parameter in your request. The
        /// parameter is applied to the messages that Amazon SQS returns in the response. If you
        /// don't include the parameter, the overall visibility timeout for the queue is used
        /// for the returned messages. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility
        /// Timeout</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// A message that isn't deleted or a message whose visibility isn't extended before the
        /// visibility timeout expires counts as a failed receive. Depending on the configuration
        /// of the queue, the message might be sent to the dead-letter queue.
        /// </para>
        ///  <note> 
        /// <para>
        /// In the future, new attributes might be added. If you write code that calls this action,
        /// we recommend that you structure your code so that it can handle new attributes gracefully.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReceiveMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReceiveMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.OverLimitException">
        /// The specified action violates a limit. For example, <code>ReceiveMessage</code> returns
        /// this error if the maximum number of in flight messages is reached and <code>AddPermission</code>
        /// returns this error if the maximum number of permissions for the queue is reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/ReceiveMessage">REST API Reference for ReceiveMessage Operation</seealso>
        public virtual Task<ReceiveMessageResponse> ReceiveMessageAsync(ReceiveMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReceiveMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReceiveMessageResponseUnmarshaller.Instance;

            return InvokeAsync<ReceiveMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemovePermission

        internal virtual RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return Invoke<RemovePermissionResponse>(request, options);
        }


        /// <summary>
        /// Revokes any permissions in the queue policy that matches the specified <code>Label</code>
        /// parameter.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// Only the owner of a queue can remove permissions from it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetQueueAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue from which permissions are removed. Queue URLs and names are case-sensitive.</param>
        /// <param name="label">The identification of the permission to remove. This is the label added using the <code> <a>AddPermission</a> </code> action.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SQS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual Task<RemovePermissionResponse> RemovePermissionAsync(string queueUrl, string label, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new RemovePermissionRequest();
            request.QueueUrl = queueUrl;
            request.Label = label;
            return RemovePermissionAsync(request, cancellationToken);
        }



        /// <summary>
        /// Revokes any permissions in the queue policy that matches the specified <code>Label</code>
        /// parameter.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// Only the owner of a queue can remove permissions from it.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetQueueAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemovePermission service method, as returned by SQS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/RemovePermission">REST API Reference for RemovePermission Operation</seealso>
        public virtual Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemovePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemovePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<RemovePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendMessage

        internal virtual SendMessageResponse SendMessage(SendMessageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return Invoke<SendMessageResponse>(request, options);
        }


        /// <summary>
        /// Delivers a message to the specified queue.
        /// 
        ///  <important> 
        /// <para>
        /// A message can include only XML, JSON, and unformatted text. The following Unicode
        /// characters are allowed:
        /// </para>
        ///  
        /// <para>
        ///  <code>#x9</code> | <code>#xA</code> | <code>#xD</code> | <code>#x20</code> to <code>#xD7FF</code>
        /// | <code>#xE000</code> to <code>#xFFFD</code> | <code>#x10000</code> to <code>#x10FFFF</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Any characters not included in this list will be rejected. For more information, see
        /// the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C specification for characters</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to which a message is sent. Queue URLs and names are case-sensitive.</param>
        /// <param name="messageBody">The message to send. The minimum size is one character. The maximum size is 256 KiB. <important> A message can include only XML, JSON, and unformatted text. The following Unicode characters are allowed:  <code>#x9</code> | <code>#xA</code> | <code>#xD</code> | <code>#x20</code> to <code>#xD7FF</code> | <code>#xE000</code> to <code>#xFFFD</code> | <code>#x10000</code> to <code>#x10FFFF</code>  Any characters not included in this list will be rejected. For more information, see the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C specification for characters</a>. </important></param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidMessageContentsException">
        /// The message contains characters outside the allowed set.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual Task<SendMessageResponse> SendMessageAsync(string queueUrl, string messageBody, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SendMessageRequest();
            request.QueueUrl = queueUrl;
            request.MessageBody = messageBody;
            return SendMessageAsync(request, cancellationToken);
        }



        /// <summary>
        /// Delivers a message to the specified queue.
        /// 
        ///  <important> 
        /// <para>
        /// A message can include only XML, JSON, and unformatted text. The following Unicode
        /// characters are allowed:
        /// </para>
        ///  
        /// <para>
        ///  <code>#x9</code> | <code>#xA</code> | <code>#xD</code> | <code>#x20</code> to <code>#xD7FF</code>
        /// | <code>#xE000</code> to <code>#xFFFD</code> | <code>#x10000</code> to <code>#x10FFFF</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Any characters not included in this list will be rejected. For more information, see
        /// the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C specification for characters</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidMessageContentsException">
        /// The message contains characters outside the allowed set.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SendMessage">REST API Reference for SendMessage Operation</seealso>
        public virtual Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendMessageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SendMessageBatch

        internal virtual SendMessageBatchResponse SendMessageBatch(SendMessageBatchRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessageBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageBatchResponseUnmarshaller.Instance;

            return Invoke<SendMessageBatchResponse>(request, options);
        }


        /// <summary>
        /// You can use <code>SendMessageBatch</code> to send up to 10 messages to the specified
        /// queue by assigning either identical or different values to each message (or by not
        /// assigning values at all). This is a batch version of <code> <a>SendMessage</a>.</code>
        /// For a FIFO queue, multiple messages within a single batch are enqueued in the order
        /// they are sent.
        /// 
        ///  
        /// <para>
        /// The result of sending each message is reported individually in the response. Because
        /// the batch request can result in a combination of successful and unsuccessful actions,
        /// you should check for batch errors even when the call returns an HTTP status code of
        /// <code>200</code>.
        /// </para>
        ///  
        /// <para>
        /// The maximum allowed individual message size and the maximum total payload size (the
        /// sum of the individual lengths of all of the batched messages) are both 256 KiB (262,144
        /// bytes).
        /// </para>
        ///  <important> 
        /// <para>
        /// A message can include only XML, JSON, and unformatted text. The following Unicode
        /// characters are allowed:
        /// </para>
        ///  
        /// <para>
        ///  <code>#x9</code> | <code>#xA</code> | <code>#xD</code> | <code>#x20</code> to <code>#xD7FF</code>
        /// | <code>#xE000</code> to <code>#xFFFD</code> | <code>#x10000</code> to <code>#x10FFFF</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Any characters not included in this list will be rejected. For more information, see
        /// the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C specification for characters</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you don't specify the <code>DelaySeconds</code> parameter for an entry, Amazon
        /// SQS uses the default value for the queue.
        /// </para>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue to which batched messages are sent. Queue URLs and names are case-sensitive.</param>
        /// <param name="entries">A list of <code> <a>SendMessageBatchRequestEntry</a> </code> items.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <code>Id</code>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.BatchRequestTooLongException">
        /// The length of all the messages put together is more than the limit.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SendMessageBatch">REST API Reference for SendMessageBatch Operation</seealso>
        public virtual Task<SendMessageBatchResponse> SendMessageBatchAsync(string queueUrl, List<SendMessageBatchRequestEntry> entries, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SendMessageBatchRequest();
            request.QueueUrl = queueUrl;
            request.Entries = entries;
            return SendMessageBatchAsync(request, cancellationToken);
        }



        /// <summary>
        /// You can use <code>SendMessageBatch</code> to send up to 10 messages to the specified
        /// queue by assigning either identical or different values to each message (or by not
        /// assigning values at all). This is a batch version of <code> <a>SendMessage</a>.</code>
        /// For a FIFO queue, multiple messages within a single batch are enqueued in the order
        /// they are sent.
        /// 
        ///  
        /// <para>
        /// The result of sending each message is reported individually in the response. Because
        /// the batch request can result in a combination of successful and unsuccessful actions,
        /// you should check for batch errors even when the call returns an HTTP status code of
        /// <code>200</code>.
        /// </para>
        ///  
        /// <para>
        /// The maximum allowed individual message size and the maximum total payload size (the
        /// sum of the individual lengths of all of the batched messages) are both 256 KiB (262,144
        /// bytes).
        /// </para>
        ///  <important> 
        /// <para>
        /// A message can include only XML, JSON, and unformatted text. The following Unicode
        /// characters are allowed:
        /// </para>
        ///  
        /// <para>
        ///  <code>#x9</code> | <code>#xA</code> | <code>#xD</code> | <code>#x20</code> to <code>#xD7FF</code>
        /// | <code>#xE000</code> to <code>#xFFFD</code> | <code>#x10000</code> to <code>#x10FFFF</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// Any characters not included in this list will be rejected. For more information, see
        /// the <a href="http://www.w3.org/TR/REC-xml/#charsets">W3C specification for characters</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you don't specify the <code>DelaySeconds</code> parameter for an entry, Amazon
        /// SQS uses the default value for the queue.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMessageBatch service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMessageBatch service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.BatchEntryIdsNotDistinctException">
        /// Two or more batch entries in the request have the same <code>Id</code>.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.BatchRequestTooLongException">
        /// The length of all the messages put together is more than the limit.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.EmptyBatchRequestException">
        /// The batch request doesn't contain any entries.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.InvalidBatchEntryIdException">
        /// The <code>Id</code> of a batch entry in a batch request doesn't abide by the specification.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.TooManyEntriesInBatchRequestException">
        /// The batch request contains more entries than permissible.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SendMessageBatch">REST API Reference for SendMessageBatch Operation</seealso>
        public virtual Task<SendMessageBatchResponse> SendMessageBatchAsync(SendMessageBatchRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SendMessageBatchRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMessageBatchResponseUnmarshaller.Instance;

            return InvokeAsync<SendMessageBatchResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetQueueAttributes

        internal virtual SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetQueueAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetQueueAttributesResponseUnmarshaller.Instance;

            return Invoke<SetQueueAttributesResponse>(request, options);
        }


        /// <summary>
        /// Sets the value of one or more queue attributes. When you change a queue's attributes,
        /// the change can take up to 60 seconds for most of the attributes to propagate throughout
        /// the Amazon SQS system. Changes made to the <code>MessageRetentionPeriod</code> attribute
        /// can take up to 15 minutes and will impact existing messages in the queue potentially
        /// causing them to be expired and deleted if the <code>MessageRetentionPeriod</code>
        /// is reduced below the age of existing messages.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// In the future, new attributes might be added. If you write code that calls this action,
        /// we recommend that you structure your code so that it can handle new attributes gracefully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetQueueAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="queueUrl">The URL of the Amazon SQS queue whose attributes are set. Queue URLs and names are case-sensitive.</param>
        /// <param name="attributes">A map of attributes to set. The following lists the names, descriptions, and values of the special request parameters that the <code>SetQueueAttributes</code> action uses: <ul> <li>  <code>DelaySeconds</code> – The length of time, in seconds, for which the delivery of all messages in the queue is delayed. Valid values: An integer from 0 to 900 (15 minutes). Default: 0.  </li> <li>  <code>MaximumMessageSize</code> – The limit of how many bytes a message can contain before Amazon SQS rejects it. Valid values: An integer from 1,024 bytes (1 KiB) up to 262,144 bytes (256 KiB). Default: 262,144 (256 KiB).  </li> <li>  <code>MessageRetentionPeriod</code> – The length of time, in seconds, for which Amazon SQS retains a message. Valid values: An integer representing seconds, from 60 (1 minute) to 1,209,600 (14 days). Default: 345,600 (4 days). When you change a queue's attributes, the change can take up to 60 seconds for most of the attributes to propagate throughout the Amazon SQS system. Changes made to the <code>MessageRetentionPeriod</code> attribute can take up to 15 minutes and will impact existing messages in the queue potentially causing them to be expired and deleted if the <code>MessageRetentionPeriod</code> is reduced below the age of existing messages. </li> <li>  <code>Policy</code> – The queue's policy. A valid Amazon Web Services policy. For more information about policy structure, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/PoliciesOverview.html">Overview of Amazon Web Services IAM Policies</a> in the <i>Identity and Access Management User Guide</i>.  </li> <li>  <code>ReceiveMessageWaitTimeSeconds</code> – The length of time, in seconds, for which a <code> <a>ReceiveMessage</a> </code> action waits for a message to arrive. Valid values: An integer from 0 to 20 (seconds). Default: 0.  </li> <li>  <code>VisibilityTimeout</code> – The visibility timeout for the queue, in seconds. Valid values: An integer from 0 to 43,200 (12 hours). Default: 30. For more information about the visibility timeout, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-visibility-timeout.html">Visibility Timeout</a> in the <i>Amazon SQS Developer Guide</i>. </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-dead-letter-queues.html">dead-letter queues:</a>  <ul> <li>  <code>RedrivePolicy</code> – The string that includes the parameters for the dead-letter queue functionality of the source queue as a JSON object. The parameters are as follows: <ul> <li>  <code>deadLetterTargetArn</code> – The Amazon Resource Name (ARN) of the dead-letter queue to which Amazon SQS moves messages after the value of <code>maxReceiveCount</code> is exceeded. </li> <li>  <code>maxReceiveCount</code> – The number of times a message is delivered to the source queue before being moved to the dead-letter queue. Default: 10. When the <code>ReceiveCount</code> for a message exceeds the <code>maxReceiveCount</code> for a queue, Amazon SQS moves the message to the dead-letter-queue. </li> </ul> </li> <li>  <code>RedriveAllowPolicy</code> – The string that includes the parameters for the permissions for the dead-letter queue redrive permission and which source queues can specify dead-letter queues as a JSON object. The parameters are as follows: <ul> <li>  <code>redrivePermission</code> – The permission type that defines which source queues can specify the current queue as the dead-letter queue. Valid values are: <ul> <li>  <code>allowAll</code> – (Default) Any source queues in this Amazon Web Services account in the same Region can specify this queue as the dead-letter queue. </li> <li>  <code>denyAll</code> – No source queues can specify this queue as the dead-letter queue. </li> <li>  <code>byQueue</code> – Only queues specified by the <code>sourceQueueArns</code> parameter can specify this queue as the dead-letter queue. </li> </ul> </li> <li>  <code>sourceQueueArns</code> – The Amazon Resource Names (ARN)s of the source queues that can specify this queue as the dead-letter queue and redrive messages. You can specify this parameter only when the <code>redrivePermission</code> parameter is set to <code>byQueue</code>. You can specify up to 10 source queue ARNs. To allow more than 10 source queues to specify dead-letter queues, set the <code>redrivePermission</code> parameter to <code>allowAll</code>. </li> </ul> </li> </ul> <note> The dead-letter queue of a FIFO queue must also be a FIFO queue. Similarly, the dead-letter queue of a standard queue must also be a standard queue. </note> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html">server-side-encryption</a>: <ul> <li>  <code>KmsMasterKeyId</code> – The ID of an Amazon Web Services managed customer master key (CMK) for Amazon SQS or a custom CMK. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-sse-key-terms">Key Terms</a>. While the alias of the AWS-managed CMK for Amazon SQS is always <code>alias/aws/sqs</code>, the alias of a custom CMK can, for example, be <code>alias/<i>MyAlias</i> </code>. For more examples, see <a href="https://docs.aws.amazon.com/kms/latest/APIReference/API_DescribeKey.html#API_DescribeKey_RequestParameters">KeyId</a> in the <i>Key Management Service API Reference</i>.  </li> <li>  <code>KmsDataKeyReusePeriodSeconds</code> – The length of time, in seconds, for which Amazon SQS can reuse a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#data-keys">data key</a> to encrypt or decrypt messages before calling KMS again. An integer representing seconds, between 60 seconds (1 minute) and 86,400 seconds (24 hours). Default: 300 (5 minutes). A shorter time period provides better security but results in more calls to KMS which might incur charges after Free Tier. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-server-side-encryption.html#sqs-how-does-the-data-key-reuse-period-work">How Does the Data Key Reuse Period Work?</a>.  </li> <li>  <code>SqsManagedSseEnabled</code> – Enables server-side queue encryption using SQS owned encryption keys. Only one server-side encryption option is supported per queue (for example, <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sse-existing-queue.html">SSE-KMS</a> or <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-configure-sqs-sse-queue.html">SSE-SQS</a>). </li> </ul> The following attribute applies only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues.html">FIFO (first-in-first-out) queues</a>: <ul> <li>  <code>ContentBasedDeduplication</code> – Enables content-based deduplication. For more information, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/FIFO-queues-exactly-once-processing.html">Exactly-once processing</a> in the <i>Amazon SQS Developer Guide</i>. Note the following:  <ul> <li> Every message must have a unique <code>MessageDeduplicationId</code>. <ul> <li> You may provide a <code>MessageDeduplicationId</code> explicitly. </li> <li> If you aren't able to provide a <code>MessageDeduplicationId</code> and you enable <code>ContentBasedDeduplication</code> for your queue, Amazon SQS uses a SHA-256 hash to generate the <code>MessageDeduplicationId</code> using the body of the message (but not the attributes of the message).  </li> <li> If you don't provide a <code>MessageDeduplicationId</code> and the queue doesn't have <code>ContentBasedDeduplication</code> set, the action fails with an error. </li> <li> If the queue has <code>ContentBasedDeduplication</code> set, your <code>MessageDeduplicationId</code> overrides the generated one. </li> </ul> </li> <li> When <code>ContentBasedDeduplication</code> is in effect, messages with identical content sent within the deduplication interval are treated as duplicates and only one copy of the message is delivered. </li> <li> If you send one message with <code>ContentBasedDeduplication</code> enabled and then another message with a <code>MessageDeduplicationId</code> that is the same as the one generated for the first <code>MessageDeduplicationId</code>, the two messages are treated as duplicates and only one copy of the message is delivered.  </li> </ul> </li> </ul> The following attributes apply only to <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/high-throughput-fifo.html">high throughput for FIFO queues</a>: <ul> <li>  <code>DeduplicationScope</code> – Specifies whether message deduplication occurs at the message group or queue level. Valid values are <code>messageGroup</code> and <code>queue</code>. </li> <li>  <code>FifoThroughputLimit</code> – Specifies whether the FIFO queue throughput quota applies to the entire queue or per message group. Valid values are <code>perQueue</code> and <code>perMessageGroupId</code>. The <code>perMessageGroupId</code> value is allowed only when the value for <code>DeduplicationScope</code> is <code>messageGroup</code>. </li> </ul> To enable high throughput for FIFO queues, do the following: <ul> <li> Set <code>DeduplicationScope</code> to <code>messageGroup</code>. </li> <li> Set <code>FifoThroughputLimit</code> to <code>perMessageGroupId</code>. </li> </ul> If you set these attributes to anything other than the values shown for enabling high throughput, normal throughput is in effect and deduplication occurs as specified. For information on throughput quotas, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/quotas-messages.html">Quotas related to messages</a> in the <i>Amazon SQS Developer Guide</i>.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeNameException">
        /// The specified attribute doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SetQueueAttributes">REST API Reference for SetQueueAttributes Operation</seealso>
        public virtual Task<SetQueueAttributesResponse> SetQueueAttributesAsync(string queueUrl, Dictionary<string, string> attributes, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var request = new SetQueueAttributesRequest();
            request.QueueUrl = queueUrl;
            request.Attributes = attributes;
            return SetQueueAttributesAsync(request, cancellationToken);
        }



        /// <summary>
        /// Sets the value of one or more queue attributes. When you change a queue's attributes,
        /// the change can take up to 60 seconds for most of the attributes to propagate throughout
        /// the Amazon SQS system. Changes made to the <code>MessageRetentionPeriod</code> attribute
        /// can take up to 15 minutes and will impact existing messages in the queue potentially
        /// causing them to be expired and deleted if the <code>MessageRetentionPeriod</code>
        /// is reduced below the age of existing messages.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// In the future, new attributes might be added. If you write code that calls this action,
        /// we recommend that you structure your code so that it can handle new attributes gracefully.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To remove the ability to change queue permissions, you must deny permission to the
        /// <code>AddPermission</code>, <code>RemovePermission</code>, and <code>SetQueueAttributes</code>
        /// actions in your IAM policy.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetQueueAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetQueueAttributes service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.InvalidAttributeNameException">
        /// The specified attribute doesn't exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/SetQueueAttributes">REST API Reference for SetQueueAttributes Operation</seealso>
        public virtual Task<SetQueueAttributesResponse> SetQueueAttributesAsync(SetQueueAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetQueueAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetQueueAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<SetQueueAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartMessageMoveTask

        internal virtual StartMessageMoveTaskResponse StartMessageMoveTask(StartMessageMoveTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMessageMoveTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMessageMoveTaskResponseUnmarshaller.Instance;

            return Invoke<StartMessageMoveTaskResponse>(request, options);
        }



        /// <summary>
        /// Starts an asynchronous task to move messages from a specified source queue to a specified
        /// destination queue.
        /// 
        ///  <note> <ul> <li> 
        /// <para>
        /// This action is currently limited to supporting message redrive from dead-letter queues
        /// (DLQs) only. In this context, the source queue is the dead-letter queue (DLQ), while
        /// the destination queue can be the original source queue (from which the messages were
        /// driven to the dead-letter-queue), or a custom destination queue. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Currently, only standard queues are supported.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Only one active message movement task is supported per queue at any given time.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartMessageMoveTask service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartMessageMoveTask service method, as returned by SQS.</returns>
        /// <exception cref="Amazon.SQS.Model.ResourceNotFoundException">
        /// One or more specified resources don't exist.
        /// </exception>
        /// <exception cref="Amazon.SQS.Model.UnsupportedOperationException">
        /// Error code 400. Unsupported operation.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/StartMessageMoveTask">REST API Reference for StartMessageMoveTask Operation</seealso>
        public virtual Task<StartMessageMoveTaskResponse> StartMessageMoveTaskAsync(StartMessageMoveTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartMessageMoveTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartMessageMoveTaskResponseUnmarshaller.Instance;

            return InvokeAsync<StartMessageMoveTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagQueue

        internal virtual TagQueueResponse TagQueue(TagQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagQueueResponseUnmarshaller.Instance;

            return Invoke<TagQueueResponse>(request, options);
        }



        /// <summary>
        /// Add cost allocation tags to the specified Amazon SQS queue. For an overview, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-tags.html">Tagging
        /// Your Amazon SQS Queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// When you use queue tags, keep the following guidelines in mind:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Adding more than 50 tags to a queue isn't recommended.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags don't have any semantic meaning. Amazon SQS interprets tags as character strings.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tags are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A new tag with a key identical to that of an existing tag overwrites the existing
        /// tag.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For a full list of tag restrictions, see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-limits.html#limits-queues">Quotas
        /// related to queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagQueue service method, as returned by SQS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/TagQueue">REST API Reference for TagQueue Operation</seealso>
        public virtual Task<TagQueueResponse> TagQueueAsync(TagQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagQueueResponseUnmarshaller.Instance;

            return InvokeAsync<TagQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagQueue

        internal virtual UntagQueueResponse UntagQueue(UntagQueueRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagQueueResponseUnmarshaller.Instance;

            return Invoke<UntagQueueResponse>(request, options);
        }



        /// <summary>
        /// Remove cost allocation tags from the specified Amazon SQS queue. For an overview,
        /// see <a href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-queue-tags.html">Tagging
        /// Your Amazon SQS Queues</a> in the <i>Amazon SQS Developer Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// Cross-account permissions don't apply to this action. For more information, see <a
        /// href="https://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-customer-managed-policy-examples.html#grant-cross-account-permissions-to-role-and-user-name">Grant
        /// cross-account permissions to a role and a username</a> in the <i>Amazon SQS Developer
        /// Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagQueue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagQueue service method, as returned by SQS.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/sqs-2012-11-05/UntagQueue">REST API Reference for UntagQueue Operation</seealso>
        public virtual Task<UntagQueueResponse> UntagQueueAsync(UntagQueueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagQueueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagQueueResponseUnmarshaller.Instance;

            return InvokeAsync<UntagQueueResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}