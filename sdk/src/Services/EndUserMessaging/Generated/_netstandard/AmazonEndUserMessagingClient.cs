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
 * Do not modify this file. This file is generated from the endusermessaging-2026-09-21.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EndUserMessaging.Model;
using Amazon.EndUserMessaging.Model.Internal.MarshallTransformations;
using Amazon.EndUserMessaging.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.EndUserMessaging
{
    /// <summary>
    /// <para>Implementation for accessing EndUserMessaging</para>
    /// <para>
    /// Service client instances are thread-safe and can be shared across multiple threads.
    /// For a given service configuration, it is recommended to reuse a client instance
    /// for the lifetime of your application.
    /// </para>
    ///
    /// AWS End User Messaging provides a set of APIs to manage brand profiles, synchronize
    /// brand profile data with SMS and Rich Communication Services (RCS) registrations, and
    /// send and validate one-time passcodes across the SMS, voice, and WhatsApp channels.
    /// </summary>
    public partial class AmazonEndUserMessagingClient : AmazonServiceClient, IAmazonEndUserMessaging
    {
        private static IServiceMetadata serviceMetadata = new AmazonEndUserMessagingMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with the credentials loaded from the application's
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
        public AmazonEndUserMessagingClient()
            : base(new AmazonEndUserMessagingConfig()) { }

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with the credentials loaded from the application's
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
        public AmazonEndUserMessagingClient(RegionEndpoint region)
            : base(new AmazonEndUserMessagingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEndUserMessagingClient Configuration Object</param>
        public AmazonEndUserMessagingClient(AmazonEndUserMessagingConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEndUserMessagingClient(AWSCredentials credentials)
            : this(credentials, new AmazonEndUserMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEndUserMessagingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEndUserMessagingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with AWS Credentials and an
        /// AmazonEndUserMessagingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEndUserMessagingClient Configuration Object</param>
        public AmazonEndUserMessagingClient(AWSCredentials credentials, AmazonEndUserMessagingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEndUserMessagingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEndUserMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEndUserMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEndUserMessagingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEndUserMessagingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEndUserMessagingClient Configuration Object</param>
        public AmazonEndUserMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonEndUserMessagingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEndUserMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEndUserMessagingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEndUserMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEndUserMessagingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEndUserMessagingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEndUserMessagingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEndUserMessagingClient Configuration Object</param>
        public AmazonEndUserMessagingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEndUserMessagingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IEndUserMessagingPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IEndUserMessagingPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new EndUserMessagingPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEndUserMessagingEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonEndUserMessagingAuthSchemeHandler());
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


        #region  CreateBrandProfile

        internal virtual CreateBrandProfileResponse CreateBrandProfile(CreateBrandProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrandProfileResponseUnmarshaller.Instance;

            return Invoke<CreateBrandProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a brand profile. A brand profile is a lightweight container that holds your
        /// brand identity information as flexible attributes. After you create a brand profile,
        /// use the CreateBrandProfileAttributes operation to add company information, addresses,
        /// compliance documents, and logos.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateBrandProfile">REST API Reference for CreateBrandProfile Operation</seealso>
        public virtual Task<CreateBrandProfileResponse> CreateBrandProfileAsync(CreateBrandProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrandProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBrandProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBrandProfileAttributes

        internal virtual CreateBrandProfileAttributesResponse CreateBrandProfileAttributes(CreateBrandProfileAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBrandProfileAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrandProfileAttributesResponseUnmarshaller.Instance;

            return Invoke<CreateBrandProfileAttributesResponse>(request, options);
        }



        /// <summary>
        /// Creates up to 10 attributes for a brand profile in a single request. For attributes
        /// of type IMAGE or DOCUMENT, the response includes a presigned Amazon S3 URL that you
        /// use to upload the media. This operation is atomic: either all of the attributes are
        /// created, or none of them are.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrandProfileAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrandProfileAttributes service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateBrandProfileAttributes">REST API Reference for CreateBrandProfileAttributes Operation</seealso>
        public virtual Task<CreateBrandProfileAttributesResponse> CreateBrandProfileAttributesAsync(CreateBrandProfileAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBrandProfileAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrandProfileAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBrandProfileAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateBrandProfileFromRegistration

        internal virtual CreateBrandProfileFromRegistrationResponse CreateBrandProfileFromRegistration(CreateBrandProfileFromRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBrandProfileFromRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrandProfileFromRegistrationResponseUnmarshaller.Instance;

            return Invoke<CreateBrandProfileFromRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Creates a brand profile and populates its attributes from an existing registration.
        /// This operation runs asynchronously. Use the GetJob operation to track its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBrandProfileFromRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBrandProfileFromRegistration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateBrandProfileFromRegistration">REST API Reference for CreateBrandProfileFromRegistration Operation</seealso>
        public virtual Task<CreateBrandProfileFromRegistrationResponse> CreateBrandProfileFromRegistrationAsync(CreateBrandProfileFromRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateBrandProfileFromRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBrandProfileFromRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBrandProfileFromRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateNotifyCodeConfiguration

        internal virtual CreateNotifyCodeConfigurationResponse CreateNotifyCodeConfiguration(CreateNotifyCodeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNotifyCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotifyCodeConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateNotifyCodeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Creates a notify code configuration. A notify code configuration is a reusable policy
        /// that defines how one-time passcodes are generated and rendered, including the code
        /// type, length, validity period, maximum number of attempts, and channel templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNotifyCodeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateNotifyCodeConfiguration">REST API Reference for CreateNotifyCodeConfiguration Operation</seealso>
        public virtual Task<CreateNotifyCodeConfigurationResponse> CreateNotifyCodeConfigurationAsync(CreateNotifyCodeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateNotifyCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNotifyCodeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNotifyCodeConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateRegistrationsFromBrandProfile

        internal virtual CreateRegistrationsFromBrandProfileResponse CreateRegistrationsFromBrandProfile(CreateRegistrationsFromBrandProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistrationsFromBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistrationsFromBrandProfileResponseUnmarshaller.Instance;

            return Invoke<CreateRegistrationsFromBrandProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates one or more registrations in the DRAFT state and prefills their fields from
        /// the attributes of a brand profile. This operation runs asynchronously. Use the GetJob
        /// operation to track its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRegistrationsFromBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRegistrationsFromBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/CreateRegistrationsFromBrandProfile">REST API Reference for CreateRegistrationsFromBrandProfile Operation</seealso>
        public virtual Task<CreateRegistrationsFromBrandProfileResponse> CreateRegistrationsFromBrandProfileAsync(CreateRegistrationsFromBrandProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateRegistrationsFromBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRegistrationsFromBrandProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRegistrationsFromBrandProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBrandProfile

        internal virtual DeleteBrandProfileResponse DeleteBrandProfile(DeleteBrandProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrandProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteBrandProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes a brand profile. This operation also deletes the attributes of the profile
        /// and any associated media. The request fails if deletion protection is enabled for
        /// the profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/DeleteBrandProfile">REST API Reference for DeleteBrandProfile Operation</seealso>
        public virtual Task<DeleteBrandProfileResponse> DeleteBrandProfileAsync(DeleteBrandProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrandProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBrandProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteBrandProfileAttribute

        internal virtual DeleteBrandProfileAttributeResponse DeleteBrandProfileAttribute(DeleteBrandProfileAttributeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBrandProfileAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrandProfileAttributeResponseUnmarshaller.Instance;

            return Invoke<DeleteBrandProfileAttributeResponse>(request, options);
        }



        /// <summary>
        /// Deletes a brand profile attribute. If the attribute stores media, this operation also
        /// deletes the associated media.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBrandProfileAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBrandProfileAttribute service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/DeleteBrandProfileAttribute">REST API Reference for DeleteBrandProfileAttribute Operation</seealso>
        public virtual Task<DeleteBrandProfileAttributeResponse> DeleteBrandProfileAttributeAsync(DeleteBrandProfileAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteBrandProfileAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBrandProfileAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBrandProfileAttributeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteNotifyCodeConfiguration

        internal virtual DeleteNotifyCodeConfigurationResponse DeleteNotifyCodeConfiguration(DeleteNotifyCodeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotifyCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotifyCodeConfigurationResponseUnmarshaller.Instance;

            return Invoke<DeleteNotifyCodeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Deletes a notify code configuration. Verifications that are already in progress are
        /// not affected, because they capture the policy at the time that the passcode was sent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNotifyCodeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/DeleteNotifyCodeConfiguration">REST API Reference for DeleteNotifyCodeConfiguration Operation</seealso>
        public virtual Task<DeleteNotifyCodeConfigurationResponse> DeleteNotifyCodeConfigurationAsync(DeleteNotifyCodeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteNotifyCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNotifyCodeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNotifyCodeConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBrandProfile

        internal virtual GetBrandProfileResponse GetBrandProfile(GetBrandProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrandProfileResponseUnmarshaller.Instance;

            return Invoke<GetBrandProfileResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the metadata for a brand profile, including its name, status, deletion protection
        /// setting, and timestamps. To retrieve the attributes of the profile, use the ListBrandProfileAttributes
        /// operation.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetBrandProfile">REST API Reference for GetBrandProfile Operation</seealso>
        public virtual Task<GetBrandProfileResponse> GetBrandProfileAsync(GetBrandProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrandProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetBrandProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetBrandProfileAttribute

        internal virtual GetBrandProfileAttributeResponse GetBrandProfileAttribute(GetBrandProfileAttributeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBrandProfileAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrandProfileAttributeResponseUnmarshaller.Instance;

            return Invoke<GetBrandProfileAttributeResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a single brand profile attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetBrandProfileAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetBrandProfileAttribute service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetBrandProfileAttribute">REST API Reference for GetBrandProfileAttribute Operation</seealso>
        public virtual Task<GetBrandProfileAttributeResponse> GetBrandProfileAttributeAsync(GetBrandProfileAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetBrandProfileAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetBrandProfileAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<GetBrandProfileAttributeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetJob

        internal virtual GetJobResponse GetJob(GetJobRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return Invoke<GetJobResponse>(request, options);
        }



        /// <summary>
        /// Retrieves the current state of an asynchronous job, including its status and any resources
        /// that it created or updated.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetJob service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetJob service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetJob">REST API Reference for GetJob Operation</seealso>
        public virtual Task<GetJobResponse> GetJobAsync(GetJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetJobResponseUnmarshaller.Instance;

            return InvokeAsync<GetJobResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetNotifyCodeConfiguration

        internal virtual GetNotifyCodeConfigurationResponse GetNotifyCodeConfiguration(GetNotifyCodeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotifyCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotifyCodeConfigurationResponseUnmarshaller.Instance;

            return Invoke<GetNotifyCodeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a notify code configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNotifyCodeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/GetNotifyCodeConfiguration">REST API Reference for GetNotifyCodeConfiguration Operation</seealso>
        public virtual Task<GetNotifyCodeConfigurationResponse> GetNotifyCodeConfigurationAsync(GetNotifyCodeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetNotifyCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNotifyCodeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<GetNotifyCodeConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBrandProfileAttributes

        internal virtual ListBrandProfileAttributesResponse ListBrandProfileAttributes(ListBrandProfileAttributesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBrandProfileAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrandProfileAttributesResponseUnmarshaller.Instance;

            return Invoke<ListBrandProfileAttributesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of the attributes for a brand profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrandProfileAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrandProfileAttributes service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListBrandProfileAttributes">REST API Reference for ListBrandProfileAttributes Operation</seealso>
        public virtual Task<ListBrandProfileAttributesResponse> ListBrandProfileAttributesAsync(ListBrandProfileAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBrandProfileAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrandProfileAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ListBrandProfileAttributesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListBrandProfiles

        internal virtual ListBrandProfilesResponse ListBrandProfiles(ListBrandProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBrandProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrandProfilesResponseUnmarshaller.Instance;

            return Invoke<ListBrandProfilesResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of the brand profiles in your account. Use the nextToken
        /// parameter to retrieve additional results.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListBrandProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListBrandProfiles service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListBrandProfiles">REST API Reference for ListBrandProfiles Operation</seealso>
        public virtual Task<ListBrandProfilesResponse> ListBrandProfilesAsync(ListBrandProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListBrandProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListBrandProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListBrandProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListJobs

        internal virtual ListJobsResponse ListJobs(ListJobsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return Invoke<ListJobsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of the asynchronous jobs in your account. You can filter
        /// the results by status, brand profile, or operation type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListJobs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListJobs service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListJobs">REST API Reference for ListJobs Operation</seealso>
        public virtual Task<ListJobsResponse> ListJobsAsync(ListJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListJobsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListNotifyCodeConfigurations

        internal virtual ListNotifyCodeConfigurationsResponse ListNotifyCodeConfigurations(ListNotifyCodeConfigurationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotifyCodeConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotifyCodeConfigurationsResponseUnmarshaller.Instance;

            return Invoke<ListNotifyCodeConfigurationsResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of the notify code configurations in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListNotifyCodeConfigurations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListNotifyCodeConfigurations service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListNotifyCodeConfigurations">REST API Reference for ListNotifyCodeConfigurations Operation</seealso>
        public virtual Task<ListNotifyCodeConfigurationsResponse> ListNotifyCodeConfigurationsAsync(ListNotifyCodeConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListNotifyCodeConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListNotifyCodeConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListNotifyCodeConfigurationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListRegistrationsFromBrandProfile

        internal virtual ListRegistrationsFromBrandProfileResponse ListRegistrationsFromBrandProfile(ListRegistrationsFromBrandProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistrationsFromBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistrationsFromBrandProfileResponseUnmarshaller.Instance;

            return Invoke<ListRegistrationsFromBrandProfileResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a paginated list of the registrations that were created from a brand profile
        /// through the synchronization operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRegistrationsFromBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRegistrationsFromBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListRegistrationsFromBrandProfile">REST API Reference for ListRegistrationsFromBrandProfile Operation</seealso>
        public virtual Task<ListRegistrationsFromBrandProfileResponse> ListRegistrationsFromBrandProfileAsync(ListRegistrationsFromBrandProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListRegistrationsFromBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRegistrationsFromBrandProfileResponseUnmarshaller.Instance;

            return InvokeAsync<ListRegistrationsFromBrandProfileResponse>(request, options, cancellationToken);
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
        /// Retrieves the tags that are associated with a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  SendNotifyCodeVerification

        internal virtual SendNotifyCodeVerificationResponse SendNotifyCodeVerification(SendNotifyCodeVerificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendNotifyCodeVerificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendNotifyCodeVerificationResponseUnmarshaller.Instance;

            return Invoke<SendNotifyCodeVerificationResponse>(request, options);
        }



        /// <summary>
        /// Generates a one-time passcode and delivers it to a recipient over the requested channel.
        /// The passcode policy is captured from the referenced notify code configuration at the
        /// time of the request, so later updates to the configuration do not affect verifications
        /// that are already in progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendNotifyCodeVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SendNotifyCodeVerification service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/SendNotifyCodeVerification">REST API Reference for SendNotifyCodeVerification Operation</seealso>
        public virtual Task<SendNotifyCodeVerificationResponse> SendNotifyCodeVerificationAsync(SendNotifyCodeVerificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = SendNotifyCodeVerificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SendNotifyCodeVerificationResponseUnmarshaller.Instance;

            return InvokeAsync<SendNotifyCodeVerificationResponse>(request, options, cancellationToken);
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
        /// Adds or overwrites the tags on a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ServiceQuotaExceededException">
        /// The request would exceed a service quota for your account.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>The response from the UntagResource service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBrandProfile

        internal virtual UpdateBrandProfileResponse UpdateBrandProfile(UpdateBrandProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateBrandProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates the name or the deletion protection setting of a brand profile. To change
        /// the information that is stored in the profile, use the brand profile attribute operations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateBrandProfile">REST API Reference for UpdateBrandProfile Operation</seealso>
        public virtual Task<UpdateBrandProfileResponse> UpdateBrandProfileAsync(UpdateBrandProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBrandProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBrandProfileAttribute

        internal virtual UpdateBrandProfileAttributeResponse UpdateBrandProfileAttribute(UpdateBrandProfileAttributeRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrandProfileAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandProfileAttributeResponseUnmarshaller.Instance;

            return Invoke<UpdateBrandProfileAttributeResponse>(request, options);
        }



        /// <summary>
        /// Updates the value, description, or category of an existing brand profile attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandProfileAttribute service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrandProfileAttribute service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateBrandProfileAttribute">REST API Reference for UpdateBrandProfileAttribute Operation</seealso>
        public virtual Task<UpdateBrandProfileAttributeResponse> UpdateBrandProfileAttributeAsync(UpdateBrandProfileAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrandProfileAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandProfileAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBrandProfileAttributeResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateBrandProfileFromRegistration

        internal virtual UpdateBrandProfileFromRegistrationResponse UpdateBrandProfileFromRegistration(UpdateBrandProfileFromRegistrationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrandProfileFromRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandProfileFromRegistrationResponseUnmarshaller.Instance;

            return Invoke<UpdateBrandProfileFromRegistrationResponse>(request, options);
        }



        /// <summary>
        /// Imports or refreshes the attributes of an existing brand profile from an existing
        /// registration. This operation runs asynchronously. Use the GetJob operation to track
        /// its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateBrandProfileFromRegistration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateBrandProfileFromRegistration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateBrandProfileFromRegistration">REST API Reference for UpdateBrandProfileFromRegistration Operation</seealso>
        public virtual Task<UpdateBrandProfileFromRegistrationResponse> UpdateBrandProfileFromRegistrationAsync(UpdateBrandProfileFromRegistrationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateBrandProfileFromRegistrationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateBrandProfileFromRegistrationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateBrandProfileFromRegistrationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateNotifyCodeConfiguration

        internal virtual UpdateNotifyCodeConfigurationResponse UpdateNotifyCodeConfiguration(UpdateNotifyCodeConfigurationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotifyCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotifyCodeConfigurationResponseUnmarshaller.Instance;

            return Invoke<UpdateNotifyCodeConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Updates the mutable fields of a notify code configuration. Only the fields that you
        /// supply are changed. For the template and language fields, supplying an empty value
        /// clears the currently stored value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNotifyCodeConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNotifyCodeConfiguration service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateNotifyCodeConfiguration">REST API Reference for UpdateNotifyCodeConfiguration Operation</seealso>
        public virtual Task<UpdateNotifyCodeConfigurationResponse> UpdateNotifyCodeConfigurationAsync(UpdateNotifyCodeConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateNotifyCodeConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNotifyCodeConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNotifyCodeConfigurationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateRegistrationsFromBrandProfile

        internal virtual UpdateRegistrationsFromBrandProfileResponse UpdateRegistrationsFromBrandProfile(UpdateRegistrationsFromBrandProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistrationsFromBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistrationsFromBrandProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateRegistrationsFromBrandProfileResponse>(request, options);
        }



        /// <summary>
        /// Repushes the attributes of a brand profile into existing DRAFT registrations. This
        /// operation runs asynchronously. Use the GetJob operation to track its progress.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRegistrationsFromBrandProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRegistrationsFromBrandProfile service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ConflictException">
        /// The request conflicts with the current state of the resource.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ResourceNotFoundException">
        /// The request references a resource that does not exist. Verify that the resource identifier
        /// is correct and try your request again.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/UpdateRegistrationsFromBrandProfile">REST API Reference for UpdateRegistrationsFromBrandProfile Operation</seealso>
        public virtual Task<UpdateRegistrationsFromBrandProfileResponse> UpdateRegistrationsFromBrandProfileAsync(UpdateRegistrationsFromBrandProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateRegistrationsFromBrandProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRegistrationsFromBrandProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRegistrationsFromBrandProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ValidateNotifyCodeVerification

        internal virtual ValidateNotifyCodeVerificationResponse ValidateNotifyCodeVerification(ValidateNotifyCodeVerificationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateNotifyCodeVerificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateNotifyCodeVerificationResponseUnmarshaller.Instance;

            return Invoke<ValidateNotifyCodeVerificationResponse>(request, options);
        }



        /// <summary>
        /// Validates a one-time passcode that a recipient submitted. Validation succeeds when
        /// the passcode matches, the validity period has not elapsed, and the maximum number
        /// of attempts has not been exceeded.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ValidateNotifyCodeVerification service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ValidateNotifyCodeVerification service method, as returned by EndUserMessaging.</returns>
        /// <exception cref="Amazon.EndUserMessaging.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.InternalServerException">
        /// An unexpected error occurred during the processing of the request.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ThrottlingException">
        /// The request was denied because it exceeded the allowed request rate.
        /// </exception>
        /// <exception cref="Amazon.EndUserMessaging.Model.ValidationException">
        /// A standard error for input validation failures. This should be thrown by services
        /// when a member of the input structure falls outside of the modeled or documented constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/endusermessaging-2026-09-21/ValidateNotifyCodeVerification">REST API Reference for ValidateNotifyCodeVerification Operation</seealso>
        public virtual Task<ValidateNotifyCodeVerificationResponse> ValidateNotifyCodeVerificationAsync(ValidateNotifyCodeVerificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ValidateNotifyCodeVerificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ValidateNotifyCodeVerificationResponseUnmarshaller.Instance;

            return InvokeAsync<ValidateNotifyCodeVerificationResponse>(request, options, cancellationToken);
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