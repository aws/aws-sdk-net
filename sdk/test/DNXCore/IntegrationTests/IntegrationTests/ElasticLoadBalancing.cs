using System;
using System.Collections.Generic;
using System.Threading;

using Amazon.ElasticLoadBalancing;
using Amazon.ElasticLoadBalancing.Model;
using Xunit;
using Amazon.DNXCore.IntegrationTests;

namespace Amazon.DNXCore.IntegrationTests
{
    
    public class ElasticLoadBalancing : TestBase<AmazonElasticLoadBalancingClient>
    {
        const string SDK_TEST_PREFIX = "aws-net-sdk";
        public string AVAILABILITY_ZONE_1;
        public string AVAILABILITY_ZONE_2;

        public const String PROTOCOL = "HTTP";
        string loadBalancerName;

        public ElasticLoadBalancing()
        {
            if (loadBalancerName != null)
            {
                Client.DeleteLoadBalancerAsync(new DeleteLoadBalancerRequest()
                {
                    LoadBalancerName = loadBalancerName
                }).Wait();
            }
        }
             
        [Fact]
        [Trait(CategoryAttribute,"ElasticLoadBalancing")]
        public void TestLoadBalancerOperations()
        {
            using(var ec2 = CreateClient<Amazon.EC2.AmazonEC2Client>())
            {
                var regionName = AWSConfigs.RegionEndpoint.SystemName;

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
                Assert.False(string.IsNullOrEmpty(dnsName));


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
                Assert.Equal(expectedHealthCheck.HealthyThreshold, createdHealthCheck.HealthyThreshold);
                Assert.Equal(expectedHealthCheck.Interval, createdHealthCheck.Interval);
                Assert.Equal(expectedHealthCheck.Target, createdHealthCheck.Target);
                Assert.Equal(expectedHealthCheck.Timeout, createdHealthCheck.Timeout);
                Assert.Equal(expectedHealthCheck.UnhealthyThreshold, createdHealthCheck.UnhealthyThreshold);


                // Describe
                List<LoadBalancerDescription> loadBalancerDescriptions =
                    Client.DescribeLoadBalancersAsync(
                            new DescribeLoadBalancersRequest()
                            {
                                LoadBalancerNames = new List<string>() { loadBalancerName }
                            }
                    ).Result.LoadBalancerDescriptions;
                Assert.Equal(1, loadBalancerDescriptions.Count);
                LoadBalancerDescription loadBalancer = loadBalancerDescriptions[0];
                Assert.Equal(loadBalancerName, loadBalancer.LoadBalancerName);
                Assert.Equal(1, loadBalancer.AvailabilityZones.Count);
                Assert.True(loadBalancer.AvailabilityZones.Contains(AVAILABILITY_ZONE_1));
                Assert.NotNull(loadBalancer.CreatedTime);
                Assert.Equal(dnsName, loadBalancer.DNSName);
                Assert.Equal(expectedHealthCheck.Target, loadBalancer.HealthCheck.Target);
                Assert.True(loadBalancer.Instances.Count == 0);
                Assert.Equal(1, loadBalancer.ListenerDescriptions.Count);
                //Assert.Equal((double)8080, (double)loadBalancer.ListenerDescriptions[0].Listener.InstancePort, 0.0);
                //Assert.Equal((double)80, (double)loadBalancer.ListenerDescriptions[0].Listener.LoadBalancerPort, 0.0);
                Assert.Equal((double)8080, (double)loadBalancer.ListenerDescriptions[0].Listener.InstancePort);
                Assert.Equal((double)80, (double)loadBalancer.ListenerDescriptions[0].Listener.LoadBalancerPort);
                Assert.Equal(PROTOCOL, loadBalancer.ListenerDescriptions[0].Listener.Protocol);
                Assert.Equal(loadBalancerName, loadBalancer.LoadBalancerName);
                Assert.NotNull(loadBalancer.SourceSecurityGroup);
                Assert.NotNull(loadBalancer.SourceSecurityGroup.GroupName);
                Assert.NotNull(loadBalancer.SourceSecurityGroup.OwnerAlias);


                // Enabled AZs
                List<String> availabilityZones =
                    Client.EnableAvailabilityZonesForLoadBalancerAsync(
                            new EnableAvailabilityZonesForLoadBalancerRequest()
                            {
                                LoadBalancerName = loadBalancerName,
                                AvailabilityZones = new List<string>() { AVAILABILITY_ZONE_2 }
                            }
                    ).Result.AvailabilityZones;
                Assert.Equal(2, availabilityZones.Count);
                Assert.True(availabilityZones.Contains(AVAILABILITY_ZONE_1));
                Assert.True(availabilityZones.Contains(AVAILABILITY_ZONE_2));

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
                Assert.Equal(1, availabilityZones.Count);
                Assert.True(availabilityZones.Contains(AVAILABILITY_ZONE_1));
                Assert.False(availabilityZones.Contains(AVAILABILITY_ZONE_2));

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
                Assert.True(DoesLoadBalancerHaveListenerWithPolicy(loadBalancerName, policyName));

                // Remove the policy from the listener
                Client.SetLoadBalancerPoliciesOfListenerAsync(new SetLoadBalancerPoliciesOfListenerRequest()
                {
                    LoadBalancerName = loadBalancerName,
                    LoadBalancerPort = 80
                }).Wait();
                Assert.False(DoesLoadBalancerHaveListenerWithPolicy(loadBalancerName, policyName));

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

            if (loadBalancers.Count == 0) AssertExtensions.Fail("Unknown load balancer: " + loadBalancerName);

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
