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
 * Do not modify this file. This file is generated from the mpa-2022-07-26.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.MPA.Model;
using Amazon.MPA.Model.Internal.MarshallTransformations;
using Amazon.MPA.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Endpoints;

#pragma warning disable CS1570
namespace Amazon.MPA
{
    /// <summary>
    /// <para>Implementation for accessing MPA</para>
    ///
    /// Multi-party approval is a capability of <a href="http://aws.amazon.com/organizations">Organizations</a>
    /// that allows you to protect a predefined list of operations through a distributed approval
    /// process. Use Multi-party approval to establish approval workflows and transform security
    /// processes into team-based decisions.
    /// 
    ///  
    /// <para>
    ///  <b>When to use Multi-party approval</b>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You need to align with the Zero Trust principle of "never trust, always verify"
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You need to make sure that the right humans have access to the right things in the
    /// right way
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You need distributed decision-making for sensitive or critical operations
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You need to protect against unintended operations on sensitive or critical resources
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// You need formal reviews and approvals for auditing or compliance reasons
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/what-is.html">What
    /// is Multi-party approval</a> in the <i>Multi-party approval User Guide</i>.
    /// </para>
    /// </summary>
    public partial class AmazonMPAClient : AmazonServiceClient, IAmazonMPA
    {
        private static IServiceMetadata serviceMetadata = new AmazonMPAMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonMPAClient with the credentials loaded from the application's
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
        public AmazonMPAClient()
            : base(new AmazonMPAConfig()) { }

        /// <summary>
        /// Constructs AmazonMPAClient with the credentials loaded from the application's
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
        public AmazonMPAClient(RegionEndpoint region)
            : base(new AmazonMPAConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonMPAClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonMPAClient Configuration Object</param>
        public AmazonMPAClient(AmazonMPAConfig config)
            : base(config) { }


        /// <summary>
        /// Constructs AmazonMPAClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonMPAClient(AWSCredentials credentials)
            : this(credentials, new AmazonMPAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMPAClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMPAClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonMPAConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMPAClient with AWS Credentials and an
        /// AmazonMPAClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonMPAClient Configuration Object</param>
        public AmazonMPAClient(AWSCredentials credentials, AmazonMPAConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMPAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonMPAClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMPAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMPAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMPAClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonMPAConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonMPAClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMPAClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonMPAClient Configuration Object</param>
        public AmazonMPAClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonMPAConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonMPAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonMPAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMPAConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonMPAClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonMPAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonMPAConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonMPAClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonMPAClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonMPAClient Configuration Object</param>
        public AmazonMPAClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonMPAConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IMPAPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IMPAPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new MPAPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMPAEndpointResolver());
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMPAAuthSchemeHandler());
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


        #region  CancelSession

        internal virtual CancelSessionResponse CancelSession(CancelSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSessionResponseUnmarshaller.Instance;

            return Invoke<CancelSessionResponse>(request, options);
        }



        /// <summary>
        /// Cancels an approval session. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Session</a>
        /// in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CancelSession service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CancelSession">REST API Reference for CancelSession Operation</seealso>
        public virtual Task<CancelSessionResponse> CancelSessionAsync(CancelSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSessionResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateApprovalTeam

        internal virtual CreateApprovalTeamResponse CreateApprovalTeam(CreateApprovalTeamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApprovalTeamResponseUnmarshaller.Instance;

            return Invoke<CreateApprovalTeamResponse>(request, options);
        }



        /// <summary>
        /// Creates a new approval team. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Approval
        /// team</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApprovalTeam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateApprovalTeam service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota for your account. Request a quota increase or
        /// reduce your request size.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CreateApprovalTeam">REST API Reference for CreateApprovalTeam Operation</seealso>
        public virtual Task<CreateApprovalTeamResponse> CreateApprovalTeamAsync(CreateApprovalTeamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApprovalTeamResponseUnmarshaller.Instance;

            return InvokeAsync<CreateApprovalTeamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  CreateIdentitySource

        internal virtual CreateIdentitySourceResponse CreateIdentitySource(CreateIdentitySourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentitySourceResponseUnmarshaller.Instance;

            return Invoke<CreateIdentitySourceResponse>(request, options);
        }



        /// <summary>
        /// Creates a new identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentitySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateIdentitySource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota for your account. Request a quota increase or
        /// reduce your request size.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CreateIdentitySource">REST API Reference for CreateIdentitySource Operation</seealso>
        public virtual Task<CreateIdentitySourceResponse> CreateIdentitySourceAsync(CreateIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentitySourceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateIdentitySourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteIdentitySource

        internal virtual DeleteIdentitySourceResponse DeleteIdentitySource(DeleteIdentitySourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentitySourceResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentitySourceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentitySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteIdentitySource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/DeleteIdentitySource">REST API Reference for DeleteIdentitySource Operation</seealso>
        public virtual Task<DeleteIdentitySourceResponse> DeleteIdentitySourceAsync(DeleteIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentitySourceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteIdentitySourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  DeleteInactiveApprovalTeamVersion

        internal virtual DeleteInactiveApprovalTeamVersionResponse DeleteInactiveApprovalTeamVersion(DeleteInactiveApprovalTeamVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInactiveApprovalTeamVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInactiveApprovalTeamVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteInactiveApprovalTeamVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes an inactive approval team. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-health.html">Team
        /// health</a> in the <i>Multi-party approval User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can also use this operation to delete a team draft. For more information, see
        /// <a href="https://docs.aws.amazon.com/mpa/latest/userguide/update-team.html#update-team-draft-status">Interacting
        /// with drafts</a> in the <i>Multi-party approval User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInactiveApprovalTeamVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInactiveApprovalTeamVersion service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/DeleteInactiveApprovalTeamVersion">REST API Reference for DeleteInactiveApprovalTeamVersion Operation</seealso>
        public virtual Task<DeleteInactiveApprovalTeamVersionResponse> DeleteInactiveApprovalTeamVersionAsync(DeleteInactiveApprovalTeamVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInactiveApprovalTeamVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInactiveApprovalTeamVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInactiveApprovalTeamVersionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetApprovalTeam

        internal virtual GetApprovalTeamResponse GetApprovalTeam(GetApprovalTeamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApprovalTeamResponseUnmarshaller.Instance;

            return Invoke<GetApprovalTeamResponse>(request, options);
        }



        /// <summary>
        /// Returns details for an approval team.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApprovalTeam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetApprovalTeam service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetApprovalTeam">REST API Reference for GetApprovalTeam Operation</seealso>
        public virtual Task<GetApprovalTeamResponse> GetApprovalTeamAsync(GetApprovalTeamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApprovalTeamResponseUnmarshaller.Instance;

            return InvokeAsync<GetApprovalTeamResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetIdentitySource

        internal virtual GetIdentitySourceResponse GetIdentitySource(GetIdentitySourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentitySourceResponseUnmarshaller.Instance;

            return Invoke<GetIdentitySourceResponse>(request, options);
        }



        /// <summary>
        /// Returns details for an identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentitySource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetIdentitySource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetIdentitySource">REST API Reference for GetIdentitySource Operation</seealso>
        public virtual Task<GetIdentitySourceResponse> GetIdentitySourceAsync(GetIdentitySourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentitySourceResponseUnmarshaller.Instance;

            return InvokeAsync<GetIdentitySourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetPolicyVersion

        internal virtual GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<GetPolicyVersionResponse>(request, options);
        }



        /// <summary>
        /// Returns details for the version of a policy. Policies define the permissions for team
        /// resources.
        /// 
        ///  
        /// <para>
        /// The protected operation for a service integration might require specific permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-integrations.html">How
        /// other services work with Multi-party approval</a> in the <i>Multi-party approval User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetPolicyVersion service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        public virtual Task<GetPolicyVersionResponse> GetPolicyVersionAsync(GetPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetPolicyVersionResponse>(request, options, cancellationToken);
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
        /// Returns details about a policy for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InvalidParameterException">
        /// The request contains an invalid parameter value.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  GetSession

        internal virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return Invoke<GetSessionResponse>(request, options);
        }



        /// <summary>
        /// Returns details for an approval session. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Session</a>
        /// in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSession service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual Task<GetSessionResponse> GetSessionAsync(GetSessionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return InvokeAsync<GetSessionResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListApprovalTeams

        internal virtual ListApprovalTeamsResponse ListApprovalTeams(ListApprovalTeamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApprovalTeamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApprovalTeamsResponseUnmarshaller.Instance;

            return Invoke<ListApprovalTeamsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of approval teams.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApprovalTeams service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListApprovalTeams service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListApprovalTeams">REST API Reference for ListApprovalTeams Operation</seealso>
        public virtual Task<ListApprovalTeamsResponse> ListApprovalTeamsAsync(ListApprovalTeamsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApprovalTeamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApprovalTeamsResponseUnmarshaller.Instance;

            return InvokeAsync<ListApprovalTeamsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListIdentitySources

        internal virtual ListIdentitySourcesResponse ListIdentitySources(ListIdentitySourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentitySourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitySourcesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitySourcesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of identity sources. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentitySources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListIdentitySources service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListIdentitySources">REST API Reference for ListIdentitySources Operation</seealso>
        public virtual Task<ListIdentitySourcesResponse> ListIdentitySourcesAsync(ListIdentitySourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentitySourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitySourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListIdentitySourcesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPolicies

        internal virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of policies. Policies define the permissions for team resources.
        /// 
        ///  
        /// <para>
        /// The protected operation for a service integration might require specific permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-integrations.html">How
        /// other services work with Multi-party approval</a> in the <i>Multi-party approval User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicies service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual Task<ListPoliciesResponse> ListPoliciesAsync(ListPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListPoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListPolicyVersions

        internal virtual ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of the versions for policies. Policies define the permissions for team
        /// resources.
        /// 
        ///  
        /// <para>
        /// The protected operation for a service integration might require specific permissions.
        /// For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-integrations.html">How
        /// other services work with Multi-party approval</a> in the <i>Multi-party approval User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPolicyVersions service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        public virtual Task<ListPolicyVersionsResponse> ListPolicyVersionsAsync(ListPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPolicyVersionsResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListResourcePolicies

        internal virtual ListResourcePoliciesResponse ListResourcePolicies(ListResourcePoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListResourcePoliciesResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of policies for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListResourcePolicies service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListResourcePolicies">REST API Reference for ListResourcePolicies Operation</seealso>
        public virtual Task<ListResourcePoliciesResponse> ListResourcePoliciesAsync(ListResourcePoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<ListResourcePoliciesResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  ListSessions

        internal virtual ListSessionsResponse ListSessions(ListSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return Invoke<ListSessionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of approval sessions. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Session</a>
        /// in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSessions service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual Task<ListSessionsResponse> ListSessionsAsync(ListSessionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSessionsResponse>(request, options, cancellationToken);
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
        /// Returns a list of the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  StartActiveApprovalTeamDeletion

        internal virtual StartActiveApprovalTeamDeletionResponse StartActiveApprovalTeamDeletion(StartActiveApprovalTeamDeletionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartActiveApprovalTeamDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartActiveApprovalTeamDeletionResponseUnmarshaller.Instance;

            return Invoke<StartActiveApprovalTeamDeletionResponse>(request, options);
        }



        /// <summary>
        /// Starts the deletion process for an active approval team.
        /// 
        ///  <note> 
        /// <para>
        ///  <b>Deletions require team approval</b> 
        /// </para>
        ///  
        /// <para>
        /// Requests to delete an active team must be approved by the team.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartActiveApprovalTeamDeletion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartActiveApprovalTeamDeletion service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/StartActiveApprovalTeamDeletion">REST API Reference for StartActiveApprovalTeamDeletion Operation</seealso>
        public virtual Task<StartActiveApprovalTeamDeletionResponse> StartActiveApprovalTeamDeletionAsync(StartActiveApprovalTeamDeletionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartActiveApprovalTeamDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartActiveApprovalTeamDeletionResponseUnmarshaller.Instance;

            return InvokeAsync<StartActiveApprovalTeamDeletionResponse>(request, options, cancellationToken);
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
        /// Creates or updates a resource tag. Each tag is a label consisting of a user-defined
        /// key and value. Tags can help you manage, identify, organize, search for, and filter
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.TooManyTagsException">
        /// The request exceeds the maximum number of tags allowed for this resource. Remove some
        /// tags, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a resource tag. Each tag is a label consisting of a user-defined key and value.
        /// Tags can help you manage, identify, organize, search for, and filter resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }
        #endregion
        
        #region  UpdateApprovalTeam

        internal virtual UpdateApprovalTeamResponse UpdateApprovalTeam(UpdateApprovalTeamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApprovalTeamResponseUnmarshaller.Instance;

            return Invoke<UpdateApprovalTeamResponse>(request, options);
        }



        /// <summary>
        /// Updates an approval team. You can request to update the team description, approval
        /// threshold, and approvers in the team.
        /// 
        ///  <note> 
        /// <para>
        ///  <b>Updates require team approval</b> 
        /// </para>
        ///  
        /// <para>
        /// Updates to an active team must be approved by the team.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalTeam service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateApprovalTeam service method, as returned by MPA.</returns>
        /// <exception cref="Amazon.MPA.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action. Check your permissions,
        /// and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ConflictException">
        /// The request cannot be completed because it conflicts with the current state of a resource.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.InternalServerException">
        /// The service encountered an internal error. Try your request again. If the problem
        /// persists, contact Amazon Web Services Support.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ResourceNotFoundException">
        /// The specified resource doesn't exist. Check the resource ID, and try again.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ServiceQuotaExceededException">
        /// The request exceeds the service quota for your account. Request a quota increase or
        /// reduce your request size.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.MPA.Model.ValidationException">
        /// The input fails to satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/UpdateApprovalTeam">REST API Reference for UpdateApprovalTeam Operation</seealso>
        public virtual Task<UpdateApprovalTeamResponse> UpdateApprovalTeamAsync(UpdateApprovalTeamRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApprovalTeamResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateApprovalTeamResponse>(request, options, cancellationToken);
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