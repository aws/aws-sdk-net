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
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.ElasticLoadBalancingV2.Model;

namespace Amazon.ElasticLoadBalancingV2
{
    /// <summary>
    /// Interface for accessing ElasticLoadBalancingV2
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
    public partial interface IAmazonElasticLoadBalancingV2 : IDisposable
    {

        
        #region  AddTags


        /// <summary>
        /// Adds the specified tags to the specified resource. You can tag your Application load
        /// balancers and your target groups.
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
        AddTagsResponse AddTags(AddTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the AddTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AddTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<AddTagsResponse> AddTagsAsync(AddTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateListener


        /// <summary>
        /// Creates a listener for the specified Application load balancer.
        /// 
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
        CreateListenerResponse CreateListener(CreateListenerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateListenerResponse> CreateListenerAsync(CreateListenerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateLoadBalancer


        /// <summary>
        /// Creates an Application load balancer.
        /// 
        ///  
        /// <para>
        /// To create listeners for your load balancer, use <a>CreateListener</a>. You can add
        /// security groups, subnets, and tags when you create your load balancer, or you can
        /// add them later using <a>SetSecurityGroups</a>, <a>SetSubnets</a>, and <a>AddTags</a>.
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
        /// see <a href="http://docs.aws.amazon.com/elasticloadbalancing/latest/application/load-balancer-limits.html">Limits
        /// for Your Application Load Balancer</a> in the <i>Application Load Balancers Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer service method.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.DuplicateLoadBalancerNameException">
        /// A load balancer with the specified name already exists for this account.
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
        CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  CreateRule


        /// <summary>
        /// Creates a rule for the specified listener.
        /// 
        ///  
        /// <para>
        /// A rule consists conditions and actions. Rules are evaluated in priority order, from
        /// the lowest value to the highest value. When the conditions for a rule are met, the
        /// specified actions are taken. If no rule's conditions are met, the default actions
        /// for the listener are taken.
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
        CreateRuleResponse CreateRule(CreateRuleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateRuleResponse> CreateRuleAsync(CreateRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        CreateTargetGroupResponse CreateTargetGroup(CreateTargetGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTargetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<CreateTargetGroupResponse> CreateTargetGroupAsync(CreateTargetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteListenerResponse DeleteListener(DeleteListenerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteListenerResponse> DeleteListenerAsync(DeleteListenerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DeleteLoadBalancer


        /// <summary>
        /// Deletes the specified load balancer and its attached listeners.
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
        DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLoadBalancer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLoadBalancer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteRuleResponse DeleteRule(DeleteRuleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteRuleResponse> DeleteRuleAsync(DeleteRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeleteTargetGroupResponse DeleteTargetGroup(DeleteTargetGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTargetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeleteTargetGroupResponse> DeleteTargetGroupAsync(DeleteTargetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DeregisterTargetsResponse DeregisterTargets(DeregisterTargetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DeregisterTargetsResponse> DeregisterTargetsAsync(DeregisterTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeListeners


        /// <summary>
        /// Describes the specified listeners or the listeners for the specified load balancer.
        /// You must specify either a load balancer or one or more listeners.
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
        DescribeListenersResponse DescribeListeners(DescribeListenersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeListeners operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeListeners operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeListenersResponse> DescribeListenersAsync(DescribeListenersRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoadBalancerAttributes


        /// <summary>
        /// Describes the attributes for the specified load balancer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerAttributes service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.LoadBalancerNotFoundException">
        /// The specified load balancer does not exist.
        /// </exception>
        DescribeLoadBalancerAttributesResponse DescribeLoadBalancerAttributes(DescribeLoadBalancerAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancerAttributesResponse> DescribeLoadBalancerAttributesAsync(DescribeLoadBalancerAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeLoadBalancers


        /// <summary>
        /// Describes the specified Application load balancers or all of your Application load
        /// balancers.
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
        DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLoadBalancers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoadBalancers operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeRulesResponse DescribeRules(DescribeRulesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeRulesResponse> DescribeRulesAsync(DescribeRulesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeSSLPolicies


        /// <summary>
        /// Describes the specified policies or all policies used for SSL negotiation.
        /// 
        ///  
        /// <para>
        /// Note that the only supported policy at this time is ELBSecurityPolicy-2015-05.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSSLPolicies service method.</param>
        /// 
        /// <returns>The response from the DescribeSSLPolicies service method, as returned by ElasticLoadBalancingV2.</returns>
        /// <exception cref="Amazon.ElasticLoadBalancingV2.Model.SSLPolicyNotFoundException">
        /// The specified SSL policy does not exist.
        /// </exception>
        DescribeSSLPoliciesResponse DescribeSSLPolicies(DescribeSSLPoliciesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSSLPolicies operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSSLPolicies operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeSSLPoliciesResponse> DescribeSSLPoliciesAsync(DescribeSSLPoliciesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes the tags for the specified resources.
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
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeTargetGroupAttributesResponse DescribeTargetGroupAttributes(DescribeTargetGroupAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTargetGroupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroupAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTargetGroupAttributesResponse> DescribeTargetGroupAttributesAsync(DescribeTargetGroupAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeTargetGroupsResponse DescribeTargetGroups(DescribeTargetGroupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTargetGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTargetGroupsResponse> DescribeTargetGroupsAsync(DescribeTargetGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        DescribeTargetHealthResponse DescribeTargetHealth(DescribeTargetHealthRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTargetHealth operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTargetHealth operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<DescribeTargetHealthResponse> DescribeTargetHealthAsync(DescribeTargetHealthRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyListener


        /// <summary>
        /// Modifies the specified properties of the specified listener.
        /// 
        ///  
        /// <para>
        /// Any properties that you do not specify retain their current values. However, changing
        /// the protocol from HTTPS to HTTP removes the security policy and SSL certificate properties.
        /// If you change the protocol from HTTP to HTTPS, you must add the security policy.
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
        ModifyListenerResponse ModifyListener(ModifyListenerRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyListener operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyListener operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyListenerResponse> ModifyListenerAsync(ModifyListenerRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  ModifyLoadBalancerAttributes


        /// <summary>
        /// Modifies the specified attributes of the specified load balancer.
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
        ModifyLoadBalancerAttributesResponse ModifyLoadBalancerAttributes(ModifyLoadBalancerAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLoadBalancerAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLoadBalancerAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyLoadBalancerAttributesResponse> ModifyLoadBalancerAttributesAsync(ModifyLoadBalancerAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyRuleResponse ModifyRule(ModifyRuleRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyRule operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyRule operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyRuleResponse> ModifyRuleAsync(ModifyRuleRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyTargetGroupResponse ModifyTargetGroup(ModifyTargetGroupRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyTargetGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyTargetGroupResponse> ModifyTargetGroupAsync(ModifyTargetGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        ModifyTargetGroupAttributesResponse ModifyTargetGroupAttributes(ModifyTargetGroupAttributesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyTargetGroupAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyTargetGroupAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<ModifyTargetGroupAttributesResponse> ModifyTargetGroupAttributesAsync(ModifyTargetGroupAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
        #region  RegisterTargets


        /// <summary>
        /// Registers the specified targets with the specified target group.
        /// 
        ///  
        /// <para>
        /// The target must be in the virtual private cloud (VPC) that you specified for the target
        /// group.
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
        RegisterTargetsResponse RegisterTargets(RegisterTargetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterTargets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTargets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RegisterTargetsResponse> RegisterTargetsAsync(RegisterTargetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        RemoveTagsResponse RemoveTags(RemoveTagsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the RemoveTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RemoveTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<RemoveTagsResponse> RemoveTagsAsync(RemoveTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SetRulePrioritiesResponse SetRulePriorities(SetRulePrioritiesRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetRulePriorities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetRulePriorities operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetRulePrioritiesResponse> SetRulePrioritiesAsync(SetRulePrioritiesRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SetSecurityGroupsResponse SetSecurityGroups(SetSecurityGroupsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetSecurityGroupsResponse> SetSecurityGroupsAsync(SetSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        SetSubnetsResponse SetSubnets(SetSubnetsRequest request);


        /// <summary>
        /// Initiates the asynchronous execution of the SetSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SetSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<SetSubnetsResponse> SetSubnetsAsync(SetSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
        
    }
}