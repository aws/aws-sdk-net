/*
 * Copyright 2010-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.ElasticLoadBalancing;
using Amazon.ElasticLoadBalancing.Model;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Interface for accessing AmazonElasticLoadBalancing.
    ///  
    ///  Elastic Load Balancing <para> Elastic Load Balancing is a cost-effective and easy to use web service to help you improve availability and
    /// scalability of your application. It makes it easy for you to distribute application loads between two or more EC2 instances. Elastic Load
    /// Balancing enables availability through redundancy and supports traffic growth of your application. </para>
    /// </summary>
    public interface AmazonElasticLoadBalancing : IDisposable
    {
        

         /// <summary>
         /// <para> Deletes listeners from the LoadBalancer for the specified port. </para>
         /// </summary>
         /// 
         /// <param name="deleteLoadBalancerListenersRequest">Container for the necessary parameters to execute the DeleteLoadBalancerListeners service
         ///           method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DeleteLoadBalancerListeners service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="LoadBalancerNotFoundException"/>
        DeleteLoadBalancerListenersResponse DeleteLoadBalancerListeners(DeleteLoadBalancerListenersRequest deleteLoadBalancerListenersRequest); 

         /// <summary>
         /// <para> Associates, updates, or disables a policy with a listener on the LoadBalancer. You can associate multiple policies with a listener.
         /// </para>
         /// </summary>
         /// 
         /// <param name="setLoadBalancerPoliciesOfListenerRequest">Container for the necessary parameters to execute the
         ///           SetLoadBalancerPoliciesOfListener service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="ListenerNotFoundException"/>
         /// <exception cref="PolicyNotFoundException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest setLoadBalancerPoliciesOfListenerRequest); 

         /// <summary>
         /// <para> Adds one or more EC2 Availability Zones to the LoadBalancer. </para> <para> The LoadBalancer evenly distributes requests across all
         /// its registered Availability Zones that contain instances. As a result, the client must ensure that its LoadBalancer is appropriately scaled
         /// for each registered Availability Zone. </para> <para><b>NOTE:</b> The new EC2 Availability Zones to be added must be in the same EC2 Region
         /// as the Availability Zones for which the LoadBalancer was created. </para>
         /// </summary>
         /// 
         /// <param name="enableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
         ///           EnableAvailabilityZonesForLoadBalancer service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the EnableAvailabilityZonesForLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="LoadBalancerNotFoundException"/>
        EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest enableAvailabilityZonesForLoadBalancerRequest); 

         /// <summary>
         /// <para> Deregisters instances from the LoadBalancer. Once the instance is deregistered, it will stop receiving traffic from the LoadBalancer.
         /// </para> <para> In order to successfully call this API, the same account credentials as those used to create the LoadBalancer must be
         /// provided. </para>
         /// </summary>
         /// 
         /// <param name="deregisterInstancesFromLoadBalancerRequest">Container for the necessary parameters to execute the
         ///           DeregisterInstancesFromLoadBalancer service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DeregisterInstancesFromLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="InvalidInstanceException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
        DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest deregisterInstancesFromLoadBalancerRequest); 

         /// <summary>
         /// <para>Returns detailed descriptions of the policies. If you specify a LoadBalancer name, the operation returns either the descriptions of
         /// the specified policies, or descriptions of all the policies created for the LoadBalancer. If you don't specify a LoadBalancer name, the
         /// operation returns descriptions of the specified sample policies, or descriptions of all the sample policies. The names of the sample
         /// policies have the <c>ELBSample-</c> prefix. </para>
         /// </summary>
         /// 
         /// <param name="describeLoadBalancerPoliciesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicies service
         ///           method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="PolicyNotFoundException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
        DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies(DescribeLoadBalancerPoliciesRequest describeLoadBalancerPoliciesRequest); 

         /// <summary>
         /// <para>Returns detailed descriptions of the policies. If you specify a LoadBalancer name, the operation returns either the descriptions of
         /// the specified policies, or descriptions of all the policies created for the LoadBalancer. If you don't specify a LoadBalancer name, the
         /// operation returns descriptions of the specified sample policies, or descriptions of all the sample policies. The names of the sample
         /// policies have the <c>ELBSample-</c> prefix. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeLoadBalancerPolicies service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="PolicyNotFoundException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
        DescribeLoadBalancerPoliciesResponse DescribeLoadBalancerPolicies();

         /// <summary>
         /// <para> Returns meta-information on the specified LoadBalancer policies defined by the Elastic Load Balancing service. The policy types that
         /// are returned from this action can be used in a CreateLoadBalancerPolicy action to instantiate specific policy configurations that will be
         /// applied to an Elastic LoadBalancer. </para>
         /// </summary>
         /// 
         /// <param name="describeLoadBalancerPolicyTypesRequest">Container for the necessary parameters to execute the DescribeLoadBalancerPolicyTypes
         ///           service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="PolicyTypeNotFoundException"/>
        DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes(DescribeLoadBalancerPolicyTypesRequest describeLoadBalancerPolicyTypesRequest); 

         /// <summary>
         /// <para> Returns meta-information on the specified LoadBalancer policies defined by the Elastic Load Balancing service. The policy types that
         /// are returned from this action can be used in a CreateLoadBalancerPolicy action to instantiate specific policy configurations that will be
         /// applied to an Elastic LoadBalancer. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeLoadBalancerPolicyTypes service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="PolicyTypeNotFoundException"/>
        DescribeLoadBalancerPolicyTypesResponse DescribeLoadBalancerPolicyTypes();

         /// <summary>
         /// <para> Sets the certificate that terminates the specified listener's SSL connections. The specified certificate replaces any prior
         /// certificate that was used on the same LoadBalancer and port. </para>
         /// </summary>
         /// 
         /// <param name="setLoadBalancerListenerSSLCertificateRequest">Container for the necessary parameters to execute the
         ///           SetLoadBalancerListenerSSLCertificate service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="ListenerNotFoundException"/>
         /// <exception cref="CertificateNotFoundException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest setLoadBalancerListenerSSLCertificateRequest); 

         /// <summary>
         /// <para> Generates a stickiness policy with sticky session lifetimes controlled by the lifetime of the browser (user-agent) or a specified
         /// expiration period. This policy can be associated only with HTTP/HTTPS listeners. </para> <para> When a LoadBalancer implements this policy,
         /// the LoadBalancer uses a special cookie to track the backend server instance for each request. When the LoadBalancer receives a request, it
         /// first checks to see if this cookie is present in the request. If so, the LoadBalancer sends the request to the application server specified
         /// in the cookie. If not, the LoadBalancer sends the request to a server that is chosen based on the existing load balancing algorithm. </para>
         /// <para> A cookie is inserted into the response for binding subsequent requests from the same user to that server. The validity of the cookie
         /// is based on the cookie expiration time, which is specified in the policy configuration. </para>
         /// </summary>
         /// 
         /// <param name="createLBCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy
         ///           service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="TooManyPoliciesException"/>
         /// <exception cref="DuplicatePolicyNameException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest createLBCookieStickinessPolicyRequest); 

         /// <summary>
         /// <para> Deletes a policy from the LoadBalancer. The specified policy must not be enabled for any listeners. </para>
         /// </summary>
         /// 
         /// <param name="deleteLoadBalancerPolicyRequest">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method
         ///           on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest deleteLoadBalancerPolicyRequest); 

         /// <summary>
         /// <para> Adds new instances to the LoadBalancer. </para> <para> Once the instance is registered, it starts receiving traffic and requests from
         /// the LoadBalancer. Any instance that is not in any of the Availability Zones registered for the LoadBalancer will be moved to the
         /// <i>OutOfService</i> state. It will move to the <i>InService</i> state when the Availability Zone is added to the LoadBalancer. </para>
         /// <para><b>NOTE:</b> In order for this call to be successful, the client must have created the LoadBalancer. The client must provide the same
         /// account credentials as those that were used to create the LoadBalancer. </para> <para><b>NOTE:</b> Completion of this API does not guarantee
         /// that operation has completed. Rather, it means that the request has been registered and the changes will happen shortly. </para>
         /// </summary>
         /// 
         /// <param name="registerInstancesWithLoadBalancerRequest">Container for the necessary parameters to execute the
         ///           RegisterInstancesWithLoadBalancer service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the RegisterInstancesWithLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="InvalidInstanceException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
        RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest registerInstancesWithLoadBalancerRequest); 

         /// <summary>
         /// <para> Enables the client to define an application healthcheck for the instances. </para>
         /// </summary>
         /// 
         /// <param name="configureHealthCheckRequest">Container for the necessary parameters to execute the ConfigureHealthCheck service method on
         ///           AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the ConfigureHealthCheck service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="LoadBalancerNotFoundException"/>
        ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest configureHealthCheckRequest); 

         /// <summary>
         /// <para> Returns detailed configuration information for the specified LoadBalancers. If no LoadBalancers are specified, the operation returns
         /// configuration information for all LoadBalancers created by the caller. </para> <para><b>NOTE:</b> The client must have created the specified
         /// input LoadBalancers in order to retrieve this information; the client must provide the same account credentials as those that were used to
         /// create the LoadBalancer. </para>
         /// </summary>
         /// 
         /// <param name="describeLoadBalancersRequest">Container for the necessary parameters to execute the DescribeLoadBalancers service method on
         ///           AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DescribeLoadBalancers service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="LoadBalancerNotFoundException"/>
        DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest describeLoadBalancersRequest); 

         /// <summary>
         /// <para> Returns detailed configuration information for the specified LoadBalancers. If no LoadBalancers are specified, the operation returns
         /// configuration information for all LoadBalancers created by the caller. </para> <para><b>NOTE:</b> The client must have created the specified
         /// input LoadBalancers in order to retrieve this information; the client must provide the same account credentials as those that were used to
         /// create the LoadBalancer. </para>
         /// </summary>
         /// 
         /// <returns>The response from the DescribeLoadBalancers service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="LoadBalancerNotFoundException"/>
        DescribeLoadBalancersResponse DescribeLoadBalancers();

         /// <summary>
         /// <para> Returns the current state of the instances of the specified LoadBalancer. If no instances are specified, the state of all the
         /// instances for the LoadBalancer is returned. </para> <para><b>NOTE:</b> The client must have created the specified input LoadBalancer in
         /// order to retrieve this information; the client must provide the same account credentials as those that were used to create the LoadBalancer.
         /// </para>
         /// </summary>
         /// 
         /// <param name="describeInstanceHealthRequest">Container for the necessary parameters to execute the DescribeInstanceHealth service method on
         ///           AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DescribeInstanceHealth service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="InvalidInstanceException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
        DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest describeInstanceHealthRequest); 

         /// <summary>
         /// <para> Adds one or more subnets to the set of configured subnets in the VPC for the LoadBalancer. </para> <para> The Loadbalancers evenly
         /// distribute requests across all of the registered subnets. </para>
         /// </summary>
         /// 
         /// <param name="attachLoadBalancerToSubnetsRequest">Container for the necessary parameters to execute the AttachLoadBalancerToSubnets service
         ///           method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the AttachLoadBalancerToSubnets service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="SubnetNotFoundException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        AttachLoadBalancerToSubnetsResponse AttachLoadBalancerToSubnets(AttachLoadBalancerToSubnetsRequest attachLoadBalancerToSubnetsRequest); 

         /// <summary>
         /// <para> Removes the specified EC2 Availability Zones from the set of configured Availability Zones for the LoadBalancer. </para> <para> There
         /// must be at least one Availability Zone registered with a LoadBalancer at all times. A client cannot remove all the Availability Zones from a
         /// LoadBalancer. Once an Availability Zone is removed, all the instances registered with the LoadBalancer that are in the removed Availability
         /// Zone go into the OutOfService state. Upon Availability Zone removal, the LoadBalancer attempts to equally balance the traffic among its
         /// remaining usable Availability Zones. Trying to remove an Availability Zone that was not associated with the LoadBalancer does nothing.
         /// </para> <para><b>NOTE:</b> In order for this call to be successful, the client must have created the LoadBalancer. The client must provide
         /// the same account credentials as those that were used to create the LoadBalancer. </para>
         /// </summary>
         /// 
         /// <param name="disableAvailabilityZonesForLoadBalancerRequest">Container for the necessary parameters to execute the
         ///           DisableAvailabilityZonesForLoadBalancer service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DisableAvailabilityZonesForLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest disableAvailabilityZonesForLoadBalancerRequest); 

         /// <summary>
         /// <para> Creates one or more listeners on a LoadBalancer for the specified port. If a listener with the given port does not already exist, it
         /// will be created; otherwise, the properties of the new listener must match the properties of the existing listener. </para>
         /// </summary>
         /// 
         /// <param name="createLoadBalancerListenersRequest">Container for the necessary parameters to execute the CreateLoadBalancerListeners service
         ///           method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the CreateLoadBalancerListeners service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="CertificateNotFoundException"/>
         /// <exception cref="DuplicateListenerException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest createLoadBalancerListenersRequest); 

         /// <summary>
         /// <para> Creates a new policy that contains the necessary attributes depending on the policy type. Policies are settings that are saved for
         /// your Elastic LoadBalancer and that can be applied to the front-end listener, or the back-end application server, depending on your policy
         /// type. </para>
         /// </summary>
         /// 
         /// <param name="createLoadBalancerPolicyRequest">Container for the necessary parameters to execute the CreateLoadBalancerPolicy service method
         ///           on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the CreateLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="PolicyTypeNotFoundException"/>
         /// <exception cref="TooManyPoliciesException"/>
         /// <exception cref="DuplicatePolicyNameException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        CreateLoadBalancerPolicyResponse CreateLoadBalancerPolicy(CreateLoadBalancerPolicyRequest createLoadBalancerPolicyRequest); 

         /// <summary>
         /// <para> Replaces the current set of policies associated with a port on which the back-end server is listening with a new set of policies.
         /// After the policies have been created using CreateLoadBalancerPolicy, they can be applied here as a list. At this time, only the back-end
         /// server authentication policy type can be applied to the back-end ports; this policy type is composed of multiple public key policies.
         /// </para>
         /// </summary>
         /// 
         /// <param name="setLoadBalancerPoliciesForBackendServerRequest">Container for the necessary parameters to execute the
         ///           SetLoadBalancerPoliciesForBackendServer service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the SetLoadBalancerPoliciesForBackendServer service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="PolicyNotFoundException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        SetLoadBalancerPoliciesForBackendServerResponse SetLoadBalancerPoliciesForBackendServer(SetLoadBalancerPoliciesForBackendServerRequest setLoadBalancerPoliciesForBackendServerRequest); 

         /// <summary>
         /// <para> Removes subnets from the set of configured subnets in the VPC for the LoadBalancer. </para> <para> After a subnet is removed all of
         /// the EndPoints registered with the LoadBalancer that are in the removed subnet will go into the <i>OutOfService</i> state. When a subnet is
         /// removed, the LoadBalancer will balance the traffic among the remaining routable subnets for the LoadBalancer. </para>
         /// </summary>
         /// 
         /// <param name="detachLoadBalancerFromSubnetsRequest">Container for the necessary parameters to execute the DetachLoadBalancerFromSubnets
         ///           service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DetachLoadBalancerFromSubnets service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        DetachLoadBalancerFromSubnetsResponse DetachLoadBalancerFromSubnets(DetachLoadBalancerFromSubnetsRequest detachLoadBalancerFromSubnetsRequest); 

         /// <summary>
         /// <para> Associates one or more security groups with your LoadBalancer in VPC. The provided security group IDs will override any currently
         /// applied security groups. </para>
         /// </summary>
         /// 
         /// <param name="applySecurityGroupsToLoadBalancerRequest">Container for the necessary parameters to execute the
         ///           ApplySecurityGroupsToLoadBalancer service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the ApplySecurityGroupsToLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
         /// <exception cref="InvalidSecurityGroupException"/>
        ApplySecurityGroupsToLoadBalancerResponse ApplySecurityGroupsToLoadBalancer(ApplySecurityGroupsToLoadBalancerRequest applySecurityGroupsToLoadBalancerRequest); 

         /// <summary>
         /// <para> Deletes the specified LoadBalancer. </para> <para> If attempting to recreate the LoadBalancer, the client must reconfigure all the
         /// settings. The DNS name associated with a deleted LoadBalancer will no longer be usable. Once deleted, the name and associated DNS record of
         /// the LoadBalancer no longer exist and traffic sent to any of its IP addresses will no longer be delivered to client instances. The client
         /// will not receive the same DNS name even if a new LoadBalancer with same LoadBalancerName is created. </para> <para> To successfully call
         /// this API, the client must provide the same account credentials as were used to create the LoadBalancer. </para> <para><b>NOTE:</b> By
         /// design, if the LoadBalancer does not exist or has already been deleted, DeleteLoadBalancer still succeeds. </para>
         /// </summary>
         /// 
         /// <param name="deleteLoadBalancerRequest">Container for the necessary parameters to execute the DeleteLoadBalancer service method on
         ///           AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DeleteLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
        DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest deleteLoadBalancerRequest); 

         /// <summary>
         /// <para> Creates a new LoadBalancer. </para> <para> After the call has completed successfully, a new LoadBalancer is created; however, it will
         /// not be usable until at least one instance has been registered. When the LoadBalancer creation is completed, the client can check whether or
         /// not it is usable by using the DescribeInstanceHealth API. The LoadBalancer is usable as soon as any registered instance is <i>InService</i>
         /// .
         /// </para> <para><b>NOTE:</b> Currently, the client's quota of LoadBalancers is limited to ten per Region. </para> <para><b>NOTE:</b>
         /// LoadBalancer DNS names vary depending on the Region they're created in. For LoadBalancers created in the United States, the DNS name ends
         /// with: us-east-1.elb.amazonaws.com (for the US Standard Region) us-west-1.elb.amazonaws.com (for the Northern California Region) For
         /// LoadBalancers created in the EU (Ireland) Region, the DNS name ends with: eu-west-1.elb.amazonaws.com </para>
         /// </summary>
         /// 
         /// <param name="createLoadBalancerRequest">Container for the necessary parameters to execute the CreateLoadBalancer service method on
         ///           AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the CreateLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="InvalidSubnetException"/>
         /// <exception cref="CertificateNotFoundException"/>
         /// <exception cref="SubnetNotFoundException"/>
         /// <exception cref="TooManyLoadBalancersException"/>
         /// <exception cref="DuplicateLoadBalancerNameException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
         /// <exception cref="InvalidSecurityGroupException"/>
        CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest createLoadBalancerRequest); 

         /// <summary>
         /// <para> Generates a stickiness policy with sticky session lifetimes that follow that of an application-generated cookie. This policy can be
         /// associated only with HTTP/HTTPS listeners. </para> <para> This policy is similar to the policy created by CreateLBCookieStickinessPolicy,
         /// except that the lifetime of the special Elastic Load Balancing cookie follows the lifetime of the application-generated cookie specified in
         /// the policy configuration. The LoadBalancer only inserts a new stickiness cookie when the application response includes a new application
         /// cookie. </para> <para> If the application cookie is explicitly removed or expires, the session stops being sticky until a new application
         /// cookie is issued. </para> <para><b>NOTE:</b> An application client must receive and send two cookies: the application-generated cookie and
         /// the special Elastic Load Balancing cookie named AWSELB. This is the default behavior for many common web browsers. </para>
         /// </summary>
         /// 
         /// <param name="createAppCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateAppCookieStickinessPolicy
         ///           service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the CreateAppCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="TooManyPoliciesException"/>
         /// <exception cref="DuplicatePolicyNameException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
        CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest createAppCookieStickinessPolicyRequest); 
    }
}
    
