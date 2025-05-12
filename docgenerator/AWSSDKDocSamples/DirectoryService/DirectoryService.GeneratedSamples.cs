using System;
using System.Collections.Generic;
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
            #region to-add-a-cidr-address-block-that-routes-traffic-for-microsoft-ad-1481580074651

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
            #region to-add-tags-to-a-directory-1481582596354

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
            #region to-cancel-a-microsoft-ad-schema-extension-that-is-in-progress-1481583276240

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
            #region to-connect-to-an-on-premises-directory-1481586749640

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
            #region to-create-an-alias-for-a-directory-1481147295279

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
            #region to-create-a-computer-account-1481676943652

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
            #region to-create-a-conditional-forwarder-1481667053089

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
            #region to-create-a-simple-ad-directory-1481669101098

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
            #region to-create-a-microsoft-ad-directory-1481670169383

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
            #region to-create-a-snapshot-of-a-directory-1481671628145

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
            #region to-create-a-trust-1481673599473

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
            #region to-delete-a-conditional-forwarder-1481673924488

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
            #region to-delete-a-directory-1481674940318

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
            #region to-delete-a-snapshot-1481678726239

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
            #region to-delete-a-trust-1481678937261

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
            #region to-remove-an-event-topic-1481679683016

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
            #region to-describe-conditional-forwarders-1481681337122

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
            #region to-describe-one-or-more-directories-1481681592059

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
            #region to-describe-event-topics-1481683733380

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
            #region to-describe-snapshots-1481742829912

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
            #region to-describe-a-trust--1481749974009

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
            #region to-disable-radius-1481752373128

            var client = new AmazonDirectoryServiceClient();
            var response = client.DisableRadius(new DisableRadiusRequest 
            {
                DirectoryId = "d-92654abfed"
            });


            #endregion
        }

        public void DirectoryServiceDisableSso()
        {
            #region to-disable-sso-1481753731802

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
            #region to-enable-radius-1481751944293

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
            #region to-enable-sso-1481753527694

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
            #region to-get-directory-limits-1481754781592

            var client = new AmazonDirectoryServiceClient();
            var response = client.GetDirectoryLimits(new GetDirectoryLimitsRequest 
            {
            });

            DirectoryLimits directoryLimits = response.DirectoryLimits;

            #endregion
        }

        public void DirectoryServiceGetSnapshotLimits()
        {
            #region to-get-snapshot-limits-1481755393694

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
            #region to-list-ip-routes-1481755837685

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
            #region to-list-schema-extensions-1481756433064

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
            #region to-list-tags-for-a-directory-1481757084225

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
            #region to-register-an-event-topic-1481757657323

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
            #region to-remove-ip-routes-1481758003547

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
            #region to-remove-tags-from-a-directory-1481759009957

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
            #region to-restore-a-snapshot-1481759429095

            var client = new AmazonDirectoryServiceClient();
            var response = client.RestoreFromSnapshot(new RestoreFromSnapshotRequest 
            {
                SnapshotId = "s-9267f6da4e"
            });


            #endregion
        }

        public void DirectoryServiceStartSchemaExtension()
        {
            #region to-start-a-schema-extension-1481830079414

            var client = new AmazonDirectoryServiceClient();
            var response = client.StartSchemaExtension(new StartSchemaExtensionRequest 
            {
                CreateSnapshotBeforeSchemaExtension = true,
                Description = "Adds maycontain attribute to user class. Precede each line as it would be formatted in an ldif file.",
                DirectoryId = "d-92654abfed",
                LdifContent = "dn: CN=User,CN=Schema,CN=Configuration,DC=sales,DC=example,DC=com
changetype: modify
add: mayContain
mayContain: drink
-

DN:
changetype: modify
replace: schemaupdatenow
schemaupdatenow: 1
-"
            });

            string schemaExtensionId = response.SchemaExtensionId;

            #endregion
        }

        public void DirectoryServiceUpdateConditionalForwarder()
        {
            #region to-update-a-conditional-forwarder-1481826693698

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
            #region to-update-radius-1481827441016

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
            #region to-verify-a-trust-1481828755113

            var client = new AmazonDirectoryServiceClient();
            var response = client.VerifyTrust(new VerifyTrustRequest 
            {
                TrustId = "t-9267353df0"
            });

            string trustId = response.TrustId;

            #endregion
        }

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}