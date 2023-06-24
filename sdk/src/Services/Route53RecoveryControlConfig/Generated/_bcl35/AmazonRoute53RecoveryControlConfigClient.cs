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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        /// <summary>
        /// Create a new cluster. A cluster is a set of redundant Regional endpoints against which
        /// you can run API calls to update or get the state of one or more routing controls.
        /// Each cluster has a name, status, Amazon Resource Name (ARN), and an array of the five
        /// cluster endpoints (one for each supported Amazon Web Services Region) that you can
        /// use with API calls to the cluster data plane.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster service method.</param>
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
        public virtual CreateClusterResponse CreateCluster(CreateClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return Invoke<CreateClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCluster operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual IAsyncResult BeginCreateCluster(CreateClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCluster.</param>
        /// 
        /// <returns>Returns a  CreateClusterResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateCluster">REST API Reference for CreateCluster Operation</seealso>
        public virtual CreateClusterResponse EndCreateCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateControlPanel

        /// <summary>
        /// Creates a new control panel. A control panel represents a group of routing controls
        /// that can be changed together in a single transaction. You can use a control panel
        /// to centrally view the operational status of applications across your organization,
        /// and trigger multi-app failovers in a single transaction, for example, to fail over
        /// an Availability Zone or Amazon Web Services Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateControlPanel service method.</param>
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
        public virtual CreateControlPanelResponse CreateControlPanel(CreateControlPanelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateControlPanelResponseUnmarshaller.Instance;

            return Invoke<CreateControlPanelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateControlPanel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateControlPanel operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateControlPanel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateControlPanel">REST API Reference for CreateControlPanel Operation</seealso>
        public virtual IAsyncResult BeginCreateControlPanel(CreateControlPanelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateControlPanelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateControlPanel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateControlPanel.</param>
        /// 
        /// <returns>Returns a  CreateControlPanelResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateControlPanel">REST API Reference for CreateControlPanel Operation</seealso>
        public virtual CreateControlPanelResponse EndCreateControlPanel(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateControlPanelResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateRoutingControl

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
        public virtual CreateRoutingControlResponse CreateRoutingControl(CreateRoutingControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingControlResponseUnmarshaller.Instance;

            return Invoke<CreateRoutingControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoutingControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoutingControl operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoutingControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateRoutingControl">REST API Reference for CreateRoutingControl Operation</seealso>
        public virtual IAsyncResult BeginCreateRoutingControl(CreateRoutingControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRoutingControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoutingControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoutingControl.</param>
        /// 
        /// <returns>Returns a  CreateRoutingControlResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateRoutingControl">REST API Reference for CreateRoutingControl Operation</seealso>
        public virtual CreateRoutingControlResponse EndCreateRoutingControl(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateRoutingControlResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSafetyRule

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
        public virtual CreateSafetyRuleResponse CreateSafetyRule(CreateSafetyRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSafetyRuleResponseUnmarshaller.Instance;

            return Invoke<CreateSafetyRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSafetyRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSafetyRule operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSafetyRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateSafetyRule">REST API Reference for CreateSafetyRule Operation</seealso>
        public virtual IAsyncResult BeginCreateSafetyRule(CreateSafetyRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSafetyRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSafetyRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSafetyRule.</param>
        /// 
        /// <returns>Returns a  CreateSafetyRuleResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/CreateSafetyRule">REST API Reference for CreateSafetyRule Operation</seealso>
        public virtual CreateSafetyRuleResponse EndCreateSafetyRule(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSafetyRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCluster

        /// <summary>
        /// Delete a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster service method.</param>
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
        public virtual DeleteClusterResponse DeleteCluster(DeleteClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return Invoke<DeleteClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCluster operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual IAsyncResult BeginDeleteCluster(DeleteClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCluster.</param>
        /// 
        /// <returns>Returns a  DeleteClusterResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteCluster">REST API Reference for DeleteCluster Operation</seealso>
        public virtual DeleteClusterResponse EndDeleteCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteControlPanel

        /// <summary>
        /// Deletes a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteControlPanel service method.</param>
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
        public virtual DeleteControlPanelResponse DeleteControlPanel(DeleteControlPanelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteControlPanelResponseUnmarshaller.Instance;

            return Invoke<DeleteControlPanelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteControlPanel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteControlPanel operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteControlPanel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteControlPanel">REST API Reference for DeleteControlPanel Operation</seealso>
        public virtual IAsyncResult BeginDeleteControlPanel(DeleteControlPanelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteControlPanelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteControlPanel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteControlPanel.</param>
        /// 
        /// <returns>Returns a  DeleteControlPanelResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteControlPanel">REST API Reference for DeleteControlPanel Operation</seealso>
        public virtual DeleteControlPanelResponse EndDeleteControlPanel(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteControlPanelResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteRoutingControl

        /// <summary>
        /// Deletes a routing control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingControl service method.</param>
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
        public virtual DeleteRoutingControlResponse DeleteRoutingControl(DeleteRoutingControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoutingControlResponseUnmarshaller.Instance;

            return Invoke<DeleteRoutingControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoutingControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoutingControl operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoutingControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteRoutingControl">REST API Reference for DeleteRoutingControl Operation</seealso>
        public virtual IAsyncResult BeginDeleteRoutingControl(DeleteRoutingControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRoutingControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoutingControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoutingControl.</param>
        /// 
        /// <returns>Returns a  DeleteRoutingControlResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteRoutingControl">REST API Reference for DeleteRoutingControl Operation</seealso>
        public virtual DeleteRoutingControlResponse EndDeleteRoutingControl(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteRoutingControlResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSafetyRule

        /// <summary>
        /// Deletes a safety rule.
        /// 
        /// /&gt;
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSafetyRule service method.</param>
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
        public virtual DeleteSafetyRuleResponse DeleteSafetyRule(DeleteSafetyRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSafetyRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteSafetyRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSafetyRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSafetyRule operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSafetyRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteSafetyRule">REST API Reference for DeleteSafetyRule Operation</seealso>
        public virtual IAsyncResult BeginDeleteSafetyRule(DeleteSafetyRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSafetyRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSafetyRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSafetyRule.</param>
        /// 
        /// <returns>Returns a  DeleteSafetyRuleResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DeleteSafetyRule">REST API Reference for DeleteSafetyRule Operation</seealso>
        public virtual DeleteSafetyRuleResponse EndDeleteSafetyRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSafetyRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeCluster

        /// <summary>
        /// Display the details about a cluster. The response includes the cluster name, endpoints,
        /// status, and Amazon Resource Name (ARN).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster service method.</param>
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
        public virtual DescribeClusterResponse DescribeCluster(DescribeClusterRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return Invoke<DescribeClusterResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCluster operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCluster
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual IAsyncResult BeginDescribeCluster(DescribeClusterRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClusterRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClusterResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCluster operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCluster.</param>
        /// 
        /// <returns>Returns a  DescribeClusterResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeCluster">REST API Reference for DescribeCluster Operation</seealso>
        public virtual DescribeClusterResponse EndDescribeCluster(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeClusterResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeControlPanel

        /// <summary>
        /// Displays details about a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeControlPanel service method.</param>
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
        public virtual DescribeControlPanelResponse DescribeControlPanel(DescribeControlPanelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeControlPanelResponseUnmarshaller.Instance;

            return Invoke<DescribeControlPanelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeControlPanel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeControlPanel operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeControlPanel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeControlPanel">REST API Reference for DescribeControlPanel Operation</seealso>
        public virtual IAsyncResult BeginDescribeControlPanel(DescribeControlPanelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeControlPanelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeControlPanel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeControlPanel.</param>
        /// 
        /// <returns>Returns a  DescribeControlPanelResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeControlPanel">REST API Reference for DescribeControlPanel Operation</seealso>
        public virtual DescribeControlPanelResponse EndDescribeControlPanel(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeControlPanelResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeRoutingControl

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
        public virtual DescribeRoutingControlResponse DescribeRoutingControl(DescribeRoutingControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoutingControlResponseUnmarshaller.Instance;

            return Invoke<DescribeRoutingControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRoutingControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoutingControl operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRoutingControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeRoutingControl">REST API Reference for DescribeRoutingControl Operation</seealso>
        public virtual IAsyncResult BeginDescribeRoutingControl(DescribeRoutingControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRoutingControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRoutingControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRoutingControl.</param>
        /// 
        /// <returns>Returns a  DescribeRoutingControlResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeRoutingControl">REST API Reference for DescribeRoutingControl Operation</seealso>
        public virtual DescribeRoutingControlResponse EndDescribeRoutingControl(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeRoutingControlResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeSafetyRule

        /// <summary>
        /// Returns information about a safety rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSafetyRule service method.</param>
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
        public virtual DescribeSafetyRuleResponse DescribeSafetyRule(DescribeSafetyRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSafetyRuleResponseUnmarshaller.Instance;

            return Invoke<DescribeSafetyRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSafetyRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSafetyRule operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSafetyRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeSafetyRule">REST API Reference for DescribeSafetyRule Operation</seealso>
        public virtual IAsyncResult BeginDescribeSafetyRule(DescribeSafetyRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSafetyRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSafetyRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSafetyRule.</param>
        /// 
        /// <returns>Returns a  DescribeSafetyRuleResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/DescribeSafetyRule">REST API Reference for DescribeSafetyRule Operation</seealso>
        public virtual DescribeSafetyRuleResponse EndDescribeSafetyRule(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeSafetyRuleResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAssociatedRoute53HealthChecks

        /// <summary>
        /// Returns an array of all Amazon Route 53 health checks associated with a specific routing
        /// control.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedRoute53HealthChecks service method.</param>
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
        public virtual ListAssociatedRoute53HealthChecksResponse ListAssociatedRoute53HealthChecks(ListAssociatedRoute53HealthChecksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedRoute53HealthChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedRoute53HealthChecksResponseUnmarshaller.Instance;

            return Invoke<ListAssociatedRoute53HealthChecksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAssociatedRoute53HealthChecks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAssociatedRoute53HealthChecks operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAssociatedRoute53HealthChecks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListAssociatedRoute53HealthChecks">REST API Reference for ListAssociatedRoute53HealthChecks Operation</seealso>
        public virtual IAsyncResult BeginListAssociatedRoute53HealthChecks(ListAssociatedRoute53HealthChecksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAssociatedRoute53HealthChecksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAssociatedRoute53HealthChecksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAssociatedRoute53HealthChecks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAssociatedRoute53HealthChecks.</param>
        /// 
        /// <returns>Returns a  ListAssociatedRoute53HealthChecksResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListAssociatedRoute53HealthChecks">REST API Reference for ListAssociatedRoute53HealthChecks Operation</seealso>
        public virtual ListAssociatedRoute53HealthChecksResponse EndListAssociatedRoute53HealthChecks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAssociatedRoute53HealthChecksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListClusters

        /// <summary>
        /// Returns an array of all the clusters in an account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListClusters service method.</param>
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
        public virtual ListClustersResponse ListClusters(ListClustersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return Invoke<ListClustersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListClusters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListClusters operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListClusters
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual IAsyncResult BeginListClusters(ListClustersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListClustersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListClustersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListClusters operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListClusters.</param>
        /// 
        /// <returns>Returns a  ListClustersResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListClusters">REST API Reference for ListClusters Operation</seealso>
        public virtual ListClustersResponse EndListClusters(IAsyncResult asyncResult)
        {
            return EndInvoke<ListClustersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListControlPanels

        /// <summary>
        /// Returns an array of control panels in an account or in a cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListControlPanels service method.</param>
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
        public virtual ListControlPanelsResponse ListControlPanels(ListControlPanelsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlPanelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlPanelsResponseUnmarshaller.Instance;

            return Invoke<ListControlPanelsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListControlPanels operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListControlPanels operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListControlPanels
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListControlPanels">REST API Reference for ListControlPanels Operation</seealso>
        public virtual IAsyncResult BeginListControlPanels(ListControlPanelsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListControlPanelsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListControlPanelsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListControlPanels operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListControlPanels.</param>
        /// 
        /// <returns>Returns a  ListControlPanelsResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListControlPanels">REST API Reference for ListControlPanels Operation</seealso>
        public virtual ListControlPanelsResponse EndListControlPanels(IAsyncResult asyncResult)
        {
            return EndInvoke<ListControlPanelsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListRoutingControls

        /// <summary>
        /// Returns an array of routing controls for a control panel. A routing control is an
        /// Amazon Route 53 Application Recovery Controller construct that has one of two states:
        /// ON and OFF. You can map the routing control state to the state of an Amazon Route
        /// 53 health check, which can be used to control routing.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingControls service method.</param>
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
        public virtual ListRoutingControlsResponse ListRoutingControls(ListRoutingControlsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoutingControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingControlsResponseUnmarshaller.Instance;

            return Invoke<ListRoutingControlsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoutingControls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoutingControls operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListRoutingControls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListRoutingControls">REST API Reference for ListRoutingControls Operation</seealso>
        public virtual IAsyncResult BeginListRoutingControls(ListRoutingControlsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListRoutingControlsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListRoutingControlsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListRoutingControls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListRoutingControls.</param>
        /// 
        /// <returns>Returns a  ListRoutingControlsResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListRoutingControls">REST API Reference for ListRoutingControls Operation</seealso>
        public virtual ListRoutingControlsResponse EndListRoutingControls(IAsyncResult asyncResult)
        {
            return EndInvoke<ListRoutingControlsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListSafetyRules

        /// <summary>
        /// List the safety rules (the assertion rules and gating rules) that you've defined for
        /// the routing controls in a control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListSafetyRules service method.</param>
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
        public virtual ListSafetyRulesResponse ListSafetyRules(ListSafetyRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSafetyRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSafetyRulesResponseUnmarshaller.Instance;

            return Invoke<ListSafetyRulesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListSafetyRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSafetyRules operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListSafetyRules
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListSafetyRules">REST API Reference for ListSafetyRules Operation</seealso>
        public virtual IAsyncResult BeginListSafetyRules(ListSafetyRulesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSafetyRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSafetyRulesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListSafetyRules operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListSafetyRules.</param>
        /// 
        /// <returns>Returns a  ListSafetyRulesResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListSafetyRules">REST API Reference for ListSafetyRules Operation</seealso>
        public virtual ListSafetyRulesResponse EndListSafetyRules(IAsyncResult asyncResult)
        {
            return EndInvoke<ListSafetyRulesResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
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
        /// <returns>Returns a  ListTagsForResourceResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Adds a tag to a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// <returns>Returns a  TagResourceResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes a tag from a resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// <returns>Returns a  UntagResourceResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateControlPanel

        /// <summary>
        /// Updates a control panel. The only update you can make to a control panel is to change
        /// the name of the control panel.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateControlPanel service method.</param>
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
        public virtual UpdateControlPanelResponse UpdateControlPanel(UpdateControlPanelRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateControlPanelResponseUnmarshaller.Instance;

            return Invoke<UpdateControlPanelResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateControlPanel operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateControlPanel operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateControlPanel
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateControlPanel">REST API Reference for UpdateControlPanel Operation</seealso>
        public virtual IAsyncResult BeginUpdateControlPanel(UpdateControlPanelRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateControlPanelRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateControlPanelResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateControlPanel operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateControlPanel.</param>
        /// 
        /// <returns>Returns a  UpdateControlPanelResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateControlPanel">REST API Reference for UpdateControlPanel Operation</seealso>
        public virtual UpdateControlPanelResponse EndUpdateControlPanel(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateControlPanelResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateRoutingControl

        /// <summary>
        /// Updates a routing control. You can only update the name of the routing control. To
        /// get or update the routing control state, see the Recovery Cluster (data plane) API
        /// actions for Amazon Route 53 Application Recovery Controller.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControl service method.</param>
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
        public virtual UpdateRoutingControlResponse UpdateRoutingControl(UpdateRoutingControlRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingControlResponseUnmarshaller.Instance;

            return Invoke<UpdateRoutingControlResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoutingControl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoutingControl operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateRoutingControl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateRoutingControl">REST API Reference for UpdateRoutingControl Operation</seealso>
        public virtual IAsyncResult BeginUpdateRoutingControl(UpdateRoutingControlRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateRoutingControlRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateRoutingControlResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateRoutingControl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateRoutingControl.</param>
        /// 
        /// <returns>Returns a  UpdateRoutingControlResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateRoutingControl">REST API Reference for UpdateRoutingControl Operation</seealso>
        public virtual UpdateRoutingControlResponse EndUpdateRoutingControl(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateRoutingControlResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSafetyRule

        /// <summary>
        /// Update a safety rule (an assertion rule or gating rule). You can only update the name
        /// and the waiting period for a safety rule. To make other updates, delete the safety
        /// rule and create a new one.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSafetyRule service method.</param>
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
        public virtual UpdateSafetyRuleResponse UpdateSafetyRule(UpdateSafetyRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSafetyRuleResponseUnmarshaller.Instance;

            return Invoke<UpdateSafetyRuleResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSafetyRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSafetyRule operation on AmazonRoute53RecoveryControlConfigClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSafetyRule
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateSafetyRule">REST API Reference for UpdateSafetyRule Operation</seealso>
        public virtual IAsyncResult BeginUpdateSafetyRule(UpdateSafetyRuleRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSafetyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSafetyRuleResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSafetyRule operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSafetyRule.</param>
        /// 
        /// <returns>Returns a  UpdateSafetyRuleResult from Route53RecoveryControlConfig.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/route53-recovery-control-config-2020-11-02/UpdateSafetyRule">REST API Reference for UpdateSafetyRule Operation</seealso>
        public virtual UpdateSafetyRuleResponse EndUpdateSafetyRule(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSafetyRuleResponse>(asyncResult);
        }

        #endregion
        
    }
}