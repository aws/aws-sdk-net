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
 * Do not modify this file. This file is generated from the pinpoint-sms-voice-v2-2022-03-31.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.PinpointSMSVoiceV2.Model;
using Amazon.PinpointSMSVoiceV2.Model.Internal.MarshallTransformations;
using Amazon.PinpointSMSVoiceV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.PinpointSMSVoiceV2
{
    /// <summary>
    /// <para>Implementation for accessing PinpointSMSVoiceV2</para>
    ///
    /// Welcome to the <i>AWS End User Messaging SMS and Voice, version 2 API Reference</i>.
    /// This guide provides information about AWS End User Messaging SMS and Voice, version
    /// 2 API resources, including supported HTTP methods, parameters, and schemas.
    /// 
    ///  
    /// <para>
    /// Amazon Pinpoint is an Amazon Web Services service that you can use to engage with
    /// your recipients across multiple messaging channels. The AWS End User Messaging SMS
    /// and Voice, version 2 API provides programmatic access to options that are unique to
    /// the SMS and voice channels. AWS End User Messaging SMS and Voice, version 2 resources
    /// such as phone numbers, sender IDs, and opt-out lists can be used by the Amazon Pinpoint
    /// API.
    /// </para>
    ///  
    /// <para>
    /// If you're new to AWS End User Messaging SMS and Voice, it's also helpful to review
    /// the <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/what-is-service.html">
    /// AWS End User Messaging SMS User Guide</a>. The <i>AWS End User Messaging SMS User
    /// Guide </i> provides tutorials, code samples, and procedures that demonstrate how to
    /// use AWS End User Messaging SMS and Voice features programmatically and how to integrate
    /// functionality into mobile apps and other types of applications. The guide also provides
    /// key information, such as AWS End User Messaging SMS and Voice integration with other
    /// Amazon Web Services services, and the quotas that apply to use of the service.
    /// </para>
    ///  
    /// <para>
    ///  <b>Regional availability</b> 
    /// </para>
    ///  
    /// <para>
    /// The <i>AWS End User Messaging SMS and Voice version 2 API Reference</i> is available
    /// in several Amazon Web Services Regions and it provides an endpoint for each of these
    /// Regions. For a list of all the Regions and endpoints where the API is currently available,
    /// see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#pinpoint_region">Amazon
    /// Web Services Service Endpoints</a> and <a href="https://docs.aws.amazon.com/general/latest/gr/pinpoint.html">Amazon
    /// Pinpoint endpoints and quotas</a> in the Amazon Web Services General Reference. To
    /// learn more about Amazon Web Services Regions, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande-manage.html">Managing
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
    public partial class AmazonPinpointSMSVoiceV2Client : AmazonServiceClient, IAmazonPinpointSMSVoiceV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonPinpointSMSVoiceV2Metadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with the credentials loaded from the application's
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
        public AmazonPinpointSMSVoiceV2Client()
            : base(new AmazonPinpointSMSVoiceV2Config()) { }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with the credentials loaded from the application's
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
        public AmazonPinpointSMSVoiceV2Client(RegionEndpoint region)
            : base(new AmazonPinpointSMSVoiceV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonPinpointSMSVoiceV2Client Configuration Object</param>
        public AmazonPinpointSMSVoiceV2Client(AmazonPinpointSMSVoiceV2Config config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonPinpointSMSVoiceV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonPinpointSMSVoiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointSMSVoiceV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonPinpointSMSVoiceV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Credentials and an
        /// AmazonPinpointSMSVoiceV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonPinpointSMSVoiceV2Client Configuration Object</param>
        public AmazonPinpointSMSVoiceV2Client(AWSCredentials credentials, AmazonPinpointSMSVoiceV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointSMSVoiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonPinpointSMSVoiceV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointSMSVoiceV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonPinpointSMSVoiceV2Client Configuration Object</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonPinpointSMSVoiceV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointSMSVoiceV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonPinpointSMSVoiceV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonPinpointSMSVoiceV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonPinpointSMSVoiceV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonPinpointSMSVoiceV2Client Configuration Object</param>
        public AmazonPinpointSMSVoiceV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonPinpointSMSVoiceV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IPinpointSMSVoiceV2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IPinpointSMSVoiceV2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new PinpointSMSVoiceV2PaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPinpointSMSVoiceV2EndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonPinpointSMSVoiceV2AuthSchemeHandler());
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


        #region  AssociateOriginationIdentity

        internal virtual AssociateOriginationIdentityResponse AssociateOriginationIdentity(AssociateOriginationIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateOriginationIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOriginationIdentityResponseUnmarshaller.Instance;

            return Invoke<AssociateOriginationIdentityResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified origination identity with a pool.
        /// 
        ///  
        /// <para>
        /// If the origination identity is a phone number and is already associated with another
        /// pool, an error is returned. A sender ID can be associated with multiple pools.
        /// </para>
        ///  
        /// <para>
        /// If the origination identity configuration doesn't match the pool's configuration,
        /// an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateOriginationIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateOriginationIdentity service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/AssociateOriginationIdentity">REST API Reference for AssociateOriginationIdentity Operation</seealso>
        public virtual Task<AssociateOriginationIdentityResponse> AssociateOriginationIdentityAsync(AssociateOriginationIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateOriginationIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateOriginationIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateOriginationIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateProtectConfiguration

        internal virtual AssociateProtectConfigurationResponse AssociateProtectConfiguration(AssociateProtectConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProtectConfigurationResponseUnmarshaller.Instance;

            return Invoke<AssociateProtectConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Associate a protect configuration with a configuration set. This replaces the configuration
        /// sets current protect configuration. A configuration set can only be associated with
        /// one protect configuration at a time. A protect configuration can be associated with
        /// multiple configuration sets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/AssociateProtectConfiguration">REST API Reference for AssociateProtectConfiguration Operation</seealso>
        public virtual Task<AssociateProtectConfigurationResponse> AssociateProtectConfigurationAsync(AssociateProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProtectConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateProtectConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateConfigurationSet

        internal virtual CreateConfigurationSetResponse CreateConfigurationSet(CreateConfigurationSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<CreateConfigurationSetResponse>(request, options);
        }



        /// <summary>
        /// Creates a new configuration set. After you create the configuration set, you can add
        /// one or more event destinations to it.
        /// 
        ///  
        /// <para>
        /// A configuration set is a set of rules that you apply to the SMS and voice messages
        /// that you send.
        /// </para>
        ///  
        /// <para>
        /// When you send a message, you can optionally specify a single configuration set.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConfigurationSet service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateConfigurationSet">REST API Reference for CreateConfigurationSet Operation</seealso>
        public virtual Task<CreateConfigurationSetResponse> CreateConfigurationSetAsync(CreateConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConfigurationSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateEventDestination

        internal virtual CreateEventDestinationResponse CreateEventDestination(CreateEventDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventDestinationResponseUnmarshaller.Instance;

            return Invoke<CreateEventDestinationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new event destination in a configuration set.
        /// 
        ///  
        /// <para>
        /// An event destination is a location where you send message events. The event options
        /// are Amazon CloudWatch, Amazon Data Firehose, or Amazon SNS. For example, when a message
        /// is delivered successfully, you can send information about that event to an event destination,
        /// or send notifications to endpoints that are subscribed to an Amazon SNS topic. 
        /// </para>
        ///  
        /// <para>
        /// You can only create one event destination at a time. You must provide a value for
        /// a single event destination using either <c>CloudWatchLogsDestination</c>, <c>KinesisFirehoseDestination</c>
        /// or <c>SnsDestination</c>. If an event destination isn't provided then an exception
        /// is returned.
        /// </para>
        ///  
        /// <para>
        /// Each configuration set can contain between 0 and 5 event destinations. Each event
        /// destination can contain a reference to a single destination, such as a CloudWatch
        /// or Firehose destination.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateEventDestination">REST API Reference for CreateEventDestination Operation</seealso>
        public virtual Task<CreateEventDestinationResponse> CreateEventDestinationAsync(CreateEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEventDestinationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateOptOutList

        internal virtual CreateOptOutListResponse CreateOptOutList(CreateOptOutListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOptOutListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOptOutListResponseUnmarshaller.Instance;

            return Invoke<CreateOptOutListResponse>(request, options);
        }



        /// <summary>
        /// Creates a new opt-out list.
        /// 
        ///  
        /// <para>
        /// If the opt-out list name already exists, an error is returned.
        /// </para>
        ///  
        /// <para>
        /// An opt-out list is a list of phone numbers that are opted out, meaning you can't send
        /// SMS or voice messages to them. If end user replies with the keyword "STOP," an entry
        /// for the phone number is added to the opt-out list. In addition to STOP, your recipients
        /// can use any supported opt-out keyword, such as CANCEL or OPTOUT. For a list of supported
        /// opt-out keywords, see <a href="https://docs.aws.amazon.com/pinpoint/latest/userguide/channels-sms-manage.html#channels-sms-manage-optout">
        /// SMS opt out </a> in the <i>AWS End User Messaging SMS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateOptOutList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateOptOutList service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateOptOutList">REST API Reference for CreateOptOutList Operation</seealso>
        public virtual Task<CreateOptOutListResponse> CreateOptOutListAsync(CreateOptOutListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateOptOutListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateOptOutListResponseUnmarshaller.Instance;

            return InvokeAsync<CreateOptOutListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreatePool

        internal virtual CreatePoolResponse CreatePool(CreatePoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePoolResponseUnmarshaller.Instance;

            return Invoke<CreatePoolResponse>(request, options);
        }



        /// <summary>
        /// Creates a new pool and associates the specified origination identity to the pool.
        /// A pool can include one or more phone numbers and SenderIds that are associated with
        /// your Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// The new pool inherits its configuration from the specified origination identity. This
        /// includes keywords, message type, opt-out list, two-way configuration, and self-managed
        /// opt-out configuration. Deletion protection isn't inherited from the origination identity
        /// and defaults to false.
        /// </para>
        ///  
        /// <para>
        /// If the origination identity is a phone number and is already associated with another
        /// pool, an error is returned. A sender ID can be associated with multiple pools.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreatePool">REST API Reference for CreatePool Operation</seealso>
        public virtual Task<CreatePoolResponse> CreatePoolAsync(CreatePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreatePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePoolResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateProtectConfiguration

        internal virtual CreateProtectConfigurationResponse CreateProtectConfiguration(CreateProtectConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProtectConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateProtectConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Create a new protect configuration. By default all country rule sets for each capability
        /// are set to <c>ALLOW</c>. Update the country rule sets using <c>UpdateProtectConfigurationCountryRuleSet</c>.
        /// A protect configurations name is stored as a Tag with the key set to <c>Name</c> and
        /// value as the name of the protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateProtectConfiguration">REST API Reference for CreateProtectConfiguration Operation</seealso>
        public virtual Task<CreateProtectConfigurationResponse> CreateProtectConfigurationAsync(CreateProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProtectConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProtectConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRegistration

        internal virtual CreateRegistrationResponse CreateRegistration(CreateRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistrationResponseUnmarshaller.Instance;

            return Invoke<CreateRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Creates a new registration based on the <b>RegistrationType</b> field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistration service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateRegistration">REST API Reference for CreateRegistration Operation</seealso>
        public virtual Task<CreateRegistrationResponse> CreateRegistrationAsync(CreateRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRegistrationAssociation

        internal virtual CreateRegistrationAssociationResponse CreateRegistrationAssociation(CreateRegistrationAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistrationAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistrationAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateRegistrationAssociationResponse>(request, options);
        }



        /// <summary>
        /// Associate the registration with an origination identity such as a phone number or
        /// sender ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistrationAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistrationAssociation service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateRegistrationAssociation">REST API Reference for CreateRegistrationAssociation Operation</seealso>
        public virtual Task<CreateRegistrationAssociationResponse> CreateRegistrationAssociationAsync(CreateRegistrationAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistrationAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistrationAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegistrationAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRegistrationAttachment

        internal virtual CreateRegistrationAttachmentResponse CreateRegistrationAttachment(CreateRegistrationAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistrationAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistrationAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateRegistrationAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Create a new registration attachment to use for uploading a file or a URL to a file.
        /// The maximum file size is 500KB and valid file extensions are PDF, JPEG and PNG. For
        /// example, many sender ID registrations require a signed “letter of authorization” (LOA)
        /// to be submitted.
        /// 
        ///  
        /// <para>
        /// Use either <c>AttachmentUrl</c> or <c>AttachmentBody</c> to upload your attachment.
        /// If both are specified then an exception is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistrationAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistrationAttachment service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateRegistrationAttachment">REST API Reference for CreateRegistrationAttachment Operation</seealso>
        public virtual Task<CreateRegistrationAttachmentResponse> CreateRegistrationAttachmentAsync(CreateRegistrationAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistrationAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistrationAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegistrationAttachmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRegistrationVersion

        internal virtual CreateRegistrationVersionResponse CreateRegistrationVersion(CreateRegistrationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistrationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistrationVersionResponseUnmarshaller.Instance;

            return Invoke<CreateRegistrationVersionResponse>(request, options);
        }



        /// <summary>
        /// Create a new version of the registration and increase the <b>VersionNumber</b>. The
        /// previous version of the registration becomes read-only.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistrationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistrationVersion service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateRegistrationVersion">REST API Reference for CreateRegistrationVersion Operation</seealso>
        public virtual Task<CreateRegistrationVersionResponse> CreateRegistrationVersionAsync(CreateRegistrationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistrationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistrationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegistrationVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateVerifiedDestinationNumber

        internal virtual CreateVerifiedDestinationNumberResponse CreateVerifiedDestinationNumber(CreateVerifiedDestinationNumberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVerifiedDestinationNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVerifiedDestinationNumberResponseUnmarshaller.Instance;

            return Invoke<CreateVerifiedDestinationNumberResponse>(request, options);
        }



        /// <summary>
        /// You can only send messages to verified destination numbers when your account is in
        /// the sandbox. You can add up to 10 verified destination numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVerifiedDestinationNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVerifiedDestinationNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/CreateVerifiedDestinationNumber">REST API Reference for CreateVerifiedDestinationNumber Operation</seealso>
        public virtual Task<CreateVerifiedDestinationNumberResponse> CreateVerifiedDestinationNumberAsync(CreateVerifiedDestinationNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateVerifiedDestinationNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVerifiedDestinationNumberResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVerifiedDestinationNumberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAccountDefaultProtectConfiguration

        internal virtual DeleteAccountDefaultProtectConfigurationResponse DeleteAccountDefaultProtectConfiguration(DeleteAccountDefaultProtectConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountDefaultProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountDefaultProtectConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteAccountDefaultProtectConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Removes the current account default protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAccountDefaultProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAccountDefaultProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteAccountDefaultProtectConfiguration">REST API Reference for DeleteAccountDefaultProtectConfiguration Operation</seealso>
        public virtual Task<DeleteAccountDefaultProtectConfigurationResponse> DeleteAccountDefaultProtectConfigurationAsync(DeleteAccountDefaultProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAccountDefaultProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAccountDefaultProtectConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAccountDefaultProtectConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteConfigurationSet

        internal virtual DeleteConfigurationSetResponse DeleteConfigurationSet(DeleteConfigurationSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return Invoke<DeleteConfigurationSetResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing configuration set.
        /// 
        ///  
        /// <para>
        /// A configuration set is a set of rules that you apply to voice and SMS messages that
        /// you send. In a configuration set, you can specify a destination for specific types
        /// of events related to voice and SMS messages. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConfigurationSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConfigurationSet service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteConfigurationSet">REST API Reference for DeleteConfigurationSet Operation</seealso>
        public virtual Task<DeleteConfigurationSetResponse> DeleteConfigurationSetAsync(DeleteConfigurationSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteConfigurationSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConfigurationSetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConfigurationSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDefaultMessageType

        internal virtual DeleteDefaultMessageTypeResponse DeleteDefaultMessageType(DeleteDefaultMessageTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDefaultMessageTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDefaultMessageTypeResponseUnmarshaller.Instance;

            return Invoke<DeleteDefaultMessageTypeResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing default message type on a configuration set.
        /// 
        ///  
        /// <para>
        ///  A message type is a type of messages that you plan to send. If you send account-related
        /// messages or time-sensitive messages such as one-time passcodes, choose <b>Transactional</b>.
        /// If you plan to send messages that contain marketing material or other promotional
        /// content, choose <b>Promotional</b>. This setting applies to your entire Amazon Web
        /// Services account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultMessageType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDefaultMessageType service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultMessageType">REST API Reference for DeleteDefaultMessageType Operation</seealso>
        public virtual Task<DeleteDefaultMessageTypeResponse> DeleteDefaultMessageTypeAsync(DeleteDefaultMessageTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDefaultMessageTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDefaultMessageTypeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDefaultMessageTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteDefaultSenderId

        internal virtual DeleteDefaultSenderIdResponse DeleteDefaultSenderId(DeleteDefaultSenderIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDefaultSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDefaultSenderIdResponseUnmarshaller.Instance;

            return Invoke<DeleteDefaultSenderIdResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing default sender ID on a configuration set.
        /// 
        ///  
        /// <para>
        /// A default sender ID is the identity that appears on recipients' devices when they
        /// receive SMS messages. Support for sender ID capabilities varies by country or region.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDefaultSenderId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDefaultSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteDefaultSenderId">REST API Reference for DeleteDefaultSenderId Operation</seealso>
        public virtual Task<DeleteDefaultSenderIdResponse> DeleteDefaultSenderIdAsync(DeleteDefaultSenderIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteDefaultSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDefaultSenderIdResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDefaultSenderIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteEventDestination

        internal virtual DeleteEventDestinationResponse DeleteEventDestination(DeleteEventDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventDestinationResponseUnmarshaller.Instance;

            return Invoke<DeleteEventDestinationResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing event destination.
        /// 
        ///  
        /// <para>
        /// An event destination is a location where you send response information about the messages
        /// that you send. For example, when a message is delivered successfully, you can send
        /// information about that event to an Amazon CloudWatch destination, or send notifications
        /// to endpoints that are subscribed to an Amazon SNS topic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteEventDestination">REST API Reference for DeleteEventDestination Operation</seealso>
        public virtual Task<DeleteEventDestinationResponse> DeleteEventDestinationAsync(DeleteEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEventDestinationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteKeyword

        internal virtual DeleteKeywordResponse DeleteKeyword(DeleteKeywordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeywordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeywordResponseUnmarshaller.Instance;

            return Invoke<DeleteKeywordResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing keyword from an origination phone number or pool.
        /// 
        ///  
        /// <para>
        /// A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, AWS End User Messaging SMS and Voice
        /// responds with a customizable message.
        /// </para>
        ///  
        /// <para>
        /// Keywords "HELP" and "STOP" can't be deleted or modified.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteKeyword service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteKeyword">REST API Reference for DeleteKeyword Operation</seealso>
        public virtual Task<DeleteKeywordResponse> DeleteKeywordAsync(DeleteKeywordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteKeywordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeywordResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeywordResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteMediaMessageSpendLimitOverride

        internal virtual DeleteMediaMessageSpendLimitOverrideResponse DeleteMediaMessageSpendLimitOverride(DeleteMediaMessageSpendLimitOverrideRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMediaMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return Invoke<DeleteMediaMessageSpendLimitOverrideResponse>(request, options);
        }



        /// <summary>
        /// Deletes an account-level monthly spending limit override for sending multimedia messages
        /// (MMS). Deleting a spend limit override will set the <c>EnforcedLimit</c> to equal
        /// the <c>MaxLimit</c>, which is controlled by Amazon Web Services. For more information
        /// on spend limits (quotas) see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/quotas.html">Quotas
        /// for Server Migration Service</a> in the <i>Server Migration Service User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMediaMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteMediaMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteMediaMessageSpendLimitOverride">REST API Reference for DeleteMediaMessageSpendLimitOverride Operation</seealso>
        public virtual Task<DeleteMediaMessageSpendLimitOverrideResponse> DeleteMediaMessageSpendLimitOverrideAsync(DeleteMediaMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteMediaMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteMediaMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMediaMessageSpendLimitOverrideResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteOptedOutNumber

        internal virtual DeleteOptedOutNumberResponse DeleteOptedOutNumber(DeleteOptedOutNumberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOptedOutNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptedOutNumberResponseUnmarshaller.Instance;

            return Invoke<DeleteOptedOutNumberResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing opted out destination phone number from the specified opt-out
        /// list.
        /// 
        ///  
        /// <para>
        /// Each destination phone number can only be deleted once every 30 days.
        /// </para>
        ///  
        /// <para>
        /// If the specified destination phone number doesn't exist or if the opt-out list doesn't
        /// exist, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptedOutNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOptedOutNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptedOutNumber">REST API Reference for DeleteOptedOutNumber Operation</seealso>
        public virtual Task<DeleteOptedOutNumberResponse> DeleteOptedOutNumberAsync(DeleteOptedOutNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOptedOutNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptedOutNumberResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOptedOutNumberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteOptOutList

        internal virtual DeleteOptOutListResponse DeleteOptOutList(DeleteOptOutListRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOptOutListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptOutListResponseUnmarshaller.Instance;

            return Invoke<DeleteOptOutListResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing opt-out list. All opted out phone numbers in the opt-out list
        /// are deleted.
        /// 
        ///  
        /// <para>
        /// If the specified opt-out list name doesn't exist or is in-use by an origination phone
        /// number or pool, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteOptOutList service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteOptOutList service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteOptOutList">REST API Reference for DeleteOptOutList Operation</seealso>
        public virtual Task<DeleteOptOutListResponse> DeleteOptOutListAsync(DeleteOptOutListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteOptOutListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteOptOutListResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteOptOutListResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeletePool

        internal virtual DeletePoolResponse DeletePool(DeletePoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePoolResponseUnmarshaller.Instance;

            return Invoke<DeletePoolResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing pool. Deleting a pool disassociates all origination identities
        /// from that pool.
        /// 
        ///  
        /// <para>
        /// If the pool status isn't active or if deletion protection is enabled, an error is
        /// returned.
        /// </para>
        ///  
        /// <para>
        /// A pool is a collection of phone numbers and SenderIds. A pool can include one or more
        /// phone numbers and SenderIds that are associated with your Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeletePool">REST API Reference for DeletePool Operation</seealso>
        public virtual Task<DeletePoolResponse> DeletePoolAsync(DeletePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeletePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePoolResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProtectConfiguration

        internal virtual DeleteProtectConfigurationResponse DeleteProtectConfiguration(DeleteProtectConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtectConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteProtectConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Permanently delete the protect configuration. The protect configuration must have
        /// deletion protection disabled and must not be associated as the account default protect
        /// configuration or associated with a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteProtectConfiguration">REST API Reference for DeleteProtectConfiguration Operation</seealso>
        public virtual Task<DeleteProtectConfigurationResponse> DeleteProtectConfigurationAsync(DeleteProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtectConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProtectConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProtectConfigurationRuleSetNumberOverride

        internal virtual DeleteProtectConfigurationRuleSetNumberOverrideResponse DeleteProtectConfigurationRuleSetNumberOverride(DeleteProtectConfigurationRuleSetNumberOverrideRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProtectConfigurationRuleSetNumberOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtectConfigurationRuleSetNumberOverrideResponseUnmarshaller.Instance;

            return Invoke<DeleteProtectConfigurationRuleSetNumberOverrideResponse>(request, options);
        }



        /// <summary>
        /// Permanently delete the protect configuration rule set number override.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProtectConfigurationRuleSetNumberOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProtectConfigurationRuleSetNumberOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteProtectConfigurationRuleSetNumberOverride">REST API Reference for DeleteProtectConfigurationRuleSetNumberOverride Operation</seealso>
        public virtual Task<DeleteProtectConfigurationRuleSetNumberOverrideResponse> DeleteProtectConfigurationRuleSetNumberOverrideAsync(DeleteProtectConfigurationRuleSetNumberOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProtectConfigurationRuleSetNumberOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProtectConfigurationRuleSetNumberOverrideResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProtectConfigurationRuleSetNumberOverrideResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRegistration

        internal virtual DeleteRegistrationResponse DeleteRegistration(DeleteRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistrationResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Permanently delete an existing registration from your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistration service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteRegistration">REST API Reference for DeleteRegistration Operation</seealso>
        public virtual Task<DeleteRegistrationResponse> DeleteRegistrationAsync(DeleteRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRegistrationAttachment

        internal virtual DeleteRegistrationAttachmentResponse DeleteRegistrationAttachment(DeleteRegistrationAttachmentRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistrationAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistrationAttachmentResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistrationAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Permanently delete the specified registration attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistrationAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistrationAttachment service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteRegistrationAttachment">REST API Reference for DeleteRegistrationAttachment Operation</seealso>
        public virtual Task<DeleteRegistrationAttachmentResponse> DeleteRegistrationAttachmentAsync(DeleteRegistrationAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistrationAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistrationAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegistrationAttachmentResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteRegistrationFieldValue

        internal virtual DeleteRegistrationFieldValueResponse DeleteRegistrationFieldValue(DeleteRegistrationFieldValueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistrationFieldValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistrationFieldValueResponseUnmarshaller.Instance;

            return Invoke<DeleteRegistrationFieldValueResponse>(request, options);
        }



        /// <summary>
        /// Delete the value in a registration form field.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRegistrationFieldValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRegistrationFieldValue service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteRegistrationFieldValue">REST API Reference for DeleteRegistrationFieldValue Operation</seealso>
        public virtual Task<DeleteRegistrationFieldValueResponse> DeleteRegistrationFieldValueAsync(DeleteRegistrationFieldValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteRegistrationFieldValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRegistrationFieldValueResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRegistrationFieldValueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes the resource-based policy document attached to the AWS End User Messaging
        /// SMS and Voice resource. A shared resource can be a Pool, Opt-out list, Sender Id,
        /// or Phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTextMessageSpendLimitOverride

        internal virtual DeleteTextMessageSpendLimitOverrideResponse DeleteTextMessageSpendLimitOverride(DeleteTextMessageSpendLimitOverrideRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTextMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTextMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return Invoke<DeleteTextMessageSpendLimitOverrideResponse>(request, options);
        }



        /// <summary>
        /// Deletes an account-level monthly spending limit override for sending text messages.
        /// Deleting a spend limit override will set the <c>EnforcedLimit</c> to equal the <c>MaxLimit</c>,
        /// which is controlled by Amazon Web Services. For more information on spend limits (quotas)
        /// see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/quotas.html">Quotas
        /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTextMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTextMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteTextMessageSpendLimitOverride">REST API Reference for DeleteTextMessageSpendLimitOverride Operation</seealso>
        public virtual Task<DeleteTextMessageSpendLimitOverrideResponse> DeleteTextMessageSpendLimitOverrideAsync(DeleteTextMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTextMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTextMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTextMessageSpendLimitOverrideResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVerifiedDestinationNumber

        internal virtual DeleteVerifiedDestinationNumberResponse DeleteVerifiedDestinationNumber(DeleteVerifiedDestinationNumberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVerifiedDestinationNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVerifiedDestinationNumberResponseUnmarshaller.Instance;

            return Invoke<DeleteVerifiedDestinationNumberResponse>(request, options);
        }



        /// <summary>
        /// Delete a verified destination phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVerifiedDestinationNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVerifiedDestinationNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteVerifiedDestinationNumber">REST API Reference for DeleteVerifiedDestinationNumber Operation</seealso>
        public virtual Task<DeleteVerifiedDestinationNumberResponse> DeleteVerifiedDestinationNumberAsync(DeleteVerifiedDestinationNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVerifiedDestinationNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVerifiedDestinationNumberResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVerifiedDestinationNumberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteVoiceMessageSpendLimitOverride

        internal virtual DeleteVoiceMessageSpendLimitOverrideResponse DeleteVoiceMessageSpendLimitOverride(DeleteVoiceMessageSpendLimitOverrideRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVoiceMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return Invoke<DeleteVoiceMessageSpendLimitOverrideResponse>(request, options);
        }



        /// <summary>
        /// Deletes an account level monthly spend limit override for sending voice messages.
        /// Deleting a spend limit override sets the <c>EnforcedLimit</c> equal to the <c>MaxLimit</c>,
        /// which is controlled by Amazon Web Services. For more information on spending limits
        /// (quotas) see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/quotas.html">Quotas
        /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVoiceMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVoiceMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DeleteVoiceMessageSpendLimitOverride">REST API Reference for DeleteVoiceMessageSpendLimitOverride Operation</seealso>
        public virtual Task<DeleteVoiceMessageSpendLimitOverrideResponse> DeleteVoiceMessageSpendLimitOverrideAsync(DeleteVoiceMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteVoiceMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVoiceMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVoiceMessageSpendLimitOverrideResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAccountAttributes

        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }



        /// <summary>
        /// Describes attributes of your Amazon Web Services account. The supported account attributes
        /// include account tier, which indicates whether your account is in the sandbox or production
        /// environment. When you're ready to move your account out of the sandbox, create an
        /// Amazon Web Services Support case for a service limit increase request.
        /// 
        ///  
        /// <para>
        /// New accounts are placed into an SMS or voice sandbox. The sandbox protects both Amazon
        /// Web Services end recipients and SMS or voice recipients from fraud and abuse. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeAccountLimits

        internal virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsResponse>(request, options);
        }



        /// <summary>
        /// Describes the current AWS End User Messaging SMS and Voice SMS Voice V2 resource quotas
        /// for your account. The description for a quota includes the quota name, current usage
        /// toward that quota, and the quota's maximum value.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial quotas
        /// on the maximum number of configuration sets, opt-out lists, phone numbers, and pools
        /// that you can create in a given Region. For more information see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/quotas.html">Quotas
        /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeConfigurationSets

        internal virtual DescribeConfigurationSetsResponse DescribeConfigurationSets(DescribeConfigurationSetsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationSetsResponseUnmarshaller.Instance;

            return Invoke<DescribeConfigurationSetsResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified configuration sets or all in your account.
        /// 
        ///  
        /// <para>
        /// If you specify configuration set names, the output includes information for only the
        /// specified configuration sets. If you specify filters, the output includes information
        /// for only those configuration sets that meet the filter criteria. If you don't specify
        /// configuration set names or filters, the output includes information for all configuration
        /// sets.
        /// </para>
        ///  
        /// <para>
        /// If you specify a configuration set name that isn't valid, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConfigurationSets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConfigurationSets service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeConfigurationSets">REST API Reference for DescribeConfigurationSets Operation</seealso>
        public virtual Task<DescribeConfigurationSetsResponse> DescribeConfigurationSetsAsync(DescribeConfigurationSetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeConfigurationSetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConfigurationSetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConfigurationSetsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeKeywords

        internal virtual DescribeKeywordsResponse DescribeKeywords(DescribeKeywordsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeKeywordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeywordsResponseUnmarshaller.Instance;

            return Invoke<DescribeKeywordsResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified keywords or all keywords on your origination phone number
        /// or pool.
        /// 
        ///  
        /// <para>
        /// A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, AWS End User Messaging SMS and Voice
        /// responds with a customizable message.
        /// </para>
        ///  
        /// <para>
        /// If you specify a keyword that isn't valid, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeywords service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeywords service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeKeywords">REST API Reference for DescribeKeywords Operation</seealso>
        public virtual Task<DescribeKeywordsResponse> DescribeKeywordsAsync(DescribeKeywordsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeKeywordsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeywordsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeywordsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeOptedOutNumbers

        internal virtual DescribeOptedOutNumbersResponse DescribeOptedOutNumbers(DescribeOptedOutNumbersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOptedOutNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptedOutNumbersResponseUnmarshaller.Instance;

            return Invoke<DescribeOptedOutNumbersResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified opted out destination numbers or all opted out destination
        /// numbers in an opt-out list.
        /// 
        ///  
        /// <para>
        /// If you specify opted out numbers, the output includes information for only the specified
        /// opted out numbers. If you specify filters, the output includes information for only
        /// those opted out numbers that meet the filter criteria. If you don't specify opted
        /// out numbers or filters, the output includes information for all opted out destination
        /// numbers in your opt-out list.
        /// </para>
        ///  
        /// <para>
        /// If you specify an opted out number that isn't valid, an exception is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptedOutNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOptedOutNumbers service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptedOutNumbers">REST API Reference for DescribeOptedOutNumbers Operation</seealso>
        public virtual Task<DescribeOptedOutNumbersResponse> DescribeOptedOutNumbersAsync(DescribeOptedOutNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOptedOutNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptedOutNumbersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOptedOutNumbersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeOptOutLists

        internal virtual DescribeOptOutListsResponse DescribeOptOutLists(DescribeOptOutListsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOptOutListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptOutListsResponseUnmarshaller.Instance;

            return Invoke<DescribeOptOutListsResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified opt-out list or all opt-out lists in your account.
        /// 
        ///  
        /// <para>
        /// If you specify opt-out list names, the output includes information for only the specified
        /// opt-out lists. Opt-out lists include only those that meet the filter criteria. If
        /// you don't specify opt-out list names or filters, the output includes information for
        /// all opt-out lists.
        /// </para>
        ///  
        /// <para>
        /// If you specify an opt-out list name that isn't valid, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeOptOutLists service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeOptOutLists service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeOptOutLists">REST API Reference for DescribeOptOutLists Operation</seealso>
        public virtual Task<DescribeOptOutListsResponse> DescribeOptOutListsAsync(DescribeOptOutListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeOptOutListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeOptOutListsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeOptOutListsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePhoneNumbers

        internal virtual DescribePhoneNumbersResponse DescribePhoneNumbers(DescribePhoneNumbersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePhoneNumbersResponseUnmarshaller.Instance;

            return Invoke<DescribePhoneNumbersResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified origination phone number, or all the phone numbers in your
        /// account.
        /// 
        ///  
        /// <para>
        /// If you specify phone number IDs, the output includes information for only the specified
        /// phone numbers. If you specify filters, the output includes information for only those
        /// phone numbers that meet the filter criteria. If you don't specify phone number IDs
        /// or filters, the output includes information for all phone numbers.
        /// </para>
        ///  
        /// <para>
        /// If you specify a phone number ID that isn't valid, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePhoneNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePhoneNumbers service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePhoneNumbers">REST API Reference for DescribePhoneNumbers Operation</seealso>
        public virtual Task<DescribePhoneNumbersResponse> DescribePhoneNumbersAsync(DescribePhoneNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePhoneNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePhoneNumbersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePhoneNumbersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribePools

        internal virtual DescribePoolsResponse DescribePools(DescribePoolsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePoolsResponseUnmarshaller.Instance;

            return Invoke<DescribePoolsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified pools or all pools associated with your Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// If you specify pool IDs, the output includes information for only the specified pools.
        /// If you specify filters, the output includes information for only those pools that
        /// meet the filter criteria. If you don't specify pool IDs or filters, the output includes
        /// information for all pools.
        /// </para>
        ///  
        /// <para>
        /// If you specify a pool ID that isn't valid, an error is returned.
        /// </para>
        ///  
        /// <para>
        /// A pool is a collection of phone numbers and SenderIds. A pool can include one or more
        /// phone numbers and SenderIds that are associated with your Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePools service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePools service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribePools">REST API Reference for DescribePools Operation</seealso>
        public virtual Task<DescribePoolsResponse> DescribePoolsAsync(DescribePoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribePoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePoolsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePoolsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeProtectConfigurations

        internal virtual DescribeProtectConfigurationsResponse DescribeProtectConfigurations(DescribeProtectConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProtectConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeProtectConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the protect configurations that match any of filters. If a filter isn’t
        /// provided then all protect configurations are returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeProtectConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeProtectConfigurations service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeProtectConfigurations">REST API Reference for DescribeProtectConfigurations Operation</seealso>
        public virtual Task<DescribeProtectConfigurationsResponse> DescribeProtectConfigurationsAsync(DescribeProtectConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeProtectConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeProtectConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeProtectConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRegistrationAttachments

        internal virtual DescribeRegistrationAttachmentsResponse DescribeRegistrationAttachments(DescribeRegistrationAttachmentsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationAttachmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistrationAttachmentsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified registration attachments or all registration attachments associated
        /// with your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationAttachments service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationAttachments">REST API Reference for DescribeRegistrationAttachments Operation</seealso>
        public virtual Task<DescribeRegistrationAttachmentsResponse> DescribeRegistrationAttachmentsAsync(DescribeRegistrationAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegistrationAttachmentsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRegistrationFieldDefinitions

        internal virtual DescribeRegistrationFieldDefinitionsResponse DescribeRegistrationFieldDefinitions(DescribeRegistrationFieldDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationFieldDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationFieldDefinitionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistrationFieldDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified registration type field definitions. You can use DescribeRegistrationFieldDefinitions
        /// to view the requirements for creating, filling out, and submitting each registration
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationFieldDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationFieldDefinitions service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationFieldDefinitions">REST API Reference for DescribeRegistrationFieldDefinitions Operation</seealso>
        public virtual Task<DescribeRegistrationFieldDefinitionsResponse> DescribeRegistrationFieldDefinitionsAsync(DescribeRegistrationFieldDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationFieldDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationFieldDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegistrationFieldDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRegistrationFieldValues

        internal virtual DescribeRegistrationFieldValuesResponse DescribeRegistrationFieldValues(DescribeRegistrationFieldValuesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationFieldValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationFieldValuesResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistrationFieldValuesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified registration field values.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationFieldValues service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationFieldValues service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationFieldValues">REST API Reference for DescribeRegistrationFieldValues Operation</seealso>
        public virtual Task<DescribeRegistrationFieldValuesResponse> DescribeRegistrationFieldValuesAsync(DescribeRegistrationFieldValuesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationFieldValuesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationFieldValuesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegistrationFieldValuesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRegistrations

        internal virtual DescribeRegistrationsResponse DescribeRegistrations(DescribeRegistrationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistrationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified registrations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrations service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrations">REST API Reference for DescribeRegistrations Operation</seealso>
        public virtual Task<DescribeRegistrationsResponse> DescribeRegistrationsAsync(DescribeRegistrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegistrationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRegistrationSectionDefinitions

        internal virtual DescribeRegistrationSectionDefinitionsResponse DescribeRegistrationSectionDefinitions(DescribeRegistrationSectionDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationSectionDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationSectionDefinitionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistrationSectionDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified registration section definitions. You can use DescribeRegistrationSectionDefinitions
        /// to view the requirements for creating, filling out, and submitting each registration
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationSectionDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationSectionDefinitions service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationSectionDefinitions">REST API Reference for DescribeRegistrationSectionDefinitions Operation</seealso>
        public virtual Task<DescribeRegistrationSectionDefinitionsResponse> DescribeRegistrationSectionDefinitionsAsync(DescribeRegistrationSectionDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationSectionDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationSectionDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegistrationSectionDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRegistrationTypeDefinitions

        internal virtual DescribeRegistrationTypeDefinitionsResponse DescribeRegistrationTypeDefinitions(DescribeRegistrationTypeDefinitionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationTypeDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationTypeDefinitionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistrationTypeDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified registration type definitions. You can use DescribeRegistrationTypeDefinitions
        /// to view the requirements for creating, filling out, and submitting each registration
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationTypeDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationTypeDefinitions service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationTypeDefinitions">REST API Reference for DescribeRegistrationTypeDefinitions Operation</seealso>
        public virtual Task<DescribeRegistrationTypeDefinitionsResponse> DescribeRegistrationTypeDefinitionsAsync(DescribeRegistrationTypeDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationTypeDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationTypeDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegistrationTypeDefinitionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeRegistrationVersions

        internal virtual DescribeRegistrationVersionsResponse DescribeRegistrationVersions(DescribeRegistrationVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegistrationVersionsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified registration version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegistrationVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegistrationVersions service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeRegistrationVersions">REST API Reference for DescribeRegistrationVersions Operation</seealso>
        public virtual Task<DescribeRegistrationVersionsResponse> DescribeRegistrationVersionsAsync(DescribeRegistrationVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeRegistrationVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegistrationVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegistrationVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSenderIds

        internal virtual DescribeSenderIdsResponse DescribeSenderIds(DescribeSenderIdsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSenderIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSenderIdsResponseUnmarshaller.Instance;

            return Invoke<DescribeSenderIdsResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified SenderIds or all SenderIds associated with your Amazon Web
        /// Services account.
        /// 
        ///  
        /// <para>
        /// If you specify SenderIds, the output includes information for only the specified SenderIds.
        /// If you specify filters, the output includes information for only those SenderIds that
        /// meet the filter criteria. If you don't specify SenderIds or filters, the output includes
        /// information for all SenderIds.
        /// </para>
        ///  
        /// <para>
        /// f you specify a sender ID that isn't valid, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSenderIds service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSenderIds service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSenderIds">REST API Reference for DescribeSenderIds Operation</seealso>
        public virtual Task<DescribeSenderIdsResponse> DescribeSenderIdsAsync(DescribeSenderIdsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSenderIdsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSenderIdsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSenderIdsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeSpendLimits

        internal virtual DescribeSpendLimitsResponse DescribeSpendLimits(DescribeSpendLimitsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSpendLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpendLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpendLimitsResponse>(request, options);
        }



        /// <summary>
        /// Describes the current monthly spend limits for sending voice and text messages.
        /// 
        ///  
        /// <para>
        /// When you establish an Amazon Web Services account, the account has initial monthly
        /// spend limit in a given Region. For more information on increasing your monthly spend
        /// limit, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/awssupport-spend-threshold.html">
        /// Requesting increases to your monthly SMS, MMS, or Voice spending quota </a> in the
        /// <i>AWS End User Messaging SMS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpendLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpendLimits service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeSpendLimits">REST API Reference for DescribeSpendLimits Operation</seealso>
        public virtual Task<DescribeSpendLimitsResponse> DescribeSpendLimitsAsync(DescribeSpendLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeSpendLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpendLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpendLimitsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DescribeVerifiedDestinationNumbers

        internal virtual DescribeVerifiedDestinationNumbersResponse DescribeVerifiedDestinationNumbers(DescribeVerifiedDestinationNumbersRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVerifiedDestinationNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVerifiedDestinationNumbersResponseUnmarshaller.Instance;

            return Invoke<DescribeVerifiedDestinationNumbersResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the specified verified destination numbers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVerifiedDestinationNumbers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVerifiedDestinationNumbers service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DescribeVerifiedDestinationNumbers">REST API Reference for DescribeVerifiedDestinationNumbers Operation</seealso>
        public virtual Task<DescribeVerifiedDestinationNumbersResponse> DescribeVerifiedDestinationNumbersAsync(DescribeVerifiedDestinationNumbersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DescribeVerifiedDestinationNumbersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVerifiedDestinationNumbersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVerifiedDestinationNumbersResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateOriginationIdentity

        internal virtual DisassociateOriginationIdentityResponse DisassociateOriginationIdentity(DisassociateOriginationIdentityRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateOriginationIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOriginationIdentityResponseUnmarshaller.Instance;

            return Invoke<DisassociateOriginationIdentityResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified origination identity from an existing pool.
        /// 
        ///  
        /// <para>
        /// If the origination identity isn't associated with the specified pool, an error is
        /// returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateOriginationIdentity service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateOriginationIdentity service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DisassociateOriginationIdentity">REST API Reference for DisassociateOriginationIdentity Operation</seealso>
        public virtual Task<DisassociateOriginationIdentityResponse> DisassociateOriginationIdentityAsync(DisassociateOriginationIdentityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateOriginationIdentityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateOriginationIdentityResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateOriginationIdentityResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateProtectConfiguration

        internal virtual DisassociateProtectConfigurationResponse DisassociateProtectConfiguration(DisassociateProtectConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProtectConfigurationResponseUnmarshaller.Instance;

            return Invoke<DisassociateProtectConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Disassociate a protect configuration from a configuration set.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DisassociateProtectConfiguration">REST API Reference for DisassociateProtectConfiguration Operation</seealso>
        public virtual Task<DisassociateProtectConfigurationResponse> DisassociateProtectConfigurationAsync(DisassociateProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProtectConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateProtectConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DiscardRegistrationVersion

        internal virtual DiscardRegistrationVersionResponse DiscardRegistrationVersion(DiscardRegistrationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DiscardRegistrationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DiscardRegistrationVersionResponseUnmarshaller.Instance;

            return Invoke<DiscardRegistrationVersionResponse>(request, options);
        }



        /// <summary>
        /// Discard the current version of the registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DiscardRegistrationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DiscardRegistrationVersion service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/DiscardRegistrationVersion">REST API Reference for DiscardRegistrationVersion Operation</seealso>
        public virtual Task<DiscardRegistrationVersionResponse> DiscardRegistrationVersionAsync(DiscardRegistrationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DiscardRegistrationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DiscardRegistrationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DiscardRegistrationVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProtectConfigurationCountryRuleSet

        internal virtual GetProtectConfigurationCountryRuleSetResponse GetProtectConfigurationCountryRuleSet(GetProtectConfigurationCountryRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProtectConfigurationCountryRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectConfigurationCountryRuleSetResponseUnmarshaller.Instance;

            return Invoke<GetProtectConfigurationCountryRuleSetResponse>(request, options);
        }



        /// <summary>
        /// Retrieve the CountryRuleSet for the specified NumberCapability from a protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProtectConfigurationCountryRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProtectConfigurationCountryRuleSet service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/GetProtectConfigurationCountryRuleSet">REST API Reference for GetProtectConfigurationCountryRuleSet Operation</seealso>
        public virtual Task<GetProtectConfigurationCountryRuleSetResponse> GetProtectConfigurationCountryRuleSetAsync(GetProtectConfigurationCountryRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProtectConfigurationCountryRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProtectConfigurationCountryRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetProtectConfigurationCountryRuleSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the JSON text of the resource-based policy document attached to the AWS
        /// End User Messaging SMS and Voice resource. A shared resource can be a Pool, Opt-out
        /// list, Sender Id, or Phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPoolOriginationIdentities

        internal virtual ListPoolOriginationIdentitiesResponse ListPoolOriginationIdentities(ListPoolOriginationIdentitiesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoolOriginationIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoolOriginationIdentitiesResponseUnmarshaller.Instance;

            return Invoke<ListPoolOriginationIdentitiesResponse>(request, options);
        }



        /// <summary>
        /// Lists all associated origination identities in your pool.
        /// 
        ///  
        /// <para>
        /// If you specify filters, the output includes information for only those origination
        /// identities that meet the filter criteria.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPoolOriginationIdentities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPoolOriginationIdentities service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListPoolOriginationIdentities">REST API Reference for ListPoolOriginationIdentities Operation</seealso>
        public virtual Task<ListPoolOriginationIdentitiesResponse> ListPoolOriginationIdentitiesAsync(ListPoolOriginationIdentitiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoolOriginationIdentitiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoolOriginationIdentitiesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoolOriginationIdentitiesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProtectConfigurationRuleSetNumberOverrides

        internal virtual ListProtectConfigurationRuleSetNumberOverridesResponse ListProtectConfigurationRuleSetNumberOverrides(ListProtectConfigurationRuleSetNumberOverridesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtectConfigurationRuleSetNumberOverridesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectConfigurationRuleSetNumberOverridesResponseUnmarshaller.Instance;

            return Invoke<ListProtectConfigurationRuleSetNumberOverridesResponse>(request, options);
        }



        /// <summary>
        /// Retrieve all of the protect configuration rule set number overrides that match the
        /// filters.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProtectConfigurationRuleSetNumberOverrides service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProtectConfigurationRuleSetNumberOverrides service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListProtectConfigurationRuleSetNumberOverrides">REST API Reference for ListProtectConfigurationRuleSetNumberOverrides Operation</seealso>
        public virtual Task<ListProtectConfigurationRuleSetNumberOverridesResponse> ListProtectConfigurationRuleSetNumberOverridesAsync(ListProtectConfigurationRuleSetNumberOverridesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProtectConfigurationRuleSetNumberOverridesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProtectConfigurationRuleSetNumberOverridesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProtectConfigurationRuleSetNumberOverridesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRegistrationAssociations

        internal virtual ListRegistrationAssociationsResponse ListRegistrationAssociations(ListRegistrationAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistrationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistrationAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListRegistrationAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieve all of the origination identities that are associated with a registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistrationAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegistrationAssociations service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListRegistrationAssociations">REST API Reference for ListRegistrationAssociations Operation</seealso>
        public virtual Task<ListRegistrationAssociationsResponse> ListRegistrationAssociationsAsync(ListRegistrationAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistrationAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistrationAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegistrationAssociationsResponse>(request, options, cancellationToken);
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
        /// List all tags associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutKeyword

        internal virtual PutKeywordResponse PutKeyword(PutKeywordRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutKeywordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeywordResponseUnmarshaller.Instance;

            return Invoke<PutKeywordResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates a keyword configuration on an origination phone number or pool.
        /// 
        ///  
        /// <para>
        ///  A keyword is a word that you can search for on a particular phone number or pool.
        /// It is also a specific word or phrase that an end user can send to your number to elicit
        /// a response, such as an informational message or a special offer. When your number
        /// receives a message that begins with a keyword, AWS End User Messaging SMS and Voice
        /// responds with a customizable message.
        /// </para>
        ///  
        /// <para>
        /// If you specify a keyword that isn't valid, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutKeyword service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutKeyword service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutKeyword">REST API Reference for PutKeyword Operation</seealso>
        public virtual Task<PutKeywordResponse> PutKeywordAsync(PutKeywordRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutKeywordRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutKeywordResponseUnmarshaller.Instance;

            return InvokeAsync<PutKeywordResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutMessageFeedback

        internal virtual PutMessageFeedbackResponse PutMessageFeedback(PutMessageFeedbackRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMessageFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMessageFeedbackResponseUnmarshaller.Instance;

            return Invoke<PutMessageFeedbackResponse>(request, options);
        }



        /// <summary>
        /// Set the MessageFeedbackStatus as <c>RECEIVED</c> or <c>FAILED</c> for the passed in
        /// MessageId. 
        /// 
        ///  
        /// <para>
        /// If you use message feedback then you must update message feedback record. When you
        /// receive a signal that a user has received the message you must use <c>PutMessageFeedback</c>
        /// to set the message feedback record as <c>RECEIVED</c>; Otherwise, an hour after the
        /// message feedback record is set to <c>FAILED</c>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutMessageFeedback service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutMessageFeedback service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutMessageFeedback">REST API Reference for PutMessageFeedback Operation</seealso>
        public virtual Task<PutMessageFeedbackResponse> PutMessageFeedbackAsync(PutMessageFeedbackRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutMessageFeedbackRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutMessageFeedbackResponseUnmarshaller.Instance;

            return InvokeAsync<PutMessageFeedbackResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutOptedOutNumber

        internal virtual PutOptedOutNumberResponse PutOptedOutNumber(PutOptedOutNumberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutOptedOutNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOptedOutNumberResponseUnmarshaller.Instance;

            return Invoke<PutOptedOutNumberResponse>(request, options);
        }



        /// <summary>
        /// Creates an opted out destination phone number in the opt-out list.
        /// 
        ///  
        /// <para>
        /// If the destination phone number isn't valid or if the specified opt-out list doesn't
        /// exist, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutOptedOutNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutOptedOutNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutOptedOutNumber">REST API Reference for PutOptedOutNumber Operation</seealso>
        public virtual Task<PutOptedOutNumberResponse> PutOptedOutNumberAsync(PutOptedOutNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutOptedOutNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutOptedOutNumberResponseUnmarshaller.Instance;

            return InvokeAsync<PutOptedOutNumberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutProtectConfigurationRuleSetNumberOverride

        internal virtual PutProtectConfigurationRuleSetNumberOverrideResponse PutProtectConfigurationRuleSetNumberOverride(PutProtectConfigurationRuleSetNumberOverrideRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProtectConfigurationRuleSetNumberOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProtectConfigurationRuleSetNumberOverrideResponseUnmarshaller.Instance;

            return Invoke<PutProtectConfigurationRuleSetNumberOverrideResponse>(request, options);
        }



        /// <summary>
        /// Create or update a phone number rule override and associate it with a protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutProtectConfigurationRuleSetNumberOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutProtectConfigurationRuleSetNumberOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutProtectConfigurationRuleSetNumberOverride">REST API Reference for PutProtectConfigurationRuleSetNumberOverride Operation</seealso>
        public virtual Task<PutProtectConfigurationRuleSetNumberOverrideResponse> PutProtectConfigurationRuleSetNumberOverrideAsync(PutProtectConfigurationRuleSetNumberOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutProtectConfigurationRuleSetNumberOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutProtectConfigurationRuleSetNumberOverrideResponseUnmarshaller.Instance;

            return InvokeAsync<PutProtectConfigurationRuleSetNumberOverrideResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutRegistrationFieldValue

        internal virtual PutRegistrationFieldValueResponse PutRegistrationFieldValue(PutRegistrationFieldValueRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRegistrationFieldValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRegistrationFieldValueResponseUnmarshaller.Instance;

            return Invoke<PutRegistrationFieldValueResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates a field value for a registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutRegistrationFieldValue service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutRegistrationFieldValue service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutRegistrationFieldValue">REST API Reference for PutRegistrationFieldValue Operation</seealso>
        public virtual Task<PutRegistrationFieldValueResponse> PutRegistrationFieldValueAsync(PutRegistrationFieldValueRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutRegistrationFieldValueRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutRegistrationFieldValueResponseUnmarshaller.Instance;

            return InvokeAsync<PutRegistrationFieldValueResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Attaches a resource-based policy to a AWS End User Messaging SMS and Voice resource(phone
        /// number, sender Id, phone poll, or opt-out list) that is used for sharing the resource.
        /// A shared resource can be a Pool, Opt-out list, Sender Id, or Phone number. For more
        /// information about resource-based policies, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/shared-resources.html">Working
        /// with shared resources</a> in the <i>AWS End User Messaging SMS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ReleasePhoneNumber

        internal virtual ReleasePhoneNumberResponse ReleasePhoneNumber(ReleasePhoneNumberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReleasePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleasePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<ReleasePhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// Releases an existing origination phone number in your account. Once released, a phone
        /// number is no longer available for sending messages.
        /// 
        ///  
        /// <para>
        /// If the origination phone number has deletion protection enabled or is associated with
        /// a pool, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleasePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleasePhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ReleasePhoneNumber">REST API Reference for ReleasePhoneNumber Operation</seealso>
        public virtual Task<ReleasePhoneNumberResponse> ReleasePhoneNumberAsync(ReleasePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReleasePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleasePhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<ReleasePhoneNumberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ReleaseSenderId

        internal virtual ReleaseSenderIdResponse ReleaseSenderId(ReleaseSenderIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReleaseSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseSenderIdResponseUnmarshaller.Instance;

            return Invoke<ReleaseSenderIdResponse>(request, options);
        }



        /// <summary>
        /// Releases an existing sender ID in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseSenderId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ReleaseSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/ReleaseSenderId">REST API Reference for ReleaseSenderId Operation</seealso>
        public virtual Task<ReleaseSenderIdResponse> ReleaseSenderIdAsync(ReleaseSenderIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ReleaseSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseSenderIdResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseSenderIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RequestPhoneNumber

        internal virtual RequestPhoneNumberResponse RequestPhoneNumber(RequestPhoneNumberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestPhoneNumberResponseUnmarshaller.Instance;

            return Invoke<RequestPhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// Request an origination phone number for use in your account. For more information
        /// on phone number request see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/phone-numbers-request.html">Request
        /// a phone number</a> in the <i>AWS End User Messaging SMS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestPhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestPhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/RequestPhoneNumber">REST API Reference for RequestPhoneNumber Operation</seealso>
        public virtual Task<RequestPhoneNumberResponse> RequestPhoneNumberAsync(RequestPhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestPhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestPhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<RequestPhoneNumberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  RequestSenderId

        internal virtual RequestSenderIdResponse RequestSenderId(RequestSenderIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestSenderIdResponseUnmarshaller.Instance;

            return Invoke<RequestSenderIdResponse>(request, options);
        }



        /// <summary>
        /// Request a new sender ID that doesn't require registration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSenderId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RequestSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/RequestSenderId">REST API Reference for RequestSenderId Operation</seealso>
        public virtual Task<RequestSenderIdResponse> RequestSenderIdAsync(RequestSenderIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = RequestSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestSenderIdResponseUnmarshaller.Instance;

            return InvokeAsync<RequestSenderIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendDestinationNumberVerificationCode

        internal virtual SendDestinationNumberVerificationCodeResponse SendDestinationNumberVerificationCode(SendDestinationNumberVerificationCodeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendDestinationNumberVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDestinationNumberVerificationCodeResponseUnmarshaller.Instance;

            return Invoke<SendDestinationNumberVerificationCodeResponse>(request, options);
        }



        /// <summary>
        /// Before you can send test messages to a verified destination phone number you need
        /// to opt-in the verified destination phone number. Creates a new text message with a
        /// verification code and send it to a verified destination phone number. Once you have
        /// the verification code use <a>VerifyDestinationNumber</a> to opt-in the verified destination
        /// phone number to receive messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendDestinationNumberVerificationCode service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendDestinationNumberVerificationCode service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendDestinationNumberVerificationCode">REST API Reference for SendDestinationNumberVerificationCode Operation</seealso>
        public virtual Task<SendDestinationNumberVerificationCodeResponse> SendDestinationNumberVerificationCodeAsync(SendDestinationNumberVerificationCodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendDestinationNumberVerificationCodeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendDestinationNumberVerificationCodeResponseUnmarshaller.Instance;

            return InvokeAsync<SendDestinationNumberVerificationCodeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendMediaMessage

        internal virtual SendMediaMessageResponse SendMediaMessage(SendMediaMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMediaMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMediaMessageResponseUnmarshaller.Instance;

            return Invoke<SendMediaMessageResponse>(request, options);
        }



        /// <summary>
        /// Creates a new multimedia message (MMS) and sends it to a recipient's phone number.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendMediaMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendMediaMessage service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendMediaMessage">REST API Reference for SendMediaMessage Operation</seealso>
        public virtual Task<SendMediaMessageResponse> SendMediaMessageAsync(SendMediaMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendMediaMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendMediaMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendMediaMessageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendTextMessage

        internal virtual SendTextMessageResponse SendTextMessage(SendTextMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendTextMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTextMessageResponseUnmarshaller.Instance;

            return Invoke<SendTextMessageResponse>(request, options);
        }



        /// <summary>
        /// Creates a new text message and sends it to a recipient's phone number. SendTextMessage
        /// only sends an SMS message to one recipient each time it is invoked.
        /// 
        ///  
        /// <para>
        /// SMS throughput limits are measured in Message Parts per Second (MPS). Your MPS limit
        /// depends on the destination country of your messages, as well as the type of phone
        /// number (origination number) that you use to send the message. For more information
        /// about MPS, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/sms-limitations-mps.html">Message
        /// Parts per Second (MPS) limits</a> in the <i>AWS End User Messaging SMS User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTextMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendTextMessage service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendTextMessage">REST API Reference for SendTextMessage Operation</seealso>
        public virtual Task<SendTextMessageResponse> SendTextMessageAsync(SendTextMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendTextMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendTextMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendTextMessageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendVoiceMessage

        internal virtual SendVoiceMessageResponse SendVoiceMessage(SendVoiceMessageRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendVoiceMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendVoiceMessageResponseUnmarshaller.Instance;

            return Invoke<SendVoiceMessageResponse>(request, options);
        }



        /// <summary>
        /// Allows you to send a request that sends a voice message. This operation uses <a href="http://aws.amazon.com/polly/">Amazon
        /// Polly</a> to convert a text script into a voice message.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendVoiceMessage service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendVoiceMessage service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SendVoiceMessage">REST API Reference for SendVoiceMessage Operation</seealso>
        public virtual Task<SendVoiceMessageResponse> SendVoiceMessageAsync(SendVoiceMessageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendVoiceMessageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendVoiceMessageResponseUnmarshaller.Instance;

            return InvokeAsync<SendVoiceMessageResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetAccountDefaultProtectConfiguration

        internal virtual SetAccountDefaultProtectConfigurationResponse SetAccountDefaultProtectConfiguration(SetAccountDefaultProtectConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetAccountDefaultProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetAccountDefaultProtectConfigurationResponseUnmarshaller.Instance;

            return Invoke<SetAccountDefaultProtectConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Set a protect configuration as your account default. You can only have one account
        /// default protect configuration at a time. The current account default protect configuration
        /// is replaced with the provided protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetAccountDefaultProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetAccountDefaultProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetAccountDefaultProtectConfiguration">REST API Reference for SetAccountDefaultProtectConfiguration Operation</seealso>
        public virtual Task<SetAccountDefaultProtectConfigurationResponse> SetAccountDefaultProtectConfigurationAsync(SetAccountDefaultProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetAccountDefaultProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetAccountDefaultProtectConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<SetAccountDefaultProtectConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetDefaultMessageFeedbackEnabled

        internal virtual SetDefaultMessageFeedbackEnabledResponse SetDefaultMessageFeedbackEnabled(SetDefaultMessageFeedbackEnabledRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetDefaultMessageFeedbackEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultMessageFeedbackEnabledResponseUnmarshaller.Instance;

            return Invoke<SetDefaultMessageFeedbackEnabledResponse>(request, options);
        }



        /// <summary>
        /// Sets a configuration set's default for message feedback.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultMessageFeedbackEnabled service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDefaultMessageFeedbackEnabled service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultMessageFeedbackEnabled">REST API Reference for SetDefaultMessageFeedbackEnabled Operation</seealso>
        public virtual Task<SetDefaultMessageFeedbackEnabledResponse> SetDefaultMessageFeedbackEnabledAsync(SetDefaultMessageFeedbackEnabledRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetDefaultMessageFeedbackEnabledRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultMessageFeedbackEnabledResponseUnmarshaller.Instance;

            return InvokeAsync<SetDefaultMessageFeedbackEnabledResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetDefaultMessageType

        internal virtual SetDefaultMessageTypeResponse SetDefaultMessageType(SetDefaultMessageTypeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetDefaultMessageTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultMessageTypeResponseUnmarshaller.Instance;

            return Invoke<SetDefaultMessageTypeResponse>(request, options);
        }



        /// <summary>
        /// Sets the default message type on a configuration set.
        /// 
        ///  
        /// <para>
        /// Choose the category of SMS messages that you plan to send from this account. If you
        /// send account-related messages or time-sensitive messages such as one-time passcodes,
        /// choose <b>Transactional</b>. If you plan to send messages that contain marketing material
        /// or other promotional content, choose <b>Promotional</b>. This setting applies to your
        /// entire Amazon Web Services account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultMessageType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDefaultMessageType service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultMessageType">REST API Reference for SetDefaultMessageType Operation</seealso>
        public virtual Task<SetDefaultMessageTypeResponse> SetDefaultMessageTypeAsync(SetDefaultMessageTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetDefaultMessageTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultMessageTypeResponseUnmarshaller.Instance;

            return InvokeAsync<SetDefaultMessageTypeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetDefaultSenderId

        internal virtual SetDefaultSenderIdResponse SetDefaultSenderId(SetDefaultSenderIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetDefaultSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultSenderIdResponseUnmarshaller.Instance;

            return Invoke<SetDefaultSenderIdResponse>(request, options);
        }



        /// <summary>
        /// Sets default sender ID on a configuration set.
        /// 
        ///  
        /// <para>
        /// When sending a text message to a destination country that supports sender IDs, the
        /// default sender ID on the configuration set specified will be used if no dedicated
        /// origination phone numbers or registered sender IDs are available in your account.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetDefaultSenderId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetDefaultSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetDefaultSenderId">REST API Reference for SetDefaultSenderId Operation</seealso>
        public virtual Task<SetDefaultSenderIdResponse> SetDefaultSenderIdAsync(SetDefaultSenderIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetDefaultSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetDefaultSenderIdResponseUnmarshaller.Instance;

            return InvokeAsync<SetDefaultSenderIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetMediaMessageSpendLimitOverride

        internal virtual SetMediaMessageSpendLimitOverrideResponse SetMediaMessageSpendLimitOverride(SetMediaMessageSpendLimitOverrideRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetMediaMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetMediaMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return Invoke<SetMediaMessageSpendLimitOverrideResponse>(request, options);
        }



        /// <summary>
        /// Sets an account level monthly spend limit override for sending MMS messages. The requested
        /// spend limit must be less than or equal to the <c>MaxLimit</c>, which is set by Amazon
        /// Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetMediaMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetMediaMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetMediaMessageSpendLimitOverride">REST API Reference for SetMediaMessageSpendLimitOverride Operation</seealso>
        public virtual Task<SetMediaMessageSpendLimitOverrideResponse> SetMediaMessageSpendLimitOverrideAsync(SetMediaMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetMediaMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetMediaMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return InvokeAsync<SetMediaMessageSpendLimitOverrideResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetTextMessageSpendLimitOverride

        internal virtual SetTextMessageSpendLimitOverrideResponse SetTextMessageSpendLimitOverride(SetTextMessageSpendLimitOverrideRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTextMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTextMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return Invoke<SetTextMessageSpendLimitOverrideResponse>(request, options);
        }



        /// <summary>
        /// Sets an account level monthly spend limit override for sending text messages. The
        /// requested spend limit must be less than or equal to the <c>MaxLimit</c>, which is
        /// set by Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetTextMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetTextMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetTextMessageSpendLimitOverride">REST API Reference for SetTextMessageSpendLimitOverride Operation</seealso>
        public virtual Task<SetTextMessageSpendLimitOverrideResponse> SetTextMessageSpendLimitOverrideAsync(SetTextMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetTextMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetTextMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return InvokeAsync<SetTextMessageSpendLimitOverrideResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SetVoiceMessageSpendLimitOverride

        internal virtual SetVoiceMessageSpendLimitOverrideResponse SetVoiceMessageSpendLimitOverride(SetVoiceMessageSpendLimitOverrideRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetVoiceMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVoiceMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return Invoke<SetVoiceMessageSpendLimitOverrideResponse>(request, options);
        }



        /// <summary>
        /// Sets an account level monthly spend limit override for sending voice messages. The
        /// requested spend limit must be less than or equal to the <c>MaxLimit</c>, which is
        /// set by Amazon Web Services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetVoiceMessageSpendLimitOverride service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetVoiceMessageSpendLimitOverride service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SetVoiceMessageSpendLimitOverride">REST API Reference for SetVoiceMessageSpendLimitOverride Operation</seealso>
        public virtual Task<SetVoiceMessageSpendLimitOverrideResponse> SetVoiceMessageSpendLimitOverrideAsync(SetVoiceMessageSpendLimitOverrideRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SetVoiceMessageSpendLimitOverrideRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetVoiceMessageSpendLimitOverrideResponseUnmarshaller.Instance;

            return InvokeAsync<SetVoiceMessageSpendLimitOverrideResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SubmitRegistrationVersion

        internal virtual SubmitRegistrationVersionResponse SubmitRegistrationVersion(SubmitRegistrationVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubmitRegistrationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitRegistrationVersionResponseUnmarshaller.Instance;

            return Invoke<SubmitRegistrationVersionResponse>(request, options);
        }



        /// <summary>
        /// Submit the specified registration for review and approval.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SubmitRegistrationVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SubmitRegistrationVersion service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/SubmitRegistrationVersion">REST API Reference for SubmitRegistrationVersion Operation</seealso>
        public virtual Task<SubmitRegistrationVersionResponse> SubmitRegistrationVersionAsync(SubmitRegistrationVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SubmitRegistrationVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SubmitRegistrationVersionResponseUnmarshaller.Instance;

            return InvokeAsync<SubmitRegistrationVersionResponse>(request, options, cancellationToken);
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
        /// an existing tag key, the value is overwritten with the new value. Each tag consists
        /// of a key and an optional value. Tag keys must be unique per resource. For more information
        /// about tags, see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/phone-numbers-tags.html">Tags
        /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes the association of the specified tags from a resource. For more information
        /// on tags see <a href="https://docs.aws.amazon.com/sms-voice/latest/userguide/phone-numbers-tags.html">Tags
        /// </a> in the <i>AWS End User Messaging SMS User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateEventDestination

        internal virtual UpdateEventDestinationResponse UpdateEventDestination(UpdateEventDestinationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventDestinationResponseUnmarshaller.Instance;

            return Invoke<UpdateEventDestinationResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing event destination in a configuration set. You can update the IAM
        /// role ARN for CloudWatch Logs and Firehose. You can also enable or disable the event
        /// destination.
        /// 
        ///  
        /// <para>
        /// You may want to update an event destination to change its matching event types or
        /// updating the destination resource ARN. You can't change an event destination's type
        /// between CloudWatch Logs, Firehose, and Amazon SNS.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEventDestination service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateEventDestination service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateEventDestination">REST API Reference for UpdateEventDestination Operation</seealso>
        public virtual Task<UpdateEventDestinationResponse> UpdateEventDestinationAsync(UpdateEventDestinationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateEventDestinationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEventDestinationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEventDestinationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePhoneNumber

        internal virtual UpdatePhoneNumberResponse UpdatePhoneNumber(UpdatePhoneNumberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;

            return Invoke<UpdatePhoneNumberResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an existing origination phone number. You can update
        /// the opt-out list, enable or disable two-way messaging, change the TwoWayChannelArn,
        /// enable or disable self-managed opt-outs, and enable or disable deletion protection.
        /// 
        ///  
        /// <para>
        /// If the origination phone number is associated with a pool, an error is returned.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePhoneNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePhoneNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePhoneNumber">REST API Reference for UpdatePhoneNumber Operation</seealso>
        public virtual Task<UpdatePhoneNumberResponse> UpdatePhoneNumberAsync(UpdatePhoneNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePhoneNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePhoneNumberResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePhoneNumberResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdatePool

        internal virtual UpdatePoolResponse UpdatePool(UpdatePoolRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePoolResponseUnmarshaller.Instance;

            return Invoke<UpdatePoolResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an existing pool. You can update the opt-out list, enable
        /// or disable two-way messaging, change the <c>TwoWayChannelArn</c>, enable or disable
        /// self-managed opt-outs, enable or disable deletion protection, and enable or disable
        /// shared routes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdatePool service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdatePool service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdatePool">REST API Reference for UpdatePool Operation</seealso>
        public virtual Task<UpdatePoolResponse> UpdatePoolAsync(UpdatePoolRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdatePoolRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdatePoolResponseUnmarshaller.Instance;

            return InvokeAsync<UpdatePoolResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProtectConfiguration

        internal virtual UpdateProtectConfigurationResponse UpdateProtectConfiguration(UpdateProtectConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateProtectConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Update the setting for an existing protect configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProtectConfiguration service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateProtectConfiguration">REST API Reference for UpdateProtectConfiguration Operation</seealso>
        public virtual Task<UpdateProtectConfigurationResponse> UpdateProtectConfigurationAsync(UpdateProtectConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProtectConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProtectConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProtectConfigurationCountryRuleSet

        internal virtual UpdateProtectConfigurationCountryRuleSetResponse UpdateProtectConfigurationCountryRuleSet(UpdateProtectConfigurationCountryRuleSetRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProtectConfigurationCountryRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectConfigurationCountryRuleSetResponseUnmarshaller.Instance;

            return Invoke<UpdateProtectConfigurationCountryRuleSetResponse>(request, options);
        }



        /// <summary>
        /// Update a country rule set to <c>ALLOW</c>, <c>BLOCK</c>, <c>MONITOR</c>, or <c>FILTER</c>
        /// messages to be sent to the specified destination counties. You can update one or multiple
        /// countries at a time. The updates are only applied to the specified NumberCapability
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProtectConfigurationCountryRuleSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProtectConfigurationCountryRuleSet service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateProtectConfigurationCountryRuleSet">REST API Reference for UpdateProtectConfigurationCountryRuleSet Operation</seealso>
        public virtual Task<UpdateProtectConfigurationCountryRuleSetResponse> UpdateProtectConfigurationCountryRuleSetAsync(UpdateProtectConfigurationCountryRuleSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProtectConfigurationCountryRuleSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProtectConfigurationCountryRuleSetResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProtectConfigurationCountryRuleSetResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateSenderId

        internal virtual UpdateSenderIdResponse UpdateSenderId(UpdateSenderIdRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSenderIdResponseUnmarshaller.Instance;

            return Invoke<UpdateSenderIdResponse>(request, options);
        }



        /// <summary>
        /// Updates the configuration of an existing sender ID.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSenderId service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSenderId service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/UpdateSenderId">REST API Reference for UpdateSenderId Operation</seealso>
        public virtual Task<UpdateSenderIdResponse> UpdateSenderIdAsync(UpdateSenderIdRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateSenderIdRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSenderIdResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSenderIdResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  VerifyDestinationNumber

        internal virtual VerifyDestinationNumberResponse VerifyDestinationNumber(VerifyDestinationNumberRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyDestinationNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyDestinationNumberResponseUnmarshaller.Instance;

            return Invoke<VerifyDestinationNumberResponse>(request, options);
        }



        /// <summary>
        /// Use the verification code that was received by the verified destination phone number
        /// to opt-in the verified destination phone number to receive more messages.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the VerifyDestinationNumber service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the VerifyDestinationNumber service method, as returned by PinpointSMSVoiceV2.</returns>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.AccessDeniedException">
        /// The request was denied because you don't have sufficient permissions to access the
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ConflictException">
        /// Your request has conflicting operations. This can occur if you're trying to perform
        /// more than one operation on the same resource at the same time or it could be that
        /// the requested action isn't valid for the current state or configuration of the resource.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.InternalServerException">
        /// The API encountered an unexpected error and couldn't complete the request. You might
        /// be able to successfully issue the request again in the future.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ResourceNotFoundException">
        /// A requested resource couldn't be found.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ThrottlingException">
        /// An error that occurred because too many requests were sent during a certain amount
        /// of time.
        /// </exception>
        /// <exception cref="Amazon.PinpointSMSVoiceV2.Model.ValidationException">
        /// A validation exception for a field.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/pinpoint-sms-voice-v2-2022-03-31/VerifyDestinationNumber">REST API Reference for VerifyDestinationNumber Operation</seealso>
        public virtual Task<VerifyDestinationNumberResponse> VerifyDestinationNumberAsync(VerifyDestinationNumberRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = VerifyDestinationNumberRequestMarshaller.Instance;
            options.ResponseUnmarshaller = VerifyDestinationNumberResponseUnmarshaller.Instance;

            return InvokeAsync<VerifyDestinationNumberResponse>(request, options, cancellationToken);
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