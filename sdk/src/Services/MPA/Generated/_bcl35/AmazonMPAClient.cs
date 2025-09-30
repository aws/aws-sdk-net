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
using System.Collections.Generic;
using System.Net;

using Amazon.MPA.Model;
using Amazon.MPA.Model.Internal.MarshallTransformations;
using Amazon.MPA.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMPAConfig()) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonMPAConfig{RegionEndpoint = region}) { }

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
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonMPAEndpointResolver());
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

        /// <summary>
        /// Cancels an approval session. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Session</a>
        /// in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSession service method.</param>
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
        public virtual CancelSessionResponse CancelSession(CancelSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSessionResponseUnmarshaller.Instance;

            return Invoke<CancelSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSession operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CancelSession">REST API Reference for CancelSession Operation</seealso>
        public virtual IAsyncResult BeginCancelSession(CancelSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CancelSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSession.</param>
        /// 
        /// <returns>Returns a  CancelSessionResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CancelSession">REST API Reference for CancelSession Operation</seealso>
        public virtual CancelSessionResponse EndCancelSession(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateApprovalTeam

        /// <summary>
        /// Creates a new approval team. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Approval
        /// team</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateApprovalTeam service method.</param>
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
        public virtual CreateApprovalTeamResponse CreateApprovalTeam(CreateApprovalTeamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApprovalTeamResponseUnmarshaller.Instance;

            return Invoke<CreateApprovalTeamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateApprovalTeam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateApprovalTeam operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateApprovalTeam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CreateApprovalTeam">REST API Reference for CreateApprovalTeam Operation</seealso>
        public virtual IAsyncResult BeginCreateApprovalTeam(CreateApprovalTeamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateApprovalTeamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateApprovalTeam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateApprovalTeam.</param>
        /// 
        /// <returns>Returns a  CreateApprovalTeamResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CreateApprovalTeam">REST API Reference for CreateApprovalTeam Operation</seealso>
        public virtual CreateApprovalTeamResponse EndCreateApprovalTeam(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateApprovalTeamResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateIdentitySource

        /// <summary>
        /// Creates a new identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentitySource service method.</param>
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
        public virtual CreateIdentitySourceResponse CreateIdentitySource(CreateIdentitySourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentitySourceResponseUnmarshaller.Instance;

            return Invoke<CreateIdentitySourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateIdentitySource operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateIdentitySource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CreateIdentitySource">REST API Reference for CreateIdentitySource Operation</seealso>
        public virtual IAsyncResult BeginCreateIdentitySource(CreateIdentitySourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = CreateIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateIdentitySourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateIdentitySource.</param>
        /// 
        /// <returns>Returns a  CreateIdentitySourceResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/CreateIdentitySource">REST API Reference for CreateIdentitySource Operation</seealso>
        public virtual CreateIdentitySourceResponse EndCreateIdentitySource(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateIdentitySourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteIdentitySource

        /// <summary>
        /// Deletes an identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentitySource service method.</param>
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
        public virtual DeleteIdentitySourceResponse DeleteIdentitySource(DeleteIdentitySourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentitySourceResponseUnmarshaller.Instance;

            return Invoke<DeleteIdentitySourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteIdentitySource operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteIdentitySource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/DeleteIdentitySource">REST API Reference for DeleteIdentitySource Operation</seealso>
        public virtual IAsyncResult BeginDeleteIdentitySource(DeleteIdentitySourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteIdentitySourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteIdentitySource.</param>
        /// 
        /// <returns>Returns a  DeleteIdentitySourceResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/DeleteIdentitySource">REST API Reference for DeleteIdentitySource Operation</seealso>
        public virtual DeleteIdentitySourceResponse EndDeleteIdentitySource(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteIdentitySourceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteInactiveApprovalTeamVersion

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
        public virtual DeleteInactiveApprovalTeamVersionResponse DeleteInactiveApprovalTeamVersion(DeleteInactiveApprovalTeamVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInactiveApprovalTeamVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInactiveApprovalTeamVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteInactiveApprovalTeamVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInactiveApprovalTeamVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInactiveApprovalTeamVersion operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInactiveApprovalTeamVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/DeleteInactiveApprovalTeamVersion">REST API Reference for DeleteInactiveApprovalTeamVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteInactiveApprovalTeamVersion(DeleteInactiveApprovalTeamVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = DeleteInactiveApprovalTeamVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInactiveApprovalTeamVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInactiveApprovalTeamVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInactiveApprovalTeamVersion.</param>
        /// 
        /// <returns>Returns a  DeleteInactiveApprovalTeamVersionResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/DeleteInactiveApprovalTeamVersion">REST API Reference for DeleteInactiveApprovalTeamVersion Operation</seealso>
        public virtual DeleteInactiveApprovalTeamVersionResponse EndDeleteInactiveApprovalTeamVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteInactiveApprovalTeamVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetApprovalTeam

        /// <summary>
        /// Returns details for an approval team.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetApprovalTeam service method.</param>
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
        public virtual GetApprovalTeamResponse GetApprovalTeam(GetApprovalTeamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApprovalTeamResponseUnmarshaller.Instance;

            return Invoke<GetApprovalTeamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetApprovalTeam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetApprovalTeam operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetApprovalTeam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetApprovalTeam">REST API Reference for GetApprovalTeam Operation</seealso>
        public virtual IAsyncResult BeginGetApprovalTeam(GetApprovalTeamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetApprovalTeamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetApprovalTeam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetApprovalTeam.</param>
        /// 
        /// <returns>Returns a  GetApprovalTeamResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetApprovalTeam">REST API Reference for GetApprovalTeam Operation</seealso>
        public virtual GetApprovalTeamResponse EndGetApprovalTeam(IAsyncResult asyncResult)
        {
            return EndInvoke<GetApprovalTeamResponse>(asyncResult);
        }

        #endregion
        
        #region  GetIdentitySource

        /// <summary>
        /// Returns details for an identity source. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetIdentitySource service method.</param>
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
        public virtual GetIdentitySourceResponse GetIdentitySource(GetIdentitySourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentitySourceResponseUnmarshaller.Instance;

            return Invoke<GetIdentitySourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetIdentitySource operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetIdentitySource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetIdentitySource">REST API Reference for GetIdentitySource Operation</seealso>
        public virtual IAsyncResult BeginGetIdentitySource(GetIdentitySourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetIdentitySourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetIdentitySourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetIdentitySource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetIdentitySource.</param>
        /// 
        /// <returns>Returns a  GetIdentitySourceResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetIdentitySource">REST API Reference for GetIdentitySource Operation</seealso>
        public virtual GetIdentitySourceResponse EndGetIdentitySource(IAsyncResult asyncResult)
        {
            return EndInvoke<GetIdentitySourceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetPolicyVersion

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
        public virtual GetPolicyVersionResponse GetPolicyVersion(GetPolicyVersionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<GetPolicyVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPolicyVersion operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        public virtual IAsyncResult BeginGetPolicyVersion(GetPolicyVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPolicyVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPolicyVersion.</param>
        /// 
        /// <returns>Returns a  GetPolicyVersionResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetPolicyVersion">REST API Reference for GetPolicyVersion Operation</seealso>
        public virtual GetPolicyVersionResponse EndGetPolicyVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetPolicyVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePolicy

        /// <summary>
        /// Returns details about a policy for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
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
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSession

        /// <summary>
        /// Returns details for an approval session. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Session</a>
        /// in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSession service method.</param>
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
        public virtual GetSessionResponse GetSession(GetSessionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return Invoke<GetSessionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSession operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSession operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSession
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual IAsyncResult BeginGetSession(GetSessionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = GetSessionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSessionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSession operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSession.</param>
        /// 
        /// <returns>Returns a  GetSessionResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/GetSession">REST API Reference for GetSession Operation</seealso>
        public virtual GetSessionResponse EndGetSession(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSessionResponse>(asyncResult);
        }

        #endregion
        
        #region  ListApprovalTeams

        /// <summary>
        /// Returns a list of approval teams.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListApprovalTeams service method.</param>
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
        public virtual ListApprovalTeamsResponse ListApprovalTeams(ListApprovalTeamsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApprovalTeamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApprovalTeamsResponseUnmarshaller.Instance;

            return Invoke<ListApprovalTeamsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListApprovalTeams operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListApprovalTeams operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListApprovalTeams
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListApprovalTeams">REST API Reference for ListApprovalTeams Operation</seealso>
        public virtual IAsyncResult BeginListApprovalTeams(ListApprovalTeamsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListApprovalTeamsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListApprovalTeamsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListApprovalTeams operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListApprovalTeams.</param>
        /// 
        /// <returns>Returns a  ListApprovalTeamsResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListApprovalTeams">REST API Reference for ListApprovalTeams Operation</seealso>
        public virtual ListApprovalTeamsResponse EndListApprovalTeams(IAsyncResult asyncResult)
        {
            return EndInvoke<ListApprovalTeamsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListIdentitySources

        /// <summary>
        /// Returns a list of identity sources. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Identity
        /// Source</a> in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListIdentitySources service method.</param>
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
        public virtual ListIdentitySourcesResponse ListIdentitySources(ListIdentitySourcesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentitySourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitySourcesResponseUnmarshaller.Instance;

            return Invoke<ListIdentitySourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListIdentitySources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListIdentitySources operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListIdentitySources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListIdentitySources">REST API Reference for ListIdentitySources Operation</seealso>
        public virtual IAsyncResult BeginListIdentitySources(ListIdentitySourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListIdentitySourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListIdentitySourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListIdentitySources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListIdentitySources.</param>
        /// 
        /// <returns>Returns a  ListIdentitySourcesResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListIdentitySources">REST API Reference for ListIdentitySources Operation</seealso>
        public virtual ListIdentitySourcesResponse EndListIdentitySources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListIdentitySourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPolicies

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
        public virtual ListPoliciesResponse ListPolicies(ListPoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return Invoke<ListPoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicies operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual IAsyncResult BeginListPolicies(ListPoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicies.</param>
        /// 
        /// <returns>Returns a  ListPoliciesResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListPolicies">REST API Reference for ListPolicies Operation</seealso>
        public virtual ListPoliciesResponse EndListPolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPolicyVersions

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
        public virtual ListPolicyVersionsResponse ListPolicyVersions(ListPolicyVersionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListPolicyVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPolicyVersions operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPolicyVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        public virtual IAsyncResult BeginListPolicyVersions(ListPolicyVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPolicyVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPolicyVersions.</param>
        /// 
        /// <returns>Returns a  ListPolicyVersionsResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListPolicyVersions">REST API Reference for ListPolicyVersions Operation</seealso>
        public virtual ListPolicyVersionsResponse EndListPolicyVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPolicyVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListResourcePolicies

        /// <summary>
        /// Returns a list of policies for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePolicies service method.</param>
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
        public virtual ListResourcePoliciesResponse ListResourcePolicies(ListResourcePoliciesRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePoliciesResponseUnmarshaller.Instance;

            return Invoke<ListResourcePoliciesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListResourcePolicies operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListResourcePolicies
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListResourcePolicies">REST API Reference for ListResourcePolicies Operation</seealso>
        public virtual IAsyncResult BeginListResourcePolicies(ListResourcePoliciesRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListResourcePoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListResourcePoliciesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListResourcePolicies operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListResourcePolicies.</param>
        /// 
        /// <returns>Returns a  ListResourcePoliciesResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListResourcePolicies">REST API Reference for ListResourcePolicies Operation</seealso>
        public virtual ListResourcePoliciesResponse EndListResourcePolicies(IAsyncResult asyncResult)
        {
            return EndInvoke<ListResourcePoliciesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSessions

        /// <summary>
        /// Returns a list of approval sessions. For more information, see <a href="https://docs.aws.amazon.com/mpa/latest/userguide/mpa-concepts.html">Session</a>
        /// in the <i>Multi-party approval User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSessions service method.</param>
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
        public virtual ListSessionsResponse ListSessions(ListSessionsRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return Invoke<ListSessionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSessions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSessions operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSessions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual IAsyncResult BeginListSessions(ListSessionsRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListSessionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSessionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSessions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSessions.</param>
        /// 
        /// <returns>Returns a  ListSessionsResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListSessions">REST API Reference for ListSessions Operation</seealso>
        public virtual ListSessionsResponse EndListSessions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSessionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Returns a list of the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  StartActiveApprovalTeamDeletion

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
        public virtual StartActiveApprovalTeamDeletionResponse StartActiveApprovalTeamDeletion(StartActiveApprovalTeamDeletionRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartActiveApprovalTeamDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartActiveApprovalTeamDeletionResponseUnmarshaller.Instance;

            return Invoke<StartActiveApprovalTeamDeletionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartActiveApprovalTeamDeletion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartActiveApprovalTeamDeletion operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartActiveApprovalTeamDeletion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/StartActiveApprovalTeamDeletion">REST API Reference for StartActiveApprovalTeamDeletion Operation</seealso>
        public virtual IAsyncResult BeginStartActiveApprovalTeamDeletion(StartActiveApprovalTeamDeletionRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = StartActiveApprovalTeamDeletionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartActiveApprovalTeamDeletionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartActiveApprovalTeamDeletion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartActiveApprovalTeamDeletion.</param>
        /// 
        /// <returns>Returns a  StartActiveApprovalTeamDeletionResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/StartActiveApprovalTeamDeletion">REST API Reference for StartActiveApprovalTeamDeletion Operation</seealso>
        public virtual StartActiveApprovalTeamDeletionResponse EndStartActiveApprovalTeamDeletion(IAsyncResult asyncResult)
        {
            return EndInvoke<StartActiveApprovalTeamDeletionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Creates or updates a resource tag. Each tag is a label consisting of a user-defined
        /// key and value. Tags can help you manage, identify, organize, search for, and filter
        /// resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a resource tag. Each tag is a label consisting of a user-defined key and value.
        /// Tags can help you manage, identify, organize, search for, and filter resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateApprovalTeam

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
        public virtual UpdateApprovalTeamResponse UpdateApprovalTeam(UpdateApprovalTeamRequest request)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApprovalTeamResponseUnmarshaller.Instance;

            return Invoke<UpdateApprovalTeamResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateApprovalTeam operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateApprovalTeam operation on AmazonMPAClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateApprovalTeam
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/UpdateApprovalTeam">REST API Reference for UpdateApprovalTeam Operation</seealso>
        public virtual IAsyncResult BeginUpdateApprovalTeam(UpdateApprovalTeamRequest request, AsyncCallback callback, object state)
        {
            var options = new Amazon.Runtime.Internal.InvokeOptions();
            options.RequestMarshaller = UpdateApprovalTeamRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateApprovalTeamResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateApprovalTeam operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateApprovalTeam.</param>
        /// 
        /// <returns>Returns a  UpdateApprovalTeamResult from MPA.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/mpa-2022-07-26/UpdateApprovalTeam">REST API Reference for UpdateApprovalTeam Operation</seealso>
        public virtual UpdateApprovalTeamResponse EndUpdateApprovalTeam(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateApprovalTeamResponse>(asyncResult);
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
            var requestContext = new Amazon.Runtime.Internal.RequestContext(false, CreateSigner())
            {
                ClientConfig = Config,
                OriginalRequest = request,
                Request = new Amazon.Runtime.Internal.DefaultRequest(request, ServiceMetadata.ServiceId)
            };

            var executionContext = new Amazon.Runtime.Internal.ExecutionContext(requestContext, null);
            var resolver = new AmazonMPAEndpointResolver();
            return resolver.GetEndpoint(executionContext);
        }

        #endregion

    }
}