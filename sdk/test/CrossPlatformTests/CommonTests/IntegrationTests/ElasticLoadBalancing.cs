using System;
using System.Collections.Generic;
using System.Threading;

using Amazon.ElasticLoadBalancing;
using Amazon.ElasticLoadBalancing.Model;
using NUnit.Framework;
using CommonTests.Framework;

namespace CommonTests.IntegrationTests
{
    [TestFixture]
    public class ElasticLoadBalancing : TestBase<AmazonElasticLoadBalancingClient>
    {
        const string SDK_TEST_PREFIX = "aws-net-sdk";
        public string AVAILABILITY_ZONE_1;
        public string AVAILABILITY_ZONE_2;

        public const String PROTOCOL = "HTTP";
        string loadBalancerName;

        [OneTimeTearDown]
        public void Cleanup()
        {
            BaseClean();
        }

        [OneTimeSetUp]
        public void TestCleanup()
        {
            if (loadBalancerName != null)
            {
                Client.DeleteLoadBalancerAsync(new DeleteLoadBalancerRequest()
                {
                    LoadBalancerName = loadBalancerName
                }).Wait();
            }
        }

        [Test]
        [Category("ElasticLoadBalancing")]
        public void TestLoadBalancerOperations()
        {
            using(var ec2 = CreateClient<Amazon.EC2.AmazonEC2Client>())
            {
                var regionName = TestRunner.RegionEndpoint.SystemName;

                var availabilityZones = ec2.DescribeAvailabilityZonesAsync(new Amazon.EC2.Model.DescribeAvailabilityZonesRequest
                {
                    Filters = new List<Amazon.EC2.Model.Filter>
                    {
                        new Amazon.EC2.Model.Filter
                        {
                            Name = "region-name",
                            Values = new List<string>
                            {
                                regionName
                            }
                        }
                    }
                }).Result.AvailabilityZones;

                AVAILABILITY_ZONE_1 = availabilityZones[0].ZoneName;
                AVAILABILITY_ZONE_2 = availabilityZones[1].ZoneName;
            }

            loadBalancerName = SDK_TEST_PREFIX+"-lb" + DateTime.Now.Ticks;
            Listener expectedListener = new Listener()
            {
                InstancePort = 8080,
                LoadBalancerPort = 80,
                Protocol = PROTOCOL
            };

            // Create a load balancer
            string dnsName = Client.CreateLoadBalancerAsync(
                    new CreateLoadBalancerRequest()
                    {
                        LoadBalancerName = loadBalancerName,
                        AvailabilityZones = new List<string>() { AVAILABILITY_ZONE_1 },
                        Listeners = new List<Listener>() { expectedListener }
                    }).Result.DNSName;
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

                HealthCheck createdHealthCheck = Client.ConfigureHealthCheckAsync(
                        new ConfigureHealthCheckRequest()
                        {
                            LoadBalancerName = loadBalancerName,
                            HealthCheck = expectedHealthCheck
                        }).Result.HealthCheck;
                Assert.AreEqual(expectedHealthCheck.HealthyThreshold, createdHealthCheck.HealthyThreshold);
                Assert.AreEqual(expectedHealthCheck.Interval, createdHealthCheck.Interval);
                Assert.AreEqual(expectedHealthCheck.Target, createdHealthCheck.Target);
                Assert.AreEqual(expectedHealthCheck.Timeout, createdHealthCheck.Timeout);
                Assert.AreEqual(expectedHealthCheck.UnhealthyThreshold, createdHealthCheck.UnhealthyThreshold);


                // Describe
                List<LoadBalancerDescription> loadBalancerDescriptions =
                    Client.DescribeLoadBalancersAsync(
                            new DescribeLoadBalancersRequest()
                            {
                                LoadBalancerNames = new List<string>() { loadBalancerName }
                            }
                    ).Result.LoadBalancerDescriptions;
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
                    Client.EnableAvailabilityZonesForLoadBalancerAsync(
                            new EnableAvailabilityZonesForLoadBalancerRequest()
                            {
                                LoadBalancerName = loadBalancerName,
                                AvailabilityZones = new List<string>() { AVAILABILITY_ZONE_2 }
                            }
                    ).Result.AvailabilityZones;
                Assert.AreEqual(2, availabilityZones.Count);
                Assert.IsTrue(availabilityZones.Contains(AVAILABILITY_ZONE_1));
                Assert.IsTrue(availabilityZones.Contains(AVAILABILITY_ZONE_2));

                UtilityMethods.Sleep(TimeSpan.FromSeconds(10));

                // Disable AZs
                availabilityZones =
                    Client.DisableAvailabilityZonesForLoadBalancerAsync(
                            new DisableAvailabilityZonesForLoadBalancerRequest()
                            {
                                LoadBalancerName = loadBalancerName,
                                AvailabilityZones = new List<string>() { AVAILABILITY_ZONE_2 }
                            }
                    ).Result.AvailabilityZones;
                Assert.AreEqual(1, availabilityZones.Count);
                Assert.IsTrue(availabilityZones.Contains(AVAILABILITY_ZONE_1));
                Assert.IsFalse(availabilityZones.Contains(AVAILABILITY_ZONE_2));

                // Create LB stickiness policy
                String policyName = SDK_TEST_PREFIX + "-policy-" + DateTime.Now.Ticks;
                Client.CreateLBCookieStickinessPolicyAsync(new CreateLBCookieStickinessPolicyRequest()
                {
                    LoadBalancerName = loadBalancerName,
                    PolicyName = policyName
                }).Wait();


                // Attach the policy to a listener
                Client.SetLoadBalancerPoliciesOfListenerAsync(new SetLoadBalancerPoliciesOfListenerRequest()
                {
                    LoadBalancerName = loadBalancerName,
                    LoadBalancerPort = 80,
                    PolicyNames = new List<string>() { policyName }
                }).Wait();
                Assert.IsTrue(DoesLoadBalancerHaveListenerWithPolicy(loadBalancerName, policyName));

                // Remove the policy from the listener
                Client.SetLoadBalancerPoliciesOfListenerAsync(new SetLoadBalancerPoliciesOfListenerRequest()
                {
                    LoadBalancerName = loadBalancerName,
                    LoadBalancerPort = 80
                }).Wait();
                Assert.IsFalse(DoesLoadBalancerHaveListenerWithPolicy(loadBalancerName, policyName));

                // Delete the policy
                Client.DeleteLoadBalancerPolicyAsync(new DeleteLoadBalancerPolicyRequest(loadBalancerName, policyName)).Wait();
            }
            finally
            {
                // Delete the test load balancer
                Client.DeleteLoadBalancerAsync(new DeleteLoadBalancerRequest() { LoadBalancerName = loadBalancerName }).Wait();
            }

        }

        private bool DoesLoadBalancerHaveListenerWithPolicy(String loadBalancerName, String policyName)
        {
            List<LoadBalancerDescription> loadBalancers = Client.DescribeLoadBalancersAsync(
                new DescribeLoadBalancersRequest() { LoadBalancerNames = new List<string>() { loadBalancerName } })
                .Result.LoadBalancerDescriptions;

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
