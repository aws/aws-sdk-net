using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using AWSSDK_DotNet.IntegrationTests.Utils;

using Amazon.ElasticLoadBalancing;
using Amazon.ElasticLoadBalancing.Model;

namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class ElasticLoadBalancing : TestBase<AmazonElasticLoadBalancingClient>
    {
        const string SDK_TEST_PREFIX = "aws-net-sdk";
        public const String AVAILABILITY_ZONE_1 = "us-east-1c";
        public const String AVAILABILITY_ZONE_2 = "us-east-1b";

        public const String PROTOCOL = "HTTP";
        string loadBalancerName;

        [ClassCleanup]
        public static void Cleanup()
        {
            BaseClean();
        }

        [TestCleanup]
        public void TestCleanup()
        {
            if (loadBalancerName != null)
            {
                Client.DeleteLoadBalancer(new DeleteLoadBalancerRequest()
                {
                    LoadBalancerName = loadBalancerName
                });
            }
        }

        [TestMethod]
        [TestCategory("ElasticLoadBalancing")]
        public void TestLoadBalancerOperations()
        {
            loadBalancerName = SDK_TEST_PREFIX+"-lb" + DateTime.Now.Ticks;
            Listener expectedListener = new Listener()
            {
                InstancePort = 8080,
                LoadBalancerPort = 80,
                Protocol = PROTOCOL
            };

            // Create a load balancer
            string dnsName = Client.CreateLoadBalancer(
                    new CreateLoadBalancerRequest()
                    {
                        LoadBalancerName = loadBalancerName,
                        AvailabilityZones = new List<string>() { AVAILABILITY_ZONE_1 },
                        Listeners = new List<Listener>() { expectedListener }
                    }).DNSName;
            try
            {
                Assert.IsFalse(string.IsNullOrEmpty(dnsName));


                // Configure health checks
                HealthCheck expectedHealthCheck = new HealthCheck()
                {
                    Interval = 120,
                    Target = "HTTP:80/ping",
                    Timeout = 60,
                    UnhealthyThreshold = 9,
                    HealthyThreshold = 10
                };

                HealthCheck createdHealthCheck = Client.ConfigureHealthCheck(
                        new ConfigureHealthCheckRequest()
                        {
                            LoadBalancerName = loadBalancerName,
                            HealthCheck = expectedHealthCheck
                        }).HealthCheck;
                Assert.AreEqual(expectedHealthCheck.HealthyThreshold, createdHealthCheck.HealthyThreshold);
                Assert.AreEqual(expectedHealthCheck.Interval, createdHealthCheck.Interval);
                Assert.AreEqual(expectedHealthCheck.Target, createdHealthCheck.Target);
                Assert.AreEqual(expectedHealthCheck.Timeout, createdHealthCheck.Timeout);
                Assert.AreEqual(expectedHealthCheck.UnhealthyThreshold, createdHealthCheck.UnhealthyThreshold);


                // Describe
                List<LoadBalancerDescription> loadBalancerDescriptions =
                    Client.DescribeLoadBalancers(
                            new DescribeLoadBalancersRequest()
                            {
                                LoadBalancerNames = new List<string>() { loadBalancerName }
                            }
                    ).LoadBalancerDescriptions;
                Assert.AreEqual(1, loadBalancerDescriptions.Count);
                LoadBalancerDescription loadBalancer = loadBalancerDescriptions[0];
                Assert.AreEqual(loadBalancerName, loadBalancer.LoadBalancerName);
                Assert.AreEqual(1, loadBalancer.AvailabilityZones.Count);
                Assert.IsTrue(loadBalancer.AvailabilityZones.Contains(AVAILABILITY_ZONE_1));
                Assert.IsNotNull(loadBalancer.CreatedTime);
                Assert.AreEqual(dnsName, loadBalancer.DNSName);
                Assert.AreEqual(expectedHealthCheck.Target, loadBalancer.HealthCheck.Target);
                Assert.IsTrue(loadBalancer.Instances.Count == 0);
                Assert.AreEqual(1, loadBalancer.ListenerDescriptions.Count);
                Assert.AreEqual((double)8080, (double)loadBalancer.ListenerDescriptions[0].Listener.InstancePort, 0.0);
                Assert.AreEqual((double)80, (double)loadBalancer.ListenerDescriptions[0].Listener.LoadBalancerPort, 0.0);
                Assert.AreEqual(PROTOCOL, loadBalancer.ListenerDescriptions[0].Listener.Protocol);
                Assert.AreEqual(loadBalancerName, loadBalancer.LoadBalancerName);
                Assert.IsNotNull(loadBalancer.SourceSecurityGroup);
                Assert.IsNotNull(loadBalancer.SourceSecurityGroup.GroupName);
                Assert.IsNotNull(loadBalancer.SourceSecurityGroup.OwnerAlias);


                // Enabled AZs
                List<String> availabilityZones =
                    Client.EnableAvailabilityZonesForLoadBalancer(
                            new EnableAvailabilityZonesForLoadBalancerRequest()
                            {
                                LoadBalancerName = loadBalancerName,
                                AvailabilityZones = new List<string>() { AVAILABILITY_ZONE_2 }
                            }
                    ).AvailabilityZones;
                Assert.AreEqual(2, availabilityZones.Count);
                Assert.IsTrue(availabilityZones.Contains(AVAILABILITY_ZONE_1));
                Assert.IsTrue(availabilityZones.Contains(AVAILABILITY_ZONE_2));

                Thread.Sleep(1000 * 10);

                // Disable AZs
                availabilityZones =
                    Client.DisableAvailabilityZonesForLoadBalancer(
                            new DisableAvailabilityZonesForLoadBalancerRequest()
                            {
                                LoadBalancerName = loadBalancerName,
                                AvailabilityZones = new List<string>() { AVAILABILITY_ZONE_2 }
                            }
                    ).AvailabilityZones;
                Assert.AreEqual(1, availabilityZones.Count);
                Assert.IsTrue(availabilityZones.Contains(AVAILABILITY_ZONE_1));
                Assert.IsFalse(availabilityZones.Contains(AVAILABILITY_ZONE_2));

                // Create LB stickiness policy
                String policyName = SDK_TEST_PREFIX + "-policy-" + DateTime.Now.Ticks;
                Client.CreateLBCookieStickinessPolicy(new CreateLBCookieStickinessPolicyRequest()
                {
                    LoadBalancerName = loadBalancerName,
                    PolicyName = policyName
                });


                // Attach the policy to a listener
                Client.SetLoadBalancerPoliciesOfListener(new SetLoadBalancerPoliciesOfListenerRequest()
                {
                    LoadBalancerName = loadBalancerName,
                    LoadBalancerPort = 80,
                    PolicyNames = new List<string>() { policyName }
                });
                Assert.IsTrue(DoesLoadBalancerHaveListenerWithPolicy(loadBalancerName, policyName));

                // Remove the policy from the listener
                Client.SetLoadBalancerPoliciesOfListener(new SetLoadBalancerPoliciesOfListenerRequest()
                {
                    LoadBalancerName = loadBalancerName,
                    LoadBalancerPort = 80
                });
                Assert.IsFalse(DoesLoadBalancerHaveListenerWithPolicy(loadBalancerName, policyName));

                // Delete the policy
                Client.DeleteLoadBalancerPolicy(new DeleteLoadBalancerPolicyRequest(loadBalancerName, policyName));
            }
            finally
            {
                // Delete the test load balancer
                Client.DeleteLoadBalancer(new DeleteLoadBalancerRequest() { LoadBalancerName = loadBalancerName });
            }

        }

        private bool DoesLoadBalancerHaveListenerWithPolicy(String loadBalancerName, String policyName)
        {
            List<LoadBalancerDescription> loadBalancers = Client.DescribeLoadBalancers(
                new DescribeLoadBalancersRequest() { LoadBalancerNames = new List<string>() { loadBalancerName } })
                .LoadBalancerDescriptions;

            if (loadBalancers.Count == 0) Assert.Fail("Unknown load balancer: " + loadBalancerName);

            List<ListenerDescription> listeners = loadBalancers[0].ListenerDescriptions;
            foreach (ListenerDescription listener in listeners)
            {
                if (listener.PolicyNames.Contains(policyName))
                    return true;
            }

            return false;
        }
    }
}
