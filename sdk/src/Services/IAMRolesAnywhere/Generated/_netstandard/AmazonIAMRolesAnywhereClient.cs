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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.IAMRolesAnywhere.Model;
using Amazon.IAMRolesAnywhere.Model.Internal.MarshallTransformations;
using Amazon.IAMRolesAnywhere.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.IAMRolesAnywhere
{
    /// <summary>
    /// <para>Implementation for accessing IAMRolesAnywhere</para>
    ///
    /// Identity and Access Management Roles Anywhere provides a secure way for your workloads
    /// such as servers, containers, and applications that run outside of Amazon Web Services
    /// to obtain temporary Amazon Web Services credentials. Your workloads can use the same
    /// IAM policies and roles you have for native Amazon Web Services applications to access
    /// Amazon Web Services resources. Using IAM Roles Anywhere eliminates the need to manage
    /// long-term credentials for workloads running outside of Amazon Web Services.
    /// 
    ///  
    /// <para>
    ///  To use IAM Roles Anywhere, your workloads must use X.509 certificates issued by their
    /// certificate authority (CA). You register the CA with IAM Roles Anywhere as a trust
    /// anchor to establish trust between your public key infrastructure (PKI) and IAM Roles
    /// Anywhere. If you don't manage your own PKI system, you can use Private Certificate
    /// Authority to create a CA and then use that to establish trust with IAM Roles Anywhere.
    /// 
    /// </para>
    ///  
    /// <para>
    /// This guide describes the IAM Roles Anywhere operations that you can call programmatically.
    /// For more information about IAM Roles Anywhere, see the <a href="https://docs.aws.amazon.com/rolesanywhere/latest/userguide/introduction.html">IAM
    /// Roles Anywhere User Guide</a>.
    /// </para>
    /// </summary>
    public partial class AmazonIAMRolesAnywhereClient : AmazonServiceClient, IAmazonIAMRolesAnywhere
    {
        private static IServiceMetadata serviceMetadata = new AmazonIAMRolesAnywhereMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with the credentials loaded from the application's
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
        public AmazonIAMRolesAnywhereClient()
            : base(new AmazonIAMRolesAnywhereConfig()) { }

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with the credentials loaded from the application's
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
        public AmazonIAMRolesAnywhereClient(RegionEndpoint region)
            : base(new AmazonIAMRolesAnywhereConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonIAMRolesAnywhereClient Configuration Object</param>
        public AmazonIAMRolesAnywhereClient(AmazonIAMRolesAnywhereConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonIAMRolesAnywhereClient(AWSCredentials credentials)
            : this(credentials, new AmazonIAMRolesAnywhereConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIAMRolesAnywhereClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonIAMRolesAnywhereConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with AWS Credentials and an
        /// AmazonIAMRolesAnywhereClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonIAMRolesAnywhereClient Configuration Object</param>
        public AmazonIAMRolesAnywhereClient(AWSCredentials credentials, AmazonIAMRolesAnywhereConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonIAMRolesAnywhereClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIAMRolesAnywhereConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIAMRolesAnywhereClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonIAMRolesAnywhereConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIAMRolesAnywhereClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonIAMRolesAnywhereClient Configuration Object</param>
        public AmazonIAMRolesAnywhereClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonIAMRolesAnywhereConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonIAMRolesAnywhereClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIAMRolesAnywhereConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonIAMRolesAnywhereClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonIAMRolesAnywhereConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonIAMRolesAnywhereClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonIAMRolesAnywhereClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonIAMRolesAnywhereClient Configuration Object</param>
        public AmazonIAMRolesAnywhereClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonIAMRolesAnywhereConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IIAMRolesAnywherePaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IIAMRolesAnywherePaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new IAMRolesAnywherePaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIAMRolesAnywhereEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonIAMRolesAnywhereAuthSchemeHandler());
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


        #region  CreateProfile

        internal virtual CreateProfileResponse CreateProfile(CreateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return Invoke<CreateProfileResponse>(request, options);
        }



        /// <summary>
        /// Creates a <i>profile</i>, a list of the roles that Roles Anywhere service is trusted
        /// to assume. You use profiles to intersect permissions with IAM managed policies.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:CreateProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateProfile">REST API Reference for CreateProfile Operation</seealso>
        public virtual Task<CreateProfileResponse> CreateProfileAsync(CreateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CreateProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateTrustAnchor

        internal virtual CreateTrustAnchorResponse CreateTrustAnchor(CreateTrustAnchorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustAnchorResponseUnmarshaller.Instance;

            return Invoke<CreateTrustAnchorResponse>(request, options);
        }



        /// <summary>
        /// Creates a trust anchor to establish trust between IAM Roles Anywhere and your certificate
        /// authority (CA). You can define a trust anchor as a reference to an Private Certificate
        /// Authority (Private CA) or by uploading a CA certificate. Your Amazon Web Services
        /// workloads can authenticate with the trust anchor using certificates issued by the
        /// CA in exchange for temporary Amazon Web Services credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:CreateTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/CreateTrustAnchor">REST API Reference for CreateTrustAnchor Operation</seealso>
        public virtual Task<CreateTrustAnchorResponse> CreateTrustAnchorAsync(CreateTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTrustAnchorResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTrustAnchorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteAttributeMapping

        internal virtual DeleteAttributeMappingResponse DeleteAttributeMapping(DeleteAttributeMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAttributeMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttributeMappingResponseUnmarshaller.Instance;

            return Invoke<DeleteAttributeMappingResponse>(request, options);
        }



        /// <summary>
        /// Delete an entry from the attribute mapping rules enforced by a given profile.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttributeMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAttributeMapping service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteAttributeMapping">REST API Reference for DeleteAttributeMapping Operation</seealso>
        public virtual Task<DeleteAttributeMappingResponse> DeleteAttributeMappingAsync(DeleteAttributeMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteAttributeMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttributeMappingResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAttributeMappingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteCrl

        internal virtual DeleteCrlResponse DeleteCrl(DeleteCrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCrlResponseUnmarshaller.Instance;

            return Invoke<DeleteCrlResponse>(request, options);
        }



        /// <summary>
        /// Deletes a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DeleteCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteCrl">REST API Reference for DeleteCrl Operation</seealso>
        public virtual Task<DeleteCrlResponse> DeleteCrlAsync(DeleteCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCrlResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCrlResponse>(request, options, cancellationToken);
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
        /// Deletes a profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DeleteProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteProfile">REST API Reference for DeleteProfile Operation</seealso>
        public virtual Task<DeleteProfileResponse> DeleteProfileAsync(DeleteProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteTrustAnchor

        internal virtual DeleteTrustAnchorResponse DeleteTrustAnchor(DeleteTrustAnchorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustAnchorResponseUnmarshaller.Instance;

            return Invoke<DeleteTrustAnchorResponse>(request, options);
        }



        /// <summary>
        /// Deletes a trust anchor.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DeleteTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DeleteTrustAnchor">REST API Reference for DeleteTrustAnchor Operation</seealso>
        public virtual Task<DeleteTrustAnchorResponse> DeleteTrustAnchorAsync(DeleteTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTrustAnchorResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTrustAnchorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableCrl

        internal virtual DisableCrlResponse DisableCrl(DisableCrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableCrlResponseUnmarshaller.Instance;

            return Invoke<DisableCrlResponse>(request, options);
        }



        /// <summary>
        /// Disables a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DisableCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableCrl">REST API Reference for DisableCrl Operation</seealso>
        public virtual Task<DisableCrlResponse> DisableCrlAsync(DisableCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableCrlResponseUnmarshaller.Instance;

            return InvokeAsync<DisableCrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableProfile

        internal virtual DisableProfileResponse DisableProfile(DisableProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableProfileResponseUnmarshaller.Instance;

            return Invoke<DisableProfileResponse>(request, options);
        }



        /// <summary>
        /// Disables a profile. When disabled, temporary credential requests with this profile
        /// fail.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DisableProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableProfile">REST API Reference for DisableProfile Operation</seealso>
        public virtual Task<DisableProfileResponse> DisableProfileAsync(DisableProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DisableProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DisableTrustAnchor

        internal virtual DisableTrustAnchorResponse DisableTrustAnchor(DisableTrustAnchorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableTrustAnchorResponseUnmarshaller.Instance;

            return Invoke<DisableTrustAnchorResponse>(request, options);
        }



        /// <summary>
        /// Disables a trust anchor. When disabled, temporary credential requests specifying this
        /// trust anchor are unauthorized.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:DisableTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisableTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/DisableTrustAnchor">REST API Reference for DisableTrustAnchor Operation</seealso>
        public virtual Task<DisableTrustAnchorResponse> DisableTrustAnchorAsync(DisableTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DisableTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableTrustAnchorResponseUnmarshaller.Instance;

            return InvokeAsync<DisableTrustAnchorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableCrl

        internal virtual EnableCrlResponse EnableCrl(EnableCrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableCrlResponseUnmarshaller.Instance;

            return Invoke<EnableCrlResponse>(request, options);
        }



        /// <summary>
        /// Enables a certificate revocation list (CRL). When enabled, certificates stored in
        /// the CRL are unauthorized to receive session credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:EnableCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableCrl">REST API Reference for EnableCrl Operation</seealso>
        public virtual Task<EnableCrlResponse> EnableCrlAsync(EnableCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableCrlResponseUnmarshaller.Instance;

            return InvokeAsync<EnableCrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableProfile

        internal virtual EnableProfileResponse EnableProfile(EnableProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableProfileResponseUnmarshaller.Instance;

            return Invoke<EnableProfileResponse>(request, options);
        }



        /// <summary>
        /// Enables temporary credential requests for a profile. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:EnableProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableProfile">REST API Reference for EnableProfile Operation</seealso>
        public virtual Task<EnableProfileResponse> EnableProfileAsync(EnableProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableProfileResponseUnmarshaller.Instance;

            return InvokeAsync<EnableProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  EnableTrustAnchor

        internal virtual EnableTrustAnchorResponse EnableTrustAnchor(EnableTrustAnchorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableTrustAnchorResponseUnmarshaller.Instance;

            return Invoke<EnableTrustAnchorResponse>(request, options);
        }



        /// <summary>
        /// Enables a trust anchor. When enabled, certificates in the trust anchor chain are authorized
        /// for trust validation. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:EnableTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the EnableTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/EnableTrustAnchor">REST API Reference for EnableTrustAnchor Operation</seealso>
        public virtual Task<EnableTrustAnchorResponse> EnableTrustAnchorAsync(EnableTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = EnableTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableTrustAnchorResponseUnmarshaller.Instance;

            return InvokeAsync<EnableTrustAnchorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetCrl

        internal virtual GetCrlResponse GetCrl(GetCrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrlResponseUnmarshaller.Instance;

            return Invoke<GetCrlResponse>(request, options);
        }



        /// <summary>
        /// Gets a certificate revocation list (CRL).
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetCrl">REST API Reference for GetCrl Operation</seealso>
        public virtual Task<GetCrlResponse> GetCrlAsync(GetCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCrlResponseUnmarshaller.Instance;

            return InvokeAsync<GetCrlResponse>(request, options, cancellationToken);
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
        /// Gets a profile.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetProfile">REST API Reference for GetProfile Operation</seealso>
        public virtual Task<GetProfileResponse> GetProfileAsync(GetProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSubject

        internal virtual GetSubjectResponse GetSubject(GetSubjectRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubjectResponseUnmarshaller.Instance;

            return Invoke<GetSubjectResponse>(request, options);
        }



        /// <summary>
        /// Gets a <i>subject</i>, which associates a certificate identity with authentication
        /// attempts. The subject stores auditing information such as the status of the last authentication
        /// attempt, the certificate data used in the attempt, and the last time the associated
        /// identity attempted authentication. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetSubject</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSubject service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSubject service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetSubject">REST API Reference for GetSubject Operation</seealso>
        public virtual Task<GetSubjectResponse> GetSubjectAsync(GetSubjectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSubjectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSubjectResponseUnmarshaller.Instance;

            return InvokeAsync<GetSubjectResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetTrustAnchor

        internal virtual GetTrustAnchorResponse GetTrustAnchor(GetTrustAnchorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrustAnchorResponseUnmarshaller.Instance;

            return Invoke<GetTrustAnchorResponse>(request, options);
        }



        /// <summary>
        /// Gets a trust anchor.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:GetTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/GetTrustAnchor">REST API Reference for GetTrustAnchor Operation</seealso>
        public virtual Task<GetTrustAnchorResponse> GetTrustAnchorAsync(GetTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTrustAnchorResponseUnmarshaller.Instance;

            return InvokeAsync<GetTrustAnchorResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ImportCrl

        internal virtual ImportCrlResponse ImportCrl(ImportCrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCrlResponseUnmarshaller.Instance;

            return Invoke<ImportCrlResponse>(request, options);
        }



        /// <summary>
        /// Imports the certificate revocation list (CRL). A CRL is a list of certificates that
        /// have been revoked by the issuing certificate Authority (CA).In order to be properly
        /// imported, a CRL must be in PEM format. IAM Roles Anywhere validates against the CRL
        /// before issuing credentials. 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ImportCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ImportCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ImportCrl">REST API Reference for ImportCrl Operation</seealso>
        public virtual Task<ImportCrlResponse> ImportCrlAsync(ImportCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ImportCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportCrlResponseUnmarshaller.Instance;

            return InvokeAsync<ImportCrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListCrls

        internal virtual ListCrlsResponse ListCrls(ListCrlsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCrlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCrlsResponseUnmarshaller.Instance;

            return Invoke<ListCrlsResponse>(request, options);
        }



        /// <summary>
        /// Lists all certificate revocation lists (CRL) in the authenticated account and Amazon
        /// Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListCrls</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCrls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCrls service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListCrls">REST API Reference for ListCrls Operation</seealso>
        public virtual Task<ListCrlsResponse> ListCrlsAsync(ListCrlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListCrlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCrlsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCrlsResponse>(request, options, cancellationToken);
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
        /// Lists all profiles in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListProfiles</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListProfiles service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListProfiles service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListProfiles">REST API Reference for ListProfiles Operation</seealso>
        public virtual Task<ListProfilesResponse> ListProfilesAsync(ListProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListProfilesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSubjects

        internal virtual ListSubjectsResponse ListSubjects(ListSubjectsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubjectsResponseUnmarshaller.Instance;

            return Invoke<ListSubjectsResponse>(request, options);
        }



        /// <summary>
        /// Lists the subjects in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListSubjects</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSubjects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSubjects service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListSubjects">REST API Reference for ListSubjects Operation</seealso>
        public virtual Task<ListSubjectsResponse> ListSubjectsAsync(ListSubjectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSubjectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSubjectsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSubjectsResponse>(request, options, cancellationToken);
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
        /// Lists the tags attached to the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListTagsForResource</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListTrustAnchors

        internal virtual ListTrustAnchorsResponse ListTrustAnchors(ListTrustAnchorsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrustAnchorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustAnchorsResponseUnmarshaller.Instance;

            return Invoke<ListTrustAnchorsResponse>(request, options);
        }



        /// <summary>
        /// Lists the trust anchors in the authenticated account and Amazon Web Services Region.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ListTrustAnchors</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTrustAnchors service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTrustAnchors service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ListTrustAnchors">REST API Reference for ListTrustAnchors Operation</seealso>
        public virtual Task<ListTrustAnchorsResponse> ListTrustAnchorsAsync(ListTrustAnchorsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTrustAnchorsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTrustAnchorsResponseUnmarshaller.Instance;

            return InvokeAsync<ListTrustAnchorsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutAttributeMapping

        internal virtual PutAttributeMappingResponse PutAttributeMapping(PutAttributeMappingRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAttributeMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAttributeMappingResponseUnmarshaller.Instance;

            return Invoke<PutAttributeMappingResponse>(request, options);
        }



        /// <summary>
        /// Put an entry in the attribute mapping rules that will be enforced by a given profile.
        /// A mapping specifies a certificate field and one or more specifiers that have contextual
        /// meanings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutAttributeMapping service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutAttributeMapping service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/PutAttributeMapping">REST API Reference for PutAttributeMapping Operation</seealso>
        public virtual Task<PutAttributeMappingResponse> PutAttributeMappingAsync(PutAttributeMappingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutAttributeMappingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutAttributeMappingResponseUnmarshaller.Instance;

            return InvokeAsync<PutAttributeMappingResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  PutNotificationSettings

        internal virtual PutNotificationSettingsResponse PutNotificationSettings(PutNotificationSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutNotificationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationSettingsResponseUnmarshaller.Instance;

            return Invoke<PutNotificationSettingsResponse>(request, options);
        }



        /// <summary>
        /// Attaches a list of <i>notification settings</i> to a trust anchor.
        /// 
        ///  
        /// <para>
        /// A notification setting includes information such as event name, threshold, status
        /// of the notification setting, and the channel to notify.
        /// </para>
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:PutNotificationSettings</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutNotificationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutNotificationSettings service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/PutNotificationSettings">REST API Reference for PutNotificationSettings Operation</seealso>
        public virtual Task<PutNotificationSettingsResponse> PutNotificationSettingsAsync(PutNotificationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = PutNotificationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutNotificationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<PutNotificationSettingsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ResetNotificationSettings

        internal virtual ResetNotificationSettingsResponse ResetNotificationSettings(ResetNotificationSettingsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetNotificationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetNotificationSettingsResponseUnmarshaller.Instance;

            return Invoke<ResetNotificationSettingsResponse>(request, options);
        }



        /// <summary>
        /// Resets the <i>custom notification setting</i> to IAM Roles Anywhere default setting.
        /// 
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:ResetNotificationSettings</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetNotificationSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ResetNotificationSettings service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/ResetNotificationSettings">REST API Reference for ResetNotificationSettings Operation</seealso>
        public virtual Task<ResetNotificationSettingsResponse> ResetNotificationSettingsAsync(ResetNotificationSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ResetNotificationSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetNotificationSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<ResetNotificationSettingsResponse>(request, options, cancellationToken);
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
        /// Attaches tags to a resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:TagResource</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.TooManyTagsException">
        /// Too many tags.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from the resource.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UntagResource</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateCrl

        internal virtual UpdateCrlResponse UpdateCrl(UpdateCrlRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCrlResponseUnmarshaller.Instance;

            return Invoke<UpdateCrlResponse>(request, options);
        }



        /// <summary>
        /// Updates the certificate revocation list (CRL). A CRL is a list of certificates that
        /// have been revoked by the issuing certificate authority (CA). IAM Roles Anywhere validates
        /// against the CRL before issuing credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateCrl</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCrl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCrl service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateCrl">REST API Reference for UpdateCrl Operation</seealso>
        public virtual Task<UpdateCrlResponse> UpdateCrlAsync(UpdateCrlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateCrlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCrlResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCrlResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateProfile

        internal virtual UpdateProfileResponse UpdateProfile(UpdateProfileRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return Invoke<UpdateProfileResponse>(request, options);
        }



        /// <summary>
        /// Updates a <i>profile</i>, a list of the roles that IAM Roles Anywhere service is trusted
        /// to assume. You use profiles to intersect permissions with IAM managed policies.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateProfile</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateProfile service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateProfile service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateProfile">REST API Reference for UpdateProfile Operation</seealso>
        public virtual Task<UpdateProfileResponse> UpdateProfileAsync(UpdateProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateProfileResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateProfileResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateTrustAnchor

        internal virtual UpdateTrustAnchorResponse UpdateTrustAnchor(UpdateTrustAnchorRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustAnchorResponseUnmarshaller.Instance;

            return Invoke<UpdateTrustAnchorResponse>(request, options);
        }



        /// <summary>
        /// Updates a trust anchor. You establish trust between IAM Roles Anywhere and your certificate
        /// authority (CA) by configuring a trust anchor. You can define a trust anchor as a reference
        /// to an Private Certificate Authority (Private CA) or by uploading a CA certificate.
        /// Your Amazon Web Services workloads can authenticate with the trust anchor using certificates
        /// issued by the CA in exchange for temporary Amazon Web Services credentials.
        /// 
        ///  
        /// <para>
        ///  <b>Required permissions: </b> <c>rolesanywhere:UpdateTrustAnchor</c>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTrustAnchor service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateTrustAnchor service method, as returned by IAMRolesAnywhere.</returns>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ResourceNotFoundException">
        /// The resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.IAMRolesAnywhere.Model.ValidationException">
        /// Validation exception error.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/rolesanywhere-2018-05-10/UpdateTrustAnchor">REST API Reference for UpdateTrustAnchor Operation</seealso>
        public virtual Task<UpdateTrustAnchorResponse> UpdateTrustAnchorAsync(UpdateTrustAnchorRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateTrustAnchorRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTrustAnchorResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTrustAnchorResponse>(request, options, cancellationToken);
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