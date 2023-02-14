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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
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
#if AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
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

        internal virtual AcceptEnvironmentAccountConnectionResponse AcceptEnvironmentAccountConnection(AcceptEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<AcceptEnvironmentAccountConnectionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<AcceptEnvironmentAccountConnectionResponse> AcceptEnvironmentAccountConnectionAsync(AcceptEnvironmentAccountConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptEnvironmentAccountConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelComponentDeployment

        internal virtual CancelComponentDeploymentResponse CancelComponentDeployment(CancelComponentDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelComponentDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelComponentDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelComponentDeploymentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelComponentDeploymentResponse> CancelComponentDeploymentAsync(CancelComponentDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelComponentDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelComponentDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CancelComponentDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelEnvironmentDeployment

        internal virtual CancelEnvironmentDeploymentResponse CancelEnvironmentDeployment(CancelEnvironmentDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelEnvironmentDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelEnvironmentDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelEnvironmentDeploymentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelEnvironmentDeploymentResponse> CancelEnvironmentDeploymentAsync(CancelEnvironmentDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelEnvironmentDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelEnvironmentDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CancelEnvironmentDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelServiceInstanceDeployment

        internal virtual CancelServiceInstanceDeploymentResponse CancelServiceInstanceDeployment(CancelServiceInstanceDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelServiceInstanceDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelServiceInstanceDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelServiceInstanceDeploymentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelServiceInstanceDeploymentResponse> CancelServiceInstanceDeploymentAsync(CancelServiceInstanceDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelServiceInstanceDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelServiceInstanceDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CancelServiceInstanceDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelServicePipelineDeployment

        internal virtual CancelServicePipelineDeploymentResponse CancelServicePipelineDeployment(CancelServicePipelineDeploymentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelServicePipelineDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelServicePipelineDeploymentResponseUnmarshaller.Instance;

            return Invoke<CancelServicePipelineDeploymentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CancelServicePipelineDeploymentResponse> CancelServicePipelineDeploymentAsync(CancelServicePipelineDeploymentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelServicePipelineDeploymentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelServicePipelineDeploymentResponseUnmarshaller.Instance;

            return InvokeAsync<CancelServicePipelineDeploymentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateComponent

        internal virtual CreateComponentResponse CreateComponent(CreateComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return Invoke<CreateComponentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateComponentResponse> CreateComponentAsync(CreateComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateComponentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironment

        internal virtual CreateEnvironmentResponse CreateEnvironment(CreateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateEnvironmentResponse> CreateEnvironmentAsync(CreateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironmentAccountConnection

        internal virtual CreateEnvironmentAccountConnectionResponse CreateEnvironmentAccountConnection(CreateEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentAccountConnectionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateEnvironmentAccountConnectionResponse> CreateEnvironmentAccountConnectionAsync(CreateEnvironmentAccountConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentAccountConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironmentTemplate

        internal virtual CreateEnvironmentTemplateResponse CreateEnvironmentTemplate(CreateEnvironmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentTemplateResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateEnvironmentTemplateResponse> CreateEnvironmentTemplateAsync(CreateEnvironmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEnvironmentTemplateVersion

        internal virtual CreateEnvironmentTemplateVersionResponse CreateEnvironmentTemplateVersion(CreateEnvironmentTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<CreateEnvironmentTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Create a new major or minor version of an environment template. A major version of
        /// an environment template is a version that <i>isn't</i> backwards compatible. A minor
        /// version of an environment template is a version that's backwards compatible within
        /// its major version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEnvironmentTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateEnvironmentTemplateVersionResponse> CreateEnvironmentTemplateVersionAsync(CreateEnvironmentTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEnvironmentTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRepository

        internal virtual CreateRepositoryResponse CreateRepository(CreateRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return Invoke<CreateRepositoryResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateService

        internal virtual CreateServiceResponse CreateService(CreateServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return Invoke<CreateServiceResponse>(request, options);
        }



        /// <summary>
        /// Create an Proton service. An Proton service is an instantiation of a service template
        /// and often includes several service instances and pipeline. For more information, see
        /// <a href="https://docs.aws.amazon.com/proton/latest/userguide/ag-services.html">Services</a>
        /// in the <i>Proton User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateServiceResponse> CreateServiceAsync(CreateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceTemplate

        internal virtual CreateServiceTemplateResponse CreateServiceTemplate(CreateServiceTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateServiceTemplateResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateServiceTemplateResponse> CreateServiceTemplateAsync(CreateServiceTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServiceTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateServiceTemplateVersion

        internal virtual CreateServiceTemplateVersionResponse CreateServiceTemplateVersion(CreateServiceTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<CreateServiceTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Create a new major or minor version of a service template. A major version of a service
        /// template is a version that <i>isn't</i> backward compatible. A minor version of a
        /// service template is a version that's backward compatible within its major version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateServiceTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateServiceTemplateVersionResponse> CreateServiceTemplateVersionAsync(CreateServiceTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateServiceTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateServiceTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTemplateSyncConfig

        internal virtual CreateTemplateSyncConfigResponse CreateTemplateSyncConfig(CreateTemplateSyncConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateSyncConfigResponseUnmarshaller.Instance;

            return Invoke<CreateTemplateSyncConfigResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<CreateTemplateSyncConfigResponse> CreateTemplateSyncConfigAsync(CreateTemplateSyncConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTemplateSyncConfigResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTemplateSyncConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteComponent

        internal virtual DeleteComponentResponse DeleteComponent(DeleteComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return Invoke<DeleteComponentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteComponentResponse> DeleteComponentAsync(DeleteComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteComponentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironment

        internal virtual DeleteEnvironmentResponse DeleteEnvironment(DeleteEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Delete an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteEnvironmentResponse> DeleteEnvironmentAsync(DeleteEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironmentAccountConnection

        internal virtual DeleteEnvironmentAccountConnectionResponse DeleteEnvironmentAccountConnection(DeleteEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentAccountConnectionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteEnvironmentAccountConnectionResponse> DeleteEnvironmentAccountConnectionAsync(DeleteEnvironmentAccountConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentAccountConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironmentTemplate

        internal virtual DeleteEnvironmentTemplateResponse DeleteEnvironmentTemplate(DeleteEnvironmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentTemplateResponse>(request, options);
        }



        /// <summary>
        /// If no other major or minor versions of an environment template exist, delete the environment
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEnvironmentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteEnvironmentTemplateResponse> DeleteEnvironmentTemplateAsync(DeleteEnvironmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEnvironmentTemplateVersion

        internal virtual DeleteEnvironmentTemplateVersionResponse DeleteEnvironmentTemplateVersion(DeleteEnvironmentTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteEnvironmentTemplateVersionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteEnvironmentTemplateVersionResponse> DeleteEnvironmentTemplateVersionAsync(DeleteEnvironmentTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEnvironmentTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRepository

        internal virtual DeleteRepositoryResponse DeleteRepository(DeleteRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return Invoke<DeleteRepositoryResponse>(request, options);
        }



        /// <summary>
        /// De-register and unlink your repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteService

        internal virtual DeleteServiceResponse DeleteService(DeleteServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteServiceResponse> DeleteServiceAsync(DeleteServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceTemplate

        internal virtual DeleteServiceTemplateResponse DeleteServiceTemplate(DeleteServiceTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceTemplateResponse>(request, options);
        }



        /// <summary>
        /// If no other major or minor versions of the service template exist, delete the service
        /// template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteServiceTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteServiceTemplateResponse> DeleteServiceTemplateAsync(DeleteServiceTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServiceTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteServiceTemplateVersion

        internal virtual DeleteServiceTemplateVersionResponse DeleteServiceTemplateVersion(DeleteServiceTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteServiceTemplateVersionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteServiceTemplateVersionResponse> DeleteServiceTemplateVersionAsync(DeleteServiceTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteServiceTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteServiceTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTemplateSyncConfig

        internal virtual DeleteTemplateSyncConfigResponse DeleteTemplateSyncConfig(DeleteTemplateSyncConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateSyncConfigResponseUnmarshaller.Instance;

            return Invoke<DeleteTemplateSyncConfigResponse>(request, options);
        }



        /// <summary>
        /// Delete a template sync configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTemplateSyncConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<DeleteTemplateSyncConfigResponse> DeleteTemplateSyncConfigAsync(DeleteTemplateSyncConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTemplateSyncConfigResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTemplateSyncConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetAccountSettings

        internal virtual GetAccountSettingsResponse GetAccountSettings(GetAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<GetAccountSettingsResponse>(request, options);
        }



        /// <summary>
        /// Get detail data for Proton account-wide settings.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetAccountSettingsResponse> GetAccountSettingsAsync(GetAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<GetAccountSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetComponent

        internal virtual GetComponentResponse GetComponent(GetComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return Invoke<GetComponentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetComponentResponse> GetComponentAsync(GetComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetComponentResponseUnmarshaller.Instance;

            return InvokeAsync<GetComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnvironment

        internal virtual GetEnvironmentResponse GetEnvironment(GetEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentResponse>(request, options);
        }



        /// <summary>
        /// Get detailed data for an environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetEnvironmentResponse> GetEnvironmentAsync(GetEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnvironmentAccountConnection

        internal virtual GetEnvironmentAccountConnectionResponse GetEnvironmentAccountConnection(GetEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentAccountConnectionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetEnvironmentAccountConnectionResponse> GetEnvironmentAccountConnectionAsync(GetEnvironmentAccountConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentAccountConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnvironmentTemplate

        internal virtual GetEnvironmentTemplateResponse GetEnvironmentTemplate(GetEnvironmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentTemplateResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentTemplateResponse>(request, options);
        }



        /// <summary>
        /// Get detailed data for an environment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetEnvironmentTemplateResponse> GetEnvironmentTemplateAsync(GetEnvironmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetEnvironmentTemplateVersion

        internal virtual GetEnvironmentTemplateVersionResponse GetEnvironmentTemplateVersion(GetEnvironmentTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<GetEnvironmentTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Get detailed data for a major or minor version of an environment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetEnvironmentTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetEnvironmentTemplateVersionResponse> GetEnvironmentTemplateVersionAsync(GetEnvironmentTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetEnvironmentTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepository

        internal virtual GetRepositoryResponse GetRepository(GetRepositoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryResponseUnmarshaller.Instance;

            return Invoke<GetRepositoryResponse>(request, options);
        }



        /// <summary>
        /// Get detail data for a linked repository.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRepository service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetRepositoryResponse> GetRepositoryAsync(GetRepositoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositoryResponseUnmarshaller.Instance;

            return InvokeAsync<GetRepositoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRepositorySyncStatus

        internal virtual GetRepositorySyncStatusResponse GetRepositorySyncStatus(GetRepositorySyncStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositorySyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositorySyncStatusResponseUnmarshaller.Instance;

            return Invoke<GetRepositorySyncStatusResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetRepositorySyncStatusResponse> GetRepositorySyncStatusAsync(GetRepositorySyncStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRepositorySyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRepositorySyncStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetRepositorySyncStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcesSummary

        internal virtual GetResourcesSummaryResponse GetResourcesSummary(GetResourcesSummaryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcesSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesSummaryResponseUnmarshaller.Instance;

            return Invoke<GetResourcesSummaryResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetResourcesSummaryResponse> GetResourcesSummaryAsync(GetResourcesSummaryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcesSummaryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcesSummaryResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcesSummaryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetService

        internal virtual GetServiceResponse GetService(GetServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return Invoke<GetServiceResponse>(request, options);
        }



        /// <summary>
        /// Get detailed data for a service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetService service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetServiceResponse> GetServiceAsync(GetServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceInstance

        internal virtual GetServiceInstanceResponse GetServiceInstance(GetServiceInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceInstanceResponseUnmarshaller.Instance;

            return Invoke<GetServiceInstanceResponse>(request, options);
        }



        /// <summary>
        /// Get detailed data for a service instance. A service instance is an instantiation of
        /// service template and it runs in a specific environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceInstance service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetServiceInstanceResponse> GetServiceInstanceAsync(GetServiceInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceTemplate

        internal virtual GetServiceTemplateResponse GetServiceTemplate(GetServiceTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceTemplateResponseUnmarshaller.Instance;

            return Invoke<GetServiceTemplateResponse>(request, options);
        }



        /// <summary>
        /// Get detailed data for a service template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetServiceTemplateResponse> GetServiceTemplateAsync(GetServiceTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetServiceTemplateVersion

        internal virtual GetServiceTemplateVersionResponse GetServiceTemplateVersion(GetServiceTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<GetServiceTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Get detailed data for a major or minor version of a service template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetServiceTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetServiceTemplateVersionResponse> GetServiceTemplateVersionAsync(GetServiceTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetServiceTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<GetServiceTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTemplateSyncConfig

        internal virtual GetTemplateSyncConfigResponse GetTemplateSyncConfig(GetTemplateSyncConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSyncConfigResponseUnmarshaller.Instance;

            return Invoke<GetTemplateSyncConfigResponse>(request, options);
        }



        /// <summary>
        /// Get detail data for a template sync configuration.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSyncConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetTemplateSyncConfigResponse> GetTemplateSyncConfigAsync(GetTemplateSyncConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSyncConfigResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateSyncConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTemplateSyncStatus

        internal virtual GetTemplateSyncStatusResponse GetTemplateSyncStatus(GetTemplateSyncStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSyncStatusResponseUnmarshaller.Instance;

            return Invoke<GetTemplateSyncStatusResponse>(request, options);
        }



        /// <summary>
        /// Get the status of a template sync.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTemplateSyncStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<GetTemplateSyncStatusResponse> GetTemplateSyncStatusAsync(GetTemplateSyncStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTemplateSyncStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTemplateSyncStatusResponseUnmarshaller.Instance;

            return InvokeAsync<GetTemplateSyncStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListComponentOutputs

        internal virtual ListComponentOutputsResponse ListComponentOutputs(ListComponentOutputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentOutputsResponseUnmarshaller.Instance;

            return Invoke<ListComponentOutputsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListComponentOutputsResponse> ListComponentOutputsAsync(ListComponentOutputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentOutputsResponseUnmarshaller.Instance;

            return InvokeAsync<ListComponentOutputsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListComponentProvisionedResources

        internal virtual ListComponentProvisionedResourcesResponse ListComponentProvisionedResources(ListComponentProvisionedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentProvisionedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListComponentProvisionedResourcesResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListComponentProvisionedResourcesResponse> ListComponentProvisionedResourcesAsync(ListComponentProvisionedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentProvisionedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListComponentProvisionedResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListComponents

        internal virtual ListComponentsResponse ListComponents(ListComponentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return Invoke<ListComponentsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListComponentsResponse> ListComponentsAsync(ListComponentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListComponentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListComponentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListComponentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironmentAccountConnections

        internal virtual ListEnvironmentAccountConnectionsResponse ListEnvironmentAccountConnections(ListEnvironmentAccountConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentAccountConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentAccountConnectionsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentAccountConnectionsResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEnvironmentAccountConnectionsResponse> ListEnvironmentAccountConnectionsAsync(ListEnvironmentAccountConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentAccountConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentAccountConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentAccountConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironmentOutputs

        internal virtual ListEnvironmentOutputsResponse ListEnvironmentOutputs(ListEnvironmentOutputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentOutputsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentOutputsResponse>(request, options);
        }



        /// <summary>
        /// List the infrastructure as code outputs for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentOutputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEnvironmentOutputsResponse> ListEnvironmentOutputsAsync(ListEnvironmentOutputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentOutputsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentOutputsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironmentProvisionedResources

        internal virtual ListEnvironmentProvisionedResourcesResponse ListEnvironmentProvisionedResources(ListEnvironmentProvisionedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentProvisionedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentProvisionedResourcesResponse>(request, options);
        }



        /// <summary>
        /// List the provisioned resources for your environment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentProvisionedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEnvironmentProvisionedResourcesResponse> ListEnvironmentProvisionedResourcesAsync(ListEnvironmentProvisionedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentProvisionedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentProvisionedResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironments

        internal virtual ListEnvironmentsResponse ListEnvironments(ListEnvironmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentsResponse>(request, options);
        }



        /// <summary>
        /// List environments with detail data summaries.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEnvironmentsResponse> ListEnvironmentsAsync(ListEnvironmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironmentTemplates

        internal virtual ListEnvironmentTemplatesResponse ListEnvironmentTemplates(ListEnvironmentTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentTemplatesResponse>(request, options);
        }



        /// <summary>
        /// List environment templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEnvironmentTemplatesResponse> ListEnvironmentTemplatesAsync(ListEnvironmentTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListEnvironmentTemplateVersions

        internal virtual ListEnvironmentTemplateVersionsResponse ListEnvironmentTemplateVersions(ListEnvironmentTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<ListEnvironmentTemplateVersionsResponse>(request, options);
        }



        /// <summary>
        /// List major or minor versions of an environment template with detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListEnvironmentTemplateVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListEnvironmentTemplateVersionsResponse> ListEnvironmentTemplateVersionsAsync(ListEnvironmentTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListEnvironmentTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListEnvironmentTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListEnvironmentTemplateVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRepositories

        internal virtual ListRepositoriesResponse ListRepositories(ListRepositoriesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return Invoke<ListRepositoriesResponse>(request, options);
        }



        /// <summary>
        /// List linked repositories with detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositories service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListRepositoriesResponse> ListRepositoriesAsync(ListRepositoriesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositoriesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositoriesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRepositoriesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRepositorySyncDefinitions

        internal virtual ListRepositorySyncDefinitionsResponse ListRepositorySyncDefinitions(ListRepositorySyncDefinitionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositorySyncDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositorySyncDefinitionsResponseUnmarshaller.Instance;

            return Invoke<ListRepositorySyncDefinitionsResponse>(request, options);
        }



        /// <summary>
        /// List repository sync definitions with detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRepositorySyncDefinitions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListRepositorySyncDefinitionsResponse> ListRepositorySyncDefinitionsAsync(ListRepositorySyncDefinitionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRepositorySyncDefinitionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRepositorySyncDefinitionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRepositorySyncDefinitionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceInstanceOutputs

        internal virtual ListServiceInstanceOutputsResponse ListServiceInstanceOutputs(ListServiceInstanceOutputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstanceOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstanceOutputsResponseUnmarshaller.Instance;

            return Invoke<ListServiceInstanceOutputsResponse>(request, options);
        }



        /// <summary>
        /// Get a list service of instance Infrastructure as Code (IaC) outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceInstanceOutputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListServiceInstanceOutputsResponse> ListServiceInstanceOutputsAsync(ListServiceInstanceOutputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstanceOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstanceOutputsResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceInstanceOutputsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceInstanceProvisionedResources

        internal virtual ListServiceInstanceProvisionedResourcesResponse ListServiceInstanceProvisionedResources(ListServiceInstanceProvisionedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstanceProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstanceProvisionedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListServiceInstanceProvisionedResourcesResponse>(request, options);
        }



        /// <summary>
        /// List provisioned resources for a service instance with details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceInstanceProvisionedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListServiceInstanceProvisionedResourcesResponse> ListServiceInstanceProvisionedResourcesAsync(ListServiceInstanceProvisionedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstanceProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstanceProvisionedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceInstanceProvisionedResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceInstances

        internal virtual ListServiceInstancesResponse ListServiceInstances(ListServiceInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstancesResponseUnmarshaller.Instance;

            return Invoke<ListServiceInstancesResponse>(request, options);
        }



        /// <summary>
        /// List service instances with summary data. This action lists service instances of all
        /// services in the Amazon Web Services account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceInstances service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListServiceInstancesResponse> ListServiceInstancesAsync(ListServiceInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServicePipelineOutputs

        internal virtual ListServicePipelineOutputsResponse ListServicePipelineOutputs(ListServicePipelineOutputsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicePipelineOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePipelineOutputsResponseUnmarshaller.Instance;

            return Invoke<ListServicePipelineOutputsResponse>(request, options);
        }



        /// <summary>
        /// Get a list of service pipeline Infrastructure as Code (IaC) outputs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicePipelineOutputs service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListServicePipelineOutputsResponse> ListServicePipelineOutputsAsync(ListServicePipelineOutputsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicePipelineOutputsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePipelineOutputsResponseUnmarshaller.Instance;

            return InvokeAsync<ListServicePipelineOutputsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServicePipelineProvisionedResources

        internal virtual ListServicePipelineProvisionedResourcesResponse ListServicePipelineProvisionedResources(ListServicePipelineProvisionedResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicePipelineProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePipelineProvisionedResourcesResponseUnmarshaller.Instance;

            return Invoke<ListServicePipelineProvisionedResourcesResponse>(request, options);
        }



        /// <summary>
        /// List provisioned resources for a service and pipeline with details.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServicePipelineProvisionedResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListServicePipelineProvisionedResourcesResponse> ListServicePipelineProvisionedResourcesAsync(ListServicePipelineProvisionedResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicePipelineProvisionedResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicePipelineProvisionedResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServicePipelineProvisionedResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServices

        internal virtual ListServicesResponse ListServices(ListServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return Invoke<ListServicesResponse>(request, options);
        }



        /// <summary>
        /// List services with summaries of detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListServicesResponse> ListServicesAsync(ListServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServicesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceTemplates

        internal virtual ListServiceTemplatesResponse ListServiceTemplates(ListServiceTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceTemplatesResponseUnmarshaller.Instance;

            return Invoke<ListServiceTemplatesResponse>(request, options);
        }



        /// <summary>
        /// List service templates with detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceTemplates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListServiceTemplatesResponse> ListServiceTemplatesAsync(ListServiceTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListServiceTemplateVersions

        internal virtual ListServiceTemplateVersionsResponse ListServiceTemplateVersions(ListServiceTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<ListServiceTemplateVersionsResponse>(request, options);
        }



        /// <summary>
        /// List major or minor versions of a service template with detail data.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListServiceTemplateVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListServiceTemplateVersionsResponse> ListServiceTemplateVersionsAsync(ListServiceTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListServiceTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListServiceTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListServiceTemplateVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// List tags for a resource. For more information, see <a href="https://docs.aws.amazon.com/proton/latest/userguide/resources.html">Proton
        /// resources and tagging</a> in the <i>Proton User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  NotifyResourceDeploymentStatusChange

        internal virtual NotifyResourceDeploymentStatusChangeResponse NotifyResourceDeploymentStatusChange(NotifyResourceDeploymentStatusChangeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyResourceDeploymentStatusChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyResourceDeploymentStatusChangeResponseUnmarshaller.Instance;

            return Invoke<NotifyResourceDeploymentStatusChangeResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<NotifyResourceDeploymentStatusChangeResponse> NotifyResourceDeploymentStatusChangeAsync(NotifyResourceDeploymentStatusChangeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = NotifyResourceDeploymentStatusChangeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = NotifyResourceDeploymentStatusChangeResponseUnmarshaller.Instance;

            return InvokeAsync<NotifyResourceDeploymentStatusChangeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectEnvironmentAccountConnection

        internal virtual RejectEnvironmentAccountConnectionResponse RejectEnvironmentAccountConnection(RejectEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectEnvironmentAccountConnectionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<RejectEnvironmentAccountConnectionResponse> RejectEnvironmentAccountConnectionAsync(RejectEnvironmentAccountConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<RejectEnvironmentAccountConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateAccountSettings

        internal virtual UpdateAccountSettingsResponse UpdateAccountSettings(UpdateAccountSettingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return Invoke<UpdateAccountSettingsResponse>(request, options);
        }



        /// <summary>
        /// Update Proton settings that are used for multiple services in the Amazon Web Services
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateAccountSettings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateAccountSettingsResponse> UpdateAccountSettingsAsync(UpdateAccountSettingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateAccountSettingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateAccountSettingsResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateAccountSettingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateComponent

        internal virtual UpdateComponentResponse UpdateComponent(UpdateComponentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return Invoke<UpdateComponentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateComponentResponse> UpdateComponentAsync(UpdateComponentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateComponentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateComponentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateComponentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironment

        internal virtual UpdateEnvironmentResponse UpdateEnvironment(UpdateEnvironmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateEnvironmentResponse> UpdateEnvironmentAsync(UpdateEnvironmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironmentAccountConnection

        internal virtual UpdateEnvironmentAccountConnectionResponse UpdateEnvironmentAccountConnection(UpdateEnvironmentAccountConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentAccountConnectionResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateEnvironmentAccountConnectionResponse> UpdateEnvironmentAccountConnectionAsync(UpdateEnvironmentAccountConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentAccountConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentAccountConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentAccountConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironmentTemplate

        internal virtual UpdateEnvironmentTemplateResponse UpdateEnvironmentTemplate(UpdateEnvironmentTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentTemplateResponse>(request, options);
        }



        /// <summary>
        /// Update an environment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateEnvironmentTemplateResponse> UpdateEnvironmentTemplateAsync(UpdateEnvironmentTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateEnvironmentTemplateVersion

        internal virtual UpdateEnvironmentTemplateVersionResponse UpdateEnvironmentTemplateVersion(UpdateEnvironmentTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateEnvironmentTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Update a major or minor version of an environment template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateEnvironmentTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateEnvironmentTemplateVersionResponse> UpdateEnvironmentTemplateVersionAsync(UpdateEnvironmentTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateEnvironmentTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateEnvironmentTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateEnvironmentTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateService

        internal virtual UpdateServiceResponse UpdateService(UpdateServiceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateServiceResponse> UpdateServiceAsync(UpdateServiceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceInstance

        internal virtual UpdateServiceInstanceResponse UpdateServiceInstance(UpdateServiceInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceInstanceResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceInstanceResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateServiceInstanceResponse> UpdateServiceInstanceAsync(UpdateServiceInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServicePipeline

        internal virtual UpdateServicePipelineResponse UpdateServicePipeline(UpdateServicePipelineRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServicePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServicePipelineResponseUnmarshaller.Instance;

            return Invoke<UpdateServicePipelineResponse>(request, options);
        }



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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateServicePipelineResponse> UpdateServicePipelineAsync(UpdateServicePipelineRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServicePipelineRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServicePipelineResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServicePipelineResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceTemplate

        internal virtual UpdateServiceTemplateResponse UpdateServiceTemplate(UpdateServiceTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceTemplateResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceTemplateResponse>(request, options);
        }



        /// <summary>
        /// Update a service template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceTemplate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateServiceTemplateResponse> UpdateServiceTemplateAsync(UpdateServiceTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateServiceTemplateVersion

        internal virtual UpdateServiceTemplateVersionResponse UpdateServiceTemplateVersion(UpdateServiceTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<UpdateServiceTemplateVersionResponse>(request, options);
        }



        /// <summary>
        /// Update a major or minor version of a service template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateServiceTemplateVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateServiceTemplateVersionResponse> UpdateServiceTemplateVersionAsync(UpdateServiceTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateServiceTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateServiceTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateServiceTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateTemplateSyncConfig

        internal virtual UpdateTemplateSyncConfigResponse UpdateTemplateSyncConfig(UpdateTemplateSyncConfigRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateSyncConfigResponseUnmarshaller.Instance;

            return Invoke<UpdateTemplateSyncConfigResponse>(request, options);
        }



        /// <summary>
        /// Update template sync configuration parameters, except for the <code>templateName</code>
        /// and <code>templateType</code>. Repository details (branch, name, and provider) should
        /// be of a linked repository. A linked repository is a repository that has been registered
        /// with Proton. For more information, see <a>CreateRepository</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateTemplateSyncConfig service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
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
        public virtual Task<UpdateTemplateSyncConfigResponse> UpdateTemplateSyncConfigAsync(UpdateTemplateSyncConfigRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateTemplateSyncConfigRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateTemplateSyncConfigResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateTemplateSyncConfigResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}