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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ElasticLoadBalancing.Model
{
    public partial class AppCookieStickinessPolicy
    {
        /// <summary>
        /// Default constructor for a new AppCookieStickinessPolicy object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public AppCookieStickinessPolicy() { }

        /// <summary>
        /// Constructs a new AppCookieStickinessPolicy object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="policyName"> The mnemonic name for the policy being created. The name must be unique within a set of policies for this load
        /// balancer. </param>
        /// <param name="cookieName"> The name of the application cookie used for stickiness. </param>
        public AppCookieStickinessPolicy(string policyName, string cookieName)
        {
            this.PolicyName = policyName;
            this.CookieName = cookieName;
        }
    }

    public partial class ConfigureHealthCheckRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new ConfigureHealthCheckRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public ConfigureHealthCheckRequest() { }

        /// <summary>
        /// Constructs a new ConfigureHealthCheckRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The mnemonic name associated with the load balancer. The name must be unique within the set of load
        /// balancers associated with your AWS account. </param>
        /// <param name="healthCheck"> A structure containing the configuration information for the new healthcheck. </param>
        public ConfigureHealthCheckRequest(string loadBalancerName, HealthCheck healthCheck)
        {
            this.LoadBalancerName = loadBalancerName;
            this.HealthCheck = healthCheck;
        }
    }

    public partial class CreateAppCookieStickinessPolicyRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new CreateAppCookieStickinessPolicyRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public CreateAppCookieStickinessPolicyRequest() { }

        /// <summary>
        /// Constructs a new CreateAppCookieStickinessPolicyRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="policyName"> The name of the policy being created. The name must be unique within the set of policies for this load balancer.
        /// </param>
        /// <param name="cookieName"> Name of the application cookie used for stickiness. </param>
        public CreateAppCookieStickinessPolicyRequest(string loadBalancerName, string policyName, string cookieName)
        {
            this.LoadBalancerName = loadBalancerName;
            this.PolicyName = policyName;
            this.CookieName = cookieName;
        }
    }

    public partial class CreateLBCookieStickinessPolicyRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new CreateLBCookieStickinessPolicyRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public CreateLBCookieStickinessPolicyRequest() { }

        /// <summary>
        /// Constructs a new CreateLBCookieStickinessPolicyRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        /// <param name="policyName"> The name of the policy being created. The name must be unique within the set of policies for this load balancer.
        /// </param>
        public CreateLBCookieStickinessPolicyRequest(string loadBalancerName, string policyName)
        {
            this.LoadBalancerName = loadBalancerName;
            this.PolicyName = policyName;
        }
    }

    public partial class CreateLoadBalancerListenersRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new CreateLoadBalancerListenersRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public CreateLoadBalancerListenersRequest() { }

        /// <summary>
        /// Constructs a new CreateLoadBalancerListenersRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="listeners"> A list of <c>LoadBalancerPort</c>, <c>InstancePort</c>, <c>Protocol</c>, and <c>SSLCertificateId</c> items.
        /// </param>
        public CreateLoadBalancerListenersRequest(string loadBalancerName, List<Listener> listeners)
        {
            this.LoadBalancerName = loadBalancerName;
            this.Listeners = listeners;
        }
    }

    public partial class CreateLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new CreateLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public CreateLoadBalancerRequest() { }

        /// <summary>
        /// Constructs a new CreateLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. The name must be unique within your set of load balancers.
        /// </param>
        public CreateLoadBalancerRequest(string loadBalancerName)
        {
            this.LoadBalancerName = loadBalancerName;
        }

        /// <summary>
        /// Constructs a new CreateLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. The name must be unique within your set of load balancers.
        /// </param>
        /// <param name="listeners"> A list of the following tuples: LoadBalancerPort, InstancePort, and Protocol. </param>
        /// <param name="availabilityZones"> A list of Availability Zones. At least one Availability Zone must be specified. Specified Availability
        /// Zones must be in the same EC2 Region as the load balancer. Traffic will be equally distributed across all zones. You can later add more
        /// Availability Zones after the creation of the load balancer by calling <a>EnableAvailabilityZonesForLoadBalancer</a> action. </param>
        public CreateLoadBalancerRequest(string loadBalancerName, List<Listener> listeners, List<string> availabilityZones)
        {
            this.LoadBalancerName = loadBalancerName;
            this.Listeners = listeners;
            this.AvailabilityZones = availabilityZones;
        }
    }

    public partial class DeleteLoadBalancerListenersRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new DeleteLoadBalancerListenersRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DeleteLoadBalancerListenersRequest() { }

        /// <summary>
        /// Constructs a new DeleteLoadBalancerListenersRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The mnemonic name associated with the load balancer. </param>
        /// <param name="loadBalancerPorts"> The client port number(s) of the load balancer listener(s) to be removed. </param>
        public DeleteLoadBalancerListenersRequest(string loadBalancerName, List<int> loadBalancerPorts)
        {
            this.LoadBalancerName = loadBalancerName;
            this.LoadBalancerPorts = loadBalancerPorts;
        }
    }

    public partial class DeleteLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new DeleteLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DeleteLoadBalancerRequest() { }

        /// <summary>
        /// Constructs a new DeleteLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        public DeleteLoadBalancerRequest(string loadBalancerName)
        {
            this.LoadBalancerName = loadBalancerName;
        }
    }

    public partial class DeregisterInstancesFromLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new DeregisterInstancesFromLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DeregisterInstancesFromLoadBalancerRequest() { }

        /// <summary>
        /// Constructs a new DeregisterInstancesFromLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        /// <param name="instances"> A list of EC2 instance IDs consisting of all instances to be deregistered. </param>
        public DeregisterInstancesFromLoadBalancerRequest(string loadBalancerName, List<Instance> instances)
        {
            this.LoadBalancerName = loadBalancerName;
            this.Instances = instances;
        }

    }

    public partial class DescribeInstanceHealthRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new DescribeInstanceHealthRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DescribeInstanceHealthRequest() { }

        /// <summary>
        /// Constructs a new DescribeInstanceHealthRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        public DescribeInstanceHealthRequest(string loadBalancerName)
        {
            this.LoadBalancerName = loadBalancerName;
        }
    }

    public partial class DescribeLoadBalancersRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new DescribeLoadBalancersRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DescribeLoadBalancersRequest() { }

        /// <summary>
        /// Constructs a new DescribeLoadBalancersRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerNames"> A list of load balancer names associated with the account. </param>
        public DescribeLoadBalancersRequest(List<string> loadBalancerNames)
        {
            this.LoadBalancerNames = loadBalancerNames;
        }
    }

    public partial class DisableAvailabilityZonesForLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new DisableAvailabilityZonesForLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public DisableAvailabilityZonesForLoadBalancerRequest() { }

        /// <summary>
        /// Constructs a new DisableAvailabilityZonesForLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        /// <param name="availabilityZones"> A list of Availability Zones to be removed from the load balancer. <note> There must be at least one
        /// Availability Zone registered with a load balancer at all times. Specified Availability Zones must be in the same region. </note> </param>
        public DisableAvailabilityZonesForLoadBalancerRequest(string loadBalancerName, List<string> availabilityZones)
        {
            this.LoadBalancerName = loadBalancerName;
            this.AvailabilityZones = availabilityZones;
        }

    }
    public partial class EnableAvailabilityZonesForLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new EnableAvailabilityZonesForLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public EnableAvailabilityZonesForLoadBalancerRequest() { }

        /// <summary>
        /// Constructs a new EnableAvailabilityZonesForLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. </param>
        /// <param name="availabilityZones"> A list of new Availability Zones for the load balancer. Each Availability Zone must be in the same region
        /// as the load balancer. </param>
        public EnableAvailabilityZonesForLoadBalancerRequest(string loadBalancerName, List<string> availabilityZones)
        {
            this.LoadBalancerName = loadBalancerName;
            this.AvailabilityZones = availabilityZones;
        }
    }

    public partial class HealthCheck
    {
        /// <summary>
        /// Default constructor for a new HealthCheck object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public HealthCheck() { }

        /// <summary>
        /// Constructs a new HealthCheck object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="target"> Specifies the instance being checked. The protocol is either TCP, HTTP, HTTPS, or SSL. The range of valid ports is one
        /// (1) through 65535. <note> TCP is the default, specified as a TCP: port pair, for example "TCP:5000". In this case a healthcheck simply
        /// attempts to open a TCP connection to the instance on the specified port. Failure to connect within the configured timeout is considered
        /// unhealthy. SSL is also specified as SSL: port pair, for example, SSL:5000. For HTTP or HTTPS protocol, the situation is different. You have
        /// to include a ping path in the string. HTTP is specified as a HTTP:port;/;PathToPing; grouping, for example "HTTP:80/weather/us/wa/seattle".
        /// In this case, a HTTP GET request is issued to the instance on the given port and path. Any answer other than "200 OK" within the timeout
        /// period is considered unhealthy. The total length of the HTTP ping target needs to be 1024 16-bit Unicode characters or less. </note>
        /// </param>
        /// <param name="interval"> Specifies the approximate interval, in seconds, between health checks of an individual instance. </param>
        /// <param name="timeout"> Specifies the amount of time, in seconds, during which no response means a failed health probe. <note> This value
        /// must be less than the <i>Interval</i> value. </note> </param>
        /// <param name="unhealthyThreshold"> Specifies the number of consecutive health probe failures required before moving the instance to the
        /// <i>Unhealthy</i> state. </param>
        /// <param name="healthyThreshold"> Specifies the number of consecutive health probe successes required before moving the instance to the
        /// <i>Healthy</i> state. </param>
        public HealthCheck(string target, int interval, int timeout, int unhealthyThreshold, int healthyThreshold)
        {
            this.Target = target;
            this.Interval = interval;
            this.Timeout = timeout;
            this.UnhealthyThreshold = unhealthyThreshold;
            this.HealthyThreshold = healthyThreshold;
        }

    }

    public partial class Instance
    {
        /// <summary>
        /// Default constructor for a new Instance object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public Instance() { }

        /// <summary>
        /// Constructs a new Instance object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="instanceId"> Provides an EC2 instance ID. </param>
        public Instance(string instanceId)
        {
            this.InstanceId = instanceId;
        }

    }

    public partial class LBCookieStickinessPolicy
    {
        /// <summary>
        /// Default constructor for a new LBCookieStickinessPolicy object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public LBCookieStickinessPolicy() { }

        /// <summary>
        /// Constructs a new LBCookieStickinessPolicy object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="policyName"> The name for the policy being created. The name must be unique within the set of policies for this load balancer.
        /// </param>
        /// <param name="cookieExpirationPeriod"> The time period in seconds after which the cookie should be considered stale. Not specifying this
        /// parameter indicates that the stickiness session will last for the duration of the browser session. </param>
        public LBCookieStickinessPolicy(string policyName, long cookieExpirationPeriod)
        {
            this.PolicyName = policyName;
            this.CookieExpirationPeriod = cookieExpirationPeriod;
        }

    }

    public partial class Listener
    {
        /// <summary>
        /// Default constructor for a new Listener object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public Listener() { }

        /// <summary>
        /// Constructs a new Listener object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="protocol"> Specifies the load balancer transport protocol to use for routing - HTTP, HTTPS, TCP or SSL. This property cannot be
        /// modified for the life of the load balancer. </param>
        /// <param name="loadBalancerPort"> Specifies the external load balancer port number. This property cannot be modified for the life of the load
        /// balancer. </param>
        /// <param name="instancePort"> Specifies the TCP port on which the instance server is listening. This property cannot be modified for the life
        /// of the load balancer. </param>
        public Listener(string protocol, int loadBalancerPort, int instancePort)
        {
            this.Protocol = protocol;
            this.LoadBalancerPort = loadBalancerPort;
            this.InstancePort = instancePort;
        }
    }

    public partial class PolicyAttribute
    {
        /// <summary>
        /// Default constructor for a new PolicyAttribute object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public PolicyAttribute() { }

        /// <summary>
        /// Constructs a new PolicyAttribute object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="attributeName"> The name of the attribute associated with the policy. </param>
        /// <param name="attributeValue"> The value of the attribute associated with the policy. </param>
        public PolicyAttribute(string attributeName, string attributeValue)
        {
            this.AttributeName = attributeName;
            this.AttributeValue = attributeValue;
        }
    }

    public partial class RegisterInstancesWithLoadBalancerRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new RegisterInstancesWithLoadBalancerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public RegisterInstancesWithLoadBalancerRequest() { }

        /// <summary>
        /// Constructs a new RegisterInstancesWithLoadBalancerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name associated with the load balancer. The name must be unique within your set of load balancers.
        /// </param>
        /// <param name="instances"> A list of instance IDs that should be registered with the load balancer. </param>
        public RegisterInstancesWithLoadBalancerRequest(string loadBalancerName, List<Instance> instances)
        {
            this.LoadBalancerName = loadBalancerName;
            this.Instances = instances;
        }
    }

    public partial class SetLoadBalancerListenerSSLCertificateRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new SetLoadBalancerListenerSSLCertificateRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public SetLoadBalancerListenerSSLCertificateRequest() { }

        /// <summary>
        /// Constructs a new SetLoadBalancerListenerSSLCertificateRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="loadBalancerPort"> The port that uses the specified SSL certificate. </param>
        /// <param name="sSLCertificateId"> The Amazon Resource Number (ARN) of the SSL certificate chain to use. For more information on SSL
        /// certificates, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/ManagingServerCerts.html"> Managing Server Certificates</a> in
        /// the <i>AWS Identity and Access Management User Guide</i>. </param>
        public SetLoadBalancerListenerSSLCertificateRequest(string loadBalancerName, int loadBalancerPort, string sSLCertificateId)
        {
            this.LoadBalancerName = loadBalancerName;
            this.LoadBalancerPort = loadBalancerPort;
            this.SSLCertificateId = sSLCertificateId;
        }

    }

    public partial class SetLoadBalancerPoliciesOfListenerRequest : AmazonElasticLoadBalancingRequest
    {
        /// <summary>
        /// Default constructor for a new SetLoadBalancerPoliciesOfListenerRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public SetLoadBalancerPoliciesOfListenerRequest() { }

        /// <summary>
        /// Constructs a new SetLoadBalancerPoliciesOfListenerRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="loadBalancerName"> The name of the load balancer. </param>
        /// <param name="loadBalancerPort"> The external port of the load balancer to associate the policy. </param>
        /// <param name="policyNames"> List of policies to be associated with the listener. If the list is empty, the current policy is removed from the
        /// listener. </param>
        public SetLoadBalancerPoliciesOfListenerRequest(string loadBalancerName, int loadBalancerPort, List<string> policyNames)
        {
            this.LoadBalancerName = loadBalancerName;
            this.LoadBalancerPort = loadBalancerPort;
            this.PolicyNames = policyNames;
        }
    }
}