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
 * Do not modify this file. This file is generated from the route53-recovery-control-config-2020-11-02.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Route53RecoveryControlConfig.Model;
using Amazon.Route53RecoveryControlConfig.Model.Internal.MarshallTransformations;
using Amazon.Route53RecoveryControlConfig.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Route53RecoveryControlConfig
{
    /// <summary>
    /// Implementation for accessing Route53RecoveryControlConfig
    ///
    /// Recovery Control Configuration API Reference for Amazon Route 53 Application Recovery
    /// Controller
    /// </summary>
    public partial class AmazonRoute53RecoveryControlConfigClient : AmazonServiceClient, IAmazonRoute53RecoveryControlConfig
    {
        private static IServiceMetadata serviceMetadata = new AmazonRoute53RecoveryControlConfigMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with the credentials loaded from the application's
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
        public AmazonRoute53RecoveryControlConfigClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53RecoveryControlConfigConfig()) { }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with the credentials loaded from the application's
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
        public AmazonRoute53RecoveryControlConfigClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonRoute53RecoveryControlConfigConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonRoute53RecoveryControlConfigClient Configuration Object</param>
        public AmazonRoute53RecoveryControlConfigClient(AmazonRoute53RecoveryControlConfigConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonRoute53RecoveryControlConfigClient(AWSCredentials credentials)
            : this(credentials, new AmazonRoute53RecoveryControlConfigConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53RecoveryControlConfigClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonRoute53RecoveryControlConfigConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with AWS Credentials and an
        /// AmazonRoute53RecoveryControlConfigClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonRoute53RecoveryControlConfigClient Configuration Object</param>
        public AmazonRoute53RecoveryControlConfigClient(AWSCredentials credentials, AmazonRoute53RecoveryControlConfigConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonRoute53RecoveryControlConfigClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53RecoveryControlConfigConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53RecoveryControlConfigClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonRoute53RecoveryControlConfigConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53RecoveryControlConfigClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonRoute53RecoveryControlConfigClient Configuration Object</param>
        public AmazonRoute53RecoveryControlConfigClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonRoute53RecoveryControlConfigConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonRoute53RecoveryControlConfigClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53RecoveryControlConfigConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonRoute53RecoveryControlConfigClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonRoute53RecoveryControlConfigConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonRoute53RecoveryControlConfigClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonRoute53RecoveryControlConfigClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonRoute53RecoveryControlConfigClient Configuration Object</param>
        public AmazonRoute53RecoveryControlConfigClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonRoute53RecoveryControlConfigConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IRoute53RecoveryControlConfigPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IRoute53RecoveryControlConfigPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new Route53RecoveryControlConfigPaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonRoute53RecoveryControlConfigEndpointResolver());
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


        #region  CreateCluster

        internal virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }



        /// <summary>
        /// Create a new cluster. A cluster is a set of redundant Regional endpoints against which
        /// you can run API calls to update or get the state of one or more routing controls.
        /// Each cluster has a name, status, Amazon Resource Name (ARN), and an array of the five
        /// cluster endpoints (one for each supported Amazon Web Services Region) that you can
        /// use with API calls to the cluster data plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCluster service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ServiceQuotaExceededException">
        /// 402 response - You attempted to create more resources than the service allows based
        /// on service quotas.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual Task<CreateClusterResponse> CreateClusterAsync(CreateClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateControlPanel

        internal virtual CreateControlPanelResponse CreateControlPanel(CreateControlPanelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateControlPanelResponseUnmarshaller.Instance;

            return Invoke<CreateControlPanelResponse>(request, options);
        }



        /// <summary>
        /// Creates a new control panel. A control panel represents a group of routing controls
        /// that can be changed together in a single transaction. You can use a control panel
        /// to centrally view the operational status of applications across your organization,
        /// and trigger multi-app failovers in a single transaction, for example, to fail over
        /// an Availability Zone or Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateControlPanel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ServiceQuotaExceededException">
        /// 402 response - You attempted to create more resources than the service allows based
        /// on service quotas.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateControlPanel">REST API Reference for CreateControlPanel Operation</seealso>
        public virtual Task<CreateControlPanelResponse> CreateControlPanelAsync(CreateControlPanelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateControlPanelResponseUnmarshaller.Instance;

            return InvokeAsync<CreateControlPanelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRoutingControl

        internal virtual CreateRoutingControlResponse CreateRoutingControl(CreateRoutingControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingControlResponseUnmarshaller.Instance;

            return Invoke<CreateRoutingControlResponse>(request, options);
        }



        /// <summary>
        /// Creates a new routing control.
        /// 
        ///  
        /// <para>
        /// A routing control has one of two states: ON and OFF. You can map the routing control
        /// state to the state of an Amazon Route 53 health check, which can be used to control
        /// traffic routing.
        /// </para>
        ///  
        /// <para>
        /// To get or update the routing control state, see the Recovery Cluster (data plane)
        /// API actions for Amazon Route 53 Application Recovery Controller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ServiceQuotaExceededException">
        /// 402 response - You attempted to create more resources than the service allows based
        /// on service quotas.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateRoutingControl">REST API Reference for CreateRoutingControl Operation</seealso>
        public virtual Task<CreateRoutingControlResponse> CreateRoutingControlAsync(CreateRoutingControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingControlResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRoutingControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSafetyRule

        internal virtual CreateSafetyRuleResponse CreateSafetyRule(CreateSafetyRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSafetyRuleResponseUnmarshaller.Instance;

            return Invoke<CreateSafetyRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a safety rule in a control panel. Safety rules let you add safeguards around
        /// changing routing control states, and for enabling and disabling routing controls,
        /// to help prevent unexpected outcomes.
        /// 
        ///  
        /// <para>
        /// There are two types of safety rules: assertion rules and gating rules.
        /// </para>
        ///  
        /// <para>
        /// Assertion rule: An assertion rule enforces that, when you change a routing control
        /// state, that a certain criteria is met. For example, the criteria might be that at
        /// least one routing control state is On after the transaction so that traffic continues
        /// to flow to at least one cell for the application. This ensures that you avoid a fail-open
        /// scenario.
        /// </para>
        ///  
        /// <para>
        /// Gating rule: A gating rule lets you configure a gating routing control as an overall
        /// "on/off" switch for a group of routing controls. Or, you can configure more complex
        /// gating scenarios, for example by configuring multiple gating routing controls.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/r53recovery/latest/dg/routing-control.safety-rules.html">Safety
        /// rules</a> in the Amazon Route 53 Application Recovery Controller Developer Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSafetyRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateSafetyRule">REST API Reference for CreateSafetyRule Operation</seealso>
        public virtual Task<CreateSafetyRuleResponse> CreateSafetyRuleAsync(CreateSafetyRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSafetyRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSafetyRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCluster

        internal virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }



        /// <summary>
        /// Delete a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCluster service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual Task<DeleteClusterResponse> DeleteClusterAsync(DeleteClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteControlPanel

        internal virtual DeleteControlPanelResponse DeleteControlPanel(DeleteControlPanelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteControlPanelResponseUnmarshaller.Instance;

            return Invoke<DeleteControlPanelResponse>(request, options);
        }



        /// <summary>
        /// Deletes a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteControlPanel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteControlPanel">REST API Reference for DeleteControlPanel Operation</seealso>
        public virtual Task<DeleteControlPanelResponse> DeleteControlPanelAsync(DeleteControlPanelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteControlPanelResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteControlPanelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoutingControl

        internal virtual DeleteRoutingControlResponse DeleteRoutingControl(DeleteRoutingControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoutingControlResponseUnmarshaller.Instance;

            return Invoke<DeleteRoutingControlResponse>(request, options);
        }



        /// <summary>
        /// Deletes a routing control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteRoutingControl">REST API Reference for DeleteRoutingControl Operation</seealso>
        public virtual Task<DeleteRoutingControlResponse> DeleteRoutingControlAsync(DeleteRoutingControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoutingControlResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRoutingControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSafetyRule

        internal virtual DeleteSafetyRuleResponse DeleteSafetyRule(DeleteSafetyRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSafetyRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteSafetyRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes a safety rule.
        /// 
        /// /&gt;
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSafetyRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteSafetyRule">REST API Reference for DeleteSafetyRule Operation</seealso>
        public virtual Task<DeleteSafetyRuleResponse> DeleteSafetyRuleAsync(DeleteSafetyRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSafetyRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSafetyRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCluster

        internal virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }



        /// <summary>
        /// Display the details about a cluster. The response includes the cluster name, endpoints,
        /// status, and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCluster service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual Task<DescribeClusterResponse> DescribeClusterAsync(DescribeClusterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClusterResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeControlPanel

        internal virtual DescribeControlPanelResponse DescribeControlPanel(DescribeControlPanelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeControlPanelResponseUnmarshaller.Instance;

            return Invoke<DescribeControlPanelResponse>(request, options);
        }



        /// <summary>
        /// Displays details about a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeControlPanel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeControlPanel">REST API Reference for DescribeControlPanel Operation</seealso>
        public virtual Task<DescribeControlPanelResponse> DescribeControlPanelAsync(DescribeControlPanelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeControlPanelResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeControlPanelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRoutingControl

        internal virtual DescribeRoutingControlResponse DescribeRoutingControl(DescribeRoutingControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoutingControlResponseUnmarshaller.Instance;

            return Invoke<DescribeRoutingControlResponse>(request, options);
        }



        /// <summary>
        /// Displays details about a routing control. A routing control has one of two states:
        /// ON and OFF. You can map the routing control state to the state of an Amazon Route
        /// 53 health check, which can be used to control routing.
        /// 
        ///  
        /// <para>
        /// To get or update the routing control state, see the Recovery Cluster (data plane)
        /// API actions for Amazon Route 53 Application Recovery Controller.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoutingControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeRoutingControl">REST API Reference for DescribeRoutingControl Operation</seealso>
        public virtual Task<DescribeRoutingControlResponse> DescribeRoutingControlAsync(DescribeRoutingControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoutingControlResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRoutingControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSafetyRule

        internal virtual DescribeSafetyRuleResponse DescribeSafetyRule(DescribeSafetyRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSafetyRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeSafetyRuleResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a safety rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSafetyRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeSafetyRule">REST API Reference for DescribeSafetyRule Operation</seealso>
        public virtual Task<DescribeSafetyRuleResponse> DescribeSafetyRuleAsync(DescribeSafetyRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSafetyRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSafetyRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAssociatedRoute53HealthChecks

        internal virtual ListAssociatedRoute53HealthChecksResponse ListAssociatedRoute53HealthChecks(ListAssociatedRoute53HealthChecksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedRoute53HealthChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedRoute53HealthChecksResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedRoute53HealthChecksResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of all Amazon Route 53 health checks associated with a specific routing
        /// control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedRoute53HealthChecks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAssociatedRoute53HealthChecks service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListAssociatedRoute53HealthChecks">REST API Reference for ListAssociatedRoute53HealthChecks Operation</seealso>
        public virtual Task<ListAssociatedRoute53HealthChecksResponse> ListAssociatedRoute53HealthChecksAsync(ListAssociatedRoute53HealthChecksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedRoute53HealthChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedRoute53HealthChecksResponseUnmarshaller.Instance;

            return InvokeAsync<ListAssociatedRoute53HealthChecksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListClusters

        internal virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of all the clusters in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListClusters service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual Task<ListClustersResponse> ListClustersAsync(ListClustersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return InvokeAsync<ListClustersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListControlPanels

        internal virtual ListControlPanelsResponse ListControlPanels(ListControlPanelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlPanelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlPanelsResponseUnmarshaller.Instance;

            return Invoke<ListControlPanelsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of control panels in an account or in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlPanels service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListControlPanels service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListControlPanels">REST API Reference for ListControlPanels Operation</seealso>
        public virtual Task<ListControlPanelsResponse> ListControlPanelsAsync(ListControlPanelsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlPanelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlPanelsResponseUnmarshaller.Instance;

            return InvokeAsync<ListControlPanelsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListRoutingControls

        internal virtual ListRoutingControlsResponse ListRoutingControls(ListRoutingControlsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoutingControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingControlsResponseUnmarshaller.Instance;

            return Invoke<ListRoutingControlsResponse>(request, options);
        }



        /// <summary>
        /// Returns an array of routing controls for a control panel. A routing control is an
        /// Amazon Route 53 Application Recovery Controller construct that has one of two states:
        /// ON and OFF. You can map the routing control state to the state of an Amazon Route
        /// 53 health check, which can be used to control routing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingControls service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListRoutingControls service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListRoutingControls">REST API Reference for ListRoutingControls Operation</seealso>
        public virtual Task<ListRoutingControlsResponse> ListRoutingControlsAsync(ListRoutingControlsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoutingControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingControlsResponseUnmarshaller.Instance;

            return InvokeAsync<ListRoutingControlsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSafetyRules

        internal virtual ListSafetyRulesResponse ListSafetyRules(ListSafetyRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSafetyRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSafetyRulesResponseUnmarshaller.Instance;

            return Invoke<ListSafetyRulesResponse>(request, options);
        }



        /// <summary>
        /// List the safety rules (the assertion rules and gating rules) that you've defined for
        /// the routing controls in a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSafetyRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListSafetyRules service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListSafetyRules">REST API Reference for ListSafetyRules Operation</seealso>
        public virtual Task<ListSafetyRulesResponse> ListSafetyRulesAsync(ListSafetyRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSafetyRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSafetyRulesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSafetyRulesResponse>(request, options, cancellationToken);
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
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
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
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateControlPanel

        internal virtual UpdateControlPanelResponse UpdateControlPanel(UpdateControlPanelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateControlPanelResponseUnmarshaller.Instance;

            return Invoke<UpdateControlPanelResponse>(request, options);
        }



        /// <summary>
        /// Updates a control panel. The only update you can make to a control panel is to change
        /// the name of the control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateControlPanel service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateControlPanel service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateControlPanel">REST API Reference for UpdateControlPanel Operation</seealso>
        public virtual Task<UpdateControlPanelResponse> UpdateControlPanelAsync(UpdateControlPanelRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateControlPanelResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateControlPanelResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateRoutingControl

        internal virtual UpdateRoutingControlResponse UpdateRoutingControl(UpdateRoutingControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingControlResponseUnmarshaller.Instance;

            return Invoke<UpdateRoutingControlResponse>(request, options);
        }



        /// <summary>
        /// Updates a routing control. You can only update the name of the routing control. To
        /// get or update the routing control state, see the Recovery Cluster (data plane) API
        /// actions for Amazon Route 53 Application Recovery Controller.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControl service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateRoutingControl service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.AccessDeniedException">
        /// 403 response - You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ConflictException">
        /// 409 response - ConflictException. You might be using a predefined variable.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ThrottlingException">
        /// 429 response - LimitExceededException or TooManyRequestsException.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateRoutingControl">REST API Reference for UpdateRoutingControl Operation</seealso>
        public virtual Task<UpdateRoutingControlResponse> UpdateRoutingControlAsync(UpdateRoutingControlRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingControlResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRoutingControlResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSafetyRule

        internal virtual UpdateSafetyRuleResponse UpdateSafetyRule(UpdateSafetyRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSafetyRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateSafetyRuleResponse>(request, options);
        }



        /// <summary>
        /// Update a safety rule (an assertion rule or gating rule). You can only update the name
        /// and the waiting period for a safety rule. To make other updates, delete the safety
        /// rule and create a new one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSafetyRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSafetyRule service method, as returned by Route53RecoveryControlConfig.</returns>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.InternalServerException">
        /// 500 response - InternalServiceError. Temporary service error. Retry the request.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ResourceNotFoundException">
        /// 404 response - MalformedQueryString. The query string contains a syntax error or resource
        /// not found.
        /// </exception>
        /// <exception cref="Amazon.Route53RecoveryControlConfig.Model.ValidationException">
        /// 400 response - Multiple causes. For example, you might have a malformed query string
        /// and input parameter might be out of range, or you might have used parameters together
        /// incorrectly.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateSafetyRule">REST API Reference for UpdateSafetyRule Operation</seealso>
        public virtual Task<UpdateSafetyRuleResponse> UpdateSafetyRuleAsync(UpdateSafetyRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSafetyRuleResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSafetyRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}