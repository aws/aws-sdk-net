using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Amazon.EC2;
using Amazon.EC2.Model;

namespace AWSSDKDocSamples.Amazon.EC2.Generated
{
    class EC2Samples : ISample
    {
        public void EC2AllocateAddress()
        {
            #region AllocateAddress-1

            var client = new AmazonEC2Client();
            var response = client.AllocateAddress(new AllocateAddressRequest
            {
            });

            string allocationId = response.AllocationId;
            DomainType domain = response.Domain;
            string networkBorderGroup = response.NetworkBorderGroup;
            string publicIp = response.PublicIp;
            string publicIpv4Pool = response.PublicIpv4Pool;

            #endregion
        }

        public void EC2AssignPrivateIpAddresses()
        {
            #region AssignPrivateIpAddresses-1

            var client = new AmazonEC2Client();
            var response = client.AssignPrivateIpAddresses(new AssignPrivateIpAddressesRequest
            {
                NetworkInterfaceId = "eni-e5aa89a3",
                PrivateIpAddresses = new List<string> {
                    "10.0.0.82"
                }
            });


            #endregion
        }

        public void EC2AssignPrivateIpAddresses()
        {
            #region AssignPrivateIpAddresses-2

            var client = new AmazonEC2Client();
            var response = client.AssignPrivateIpAddresses(new AssignPrivateIpAddressesRequest
            {
                NetworkInterfaceId = "eni-e5aa89a3",
                SecondaryPrivateIpAddressCount = 2
            });


            #endregion
        }

        public void EC2AssociateAddress()
        {
            #region AssociateAddress-1

            var client = new AmazonEC2Client();
            var response = client.AssociateAddress(new AssociateAddressRequest
            {
                AllocationId = "eipalloc-64d5890a",
                InstanceId = "i-0b263919b6498b123"
            });

            string associationId = response.AssociationId;

            #endregion
        }

        public void EC2AssociateAddress()
        {
            #region AssociateAddress-2

            var client = new AmazonEC2Client();
            var response = client.AssociateAddress(new AssociateAddressRequest
            {
                AllocationId = "eipalloc-64d5890a",
                NetworkInterfaceId = "eni-1a2b3c4d"
            });

            string associationId = response.AssociationId;

            #endregion
        }

        public void EC2AssociateApplicationStatusCheck()
        {
            #region AssociateApplicationStatusCheck-1

            var client = new AmazonEC2Client();
            var response = client.AssociateApplicationStatusCheck(new AssociateApplicationStatusCheckRequest
            {
                ApplicationStatusCheckId = "asc-0123456789abcdef0",
                TargetTagAssociations = new List<CustomTagKeyValueRequestPair> {
                    new CustomTagKeyValueRequestPair {
                        Key = "env",
                        Value = "prod"
                    }
                }
            });

            List<SuccessfulAssociationResponseObject> successfulResults = response.SuccessfulResults;
            List<UnsuccessfulAssociationResponseObject> unsuccessfulResults = response.UnsuccessfulResults;

            #endregion
        }

        public void EC2AssociateDhcpOptions()
        {
            #region AssociateDhcpOptions-1

            var client = new AmazonEC2Client();
            var response = client.AssociateDhcpOptions(new AssociateDhcpOptionsRequest
            {
                DhcpOptionsId = "dopt-d9070ebb",
                VpcId = "vpc-a01106c2"
            });


            #endregion
        }

        public void EC2AssociateDhcpOptions()
        {
            #region AssociateDhcpOptions-2

            var client = new AmazonEC2Client();
            var response = client.AssociateDhcpOptions(new AssociateDhcpOptionsRequest
            {
                DhcpOptionsId = "default",
                VpcId = "vpc-a01106c2"
            });


            #endregion
        }

        public void EC2AssociateIamInstanceProfile()
        {
            #region AssociateIamInstanceProfile-1

            var client = new AmazonEC2Client();
            var response = client.AssociateIamInstanceProfile(new AssociateIamInstanceProfileRequest
            {
                IamInstanceProfile = new IamInstanceProfileSpecification { Name = "admin-role" },
                InstanceId = "i-123456789abcde123"
            });

            IamInstanceProfileAssociation iamInstanceProfileAssociation = response.IamInstanceProfileAssociation;

            #endregion
        }

        public void EC2AssociateRouteTable()
        {
            #region AssociateRouteTable-1

            var client = new AmazonEC2Client();
            var response = client.AssociateRouteTable(new AssociateRouteTableRequest
            {
                RouteTableId = "rtb-22574640",
                SubnetId = "subnet-9d4a7b6"
            });

            string associationId = response.AssociationId;

            #endregion
        }

        public void EC2AttachInternetGateway()
        {
            #region AttachInternetGateway-1

            var client = new AmazonEC2Client();
            var response = client.AttachInternetGateway(new AttachInternetGatewayRequest
            {
                InternetGatewayId = "igw-c0a643a9",
                VpcId = "vpc-a01106c2"
            });


            #endregion
        }

        public void EC2AttachNetworkInterface()
        {
            #region AttachNetworkInterface-1

            var client = new AmazonEC2Client();
            var response = client.AttachNetworkInterface(new AttachNetworkInterfaceRequest
            {
                DeviceIndex = 1,
                InstanceId = "i-1234567890abcdef0",
                NetworkInterfaceId = "eni-e5aa89a3"
            });

            string attachmentId = response.AttachmentId;

            #endregion
        }

        public void EC2AttachVolume()
        {
            #region AttachVolume-1

            var client = new AmazonEC2Client();
            var response = client.AttachVolume(new AttachVolumeRequest
            {
                Device = "/dev/sdf",
                InstanceId = "i-01474ef662b89480",
                VolumeId = "vol-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2AuthorizeSecurityGroupEgress()
        {
            #region AuthorizeSecurityGroupEgress-1

            var client = new AmazonEC2Client();
            var response = client.AuthorizeSecurityGroupEgress(new AuthorizeSecurityGroupEgressRequest
            {
                GroupId = "sg-1a2b3c4d",
                IpPermissions = new List<IpPermission> {
                    new IpPermission {
                        FromPort = 80,
                        IpProtocol = "tcp",
                        ToPort = 80
                    }
                }
            });


            #endregion
        }

        public void EC2AuthorizeSecurityGroupEgress()
        {
            #region AuthorizeSecurityGroupEgress-2

            var client = new AmazonEC2Client();
            var response = client.AuthorizeSecurityGroupEgress(new AuthorizeSecurityGroupEgressRequest
            {
                GroupId = "sg-1a2b3c4d",
                IpPermissions = new List<IpPermission> {
                    new IpPermission {
                        FromPort = 80,
                        IpProtocol = "tcp",
                        ToPort = 80,
                        UserIdGroupPairs = new List<UserIdGroupPair> {
                            new UserIdGroupPair { GroupId = "sg-4b51a32f" }
                        }
                    }
                }
            });


            #endregion
        }

        public void EC2AuthorizeSecurityGroupIngress()
        {
            #region AuthorizeSecurityGroupIngress-1

            var client = new AmazonEC2Client();
            var response = client.AuthorizeSecurityGroupIngress(new AuthorizeSecurityGroupIngressRequest
            {
                GroupId = "sg-111aaa22",
                IpPermissions = new List<IpPermission> {
                    new IpPermission {
                        FromPort = 80,
                        IpProtocol = "tcp",
                        ToPort = 80,
                        UserIdGroupPairs = new List<UserIdGroupPair> {
                            new UserIdGroupPair {
                                Description = "HTTP access from other instances",
                                GroupId = "sg-1a2b3c4d"
                            }
                        }
                    }
                }
            });


            #endregion
        }

        public void EC2AuthorizeSecurityGroupIngress()
        {
            #region AuthorizeSecurityGroupIngress-2

            var client = new AmazonEC2Client();
            var response = client.AuthorizeSecurityGroupIngress(new AuthorizeSecurityGroupIngressRequest
            {
                GroupId = "sg-903004f8",
                IpPermissions = new List<IpPermission> {
                    new IpPermission {
                        FromPort = 22,
                        IpProtocol = "tcp",
                        ToPort = 22
                    }
                }
            });


            #endregion
        }

        public void EC2AuthorizeSecurityGroupIngress()
        {
            #region AuthorizeSecurityGroupIngress-3

            var client = new AmazonEC2Client();
            var response = client.AuthorizeSecurityGroupIngress(new AuthorizeSecurityGroupIngressRequest
            {
                GroupId = "sg-123abc12 ",
                IpPermissions = new List<IpPermission> {
                    new IpPermission {
                        FromPort = 3389,
                        IpProtocol = "tcp",
                        Ipv6Ranges = new List<Ipv6Range> {
                            new Ipv6Range {
                                CidrIpv6 = "2001:db8:1234:1a00::/64",
                                Description = "RDP access from the NY office"
                            }
                        },
                        ToPort = 3389
                    }
                }
            });


            #endregion
        }

        public void EC2CancelSpotFleetRequests()
        {
            #region CancelSpotFleetRequests-1

            var client = new AmazonEC2Client();
            var response = client.CancelSpotFleetRequests(new CancelSpotFleetRequestsRequest
            {
                SpotFleetRequestIds = new List<string> {
                    "sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE"
                },
                TerminateInstances = true
            });

            List<CancelSpotFleetRequestsSuccessItem> successfulFleetRequests = response.SuccessfulFleetRequests;

            #endregion
        }

        public void EC2CancelSpotFleetRequests()
        {
            #region CancelSpotFleetRequests-2

            var client = new AmazonEC2Client();
            var response = client.CancelSpotFleetRequests(new CancelSpotFleetRequestsRequest
            {
                SpotFleetRequestIds = new List<string> {
                    "sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE"
                },
                TerminateInstances = false
            });

            List<CancelSpotFleetRequestsSuccessItem> successfulFleetRequests = response.SuccessfulFleetRequests;

            #endregion
        }

        public void EC2CancelSpotInstanceRequests()
        {
            #region CancelSpotInstanceRequests-1

            var client = new AmazonEC2Client();
            var response = client.CancelSpotInstanceRequests(new CancelSpotInstanceRequestsRequest
            {
                SpotInstanceRequestIds = new List<string> {
                    "sir-08b93456"
                }
            });

            List<CancelledSpotInstanceRequest> cancelledSpotInstanceRequests = response.CancelledSpotInstanceRequests;

            #endregion
        }

        public void EC2ConfirmProductInstance()
        {
            #region ConfirmProductInstance-1

            var client = new AmazonEC2Client();
            var response = client.ConfirmProductInstance(new ConfirmProductInstanceRequest
            {
                InstanceId = "i-1234567890abcdef0",
                ProductCode = "774F4FF8"
            });

            string ownerId = response.OwnerId;

            #endregion
        }

        public void EC2CopyImage()
        {
            #region CopyImage-1

            var client = new AmazonEC2Client();
            var response = client.CopyImage(new CopyImageRequest
            {
                Description = "",
                Name = "My server",
                SourceImageId = "ami-5731123e",
                SourceRegion = "us-east-1"
            });

            string imageId = response.ImageId;

            #endregion
        }

        public void EC2CopySnapshot()
        {
            #region CopySnapshot-1

            var client = new AmazonEC2Client();
            var response = client.CopySnapshot(new CopySnapshotRequest
            {
                Description = "This is my copied snapshot.",
                DestinationRegion = "us-east-1",
                SourceRegion = "us-west-2",
                SourceSnapshotId = "snap-066877671789bd71b"
            });

            string snapshotId = response.SnapshotId;

            #endregion
        }

        public void EC2CreateApplicationStatusCheck()
        {
            #region CreateApplicationStatusCheck-1

            var client = new AmazonEC2Client();
            var response = client.CreateApplicationStatusCheck(new CreateApplicationStatusCheckRequest
            {
                Aggregation = "included",
                Path = "/health",
                Port = 80,
                Protocol = "http"
            });

            ApplicationStatusCheckResponseObject applicationStatusCheck = response.ApplicationStatusCheck;

            #endregion
        }

        public void EC2CreateCustomerGateway()
        {
            #region CreateCustomerGateway-1

            var client = new AmazonEC2Client();
            var response = client.CreateCustomerGateway(new CreateCustomerGatewayRequest
            {
                BgpAsn = 65534,
                PublicIp = "12.1.2.3",
                Type = "ipsec.1"
            });

            CustomerGateway customerGateway = response.CustomerGateway;

            #endregion
        }

        public void EC2CreateDhcpOptions()
        {
            #region CreateDhcpOptions-1

            var client = new AmazonEC2Client();
            var response = client.CreateDhcpOptions(new CreateDhcpOptionsRequest
            {
                DhcpConfigurations = new List<DhcpConfiguration> {
                    new DhcpConfiguration {
                        Key = "domain-name-servers",
                        Values = new List<string> {
                            "10.2.5.1",
                            "10.2.5.2"
                        }
                    }
                }
            });

            DhcpOptions dhcpOptions = response.DhcpOptions;

            #endregion
        }

        public void EC2CreateInternetGateway()
        {
            #region CreateInternetGateway-1

            var client = new AmazonEC2Client();
            var response = client.CreateInternetGateway(new CreateInternetGatewayRequest
            {
            });

            InternetGateway internetGateway = response.InternetGateway;

            #endregion
        }

        public void EC2CreateKeyPair()
        {
            #region CreateKeyPair-1

            var client = new AmazonEC2Client();
            var response = client.CreateKeyPair(new CreateKeyPairRequest
            {
                KeyName = "my-key-pair"
            });


            #endregion
        }

        public void EC2CreateLaunchTemplate()
        {
            #region CreateLaunchTemplate-1

            var client = new AmazonEC2Client();
            var response = client.CreateLaunchTemplate(new CreateLaunchTemplateRequest
            {
                LaunchTemplateData = new RequestLaunchTemplateData {
                    ImageId = "ami-8c1be5f6",
                    InstanceType = "t2.small",
                    NetworkInterfaces = new List<LaunchTemplateInstanceNetworkInterfaceSpecificationRequest> {
                        new LaunchTemplateInstanceNetworkInterfaceSpecificationRequest {
                            AssociatePublicIpAddress = true,
                            DeviceIndex = 0,
                            Ipv6AddressCount = 1,
                            SubnetId = "subnet-7b16de0c"
                        }
                    },
                    TagSpecifications = new List<LaunchTemplateTagSpecificationRequest> {
                        new LaunchTemplateTagSpecificationRequest {
                            ResourceType = "instance",
                            Tags = new List<Tag> {
                                new Tag {
                                    Key = "Name",
                                    Value = "webserver"
                                }
                            }
                        }
                    }
                },
                LaunchTemplateName = "my-template",
                VersionDescription = "WebVersion1"
            });

            LaunchTemplate launchTemplate = response.LaunchTemplate;

            #endregion
        }

        public void EC2CreateLaunchTemplateVersion()
        {
            #region CreateLaunchTemplateVersion-1

            var client = new AmazonEC2Client();
            var response = client.CreateLaunchTemplateVersion(new CreateLaunchTemplateVersionRequest
            {
                LaunchTemplateData = new RequestLaunchTemplateData { ImageId = "ami-c998b6b2" },
                LaunchTemplateId = "lt-0abcd290751193123",
                SourceVersion = "1",
                VersionDescription = "WebVersion2"
            });

            LaunchTemplateVersion launchTemplateVersion = response.LaunchTemplateVersion;

            #endregion
        }

        public void EC2CreateNatGateway()
        {
            #region CreateNatGateway-1

            var client = new AmazonEC2Client();
            var response = client.CreateNatGateway(new CreateNatGatewayRequest
            {
                AllocationId = "eipalloc-37fc1a52",
                SubnetId = "subnet-1a2b3c4d"
            });

            NatGateway natGateway = response.NatGateway;

            #endregion
        }

        public void EC2CreateNetworkAcl()
        {
            #region CreateNetworkAcl-1

            var client = new AmazonEC2Client();
            var response = client.CreateNetworkAcl(new CreateNetworkAclRequest
            {
                VpcId = "vpc-a01106c2"
            });

            NetworkAcl networkAcl = response.NetworkAcl;

            #endregion
        }

        public void EC2CreateNetworkAclEntry()
        {
            #region CreateNetworkAclEntry-1

            var client = new AmazonEC2Client();
            var response = client.CreateNetworkAclEntry(new CreateNetworkAclEntryRequest
            {
                CidrBlock = "0.0.0.0/0",
                Egress = false,
                NetworkAclId = "acl-5fb85d36",
                PortRange = new PortRange {
                    From = 53,
                    To = 53
                },
                Protocol = "17",
                RuleAction = "allow",
                RuleNumber = 100
            });


            #endregion
        }

        public void EC2CreatePlacementGroup()
        {
            #region CreatePlacementGroup-1

            var client = new AmazonEC2Client();
            var response = client.CreatePlacementGroup(new CreatePlacementGroupRequest
            {
                GroupName = "my-cluster",
                Strategy = "cluster"
            });


            #endregion
        }

        public void EC2CreateRoute()
        {
            #region CreateRoute-1

            var client = new AmazonEC2Client();
            var response = client.CreateRoute(new CreateRouteRequest
            {
                DestinationCidrBlock = "0.0.0.0/0",
                GatewayId = "igw-c0a643a9",
                RouteTableId = "rtb-22574640"
            });


            #endregion
        }

        public void EC2CreateRouteTable()
        {
            #region CreateRouteTable-1

            var client = new AmazonEC2Client();
            var response = client.CreateRouteTable(new CreateRouteTableRequest
            {
                VpcId = "vpc-a01106c2"
            });

            RouteTable routeTable = response.RouteTable;

            #endregion
        }

        public void EC2CreateSecondaryNetwork()
        {
            #region CreateSecondaryNetwork-1

            var client = new AmazonEC2Client();
            var response = client.CreateSecondaryNetwork(new CreateSecondaryNetworkRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                Ipv4CidrBlock = "10.0.0.0/16",
                NetworkType = "rdma",
                TagSpecifications = new List<TagSpecification> {
                    new TagSpecification {
                        ResourceType = "secondary-network",
                        Tags = new List<Tag> {
                            new Tag {
                                Key = "Name",
                                Value = "Prod Secondary Network"
                            }
                        }
                    }
                }
            });

            string clientToken = response.ClientToken;
            SecondaryNetwork secondaryNetwork = response.SecondaryNetwork;

            #endregion
        }

        public void EC2CreateSecondarySubnet()
        {
            #region CreateSecondarySubnet-1

            var client = new AmazonEC2Client();
            var response = client.CreateSecondarySubnet(new CreateSecondarySubnetRequest
            {
                AvailabilityZoneId = "use2-az1",
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                Ipv4CidrBlock = "10.0.0.0/24",
                SecondaryNetworkId = "sn-0123456789abcdef0",
                TagSpecifications = new List<TagSpecification> {
                    new TagSpecification {
                        ResourceType = "secondary-subnet",
                        Tags = new List<Tag> {
                            new Tag {
                                Key = "Name",
                                Value = "Prod Secondary Subnet"
                            },
                            new Tag {
                                Key = "Environment",
                                Value = "Production"
                            }
                        }
                    }
                }
            });

            string clientToken = response.ClientToken;
            SecondarySubnet secondarySubnet = response.SecondarySubnet;

            #endregion
        }

        public void EC2CreateSecurityGroup()
        {
            #region CreateSecurityGroup-1

            var client = new AmazonEC2Client();
            var response = client.CreateSecurityGroup(new CreateSecurityGroupRequest
            {
                Description = "My security group",
                GroupName = "my-security-group",
                VpcId = "vpc-1a2b3c4d"
            });

            string groupId = response.GroupId;

            #endregion
        }

        public void EC2CreateSnapshot()
        {
            #region CreateSnapshot-1

            var client = new AmazonEC2Client();
            var response = client.CreateSnapshot(new CreateSnapshotRequest
            {
                Description = "This is my root volume snapshot.",
                VolumeId = "vol-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2CreateSpotDatafeedSubscription()
        {
            #region CreateSpotDatafeedSubscription-1

            var client = new AmazonEC2Client();
            var response = client.CreateSpotDatafeedSubscription(new CreateSpotDatafeedSubscriptionRequest
            {
                Bucket = "my-s3-bucket",
                Prefix = "spotdata"
            });

            SpotDatafeedSubscription spotDatafeedSubscription = response.SpotDatafeedSubscription;

            #endregion
        }

        public void EC2CreateSubnet()
        {
            #region CreateSubnet-1

            var client = new AmazonEC2Client();
            var response = client.CreateSubnet(new CreateSubnetRequest
            {
                CidrBlock = "10.0.1.0/24",
                VpcId = "vpc-a01106c2"
            });

            Subnet subnet = response.Subnet;

            #endregion
        }

        public void EC2CreateTags()
        {
            #region CreateTags-1

            var client = new AmazonEC2Client();
            var response = client.CreateTags(new CreateTagsRequest
            {
                Resources = new List<string> {
                    "ami-78a54011"
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Stack",
                        Value = "production"
                    }
                }
            });


            #endregion
        }

        public void EC2CreateVolume()
        {
            #region CreateVolume-1

            var client = new AmazonEC2Client();
            var response = client.CreateVolume(new CreateVolumeRequest
            {
                AvailabilityZone = "us-east-1a",
                Iops = 1000,
                SnapshotId = "snap-066877671789bd71b",
                VolumeType = "io1"
            });


            #endregion
        }

        public void EC2CreateVolume()
        {
            #region CreateVolume-2

            var client = new AmazonEC2Client();
            var response = client.CreateVolume(new CreateVolumeRequest
            {
                AvailabilityZone = "us-east-1a",
                Size = 80,
                VolumeType = "gp2"
            });


            #endregion
        }

        public void EC2CreateVpc()
        {
            #region CreateVpc-1

            var client = new AmazonEC2Client();
            var response = client.CreateVpc(new CreateVpcRequest
            {
                CidrBlock = "10.0.0.0/16"
            });

            Vpc vpc = response.Vpc;

            #endregion
        }

        public void EC2DeleteApplicationStatusCheck()
        {
            #region DeleteApplicationStatusCheck-1

            var client = new AmazonEC2Client();
            var response = client.DeleteApplicationStatusCheck(new DeleteApplicationStatusCheckRequest
            {
                ApplicationStatusCheckId = "asc-0123456789abcdef0"
            });

            ApplicationStatusCheckResponseObject applicationStatusCheck = response.ApplicationStatusCheck;

            #endregion
        }

        public void EC2DeleteCustomerGateway()
        {
            #region DeleteCustomerGateway-1

            var client = new AmazonEC2Client();
            var response = client.DeleteCustomerGateway(new DeleteCustomerGatewayRequest
            {
                CustomerGatewayId = "cgw-0e11f167"
            });


            #endregion
        }

        public void EC2DeleteDhcpOptions()
        {
            #region DeleteDhcpOptions-1

            var client = new AmazonEC2Client();
            var response = client.DeleteDhcpOptions(new DeleteDhcpOptionsRequest
            {
                DhcpOptionsId = "dopt-d9070ebb"
            });


            #endregion
        }

        public void EC2DeleteInternetGateway()
        {
            #region DeleteInternetGateway-1

            var client = new AmazonEC2Client();
            var response = client.DeleteInternetGateway(new DeleteInternetGatewayRequest
            {
                InternetGatewayId = "igw-c0a643a9"
            });


            #endregion
        }

        public void EC2DeleteKeyPair()
        {
            #region DeleteKeyPair-1

            var client = new AmazonEC2Client();
            var response = client.DeleteKeyPair(new DeleteKeyPairRequest
            {
                KeyName = "my-key-pair"
            });


            #endregion
        }

        public void EC2DeleteLaunchTemplate()
        {
            #region DeleteLaunchTemplate-1

            var client = new AmazonEC2Client();
            var response = client.DeleteLaunchTemplate(new DeleteLaunchTemplateRequest
            {
                LaunchTemplateId = "lt-0abcd290751193123"
            });

            LaunchTemplate launchTemplate = response.LaunchTemplate;

            #endregion
        }

        public void EC2DeleteLaunchTemplateVersions()
        {
            #region DeleteLaunchTemplateVersions-1

            var client = new AmazonEC2Client();
            var response = client.DeleteLaunchTemplateVersions(new DeleteLaunchTemplateVersionsRequest
            {
                LaunchTemplateId = "lt-0abcd290751193123",
                Versions = new List<string> {
                    "1"
                }
            });

            List<DeleteLaunchTemplateVersionsResponseSuccessItem> successfullyDeletedLaunchTemplateVersions = response.SuccessfullyDeletedLaunchTemplateVersions;
            List<DeleteLaunchTemplateVersionsResponseErrorItem> unsuccessfullyDeletedLaunchTemplateVersions = response.UnsuccessfullyDeletedLaunchTemplateVersions;

            #endregion
        }

        public void EC2DeleteNatGateway()
        {
            #region DeleteNatGateway-1

            var client = new AmazonEC2Client();
            var response = client.DeleteNatGateway(new DeleteNatGatewayRequest
            {
                NatGatewayId = "nat-04ae55e711cec5680"
            });

            string natGatewayId = response.NatGatewayId;

            #endregion
        }

        public void EC2DeleteNetworkAcl()
        {
            #region DeleteNetworkAcl-1

            var client = new AmazonEC2Client();
            var response = client.DeleteNetworkAcl(new DeleteNetworkAclRequest
            {
                NetworkAclId = "acl-5fb85d36"
            });


            #endregion
        }

        public void EC2DeleteNetworkAclEntry()
        {
            #region DeleteNetworkAclEntry-1

            var client = new AmazonEC2Client();
            var response = client.DeleteNetworkAclEntry(new DeleteNetworkAclEntryRequest
            {
                Egress = true,
                NetworkAclId = "acl-5fb85d36",
                RuleNumber = 100
            });


            #endregion
        }

        public void EC2DeleteNetworkInterface()
        {
            #region DeleteNetworkInterface-1

            var client = new AmazonEC2Client();
            var response = client.DeleteNetworkInterface(new DeleteNetworkInterfaceRequest
            {
                NetworkInterfaceId = "eni-e5aa89a3"
            });


            #endregion
        }

        public void EC2DeletePlacementGroup()
        {
            #region DeletePlacementGroup-1

            var client = new AmazonEC2Client();
            var response = client.DeletePlacementGroup(new DeletePlacementGroupRequest
            {
                GroupName = "my-cluster"
            });


            #endregion
        }

        public void EC2DeleteRoute()
        {
            #region DeleteRoute-1

            var client = new AmazonEC2Client();
            var response = client.DeleteRoute(new DeleteRouteRequest
            {
                DestinationCidrBlock = "0.0.0.0/0",
                RouteTableId = "rtb-22574640"
            });


            #endregion
        }

        public void EC2DeleteRouteTable()
        {
            #region DeleteRouteTable-1

            var client = new AmazonEC2Client();
            var response = client.DeleteRouteTable(new DeleteRouteTableRequest
            {
                RouteTableId = "rtb-22574640"
            });


            #endregion
        }

        public void EC2DeleteSecondaryNetwork()
        {
            #region DeleteSecondaryNetwork-1

            var client = new AmazonEC2Client();
            var response = client.DeleteSecondaryNetwork(new DeleteSecondaryNetworkRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                SecondaryNetworkId = "sn-0123456789abcdef0"
            });

            string clientToken = response.ClientToken;
            SecondaryNetwork secondaryNetwork = response.SecondaryNetwork;

            #endregion
        }

        public void EC2DeleteSecondarySubnet()
        {
            #region DeleteSecondarySubnet-1

            var client = new AmazonEC2Client();
            var response = client.DeleteSecondarySubnet(new DeleteSecondarySubnetRequest
            {
                ClientToken = "550e8400-e29b-41d4-a716-446655440000",
                SecondarySubnetId = "ss-0123456789abcdef0"
            });

            string clientToken = response.ClientToken;
            SecondarySubnet secondarySubnet = response.SecondarySubnet;

            #endregion
        }

        public void EC2DeleteSecurityGroup()
        {
            #region DeleteSecurityGroup-1

            var client = new AmazonEC2Client();
            var response = client.DeleteSecurityGroup(new DeleteSecurityGroupRequest
            {
                GroupId = "sg-903004f8"
            });


            #endregion
        }

        public void EC2DeleteSnapshot()
        {
            #region DeleteSnapshot-1

            var client = new AmazonEC2Client();
            var response = client.DeleteSnapshot(new DeleteSnapshotRequest
            {
                SnapshotId = "snap-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2DeleteSpotDatafeedSubscription()
        {
            #region DeleteSpotDatafeedSubscription-1

            var client = new AmazonEC2Client();
            var response = client.DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest
            {
            });


            #endregion
        }

        public void EC2DeleteSubnet()
        {
            #region DeleteSubnet-1

            var client = new AmazonEC2Client();
            var response = client.DeleteSubnet(new DeleteSubnetRequest
            {
                SubnetId = "subnet-9d4a7b6c"
            });


            #endregion
        }

        public void EC2DeleteTags()
        {
            #region DeleteTags-1

            var client = new AmazonEC2Client();
            var response = client.DeleteTags(new DeleteTagsRequest
            {
                Resources = new List<string> {
                    "ami-78a54011"
                },
                Tags = new List<Tag> {
                    new Tag {
                        Key = "Stack",
                        Value = "test"
                    }
                }
            });


            #endregion
        }

        public void EC2DeleteVolume()
        {
            #region DeleteVolume-1

            var client = new AmazonEC2Client();
            var response = client.DeleteVolume(new DeleteVolumeRequest
            {
                VolumeId = "vol-049df61146c4d7901"
            });


            #endregion
        }

        public void EC2DeleteVpc()
        {
            #region DeleteVpc-1

            var client = new AmazonEC2Client();
            var response = client.DeleteVpc(new DeleteVpcRequest
            {
                VpcId = "vpc-a01106c2"
            });


            #endregion
        }

        public void EC2DescribeAccountAttributes()
        {
            #region DescribeAccountAttributes-1

            var client = new AmazonEC2Client();
            var response = client.DescribeAccountAttributes(new DescribeAccountAttributesRequest
            {
                AttributeNames = new List<string> {
                    "supported-platforms"
                }
            });

            List<AccountAttribute> accountAttributes = response.AccountAttributes;

            #endregion
        }

        public void EC2DescribeAccountAttributes()
        {
            #region DescribeAccountAttributes-2

            var client = new AmazonEC2Client();
            var response = client.DescribeAccountAttributes(new DescribeAccountAttributesRequest
            {
            });

            List<AccountAttribute> accountAttributes = response.AccountAttributes;

            #endregion
        }

        public void EC2DescribeAddresses()
        {
            #region DescribeAddresses-1

            var client = new AmazonEC2Client();
            var response = client.DescribeAddresses(new DescribeAddressesRequest
            {
            });

            List<Address> addresses = response.Addresses;

            #endregion
        }

        public void EC2DescribeApplicationStatus()
        {
            #region DescribeApplicationStatus-1

            var client = new AmazonEC2Client();
            var response = client.DescribeApplicationStatus(new DescribeApplicationStatusRequest
            {
                InstanceIds = new List<string> {
                    "i-0123456789abcdef0"
                }
            });

            ApplicationStatusesResponseType applicationStatuses = response.ApplicationStatuses;

            #endregion
        }

        public void EC2DescribeApplicationStatus()
        {
            #region DescribeApplicationStatus-2

            var client = new AmazonEC2Client();
            var response = client.DescribeApplicationStatus(new DescribeApplicationStatusRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "availability-zone-id",
                        Values = new List<string> {
                            "use1-az1"
                        }
                    },
                    new Filter {
                        Name = "status",
                        Values = new List<string> {
                            "impaired"
                        }
                    }
                },
                MaxResults = 10
            });

            ApplicationStatusesResponseType applicationStatuses = response.ApplicationStatuses;

            #endregion
        }

        public void EC2DescribeApplicationStatusCheckAssociations()
        {
            #region DescribeApplicationStatusCheckAssociations-1

            var client = new AmazonEC2Client();
            var response = client.DescribeApplicationStatusCheckAssociations(new DescribeApplicationStatusCheckAssociationsRequest
            {
                ApplicationStatusCheckIds = new List<string> {
                    "asc-0123456789abcdef0"
                },
                Filters = new List<Filter> {
                    new Filter {
                        Name = "association-type",
                        Values = new List<string> {
                            "instance-id"
                        }
                    }
                }
            });

            List<ApplicationStatusCheckAssociationObject> associations = response.Associations;

            #endregion
        }

        public void EC2DescribeApplicationStatusChecks()
        {
            #region DescribeApplicationStatusChecks-1

            var client = new AmazonEC2Client();
            var response = client.DescribeApplicationStatusChecks(new DescribeApplicationStatusChecksRequest
            {
                ApplicationStatusCheckIds = new List<string> {
                    "asc-0123456789abcdef0"
                }
            });

            List<ApplicationStatusCheckResponseObject> applicationStatusChecks = response.ApplicationStatusChecks;

            #endregion
        }

        public void EC2DescribeApplicationStatusChecks()
        {
            #region DescribeApplicationStatusChecks-2

            var client = new AmazonEC2Client();
            var response = client.DescribeApplicationStatusChecks(new DescribeApplicationStatusChecksRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "aggregation",
                        Values = new List<string> {
                            "included"
                        }
                    }
                },
                MaxResults = 10
            });

            List<ApplicationStatusCheckResponseObject> applicationStatusChecks = response.ApplicationStatusChecks;

            #endregion
        }

        public void EC2DescribeAvailabilityZones()
        {
            #region DescribeAvailabilityZones-1

            var client = new AmazonEC2Client();
            var response = client.DescribeAvailabilityZones(new DescribeAvailabilityZonesRequest
            {
            });

            List<AvailabilityZone> availabilityZones = response.AvailabilityZones;

            #endregion
        }

        public void EC2DescribeCustomerGateways()
        {
            #region DescribeCustomerGateways-1

            var client = new AmazonEC2Client();
            var response = client.DescribeCustomerGateways(new DescribeCustomerGatewaysRequest
            {
                CustomerGatewayIds = new List<string> {
                    "cgw-0e11f167"
                }
            });

            List<CustomerGateway> customerGateways = response.CustomerGateways;

            #endregion
        }

        public void EC2DescribeDhcpOptions()
        {
            #region DescribeDhcpOptions-1

            var client = new AmazonEC2Client();
            var response = client.DescribeDhcpOptions(new DescribeDhcpOptionsRequest
            {
                DhcpOptionsIds = new List<string> {
                    "dopt-d9070ebb"
                }
            });

            List<DhcpOptions> dhcpOptions = response.DhcpOptions;

            #endregion
        }

        public void EC2DescribeIamInstanceProfileAssociations()
        {
            #region DescribeIamInstanceProfileAssociations-1

            var client = new AmazonEC2Client();
            var response = client.DescribeIamInstanceProfileAssociations(new DescribeIamInstanceProfileAssociationsRequest
            {
                AssociationIds = new List<string> {
                    "iip-assoc-0db249b1f25fa24b8"
                }
            });

            List<IamInstanceProfileAssociation> iamInstanceProfileAssociations = response.IamInstanceProfileAssociations;

            #endregion
        }

        public void EC2DescribeImageAttribute()
        {
            #region DescribeImageAttribute-1

            var client = new AmazonEC2Client();
            var response = client.DescribeImageAttribute(new DescribeImageAttributeRequest
            {
                Attribute = "launchPermission",
                ImageId = "ami-5731123e"
            });


            #endregion
        }

        public void EC2DescribeImages()
        {
            #region DescribeImages-1

            var client = new AmazonEC2Client();
            var response = client.DescribeImages(new DescribeImagesRequest
            {
                ImageIds = new List<string> {
                    "ami-5731123e"
                }
            });

            List<Image> images = response.Images;

            #endregion
        }

        public void EC2DescribeInstanceAttribute()
        {
            #region DescribeInstanceAttribute-1

            var client = new AmazonEC2Client();
            var response = client.DescribeInstanceAttribute(new DescribeInstanceAttributeRequest
            {
                Attribute = "blockDeviceMapping",
                InstanceId = "i-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2DescribeInstanceAttribute()
        {
            #region DescribeInstanceAttribute-2

            var client = new AmazonEC2Client();
            var response = client.DescribeInstanceAttribute(new DescribeInstanceAttributeRequest
            {
                Attribute = "instanceType",
                InstanceId = "i-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2DescribeInstances()
        {
            #region DescribeInstances-1

            var client = new AmazonEC2Client();
            var response = client.DescribeInstances(new DescribeInstancesRequest
            {
                InstanceIds = new List<string> {
                    "i-1234567890abcdef0"
                }
            });


            #endregion
        }

        public void EC2DescribeInstances()
        {
            #region DescribeInstances-2

            var client = new AmazonEC2Client();
            var response = client.DescribeInstances(new DescribeInstancesRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "tag:Purpose",
                        Values = new List<string> {
                            "test"
                        }
                    }
                }
            });


            #endregion
        }

        public void EC2DescribeInstances()
        {
            #region DescribeInstances-3

            var client = new AmazonEC2Client();
            var response = client.DescribeInstances(new DescribeInstancesRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "instance-type",
                        Values = new List<string> {
                            "t2.micro"
                        }
                    }
                }
            });


            #endregion
        }

        public void EC2DescribeInstanceStatus()
        {
            #region DescribeInstanceStatus-1

            var client = new AmazonEC2Client();
            var response = client.DescribeInstanceStatus(new DescribeInstanceStatusRequest
            {
                InstanceIds = new List<string> {
                    "i-1234567890abcdef0"
                }
            });

            List<InstanceStatus> instanceStatuses = response.InstanceStatuses;

            #endregion
        }

        public void EC2DescribeInternetGateways()
        {
            #region DescribeInternetGateways-1

            var client = new AmazonEC2Client();
            var response = client.DescribeInternetGateways(new DescribeInternetGatewaysRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "attachment.vpc-id",
                        Values = new List<string> {
                            "vpc-a01106c2"
                        }
                    }
                }
            });

            List<InternetGateway> internetGateways = response.InternetGateways;

            #endregion
        }

        public void EC2DescribeKeyPairs()
        {
            #region DescribeKeyPairs-1

            var client = new AmazonEC2Client();
            var response = client.DescribeKeyPairs(new DescribeKeyPairsRequest
            {
                KeyNames = new List<string> {
                    "my-key-pair"
                }
            });

            List<KeyPairInfo> keyPairs = response.KeyPairs;

            #endregion
        }

        public void EC2DescribeLaunchTemplates()
        {
            #region DescribeLaunchTemplates-1

            var client = new AmazonEC2Client();
            var response = client.DescribeLaunchTemplates(new DescribeLaunchTemplatesRequest
            {
                LaunchTemplateIds = new List<string> {
                    "lt-01238c059e3466abc"
                }
            });

            List<LaunchTemplate> launchTemplates = response.LaunchTemplates;

            #endregion
        }

        public void EC2DescribeLaunchTemplateVersions()
        {
            #region DescribeLaunchTemplateVersions-1

            var client = new AmazonEC2Client();
            var response = client.DescribeLaunchTemplateVersions(new DescribeLaunchTemplateVersionsRequest
            {
                LaunchTemplateId = "068f72b72934aff71"
            });

            List<LaunchTemplateVersion> launchTemplateVersions = response.LaunchTemplateVersions;

            #endregion
        }

        public void EC2DescribeMovingAddresses()
        {
            #region DescribeMovingAddresses-1

            var client = new AmazonEC2Client();
            var response = client.DescribeMovingAddresses(new DescribeMovingAddressesRequest
            {
            });

            List<MovingAddressStatus> movingAddressStatuses = response.MovingAddressStatuses;

            #endregion
        }

        public void EC2DescribeNatGateways()
        {
            #region DescribeNatGateways-1

            var client = new AmazonEC2Client();
            var response = client.DescribeNatGateways(new DescribeNatGatewaysRequest
            {
                Filter = new List<Filter> {
                    new Filter {
                        Name = "vpc-id",
                        Values = new List<string> {
                            "vpc-1a2b3c4d"
                        }
                    }
                }
            });

            List<NatGateway> natGateways = response.NatGateways;

            #endregion
        }

        public void EC2DescribeNetworkAcls()
        {
            #region DescribeNetworkAcls-1

            var client = new AmazonEC2Client();
            var response = client.DescribeNetworkAcls(new DescribeNetworkAclsRequest
            {
                NetworkAclIds = new List<string> {
                    "acl-5fb85d36"
                }
            });

            List<NetworkAcl> networkAcls = response.NetworkAcls;

            #endregion
        }

        public void EC2DescribeNetworkInterfaceAttribute()
        {
            #region DescribeNetworkInterfaceAttribute-1

            var client = new AmazonEC2Client();
            var response = client.DescribeNetworkInterfaceAttribute(new DescribeNetworkInterfaceAttributeRequest
            {
                Attribute = "attachment",
                NetworkInterfaceId = "eni-686ea200"
            });

            NetworkInterfaceAttachment attachment = response.Attachment;
            string networkInterfaceId = response.NetworkInterfaceId;

            #endregion
        }

        public void EC2DescribeNetworkInterfaceAttribute()
        {
            #region DescribeNetworkInterfaceAttribute-2

            var client = new AmazonEC2Client();
            var response = client.DescribeNetworkInterfaceAttribute(new DescribeNetworkInterfaceAttributeRequest
            {
                Attribute = "description",
                NetworkInterfaceId = "eni-686ea200"
            });

            string description = response.Description;
            string networkInterfaceId = response.NetworkInterfaceId;

            #endregion
        }

        public void EC2DescribeNetworkInterfaceAttribute()
        {
            #region DescribeNetworkInterfaceAttribute-3

            var client = new AmazonEC2Client();
            var response = client.DescribeNetworkInterfaceAttribute(new DescribeNetworkInterfaceAttributeRequest
            {
                Attribute = "groupSet",
                NetworkInterfaceId = "eni-686ea200"
            });

            List<GroupIdentifier> groups = response.Groups;
            string networkInterfaceId = response.NetworkInterfaceId;

            #endregion
        }

        public void EC2DescribeNetworkInterfaceAttribute()
        {
            #region DescribeNetworkInterfaceAttribute-4

            var client = new AmazonEC2Client();
            var response = client.DescribeNetworkInterfaceAttribute(new DescribeNetworkInterfaceAttributeRequest
            {
                Attribute = "sourceDestCheck",
                NetworkInterfaceId = "eni-686ea200"
            });

            string networkInterfaceId = response.NetworkInterfaceId;
            bool? sourceDestCheck = response.SourceDestCheck;

            #endregion
        }

        public void EC2DescribeNetworkInterfaces()
        {
            #region DescribeNetworkInterfaces-1

            var client = new AmazonEC2Client();
            var response = client.DescribeNetworkInterfaces(new DescribeNetworkInterfacesRequest
            {
                NetworkInterfaceIds = new List<string> {
                    "eni-e5aa89a3"
                }
            });

            List<NetworkInterface> networkInterfaces = response.NetworkInterfaces;

            #endregion
        }

        public void EC2DescribeRegions()
        {
            #region DescribeRegions-1

            var client = new AmazonEC2Client();
            var response = client.DescribeRegions(new DescribeRegionsRequest
            {
            });

            List<Region> regions = response.Regions;

            #endregion
        }

        public void EC2DescribeRouteTables()
        {
            #region DescribeRouteTables-1

            var client = new AmazonEC2Client();
            var response = client.DescribeRouteTables(new DescribeRouteTablesRequest
            {
                RouteTableIds = new List<string> {
                    "rtb-1f382e7d"
                }
            });

            List<RouteTable> routeTables = response.RouteTables;

            #endregion
        }

        public void EC2DescribeSecondaryInterfaces()
        {
            #region DescribeSecondaryInterfaces-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSecondaryInterfaces(new DescribeSecondaryInterfacesRequest
            {
            });

            List<SecondaryInterface> secondaryInterfaces = response.SecondaryInterfaces;

            #endregion
        }

        public void EC2DescribeSecondaryInterfaces()
        {
            #region DescribeSecondaryInterfaces-2

            var client = new AmazonEC2Client();
            var response = client.DescribeSecondaryInterfaces(new DescribeSecondaryInterfacesRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "attachment.instance-id",
                        Values = new List<string> {
                            "i-1234567890abcdef0"
                        }
                    }
                },
                MaxResults = 5
            });

            string nextToken = response.NextToken;
            List<SecondaryInterface> secondaryInterfaces = response.SecondaryInterfaces;

            #endregion
        }

        public void EC2DescribeSecondaryNetworks()
        {
            #region DescribeSecondaryNetworks-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSecondaryNetworks(new DescribeSecondaryNetworksRequest
            {
                SecondaryNetworkIds = new List<string> {
                    "sn-0123456789abcdef0",
                    "sn-0987654321fedcba0"
                }
            });

            List<SecondaryNetwork> secondaryNetworks = response.SecondaryNetworks;

            #endregion
        }

        public void EC2DescribeSecondaryNetworks()
        {
            #region DescribeSecondaryNetworks-2

            var client = new AmazonEC2Client();
            var response = client.DescribeSecondaryNetworks(new DescribeSecondaryNetworksRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "tag:Environment",
                        Values = new List<string> {
                            "Production"
                        }
                    },
                    new Filter {
                        Name = "state",
                        Values = new List<string> {
                            "create-complete"
                        }
                    }
                },
                MaxResults = 5
            });

            string nextToken = response.NextToken;
            List<SecondaryNetwork> secondaryNetworks = response.SecondaryNetworks;

            #endregion
        }

        public void EC2DescribeSecondarySubnets()
        {
            #region DescribeSecondarySubnets-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSecondarySubnets(new DescribeSecondarySubnetsRequest
            {
                SecondarySubnetIds = new List<string> {
                    "ss-0123456789abcdef0",
                    "ss-0987654321fedcba0"
                }
            });

            List<SecondarySubnet> secondarySubnets = response.SecondarySubnets;

            #endregion
        }

        public void EC2DescribeSecurityGroupReferences()
        {
            #region DescribeSecurityGroupReferences-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSecurityGroupReferences(new DescribeSecurityGroupReferencesRequest
            {
                GroupId = new List<string> {
                    "sg-903004f8"
                }
            });

            List<SecurityGroupReference> securityGroupReferenceSet = response.SecurityGroupReferenceSet;

            #endregion
        }

        public void EC2DescribeSecurityGroups()
        {
            #region DescribeSecurityGroups-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSecurityGroups(new DescribeSecurityGroupsRequest
            {
                GroupIds = new List<string> {
                    "sg-903004f8"
                }
            });


            #endregion
        }

        public void EC2DescribeSecurityGroups()
        {
            #region DescribeSecurityGroups-2

            var client = new AmazonEC2Client();
            var response = client.DescribeSecurityGroups(new DescribeSecurityGroupsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "tag:Purpose",
                        Values = new List<string> {
                            "test"
                        }
                    }
                }
            });


            #endregion
        }

        public void EC2DescribeSnapshotAttribute()
        {
            #region DescribeSnapshotAttribute-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSnapshotAttribute(new DescribeSnapshotAttributeRequest
            {
                Attribute = "createVolumePermission",
                SnapshotId = "snap-066877671789bd71b"
            });

            List<CreateVolumePermission> createVolumePermissions = response.CreateVolumePermissions;
            string snapshotId = response.SnapshotId;

            #endregion
        }

        public void EC2DescribeSnapshots()
        {
            #region DescribeSnapshots-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSnapshots(new DescribeSnapshotsRequest
            {
                SnapshotIds = new List<string> {
                    "snap-1234567890abcdef0"
                }
            });

            string nextToken = response.NextToken;
            List<Snapshot> snapshots = response.Snapshots;

            #endregion
        }

        public void EC2DescribeSnapshots()
        {
            #region DescribeSnapshots-2

            var client = new AmazonEC2Client();
            var response = client.DescribeSnapshots(new DescribeSnapshotsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "status",
                        Values = new List<string> {
                            "pending"
                        }
                    }
                },
                OwnerIds = new List<string> {
                    "012345678910"
                }
            });

            string nextToken = response.NextToken;
            List<Snapshot> snapshots = response.Snapshots;

            #endregion
        }

        public void EC2DescribeSpotDatafeedSubscription()
        {
            #region DescribeSpotDatafeedSubscription-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSpotDatafeedSubscription(new DescribeSpotDatafeedSubscriptionRequest
            {
            });

            SpotDatafeedSubscription spotDatafeedSubscription = response.SpotDatafeedSubscription;

            #endregion
        }

        public void EC2DescribeSpotFleetInstances()
        {
            #region DescribeSpotFleetInstances-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSpotFleetInstances(new DescribeSpotFleetInstancesRequest
            {
                SpotFleetRequestId = "sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE"
            });

            List<ActiveInstance> activeInstances = response.ActiveInstances;
            string spotFleetRequestId = response.SpotFleetRequestId;

            #endregion
        }

        public void EC2DescribeSpotFleetRequestHistory()
        {
            #region DescribeSpotFleetRequestHistory-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSpotFleetRequestHistory(new DescribeSpotFleetRequestHistoryRequest
            {
                SpotFleetRequestId = "sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE",
                StartTime = new DateTime(2015, 5, 26, 0, 0, 0, DateTimeKind.Utc)
            });

            List<HistoryRecord> historyRecords = response.HistoryRecords;
            string nextToken = response.NextToken;
            string spotFleetRequestId = response.SpotFleetRequestId;
            DateTime? startTime = response.StartTime;

            #endregion
        }

        public void EC2DescribeSpotFleetRequests()
        {
            #region DescribeSpotFleetRequests-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSpotFleetRequests(new DescribeSpotFleetRequestsRequest
            {
                SpotFleetRequestIds = new List<string> {
                    "sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE"
                }
            });

            List<SpotFleetRequestConfig> spotFleetRequestConfigs = response.SpotFleetRequestConfigs;

            #endregion
        }

        public void EC2DescribeSpotInstanceRequests()
        {
            #region DescribeSpotInstanceRequests-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSpotInstanceRequests(new DescribeSpotInstanceRequestsRequest
            {
                SpotInstanceRequestIds = new List<string> {
                    "sir-08b93456"
                }
            });

            List<SpotInstanceRequest> spotInstanceRequests = response.SpotInstanceRequests;

            #endregion
        }

        public void EC2DescribeSpotPriceHistory()
        {
            #region DescribeSpotPriceHistory-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest
            {
                EndTime = new DateTime(2014, 1, 6, 8, 9, 10, 50, DateTimeKind.Utc),
                InstanceTypes = new List<string> {
                    "m1.xlarge"
                },
                ProductDescriptions = new List<string> {
                    "Linux/UNIX (Amazon VPC)"
                },
                StartTime = new DateTime(2014, 1, 6, 7, 8, 9, 50, DateTimeKind.Utc)
            });

            List<SpotPrice> spotPriceHistory = response.SpotPriceHistory;

            #endregion
        }

        public void EC2DescribeSubnets()
        {
            #region DescribeSubnets-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSubnets(new DescribeSubnetsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "vpc-id",
                        Values = new List<string> {
                            "vpc-a01106c2"
                        }
                    }
                }
            });

            List<Subnet> subnets = response.Subnets;

            #endregion
        }

        public void EC2DescribeTags()
        {
            #region DescribeTags-1

            var client = new AmazonEC2Client();
            var response = client.DescribeTags(new DescribeTagsRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "resource-id",
                        Values = new List<string> {
                            "i-1234567890abcdef8"
                        }
                    }
                }
            });

            List<TagDescription> tags = response.Tags;

            #endregion
        }

        public void EC2DescribeVolumeAttribute()
        {
            #region DescribeVolumeAttribute-1

            var client = new AmazonEC2Client();
            var response = client.DescribeVolumeAttribute(new DescribeVolumeAttributeRequest
            {
                Attribute = "autoEnableIO",
                VolumeId = "vol-049df61146c4d7901"
            });

            bool? autoEnableIO = response.AutoEnableIO;
            string volumeId = response.VolumeId;

            #endregion
        }

        public void EC2DescribeVolumes()
        {
            #region DescribeVolumes-1

            var client = new AmazonEC2Client();
            var response = client.DescribeVolumes(new DescribeVolumesRequest
            {
            });

            string nextToken = response.NextToken;
            List<Volume> volumes = response.Volumes;

            #endregion
        }

        public void EC2DescribeVolumes()
        {
            #region DescribeVolumes-2

            var client = new AmazonEC2Client();
            var response = client.DescribeVolumes(new DescribeVolumesRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "attachment.instance-id",
                        Values = new List<string> {
                            "i-1234567890abcdef0"
                        }
                    },
                    new Filter {
                        Name = "attachment.delete-on-termination",
                        Values = new List<string> {
                            "true"
                        }
                    }
                }
            });

            List<Volume> volumes = response.Volumes;

            #endregion
        }

        public void EC2DescribeVolumeStatus()
        {
            #region DescribeVolumeStatus-1

            var client = new AmazonEC2Client();
            var response = client.DescribeVolumeStatus(new DescribeVolumeStatusRequest
            {
                VolumeIds = new List<string> {
                    "vol-1234567890abcdef0"
                }
            });

            List<VolumeStatusItem> volumeStatuses = response.VolumeStatuses;

            #endregion
        }

        public void EC2DescribeVolumeStatus()
        {
            #region DescribeVolumeStatus-2

            var client = new AmazonEC2Client();
            var response = client.DescribeVolumeStatus(new DescribeVolumeStatusRequest
            {
                Filters = new List<Filter> {
                    new Filter {
                        Name = "volume-status.status",
                        Values = new List<string> {
                            "impaired"
                        }
                    }
                }
            });

            List<VolumeStatusItem> volumeStatuses = response.VolumeStatuses;

            #endregion
        }

        public void EC2DescribeVpcAttribute()
        {
            #region DescribeVpcAttribute-1

            var client = new AmazonEC2Client();
            var response = client.DescribeVpcAttribute(new DescribeVpcAttributeRequest
            {
                Attribute = "enableDnsSupport",
                VpcId = "vpc-a01106c2"
            });

            bool? enableDnsSupport = response.EnableDnsSupport;
            string vpcId = response.VpcId;

            #endregion
        }

        public void EC2DescribeVpcAttribute()
        {
            #region DescribeVpcAttribute-2

            var client = new AmazonEC2Client();
            var response = client.DescribeVpcAttribute(new DescribeVpcAttributeRequest
            {
                Attribute = "enableDnsHostnames",
                VpcId = "vpc-a01106c2"
            });

            bool? enableDnsHostnames = response.EnableDnsHostnames;
            string vpcId = response.VpcId;

            #endregion
        }

        public void EC2DescribeVpcs()
        {
            #region DescribeVpcs-1

            var client = new AmazonEC2Client();
            var response = client.DescribeVpcs(new DescribeVpcsRequest
            {
                VpcIds = new List<string> {
                    "vpc-a01106c2"
                }
            });

            List<Vpc> vpcs = response.Vpcs;

            #endregion
        }

        public void EC2DetachInternetGateway()
        {
            #region DetachInternetGateway-1

            var client = new AmazonEC2Client();
            var response = client.DetachInternetGateway(new DetachInternetGatewayRequest
            {
                InternetGatewayId = "igw-c0a643a9",
                VpcId = "vpc-a01106c2"
            });


            #endregion
        }

        public void EC2DetachNetworkInterface()
        {
            #region DetachNetworkInterface-1

            var client = new AmazonEC2Client();
            var response = client.DetachNetworkInterface(new DetachNetworkInterfaceRequest
            {
                AttachmentId = "eni-attach-66c4350a"
            });


            #endregion
        }

        public void EC2DetachVolume()
        {
            #region DetachVolume-1

            var client = new AmazonEC2Client();
            var response = client.DetachVolume(new DetachVolumeRequest
            {
                VolumeId = "vol-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2DisableApplicationStatusCheckSuppression()
        {
            #region DisableApplicationStatusCheckSuppression-1

            var client = new AmazonEC2Client();
            var response = client.DisableApplicationStatusCheckSuppression(new DisableApplicationStatusCheckSuppressionRequest
            {
                InstanceIds = new List<string> {
                    "i-0123456789abcdef0"
                }
            });

            List<SuccessfulSuppressionResponseObject> successfulResults = response.SuccessfulResults;
            List<UnsuccessfulSuppressionResponseObject> unsuccessfulResults = response.UnsuccessfulResults;

            #endregion
        }

        public void EC2DisableVgwRoutePropagation()
        {
            #region DisableVgwRoutePropagation-1

            var client = new AmazonEC2Client();
            var response = client.DisableVgwRoutePropagation(new DisableVgwRoutePropagationRequest
            {
                GatewayId = "vgw-9a4cacf3",
                RouteTableId = "rtb-22574640"
            });


            #endregion
        }

        public void EC2DisassociateAddress()
        {
            #region DisassociateAddress-1

            var client = new AmazonEC2Client();
            var response = client.DisassociateAddress(new DisassociateAddressRequest
            {
                AssociationId = "eipassoc-2bebb745"
            });


            #endregion
        }

        public void EC2DisassociateApplicationStatusCheck()
        {
            #region DisassociateApplicationStatusCheck-1

            var client = new AmazonEC2Client();
            var response = client.DisassociateApplicationStatusCheck(new DisassociateApplicationStatusCheckRequest
            {
                ApplicationStatusCheckId = "asc-0123456789abcdef0",
                TargetTagAssociations = new List<CustomTagKeyValueRequestPair> {
                    new CustomTagKeyValueRequestPair {
                        Key = "env",
                        Value = "prod"
                    }
                }
            });

            List<SuccessfulAssociationResponseObject> successfulResults = response.SuccessfulResults;
            List<UnsuccessfulAssociationResponseObject> unsuccessfulResults = response.UnsuccessfulResults;

            #endregion
        }

        public void EC2DisassociateIamInstanceProfile()
        {
            #region DisassociateIamInstanceProfile-1

            var client = new AmazonEC2Client();
            var response = client.DisassociateIamInstanceProfile(new DisassociateIamInstanceProfileRequest
            {
                AssociationId = "iip-assoc-05020b59952902f5f"
            });

            IamInstanceProfileAssociation iamInstanceProfileAssociation = response.IamInstanceProfileAssociation;

            #endregion
        }

        public void EC2DisassociateRouteTable()
        {
            #region DisassociateRouteTable-1

            var client = new AmazonEC2Client();
            var response = client.DisassociateRouteTable(new DisassociateRouteTableRequest
            {
                AssociationId = "rtbassoc-781d0d1a"
            });


            #endregion
        }

        public void EC2EnableApplicationStatusCheckSuppression()
        {
            #region EnableApplicationStatusCheckSuppression-1

            var client = new AmazonEC2Client();
            var response = client.EnableApplicationStatusCheckSuppression(new EnableApplicationStatusCheckSuppressionRequest
            {
                DurationSeconds = 3600,
                InstanceIds = new List<string> {
                    "i-0123456789abcdef0"
                }
            });

            List<SuccessfulSuppressionResponseObject> successfulResults = response.SuccessfulResults;
            List<UnsuccessfulSuppressionResponseObject> unsuccessfulResults = response.UnsuccessfulResults;

            #endregion
        }

        public void EC2EnableVgwRoutePropagation()
        {
            #region EnableVgwRoutePropagation-1

            var client = new AmazonEC2Client();
            var response = client.EnableVgwRoutePropagation(new EnableVgwRoutePropagationRequest
            {
                GatewayId = "vgw-9a4cacf3",
                RouteTableId = "rtb-22574640"
            });


            #endregion
        }

        public void EC2EnableVolumeIO()
        {
            #region EnableVolumeIO-1

            var client = new AmazonEC2Client();
            var response = client.EnableVolumeIO(new EnableVolumeIORequest
            {
                VolumeId = "vol-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2GetConsoleOutput()
        {
            #region GetConsoleOutput-1

            var client = new AmazonEC2Client();
            var response = client.GetConsoleOutput(new GetConsoleOutputRequest
            {
                InstanceId = "i-1234567890abcdef0"
            });

            string instanceId = response.InstanceId;
            string output = response.Output;
            DateTime? timestamp = response.Timestamp;

            #endregion
        }

        public void EC2GetLaunchTemplateData()
        {
            #region GetLaunchTemplateData-1

            var client = new AmazonEC2Client();
            var response = client.GetLaunchTemplateData(new GetLaunchTemplateDataRequest
            {
                InstanceId = "0123d646e8048babc"
            });

            ResponseLaunchTemplateData launchTemplateData = response.LaunchTemplateData;

            #endregion
        }

        public void EC2ModifyApplicationStatusCheck()
        {
            #region ModifyApplicationStatusCheck-1

            var client = new AmazonEC2Client();
            var response = client.ModifyApplicationStatusCheck(new ModifyApplicationStatusCheckRequest
            {
                ApplicationStatusCheckId = "asc-0123456789abcdef0",
                Path = "/healthv2",
                Port = 8080
            });

            ApplicationStatusCheckResponseObject applicationStatusCheck = response.ApplicationStatusCheck;

            #endregion
        }

        public void EC2ModifyImageAttribute()
        {
            #region ModifyImageAttribute-1

            var client = new AmazonEC2Client();
            var response = client.ModifyImageAttribute(new ModifyImageAttributeRequest
            {
                ImageId = "ami-5731123e",
                LaunchPermission = new LaunchPermissionModifications { Add = new List<LaunchPermission> {
                    new LaunchPermission { UserId = "123456789012" }
                } }
            });


            #endregion
        }

        public void EC2ModifyImageAttribute()
        {
            #region ModifyImageAttribute-2

            var client = new AmazonEC2Client();
            var response = client.ModifyImageAttribute(new ModifyImageAttributeRequest
            {
                ImageId = "ami-5731123e",
                LaunchPermission = new LaunchPermissionModifications { Add = new List<LaunchPermission> {
                    new LaunchPermission { Group = "all" }
                } }
            });


            #endregion
        }

        public void EC2ModifyInstanceAttribute()
        {
            #region ModifyInstanceAttribute-1

            var client = new AmazonEC2Client();
            var response = client.ModifyInstanceAttribute(new ModifyInstanceAttributeRequest
            {
                EnaSupport = <data>,
                InstanceId = "i-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2ModifyInstanceAttribute()
        {
            #region ModifyInstanceAttribute-2

            var client = new AmazonEC2Client();
            var response = client.ModifyInstanceAttribute(new ModifyInstanceAttributeRequest
            {
                InstanceId = "i-1234567890abcdef0",
                InstanceType = <data>
            });


            #endregion
        }

        public void EC2ModifyLaunchTemplate()
        {
            #region ModifyLaunchTemplate-1

            var client = new AmazonEC2Client();
            var response = client.ModifyLaunchTemplate(new ModifyLaunchTemplateRequest
            {
                DefaultVersion = "2",
                LaunchTemplateId = "lt-0abcd290751193123"
            });

            LaunchTemplate launchTemplate = response.LaunchTemplate;

            #endregion
        }

        public void EC2ModifyNetworkInterfaceAttribute()
        {
            #region ModifyNetworkInterfaceAttribute-1

            var client = new AmazonEC2Client();
            var response = client.ModifyNetworkInterfaceAttribute(new ModifyNetworkInterfaceAttributeRequest
            {
                Attachment = new NetworkInterfaceAttachmentChanges {
                    AttachmentId = "eni-attach-43348162",
                    DeleteOnTermination = false
                },
                NetworkInterfaceId = "eni-686ea200"
            });


            #endregion
        }

        public void EC2ModifyNetworkInterfaceAttribute()
        {
            #region ModifyNetworkInterfaceAttribute-2

            var client = new AmazonEC2Client();
            var response = client.ModifyNetworkInterfaceAttribute(new ModifyNetworkInterfaceAttributeRequest
            {
                Description = <data>,
                NetworkInterfaceId = "eni-686ea200"
            });


            #endregion
        }

        public void EC2ModifyNetworkInterfaceAttribute()
        {
            #region ModifyNetworkInterfaceAttribute-3

            var client = new AmazonEC2Client();
            var response = client.ModifyNetworkInterfaceAttribute(new ModifyNetworkInterfaceAttributeRequest
            {
                Groups = new List<string> {
                    "sg-903004f8",
                    "sg-1a2b3c4d"
                },
                NetworkInterfaceId = "eni-686ea200"
            });


            #endregion
        }

        public void EC2ModifyNetworkInterfaceAttribute()
        {
            #region ModifyNetworkInterfaceAttribute-4

            var client = new AmazonEC2Client();
            var response = client.ModifyNetworkInterfaceAttribute(new ModifyNetworkInterfaceAttributeRequest
            {
                NetworkInterfaceId = "eni-686ea200",
                SourceDestCheck = <data>
            });


            #endregion
        }

        public void EC2ModifySnapshotAttribute()
        {
            #region ModifySnapshotAttribute-1

            var client = new AmazonEC2Client();
            var response = client.ModifySnapshotAttribute(new ModifySnapshotAttributeRequest
            {
                Attribute = "createVolumePermission",
                GroupNames = new List<string> {
                    "all"
                },
                OperationType = "add",
                SnapshotId = "snap-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2ModifySnapshotAttribute()
        {
            #region ModifySnapshotAttribute-2

            var client = new AmazonEC2Client();
            var response = client.ModifySnapshotAttribute(new ModifySnapshotAttributeRequest
            {
                Attribute = "createVolumePermission",
                OperationType = "remove",
                SnapshotId = "snap-1234567890abcdef0",
                UserIds = new List<string> {
                    "123456789012"
                }
            });


            #endregion
        }

        public void EC2ModifySpotFleetRequest()
        {
            #region ModifySpotFleetRequest-1

            var client = new AmazonEC2Client();
            var response = client.ModifySpotFleetRequest(new ModifySpotFleetRequestRequest
            {
                SpotFleetRequestId = "sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE",
                TargetCapacity = 20
            });

            bool? @return = response.Return;

            #endregion
        }

        public void EC2ModifySubnetAttribute()
        {
            #region ModifySubnetAttribute-1

            var client = new AmazonEC2Client();
            var response = client.ModifySubnetAttribute(new ModifySubnetAttributeRequest
            {
                MapPublicIpOnLaunch = <data>,
                SubnetId = "subnet-1a2b3c4d"
            });


            #endregion
        }

        public void EC2ModifyVolumeAttribute()
        {
            #region ModifyVolumeAttribute-1

            var client = new AmazonEC2Client();
            var response = client.ModifyVolumeAttribute(new ModifyVolumeAttributeRequest
            {
                AutoEnableIO = <data>,
                DryRun = true,
                VolumeId = "vol-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2ModifyVpcAttribute()
        {
            #region ModifyVpcAttribute-1

            var client = new AmazonEC2Client();
            var response = client.ModifyVpcAttribute(new ModifyVpcAttributeRequest
            {
                EnableDnsSupport = <data>,
                VpcId = "vpc-a01106c2"
            });


            #endregion
        }

        public void EC2ModifyVpcAttribute()
        {
            #region ModifyVpcAttribute-2

            var client = new AmazonEC2Client();
            var response = client.ModifyVpcAttribute(new ModifyVpcAttributeRequest
            {
                EnableDnsHostnames = <data>,
                VpcId = "vpc-a01106c2"
            });


            #endregion
        }

        public void EC2MoveAddressToVpc()
        {
            #region MoveAddressToVpc-1

            var client = new AmazonEC2Client();
            var response = client.MoveAddressToVpc(new MoveAddressToVpcRequest
            {
                PublicIp = "54.123.4.56"
            });

            Status status = response.Status;

            #endregion
        }

        public void EC2RebootInstances()
        {
            #region RebootInstances-1

            var client = new AmazonEC2Client();
            var response = client.RebootInstances(new RebootInstancesRequest
            {
                InstanceIds = new List<string> {
                    "i-1234567890abcdef5"
                }
            });


            #endregion
        }

        public void EC2ReleaseAddress()
        {
            #region ReleaseAddress-1

            var client = new AmazonEC2Client();
            var response = client.ReleaseAddress(new ReleaseAddressRequest
            {
                AllocationId = "eipalloc-64d5890a"
            });


            #endregion
        }

        public void EC2ReplaceNetworkAclAssociation()
        {
            #region ReplaceNetworkAclAssociation-1

            var client = new AmazonEC2Client();
            var response = client.ReplaceNetworkAclAssociation(new ReplaceNetworkAclAssociationRequest
            {
                AssociationId = "aclassoc-e5b95c8c",
                NetworkAclId = "acl-5fb85d36"
            });

            string newAssociationId = response.NewAssociationId;

            #endregion
        }

        public void EC2ReplaceNetworkAclEntry()
        {
            #region ReplaceNetworkAclEntry-1

            var client = new AmazonEC2Client();
            var response = client.ReplaceNetworkAclEntry(new ReplaceNetworkAclEntryRequest
            {
                CidrBlock = "203.0.113.12/24",
                Egress = false,
                NetworkAclId = "acl-5fb85d36",
                PortRange = new PortRange {
                    From = 53,
                    To = 53
                },
                Protocol = "17",
                RuleAction = "allow",
                RuleNumber = 100
            });


            #endregion
        }

        public void EC2ReplaceRoute()
        {
            #region ReplaceRoute-1

            var client = new AmazonEC2Client();
            var response = client.ReplaceRoute(new ReplaceRouteRequest
            {
                DestinationCidrBlock = "10.0.0.0/16",
                GatewayId = "vgw-9a4cacf3",
                RouteTableId = "rtb-22574640"
            });


            #endregion
        }

        public void EC2ReplaceRouteTableAssociation()
        {
            #region ReplaceRouteTableAssociation-1

            var client = new AmazonEC2Client();
            var response = client.ReplaceRouteTableAssociation(new ReplaceRouteTableAssociationRequest
            {
                AssociationId = "rtbassoc-781d0d1a",
                RouteTableId = "rtb-22574640"
            });

            string newAssociationId = response.NewAssociationId;

            #endregion
        }

        public void EC2RequestSpotFleet()
        {
            #region RequestSpotFleet-1

            var client = new AmazonEC2Client();
            var response = client.RequestSpotFleet(new RequestSpotFleetRequest
            {
                SpotFleetRequestConfig = new SpotFleetRequestConfigData {
                    IamFleetRole = "arn:aws:iam::123456789012:role/my-spot-fleet-role",
                    LaunchSpecifications = new List<SpotFleetLaunchSpecification> {
                        new SpotFleetLaunchSpecification {
                            IamInstanceProfile = new IamInstanceProfileSpecification { Arn = "arn:aws:iam::123456789012:instance-profile/my-iam-role" },
                            ImageId = "ami-1a2b3c4d",
                            InstanceType = "m3.medium",
                            KeyName = "my-key-pair",
                            SecurityGroups = new List<GroupIdentifier> {
                                new GroupIdentifier { GroupId = "sg-1a2b3c4d" }
                            },
                            SubnetId = "subnet-1a2b3c4d, subnet-3c4d5e6f"
                        }
                    },
                    SpotPrice = "0.04",
                    TargetCapacity = 2
                }
            });

            string spotFleetRequestId = response.SpotFleetRequestId;

            #endregion
        }

        public void EC2RequestSpotFleet()
        {
            #region RequestSpotFleet-2

            var client = new AmazonEC2Client();
            var response = client.RequestSpotFleet(new RequestSpotFleetRequest
            {
                SpotFleetRequestConfig = new SpotFleetRequestConfigData {
                    IamFleetRole = "arn:aws:iam::123456789012:role/my-spot-fleet-role",
                    LaunchSpecifications = new List<SpotFleetLaunchSpecification> {
                        new SpotFleetLaunchSpecification {
                            IamInstanceProfile = new IamInstanceProfileSpecification { Arn = "arn:aws:iam::123456789012:instance-profile/my-iam-role" },
                            ImageId = "ami-1a2b3c4d",
                            InstanceType = "m3.medium",
                            KeyName = "my-key-pair",
                            Placement = new SpotPlacement { AvailabilityZone = "us-west-2a, us-west-2b" },
                            SecurityGroups = new List<GroupIdentifier> {
                                new GroupIdentifier { GroupId = "sg-1a2b3c4d" }
                            }
                        }
                    },
                    SpotPrice = "0.04",
                    TargetCapacity = 2
                }
            });

            string spotFleetRequestId = response.SpotFleetRequestId;

            #endregion
        }

        public void EC2RequestSpotFleet()
        {
            #region RequestSpotFleet-3

            var client = new AmazonEC2Client();
            var response = client.RequestSpotFleet(new RequestSpotFleetRequest
            {
                SpotFleetRequestConfig = new SpotFleetRequestConfigData {
                    IamFleetRole = "arn:aws:iam::123456789012:role/my-spot-fleet-role",
                    LaunchSpecifications = new List<SpotFleetLaunchSpecification> {
                        new SpotFleetLaunchSpecification {
                            IamInstanceProfile = new IamInstanceProfileSpecification { Arn = "arn:aws:iam::880185128111:instance-profile/my-iam-role" },
                            ImageId = "ami-1a2b3c4d",
                            InstanceType = "m3.medium",
                            KeyName = "my-key-pair",
                            NetworkInterfaces = new List<InstanceNetworkInterfaceSpecification> {
                                new InstanceNetworkInterfaceSpecification {
                                    AssociatePublicIpAddress = true,
                                    DeviceIndex = 0,
                                    Groups = new List<string> {
                                        "sg-1a2b3c4d"
                                    },
                                    SubnetId = "subnet-1a2b3c4d"
                                }
                            }
                        }
                    },
                    SpotPrice = "0.04",
                    TargetCapacity = 2
                }
            });

            string spotFleetRequestId = response.SpotFleetRequestId;

            #endregion
        }

        public void EC2RequestSpotFleet()
        {
            #region RequestSpotFleet-4

            var client = new AmazonEC2Client();
            var response = client.RequestSpotFleet(new RequestSpotFleetRequest
            {
                SpotFleetRequestConfig = new SpotFleetRequestConfigData {
                    AllocationStrategy = "diversified",
                    IamFleetRole = "arn:aws:iam::123456789012:role/my-spot-fleet-role",
                    LaunchSpecifications = new List<SpotFleetLaunchSpecification> {
                        new SpotFleetLaunchSpecification {
                            ImageId = "ami-1a2b3c4d",
                            InstanceType = "c4.2xlarge",
                            SubnetId = "subnet-1a2b3c4d"
                        },
                        new SpotFleetLaunchSpecification {
                            ImageId = "ami-1a2b3c4d",
                            InstanceType = "m3.2xlarge",
                            SubnetId = "subnet-1a2b3c4d"
                        },
                        new SpotFleetLaunchSpecification {
                            ImageId = "ami-1a2b3c4d",
                            InstanceType = "r3.2xlarge",
                            SubnetId = "subnet-1a2b3c4d"
                        }
                    },
                    SpotPrice = "0.70",
                    TargetCapacity = 30
                }
            });

            string spotFleetRequestId = response.SpotFleetRequestId;

            #endregion
        }

        public void EC2RequestSpotInstances()
        {
            #region RequestSpotInstances-1

            var client = new AmazonEC2Client();
            var response = client.RequestSpotInstances(new RequestSpotInstancesRequest
            {
                InstanceCount = 5,
                LaunchSpecification = new LaunchSpecification {
                    IamInstanceProfile = new IamInstanceProfileSpecification { Arn = "arn:aws:iam::123456789012:instance-profile/my-iam-role" },
                    ImageId = "ami-1a2b3c4d",
                    InstanceType = "m3.medium",
                    KeyName = "my-key-pair",
                    Placement = new SpotPlacement { AvailabilityZone = "us-west-2a" },
                },
                SpotPrice = "0.03",
                Type = "one-time"
            });


            #endregion
        }

        public void EC2RequestSpotInstances()
        {
            #region RequestSpotInstances-2

            var client = new AmazonEC2Client();
            var response = client.RequestSpotInstances(new RequestSpotInstancesRequest
            {
                InstanceCount = 5,
                LaunchSpecification = new LaunchSpecification {
                    IamInstanceProfile = new IamInstanceProfileSpecification { Arn = "arn:aws:iam::123456789012:instance-profile/my-iam-role" },
                    ImageId = "ami-1a2b3c4d",
                    InstanceType = "m3.medium",
                    SubnetId = "subnet-1a2b3c4d"
                },
                SpotPrice = "0.050",
                Type = "one-time"
            });


            #endregion
        }

        public void EC2ResetImageAttribute()
        {
            #region ResetImageAttribute-1

            var client = new AmazonEC2Client();
            var response = client.ResetImageAttribute(new ResetImageAttributeRequest
            {
                Attribute = "launchPermission",
                ImageId = "ami-5731123e"
            });


            #endregion
        }

        public void EC2ResetInstanceAttribute()
        {
            #region ResetInstanceAttribute-1

            var client = new AmazonEC2Client();
            var response = client.ResetInstanceAttribute(new ResetInstanceAttributeRequest
            {
                Attribute = "sourceDestCheck",
                InstanceId = "i-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2ResetSnapshotAttribute()
        {
            #region ResetSnapshotAttribute-1

            var client = new AmazonEC2Client();
            var response = client.ResetSnapshotAttribute(new ResetSnapshotAttributeRequest
            {
                Attribute = "createVolumePermission",
                SnapshotId = "snap-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2RunInstances()
        {
            #region RunInstances-1

            var client = new AmazonEC2Client();
            var response = client.RunInstances(new RunInstancesRequest
            {
                BlockDeviceMappings = new List<BlockDeviceMapping> {
                    new BlockDeviceMapping {
                        DeviceName = "/dev/sdh",
                        Ebs = new EbsBlockDevice { VolumeSize = 100 }
                    }
                },
                ImageId = "ami-abc12345",
                InstanceType = "t2.micro",
                KeyName = "my-key-pair",
                MaxCount = 1,
                MinCount = 1,
                SecurityGroupIds = new List<string> {
                    "sg-1a2b3c4d"
                },
                SubnetId = "subnet-6e7f829e",
                TagSpecifications = new List<TagSpecification> {
                    new TagSpecification {
                        ResourceType = "instance",
                        Tags = new List<Tag> {
                            new Tag {
                                Key = "Purpose",
                                Value = "test"
                            }
                        }
                    }
                }
            });


            #endregion
        }

        public void EC2StartInstances()
        {
            #region StartInstances-1

            var client = new AmazonEC2Client();
            var response = client.StartInstances(new StartInstancesRequest
            {
                InstanceIds = new List<string> {
                    "i-1234567890abcdef0"
                }
            });

            List<InstanceStateChange> startingInstances = response.StartingInstances;

            #endregion
        }

        public void EC2StopInstances()
        {
            #region StopInstances-1

            var client = new AmazonEC2Client();
            var response = client.StopInstances(new StopInstancesRequest
            {
                InstanceIds = new List<string> {
                    "i-1234567890abcdef0"
                }
            });

            List<InstanceStateChange> stoppingInstances = response.StoppingInstances;

            #endregion
        }

        public void EC2TerminateInstances()
        {
            #region TerminateInstances-1

            var client = new AmazonEC2Client();
            var response = client.TerminateInstances(new TerminateInstancesRequest
            {
                InstanceIds = new List<string> {
                    "i-1234567890abcdef0"
                }
            });

            List<InstanceStateChange> terminatingInstances = response.TerminatingInstances;

            #endregion
        }

        public void EC2UnassignPrivateIpAddresses()
        {
            #region UnassignPrivateIpAddresses-1

            var client = new AmazonEC2Client();
            var response = client.UnassignPrivateIpAddresses(new UnassignPrivateIpAddressesRequest
            {
                NetworkInterfaceId = "eni-e5aa89a3",
                PrivateIpAddresses = new List<string> {
                    "10.0.0.82"
                }
            });


            #endregion
        }

        public void EC2UpdateSecurityGroupRuleDescriptionsEgress()
        {
            #region UpdateSecurityGroupRuleDescriptionsEgress-1

            var client = new AmazonEC2Client();
            var response = client.UpdateSecurityGroupRuleDescriptionsEgress(new UpdateSecurityGroupRuleDescriptionsEgressRequest
            {
                GroupId = "sg-123abc12",
                IpPermissions = new List<IpPermission> {
                    new IpPermission {
                        FromPort = 80,
                        IpProtocol = "tcp",
                        ToPort = 80
                    }
                }
            });


            #endregion
        }

        public void EC2UpdateSecurityGroupRuleDescriptionsIngress()
        {
            #region UpdateSecurityGroupRuleDescriptionsIngress-1

            var client = new AmazonEC2Client();
            var response = client.UpdateSecurityGroupRuleDescriptionsIngress(new UpdateSecurityGroupRuleDescriptionsIngressRequest
            {
                GroupId = "sg-123abc12",
                IpPermissions = new List<IpPermission> {
                    new IpPermission {
                        FromPort = 22,
                        IpProtocol = "tcp",
                        ToPort = 22
                    }
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
