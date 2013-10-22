/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Threading;
using System.Threading.Tasks;

using Amazon.ElasticLoadBalancing.Model;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Interface for accessing AmazonElasticLoadBalancing.
    /// 
    /// Elastic Load Balancing <para> Elastic Load Balancing is a cost-effective and easy to use web service to help you improve the availability
    /// and scalability of your application running on Amazon Elastic Cloud Compute (Amazon EC2). It makes it easy for you to distribute application
    /// loads between two or more EC2 instances. Elastic Load Balancing supports the growth in traffic of your application by enabling availability
    /// through redundancy. </para> <para>This guide provides detailed information about Elastic Load Balancing actions, data types, and parameters
    /// that can be used for sending a query request. Query requests are HTTP or HTTPS requests that use the HTTP verb GET or POST and a query
    /// parameter named Action or Operation. Action is used throughout this documentation, although Operation is supported for backward
    /// compatibility with other AWS Query APIs.</para> <para>For detailed information on constructing a query request using the actions, data
    /// types, and parameters mentioned in this guide, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/using-query-api.html">Using the Query API</a> in the <i>Elastic
    /// Load Balancing Developer Guide</i> .</para> <para>For detailed information about Elastic Load Balancing features and their associated
    /// actions, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/UserScenarios.html">Using Elastic Load
    /// Balancing</a> in the <i>Elastic Load Balancing Developer Guide</i> .</para> <para>This reference guide is based on the current WSDL, which
    /// is available at: <a href="http://elasticloadbalancing.amazonaws.com/doc/2012-06-01/ElasticLoadBalancing.wsdl">http://elasticloadbalancing.amazonaws.com/doc/2012-06-01/ElasticLoadBalancing.wsdl</a> </para>
    /// </summary>
	public partial interface IAmazonElasticLoadBalancing : IDisposable
    {
 
        /// <summary>
        /// <para> Associates one or more security groups with your load balancer in VPC. The provided security group IDs will override any currently
        /// applied security groups. </para>
        /// </summary>
        /// 
        /// <param name="applySecurityGroupsToLoadBalancerRequest">Container for the necessary parameters to execute the
        /// ApplySecurityGroupsToLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the ApplySecurityGroupsToLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ApplySecurityGroupsToLoadBalancerResponse> ApplySecurityGroupsToLoadBalancerAsync(ApplySecurityGroupsToLoadBalancerRequest applySecurityGroupsToLoadBalancerRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Adds one or more subnets to the set of configured subnets in the VPC for the load balancer. </para> <para> The Loadbalancers evenly
        /// distribute requests across all of the registered subnets. </para>
        /// </summary>
        /// 
        /// <param name="attachLoadBalancerToSubnetsRequest">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets service
        /// method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the AttachLoadBalancerToSubnets service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<AttachLoadBalancerToSubnetsResponse> AttachLoadBalancerToSubnetsAsync(AttachLoadBalancerToSubnetsRequest attachLoadBalancerToSubnetsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Enables the client to define an application healthcheck for the instances. </para>
        /// </summary>
        /// 
        /// <param name="configureHealthCheckRequest">Container for the necessary parameters to execute the ConfigureHealthCheck service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the ConfigureHealthCheck service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<ConfigureHealthCheckResponse> ConfigureHealthCheckAsync(ConfigureHealthCheckRequest configureHealthCheckRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Generates a stickiness policy with sticky session lifetimes that follow that of an application-generated cookie. This policy can be
        /// associated only with HTTP/HTTPS listeners. </para> <para> This policy is similar to the policy created by CreateLBCookieStickinessPolicy,
        /// except that the lifetime of the special Elastic Load Balancing cookie follows the lifetime of the application-generated cookie specified in
        /// the policy configuration. The load balancer only inserts a new stickiness cookie when the application response includes a new application
        /// cookie. </para> <para> If the application cookie is explicitly removed or expires, the session stops being sticky until a new application
        /// cookie is issued. </para> <para><b>NOTE:</b> An application client must receive and send two cookies: the application-generated cookie and
        /// the special Elastic Load Balancing cookie named AWSELB. This is the default behavior for many common web browsers. </para> <para>For
        /// information on using CreateAppCookieStickinessPolicy, see <i>Using the Query API</i> in the <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsAppCookies">Enabling Application-Controlled Sesssion Stickiness</a> section of the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createAppCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy
        /// service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateAppCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateAppCookieStickinessPolicyResponse> CreateAppCookieStickinessPolicyAsync(CreateAppCookieStickinessPolicyRequest createAppCookieStickinessPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Generates a stickiness policy with sticky session lifetimes controlled by the lifetime of the browser (user-agent) or a specified
        /// expiration period. This policy can be associated only with HTTP/HTTPS listeners. </para> <para> When a load balancer implements this policy,
        /// the load balancer uses a special cookie to track the backend server instance for each request. When the load balancer receives a request, it
        /// first checks to see if this cookie is present in the request. If so, the load balancer sends the request to the application server specified
        /// in the cookie. If not, the load balancer sends the request to a server that is chosen based on the existing load balancing algorithm.
        /// </para> <para> A cookie is inserted into the response for binding subsequent requests from the same user to that server. The validity of the
        /// cookie is based on the cookie expiration time, which is specified in the policy configuration. </para> <para>For information on using
        /// CreateLBCookieStickinessPolicy, see <i>Using the Query API</i> in the <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_StickySessions.html#US_EnableStickySessionsLBCookies">Enabling Duration-Based Sesssion Stickiness</a> section of the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createLBCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy
        /// service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateLBCookieStickinessPolicyResponse> CreateLBCookieStickinessPolicyAsync(CreateLBCookieStickinessPolicyRequest createLBCookieStickinessPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new load balancer. </para> <para> After the call has completed successfully, a new load balancer is created; however, it
        /// will not be usable until at least one instance has been registered. When the load balancer creation is completed, the client can check
        /// whether or not it is usable by using the DescribeInstanceHealth action. The load balancer is usable as soon as any registered instance is
        /// <i>InService</i> .
        /// </para> <para><b>NOTE:</b> Currently, the client's quota of load balancers is limited to ten per Region. </para> <para><b>NOTE:</b>
        /// Load balancer DNS names vary depending on the Region they're created in. For load balancers created in the United States, the DNS name ends
        /// with: us-east-1.elb.amazonaws.com (for the Northern Virginia Region) us-west-1.elb.amazonaws.com (for the Northern California Region) For
        /// load balancers created in the EU (Ireland) Region, the DNS name ends with: eu-west-1.elb.amazonaws.com </para> <para>For information on
        /// using CreateLoadBalancer to create a new load balancer in Amazon EC2, go to <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/creating_lb_QueryAPI.html">Using Query API</a> section in the
        /// <i>Creating a Load Balancer With SSL Cipher Settings and Back-end Authentication</i> topic of the <i>Elastic Load Balancing Developer
        /// Guide</i> .</para> <para>For information on using CreateLoadBalancer to create a new load balancer in Amazon VPC, see <i>Using the Query
        /// API</i> in the <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/USVPC_creating_basic_lb.html">Creating a
        /// Basic Load Balancer in Amazon VPC</a> section in the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerRequest">Container for the necessary parameters to execute the CreateLoadBalancer service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSubnetException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSecurityGroupException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidSchemeException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicateLoadBalancerNameException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyLoadBalancersException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.SubnetNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateLoadBalancerResponse> CreateLoadBalancerAsync(CreateLoadBalancerRequest createLoadBalancerRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates one or more listeners on a load balancer for the specified port. If a listener with the given port does not already exist, it
        /// will be created; otherwise, the properties of the new listener must match the properties of the existing listener. </para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerListenersRequest">Container for the necessary parameters to execute the CreateLoadBalancerListeners service
        /// method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerListeners service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicateListenerException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateLoadBalancerListenersResponse> CreateLoadBalancerListenersAsync(CreateLoadBalancerListenersRequest createLoadBalancerListenersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new policy that contains the necessary attributes depending on the policy type. Policies are settings that are saved for
        /// your load balancer and that can be applied to the front-end listener, or the back-end application server, depending on your policy type.
        /// </para>
        /// </summary>
        /// 
        /// <param name="createLoadBalancerPolicyRequest">Container for the necessary parameters to execute the CreateLoadBalancerPolicy service method
        /// on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the CreateLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.DuplicatePolicyNameException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.TooManyPoliciesException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<CreateLoadBalancerPolicyResponse> CreateLoadBalancerPolicyAsync(CreateLoadBalancerPolicyRequest createLoadBalancerPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes the specified load balancer. </para> <para> If attempting to recreate the load balancer, the client must reconfigure all the
        /// settings. The DNS name associated with a deleted load balancer will no longer be usable. Once deleted, the name and associated DNS record of
        /// the load balancer no longer exist and traffic sent to any of its IP addresses will no longer be delivered to client instances. The client
        /// will not receive the same DNS name even if a new load balancer with same load balancer name is created. </para> <para> To successfully call
        /// this API, the client must provide the same account credentials as were used to create the load balancer. </para> <para><b>NOTE:</b> By
        /// design, if the load balancer does not exist or has already been deleted, DeleteLoadBalancer still succeeds. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerRequest">Container for the necessary parameters to execute the DeleteLoadBalancer service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteLoadBalancerResponse> DeleteLoadBalancerAsync(DeleteLoadBalancerRequest deleteLoadBalancerRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes listeners from the load balancer for the specified port. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerListenersRequest">Container for the necessary parameters to execute the DeleteLoadBalancerListeners service
        /// method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerListeners service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteLoadBalancerListenersResponse> DeleteLoadBalancerListenersAsync(DeleteLoadBalancerListenersRequest deleteLoadBalancerListenersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes a policy from the load balancer. The specified policy must not be enabled for any listeners. </para>
        /// </summary>
        /// 
        /// <param name="deleteLoadBalancerPolicyRequest">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method
        /// on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeleteLoadBalancerPolicyResponse> DeleteLoadBalancerPolicyAsync(DeleteLoadBalancerPolicyRequest deleteLoadBalancerPolicyRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deregisters instances from the load balancer. Once the instance is deregistered, it will stop receiving traffic from the load
        /// balancer. </para> <para> In order to successfully call this API, the same account credentials as those used to create the load balancer must
        /// be provided. </para>
        /// </summary>
        /// 
        /// <param name="deregisterInstancesFromLoadBalancerRequest">Container for the necessary parameters to execute the
        /// DeregisterInstancesFromLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DeregisterInstancesFromLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidInstanceException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DeregisterInstancesFromLoadBalancerResponse> DeregisterInstancesFromLoadBalancerAsync(DeregisterInstancesFromLoadBalancerRequest deregisterInstancesFromLoadBalancerRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns the current state of the instances of the specified load balancer. If no instances are specified, the state of all the
        /// instances for the load balancer is returned. </para> <para><b>NOTE:</b> The client must have created the specified input load balancer in
        /// order to retrieve this information; the client must provide the same account credentials as those that were used to create the load
        /// balancer. </para>
        /// </summary>
        /// 
        /// <param name="describeInstanceHealthRequest">Container for the necessary parameters to execute the DescribeInstanceHealth service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeInstanceHealth service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidInstanceException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeInstanceHealthResponse> DescribeInstanceHealthAsync(DescribeInstanceHealthRequest describeInstanceHealthRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para>Returns detailed descriptions of the policies. If you specify a load balancer name, the operation returns either the descriptions of
        /// the specified policies, or descriptions of all the policies created for the load balancer. If you don't specify a load balancer name, the
        /// operation returns descriptions of the specified sample policies, or descriptions of all the sample policies. The names of the sample
        /// policies have the <c>ELBSample-</c> prefix. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPoliciesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service
        /// method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeLoadBalancerPoliciesResponse> DescribeLoadBalancerPoliciesAsync(DescribeLoadBalancerPoliciesRequest describeLoadBalancerPoliciesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns meta-information on the specified load balancer policies defined by the Elastic Load Balancing service. The policy types
        /// that are returned from this action can be used in a CreateLoadBalancerPolicy action to instantiate specific policy configurations that will
        /// be applied to a load balancer. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancerPolicyTypesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes
        /// service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyTypeNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeLoadBalancerPolicyTypesResponse> DescribeLoadBalancerPolicyTypesAsync(DescribeLoadBalancerPolicyTypesRequest describeLoadBalancerPolicyTypesRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns detailed configuration information for the specified load balancers. If no load balancers are specified, the operation
        /// returns configuration information for all load balancers created by the caller. </para> <para><b>NOTE:</b> The client must have created the
        /// specified input load balancers in order to retrieve this information; the client must provide the same account credentials as those that
        /// were used to create the load balancer. </para>
        /// </summary>
        /// 
        /// <param name="describeLoadBalancersRequest">Container for the necessary parameters to execute the DescribeLoadBalancers service method on
        /// AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DescribeLoadBalancers service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DescribeLoadBalancersResponse> DescribeLoadBalancersAsync(DescribeLoadBalancersRequest describeLoadBalancersRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Removes subnets from the set of configured subnets in the VPC for the load balancer. </para> <para> After a subnet is removed all of
        /// the EndPoints registered with the load balancer that are in the removed subnet will go into the <i>OutOfService</i> state. When a subnet is
        /// removed, the load balancer will balance the traffic among the remaining routable subnets for the load balancer. </para>
        /// </summary>
        /// 
        /// <param name="detachLoadBalancerFromSubnetsRequest">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets
        /// service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DetachLoadBalancerFromSubnets service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DetachLoadBalancerFromSubnetsResponse> DetachLoadBalancerFromSubnetsAsync(DetachLoadBalancerFromSubnetsRequest detachLoadBalancerFromSubnetsRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Removes the specified EC2 Availability Zones from the set of configured Availability Zones for the load balancer. </para> <para>
        /// There must be at least one Availability Zone registered with a load balancer at all times. A client cannot remove all the Availability Zones
        /// from a load balancer. Once an Availability Zone is removed, all the instances registered with the load balancer that are in the removed
        /// Availability Zone go into the OutOfService state. Upon Availability Zone removal, the load balancer attempts to equally balance the traffic
        /// among its remaining usable Availability Zones. Trying to remove an Availability Zone that was not associated with the load balancer does
        /// nothing. </para> <para><b>NOTE:</b> In order for this call to be successful, the client must have created the load balancer. The client must
        /// provide the same account credentials as those that were used to create the load balancer. </para>
        /// </summary>
        /// 
        /// <param name="disableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        /// DisableAvailabilityZonesForLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the DisableAvailabilityZonesForLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<DisableAvailabilityZonesForLoadBalancerResponse> DisableAvailabilityZonesForLoadBalancerAsync(DisableAvailabilityZonesForLoadBalancerRequest disableAvailabilityZonesForLoadBalancerRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Adds one or more EC2 Availability Zones to the load balancer. </para> <para> The load balancer evenly distributes requests across all
        /// its registered Availability Zones that contain instances. As a result, the client must ensure that its load balancer is appropriately scaled
        /// for each registered Availability Zone. </para> <para><b>NOTE:</b> The new EC2 Availability Zones to be added must be in the same EC2 Region
        /// as the Availability Zones for which the load balancer was created. </para>
        /// </summary>
        /// 
        /// <param name="enableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
        /// EnableAvailabilityZonesForLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the EnableAvailabilityZonesForLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<EnableAvailabilityZonesForLoadBalancerResponse> EnableAvailabilityZonesForLoadBalancerAsync(EnableAvailabilityZonesForLoadBalancerRequest enableAvailabilityZonesForLoadBalancerRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Adds new instances to the load balancer. </para> <para> Once the instance is registered, it starts receiving traffic and requests
        /// from the load balancer. Any instance that is not in any of the Availability Zones registered for the load balancer will be moved to the
        /// <i>OutOfService</i> state. It will move to the <i>InService</i> state when the Availability Zone is added to the load balancer. </para>
        /// <para><b>NOTE:</b> In order for this call to be successful, the client must have created the load balancer. The client must provide the same
        /// account credentials as those that were used to create the load balancer. </para> <para><b>NOTE:</b> Completion of this API does not
        /// guarantee that operation has completed. Rather, it means that the request has been registered and the changes will happen shortly. </para>
        /// </summary>
        /// 
        /// <param name="registerInstancesWithLoadBalancerRequest">Container for the necessary parameters to execute the
        /// RegisterInstancesWithLoadBalancer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the RegisterInstancesWithLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidInstanceException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<RegisterInstancesWithLoadBalancerResponse> RegisterInstancesWithLoadBalancerAsync(RegisterInstancesWithLoadBalancerRequest registerInstancesWithLoadBalancerRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Sets the certificate that terminates the specified listener's SSL connections. The specified certificate replaces any prior
        /// certificate that was used on the same load balancer and port. </para> <para>For information on using SetLoadBalancerListenerSSLCertificate,
        /// see <i>Using the Query API </i> in the <a href="http://docs.aws.amazon.com/ElasticLoadBalancing/latest/DeveloperGuide/US_UpdatingLoadBalancerSSL.html">Updating an SSL Certificate
        /// for a Load Balancer</a> section in of the <i>Elastic Load Balancing Developer Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerListenerSSLCertificateRequest">Container for the necessary parameters to execute the
        /// SetLoadBalancerListenerSSLCertificate service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.CertificateNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetLoadBalancerListenerSSLCertificateResponse> SetLoadBalancerListenerSSLCertificateAsync(SetLoadBalancerListenerSSLCertificateRequest setLoadBalancerListenerSSLCertificateRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Replaces the current set of policies associated with a port on which the back-end server is listening with a new set of policies.
        /// After the policies have been created using CreateLoadBalancerPolicy, they can be applied here as a list. At this time, only the back-end
        /// server authentication policy type can be applied to the back-end ports; this policy type is composed of multiple public key policies.
        /// </para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesForBackendServerRequest">Container for the necessary parameters to execute the
        /// SetLoadBalancerPoliciesForBackendServer service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesForBackendServer service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetLoadBalancerPoliciesForBackendServerResponse> SetLoadBalancerPoliciesForBackendServerAsync(SetLoadBalancerPoliciesForBackendServerRequest setLoadBalancerPoliciesForBackendServerRequest, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Associates, updates, or disables a policy with a listener on the load balancer. You can associate multiple policies with a listener.
        /// </para>
        /// </summary>
        /// 
        /// <param name="setLoadBalancerPoliciesOfListenerRequest">Container for the necessary parameters to execute the
        /// SetLoadBalancerPoliciesOfListener service method on AmazonElasticLoadBalancing.</param>
        /// 
        /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by AmazonElasticLoadBalancing.</returns>
        /// 
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.PolicyNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.InvalidConfigurationRequestException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.LoadBalancerNotFoundException" />
        /// <exception cref="T:Amazon.ElasticLoadBalancing.Model.ListenerNotFoundException" />
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		Task<SetLoadBalancerPoliciesOfListenerResponse> SetLoadBalancerPoliciesOfListenerAsync(SetLoadBalancerPoliciesOfListenerRequest setLoadBalancerPoliciesOfListenerRequest, CancellationToken cancellationToken = default(CancellationToken));
    }
}
