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
 * Do not modify this file. This file is generated from the elasticloadbalancingv2-2015-12-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations;
using Amazon.ElasticLoadBalancingV2.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancingV2
{
    /// <summary>
    /// Implementation for accessing ElasticLoadBalancingV2
    ///
    /// Elastic Load Balancing 
    /// <para>
    /// A load balancer distributes incoming traffic across targets, such as your EC2 instances.
    /// This enables you to increase the availability of your application. The load balancer
    /// also monitors the health of its registered targets and ensures that it routes traffic
    /// only to healthy targets. You configure your load balancer to accept incoming traffic
    /// by specifying one or more listeners, which are configured with a protocol and port
    /// number for connections from clients to the load balancer. You configure a target group
    /// with a protocol and port number for connections from the load balancer to the targets,
    /// and with health check settings to be used when checking the health status of the targets.
    /// </para>
    ///  
    /// <para>
    /// Elastic Load Balancing supports the following types of load balancers: Application
    /// Load Balancers, Network Load Balancers, Gateway Load Balancers, and Classic Load Balancers.
    /// This reference covers the following load balancer types:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Application Load Balancer - Operates at the application layer (layer 7) and supports
    /// HTTP and HTTPS.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Network Load Balancer - Operates at the transport layer (layer 4) and supports TCP,
    /// TLS, and UDP.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Gateway Load Balancer - Operates at the network layer (layer 3).
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information, see the <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/userguide/">Elastic
    /// Load Balancing User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// All Elastic Load Balancing operations are idempotent, which means that they complete
    /// at most one time. If you repeat an operation, it succeeds.
    /// </para>
    /// </summary>
    public partial class AmazonElasticLoadBalancingV2Client : AmazonServiceClient, IAmazonElasticLoadBalancingV2
    {
        private static IServiceMetadata serviceMetadata = new AmazonElasticLoadBalancingV2Metadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingV2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingV2Config()) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingV2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingV2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticLoadBalancingV2Client Configuration Object</param>
        public AmazonElasticLoadBalancingV2Client(AmazonElasticLoadBalancingV2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(config), config){}


        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticLoadBalancingV2Client(AWSCredentials credentials)
            : this(credentials, new AmazonElasticLoadBalancingV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingV2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticLoadBalancingV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with AWS Credentials and an
        /// AmazonElasticLoadBalancingV2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingV2Client Configuration Object</param>
        public AmazonElasticLoadBalancingV2Client(AWSCredentials credentials, AmazonElasticLoadBalancingV2Config clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticLoadBalancingV2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingV2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingV2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingV2Client Configuration Object</param>
        public AmazonElasticLoadBalancingV2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticLoadBalancingV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticLoadBalancingV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingV2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingV2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingV2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingV2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingV2Client Configuration Object</param>
        public AmazonElasticLoadBalancingV2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticLoadBalancingV2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private IElasticLoadBalancingV2PaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public IElasticLoadBalancingV2PaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new ElasticLoadBalancingV2PaginatorFactory(this);
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonElasticLoadBalancingV2EndpointResolver());
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


        #region  AddListenerCertificates

        internal virtual AddListenerCertificatesResponse AddListenerCertificates(AddListenerCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddListenerCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddListenerCertificatesResponseUnmarshaller.Instance;

            return Invoke<AddListenerCertificatesResponse>(request, options);
        }



        /// <summary>
        /// Adds the specified SSL server certificate to the certificate list for the specified
        /// HTTPS or TLS listener.
        /// 
        ///  
        /// <para>
        /// If the certificate in already in the certificate list, the call is successful but
        /// the certificate is not added again.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/create-https-listener.html">HTTPS
        /// listeners</a> in the <i>Application Load Balancers Guide</i> or <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/create-tls-listener.html">TLS
        /// listeners</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddListenerCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddListenerCertificates service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CertificateNotFoundException">
        /// The specified certificate does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddListenerCertificates">REST API Reference for AddListenerCertificates Operation</seealso>
        public virtual Task<AddListenerCertificatesResponse> AddListenerCertificatesAsync(AddListenerCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddListenerCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddListenerCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<AddListenerCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AddTags

        internal virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsResponse>(request, options);
        }



        /// <summary>
        /// Adds the specified tags to the specified Elastic Load Balancing resource. You can
        /// tag your Application Load Balancers, Network Load Balancers, Gateway Load Balancers,
        /// target groups, listeners, and rules.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a resource already has a tag
        /// with the same key, <code>AddTags</code> updates its value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AddTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateListener

        internal virtual CreateListenerResponse CreateListener(CreateListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListenerResponseUnmarshaller.Instance;

            return Invoke<CreateListenerResponse>(request, options);
        }



        /// <summary>
        /// Creates a listener for the specified Application Load Balancer, Network Load Balancer,
        /// or Gateway Load Balancer.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-listeners.html">Listeners
        /// for your Application Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-listeners.html">Listeners
        /// for your Network Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/gateway-listeners.html">Listeners
        /// for your Gateway Load Balancers</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent, which means that it completes at most one time. If you
        /// attempt to create multiple listeners with the same settings, each call succeeds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateListener service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ALPNPolicyNotSupportedException">
        /// The specified ALPN policy is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CertificateNotFoundException">
        /// The specified certificate does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateListenerException">
        /// A listener with the specified port already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyListenersException">
        /// You've reached the limit on the number of listeners per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateListener">REST API Reference for CreateListener Operation</seealso>
        public virtual Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateListenerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateListenerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancer

        internal virtual CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerResponse>(request, options);
        }



        /// <summary>
        /// Creates an Application Load Balancer, Network Load Balancer, or Gateway Load Balancer.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/application-load-balancers.html">Application
        /// Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/network-load-balancers.html">Network
        /// Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/gateway-load-balancers.html">Gateway
        /// Load Balancers</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent, which means that it completes at most one time. If you
        /// attempt to create multiple load balancers with the same settings, each call succeeds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AllocationIdNotFoundException">
        /// The specified allocation ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AvailabilityZoneNotSupportedException">
        /// The specified Availability Zone is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateLoadBalancerNameException">
        /// A load balancer with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSchemeException">
        /// The requested scheme is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSecurityGroupException">
        /// The specified security group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSubnetException">
        /// The specified subnet is out of available addresses.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SubnetNotFoundException">
        /// The specified subnet does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyLoadBalancersException">
        /// You've reached the limit on the number of load balancers for your Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        public virtual Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRule

        internal virtual CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleResponse>(request, options);
        }



        /// <summary>
        /// Creates a rule for the specified listener. The listener must be associated with an
        /// Application Load Balancer.
        /// 
        ///  
        /// <para>
        /// Each rule consists of a priority, one or more actions, and one or more conditions.
        /// Rules are evaluated in priority order, from the lowest value to the highest value.
        /// When the conditions for a rule are met, its actions are performed. If the conditions
        /// for no rules are met, the actions for the default rule are performed. For more information,
        /// see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-listeners.html#listener-rules">Listener
        /// rules</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.PriorityInUseException">
        /// The specified priority is in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRulesException">
        /// You've reached the limit on the number of rules per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetGroupsException">
        /// You've reached the limit on the number of target groups for your Amazon Web Services
        /// account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public virtual Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTargetGroup

        internal virtual CreateTargetGroupResponse CreateTargetGroup(CreateTargetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTargetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateTargetGroupResponse>(request, options);
        }



        /// <summary>
        /// Creates a target group.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-target-groups.html">Target
        /// groups for your Application Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html">Target
        /// groups for your Network Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/target-groups.html">Target
        /// groups for your Gateway Load Balancers</a> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This operation is idempotent, which means that it completes at most one time. If you
        /// attempt to create multiple target groups with the same settings, each call succeeds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTargetGroupNameException">
        /// A target group with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetGroupsException">
        /// You've reached the limit on the number of target groups for your Amazon Web Services
        /// account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        public virtual Task<CreateTargetGroupResponse> CreateTargetGroupAsync(CreateTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTargetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTargetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteListener

        internal virtual DeleteListenerResponse DeleteListener(DeleteListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListenerResponseUnmarshaller.Instance;

            return Invoke<DeleteListenerResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified listener.
        /// 
        ///  
        /// <para>
        /// Alternatively, your listener is deleted when you delete the load balancer to which
        /// it is attached.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteListener service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        public virtual Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteListenerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteListenerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancer

        internal virtual DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified Application Load Balancer, Network Load Balancer, or Gateway
        /// Load Balancer. Deleting a load balancer also deletes its listeners.
        /// 
        ///  
        /// <para>
        /// You can't delete a load balancer if deletion protection is enabled. If the load balancer
        /// does not exist or has already been deleted, the call succeeds.
        /// </para>
        ///  
        /// <para>
        /// Deleting a load balancer does not affect its registered targets. For example, your
        /// EC2 instances continue to run and are still registered to their target groups. If
        /// you no longer need these EC2 instances, you can stop or terminate them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        public virtual Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLoadBalancerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRule

        internal virtual DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified rule.
        /// 
        ///  
        /// <para>
        /// You can't delete the default rule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public virtual Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTargetGroup

        internal virtual DeleteTargetGroupResponse DeleteTargetGroup(DeleteTargetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteTargetGroupResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified target group.
        /// 
        ///  
        /// <para>
        /// You can delete a target group if it is not referenced by any actions. Deleting a target
        /// group also deletes any associated health checks. Deleting a target group does not
        /// affect its registered targets. For example, any EC2 instances continue to run until
        /// you stop or terminate them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        public virtual Task<DeleteTargetGroupResponse> DeleteTargetGroupAsync(DeleteTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTargetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTargetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTargets

        internal virtual DeregisterTargetsResponse DeregisterTargets(DeregisterTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTargetsResponseUnmarshaller.Instance;

            return Invoke<DeregisterTargetsResponse>(request, options);
        }



        /// <summary>
        /// Deregisters the specified targets from the specified target group. After the targets
        /// are deregistered, they no longer receive traffic from the load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTargets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist, is not in the same VPC as the target group, or
        /// has an unsupported instance type.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        public virtual Task<DeregisterTargetsResponse> DeregisterTargetsAsync(DeregisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountLimits

        internal virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsResponse>(request, options);
        }



        /// <summary>
        /// Describes the current Elastic Load Balancing resource limits for your Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-limits.html">Quotas
        /// for your Application Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-limits.html">Quotas
        /// for your Network Load Balancers</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/quotas-limits.html">Quotas
        /// for your Gateway Load Balancers</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeListenerCertificates

        internal virtual DescribeListenerCertificatesResponse DescribeListenerCertificates(DescribeListenerCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeListenerCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeListenerCertificatesResponseUnmarshaller.Instance;

            return Invoke<DescribeListenerCertificatesResponse>(request, options);
        }



        /// <summary>
        /// Describes the default certificate and the certificate list for the specified HTTPS
        /// or TLS listener.
        /// 
        ///  
        /// <para>
        /// If the default certificate is also in the certificate list, it appears twice in the
        /// results (once with <code>IsDefault</code> set to true and once with <code>IsDefault</code>
        /// set to false).
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/create-https-listener.html#https-listener-certificates">SSL
        /// certificates</a> in the <i>Application Load Balancers Guide</i> or <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/create-tls-listener.html#tls-listener-certificate">Server
        /// certificates</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListenerCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeListenerCertificates service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListenerCertificates">REST API Reference for DescribeListenerCertificates Operation</seealso>
        public virtual Task<DescribeListenerCertificatesResponse> DescribeListenerCertificatesAsync(DescribeListenerCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeListenerCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeListenerCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeListenerCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeListeners

        internal virtual DescribeListenersResponse DescribeListeners(DescribeListenersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeListenersResponseUnmarshaller.Instance;

            return Invoke<DescribeListenersResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified listeners or the listeners for the specified Application Load
        /// Balancer, Network Load Balancer, or Gateway Load Balancer. You must specify either
        /// a load balancer or one or more listeners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListeners service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeListeners service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListeners">REST API Reference for DescribeListeners Operation</seealso>
        public virtual Task<DescribeListenersResponse> DescribeListenersAsync(DescribeListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeListenersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeListenersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeListenersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerAttributes

        internal virtual DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancerAttributesResponse>(request, options);
        }



        /// <summary>
        /// Describes the attributes for the specified Application Load Balancer, Network Load
        /// Balancer, or Gateway Load Balancer.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/application-load-balancers.html#load-balancer-attributes">Load
        /// balancer attributes</a> in the <i>Application Load Balancers Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/network-load-balancers.html#load-balancer-attributes">Load
        /// balancer attributes</a> in the <i>Network Load Balancers Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/gateway-load-balancers.html#load-balancer-attributes">Load
        /// balancer attributes</a> in the <i>Gateway Load Balancers Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancerAttributes">REST API Reference for DescribeLoadBalancerAttributes Operation</seealso>
        public virtual Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancerAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancerAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancers

        internal virtual DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancersResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified load balancers or all of your load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRules

        internal virtual DescribeRulesResponse DescribeRules(DescribeRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeRulesResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified rules or the rules for the specified listener. You must specify
        /// either a listener or one or more rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRules service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRules service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeRules">REST API Reference for DescribeRules Operation</seealso>
        public virtual Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRulesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSSLPolicies

        internal virtual DescribeSSLPoliciesResponse DescribeSSLPolicies(DescribeSSLPoliciesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSSLPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSSLPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeSSLPoliciesResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified policies or all policies used for SSL negotiation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/create-https-listener.html#describe-ssl-policies">Security
        /// policies</a> in the <i>Application Load Balancers Guide</i> or <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/create-tls-listener.html#describe-ssl-policies">Security
        /// policies</a> in the <i>Network Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSSLPolicies service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSSLPolicies service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeSSLPolicies">REST API Reference for DescribeSSLPolicies Operation</seealso>
        public virtual Task<DescribeSSLPoliciesResponse> DescribeSSLPoliciesAsync(DescribeSSLPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSSLPoliciesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSSLPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSSLPoliciesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }



        /// <summary>
        /// Describes the tags for the specified Elastic Load Balancing resources. You can describe
        /// the tags for one or more Application Load Balancers, Network Load Balancers, Gateway
        /// Load Balancers, target groups, listeners, or rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTargetGroupAttributes

        internal virtual DescribeTargetGroupAttributesResponse DescribeTargetGroupAttributes(DescribeTargetGroupAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTargetGroupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTargetGroupAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeTargetGroupAttributesResponse>(request, options);
        }



        /// <summary>
        /// Describes the attributes for the specified target group.
        /// 
        ///  
        /// <para>
        /// For more information, see the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-target-groups.html#target-group-attributes">Target
        /// group attributes</a> in the <i>Application Load Balancers Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/network/load-balancer-target-groups.html#target-group-attributes">Target
        /// group attributes</a> in the <i>Network Load Balancers Guide</i> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="https://docs.aws.amazon.com/elasticloadbalancing/latest/gateway/target-groups.html#target-group-attributes">Target
        /// group attributes</a> in the <i>Gateway Load Balancers Guide</i> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroupAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTargetGroupAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroupAttributes">REST API Reference for DescribeTargetGroupAttributes Operation</seealso>
        public virtual Task<DescribeTargetGroupAttributesResponse> DescribeTargetGroupAttributesAsync(DescribeTargetGroupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTargetGroupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTargetGroupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTargetGroupAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTargetGroups

        internal virtual DescribeTargetGroupsResponse DescribeTargetGroups(DescribeTargetGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeTargetGroupsResponse>(request, options);
        }



        /// <summary>
        /// Describes the specified target groups or all of your target groups. By default, all
        /// target groups are described. Alternatively, you can specify one of the following to
        /// filter the results: the ARN of the load balancer, the names of one or more target
        /// groups, or the ARNs of one or more target groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTargetGroups service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroups">REST API Reference for DescribeTargetGroups Operation</seealso>
        public virtual Task<DescribeTargetGroupsResponse> DescribeTargetGroupsAsync(DescribeTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTargetGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTargetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTargetGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTargetHealth

        internal virtual DescribeTargetHealthResponse DescribeTargetHealth(DescribeTargetHealthRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTargetHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTargetHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeTargetHealthResponse>(request, options);
        }



        /// <summary>
        /// Describes the health of the specified targets or all of your targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetHealth service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTargetHealth service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.HealthUnavailableException">
        /// The health of the specified targets could not be retrieved due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist, is not in the same VPC as the target group, or
        /// has an unsupported instance type.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetHealth">REST API Reference for DescribeTargetHealth Operation</seealso>
        public virtual Task<DescribeTargetHealthResponse> DescribeTargetHealthAsync(DescribeTargetHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTargetHealthRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTargetHealthResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTargetHealthResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyListener

        internal virtual ModifyListenerResponse ModifyListener(ModifyListenerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyListenerResponseUnmarshaller.Instance;

            return Invoke<ModifyListenerResponse>(request, options);
        }



        /// <summary>
        /// Replaces the specified properties of the specified listener. Any properties that you
        /// do not specify remain unchanged.
        /// 
        ///  
        /// <para>
        /// Changing the protocol from HTTPS to HTTP, or from TLS to TCP, removes the security
        /// policy and default certificate properties. If you change the protocol from HTTP to
        /// HTTPS, or from TCP to TLS, you must add the security policy and default certificate
        /// properties.
        /// </para>
        ///  
        /// <para>
        /// To add an item to a list, remove an item from a list, or update an item in a list,
        /// you must provide the entire list. For example, to add an action, specify a list with
        /// the current actions plus the new action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyListener service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyListener service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ALPNPolicyNotSupportedException">
        /// The specified ALPN policy is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.CertificateNotFoundException">
        /// The specified certificate does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateListenerException">
        /// A listener with the specified port already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyListenersException">
        /// You've reached the limit on the number of listeners per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyListener">REST API Reference for ModifyListener Operation</seealso>
        public virtual Task<ModifyListenerResponse> ModifyListenerAsync(ModifyListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyListenerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyListenerResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyListenerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyLoadBalancerAttributes

        internal virtual ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyLoadBalancerAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance;

            return Invoke<ModifyLoadBalancerAttributesResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified attributes of the specified Application Load Balancer, Network
        /// Load Balancer, or Gateway Load Balancer.
        /// 
        ///  
        /// <para>
        /// If any of the specified attributes can't be modified as requested, the call fails.
        /// Any existing attributes that you do not modify retain their current values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyLoadBalancerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyLoadBalancerAttributes">REST API Reference for ModifyLoadBalancerAttributes Operation</seealso>
        public virtual Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyLoadBalancerAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyLoadBalancerAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyRule

        internal virtual ModifyRuleResponse ModifyRule(ModifyRuleRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyRuleResponseUnmarshaller.Instance;

            return Invoke<ModifyRuleResponse>(request, options);
        }



        /// <summary>
        /// Replaces the specified properties of the specified rule. Any properties that you do
        /// not specify are unchanged.
        /// 
        ///  
        /// <para>
        /// To add an item to a list, remove an item from a list, or update an item in a list,
        /// you must provide the entire list. For example, to add an action, specify a list with
        /// the current actions plus the new action.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyRule service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.IncompatibleProtocolsException">
        /// The specified configuration is not valid with this protocol.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidLoadBalancerActionException">
        /// The requested action is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyActionsException">
        /// You've reached the limit on the number of actions per rule.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyUniqueTargetGroupsPerLoadBalancerException">
        /// You've reached the limit on the number of unique target groups per load balancer across
        /// all listeners. If a target group is used by multiple actions for a load balancer,
        /// it is counted as only one use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyRule">REST API Reference for ModifyRule Operation</seealso>
        public virtual Task<ModifyRuleResponse> ModifyRuleAsync(ModifyRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyRuleRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyRuleResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyRuleResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyTargetGroup

        internal virtual ModifyTargetGroupResponse ModifyTargetGroup(ModifyTargetGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyTargetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyTargetGroupResponse>(request, options);
        }



        /// <summary>
        /// Modifies the health checks used when evaluating the health state of the targets in
        /// the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroup service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroup">REST API Reference for ModifyTargetGroup Operation</seealso>
        public virtual Task<ModifyTargetGroupResponse> ModifyTargetGroupAsync(ModifyTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyTargetGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyTargetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyTargetGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyTargetGroupAttributes

        internal virtual ModifyTargetGroupAttributesResponse ModifyTargetGroupAttributes(ModifyTargetGroupAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyTargetGroupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyTargetGroupAttributesResponseUnmarshaller.Instance;

            return Invoke<ModifyTargetGroupAttributesResponse>(request, options);
        }



        /// <summary>
        /// Modifies the specified attributes of the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroupAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ModifyTargetGroupAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroupAttributes">REST API Reference for ModifyTargetGroupAttributes Operation</seealso>
        public virtual Task<ModifyTargetGroupAttributesResponse> ModifyTargetGroupAttributesAsync(ModifyTargetGroupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyTargetGroupAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyTargetGroupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyTargetGroupAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterTargets

        internal virtual RegisterTargetsResponse RegisterTargets(RegisterTargetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTargetsResponseUnmarshaller.Instance;

            return Invoke<RegisterTargetsResponse>(request, options);
        }



        /// <summary>
        /// Registers the specified targets with the specified target group.
        /// 
        ///  
        /// <para>
        /// If the target is an EC2 instance, it must be in the <code>running</code> state when
        /// you register it.
        /// </para>
        ///  
        /// <para>
        /// By default, the load balancer routes requests to registered targets using the protocol
        /// and port for the target group. Alternatively, you can override the port for a target
        /// when you register it. You can register each EC2 instance or IP address with the same
        /// target group multiple times using different ports.
        /// </para>
        ///  
        /// <para>
        /// With a Network Load Balancer, you cannot register instances by instance ID if they
        /// have the following instance types: C1, CC1, CC2, CG1, CG2, CR1, CS1, G1, G2, HI1,
        /// HS1, M1, M2, M3, and T1. You can register instances of these types by IP address.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTargets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist, is not in the same VPC as the target group, or
        /// has an unsupported instance type.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetsException">
        /// You've reached the limit on the number of targets.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        public virtual Task<RegisterTargetsResponse> RegisterTargetsAsync(RegisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTargetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTargetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveListenerCertificates

        internal virtual RemoveListenerCertificatesResponse RemoveListenerCertificates(RemoveListenerCertificatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveListenerCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveListenerCertificatesResponseUnmarshaller.Instance;

            return Invoke<RemoveListenerCertificatesResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified certificate from the certificate list for the specified HTTPS
        /// or TLS listener.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveListenerCertificates service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveListenerCertificates service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveListenerCertificates">REST API Reference for RemoveListenerCertificates Operation</seealso>
        public virtual Task<RemoveListenerCertificatesResponse> RemoveListenerCertificatesAsync(RemoveListenerCertificatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveListenerCertificatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveListenerCertificatesResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveListenerCertificatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsResponse>(request, options);
        }



        /// <summary>
        /// Removes the specified tags from the specified Elastic Load Balancing resources. You
        /// can remove the tags for one or more Application Load Balancers, Network Load Balancers,
        /// Gateway Load Balancers, target groups, listeners, or rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RemoveTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetIpAddressType

        internal virtual SetIpAddressTypeResponse SetIpAddressType(SetIpAddressTypeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIpAddressTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIpAddressTypeResponseUnmarshaller.Instance;

            return Invoke<SetIpAddressTypeResponse>(request, options);
        }



        /// <summary>
        /// Sets the type of IP addresses used by the subnets of the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIpAddressType service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetIpAddressType service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSubnetException">
        /// The specified subnet is out of available addresses.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetIpAddressType">REST API Reference for SetIpAddressType Operation</seealso>
        public virtual Task<SetIpAddressTypeResponse> SetIpAddressTypeAsync(SetIpAddressTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetIpAddressTypeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetIpAddressTypeResponseUnmarshaller.Instance;

            return InvokeAsync<SetIpAddressTypeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetRulePriorities

        internal virtual SetRulePrioritiesResponse SetRulePriorities(SetRulePrioritiesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRulePrioritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRulePrioritiesResponseUnmarshaller.Instance;

            return Invoke<SetRulePrioritiesResponse>(request, options);
        }



        /// <summary>
        /// Sets the priorities of the specified rules.
        /// 
        ///  
        /// <para>
        /// You can reorder the rules as long as there are no priority conflicts in the new order.
        /// Any existing rules that you do not specify retain their current priority.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetRulePriorities service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetRulePriorities service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.PriorityInUseException">
        /// The specified priority is in use.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetRulePriorities">REST API Reference for SetRulePriorities Operation</seealso>
        public virtual Task<SetRulePrioritiesResponse> SetRulePrioritiesAsync(SetRulePrioritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetRulePrioritiesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetRulePrioritiesResponseUnmarshaller.Instance;

            return InvokeAsync<SetRulePrioritiesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetSecurityGroups

        internal virtual SetSecurityGroupsResponse SetSecurityGroups(SetSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<SetSecurityGroupsResponse>(request, options);
        }



        /// <summary>
        /// Associates the specified security groups with the specified Application Load Balancer.
        /// The specified security groups override the previously associated security groups.
        /// 
        ///  
        /// <para>
        /// You can't specify a security group for a Network Load Balancer or Gateway Load Balancer.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityGroups service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSecurityGroups service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSecurityGroupException">
        /// The specified security group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSecurityGroups">REST API Reference for SetSecurityGroups Operation</seealso>
        public virtual Task<SetSecurityGroupsResponse> SetSecurityGroupsAsync(SetSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<SetSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SetSubnets

        internal virtual SetSubnetsResponse SetSubnets(SetSubnetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSubnetsResponseUnmarshaller.Instance;

            return Invoke<SetSubnetsResponse>(request, options);
        }



        /// <summary>
        /// Enables the Availability Zones for the specified public subnets for the specified
        /// Application Load Balancer or Network Load Balancer. The specified subnets replace
        /// the previously enabled subnets.
        /// 
        ///  
        /// <para>
        /// When you specify subnets for a Network Load Balancer, you must include all subnets
        /// that were enabled previously, with their existing configurations, plus any additional
        /// subnets.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSubnets service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the SetSubnets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AllocationIdNotFoundException">
        /// The specified allocation ID does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.AvailabilityZoneNotSupportedException">
        /// The specified Availability Zone is not supported.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidSubnetException">
        /// The specified subnet is out of available addresses.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SubnetNotFoundException">
        /// The specified subnet does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSubnets">REST API Reference for SetSubnets Operation</seealso>
        public virtual Task<SetSubnetsResponse> SetSubnetsAsync(SetSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SetSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SetSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<SetSubnetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}