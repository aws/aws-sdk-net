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
    /// Elastic Load Balancing supports two types of load balancers: Classic load balancers
    /// and Application load balancers (new). A Classic load balancer makes routing and load
    /// balancing decisions either at the transport layer (TCP/SSL) or the application layer
    /// (HTTP/HTTPS), and supports either EC2-Classic or a VPC. An Application load balancer
    /// makes routing and load balancing decisions at the application layer (HTTP/HTTPS),
    /// supports path-based routing, and can route requests to one or more ports on each EC2
    /// instance or container instance in your virtual private cloud (VPC). For more information,
    /// see the <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/userguide/">Elastic
    /// Load Balancing User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// This reference covers the 2015-12-01 API, which supports Application load balancers.
    /// The 2012-06-01 API supports Classic load balancers.
    /// </para>
    ///  
    /// <para>
    /// To get started with an Application load balancer, complete the following tasks:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// Create a load balancer using <a>CreateLoadBalancer</a>.
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
    /// To delete an Application load balancer and its related resources, complete the following
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

        internal AddTagsResponse AddTags(AddTagsRequest request)
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
        public Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AddTagsRequestMarshaller();
            var unmarshaller = AddTagsResponseUnmarshaller.Instance;

            return InvokeAsync<AddTagsRequest,AddTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateListener

        internal CreateListenerResponse CreateListener(CreateListenerRequest request)
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
        public Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateListenerRequestMarshaller();
            var unmarshaller = CreateListenerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateListenerRequest,CreateListenerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateLoadBalancer

        internal CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request)
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
        public Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateLoadBalancerRequestMarshaller();
            var unmarshaller = CreateLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLoadBalancerRequest,CreateLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRule

        internal CreateRuleResponse CreateRule(CreateRuleRequest request)
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
        public Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRuleRequestMarshaller();
            var unmarshaller = CreateRuleResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRuleRequest,CreateRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTargetGroup

        internal CreateTargetGroupResponse CreateTargetGroup(CreateTargetGroupRequest request)
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
        public Task<CreateTargetGroupResponse> CreateTargetGroupAsync(CreateTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTargetGroupRequestMarshaller();
            var unmarshaller = CreateTargetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTargetGroupRequest,CreateTargetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteListener

        internal DeleteListenerResponse DeleteListener(DeleteListenerRequest request)
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
        public Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteListenerRequestMarshaller();
            var unmarshaller = DeleteListenerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteListenerRequest,DeleteListenerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteLoadBalancer

        internal DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request)
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
        public Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteLoadBalancerRequestMarshaller();
            var unmarshaller = DeleteLoadBalancerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLoadBalancerRequest,DeleteLoadBalancerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRule

        internal DeleteRuleResponse DeleteRule(DeleteRuleRequest request)
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
        public Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRuleRequestMarshaller();
            var unmarshaller = DeleteRuleResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRuleRequest,DeleteRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTargetGroup

        internal DeleteTargetGroupResponse DeleteTargetGroup(DeleteTargetGroupRequest request)
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
        public Task<DeleteTargetGroupResponse> DeleteTargetGroupAsync(DeleteTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTargetGroupRequestMarshaller();
            var unmarshaller = DeleteTargetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTargetGroupRequest,DeleteTargetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTargets

        internal DeregisterTargetsResponse DeregisterTargets(DeregisterTargetsRequest request)
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
        public Task<DeregisterTargetsResponse> DeregisterTargetsAsync(DeregisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterTargetsRequestMarshaller();
            var unmarshaller = DeregisterTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTargetsRequest,DeregisterTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeListeners

        internal DescribeListenersResponse DescribeListeners(DescribeListenersRequest request)
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
        public Task<DescribeListenersResponse> DescribeListenersAsync(DescribeListenersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeListenersRequestMarshaller();
            var unmarshaller = DescribeListenersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeListenersRequest,DescribeListenersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancerAttributes

        internal DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request)
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
        public Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = DescribeLoadBalancerAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancerAttributesRequest,DescribeLoadBalancerAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoadBalancers

        internal DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request)
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
        public Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeLoadBalancersRequestMarshaller();
            var unmarshaller = DescribeLoadBalancersResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoadBalancersRequest,DescribeLoadBalancersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRules

        internal DescribeRulesResponse DescribeRules(DescribeRulesRequest request)
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
        public Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRulesRequestMarshaller();
            var unmarshaller = DescribeRulesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRulesRequest,DescribeRulesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSSLPolicies

        internal DescribeSSLPoliciesResponse DescribeSSLPolicies(DescribeSSLPoliciesRequest request)
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
        public Task<DescribeSSLPoliciesResponse> DescribeSSLPoliciesAsync(DescribeSSLPoliciesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSSLPoliciesRequestMarshaller();
            var unmarshaller = DescribeSSLPoliciesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSSLPoliciesRequest,DescribeSSLPoliciesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
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
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTargetGroupAttributes

        internal DescribeTargetGroupAttributesResponse DescribeTargetGroupAttributes(DescribeTargetGroupAttributesRequest request)
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
        public Task<DescribeTargetGroupAttributesResponse> DescribeTargetGroupAttributesAsync(DescribeTargetGroupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTargetGroupAttributesRequestMarshaller();
            var unmarshaller = DescribeTargetGroupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTargetGroupAttributesRequest,DescribeTargetGroupAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTargetGroups

        internal DescribeTargetGroupsResponse DescribeTargetGroups(DescribeTargetGroupsRequest request)
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
        public Task<DescribeTargetGroupsResponse> DescribeTargetGroupsAsync(DescribeTargetGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTargetGroupsRequestMarshaller();
            var unmarshaller = DescribeTargetGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTargetGroupsRequest,DescribeTargetGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTargetHealth

        internal DescribeTargetHealthResponse DescribeTargetHealth(DescribeTargetHealthRequest request)
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
        public Task<DescribeTargetHealthResponse> DescribeTargetHealthAsync(DescribeTargetHealthRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTargetHealthRequestMarshaller();
            var unmarshaller = DescribeTargetHealthResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTargetHealthRequest,DescribeTargetHealthResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyListener

        internal ModifyListenerResponse ModifyListener(ModifyListenerRequest request)
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
        public Task<ModifyListenerResponse> ModifyListenerAsync(ModifyListenerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyListenerRequestMarshaller();
            var unmarshaller = ModifyListenerResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyListenerRequest,ModifyListenerResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyLoadBalancerAttributes

        internal ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request)
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
        public Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyLoadBalancerAttributesRequestMarshaller();
            var unmarshaller = ModifyLoadBalancerAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyLoadBalancerAttributesRequest,ModifyLoadBalancerAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyRule

        internal ModifyRuleResponse ModifyRule(ModifyRuleRequest request)
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
        public Task<ModifyRuleResponse> ModifyRuleAsync(ModifyRuleRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyRuleRequestMarshaller();
            var unmarshaller = ModifyRuleResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyRuleRequest,ModifyRuleResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyTargetGroup

        internal ModifyTargetGroupResponse ModifyTargetGroup(ModifyTargetGroupRequest request)
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
        public Task<ModifyTargetGroupResponse> ModifyTargetGroupAsync(ModifyTargetGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyTargetGroupRequestMarshaller();
            var unmarshaller = ModifyTargetGroupResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyTargetGroupRequest,ModifyTargetGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyTargetGroupAttributes

        internal ModifyTargetGroupAttributesResponse ModifyTargetGroupAttributes(ModifyTargetGroupAttributesRequest request)
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
        public Task<ModifyTargetGroupAttributesResponse> ModifyTargetGroupAttributesAsync(ModifyTargetGroupAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyTargetGroupAttributesRequestMarshaller();
            var unmarshaller = ModifyTargetGroupAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyTargetGroupAttributesRequest,ModifyTargetGroupAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterTargets

        internal RegisterTargetsResponse RegisterTargets(RegisterTargetsRequest request)
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
        public Task<RegisterTargetsResponse> RegisterTargetsAsync(RegisterTargetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterTargetsRequestMarshaller();
            var unmarshaller = RegisterTargetsResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTargetsRequest,RegisterTargetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RemoveTags

        internal RemoveTagsResponse RemoveTags(RemoveTagsRequest request)
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
        public Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RemoveTagsRequestMarshaller();
            var unmarshaller = RemoveTagsResponseUnmarshaller.Instance;

            return InvokeAsync<RemoveTagsRequest,RemoveTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetRulePriorities

        internal SetRulePrioritiesResponse SetRulePriorities(SetRulePrioritiesRequest request)
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
        public Task<SetRulePrioritiesResponse> SetRulePrioritiesAsync(SetRulePrioritiesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetRulePrioritiesRequestMarshaller();
            var unmarshaller = SetRulePrioritiesResponseUnmarshaller.Instance;

            return InvokeAsync<SetRulePrioritiesRequest,SetRulePrioritiesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetSecurityGroups

        internal SetSecurityGroupsResponse SetSecurityGroups(SetSecurityGroupsRequest request)
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
        public Task<SetSecurityGroupsResponse> SetSecurityGroupsAsync(SetSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new SetSecurityGroupsRequestMarshaller();
            var unmarshaller = SetSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<SetSecurityGroupsRequest,SetSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  SetSubnets

        internal SetSubnetsResponse SetSubnets(SetSubnetsRequest request)
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