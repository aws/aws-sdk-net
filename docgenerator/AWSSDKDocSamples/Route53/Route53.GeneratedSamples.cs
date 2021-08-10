using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.Route53;
using Amazon.Route53.Model;

namespace AWSSDKDocSamples.Amazon.Route53.Generated
{
    class Route53Samples : ISample
    {
        public void Route53AssociateVPCWithHostedZone()
        {
            #region to-associate-a-vpc-with-a-hosted-zone-1484069228699

            var client = new AmazonRoute53Client();
            var response = client.AssociateVPCWithHostedZone(new AssociateVPCWithHostedZoneRequest 
            {
                Comment = "",
                HostedZoneId = "Z3M3LMPEXAMPLE",
                VPC = new VPC {
                    VPCId = "vpc-1a2b3c4d",
                    VPCRegion = "us-east-2"
                }
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeResourceRecordSets()
        {
            #region to-create-update-or-delete-resource-record-sets-1484344703668

            var client = new AmazonRoute53Client();
            var response = client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest 
            {
                ChangeBatch = new ChangeBatch {
                    Changes = new List<Change> {
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                Name = "example.com",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.44" }
                                },
                                TTL = 60,
                                Type = "A"
                            }
                        }
                    },
                    Comment = "Web server for example.com"
                },
                HostedZoneId = "Z3M3LMPEXAMPLE"
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeResourceRecordSets()
        {
            #region to-create-weighted-resource-record-sets-1484348208522

            var client = new AmazonRoute53Client();
            var response = client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest 
            {
                ChangeBatch = new ChangeBatch {
                    Changes = new List<Change> {
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                HealthCheckId = "abcdef11-2222-3333-4444-555555fedcba",
                                Name = "example.com",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.44" }
                                },
                                SetIdentifier = "Seattle data center",
                                TTL = 60,
                                Type = "A",
                                Weight = 100
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                HealthCheckId = "abcdef66-7777-8888-9999-000000fedcba",
                                Name = "example.com",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.45" }
                                },
                                SetIdentifier = "Portland data center",
                                TTL = 60,
                                Type = "A",
                                Weight = 200
                            }
                        }
                    },
                    Comment = "Web servers for example.com"
                },
                HostedZoneId = "Z3M3LMPEXAMPLE"
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeResourceRecordSets()
        {
            #region to-create-an-alias-resource-record-set-1484348404062

            var client = new AmazonRoute53Client();
            var response = client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest 
            {
                ChangeBatch = new ChangeBatch {
                    Changes = new List<Change> {
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "d123rk29d0stfj.cloudfront.net",
                                    EvaluateTargetHealth = false,
                                    HostedZoneId = "Z2FDTNDATAQYW2"
                                },
                                Name = "example.com",
                                Type = "A"
                            }
                        }
                    },
                    Comment = "CloudFront distribution for example.com"
                },
                HostedZoneId = "Z3M3LMPEXAMPLE" // Depends on the type of resource that you want to route traffic to
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeResourceRecordSets()
        {
            #region to-create-weighted-alias-resource-record-sets-1484349467416

            var client = new AmazonRoute53Client();
            var response = client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest 
            {
                ChangeBatch = new ChangeBatch {
                    Changes = new List<Change> {
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "example-com-123456789.us-east-2.elb.amazonaws.com ",
                                    EvaluateTargetHealth = true,
                                    HostedZoneId = "Z3AADJGX6KTTL2"
                                },
                                Name = "example.com",
                                SetIdentifier = "Ohio region",
                                Type = "A",
                                Weight = 100
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "example-com-987654321.us-west-2.elb.amazonaws.com ",
                                    EvaluateTargetHealth = true,
                                    HostedZoneId = "Z1H1FL5HABSF5"
                                },
                                Name = "example.com",
                                SetIdentifier = "Oregon region",
                                Type = "A",
                                Weight = 200
                            }
                        }
                    },
                    Comment = "ELB load balancers for example.com"
                },
                HostedZoneId = "Z3M3LMPEXAMPLE" // Depends on the type of resource that you want to route traffic to
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeResourceRecordSets()
        {
            #region to-create-latency-resource-record-sets-1484350219917

            var client = new AmazonRoute53Client();
            var response = client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest 
            {
                ChangeBatch = new ChangeBatch {
                    Changes = new List<Change> {
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                HealthCheckId = "abcdef11-2222-3333-4444-555555fedcba",
                                Name = "example.com",
                                Region = "us-east-2",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.44" }
                                },
                                SetIdentifier = "Ohio region",
                                TTL = 60,
                                Type = "A"
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                HealthCheckId = "abcdef66-7777-8888-9999-000000fedcba",
                                Name = "example.com",
                                Region = "us-west-2",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.45" }
                                },
                                SetIdentifier = "Oregon region",
                                TTL = 60,
                                Type = "A"
                            }
                        }
                    },
                    Comment = "EC2 instances for example.com"
                },
                HostedZoneId = "Z3M3LMPEXAMPLE"
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeResourceRecordSets()
        {
            #region to-create-latency-alias-resource-record-sets-1484601774179

            var client = new AmazonRoute53Client();
            var response = client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest 
            {
                ChangeBatch = new ChangeBatch {
                    Changes = new List<Change> {
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "example-com-123456789.us-east-2.elb.amazonaws.com ",
                                    EvaluateTargetHealth = true,
                                    HostedZoneId = "Z3AADJGX6KTTL2"
                                },
                                Name = "example.com",
                                Region = "us-east-2",
                                SetIdentifier = "Ohio region",
                                Type = "A"
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "example-com-987654321.us-west-2.elb.amazonaws.com ",
                                    EvaluateTargetHealth = true,
                                    HostedZoneId = "Z1H1FL5HABSF5"
                                },
                                Name = "example.com",
                                Region = "us-west-2",
                                SetIdentifier = "Oregon region",
                                Type = "A"
                            }
                        }
                    },
                    Comment = "ELB load balancers for example.com"
                },
                HostedZoneId = "Z3M3LMPEXAMPLE" // Depends on the type of resource that you want to route traffic to
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeResourceRecordSets()
        {
            #region to-create-failover-resource-record-sets-1484604541740

            var client = new AmazonRoute53Client();
            var response = client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest 
            {
                ChangeBatch = new ChangeBatch {
                    Changes = new List<Change> {
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                Failover = "PRIMARY",
                                HealthCheckId = "abcdef11-2222-3333-4444-555555fedcba",
                                Name = "example.com",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.44" }
                                },
                                SetIdentifier = "Ohio region",
                                TTL = 60,
                                Type = "A"
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                Failover = "SECONDARY",
                                HealthCheckId = "abcdef66-7777-8888-9999-000000fedcba",
                                Name = "example.com",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.45" }
                                },
                                SetIdentifier = "Oregon region",
                                TTL = 60,
                                Type = "A"
                            }
                        }
                    },
                    Comment = "Failover configuration for example.com"
                },
                HostedZoneId = "Z3M3LMPEXAMPLE"
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeResourceRecordSets()
        {
            #region to-create-failover-alias-resource-record-sets-1484607497724

            var client = new AmazonRoute53Client();
            var response = client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest 
            {
                ChangeBatch = new ChangeBatch {
                    Changes = new List<Change> {
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "example-com-123456789.us-east-2.elb.amazonaws.com ",
                                    EvaluateTargetHealth = true,
                                    HostedZoneId = "Z3AADJGX6KTTL2"
                                },
                                Failover = "PRIMARY",
                                Name = "example.com",
                                SetIdentifier = "Ohio region",
                                Type = "A"
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "example-com-987654321.us-west-2.elb.amazonaws.com ",
                                    EvaluateTargetHealth = true,
                                    HostedZoneId = "Z1H1FL5HABSF5"
                                },
                                Failover = "SECONDARY",
                                Name = "example.com",
                                SetIdentifier = "Oregon region",
                                Type = "A"
                            }
                        }
                    },
                    Comment = "Failover alias configuration for example.com"
                },
                HostedZoneId = "Z3M3LMPEXAMPLE" // Depends on the type of resource that you want to route traffic to
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeResourceRecordSets()
        {
            #region to-create-geolocation-resource-record-sets-1484612462466

            var client = new AmazonRoute53Client();
            var response = client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest 
            {
                ChangeBatch = new ChangeBatch {
                    Changes = new List<Change> {
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                GeoLocation = new GeoLocation { ContinentCode = "NA" },
                                Name = "example.com",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.44" }
                                },
                                SetIdentifier = "North America",
                                TTL = 60,
                                Type = "A"
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                GeoLocation = new GeoLocation { ContinentCode = "SA" },
                                Name = "example.com",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.45" }
                                },
                                SetIdentifier = "South America",
                                TTL = 60,
                                Type = "A"
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                GeoLocation = new GeoLocation { ContinentCode = "EU" },
                                Name = "example.com",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.46" }
                                },
                                SetIdentifier = "Europe",
                                TTL = 60,
                                Type = "A"
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                GeoLocation = new GeoLocation { CountryCode = "*" },
                                Name = "example.com",
                                ResourceRecords = new List<ResourceRecord> {
                                    new ResourceRecord { Value = "192.0.2.47" }
                                },
                                SetIdentifier = "Other locations",
                                TTL = 60,
                                Type = "A"
                            }
                        }
                    },
                    Comment = "Geolocation configuration for example.com"
                },
                HostedZoneId = "Z3M3LMPEXAMPLE"
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeResourceRecordSets()
        {
            #region to-create-geolocation-alias-resource-record-sets-1484612871203

            var client = new AmazonRoute53Client();
            var response = client.ChangeResourceRecordSets(new ChangeResourceRecordSetsRequest 
            {
                ChangeBatch = new ChangeBatch {
                    Changes = new List<Change> {
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "example-com-123456789.us-east-2.elb.amazonaws.com ",
                                    EvaluateTargetHealth = true,
                                    HostedZoneId = "Z3AADJGX6KTTL2"
                                },
                                GeoLocation = new GeoLocation { ContinentCode = "NA" },
                                Name = "example.com",
                                SetIdentifier = "North America",
                                Type = "A"
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "example-com-234567890.sa-east-1.elb.amazonaws.com ",
                                    EvaluateTargetHealth = true,
                                    HostedZoneId = "Z2P70J7HTTTPLU"
                                },
                                GeoLocation = new GeoLocation { ContinentCode = "SA" },
                                Name = "example.com",
                                SetIdentifier = "South America",
                                Type = "A"
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "example-com-234567890.eu-central-1.elb.amazonaws.com ",
                                    EvaluateTargetHealth = true,
                                    HostedZoneId = "Z215JYRZR1TBD5"
                                },
                                GeoLocation = new GeoLocation { ContinentCode = "EU" },
                                Name = "example.com",
                                SetIdentifier = "Europe",
                                Type = "A"
                            }
                        },
                        new Change {
                            Action = "CREATE",
                            ResourceRecordSet = new ResourceRecordSet {
                                AliasTarget = new AliasTarget {
                                    DNSName = "example-com-234567890.ap-southeast-1.elb.amazonaws.com ",
                                    EvaluateTargetHealth = true,
                                    HostedZoneId = "Z1LMS91P8CMLE5"
                                },
                                GeoLocation = new GeoLocation { CountryCode = "*" },
                                Name = "example.com",
                                SetIdentifier = "Other locations",
                                Type = "A"
                            }
                        }
                    },
                    Comment = "Geolocation alias configuration for example.com"
                },
                HostedZoneId = "Z3M3LMPEXAMPLE" // Depends on the type of resource that you want to route traffic to
            });

            ChangeInfo changeInfo = response.ChangeInfo;

            #endregion
        }

        public void Route53ChangeTagsForResource()
        {
            #region to-add-or-remove-tags-from-a-hosted-zone-or-health-check-1484084752409

            var client = new AmazonRoute53Client();
            var response = client.ChangeTagsForResource(new ChangeTagsForResourceRequest 
            {
                AddTags = new List<Tag> {
                    new Tag {
                        Key = "apex",
                        Value = "3874"
                    },
                    new Tag {
                        Key = "acme",
                        Value = "4938"
                    }
                },
                RemoveTagKeys = new List<string> {
                    "Nadir"
                },
                ResourceId = "Z3M3LMPEXAMPLE",
                ResourceType = "hostedzone" // Valid values are healthcheck and hostedzone.
            });


            #endregion
        }

        public void Route53GetHostedZone()
        {
            #region to-get-information-about-a-hosted-zone-1481752361124

            var client = new AmazonRoute53Client();
            var response = client.GetHostedZone(new GetHostedZoneRequest 
            {
                Id = "Z3M3LMPEXAMPLE"
            });

            DelegationSet delegationSet = response.DelegationSet;
            HostedZone hostedZone = response.HostedZone;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}