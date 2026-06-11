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
 * Do not modify this file. This file is generated from the socialmessaging-2024-01-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.SocialMessaging.Model;
using Amazon.SocialMessaging.Model.Internal.MarshallTransformations;
using Amazon.SocialMessaging.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.SocialMessaging
{
    /// <summary>
    /// <para>Implementation for accessing SocialMessaging</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// <i>Amazon Web Services End User Messaging Social</i>, also referred to as Social
    /// messaging, is a messaging service that enables application developers to incorporate
    /// WhatsApp into their existing workflows. The <i>Amazon Web Services End User Messaging
    /// Social API</i> provides information about the <i>Amazon Web Services End User Messaging
    /// Social API</i> resources, including supported HTTP methods, parameters, and schemas.
    /// 
    ///  
    /// <para>
    /// The <i>Amazon Web Services End User Messaging Social API</i> provides programmatic
    /// access to options that are unique to the WhatsApp Business Platform.
    /// </para>
    ///  
    /// <para>
    /// If you're new to the <i>Amazon Web Services End User Messaging Social API</i>, it's
    /// also helpful to review <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/what-is-service.html">What
    /// is Amazon Web Services End User Messaging Social</a> in the <i>Amazon Web Services
    /// End User Messaging Social User Guide</i>. The <i>Amazon Web Services End User Messaging
    /// Social User Guide</i> provides tutorials, code samples, and procedures that demonstrate
    /// how to use <i>Amazon Web Services End User Messaging Social API</i> features programmatically
    /// and how to integrate functionality into applications. The guide also provides key
    /// information, such as integration with other Amazon Web Services services, and the
    /// quotas that apply to use of the service.
    /// </para>
    ///  
    /// <para>
    ///  <b>Regional availability</b> 
    /// </para>
    ///  
    /// <para>
    /// The <i>Amazon Web Services End User Messaging Social API</i> is available across several
    /// Amazon Web Services Regions and it provides a dedicated endpoint for each of these
    /// Regions. For a list of all the Regions and endpoints where the API is currently available,
    /// see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#pinpoint_region">Amazon
    /// Web Services Service Endpoints</a> and <a href="https://docs.aws.amazon.com/general/latest/gr/end-user-messaging.html">Amazon
    /// Web Services End User Messaging endpoints and quotas</a> in the Amazon Web Services
    /// General Reference. To learn more about Amazon Web Services Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
    /// Amazon Web Services Regions</a> in the Amazon Web Services General Reference.
    /// </para>
    ///  
    /// <para>
    /// In each Region, Amazon Web Services maintains multiple Availability Zones. These Availability
    /// Zones are physically isolated from each other, but are united by private, low-latency,
    /// high-throughput, and highly redundant network connections. These Availability Zones
    /// enable us to provide very high levels of availability and redundancy, while also minimizing
    /// latency. To learn more about the number of Availability Zones that are available in
    /// each Region, see <a href="https://aws.amazon.com/about-aws/global-infrastructure/">Amazon
    /// Web Services Global Infrastructure.</a> 
    /// </para>
    /// </summary>
    public partial class AmazonSocialMessagingClient : AmazonServiceClient, IAmazonSocialMessaging
    {
        private static IServiceMetadata serviceMetadata = new AmazonSocialMessagingMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with the credentials loaded from the application's
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
        public AmazonSocialMessagingClient()
            : base(new AmazonSocialMessagingConfig()) { }

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with the credentials loaded from the application's
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
        public AmazonSocialMessagingClient(RegionEndpoint region)
            : base(new AmazonSocialMessagingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonSocialMessagingClient Configuration Object</param>
        public AmazonSocialMessagingClient(AmazonSocialMessagingConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonSocialMessagingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSocialMessagingClient(AWSCredentials credentials)
            : this(credentials, new AmazonSocialMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSocialMessagingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSocialMessagingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with AWS Credentials and an
        /// AmazonSocialMessagingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSocialMessagingClient Configuration Object</param>
        public AmazonSocialMessagingClient(AWSCredentials credentials, AmazonSocialMessagingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSocialMessagingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSocialMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSocialMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSocialMessagingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSocialMessagingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSocialMessagingClient Configuration Object</param>
        public AmazonSocialMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSocialMessagingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSocialMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSocialMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSocialMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSocialMessagingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSocialMessagingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSocialMessagingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSocialMessagingClient Configuration Object</param>
        public AmazonSocialMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSocialMessagingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private ISocialMessagingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public ISocialMessagingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new SocialMessagingPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

        #region Overrides

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSocialMessagingEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonSocialMessagingAuthSchemeHandler());
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


        #region  AssociateWhatsAppBusinessAccount

        internal virtual AssociateWhatsAppBusinessAccountResponse AssociateWhatsAppBusinessAccount(AssociateWhatsAppBusinessAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateWhatsAppBusinessAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWhatsAppBusinessAccountResponseUnmarshaller.Instance;

            return Invoke<AssociateWhatsAppBusinessAccountResponse>(request, options);
        }



        /// <summary>
        /// This is only used through the Amazon Web Services console during sign-up to associate
        /// your WhatsApp Business Account to your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateWhatsAppBusinessAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateWhatsAppBusinessAccount service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.LimitExceededException">
        /// The request was denied because it would exceed one or more service quotas or limits.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/AssociateWhatsAppBusinessAccount">REST API Reference for AssociateWhatsAppBusinessAccount Operation</seealso>
        public virtual Task<AssociateWhatsAppBusinessAccountResponse> AssociateWhatsAppBusinessAccountAsync(AssociateWhatsAppBusinessAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateWhatsAppBusinessAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateWhatsAppBusinessAccountResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateWhatsAppBusinessAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWhatsAppFlow

        internal virtual CreateWhatsAppFlowResponse CreateWhatsAppFlow(CreateWhatsAppFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatsAppFlowResponseUnmarshaller.Instance;

            return Invoke<CreateWhatsAppFlowResponse>(request, options);
        }



        /// <summary>
        /// Creates a new WhatsApp Flow. Flows enable businesses to create rich, interactive forms
        /// and experiences that users can complete without leaving WhatsApp. The Flow is created
        /// in DRAFT status. If <c>publish</c> is set to <c>true</c> and a valid <c>flowJson</c>
        /// is provided, the Flow is published immediately.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWhatsAppFlow service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppFlow">REST API Reference for CreateWhatsAppFlow Operation</seealso>
        public virtual Task<CreateWhatsAppFlowResponse> CreateWhatsAppFlowAsync(CreateWhatsAppFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatsAppFlowResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWhatsAppFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWhatsAppMessageTemplate

        internal virtual CreateWhatsAppMessageTemplateResponse CreateWhatsAppMessageTemplate(CreateWhatsAppMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWhatsAppMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatsAppMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateWhatsAppMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Creates a new WhatsApp message template from a custom definition.
        /// 
        ///  <note> 
        /// <para>
        /// Amazon Web Services End User Messaging Social does not store any WhatsApp message
        /// template content.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWhatsAppMessageTemplate service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplate">REST API Reference for CreateWhatsAppMessageTemplate Operation</seealso>
        public virtual Task<CreateWhatsAppMessageTemplateResponse> CreateWhatsAppMessageTemplateAsync(CreateWhatsAppMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWhatsAppMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatsAppMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWhatsAppMessageTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWhatsAppMessageTemplateFromLibrary

        internal virtual CreateWhatsAppMessageTemplateFromLibraryResponse CreateWhatsAppMessageTemplateFromLibrary(CreateWhatsAppMessageTemplateFromLibraryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWhatsAppMessageTemplateFromLibraryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatsAppMessageTemplateFromLibraryResponseUnmarshaller.Instance;

            return Invoke<CreateWhatsAppMessageTemplateFromLibraryResponse>(request, options);
        }



        /// <summary>
        /// Creates a new WhatsApp message template using a template from Meta's template library.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplateFromLibrary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWhatsAppMessageTemplateFromLibrary service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplateFromLibrary">REST API Reference for CreateWhatsAppMessageTemplateFromLibrary Operation</seealso>
        public virtual Task<CreateWhatsAppMessageTemplateFromLibraryResponse> CreateWhatsAppMessageTemplateFromLibraryAsync(CreateWhatsAppMessageTemplateFromLibraryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWhatsAppMessageTemplateFromLibraryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatsAppMessageTemplateFromLibraryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWhatsAppMessageTemplateFromLibraryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateWhatsAppMessageTemplateMedia

        internal virtual CreateWhatsAppMessageTemplateMediaResponse CreateWhatsAppMessageTemplateMedia(CreateWhatsAppMessageTemplateMediaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWhatsAppMessageTemplateMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatsAppMessageTemplateMediaResponseUnmarshaller.Instance;

            return Invoke<CreateWhatsAppMessageTemplateMediaResponse>(request, options);
        }



        /// <summary>
        /// Uploads media for use in a WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateWhatsAppMessageTemplateMedia service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateWhatsAppMessageTemplateMedia service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/CreateWhatsAppMessageTemplateMedia">REST API Reference for CreateWhatsAppMessageTemplateMedia Operation</seealso>
        public virtual Task<CreateWhatsAppMessageTemplateMediaResponse> CreateWhatsAppMessageTemplateMediaAsync(CreateWhatsAppMessageTemplateMediaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateWhatsAppMessageTemplateMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateWhatsAppMessageTemplateMediaResponseUnmarshaller.Instance;

            return InvokeAsync<CreateWhatsAppMessageTemplateMediaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWhatsAppFlow

        internal virtual DeleteWhatsAppFlowResponse DeleteWhatsAppFlow(DeleteWhatsAppFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatsAppFlowResponseUnmarshaller.Instance;

            return Invoke<DeleteWhatsAppFlowResponse>(request, options);
        }



        /// <summary>
        /// Deletes a WhatsApp Flow permanently. Only Flows in DRAFT status can be deleted. Published
        /// or deprecated Flows cannot be deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatsAppFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWhatsAppFlow service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DeleteWhatsAppFlow">REST API Reference for DeleteWhatsAppFlow Operation</seealso>
        public virtual Task<DeleteWhatsAppFlowResponse> DeleteWhatsAppFlowAsync(DeleteWhatsAppFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatsAppFlowResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWhatsAppFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWhatsAppMessageMedia

        internal virtual DeleteWhatsAppMessageMediaResponse DeleteWhatsAppMessageMedia(DeleteWhatsAppMessageMediaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWhatsAppMessageMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatsAppMessageMediaResponseUnmarshaller.Instance;

            return Invoke<DeleteWhatsAppMessageMediaResponse>(request, options);
        }



        /// <summary>
        /// Delete a media object from the WhatsApp service. If the object is still in an Amazon
        /// S3 bucket you should delete it from there too.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatsAppMessageMedia service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWhatsAppMessageMedia service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DeleteWhatsAppMessageMedia">REST API Reference for DeleteWhatsAppMessageMedia Operation</seealso>
        public virtual Task<DeleteWhatsAppMessageMediaResponse> DeleteWhatsAppMessageMediaAsync(DeleteWhatsAppMessageMediaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWhatsAppMessageMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatsAppMessageMediaResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWhatsAppMessageMediaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteWhatsAppMessageTemplate

        internal virtual DeleteWhatsAppMessageTemplateResponse DeleteWhatsAppMessageTemplate(DeleteWhatsAppMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWhatsAppMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatsAppMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteWhatsAppMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Deletes a WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteWhatsAppMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteWhatsAppMessageTemplate service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DeleteWhatsAppMessageTemplate">REST API Reference for DeleteWhatsAppMessageTemplate Operation</seealso>
        public virtual Task<DeleteWhatsAppMessageTemplateResponse> DeleteWhatsAppMessageTemplateAsync(DeleteWhatsAppMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteWhatsAppMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteWhatsAppMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteWhatsAppMessageTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeprecateWhatsAppFlow

        internal virtual DeprecateWhatsAppFlowResponse DeprecateWhatsAppFlow(DeprecateWhatsAppFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeprecateWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateWhatsAppFlowResponseUnmarshaller.Instance;

            return Invoke<DeprecateWhatsAppFlowResponse>(request, options);
        }



        /// <summary>
        /// Deprecates a published WhatsApp Flow, marking it as no longer recommended for use.
        /// The Flow must be in PUBLISHED status. This is an irreversible operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeprecateWhatsAppFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeprecateWhatsAppFlow service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DeprecateWhatsAppFlow">REST API Reference for DeprecateWhatsAppFlow Operation</seealso>
        public virtual Task<DeprecateWhatsAppFlowResponse> DeprecateWhatsAppFlowAsync(DeprecateWhatsAppFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeprecateWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprecateWhatsAppFlowResponseUnmarshaller.Instance;

            return InvokeAsync<DeprecateWhatsAppFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateWhatsAppBusinessAccount

        internal virtual DisassociateWhatsAppBusinessAccountResponse DisassociateWhatsAppBusinessAccount(DisassociateWhatsAppBusinessAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateWhatsAppBusinessAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWhatsAppBusinessAccountResponseUnmarshaller.Instance;

            return Invoke<DisassociateWhatsAppBusinessAccountResponse>(request, options);
        }



        /// <summary>
        /// Disassociate a WhatsApp Business Account (WABA) from your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateWhatsAppBusinessAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateWhatsAppBusinessAccount service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/DisassociateWhatsAppBusinessAccount">REST API Reference for DisassociateWhatsAppBusinessAccount Operation</seealso>
        public virtual Task<DisassociateWhatsAppBusinessAccountResponse> DisassociateWhatsAppBusinessAccountAsync(DisassociateWhatsAppBusinessAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateWhatsAppBusinessAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateWhatsAppBusinessAccountResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateWhatsAppBusinessAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLinkedWhatsAppBusinessAccount

        internal virtual GetLinkedWhatsAppBusinessAccountResponse GetLinkedWhatsAppBusinessAccount(GetLinkedWhatsAppBusinessAccountRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkedWhatsAppBusinessAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkedWhatsAppBusinessAccountResponseUnmarshaller.Instance;

            return Invoke<GetLinkedWhatsAppBusinessAccountResponse>(request, options);
        }



        /// <summary>
        /// Get the details of your linked WhatsApp Business Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkedWhatsAppBusinessAccount service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLinkedWhatsAppBusinessAccount service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetLinkedWhatsAppBusinessAccount">REST API Reference for GetLinkedWhatsAppBusinessAccount Operation</seealso>
        public virtual Task<GetLinkedWhatsAppBusinessAccountResponse> GetLinkedWhatsAppBusinessAccountAsync(GetLinkedWhatsAppBusinessAccountRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkedWhatsAppBusinessAccountRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkedWhatsAppBusinessAccountResponseUnmarshaller.Instance;

            return InvokeAsync<GetLinkedWhatsAppBusinessAccountResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetLinkedWhatsAppBusinessAccountPhoneNumber

        internal virtual GetLinkedWhatsAppBusinessAccountPhoneNumberResponse GetLinkedWhatsAppBusinessAccountPhoneNumber(GetLinkedWhatsAppBusinessAccountPhoneNumberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkedWhatsAppBusinessAccountPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkedWhatsAppBusinessAccountPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<GetLinkedWhatsAppBusinessAccountPhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// Retrieve the WABA account id and phone number details of a WhatsApp business account
        /// phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkedWhatsAppBusinessAccountPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLinkedWhatsAppBusinessAccountPhoneNumber service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetLinkedWhatsAppBusinessAccountPhoneNumber">REST API Reference for GetLinkedWhatsAppBusinessAccountPhoneNumber Operation</seealso>
        public virtual Task<GetLinkedWhatsAppBusinessAccountPhoneNumberResponse> GetLinkedWhatsAppBusinessAccountPhoneNumberAsync(GetLinkedWhatsAppBusinessAccountPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetLinkedWhatsAppBusinessAccountPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkedWhatsAppBusinessAccountPhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<GetLinkedWhatsAppBusinessAccountPhoneNumberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWhatsAppFlow

        internal virtual GetWhatsAppFlowResponse GetWhatsAppFlow(GetWhatsAppFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWhatsAppFlowResponseUnmarshaller.Instance;

            return Invoke<GetWhatsAppFlowResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata and status of a WhatsApp Flow, including validation errors,
        /// preview information, and health status.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWhatsAppFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWhatsAppFlow service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetWhatsAppFlow">REST API Reference for GetWhatsAppFlow Operation</seealso>
        public virtual Task<GetWhatsAppFlowResponse> GetWhatsAppFlowAsync(GetWhatsAppFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWhatsAppFlowResponseUnmarshaller.Instance;

            return InvokeAsync<GetWhatsAppFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWhatsAppFlowPreview

        internal virtual GetWhatsAppFlowPreviewResponse GetWhatsAppFlowPreview(GetWhatsAppFlowPreviewRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWhatsAppFlowPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWhatsAppFlowPreviewResponseUnmarshaller.Instance;

            return Invoke<GetWhatsAppFlowPreviewResponse>(request, options);
        }



        /// <summary>
        /// Generates a web preview URL for testing a WhatsApp Flow before publishing. Preview
        /// URLs expire in 30 days and can be shared with stakeholders for review.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWhatsAppFlowPreview service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWhatsAppFlowPreview service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetWhatsAppFlowPreview">REST API Reference for GetWhatsAppFlowPreview Operation</seealso>
        public virtual Task<GetWhatsAppFlowPreviewResponse> GetWhatsAppFlowPreviewAsync(GetWhatsAppFlowPreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWhatsAppFlowPreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWhatsAppFlowPreviewResponseUnmarshaller.Instance;

            return InvokeAsync<GetWhatsAppFlowPreviewResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWhatsAppMessageMedia

        internal virtual GetWhatsAppMessageMediaResponse GetWhatsAppMessageMedia(GetWhatsAppMessageMediaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWhatsAppMessageMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWhatsAppMessageMediaResponseUnmarshaller.Instance;

            return Invoke<GetWhatsAppMessageMediaResponse>(request, options);
        }



        /// <summary>
        /// Get a media file from the WhatsApp service. On successful completion the media file
        /// is retrieved from Meta and stored in the specified Amazon S3 bucket. Use either <c>destinationS3File</c>
        /// or <c>destinationS3PresignedUrl</c> for the destination. If both are used then an
        /// <c>InvalidParameterException</c> is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWhatsAppMessageMedia service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWhatsAppMessageMedia service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetWhatsAppMessageMedia">REST API Reference for GetWhatsAppMessageMedia Operation</seealso>
        public virtual Task<GetWhatsAppMessageMediaResponse> GetWhatsAppMessageMediaAsync(GetWhatsAppMessageMediaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWhatsAppMessageMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWhatsAppMessageMediaResponseUnmarshaller.Instance;

            return InvokeAsync<GetWhatsAppMessageMediaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetWhatsAppMessageTemplate

        internal virtual GetWhatsAppMessageTemplateResponse GetWhatsAppMessageTemplate(GetWhatsAppMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWhatsAppMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWhatsAppMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<GetWhatsAppMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a specific WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetWhatsAppMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetWhatsAppMessageTemplate service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/GetWhatsAppMessageTemplate">REST API Reference for GetWhatsAppMessageTemplate Operation</seealso>
        public virtual Task<GetWhatsAppMessageTemplateResponse> GetWhatsAppMessageTemplateAsync(GetWhatsAppMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetWhatsAppMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetWhatsAppMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetWhatsAppMessageTemplateResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListLinkedWhatsAppBusinessAccounts

        internal virtual ListLinkedWhatsAppBusinessAccountsResponse ListLinkedWhatsAppBusinessAccounts(ListLinkedWhatsAppBusinessAccountsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLinkedWhatsAppBusinessAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinkedWhatsAppBusinessAccountsResponseUnmarshaller.Instance;

            return Invoke<ListLinkedWhatsAppBusinessAccountsResponse>(request, options);
        }



        /// <summary>
        /// List all WhatsApp Business Accounts linked to your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListLinkedWhatsAppBusinessAccounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListLinkedWhatsAppBusinessAccounts service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListLinkedWhatsAppBusinessAccounts">REST API Reference for ListLinkedWhatsAppBusinessAccounts Operation</seealso>
        public virtual Task<ListLinkedWhatsAppBusinessAccountsResponse> ListLinkedWhatsAppBusinessAccountsAsync(ListLinkedWhatsAppBusinessAccountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListLinkedWhatsAppBusinessAccountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListLinkedWhatsAppBusinessAccountsResponseUnmarshaller.Instance;

            return InvokeAsync<ListLinkedWhatsAppBusinessAccountsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// List all tags associated with a resource, such as a phone number or WABA.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWhatsAppFlowAssets

        internal virtual ListWhatsAppFlowAssetsResponse ListWhatsAppFlowAssets(ListWhatsAppFlowAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWhatsAppFlowAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatsAppFlowAssetsResponseUnmarshaller.Instance;

            return Invoke<ListWhatsAppFlowAssetsResponse>(request, options);
        }



        /// <summary>
        /// Lists the assets (Flow JSON definition) of a WhatsApp Flow with presigned download
        /// URLs. Download URLs are generated by Meta and expire after a short period.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatsAppFlowAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWhatsAppFlowAssets service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListWhatsAppFlowAssets">REST API Reference for ListWhatsAppFlowAssets Operation</seealso>
        public virtual Task<ListWhatsAppFlowAssetsResponse> ListWhatsAppFlowAssetsAsync(ListWhatsAppFlowAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWhatsAppFlowAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatsAppFlowAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWhatsAppFlowAssetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWhatsAppFlows

        internal virtual ListWhatsAppFlowsResponse ListWhatsAppFlows(ListWhatsAppFlowsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWhatsAppFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatsAppFlowsResponseUnmarshaller.Instance;

            return Invoke<ListWhatsAppFlowsResponse>(request, options);
        }



        /// <summary>
        /// Lists all WhatsApp Flows for a WhatsApp Business Account. Returns summary information
        /// including Flow ID, name, status, and categories.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatsAppFlows service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWhatsAppFlows service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListWhatsAppFlows">REST API Reference for ListWhatsAppFlows Operation</seealso>
        public virtual Task<ListWhatsAppFlowsResponse> ListWhatsAppFlowsAsync(ListWhatsAppFlowsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWhatsAppFlowsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatsAppFlowsResponseUnmarshaller.Instance;

            return InvokeAsync<ListWhatsAppFlowsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWhatsAppMessageTemplates

        internal virtual ListWhatsAppMessageTemplatesResponse ListWhatsAppMessageTemplates(ListWhatsAppMessageTemplatesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWhatsAppMessageTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatsAppMessageTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListWhatsAppMessageTemplatesResponse>(request, options);
        }



        /// <summary>
        /// Lists WhatsApp message templates for a specific WhatsApp Business Account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatsAppMessageTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWhatsAppMessageTemplates service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListWhatsAppMessageTemplates">REST API Reference for ListWhatsAppMessageTemplates Operation</seealso>
        public virtual Task<ListWhatsAppMessageTemplatesResponse> ListWhatsAppMessageTemplatesAsync(ListWhatsAppMessageTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWhatsAppMessageTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatsAppMessageTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListWhatsAppMessageTemplatesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListWhatsAppTemplateLibrary

        internal virtual ListWhatsAppTemplateLibraryResponse ListWhatsAppTemplateLibrary(ListWhatsAppTemplateLibraryRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWhatsAppTemplateLibraryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatsAppTemplateLibraryResponseUnmarshaller.Instance;

            return Invoke<ListWhatsAppTemplateLibraryResponse>(request, options);
        }



        /// <summary>
        /// Lists templates available in Meta's template library for WhatsApp messaging.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListWhatsAppTemplateLibrary service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListWhatsAppTemplateLibrary service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/ListWhatsAppTemplateLibrary">REST API Reference for ListWhatsAppTemplateLibrary Operation</seealso>
        public virtual Task<ListWhatsAppTemplateLibraryResponse> ListWhatsAppTemplateLibraryAsync(ListWhatsAppTemplateLibraryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListWhatsAppTemplateLibraryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListWhatsAppTemplateLibraryResponseUnmarshaller.Instance;

            return InvokeAsync<ListWhatsAppTemplateLibraryResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PostWhatsAppMessageMedia

        internal virtual PostWhatsAppMessageMediaResponse PostWhatsAppMessageMedia(PostWhatsAppMessageMediaRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostWhatsAppMessageMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostWhatsAppMessageMediaResponseUnmarshaller.Instance;

            return Invoke<PostWhatsAppMessageMediaResponse>(request, options);
        }



        /// <summary>
        /// Upload a media file to the WhatsApp service. Only the specified <c>originationPhoneNumberId</c>
        /// has the permissions to send the media file when using <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_SendWhatsAppMessage.html">SendWhatsAppMessage</a>.
        /// You must use either <c>sourceS3File</c> or <c>sourceS3PresignedUrl</c> for the source.
        /// If both or neither are specified then an <c>InvalidParameterException</c> is returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PostWhatsAppMessageMedia service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PostWhatsAppMessageMedia service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/PostWhatsAppMessageMedia">REST API Reference for PostWhatsAppMessageMedia Operation</seealso>
        public virtual Task<PostWhatsAppMessageMediaResponse> PostWhatsAppMessageMediaAsync(PostWhatsAppMessageMediaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PostWhatsAppMessageMediaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PostWhatsAppMessageMediaResponseUnmarshaller.Instance;

            return InvokeAsync<PostWhatsAppMessageMediaResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PublishWhatsAppFlow

        internal virtual PublishWhatsAppFlowResponse PublishWhatsAppFlow(PublishWhatsAppFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishWhatsAppFlowResponseUnmarshaller.Instance;

            return Invoke<PublishWhatsAppFlowResponse>(request, options);
        }



        /// <summary>
        /// Publishes a WhatsApp Flow, making it available for use in template messages. The Flow
        /// must be in DRAFT status with valid Flow JSON that passes Meta's validation. This is
        /// an irreversible operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishWhatsAppFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PublishWhatsAppFlow service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/PublishWhatsAppFlow">REST API Reference for PublishWhatsAppFlow Operation</seealso>
        public virtual Task<PublishWhatsAppFlowResponse> PublishWhatsAppFlowAsync(PublishWhatsAppFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PublishWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PublishWhatsAppFlowResponseUnmarshaller.Instance;

            return InvokeAsync<PublishWhatsAppFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutWhatsAppBusinessAccountEventDestinations

        internal virtual PutWhatsAppBusinessAccountEventDestinationsResponse PutWhatsAppBusinessAccountEventDestinations(PutWhatsAppBusinessAccountEventDestinationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWhatsAppBusinessAccountEventDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWhatsAppBusinessAccountEventDestinationsResponseUnmarshaller.Instance;

            return Invoke<PutWhatsAppBusinessAccountEventDestinationsResponse>(request, options);
        }



        /// <summary>
        /// Add an event destination to log event data from WhatsApp for a WhatsApp Business Account
        /// (WABA). A WABA can only have one event destination at a time. All resources associated
        /// with the WABA use the same event destination.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutWhatsAppBusinessAccountEventDestinations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutWhatsAppBusinessAccountEventDestinations service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/PutWhatsAppBusinessAccountEventDestinations">REST API Reference for PutWhatsAppBusinessAccountEventDestinations Operation</seealso>
        public virtual Task<PutWhatsAppBusinessAccountEventDestinationsResponse> PutWhatsAppBusinessAccountEventDestinationsAsync(PutWhatsAppBusinessAccountEventDestinationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutWhatsAppBusinessAccountEventDestinationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutWhatsAppBusinessAccountEventDestinationsResponseUnmarshaller.Instance;

            return InvokeAsync<PutWhatsAppBusinessAccountEventDestinationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendWhatsAppMessage

        internal virtual SendWhatsAppMessageResponse SendWhatsAppMessage(SendWhatsAppMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendWhatsAppMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendWhatsAppMessageResponseUnmarshaller.Instance;

            return Invoke<SendWhatsAppMessageResponse>(request, options);
        }



        /// <summary>
        /// Send a WhatsApp message. For examples of sending a message using the Amazon Web Services
        /// CLI, see <a href="https://docs.aws.amazon.com/social-messaging/latest/userguide/send-message.html">Sending
        /// messages</a> in the <i> <i>Amazon Web Services End User Messaging Social User Guide</i>
        /// </i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendWhatsAppMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendWhatsAppMessage service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/SendWhatsAppMessage">REST API Reference for SendWhatsAppMessage Operation</seealso>
        public virtual Task<SendWhatsAppMessageResponse> SendWhatsAppMessageAsync(SendWhatsAppMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendWhatsAppMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendWhatsAppMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendWhatsAppMessageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds or overwrites only the specified tags for the specified resource. When you specify
        /// an existing tag key, the value is overwritten with the new value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWhatsAppFlow

        internal virtual UpdateWhatsAppFlowResponse UpdateWhatsAppFlow(UpdateWhatsAppFlowRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWhatsAppFlowResponseUnmarshaller.Instance;

            return Invoke<UpdateWhatsAppFlowResponse>(request, options);
        }



        /// <summary>
        /// Updates the metadata of a WhatsApp Flow, such as its name or categories. This does
        /// not update the Flow JSON definition. Use <a href="https://docs.aws.amazon.com/social-messaging/latest/APIReference/API_UpdateWhatsAppFlowAssets.html">UpdateWhatsAppFlowAssets</a>
        /// to update the Flow JSON.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWhatsAppFlow service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWhatsAppFlow service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/UpdateWhatsAppFlow">REST API Reference for UpdateWhatsAppFlow Operation</seealso>
        public virtual Task<UpdateWhatsAppFlowResponse> UpdateWhatsAppFlowAsync(UpdateWhatsAppFlowRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWhatsAppFlowRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWhatsAppFlowResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWhatsAppFlowResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWhatsAppFlowAssets

        internal virtual UpdateWhatsAppFlowAssetsResponse UpdateWhatsAppFlowAssets(UpdateWhatsAppFlowAssetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWhatsAppFlowAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWhatsAppFlowAssetsResponseUnmarshaller.Instance;

            return Invoke<UpdateWhatsAppFlowAssetsResponse>(request, options);
        }



        /// <summary>
        /// Updates the Flow JSON definition (assets) of a WhatsApp Flow. Updating a published
        /// Flow's assets reverts it to DRAFT status, requiring re-publishing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWhatsAppFlowAssets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWhatsAppFlowAssets service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/UpdateWhatsAppFlowAssets">REST API Reference for UpdateWhatsAppFlowAssets Operation</seealso>
        public virtual Task<UpdateWhatsAppFlowAssetsResponse> UpdateWhatsAppFlowAssetsAsync(UpdateWhatsAppFlowAssetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWhatsAppFlowAssetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWhatsAppFlowAssetsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWhatsAppFlowAssetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateWhatsAppMessageTemplate

        internal virtual UpdateWhatsAppMessageTemplateResponse UpdateWhatsAppMessageTemplate(UpdateWhatsAppMessageTemplateRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWhatsAppMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWhatsAppMessageTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateWhatsAppMessageTemplateResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing WhatsApp message template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateWhatsAppMessageTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateWhatsAppMessageTemplate service method, as returned by SocialMessaging.</returns>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedByMetaException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.DependencyException">
        /// Thrown when performing an action because a dependency would be broken.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InternalServiceException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.InvalidParametersException">
        /// One or more parameters provided to the action are not valid.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ResourceNotFoundException">
        /// The resource was not found.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ThrottledRequestException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.SocialMessaging.Model.ValidationException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/socialmessaging-2024-01-01/UpdateWhatsAppMessageTemplate">REST API Reference for UpdateWhatsAppMessageTemplate Operation</seealso>
        public virtual Task<UpdateWhatsAppMessageTemplateResponse> UpdateWhatsAppMessageTemplateAsync(UpdateWhatsAppMessageTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateWhatsAppMessageTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateWhatsAppMessageTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateWhatsAppMessageTemplateResponse>(request, options, cancellationToken);
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