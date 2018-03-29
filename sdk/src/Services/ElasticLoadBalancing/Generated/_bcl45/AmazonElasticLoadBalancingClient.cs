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
 * Do not modify this file. This file is generated from the elasticloadbalancing-2012-06-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ElasticLoadBalancing.Model;
using Amazon.ElasticLoadBalancing.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Implementation for accessing ElasticLoadBalancing
    ///
    /// Elastic Load Balancing 
    /// <para>
    /// A load balancer can distribute incoming traffic across your EC2 instances. This enables
    /// you to increase the availability of your application. The load balancer also monitors
    /// the health of its registered instances and ensures that it routes traffic only to
    /// healthy instances. You configure your load balancer to accept incoming traffic by
    /// specifying one or more listeners, which are configured with a protocol and port number
    /// for connections from clients to the load balancer and a protocol and port number for
    /// connections from the load balancer to the instances.
    /// </para>
    ///  
    /// <para>
    /// Elastic Load Balancing supports three types of load balancers: Application Load Balancers,
    /// Network Load Balancers, and Classic Load Balancers. You can select a load balancer
    /// based on your application needs. For more information, see the <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/userguide/">Elastic
    /// Load Balancing User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This reference covers the 2012-06-01 API, which supports Classic Load Balancers. The
    /// 2015-12-01 API supports Application Load Balancers and Network Load Balancers.
    /// </para>
    ///  
    /// <para>
    /// To get started, create a load balancer with one or more listeners using <a>CreateLoadBalancer</a>.
    /// Register your instances with the load balancer using <a>RegisterInstancesWithLoadBalancer</a>.
    /// </para>
    ///  
    /// <para>
    /// All Elastic Load Balancing operations are <i>idempotent</i>, which means that they
    /// complete at most one time. If you repeat an operation, it succeeds with a 200 OK response
    /// code.
    /// </para>
    /// </summary>
    public partial class AmazonElasticLoadBalancingClient : AmazonServiceClient, IAmazonElasticLoadBalancing
    {
        #region Constructors

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig()) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        public AmazonElasticLoadBalancingClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonElasticLoadBalancingConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AmazonElasticLoadBalancingConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials)
            : this(credentials, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonElasticLoadBalancingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Credentials and an
        /// AmazonElasticLoadBalancingClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(AWSCredentials credentials, AmazonElasticLoadBalancingConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonElasticLoadBalancingConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonElasticLoadBalancingConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonElasticLoadBalancingConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonElasticLoadBalancingClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonElasticLoadBalancingClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonElasticLoadBalancingClient Configuration Object</param>
        public AmazonElasticLoadBalancingClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonElasticLoadBalancingConfig clientConfig)
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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.ElasticLoadBalancing.Internal.ProcessRequestHandler());
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
        /// Adds the specified tags to the specified load balancer. Each load balancer can have
        /// a maximum of 10 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a tag with the same key is already
        /// associated with the load balancer, <code>AddTags</code> updates its value.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/add-remove-tags.html">Tag
        /// Your Classic Load Balancer</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AddTags service method.</param>
        /// 
        /// <returns>The response from the AddTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyTagsException">
        /// The quota for the number of tags that can be assigned to a load balancer has been
        /// reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual AddTagsResponse AddTags(AddTagsRequest request)
        {
            var marshaller = AddTagsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/AddTags">REST API Reference for AddTags Operation</seealso>
        public virtual Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AddTagsRequestMarshaller.Instance;
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsRequest,AddTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ApplySecurityGroupsToLoadBalancer


        /// <summary>
        /// Associates one or more security groups with your load balancer in a virtual private
        /// cloud (VPC). The specified security groups override the previously associated security
        /// groups.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-security-groups.html#elb-vpc-security-groups">Security
        /// Groups for Load Balancers in a VPC</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException">
        /// One or more of the specified security groups do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/ApplySecurityGroupsToLoadBalancer">REST API Reference for ApplySecurityGroupsToLoadBalancer Operation</seealso>
        public virtual ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest request)
        {
            var marshaller = ApplySecurityGroupsToLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<ApplySecurityGroupsToLoadBalancerRequest,ApplySecurityGroupsToLoadBalancerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/ApplySecurityGroupsToLoadBalancer">REST API Reference for ApplySecurityGroupsToLoadBalancer Operation</seealso>
        public virtual Task<ApplySecurityGroupsToLoadBalancerResponse> ApplySecurityGroupsToLoadBalancerAsync(ApplySecurityGroupsToLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ApplySecurityGroupsToLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = ApplySecurityGroupsToLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<ApplySecurityGroupsToLoadBalancerRequest,ApplySecurityGroupsToLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachLoadBalancerToSubnets


        /// <summary>
        /// Adds one or more subnets to the set of configured subnets for the specified load balancer.
        /// 
        ///  
        /// <para>
        /// The load balancer evenly distributes requests across all registered subnets. For more
        /// information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-manage-subnets.html">Add
        /// or Remove Subnets for Your Load Balancer in a VPC</a> in the <i>Classic Load Balancer
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets service method.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerToSubnets service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSubnetException">
        /// The specified VPC has no associated Internet gateway.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException">
        /// One or more of the specified subnets do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/AttachLoadBalancerToSubnets">REST API Reference for AttachLoadBalancerToSubnets Operation</seealso>
        public virtual AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest request)
        {
            var marshaller = AttachLoadBalancerToSubnetsRequestMarshaller.Instance;
            var unmarshaller = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance;

            return Invoke<AttachLoadBalancerToSubnetsRequest,AttachLoadBalancerToSubnetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachLoadBalancerToSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/AttachLoadBalancerToSubnets">REST API Reference for AttachLoadBalancerToSubnets Operation</seealso>
        public virtual Task<AttachLoadBalancerToSubnetsResponse> AttachLoadBalancerToSubnetsAsync(AttachLoadBalancerToSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = AttachLoadBalancerToSubnetsRequestMarshaller.Instance;
            var unmarshaller = AttachLoadBalancerToSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<AttachLoadBalancerToSubnetsRequest,AttachLoadBalancerToSubnetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ConfigureHealthCheck


        /// <summary>
        /// Specifies the health check settings to use when evaluating the health state of your
        /// EC2 instances.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-healthchecks.html">Configure
        /// Health Checks for Your Load Balancer</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck service method.</param>
        /// 
        /// <returns>The response from the ConfigureHealthCheck service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/ConfigureHealthCheck">REST API Reference for ConfigureHealthCheck Operation</seealso>
        public virtual ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest request)
        {
            var marshaller = ConfigureHealthCheckRequestMarshaller.Instance;
            var unmarshaller = ConfigureHealthCheckResponseUnmarshaller.Instance;

            return Invoke<ConfigureHealthCheckRequest,ConfigureHealthCheckResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfigureHealthCheck operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfigureHealthCheck operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/ConfigureHealthCheck">REST API Reference for ConfigureHealthCheck Operation</seealso>
        public virtual Task<ConfigureHealthCheckResponse> ConfigureHealthCheckAsync(ConfigureHealthCheckRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ConfigureHealthCheckRequestMarshaller.Instance;
            var unmarshaller = ConfigureHealthCheckResponseUnmarshaller.Instance;

            return InvokeAsync<ConfigureHealthCheckRequest,ConfigureHealthCheckResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateAppCookieStickinessPolicy


        /// <summary>
        /// Generates a stickiness policy with sticky session lifetimes that follow that of an
        /// application-generated cookie. This policy can be associated only with HTTP/HTTPS listeners.
        /// 
        ///  
        /// <para>
        /// This policy is similar to the policy created by <a>CreateLBCookieStickinessPolicy</a>,
        /// except that the lifetime of the special Elastic Load Balancing cookie, <code>AWSELB</code>,
        /// follows the lifetime of the application-generated cookie specified in the policy configuration.
        /// The load balancer only inserts a new stickiness cookie when the application response
        /// includes a new application cookie.
        /// </para>
        ///  
        /// <para>
        /// If the application cookie is explicitly removed or expires, the session stops being
        /// sticky until a new application cookie is issued.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-application">Application-Controlled
        /// Session Stickiness</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateAppCookieStickinessPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// A policy with the specified name already exists for this load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// The quota for the number of policies for this load balancer has been reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateAppCookieStickinessPolicy">REST API Reference for CreateAppCookieStickinessPolicy Operation</seealso>
        public virtual CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request)
        {
            var marshaller = CreateAppCookieStickinessPolicyRequestMarshaller.Instance;
            var unmarshaller = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateAppCookieStickinessPolicyRequest,CreateAppCookieStickinessPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateAppCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateAppCookieStickinessPolicy">REST API Reference for CreateAppCookieStickinessPolicy Operation</seealso>
        public virtual Task<CreateAppCookieStickinessPolicyResponse> CreateAppCookieStickinessPolicyAsync(CreateAppCookieStickinessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateAppCookieStickinessPolicyRequestMarshaller.Instance;
            var unmarshaller = CreateAppCookieStickinessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateAppCookieStickinessPolicyRequest,CreateAppCookieStickinessPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLBCookieStickinessPolicy


        /// <summary>
        /// Generates a stickiness policy with sticky session lifetimes controlled by the lifetime
        /// of the browser (user-agent) or a specified expiration period. This policy can be associated
        /// only with HTTP/HTTPS listeners.
        /// 
        ///  
        /// <para>
        /// When a load balancer implements this policy, the load balancer uses a special cookie
        /// to track the instance for each request. When the load balancer receives a request,
        /// it first checks to see if this cookie is present in the request. If so, the load balancer
        /// sends the request to the application server specified in the cookie. If not, the load
        /// balancer sends the request to a server that is chosen based on the existing load-balancing
        /// algorithm.
        /// </para>
        ///  
        /// <para>
        /// A cookie is inserted into the response for binding subsequent requests from the same
        /// user to that server. The validity of the cookie is based on the cookie expiration
        /// time, which is specified in the policy configuration.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-duration">Duration-Based
        /// Session Stickiness</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// A policy with the specified name already exists for this load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// The quota for the number of policies for this load balancer has been reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLBCookieStickinessPolicy">REST API Reference for CreateLBCookieStickinessPolicy Operation</seealso>
        public virtual CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request)
        {
            var marshaller = CreateLBCookieStickinessPolicyRequestMarshaller.Instance;
            var unmarshaller = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateLBCookieStickinessPolicyRequest,CreateLBCookieStickinessPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLBCookieStickinessPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLBCookieStickinessPolicy">REST API Reference for CreateLBCookieStickinessPolicy Operation</seealso>
        public virtual Task<CreateLBCookieStickinessPolicyResponse> CreateLBCookieStickinessPolicyAsync(CreateLBCookieStickinessPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLBCookieStickinessPolicyRequestMarshaller.Instance;
            var unmarshaller = CreateLBCookieStickinessPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLBCookieStickinessPolicyRequest,CreateLBCookieStickinessPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancer


        /// <summary>
        /// Creates a Classic Load Balancer.
        /// 
        ///  
        /// <para>
        /// You can add listeners, security groups, subnets, and tags when you create your load
        /// balancer, or you can add them later using <a>CreateLoadBalancerListeners</a>, <a>ApplySecurityGroupsToLoadBalancer</a>,
        /// <a>AttachLoadBalancerToSubnets</a>, and <a>AddTags</a>.
        /// </para>
        ///  
        /// <para>
        /// To describe your current load balancers, see <a>DescribeLoadBalancers</a>. When you
        /// are finished with a load balancer, you can delete it using <a>DeleteLoadBalancer</a>.
        /// </para>
        ///  
        /// <para>
        /// You can create up to 20 load balancers per region per account. You can request an
        /// increase for the number of load balancers for your account. For more information,
        /// see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-limits.html">Limits
        /// for Your Classic Load Balancer</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified ARN does not refer to a valid SSL certificate in AWS Identity and Access
        /// Management (IAM) or AWS Certificate Manager (ACM). Note that if you recently uploaded
        /// the certificate to IAM, this error might indicate that the certificate is not fully
        /// available yet.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateAccessPointNameException">
        /// The specified load balancer name already exists for this account.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSchemeException">
        /// The specified value for the schema is not valid. You can only specify a scheme for
        /// load balancers in a VPC.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException">
        /// One or more of the specified security groups do not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidSubnetException">
        /// The specified VPC has no associated Internet gateway.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.OperationNotPermittedException">
        /// This operation is not allowed.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException">
        /// One or more of the specified subnets do not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyAccessPointsException">
        /// The quota for the number of load balancers has been reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyTagsException">
        /// The quota for the number of tags that can be assigned to a load balancer has been
        /// reached.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.UnsupportedProtocolException">
        /// The specified protocol or signature version is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        public virtual CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
        {
            var marshaller = CreateLoadBalancerRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLoadBalancer">REST API Reference for CreateLoadBalancer Operation</seealso>
        public virtual Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerRequest,CreateLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancerListeners


        /// <summary>
        /// Creates one or more listeners for the specified load balancer. If a listener with
        /// the specified port does not already exist, it is created; otherwise, the properties
        /// of the new listener must match the properties of the existing listener.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-listener-config.html">Listeners
        /// for Your Classic Load Balancer</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerListeners service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified ARN does not refer to a valid SSL certificate in AWS Identity and Access
        /// Management (IAM) or AWS Certificate Manager (ACM). Note that if you recently uploaded
        /// the certificate to IAM, this error might indicate that the certificate is not fully
        /// available yet.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicateListenerException">
        /// A listener already exists for the specified load balancer name and port, but with
        /// a different instance port, protocol, or SSL certificate.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.UnsupportedProtocolException">
        /// The specified protocol or signature version is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLoadBalancerListeners">REST API Reference for CreateLoadBalancerListeners Operation</seealso>
        public virtual CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest request)
        {
            var marshaller = CreateLoadBalancerListenersRequestMarshaller.Instance;
            var unmarshaller = CreateLoadBalancerListenersResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerListenersRequest,CreateLoadBalancerListenersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLoadBalancerListeners">REST API Reference for CreateLoadBalancerListeners Operation</seealso>
        public virtual Task<CreateLoadBalancerListenersResponse> CreateLoadBalancerListenersAsync(CreateLoadBalancerListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLoadBalancerListenersRequestMarshaller.Instance;
            var unmarshaller = CreateLoadBalancerListenersResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerListenersRequest,CreateLoadBalancerListenersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancerPolicy


        /// <summary>
        /// Creates a policy with the specified attributes for the specified load balancer.
        /// 
        ///  
        /// <para>
        /// Policies are settings that are saved for your load balancer and that can be applied
        /// to the listener or the application server, depending on the policy type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException">
        /// A policy with the specified name already exists for this load balancer.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException">
        /// The quota for the number of policies for this load balancer has been reached.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLoadBalancerPolicy">REST API Reference for CreateLoadBalancerPolicy Operation</seealso>
        public virtual CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest request)
        {
            var marshaller = CreateLoadBalancerPolicyRequestMarshaller.Instance;
            var unmarshaller = CreateLoadBalancerPolicyResponseUnmarshaller.Instance;

            return Invoke<CreateLoadBalancerPolicyRequest,CreateLoadBalancerPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/CreateLoadBalancerPolicy">REST API Reference for CreateLoadBalancerPolicy Operation</seealso>
        public virtual Task<CreateLoadBalancerPolicyResponse> CreateLoadBalancerPolicyAsync(CreateLoadBalancerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateLoadBalancerPolicyRequestMarshaller.Instance;
            var unmarshaller = CreateLoadBalancerPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerPolicyRequest,CreateLoadBalancerPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancer


        /// <summary>
        /// Deletes the specified load balancer.
        /// 
        ///  
        /// <para>
        /// If you are attempting to recreate a load balancer, you must reconfigure all settings.
        /// The DNS name associated with a deleted load balancer are no longer usable. The name
        /// and associated DNS record of the deleted load balancer no longer exist and traffic
        /// sent to any of its IP addresses is no longer delivered to your instances.
        /// </para>
        ///  
        /// <para>
        /// If the load balancer does not exist or has already been deleted, the call to <code>DeleteLoadBalancer</code>
        /// still succeeds.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        public virtual DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
        {
            var marshaller = DeleteLoadBalancerRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeleteLoadBalancer">REST API Reference for DeleteLoadBalancer Operation</seealso>
        public virtual Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerRequest,DeleteLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancerListeners


        /// <summary>
        /// Deletes the specified listeners from the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerListeners service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeleteLoadBalancerListeners">REST API Reference for DeleteLoadBalancerListeners Operation</seealso>
        public virtual DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest request)
        {
            var marshaller = DeleteLoadBalancerListenersRequestMarshaller.Instance;
            var unmarshaller = DeleteLoadBalancerListenersResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerListenersRequest,DeleteLoadBalancerListenersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeleteLoadBalancerListeners">REST API Reference for DeleteLoadBalancerListeners Operation</seealso>
        public virtual Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListenersAsync(DeleteLoadBalancerListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLoadBalancerListenersRequestMarshaller.Instance;
            var unmarshaller = DeleteLoadBalancerListenersResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerListenersRequest,DeleteLoadBalancerListenersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancerPolicy


        /// <summary>
        /// Deletes the specified policy from the specified load balancer. This policy must not
        /// be enabled for any listeners.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeleteLoadBalancerPolicy">REST API Reference for DeleteLoadBalancerPolicy Operation</seealso>
        public virtual DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request)
        {
            var marshaller = DeleteLoadBalancerPolicyRequestMarshaller.Instance;
            var unmarshaller = DeleteLoadBalancerPolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteLoadBalancerPolicyRequest,DeleteLoadBalancerPolicyResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancerPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeleteLoadBalancerPolicy">REST API Reference for DeleteLoadBalancerPolicy Operation</seealso>
        public virtual Task<DeleteLoadBalancerPolicyResponse> DeleteLoadBalancerPolicyAsync(DeleteLoadBalancerPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteLoadBalancerPolicyRequestMarshaller.Instance;
            var unmarshaller = DeleteLoadBalancerPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerPolicyRequest,DeleteLoadBalancerPolicyResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterInstancesFromLoadBalancer


        /// <summary>
        /// Deregisters the specified instances from the specified load balancer. After the instance
        /// is deregistered, it no longer receives traffic from the load balancer.
        /// 
        ///  
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> to verify that the instance is deregistered
        /// from the load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-deregister-register-instances.html">Register
        /// or De-Register EC2 Instances</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DeregisterInstancesFromLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified endpoint is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeregisterInstancesFromLoadBalancer">REST API Reference for DeregisterInstancesFromLoadBalancer Operation</seealso>
        public virtual DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request)
        {
            var marshaller = DeregisterInstancesFromLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DeregisterInstancesFromLoadBalancerRequest,DeregisterInstancesFromLoadBalancerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterInstancesFromLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterInstancesFromLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DeregisterInstancesFromLoadBalancer">REST API Reference for DeregisterInstancesFromLoadBalancer Operation</seealso>
        public virtual Task<DeregisterInstancesFromLoadBalancerResponse> DeregisterInstancesFromLoadBalancerAsync(DeregisterInstancesFromLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeregisterInstancesFromLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = DeregisterInstancesFromLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterInstancesFromLoadBalancerRequest,DeregisterInstancesFromLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountLimits


        /// <summary>
        /// Describes the current Elastic Load Balancing resource limits for your AWS account.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-limits.html">Limits
        /// for Your Classic Load Balancer</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountLimits service method, as returned by ElasticLoadBalancing.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual DescribeAccountLimitsResponse DescribeAccountLimits(DescribeAccountLimitsRequest request)
        {
            var marshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountLimitsRequest,DescribeAccountLimitsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountLimits operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountLimits operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeAccountLimits">REST API Reference for DescribeAccountLimits Operation</seealso>
        public virtual Task<DescribeAccountLimitsResponse> DescribeAccountLimitsAsync(DescribeAccountLimitsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeAccountLimitsRequestMarshaller.Instance;
            var unmarshaller = DescribeAccountLimitsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountLimitsRequest,DescribeAccountLimitsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceHealth


        /// <summary>
        /// Describes the state of the specified instances with respect to the specified load
        /// balancer. If no instances are specified, the call describes the state of all instances
        /// that are currently registered with the load balancer. If instances are specified,
        /// their state is returned even if they are no longer registered with the load balancer.
        /// The state of terminated instances is not returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceHealth service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified endpoint is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeInstanceHealth">REST API Reference for DescribeInstanceHealth Operation</seealso>
        public virtual DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request)
        {
            var marshaller = DescribeInstanceHealthRequestMarshaller.Instance;
            var unmarshaller = DescribeInstanceHealthResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceHealthRequest,DescribeInstanceHealthResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeInstanceHealth">REST API Reference for DescribeInstanceHealth Operation</seealso>
        public virtual Task<DescribeInstanceHealthResponse> DescribeInstanceHealthAsync(DescribeInstanceHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeInstanceHealthRequestMarshaller.Instance;
            var unmarshaller = DescribeInstanceHealthResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceHealthRequest,DescribeInstanceHealthResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerAttributes


        /// <summary>
        /// Describes the attributes for the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.LoadBalancerAttributeNotFoundException">
        /// The specified load balancer attribute does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerAttributes">REST API Reference for DescribeLoadBalancerAttributes Operation</seealso>
        public virtual DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request)
        {
            var marshaller = DescribeLoadBalancerAttributesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerAttributes">REST API Reference for DescribeLoadBalancerAttributes Operation</seealso>
        public virtual Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLoadBalancerAttributesRequestMarshaller.Instance;
            var unmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancerAttributesRequest,DescribeLoadBalancerAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerPolicies


        /// <summary>
        /// Describes the specified policies.
        /// 
        ///  
        /// <para>
        /// If you specify a load balancer name, the action returns the descriptions of all policies
        /// created for the load balancer. If you specify a policy name associated with your load
        /// balancer, the action returns the description of that policy. If you don't specify
        /// a load balancer name, the action returns descriptions of the specified sample policies,
        /// or descriptions of all sample policies. The names of the sample policies have the
        /// <code>ELBSample-</code> prefix.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicies">REST API Reference for DescribeLoadBalancerPolicies Operation</seealso>
        public virtual DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies()
        {
            return DescribeLoadBalancerPolicies(new DescribeLoadBalancerPoliciesRequest());
        }


        /// <summary>
        /// Describes the specified policies.
        /// 
        ///  
        /// <para>
        /// If you specify a load balancer name, the action returns the descriptions of all policies
        /// created for the load balancer. If you specify a policy name associated with your load
        /// balancer, the action returns the description of that policy. If you don't specify
        /// a load balancer name, the action returns descriptions of the specified sample policies,
        /// or descriptions of all sample policies. The names of the sample policies have the
        /// <code>ELBSample-</code> prefix.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicies">REST API Reference for DescribeLoadBalancerPolicies Operation</seealso>
        public virtual DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest request)
        {
            var marshaller = DescribeLoadBalancerPoliciesRequestMarshaller.Instance;
            var unmarshaller = DescribeLoadBalancerPoliciesResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancerPoliciesRequest,DescribeLoadBalancerPoliciesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the specified policies.
        /// 
        ///  
        /// <para>
        /// If you specify a load balancer name, the action returns the descriptions of all policies
        /// created for the load balancer. If you specify a policy name associated with your load
        /// balancer, the action returns the description of that policy. If you don't specify
        /// a load balancer name, the action returns descriptions of the specified sample policies,
        /// or descriptions of all sample policies. The names of the sample policies have the
        /// <code>ELBSample-</code> prefix.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicies">REST API Reference for DescribeLoadBalancerPolicies Operation</seealso>
        public virtual Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLoadBalancerPoliciesAsync(new DescribeLoadBalancerPoliciesRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicies">REST API Reference for DescribeLoadBalancerPolicies Operation</seealso>
        public virtual Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(DescribeLoadBalancerPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLoadBalancerPoliciesRequestMarshaller.Instance;
            var unmarshaller = DescribeLoadBalancerPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancerPoliciesRequest,DescribeLoadBalancerPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerPolicyTypes


        /// <summary>
        /// Describes the specified load balancer policy types or all load balancer policy types.
        /// 
        ///  
        /// <para>
        /// The description of each type indicates how it can be used. For example, some policies
        /// can be used only with layer 7 listeners, some policies can be used only with layer
        /// 4 listeners, and some policies can be used only with your EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>CreateLoadBalancerPolicy</a> to create a policy configuration for any
        /// of these policy types. Then, depending on the policy type, use either <a>SetLoadBalancerPoliciesOfListener</a>
        /// or <a>SetLoadBalancerPoliciesForBackendServer</a> to set the policy.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicyTypes">REST API Reference for DescribeLoadBalancerPolicyTypes Operation</seealso>
        public virtual DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes()
        {
            return DescribeLoadBalancerPolicyTypes(new DescribeLoadBalancerPolicyTypesRequest());
        }


        /// <summary>
        /// Describes the specified load balancer policy types or all load balancer policy types.
        /// 
        ///  
        /// <para>
        /// The description of each type indicates how it can be used. For example, some policies
        /// can be used only with layer 7 listeners, some policies can be used only with layer
        /// 4 listeners, and some policies can be used only with your EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>CreateLoadBalancerPolicy</a> to create a policy configuration for any
        /// of these policy types. Then, depending on the policy type, use either <a>SetLoadBalancerPoliciesOfListener</a>
        /// or <a>SetLoadBalancerPoliciesForBackendServer</a> to set the policy.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicyTypes">REST API Reference for DescribeLoadBalancerPolicyTypes Operation</seealso>
        public virtual DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest request)
        {
            var marshaller = DescribeLoadBalancerPolicyTypesRequestMarshaller.Instance;
            var unmarshaller = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancerPolicyTypesRequest,DescribeLoadBalancerPolicyTypesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the specified load balancer policy types or all load balancer policy types.
        /// 
        ///  
        /// <para>
        /// The description of each type indicates how it can be used. For example, some policies
        /// can be used only with layer 7 listeners, some policies can be used only with layer
        /// 4 listeners, and some policies can be used only with your EC2 instances.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>CreateLoadBalancerPolicy</a> to create a policy configuration for any
        /// of these policy types. Then, depending on the policy type, use either <a>SetLoadBalancerPoliciesOfListener</a>
        /// or <a>SetLoadBalancerPoliciesForBackendServer</a> to set the policy.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException">
        /// One or more of the specified policy types do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicyTypes">REST API Reference for DescribeLoadBalancerPolicyTypes Operation</seealso>
        public virtual Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLoadBalancerPolicyTypesAsync(new DescribeLoadBalancerPolicyTypesRequest(), cancellationToken);
        }
        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerPolicyTypes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancerPolicyTypes">REST API Reference for DescribeLoadBalancerPolicyTypes Operation</seealso>
        public virtual Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(DescribeLoadBalancerPolicyTypesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLoadBalancerPolicyTypesRequestMarshaller.Instance;
            var unmarshaller = DescribeLoadBalancerPolicyTypesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancerPolicyTypesRequest,DescribeLoadBalancerPolicyTypesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancers


        /// <summary>
        /// Describes the specified the load balancers. If no load balancers are specified, the
        /// call describes all of your load balancers.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DependencyThrottleException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual DescribeLoadBalancersResponse DescribeLoadBalancers()
        {
            return DescribeLoadBalancers(new DescribeLoadBalancersRequest());
        }


        /// <summary>
        /// Describes the specified the load balancers. If no load balancers are specified, the
        /// call describes all of your load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DependencyThrottleException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
        {
            var marshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return Invoke<DescribeLoadBalancersRequest,DescribeLoadBalancersResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the specified the load balancers. If no load balancers are specified, the
        /// call describes all of your load balancers.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.DependencyThrottleException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLoadBalancersAsync(new DescribeLoadBalancersRequest(), cancellationToken);
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeLoadBalancers">REST API Reference for DescribeLoadBalancers Operation</seealso>
        public virtual Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeLoadBalancersRequestMarshaller.Instance;
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancersRequest,DescribeLoadBalancersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the tags associated with the specified load balancers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = DescribeTagsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeTagsRequestMarshaller.Instance;
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachLoadBalancerFromSubnets


        /// <summary>
        /// Removes the specified subnets from the set of configured subnets for the load balancer.
        /// 
        ///  
        /// <para>
        /// After a subnet is removed, all EC2 instances registered with the load balancer in
        /// the removed subnet go into the <code>OutOfService</code> state. Then, the load balancer
        /// balances the traffic among the remaining routable subnets.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets service method.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerFromSubnets service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DetachLoadBalancerFromSubnets">REST API Reference for DetachLoadBalancerFromSubnets Operation</seealso>
        public virtual DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest request)
        {
            var marshaller = DetachLoadBalancerFromSubnetsRequestMarshaller.Instance;
            var unmarshaller = DetachLoadBalancerFromSubnetsResponseUnmarshaller.Instance;

            return Invoke<DetachLoadBalancerFromSubnetsRequest,DetachLoadBalancerFromSubnetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachLoadBalancerFromSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DetachLoadBalancerFromSubnets">REST API Reference for DetachLoadBalancerFromSubnets Operation</seealso>
        public virtual Task<DetachLoadBalancerFromSubnetsResponse> DetachLoadBalancerFromSubnetsAsync(DetachLoadBalancerFromSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DetachLoadBalancerFromSubnetsRequestMarshaller.Instance;
            var unmarshaller = DetachLoadBalancerFromSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<DetachLoadBalancerFromSubnetsRequest,DetachLoadBalancerFromSubnetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableAvailabilityZonesForLoadBalancer


        /// <summary>
        /// Removes the specified Availability Zones from the set of Availability Zones for the
        /// specified load balancer.
        /// 
        ///  
        /// <para>
        /// There must be at least one Availability Zone registered with a load balancer at all
        /// times. After an Availability Zone is removed, all instances registered with the load
        /// balancer that are in the removed Availability Zone go into the <code>OutOfService</code>
        /// state. Then, the load balancer attempts to equally balance the traffic among its remaining
        /// Availability Zones.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-disable-az.html">Add
        /// or Remove Availability Zones</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the DisableAvailabilityZonesForLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DisableAvailabilityZonesForLoadBalancer">REST API Reference for DisableAvailabilityZonesForLoadBalancer Operation</seealso>
        public virtual DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request)
        {
            var marshaller = DisableAvailabilityZonesForLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<DisableAvailabilityZonesForLoadBalancerRequest,DisableAvailabilityZonesForLoadBalancerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/DisableAvailabilityZonesForLoadBalancer">REST API Reference for DisableAvailabilityZonesForLoadBalancer Operation</seealso>
        public virtual Task<DisableAvailabilityZonesForLoadBalancerResponse> DisableAvailabilityZonesForLoadBalancerAsync(DisableAvailabilityZonesForLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DisableAvailabilityZonesForLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = DisableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DisableAvailabilityZonesForLoadBalancerRequest,DisableAvailabilityZonesForLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableAvailabilityZonesForLoadBalancer


        /// <summary>
        /// Adds the specified Availability Zones to the set of Availability Zones for the specified
        /// load balancer.
        /// 
        ///  
        /// <para>
        /// The load balancer evenly distributes requests across all its registered Availability
        /// Zones that contain instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-disable-az.html">Add
        /// or Remove Availability Zones</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the EnableAvailabilityZonesForLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/EnableAvailabilityZonesForLoadBalancer">REST API Reference for EnableAvailabilityZonesForLoadBalancer Operation</seealso>
        public virtual EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request)
        {
            var marshaller = EnableAvailabilityZonesForLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<EnableAvailabilityZonesForLoadBalancerRequest,EnableAvailabilityZonesForLoadBalancerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableAvailabilityZonesForLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableAvailabilityZonesForLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/EnableAvailabilityZonesForLoadBalancer">REST API Reference for EnableAvailabilityZonesForLoadBalancer Operation</seealso>
        public virtual Task<EnableAvailabilityZonesForLoadBalancerResponse> EnableAvailabilityZonesForLoadBalancerAsync(EnableAvailabilityZonesForLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = EnableAvailabilityZonesForLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = EnableAvailabilityZonesForLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<EnableAvailabilityZonesForLoadBalancerRequest,EnableAvailabilityZonesForLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyLoadBalancerAttributes


        /// <summary>
        /// Modifies the attributes of the specified load balancer.
        /// 
        ///  
        /// <para>
        /// You can modify the load balancer attributes, such as <code>AccessLogs</code>, <code>ConnectionDraining</code>,
        /// and <code>CrossZoneLoadBalancing</code> by either enabling or disabling them. Or,
        /// you can modify the load balancer attribute <code>ConnectionSettings</code> by specifying
        /// an idle connection timeout value for your load balancer.
        /// </para>
        ///  
        /// <para>
        /// For more information, see the following in the <i>Classic Load Balancer Guide</i>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-disable-crosszone-lb.html">Cross-Zone
        /// Load Balancing</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/config-conn-drain.html">Connection
        /// Draining</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/access-log-collection.html">Access
        /// Logs</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/config-idle-timeout.html">Idle
        /// Connection Timeout</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the ModifyLoadBalancerAttributes service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.LoadBalancerAttributeNotFoundException">
        /// The specified load balancer attribute does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/ModifyLoadBalancerAttributes">REST API Reference for ModifyLoadBalancerAttributes Operation</seealso>
        public virtual ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request)
        {
            var marshaller = ModifyLoadBalancerAttributesRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/ModifyLoadBalancerAttributes">REST API Reference for ModifyLoadBalancerAttributes Operation</seealso>
        public virtual Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ModifyLoadBalancerAttributesRequestMarshaller.Instance;
            var unmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyLoadBalancerAttributesRequest,ModifyLoadBalancerAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterInstancesWithLoadBalancer


        /// <summary>
        /// Adds the specified instances to the specified load balancer.
        /// 
        ///  
        /// <para>
        /// The instance must be a running instance in the same network as the load balancer (EC2-Classic
        /// or the same VPC). If you have EC2-Classic instances and a load balancer in a VPC with
        /// ClassicLink enabled, you can link the EC2-Classic instances to that VPC and then register
        /// the linked EC2-Classic instances with the load balancer in the VPC.
        /// </para>
        ///  
        /// <para>
        /// Note that <code>RegisterInstanceWithLoadBalancer</code> completes when the request
        /// has been registered. Instance registration takes a little time to complete. To check
        /// the state of the registered instances, use <a>DescribeLoadBalancers</a> or <a>DescribeInstanceHealth</a>.
        /// </para>
        ///  
        /// <para>
        /// After the instance is registered, it starts receiving traffic and requests from the
        /// load balancer. Any instance that is not in one of the Availability Zones registered
        /// for the load balancer is moved to the <code>OutOfService</code> state. If an Availability
        /// Zone is added to the load balancer later, any instances registered with the load balancer
        /// move to the <code>InService</code> state.
        /// </para>
        ///  
        /// <para>
        /// To deregister instances from a load balancer, use <a>DeregisterInstancesFromLoadBalancer</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-deregister-register-instances.html">Register
        /// or De-Register EC2 Instances</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the RegisterInstancesWithLoadBalancer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidEndPointException">
        /// The specified endpoint is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/RegisterInstancesWithLoadBalancer">REST API Reference for RegisterInstancesWithLoadBalancer Operation</seealso>
        public virtual RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request)
        {
            var marshaller = RegisterInstancesWithLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = RegisterInstancesWithLoadBalancerResponseUnmarshaller.Instance;

            return Invoke<RegisterInstancesWithLoadBalancerRequest,RegisterInstancesWithLoadBalancerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterInstancesWithLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterInstancesWithLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/RegisterInstancesWithLoadBalancer">REST API Reference for RegisterInstancesWithLoadBalancer Operation</seealso>
        public virtual Task<RegisterInstancesWithLoadBalancerResponse> RegisterInstancesWithLoadBalancerAsync(RegisterInstancesWithLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RegisterInstancesWithLoadBalancerRequestMarshaller.Instance;
            var unmarshaller = RegisterInstancesWithLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterInstancesWithLoadBalancerRequest,RegisterInstancesWithLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags


        /// <summary>
        /// Removes one or more tags from the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags service method.</param>
        /// 
        /// <returns>The response from the RemoveTags service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
        {
            var marshaller = RemoveTagsRequestMarshaller.Instance;
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
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/RemoveTags">REST API Reference for RemoveTags Operation</seealso>
        public virtual Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = RemoveTagsRequestMarshaller.Instance;
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetLoadBalancerListenerSSLCertificate


        /// <summary>
        /// Sets the certificate that terminates the specified listener's SSL connections. The
        /// specified certificate replaces any prior certificate that was used on the same load
        /// balancer and port.
        /// 
        ///  
        /// <para>
        /// For more information about updating your SSL certificate, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-update-ssl-cert.html">Replace
        /// the SSL Certificate for Your Load Balancer</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException">
        /// The specified ARN does not refer to a valid SSL certificate in AWS Identity and Access
        /// Management (IAM) or AWS Certificate Manager (ACM). Note that if you recently uploaded
        /// the certificate to IAM, this error might indicate that the certificate is not fully
        /// available yet.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException">
        /// The load balancer does not have a listener configured at the specified port.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.UnsupportedProtocolException">
        /// The specified protocol or signature version is not supported.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/SetLoadBalancerListenerSSLCertificate">REST API Reference for SetLoadBalancerListenerSSLCertificate Operation</seealso>
        public virtual SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest request)
        {
            var marshaller = SetLoadBalancerListenerSSLCertificateRequestMarshaller.Instance;
            var unmarshaller = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance;

            return Invoke<SetLoadBalancerListenerSSLCertificateRequest,SetLoadBalancerListenerSSLCertificateResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerListenerSSLCertificate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerListenerSSLCertificate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/SetLoadBalancerListenerSSLCertificate">REST API Reference for SetLoadBalancerListenerSSLCertificate Operation</seealso>
        public virtual Task<SetLoadBalancerListenerSSLCertificateResponse> SetLoadBalancerListenerSSLCertificateAsync(SetLoadBalancerListenerSSLCertificateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetLoadBalancerListenerSSLCertificateRequestMarshaller.Instance;
            var unmarshaller = SetLoadBalancerListenerSSLCertificateResponseUnmarshaller.Instance;

            return InvokeAsync<SetLoadBalancerListenerSSLCertificateRequest,SetLoadBalancerListenerSSLCertificateResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetLoadBalancerPoliciesForBackendServer


        /// <summary>
        /// Replaces the set of policies associated with the specified port on which the EC2 instance
        /// is listening with a new set of policies. At this time, only the back-end server authentication
        /// policy type can be applied to the instance ports; this policy type is composed of
        /// multiple public key policies.
        /// 
        ///  
        /// <para>
        /// Each time you use <code>SetLoadBalancerPoliciesForBackendServer</code> to enable the
        /// policies, use the <code>PolicyNames</code> parameter to list the policies that you
        /// want to enable.
        /// </para>
        ///  
        /// <para>
        /// You can use <a>DescribeLoadBalancers</a> or <a>DescribeLoadBalancerPolicies</a> to
        /// verify that the policy is associated with the EC2 instance.
        /// </para>
        ///  
        /// <para>
        /// For more information about enabling back-end instance authentication, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-create-https-ssl-load-balancer.html#configure_backendauth_clt">Configure
        /// Back-end Instance Authentication</a> in the <i>Classic Load Balancer Guide</i>. For
        /// more information about Proxy Protocol, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/enable-proxy-protocol.html">Configure
        /// Proxy Protocol Support</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesForBackendServer service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/SetLoadBalancerPoliciesForBackendServer">REST API Reference for SetLoadBalancerPoliciesForBackendServer Operation</seealso>
        public virtual SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest request)
        {
            var marshaller = SetLoadBalancerPoliciesForBackendServerRequestMarshaller.Instance;
            var unmarshaller = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.Instance;

            return Invoke<SetLoadBalancerPoliciesForBackendServerRequest,SetLoadBalancerPoliciesForBackendServerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesForBackendServer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesForBackendServer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/SetLoadBalancerPoliciesForBackendServer">REST API Reference for SetLoadBalancerPoliciesForBackendServer Operation</seealso>
        public virtual Task<SetLoadBalancerPoliciesForBackendServerResponse> SetLoadBalancerPoliciesForBackendServerAsync(SetLoadBalancerPoliciesForBackendServerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetLoadBalancerPoliciesForBackendServerRequestMarshaller.Instance;
            var unmarshaller = SetLoadBalancerPoliciesForBackendServerResponseUnmarshaller.Instance;

            return InvokeAsync<SetLoadBalancerPoliciesForBackendServerRequest,SetLoadBalancerPoliciesForBackendServerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetLoadBalancerPoliciesOfListener


        /// <summary>
        /// Replaces the current set of policies for the specified load balancer port with the
        /// specified set of policies.
        /// 
        ///  
        /// <para>
        /// To enable back-end server authentication, use <a>SetLoadBalancerPoliciesForBackendServer</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about setting policies, see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/ssl-config-update.html">Update
        /// the SSL Negotiation Configuration</a>, <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-duration">Duration-Based
        /// Session Stickiness</a>, and <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/classic/elb-sticky-sessions.html#enable-sticky-sessions-application">Application-Controlled
        /// Session Stickiness</a> in the <i>Classic Load Balancer Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener service method.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by ElasticLoadBalancing.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.AccessPointNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException">
        /// The requested configuration change is not valid.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException">
        /// The load balancer does not have a listener configured at the specified port.
        /// </exception>
        /// <exception cref="Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException">
        /// One or more of the specified policies do not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/SetLoadBalancerPoliciesOfListener">REST API Reference for SetLoadBalancerPoliciesOfListener Operation</seealso>
        public virtual SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request)
        {
            var marshaller = SetLoadBalancerPoliciesOfListenerRequestMarshaller.Instance;
            var unmarshaller = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance;

            return Invoke<SetLoadBalancerPoliciesOfListenerRequest,SetLoadBalancerPoliciesOfListenerResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the SetLoadBalancerPoliciesOfListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetLoadBalancerPoliciesOfListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/elasticloadbalancing-2012-06-01/SetLoadBalancerPoliciesOfListener">REST API Reference for SetLoadBalancerPoliciesOfListener Operation</seealso>
        public virtual Task<SetLoadBalancerPoliciesOfListenerResponse> SetLoadBalancerPoliciesOfListenerAsync(SetLoadBalancerPoliciesOfListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = SetLoadBalancerPoliciesOfListenerRequestMarshaller.Instance;
            var unmarshaller = SetLoadBalancerPoliciesOfListenerResponseUnmarshaller.Instance;

            return InvokeAsync<SetLoadBalancerPoliciesOfListenerRequest,SetLoadBalancerPoliciesOfListenerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}