/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.ElasticLoadBalancingV2.Model;
using Amazon.ElasticLoadBalancingV2.Model.Internal.MarshallTransformations;
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
    /// Elastic Load Balancing supports two types of load balancers: Classic Load Balancers
    /// and Application Load Balancers. A Classic Load Balancer makes routing and load balancing
    /// decisions either at the transport layer (TCP/SSL) or the application layer (HTTP/HTTPS),
    /// and supports either EC2-Classic or a VPC. An Application Load Balancer makes routing
    /// and load balancing decisions at the application layer (HTTP/HTTPS), supports path-based
    /// routing, and can route requests to one or more ports on each EC2 instance or container
    /// instance in your virtual private cloud (VPC). For more information, see the <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/userguide/">Elastic
    /// Load Balancing User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This reference covers the 2015-12-01 API, which supports Application Load Balancers.
    /// The 2012-06-01 API supports Classic Load Balancers.
    /// </para>
    ///  
    /// <para>
    /// To get started, complete the following tasks:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create an Application Load Balancer using <a>CreateLoadBalancer</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create a target group using <a>CreateTargetGroup</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Register targets for the target group using <a>RegisterTargets</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create one or more listeners for your load balancer using <a>CreateListener</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) Create one or more rules for content routing based on URL using <a>CreateRule</a>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// To delete an Application Load Balancer and its related resources, complete the following
    /// tasks:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Delete the load balancer using <a>DeleteLoadBalancer</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Delete the target group using <a>DeleteTargetGroup</a>.
    /// </para>
    ///  </li> </ol> 
    /// <para>
    /// All Elastic Load Balancing operations are idempotent, which means that they complete
    /// at most one time. If you repeat an operation, it succeeds.
    /// </para>
    /// </summary>
    public partial class AmazonElasticLoadBalancingV2Client : AmazonServiceClient, IAmazonElasticLoadBalancingV2
    {
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
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
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

        
        #region  AddTags


        /// <summary>
        /// Adds the specified tags to the specified resource. You can tag your Application Load
        /// Balancers and your target groups.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a resource already has a tag
        /// with the same key, <code>AddTags</code> updates its value.
        /// </para>
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>DescribeTags</a>. To remove tags
        /// from your resources, use <a>RemoveTags</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public AddTagsResponse AddTags(AddTagsRequest request)
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return Invoke<AddTagsRequest,AddTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsRequest,AddTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateListener


        /// <summary>
        /// Creates a listener for the specified Application Load Balancer.
        /// 
        ///  
        /// <para>
        /// You can create up to 10 listeners per load balancer.
        /// </para>
        ///  
        /// <para>
        /// To update a listener, use <a>ModifyListener</a>. When you are finished with a listener,
        /// you can delete it using <a>DeleteListener</a>. If you are finished with both the listener
        /// and the load balancer, you can delete them both using <a>DeleteLoadBalancer</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-listeners.html">Listeners
        /// for Your Application Load Balancers</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateListener service method.</param>
        /// 
        /// <returns>The response from the CreateListener service method, as returned by ElasticLoadBalancingV2.</returns>
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
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per listener.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyListenersException">
        /// You've reached the limit on the number of listeners per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateListener">REST API Reference for CreateListener Operation</seealso>
        public CreateListenerResponse CreateListener(CreateListenerRequest request)
        {
            var marshaller = new CreateListenerRequestMarshaller();
            var unmarshaller = CreateListenerResponseUnmarshaller.Instance;

            return Invoke<CreateListenerRequest,CreateListenerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateListener">REST API Reference for CreateListener Operation</seealso>
        public Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateListenerRequestMarshaller();
            var unmarshaller = CreateListenerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateListenerRequest,CreateListenerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancer


        /// <summary>
        /// Creates an Application Load Balancer.
        /// 
        ///  
        /// <para>
        /// When you create a load balancer, you can specify security groups, subnets, IP address
        /// type, and tags. Otherwise, you could do so later using <a>SetSecurityGroups</a>, <a>SetSubnets</a>,
        /// <a>SetIpAddressType</a>, and <a>AddTags</a>.
        /// </para>
        ///  
        /// <para>
        /// To create listeners for your load balancer, use <a>CreateListener</a>. To describe
        /// your current load balancers, see <a>DescribeLoadBalancers</a>. When you are finished
        /// with a load balancer, you can delete it using <a>DeleteLoadBalancer</a>.
        /// </para>
        ///  
        /// <para>
        /// You can create up to 20 load balancers per region per account. You can request an
        /// increase for the number of load balancers for your account. For more information,
        /// see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-limits.html">Limits
        /// for Your Application Load Balancer</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/application/application-load-balancers.html">Application
        /// Load Balancers</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by ElasticLoadBalancingV2.</returns>
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
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SubnetNotFoundException">
        /// The specified subnet does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyLoadBalancersException">
        /// You've reached the limit on the number of load balancers for your AWS account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTagsException">
        /// You've reached the limit on the number of tags per load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        public CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var unmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerRequest,CreateLoadBalancerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        public Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var unmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerRequest,CreateLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// Creates a rule for the specified listener.
        /// 
        ///  
        /// <para>
        /// Each rule can have one action and one condition. Rules are evaluated in priority order,
        /// from the lowest value to the highest value. When the condition for a rule is met,
        /// the specified action is taken. If no conditions are met, the default action for the
        /// default rule is taken. For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-listeners.html#listener-rules">Listener
        /// Rules</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// To view your current rules, use <a>DescribeRules</a>. To update a rule, use <a>ModifyRule</a>.
        /// To set the priorities of your rules, use <a>SetRulePriorities</a>. To delete a rule,
        /// use <a>DeleteRule</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRule service method.</param>
        /// 
        /// <returns>The response from the CreateRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
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
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRulesException">
        /// You've reached the limit on the number of rules per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetGroupsException">
        /// You've reached the limit on the number of target groups for your AWS account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public CreateRuleResponse CreateRule(CreateRuleRequest request)
        {
            var marshaller = new CreateRuleRequestMarshaller();
            var unmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return Invoke<CreateRuleRequest,CreateRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateRule">REST API Reference for CreateRule Operation</seealso>
        public Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRuleRequestMarshaller();
            var unmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleRequest,CreateRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTargetGroup


        /// <summary>
        /// Creates a target group.
        /// 
        ///  
        /// <para>
        /// To register targets with the target group, use <a>RegisterTargets</a>. To update the
        /// health check settings for the target group, use <a>ModifyTargetGroup</a>. To monitor
        /// the health of targets in the target group, use <a>DescribeTargetHealth</a>.
        /// </para>
        ///  
        /// <para>
        /// To route traffic to the targets in a target group, specify the target group in an
        /// action using <a>CreateListener</a> or <a>CreateRule</a>.
        /// </para>
        ///  
        /// <para>
        /// To delete a target group, use <a>DeleteTargetGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-target-groups.html">Target
        /// Groups for Your Application Load Balancers</a> in the <i>Application Load Balancers
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup service method.</param>
        /// 
        /// <returns>The response from the CreateTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateTargetGroupNameException">
        /// A target group with the specified name already exists.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyTargetGroupsException">
        /// You've reached the limit on the number of target groups for your AWS account.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        public CreateTargetGroupResponse CreateTargetGroup(CreateTargetGroupRequest request)
        {
            var marshaller = new CreateTargetGroupRequestMarshaller();
            var unmarshaller = CreateTargetGroupResponseUnmarshaller.Instance;

            return Invoke<CreateTargetGroupRequest,CreateTargetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/CreateTargetGroup">REST API Reference for CreateTargetGroup Operation</seealso>
        public Task<CreateTargetGroupResponse> CreateTargetGroupAsync(CreateTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTargetGroupRequestMarshaller();
            var unmarshaller = CreateTargetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTargetGroupRequest,CreateTargetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteListener


        /// <summary>
        /// Deletes the specified listener.
        /// 
        ///  
        /// <para>
        /// Alternatively, your listener is deleted when you delete the load balancer it is attached
        /// to using <a>DeleteLoadBalancer</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener service method.</param>
        /// 
        /// <returns>The response from the DeleteListener service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        public DeleteListenerResponse DeleteListener(DeleteListenerRequest request)
        {
            var marshaller = new DeleteListenerRequestMarshaller();
            var unmarshaller = DeleteListenerResponseUnmarshaller.Instance;

            return Invoke<DeleteListenerRequest,DeleteListenerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteListener">REST API Reference for DeleteListener Operation</seealso>
        public Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteListenerRequestMarshaller();
            var unmarshaller = DeleteListenerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteListenerRequest,DeleteListenerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancer


        /// <summary>
        /// Deletes the specified Application Load Balancer and its attached listeners.
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
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        public DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            var marshaller = new DeleteLoadBalancerRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerRequest,DeleteLoadBalancerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLoadBalancerRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerRequest,DeleteLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRule


        /// <summary>
        /// Deletes the specified rule.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule service method.</param>
        /// 
        /// <returns>The response from the DeleteRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
        {
            var marshaller = new DeleteRuleRequestMarshaller();
            var unmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return Invoke<DeleteRuleRequest,DeleteRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteRule">REST API Reference for DeleteRule Operation</seealso>
        public Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRuleRequestMarshaller();
            var unmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleRequest,DeleteRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTargetGroup


        /// <summary>
        /// Deletes the specified target group.
        /// 
        ///  
        /// <para>
        /// You can delete a target group if it is not referenced by any actions. Deleting a target
        /// group also deletes any associated health checks.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ResourceInUseException">
        /// A specified resource is in use.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        public DeleteTargetGroupResponse DeleteTargetGroup(DeleteTargetGroupRequest request)
        {
            var marshaller = new DeleteTargetGroupRequestMarshaller();
            var unmarshaller = DeleteTargetGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteTargetGroupRequest,DeleteTargetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeleteTargetGroup">REST API Reference for DeleteTargetGroup Operation</seealso>
        public Task<DeleteTargetGroupResponse> DeleteTargetGroupAsync(DeleteTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTargetGroupRequestMarshaller();
            var unmarshaller = DeleteTargetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTargetGroupRequest,DeleteTargetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTargets


        /// <summary>
        /// Deregisters the specified targets from the specified target group. After the targets
        /// are deregistered, they no longer receive traffic from the load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets service method.</param>
        /// 
        /// <returns>The response from the DeregisterTargets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist or is not in the same VPC as the target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        public DeregisterTargetsResponse DeregisterTargets(DeregisterTargetsRequest request)
        {
            var marshaller = new DeregisterTargetsRequestMarshaller();
            var unmarshaller = DeregisterTargetsResponseUnmarshaller.Instance;

            return Invoke<DeregisterTargetsRequest,DeregisterTargetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DeregisterTargets">REST API Reference for DeregisterTargets Operation</seealso>
        public Task<DeregisterTargetsResponse> DeregisterTargetsAsync(DeregisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterTargetsRequestMarshaller();
            var unmarshaller = DeregisterTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTargetsRequest,DeregisterTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeListeners


        /// <summary>
        /// Describes the specified listeners or the listeners for the specified Application Load
        /// Balancer. You must specify either a load balancer or one or more listeners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeListeners service method.</param>
        /// 
        /// <returns>The response from the DescribeListeners service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListeners">REST API Reference for DescribeListeners Operation</seealso>
        public DescribeListenersResponse DescribeListeners(DescribeListenersRequest request)
        {
            var marshaller = new DescribeListenersRequestMarshaller();
            var unmarshaller = DescribeListenersResponseUnmarshaller.Instance;

            return Invoke<DescribeListenersRequest,DescribeListenersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeListeners">REST API Reference for DescribeListeners Operation</seealso>
        public Task<DescribeListenersResponse> DescribeListenersAsync(DescribeListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeListenersRequestMarshaller();
            var unmarshaller = DescribeListenersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeListenersRequest,DescribeListenersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerAttributes


        /// <summary>
        /// Describes the attributes for the specified Application Load Balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancerAttributes">REST API Reference for DescribeLoadBalancerAttributes Operation</seealso>
        public DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request)
        {
            var marshaller = new DescribeLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancerAttributesRequest,DescribeLoadBalancerAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancerAttributes">REST API Reference for DescribeLoadBalancerAttributes Operation</seealso>
        public Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancerAttributesRequest,DescribeLoadBalancerAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancers


        /// <summary>
        /// Describes the specified Application Load Balancers or all of your Application Load
        /// Balancers.
        /// 
        ///  
        /// <para>
        /// To describe the listeners for a load balancer, use <a>DescribeListeners</a>. To describe
        /// the attributes for a load balancer, use <a>DescribeLoadBalancerAttributes</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancersRequest,DescribeLoadBalancersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancersRequest,DescribeLoadBalancersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRules


        /// <summary>
        /// Describes the specified rules or the rules for the specified listener. You must specify
        /// either a listener or one or more rules.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRules service method.</param>
        /// 
        /// <returns>The response from the DescribeRules service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.ListenerNotFoundException">
        /// The specified listener does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeRules">REST API Reference for DescribeRules Operation</seealso>
        public DescribeRulesResponse DescribeRules(DescribeRulesRequest request)
        {
            var marshaller = new DescribeRulesRequestMarshaller();
            var unmarshaller = DescribeRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeRulesRequest,DescribeRulesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeRules">REST API Reference for DescribeRules Operation</seealso>
        public Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRulesRequestMarshaller();
            var unmarshaller = DescribeRulesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRulesRequest,DescribeRulesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSSLPolicies


        /// <summary>
        /// Describes the specified policies or all policies used for SSL negotiation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/application/create-https-listener.html#describe-ssl-policies">Security
        /// Policies</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSSLPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeSSLPolicies service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeSSLPolicies">REST API Reference for DescribeSSLPolicies Operation</seealso>
        public DescribeSSLPoliciesResponse DescribeSSLPolicies(DescribeSSLPoliciesRequest request)
        {
            var marshaller = new DescribeSSLPoliciesRequestMarshaller();
            var unmarshaller = DescribeSSLPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeSSLPoliciesRequest,DescribeSSLPoliciesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSSLPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSSLPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeSSLPolicies">REST API Reference for DescribeSSLPolicies Operation</seealso>
        public Task<DescribeSSLPoliciesResponse> DescribeSSLPoliciesAsync(DescribeSSLPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSSLPoliciesRequestMarshaller();
            var unmarshaller = DescribeSSLPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSSLPoliciesRequest,DescribeSSLPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the tags for the specified resources. You can describe the tags for one
        /// or more Application Load Balancers and target groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
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
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTargetGroupAttributes


        /// <summary>
        /// Describes the attributes for the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroupAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeTargetGroupAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroupAttributes">REST API Reference for DescribeTargetGroupAttributes Operation</seealso>
        public DescribeTargetGroupAttributesResponse DescribeTargetGroupAttributes(DescribeTargetGroupAttributesRequest request)
        {
            var marshaller = new DescribeTargetGroupAttributesRequestMarshaller();
            var unmarshaller = DescribeTargetGroupAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeTargetGroupAttributesRequest,DescribeTargetGroupAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTargetGroupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroupAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroupAttributes">REST API Reference for DescribeTargetGroupAttributes Operation</seealso>
        public Task<DescribeTargetGroupAttributesResponse> DescribeTargetGroupAttributesAsync(DescribeTargetGroupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTargetGroupAttributesRequestMarshaller();
            var unmarshaller = DescribeTargetGroupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTargetGroupAttributesRequest,DescribeTargetGroupAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTargetGroups


        /// <summary>
        /// Describes the specified target groups or all of your target groups. By default, all
        /// target groups are described. Alternatively, you can specify one of the following to
        /// filter the results: the ARN of the load balancer, the names of one or more target
        /// groups, or the ARNs of one or more target groups.
        /// 
        ///  
        /// <para>
        /// To describe the targets for a target group, use <a>DescribeTargetHealth</a>. To describe
        /// the attributes of a target group, use <a>DescribeTargetGroupAttributes</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeTargetGroups service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroups">REST API Reference for DescribeTargetGroups Operation</seealso>
        public DescribeTargetGroupsResponse DescribeTargetGroups(DescribeTargetGroupsRequest request)
        {
            var marshaller = new DescribeTargetGroupsRequestMarshaller();
            var unmarshaller = DescribeTargetGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeTargetGroupsRequest,DescribeTargetGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetGroups">REST API Reference for DescribeTargetGroups Operation</seealso>
        public Task<DescribeTargetGroupsResponse> DescribeTargetGroupsAsync(DescribeTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTargetGroupsRequestMarshaller();
            var unmarshaller = DescribeTargetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTargetGroupsRequest,DescribeTargetGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTargetHealth


        /// <summary>
        /// Describes the health of the specified targets or all of your targets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeTargetHealth service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.HealthUnavailableException">
        /// The health of the specified targets could not be retrieved due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist or is not in the same VPC as the target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetHealth">REST API Reference for DescribeTargetHealth Operation</seealso>
        public DescribeTargetHealthResponse DescribeTargetHealth(DescribeTargetHealthRequest request)
        {
            var marshaller = new DescribeTargetHealthRequestMarshaller();
            var unmarshaller = DescribeTargetHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeTargetHealthRequest,DescribeTargetHealthResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTargetHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/DescribeTargetHealth">REST API Reference for DescribeTargetHealth Operation</seealso>
        public Task<DescribeTargetHealthResponse> DescribeTargetHealthAsync(DescribeTargetHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTargetHealthRequestMarshaller();
            var unmarshaller = DescribeTargetHealthResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTargetHealthRequest,DescribeTargetHealthResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyListener


        /// <summary>
        /// Modifies the specified properties of the specified listener.
        /// 
        ///  
        /// <para>
        /// Any properties that you do not specify retain their current values. However, changing
        /// the protocol from HTTPS to HTTP removes the security policy and SSL certificate properties.
        /// If you change the protocol from HTTP to HTTPS, you must add the security policy and
        /// server certificate.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyListener service method.</param>
        /// 
        /// <returns>The response from the ModifyListener service method, as returned by ElasticLoadBalancingV2.</returns>
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
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyCertificatesException">
        /// You've reached the limit on the number of certificates per listener.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyListenersException">
        /// You've reached the limit on the number of listeners per load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.UnsupportedProtocolException">
        /// The specified protocol is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyListener">REST API Reference for ModifyListener Operation</seealso>
        public ModifyListenerResponse ModifyListener(ModifyListenerRequest request)
        {
            var marshaller = new ModifyListenerRequestMarshaller();
            var unmarshaller = ModifyListenerResponseUnmarshaller.Instance;

            return Invoke<ModifyListenerRequest,ModifyListenerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyListener">REST API Reference for ModifyListener Operation</seealso>
        public Task<ModifyListenerResponse> ModifyListenerAsync(ModifyListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyListenerRequestMarshaller();
            var unmarshaller = ModifyListenerResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyListenerRequest,ModifyListenerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyLoadBalancerAttributes


        /// <summary>
        /// Modifies the specified attributes of the specified Application Load Balancer.
        /// 
        ///  
        /// <para>
        /// If any of the specified attributes can't be modified as requested, the call fails.
        /// Any existing attributes that you do not modify retain their current values.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyLoadBalancerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidConfigurationRequestException">
        /// The requested configuration is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyLoadBalancerAttributes">REST API Reference for ModifyLoadBalancerAttributes Operation</seealso>
        public ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request)
        {
            var marshaller = new ModifyLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance;

            return Invoke<ModifyLoadBalancerAttributesRequest,ModifyLoadBalancerAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyLoadBalancerAttributes">REST API Reference for ModifyLoadBalancerAttributes Operation</seealso>
        public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyLoadBalancerAttributesRequest,ModifyLoadBalancerAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyRule


        /// <summary>
        /// Modifies the specified rule.
        /// 
        ///  
        /// <para>
        /// Any existing properties that you do not modify retain their current values.
        /// </para>
        ///  
        /// <para>
        /// To modify the default action, use <a>ModifyListener</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyRule service method.</param>
        /// 
        /// <returns>The response from the ModifyRule service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.RuleNotFoundException">
        /// The specified rule does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupAssociationLimitException">
        /// You've reached the limit on the number of load balancers per target group.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TooManyRegistrationsForTargetIdException">
        /// You've reached the limit on the number of times a target can be registered with a
        /// load balancer.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyRule">REST API Reference for ModifyRule Operation</seealso>
        public ModifyRuleResponse ModifyRule(ModifyRuleRequest request)
        {
            var marshaller = new ModifyRuleRequestMarshaller();
            var unmarshaller = ModifyRuleResponseUnmarshaller.Instance;

            return Invoke<ModifyRuleRequest,ModifyRuleResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyRule">REST API Reference for ModifyRule Operation</seealso>
        public Task<ModifyRuleResponse> ModifyRuleAsync(ModifyRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyRuleRequestMarshaller();
            var unmarshaller = ModifyRuleResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyRuleRequest,ModifyRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyTargetGroup


        /// <summary>
        /// Modifies the health checks used when evaluating the health state of the targets in
        /// the specified target group.
        /// 
        ///  
        /// <para>
        /// To monitor the health of the targets, use <a>DescribeTargetHealth</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroup service method.</param>
        /// 
        /// <returns>The response from the ModifyTargetGroup service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroup">REST API Reference for ModifyTargetGroup Operation</seealso>
        public ModifyTargetGroupResponse ModifyTargetGroup(ModifyTargetGroupRequest request)
        {
            var marshaller = new ModifyTargetGroupRequestMarshaller();
            var unmarshaller = ModifyTargetGroupResponseUnmarshaller.Instance;

            return Invoke<ModifyTargetGroupRequest,ModifyTargetGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroup">REST API Reference for ModifyTargetGroup Operation</seealso>
        public Task<ModifyTargetGroupResponse> ModifyTargetGroupAsync(ModifyTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyTargetGroupRequestMarshaller();
            var unmarshaller = ModifyTargetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyTargetGroupRequest,ModifyTargetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyTargetGroupAttributes


        /// <summary>
        /// Modifies the specified attributes of the specified target group.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroupAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyTargetGroupAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.TargetGroupNotFoundException">
        /// The specified target group does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroupAttributes">REST API Reference for ModifyTargetGroupAttributes Operation</seealso>
        public ModifyTargetGroupAttributesResponse ModifyTargetGroupAttributes(ModifyTargetGroupAttributesRequest request)
        {
            var marshaller = new ModifyTargetGroupAttributesRequestMarshaller();
            var unmarshaller = ModifyTargetGroupAttributesResponseUnmarshaller.Instance;

            return Invoke<ModifyTargetGroupAttributesRequest,ModifyTargetGroupAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyTargetGroupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroupAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/ModifyTargetGroupAttributes">REST API Reference for ModifyTargetGroupAttributes Operation</seealso>
        public Task<ModifyTargetGroupAttributesResponse> ModifyTargetGroupAttributesAsync(ModifyTargetGroupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyTargetGroupAttributesRequestMarshaller();
            var unmarshaller = ModifyTargetGroupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyTargetGroupAttributesRequest,ModifyTargetGroupAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterTargets


        /// <summary>
        /// Registers the specified targets with the specified target group.
        /// 
        ///  
        /// <para>
        /// By default, the load balancer routes requests to registered targets using the protocol
        /// and port number for the target group. Alternatively, you can override the port for
        /// a target when you register it.
        /// </para>
        ///  
        /// <para>
        /// The target must be in the virtual private cloud (VPC) that you specified for the target
        /// group. If the target is an EC2 instance, it must be in the <code>running</code> state
        /// when you register it.
        /// </para>
        ///  
        /// <para>
        /// To remove a target from a target group, use <a>DeregisterTargets</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets service method.</param>
        /// 
        /// <returns>The response from the RegisterTargets service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.InvalidTargetException">
        /// The specified target does not exist or is not in the same VPC as the target group.
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
        public RegisterTargetsResponse RegisterTargets(RegisterTargetsRequest request)
        {
            var marshaller = new RegisterTargetsRequestMarshaller();
            var unmarshaller = RegisterTargetsResponseUnmarshaller.Instance;

            return Invoke<RegisterTargetsRequest,RegisterTargetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RegisterTargets">REST API Reference for RegisterTargets Operation</seealso>
        public Task<RegisterTargetsResponse> RegisterTargetsAsync(RegisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterTargetsRequestMarshaller();
            var unmarshaller = RegisterTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTargetsRequest,RegisterTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes the specified tags from the specified resource.
        /// 
        ///  
        /// <para>
        /// To list the current tags for your resources, use <a>DescribeTags</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
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
        public RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return Invoke<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetIpAddressType


        /// <summary>
        /// Sets the type of IP addresses used by the subnets of the specified Application Load
        /// Balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetIpAddressType service method.</param>
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
        public SetIpAddressTypeResponse SetIpAddressType(SetIpAddressTypeRequest request)
        {
            var marshaller = new SetIpAddressTypeRequestMarshaller();
            var unmarshaller = SetIpAddressTypeResponseUnmarshaller.Instance;

            return Invoke<SetIpAddressTypeRequest,SetIpAddressTypeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetIpAddressType operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetIpAddressType operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetIpAddressType">REST API Reference for SetIpAddressType Operation</seealso>
        public Task<SetIpAddressTypeResponse> SetIpAddressTypeAsync(SetIpAddressTypeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetIpAddressTypeRequestMarshaller();
            var unmarshaller = SetIpAddressTypeResponseUnmarshaller.Instance;

            return InvokeAsync<SetIpAddressTypeRequest,SetIpAddressTypeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetRulePriorities


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
        public SetRulePrioritiesResponse SetRulePriorities(SetRulePrioritiesRequest request)
        {
            var marshaller = new SetRulePrioritiesRequestMarshaller();
            var unmarshaller = SetRulePrioritiesResponseUnmarshaller.Instance;

            return Invoke<SetRulePrioritiesRequest,SetRulePrioritiesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetRulePriorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRulePriorities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetRulePriorities">REST API Reference for SetRulePriorities Operation</seealso>
        public Task<SetRulePrioritiesResponse> SetRulePrioritiesAsync(SetRulePrioritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetRulePrioritiesRequestMarshaller();
            var unmarshaller = SetRulePrioritiesResponseUnmarshaller.Instance;

            return InvokeAsync<SetRulePrioritiesRequest,SetRulePrioritiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetSecurityGroups


        /// <summary>
        /// Associates the specified security groups with the specified load balancer. The specified
        /// security groups override the previously associated security groups.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityGroups service method.</param>
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
        public SetSecurityGroupsResponse SetSecurityGroups(SetSecurityGroupsRequest request)
        {
            var marshaller = new SetSecurityGroupsRequestMarshaller();
            var unmarshaller = SetSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<SetSecurityGroupsRequest,SetSecurityGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSecurityGroups">REST API Reference for SetSecurityGroups Operation</seealso>
        public Task<SetSecurityGroupsResponse> SetSecurityGroupsAsync(SetSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetSecurityGroupsRequestMarshaller();
            var unmarshaller = SetSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<SetSecurityGroupsRequest,SetSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetSubnets


        /// <summary>
        /// Enables the Availability Zone for the specified subnets for the specified load balancer.
        /// The specified subnets replace the previously enabled subnets.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetSubnets service method.</param>
        /// 
        /// <returns>The response from the SetSubnets service method, as returned by ElasticLoadBalancingV2.</returns>
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
        public SetSubnetsResponse SetSubnets(SetSubnetsRequest request)
        {
            var marshaller = new SetSubnetsRequestMarshaller();
            var unmarshaller = SetSubnetsResponseUnmarshaller.Instance;

            return Invoke<SetSubnetsRequest,SetSubnetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancingv2-2015-12-01/SetSubnets">REST API Reference for SetSubnets Operation</seealso>
        public Task<SetSubnetsResponse> SetSubnetsAsync(SetSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetSubnetsRequestMarshaller();
            var unmarshaller = SetSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<SetSubnetsRequest,SetSubnetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}