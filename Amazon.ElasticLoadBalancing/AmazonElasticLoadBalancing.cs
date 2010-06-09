/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-11-25
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using Amazon.ElasticLoadBalancing.Model;

namespace Amazon.ElasticLoadBalancing
{
    /// <summary>
    /// Elastic Load Balancing automatically distributes incoming application traffic across multiple
    /// Amazon EC2 instances. It enables you to achieve even greater fault tolerance in your applications,
    /// seamlessly providing the amount of load balancing capacity needed in response to incoming application
    /// traffic. Elastic Load Balancing detects unhealthy instances within a pool and automatically reroutes
    /// traffic to healthy instances until the unhealthy instances have been restored. You can enable Elastic
    /// Load Balancing within a single Availability Zone or across multiple zones for even more consistent
    /// application performance. Amazon CloudWatch can be used to capture a specific Elastic Load Balancer’s
    /// operational metrics, such as request count and request latency, at no additional cost beyond Elastic
    /// Load Balancing fees.
    /// </summary>
    public interface AmazonElasticLoadBalancing : IDisposable
    {
        /// <summary>
        /// Deregister Instances From Load Balancer
        /// </summary>
        /// <param name="request">Deregister Instances From Load Balancer  request</param>
        /// <returns>Deregister Instances From Load Balancer  Response from the service</returns>
        DeregisterInstancesFromLoadBalancerResponse DeregisterInstancesFromLoadBalancer(DeregisterInstancesFromLoadBalancerRequest request);

        /// <summary>
        /// Configure Health Check
        /// </summary>
        /// <param name="request">Configure Health Check  request</param>
        /// <returns>Configure Health Check  Response from the service</returns>
        ConfigureHealthCheckResponse ConfigureHealthCheck(ConfigureHealthCheckRequest request);

        /// <summary>
        /// Delete Load Balancer
        /// </summary>
        /// <param name="request">Delete Load Balancer  request</param>
        /// <returns>Delete Load Balancer  Response from the service</returns>
        DeleteLoadBalancerResponse DeleteLoadBalancer(DeleteLoadBalancerRequest request);

        /// <summary>
        /// Register Instances With Load Balancer
        /// </summary>
        /// <param name="request">Register Instances With Load Balancer  request</param>
        /// <returns>Register Instances With Load Balancer  Response from the service</returns>
        RegisterInstancesWithLoadBalancerResponse RegisterInstancesWithLoadBalancer(RegisterInstancesWithLoadBalancerRequest request);

        /// <summary>
        /// Create Load Balancer
        /// </summary>
        /// <param name="request">Create Load Balancer  request</param>
        /// <returns>Create Load Balancer  Response from the service</returns>
        CreateLoadBalancerResponse CreateLoadBalancer(CreateLoadBalancerRequest request);

        /// <summary>
        /// Enable Availability Zones For Load Balancer
        /// </summary>
        /// <param name="request">Enable Availability Zones For Load Balancer  request</param>
        /// <returns>Enable Availability Zones For Load Balancer  Response from the service</returns>
        EnableAvailabilityZonesForLoadBalancerResponse EnableAvailabilityZonesForLoadBalancer(EnableAvailabilityZonesForLoadBalancerRequest request);

        /// <summary>
        /// Disable Availability Zones For Load Balancer
        /// </summary>
        /// <param name="request">Disable Availability Zones For Load Balancer  request</param>
        /// <returns>Disable Availability Zones For Load Balancer  Response from the service</returns>
        DisableAvailabilityZonesForLoadBalancerResponse DisableAvailabilityZonesForLoadBalancer(DisableAvailabilityZonesForLoadBalancerRequest request);

        /// <summary>
        /// Describe Instance Health
        /// </summary>
        /// <param name="request">Describe Instance Health  request</param>
        /// <returns>Describe Instance Health  Response from the service</returns>
        DescribeInstanceHealthResponse DescribeInstanceHealth(DescribeInstanceHealthRequest request);

        /// <summary>
        /// Describe Load Balancers
        /// </summary>
        /// <param name="request">Describe Load Balancers  request</param>
        /// <returns>Describe Load Balancers  Response from the service</returns>
        DescribeLoadBalancersResponse DescribeLoadBalancers(DescribeLoadBalancersRequest request);

        /// <summary>
        /// Set Load Balancer Policies Of Listener
        /// </summary>
        /// <param name="request">Set Load Balancer Policies Of Listener  request</param>
        /// <returns>Set Load Balancer Policies Of Listener  Response from the service</returns>
        SetLoadBalancerPoliciesOfListenerResponse SetLoadBalancerPoliciesOfListener(SetLoadBalancerPoliciesOfListenerRequest request);

        /// <summary>
        /// Create App Cookie Stickiness Policy
        /// </summary>
        /// <param name="request">Create App Cookie Stickiness Policy  request</param>
        /// <returns>Create App Cookie Stickiness Policy  Response from the service</returns>
        CreateAppCookieStickinessPolicyResponse CreateAppCookieStickinessPolicy(CreateAppCookieStickinessPolicyRequest request);

        /// <summary>
        /// Create LB Cookie Stickiness Policy
        /// </summary>
        /// <param name="request">Create LB Cookie Stickiness Policy  request</param>
        /// <returns>Create LB Cookie Stickiness Policy  Response from the service</returns>
        CreateLBCookieStickinessPolicyResponse CreateLBCookieStickinessPolicy(CreateLBCookieStickinessPolicyRequest request);

        /// <summary>
        /// Delete Load Balancer Policy
        /// </summary>
        /// <param name="request">Delete Load Balancer Policy  request</param>
        /// <returns>Delete Load Balancer Policy  Response from the service</returns>
        DeleteLoadBalancerPolicyResponse DeleteLoadBalancerPolicy(DeleteLoadBalancerPolicyRequest request);

    }
}
