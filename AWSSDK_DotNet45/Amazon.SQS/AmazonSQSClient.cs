/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.SQS.Model;
using Amazon.SQS.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.SQS
{
    /// <summary>
    /// Implementation for accessing AmazonSQS.
    /// 
    /// Amazon Simple Queue Service <para>Welcome to the <i>Amazon Simple Queue Service API Reference</i> . This section describes who should read
    /// this guide, how the guide is organized, and other resources related to the Amazon Simple Queue Service (Amazon SQS).</para> <para>Amazon SQS
    /// offers reliable and scalable hosted queues for storing messages as they travel between computers. By using Amazon SQS, you can move data
    /// between distributed components of your applications that perform different tasks without losing messages or requiring each component to be
    /// always available.</para> <para>Helpful Links:
    /// <ul>
    /// <li> <a href="http://queue.amazonaws.com/doc/2012-11-05/QueueService.wsdl">Current WSDL (2012-11-05)</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/MakingRequestsArticle.html">Making API
    /// Requests</a> </li>
    /// <li> <a href="http://aws.amazon.com/sqs/">Amazon SQS product page</a> </li>
    /// <li> <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#sqs_region">Regions and Endpoints</a> </li>
    /// 
    /// </ul>
    /// </para> <para>We also provide SDKs that enable you to access Amazon SQS from your preferred programming language. The SDKs contain
    /// functionality that automatically takes care of tasks such as:</para> <para>
    /// <ul>
    /// <li>Cryptographically signing your service requests</li>
    /// <li>Retrying requests</li>
    /// <li>Handling error responses</li>
    /// 
    /// </ul>
    /// </para> <para>For a list of available SDKs, go to <a href="http://aws.amazon.com/tools/">Tools for Amazon Web Services</a> .</para>
    /// </summary>
	public partial class AmazonSQSClient : AmazonWebServiceClient, Amazon.SQS.IAmazonSQS
    {

        AWS4Signer signer = new AWS4Signer();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSQSClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSQSConfig(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSQSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSQSClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSQSConfig(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonSQSClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSQS Configuration Object</param>
        public AmazonSQSClient(AmazonSQSConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : this(credentials, new AmazonSQSConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Credentials and an
        /// AmazonSQSClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(AWSCredentials credentials, AmazonSQSConfig clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
        /// AmazonSQSClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSQSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSQSConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQSClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSQSClient Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSQSConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
        /// <summary>
        /// <para>Adds a permission to a queue for a specific <a href="http://docs.aws.amazon.com/general/latest/gr/glos-chap.html#P">principal</a> .
        /// This allows for sharing access to the queue.</para> <para>When you create a queue, you have full control access rights for the queue.
        /// Only you (as owner of the queue) can grant or deny permissions to the queue. For more information about these permissions, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html">Shared Queues</a> in the <i>Amazon SQS
        /// Developer Guide</i> .</para> <para><b>NOTE:</b> AddPermission writes an Amazon SQS-generated policy. If you want to write your own policy,
        /// use SetQueueAttributes to upload your policy. For more information about writing your own policy, see Using The Access Policy Language in
        /// the Amazon SQS Developer Guide. </para> <para><b>NOTE:</b>Some API actions take lists of parameters. These lists are specified using the
        /// param.n notation. Values of n are integers starting from 1. For example, a parameter list with two elements looks like this: </para> <para>
        /// <c>&amp;amp;Attribute.1=this</c> </para> <para> <c>&amp;amp;Attribute.2=that</c> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission service method on AmazonSQS.</param>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.OverLimitException" />
		public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            var task = AddPermissionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.AddPermission"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddPermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AddPermissionResponse> AddPermissionAsync(AddPermissionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddPermissionRequestMarshaller();
            var unmarshaller = AddPermissionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AddPermissionRequest, AddPermissionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Changes the visibility timeout of a specified message in a queue to a new value. The maximum allowed timeout value you can set the
        /// value to is 12 hours. This means you can't extend the timeout of a message in an existing queue to more than a total visibility timeout of
        /// 12 hours. (For more information visibility timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility Timeout</a> in the <i>Amazon SQS
        /// Developer Guide</i> .)</para> <para>For example, let's say you have a message and its default message visibility timeout is 30 minutes. You
        /// could call <c>ChangeMessageVisiblity</c> with a value of two hours and the effective timeout would be two hours and 30 minutes. When that
        /// time comes near you could again extend the time out by calling ChangeMessageVisiblity, but this time the maximum allowed timeout would be 9
        /// hours and 30 minutes.</para> <para><b>IMPORTANT:</b>If you attempt to set the VisibilityTimeout to an amount more than the maximum time
        /// left, Amazon SQS returns an error. It will not automatically recalculate and increase the timeout to the maximum time remaining.</para>
        /// <para><b>IMPORTANT:</b>Unlike with a queue, when you change the visibility timeout for a specific message, that timeout value is applied
        /// immediately but is not saved in memory for that message. If you don't delete a message after it is received, the visibility timeout for the
        /// message the next time it is received reverts to the original timeout value, not the value you set with the ChangeMessageVisibility
        /// action.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibility service method on
        /// AmazonSQS.</param>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.ReceiptHandleIsInvalidException" />
        /// <exception cref="T:Amazon.SQS.Model.MessageNotInflightException" />
		public ChangeMessageVisibilityResponse ChangeMessageVisibility(ChangeMessageVisibilityRequest request)
        {
            var task = ChangeMessageVisibilityAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ChangeMessageVisibility operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ChangeMessageVisibility"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibility operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ChangeMessageVisibilityResponse> ChangeMessageVisibilityAsync(ChangeMessageVisibilityRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeMessageVisibilityRequestMarshaller();
            var unmarshaller = ChangeMessageVisibilityResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ChangeMessageVisibilityRequest, ChangeMessageVisibilityResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Changes the visibility timeout of multiple messages. This is a batch version of ChangeMessageVisibility. The result of the action on
        /// each message is reported individually in the response. You can send up to 10 ChangeMessageVisibility requests with each
        /// <c>ChangeMessageVisibilityBatch</c> action.</para> <para><b>IMPORTANT:</b>Because the batch request can result in a combination of
        /// successful and unsuccessful actions, you should check for batch errors even when the call returns an HTTP status code of 200.</para>
        /// <para><b>NOTE:</b>Some API actions take lists of parameters. These lists are specified using the param.n notation. Values of n are integers
        /// starting from 1. For example, a parameter list with two elements looks like this: </para> <para> <c>&amp;amp;Attribute.1=this</c> </para>
        /// <para> <c>&amp;amp;Attribute.2=that</c> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch service
        /// method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the ChangeMessageVisibilityBatch service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.BatchEntryIdsNotDistinctException" />
        /// <exception cref="T:Amazon.SQS.Model.TooManyEntriesInBatchRequestException" />
        /// <exception cref="T:Amazon.SQS.Model.InvalidBatchEntryIdException" />
        /// <exception cref="T:Amazon.SQS.Model.EmptyBatchRequestException" />
		public ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request)
        {
            var task = ChangeMessageVisibilityBatchAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ChangeMessageVisibilityBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ChangeMessageVisibilityBatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ChangeMessageVisibilityBatchResponse> ChangeMessageVisibilityBatchAsync(ChangeMessageVisibilityBatchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ChangeMessageVisibilityBatchRequestMarshaller();
            var unmarshaller = ChangeMessageVisibilityBatchResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ChangeMessageVisibilityBatchRequest, ChangeMessageVisibilityBatchResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a new queue, or returns the URL of an existing one. When you request <c>CreateQueue</c> , you provide a name for the queue. To
        /// successfully create a new queue, you must provide a name that is unique within the scope of your own queues.</para> <para><b>NOTE:</b> If
        /// you delete a queue, you must wait at least 60 seconds before creating a queue with the same name. </para> <para>You may pass one or more
        /// attributes in the request. If you do not provide a value for any attribute, the queue will have the default value for that attribute.
        /// Permitted attributes are the same that can be set using SetQueueAttributes.</para> <para><b>NOTE:</b> Use GetQueueUrl to get a queue's URL.
        /// GetQueueUrl requires only the QueueName parameter. </para> <para>If you provide the name of an existing queue, along with the exact names
        /// and values of all the queue's attributes, <c>CreateQueue</c> returns the queue URL for the existing queue. If the queue name, attribute
        /// names, or attribute values do not match an existing queue, <c>CreateQueue</c> returns an error.</para> <para><b>NOTE:</b>Some API actions
        /// take lists of parameters. These lists are specified using the param.n notation. Values of n are integers starting from 1. For example, a
        /// parameter list with two elements looks like this: </para> <para> <c>&amp;amp;Attribute.1=this</c> </para> <para>
        /// <c>&amp;amp;Attribute.2=that</c> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.QueueNameExistsException" />
        /// <exception cref="T:Amazon.SQS.Model.QueueDeletedRecentlyException" />
		public CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            var task = CreateQueueAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueue operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.CreateQueue"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateQueueResponse> CreateQueueAsync(CreateQueueRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateQueueRequestMarshaller();
            var unmarshaller = CreateQueueResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateQueueRequest, CreateQueueResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Deletes the specified message from the specified queue. You specify the message by using the message's <c>receipt handle</c> and not
        /// the <c>message ID</c> you received when you sent the message. Even if the message is locked by another reader due to the visibility timeout
        /// setting, it is still deleted from the queue. If you leave a message in the queue for longer than the queue's configured retention period,
        /// Amazon SQS automatically deletes it. </para> <para><b>NOTE:</b> The receipt handle is associated with a specific instance of receiving the
        /// message. If you receive a message more than once, the receipt handle you get each time you receive the message is different. When you
        /// request DeleteMessage, if you don't provide the most recently received receipt handle for the message, the request will still succeed, but
        /// the message might not be deleted. </para> <para><b>IMPORTANT:</b> It is possible you will receive a message even after you have deleted it.
        /// This might happen on rare occasions if one of the servers storing a copy of the message is unavailable when you request to delete the
        /// message. The copy remains on the server and might be returned to you again on a subsequent receive request. You should create your system to
        /// be idempotent so that receiving a particular message more than once is not a problem. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage service method on AmazonSQS.</param>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.ReceiptHandleIsInvalidException" />
        /// <exception cref="T:Amazon.SQS.Model.InvalidIdFormatException" />
		public DeleteMessageResponse DeleteMessage(DeleteMessageRequest request)
        {
            var task = DeleteMessageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.DeleteMessage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteMessageResponse> DeleteMessageAsync(DeleteMessageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMessageRequestMarshaller();
            var unmarshaller = DeleteMessageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteMessageRequest, DeleteMessageResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes multiple messages. This is a batch version of DeleteMessage. The result of the delete action on each message is reported
        /// individually in the response.</para> <para><b>IMPORTANT:</b> Because the batch request can result in a combination of successful and
        /// unsuccessful actions, you should check for batch errors even when the call returns an HTTP status code of 200. </para>
        /// <para><b>NOTE:</b>Some API actions take lists of parameters. These lists are specified using the param.n notation. Values of n are integers
        /// starting from 1. For example, a parameter list with two elements looks like this: </para> <para> <c>&amp;amp;Attribute.1=this</c> </para>
        /// <para> <c>&amp;amp;Attribute.2=that</c> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageBatch service method on
        /// AmazonSQS.</param>
        /// 
        /// <returns>The response from the DeleteMessageBatch service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.BatchEntryIdsNotDistinctException" />
        /// <exception cref="T:Amazon.SQS.Model.TooManyEntriesInBatchRequestException" />
        /// <exception cref="T:Amazon.SQS.Model.InvalidBatchEntryIdException" />
        /// <exception cref="T:Amazon.SQS.Model.EmptyBatchRequestException" />
		public DeleteMessageBatchResponse DeleteMessageBatch(DeleteMessageBatchRequest request)
        {
            var task = DeleteMessageBatchAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessageBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.DeleteMessageBatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMessageBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteMessageBatchResponse> DeleteMessageBatchAsync(DeleteMessageBatchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteMessageBatchRequestMarshaller();
            var unmarshaller = DeleteMessageBatchResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteMessageBatchRequest, DeleteMessageBatchResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Deletes the queue specified by the <b>queue URL</b> , regardless of whether the queue is empty. If the specified queue does not
        /// exist, Amazon SQS returns a successful response. </para> <para><b>IMPORTANT:</b> Use DeleteQueue with care; once you delete your queue, any
        /// messages in the queue are no longer available. </para> <para> When you delete a queue, the deletion process takes up to 60 seconds. Requests
        /// you send involving that queue during the 60 seconds might succeed. For example, a SendMessage request might succeed, but after the 60
        /// seconds, the queue and that message you sent no longer exist. Also, when you delete a queue, you must wait at least 60 seconds before
        /// creating a queue with the same name. </para> <para> We reserve the right to delete queues that have had no activity for more than 30 days.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSConcepts.html">How Amazon
        /// SQS Queues Work</a> in the <i>Amazon SQS Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue service method on AmazonSQS.</param>
		public DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            var task = DeleteQueueAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueue operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.DeleteQueue"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteQueue operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteQueueResponse> DeleteQueueAsync(DeleteQueueRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteQueueRequestMarshaller();
            var unmarshaller = DeleteQueueResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteQueueRequest, DeleteQueueResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Gets attributes for the specified queue. The following attributes are supported:
        /// <ul>
        /// <li> <c>All</c> - returns all values.</li>
        /// <li> <c>ApproximateNumberOfMessages</c> - returns the approximate number of visible messages in a queue. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ApproximateNumber.html">Resources Required to Process
        /// Messages</a> in the <i>Amazon SQS Developer Guide</i> .</li>
        /// <li> <c>ApproximateNumberOfMessagesNotVisible</c> - returns the approximate number of messages that are not timed-out and not deleted. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ApproximateNumber.html">Resources
        /// Required to Process Messages</a> in the <i>Amazon SQS Developer Guide</i> .</li>
        /// <li> <c>VisibilityTimeout</c> - returns the visibility timeout for the queue. For more information about visibility timeout, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility Timeout</a> in the <i>Amazon SQS
        /// Developer Guide</i> .</li>
        /// <li> <c>CreatedTimestamp</c> - returns the time when the queue was created (epoch time in seconds).</li>
        /// <li> <c>LastModifiedTimestamp</c> - returns the time when the queue was last changed (epoch time in seconds).</li>
        /// <li> <c>Policy</c> - returns the queue's policy.</li>
        /// <li> <c>MaximumMessageSize</c> - returns the limit of how many bytes a message can contain before Amazon SQS rejects it.</li>
        /// <li> <c>MessageRetentionPeriod</c> - returns the number of seconds Amazon SQS retains a message.</li>
        /// <li> <c>QueueArn</c> - returns the queue's Amazon resource name (ARN).</li>
        /// <li> <c>ApproximateNumberOfMessagesDelayed</c> - returns the approximate number of messages that are pending to be added to the queue.</li>
        /// <li> <c>DelaySeconds</c> - returns the default delay on the queue in seconds.</li>
        /// <li> <c>ReceiveMessageWaitTimeSeconds</c> - returns the time for which a ReceiveMessage call will wait for a message to arrive.</li>
        /// <li> <c>RedrivePolicy</c> - returns the parameters for dead letter queue functionality of the source queue. For more information about
        /// RedrivePolicy and dead letter queues, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/SQSDeadLetterQueue.html">Using Amazon SQS Dead Letter
        /// Queues</a> in the <i>Amazon SQS Developer Guide</i> .</li>
        /// 
        /// </ul>
        /// </para> <para><b>NOTE:</b>Going forward, new attributes might be added. If you are writing code that calls this action, we recommend that
        /// you structure your code so that it can handle new attributes gracefully.</para> <para><b>NOTE:</b>Some API actions take lists of parameters.
        /// These lists are specified using the param.n notation. Values of n are integers starting from 1. For example, a parameter list with two
        /// elements looks like this: </para> <para> <c>&amp;amp;Attribute.1=this</c> </para> <para> <c>&amp;amp;Attribute.2=that</c> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueAttributes service method on
        /// AmazonSQS.</param>
        /// 
        /// <returns>The response from the GetQueueAttributes service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.InvalidAttributeNameException" />
		public GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest request)
        {
            var task = GetQueueAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueAttributes operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.GetQueueAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<GetQueueAttributesResponse> GetQueueAttributesAsync(GetQueueAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetQueueAttributesRequestMarshaller();
            var unmarshaller = GetQueueAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetQueueAttributesRequest, GetQueueAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Returns the URL of an existing queue. This action provides a simple way to retrieve the URL of an Amazon SQS queue. </para> <para> To
        /// access a queue that belongs to another AWS account, use the <c>QueueOwnerAWSAccountId</c> parameter to specify the account ID of the queue's
        /// owner. The queue's owner must grant you permission to access the queue. For more information about shared queue access, see AddPermission or
        /// go to <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/acp-overview.html">Shared Queues</a> in the
        /// <i>Amazon SQS Developer Guide</i> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueUrl service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the GetQueueUrl service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.QueueDoesNotExistException" />
		public GetQueueUrlResponse GetQueueUrl(GetQueueUrlRequest request)
        {
            var task = GetQueueUrlAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueUrl operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.GetQueueUrl"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetQueueUrl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<GetQueueUrlResponse> GetQueueUrlAsync(GetQueueUrlRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetQueueUrlRequestMarshaller();
            var unmarshaller = GetQueueUrlResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetQueueUrlRequest, GetQueueUrlResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Returns a list of your queues that have the RedrivePolicy queue attribute configured with a dead letter queue.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeadLetterSourceQueues service
        /// method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the ListDeadLetterSourceQueues service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.QueueDoesNotExistException" />
		public ListDeadLetterSourceQueuesResponse ListDeadLetterSourceQueues(ListDeadLetterSourceQueuesRequest request)
        {
            var task = ListDeadLetterSourceQueuesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListDeadLetterSourceQueues operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ListDeadLetterSourceQueues"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListDeadLetterSourceQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ListDeadLetterSourceQueuesResponse> ListDeadLetterSourceQueuesAsync(ListDeadLetterSourceQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListDeadLetterSourceQueuesRequestMarshaller();
            var unmarshaller = ListDeadLetterSourceQueuesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListDeadLetterSourceQueuesRequest, ListDeadLetterSourceQueuesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Returns a list of your queues. The maximum number of queues that can be returned is 1000. If you specify a value for the optional
        /// <c>QueueNamePrefix</c> parameter, only queues with a name beginning with the specified value are returned.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueues service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by AmazonSQS.</returns>
		public ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            var task = ListQueuesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ListQueues operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ListQueues"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListQueues operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ListQueuesResponse> ListQueuesAsync(ListQueuesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ListQueuesRequestMarshaller();
            var unmarshaller = ListQueuesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ListQueuesRequest, ListQueuesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Returns a list of your queues. The maximum number of queues that can be returned is 1000. If you specify a value for the optional
        /// <c>QueueNamePrefix</c> parameter, only queues with a name beginning with the specified value are returned.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the ListQueues service method, as returned by AmazonSQS.</returns>
		public ListQueuesResponse ListQueues()
        {
            return this.ListQueues(new ListQueuesRequest());
        }
 
        /// <summary>
        /// <para> Retrieves one or more messages from the specified queue. Long poll support is enabled by using the <c>WaitTimeSeconds</c> parameter.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/sqs-long-polling.html">Amazon
        /// SQS Long Poll</a> in the <i>Amazon SQS Developer Guide</i> .
        /// </para> <para> Short poll is the default behavior where a weighted random set of machines is sampled on a <c>ReceiveMessage</c> call.
        /// This means only the messages on the sampled machines are returned. If the number of messages in the queue is small (less than 1000), it is
        /// likely you will get fewer messages than you requested per <c>ReceiveMessage</c> call. If the number of messages in the queue is extremely
        /// small, you might not receive any messages in a particular <c>ReceiveMessage</c> response; in which case you should repeat the request.
        /// </para> <para> For each message returned, the response includes the following: </para>
        /// <ul>
        /// <li> <para> Message body </para> </li>
        /// <li> <para> MD5 digest of the message body. For information about MD5, go to <a href="http://www.faqs.org/rfcs/rfc1321.html">http://www.faqs.org/rfcs/rfc1321.html</a> .
        /// </para> </li>
        /// <li> <para> Message ID you received when you sent the message to the queue. </para> </li>
        /// <li> <para> Receipt handle. </para> </li>
        /// 
        /// </ul>
        /// <para> The receipt handle is the identifier you must provide when deleting the message. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/ImportantIdentifiers.html">Queue and Message
        /// Identifiers</a> in the <i>Amazon SQS Developer Guide</i> .
        /// </para> <para> You can provide the <c>VisibilityTimeout</c> parameter in your request, which will be applied to the messages that Amazon
        /// SQS returns in the response. If you do not include the parameter, the overall visibility timeout for the queue is used for the returned
        /// messages. For more information, see <a href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html">Visibility Timeout</a> in the <i>Amazon SQS Developer Guide</i> .
        /// </para> <para><b>NOTE:</b> Going forward, new attributes might be added. If you are writing code that calls this action, we recommend
        /// that you structure your code so that it can handle new attributes gracefully. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReceiveMessage service method on
        /// AmazonSQS.</param>
        /// 
        /// <returns>The response from the ReceiveMessage service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.OverLimitException" />
		public ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request)
        {
            var task = ReceiveMessageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the ReceiveMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ReceiveMessage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReceiveMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ReceiveMessageResponse> ReceiveMessageAsync(ReceiveMessageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReceiveMessageRequestMarshaller();
            var unmarshaller = ReceiveMessageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReceiveMessageRequest, ReceiveMessageResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Revokes any permissions in the queue policy that matches the specified <c>Label</c> parameter. Only the owner of the queue can remove
        /// permissions.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission service method on
        /// AmazonSQS.</param>
		public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            var task = RemovePermissionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.RemovePermission"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemovePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RemovePermissionResponse> RemovePermissionAsync(RemovePermissionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemovePermissionRequestMarshaller();
            var unmarshaller = RemovePermissionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RemovePermissionRequest, RemovePermissionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para> Delivers a message to the specified queue. With Amazon SQS, you now have the ability to send large payload messages that are up to
        /// 256KB (262,144 bytes) in size. To send large payloads, you must use an AWS SDK that supports SigV4 signing. To verify whether SigV4 is
        /// supported for an AWS SDK, check the SDK release notes. </para> <para><b>IMPORTANT:</b> The following list shows the characters (in Unicode)
        /// allowed in your message, according to the W3C XML specification. For more information, go to http://www.w3.org/TR/REC-xml/#charsets If you
        /// send any characters not included in the list, your request will be rejected. #x9 | #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] |
        /// [#x10000 to #x10FFFF] </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessage service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.InvalidMessageContentsException" />
		public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            var task = SendMessageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SendMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.SendMessage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SendMessageResponse> SendMessageAsync(SendMessageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendMessageRequestMarshaller();
            var unmarshaller = SendMessageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SendMessageRequest, SendMessageResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Delivers up to ten messages to the specified queue. This is a batch version of SendMessage. The result of the send action on each
        /// message is reported individually in the response. The maximum allowed individual message size is 256 KB (262,144 bytes).</para> <para>The
        /// maximum total payload size (i.e., the sum of all a batch's individual message lengths) is also 256 KB (262,144 bytes).</para> <para>If the
        /// <c>DelaySeconds</c> parameter is not specified for an entry, the default for the queue is used.</para> <para><b>IMPORTANT:</b>The following
        /// list shows the characters (in Unicode) that are allowed in your message, according to the W3C XML specification. For more information, go to
        /// http://www.faqs.org/rfcs/rfc1321.html. If you send any characters that are not included in the list, your request will be rejected. #x9 |
        /// #xA | #xD | [#x20 to #xD7FF] | [#xE000 to #xFFFD] | [#x10000 to #x10FFFF] </para> <para><b>IMPORTANT:</b> Because the batch request can
        /// result in a combination of successful and unsuccessful actions, you should check for batch errors even when the call returns an HTTP status
        /// code of 200. </para> <para><b>NOTE:</b>Some API actions take lists of parameters. These lists are specified using the param.n notation.
        /// Values of n are integers starting from 1. For example, a parameter list with two elements looks like this: </para> <para>
        /// <c>&amp;amp;Attribute.1=this</c> </para> <para> <c>&amp;amp;Attribute.2=that</c> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessageBatch service method on
        /// AmazonSQS.</param>
        /// 
        /// <returns>The response from the SendMessageBatch service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.BatchEntryIdsNotDistinctException" />
        /// <exception cref="T:Amazon.SQS.Model.TooManyEntriesInBatchRequestException" />
        /// <exception cref="T:Amazon.SQS.Model.BatchRequestTooLongException" />
        /// <exception cref="T:Amazon.SQS.Model.InvalidBatchEntryIdException" />
        /// <exception cref="T:Amazon.SQS.Model.EmptyBatchRequestException" />
		public SendMessageBatchResponse SendMessageBatch(SendMessageBatchRequest request)
        {
            var task = SendMessageBatchAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SendMessageBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.SendMessageBatch"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendMessageBatch operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SendMessageBatchResponse> SendMessageBatchAsync(SendMessageBatchRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SendMessageBatchRequestMarshaller();
            var unmarshaller = SendMessageBatchResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SendMessageBatchRequest, SendMessageBatchResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Sets the value of one or more queue attributes.</para> <para><b>NOTE:</b>Going forward, new attributes might be added. If you are
        /// writing code that calls this action, we recommend that you structure your code so that it can handle new attributes gracefully.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetQueueAttributes service method on
        /// AmazonSQS.</param>
        /// 
        /// <exception cref="T:Amazon.SQS.Model.InvalidAttributeNameException" />
		public SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest request)
        {
            var task = SetQueueAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }
          
        /// <summary>
        /// Initiates the asynchronous execution of the SetQueueAttributes operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.SetQueueAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetQueueAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<SetQueueAttributesResponse> SetQueueAttributesAsync(SetQueueAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetQueueAttributesRequestMarshaller();
            var unmarshaller = SetQueueAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, SetQueueAttributesRequest, SetQueueAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
