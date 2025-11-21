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
 * Do not modify this file. This file is generated from the route53profiles-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Route53Profiles.Model;
using Amazon.Route53Profiles.Model.Internal.MarshallTransformations;
using Amazon.Route53Profiles.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.Route53Profiles
{
    /// <summary>
    /// <para>Implementation for accessing Route53Profiles</para>
    ///
    /// With Amazon Route 53 Profiles you can share Route 53 configurations with VPCs and
    /// AWS accounts
    /// </summary>
    public partial class AmazonRoute53ProfilesClient : AmazonServiceClient, IAmazonRoute53Profiles
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoute53ProfilesMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with the credentials loaded from the application's
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
        public AmazonRoute53ProfilesClient()
            : base(new AmazonRoute53ProfilesConfig()) { }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with the credentials loaded from the application's
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
        public AmazonRoute53ProfilesClient(RegionEndpoint region)
            : base(new AmazonRoute53ProfilesConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoute53ProfilesClient Configuration Object</param>
        public AmazonRoute53ProfilesClient(AmazonRoute53ProfilesConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53ProfilesClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53ProfilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ProfilesClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53ProfilesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Credentials and an
        /// AmazonRoute53ProfilesClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53ProfilesClient Configuration Object</param>
        public AmazonRoute53ProfilesClient(AWSCredentials credentials, AmazonRoute53ProfilesConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53ProfilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53ProfilesConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53ProfilesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53ProfilesClient Configuration Object</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53ProfilesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53ProfilesConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53ProfilesConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53ProfilesClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53ProfilesClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53ProfilesClient Configuration Object</param>
        public AmazonRoute53ProfilesClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53ProfilesConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IRoute53ProfilesPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRoute53ProfilesPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Route53ProfilesPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRoute53ProfilesEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRoute53ProfilesAuthSchemeHandler());
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


        #region  AssociateProfile

        internal virtual AssociateProfileResponse AssociateProfile(AssociateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProfileResponseUnmarshaller.Instance;

            return Invoke<AssociateProfileResponse>(request, options);
        }



        /// <summary>
        /// Associates a Route 53 Profiles profile with a VPC. A VPC can have only one Profile
        /// associated with it, but a Profile can be associated with 1000 of VPCs (and you can
        /// request a higher quota). For more information, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities">https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/DNSLimitations.html#limits-api-entities</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceExistsException">
        /// The resource you are trying to associate, has already been associated.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/AssociateProfile">REST API Reference for AssociateProfile Operation</seealso>
        public virtual Task<AssociateProfileResponse> AssociateProfileAsync(AssociateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  AssociateResourceToProfile

        internal virtual AssociateResourceToProfileResponse AssociateResourceToProfile(AssociateResourceToProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateResourceToProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceToProfileResponseUnmarshaller.Instance;

            return Invoke<AssociateResourceToProfileResponse>(request, options);
        }



        /// <summary>
        /// Associates a DNS reource configuration to a Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateResourceToProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateResourceToProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/AssociateResourceToProfile">REST API Reference for AssociateResourceToProfile Operation</seealso>
        public virtual Task<AssociateResourceToProfileResponse> AssociateResourceToProfileAsync(AssociateResourceToProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = AssociateResourceToProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateResourceToProfileResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateResourceToProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateProfile

        internal virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates an empty Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteProfile

        internal virtual DeleteProfileResponse DeleteProfile(DeleteProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return Invoke<DeleteProfileResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified Route 53 Profile. Before you can delete a profile, you must
        /// first disassociate it from all VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateProfile

        internal virtual DisassociateProfileResponse DisassociateProfile(DisassociateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProfileResponseUnmarshaller.Instance;

            return Invoke<DisassociateProfileResponse>(request, options);
        }



        /// <summary>
        /// Dissociates a specified Route 53 Profile from the specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DisassociateProfile">REST API Reference for DisassociateProfile Operation</seealso>
        public virtual Task<DisassociateProfileResponse> DisassociateProfileAsync(DisassociateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisassociateResourceFromProfile

        internal virtual DisassociateResourceFromProfileResponse DisassociateResourceFromProfile(DisassociateResourceFromProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateResourceFromProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceFromProfileResponseUnmarshaller.Instance;

            return Invoke<DisassociateResourceFromProfileResponse>(request, options);
        }



        /// <summary>
        /// Dissoaciated a specified resource, from the Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateResourceFromProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateResourceFromProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/DisassociateResourceFromProfile">REST API Reference for DisassociateResourceFromProfile Operation</seealso>
        public virtual Task<DisassociateResourceFromProfileResponse> DisassociateResourceFromProfileAsync(DisassociateResourceFromProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisassociateResourceFromProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateResourceFromProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateResourceFromProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProfile

        internal virtual GetProfileResponse GetProfile(GetProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return Invoke<GetProfileResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specified Route 53 Profile, such as whether whether the
        /// Profile is shared, and the current status of the Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProfileAssociation

        internal virtual GetProfileAssociationResponse GetProfileAssociation(GetProfileAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileAssociationResponseUnmarshaller.Instance;

            return Invoke<GetProfileAssociationResponse>(request, options);
        }



        /// <summary>
        /// Retrieves a Route 53 Profile association for a VPC. A VPC can have only one Profile
        /// association, but a Profile can be associated with up to 5000 VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfileAssociation service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfileAssociation">REST API Reference for GetProfileAssociation Operation</seealso>
        public virtual Task<GetProfileAssociationResponse> GetProfileAssociationAsync(GetProfileAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetProfileResourceAssociation

        internal virtual GetProfileResourceAssociationResponse GetProfileResourceAssociation(GetProfileResourceAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResourceAssociationResponseUnmarshaller.Instance;

            return Invoke<GetProfileResourceAssociationResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a specified Route 53 Profile resource association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfileResourceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfileResourceAssociation service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/GetProfileResourceAssociation">REST API Reference for GetProfileResourceAssociation Operation</seealso>
        public virtual Task<GetProfileResourceAssociationResponse> GetProfileResourceAssociationAsync(GetProfileResourceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResourceAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileResourceAssociationResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProfileAssociations

        internal virtual ListProfileAssociationsResponse ListProfileAssociations(ListProfileAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListProfileAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the VPCs that the specified Route 53 Profile is associated with.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfileAssociations service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> you provided isn;t valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfileAssociations">REST API Reference for ListProfileAssociations Operation</seealso>
        public virtual Task<ListProfileAssociationsResponse> ListProfileAssociationsAsync(ListProfileAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProfileAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProfileResourceAssociations

        internal virtual ListProfileResourceAssociationsResponse ListProfileResourceAssociations(ListProfileResourceAssociationsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileResourceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileResourceAssociationsResponseUnmarshaller.Instance;

            return Invoke<ListProfileResourceAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists all the resource associations for the specified Route 53 Profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfileResourceAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfileResourceAssociations service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> you provided isn;t valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfileResourceAssociations">REST API Reference for ListProfileResourceAssociations Operation</seealso>
        public virtual Task<ListProfileResourceAssociationsResponse> ListProfileResourceAssociationsAsync(ListProfileResourceAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfileResourceAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfileResourceAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<ListProfileResourceAssociationsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListProfiles

        internal virtual ListProfilesResponse ListProfiles(ListProfilesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return Invoke<ListProfilesResponse>(request, options);
        }



        /// <summary>
        /// Lists all the Route 53 Profiles associated with your Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidNextTokenException">
        /// The <c>NextToken</c> you provided isn;t valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProfilesResponse>(request, options, cancellationToken);
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
        /// Lists the tags that you associated with the specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Adds one or more tags to a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes one or more tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProfileResourceAssociation

        internal virtual UpdateProfileResourceAssociationResponse UpdateProfileResourceAssociation(UpdateProfileResourceAssociationRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProfileResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResourceAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileResourceAssociationResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified Route 53 Profile resourse association.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfileResourceAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProfileResourceAssociation service method, as returned by Route53Profiles.</returns>
        /// <exception cref="Amazon.Route53Profiles.Model.AccessDeniedException">
        /// The current account doesn't have the IAM permissions required to perform the specified
        /// operation.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ConflictException">
        /// The request you submitted conflicts with an existing request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InternalServiceErrorException">
        /// An internal server error occured. Retry your request.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.InvalidParameterException">
        /// One or more parameters in this request are not valid.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.LimitExceededException">
        /// The request caused one or more limits to be exceeded.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ResourceNotFoundException">
        /// The resource you are associating is not found.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ThrottlingException">
        /// The request was throttled. Try again in a few minutes.
        /// </exception>
        /// <exception cref="Amazon.Route53Profiles.Model.ValidationException">
        /// You have provided an invalid command.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53profiles-2018-05-10/UpdateProfileResourceAssociation">REST API Reference for UpdateProfileResourceAssociation Operation</seealso>
        public virtual Task<UpdateProfileResourceAssociationResponse> UpdateProfileResourceAssociationAsync(UpdateProfileResourceAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProfileResourceAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResourceAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProfileResourceAssociationResponse>(request, options, cancellationToken);
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