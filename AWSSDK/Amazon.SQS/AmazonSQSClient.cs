/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2012-11-05
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Xml;
using System.Xml.Serialization;

using Amazon.SQS.Model;
using Attribute = Amazon.SQS.Model.Attribute;

using Amazon.Util;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

using ErrorResponse = Amazon.SQS.Model.ErrorResponse;

namespace Amazon.SQS
{
    /// <summary>
    /// AmazonSQSClient is an implementation of AmazonSQS;
    /// the client allows you to manage your AmazonSQS resources.<br />
    /// If you want to use the AmazonSQSClient from a Medium Trust
    /// hosting environment, please create the client with an
    /// AmazonSQSConfig object whose UseSecureStringForAwsSecretKey
    /// property is false.
    /// </summary>
    /// <remarks>
    /// Amazon Simple Queue Service (Amazon SQS) offers a reliable, highly scalable hosted queue for storing
    /// messages as they travel between computers. By using Amazon SQS, developers can simply move data between
    /// distributed application components performing different tasks, without losing messages or requiring each
    /// component to be always available.  Amazon SQS works by exposing Amazon's web-scale messaging infrastructure
    /// as a web service. Any computer on the Internet can add or read messages without any installed software or
    /// special firewall configurations. Components of applications using Amazon SQS can run independently, and do
    /// not need to be on the same network, developed with the same technologies, or running at the same time.
    /// </remarks>
    /// <seealso cref="P:Amazon.SQS.AmazonSQSConfig.UseSecureStringForAwsSecretKey"/>
    public class AmazonSQSClient : AmazonSQS
    {
        private bool ownCredentials;
        private AWSCredentials credentials;
        private AmazonSQSConfig config;
        private bool disposed;

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonSQSClient
        /// </summary>
        /// <param name="fDisposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool fDisposing)
        {
            if (!this.disposed)
            {
                if (fDisposing && credentials != null)
                {
                    if (ownCredentials)
                    {
                        credentials.Dispose();
                    }
                    credentials = null;
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~AmazonSQSClient()
        {
            this.Dispose(false);
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
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonSQSConfig(), true) { }

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
        /// <param name="region">The region to connect to.</param>
        public AmazonSQSClient(RegionEndpoint region)
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonSQSConfig() { RegionEndpoint = region }, true) { }

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
            : this(FallbackCredentialsFactory.GetCredentials(), config, true) { }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSQSConfig()) { }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect to.</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSQSConfig() { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQS Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonSQS Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSQSConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true) { }

        /// <summary>
        /// Constructs an AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQS Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The AmazonSQS Configuration Object</param>
        public AmazonSQSClient(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonSQSConfig config)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true) { }

        /// <summary>
        /// Constructs an AmazonSQSClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSQS Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="region">The region to connect to.</param>
        public AmazonSQSClient(string awsAccessKeyId, SecureString awsSecretAccessKey, RegionEndpoint region)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonSQSConfig() { RegionEndpoint = region }, true) { }

        /// <summary>
        /// Constructs AmazonSQSClient with AWSCredentials
        /// </summary>
        /// <param name="credentials"></param>
        public AmazonSQSClient(AWSCredentials credentials)
            : this(credentials, new AmazonSQSConfig()) { }

        /// <summary>
        /// Constructs AmazonSQSClient with AWSCredentials
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="region">The region to connect to.</param>
        public AmazonSQSClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSQSConfig() { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs AmazonSQSClient with AWSCredentials and an AmazonSQS Configuration object.
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="config"></param>
        public AmazonSQSClient(AWSCredentials credentials, AmazonSQSConfig config)
            : this(credentials, config, false) { }


        // Constructs an AmazonSQSClient with credentials, config and flag which
        // specifies if the credentials are owned by the client or not
        private AmazonSQSClient(AWSCredentials credentials, AmazonSQSConfig config, bool ownCredentials)
        {
            this.credentials = credentials;
            this.config = config;
            this.ownCredentials = ownCredentials;
        }

        #endregion

        #region Public API

        /// <summary>
        /// Creates a new queue, or returns the URL of an existing one.
        /// </summary>
        /// <remarks>
        /// <para>
        /// When you request CreateQueue, you provide a name for the queue. To successfully
        /// create a new queue, you must provide a name that is unique within the scope of
        /// your own queues. If you provide the name of an existing queue, a new queue isn't
        /// created and an error isn't returned. Instead, the request succeeds and the queue
        /// URL for the existing queue is returned.
        /// </para>
        /// <para>
        /// Exception: if you provide a value for DefaultVisibilityTimeout that is different
        /// from the value for the existing queue, you receive an error.
        /// </para>
        /// </remarks>
        /// <param name="request">Create Queue  request</param>
        /// <returns>Create Queue  Response from the service</returns>
        public CreateQueueResponse CreateQueue(CreateQueueRequest request)
        {
            return Invoke<CreateQueueResponse>(request, ConvertCreateQueue(request));
        }

        /// <summary>
        /// Returns a list of your queues. The maximum number of queues that can be returned is 1000.
        /// </summary>
        /// <remarks>
        /// If you specify a value for the optional QueueNamePrefix parameter, only queues with a name beginning with the
        /// specified value are returned.
        /// </remarks>
        /// <param name="request">List Queues  request</param>
        /// <returns>List Queues  Response from the service</returns>
        public ListQueuesResponse ListQueues(ListQueuesRequest request)
        {
            return Invoke<ListQueuesResponse>(request, ConvertListQueues(request));
        }

        /// <summary>
        /// Adds the specified permission(s) to a queue for the specified principal(s).
        /// </summary>
        /// <remarks>
        /// This allows for sharing access to the queue.
        /// </remarks>
        /// <param name="request">Add Permission  request</param>
        /// <returns>Add Permission  Response from the service</returns>
        public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            return Invoke<AddPermissionResponse>(request, ConvertAddPermission(request));
        }

        /// <summary>
        /// Extends the read lock timeout of a single message in a queue.
        /// </summary>
        /// <param name="request">Change Message Visibility  request</param>
        /// <returns>Change Message Visibility  Response from the service</returns>
        public ChangeMessageVisibilityResponse ChangeMessageVisibility(ChangeMessageVisibilityRequest request)
        {
            return Invoke<ChangeMessageVisibilityResponse>(request, ConvertChangeMessageVisibility(request));
        }

        /// <summary>
        /// Extends the read lock timeout of multiple messages in a queue.
        /// </summary>
        /// <remarks>
        /// This operation takes multiple receipt handles and extends the lock timeout for each of the them.
        /// The result of the operation on each message is reported individually in the response.
        /// </remarks>
        /// <param name="request">Change Message Visibility Batch request</param>
        /// <returns>Change Message Visibility Response from the service</returns>
        public ChangeMessageVisibilityBatchResponse ChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request)
        {
            return Invoke<ChangeMessageVisibilityBatchResponse>(request, ConvertChangeMessageVisibilityBatch(request));
        }

        /// <summary>
        /// Unconditionally removes the specified message from the specified queue.
        /// </summary>
        /// <remarks>
        /// Even if the message is locked by another reader due to the visibility timeout setting, it is still deleted from the queue.
        /// </remarks>
        /// <param name="request">Delete Message  request</param>
        /// <returns>Delete Message  Response from the service</returns>
        public DeleteMessageResponse DeleteMessage(DeleteMessageRequest request)
        {
            return Invoke<DeleteMessageResponse>(request, ConvertDeleteMessage(request));
        }

        /// <summary>
        /// Removes multiple messages from the specified queue.
        /// </summary>
        /// <remarks>
        /// This operation takes multiple receipt handles and deletes each one of the messages.
        /// The result of the delete operation on each message is reported individually in the response.
        /// </remarks>
        /// <param name="request">DeleteMessageBatch request</param>
        /// <returns>DeleteMessageBatch Response from the service</returns>
        public DeleteMessageBatchResponse DeleteMessageBatch(DeleteMessageBatchRequest request)
        {
            return Invoke<DeleteMessageBatchResponse>(request, ConvertDeleteMessageBatch(request));
        }

        /// <summary>
        /// <para>
        /// Deletes the queue specified by the queue URL, regardless of whether the queue is empty.
        /// </para>
        /// </summary>
        /// <remarks>
        /// <para>
        /// If the specified queue does not exist, SQS returns a successful response. Use DeleteQueue with care; once you
        /// delete your queue, any messages in the queue are no longer available.
        /// </para>
        /// <para>
        /// When you delete a queue, the deletion process takes up to 60 seconds. Requests you send involving that queue
        /// during the 60 seconds might succeed. For example, a SendMessage request might succeed, but after the 60 seconds,
        /// the queue and that message you sent no longer exist. Also, when you delete a queue, you must wait at least 60 seconds
        /// before creating a queue with the same name.
        /// </para>
        /// <para>
        /// We reserve the right to delete queues that have had no activity for more than 30 days.
        /// </para>
        /// </remarks>
        /// <param name="request">Delete Queue  request</param>
        /// <returns>Delete Queue  Response from the service</returns>
        public DeleteQueueResponse DeleteQueue(DeleteQueueRequest request)
        {
            return Invoke<DeleteQueueResponse>(request, ConvertDeleteQueue(request));
        }

        /// <summary>
        /// Gets one or all attributes of a queue.
        /// </summary>
        /// <remarks>
        /// Gets one or all attributes of a queue. The following table lists the valid values for attributes to be returned.
        /// <list type="definition">
        ///     <item>
        ///         <term>All</term>
        ///         <description>All values.</description>
        ///     </item>
        ///     <item>
        ///         <term>ApproximateNumberOfMessages</term>
        ///         <description>The approximate number of visible messages in a queue.</description>
        ///     </item>
        ///     <item>
        ///         <term>ApproximateNumberOfMessagesNotVisible</term>
        ///         <description>The approximate number of messages that are not timed-out and not deleted.</description>
        ///     </item>
        ///     <item>
        ///         <term>VisibilityTimeout</term>
        ///         <description>The visibility timeout for the queue.</description>
        ///     </item>
        ///     <item>
        ///         <term>CreatedTimestamp</term>
        ///         <description>The time when the queue was created (epoch time in seconds).</description>
        ///     </item>
        ///     <item>
        ///         <term>LastModifiedTimestamp</term>
        ///         <description>The time when the queue was last changed (epoch time in seconds).</description>
        ///     </item>
        ///     <item>
        ///         <term>Policy</term>
        ///         <description>The queue's policy.</description>
        ///     </item>
        ///     <item>
        ///         <term>MaximumMessageSize</term>
        ///         <description>The limit of how many bytes a message can contain before Amazon SQS rejects it.</description>
        ///     </item>
        ///     <item>
        ///         <term>MessageRetentionPeriod</term>
        ///         <description>The number of seconds Amazon SQS retains a message.</description>
        ///     </item>
        ///     <item>
        ///         <term>QueueArn</term>
        ///         <description>The queue's Amazon resource name (ARN).</description>
        ///     </item>
        ///     <item>
        ///         <term>DelaySeconds</term>
        ///         <description>The default delay for messages to be delivered.</description>
        ///     </item>
        ///     <item>
        ///         <term>ApproximateNumberOfMessagesDelayed</term>
        ///         <description>The approximate number of messages that are delayed from delivery.</description>
        ///     </item>
        /// </list>
        /// </remarks>
        /// <param name="request">Get Queue Attributes  request</param>
        /// <returns>Get Queue Attributes  Response from the service</returns>
        public GetQueueAttributesResponse GetQueueAttributes(GetQueueAttributesRequest request)
        {
            return Invoke<GetQueueAttributesResponse>(request, ConvertGetQueueAttributes(request));
        }

        /// <summary>
        /// Returns the URL of an existing queue.
        /// </summary>
        /// <param name="request">GetQueueUrl  request</param>
        /// <returns>GetQueueUrl Response from the service</returns>
        public GetQueueUrlResponse GetQueueUrl(GetQueueUrlRequest request)
        {
            return Invoke<GetQueueUrlResponse>(request, ConvertGetQueueUrl(request));
        }

        /// <summary>
        /// Removes the permission with the specified statement id from the queue.
        /// </summary>
        /// <param name="request">Remove Permission  request</param>
        /// <returns>Remove Permission  Response from the service</returns>
        public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            return Invoke<RemovePermissionResponse>(request, ConvertRemovePermission(request));
        }

        /// <summary>
        /// <para>
        /// Retrieves one or more messages from the specified queue, including the message
        /// body and message ID of each message. Messages returned by this action stay in
        /// the queue until you delete them. However, once a message is returned to a
        /// ReceiveMessage request, it is not returned on subsequent ReceiveMessage requests
        /// for the duration of the VisibilityTimeout. If you do not specify a
        /// VisibilityTimeout in the request, the overall visibility timeout for the queue
        /// is used for the returned messages.
        /// </para>
        /// <para>
        /// If a message is available in the queue, the call will return immediately. Otherwise,
        /// it will wait up to WaitTimeSeconds for a message to arrive. If you do not specify
        /// WaitTimeSeconds in the request, the queue attribute by the same name is used to
        /// determine how long to wait.
        /// </para>
        /// <para>
        /// You could ask for additional information about each message through the attributes.
        /// Attributes that can be requested are [SenderId, ApproximateFirstReceiveTimestamp,
        /// ApproximateReceiveCount, SentTimestamp].
        /// </para>
        /// </summary>
        /// <remarks>
        /// Messages returned by this action stay in the queue until you delete them. However, once a message is returned to a
        /// ReceiveMessage request, it is not returned on subsequent ReceiveMessage requests for the duration of the
        /// VisibilityTimeout. If you do not specify a VisibilityTimeout in the request, the overall visibility timeout for the
        /// queue is used for the returned messages.
        /// </remarks>
        /// <param name="request">Receive Message  request</param>
        /// <returns>Receive Message  Response from the service</returns>
        public ReceiveMessageResponse ReceiveMessage(ReceiveMessageRequest request)
        {
            return Invoke<ReceiveMessageResponse>(request, ConvertReceiveMessage(request));
        }

        /// <summary>
        /// Delivers a message to the specified queue.
        /// </summary>
        /// <param name="request">Send Message  request</param>
        /// <returns>Send Message  Response from the service</returns>
        public SendMessageResponse SendMessage(SendMessageRequest request)
        {
            return Invoke<SendMessageResponse>(request, ConvertSendMessage(request));
        }

        /// <summary>
        /// Sends multiple messages to a queue.
        /// </summary>
        /// <remarks>
        /// This operation takes multiple messages and adds each of them to the queue.
        /// The result of each add operation is reported individually in the response.
        /// </remarks>
        /// <param name="request">SendMessageBatch  request</param>
        /// <returns>SendMessageBatch Response from the service</returns>
        public SendMessageBatchResponse SendMessageBatch(SendMessageBatchRequest request)
        {
            return Invoke<SendMessageBatchResponse>(request, ConvertSendMessageBatch(request));
        }

        /// <summary>
        /// <para>
        /// Sets the value of one or more queue attributes. Currently, you can set only one attribute per request. Valid attributes that
        /// can be set are [VisibilityTimeout, Policy, MaximumMessageSize,
        /// MessageRetentionPeriod, WaitTimeSeconds].
        /// </para>
        /// </summary>
        /// <param name="request">Set Queue Attributes  request</param>
        /// <returns>Set Queue Attributes  Response from the service</returns>
        public SetQueueAttributesResponse SetQueueAttributes(SetQueueAttributesRequest request)
        {
            return Invoke<SetQueueAttributesResponse>(request, ConvertSetQueueAttributes(request));
        }

        #endregion

        #region Private API

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonSQSConfig instance
         */
        private static HttpWebRequest ConfigureWebRequest(int contentLength, string queueUrl, AmazonSQSConfig config, IDictionary<string, string> headers)
        {
            HttpWebRequest request = WebRequest.Create(queueUrl) as HttpWebRequest;
            if (request != null)
            {
                request.ServicePoint.ConnectionLimit = config.ConnectionLimit;

                if (config.IsSetProxyHost() && config.IsSetProxyPort())
                {
                    WebProxy proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                    request.Proxy = proxy;
                }
                if (request.Proxy != null && config.IsSetProxyCredentials())
                {
                    request.Proxy.Credentials = config.ProxyCredentials;
                }
                request.Method = "POST";
                request.Timeout = 50000;
                request.ContentType = AWSSDKUtils.UrlEncodedContent;
                request.ContentLength = contentLength;

                request.ServicePoint.Expect100Continue = false;
                request.ServicePoint.UseNagleAlgorithm = false;
            }

            Amazon.Runtime.AmazonWebServiceClient.AddHeaders(request, headers);

            return request;
        }

        /**
         * Invoke request and return response
         */
        private T Invoke<T>(SQSRequest sqsRequest, IDictionary<string, string> parameters)
        {
            string actionName = parameters["Action"];
            T response = default(T);

            string url;
            if (config.RegionEndpoint != null)
                url = "https://" + config.RegionEndpoint.GetEndpointForService(config.RegionEndpointServiceName).Hostname;
            else
                url = config.ServiceURL;

            string queueUrl = parameters.ContainsKey("QueueUrl") ? parameters["QueueUrl"] : url;

            if (parameters.ContainsKey("QueueUrl"))
            {
                parameters.Remove("QueueUrl");
            }
            HttpStatusCode statusCode = default(HttpStatusCode);

            /* Add required request parameters */
            IDictionary<string, string> headers = new Dictionary<string, string>();
            headers[AWSSDKUtils.UserAgentHeader] = config.UserAgent;
            ProcessRequestHandlers(sqsRequest, headers);
            AddRequiredParameters(headers, parameters, queueUrl);

            string queryString = AWSSDKUtils.GetParametersAsString(parameters);

            byte[] requestData = Encoding.UTF8.GetBytes(queryString);
            bool shouldRetry = true;
            int retries = 0;
            int maxRetries = config.IsSetMaxErrorRetry() ? config.MaxErrorRetry : AWSSDKUtils.DefaultMaxRetry;
            do
            {
                string responseBody = null;                
                HttpWebRequest request = ConfigureWebRequest(requestData.Length, queueUrl, config, headers);
                
                /* Submit the request and read response body */
                try
                {
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(requestData, 0, requestData.Length);
                    }

                    using (HttpWebResponse httpResponse = request.GetResponse() as HttpWebResponse)
                    {
                        if (httpResponse == null)
                        {
                            throw new WebException(
                                "The Web Response for a successful request is null!",
                                WebExceptionStatus.ProtocolError
                                );
                        }

                        statusCode = httpResponse.StatusCode;
                        using (StreamReader reader = new StreamReader(httpResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }
                    }

                    /* Attempt to deserialize response into <Action> Response type */
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    using (XmlTextReader sr = new XmlTextReader(new StringReader(responseBody)))
                    {
                        response = (T)serializer.Deserialize(sr);
                    }
                    shouldRetry = false;
                }
                /* Web exception is thrown on unsucessful responses */
                catch (WebException we)
                {
                    shouldRetry = false;
                    using (HttpWebResponse httpErrorResponse = we.Response as HttpWebResponse)
                    {
                        if (httpErrorResponse == null)
                        {
                            // Abort the unsuccessful request
                            request.Abort();
                            throw we;
                        }
                        statusCode = httpErrorResponse.StatusCode;
                        using (StreamReader reader = new StreamReader(httpErrorResponse.GetResponseStream(), Encoding.UTF8))
                        {
                            responseBody = reader.ReadToEnd();
                        }

                        // Abort the unsuccessful request
                        request.Abort();
                    }

                    if (statusCode == HttpStatusCode.InternalServerError ||
                        statusCode == HttpStatusCode.ServiceUnavailable)
                    {
                        shouldRetry = true;
                        PauseOnRetry(++retries, maxRetries, statusCode, we);
                    }
                    else
                    {
                        /* Attempt to deserialize response into ErrorResponse type */
                        try
                        {
                            using (XmlTextReader sr = new XmlTextReader(new StringReader(responseBody)))
                            {
                                XmlSerializer serializer = new XmlSerializer(typeof(ErrorResponse));
                                ErrorResponse errorResponse = (ErrorResponse)serializer.Deserialize(sr);
                                Error error = errorResponse.Error[0];

                                /* Throw formatted exception with information available from the error response */
                                throw new AmazonSQSException(
                                    error.Message,
                                    statusCode,
                                    error.Code,
                                    error.Type,
                                    errorResponse.RequestId,
                                    errorResponse.ToXML()
                                    );
                            }
                        }
                        /* Rethrow on deserializer error */
                        catch (Exception e)
                        {
                            if (e is AmazonSQSException)
                            {
                                throw;
                            }
                            else
                            {
                                throw ReportAnyErrors(responseBody, statusCode);
                            }
                        }
                    }
                }
                /* Catch other exceptions, attempt to convert to formatted exception,
                 * else rethrow wrapped exception */
                catch (Exception)
                {
                    // Abort the unsuccessful request
                    request.Abort();
                    throw;
                }
            } while (shouldRetry);

            return response;
        }

        protected virtual void ProcessRequestHandlers(IRequestEvents request, IDictionary<string, string> headers)
        {
            if (request == null) throw new ArgumentNullException("request");

            HeadersRequestEventArgs args = HeadersRequestEventArgs.Create(headers);

            request.FireBeforeRequestEvent(this, args);
        }

        /**
         * Look for additional error strings in the response and return formatted exception
         */
        private static AmazonSQSException ReportAnyErrors(string responseBody, HttpStatusCode status)
        {
            AmazonSQSException ex = null;

            if (responseBody != null && responseBody.StartsWith("<"))
            {
                Match errorMatcherOne = Regex.Match(
                    responseBody,
                    "<RequestId>(.*)</RequestId>.*<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?",
                    RegexOptions.Multiline);
                Match errorMatcherTwo = Regex.Match(
                    responseBody,
                    "<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>",
                    RegexOptions.Multiline);

                if (errorMatcherOne.Success)
                {
                    string requestId = errorMatcherOne.Groups[1].Value;
                    string code = errorMatcherOne.Groups[2].Value;
                    string message = errorMatcherOne.Groups[3].Value;

                    ex = new AmazonSQSException(message, status, code, "Unknown", requestId, responseBody);
                }
                else if (errorMatcherTwo.Success)
                {
                    string code = errorMatcherTwo.Groups[1].Value;
                    string message = errorMatcherTwo.Groups[2].Value;
                    string requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new AmazonSQSException(message, status, code, "Unknown", requestId, responseBody);
                }
                else
                {
                    ex = new AmazonSQSException("Internal Error", status);
                }
            }
            else
            {
                ex = new AmazonSQSException("Internal Error", status);
            }
            return ex;
        }

        /**
         * Exponential sleep on failed request
         */
        private static void PauseOnRetry(int retries, int maxRetries, HttpStatusCode status, Exception cause)
        {
            if (retries <= maxRetries)
            {
                int delay = (int)Math.Pow(4, retries) * 100;
                System.Threading.Thread.Sleep(delay);
            }
            else
            {
                throw new AmazonSQSException(
                    "Maximum number of retry attempts reached : " + (retries - 1),
                    status,
                    cause
                    );
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> headers, IDictionary<string, string> parameters, string queueUrl)
        {
            using (ImmutableCredentials immutableCredentials = this.credentials.GetCredentials())
            {
                if (immutableCredentials.UseToken)
                {
                    parameters["SecurityToken"] = immutableCredentials.Token;
                }
                parameters["AWSAccessKeyId"] = immutableCredentials.AccessKey;
                parameters["SignatureVersion"] = config.SignatureVersion;
                parameters["SignatureMethod"] = config.SignatureMethod;
                parameters["Timestamp"] = AWSSDKUtils.FormattedCurrentTimestampISO8601;
                parameters["Version"] = config.ServiceVersion;
                if (!config.SignatureVersion.Equals("4"))
                {
                    throw new AmazonSQSException("Invalid Signature Version specified");
                }

                string region = this.config.AuthenticationRegion ?? AWSSDKUtils.DetermineRegion(queueUrl);
                string authorizationHeader = AWS4Signer.CalculateSignature(headers, parameters, queueUrl, "POST", "sqs", region, immutableCredentials);
                headers.Add("Authorization", authorizationHeader);
            }
        }

        /**
         * Convert CreateQueueRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateQueue(CreateQueueRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateQueue";
            if (request.IsSetQueueName())
            {
                parameters["QueueName"] = request.QueueName;
            }
            if (request.IsSetDefaultVisibilityTimeout())
            {
                parameters["DefaultVisibilityTimeout"] = request.DefaultVisibilityTimeout.ToString();
            }
            List<Attribute> createQueueRequestAttributeList = request.Attribute;
            int createQueueRequestAttributeListIndex = 1;
            foreach (Attribute createQueueRequestAttribute in createQueueRequestAttributeList)
            {
                if (createQueueRequestAttribute.IsSetName())
                {
                    parameters[String.Concat("Attribute", ".", createQueueRequestAttributeListIndex, ".", "Name")] = createQueueRequestAttribute.Name;
                }
                if (createQueueRequestAttribute.IsSetValue())
                {
                    parameters[String.Concat("Attribute", ".", createQueueRequestAttributeListIndex, ".", "Value")] = createQueueRequestAttribute.Value;
                }

                createQueueRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert ListQueuesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertListQueues(ListQueuesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ListQueues";
            if (request.IsSetQueueNamePrefix())
            {
                parameters["QueueNamePrefix"] = request.QueueNamePrefix;
            }
            List<Attribute> listQueuesRequestAttributeList = request.Attribute;
            int listQueuesRequestAttributeListIndex = 1;
            foreach (Attribute listQueuesRequestAttribute in listQueuesRequestAttributeList)
            {
                if (listQueuesRequestAttribute.IsSetName())
                {
                    parameters[String.Concat("Attribute", ".", listQueuesRequestAttributeListIndex, ".", "Name")] = listQueuesRequestAttribute.Name;
                }
                if (listQueuesRequestAttribute.IsSetValue())
                {
                    parameters[String.Concat("Attribute", ".", listQueuesRequestAttributeListIndex, ".", "Value")] = listQueuesRequestAttribute.Value;
                }

                listQueuesRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert ChangeMessageVisibilityRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertChangeMessageVisibility(ChangeMessageVisibilityRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ChangeMessageVisibility";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }
            if (request.IsSetReceiptHandle())
            {
                parameters["ReceiptHandle"] = request.ReceiptHandle;
            }
            if (request.IsSetVisibilityTimeout())
            {
                parameters["VisibilityTimeout"] = request.VisibilityTimeout.ToString();
            }
            List<Attribute> changeMessageVisibilityRequestAttributeList = request.Attribute;
            int changeMessageVisibilityRequestAttributeListIndex = 1;
            foreach (Attribute changeMessageVisibilityRequestAttribute in changeMessageVisibilityRequestAttributeList)
            {
                if (changeMessageVisibilityRequestAttribute.IsSetName())
                {
                    parameters[String.Concat("Attribute", ".", changeMessageVisibilityRequestAttributeListIndex, ".", "Name")] = changeMessageVisibilityRequestAttribute.Name;
                }
                if (changeMessageVisibilityRequestAttribute.IsSetValue())
                {
                    parameters[String.Concat("Attribute", ".", changeMessageVisibilityRequestAttributeListIndex, ".", "Value")] = changeMessageVisibilityRequestAttribute.Value;
                }

                changeMessageVisibilityRequestAttributeListIndex++;
            }

            return parameters;
        }

        private static IDictionary<string, string> ConvertChangeMessageVisibilityBatch(ChangeMessageVisibilityBatchRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ChangeMessageVisibilityBatch";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }

            int changeMessageVisibilityBatchRequestEntryListIndex = 1;
            foreach (ChangeMessageVisibilityBatchRequestEntry changeMessageVisibilityBatchRequestEntry in request.Entries)
            {
                if (changeMessageVisibilityBatchRequestEntry.IsSetId())
                {
                    parameters[String.Concat("ChangeMessageVisibilityBatchRequestEntry", ".", changeMessageVisibilityBatchRequestEntryListIndex, ".Id")] = changeMessageVisibilityBatchRequestEntry.Id;
                }

                if (changeMessageVisibilityBatchRequestEntry.IsSetReceiptHandle())
                {
                    parameters[String.Concat("ChangeMessageVisibilityBatchRequestEntry", ".", changeMessageVisibilityBatchRequestEntryListIndex, ".ReceiptHandle")] = changeMessageVisibilityBatchRequestEntry.ReceiptHandle;
                }

                if (changeMessageVisibilityBatchRequestEntry.IsSetVisibilityTimeout())
                {
                    parameters[String.Concat("ChangeMessageVisibilityBatchRequestEntry", ".", changeMessageVisibilityBatchRequestEntryListIndex, ".VisibilityTimeout")] = changeMessageVisibilityBatchRequestEntry.VisibilityTimeout.ToString();
                }

                changeMessageVisibilityBatchRequestEntryListIndex++;
            }



            return parameters;
        }

        /**
         * Convert DeleteMessageRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteMessage(DeleteMessageRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteMessage";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }
            if (request.IsSetReceiptHandle())
            {
                parameters["ReceiptHandle"] = request.ReceiptHandle;
            }
            List<Attribute> deleteMessageRequestAttributeList = request.Attribute;
            int deleteMessageRequestAttributeListIndex = 1;
            foreach (Attribute deleteMessageRequestAttribute in deleteMessageRequestAttributeList)
            {
                if (deleteMessageRequestAttribute.IsSetName())
                {
                    parameters[String.Concat("Attribute", ".", deleteMessageRequestAttributeListIndex, ".", "Name")] = deleteMessageRequestAttribute.Name;
                }
                if (deleteMessageRequestAttribute.IsSetValue())
                {
                    parameters[String.Concat("Attribute", ".", deleteMessageRequestAttributeListIndex, ".", "Value")] = deleteMessageRequestAttribute.Value;
                }

                deleteMessageRequestAttributeListIndex++;
            }

            return parameters;
        }

        private static IDictionary<string, string> ConvertDeleteMessageBatch(DeleteMessageBatchRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteMessageBatch";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }

            int deleteMessageBatchRequestEntryListIndex = 1;
            foreach (DeleteMessageBatchRequestEntry deleteMessageBatchRequestEntry in request.Entries)
            {
                if (deleteMessageBatchRequestEntry.IsSetId())
                {
                    parameters[String.Concat("DeleteMessageBatchRequestEntry", ".", deleteMessageBatchRequestEntryListIndex, ".Id")] = deleteMessageBatchRequestEntry.Id;
                }

                if (deleteMessageBatchRequestEntry.IsSetReceiptHandle())
                {
                    parameters[String.Concat("DeleteMessageBatchRequestEntry", ".", deleteMessageBatchRequestEntryListIndex, ".ReceiptHandle")] = deleteMessageBatchRequestEntry.ReceiptHandle;
                }

                deleteMessageBatchRequestEntryListIndex++;
            }

            return parameters;
        }

        /**
         * Convert DeleteQueueRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteQueue(DeleteQueueRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteQueue";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }
            List<Attribute> deleteQueueRequestAttributeList = request.Attribute;
            int deleteQueueRequestAttributeListIndex = 1;
            foreach (Attribute deleteQueueRequestAttribute in deleteQueueRequestAttributeList)
            {
                if (deleteQueueRequestAttribute.IsSetName())
                {
                    parameters[String.Concat("Attribute", ".", deleteQueueRequestAttributeListIndex, ".", "Name")] = deleteQueueRequestAttribute.Name;
                }
                if (deleteQueueRequestAttribute.IsSetValue())
                {
                    parameters[String.Concat("Attribute", ".", deleteQueueRequestAttributeListIndex, ".", "Value")] = deleteQueueRequestAttribute.Value;
                }

                deleteQueueRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert GetQueueAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertGetQueueAttributes(GetQueueAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "GetQueueAttributes";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }
            List<string> getQueueAttributesRequestAttributeNameList = request.AttributeName;
            int getQueueAttributesRequestAttributeNameListIndex = 1;
            foreach (string getQueueAttributesRequestAttributeName in getQueueAttributesRequestAttributeNameList)
            {
                parameters[String.Concat("AttributeName", ".", getQueueAttributesRequestAttributeNameListIndex)] = getQueueAttributesRequestAttributeName;
                getQueueAttributesRequestAttributeNameListIndex++;
            }

            return parameters;
        }


        /**
         * Convert GetQueueAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertGetQueueUrl(GetQueueUrlRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "GetQueueUrl";
            if (request.IsSetQueueName())
            {
                parameters["QueueName"] = request.QueueName;
            }
            if (request.IsSetQueueOwnerAWSAccountId())
            {
                parameters["QueueOwnerAWSAccountId"] = request.QueueOwnerAWSAccountId;
            }

            return parameters;
        }

        /**
         * Convert ReceiveMessageRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertReceiveMessage(ReceiveMessageRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ReceiveMessage";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }
            if (request.IsSetMaxNumberOfMessages())
            {
                parameters["MaxNumberOfMessages"] = request.MaxNumberOfMessages.ToString();
            }
            if (request.IsSetVisibilityTimeout())
            {
                parameters["VisibilityTimeout"] = request.VisibilityTimeout.ToString();
            }
            if (request.IsSetWaitTimeSeconds())
            {
                parameters["WaitTimeSeconds"] = request.WaitTimeSeconds.ToString();
            }
            List<string> receiveMessageRequestAttributeNameList = request.AttributeName;
            int receiveMessageRequestAttributeNameListIndex = 1;
            foreach (string receiveMessageRequestAttributeName in receiveMessageRequestAttributeNameList)
            {
                parameters[String.Concat("AttributeName", ".", receiveMessageRequestAttributeNameListIndex)] = receiveMessageRequestAttributeName;
                receiveMessageRequestAttributeNameListIndex++;
            }

            return parameters;
        }

        /**
         * Convert SendMessageRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertSendMessage(SendMessageRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "SendMessage";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }
            if (request.IsSetMessageBody())
            {
                parameters["MessageBody"] = request.MessageBody;
            }
            if (request.IsSetDelaySeconds())
            {
                parameters["DelaySeconds"] = request.DelaySeconds.ToString();
            }

            return parameters;
        }

        private static IDictionary<string, string> ConvertSendMessageBatch(SendMessageBatchRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "SendMessageBatch";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }

            int sendMessageBatchRequestEntryListIndex = 1;
            foreach (SendMessageBatchRequestEntry sendMessageBatchRequestEntry in request.Entries)
            {
                if (sendMessageBatchRequestEntry.IsSetId())
                {
                    parameters[String.Concat("SendMessageBatchRequestEntry", ".", sendMessageBatchRequestEntryListIndex, ".Id")] = sendMessageBatchRequestEntry.Id;
                }

                if (sendMessageBatchRequestEntry.IsSetMessageBody())
                {
                    parameters[String.Concat("SendMessageBatchRequestEntry", ".", sendMessageBatchRequestEntryListIndex, ".MessageBody")] = sendMessageBatchRequestEntry.MessageBody;
                }

                if (sendMessageBatchRequestEntry.IsSetDelaySeconds())
                {
                    parameters[String.Concat("SendMessageBatchRequestEntry", ".", sendMessageBatchRequestEntryListIndex, ".DelaySeconds")] = sendMessageBatchRequestEntry.DelaySeconds.ToString();
                }

                sendMessageBatchRequestEntryListIndex++;
            }

            return parameters;
        }

        /**
         * Convert SetQueueAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertSetQueueAttributes(SetQueueAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "SetQueueAttributes";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }
            List<Attribute> setQueueAttributesRequestAttributeList = request.Attribute;
            int setQueueAttributesRequestAttributeListIndex = 1;
            foreach (Attribute setQueueAttributesRequestAttribute in setQueueAttributesRequestAttributeList)
            {
                if (setQueueAttributesRequestAttribute.IsSetName())
                {
                    parameters[String.Concat("Attribute", ".", setQueueAttributesRequestAttributeListIndex, ".", "Name")] = setQueueAttributesRequestAttribute.Name;
                }
                if (setQueueAttributesRequestAttribute.IsSetValue())
                {
                    parameters[String.Concat("Attribute", ".", setQueueAttributesRequestAttributeListIndex, ".", "Value")] = setQueueAttributesRequestAttribute.Value;
                }

                setQueueAttributesRequestAttributeListIndex++;
            }

            return parameters;
        }

        /**
         * Convert AddPermissionRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertAddPermission(AddPermissionRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "AddPermission";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }
            if (request.IsSetLabel())
            {
                parameters["Label"] = request.Label;
            }
            List<string> addPermissionRequestAWSAccountIdList = request.AWSAccountId;
            int addPermissionRequestAWSAccountIdListIndex = 1;
            foreach (string addPermissionRequestAWSAccountId in addPermissionRequestAWSAccountIdList)
            {
                parameters[String.Concat("AWSAccountId", ".", addPermissionRequestAWSAccountIdListIndex)] = addPermissionRequestAWSAccountId;
                addPermissionRequestAWSAccountIdListIndex++;
            }
            List<string> addPermissionRequestActionNameList = request.ActionName;
            int addPermissionRequestActionNameListIndex = 1;
            foreach (string addPermissionRequestActionName in addPermissionRequestActionNameList)
            {
                parameters[String.Concat("ActionName", ".", addPermissionRequestActionNameListIndex)] = addPermissionRequestActionName;
                addPermissionRequestActionNameListIndex++;
            }

            return parameters;
        }

        /**
         * Convert RemovePermissionRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertRemovePermission(RemovePermissionRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "RemovePermission";
            if (request.IsSetQueueUrl())
            {
                parameters["QueueUrl"] = request.QueueUrl;
            }
            if (request.IsSetLabel())
            {
                parameters["Label"] = request.Label;
            }

            return parameters;
        }

        #endregion
    }
}
