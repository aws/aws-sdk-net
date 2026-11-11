using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ElasticLoadBalancing;
using Amazon.ElasticLoadBalancing.Model;

namespace AWSSDKDocSamples.Amazon.ElasticLoadBalancing.Generated
{
    class ElasticLoadBalancingSamples : ISample
    {
        public void ElasticLoadBalancingAddTags()
        {
            #region AddTags-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.AddTags(new AddTagsRequest
            {
                LoadBalancerNames = new List<string> {
                    "my-load-balancer"
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "project",
                        Value = "lima"
                    },
                    new Tag {
                        Key = "department",
                        Value = "digital-media"
                    }
                }
            });


            #endregion
        }

        public void ElasticLoadBalancingApplySecurityGroupsToLoadBalancer()
        {
            #region ApplySecurityGroupsToLoadBalancer-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.ApplySecurityGroupsToLoadBalancer(new ApplySecurityGroupsToLoadBalancerRequest
            {
                LoadBalancerName = "my-load-balancer",
                SecurityGroups = new List<string> {
                    "sg-fc448899"
                }
            });

            List<string> securityGroups = response.SecurityGroups;

            #endregion
        }

        public void ElasticLoadBalancingAttachLoadBalancerToSubnets()
        {
            #region AttachLoadBalancerToSubnets-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.AttachLoadBalancerToSubnets(new AttachLoadBalancerToSubnetsRequest
            {
                LoadBalancerName = "my-load-balancer",
                Subnets = new List<string> {
                    "subnet-0ecac448"
                }
            });

            List<string> subnets = response.Subnets;

            #endregion
        }

        public void ElasticLoadBalancingConfigureHealthCheck()
        {
            #region ConfigureHealthCheck-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.ConfigureHealthCheck(new ConfigureHealthCheckRequest
            {
                HealthCheck = new HealthCheck {
                    HealthyThreshold = 2,
                    Interval = 30,
                    Target = "HTTP:80/png",
                    Timeout = 3,
                    UnhealthyThreshold = 2
                },
                LoadBalancerName = "my-load-balancer"
            });

            HealthCheck healthCheck = response.HealthCheck;

            #endregion
        }

        public void ElasticLoadBalancingCreateAppCookieStickinessPolicy()
        {
            #region CreateAppCookieStickinessPolicy-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateAppCookieStickinessPolicy(new CreateAppCookieStickinessPolicyRequest
            {
                CookieName = "my-app-cookie",
                LoadBalancerName = "my-load-balancer",
                PolicyName = "my-app-cookie-policy"
            });


            #endregion
        }

        public void ElasticLoadBalancingCreateLBCookieStickinessPolicy()
        {
            #region CreateLBCookieStickinessPolicy-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLBCookieStickinessPolicy(new CreateLBCookieStickinessPolicyRequest
            {
                CookieExpirationPeriod = 60,
                LoadBalancerName = "my-load-balancer",
                PolicyName = "my-duration-cookie-policy"
            });


            #endregion
        }

        public void ElasticLoadBalancingCreateLoadBalancer()
        {
            #region CreateLoadBalancer-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLoadBalancer(new CreateLoadBalancerRequest
            {
                Listeners = new List<Listener> {
                    new Listener {
                        InstancePort = 80,
                        InstanceProtocol = "HTTP",
                        LoadBalancerPort = 80,
                        Protocol = "HTTP"
                    }
                },
                LoadBalancerName = "my-load-balancer",
                SecurityGroups = new List<string> {
                    "sg-a61988c3"
                },
                Subnets = new List<string> {
                    "subnet-15aaab61"
                }
            });

            string dnsName = response.DNSName;

            #endregion
        }

        public void ElasticLoadBalancingCreateLoadBalancer()
        {
            #region CreateLoadBalancer-2

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLoadBalancer(new CreateLoadBalancerRequest
            {
                AvailabilityZones = new List<string> {
                    "us-west-2a"
                },
                Listeners = new List<Listener> {
                    new Listener {
                        InstancePort = 80,
                        InstanceProtocol = "HTTP",
                        LoadBalancerPort = 80,
                        Protocol = "HTTP"
                    }
                },
                LoadBalancerName = "my-load-balancer"
            });

            string dnsName = response.DNSName;

            #endregion
        }

        public void ElasticLoadBalancingCreateLoadBalancer()
        {
            #region CreateLoadBalancer-3

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLoadBalancer(new CreateLoadBalancerRequest
            {
                Listeners = new List<Listener> {
                    new Listener {
                        InstancePort = 80,
                        InstanceProtocol = "HTTP",
                        LoadBalancerPort = 80,
                        Protocol = "HTTP"
                    },
                    new Listener {
                        InstancePort = 80,
                        InstanceProtocol = "HTTP",
                        LoadBalancerPort = 443,
                        Protocol = "HTTPS",
                        SSLCertificateId = "arn:aws:iam::123456789012:server-certificate/my-server-cert"
                    }
                },
                LoadBalancerName = "my-load-balancer",
                SecurityGroups = new List<string> {
                    "sg-a61988c3"
                },
                Subnets = new List<string> {
                    "subnet-15aaab61"
                }
            });

            string dnsName = response.DNSName;

            #endregion
        }

        public void ElasticLoadBalancingCreateLoadBalancer()
        {
            #region CreateLoadBalancer-4

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLoadBalancer(new CreateLoadBalancerRequest
            {
                AvailabilityZones = new List<string> {
                    "us-west-2a"
                },
                Listeners = new List<Listener> {
                    new Listener {
                        InstancePort = 80,
                        InstanceProtocol = "HTTP",
                        LoadBalancerPort = 80,
                        Protocol = "HTTP"
                    },
                    new Listener {
                        InstancePort = 80,
                        InstanceProtocol = "HTTP",
                        LoadBalancerPort = 443,
                        Protocol = "HTTPS",
                        SSLCertificateId = "arn:aws:iam::123456789012:server-certificate/my-server-cert"
                    }
                },
                LoadBalancerName = "my-load-balancer"
            });

            string dnsName = response.DNSName;

            #endregion
        }

        public void ElasticLoadBalancingCreateLoadBalancer()
        {
            #region CreateLoadBalancer-5

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLoadBalancer(new CreateLoadBalancerRequest
            {
                Listeners = new List<Listener> {
                    new Listener {
                        InstancePort = 80,
                        InstanceProtocol = "HTTP",
                        LoadBalancerPort = 80,
                        Protocol = "HTTP"
                    }
                },
                LoadBalancerName = "my-load-balancer",
                Scheme = "internal",
                SecurityGroups = new List<string> {
                    "sg-a61988c3"
                },
                Subnets = new List<string> {
                    "subnet-15aaab61"
                }
            });

            string dnsName = response.DNSName;

            #endregion
        }

        public void ElasticLoadBalancingCreateLoadBalancerListeners()
        {
            #region CreateLoadBalancerListeners-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLoadBalancerListeners(new CreateLoadBalancerListenersRequest
            {
                Listeners = new List<Listener> {
                    new Listener {
                        InstancePort = 80,
                        InstanceProtocol = "HTTP",
                        LoadBalancerPort = 80,
                        Protocol = "HTTP"
                    }
                },
                LoadBalancerName = "my-load-balancer"
            });


            #endregion
        }

        public void ElasticLoadBalancingCreateLoadBalancerListeners()
        {
            #region CreateLoadBalancerListeners-2

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLoadBalancerListeners(new CreateLoadBalancerListenersRequest
            {
                Listeners = new List<Listener> {
                    new Listener {
                        InstancePort = 80,
                        InstanceProtocol = "HTTP",
                        LoadBalancerPort = 443,
                        Protocol = "HTTPS",
                        SSLCertificateId = "arn:aws:iam::123456789012:server-certificate/my-server-cert"
                    }
                },
                LoadBalancerName = "my-load-balancer"
            });


            #endregion
        }

        public void ElasticLoadBalancingCreateLoadBalancerPolicy()
        {
            #region CreateLoadBalancerPolicy-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLoadBalancerPolicy(new CreateLoadBalancerPolicyRequest
            {
                LoadBalancerName = "my-load-balancer",
                PolicyAttributes = new List<PolicyAttribute> {
                    new PolicyAttribute {
                        AttributeName = "ProxyProtocol",
                        AttributeValue = "true"
                    }
                },
                PolicyName = "my-ProxyProtocol-policy",
                PolicyTypeName = "ProxyProtocolPolicyType"
            });


            #endregion
        }

        public void ElasticLoadBalancingCreateLoadBalancerPolicy()
        {
            #region CreateLoadBalancerPolicy-2

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLoadBalancerPolicy(new CreateLoadBalancerPolicyRequest
            {
                LoadBalancerName = "my-load-balancer",
                PolicyAttributes = new List<PolicyAttribute> {
                    new PolicyAttribute {
                        AttributeName = "PublicKey",
                        AttributeValue = "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAwAYUjnfyEyXr1pxjhFWBpMlggUcqoi3kl+dS74kj//c6x7ROtusUaeQCTgIUkayttRDWchuqo1pHC1u+n5xxXnBBe2ejbb2WRsKIQ5rXEeixsjFpFsojpSQKkzhVGI6mJVZBJDVKSHmswnwLBdofLhzvllpovBPTHe+o4haAWvDBALJU0pkSI1FecPHcs2hwxf14zHoXy1e2k36A64nXW43wtfx5qcVSIxtCEOjnYRg7RPvybaGfQ+v6Iaxb/+7J5kEvZhTFQId+bSiJImF1FSUT1W1xwzBZPUbcUkkXDj45vC2s3Z8E+Lk7a3uZhvsQHLZnrfuWjBWGWvZ/MhZYgEXAMPLE"
                    }
                },
                PolicyName = "my-PublicKey-policy",
                PolicyTypeName = "PublicKeyPolicyType"
            });


            #endregion
        }

        public void ElasticLoadBalancingCreateLoadBalancerPolicy()
        {
            #region CreateLoadBalancerPolicy-3

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.CreateLoadBalancerPolicy(new CreateLoadBalancerPolicyRequest
            {
                LoadBalancerName = "my-load-balancer",
                PolicyAttributes = new List<PolicyAttribute> {
                    new PolicyAttribute {
                        AttributeName = "PublicKeyPolicyName",
                        AttributeValue = "my-PublicKey-policy"
                    }
                },
                PolicyName = "my-authentication-policy",
                PolicyTypeName = "BackendServerAuthenticationPolicyType"
            });


            #endregion
        }

        public void ElasticLoadBalancingDeleteLoadBalancer()
        {
            #region DeleteLoadBalancer-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DeleteLoadBalancer(new DeleteLoadBalancerRequest
            {
                LoadBalancerName = "my-load-balancer"
            });


            #endregion
        }

        public void ElasticLoadBalancingDeleteLoadBalancerListeners()
        {
            #region DeleteLoadBalancerListeners-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DeleteLoadBalancerListeners(new DeleteLoadBalancerListenersRequest
            {
                LoadBalancerName = "my-load-balancer",
                LoadBalancerPorts = new List<int> {
                    80
                }
            });


            #endregion
        }

        public void ElasticLoadBalancingDeleteLoadBalancerPolicy()
        {
            #region DeleteLoadBalancerPolicy-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DeleteLoadBalancerPolicy(new DeleteLoadBalancerPolicyRequest
            {
                LoadBalancerName = "my-load-balancer",
                PolicyName = "my-duration-cookie-policy"
            });


            #endregion
        }

        public void ElasticLoadBalancingDeregisterInstancesFromLoadBalancer()
        {
            #region DeregisterInstancesFromLoadBalancer-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DeregisterInstancesFromLoadBalancer(new DeregisterInstancesFromLoadBalancerRequest
            {
                Instances = new List<Instance> {
                    new Instance { InstanceId = "i-d6f6fae3" }
                },
                LoadBalancerName = "my-load-balancer"
            });

            List<Instance> instances = response.Instances;

            #endregion
        }

        public void ElasticLoadBalancingDescribeInstanceHealth()
        {
            #region DescribeInstanceHealth-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DescribeInstanceHealth(new DescribeInstanceHealthRequest
            {
                LoadBalancerName = "my-load-balancer"
            });

            List<InstanceState> instanceStates = response.InstanceStates;

            #endregion
        }

        public void ElasticLoadBalancingDescribeLoadBalancerAttributes()
        {
            #region DescribeLoadBalancerAttributes-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DescribeLoadBalancerAttributes(new DescribeLoadBalancerAttributesRequest
            {
                LoadBalancerName = "my-load-balancer"
            });

            LoadBalancerAttributes loadBalancerAttributes = response.LoadBalancerAttributes;

            #endregion
        }

        public void ElasticLoadBalancingDescribeLoadBalancerPolicies()
        {
            #region DescribeLoadBalancerPolicies-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DescribeLoadBalancerPolicies(new DescribeLoadBalancerPoliciesRequest
            {
                LoadBalancerName = "my-load-balancer",
                PolicyNames = new List<string> {
                    "my-authentication-policy"
                }
            });

            List<PolicyDescription> policyDescriptions = response.PolicyDescriptions;

            #endregion
        }

        public void ElasticLoadBalancingDescribeLoadBalancerPolicyTypes()
        {
            #region DescribeLoadBalancerPolicyTypes-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DescribeLoadBalancerPolicyTypes(new DescribeLoadBalancerPolicyTypesRequest
            {
                PolicyTypeNames = new List<string> {
                    "ProxyProtocolPolicyType"
                }
            });

            List<PolicyTypeDescription> policyTypeDescriptions = response.PolicyTypeDescriptions;

            #endregion
        }

        public void ElasticLoadBalancingDescribeLoadBalancers()
        {
            #region DescribeLoadBalancers-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DescribeLoadBalancers(new DescribeLoadBalancersRequest
            {
                LoadBalancerNames = new List<string> {
                    "my-load-balancer"
                }
            });

            List<LoadBalancerDescription> loadBalancerDescriptions = response.LoadBalancerDescriptions;

            #endregion
        }

        public void ElasticLoadBalancingDescribeTags()
        {
            #region DescribeTags-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DescribeTags(new DescribeTagsRequest
            {
                LoadBalancerNames = new List<string> {
                    "my-load-balancer"
                }
            });

            List<TagDescription> tagDescriptions = response.TagDescriptions;

            #endregion
        }

        public void ElasticLoadBalancingDetachLoadBalancerFromSubnets()
        {
            #region DetachLoadBalancerFromSubnets-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DetachLoadBalancerFromSubnets(new DetachLoadBalancerFromSubnetsRequest
            {
                LoadBalancerName = "my-load-balancer",
                Subnets = new List<string> {
                    "subnet-0ecac448"
                }
            });

            List<string> subnets = response.Subnets;

            #endregion
        }

        public void ElasticLoadBalancingDisableAvailabilityZonesForLoadBalancer()
        {
            #region DisableAvailabilityZonesForLoadBalancer-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.DisableAvailabilityZonesForLoadBalancer(new DisableAvailabilityZonesForLoadBalancerRequest
            {
                AvailabilityZones = new List<string> {
                    "us-west-2a"
                },
                LoadBalancerName = "my-load-balancer"
            });

            List<string> availabilityZones = response.AvailabilityZones;

            #endregion
        }

        public void ElasticLoadBalancingEnableAvailabilityZonesForLoadBalancer()
        {
            #region EnableAvailabilityZonesForLoadBalancer-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.EnableAvailabilityZonesForLoadBalancer(new EnableAvailabilityZonesForLoadBalancerRequest
            {
                AvailabilityZones = new List<string> {
                    "us-west-2b"
                },
                LoadBalancerName = "my-load-balancer"
            });

            List<string> availabilityZones = response.AvailabilityZones;

            #endregion
        }

        public void ElasticLoadBalancingModifyLoadBalancerAttributes()
        {
            #region ModifyLoadBalancerAttributes-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.ModifyLoadBalancerAttributes(new ModifyLoadBalancerAttributesRequest
            {
                LoadBalancerAttributes = new LoadBalancerAttributes { CrossZoneLoadBalancing = new CrossZoneLoadBalancing { Enabled = true } },
                LoadBalancerName = "my-load-balancer"
            });

            LoadBalancerAttributes loadBalancerAttributes = response.LoadBalancerAttributes;
            string loadBalancerName = response.LoadBalancerName;

            #endregion
        }

        public void ElasticLoadBalancingModifyLoadBalancerAttributes()
        {
            #region ModifyLoadBalancerAttributes-2

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.ModifyLoadBalancerAttributes(new ModifyLoadBalancerAttributesRequest
            {
                LoadBalancerAttributes = new LoadBalancerAttributes { ConnectionDraining = new ConnectionDraining {
                    Enabled = true,
                    Timeout = 300
                } },
                LoadBalancerName = "my-load-balancer"
            });

            LoadBalancerAttributes loadBalancerAttributes = response.LoadBalancerAttributes;
            string loadBalancerName = response.LoadBalancerName;

            #endregion
        }

        public void ElasticLoadBalancingRegisterInstancesWithLoadBalancer()
        {
            #region RegisterInstancesWithLoadBalancer-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.RegisterInstancesWithLoadBalancer(new RegisterInstancesWithLoadBalancerRequest
            {
                Instances = new List<Instance> {
                    new Instance { InstanceId = "i-d6f6fae3" }
                },
                LoadBalancerName = "my-load-balancer"
            });

            List<Instance> instances = response.Instances;

            #endregion
        }

        public void ElasticLoadBalancingRemoveTags()
        {
            #region RemoveTags-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.RemoveTags(new RemoveTagsRequest
            {
                LoadBalancerNames = new List<string> {
                    "my-load-balancer"
                },
                Tags = new List<TagKeyOnly> {
                    new TagKeyOnly { Key = "project" }
                }
            });


            #endregion
        }

        public void ElasticLoadBalancingSetLoadBalancerListenerSSLCertificate()
        {
            #region SetLoadBalancerListenerSSLCertificate-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.SetLoadBalancerListenerSSLCertificate(new SetLoadBalancerListenerSSLCertificateRequest
            {
                LoadBalancerName = "my-load-balancer",
                LoadBalancerPort = 443,
                SSLCertificateId = "arn:aws:iam::123456789012:server-certificate/new-server-cert"
            });


            #endregion
        }

        public void ElasticLoadBalancingSetLoadBalancerPoliciesForBackendServer()
        {
            #region SetLoadBalancerPoliciesForBackendServer-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.SetLoadBalancerPoliciesForBackendServer(new SetLoadBalancerPoliciesForBackendServerRequest
            {
                InstancePort = 80,
                LoadBalancerName = "my-load-balancer",
                PolicyNames = new List<string> {
                    "my-ProxyProtocol-policy"
                }
            });


            #endregion
        }

        public void ElasticLoadBalancingSetLoadBalancerPoliciesOfListener()
        {
            #region SetLoadBalancerPoliciesOfListener-1

            var client = new AmazonElasticLoadBalancingClient();
            var response = client.SetLoadBalancerPoliciesOfListener(new SetLoadBalancerPoliciesOfListenerRequest
            {
                LoadBalancerName = "my-load-balancer",
                LoadBalancerPort = 80,
                PolicyNames = new List<string> {
                    "my-SSLNegotiation-policy"
                }
            });


            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
