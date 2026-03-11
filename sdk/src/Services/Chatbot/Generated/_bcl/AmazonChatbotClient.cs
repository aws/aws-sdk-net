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
 * Do not modify this file. This file is generated from the chatbot-2017-10-11.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Chatbot.Model;
using Amazon.Chatbot.Model.Internal.MarshallTransformations;
using Amazon.Chatbot.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Chatbot
{
    /// <summary>
    /// <para>Implementation for accessing Chatbot</para>
    ///
    /// The <i>AWS Chatbot API Reference</i> provides descriptions, API request parameters,
    /// and the XML response for each of the AWS Chatbot API actions.
    /// 
    ///  
    /// <para>
    /// AWS Chatbot APIs are currently available in the following Regions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// US East (Ohio) - <c>us-east-2</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// US West (Oregon) - <c>us-west-2</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asia Pacific (Singapore) - <c>ap-southeast-1</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Europe (Ireland) - <c>eu-west-1</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// The AWS Chatbot console can only be used in US East (Ohio). Your configuration data
    /// however, is stored in each of the relevant available Regions.
    /// </para>
    ///  <note> 
    /// <para>
    /// Your AWS CloudTrail events are logged in whatever Region you call from, not US East
    /// (N. Virginia) by default.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class AmazonChatbotClient : AmazonServiceClient, IAmazonChatbot
    {
        private static IServiceMetadata serviceMetadata = new AmazonChatbotMetadata();
        private IChatbotPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IChatbotPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ChatbotPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
        #region Constructors

        /// <summary>
        /// Constructs AmazonChatbotClient with the credentials loaded from the application's
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
        public AmazonChatbotClient()
            : base(new AmazonChatbotConfig()) { }

        /// <summary>
        /// Constructs AmazonChatbotClient with the credentials loaded from the application's
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
        public AmazonChatbotClient(RegionEndpoint region)
            : base(new AmazonChatbotConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonChatbotClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonChatbotClient Configuration Object</param>
        public AmazonChatbotClient(AmazonChatbotConfig config)
            : base(config) { }

        /// <summary>
        /// Constructs AmazonChatbotClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonChatbotClient(AWSCredentials credentials)
            : this(credentials, new AmazonChatbotConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChatbotClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChatbotClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonChatbotConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChatbotClient with AWS Credentials and an
        /// AmazonChatbotClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonChatbotClient Configuration Object</param>
        public AmazonChatbotClient(AWSCredentials credentials, AmazonChatbotConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChatbotClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonChatbotClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChatbotConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChatbotClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChatbotClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonChatbotConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonChatbotClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChatbotClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonChatbotClient Configuration Object</param>
        public AmazonChatbotClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonChatbotConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonChatbotClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonChatbotClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChatbotConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonChatbotClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonChatbotClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonChatbotConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonChatbotClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonChatbotClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonChatbotClient Configuration Object</param>
        public AmazonChatbotClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonChatbotConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides  

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonChatbotEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonChatbotAuthSchemeHandler());
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


        #region  AssociateToConfiguration


        /// <summary>
        /// Links a resource (for example, a custom action) to a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateToConfiguration service method.</param>
        /// 
        /// <returns>The response from the AssociateToConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/AssociateToConfiguration">REST API Reference for AssociateToConfiguration Operation</seealso>
        public virtual AssociateToConfigurationResponse AssociateToConfiguration(AssociateToConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateToConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateToConfigurationResponseUnmarshaller.Instance;

            return Invoke<AssociateToConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Links a resource (for example, a custom action) to a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateToConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateToConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/AssociateToConfiguration">REST API Reference for AssociateToConfiguration Operation</seealso>
        public virtual Task<AssociateToConfigurationResponse> AssociateToConfigurationAsync(AssociateToConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateToConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateToConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<AssociateToConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateChimeWebhookConfiguration


        /// <summary>
        /// Creates an AWS Chatbot configuration for Amazon Chime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateChimeWebhookConfiguration">REST API Reference for CreateChimeWebhookConfiguration Operation</seealso>
        public virtual CreateChimeWebhookConfigurationResponse CreateChimeWebhookConfiguration(CreateChimeWebhookConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChimeWebhookConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChimeWebhookConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateChimeWebhookConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates an AWS Chatbot configuration for Amazon Chime.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateChimeWebhookConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateChimeWebhookConfiguration">REST API Reference for CreateChimeWebhookConfiguration Operation</seealso>
        public virtual Task<CreateChimeWebhookConfigurationResponse> CreateChimeWebhookConfigurationAsync(CreateChimeWebhookConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateChimeWebhookConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateChimeWebhookConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateChimeWebhookConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomAction


        /// <summary>
        /// Creates a custom action that can be invoked as an alias or as a button on a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomAction service method.</param>
        /// 
        /// <returns>The response from the CreateCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateCustomAction">REST API Reference for CreateCustomAction Operation</seealso>
        public virtual CreateCustomActionResponse CreateCustomAction(CreateCustomActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomActionResponseUnmarshaller.Instance;

            return Invoke<CreateCustomActionResponse>(request, options);
        }


        /// <summary>
        /// Creates a custom action that can be invoked as an alias or as a button on a notification.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateCustomAction">REST API Reference for CreateCustomAction Operation</seealso>
        public virtual Task<CreateCustomActionResponse> CreateCustomActionAsync(CreateCustomActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateCustomActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateCustomActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Creates an AWS Chatbot configuration for Microsoft Teams.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateMicrosoftTeamsChannelConfiguration">REST API Reference for CreateMicrosoftTeamsChannelConfiguration Operation</seealso>
        public virtual CreateMicrosoftTeamsChannelConfigurationResponse CreateMicrosoftTeamsChannelConfiguration(CreateMicrosoftTeamsChannelConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMicrosoftTeamsChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateMicrosoftTeamsChannelConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates an AWS Chatbot configuration for Microsoft Teams.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMicrosoftTeamsChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateMicrosoftTeamsChannelConfiguration">REST API Reference for CreateMicrosoftTeamsChannelConfiguration Operation</seealso>
        public virtual Task<CreateMicrosoftTeamsChannelConfigurationResponse> CreateMicrosoftTeamsChannelConfigurationAsync(CreateMicrosoftTeamsChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateMicrosoftTeamsChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateMicrosoftTeamsChannelConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSlackChannelConfiguration


        /// <summary>
        /// Creates an AWS Chatbot confugration for Slack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateSlackChannelConfiguration">REST API Reference for CreateSlackChannelConfiguration Operation</seealso>
        public virtual CreateSlackChannelConfigurationResponse CreateSlackChannelConfiguration(CreateSlackChannelConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSlackChannelConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateSlackChannelConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Creates an AWS Chatbot confugration for Slack.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSlackChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.ConflictException">
        /// There was an issue processing your request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.CreateSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.LimitExceededException">
        /// You have exceeded a service limit for AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/CreateSlackChannelConfiguration">REST API Reference for CreateSlackChannelConfiguration Operation</seealso>
        public virtual Task<CreateSlackChannelConfigurationResponse> CreateSlackChannelConfigurationAsync(CreateSlackChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSlackChannelConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<CreateSlackChannelConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteChimeWebhookConfiguration


        /// <summary>
        /// Deletes a Amazon Chime webhook configuration for AWS Chatbot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteChimeWebhookConfiguration">REST API Reference for DeleteChimeWebhookConfiguration Operation</seealso>
        public virtual DeleteChimeWebhookConfigurationResponse DeleteChimeWebhookConfiguration(DeleteChimeWebhookConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChimeWebhookConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChimeWebhookConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteChimeWebhookConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Amazon Chime webhook configuration for AWS Chatbot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteChimeWebhookConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteChimeWebhookConfiguration">REST API Reference for DeleteChimeWebhookConfiguration Operation</seealso>
        public virtual Task<DeleteChimeWebhookConfigurationResponse> DeleteChimeWebhookConfigurationAsync(DeleteChimeWebhookConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteChimeWebhookConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteChimeWebhookConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteChimeWebhookConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomAction


        /// <summary>
        /// Deletes a custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomAction service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteCustomAction">REST API Reference for DeleteCustomAction Operation</seealso>
        public virtual DeleteCustomActionResponse DeleteCustomAction(DeleteCustomActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomActionResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomActionResponse>(request, options);
        }


        /// <summary>
        /// Deletes a custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteCustomAction">REST API Reference for DeleteCustomAction Operation</seealso>
        public virtual Task<DeleteCustomActionResponse> DeleteCustomActionAsync(DeleteCustomActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCustomActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteCustomActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Deletes a Microsoft Teams channel configuration for AWS Chatbot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsChannelConfiguration">REST API Reference for DeleteMicrosoftTeamsChannelConfiguration Operation</seealso>
        public virtual DeleteMicrosoftTeamsChannelConfigurationResponse DeleteMicrosoftTeamsChannelConfiguration(DeleteMicrosoftTeamsChannelConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMicrosoftTeamsChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteMicrosoftTeamsChannelConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Microsoft Teams channel configuration for AWS Chatbot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsChannelConfiguration">REST API Reference for DeleteMicrosoftTeamsChannelConfiguration Operation</seealso>
        public virtual Task<DeleteMicrosoftTeamsChannelConfigurationResponse> DeleteMicrosoftTeamsChannelConfigurationAsync(DeleteMicrosoftTeamsChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMicrosoftTeamsChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMicrosoftTeamsChannelConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMicrosoftTeamsConfiguredTeam


        /// <summary>
        /// Deletes the Microsoft Teams team authorization allowing for channels to be configured
        /// in that Microsoft Teams team. Note that the Microsoft Teams team must have no channels
        /// configured to remove it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsConfiguredTeam service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsConfiguredTeam service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsConfiguredTeamException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsConfiguredTeam">REST API Reference for DeleteMicrosoftTeamsConfiguredTeam Operation</seealso>
        public virtual DeleteMicrosoftTeamsConfiguredTeamResponse DeleteMicrosoftTeamsConfiguredTeam(DeleteMicrosoftTeamsConfiguredTeamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMicrosoftTeamsConfiguredTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMicrosoftTeamsConfiguredTeamResponseUnmarshaller.Instance;

            return Invoke<DeleteMicrosoftTeamsConfiguredTeamResponse>(request, options);
        }


        /// <summary>
        /// Deletes the Microsoft Teams team authorization allowing for channels to be configured
        /// in that Microsoft Teams team. Note that the Microsoft Teams team must have no channels
        /// configured to remove it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsConfiguredTeam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsConfiguredTeam service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteTeamsConfiguredTeamException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsConfiguredTeam">REST API Reference for DeleteMicrosoftTeamsConfiguredTeam Operation</seealso>
        public virtual Task<DeleteMicrosoftTeamsConfiguredTeamResponse> DeleteMicrosoftTeamsConfiguredTeamAsync(DeleteMicrosoftTeamsConfiguredTeamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMicrosoftTeamsConfiguredTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMicrosoftTeamsConfiguredTeamResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMicrosoftTeamsConfiguredTeamResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteMicrosoftTeamsUserIdentity


        /// <summary>
        /// Identifes a user level permission for a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsUserIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteMicrosoftTeamsUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsUserIdentity">REST API Reference for DeleteMicrosoftTeamsUserIdentity Operation</seealso>
        public virtual DeleteMicrosoftTeamsUserIdentityResponse DeleteMicrosoftTeamsUserIdentity(DeleteMicrosoftTeamsUserIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMicrosoftTeamsUserIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMicrosoftTeamsUserIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteMicrosoftTeamsUserIdentityResponse>(request, options);
        }


        /// <summary>
        /// Identifes a user level permission for a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMicrosoftTeamsUserIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMicrosoftTeamsUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteMicrosoftTeamsUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteMicrosoftTeamsUserIdentity">REST API Reference for DeleteMicrosoftTeamsUserIdentity Operation</seealso>
        public virtual Task<DeleteMicrosoftTeamsUserIdentityResponse> DeleteMicrosoftTeamsUserIdentityAsync(DeleteMicrosoftTeamsUserIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMicrosoftTeamsUserIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMicrosoftTeamsUserIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteMicrosoftTeamsUserIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSlackChannelConfiguration


        /// <summary>
        /// Deletes a Slack channel configuration for AWS Chatbot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackChannelConfiguration">REST API Reference for DeleteSlackChannelConfiguration Operation</seealso>
        public virtual DeleteSlackChannelConfigurationResponse DeleteSlackChannelConfiguration(DeleteSlackChannelConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlackChannelConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteSlackChannelConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Deletes a Slack channel configuration for AWS Chatbot
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackChannelConfiguration">REST API Reference for DeleteSlackChannelConfiguration Operation</seealso>
        public virtual Task<DeleteSlackChannelConfigurationResponse> DeleteSlackChannelConfigurationAsync(DeleteSlackChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlackChannelConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSlackChannelConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSlackUserIdentity


        /// <summary>
        /// Deletes a user level permission for a Slack channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackUserIdentity service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackUserIdentity">REST API Reference for DeleteSlackUserIdentity Operation</seealso>
        public virtual DeleteSlackUserIdentityResponse DeleteSlackUserIdentity(DeleteSlackUserIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlackUserIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlackUserIdentityResponseUnmarshaller.Instance;

            return Invoke<DeleteSlackUserIdentityResponse>(request, options);
        }


        /// <summary>
        /// Deletes a user level permission for a Slack channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackUserIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlackUserIdentity service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackUserIdentityException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackUserIdentity">REST API Reference for DeleteSlackUserIdentity Operation</seealso>
        public virtual Task<DeleteSlackUserIdentityResponse> DeleteSlackUserIdentityAsync(DeleteSlackUserIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlackUserIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlackUserIdentityResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSlackUserIdentityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSlackWorkspaceAuthorization


        /// <summary>
        /// Deletes the Slack workspace authorization that allows channels to be configured in
        /// that workspace. This requires all configured channels in the workspace to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackWorkspaceAuthorization service method.</param>
        /// 
        /// <returns>The response from the DeleteSlackWorkspaceAuthorization service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackWorkspaceAuthorizationException">
        /// There was an issue deleting your Slack workspace.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackWorkspaceAuthorization">REST API Reference for DeleteSlackWorkspaceAuthorization Operation</seealso>
        public virtual DeleteSlackWorkspaceAuthorizationResponse DeleteSlackWorkspaceAuthorization(DeleteSlackWorkspaceAuthorizationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlackWorkspaceAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlackWorkspaceAuthorizationResponseUnmarshaller.Instance;

            return Invoke<DeleteSlackWorkspaceAuthorizationResponse>(request, options);
        }


        /// <summary>
        /// Deletes the Slack workspace authorization that allows channels to be configured in
        /// that workspace. This requires all configured channels in the workspace to be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSlackWorkspaceAuthorization service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSlackWorkspaceAuthorization service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DeleteSlackWorkspaceAuthorizationException">
        /// There was an issue deleting your Slack workspace.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DeleteSlackWorkspaceAuthorization">REST API Reference for DeleteSlackWorkspaceAuthorization Operation</seealso>
        public virtual Task<DeleteSlackWorkspaceAuthorizationResponse> DeleteSlackWorkspaceAuthorizationAsync(DeleteSlackWorkspaceAuthorizationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteSlackWorkspaceAuthorizationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSlackWorkspaceAuthorizationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DeleteSlackWorkspaceAuthorizationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeChimeWebhookConfigurations


        /// <summary>
        /// Lists Amazon Chime webhook configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChimeWebhookConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeChimeWebhookConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeChimeWebhookConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeChimeWebhookConfigurations">REST API Reference for DescribeChimeWebhookConfigurations Operation</seealso>
        public virtual DescribeChimeWebhookConfigurationsResponse DescribeChimeWebhookConfigurations(DescribeChimeWebhookConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChimeWebhookConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChimeWebhookConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeChimeWebhookConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Lists Amazon Chime webhook configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeChimeWebhookConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeChimeWebhookConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeChimeWebhookConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeChimeWebhookConfigurations">REST API Reference for DescribeChimeWebhookConfigurations Operation</seealso>
        public virtual Task<DescribeChimeWebhookConfigurationsResponse> DescribeChimeWebhookConfigurationsAsync(DescribeChimeWebhookConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeChimeWebhookConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeChimeWebhookConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeChimeWebhookConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSlackChannelConfigurations


        /// <summary>
        /// Lists Slack channel configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackChannelConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackChannelConfigurations">REST API Reference for DescribeSlackChannelConfigurations Operation</seealso>
        public virtual DescribeSlackChannelConfigurationsResponse DescribeSlackChannelConfigurations(DescribeSlackChannelConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSlackChannelConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSlackChannelConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeSlackChannelConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Lists Slack channel configurations optionally filtered by ChatConfigurationArn
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackChannelConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSlackChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackChannelConfigurations">REST API Reference for DescribeSlackChannelConfigurations Operation</seealso>
        public virtual Task<DescribeSlackChannelConfigurationsResponse> DescribeSlackChannelConfigurationsAsync(DescribeSlackChannelConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSlackChannelConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSlackChannelConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSlackChannelConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSlackUserIdentities


        /// <summary>
        /// Lists all Slack user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackUserIdentities service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackUserIdentitiesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackUserIdentities">REST API Reference for DescribeSlackUserIdentities Operation</seealso>
        public virtual DescribeSlackUserIdentitiesResponse DescribeSlackUserIdentities(DescribeSlackUserIdentitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSlackUserIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSlackUserIdentitiesResponseUnmarshaller.Instance;

            return Invoke<DescribeSlackUserIdentitiesResponse>(request, options);
        }


        /// <summary>
        /// Lists all Slack user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackUserIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSlackUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackUserIdentitiesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackUserIdentities">REST API Reference for DescribeSlackUserIdentities Operation</seealso>
        public virtual Task<DescribeSlackUserIdentitiesResponse> DescribeSlackUserIdentitiesAsync(DescribeSlackUserIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSlackUserIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSlackUserIdentitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSlackUserIdentitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSlackWorkspaces


        /// <summary>
        /// List all authorized Slack workspaces connected to the AWS Account onboarded with AWS
        /// Chatbot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackWorkspaces service method.</param>
        /// 
        /// <returns>The response from the DescribeSlackWorkspaces service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackWorkspacesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackWorkspaces">REST API Reference for DescribeSlackWorkspaces Operation</seealso>
        public virtual DescribeSlackWorkspacesResponse DescribeSlackWorkspaces(DescribeSlackWorkspacesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSlackWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSlackWorkspacesResponseUnmarshaller.Instance;

            return Invoke<DescribeSlackWorkspacesResponse>(request, options);
        }


        /// <summary>
        /// List all authorized Slack workspaces connected to the AWS Account onboarded with AWS
        /// Chatbot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSlackWorkspaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSlackWorkspaces service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.DescribeSlackWorkspacesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DescribeSlackWorkspaces">REST API Reference for DescribeSlackWorkspaces Operation</seealso>
        public virtual Task<DescribeSlackWorkspacesResponse> DescribeSlackWorkspacesAsync(DescribeSlackWorkspacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSlackWorkspacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSlackWorkspacesResponseUnmarshaller.Instance;
            
            return InvokeAsync<DescribeSlackWorkspacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateFromConfiguration


        /// <summary>
        /// Unlink a resource, for example a custom action, from a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromConfiguration service method.</param>
        /// 
        /// <returns>The response from the DisassociateFromConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DisassociateFromConfiguration">REST API Reference for DisassociateFromConfiguration Operation</seealso>
        public virtual DisassociateFromConfigurationResponse DisassociateFromConfiguration(DisassociateFromConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFromConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromConfigurationResponseUnmarshaller.Instance;

            return Invoke<DisassociateFromConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Unlink a resource, for example a custom action, from a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateFromConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateFromConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/DisassociateFromConfiguration">REST API Reference for DisassociateFromConfiguration Operation</seealso>
        public virtual Task<DisassociateFromConfigurationResponse> DisassociateFromConfigurationAsync(DisassociateFromConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateFromConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateFromConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<DisassociateFromConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountPreferences


        /// <summary>
        /// Returns AWS Chatbot account preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPreferences service method.</param>
        /// 
        /// <returns>The response from the GetAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetAccountPreferences">REST API Reference for GetAccountPreferences Operation</seealso>
        public virtual GetAccountPreferencesResponse GetAccountPreferences(GetAccountPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountPreferencesResponseUnmarshaller.Instance;

            return Invoke<GetAccountPreferencesResponse>(request, options);
        }


        /// <summary>
        /// Returns AWS Chatbot account preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetAccountPreferences">REST API Reference for GetAccountPreferences Operation</seealso>
        public virtual Task<GetAccountPreferencesResponse> GetAccountPreferencesAsync(GetAccountPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetAccountPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountPreferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetAccountPreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCustomAction


        /// <summary>
        /// Returns a custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomAction service method.</param>
        /// 
        /// <returns>The response from the GetCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetCustomAction">REST API Reference for GetCustomAction Operation</seealso>
        public virtual GetCustomActionResponse GetCustomAction(GetCustomActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomActionResponseUnmarshaller.Instance;

            return Invoke<GetCustomActionResponse>(request, options);
        }


        /// <summary>
        /// Returns a custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetCustomAction">REST API Reference for GetCustomAction Operation</seealso>
        public virtual Task<GetCustomActionResponse> GetCustomActionAsync(GetCustomActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCustomActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetCustomActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Returns a Microsoft Teams channel configuration in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the GetMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetMicrosoftTeamsChannelConfiguration">REST API Reference for GetMicrosoftTeamsChannelConfiguration Operation</seealso>
        public virtual GetMicrosoftTeamsChannelConfigurationResponse GetMicrosoftTeamsChannelConfiguration(GetMicrosoftTeamsChannelConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMicrosoftTeamsChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetMicrosoftTeamsChannelConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Returns a Microsoft Teams channel configuration in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetMicrosoftTeamsChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.GetTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/GetMicrosoftTeamsChannelConfiguration">REST API Reference for GetMicrosoftTeamsChannelConfiguration Operation</seealso>
        public virtual Task<GetMicrosoftTeamsChannelConfigurationResponse> GetMicrosoftTeamsChannelConfigurationAsync(GetMicrosoftTeamsChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetMicrosoftTeamsChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<GetMicrosoftTeamsChannelConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssociations


        /// <summary>
        /// Lists resources associated with a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public virtual ListAssociationsResponse ListAssociations(ListAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Lists resources associated with a channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociations service method, as returned by Chatbot.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListAssociations">REST API Reference for ListAssociations Operation</seealso>
        public virtual Task<ListAssociationsResponse> ListAssociationsAsync(ListAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCustomActions


        /// <summary>
        /// Lists custom actions defined in this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomActions service method.</param>
        /// 
        /// <returns>The response from the ListCustomActions service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListCustomActions">REST API Reference for ListCustomActions Operation</seealso>
        public virtual ListCustomActionsResponse ListCustomActions(ListCustomActionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomActionsResponseUnmarshaller.Instance;

            return Invoke<ListCustomActionsResponse>(request, options);
        }


        /// <summary>
        /// Lists custom actions defined in this account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCustomActions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCustomActions service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListCustomActions">REST API Reference for ListCustomActions Operation</seealso>
        public virtual Task<ListCustomActionsResponse> ListCustomActionsAsync(ListCustomActionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCustomActionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCustomActionsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListCustomActionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMicrosoftTeamsChannelConfigurations


        /// <summary>
        /// Lists all AWS Chatbot Microsoft Teams channel configurations in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsChannelConfigurations service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListTeamsChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsChannelConfigurations">REST API Reference for ListMicrosoftTeamsChannelConfigurations Operation</seealso>
        public virtual ListMicrosoftTeamsChannelConfigurationsResponse ListMicrosoftTeamsChannelConfigurations(ListMicrosoftTeamsChannelConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrosoftTeamsChannelConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrosoftTeamsChannelConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListMicrosoftTeamsChannelConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Lists all AWS Chatbot Microsoft Teams channel configurations in an AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsChannelConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsChannelConfigurations service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListTeamsChannelConfigurationsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsChannelConfigurations">REST API Reference for ListMicrosoftTeamsChannelConfigurations Operation</seealso>
        public virtual Task<ListMicrosoftTeamsChannelConfigurationsResponse> ListMicrosoftTeamsChannelConfigurationsAsync(ListMicrosoftTeamsChannelConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrosoftTeamsChannelConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrosoftTeamsChannelConfigurationsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMicrosoftTeamsChannelConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMicrosoftTeamsConfiguredTeams


        /// <summary>
        /// Lists all authorized Microsoft Teams for an AWS Account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsConfiguredTeams service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsConfiguredTeams service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListMicrosoftTeamsConfiguredTeamsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsConfiguredTeams">REST API Reference for ListMicrosoftTeamsConfiguredTeams Operation</seealso>
        public virtual ListMicrosoftTeamsConfiguredTeamsResponse ListMicrosoftTeamsConfiguredTeams(ListMicrosoftTeamsConfiguredTeamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrosoftTeamsConfiguredTeamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrosoftTeamsConfiguredTeamsResponseUnmarshaller.Instance;

            return Invoke<ListMicrosoftTeamsConfiguredTeamsResponse>(request, options);
        }


        /// <summary>
        /// Lists all authorized Microsoft Teams for an AWS Account
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsConfiguredTeams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsConfiguredTeams service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListMicrosoftTeamsConfiguredTeamsException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsConfiguredTeams">REST API Reference for ListMicrosoftTeamsConfiguredTeams Operation</seealso>
        public virtual Task<ListMicrosoftTeamsConfiguredTeamsResponse> ListMicrosoftTeamsConfiguredTeamsAsync(ListMicrosoftTeamsConfiguredTeamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrosoftTeamsConfiguredTeamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrosoftTeamsConfiguredTeamsResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMicrosoftTeamsConfiguredTeamsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListMicrosoftTeamsUserIdentities


        /// <summary>
        /// A list all Microsoft Teams user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsUserIdentities service method.</param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListMicrosoftTeamsUserIdentitiesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsUserIdentities">REST API Reference for ListMicrosoftTeamsUserIdentities Operation</seealso>
        public virtual ListMicrosoftTeamsUserIdentitiesResponse ListMicrosoftTeamsUserIdentities(ListMicrosoftTeamsUserIdentitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrosoftTeamsUserIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrosoftTeamsUserIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListMicrosoftTeamsUserIdentitiesResponse>(request, options);
        }


        /// <summary>
        /// A list all Microsoft Teams user identities with a mapped role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMicrosoftTeamsUserIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListMicrosoftTeamsUserIdentities service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ListMicrosoftTeamsUserIdentitiesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListMicrosoftTeamsUserIdentities">REST API Reference for ListMicrosoftTeamsUserIdentities Operation</seealso>
        public virtual Task<ListMicrosoftTeamsUserIdentitiesResponse> ListMicrosoftTeamsUserIdentitiesAsync(ListMicrosoftTeamsUserIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListMicrosoftTeamsUserIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListMicrosoftTeamsUserIdentitiesResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListMicrosoftTeamsUserIdentitiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a user, server, or role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ServiceUnavailableException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }


        /// <summary>
        /// Lists all of the tags associated with the Amazon Resource Name (ARN) that you specify.
        /// The resource can be a user, server, or role.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ServiceUnavailableException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ServiceUnavailableException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.TooManyTagsException">
        /// The supplied list of tags contains too many tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }


        /// <summary>
        /// Attaches a key-value pair to a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ServiceUnavailableException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.TooManyTagsException">
        /// The supplied list of tags contains too many tags.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Detaches a key-value pair from a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ServiceUnavailableException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }


        /// <summary>
        /// Detaches a key-value pair from a resource, as identified by its Amazon Resource Name
        /// (ARN). Resources are users, servers, roles, and other entities.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ServiceUnavailableException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;
            
            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccountPreferences


        /// <summary>
        /// Updates AWS Chatbot account preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPreferences service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateAccountPreferences">REST API Reference for UpdateAccountPreferences Operation</seealso>
        public virtual UpdateAccountPreferencesResponse UpdateAccountPreferences(UpdateAccountPreferencesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountPreferencesResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountPreferencesResponse>(request, options);
        }


        /// <summary>
        /// Updates AWS Chatbot account preferences.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountPreferences service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateAccountPreferences service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateAccountPreferencesException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateAccountPreferences">REST API Reference for UpdateAccountPreferences Operation</seealso>
        public virtual Task<UpdateAccountPreferencesResponse> UpdateAccountPreferencesAsync(UpdateAccountPreferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateAccountPreferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountPreferencesResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateAccountPreferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateChimeWebhookConfiguration


        /// <summary>
        /// Updates a Amazon Chime webhook configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChimeWebhookConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateChimeWebhookConfiguration">REST API Reference for UpdateChimeWebhookConfiguration Operation</seealso>
        public virtual UpdateChimeWebhookConfigurationResponse UpdateChimeWebhookConfiguration(UpdateChimeWebhookConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChimeWebhookConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChimeWebhookConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateChimeWebhookConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates a Amazon Chime webhook configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateChimeWebhookConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateChimeWebhookConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateChimeWebhookConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateChimeWebhookConfiguration">REST API Reference for UpdateChimeWebhookConfiguration Operation</seealso>
        public virtual Task<UpdateChimeWebhookConfigurationResponse> UpdateChimeWebhookConfigurationAsync(UpdateChimeWebhookConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateChimeWebhookConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateChimeWebhookConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateChimeWebhookConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCustomAction


        /// <summary>
        /// Updates a custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomAction service method.</param>
        /// 
        /// <returns>The response from the UpdateCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateCustomAction">REST API Reference for UpdateCustomAction Operation</seealso>
        public virtual UpdateCustomActionResponse UpdateCustomAction(UpdateCustomActionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCustomActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomActionResponseUnmarshaller.Instance;

            return Invoke<UpdateCustomActionResponse>(request, options);
        }


        /// <summary>
        /// Updates a custom action.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCustomAction service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCustomAction service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InternalServiceErrorException">
        /// Unexpected error during processing of request.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UnauthorizedException">
        /// The request was rejected because it doesn't have valid credentials for the target
        /// resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateCustomAction">REST API Reference for UpdateCustomAction Operation</seealso>
        public virtual Task<UpdateCustomActionResponse> UpdateCustomActionAsync(UpdateCustomActionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCustomActionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCustomActionResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateCustomActionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateMicrosoftTeamsChannelConfiguration


        /// <summary>
        /// Updates an Microsoft Teams channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrosoftTeamsChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateMicrosoftTeamsChannelConfiguration">REST API Reference for UpdateMicrosoftTeamsChannelConfiguration Operation</seealso>
        public virtual UpdateMicrosoftTeamsChannelConfigurationResponse UpdateMicrosoftTeamsChannelConfiguration(UpdateMicrosoftTeamsChannelConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMicrosoftTeamsChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateMicrosoftTeamsChannelConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates an Microsoft Teams channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMicrosoftTeamsChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateMicrosoftTeamsChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateTeamsChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateMicrosoftTeamsChannelConfiguration">REST API Reference for UpdateMicrosoftTeamsChannelConfiguration Operation</seealso>
        public virtual Task<UpdateMicrosoftTeamsChannelConfigurationResponse> UpdateMicrosoftTeamsChannelConfigurationAsync(UpdateMicrosoftTeamsChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateMicrosoftTeamsChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateMicrosoftTeamsChannelConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateMicrosoftTeamsChannelConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSlackChannelConfiguration


        /// <summary>
        /// Updates a Slack channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlackChannelConfiguration service method.</param>
        /// 
        /// <returns>The response from the UpdateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateSlackChannelConfiguration">REST API Reference for UpdateSlackChannelConfiguration Operation</seealso>
        public virtual UpdateSlackChannelConfigurationResponse UpdateSlackChannelConfiguration(UpdateSlackChannelConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSlackChannelConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateSlackChannelConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Updates a Slack channel configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSlackChannelConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSlackChannelConfiguration service method, as returned by Chatbot.</returns>
        /// <exception cref="Amazon.Chatbot.Model.InvalidParameterException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.InvalidRequestException">
        /// Your request input doesn't meet the constraints required by AWS Chatbot.
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.ResourceNotFoundException">
        /// We were unable to find the resource for your request
        /// </exception>
        /// <exception cref="Amazon.Chatbot.Model.UpdateSlackChannelConfigurationException">
        /// We can’t process your request right now because of a server issue. Try again later.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/chatbot-2017-10-11/UpdateSlackChannelConfiguration">REST API Reference for UpdateSlackChannelConfiguration Operation</seealso>
        public virtual Task<UpdateSlackChannelConfigurationResponse> UpdateSlackChannelConfigurationAsync(UpdateSlackChannelConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSlackChannelConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSlackChannelConfigurationResponseUnmarshaller.Instance;
            
            return InvokeAsync<UpdateSlackChannelConfigurationResponse>(request, options, cancellationToken);
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
            var parameters = new ServiceOperationEndpointParameters(request);
            return Config.DetermineServiceOperationEndpoint(parameters);
        }

        #endregion

    }
}