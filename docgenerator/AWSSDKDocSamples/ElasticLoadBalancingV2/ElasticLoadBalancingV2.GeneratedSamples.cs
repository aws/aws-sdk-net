using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.ElasticLoadBalancingV2;
using Amazon.ElasticLoadBalancingV2.Model;

namespace AWSSDKDocSamples.Amazon.ElasticLoadBalancingV2.Generated
{
    class ElasticLoadBalancingV2Samples : ISample
    {
        public void ElasticLoadBalancingV2AddTags()
        {
            #region elbv2-add-tags-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.AddTags(new AddTagsRequest 
            {
                ResourceArns = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188"
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

        public void ElasticLoadBalancingV2CreateListener()
        {
            #region elbv2-create-listener-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.CreateListener(new CreateListenerRequest 
            {
                DefaultActions = new List<Action> {
                    new Action {
                        TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067",
                        Type = "forward"
                    }
                },
                LoadBalancerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188",
                Port = 80,
                Protocol = "HTTP"
            });

            List<Listener> listeners = response.Listeners;

            #endregion
        }

        public void ElasticLoadBalancingV2CreateListener()
        {
            #region elbv2-create-listener-2

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.CreateListener(new CreateListenerRequest 
            {
                Certificates = new List<Certificate> {
                    new Certificate { CertificateArn = "arn:aws:iam::123456789012:server-certificate/my-server-cert" }
                },
                DefaultActions = new List<Action> {
                    new Action {
                        TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067",
                        Type = "forward"
                    }
                },
                LoadBalancerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188",
                Port = 443,
                Protocol = "HTTPS",
                SslPolicy = "ELBSecurityPolicy-2015-05"
            });

            List<Listener> listeners = response.Listeners;

            #endregion
        }

        public void ElasticLoadBalancingV2CreateLoadBalancer()
        {
            #region elbv2-create-load-balancer-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.CreateLoadBalancer(new CreateLoadBalancerRequest 
            {
                Name = "my-load-balancer",
                Subnets = new List<string> {
                    "subnet-b7d581c0",
                    "subnet-8360a9e7"
                }
            });

            List<LoadBalancer> loadBalancers = response.LoadBalancers;

            #endregion
        }

        public void ElasticLoadBalancingV2CreateLoadBalancer()
        {
            #region elbv2-create-load-balancer-2

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.CreateLoadBalancer(new CreateLoadBalancerRequest 
            {
                Name = "my-internal-load-balancer",
                Scheme = "internal",
                SecurityGroups = new List<string> {
                    
                },
                Subnets = new List<string> {
                    "subnet-b7d581c0",
                    "subnet-8360a9e7"
                }
            });

            List<LoadBalancer> loadBalancers = response.LoadBalancers;

            #endregion
        }

        public void ElasticLoadBalancingV2CreateRule()
        {
            #region elbv2-create-rule-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.CreateRule(new CreateRuleRequest 
            {
                Actions = new List<Action> {
                    new Action {
                        TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067",
                        Type = "forward"
                    }
                },
                Conditions = new List<RuleCondition> {
                    new RuleCondition {
                        Field = "path-pattern",
                        Values = new List<string> {
                            "/img/*"
                        }
                    }
                },
                ListenerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:listener/app/my-load-balancer/50dc6c495c0c9188/f2f7dc8efc522ab2",
                Priority = 10
            });

            List<Rule> rules = response.Rules;

            #endregion
        }

        public void ElasticLoadBalancingV2CreateTargetGroup()
        {
            #region elbv2-create-target-group-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.CreateTargetGroup(new CreateTargetGroupRequest 
            {
                Name = "my-targets",
                Port = 80,
                Protocol = "HTTP",
                VpcId = "vpc-3ac0fb5f"
            });

            List<TargetGroup> targetGroups = response.TargetGroups;

            #endregion
        }

        public void ElasticLoadBalancingV2DeleteListener()
        {
            #region elbv2-delete-listener-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DeleteListener(new DeleteListenerRequest 
            {
                ListenerArn = "arn:aws:elasticloadbalancing:ua-west-2:123456789012:listener/app/my-load-balancer/50dc6c495c0c9188/f2f7dc8efc522ab2"
            });


            #endregion
        }

        public void ElasticLoadBalancingV2DeleteLoadBalancer()
        {
            #region elbv2-delete-load-balancer-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DeleteLoadBalancer(new DeleteLoadBalancerRequest 
            {
                LoadBalancerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188"
            });


            #endregion
        }

        public void ElasticLoadBalancingV2DeleteRule()
        {
            #region elbv2-delete-rule-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DeleteRule(new DeleteRuleRequest 
            {
                RuleArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:listener-rule/app/my-load-balancer/50dc6c495c0c9188/f2f7dc8efc522ab2/1291d13826f405c3"
            });


            #endregion
        }

        public void ElasticLoadBalancingV2DeleteSharedTrustStoreAssociation()
        {
            #region delete-a-shared-trust-store-association-1721684063527

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DeleteSharedTrustStoreAssociation(new DeleteSharedTrustStoreAssociationRequest 
            {
                ResourceArn = "arn:aws:elasticloadbalancing:us-east-1:123456789012:loadbalancer/app/my-load-balancer/80233fa81d678c2c",
                TrustStoreArn = "arn:aws:elasticloadbalancing:us-east-1:123456789012:truststore/my-trust-store/73e2d6bc24d8a063"
            });


            #endregion
        }

        public void ElasticLoadBalancingV2DeleteTargetGroup()
        {
            #region elbv2-delete-target-group-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DeleteTargetGroup(new DeleteTargetGroupRequest 
            {
                TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
            });


            #endregion
        }

        public void ElasticLoadBalancingV2DeregisterTargets()
        {
            #region elbv2-deregister-targets-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DeregisterTargets(new DeregisterTargetsRequest 
            {
                TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067",
                Targets = new List<TargetDescription> {
                    new TargetDescription { Id = "i-0f76fade" }
                }
            });


            #endregion
        }

        public void ElasticLoadBalancingV2DescribeListenerAttributes()
        {
            #region describe-listener-attributes-1724874395194

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeListenerAttributes(new DescribeListenerAttributesRequest 
            {
                ListenerArn = "aws:elasticloadbalancing:us-east-1:123456789012:listener/net/my-listener/73e2d6bc24d8a067/d5dc06411fa5bcea"
            });


            #endregion
        }

        public void ElasticLoadBalancingV2DescribeListeners()
        {
            #region elbv2-describe-listeners-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeListeners(new DescribeListenersRequest 
            {
                ListenerArns = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:listener/app/my-load-balancer/50dc6c495c0c9188/f2f7dc8efc522ab2"
                }
            });

            List<Listener> listeners = response.Listeners;

            #endregion
        }

        public void ElasticLoadBalancingV2DescribeLoadBalancerAttributes()
        {
            #region elbv2-describe-load-balancer-attributes-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeLoadBalancerAttributes(new DescribeLoadBalancerAttributesRequest 
            {
                LoadBalancerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188"
            });

            List<LoadBalancerAttribute> attributes = response.Attributes;

            #endregion
        }

        public void ElasticLoadBalancingV2DescribeLoadBalancers()
        {
            #region elbv2-describe-load-balancers-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeLoadBalancers(new DescribeLoadBalancersRequest 
            {
                LoadBalancerArns = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188"
                }
            });

            List<LoadBalancer> loadBalancers = response.LoadBalancers;

            #endregion
        }

        public void ElasticLoadBalancingV2DescribeRules()
        {
            #region elbv2-describe-rules-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeRules(new DescribeRulesRequest 
            {
                RuleArns = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:listener-rule/app/my-load-balancer/50dc6c495c0c9188/f2f7dc8efc522ab2/9683b2d02a6cabee"
                }
            });

            List<Rule> rules = response.Rules;

            #endregion
        }

        public void ElasticLoadBalancingV2DescribeSSLPolicies()
        {
            #region elbv2-describe-ssl-policies-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeSSLPolicies(new DescribeSSLPoliciesRequest 
            {
                Names = new List<string> {
                    "ELBSecurityPolicy-2015-05"
                }
            });

            List<SslPolicy> sslPolicies = response.SslPolicies;

            #endregion
        }

        public void ElasticLoadBalancingV2DescribeTags()
        {
            #region elbv2-describe-tags-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeTags(new DescribeTagsRequest 
            {
                ResourceArns = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188"
                }
            });

            List<TagDescription> tagDescriptions = response.TagDescriptions;

            #endregion
        }

        public void ElasticLoadBalancingV2DescribeTargetGroupAttributes()
        {
            #region elbv2-describe-target-group-attributes-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeTargetGroupAttributes(new DescribeTargetGroupAttributesRequest 
            {
                TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
            });

            List<TargetGroupAttribute> attributes = response.Attributes;

            #endregion
        }

        public void ElasticLoadBalancingV2DescribeTargetGroups()
        {
            #region elbv2-describe-target-groups-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeTargetGroups(new DescribeTargetGroupsRequest 
            {
                TargetGroupArns = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
                }
            });

            List<TargetGroup> targetGroups = response.TargetGroups;

            #endregion
        }

        public void ElasticLoadBalancingV2DescribeTargetHealth()
        {
            #region elbv2-describe-target-health-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeTargetHealth(new DescribeTargetHealthRequest 
            {
                TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
            });

            List<TargetHealthDescription> targetHealthDescriptions = response.TargetHealthDescriptions;

            #endregion
        }

        public void ElasticLoadBalancingV2DescribeTargetHealth()
        {
            #region elbv2-describe-target-health-2

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.DescribeTargetHealth(new DescribeTargetHealthRequest 
            {
                TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067",
                Targets = new List<TargetDescription> {
                    new TargetDescription {
                        Id = "i-0f76fade",
                        Port = 80
                    }
                }
            });

            List<TargetHealthDescription> targetHealthDescriptions = response.TargetHealthDescriptions;

            #endregion
        }

        public void ElasticLoadBalancingV2GetResourcePolicy()
        {
            #region retrieve-a-resource-policy-1721684356628

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.GetResourcePolicy(new GetResourcePolicyRequest 
            {
                ResourceArn = "arn:aws:elasticloadbalancing:us-east-1:123456789012:truststore/my-trust-store/73e2d6bc24d8a067"
            });


            #endregion
        }

        public void ElasticLoadBalancingV2ModifyListener()
        {
            #region elbv2-modify-listener-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.ModifyListener(new ModifyListenerRequest 
            {
                DefaultActions = new List<Action> {
                    new Action {
                        TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-new-targets/2453ed029918f21f",
                        Type = "forward"
                    }
                },
                ListenerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:listener/app/my-load-balancer/50dc6c495c0c9188/f2f7dc8efc522ab2"
            });

            List<Listener> listeners = response.Listeners;

            #endregion
        }

        public void ElasticLoadBalancingV2ModifyListener()
        {
            #region elbv2-modify-listener-2

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.ModifyListener(new ModifyListenerRequest 
            {
                Certificates = new List<Certificate> {
                    new Certificate { CertificateArn = "arn:aws:iam::123456789012:server-certificate/my-new-server-cert" }
                },
                ListenerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:listener/app/my-load-balancer/50dc6c495c0c9188/0467ef3c8400ae65"
            });

            List<Listener> listeners = response.Listeners;

            #endregion
        }

        public void ElasticLoadBalancingV2ModifyLoadBalancerAttributes()
        {
            #region elbv2-modify-load-balancer-attributes-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.ModifyLoadBalancerAttributes(new ModifyLoadBalancerAttributesRequest 
            {
                Attributes = new List<LoadBalancerAttribute> {
                    new LoadBalancerAttribute {
                        Key = "deletion_protection.enabled",
                        Value = "true"
                    }
                },
                LoadBalancerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188"
            });

            List<LoadBalancerAttribute> attributes = response.Attributes;

            #endregion
        }

        public void ElasticLoadBalancingV2ModifyLoadBalancerAttributes()
        {
            #region elbv2-modify-load-balancer-attributes-2

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.ModifyLoadBalancerAttributes(new ModifyLoadBalancerAttributesRequest 
            {
                Attributes = new List<LoadBalancerAttribute> {
                    new LoadBalancerAttribute {
                        Key = "idle_timeout.timeout_seconds",
                        Value = "30"
                    }
                },
                LoadBalancerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188"
            });

            List<LoadBalancerAttribute> attributes = response.Attributes;

            #endregion
        }

        public void ElasticLoadBalancingV2ModifyLoadBalancerAttributes()
        {
            #region elbv2-modify-load-balancer-attributes-3

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.ModifyLoadBalancerAttributes(new ModifyLoadBalancerAttributesRequest 
            {
                Attributes = new List<LoadBalancerAttribute> {
                    new LoadBalancerAttribute {
                        Key = "access_logs.s3.enabled",
                        Value = "true"
                    },
                    new LoadBalancerAttribute {
                        Key = "access_logs.s3.bucket",
                        Value = "my-loadbalancer-logs"
                    },
                    new LoadBalancerAttribute {
                        Key = "access_logs.s3.prefix",
                        Value = "myapp"
                    }
                },
                LoadBalancerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188"
            });

            List<LoadBalancerAttribute> attributes = response.Attributes;

            #endregion
        }

        public void ElasticLoadBalancingV2ModifyRule()
        {
            #region elbv2-modify-rule-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.ModifyRule(new ModifyRuleRequest 
            {
                Conditions = new List<RuleCondition> {
                    new RuleCondition {
                        Field = "path-pattern",
                        Values = new List<string> {
                            "/images/*"
                        }
                    }
                },
                RuleArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:listener-rule/app/my-load-balancer/50dc6c495c0c9188/f2f7dc8efc522ab2/9683b2d02a6cabee"
            });

            List<Rule> rules = response.Rules;

            #endregion
        }

        public void ElasticLoadBalancingV2ModifyTargetGroup()
        {
            #region elbv2-modify-target-group-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.ModifyTargetGroup(new ModifyTargetGroupRequest 
            {
                HealthCheckPort = "443",
                HealthCheckProtocol = "HTTPS",
                TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-https-targets/2453ed029918f21f"
            });

            List<TargetGroup> targetGroups = response.TargetGroups;

            #endregion
        }

        public void ElasticLoadBalancingV2ModifyTargetGroupAttributes()
        {
            #region elbv2-modify-target-group-attributes-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.ModifyTargetGroupAttributes(new ModifyTargetGroupAttributesRequest 
            {
                Attributes = new List<TargetGroupAttribute> {
                    new TargetGroupAttribute {
                        Key = "deregistration_delay.timeout_seconds",
                        Value = "600"
                    }
                },
                TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067"
            });

            List<TargetGroupAttribute> attributes = response.Attributes;

            #endregion
        }

        public void ElasticLoadBalancingV2RegisterTargets()
        {
            #region elbv2-register-targets-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.RegisterTargets(new RegisterTargetsRequest 
            {
                TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-targets/73e2d6bc24d8a067",
                Targets = new List<TargetDescription> {
                    new TargetDescription { Id = "i-80c8dd94" },
                    new TargetDescription { Id = "i-ceddcd4d" }
                }
            });


            #endregion
        }

        public void ElasticLoadBalancingV2RegisterTargets()
        {
            #region elbv2-register-targets-2

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.RegisterTargets(new RegisterTargetsRequest 
            {
                TargetGroupArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:targetgroup/my-new-targets/3bb63f11dfb0faf9",
                Targets = new List<TargetDescription> {
                    new TargetDescription {
                        Id = "i-80c8dd94",
                        Port = 80
                    },
                    new TargetDescription {
                        Id = "i-80c8dd94",
                        Port = 766
                    }
                }
            });


            #endregion
        }

        public void ElasticLoadBalancingV2RemoveTags()
        {
            #region elbv2-remove-tags-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.RemoveTags(new RemoveTagsRequest 
            {
                ResourceArns = new List<string> {
                    "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188"
                },
                TagKeys = new List<string> {
                    "project",
                    "department"
                }
            });


            #endregion
        }

        public void ElasticLoadBalancingV2SetRulePriorities()
        {
            #region elbv2-set-rule-priorities-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.SetRulePriorities(new SetRulePrioritiesRequest 
            {
                RulePriorities = new List<RulePriorityPair> {
                    new RulePriorityPair {
                        Priority = 5,
                        RuleArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:listener-rule/app/my-load-balancer/50dc6c495c0c9188/f2f7dc8efc522ab2/1291d13826f405c3"
                    }
                }
            });

            List<Rule> rules = response.Rules;

            #endregion
        }

        public void ElasticLoadBalancingV2SetSecurityGroups()
        {
            #region elbv2-set-security-groups-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.SetSecurityGroups(new SetSecurityGroupsRequest 
            {
                LoadBalancerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188",
                SecurityGroups = new List<string> {
                    "sg-5943793c"
                }
            });

            List<string> securityGroupIds = response.SecurityGroupIds;

            #endregion
        }

        public void ElasticLoadBalancingV2SetSubnets()
        {
            #region elbv2-set-subnets-1

            var client = new AmazonElasticLoadBalancingV2Client();
            var response = client.SetSubnets(new SetSubnetsRequest 
            {
                LoadBalancerArn = "arn:aws:elasticloadbalancing:us-west-2:123456789012:loadbalancer/app/my-load-balancer/50dc6c495c0c9188",
                Subnets = new List<string> {
                    "subnet-8360a9e7",
                    "subnet-b7d581c0"
                }
            });

            List<AvailabilityZone> availabilityZones = response.AvailabilityZones;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}