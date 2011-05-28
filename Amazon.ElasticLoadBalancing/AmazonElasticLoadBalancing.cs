/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
         /// <para> Creates a new LoadBalancer. </para> <para> Once the call has completed successfully, a new LoadBalancer is created; however, it will
         /// not be usable until at least one instance has been registered. When the LoadBalancer creation is completed, the client can check whether or
         /// not it is usable by using the DescribeInstanceHealth API. The LoadBalancer is usable as soon as any registered instance is <i>InService</i>
         /// .
         /// </para> <para><b>NOTE:</b> Currently, the client's quota of LoadBalancers is limited to five per Region. </para> <para><b>NOTE:</b>
         /// Load balancer DNS names vary depending on the Region they're created in. For load balancers created in the United States, the DNS name ends
         /// with: us-east-1.elb.amazonaws.com (for the US Standard Region) us-west-1.elb.amazonaws.com (for the Northern California Region) For load
         /// balancers created in the EU (Ireland) Region, the DNS name ends with: eu-west-1.elb.amazonaws.com </para>
         /// </summary>
         /// 
         /// <param name="createLoadBalancerRequest">Container for the necessary parameters to execute the CreateLoadBalancer service method on
         ///           AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the CreateLoadBalancer service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="TooManyLoadBalancersException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
         /// <exception cref="CertificateNotFoundException"/>
         /// <exception cref="DuplicateLoadBalancerNameException"/>
        CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest createLoadBalancerRequest); 

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
         /// <para> Generates a stickiness policy with sticky session lifetimes controlled by the lifetime of the browser (user-agent) or a specified
         /// expiration period. This policy can be associated only with HTTP/HTTPS listeners. </para> <para> When a load balancer implements this policy,
         /// the load balancer uses a special cookie to track the backend server instance for each request. When the load balancer receives a request, it
         /// first checks to see if this cookie is present in the request. If so, the load balancer sends the request to the application server specified
         /// in the cookie. If not, the load balancer sends the request to a server that is chosen based on the existing load balancing algorithm.
         /// </para> <para> A cookie is inserted into the response for binding subsequent requests from the same user to that server. The validity of the
         /// cookie is based on the cookie expiration time, which is specified in the policy configuration. </para>
         /// </summary>
         /// 
         /// <param name="createLBCookieStickinessPolicyRequest">Container for the necessary parameters to execute the CreateLBCookieStickinessPolicy
         ///           service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the CreateLBCookieStickinessPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="InvalidConfigurationRequestException"/>
         /// <exception cref="TooManyPoliciesException"/>
         /// <exception cref="DuplicatePolicyNameException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
        CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest createLBCookieStickinessPolicyRequest); 

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
         /// <exception cref="InvalidConfigurationRequestException"/>
         /// <exception cref="CertificateNotFoundException"/>
         /// <exception cref="DuplicateListenerException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
        CreateLoadBalancerListenersResponse CreateLoadBalancerListeners(CreateLoadBalancerListenersRequest createLoadBalancerListenersRequest); 

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
         /// <exception cref="InvalidConfigurationRequestException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
        DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest disableAvailabilityZonesForLoadBalancerRequest); 

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
         /// <para> Generates a stickiness policy with sticky session lifetimes that follow that of an application-generated cookie. This policy can be
         /// associated only with HTTP/HTTPS listeners. </para> <para> This policy is similar to the policy created by CreateLBCookieStickinessPolicy,
         /// except that the lifetime of the special Elastic Load Balancing cookie follows the lifetime of the application-generated cookie specified in
         /// the policy configuration. The load balancer only inserts a new stickiness cookie when the application response includes a new application
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
         /// <exception cref="InvalidConfigurationRequestException"/>
         /// <exception cref="TooManyPoliciesException"/>
         /// <exception cref="DuplicatePolicyNameException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
        CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest createAppCookieStickinessPolicyRequest); 

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
         /// <para> Sets the certificate that terminates the specified listener's SSL connections. The specified certificate replaces any prior
         /// certificate that was used on the same LoadBalancer and port. </para>
         /// </summary>
         /// 
         /// <param name="setLoadBalancerListenerSSLCertificateRequest">Container for the necessary parameters to execute the
         ///           SetLoadBalancerListenerSSLCertificate service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the SetLoadBalancerListenerSSLCertificate service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="InvalidConfigurationRequestException"/>
         /// <exception cref="CertificateNotFoundException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="ListenerNotFoundException"/>
        SetLoadBalancerListenerSSLCertificateResponse SetLoadBalancerListenerSSLCertificate(SetLoadBalancerListenerSSLCertificateRequest setLoadBalancerListenerSSLCertificateRequest); 

         /// <summary>
         /// <para> Deletes a policy from the LoadBalancer. The specified policy must not be enabled for any listeners. </para>
         /// </summary>
         /// 
         /// <param name="deleteLoadBalancerPolicyRequest">Container for the necessary parameters to execute the DeleteLoadBalancerPolicy service method
         ///           on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the DeleteLoadBalancerPolicy service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="InvalidConfigurationRequestException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
        DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest deleteLoadBalancerPolicyRequest); 

         /// <summary>
         /// <para> Associates, updates, or disables a policy with a listener on the load balancer. Currently only zero (0) or one (1) policy can be
         /// associated with a listener. </para>
         /// </summary>
         /// 
         /// <param name="setLoadBalancerPoliciesOfListenerRequest">Container for the necessary parameters to execute the
         ///           SetLoadBalancerPoliciesOfListener service method on AmazonElasticLoadBalancing.</param>
         /// 
         /// <returns>The response from the SetLoadBalancerPoliciesOfListener service method, as returned by AmazonElasticLoadBalancing.</returns>
         /// 
         /// <exception cref="PolicyNotFoundException"/>
         /// <exception cref="InvalidConfigurationRequestException"/>
         /// <exception cref="LoadBalancerNotFoundException"/>
         /// <exception cref="ListenerNotFoundException"/>
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
    }
}
    
