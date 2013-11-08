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
    /// Amazon Simple Queue Service <para>Amazon Simple Queue Service (Amazon SQS) offers a reliable, highly scalable, hosted queue for storing
    /// messages as they travel between computers. By using Amazon SQS, developers can simply move data between distributed components of their
    /// applications that perform different tasks, without losing messages or requiring each component to be always available. Amazon SQS makes it
    /// easy to build an automated workflow, working in close conjunction with the Amazon Elastic Compute Cloud (Amazon EC2) and the other AWS
    /// infrastructure web services.</para> <para>Amazon SQS works by exposing Amazon's web-scale messaging infrastructure as a web service. Any
    /// computer on the Internet can add or read messages without any installed software or special firewall configurations. Components of
    /// applications using Amazon SQS can run independently, and do not need to be on the same network, developed with the same technologies, or
    /// running at the same time.</para> <para>Visit <a href="http://aws.amazon.com/sqs/" >http://aws.amazon.com/sqs/</a> for more
    /// information.</para>
    /// </summary>
    public partial class AmazonSQSClient : AmazonWebServiceClient, IAmazonSQS
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSQSConfig{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
        /// AmazonSQSClient Configuration object. 
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region AddPermission

        /// <summary>
        /// <para>The AddPermission action adds a permission to a queue for a specific <a
        /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/APIReference/Glossary.html" >principal</a> .
        /// This allows for sharing access to the queue.</para> <para>When you create a queue, you have full control access rights for the queue.
        /// Only you (as owner of the queue) can grant or deny permissions to the queue. For more information about these permissions, see <a
        /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/?acp-overview.html" >Shared Queues</a> in the Amazon SQS
        /// Developer Guide.</para> <para> <c>AddPermission</c> writes an SQS-generated policy. If you want to write your own policy, use
        /// SetQueueAttributes to upload your policy. For more information about writing your own policy, see <a
        /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/?AccessPolicyLanguage.html" >Appendix: The Access Policy
        /// Language</a> in the Amazon SQS Developer Guide.</para>
        /// </summary>
        /// 
        /// <param name="addPermissionRequest">Container for the necessary parameters to execute the AddPermission service method on AmazonSQS.</param>
        /// 
        /// <exception cref="OverLimitException"/>
        public AddPermissionResponse AddPermission(AddPermissionRequest addPermissionRequest)
        {
            IAsyncResult asyncResult = invokeAddPermission(addPermissionRequest, null, null, true);
            return EndAddPermission(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.AddPermission"/>
        /// </summary>
        /// 
        /// <param name="addPermissionRequest">Container for the necessary parameters to execute the AddPermission operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAddPermission(AddPermissionRequest addPermissionRequest, AsyncCallback callback, object state)
        {
            return invokeAddPermission(addPermissionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AddPermission operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.AddPermission"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAddPermission.</param>
        public AddPermissionResponse EndAddPermission(IAsyncResult asyncResult)
        {
            return endOperation<AddPermissionResponse>(asyncResult);
        }
        
        IAsyncResult invokeAddPermission(AddPermissionRequest addPermissionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AddPermissionRequestMarshaller().Marshall(addPermissionRequest);
            var unmarshaller = AddPermissionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ChangeMessageVisibility

        /// <summary>
        /// <para>The <c>ChangeMessageVisibility</c> action changes the visibility timeout of a specified message in a queue to a new value. The maximum
        /// allowed timeout value you can set the value to is 12 hours. This means you can't extend the timeout of a message in an existing queue to
        /// more than a total visibility timeout of 12 hours. (For more information visibility timeout, see <a
        /// href="http://docs.aws.amazon.com/AWSSimpleQueueService/latest/SQSDeveloperGuide/AboutVT.html" >Visibility Timeout</a> in the Amazon SQS
        /// Developer Guide.)</para> <para>For example, let's say you have a message and its default message visibility timeout is 30 minutes. You could
        /// call <c>ChangeMessageVisiblity</c> with a value of two hours and the effective timeout would be two hours and 30 minutes. When that time
        /// comes near you could again extend the time out by calling ChangeMessageVisiblity, but this time the maximum allowed timeout would be 9 hours
        /// and 30 minutes.</para> <para><b>IMPORTANT:</b>If you attempt to set the VisibilityTimeout to an amount more than the maximum time left,
        /// Amazon SQS returns an error. It will not automatically recalculate and increase the timeout to the maximum time remaining.</para>
        /// <para><b>IMPORTANT:</b>Unlike with a queue, when you change the visibility timeout for a specific message, that timeout value is applied
        /// immediately but is not saved in memory for that message. If you don't delete a message after it is received, the visibility timeout for the
        /// message the next time it is received reverts to the original timeout value, not the value you set with the ChangeMessageVisibility
        /// action.</para>
        /// </summary>
        /// 
        /// <param name="changeMessageVisibilityRequest">Container for the necessary parameters to execute the ChangeMessageVisibility service method on
        ///          AmazonSQS.</param>
        /// 
        /// <exception cref="ReceiptHandleIsInvalidException"/>
        /// <exception cref="MessageNotInflightException"/>
        public ChangeMessageVisibilityResponse ChangeMessageVisibility(ChangeMessageVisibilityRequest changeMessageVisibilityRequest)
        {
            IAsyncResult asyncResult = invokeChangeMessageVisibility(changeMessageVisibilityRequest, null, null, true);
            return EndChangeMessageVisibility(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeMessageVisibility operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ChangeMessageVisibility"/>
        /// </summary>
        /// 
        /// <param name="changeMessageVisibilityRequest">Container for the necessary parameters to execute the ChangeMessageVisibility operation on
        ///          AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginChangeMessageVisibility(ChangeMessageVisibilityRequest changeMessageVisibilityRequest, AsyncCallback callback, object state)
        {
            return invokeChangeMessageVisibility(changeMessageVisibilityRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ChangeMessageVisibility operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ChangeMessageVisibility"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangeMessageVisibility.</param>
        public ChangeMessageVisibilityResponse EndChangeMessageVisibility(IAsyncResult asyncResult)
        {
            return endOperation<ChangeMessageVisibilityResponse>(asyncResult);
        }
        
        IAsyncResult invokeChangeMessageVisibility(ChangeMessageVisibilityRequest changeMessageVisibilityRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ChangeMessageVisibilityRequestMarshaller().Marshall(changeMessageVisibilityRequest);
            var unmarshaller = ChangeMessageVisibilityResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ChangeMessageVisibilityBatch

        /// <summary>
        /// <para>This is a batch version of ChangeMessageVisibility. It takes multiple receipt handles and performs the operation on each of the them.
        /// The result of the operation on each message is reported individually in the response.</para>
        /// </summary>
        /// 
        /// <param name="changeMessageVisibilityBatchRequest">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch service
        ///          method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the ChangeMessageVisibilityBatch service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="BatchEntryIdsNotDistinctException"/>
        /// <exception cref="TooManyEntriesInBatchRequestException"/>
        /// <exception cref="InvalidBatchEntryIdException"/>
        /// <exception cref="EmptyBatchRequestException"/>
        public ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest changeMessageVisibilityBatchRequest)
        {
            IAsyncResult asyncResult = invokeChangeMessageVisibilityBatch(changeMessageVisibilityBatchRequest, null, null, true);
            return EndChangeMessageVisibilityBatch(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ChangeMessageVisibilityBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ChangeMessageVisibilityBatch"/>
        /// </summary>
        /// 
        /// <param name="changeMessageVisibilityBatchRequest">Container for the necessary parameters to execute the ChangeMessageVisibilityBatch
        ///          operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndChangeMessageVisibilityBatch operation.</returns>
        public IAsyncResult BeginChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest changeMessageVisibilityBatchRequest, AsyncCallback callback, object state)
        {
            return invokeChangeMessageVisibilityBatch(changeMessageVisibilityBatchRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ChangeMessageVisibilityBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ChangeMessageVisibilityBatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginChangeMessageVisibilityBatch.</param>
        /// 
        /// <returns>Returns a ChangeMessageVisibilityBatchResult from AmazonSQS.</returns>
        public ChangeMessageVisibilityBatchResponse EndChangeMessageVisibilityBatch(IAsyncResult asyncResult)
        {
            return endOperation<ChangeMessageVisibilityBatchResponse>(asyncResult);
        }
        
        IAsyncResult invokeChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest changeMessageVisibilityBatchRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ChangeMessageVisibilityBatchRequestMarshaller().Marshall(changeMessageVisibilityBatchRequest);
            var unmarshaller = ChangeMessageVisibilityBatchResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateQueue

        /// <summary>
        /// <para>The <c>CreateQueue</c> action creates a new queue, or returns the URL of an existing one. When you request <c>CreateQueue</c> , you
        /// provide a name for the queue. To successfully create a new queue, you must provide a name that is unique within the scope of your own
        /// queues.</para> <para>You may pass one or more attributes in the request. If you do not provide a value for any attribute, the queue will
        /// have the default value for that attribute. Permitted attributes are the same that can be set using SetQueueAttributes.</para> <para>If you
        /// provide the name of an existing queue, a new queue isn't created. If the values of attributes provided with the request match up with those
        /// on the existing queue, the queue URL is returned. Otherwise, a <c>QueueNameExists</c> error is returned.</para>
        /// </summary>
        /// 
        /// <param name="createQueueRequest">Container for the necessary parameters to execute the CreateQueue service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the CreateQueue service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="QueueNameExistsException"/>
        /// <exception cref="QueueDeletedRecentlyException"/>
        public CreateQueueResponse CreateQueue(CreateQueueRequest createQueueRequest)
        {
            IAsyncResult asyncResult = invokeCreateQueue(createQueueRequest, null, null, true);
            return EndCreateQueue(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateQueue operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.CreateQueue"/>
        /// </summary>
        /// 
        /// <param name="createQueueRequest">Container for the necessary parameters to execute the CreateQueue operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateQueue
        ///         operation.</returns>
        public IAsyncResult BeginCreateQueue(CreateQueueRequest createQueueRequest, AsyncCallback callback, object state)
        {
            return invokeCreateQueue(createQueueRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateQueue operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.CreateQueue"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateQueue.</param>
        /// 
        /// <returns>Returns a CreateQueueResult from AmazonSQS.</returns>
        public CreateQueueResponse EndCreateQueue(IAsyncResult asyncResult)
        {
            return endOperation<CreateQueueResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateQueue(CreateQueueRequest createQueueRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateQueueRequestMarshaller().Marshall(createQueueRequest);
            var unmarshaller = CreateQueueResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteMessage

        /// <summary>
        /// <para>The <c>DeleteMessage</c> action unconditionally removes the specified message from the specified queue. Even if the message is locked
        /// by another reader due to the visibility timeout setting, it is still deleted from the queue.</para>
        /// </summary>
        /// 
        /// <param name="deleteMessageRequest">Container for the necessary parameters to execute the DeleteMessage service method on AmazonSQS.</param>
        /// 
        /// <exception cref="ReceiptHandleIsInvalidException"/>
        /// <exception cref="InvalidIdFormatException"/>
        public DeleteMessageResponse DeleteMessage(DeleteMessageRequest deleteMessageRequest)
        {
            IAsyncResult asyncResult = invokeDeleteMessage(deleteMessageRequest, null, null, true);
            return EndDeleteMessage(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.DeleteMessage"/>
        /// </summary>
        /// 
        /// <param name="deleteMessageRequest">Container for the necessary parameters to execute the DeleteMessage operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteMessage(DeleteMessageRequest deleteMessageRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteMessage(deleteMessageRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.DeleteMessage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMessage.</param>
        public DeleteMessageResponse EndDeleteMessage(IAsyncResult asyncResult)
        {
            return endOperation<DeleteMessageResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteMessage(DeleteMessageRequest deleteMessageRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteMessageRequestMarshaller().Marshall(deleteMessageRequest);
            var unmarshaller = DeleteMessageResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteMessageBatch

        /// <summary>
        /// <para>This is a batch version of DeleteMessage. It takes multiple receipt handles and deletes each one of the messages. The result of the
        /// delete operation on each message is reported individually in the response.</para>
        /// </summary>
        /// 
        /// <param name="deleteMessageBatchRequest">Container for the necessary parameters to execute the DeleteMessageBatch service method on
        ///          AmazonSQS.</param>
        /// 
        /// <returns>The response from the DeleteMessageBatch service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="BatchEntryIdsNotDistinctException"/>
        /// <exception cref="TooManyEntriesInBatchRequestException"/>
        /// <exception cref="InvalidBatchEntryIdException"/>
        /// <exception cref="EmptyBatchRequestException"/>
        public DeleteMessageBatchResponse DeleteMessageBatch(DeleteMessageBatchRequest deleteMessageBatchRequest)
        {
            IAsyncResult asyncResult = invokeDeleteMessageBatch(deleteMessageBatchRequest, null, null, true);
            return EndDeleteMessageBatch(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMessageBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.DeleteMessageBatch"/>
        /// </summary>
        /// 
        /// <param name="deleteMessageBatchRequest">Container for the necessary parameters to execute the DeleteMessageBatch operation on
        ///          AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteMessageBatch operation.</returns>
        public IAsyncResult BeginDeleteMessageBatch(DeleteMessageBatchRequest deleteMessageBatchRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteMessageBatch(deleteMessageBatchRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteMessageBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.DeleteMessageBatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteMessageBatch.</param>
        /// 
        /// <returns>Returns a DeleteMessageBatchResult from AmazonSQS.</returns>
        public DeleteMessageBatchResponse EndDeleteMessageBatch(IAsyncResult asyncResult)
        {
            return endOperation<DeleteMessageBatchResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteMessageBatch(DeleteMessageBatchRequest deleteMessageBatchRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteMessageBatchRequestMarshaller().Marshall(deleteMessageBatchRequest);
            var unmarshaller = DeleteMessageBatchResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteQueue

        /// <summary>
        /// <para>This action unconditionally deletes the queue specified by the queue URL. Use this operation WITH CARE! The queue is deleted even if
        /// it is NOT empty.</para> <para>Once a queue has been deleted, the queue name is unavailable for use with new queues for 60 seconds.</para>
        /// </summary>
        /// 
        /// <param name="deleteQueueRequest">Container for the necessary parameters to execute the DeleteQueue service method on AmazonSQS.</param>
        /// 
        public DeleteQueueResponse DeleteQueue(DeleteQueueRequest deleteQueueRequest)
        {
            IAsyncResult asyncResult = invokeDeleteQueue(deleteQueueRequest, null, null, true);
            return EndDeleteQueue(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteQueue operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.DeleteQueue"/>
        /// </summary>
        /// 
        /// <param name="deleteQueueRequest">Container for the necessary parameters to execute the DeleteQueue operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteQueue(DeleteQueueRequest deleteQueueRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteQueue(deleteQueueRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteQueue operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.DeleteQueue"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteQueue.</param>
        public DeleteQueueResponse EndDeleteQueue(IAsyncResult asyncResult)
        {
            return endOperation<DeleteQueueResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteQueue(DeleteQueueRequest deleteQueueRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteQueueRequestMarshaller().Marshall(deleteQueueRequest);
            var unmarshaller = DeleteQueueResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetQueueAttributes

        /// <summary>
        /// <para>Gets attributes for the specified queue. The following attributes are supported:
        /// <ul>
        /// <li> <c>All</c> - returns all values.</li>
        /// <li> <c>ApproximateNumberOfMessages</c> - returns the approximate number of visible messages in a queue. For more information, see
        /// Resources Required to Process Messages in the Amazon SQS Developer Guide.</li>
        /// <li> <c>ApproximateNumberOfMessagesNotVisible</c> - returns the approximate number of messages that are not timed-out and not deleted. For
        /// more information, see Resources Required to Process Messages in the Amazon SQS Developer Guide.</li>
        /// <li> <c>VisibilityTimeout</c> - returns the visibility timeout for the queue. For more information about visibility timeout, see Visibility
        /// Timeout in the Amazon SQS Developer Guide.</li>
        /// <li> <c>CreatedTimestamp</c> - returns the time when the queue was created (epoch time in seconds).</li>
        /// <li> <c>LastModifiedTimestamp</c> - returns the time when the queue was last changed (epoch time in seconds).</li>
        /// <li> <c>Policy</c> - returns the queue's policy.</li>
        /// <li> <c>MaximumMessageSize</c> - returns the limit of how many bytes a message can contain before Amazon SQS rejects it.</li>
        /// <li> <c>MessageRetentionPeriod</c> - returns the number of seconds Amazon SQS retains a message.</li>
        /// <li> <c>QueueArn</c> - returns the queue's Amazon resource name (ARN).</li>
        /// <li> <c>ApproximateNumberOfMessagesDelayed</c> - returns the approximate number of messages that are pending to be added to the queue.</li>
        /// <li> <c>DelaySeconds</c> - returns the default delay on the queue in seconds.</li>
        /// <li> <c>ReceiveMessageWaitTimeSeconds</c> - returns the time for which a ReceiveMessage call will wait for a message to arrive.</li>
        /// 
        /// </ul>
        /// </para>
        /// </summary>
        /// 
        /// <param name="getQueueAttributesRequest">Container for the necessary parameters to execute the GetQueueAttributes service method on
        ///          AmazonSQS.</param>
        /// 
        /// <returns>The response from the GetQueueAttributes service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="InvalidAttributeNameException"/>
        public GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest getQueueAttributesRequest)
        {
            IAsyncResult asyncResult = invokeGetQueueAttributes(getQueueAttributesRequest, null, null, true);
            return EndGetQueueAttributes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueAttributes operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.GetQueueAttributes"/>
        /// </summary>
        /// 
        /// <param name="getQueueAttributesRequest">Container for the necessary parameters to execute the GetQueueAttributes operation on
        ///          AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndGetQueueAttributes operation.</returns>
        public IAsyncResult BeginGetQueueAttributes(GetQueueAttributesRequest getQueueAttributesRequest, AsyncCallback callback, object state)
        {
            return invokeGetQueueAttributes(getQueueAttributesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetQueueAttributes operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.GetQueueAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueueAttributes.</param>
        /// 
        /// <returns>Returns a GetQueueAttributesResult from AmazonSQS.</returns>
        public GetQueueAttributesResponse EndGetQueueAttributes(IAsyncResult asyncResult)
        {
            return endOperation<GetQueueAttributesResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetQueueAttributes(GetQueueAttributesRequest getQueueAttributesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetQueueAttributesRequestMarshaller().Marshall(getQueueAttributesRequest);
            var unmarshaller = GetQueueAttributesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetQueueUrl

        /// <summary>
        /// <para>The <c>GetQueueUrl</c> action returns the URL of an existing queue.</para>
        /// </summary>
        /// 
        /// <param name="getQueueUrlRequest">Container for the necessary parameters to execute the GetQueueUrl service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the GetQueueUrl service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="QueueDoesNotExistException"/>
        public GetQueueUrlResponse GetQueueUrl(GetQueueUrlRequest getQueueUrlRequest)
        {
            IAsyncResult asyncResult = invokeGetQueueUrl(getQueueUrlRequest, null, null, true);
            return EndGetQueueUrl(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetQueueUrl operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.GetQueueUrl"/>
        /// </summary>
        /// 
        /// <param name="getQueueUrlRequest">Container for the necessary parameters to execute the GetQueueUrl operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetQueueUrl
        ///         operation.</returns>
        public IAsyncResult BeginGetQueueUrl(GetQueueUrlRequest getQueueUrlRequest, AsyncCallback callback, object state)
        {
            return invokeGetQueueUrl(getQueueUrlRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetQueueUrl operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.GetQueueUrl"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetQueueUrl.</param>
        /// 
        /// <returns>Returns a GetQueueUrlResult from AmazonSQS.</returns>
        public GetQueueUrlResponse EndGetQueueUrl(IAsyncResult asyncResult)
        {
            return endOperation<GetQueueUrlResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetQueueUrl(GetQueueUrlRequest getQueueUrlRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetQueueUrlRequestMarshaller().Marshall(getQueueUrlRequest);
            var unmarshaller = GetQueueUrlResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ListQueues

        /// <summary>
        /// <para>Returns a list of your queues.</para>
        /// </summary>
        /// 
        /// <param name="listQueuesRequest">Container for the necessary parameters to execute the ListQueues service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by AmazonSQS.</returns>
        /// 
        public ListQueuesResponse ListQueues(ListQueuesRequest listQueuesRequest)
        {
            IAsyncResult asyncResult = invokeListQueues(listQueuesRequest, null, null, true);
            return EndListQueues(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ListQueues operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ListQueues"/>
        /// </summary>
        /// 
        /// <param name="listQueuesRequest">Container for the necessary parameters to execute the ListQueues operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListQueues
        ///         operation.</returns>
        public IAsyncResult BeginListQueues(ListQueuesRequest listQueuesRequest, AsyncCallback callback, object state)
        {
            return invokeListQueues(listQueuesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ListQueues operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ListQueues"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListQueues.</param>
        /// 
        /// <returns>Returns a ListQueuesResult from AmazonSQS.</returns>
        public ListQueuesResponse EndListQueues(IAsyncResult asyncResult)
        {
            return endOperation<ListQueuesResponse>(asyncResult);
        }
        
        IAsyncResult invokeListQueues(ListQueuesRequest listQueuesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ListQueuesRequestMarshaller().Marshall(listQueuesRequest);
            var unmarshaller = ListQueuesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns a list of your queues.</para>
        /// </summary>
        /// 
        /// <returns>The response from the ListQueues service method, as returned by AmazonSQS.</returns>
        /// 
        public ListQueuesResponse ListQueues()
        {
            return ListQueues(new ListQueuesRequest());
        }
        

        #endregion
    
        #region ReceiveMessage

        /// <summary>
        /// <para>Retrieves one or more messages from the specified queue, including the message body and message ID of each message. Messages returned
        /// by this action stay in the queue until you delete them. However, once a message is returned to a <c>ReceiveMessage</c> request, it is not
        /// returned on subsequent <c>ReceiveMessage</c> requests for the duration of the <c>VisibilityTimeout</c> . If you do not specify a
        /// <c>VisibilityTimeout</c> in the request, the overall visibility timeout for the queue is used for the returned messages.</para> <para>If a
        /// message is available in the queue, the call will return immediately. Otherwise, it will wait up to <c>WaitTimeSeconds</c> for a message to
        /// arrive. If you do not specify <c>WaitTimeSeconds</c> in the request, the queue attribute ReceiveMessageWaitTimeSeconds is used to determine
        /// how long to wait.</para> <para>You could ask for additional information about each message through the attributes. Attributes that can be
        /// requested are <c>[SenderId, ApproximateFirstReceiveTimestamp, ApproximateReceiveCount, SentTimestamp]</c> .</para>
        /// </summary>
        /// 
        /// <param name="receiveMessageRequest">Container for the necessary parameters to execute the ReceiveMessage service method on
        ///          AmazonSQS.</param>
        /// 
        /// <returns>The response from the ReceiveMessage service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="OverLimitException"/>
        public ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest receiveMessageRequest)
        {
            IAsyncResult asyncResult = invokeReceiveMessage(receiveMessageRequest, null, null, true);
            return EndReceiveMessage(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReceiveMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ReceiveMessage"/>
        /// </summary>
        /// 
        /// <param name="receiveMessageRequest">Container for the necessary parameters to execute the ReceiveMessage operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReceiveMessage
        ///         operation.</returns>
        public IAsyncResult BeginReceiveMessage(ReceiveMessageRequest receiveMessageRequest, AsyncCallback callback, object state)
        {
            return invokeReceiveMessage(receiveMessageRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReceiveMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.ReceiveMessage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReceiveMessage.</param>
        /// 
        /// <returns>Returns a ReceiveMessageResult from AmazonSQS.</returns>
        public ReceiveMessageResponse EndReceiveMessage(IAsyncResult asyncResult)
        {
            return endOperation<ReceiveMessageResponse>(asyncResult);
        }
        
        IAsyncResult invokeReceiveMessage(ReceiveMessageRequest receiveMessageRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReceiveMessageRequestMarshaller().Marshall(receiveMessageRequest);
            var unmarshaller = ReceiveMessageResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RemovePermission

        /// <summary>
        /// <para>The <c>RemovePermission</c> action revokes any permissions in the queue policy that matches the specified <c>Label</c> parameter. Only
        /// the owner of the queue can remove permissions.</para>
        /// </summary>
        /// 
        /// <param name="removePermissionRequest">Container for the necessary parameters to execute the RemovePermission service method on
        ///          AmazonSQS.</param>
        /// 
        public RemovePermissionResponse RemovePermission(RemovePermissionRequest removePermissionRequest)
        {
            IAsyncResult asyncResult = invokeRemovePermission(removePermissionRequest, null, null, true);
            return EndRemovePermission(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.RemovePermission"/>
        /// </summary>
        /// 
        /// <param name="removePermissionRequest">Container for the necessary parameters to execute the RemovePermission operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRemovePermission(RemovePermissionRequest removePermissionRequest, AsyncCallback callback, object state)
        {
            return invokeRemovePermission(removePermissionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RemovePermission operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.RemovePermission"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRemovePermission.</param>
        public RemovePermissionResponse EndRemovePermission(IAsyncResult asyncResult)
        {
            return endOperation<RemovePermissionResponse>(asyncResult);
        }
        
        IAsyncResult invokeRemovePermission(RemovePermissionRequest removePermissionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RemovePermissionRequestMarshaller().Marshall(removePermissionRequest);
            var unmarshaller = RemovePermissionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SendMessage

        /// <summary>
        /// <para>The <c>SendMessage</c> action delivers a message to the specified queue.</para>
        /// </summary>
        /// 
        /// <param name="sendMessageRequest">Container for the necessary parameters to execute the SendMessage service method on AmazonSQS.</param>
        /// 
        /// <returns>The response from the SendMessage service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="InvalidMessageContentsException"/>
        public SendMessageResponse SendMessage(SendMessageRequest sendMessageRequest)
        {
            IAsyncResult asyncResult = invokeSendMessage(sendMessageRequest, null, null, true);
            return EndSendMessage(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.SendMessage"/>
        /// </summary>
        /// 
        /// <param name="sendMessageRequest">Container for the necessary parameters to execute the SendMessage operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendMessage
        ///         operation.</returns>
        public IAsyncResult BeginSendMessage(SendMessageRequest sendMessageRequest, AsyncCallback callback, object state)
        {
            return invokeSendMessage(sendMessageRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SendMessage operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.SendMessage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessage.</param>
        /// 
        /// <returns>Returns a SendMessageResult from AmazonSQS.</returns>
        public SendMessageResponse EndSendMessage(IAsyncResult asyncResult)
        {
            return endOperation<SendMessageResponse>(asyncResult);
        }
        
        IAsyncResult invokeSendMessage(SendMessageRequest sendMessageRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SendMessageRequestMarshaller().Marshall(sendMessageRequest);
            var unmarshaller = SendMessageResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SendMessageBatch

        /// <summary>
        /// <para>This is a batch version of SendMessage. It takes multiple messages and adds each of them to the queue. The result of each add
        /// operation is reported individually in the response.</para>
        /// </summary>
        /// 
        /// <param name="sendMessageBatchRequest">Container for the necessary parameters to execute the SendMessageBatch service method on
        ///          AmazonSQS.</param>
        /// 
        /// <returns>The response from the SendMessageBatch service method, as returned by AmazonSQS.</returns>
        /// 
        /// <exception cref="BatchEntryIdsNotDistinctException"/>
        /// <exception cref="TooManyEntriesInBatchRequestException"/>
        /// <exception cref="BatchRequestTooLongException"/>
        /// <exception cref="InvalidBatchEntryIdException"/>
        /// <exception cref="EmptyBatchRequestException"/>
        public SendMessageBatchResponse SendMessageBatch(SendMessageBatchRequest sendMessageBatchRequest)
        {
            IAsyncResult asyncResult = invokeSendMessageBatch(sendMessageBatchRequest, null, null, true);
            return EndSendMessageBatch(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SendMessageBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.SendMessageBatch"/>
        /// </summary>
        /// 
        /// <param name="sendMessageBatchRequest">Container for the necessary parameters to execute the SendMessageBatch operation on AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendMessageBatch
        ///         operation.</returns>
        public IAsyncResult BeginSendMessageBatch(SendMessageBatchRequest sendMessageBatchRequest, AsyncCallback callback, object state)
        {
            return invokeSendMessageBatch(sendMessageBatchRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SendMessageBatch operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.SendMessageBatch"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendMessageBatch.</param>
        /// 
        /// <returns>Returns a SendMessageBatchResult from AmazonSQS.</returns>
        public SendMessageBatchResponse EndSendMessageBatch(IAsyncResult asyncResult)
        {
            return endOperation<SendMessageBatchResponse>(asyncResult);
        }
        
        IAsyncResult invokeSendMessageBatch(SendMessageBatchRequest sendMessageBatchRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SendMessageBatchRequestMarshaller().Marshall(sendMessageBatchRequest);
            var unmarshaller = SendMessageBatchResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region SetQueueAttributes

        /// <summary>
        /// <para>Sets the value of one or more queue attributes. Valid attributes that can be set are [VisibilityTimeout, Policy, MaximumMessageSize,
        /// MessageRetentionPeriod, ReceiveMessageWaitTimeSeconds].</para>
        /// </summary>
        /// 
        /// <param name="setQueueAttributesRequest">Container for the necessary parameters to execute the SetQueueAttributes service method on
        ///          AmazonSQS.</param>
        /// 
        /// <exception cref="InvalidAttributeNameException"/>
        public SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest setQueueAttributesRequest)
        {
            IAsyncResult asyncResult = invokeSetQueueAttributes(setQueueAttributesRequest, null, null, true);
            return EndSetQueueAttributes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the SetQueueAttributes operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.SetQueueAttributes"/>
        /// </summary>
        /// 
        /// <param name="setQueueAttributesRequest">Container for the necessary parameters to execute the SetQueueAttributes operation on
        ///          AmazonSQS.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginSetQueueAttributes(SetQueueAttributesRequest setQueueAttributesRequest, AsyncCallback callback, object state)
        {
            return invokeSetQueueAttributes(setQueueAttributesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the SetQueueAttributes operation.
        /// <seealso cref="Amazon.SQS.IAmazonSQS.SetQueueAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSetQueueAttributes.</param>
        public SetQueueAttributesResponse EndSetQueueAttributes(IAsyncResult asyncResult)
        {
            return endOperation<SetQueueAttributesResponse>(asyncResult);
        }
        
        IAsyncResult invokeSetQueueAttributes(SetQueueAttributesRequest setQueueAttributesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new SetQueueAttributesRequestMarshaller().Marshall(setQueueAttributesRequest);
            var unmarshaller = SetQueueAttributesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
