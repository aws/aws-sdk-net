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
 * Do not modify this file. This file is generated from the proton-2020-07-20.normal.json service model.
 */


using System;
using System.Collections.Generic;
using System.Net;

using Amazon.Proton.Model;
using Amazon.Proton.Model.Internal.MarshallTransformations;
using Amazon.Proton.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Proton
{
    /// <summary>
    /// Implementation for accessing Proton
    ///
    /// This is the Proton Service API Reference. It provides descriptions, syntax and usage
    /// examples for each of the <a href="https://docs.aws.amazon.com/proton/latest/APIReference/API_Operations.html">actions</a>
    /// and <a href="https://docs.aws.amazon.com/proton/latest/APIReference/API_Types.html">data
    /// types</a> for the Proton service.
    /// 
    ///  
    /// <para>
    /// The documentation for each action shows the Query API request parameters and the XML
    /// response.
    /// </para>
    ///  
    /// <para>
    /// Alternatively, you can use the Amazon Web Services CLI to access an API. For more
    /// information, see the <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-chap-welcome.html">Amazon
    /// Web Services Command Line Interface User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// The Proton service is a two-pronged automation framework. Administrators create service
    /// templates to provide standardized infrastructure and deployment tooling for serverless
    /// and container based applications. Developers, in turn, select from the available service
    /// templates to automate their application or service deployments.
    /// </para>
    ///  
    /// <para>
    /// Because administrators define the infrastructure and tooling that Proton deploys and
    /// manages, they need permissions to use all of the listed API operations.
    /// </para>
    ///  
    /// <para>
    /// When developers select a specific infrastructure and tooling set, Proton deploys their
    /// applications. To monitor their applications that are running on Proton, developers
    /// need permissions to the service <i>create</i>, <i>list</i>, <i>update</i> and <i>delete</i>
    /// API operations and the service instance <i>list</i> and <i>update</i> API operations.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Proton, see the <a href="https://docs.aws.amazon.com/proton/latest/userguide/Welcome.html">Proton
    /// User Guide</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Ensuring Idempotency</b> 
    /// </para>
    ///  
    /// <para>
    /// When you make a mutating API request, the request typically returns a result before
    /// the asynchronous workflows of the operation are complete. Operations might also time
    /// out or encounter other server issues before they're complete, even if the request
    /// already returned a result. This might make it difficult to determine whether the request
    /// succeeded. Moreover, you might need to retry the request multiple times to ensure
    /// that the operation completes successfully. However, if the original request and the
    /// subsequent retries are successful, the operation occurs multiple times. This means
    /// that you might create more resources than you intended.
    /// </para>
    ///  
    /// <para>
    ///  <i>Idempotency</i> ensures that an API request action completes no more than one
    /// time. With an idempotent request, if the original request action completes successfully,
    /// any subsequent retries complete successfully without performing any further actions.
    /// However, the result might contain updated information, such as the current creation
    /// status.
    /// </para>
    ///  
    /// <para>
    /// The following lists of APIs are grouped according to methods that ensure idempotency.
    /// </para>
    ///  
    /// <para>
    ///  <b>Idempotent create APIs with a client token</b> 
    /// </para>
    ///  
    /// <para>
    /// The API actions in this list support idempotency with the use of a <i>client token</i>.
    /// The corresponding Amazon Web Services CLI commands also support idempotency using
    /// a client token. A client token is a unique, case-sensitive string of up to 64 ASCII
    /// characters. To make an idempotent API request using one of these actions, specify
    /// a client token in the request. We recommend that you <i>don't</i> reuse the same client
    /// token for other API requests. If you don’t provide a client token for these APIs,
    /// a default client token is automatically provided by SDKs.
    /// </para>
    ///  
    /// <para>
    /// Given a request action that has succeeded:
    /// </para>
    ///  
    /// <para>
    /// If you retry the request using the same client token and the same parameters, the
    /// retry succeeds without performing any further actions other than returning the original
    /// resource detail data in the response.
    /// </para>
    ///  
    /// <para>
    /// If you retry the request using the same client token, but one or more of the parameters
    /// are different, the retry throws a <code>ValidationException</code> with an <code>IdempotentParameterMismatch</code>
    /// error.
    /// </para>
    ///  
    /// <para>
    /// Client tokens expire eight hours after a request is made. If you retry the request
    /// with the expired token, a new resource is created.
    /// </para>
    ///  
    /// <para>
    /// If the original resource is deleted and you retry the request, a new resource is created.
    /// </para>
    ///  
    /// <para>
    /// Idempotent create APIs with a client token:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CreateEnvironmentTemplateVersion
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CreateServiceTemplateVersion
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CreateEnvironmentAccountConnection
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Idempotent create APIs</b> 
    /// </para>
    ///  
    /// <para>
    /// Given a request action that has succeeded:
    /// </para>
    ///  
    /// <para>
    /// If you retry the request with an API from this group, and the original resource <i>hasn't</i>
    /// been modified, the retry succeeds without performing any further actions other than
    /// returning the original resource detail data in the response.
    /// </para>
    ///  
    /// <para>
    /// If the original resource has been modified, the retry throws a <code>ConflictException</code>.
    /// </para>
    ///  
    /// <para>
    /// If you retry with different input parameters, the retry throws a <code>ValidationException</code>
    /// with an <code>IdempotentParameterMismatch</code> error.
    /// </para>
    ///  
    /// <para>
    /// Idempotent create APIs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// CreateEnvironmentTemplate
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CreateServiceTemplate
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CreateEnvironment
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// CreateService
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Idempotent delete APIs</b> 
    /// </para>
    ///  
    /// <para>
    /// Given a request action that has succeeded:
    /// </para>
    ///  
    /// <para>
    /// When you retry the request with an API from this group and the resource was deleted,
    /// its metadata is returned in the response.
    /// </para>
    ///  
    /// <para>
    /// If you retry and the resource doesn't exist, the response is empty.
    /// </para>
    ///  
    /// <para>
    /// In both cases, the retry succeeds.
    /// </para>
    ///  
    /// <para>
    /// Idempotent delete APIs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// DeleteEnvironmentTemplate
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DeleteEnvironmentTemplateVersion
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DeleteServiceTemplate
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DeleteServiceTemplateVersion
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DeleteEnvironmentAccountConnection
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>Asynchronous idempotent delete APIs</b> 
    /// </para>
    ///  
    /// <para>
    /// Given a request action that has succeeded:
    /// </para>
    ///  
    /// <para>
    /// If you retry the request with an API from this group, if the original request delete
    /// operation status is <code>DELETE_IN_PROGRESS</code>, the retry returns the resource
    /// detail data in the response without performing any further actions.
    /// </para>
    ///  
    /// <para>
    /// If the original request delete operation is complete, a retry returns an empty response.
    /// </para>
    ///  
    /// <para>
    /// Asynchronous idempotent delete APIs:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// DeleteEnvironment
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// DeleteService
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonProtonClient : AmazonServiceClient, IAmazonProton
    {
        private static IServiceMetadata serviceMetadata = new AmazonProtonMetadata();

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        private IProtonPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IProtonPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ProtonPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif
        #region Constructors

        /// <summary>
        /// Constructs AmazonProtonClient with the credentials loaded from the application's
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
        public AmazonProtonClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonProtonConfig()) { }

        /// <summary>
        /// Constructs AmazonProtonClient with the credentials loaded from the application's
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
        public AmazonProtonClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonProtonConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonProtonClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonProtonClient Configuration Object</param>
        public AmazonProtonClient(AmazonProtonConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonProtonClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonProtonClient(AWSCredentials credentials)
            : this(credentials, new AmazonProtonConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonProtonClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonProtonClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonProtonConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonProtonClient with AWS Credentials and an
        /// AmazonProtonClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonProtonClient Configuration Object</param>
        public AmazonProtonClient(AWSCredentials credentials, AmazonProtonConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonProtonClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonProtonClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonProtonConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonProtonClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonProtonClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonProtonConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonProtonClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonProtonClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonProtonClient Configuration Object</param>
        public AmazonProtonClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonProtonConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonProtonClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonProtonClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonProtonConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonProtonClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonProtonClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonProtonConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonProtonClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonProtonClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonProtonClient Configuration Object</param>
        public AmazonProtonClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonProtonConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonProtonEndpointResolver());
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


        #region  AcceptEnvironmentAccountConnection

        /// <summary>
        /// In a management account, an environment account connection request is accepted. When
        /// the environment account connection request is accepted, Proton can use the associated
        /// IAM role to provision environment infrastructure resources in the associated environment
        /// account.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
        /// account connections</a> in the <i>Proton User guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptEnvironmentAccountConnection service method.</param>
        /// 
        /// <returns>The response from the AcceptEnvironmentAccountConnection service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/AcceptEnvironmentAccountConnection">REST API Reference for AcceptEnvironmentAccountConnection Operation</seealso>
        public virtual AcceptEnvironmentAccountConnectionResponse AcceptEnvironmentAccountConnection(AcceptEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<AcceptEnvironmentAccountConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptEnvironmentAccountConnection operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptEnvironmentAccountConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/AcceptEnvironmentAccountConnection">REST API Reference for AcceptEnvironmentAccountConnection Operation</seealso>
        public virtual IAsyncResult BeginAcceptEnvironmentAccountConnection(AcceptEnvironmentAccountConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptEnvironmentAccountConnection.</param>
        /// 
        /// <returns>Returns a  AcceptEnvironmentAccountConnectionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/AcceptEnvironmentAccountConnection">REST API Reference for AcceptEnvironmentAccountConnection Operation</seealso>
        public virtual AcceptEnvironmentAccountConnectionResponse EndAcceptEnvironmentAccountConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptEnvironmentAccountConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelComponentDeployment

        /// <summary>
        /// Attempts to cancel a component deployment (for a component that is in the <code>IN_PROGRESS</code>
        /// deployment status).
        /// 
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelComponentDeployment service method.</param>
        /// 
        /// <returns>The response from the CancelComponentDeployment service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelComponentDeployment">REST API Reference for CancelComponentDeployment Operation</seealso>
        public virtual CancelComponentDeploymentResponse CancelComponentDeployment(CancelComponentDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelComponentDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelComponentDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelComponentDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelComponentDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelComponentDeployment operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelComponentDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelComponentDeployment">REST API Reference for CancelComponentDeployment Operation</seealso>
        public virtual IAsyncResult BeginCancelComponentDeployment(CancelComponentDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelComponentDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelComponentDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelComponentDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelComponentDeployment.</param>
        /// 
        /// <returns>Returns a  CancelComponentDeploymentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelComponentDeployment">REST API Reference for CancelComponentDeployment Operation</seealso>
        public virtual CancelComponentDeploymentResponse EndCancelComponentDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelComponentDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelEnvironmentDeployment

        /// <summary>
        /// Attempts to cancel an environment deployment on an <a>UpdateEnvironment</a> action,
        /// if the deployment is <code>IN_PROGRESS</code>. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-update.html">Update
        /// an environment</a> in the <i>Proton User guide</i>.
        /// 
        ///  
        /// <para>
        /// The following list includes potential cancellation scenarios.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the cancellation attempt succeeds, the resulting deployment state is <code>CANCELLED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the cancellation attempt fails, the resulting deployment state is <code>FAILED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the current <a>UpdateEnvironment</a> action succeeds before the cancellation attempt
        /// starts, the resulting deployment state is <code>SUCCEEDED</code> and the cancellation
        /// attempt has no effect.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelEnvironmentDeployment service method.</param>
        /// 
        /// <returns>The response from the CancelEnvironmentDeployment service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelEnvironmentDeployment">REST API Reference for CancelEnvironmentDeployment Operation</seealso>
        public virtual CancelEnvironmentDeploymentResponse CancelEnvironmentDeployment(CancelEnvironmentDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelEnvironmentDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelEnvironmentDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelEnvironmentDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelEnvironmentDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelEnvironmentDeployment operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelEnvironmentDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelEnvironmentDeployment">REST API Reference for CancelEnvironmentDeployment Operation</seealso>
        public virtual IAsyncResult BeginCancelEnvironmentDeployment(CancelEnvironmentDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelEnvironmentDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelEnvironmentDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelEnvironmentDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelEnvironmentDeployment.</param>
        /// 
        /// <returns>Returns a  CancelEnvironmentDeploymentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelEnvironmentDeployment">REST API Reference for CancelEnvironmentDeployment Operation</seealso>
        public virtual CancelEnvironmentDeploymentResponse EndCancelEnvironmentDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelEnvironmentDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelServiceInstanceDeployment

        /// <summary>
        /// Attempts to cancel a service instance deployment on an <a>UpdateServiceInstance</a>
        /// action, if the deployment is <code>IN_PROGRESS</code>. For more information, see <a
        /// href="https://docs.aws.amazon.com/proton/latest/userguide/ag-svc-instance-update.html">Update
        /// a service instance</a> in the <i>Proton User guide</i>.
        /// 
        ///  
        /// <para>
        /// The following list includes potential cancellation scenarios.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the cancellation attempt succeeds, the resulting deployment state is <code>CANCELLED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the cancellation attempt fails, the resulting deployment state is <code>FAILED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the current <a>UpdateServiceInstance</a> action succeeds before the cancellation
        /// attempt starts, the resulting deployment state is <code>SUCCEEDED</code> and the cancellation
        /// attempt has no effect.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelServiceInstanceDeployment service method.</param>
        /// 
        /// <returns>The response from the CancelServiceInstanceDeployment service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelServiceInstanceDeployment">REST API Reference for CancelServiceInstanceDeployment Operation</seealso>
        public virtual CancelServiceInstanceDeploymentResponse CancelServiceInstanceDeployment(CancelServiceInstanceDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelServiceInstanceDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelServiceInstanceDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelServiceInstanceDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelServiceInstanceDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelServiceInstanceDeployment operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelServiceInstanceDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelServiceInstanceDeployment">REST API Reference for CancelServiceInstanceDeployment Operation</seealso>
        public virtual IAsyncResult BeginCancelServiceInstanceDeployment(CancelServiceInstanceDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelServiceInstanceDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelServiceInstanceDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelServiceInstanceDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelServiceInstanceDeployment.</param>
        /// 
        /// <returns>Returns a  CancelServiceInstanceDeploymentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelServiceInstanceDeployment">REST API Reference for CancelServiceInstanceDeployment Operation</seealso>
        public virtual CancelServiceInstanceDeploymentResponse EndCancelServiceInstanceDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelServiceInstanceDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CancelServicePipelineDeployment

        /// <summary>
        /// Attempts to cancel a service pipeline deployment on an <a>UpdateServicePipeline</a>
        /// action, if the deployment is <code>IN_PROGRESS</code>. For more information, see <a
        /// href="https://docs.aws.amazon.com/proton/latest/userguide/ag-svc-pipeline-update.html">Update
        /// a service pipeline</a> in the <i>Proton User guide</i>.
        /// 
        ///  
        /// <para>
        /// The following list includes potential cancellation scenarios.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the cancellation attempt succeeds, the resulting deployment state is <code>CANCELLED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the cancellation attempt fails, the resulting deployment state is <code>FAILED</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the current <a>UpdateServicePipeline</a> action succeeds before the cancellation
        /// attempt starts, the resulting deployment state is <code>SUCCEEDED</code> and the cancellation
        /// attempt has no effect.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelServicePipelineDeployment service method.</param>
        /// 
        /// <returns>The response from the CancelServicePipelineDeployment service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelServicePipelineDeployment">REST API Reference for CancelServicePipelineDeployment Operation</seealso>
        public virtual CancelServicePipelineDeploymentResponse CancelServicePipelineDeployment(CancelServicePipelineDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelServicePipelineDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelServicePipelineDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelServicePipelineDeploymentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelServicePipelineDeployment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelServicePipelineDeployment operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelServicePipelineDeployment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelServicePipelineDeployment">REST API Reference for CancelServicePipelineDeployment Operation</seealso>
        public virtual IAsyncResult BeginCancelServicePipelineDeployment(CancelServicePipelineDeploymentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelServicePipelineDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelServicePipelineDeploymentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CancelServicePipelineDeployment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelServicePipelineDeployment.</param>
        /// 
        /// <returns>Returns a  CancelServicePipelineDeploymentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CancelServicePipelineDeployment">REST API Reference for CancelServicePipelineDeployment Operation</seealso>
        public virtual CancelServicePipelineDeploymentResponse EndCancelServicePipelineDeployment(IAsyncResult asyncResult)
        {
            return EndInvoke<CancelServicePipelineDeploymentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateComponent

        /// <summary>
        /// Create an Proton component. A component is an infrastructure extension for a service
        /// instance.
        /// 
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent service method.</param>
        /// 
        /// <returns>The response from the CreateComponent service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual CreateComponentResponse CreateComponent(CreateComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return Invoke<CreateComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateComponent operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual IAsyncResult BeginCreateComponent(CreateComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateComponent.</param>
        /// 
        /// <returns>Returns a  CreateComponentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateComponent">REST API Reference for CreateComponent Operation</seealso>
        public virtual CreateComponentResponse EndCreateComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEnvironment

        /// <summary>
        /// Deploy a new environment. An Proton environment is created from an environment template
        /// that defines infrastructure and resources that can be shared across services.
        /// 
        ///  <p class="title"> <b>You can provision environments using the following methods:</b>
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Amazon Web Services-managed provisioning: Proton makes direct calls to provision your
        /// resources.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Self-managed provisioning: Proton makes pull requests on your repository to provide
        /// compiled infrastructure as code (IaC) files that your IaC engine uses to provision
        /// resources.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-environments.html">Environments</a>
        /// and <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-works-prov-methods.html">Provisioning
        /// methods</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironment service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironment operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironment(CreateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironment.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironment">REST API Reference for CreateEnvironment Operation</seealso>
        public virtual CreateEnvironmentResponse EndCreateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEnvironmentAccountConnection

        /// <summary>
        /// Create an environment account connection in an environment account so that environment
        /// infrastructure resources can be provisioned in the environment account from a management
        /// account.
        /// 
        ///  
        /// <para>
        /// An environment account connection is a secure bi-directional connection between a
        /// <i>management account</i> and an <i>environment account</i> that maintains authorization
        /// and permissions. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
        /// account connections</a> in the <i>Proton User guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentAccountConnection service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentAccountConnection service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironmentAccountConnection">REST API Reference for CreateEnvironmentAccountConnection Operation</seealso>
        public virtual CreateEnvironmentAccountConnectionResponse CreateEnvironmentAccountConnection(CreateEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentAccountConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentAccountConnection operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironmentAccountConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironmentAccountConnection">REST API Reference for CreateEnvironmentAccountConnection Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironmentAccountConnection(CreateEnvironmentAccountConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironmentAccountConnection.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentAccountConnectionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironmentAccountConnection">REST API Reference for CreateEnvironmentAccountConnection Operation</seealso>
        public virtual CreateEnvironmentAccountConnectionResponse EndCreateEnvironmentAccountConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentAccountConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEnvironmentTemplate

        /// <summary>
        /// Create an environment template for Proton. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-templates.html">Environment
        /// Templates</a> in the <i>Proton User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can create an environment template in one of the two following ways:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Register and publish a <i>standard</i> environment template that instructs Proton
        /// to deploy and manage environment infrastructure.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Register and publish a <i>customer managed</i> environment template that connects
        /// Proton to your existing provisioned infrastructure that you manage. Proton <i>doesn't</i>
        /// manage your existing provisioned infrastructure. To create an environment template
        /// for customer provisioned and managed infrastructure, include the <code>provisioning</code>
        /// parameter and set the value to <code>CUSTOMER_MANAGED</code>. For more information,
        /// see <a href="https://docs.aws.amazon.com/proton/latest/userguide/template-create.html">Register
        /// and publish an environment template</a> in the <i>Proton User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentTemplate service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironmentTemplate">REST API Reference for CreateEnvironmentTemplate Operation</seealso>
        public virtual CreateEnvironmentTemplateResponse CreateEnvironmentTemplate(CreateEnvironmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentTemplate operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironmentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironmentTemplate">REST API Reference for CreateEnvironmentTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironmentTemplate(CreateEnvironmentTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironmentTemplate.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentTemplateResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironmentTemplate">REST API Reference for CreateEnvironmentTemplate Operation</seealso>
        public virtual CreateEnvironmentTemplateResponse EndCreateEnvironmentTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateEnvironmentTemplateVersion

        /// <summary>
        /// Create a new major or minor version of an environment template. A major version of
        /// an environment template is a version that <i>isn't</i> backwards compatible. A minor
        /// version of an environment template is a version that's backwards compatible within
        /// its major version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the CreateEnvironmentTemplateVersion service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironmentTemplateVersion">REST API Reference for CreateEnvironmentTemplateVersion Operation</seealso>
        public virtual CreateEnvironmentTemplateVersionResponse CreateEnvironmentTemplateVersion(CreateEnvironmentTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentTemplateVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEnvironmentTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentTemplateVersion operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEnvironmentTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironmentTemplateVersion">REST API Reference for CreateEnvironmentTemplateVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateEnvironmentTemplateVersion(CreateEnvironmentTemplateVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEnvironmentTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEnvironmentTemplateVersion.</param>
        /// 
        /// <returns>Returns a  CreateEnvironmentTemplateVersionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateEnvironmentTemplateVersion">REST API Reference for CreateEnvironmentTemplateVersion Operation</seealso>
        public virtual CreateEnvironmentTemplateVersionResponse EndCreateEnvironmentTemplateVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateEnvironmentTemplateVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRepository

        /// <summary>
        /// Create and register a link to a repository. Proton uses the link to repeatedly access
        /// the repository, to either push to it (self-managed provisioning) or pull from it (template
        /// sync). You can share a linked repository across multiple resources (like environments
        /// using self-managed provisioning, or synced templates). When you create a repository
        /// link, Proton creates a <a href="https://docs.aws.amazon.com/proton/latest/userguide/using-service-linked-roles.html">service-linked
        /// role</a> for you.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-works-prov-methods.html#ag-works-prov-methods-self">Self-managed
        /// provisioning</a>, <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-template-authoring.html#ag-template-bundles">Template
        /// bundles</a>, and <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-template-sync-configs.html">Template
        /// sync configurations</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository service method.</param>
        /// 
        /// <returns>The response from the CreateRepository service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRepository operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual IAsyncResult BeginCreateRepository(CreateRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRepository.</param>
        /// 
        /// <returns>Returns a  CreateRepositoryResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateRepository">REST API Reference for CreateRepository Operation</seealso>
        public virtual CreateRepositoryResponse EndCreateRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateService

        /// <summary>
        /// Create an Proton service. An Proton service is an instantiation of a service template
        /// and often includes several service instances and pipeline. For more information, see
        /// <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-services.html">Services</a>
        /// in the <i>Proton User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// 
        /// <returns>The response from the CreateService service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return Invoke<CreateServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateService operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual IAsyncResult BeginCreateService(CreateServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateService.</param>
        /// 
        /// <returns>Returns a  CreateServiceResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateService">REST API Reference for CreateService Operation</seealso>
        public virtual CreateServiceResponse EndCreateService(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateServiceTemplate

        /// <summary>
        /// Create a service template. The administrator creates a service template to define
        /// standardized infrastructure and an optional CI/CD service pipeline. Developers, in
        /// turn, select the service template from Proton. If the selected service template includes
        /// a service pipeline definition, they provide a link to their source code repository.
        /// Proton then deploys and manages the infrastructure defined by the selected service
        /// template. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-templates.html">Proton
        /// templates</a> in the <i>Proton User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateServiceTemplate service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateServiceTemplate">REST API Reference for CreateServiceTemplate Operation</seealso>
        public virtual CreateServiceTemplateResponse CreateServiceTemplate(CreateServiceTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateServiceTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceTemplate operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateServiceTemplate">REST API Reference for CreateServiceTemplate Operation</seealso>
        public virtual IAsyncResult BeginCreateServiceTemplate(CreateServiceTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceTemplate.</param>
        /// 
        /// <returns>Returns a  CreateServiceTemplateResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateServiceTemplate">REST API Reference for CreateServiceTemplate Operation</seealso>
        public virtual CreateServiceTemplateResponse EndCreateServiceTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServiceTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateServiceTemplateVersion

        /// <summary>
        /// Create a new major or minor version of a service template. A major version of a service
        /// template is a version that <i>isn't</i> backward compatible. A minor version of a
        /// service template is a version that's backward compatible within its major version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the CreateServiceTemplateVersion service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateServiceTemplateVersion">REST API Reference for CreateServiceTemplateVersion Operation</seealso>
        public virtual CreateServiceTemplateVersionResponse CreateServiceTemplateVersion(CreateServiceTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<CreateServiceTemplateVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateServiceTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceTemplateVersion operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateServiceTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateServiceTemplateVersion">REST API Reference for CreateServiceTemplateVersion Operation</seealso>
        public virtual IAsyncResult BeginCreateServiceTemplateVersion(CreateServiceTemplateVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceTemplateVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateServiceTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateServiceTemplateVersion.</param>
        /// 
        /// <returns>Returns a  CreateServiceTemplateVersionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateServiceTemplateVersion">REST API Reference for CreateServiceTemplateVersion Operation</seealso>
        public virtual CreateServiceTemplateVersionResponse EndCreateServiceTemplateVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateServiceTemplateVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTemplateSyncConfig

        /// <summary>
        /// Set up a template to create new template versions automatically by tracking a linked
        /// repository. A linked repository is a repository that has been registered with Proton.
        /// For more information, see <a>CreateRepository</a>.
        /// 
        ///  
        /// <para>
        /// When a commit is pushed to your linked repository, Proton checks for changes to your
        /// repository template bundles. If it detects a template bundle change, a new major or
        /// minor version of its template is created, if the version doesn’t already exist. For
        /// more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-template-sync-configs.html">Template
        /// sync configurations</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateSyncConfig service method.</param>
        /// 
        /// <returns>The response from the CreateTemplateSyncConfig service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateTemplateSyncConfig">REST API Reference for CreateTemplateSyncConfig Operation</seealso>
        public virtual CreateTemplateSyncConfigResponse CreateTemplateSyncConfig(CreateTemplateSyncConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateSyncConfigResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateSyncConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTemplateSyncConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTemplateSyncConfig operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTemplateSyncConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateTemplateSyncConfig">REST API Reference for CreateTemplateSyncConfig Operation</seealso>
        public virtual IAsyncResult BeginCreateTemplateSyncConfig(CreateTemplateSyncConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateSyncConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTemplateSyncConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTemplateSyncConfig.</param>
        /// 
        /// <returns>Returns a  CreateTemplateSyncConfigResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/CreateTemplateSyncConfig">REST API Reference for CreateTemplateSyncConfig Operation</seealso>
        public virtual CreateTemplateSyncConfigResponse EndCreateTemplateSyncConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTemplateSyncConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteComponent

        /// <summary>
        /// Delete an Proton component resource.
        /// 
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent service method.</param>
        /// 
        /// <returns>The response from the DeleteComponent service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteComponent operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual IAsyncResult BeginDeleteComponent(DeleteComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteComponent.</param>
        /// 
        /// <returns>Returns a  DeleteComponentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteComponent">REST API Reference for DeleteComponent Operation</seealso>
        public virtual DeleteComponentResponse EndDeleteComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironment

        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironment service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironment(DeleteEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironment.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironment">REST API Reference for DeleteEnvironment Operation</seealso>
        public virtual DeleteEnvironmentResponse EndDeleteEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironmentAccountConnection

        /// <summary>
        /// In an environment account, delete an environment account connection.
        /// 
        ///  
        /// <para>
        /// After you delete an environment account connection that’s in use by an Proton environment,
        /// Proton <i>can’t</i> manage the environment infrastructure resources until a new environment
        /// account connection is accepted for the environment account and associated environment.
        /// You're responsible for cleaning up provisioned resources that remain without an environment
        /// connection.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
        /// account connections</a> in the <i>Proton User guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentAccountConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentAccountConnection service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironmentAccountConnection">REST API Reference for DeleteEnvironmentAccountConnection Operation</seealso>
        public virtual DeleteEnvironmentAccountConnectionResponse DeleteEnvironmentAccountConnection(DeleteEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentAccountConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentAccountConnection operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentAccountConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironmentAccountConnection">REST API Reference for DeleteEnvironmentAccountConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironmentAccountConnection(DeleteEnvironmentAccountConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentAccountConnection.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentAccountConnectionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironmentAccountConnection">REST API Reference for DeleteEnvironmentAccountConnection Operation</seealso>
        public virtual DeleteEnvironmentAccountConnectionResponse EndDeleteEnvironmentAccountConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentAccountConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironmentTemplate

        /// <summary>
        /// If no other major or minor versions of an environment template exist, delete the environment
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentTemplate service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironmentTemplate">REST API Reference for DeleteEnvironmentTemplate Operation</seealso>
        public virtual DeleteEnvironmentTemplateResponse DeleteEnvironmentTemplate(DeleteEnvironmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentTemplate operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironmentTemplate">REST API Reference for DeleteEnvironmentTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironmentTemplate(DeleteEnvironmentTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentTemplateResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironmentTemplate">REST API Reference for DeleteEnvironmentTemplate Operation</seealso>
        public virtual DeleteEnvironmentTemplateResponse EndDeleteEnvironmentTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteEnvironmentTemplateVersion

        /// <summary>
        /// If no other minor versions of an environment template exist, delete a major version
        /// of the environment template if it's not the <code>Recommended</code> version. Delete
        /// the <code>Recommended</code> version of the environment template if no other major
        /// versions or minor versions of the environment template exist. A major version of an
        /// environment template is a version that's not backward compatible.
        /// 
        ///  
        /// <para>
        /// Delete a minor version of an environment template if it <i>isn't</i> the <code>Recommended</code>
        /// version. Delete a <code>Recommended</code> minor version of the environment template
        /// if no other minor versions of the environment template exist. A minor version of an
        /// environment template is a version that's backward compatible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteEnvironmentTemplateVersion service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironmentTemplateVersion">REST API Reference for DeleteEnvironmentTemplateVersion Operation</seealso>
        public virtual DeleteEnvironmentTemplateVersionResponse DeleteEnvironmentTemplateVersion(DeleteEnvironmentTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentTemplateVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEnvironmentTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentTemplateVersion operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEnvironmentTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironmentTemplateVersion">REST API Reference for DeleteEnvironmentTemplateVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteEnvironmentTemplateVersion(DeleteEnvironmentTemplateVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEnvironmentTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEnvironmentTemplateVersion.</param>
        /// 
        /// <returns>Returns a  DeleteEnvironmentTemplateVersionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteEnvironmentTemplateVersion">REST API Reference for DeleteEnvironmentTemplateVersion Operation</seealso>
        public virtual DeleteEnvironmentTemplateVersionResponse EndDeleteEnvironmentTemplateVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteEnvironmentTemplateVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRepository

        /// <summary>
        /// De-register and unlink your repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// 
        /// <returns>The response from the DeleteRepository service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual IAsyncResult BeginDeleteRepository(DeleteRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRepository.</param>
        /// 
        /// <returns>Returns a  DeleteRepositoryResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteRepository">REST API Reference for DeleteRepository Operation</seealso>
        public virtual DeleteRepositoryResponse EndDeleteRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteService

        /// <summary>
        /// Delete a service, with its instances and pipeline.
        /// 
        ///  <note> 
        /// <para>
        /// You can't delete a service if it has any service instances that have components attached
        /// to them.
        /// </para>
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteService service method.</param>
        /// 
        /// <returns>The response from the DeleteService service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteService operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual IAsyncResult BeginDeleteService(DeleteServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteService.</param>
        /// 
        /// <returns>Returns a  DeleteServiceResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteService">REST API Reference for DeleteService Operation</seealso>
        public virtual DeleteServiceResponse EndDeleteService(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServiceTemplate

        /// <summary>
        /// If no other major or minor versions of the service template exist, delete the service
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceTemplate service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteServiceTemplate">REST API Reference for DeleteServiceTemplate Operation</seealso>
        public virtual DeleteServiceTemplateResponse DeleteServiceTemplate(DeleteServiceTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceTemplate operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteServiceTemplate">REST API Reference for DeleteServiceTemplate Operation</seealso>
        public virtual IAsyncResult BeginDeleteServiceTemplate(DeleteServiceTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteServiceTemplateResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteServiceTemplate">REST API Reference for DeleteServiceTemplate Operation</seealso>
        public virtual DeleteServiceTemplateResponse EndDeleteServiceTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServiceTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteServiceTemplateVersion

        /// <summary>
        /// If no other minor versions of a service template exist, delete a major version of
        /// the service template if it's not the <code>Recommended</code> version. Delete the
        /// <code>Recommended</code> version of the service template if no other major versions
        /// or minor versions of the service template exist. A major version of a service template
        /// is a version that <i>isn't</i> backwards compatible.
        /// 
        ///  
        /// <para>
        /// Delete a minor version of a service template if it's not the <code>Recommended</code>
        /// version. Delete a <code>Recommended</code> minor version of the service template if
        /// no other minor versions of the service template exist. A minor version of a service
        /// template is a version that's backwards compatible.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteServiceTemplateVersion service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteServiceTemplateVersion">REST API Reference for DeleteServiceTemplateVersion Operation</seealso>
        public virtual DeleteServiceTemplateVersionResponse DeleteServiceTemplateVersion(DeleteServiceTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceTemplateVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteServiceTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceTemplateVersion operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteServiceTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteServiceTemplateVersion">REST API Reference for DeleteServiceTemplateVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteServiceTemplateVersion(DeleteServiceTemplateVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceTemplateVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteServiceTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteServiceTemplateVersion.</param>
        /// 
        /// <returns>Returns a  DeleteServiceTemplateVersionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteServiceTemplateVersion">REST API Reference for DeleteServiceTemplateVersion Operation</seealso>
        public virtual DeleteServiceTemplateVersionResponse EndDeleteServiceTemplateVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteServiceTemplateVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteTemplateSyncConfig

        /// <summary>
        /// Delete a template sync configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateSyncConfig service method.</param>
        /// 
        /// <returns>The response from the DeleteTemplateSyncConfig service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteTemplateSyncConfig">REST API Reference for DeleteTemplateSyncConfig Operation</seealso>
        public virtual DeleteTemplateSyncConfigResponse DeleteTemplateSyncConfig(DeleteTemplateSyncConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateSyncConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateSyncConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTemplateSyncConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateSyncConfig operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTemplateSyncConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteTemplateSyncConfig">REST API Reference for DeleteTemplateSyncConfig Operation</seealso>
        public virtual IAsyncResult BeginDeleteTemplateSyncConfig(DeleteTemplateSyncConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateSyncConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTemplateSyncConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTemplateSyncConfig.</param>
        /// 
        /// <returns>Returns a  DeleteTemplateSyncConfigResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/DeleteTemplateSyncConfig">REST API Reference for DeleteTemplateSyncConfig Operation</seealso>
        public virtual DeleteTemplateSyncConfigResponse EndDeleteTemplateSyncConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteTemplateSyncConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetAccountSettings

        /// <summary>
        /// Get detail data for Proton account-wide settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// 
        /// <returns>The response from the GetAccountSettings service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginGetAccountSettings(GetAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetAccountSettings.</param>
        /// 
        /// <returns>Returns a  GetAccountSettingsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetAccountSettings">REST API Reference for GetAccountSettings Operation</seealso>
        public virtual GetAccountSettingsResponse EndGetAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<GetAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetComponent

        /// <summary>
        /// Get detailed data for a component.
        /// 
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetComponent service method.</param>
        /// 
        /// <returns>The response from the GetComponent service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse GetComponent(GetComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetComponent operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual IAsyncResult BeginGetComponent(GetComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetComponent.</param>
        /// 
        /// <returns>Returns a  GetComponentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetComponent">REST API Reference for GetComponent Operation</seealso>
        public virtual GetComponentResponse EndGetComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<GetComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironment

        /// <summary>
        /// Get detailed data for an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// 
        /// <returns>The response from the GetEnvironment service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironment(GetEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironment.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironment">REST API Reference for GetEnvironment Operation</seealso>
        public virtual GetEnvironmentResponse EndGetEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironmentAccountConnection

        /// <summary>
        /// In an environment account, get the detailed data for an environment account connection.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
        /// account connections</a> in the <i>Proton User guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentAccountConnection service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentAccountConnection service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironmentAccountConnection">REST API Reference for GetEnvironmentAccountConnection Operation</seealso>
        public virtual GetEnvironmentAccountConnectionResponse GetEnvironmentAccountConnection(GetEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentAccountConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentAccountConnection operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironmentAccountConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironmentAccountConnection">REST API Reference for GetEnvironmentAccountConnection Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironmentAccountConnection(GetEnvironmentAccountConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironmentAccountConnection.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentAccountConnectionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironmentAccountConnection">REST API Reference for GetEnvironmentAccountConnection Operation</seealso>
        public virtual GetEnvironmentAccountConnectionResponse EndGetEnvironmentAccountConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentAccountConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironmentTemplate

        /// <summary>
        /// Get detailed data for an environment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentTemplate service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentTemplate service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironmentTemplate">REST API Reference for GetEnvironmentTemplate Operation</seealso>
        public virtual GetEnvironmentTemplateResponse GetEnvironmentTemplate(GetEnvironmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentTemplateResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentTemplate operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironmentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironmentTemplate">REST API Reference for GetEnvironmentTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironmentTemplate(GetEnvironmentTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironmentTemplate.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentTemplateResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironmentTemplate">REST API Reference for GetEnvironmentTemplate Operation</seealso>
        public virtual GetEnvironmentTemplateResponse EndGetEnvironmentTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetEnvironmentTemplateVersion

        /// <summary>
        /// Get detailed data for a major or minor version of an environment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the GetEnvironmentTemplateVersion service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironmentTemplateVersion">REST API Reference for GetEnvironmentTemplateVersion Operation</seealso>
        public virtual GetEnvironmentTemplateVersionResponse GetEnvironmentTemplateVersion(GetEnvironmentTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentTemplateVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetEnvironmentTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentTemplateVersion operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetEnvironmentTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironmentTemplateVersion">REST API Reference for GetEnvironmentTemplateVersion Operation</seealso>
        public virtual IAsyncResult BeginGetEnvironmentTemplateVersion(GetEnvironmentTemplateVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetEnvironmentTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetEnvironmentTemplateVersion.</param>
        /// 
        /// <returns>Returns a  GetEnvironmentTemplateVersionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetEnvironmentTemplateVersion">REST API Reference for GetEnvironmentTemplateVersion Operation</seealso>
        public virtual GetEnvironmentTemplateVersionResponse EndGetEnvironmentTemplateVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetEnvironmentTemplateVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRepository

        /// <summary>
        /// Get detail data for a linked repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepository service method.</param>
        /// 
        /// <returns>The response from the GetRepository service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetRepository">REST API Reference for GetRepository Operation</seealso>
        public virtual GetRepositoryResponse GetRepository(GetRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepository operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepository operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepository
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetRepository">REST API Reference for GetRepository Operation</seealso>
        public virtual IAsyncResult BeginGetRepository(GetRepositoryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepository operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepository.</param>
        /// 
        /// <returns>Returns a  GetRepositoryResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetRepository">REST API Reference for GetRepository Operation</seealso>
        public virtual GetRepositoryResponse EndGetRepository(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRepositoryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRepositorySyncStatus

        /// <summary>
        /// Get the sync status of a repository used for Proton template sync. For more information
        /// about template sync, see .
        /// 
        ///  <note> 
        /// <para>
        /// A repository sync status isn't tied to the Proton Repository resource (or any other
        /// Proton resource). Therefore, tags on an Proton Repository resource have no effect
        /// on this action. Specifically, you can't use these tags to control access to this action
        /// using Attribute-based access control (ABAC).
        /// </para>
        ///  
        /// <para>
        /// For more information about ABAC, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/security_iam_service-with-iam.html#security_iam_service-with-iam-tags">ABAC</a>
        /// in the <i>Proton User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepositorySyncStatus service method.</param>
        /// 
        /// <returns>The response from the GetRepositorySyncStatus service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetRepositorySyncStatus">REST API Reference for GetRepositorySyncStatus Operation</seealso>
        public virtual GetRepositorySyncStatusResponse GetRepositorySyncStatus(GetRepositorySyncStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositorySyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositorySyncStatusResponseUnmarshaller.Instance;

            return Invoke<GetRepositorySyncStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRepositorySyncStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRepositorySyncStatus operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRepositorySyncStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetRepositorySyncStatus">REST API Reference for GetRepositorySyncStatus Operation</seealso>
        public virtual IAsyncResult BeginGetRepositorySyncStatus(GetRepositorySyncStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositorySyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositorySyncStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRepositorySyncStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRepositorySyncStatus.</param>
        /// 
        /// <returns>Returns a  GetRepositorySyncStatusResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetRepositorySyncStatus">REST API Reference for GetRepositorySyncStatus Operation</seealso>
        public virtual GetRepositorySyncStatusResponse EndGetRepositorySyncStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRepositorySyncStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcesSummary

        /// <summary>
        /// Get counts of Proton resources.
        /// 
        ///  
        /// <para>
        /// For infrastructure-provisioning resources (environments, services, service instances,
        /// pipelines), the action returns staleness counts. A resource is stale when it's behind
        /// the recommended version of the Proton template that it uses and it needs an update
        /// to become current.
        /// </para>
        ///  
        /// <para>
        /// The action returns staleness counts (counts of resources that are up-to-date, behind
        /// a template major version, or behind a template minor version), the total number of
        /// resources, and the number of resources that are in a failed state, grouped by resource
        /// type. Components, environments, and service templates are exceptions—see the <code>components</code>,
        /// <code>environments</code>, and <code>serviceTemplates</code> field descriptions.
        /// </para>
        ///  
        /// <para>
        /// For context, the action also returns the total number of each type of Proton template
        /// in the Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/monitoring-dashboard.html">Proton
        /// dashboard</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcesSummary service method.</param>
        /// 
        /// <returns>The response from the GetResourcesSummary service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetResourcesSummary">REST API Reference for GetResourcesSummary Operation</seealso>
        public virtual GetResourcesSummaryResponse GetResourcesSummary(GetResourcesSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcesSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesSummaryResponseUnmarshaller.Instance;

            return Invoke<GetResourcesSummaryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcesSummary operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcesSummary operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcesSummary
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetResourcesSummary">REST API Reference for GetResourcesSummary Operation</seealso>
        public virtual IAsyncResult BeginGetResourcesSummary(GetResourcesSummaryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcesSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesSummaryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcesSummary operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcesSummary.</param>
        /// 
        /// <returns>Returns a  GetResourcesSummaryResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetResourcesSummary">REST API Reference for GetResourcesSummary Operation</seealso>
        public virtual GetResourcesSummaryResponse EndGetResourcesSummary(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcesSummaryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetService

        /// <summary>
        /// Get detailed data for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// 
        /// <returns>The response from the GetService service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetService">REST API Reference for GetService Operation</seealso>
        public virtual GetServiceResponse GetService(GetServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return Invoke<GetServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetService operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetService">REST API Reference for GetService Operation</seealso>
        public virtual IAsyncResult BeginGetService(GetServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetService.</param>
        /// 
        /// <returns>Returns a  GetServiceResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetService">REST API Reference for GetService Operation</seealso>
        public virtual GetServiceResponse EndGetService(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceInstance

        /// <summary>
        /// Get detailed data for a service instance. A service instance is an instantiation of
        /// service template and it runs in a specific environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceInstance service method.</param>
        /// 
        /// <returns>The response from the GetServiceInstance service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetServiceInstance">REST API Reference for GetServiceInstance Operation</seealso>
        public virtual GetServiceInstanceResponse GetServiceInstance(GetServiceInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceInstanceResponseUnmarshaller.Instance;

            return Invoke<GetServiceInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceInstance operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetServiceInstance">REST API Reference for GetServiceInstance Operation</seealso>
        public virtual IAsyncResult BeginGetServiceInstance(GetServiceInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceInstance.</param>
        /// 
        /// <returns>Returns a  GetServiceInstanceResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetServiceInstance">REST API Reference for GetServiceInstance Operation</seealso>
        public virtual GetServiceInstanceResponse EndGetServiceInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceTemplate

        /// <summary>
        /// Get detailed data for a service template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceTemplate service method.</param>
        /// 
        /// <returns>The response from the GetServiceTemplate service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetServiceTemplate">REST API Reference for GetServiceTemplate Operation</seealso>
        public virtual GetServiceTemplateResponse GetServiceTemplate(GetServiceTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceTemplateResponseUnmarshaller.Instance;

            return Invoke<GetServiceTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceTemplate operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetServiceTemplate">REST API Reference for GetServiceTemplate Operation</seealso>
        public virtual IAsyncResult BeginGetServiceTemplate(GetServiceTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceTemplate.</param>
        /// 
        /// <returns>Returns a  GetServiceTemplateResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetServiceTemplate">REST API Reference for GetServiceTemplate Operation</seealso>
        public virtual GetServiceTemplateResponse EndGetServiceTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  GetServiceTemplateVersion

        /// <summary>
        /// Get detailed data for a major or minor version of a service template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the GetServiceTemplateVersion service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetServiceTemplateVersion">REST API Reference for GetServiceTemplateVersion Operation</seealso>
        public virtual GetServiceTemplateVersionResponse GetServiceTemplateVersion(GetServiceTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<GetServiceTemplateVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetServiceTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetServiceTemplateVersion operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetServiceTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetServiceTemplateVersion">REST API Reference for GetServiceTemplateVersion Operation</seealso>
        public virtual IAsyncResult BeginGetServiceTemplateVersion(GetServiceTemplateVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceTemplateVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetServiceTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetServiceTemplateVersion.</param>
        /// 
        /// <returns>Returns a  GetServiceTemplateVersionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetServiceTemplateVersion">REST API Reference for GetServiceTemplateVersion Operation</seealso>
        public virtual GetServiceTemplateVersionResponse EndGetServiceTemplateVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<GetServiceTemplateVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTemplateSyncConfig

        /// <summary>
        /// Get detail data for a template sync configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSyncConfig service method.</param>
        /// 
        /// <returns>The response from the GetTemplateSyncConfig service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetTemplateSyncConfig">REST API Reference for GetTemplateSyncConfig Operation</seealso>
        public virtual GetTemplateSyncConfigResponse GetTemplateSyncConfig(GetTemplateSyncConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSyncConfigResponseUnmarshaller.Instance;

            return Invoke<GetTemplateSyncConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplateSyncConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSyncConfig operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplateSyncConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetTemplateSyncConfig">REST API Reference for GetTemplateSyncConfig Operation</seealso>
        public virtual IAsyncResult BeginGetTemplateSyncConfig(GetTemplateSyncConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSyncConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplateSyncConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplateSyncConfig.</param>
        /// 
        /// <returns>Returns a  GetTemplateSyncConfigResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetTemplateSyncConfig">REST API Reference for GetTemplateSyncConfig Operation</seealso>
        public virtual GetTemplateSyncConfigResponse EndGetTemplateSyncConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTemplateSyncConfigResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTemplateSyncStatus

        /// <summary>
        /// Get the status of a template sync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSyncStatus service method.</param>
        /// 
        /// <returns>The response from the GetTemplateSyncStatus service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetTemplateSyncStatus">REST API Reference for GetTemplateSyncStatus Operation</seealso>
        public virtual GetTemplateSyncStatusResponse GetTemplateSyncStatus(GetTemplateSyncStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSyncStatusResponseUnmarshaller.Instance;

            return Invoke<GetTemplateSyncStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTemplateSyncStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSyncStatus operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTemplateSyncStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetTemplateSyncStatus">REST API Reference for GetTemplateSyncStatus Operation</seealso>
        public virtual IAsyncResult BeginGetTemplateSyncStatus(GetTemplateSyncStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSyncStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTemplateSyncStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTemplateSyncStatus.</param>
        /// 
        /// <returns>Returns a  GetTemplateSyncStatusResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/GetTemplateSyncStatus">REST API Reference for GetTemplateSyncStatus Operation</seealso>
        public virtual GetTemplateSyncStatusResponse EndGetTemplateSyncStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTemplateSyncStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponentOutputs

        /// <summary>
        /// Get a list of component Infrastructure as Code (IaC) outputs.
        /// 
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentOutputs service method.</param>
        /// 
        /// <returns>The response from the ListComponentOutputs service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListComponentOutputs">REST API Reference for ListComponentOutputs Operation</seealso>
        public virtual ListComponentOutputsResponse ListComponentOutputs(ListComponentOutputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentOutputsResponseUnmarshaller.Instance;

            return Invoke<ListComponentOutputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponentOutputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponentOutputs operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponentOutputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListComponentOutputs">REST API Reference for ListComponentOutputs Operation</seealso>
        public virtual IAsyncResult BeginListComponentOutputs(ListComponentOutputsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentOutputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponentOutputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponentOutputs.</param>
        /// 
        /// <returns>Returns a  ListComponentOutputsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListComponentOutputs">REST API Reference for ListComponentOutputs Operation</seealso>
        public virtual ListComponentOutputsResponse EndListComponentOutputs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentOutputsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponentProvisionedResources

        /// <summary>
        /// List provisioned resources for a component with details.
        /// 
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponentProvisionedResources service method.</param>
        /// 
        /// <returns>The response from the ListComponentProvisionedResources service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListComponentProvisionedResources">REST API Reference for ListComponentProvisionedResources Operation</seealso>
        public virtual ListComponentProvisionedResourcesResponse ListComponentProvisionedResources(ListComponentProvisionedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentProvisionedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListComponentProvisionedResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponentProvisionedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponentProvisionedResources operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponentProvisionedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListComponentProvisionedResources">REST API Reference for ListComponentProvisionedResources Operation</seealso>
        public virtual IAsyncResult BeginListComponentProvisionedResources(ListComponentProvisionedResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentProvisionedResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponentProvisionedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponentProvisionedResources.</param>
        /// 
        /// <returns>Returns a  ListComponentProvisionedResourcesResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListComponentProvisionedResources">REST API Reference for ListComponentProvisionedResources Operation</seealso>
        public virtual ListComponentProvisionedResourcesResponse EndListComponentProvisionedResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentProvisionedResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListComponents

        /// <summary>
        /// List components with summary data. You can filter the result list by environment,
        /// service, or a single service instance.
        /// 
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListComponents service method.</param>
        /// 
        /// <returns>The response from the ListComponents service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListComponents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListComponents operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListComponents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual IAsyncResult BeginListComponents(ListComponentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListComponents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListComponents.</param>
        /// 
        /// <returns>Returns a  ListComponentsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListComponents">REST API Reference for ListComponents Operation</seealso>
        public virtual ListComponentsResponse EndListComponents(IAsyncResult asyncResult)
        {
            return EndInvoke<ListComponentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentAccountConnections

        /// <summary>
        /// View a list of environment account connections.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
        /// account connections</a> in the <i>Proton User guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentAccountConnections service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentAccountConnections service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentAccountConnections">REST API Reference for ListEnvironmentAccountConnections Operation</seealso>
        public virtual ListEnvironmentAccountConnectionsResponse ListEnvironmentAccountConnections(ListEnvironmentAccountConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentAccountConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentAccountConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentAccountConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentAccountConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentAccountConnections operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentAccountConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentAccountConnections">REST API Reference for ListEnvironmentAccountConnections Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentAccountConnections(ListEnvironmentAccountConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentAccountConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentAccountConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentAccountConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentAccountConnections.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentAccountConnectionsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentAccountConnections">REST API Reference for ListEnvironmentAccountConnections Operation</seealso>
        public virtual ListEnvironmentAccountConnectionsResponse EndListEnvironmentAccountConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentAccountConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentOutputs

        /// <summary>
        /// List the infrastructure as code outputs for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentOutputs service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentOutputs service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentOutputs">REST API Reference for ListEnvironmentOutputs Operation</seealso>
        public virtual ListEnvironmentOutputsResponse ListEnvironmentOutputs(ListEnvironmentOutputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentOutputsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentOutputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentOutputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentOutputs operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentOutputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentOutputs">REST API Reference for ListEnvironmentOutputs Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentOutputs(ListEnvironmentOutputsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentOutputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentOutputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentOutputs.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentOutputsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentOutputs">REST API Reference for ListEnvironmentOutputs Operation</seealso>
        public virtual ListEnvironmentOutputsResponse EndListEnvironmentOutputs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentOutputsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentProvisionedResources

        /// <summary>
        /// List the provisioned resources for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentProvisionedResources service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentProvisionedResources service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentProvisionedResources">REST API Reference for ListEnvironmentProvisionedResources Operation</seealso>
        public virtual ListEnvironmentProvisionedResourcesResponse ListEnvironmentProvisionedResources(ListEnvironmentProvisionedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentProvisionedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentProvisionedResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentProvisionedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentProvisionedResources operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentProvisionedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentProvisionedResources">REST API Reference for ListEnvironmentProvisionedResources Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentProvisionedResources(ListEnvironmentProvisionedResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentProvisionedResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentProvisionedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentProvisionedResources.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentProvisionedResourcesResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentProvisionedResources">REST API Reference for ListEnvironmentProvisionedResources Operation</seealso>
        public virtual ListEnvironmentProvisionedResourcesResponse EndListEnvironmentProvisionedResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentProvisionedResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironments

        /// <summary>
        /// List environments with detail data summaries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// 
        /// <returns>The response from the ListEnvironments service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual IAsyncResult BeginListEnvironments(ListEnvironmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironments.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironments">REST API Reference for ListEnvironments Operation</seealso>
        public virtual ListEnvironmentsResponse EndListEnvironments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentTemplates

        /// <summary>
        /// List environment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentTemplates service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentTemplates service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentTemplates">REST API Reference for ListEnvironmentTemplates Operation</seealso>
        public virtual ListEnvironmentTemplatesResponse ListEnvironmentTemplates(ListEnvironmentTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentTemplates operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentTemplates">REST API Reference for ListEnvironmentTemplates Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentTemplates(ListEnvironmentTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentTemplates.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentTemplatesResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentTemplates">REST API Reference for ListEnvironmentTemplates Operation</seealso>
        public virtual ListEnvironmentTemplatesResponse EndListEnvironmentTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListEnvironmentTemplateVersions

        /// <summary>
        /// List major or minor versions of an environment template with detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the ListEnvironmentTemplateVersions service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentTemplateVersions">REST API Reference for ListEnvironmentTemplateVersions Operation</seealso>
        public virtual ListEnvironmentTemplateVersionsResponse ListEnvironmentTemplateVersions(ListEnvironmentTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentTemplateVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListEnvironmentTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentTemplateVersions operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListEnvironmentTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentTemplateVersions">REST API Reference for ListEnvironmentTemplateVersions Operation</seealso>
        public virtual IAsyncResult BeginListEnvironmentTemplateVersions(ListEnvironmentTemplateVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentTemplateVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListEnvironmentTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListEnvironmentTemplateVersions.</param>
        /// 
        /// <returns>Returns a  ListEnvironmentTemplateVersionsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListEnvironmentTemplateVersions">REST API Reference for ListEnvironmentTemplateVersions Operation</seealso>
        public virtual ListEnvironmentTemplateVersionsResponse EndListEnvironmentTemplateVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListEnvironmentTemplateVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRepositories

        /// <summary>
        /// List linked repositories with detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories service method.</param>
        /// 
        /// <returns>The response from the ListRepositories service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        public virtual ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListRepositoriesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositories operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositories
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        public virtual IAsyncResult BeginListRepositories(ListRepositoriesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositories operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositories.</param>
        /// 
        /// <returns>Returns a  ListRepositoriesResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListRepositories">REST API Reference for ListRepositories Operation</seealso>
        public virtual ListRepositoriesResponse EndListRepositories(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRepositoriesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRepositorySyncDefinitions

        /// <summary>
        /// List repository sync definitions with detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositorySyncDefinitions service method.</param>
        /// 
        /// <returns>The response from the ListRepositorySyncDefinitions service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListRepositorySyncDefinitions">REST API Reference for ListRepositorySyncDefinitions Operation</seealso>
        public virtual ListRepositorySyncDefinitionsResponse ListRepositorySyncDefinitions(ListRepositorySyncDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositorySyncDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositorySyncDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListRepositorySyncDefinitionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRepositorySyncDefinitions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRepositorySyncDefinitions operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRepositorySyncDefinitions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListRepositorySyncDefinitions">REST API Reference for ListRepositorySyncDefinitions Operation</seealso>
        public virtual IAsyncResult BeginListRepositorySyncDefinitions(ListRepositorySyncDefinitionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositorySyncDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositorySyncDefinitionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRepositorySyncDefinitions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRepositorySyncDefinitions.</param>
        /// 
        /// <returns>Returns a  ListRepositorySyncDefinitionsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListRepositorySyncDefinitions">REST API Reference for ListRepositorySyncDefinitions Operation</seealso>
        public virtual ListRepositorySyncDefinitionsResponse EndListRepositorySyncDefinitions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRepositorySyncDefinitionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceInstanceOutputs

        /// <summary>
        /// Get a list service of instance Infrastructure as Code (IaC) outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceInstanceOutputs service method.</param>
        /// 
        /// <returns>The response from the ListServiceInstanceOutputs service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceInstanceOutputs">REST API Reference for ListServiceInstanceOutputs Operation</seealso>
        public virtual ListServiceInstanceOutputsResponse ListServiceInstanceOutputs(ListServiceInstanceOutputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstanceOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstanceOutputsResponseUnmarshaller.Instance;

            return Invoke<ListServiceInstanceOutputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceInstanceOutputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceInstanceOutputs operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceInstanceOutputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceInstanceOutputs">REST API Reference for ListServiceInstanceOutputs Operation</seealso>
        public virtual IAsyncResult BeginListServiceInstanceOutputs(ListServiceInstanceOutputsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstanceOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstanceOutputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceInstanceOutputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceInstanceOutputs.</param>
        /// 
        /// <returns>Returns a  ListServiceInstanceOutputsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceInstanceOutputs">REST API Reference for ListServiceInstanceOutputs Operation</seealso>
        public virtual ListServiceInstanceOutputsResponse EndListServiceInstanceOutputs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceInstanceOutputsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceInstanceProvisionedResources

        /// <summary>
        /// List provisioned resources for a service instance with details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceInstanceProvisionedResources service method.</param>
        /// 
        /// <returns>The response from the ListServiceInstanceProvisionedResources service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceInstanceProvisionedResources">REST API Reference for ListServiceInstanceProvisionedResources Operation</seealso>
        public virtual ListServiceInstanceProvisionedResourcesResponse ListServiceInstanceProvisionedResources(ListServiceInstanceProvisionedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstanceProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstanceProvisionedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListServiceInstanceProvisionedResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceInstanceProvisionedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceInstanceProvisionedResources operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceInstanceProvisionedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceInstanceProvisionedResources">REST API Reference for ListServiceInstanceProvisionedResources Operation</seealso>
        public virtual IAsyncResult BeginListServiceInstanceProvisionedResources(ListServiceInstanceProvisionedResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstanceProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstanceProvisionedResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceInstanceProvisionedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceInstanceProvisionedResources.</param>
        /// 
        /// <returns>Returns a  ListServiceInstanceProvisionedResourcesResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceInstanceProvisionedResources">REST API Reference for ListServiceInstanceProvisionedResources Operation</seealso>
        public virtual ListServiceInstanceProvisionedResourcesResponse EndListServiceInstanceProvisionedResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceInstanceProvisionedResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceInstances

        /// <summary>
        /// List service instances with summary data. This action lists service instances of all
        /// services in the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceInstances service method.</param>
        /// 
        /// <returns>The response from the ListServiceInstances service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceInstances">REST API Reference for ListServiceInstances Operation</seealso>
        public virtual ListServiceInstancesResponse ListServiceInstances(ListServiceInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstancesResponseUnmarshaller.Instance;

            return Invoke<ListServiceInstancesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceInstances operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceInstances">REST API Reference for ListServiceInstances Operation</seealso>
        public virtual IAsyncResult BeginListServiceInstances(ListServiceInstancesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstancesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceInstances.</param>
        /// 
        /// <returns>Returns a  ListServiceInstancesResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceInstances">REST API Reference for ListServiceInstances Operation</seealso>
        public virtual ListServiceInstancesResponse EndListServiceInstances(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceInstancesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServicePipelineOutputs

        /// <summary>
        /// Get a list of service pipeline Infrastructure as Code (IaC) outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicePipelineOutputs service method.</param>
        /// 
        /// <returns>The response from the ListServicePipelineOutputs service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServicePipelineOutputs">REST API Reference for ListServicePipelineOutputs Operation</seealso>
        public virtual ListServicePipelineOutputsResponse ListServicePipelineOutputs(ListServicePipelineOutputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicePipelineOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePipelineOutputsResponseUnmarshaller.Instance;

            return Invoke<ListServicePipelineOutputsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServicePipelineOutputs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServicePipelineOutputs operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServicePipelineOutputs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServicePipelineOutputs">REST API Reference for ListServicePipelineOutputs Operation</seealso>
        public virtual IAsyncResult BeginListServicePipelineOutputs(ListServicePipelineOutputsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicePipelineOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePipelineOutputsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServicePipelineOutputs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServicePipelineOutputs.</param>
        /// 
        /// <returns>Returns a  ListServicePipelineOutputsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServicePipelineOutputs">REST API Reference for ListServicePipelineOutputs Operation</seealso>
        public virtual ListServicePipelineOutputsResponse EndListServicePipelineOutputs(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServicePipelineOutputsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServicePipelineProvisionedResources

        /// <summary>
        /// List provisioned resources for a service and pipeline with details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicePipelineProvisionedResources service method.</param>
        /// 
        /// <returns>The response from the ListServicePipelineProvisionedResources service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServicePipelineProvisionedResources">REST API Reference for ListServicePipelineProvisionedResources Operation</seealso>
        public virtual ListServicePipelineProvisionedResourcesResponse ListServicePipelineProvisionedResources(ListServicePipelineProvisionedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicePipelineProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePipelineProvisionedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListServicePipelineProvisionedResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServicePipelineProvisionedResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServicePipelineProvisionedResources operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServicePipelineProvisionedResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServicePipelineProvisionedResources">REST API Reference for ListServicePipelineProvisionedResources Operation</seealso>
        public virtual IAsyncResult BeginListServicePipelineProvisionedResources(ListServicePipelineProvisionedResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicePipelineProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePipelineProvisionedResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServicePipelineProvisionedResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServicePipelineProvisionedResources.</param>
        /// 
        /// <returns>Returns a  ListServicePipelineProvisionedResourcesResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServicePipelineProvisionedResources">REST API Reference for ListServicePipelineProvisionedResources Operation</seealso>
        public virtual ListServicePipelineProvisionedResourcesResponse EndListServicePipelineProvisionedResources(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServicePipelineProvisionedResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServices

        /// <summary>
        /// List services with summaries of detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// 
        /// <returns>The response from the ListServices service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServices operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual IAsyncResult BeginListServices(ListServicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServices.</param>
        /// 
        /// <returns>Returns a  ListServicesResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServices">REST API Reference for ListServices Operation</seealso>
        public virtual ListServicesResponse EndListServices(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServicesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceTemplates

        /// <summary>
        /// List service templates with detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceTemplates service method.</param>
        /// 
        /// <returns>The response from the ListServiceTemplates service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceTemplates">REST API Reference for ListServiceTemplates Operation</seealso>
        public virtual ListServiceTemplatesResponse ListServiceTemplates(ListServiceTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListServiceTemplatesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceTemplates operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceTemplates">REST API Reference for ListServiceTemplates Operation</seealso>
        public virtual IAsyncResult BeginListServiceTemplates(ListServiceTemplatesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceTemplatesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceTemplates.</param>
        /// 
        /// <returns>Returns a  ListServiceTemplatesResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceTemplates">REST API Reference for ListServiceTemplates Operation</seealso>
        public virtual ListServiceTemplatesResponse EndListServiceTemplates(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceTemplatesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListServiceTemplateVersions

        /// <summary>
        /// List major or minor versions of a service template with detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the ListServiceTemplateVersions service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceTemplateVersions">REST API Reference for ListServiceTemplateVersions Operation</seealso>
        public virtual ListServiceTemplateVersionsResponse ListServiceTemplateVersions(ListServiceTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<ListServiceTemplateVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListServiceTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListServiceTemplateVersions operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListServiceTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceTemplateVersions">REST API Reference for ListServiceTemplateVersions Operation</seealso>
        public virtual IAsyncResult BeginListServiceTemplateVersions(ListServiceTemplateVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceTemplateVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListServiceTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListServiceTemplateVersions.</param>
        /// 
        /// <returns>Returns a  ListServiceTemplateVersionsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListServiceTemplateVersions">REST API Reference for ListServiceTemplateVersions Operation</seealso>
        public virtual ListServiceTemplateVersionsResponse EndListServiceTemplateVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListServiceTemplateVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// List tags for a resource. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">Proton
        /// resources and tagging</a> in the <i>Proton User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  ListTagsForResourceResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  NotifyResourceDeploymentStatusChange

        /// <summary>
        /// Notify Proton of status changes to a provisioned resource when you use self-managed
        /// provisioning.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-works-prov-methods.html#ag-works-prov-methods-self">Self-managed
        /// provisioning</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the NotifyResourceDeploymentStatusChange service method.</param>
        /// 
        /// <returns>The response from the NotifyResourceDeploymentStatusChange service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/NotifyResourceDeploymentStatusChange">REST API Reference for NotifyResourceDeploymentStatusChange Operation</seealso>
        public virtual NotifyResourceDeploymentStatusChangeResponse NotifyResourceDeploymentStatusChange(NotifyResourceDeploymentStatusChangeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyResourceDeploymentStatusChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyResourceDeploymentStatusChangeResponseUnmarshaller.Instance;

            return Invoke<NotifyResourceDeploymentStatusChangeResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the NotifyResourceDeploymentStatusChange operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the NotifyResourceDeploymentStatusChange operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndNotifyResourceDeploymentStatusChange
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/NotifyResourceDeploymentStatusChange">REST API Reference for NotifyResourceDeploymentStatusChange Operation</seealso>
        public virtual IAsyncResult BeginNotifyResourceDeploymentStatusChange(NotifyResourceDeploymentStatusChangeRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyResourceDeploymentStatusChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyResourceDeploymentStatusChangeResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  NotifyResourceDeploymentStatusChange operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginNotifyResourceDeploymentStatusChange.</param>
        /// 
        /// <returns>Returns a  NotifyResourceDeploymentStatusChangeResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/NotifyResourceDeploymentStatusChange">REST API Reference for NotifyResourceDeploymentStatusChange Operation</seealso>
        public virtual NotifyResourceDeploymentStatusChangeResponse EndNotifyResourceDeploymentStatusChange(IAsyncResult asyncResult)
        {
            return EndInvoke<NotifyResourceDeploymentStatusChangeResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectEnvironmentAccountConnection

        /// <summary>
        /// In a management account, reject an environment account connection from another environment
        /// account.
        /// 
        ///  
        /// <para>
        /// After you reject an environment account connection request, you <i>can't</i> accept
        /// or use the rejected environment account connection.
        /// </para>
        ///  
        /// <para>
        /// You <i>can’t</i> reject an environment account connection that's connected to an environment.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
        /// account connections</a> in the <i>Proton User guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectEnvironmentAccountConnection service method.</param>
        /// 
        /// <returns>The response from the RejectEnvironmentAccountConnection service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/RejectEnvironmentAccountConnection">REST API Reference for RejectEnvironmentAccountConnection Operation</seealso>
        public virtual RejectEnvironmentAccountConnectionResponse RejectEnvironmentAccountConnection(RejectEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectEnvironmentAccountConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectEnvironmentAccountConnection operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectEnvironmentAccountConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/RejectEnvironmentAccountConnection">REST API Reference for RejectEnvironmentAccountConnection Operation</seealso>
        public virtual IAsyncResult BeginRejectEnvironmentAccountConnection(RejectEnvironmentAccountConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectEnvironmentAccountConnection.</param>
        /// 
        /// <returns>Returns a  RejectEnvironmentAccountConnectionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/RejectEnvironmentAccountConnection">REST API Reference for RejectEnvironmentAccountConnection Operation</seealso>
        public virtual RejectEnvironmentAccountConnectionResponse EndRejectEnvironmentAccountConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectEnvironmentAccountConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tag a resource. A tag is a key-value pair of metadata that you associate with an Proton
        /// resource.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">Proton
        /// resources and tagging</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  TagResourceResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Remove a customer tag from a resource. A tag is a key-value pair of metadata associated
        /// with an Proton resource.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">Proton
        /// resources and tagging</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
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
        /// <returns>Returns a  UntagResourceResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateAccountSettings

        /// <summary>
        /// Update Proton settings that are used for multiple services in the Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// 
        /// <returns>The response from the UpdateAccountSettings service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSettingsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateAccountSettings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual IAsyncResult BeginUpdateAccountSettings(UpdateAccountSettingsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateAccountSettings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateAccountSettings.</param>
        /// 
        /// <returns>Returns a  UpdateAccountSettingsResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateAccountSettings">REST API Reference for UpdateAccountSettings Operation</seealso>
        public virtual UpdateAccountSettingsResponse EndUpdateAccountSettings(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateAccountSettingsResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateComponent

        /// <summary>
        /// Update a component.
        /// 
        ///  
        /// <para>
        /// There are a few modes for updating a component. The <code>deploymentType</code> field
        /// defines the mode.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't update a component while its deployment status, or the deployment status
        /// of a service instance attached to it, is <code>IN_PROGRESS</code>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent service method.</param>
        /// 
        /// <returns>The response from the UpdateComponent service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual UpdateComponentResponse UpdateComponent(UpdateComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateComponent operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateComponent
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual IAsyncResult BeginUpdateComponent(UpdateComponentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateComponent operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateComponent.</param>
        /// 
        /// <returns>Returns a  UpdateComponentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateComponent">REST API Reference for UpdateComponent Operation</seealso>
        public virtual UpdateComponentResponse EndUpdateComponent(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateComponentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnvironment

        /// <summary>
        /// Update an environment.
        /// 
        ///  
        /// <para>
        /// If the environment is associated with an environment account connection, <i>don't</i>
        /// update or include the <code>protonServiceRoleArn</code> and <code>provisioningRepository</code>
        /// parameter to update or connect to an environment account connection.
        /// </para>
        ///  
        /// <para>
        /// You can only update to a new environment account connection if that connection was
        /// created in the same environment account that the current environment account connection
        /// was created in. The account connection must also be associated with the current environment.
        /// </para>
        ///  
        /// <para>
        /// If the environment <i>isn't</i> associated with an environment account connection,
        /// <i>don't</i> update or include the <code>environmentAccountConnectionId</code> parameter.
        /// You <i>can't</i> update or connect the environment to an environment account connection
        /// if it <i>isn't</i> already associated with an environment connection.
        /// </para>
        ///  
        /// <para>
        /// You can update either the <code>environmentAccountConnectionId</code> or <code>protonServiceRoleArn</code>
        /// parameter and value. You can’t update both.
        /// </para>
        ///  
        /// <para>
        /// If the environment was configured for Amazon Web Services-managed provisioning, omit
        /// the <code>provisioningRepository</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// If the environment was configured for self-managed provisioning, specify the <code>provisioningRepository</code>
        /// parameter and omit the <code>protonServiceRoleArn</code> and <code>environmentAccountConnectionId</code>
        /// parameters.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-environments.html">Environments</a>
        /// and <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-works-prov-methods.html">Provisioning
        /// methods</a> in the <i>Proton User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// There are four modes for updating an environment. The <code>deploymentType</code>
        /// field defines the mode.
        /// </para>
        ///  <dl> <dt/> <dd> 
        /// <para>
        ///  <code>NONE</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, a deployment <i>doesn't</i> occur. Only the requested metadata parameters
        /// are updated.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>CURRENT_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the environment is deployed and updated with the new spec that you provide.
        /// Only requested parameters are updated. <i>Don’t</i> include minor or major version
        /// parameters when you use this <code>deployment-type</code>.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>MINOR_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the environment is deployed and updated with the published, recommended
        /// (latest) minor version of the current major version in use, by default. You can also
        /// specify a different minor version of the current major version in use.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>MAJOR_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the environment is deployed and updated with the published, recommended
        /// (latest) major and minor version of the current template, by default. You can also
        /// specify a different major version that's higher than the major version in use and
        /// a minor version.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironment service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironment operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironment(UpdateEnvironmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironment.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironment">REST API Reference for UpdateEnvironment Operation</seealso>
        public virtual UpdateEnvironmentResponse EndUpdateEnvironment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnvironmentAccountConnection

        /// <summary>
        /// In an environment account, update an environment account connection to use a new IAM
        /// role.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-env-account-connections.html">Environment
        /// account connections</a> in the <i>Proton User guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentAccountConnection service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironmentAccountConnection service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironmentAccountConnection">REST API Reference for UpdateEnvironmentAccountConnection Operation</seealso>
        public virtual UpdateEnvironmentAccountConnectionResponse UpdateEnvironmentAccountConnection(UpdateEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentAccountConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentAccountConnection operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironmentAccountConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironmentAccountConnection">REST API Reference for UpdateEnvironmentAccountConnection Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironmentAccountConnection(UpdateEnvironmentAccountConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironmentAccountConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironmentAccountConnection.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentAccountConnectionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironmentAccountConnection">REST API Reference for UpdateEnvironmentAccountConnection Operation</seealso>
        public virtual UpdateEnvironmentAccountConnectionResponse EndUpdateEnvironmentAccountConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentAccountConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnvironmentTemplate

        /// <summary>
        /// Update an environment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironmentTemplate service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironmentTemplate">REST API Reference for UpdateEnvironmentTemplate Operation</seealso>
        public virtual UpdateEnvironmentTemplateResponse UpdateEnvironmentTemplate(UpdateEnvironmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentTemplate operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironmentTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironmentTemplate">REST API Reference for UpdateEnvironmentTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironmentTemplate(UpdateEnvironmentTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironmentTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironmentTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentTemplateResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironmentTemplate">REST API Reference for UpdateEnvironmentTemplate Operation</seealso>
        public virtual UpdateEnvironmentTemplateResponse EndUpdateEnvironmentTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateEnvironmentTemplateVersion

        /// <summary>
        /// Update a major or minor version of an environment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateEnvironmentTemplateVersion service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironmentTemplateVersion">REST API Reference for UpdateEnvironmentTemplateVersion Operation</seealso>
        public virtual UpdateEnvironmentTemplateVersionResponse UpdateEnvironmentTemplateVersion(UpdateEnvironmentTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentTemplateVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateEnvironmentTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentTemplateVersion operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateEnvironmentTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironmentTemplateVersion">REST API Reference for UpdateEnvironmentTemplateVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateEnvironmentTemplateVersion(UpdateEnvironmentTemplateVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateEnvironmentTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateEnvironmentTemplateVersion.</param>
        /// 
        /// <returns>Returns a  UpdateEnvironmentTemplateVersionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateEnvironmentTemplateVersion">REST API Reference for UpdateEnvironmentTemplateVersion Operation</seealso>
        public virtual UpdateEnvironmentTemplateVersionResponse EndUpdateEnvironmentTemplateVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateEnvironmentTemplateVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateService

        /// <summary>
        /// Edit a service description or use a spec to add and delete service instances.
        /// 
        ///  <note> 
        /// <para>
        /// Existing service instances and the service pipeline <i>can't</i> be edited using this
        /// API. They can only be deleted.
        /// </para>
        ///  </note> 
        /// <para>
        /// Use the <code>description</code> parameter to modify the description.
        /// </para>
        ///  
        /// <para>
        /// Edit the <code>spec</code> parameter to add or delete instances.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't delete a service instance (remove it from the spec) if it has an attached
        /// component.
        /// </para>
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateService service method.</param>
        /// 
        /// <returns>The response from the UpdateService service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ServiceQuotaExceededException">
        /// A quota was exceeded. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-limits.html">Proton
        /// Quotas</a> in the <i>Proton User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateService operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateService operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateService
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual IAsyncResult BeginUpdateService(UpdateServiceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateService operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateService.</param>
        /// 
        /// <returns>Returns a  UpdateServiceResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateService">REST API Reference for UpdateService Operation</seealso>
        public virtual UpdateServiceResponse EndUpdateService(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServiceInstance

        /// <summary>
        /// Update a service instance.
        /// 
        ///  
        /// <para>
        /// There are a few modes for updating a service instance. The <code>deploymentType</code>
        /// field defines the mode.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can't update a service instance while its deployment status, or the deployment
        /// status of a component attached to it, is <code>IN_PROGRESS</code>.
        /// </para>
        ///  
        /// <para>
        /// For more information about components, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-components.html">Proton
        /// components</a> in the <i>Proton User Guide</i>.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceInstance service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceInstance service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServiceInstance">REST API Reference for UpdateServiceInstance Operation</seealso>
        public virtual UpdateServiceInstanceResponse UpdateServiceInstance(UpdateServiceInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceInstanceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceInstance operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServiceInstance">REST API Reference for UpdateServiceInstance Operation</seealso>
        public virtual IAsyncResult BeginUpdateServiceInstance(UpdateServiceInstanceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceInstanceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceInstance.</param>
        /// 
        /// <returns>Returns a  UpdateServiceInstanceResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServiceInstance">REST API Reference for UpdateServiceInstance Operation</seealso>
        public virtual UpdateServiceInstanceResponse EndUpdateServiceInstance(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceInstanceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServicePipeline

        /// <summary>
        /// Update the service pipeline.
        /// 
        ///  
        /// <para>
        /// There are four modes for updating a service pipeline. The <code>deploymentType</code>
        /// field defines the mode.
        /// </para>
        ///  <dl> <dt/> <dd> 
        /// <para>
        ///  <code>NONE</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, a deployment <i>doesn't</i> occur. Only the requested metadata parameters
        /// are updated.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>CURRENT_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the service pipeline is deployed and updated with the new spec that
        /// you provide. Only requested parameters are updated. <i>Don’t</i> include major or
        /// minor version parameters when you use this <code>deployment-type</code>.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>MINOR_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the service pipeline is deployed and updated with the published, recommended
        /// (latest) minor version of the current major version in use, by default. You can specify
        /// a different minor version of the current major version in use.
        /// </para>
        ///  </dd> <dt/> <dd> 
        /// <para>
        ///  <code>MAJOR_VERSION</code> 
        /// </para>
        ///  
        /// <para>
        /// In this mode, the service pipeline is deployed and updated with the published, recommended
        /// (latest) major and minor version of the current template by default. You can specify
        /// a different major version that's higher than the major version in use and a minor
        /// version.
        /// </para>
        ///  </dd> </dl>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServicePipeline service method.</param>
        /// 
        /// <returns>The response from the UpdateServicePipeline service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServicePipeline">REST API Reference for UpdateServicePipeline Operation</seealso>
        public virtual UpdateServicePipelineResponse UpdateServicePipeline(UpdateServicePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServicePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServicePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdateServicePipelineResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServicePipeline operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServicePipeline operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServicePipeline
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServicePipeline">REST API Reference for UpdateServicePipeline Operation</seealso>
        public virtual IAsyncResult BeginUpdateServicePipeline(UpdateServicePipelineRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServicePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServicePipelineResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServicePipeline operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServicePipeline.</param>
        /// 
        /// <returns>Returns a  UpdateServicePipelineResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServicePipeline">REST API Reference for UpdateServicePipeline Operation</seealso>
        public virtual UpdateServicePipelineResponse EndUpdateServicePipeline(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServicePipelineResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServiceTemplate

        /// <summary>
        /// Update a service template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceTemplate service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceTemplate service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServiceTemplate">REST API Reference for UpdateServiceTemplate Operation</seealso>
        public virtual UpdateServiceTemplateResponse UpdateServiceTemplate(UpdateServiceTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceTemplateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceTemplate operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServiceTemplate">REST API Reference for UpdateServiceTemplate Operation</seealso>
        public virtual IAsyncResult BeginUpdateServiceTemplate(UpdateServiceTemplateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceTemplateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceTemplate.</param>
        /// 
        /// <returns>Returns a  UpdateServiceTemplateResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServiceTemplate">REST API Reference for UpdateServiceTemplate Operation</seealso>
        public virtual UpdateServiceTemplateResponse EndUpdateServiceTemplate(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceTemplateResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateServiceTemplateVersion

        /// <summary>
        /// Update a major or minor version of a service template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the UpdateServiceTemplateVersion service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServiceTemplateVersion">REST API Reference for UpdateServiceTemplateVersion Operation</seealso>
        public virtual UpdateServiceTemplateVersionResponse UpdateServiceTemplateVersion(UpdateServiceTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceTemplateVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateServiceTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceTemplateVersion operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateServiceTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServiceTemplateVersion">REST API Reference for UpdateServiceTemplateVersion Operation</seealso>
        public virtual IAsyncResult BeginUpdateServiceTemplateVersion(UpdateServiceTemplateVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceTemplateVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateServiceTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateServiceTemplateVersion.</param>
        /// 
        /// <returns>Returns a  UpdateServiceTemplateVersionResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateServiceTemplateVersion">REST API Reference for UpdateServiceTemplateVersion Operation</seealso>
        public virtual UpdateServiceTemplateVersionResponse EndUpdateServiceTemplateVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateServiceTemplateVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateTemplateSyncConfig

        /// <summary>
        /// Update template sync configuration parameters, except for the <code>templateName</code>
        /// and <code>templateType</code>. Repository details (branch, name, and provider) should
        /// be of a linked repository. A linked repository is a repository that has been registered
        /// with Proton. For more information, see <a>CreateRepository</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateSyncConfig service method.</param>
        /// 
        /// <returns>The response from the UpdateTemplateSyncConfig service method, as returned by Proton.</returns>
        /// <exception cref="Amazon.Proton.Model.AccessDeniedException">
        /// There <i>isn't</i> sufficient access for performing this action.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ConflictException">
        /// The request <i>couldn't</i> be made due to a conflicting operation or resource.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.InternalServerException">
        /// The request failed to register with the service.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ResourceNotFoundException">
        /// The requested resource <i>wasn't</i> found.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.Proton.Model.ValidationException">
        /// The input is invalid or an out-of-range value was supplied for the input parameter.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateTemplateSyncConfig">REST API Reference for UpdateTemplateSyncConfig Operation</seealso>
        public virtual UpdateTemplateSyncConfigResponse UpdateTemplateSyncConfig(UpdateTemplateSyncConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateSyncConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateSyncConfigResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateTemplateSyncConfig operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateSyncConfig operation on AmazonProtonClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateTemplateSyncConfig
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateTemplateSyncConfig">REST API Reference for UpdateTemplateSyncConfig Operation</seealso>
        public virtual IAsyncResult BeginUpdateTemplateSyncConfig(UpdateTemplateSyncConfigRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateSyncConfigResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateTemplateSyncConfig operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateTemplateSyncConfig.</param>
        /// 
        /// <returns>Returns a  UpdateTemplateSyncConfigResult from Proton.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/proton-2020-07-20/UpdateTemplateSyncConfig">REST API Reference for UpdateTemplateSyncConfig Operation</seealso>
        public virtual UpdateTemplateSyncConfigResponse EndUpdateTemplateSyncConfig(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateTemplateSyncConfigResponse>(asyncResult);
        }

        #endregion
        
    }
}