using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.DirectoryService;
using Amazon.DirectoryService.Model;

namespace AWSSDKDocSamples.Amazon.DirectoryService.Generated
{
    class DirectoryServiceSamples : ISample
    {
        public void DirectoryServiceAddIpRoutes()
        {
            #region AddIpRoutes-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.AddIpRoutes(new AddIpRoutesRequest
            {
                DirectoryId = "d-92654abfed",
                IpRoutes = new List<IpRoute> {
                    new IpRoute {
                        CidrIp = "12.12.12.12/32",
                        Description = "my IpRoute"
                    }
                }
            });


            #endregion
        }

        public void DirectoryServiceAddTagsToResource()
        {
            #region AddTagsToResource-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.AddTagsToResource(new AddTagsToResourceRequest
            {
                ResourceId = "d-92654abfed",
                Tags = new List<Tag> {
                    new Tag {
                        Key = "environment",
                        Value = "production"
                    }
                }
            });


            #endregion
        }

        public void DirectoryServiceCancelSchemaExtension()
        {
            #region CancelSchemaExtension-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.CancelSchemaExtension(new CancelSchemaExtensionRequest
            {
                DirectoryId = "d-92654abfed",
                SchemaExtensionId = "e-926731d2a0"
            });


            #endregion
        }

        public void DirectoryServiceConnectDirectory()
        {
            #region ConnectDirectory-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.ConnectDirectory(new ConnectDirectoryRequest
            {
                ConnectSettings = new DirectoryConnectSettings {
                    CustomerDnsIps = new List<string> {
                        "172.30.21.228"
                    },
                    CustomerUserName = "Administrator",
                    SubnetIds = new List<string> {
                        "subnet-ba0146de",
                        "subnet-bef46bc8"
                    },
                    VpcId = "vpc-45025421"
                },
                Description = "Connector to corp",
                Name = "corp.example.com",
                Password = "Str0ngP@ssw0rd",
                ShortName = "corp",
                Size = "Small"
            });

            string directoryId = response.DirectoryId;

            #endregion
        }

        public void DirectoryServiceCreateAlias()
        {
            #region CreateAlias-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.CreateAlias(new CreateAliasRequest
            {
                Alias = "salesorg",
                DirectoryId = "d-92654abfed"
            });

            string alias = response.Alias;
            string directoryId = response.DirectoryId;

            #endregion
        }

        public void DirectoryServiceCreateComputer()
        {
            #region CreateComputer-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.CreateComputer(new CreateComputerRequest
            {
                ComputerAttributes = new List<Attribute> {
                    new Attribute {
                        Name = "ip",
                        Value = "192.168.101.100"
                    }
                },
                ComputerName = "labcomputer",
                DirectoryId = "d-92654abfed",
                OrganizationalUnitDistinguishedName = "OU=Computers,OU=example,DC=corp,DC=example,DC=com",
                Password = "Str0ngP@ssw0rd"
            });

            Computer computer = response.Computer;

            #endregion
        }

        public void DirectoryServiceCreateConditionalForwarder()
        {
            #region CreateConditionalForwarder-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.CreateConditionalForwarder(new CreateConditionalForwarderRequest
            {
                DirectoryId = "d-92654abfed",
                DnsIpAddrs = new List<string> {
                    "172.30.21.228"
                },
                RemoteDomainName = "sales.example.com"
            });


            #endregion
        }

        public void DirectoryServiceCreateDirectory()
        {
            #region CreateDirectory-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.CreateDirectory(new CreateDirectoryRequest
            {
                Description = "Regional directory for example.com",
                Name = "seattle.example.com",
                Password = "Str0ngP@ssw0rd",
                ShortName = "seattle",
                Size = "Small",
                VpcSettings = new DirectoryVpcSettings {
                    SubnetIds = new List<string> {
                        "subnet-ba0146de",
                        "subnet-bef46bc8"
                    },
                    VpcId = "vpc-45025421"
                }
            });

            string directoryId = response.DirectoryId;

            #endregion
        }

        public void DirectoryServiceCreateMicrosoftAD()
        {
            #region CreateMicrosoftAD-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.CreateMicrosoftAD(new CreateMicrosoftADRequest
            {
                Description = "Corporate AD directory",
                Name = "ad.example.com",
                Password = "Str0ngP@ssw0rd",
                ShortName = "ad",
                VpcSettings = new DirectoryVpcSettings {
                    SubnetIds = new List<string> {
                        "subnet-ba0146de",
                        "subnet-bef46bc8"
                    },
                    VpcId = "vpc-45025421"
                }
            });

            string directoryId = response.DirectoryId;

            #endregion
        }

        public void DirectoryServiceCreateSnapshot()
        {
            #region CreateSnapshot-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.CreateSnapshot(new CreateSnapshotRequest
            {
                DirectoryId = "d-92654abfed",
                Name = "ad.example.com"
            });

            string snapshotId = response.SnapshotId;

            #endregion
        }

        public void DirectoryServiceCreateTrust()
        {
            #region CreateTrust-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.CreateTrust(new CreateTrustRequest
            {
                ConditionalForwarderIpAddrs = new List<string> {
                    "172.30.21.228"
                },
                DirectoryId = "d-92654abfed",
                RemoteDomainName = "europe.example.com",
                TrustDirection = "One-Way: Outgoing",
                TrustPassword = "Str0ngP@ssw0rd",
                TrustType = "Forest"
            });

            string trustId = response.TrustId;

            #endregion
        }

        public void DirectoryServiceDeleteConditionalForwarder()
        {
            #region DeleteConditionalForwarder-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DeleteConditionalForwarder(new DeleteConditionalForwarderRequest
            {
                DirectoryId = "d-92654abfed",
                RemoteDomainName = "sales.example.com"
            });


            #endregion
        }

        public void DirectoryServiceDeleteDirectory()
        {
            #region DeleteDirectory-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DeleteDirectory(new DeleteDirectoryRequest
            {
                DirectoryId = "d-92654abfed"
            });

            string directoryId = response.DirectoryId;

            #endregion
        }

        public void DirectoryServiceDeleteSnapshot()
        {
            #region DeleteSnapshot-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DeleteSnapshot(new DeleteSnapshotRequest
            {
                SnapshotId = "s-9267f8d3f0"
            });

            string snapshotId = response.SnapshotId;

            #endregion
        }

        public void DirectoryServiceDeleteTrust()
        {
            #region DeleteTrust-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DeleteTrust(new DeleteTrustRequest
            {
                DeleteAssociatedConditionalForwarder = true,
                TrustId = "t-9267353743"
            });

            string trustId = response.TrustId;

            #endregion
        }

        public void DirectoryServiceDeregisterEventTopic()
        {
            #region DeregisterEventTopic-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DeregisterEventTopic(new DeregisterEventTopicRequest
            {
                DirectoryId = "d-92654abfed",
                TopicName = "snstopicexample"
            });


            #endregion
        }

        public void DirectoryServiceDescribeConditionalForwarders()
        {
            #region DescribeConditionalForwarders-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DescribeConditionalForwarders(new DescribeConditionalForwardersRequest
            {
                DirectoryId = "d-92654abfed",
                RemoteDomainNames = new List<string> {
                    "sales.example.com"
                }
            });

            List<ConditionalForwarder> conditionalForwarders = response.ConditionalForwarders;

            #endregion
        }

        public void DirectoryServiceDescribeDirectories()
        {
            #region DescribeDirectories-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DescribeDirectories(new DescribeDirectoriesRequest
            {
                DirectoryIds = new List<string> {
                    "d-92654abfed"
                },
                Limit = 0
            });

            List<DirectoryDescription> directoryDescriptions = response.DirectoryDescriptions;

            #endregion
        }

        public void DirectoryServiceDescribeEventTopics()
        {
            #region DescribeEventTopics-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DescribeEventTopics(new DescribeEventTopicsRequest
            {
                DirectoryId = "d-92654abfed",
                TopicNames = new List<string> {
                    "snstopicexample"
                }
            });

            List<EventTopic> eventTopics = response.EventTopics;

            #endregion
        }

        public void DirectoryServiceDescribeSnapshots()
        {
            #region DescribeSnapshots-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DescribeSnapshots(new DescribeSnapshotsRequest
            {
                DirectoryId = "d-92654abfed",
                Limit = 0,
                SnapshotIds = new List<string> {
                    "s-9267f6da4e"
                }
            });

            List<Snapshot> snapshots = response.Snapshots;

            #endregion
        }

        public void DirectoryServiceDescribeTrusts()
        {
            #region DescribeTrusts-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DescribeTrusts(new DescribeTrustsRequest
            {
                DirectoryId = "d-92654abfed",
                Limit = 0,
                TrustIds = new List<string> {
                    "t-9267353df0"
                }
            });

            List<Trust> trusts = response.Trusts;

            #endregion
        }

        public void DirectoryServiceDisableRadius()
        {
            #region DisableRadius-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DisableRadius(new DisableRadiusRequest
            {
                DirectoryId = "d-92654abfed"
            });


            #endregion
        }

        public void DirectoryServiceDisableSso()
        {
            #region DisableSso-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.DisableSso(new DisableSsoRequest
            {
                DirectoryId = "d-92654abfed",
                Password = "Str0ngP@ssw0rd",
                UserName = "Admin"
            });


            #endregion
        }

        public void DirectoryServiceEnableRadius()
        {
            #region EnableRadius-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.EnableRadius(new EnableRadiusRequest
            {
                DirectoryId = "d-92654abfed",
                RadiusSettings = new RadiusSettings {
                    AuthenticationProtocol = "PAP",
                    DisplayLabel = "MyRadius",
                    RadiusPort = 1200,
                    RadiusRetries = 2,
                    RadiusServers = new List<string> {
                        "172.168.111.12"
                    },
                    RadiusTimeout = 1,
                    SharedSecret = "123456789",
                    UseSameUsername = true
                }
            });


            #endregion
        }

        public void DirectoryServiceEnableSso()
        {
            #region EnableSso-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.EnableSso(new EnableSsoRequest
            {
                DirectoryId = "d-92654abfed",
                Password = "Str0ngP@ssw0rd",
                UserName = "Admin"
            });


            #endregion
        }

        public void DirectoryServiceGetDirectoryLimits()
        {
            #region GetDirectoryLimits-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.GetDirectoryLimits(new GetDirectoryLimitsRequest
            {
            });

            DirectoryLimits directoryLimits = response.DirectoryLimits;

            #endregion
        }

        public void DirectoryServiceGetSnapshotLimits()
        {
            #region GetSnapshotLimits-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.GetSnapshotLimits(new GetSnapshotLimitsRequest
            {
                DirectoryId = "d-92654abfed"
            });

            SnapshotLimits snapshotLimits = response.SnapshotLimits;

            #endregion
        }

        public void DirectoryServiceListIpRoutes()
        {
            #region ListIpRoutes-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.ListIpRoutes(new ListIpRoutesRequest
            {
                DirectoryId = "d-92654abfed",
                Limit = 0
            });

            List<IpRouteInfo> ipRoutesInfo = response.IpRoutesInfo;

            #endregion
        }

        public void DirectoryServiceListSchemaExtensions()
        {
            #region ListSchemaExtensions-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.ListSchemaExtensions(new ListSchemaExtensionsRequest
            {
                DirectoryId = "d-92654abfed",
                Limit = 0
            });

            List<SchemaExtensionInfo> schemaExtensionsInfo = response.SchemaExtensionsInfo;

            #endregion
        }

        public void DirectoryServiceListTagsForResource()
        {
            #region ListTagsForResource-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.ListTagsForResource(new ListTagsForResourceRequest
            {
                Limit = 0,
                ResourceId = "d-92654abfed"
            });

            List<Tag> tags = response.Tags;

            #endregion
        }

        public void DirectoryServiceRegisterEventTopic()
        {
            #region RegisterEventTopic-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.RegisterEventTopic(new RegisterEventTopicRequest
            {
                DirectoryId = "d-92654abfed",
                TopicName = "snstopicexample"
            });


            #endregion
        }

        public void DirectoryServiceRemoveIpRoutes()
        {
            #region RemoveIpRoutes-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.RemoveIpRoutes(new RemoveIpRoutesRequest
            {
                CidrIps = new List<string> {
                    "12.12.12.12/32"
                },
                DirectoryId = "d-92654abfed"
            });


            #endregion
        }

        public void DirectoryServiceRemoveTagsFromResource()
        {
            #region RemoveTagsFromResource-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.RemoveTagsFromResource(new RemoveTagsFromResourceRequest
            {
                ResourceId = "d-92654abfed",
                TagKeys = new List<string> {
                    "environment"
                }
            });


            #endregion
        }

        public void DirectoryServiceRestoreFromSnapshot()
        {
            #region RestoreFromSnapshot-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.RestoreFromSnapshot(new RestoreFromSnapshotRequest
            {
                SnapshotId = "s-9267f6da4e"
            });


            #endregion
        }

        public void DirectoryServiceStartSchemaExtension()
        {
            #region StartSchemaExtension-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.StartSchemaExtension(new StartSchemaExtensionRequest
            {
                CreateSnapshotBeforeSchemaExtension = true,
                Description = "Adds maycontain attribute to user class. Precede each line as it would be formatted in an ldif file.",
                DirectoryId = "d-92654abfed",
                LdifContent = "dn: CN=User,CN=Schema,CN=Configuration,DC=sales,DC=example,DC=com\nchangetype: modify\nadd: mayContain\nmayContain: drink\n-\n\nDN:\nchangetype: modify\nreplace: schemaupdatenow\nschemaupdatenow: 1\n-"
            });

            string schemaExtensionId = response.SchemaExtensionId;

            #endregion
        }

        public void DirectoryServiceUpdateConditionalForwarder()
        {
            #region UpdateConditionalForwarder-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.UpdateConditionalForwarder(new UpdateConditionalForwarderRequest
            {
                DirectoryId = "d-92654abfed",
                DnsIpAddrs = new List<string> {
                    "172.168.101.11"
                },
                RemoteDomainName = "sales.example.com"
            });


            #endregion
        }

        public void DirectoryServiceUpdateRadius()
        {
            #region UpdateRadius-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.UpdateRadius(new UpdateRadiusRequest
            {
                DirectoryId = "d-92654abfed",
                RadiusSettings = new RadiusSettings {
                    AuthenticationProtocol = "PAP",
                    DisplayLabel = "MyRadius",
                    RadiusPort = 1027,
                    RadiusRetries = 1,
                    RadiusServers = new List<string> {
                        "172.168.101.113"
                    },
                    RadiusTimeout = 1,
                    SharedSecret = "12345678",
                    UseSameUsername = true
                }
            });


            #endregion
        }

        public void DirectoryServiceVerifyTrust()
        {
            #region VerifyTrust-1

            var client = new AmazonDirectoryServiceClient();
            var response = client.VerifyTrust(new VerifyTrustRequest
            {
                TrustId = "t-9267353df0"
            });

            string trustId = response.TrustId;

            #endregion
        }

        #region ISample Members
        public virtual void Run()
        {
        }
        #endregion
    }
}
