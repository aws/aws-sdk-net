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
using Amazon.Runtime;
using Amazon.Runtime.Internal;

using ErrorResponse = Amazon.SimpleNotificationService.Model.ErrorResponse;
using Amazon.Runtime.Internal.Auth;

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
        private bool ownCredentials;
        private AWSCredentials credentials;
        private AmazonSimpleNotificationServiceConfig config;
        private bool disposed;

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
        ~AmazonSimpleNotificationServiceClient()
        {
            this.Dispose(false);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleNotificationServiceClient()
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig(), true) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
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
        public AmazonSimpleNotificationServiceClient(RegionEndpoint region)
            : this(FallbackCredentialsFactory.GetCredentials(), new AmazonSimpleNotificationServiceConfig() { RegionEndpoint = region }, true) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSimpleNotificationService Configuration Object</param>
        public AmazonSimpleNotificationServiceClient(AmazonSimpleNotificationServiceConfig config)
            : this(FallbackCredentialsFactory.GetCredentials(), config, true) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonSimpleNotificationServiceConfig(), true) { }

        /// <summary>
        /// Constructs AmazonSimpleNotificationServiceClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect to.</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonSimpleNotificationServiceConfig() { RegionEndpoint = region }, true) { }

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
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), config, true) { }

        /// <summary>
        /// Constructs an AmazonSimpleNotificationServiceClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSimpleNotificationService Configuration object
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key as a SecureString</param>
        /// <param name="region">The region to connect to.</param>
        public AmazonSimpleNotificationServiceClient(string awsAccessKeyId, SecureString awsSecretAccessKey, RegionEndpoint region)
            : this(new BasicAWSCredentials(awsAccessKeyId, awsSecretAccessKey), new AmazonSimpleNotificationServiceConfig() { RegionEndpoint = region }, true) { }

        /// <summary>
        /// Constructs an AmazonSimpleNotificationServiceClient with AWSCredentials
        /// </summary>
        /// <param name="credentials"></param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials)
            : this(credentials, new AmazonSimpleNotificationServiceConfig()) { }

        /// <summary>
        /// Constructs an AmazonSimpleNotificationServiceClient with AWSCredentials
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="region">The region to connect to.</param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSimpleNotificationServiceConfig() { RegionEndpoint = region }) { }

        /// <summary>
        /// Constructs an AmazonSimpleNotificationServiceClient with AWSCredentials and an
        /// AmazonSimpleNotificationService Configuration object
        /// </summary>
        /// <param name="credentials"></param>
        /// <param name="config"></param>
        public AmazonSimpleNotificationServiceClient(AWSCredentials credentials, AmazonSimpleNotificationServiceConfig config)
            : this(credentials, config, false) { }

        // Constructs an AmazonSimpleNotificationServiceClient with credentials, config and flag which
        // specifies if the credentials are owned by the client or not
        private AmazonSimpleNotificationServiceClient(AWSCredentials credentials, AmazonSimpleNotificationServiceConfig config, bool ownCredentials)
        {
            this.credentials = credentials;
            this.config = config;
            this.ownCredentials = ownCredentials;
        }

        #endregion

        #region Public API

        /// <summary>
        /// Verifies an endpoint owner's intent to receive messages by validating the token
        /// sent to the endpoint by an earlier Subscribe action.
        /// If the token is valid, the action creates a new subscription and returns its
        /// Amazon Resource Name (ARN).
        /// </summary>
        /// <remarks>
        /// This call requires an AWS signature only when the AuthenticateOnUnsubscribe
        /// flag is set to "true".
        /// </remarks>
        /// <param name="request">Confirm Subscription  request</param>
        /// <returns>Confirm Subscription  Response from the service</returns>
        public ConfirmSubscriptionResponse ConfirmSubscription(ConfirmSubscriptionRequest request)
        {
            return Invoke<ConfirmSubscriptionResponse>(request, ConvertConfirmSubscription(request));
        }

        /// <summary>
        /// Returns all of the properties of a topic customers have created. Topic
        /// properties returned might differ based on the authorization of the user.
        /// </summary>
        /// <param name="request">Get Topic Attributes  request</param>
        /// <returns>Get Topic Attributes  Response from the service</returns>
        public GetTopicAttributesResponse GetTopicAttributes(GetTopicAttributesRequest request)
        {
            return Invoke<GetTopicAttributesResponse>(request, ConvertGetTopicAttributes(request));
        }

        /// <summary>
        /// Prepares to subscribe an endpoint by sending the endpoint a confirmation message.
        /// </summary>
        /// <remarks>
        /// To actually create a subscription, the endpoint owner must call the ConfirmSubscription
        /// action with the token from the confirmation message. Confirmation tokens are valid for three days.
        /// </remarks>
        /// <param name="request">Subscribe  request</param>
        /// <returns>Subscribe  Response from the service</returns>
        public SubscribeResponse Subscribe(SubscribeRequest request)
        {
            return Invoke<SubscribeResponse>(request, ConvertSubscribe(request));
        }

        /// <summary>
        /// Sets an attribute of a topic to a new value.
        /// </summary>
        /// <param name="request">Set Topic Attributes  request</param>
        /// <returns>Set Topic Attributes  Response from the service</returns>
        public SetTopicAttributesResponse SetTopicAttributes(SetTopicAttributesRequest request)
        {
            return Invoke<SetTopicAttributesResponse>(request, ConvertSetTopicAttributes(request));
        }

        /// <summary>
        /// Returns all of the properties of a subscription customers have created. Subscription
        /// properties returned might differ based on the authorization of the user.
        /// </summary>
        /// <param name="request">Get Subscription Attributes  request</param>
        /// <returns>Get Subscription Attributes  Response from the service</returns>
        public GetSubscriptionAttributesResponse GetSubscriptionAttributes(GetSubscriptionAttributesRequest request)
        {
            return Invoke<GetSubscriptionAttributesResponse>(request, ConvertGetSubscriptionAttributes(request));
        }

        /// <summary>
        /// Sets an attribute of the topic to a new value.
        /// </summary>
        /// <param name="request">Set Subscription Attributes  request</param>
        /// <returns>Set Subscription Attributes  Response from the service</returns>
        public SetSubscriptionAttributesResponse SetSubscriptionAttributes(SetSubscriptionAttributesRequest request)
        {
            return Invoke<SetSubscriptionAttributesResponse>(request, ConvertSetSubscriptionAttributes(request));
        }

        /// <summary>
        /// Deletes a topic and all its subscriptions.
        /// Deleting a topic might prevent some messages previously sent to the topic from being delivered to
        /// subscribers.
        /// </summary>
        /// <remarks>
        /// This operation is idempotent, so deleting a topic that does not
        /// exist will not result in an error.
        /// </remarks>
        /// <param name="request">Delete Topic  request</param>
        /// <returns>Delete Topic  Response from the service</returns>
        public DeleteTopicResponse DeleteTopic(DeleteTopicRequest request)
        {
            return Invoke<DeleteTopicResponse>(request, ConvertDeleteTopic(request));
        }

        /// <summary>
        /// Removes a statement from a topic's access control policy.
        /// </summary>
        /// <param name="request">Remove Permission  request</param>
        /// <returns>Remove Permission  Response from the service</returns>
        public RemovePermissionResponse RemovePermission(RemovePermissionRequest request)
        {
            return Invoke<RemovePermissionResponse>(request, ConvertRemovePermission(request));
        }

        /// <summary>
        /// Returns a list of the requester's subscriptions.
        /// </summary>
        /// <remarks>
        /// Each call returns a limited list of subscriptions. If there are more subscriptions,
        /// a NextToken is also returned. Use the NextToken parameter in a new ListSubscriptions
        /// call to get further results.
        /// </remarks>
        /// <param name="request">List Subscriptions  request</param>
        /// <returns>List Subscriptions  Response from the service</returns>
        public ListSubscriptionsResponse ListSubscriptions(ListSubscriptionsRequest request)
        {
            return Invoke<ListSubscriptionsResponse>(request, ConvertListSubscriptions(request));
        }

        /// <summary>
        /// Adds a statement to a topic's access control policy, granting access for the specified AWS accounts to the specified actions.
        /// </summary>
        /// <param name="request">Add Permission  request</param>
        /// <returns>Add Permission  Response from the service</returns>
        public AddPermissionResponse AddPermission(AddPermissionRequest request)
        {
            return Invoke<AddPermissionResponse>(request, ConvertAddPermission(request));
        }

        /// <summary>
        /// Creates a topic to which notifications can be published. Users can create
        /// at most 25 topics.
        /// </summary>
        /// <remarks>
        /// This action is idempotent, so if the requester
        /// already owns a topic with the specified name, that topic's ARN will be
        /// returned without creating a new topic.
        /// </remarks>
        /// <param name="request">Create Topic  request</param>
        /// <returns>Create Topic  Response from the service</returns>
        public CreateTopicResponse CreateTopic(CreateTopicRequest request)
        {
            return Invoke<CreateTopicResponse>(request, ConvertCreateTopic(request));
        }

        /// <summary>
        /// Returns a list of the requester's topics.
        /// </summary>
        /// <remarks>
        /// Each call returns a limited list of topics. If there are more topics,
        /// a NextToken is also returned. Use the NextToken parameter in a new
        /// ListTopics call to get further results.
        /// </remarks>
        /// <param name="request">List Topics  request</param>
        /// <returns>List Topics  Response from the service</returns>
        public ListTopicsResponse ListTopics(ListTopicsRequest request)
        {
            return Invoke<ListTopicsResponse>(request, ConvertListTopics(request));
        }

        /// <summary>
        /// Deletes a subscription.
        /// </summary>
        /// <remarks>
        /// If the subscription requires authentication for deletion, only the owner
        /// of the subscription or the its topic's owner can unsubscribe, and an AWS
        /// signature is required.
        /// If the Unsubscribe call does not require authentication and the requester is not
        /// the subscription owner, a final cancellation message is delivered to the
        /// endpoint, so that the endpoint owner can easily resubscribe to the topic if
        /// the Unsubscribe request was unintended.
        /// </remarks>
        /// <param name="request">Unsubscribe  request</param>
        /// <returns>Unsubscribe  Response from the service</returns>
        public UnsubscribeResponse Unsubscribe(UnsubscribeRequest request)
        {
            return Invoke<UnsubscribeResponse>(request, ConvertUnsubscribe(request));
        }

        /// <summary>
        /// Returns a list of the subscriptions to a specific topic.
        /// </summary>
        /// <remarks>
        /// Each call returns a limited list of subscriptions. If there are more subscriptions,
        /// a NextToken is also returned. Use the NextToken parameter in a new ListSubscriptionsByTopic
        /// call to get further results.
        /// </remarks>
        /// <param name="request">List Subscriptions By Topic  request</param>
        /// <returns>List Subscriptions By Topic  Response from the service</returns>
        public ListSubscriptionsByTopicResponse ListSubscriptionsByTopic(ListSubscriptionsByTopicRequest request)
        {
            return Invoke<ListSubscriptionsByTopicResponse>(request, ConvertListSubscriptionsByTopic(request));
        }

        /// <summary>
        /// Sends a message to all of a topic's subscribed endpoints.
        /// </summary>
        /// <remarks>
        /// When a messageId is returned, the message has been saved and Amazon SNS will
        /// attempt to deliver it to the topic's subscribers shortly.
        /// The format of the outgoing message to each subscribed endpoint depends on the
        /// notification protocol selected.
        /// </remarks>
        /// <param name="request">Publish  request</param>
        /// <returns>Publish  Response from the service</returns>
        public PublishResponse Publish(PublishRequest request)
        {
            return Invoke<PublishResponse>(request, ConvertPublish(request));
        }

        /// <summary>
        /// Creates a platform application object for one of the supported push notification services, 
        /// such as APNS and GCM, to which devices and mobile apps may register.
        /// </summary>
        /// <remarks>
        /// You must specify PlatformPrincipal and PlatformCredential attributes when using this method.
        /// The PlatformPrincipal is received from the notification service. For APNS/APNS_SANDBOX, PlatformPrincipal is "SSL certificate". 
        /// For GCM, PlatformPrincipal is not applicable. For ADM PlatformPrincipal is "client id". The PlatformCredential is also received from the notification service. 
        /// For APNS/APNS_SANDBOX, PlatformCredential is "private key". For GCM, PlatformCredential is "API key". For ADM, PlatformCredential is "client secret".   
        /// The PlatformApplicationArn that is returned by this method is then used as an attribute for the <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.CreatePlatformEndpoint"/> method.
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>. 
        /// </remarks>
        /// <param name="request">Create Platform Application request.</param>
        /// <returns>Create Platform Application response from the service.</returns>
        public CreatePlatformApplicationResponse CreatePlatformApplication(CreatePlatformApplicationRequest request)
        {
            return Invoke<CreatePlatformApplicationResponse>(request, ConvertCreatePlatformApplication(request));
        }

        /// <summary>
        /// Creates an endpoint for a device on one of the supported push notification services, such as GCM and APNS.
        /// </summary>
        /// <remarks>
        /// This method requires the PlatformApplicationArn that is returned from <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.CreatePlatformApplication"/>. 
        /// The EndpointArn that is returned when using this method can then be used by the <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.Publish"/> method to 
        /// send a message to a mobile app or by the <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.Subscribe"/> action for subscription to a topic.        
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Create Platform Endpoint request.</param>
        /// <returns>Create Platform Endpoint response from the service.</returns>
        public CreatePlatformEndpointResponse CreatePlatformEndpoint(CreatePlatformEndpointRequest request)
        {
            return Invoke<CreatePlatformEndpointResponse>(request, ConvertCreatePlatformEndpoint(request));
        }

        /// <summary>
        /// Deletes the endpoint for a device on one of the supported push notification services, such as GCM and APNS. 
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Delete Endpoint request.</param>
        /// <returns>Delete Endpoint response from the service.</returns>
        public DeleteEndpointResponse DeleteEndpoint(DeleteEndpointRequest request)
        {
            return Invoke<DeleteEndpointResponse>(request, ConvertDeleteEndpoint(request));
        }

        /// <summary>
        /// Deletes a platform application object for one of the supported push notification services, 
        /// such as APNS and GCM.
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Delete Platform Application request.</param>
        /// <returns>Delete Platform Application response from the service.</returns>
        public DeletePlatformApplicationResponse DeletePlatformApplication(DeletePlatformApplicationRequest request)
        {
            return Invoke<DeletePlatformApplicationResponse>(request, ConvertDeletePlatformApplicationResponse(request));
        }

        /// <summary>
        /// Sets the attributes of the platform application object for the supported push notification services, 
        /// such as APNS and GCM.
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Set Platform Application Attributes request.</param>
        /// <returns>Set Platform Application Attributes response from the service.</returns>
        public SetPlatformApplicationAttributesResponse SetPlatformApplicationAttributes(SetPlatformApplicationAttributesRequest request)
        {
            return Invoke<SetPlatformApplicationAttributesResponse>(request, ConvertSetPlatformApplicationAttributesResponse(request));
        }

        /// <summary>
        /// Sets the attributes for the an endpoint for a device on one of the supported push notification services, such as GCM and APNS.
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Set Endpoint Attributes request.</param>
        /// <returns>Set Endpoint Attributes response from the service.</returns>
        public SetEndpointAttributesResponse SetEndpointAttributes(SetEndpointAttributesRequest request)
        {
            return Invoke<SetEndpointAttributesResponse>(request, ConvertSetEndpointAttributesResponse(request));
        }

        /// <summary>
        /// Retrieves the attributes of the platform application object for the supported push notification services, 
        /// such as APNS and GCM.
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Get Platform Application Attributes request.</param>
        /// <returns>Get Platform Application Attributes response from the service.</returns>
        public GetPlatformApplicationAttributesResponse GetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request)
        {
            return Invoke<GetPlatformApplicationAttributesResponse>(request, ConvertGetPlatformApplicationAttributes(request));
        }

        /// <summary>
        /// Retrieves the endpoint attributes for a device on one of the supported push notification services, such as GCM and APNS. 
        /// </summary>
        /// <remarks>
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">Get Endpoint Attributes request.</param>
        /// <returns>Get Endpoint Attributes response from the service.</returns>
        public GetEndpointAttributesResponse GetEndpointAttributes(GetEndpointAttributesRequest request)
        {
            return Invoke<GetEndpointAttributesResponse>(request, ConvertGetEndpointAttributes(request));
        }

        /// <summary>
        /// Lists the platform application objects for the supported push notification services, 
        /// such as APNS and GCM.
        /// </summary>
        /// <remarks>
        /// The results for this method are paginated and return a limited list of applications, up to 100.
        /// If additional records are available after the first page results, then a NextToken string will be returned. 
        /// To receive the next page, you call this method again using the NextToken string received from the previous call. 
        /// When there are no more records to return, NextToken will be null.
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">List Platform Applications request.</param>
        /// <returns>List Platform Applications response from the service.</returns>
        public ListPlatformApplicationsResponse ListPlatformApplications(ListPlatformApplicationsRequest request)
        {
            return Invoke<ListPlatformApplicationsResponse>(request, ConvertListPlatformApplications(request));
        }

        /// <summary>
        /// Lists the endpoints and endpoint attributes for devices in a supported push notification service, such as GCM and APNS.
        /// </summary>
        /// <remarks>
        /// The results for this method are paginated and return a limited list of endpoints, up to 100.
        /// If additional records are available after the first page results, then a NextToken string will be returned. 
        /// To receive the next page, you call this method again using the NextToken string received from the previous call. 
        /// When there are no more records to return, NextToken will be null.
        /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
        /// </remarks>
        /// <param name="request">List Endpoints By Platform Application request.</param>
        /// <returns>List Endpoints By Platform Application response from the service.</returns>
        public ListEndpointsByPlatformApplicationResponse ListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request)
        {
            return Invoke<ListEndpointsByPlatformApplicationResponse>(request, ConvertListEndpointsByPlatformApplication(request));
        }
        
        #endregion

        #region Private API

        /**
         * Configure HttpClient with set of defaults as well as configuration
         * from AmazonSimpleNotificationServiceConfig instance
         */
        private static HttpWebRequest ConfigureWebRequest(int contentLength, string url, AmazonSimpleNotificationServiceConfig config, IDictionary<string, string> headers)
        {
            HttpWebRequest request = WebRequest.Create(url) as HttpWebRequest;
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
        private T Invoke<T>(SNSRequest snsRequest, IDictionary<string, string> parameters)
        {
            string actionName = parameters["Action"];
            T response = default(T);
            HttpStatusCode statusCode = default(HttpStatusCode);

            string url;
            if (config.RegionEndpoint != null)
                url = "https://" + config.RegionEndpoint.GetEndpointForService(config.RegionEndpointServiceName).Hostname;
            else
                url = config.ServiceURL;

            /* Add required request parameters */
            IDictionary<string, string> headers = new Dictionary<string, string>();
            headers[AWSSDKUtils.UserAgentHeader] = config.UserAgent;
            ProcessRequestHandlers(snsRequest, headers);
            AddRequiredParameters(headers, parameters, url);

            string queryString = AWSSDKUtils.GetParametersAsString(parameters);
            byte[] requestData = Encoding.UTF8.GetBytes(queryString);

            bool shouldRetry = true;
            int retries = 0;
            int maxRetries = config.IsSetMaxErrorRetry() ? config.MaxErrorRetry : AWSSDKUtils.DefaultMaxRetry;

            do
            {
                string responseBody = null;

                HttpWebRequest request = ConfigureWebRequest(requestData.Length, url, config, headers);

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

        protected virtual void ProcessRequestHandlers(IRequestEvents request, IDictionary<string, string> headers)
        {
            if (request == null) throw new ArgumentNullException("request");

            HeadersRequestEventArgs args = HeadersRequestEventArgs.Create(headers);

            request.FireBeforeRequestEvent(this, args);
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
        private static void PauseOnRetry(int retries, int maxRetries, HttpStatusCode status, Exception cause)
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
                    status,
                    cause
                    );
            }
        }

        /**
         * Add authentication related and version parameters
         */
        private void AddRequiredParameters(IDictionary<string, string> headers, IDictionary<string, string> parameters, string url)
        {
            using (ImmutableCredentials immutableCredentials = this.credentials.GetCredentials())
            {
                if (String.IsNullOrEmpty(immutableCredentials.AccessKey))
                {
                    throw new AmazonSimpleNotificationServiceException("The AWS Access Key ID cannot be NULL or a Zero length string");
                }

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
                    throw new AmazonSimpleNotificationServiceException("Invalid Signature Version specified");
                }
                string region = this.config.AuthenticationRegion ?? AWSSDKUtils.DetermineRegion(url);
                string authorizationHeader = AWS4Signer.CalculateSignature(headers,
                                                                           parameters,
                                                                           url,
                                                                           "POST",
                                                                           "sns",
                                                                           region,
                                                                           immutableCredentials);
                headers.Add("Authorization", authorizationHeader);
            }
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
         * Convert GetSubscriptionAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertGetSubscriptionAttributes(GetSubscriptionAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "GetSubscriptionAttributes";
            if (request.IsSetSubscriptionArn())
            {
                parameters["SubscriptionArn"] = request.SubscriptionArn;
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
         * Convert SetSubscriptionAttributesRequest to name value pairs
         */
        private static IDictionary<string, string> ConvertSetSubscriptionAttributes(SetSubscriptionAttributesRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "SetSubscriptionAttributes";
            if (request.IsSetSubscriptionArn())
            {
                parameters["SubscriptionArn"] = request.SubscriptionArn;
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
                parameters[String.Concat("AWSAccountId", ".member.", addPermissionRequestAWSAccountIdsListIndex)] = addPermissionRequestAWSAccountIds;
                addPermissionRequestAWSAccountIdsListIndex++;
            }
            List<string> addPermissionRequestActionNamesList = request.ActionNames;
            int addPermissionRequestActionNamesListIndex = 1;
            foreach (string addPermissionRequestActionNames in addPermissionRequestActionNamesList)
            {
                parameters[String.Concat("ActionName", ".member.", addPermissionRequestActionNamesListIndex)] = addPermissionRequestActionNames;
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
            if (request.IsSetMessageStructure())
            {
                parameters["MessageStructure"] = request.MessageStructure;
            }
            if (request.IsSetSubject())
            {
                parameters["Subject"] = request.Subject;
            }
            if (request.IsSetTargetArn())
            {
                parameters["TargetArn"] = request.TargetArn;
            }

            return parameters;
        }

        /**
         * Convert CreatePlatformApplicationRequest to name value pairs
         */
        private IDictionary<string, string> ConvertCreatePlatformApplication(CreatePlatformApplicationRequest request)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["Action"] = "CreatePlatformApplication";

            if (request.IsSetName())
                parameters["Name"] = request.Name;

            if (request.IsSetPlatform())
                parameters["Platform"] = request.Platform;

            if (request.IsSetAttributes())
            {
                int i = 1;

                foreach (var kvp in request.Attributes)
                {
                    string k = String.Format("Attributes.entry.{0}.key", i);
                    parameters[k] = kvp.Key;

                    string v = String.Format("Attributes.entry.{0}.value", i);
                    parameters[v] = kvp.Value;

                    ++i;
                }
            }

            return parameters;
        }

        /**
         * Convert CreatePlatformEndpointRequest to name value pairs
         */
        private IDictionary<string, string> ConvertCreatePlatformEndpoint(CreatePlatformEndpointRequest request)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["Action"] = "CreatePlatformEndpoint";

            if (request.IsSetPlatformApplicationArn())
                parameters["PlatformApplicationArn"] = request.PlatformApplicationArn;

            if (request.IsSetToken())
                parameters["Token"] = request.Token;

            if (request.IsSetCustomUserData())
                parameters["CustomUserData"] = request.CustomUserData;

            if (request.IsSetAttributes())
            {
                int i = 1;

                foreach (var kvp in request.Attributes)
                {
                    string k = String.Format("Attributes.entry.{0}.key", i);
                    parameters[k] = kvp.Key;

                    string v = String.Format("Attributes.entry.{0}.value", i);
                    parameters[v] = kvp.Value;

                    ++i;
                }
            }

            return parameters;
        }

        /**
         * Convert DeleteEndpointRequest to name value pairs
         */
        private IDictionary<string, string> ConvertDeleteEndpoint(DeleteEndpointRequest request)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["Action"] = "DeleteEndpoint";

            if (request.IsSetEndpointArn())
                parameters["EndpointArn"] = request.EndpointArn;

            return parameters;
        }

        /**
         * Convert DeletePlatformApplicationRequest to name value pairs
         */
        private IDictionary<string, string> ConvertDeletePlatformApplicationResponse(DeletePlatformApplicationRequest request)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["Action"] = "DeletePlatformApplication";

            if (request.IsSetPlatformApplicationArn())
                parameters["PlatformApplicationArn"] = request.PlatformApplicationArn;

            return parameters;
        }

        /**
         * Convert SetPlatformApplicationAttributesRequest to name value pairs
         */
        private IDictionary<string, string> ConvertSetPlatformApplicationAttributesResponse(SetPlatformApplicationAttributesRequest request)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["Action"] = "SetPlatformApplicationAttributes";

            if (request.IsSetPlatformApplicationArn())
                parameters["PlatformApplicationArn"] = request.PlatformApplicationArn;

            if (request.IsSetAttributes())
            {
                int i = 1;

                foreach (var kvp in request.Attributes)
                {
                    string k = String.Format("Attributes.entry.{0}.key", i);
                    parameters[k] = kvp.Key;

                    string v = String.Format("Attributes.entry.{0}.value", i);
                    parameters[v] = kvp.Value;

                    ++i;
                }
            }

            return parameters;
        }

        /**
         * Convert SetEndpointAttributesRequest to name value pairs
         */
        private IDictionary<string, string> ConvertSetEndpointAttributesResponse(SetEndpointAttributesRequest request)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["Action"] = "SetEndpointAttributes";

            if (request.IsSetEndpointArn())
                parameters["EndpointArn"] = request.EndpointArn;

            if (request.IsSetAttributes())
            {
                int i = 1;

                foreach (var kvp in request.Attributes)
                {
                    string k = String.Format("Attributes.entry.{0}.key", i);
                    parameters[k] = kvp.Key;

                    string v = String.Format("Attributes.entry.{0}.value", i);
                    parameters[v] = kvp.Value;

                    ++i;
                }
            }

            return parameters;
        }

        /**
         * Convert GetPlatformApplicationAttributesRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetPlatformApplicationAttributes(GetPlatformApplicationAttributesRequest request)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["Action"] = "GetPlatformApplicationAttributes";

            if (request.IsSetPlatformApplicationArn())
                parameters["PlatformApplicationArn"] = request.PlatformApplicationArn;

            return parameters;
        }

        /**
         * Convert GetEndpointAttributesRequest to name value pairs
         */
        private IDictionary<string, string> ConvertGetEndpointAttributes(GetEndpointAttributesRequest request)
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            parameters["Action"] = "GetEndpointAttributes";

            if (request.IsSetEndpointArn())
                parameters["EndpointArn"] = request.EndpointArn;

            return parameters;
        }

        /**
         * Convert ListEndpointsByPlatformApplicationRequest to name value pairs
         */
        private IDictionary<string, string> ConvertListEndpointsByPlatformApplication(ListEndpointsByPlatformApplicationRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ListEndpointsByPlatformApplication";
            if (request.IsSetPlatformApplicationArn())
            {
                parameters["PlatformApplicationArn"] = request.PlatformApplicationArn;
            }
            if (request.IsSetNextToken())
            {
                parameters["NextToken"] = request.NextToken;
            }

            return parameters;
        }

        /**
         * Convert ListPlatformApplicationsRequest to name value pairs
         */
        private IDictionary<string, string> ConvertListPlatformApplications(ListPlatformApplicationsRequest request)
        {
            IDictionary<string, string> parameters = new Dictionary<string, string>();
            parameters["Action"] = "ListPlatformApplications";
            if (request.IsSetNextToken())
            {
                parameters["NextToken"] = request.NextToken;
            }

            return parameters;
        }

        /*
         *  Transforms response based on xslt template
         */
        private static string Transform(string responseBody, Type t)
        {
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

            XslCompiledTransform transformer = AWSSDKUtils.GetXslCompiledTransform(resourceName);
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

        #endregion        
    }
}
