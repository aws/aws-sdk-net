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
using System.Collections.Generic;
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for Elastic Load Balancing.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public class ElasticLoadBalancingActionIdentifiers
    {
        public static readonly ActionIdentifier AllElasticLoadBalancingActions = new ActionIdentifier("elasticloadbalancing:*");

        public static readonly ActionIdentifier ConfigureHealthCheck = new ActionIdentifier("elasticloadbalancing:ConfigureHealthCheck");
        public static readonly ActionIdentifier CreateAppCookieStickinessPolicy = new ActionIdentifier("elasticloadbalancing:CreateAppCookieStickinessPolicy");
        public static readonly ActionIdentifier CreateLBCookieStickinessPolicy = new ActionIdentifier("elasticloadbalancing:CreateLBCookieStickinessPolicy");
        public static readonly ActionIdentifier CreateLoadBalancer = new ActionIdentifier("elasticloadbalancing:CreateLoadBalancer");
        public static readonly ActionIdentifier CreateLoadBalancerListeners = new ActionIdentifier("elasticloadbalancing:CreateLoadBalancerListeners");
        public static readonly ActionIdentifier DeleteLoadBalancer = new ActionIdentifier("elasticloadbalancing:DeleteLoadBalancer");
        public static readonly ActionIdentifier DeleteLoadBalancerListeners = new ActionIdentifier("elasticloadbalancing:DeleteLoadBalancerListeners");
        public static readonly ActionIdentifier DeleteLoadBalancerPolicy = new ActionIdentifier("elasticloadbalancing:DeleteLoadBalancerPolicy");
        public static readonly ActionIdentifier DeregisterInstancesFromLoadBalancer = new ActionIdentifier("elasticloadbalancing:DeregisterInstancesFromLoadBalancer");
        public static readonly ActionIdentifier DescribeInstanceHealth = new ActionIdentifier("elasticloadbalancing:DescribeInstanceHealth");
        public static readonly ActionIdentifier DescribeLoadBalancers = new ActionIdentifier("elasticloadbalancing:DescribeLoadBalancers");
        public static readonly ActionIdentifier DisableAvailabilityZonesForLoadBalancer = new ActionIdentifier("elasticloadbalancing:DisableAvailabilityZonesForLoadBalancer");
        public static readonly ActionIdentifier EnableAvailabilityZonesForLoadBalancer = new ActionIdentifier("elasticloadbalancing:EnableAvailabilityZonesForLoadBalancer");
        public static readonly ActionIdentifier RegisterInstancesWithLoadBalancer = new ActionIdentifier("elasticloadbalancing:RegisterInstancesWithLoadBalancer");
        public static readonly ActionIdentifier SetLoadBalancerListenerSSLCertificate = new ActionIdentifier("elasticloadbalancing:SetLoadBalancerListenerSSLCertificate");
        public static readonly ActionIdentifier SetLoadBalancerPoliciesOfListener = new ActionIdentifier("elasticloadbalancing:SetLoadBalancerPoliciesOfListener");
    }
}
