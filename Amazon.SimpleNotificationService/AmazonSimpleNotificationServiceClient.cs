/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2010-03-31
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Xml;
using System.Xml.Xsl;
using System.Xml.Serialization;

using Amazon.Util;

using Amazon.SimpleNotificationService.Model;

namespace Amazon.SimpleNotificationService
{
    /// <summary>
    /// AmazonSimpleNotificationServiceClient is an implementation of AmazonSimpleNotificationService;
    /// the client allows you to manage your AmazonSimpleNotificationService resources.<br />
    /// If you want to use the AmazonSimpleNotificationServiceClient from a Medium Trust
    /// hosting environment, please create the client with an
    /// AmazonSimpleNotificationServiceConfig object whose UseSecureStringForAwsSecretKey
    /// property is false.
    /// </summary>
    /// <remarks>
    /// Amazon Simple Notification Service
    /// </remarks>
    /// <seealso cref="P:Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceConfig.UseSecureStringForAwsSecretKey"/>
    public class AmazonSimpleNotificationServiceClient : AmazonSimpleNotificationService
    {
        private string awsAccessKeyId;
        private SecureString awsSecretAccessKey;
        private AmazonSimpleNotificationServiceConfig config;
        private bool disposed;
        private string clearAwsSecretAccessKey;

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonSimpleNotificationServiceClient
        /// </summary>
        /// <param name="fDisposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool fDisposing)
        {
            if (!this.disposed)
            {
                if (fDisposing)
                {
                    //Remove Unmanaged Resources
                    // I.O.W. remove resources that have to be explicitly
                    // "Dispose"d or Closed
                    if (awsSecretAccessKey != null)
                    {
                        awsSecretAccessKey.Dispose();
                        awsSecretAccessKey = null;
                    }
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
        ~AmazonSimpleNotificationServiceClient()
        {
            this.Dispose(false);
        }

        #endregion

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSimpleNotificationServiceConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationService Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="config">The AmazonSimpleNotificationService Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSimpleNotificationServiceConfig config)
        {
            if (!String.IsNullOrEmpty(awsSecretAccessKey))
            {
                if (config.UseSecureStringForAwsSecretKey)
                {
                    this.awsSecretAccessKey = new SecureString();
                    foreach (char ch in awsSecretAccessKey.ToCharArray())
                    {
                        this.awsSecretAccessKey.AppendChar(ch);
                    }
                    this.awsSecretAccessKey.MakeReadOnly();
                }
                else
                {
                    clearAwsSecretAccessKey = awsSecretAccessKey;
                }
            }
            this.awsAccessKeyId = awsAccessKeyId;
            this.config = config;
        }

        /// <summary>
        /// Constructs an AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationService Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="config">The AmazonSimpleNotificationService Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, SecureString awsSecretAccessKey, AmazonSimpleNotificationServiceConfig config)
        {
            this.awsAccessKeyId = awsAccessKeyId;
            this.awsSecretAccessKey = awsSecretAccessKey;
            this.config = config;
        }

        #region Public API

        /// <summary>
        /// Confirm Subscription
        /// </summary>
        /// <param name="request">Confirm Subscription  request</param>
        /// <returns>Confirm Subscription  Response from the service</returns>
        /// <remarks>
        /// The ConfirmSubscription action verifies an endpoint owner's intent to receive messages by validating
        /// the token sent to the endpoint by an earlier Subscribe action. If the
        /// token is valid, the action creates a new subscription and returns its
        /// Amazon Resource Name (ARN). This call requires an AWS signature only when the AuthenticateOnUnsubscribe flag is set to "true".
        /// </remarks>
        public ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request)
        {
            return Invoke<ConfirmSubscriptionResponse>(ConvertConfirmSubscription(request));
        }

        /// <summary>
        /// Get Topic Attributes
        /// </summary>
        /// <param name="request">Get Topic Attributes  request</param>
        /// <returns>Get Topic Attributes  Response from the service</returns>
        /// <remarks>
        /// The GetTopicAttribtues action returns all of the properties of a topic customers have created. Topic
        /// properties returned might differ based on the authorization of the user.
        /// </remarks>
        public GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request)
        {
            return Invoke<GetTopicAttributesResponse>(ConvertGetTopicAttributes(request));
        }

        /// <summary>
        /// Subscribe
        /// </summary>
        /// <param name="request">Subscribe  request</param>
        /// <returns>Subscribe  Response from the service</returns>
        /// <remarks>
        /// The Subscribe action prepares to subscribe an endpoint by sending the endpoint a confirmation message. To actually create a
        /// subscription, the endpoint owner must call the ConfirmSubscription
        /// action with the token from the confirmation message. Confirmation tokens are
        /// valid for twenty-four hours.
        /// </remarks>
        public SubscribeResponse Subscribe(SubscribeRequest request)
        {
            return Invoke<SubscribeResponse>(ConvertSubscribe(request));
        }

        /// <summary>
        /// Set Topic Attributes
        /// </summary>
        /// <param name="request">Set Topic Attributes  request</param>
        /// <returns>Set Topic Attributes  Response from the service</returns>
        /// <remarks>
        /// The SetTopicAttributes action allows a topic owner to set an attribute of the topic to a new value.
        /// </remarks>
        public SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request)
        {
            return Invoke<SetTopicAttributesResponse>(ConvertSetTopicAttributes(request));
        }

        /// <summary>
        /// Delete Topic
        /// </summary>
        /// <param name="request">Delete Topic  request</param>
        /// <returns>Delete Topic  Response from the service</returns>
        /// <remarks>
        /// The DeleteTopic action deletes a topic and all its subscriptions. Deleting a topic might
        /// prevent some messages previously sent to the topic from being delivered to
        /// subscribers. This action is idempotent, so deleting a topic that does not
        /// exist will not result in an error.
        /// </remarks>
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            return Invoke<DeleteTopicResponse>(ConvertDeleteTopic(request));
        }

        /// <summary>
        /// Remove Permission
        /// </summary>
        /// <param name="request">Remove Permission  request</param>
        /// <returns>Remove Permission  Response from the service</returns>
        /// <remarks>
        /// The RemovePermission action removes a statement from a topic's access control policy.
        /// </remarks>
        public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            return Invoke<RemovePermissionResponse>(ConvertRemovePermission(request));
        }

        /// <summary>
        /// List Subscriptions
        /// </summary>
        /// <param name="request">List Subscriptions  request</param>
        /// <returns>List Subscriptions  Response from the service</returns>
        /// <remarks>
        /// The ListSubscriptions action returns a list of the requester's subscriptions. Each call returns a limited list
        /// of subscriptions. If there are more subscriptions, a NextToken is also returned. Use the NextToken parameter in a
        /// new ListSubscriptions call to get further results.
        /// </remarks>
        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            return Invoke<ListSubscriptionsResponse>(ConvertListSubscriptions(request));
        }

        /// <summary>
        /// Add Permission
        /// </summary>
        /// <param name="request">Add Permission  request</param>
        /// <returns>Add Permission  Response from the service</returns>
        /// <remarks>
        /// The AddPermission action adds a statement to a topic's access control policy, granting access for the specified AWS accounts to the specified actions.
        /// </remarks>
        public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            return Invoke<AddPermissionResponse>(ConvertAddPermission(request));
        }

        /// <summary>
        /// Create Topic
        /// </summary>
        /// <param name="request">Create Topic  request</param>
        /// <returns>Create Topic  Response from the service</returns>
        /// <remarks>
        /// The CreateTopic action creates a topic to which notifications can be published. Users can create
        /// at most 25 topics. This action is idempotent, so if the requester
        /// already owns a topic with the specified name, that topic's ARN will be
        /// returned without creating a new topic.
        /// </remarks>
        public CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            return Invoke<CreateTopicResponse>(ConvertCreateTopic(request));
        }

        /// <summary>
        /// List Topics
        /// </summary>
        /// <param name="request">List Topics  request</param>
        /// <returns>List Topics  Response from the service</returns>
        /// <remarks>
        /// The ListTopics action returns a list of the requester's topics. Each call returns a limited list of topics. If
        /// there are more topics, a NextToken is also returned. Use the NextToken parameter in a new ListTopics call to get
        /// further results.
        /// </remarks>
        public ListTopicsResponse ListTopics(ListTopicsRequest request)
        {
            return Invoke<ListTopicsResponse>(ConvertListTopics(request));
        }

        /// <summary>
        /// Unsubscribe
        /// </summary>
        /// <param name="request">Unsubscribe  request</param>
        /// <returns>Unsubscribe  Response from the service</returns>
        /// <remarks>
        /// The Unsubscribe action deletes a subscription. If the subscription requires authentication for
        /// deletion, only the owner of the subscription or the its topic's owner
        /// can unsubscribe, and an AWS signature is required. If the
        /// Unsubscribe call does not require authentication and the requester is not
        /// the subscription owner, a final cancellation message is delivered to the
        /// endpoint, so that the endpoint owner can easily resubscribe to the topic if
        /// the Unsubscribe request was unintended.
        /// </remarks>
        public UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            return Invoke<UnsubscribeResponse>(ConvertUnsubscribe(request));
        }

        /// <summary>
        /// List Subscriptions By Topic
        /// </summary>
        /// <param name="request">List Subscriptions By Topic  request</param>
        /// <returns>List Subscriptions By Topic  Response from the service</returns>
        /// <remarks>
        /// The ListSubscriptionsByTopic action returns a list of the subscriptions to a specific topic. Each call returns
        /// a limited list of subscriptions. If there are more subscriptions, a NextToken is also returned. Use the NextToken
        /// parameter in a new ListSubscriptionsByTopic call to get further results.
        /// </remarks>
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request)
        {
            return Invoke<ListSubscriptionsByTopicResponse>(ConvertListSubscriptionsByTopic(request));
        }

        /// <summary>
        /// Publish
        /// </summary>
        /// <param name="request">Publish  request</param>
        /// <returns>Publish  Response from the service</returns>
        /// <remarks>
        /// The Publish action sends a message to all of a topic's subscribed endpoints. When a
        /// messageId is returned, the message has been saved and Amazon SNS will attempt to deliver it
        /// to the topic's subscribers shortly. The format of the outgoing message to each
        /// subscribed endpoint depends on the notification protocol selected.
        /// </remarks>
        public PublishResponse Publish(PublishRequest request)
        {
            return Invoke<PublishResponse>(ConvertPublish(request));
        }

        #endregion

        #region Private API

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonSimpleNotificationServiceConfig instance
         */
        private static HttpWebRequest ConfigureWebRequest(int contentLength, AmazonSimpleNotificationServiceConfig config)
        {
            HttpWebRequest request = WebRequest.Create(config.ServiceURL) as HttpWebRequest;
            if (request != null)
            {
                if (config.IsSetProxyHost() && config.IsSetProxyPort())
                {
                    WebProxy proxy = new WebProxy(config.ProxyHost, config.ProxyPort);
                    if (config.IsSetProxyUsername())
                    {
                        proxy.Credentials = new NetworkCredential(
                            config.ProxyUsername,
                            config.ProxyPassword ?? String.Empty
                            );
                    }
                    request.Proxy = proxy;
                }
                request.UserAgent = config.UserAgent;
                request.Method = "POST";
                request.Timeout = 50000;
                request.ContentType = AWSSDKUtils.UrlEncodedContent;
                request.ContentLength = contentLength;

                request.ServicePoint.Expect100Continue = false;
                request.ServicePoint.UseNagleAlgorithm = false;
            }

            return request;
        }

        /**
         * Invoke request and return response
         */
        private T Invoke<T>(IDictionary<string, string> parameters)
        {
            string actionName = parameters["Action"];
            T response = default(T);
            HttpStatusCode statusCode = default(HttpStatusCode);

            /* Add required request parameters */
            AddRequiredParameters(parameters);

            string queryString = AWSSDKUtils.GetParametersAsString(parameters);

            byte[] requestData = Encoding.UTF8.GetBytes(queryString);
            bool shouldRetry = true;
            int retries = 0;
            int maxRetries = config.IsSetMaxErrorRetry() ? config.MaxErrorRetry : AWSSDKUtils.DefaultMaxRetry;

            do
            {
                string responseBody = null;
                HttpWebRequest request = ConfigureWebRequest(requestData.Length, config);
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

                    /* Perform response transformation */
                    if (responseBody.Trim().EndsWith(String.Concat(actionName, "Response>")))
                    {
                        responseBody = Transform(responseBody, this.GetType());
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
                        PauseOnRetry(++retries, maxRetries, statusCode);
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
                                throw new AmazonSimpleNotificationServiceException(
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
                            if (e is AmazonSimpleNotificationServiceException)
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

        /**
         * Look for additional error strings in the response and return formatted exception
         */
        private static AmazonSimpleNotificationServiceException ReportAnyErrors(string responseBody, HttpStatusCode status)
        {
            AmazonSimpleNotificationServiceException ex = null;

            if (responseBody != null &&
                responseBody.StartsWith("<"))
            {
                Match errorMatcherOne = Regex.Match(
                    responseBody,
                    "<RequestId>(.*)</RequestId>.*<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?",
                    RegexOptions.Multiline
                    );
                Match errorMatcherTwo = Regex.Match(
                    responseBody,
                    "<Error><Code>(.*)</Code><Message>(.*)</Message></Error>.*(<Error>)?.*<RequestID>(.*)</RequestID>",
                    RegexOptions.Multiline
                    );

                if (errorMatcherOne.Success)
                {
                    string requestId = errorMatcherOne.Groups[1].Value;
                    string code = errorMatcherOne.Groups[2].Value;
                    string message = errorMatcherOne.Groups[3].Value;

                    ex = new AmazonSimpleNotificationServiceException(message, status, code, "Unknown", requestId, responseBody);
                }
                else if (errorMatcherTwo.Success)
                {
                    string code = errorMatcherTwo.Groups[1].Value;
                    string message = errorMatcherTwo.Groups[2].Value;
                    string requestId = errorMatcherTwo.Groups[4].Value;

                    ex = new AmazonSimpleNotificationServiceException(message, status, code, "Unknown", requestId, responseBody);
                }
                else
                {
                    ex = new AmazonSimpleNotificationServiceException("Internal Error", status);
                }
            }
            else
            {
                ex = new AmazonSimpleNotificationServiceException("Internal Error", status);
            }
            return ex;
        }

        /**
         * Exponential sleep on failed request
         */
        private static void PauseOnRetry(int retries, int maxRetries, HttpStatusCode status)
        {
            if (retries <= maxRetries)
            {
                int delay = (int)Math.Pow(4, retries) * 100;
                System.Threading.Thread.Sleep(delay);
            }
            else
            {
                throw new AmazonSimpleNotificationServiceException(
                    "Maximum number of retry attempts reached : " + (retries - 1),
                    status
                    );
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> parameters)
        {
            if (String.IsNullOrEmpty(this.awsAccessKeyId))
            {
                throw new AmazonSimpleNotificationServiceException("The AWS Access Key ID cannot be NULL or a Zero length string");
            }

            parameters["AWSAccessKeyId"] = this.awsAccessKeyId;
            parameters["SignatureVersion"] = config.SignatureVersion;
            parameters["SignatureMethod"] = config.SignatureMethod;
            parameters["Timestamp"] = AWSSDKUtils.FormattedCurrentTimestampISO8601;
            parameters["Version"] = config.ServiceVersion;
            if (!config.SignatureVersion.Equals("2"))
            {
                throw new AmazonSimpleNotificationServiceException("Invalid Signature Version specified");
            }
            string toSign = AWSSDKUtils.CalculateStringToSignV2(parameters, config.ServiceURL);

            KeyedHashAlgorithm algorithm = KeyedHashAlgorithm.Create(config.SignatureMethod.ToUpper());
            string auth;

            if (config.UseSecureStringForAwsSecretKey)
            {
                auth = AWSSDKUtils.HMACSign(toSign, awsSecretAccessKey, algorithm);
            }
            else
            {
                auth = AWSSDKUtils.HMACSign(toSign, clearAwsSecretAccessKey, algorithm);
            }
            parameters["Signature"] = auth;
        }

        /**
         * Convert ConfirmSubscriptionRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertConfirmSubscription(ConfirmSubscriptionRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ConfirmSubscription";
            if (request.IsSetTopicArn())
            {
                parameters["TopicArn"] = request.TopicArn;
            }
            if (request.IsSetToken())
            {
                parameters["Token"] = request.Token;
            }
            if (request.IsSetAuthenticateOnUnsubscribe())
            {
                parameters["AuthenticateOnUnsubscribe"] = request.AuthenticateOnUnsubscribe;
            }

            return parameters;
        }

        /**
         * Convert GetTopicAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertGetTopicAttributes(GetTopicAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "GetTopicAttributes";
            if (request.IsSetTopicArn())
            {
                parameters["TopicArn"] = request.TopicArn;
            }

            return parameters;
        }

        /**
         * Convert SubscribeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertSubscribe(SubscribeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "Subscribe";
            if (request.IsSetTopicArn())
            {
                parameters["TopicArn"] = request.TopicArn;
            }
            if (request.IsSetProtocol())
            {
                parameters["Protocol"] = request.Protocol;
            }
            if (request.IsSetEndpoint())
            {
                parameters["Endpoint"] = request.Endpoint;
            }

            return parameters;
        }

        /**
         * Convert SetTopicAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertSetTopicAttributes(SetTopicAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "SetTopicAttributes";
            if (request.IsSetTopicArn())
            {
                parameters["TopicArn"] = request.TopicArn;
            }
            if (request.IsSetAttributeName())
            {
                parameters["AttributeName"] = request.AttributeName;
            }
            if (request.IsSetAttributeValue())
            {
                parameters["AttributeValue"] = request.AttributeValue;
            }

            return parameters;
        }

        /**
         * Convert DeleteTopicRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertDeleteTopic(DeleteTopicRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "DeleteTopic";
            if (request.IsSetTopicArn())
            {
                parameters["TopicArn"] = request.TopicArn;
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
            if (request.IsSetTopicArn())
            {
                parameters["TopicArn"] = request.TopicArn;
            }
            if (request.IsSetLabel())
            {
                parameters["Label"] = request.Label;
            }

            return parameters;
        }

        /**
         * Convert ListSubscriptionsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertListSubscriptions(ListSubscriptionsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ListSubscriptions";
            if (request.IsSetNextToken())
            {
                parameters["NextToken"] = request.NextToken;
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
            if (request.IsSetTopicArn())
            {
                parameters["TopicArn"] = request.TopicArn;
            }
            if (request.IsSetLabel())
            {
                parameters["Label"] = request.Label;
            }
            List<string> addPermissionRequestAWSAccountIdsList = request.AWSAccountIds;
            int addPermissionRequestAWSAccountIdsListIndex = 1;
            foreach (string addPermissionRequestAWSAccountIds in addPermissionRequestAWSAccountIdsList)
            {
                parameters[String.Concat("AWSAccountIds", ".member.", addPermissionRequestAWSAccountIdsListIndex)] = addPermissionRequestAWSAccountIds;
                addPermissionRequestAWSAccountIdsListIndex++;
            }
            List<string> addPermissionRequestActionNamesList = request.ActionNames;
            int addPermissionRequestActionNamesListIndex = 1;
            foreach (string addPermissionRequestActionNames in addPermissionRequestActionNamesList)
            {
                parameters[String.Concat("ActionNames", ".member.", addPermissionRequestActionNamesListIndex)] = addPermissionRequestActionNames;
                addPermissionRequestActionNamesListIndex++;
            }

            return parameters;
        }

        /**
         * Convert CreateTopicRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertCreateTopic(CreateTopicRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "CreateTopic";
            if (request.IsSetName())
            {
                parameters["Name"] = request.Name;
            }

            return parameters;
        }

        /**
         * Convert ListTopicsRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertListTopics(ListTopicsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ListTopics";
            if (request.IsSetNextToken())
            {
                parameters["NextToken"] = request.NextToken;
            }

            return parameters;
        }

        /**
         * Convert UnsubscribeRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertUnsubscribe(UnsubscribeRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "Unsubscribe";
            if (request.IsSetSubscriptionArn())
            {
                parameters["SubscriptionArn"] = request.SubscriptionArn;
            }

            return parameters;
        }

        /**
         * Convert ListSubscriptionsByTopicRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ListSubscriptionsByTopic";
            if (request.IsSetTopicArn())
            {
                parameters["TopicArn"] = request.TopicArn;
            }
            if (request.IsSetNextToken())
            {
                parameters["NextToken"] = request.NextToken;
            }

            return parameters;
        }

        /**
         * Convert PublishRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertPublish(PublishRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "Publish";
            if (request.IsSetTopicArn())
            {
                parameters["TopicArn"] = request.TopicArn;
            }
            if (request.IsSetMessage())
            {
                parameters["Message"] = request.Message;
            }
            if (request.IsSetSubject())
            {
                parameters["Subject"] = request.Subject;
            }

            return parameters;
        }

        /*
         *  Transforms response based on xslt template
         */
        private static string Transform(string responseBody, Type t)
        {
            XslCompiledTransform transformer = new XslCompiledTransform();

            // Build the name of the xslt transform to apply to the response
            char[] seps = { ',' };

            Assembly assembly = Assembly.GetAssembly(t);
            string assemblyName = assembly.FullName;
            assemblyName = assemblyName.Split(seps)[0];

            string ns = t.Namespace;
            string resourceName = String.Concat(
                assemblyName,
                ".",
                ns,
                ".Model.",
                "ResponseTransformer.xslt"
                );
            using (XmlTextReader xmlReader = new XmlTextReader(assembly.GetManifestResourceStream(resourceName)))
            {
                transformer.Load(xmlReader);

                StringBuilder sb = new StringBuilder(1024);
                using (XmlTextReader xmlR = new XmlTextReader(new StringReader(responseBody)))
                {
                    using (StringWriter sw = new StringWriter(sb))
                    {
                        transformer.Transform(xmlR, null, sw);
                        return sb.ToString();
                    }
                }
            }
        }

        #endregion
    }
}
