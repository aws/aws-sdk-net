using System;
using System.Collections.Generic;
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
            #region ec2-allocate-address-1

            var client = new AmazonEC2Client();
            var response = client.AllocateAddress(new AllocateAddressRequest 
            {
            });

            string allocationId = response.AllocationId;
            string domain = response.Domain;
            string networkBorderGroup = response.NetworkBorderGroup;
            string publicIp = response.PublicIp;
            string publicIpv4Pool = response.PublicIpv4Pool;

            #endregion
        }

        public void EC2AssignPrivateIpAddresses()
        {
            #region ec2-assign-private-ip-addresses-1

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
            #region ec2-assign-private-ip-addresses-2

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
            #region ec2-associate-address-1

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
            #region ec2-associate-address-2

            var client = new AmazonEC2Client();
            var response = client.AssociateAddress(new AssociateAddressRequest 
            {
                AllocationId = "eipalloc-64d5890a",
                NetworkInterfaceId = "eni-1a2b3c4d"
            });

            string associationId = response.AssociationId;

            #endregion
        }

        public void EC2AssociateDhcpOptions()
        {
            #region ec2-associate-dhcp-options-1

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
            #region ec2-associate-dhcp-options-2

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
            #region to-associate-an-iam-instance-profile-with-an-instance-1528928429850

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
            #region ec2-associate-route-table-1

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
            #region ec2-attach-internet-gateway-1

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
            #region ec2-attach-network-interface-1

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
            #region to-attach-a-volume-to-an-instance-1472499213109

            var client = new AmazonEC2Client();
            var response = client.AttachVolume(new AttachVolumeRequest 
            {
                Device = "/dev/sdf",
                InstanceId = "i-01474ef662b89480",
                VolumeId = "vol-1234567890abcdef0"
            });

            DateTime attachTime = response.AttachTime;
            string device = response.Device;
            string instanceId = response.InstanceId;
            string state = response.State;
            string volumeId = response.VolumeId;

            #endregion
        }

        public void EC2AuthorizeSecurityGroupEgress()
        {
            #region to-add-a-rule-that-allows-outbound-traffic-to-a-specific-address-range-1528929309636

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
            #region to-add-a-rule-that-allows-outbound-traffic-to-a-specific-security-group-1528929760260

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
            #region to-add-a-rule-that-allows-inbound-ssh-traffic-1529011610328

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
            #region to-add-a-rule-that-allows-inbound-http-traffic-from-another-security-group-1529012163168

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
            #region to-add-a-rule-with-a-description-1529012418116

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
            #region ec2-cancel-spot-fleet-requests-1

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
            #region ec2-cancel-spot-fleet-requests-2

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
            #region ec2-cancel-spot-instance-requests-1

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
            #region to-confirm-the-product-instance-1472712108494

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
            #region to-copy-an-ami-to-another-region-1529022820832

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
            #region to-copy-a-snapshot-1472502259774

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

        public void EC2CreateCustomerGateway()
        {
            #region ec2-create-customer-gateway-1

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
            #region ec2-create-dhcp-options-1

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

        public void EC2CreateImage()
        {
            #region to-create-an-ami-from-an-amazon-ebs-backed-instance-1529023150636

            var client = new AmazonEC2Client();
            var response = client.CreateImage(new CreateImageRequest 
            {
                BlockDeviceMappings = new List<BlockDeviceMapping> {
                    new BlockDeviceMapping {
                        DeviceName = "/dev/sdh",
                        Ebs = new EbsBlockDevice { VolumeSize = 100 }
                    },
                    new BlockDeviceMapping {
                        DeviceName = "/dev/sdc",
                        VirtualName = "ephemeral1"
                    }
                },
                Description = "An AMI for my server",
                InstanceId = "i-1234567890abcdef0",
                Name = "My server",
                NoReboot = true
            });

            string imageId = response.ImageId;

            #endregion
        }

        public void EC2CreateInternetGateway()
        {
            #region ec2-create-internet-gateway-1

            var client = new AmazonEC2Client();
            var response = client.CreateInternetGateway(new CreateInternetGatewayRequest 
            {
            });

            InternetGateway internetGateway = response.InternetGateway;

            #endregion
        }

        public void EC2CreateKeyPair()
        {
            #region ec2-create-key-pair-1

            var client = new AmazonEC2Client();
            var response = client.CreateKeyPair(new CreateKeyPairRequest 
            {
                KeyName = "my-key-pair"
            });


            #endregion
        }

        public void EC2CreateLaunchTemplate()
        {
            #region to-create-a-launch-template-1529023655488

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
            #region to-create-a-launch-template-version-1529024195702

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
            #region ec2-create-nat-gateway-1

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
            #region ec2-create-network-acl-1

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
            #region ec2-create-network-acl-entry-1

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

        public void EC2CreateNetworkInterface()
        {
            #region ec2-create-network-interface-1

            var client = new AmazonEC2Client();
            var response = client.CreateNetworkInterface(new CreateNetworkInterfaceRequest 
            {
                Description = "my network interface",
                Groups = new List<string> {
                    "sg-903004f8"
                },
                PrivateIpAddress = "10.0.2.17",
                SubnetId = "subnet-9d4a7b6c"
            });

            NetworkInterface networkInterface = response.NetworkInterface;

            #endregion
        }

        public void EC2CreatePlacementGroup()
        {
            #region to-create-a-placement-group-1472712245768

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
            #region ec2-create-route-1

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
            #region ec2-create-route-table-1

            var client = new AmazonEC2Client();
            var response = client.CreateRouteTable(new CreateRouteTableRequest 
            {
                VpcId = "vpc-a01106c2"
            });

            RouteTable routeTable = response.RouteTable;

            #endregion
        }

        public void EC2CreateSecurityGroup()
        {
            #region to-create-a-security-group-for-a-vpc-1529024532716

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
            #region to-create-a-snapshot-1472502529790

            var client = new AmazonEC2Client();
            var response = client.CreateSnapshot(new CreateSnapshotRequest 
            {
                Description = "This is my root volume snapshot.",
                VolumeId = "vol-1234567890abcdef0"
            });

            string description = response.Description;
            string ownerId = response.OwnerId;
            string snapshotId = response.SnapshotId;
            DateTime startTime = response.StartTime;
            string state = response.State;
            List<Tag> tags = response.Tags;
            string volumeId = response.VolumeId;
            int volumeSize = response.VolumeSize;

            #endregion
        }

        public void EC2CreateSpotDatafeedSubscription()
        {
            #region ec2-create-spot-datafeed-subscription-1

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
            #region ec2-create-subnet-1

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
            #region ec2-create-tags-1

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
            #region to-create-a-new-volume-1472496724296

            var client = new AmazonEC2Client();
            var response = client.CreateVolume(new CreateVolumeRequest 
            {
                AvailabilityZone = "us-east-1a",
                Size = 80,
                VolumeType = "gp2"
            });

            string availabilityZone = response.AvailabilityZone;
            DateTime createTime = response.CreateTime;
            bool encrypted = response.Encrypted;
            int iops = response.Iops;
            int size = response.Size;
            string snapshotId = response.SnapshotId;
            string state = response.State;
            string volumeId = response.VolumeId;
            string volumeType = response.VolumeType;

            #endregion
        }

        public void EC2CreateVolume()
        {
            #region to-create-a-new-provisioned-iops-ssd-volume-from-a-snapshot-1472498975176

            var client = new AmazonEC2Client();
            var response = client.CreateVolume(new CreateVolumeRequest 
            {
                AvailabilityZone = "us-east-1a",
                Iops = 1000,
                SnapshotId = "snap-066877671789bd71b",
                VolumeType = "io1"
            });

            List<VolumeAttachment> attachments = response.Attachments;
            string availabilityZone = response.AvailabilityZone;
            DateTime createTime = response.CreateTime;
            int iops = response.Iops;
            int size = response.Size;
            string snapshotId = response.SnapshotId;
            string state = response.State;
            List<Tag> tags = response.Tags;
            string volumeId = response.VolumeId;
            string volumeType = response.VolumeType;

            #endregion
        }

        public void EC2CreateVpc()
        {
            #region ec2-create-vpc-1

            var client = new AmazonEC2Client();
            var response = client.CreateVpc(new CreateVpcRequest 
            {
                CidrBlock = "10.0.0.0/16"
            });

            Vpc vpc = response.Vpc;

            #endregion
        }

        public void EC2DeleteCustomerGateway()
        {
            #region ec2-delete-customer-gateway-1

            var client = new AmazonEC2Client();
            var response = client.DeleteCustomerGateway(new DeleteCustomerGatewayRequest 
            {
                CustomerGatewayId = "cgw-0e11f167"
            });


            #endregion
        }

        public void EC2DeleteDhcpOptions()
        {
            #region ec2-delete-dhcp-options-1

            var client = new AmazonEC2Client();
            var response = client.DeleteDhcpOptions(new DeleteDhcpOptionsRequest 
            {
                DhcpOptionsId = "dopt-d9070ebb"
            });


            #endregion
        }

        public void EC2DeleteInternetGateway()
        {
            #region ec2-delete-internet-gateway-1

            var client = new AmazonEC2Client();
            var response = client.DeleteInternetGateway(new DeleteInternetGatewayRequest 
            {
                InternetGatewayId = "igw-c0a643a9"
            });


            #endregion
        }

        public void EC2DeleteKeyPair()
        {
            #region ec2-delete-key-pair-1

            var client = new AmazonEC2Client();
            var response = client.DeleteKeyPair(new DeleteKeyPairRequest 
            {
                KeyName = "my-key-pair"
            });


            #endregion
        }

        public void EC2DeleteLaunchTemplate()
        {
            #region to-delete-a-launch-template-1529024658216

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
            #region to-delete-a-launch-template-version-1529024790864

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
            #region ec2-delete-nat-gateway-1

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
            #region ec2-delete-network-acl-1

            var client = new AmazonEC2Client();
            var response = client.DeleteNetworkAcl(new DeleteNetworkAclRequest 
            {
                NetworkAclId = "acl-5fb85d36"
            });


            #endregion
        }

        public void EC2DeleteNetworkAclEntry()
        {
            #region ec2-delete-network-acl-entry-1

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
            #region ec2-delete-network-interface-1

            var client = new AmazonEC2Client();
            var response = client.DeleteNetworkInterface(new DeleteNetworkInterfaceRequest 
            {
                NetworkInterfaceId = "eni-e5aa89a3"
            });


            #endregion
        }

        public void EC2DeletePlacementGroup()
        {
            #region to-delete-a-placement-group-1472712349959

            var client = new AmazonEC2Client();
            var response = client.DeletePlacementGroup(new DeletePlacementGroupRequest 
            {
                GroupName = "my-cluster"
            });


            #endregion
        }

        public void EC2DeleteRoute()
        {
            #region ec2-delete-route-1

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
            #region ec2-delete-route-table-1

            var client = new AmazonEC2Client();
            var response = client.DeleteRouteTable(new DeleteRouteTableRequest 
            {
                RouteTableId = "rtb-22574640"
            });


            #endregion
        }

        public void EC2DeleteSecurityGroup()
        {
            #region to-delete-a-security-group-1529024952972

            var client = new AmazonEC2Client();
            var response = client.DeleteSecurityGroup(new DeleteSecurityGroupRequest 
            {
                GroupId = "sg-903004f8"
            });


            #endregion
        }

        public void EC2DeleteSnapshot()
        {
            #region to-delete-a-snapshot-1472503042567

            var client = new AmazonEC2Client();
            var response = client.DeleteSnapshot(new DeleteSnapshotRequest 
            {
                SnapshotId = "snap-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2DeleteSpotDatafeedSubscription()
        {
            #region ec2-delete-spot-datafeed-subscription-1

            var client = new AmazonEC2Client();
            var response = client.DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest 
            {
            });


            #endregion
        }

        public void EC2DeleteSubnet()
        {
            #region ec2-delete-subnet-1

            var client = new AmazonEC2Client();
            var response = client.DeleteSubnet(new DeleteSubnetRequest 
            {
                SubnetId = "subnet-9d4a7b6c"
            });


            #endregion
        }

        public void EC2DeleteTags()
        {
            #region ec2-delete-tags-1

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
            #region to-delete-a-volume-1472503111160

            var client = new AmazonEC2Client();
            var response = client.DeleteVolume(new DeleteVolumeRequest 
            {
                VolumeId = "vol-049df61146c4d7901"
            });


            #endregion
        }

        public void EC2DeleteVpc()
        {
            #region ec2-delete-vpc-1

            var client = new AmazonEC2Client();
            var response = client.DeleteVpc(new DeleteVpcRequest 
            {
                VpcId = "vpc-a01106c2"
            });


            #endregion
        }

        public void EC2DescribeAccountAttributes()
        {
            #region ec2-describe-account-attributes-1

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
            #region ec2-describe-account-attributes-2

            var client = new AmazonEC2Client();
            var response = client.DescribeAccountAttributes(new DescribeAccountAttributesRequest 
            {
            });

            List<AccountAttribute> accountAttributes = response.AccountAttributes;

            #endregion
        }

        public void EC2DescribeAddresses()
        {
            #region ec2-describe-addresses-1

            var client = new AmazonEC2Client();
            var response = client.DescribeAddresses(new DescribeAddressesRequest 
            {
            });

            List<Address> addresses = response.Addresses;

            #endregion
        }

        public void EC2DescribeAvailabilityZones()
        {
            #region ec2-describe-availability-zones-1

            var client = new AmazonEC2Client();
            var response = client.DescribeAvailabilityZones(new DescribeAvailabilityZonesRequest 
            {
            });

            List<AvailabilityZone> availabilityZones = response.AvailabilityZones;

            #endregion
        }

        public void EC2DescribeCustomerGateways()
        {
            #region ec2-describe-customer-gateways-1

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
            #region ec2-describe-dhcp-options-1

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
            #region to-describe-an-iam-instance-profile-association-1529025123918

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
            #region to-describe-the-launch-permissions-for-an-ami-1529025296264

            var client = new AmazonEC2Client();
            var response = client.DescribeImageAttribute(new DescribeImageAttributeRequest 
            {
                Attribute = "launchPermission",
                ImageId = "ami-5731123e"
            });

            string imageId = response.ImageId;
            List<LaunchPermission> launchPermissions = response.LaunchPermissions;

            #endregion
        }

        public void EC2DescribeImages()
        {
            #region to-describe-an-ami-1529025482866

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
            #region to-describe-the-instance-type-1472712432132

            var client = new AmazonEC2Client();
            var response = client.DescribeInstanceAttribute(new DescribeInstanceAttributeRequest 
            {
                Attribute = "instanceType",
                InstanceId = "i-1234567890abcdef0"
            });

            string instanceId = response.InstanceId;
            string instanceType = response.InstanceType;

            #endregion
        }

        public void EC2DescribeInstanceAttribute()
        {
            #region to-describe-the-disableapitermination-attribute-1472712533466

            var client = new AmazonEC2Client();
            var response = client.DescribeInstanceAttribute(new DescribeInstanceAttributeRequest 
            {
                Attribute = "disableApiTermination",
                InstanceId = "i-1234567890abcdef0"
            });

            bool disableApiTermination = response.DisableApiTermination;
            string instanceId = response.InstanceId;

            #endregion
        }

        public void EC2DescribeInstanceAttribute()
        {
            #region to-describe-the-block-device-mapping-for-an-instance-1472712645423

            var client = new AmazonEC2Client();
            var response = client.DescribeInstanceAttribute(new DescribeInstanceAttributeRequest 
            {
                Attribute = "blockDeviceMapping",
                InstanceId = "i-1234567890abcdef0"
            });

            List<InstanceBlockDeviceMapping> blockDeviceMappings = response.BlockDeviceMappings;
            string instanceId = response.InstanceId;

            #endregion
        }

        public void EC2DescribeInstances()
        {
            #region to-describe-an-amazon-ec2-instance-1529025982172

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
            #region to-describe-the-instances-with-the-instance-type-t2micro-1529026147602

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

        public void EC2DescribeInstances()
        {
            #region to-describe-the-instances-with-a-specific-tag-1529026251928

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

        public void EC2DescribeInstanceStatus()
        {
            #region to-describe-the-status-of-an-instance-1529025696830

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
            #region ec2-describe-internet-gateways-1

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
            #region ec2-describe-key-pairs-1

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
            #region to-describe-a-launch-template-1529344182862

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
            #region to-describe-the-versions-for-a-launch-template-1529344425048

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
            #region ec2-describe-moving-addresses-1

            var client = new AmazonEC2Client();
            var response = client.DescribeMovingAddresses(new DescribeMovingAddressesRequest 
            {
            });

            List<MovingAddressStatus> movingAddressStatuses = response.MovingAddressStatuses;

            #endregion
        }

        public void EC2DescribeNatGateways()
        {
            #region ec2-describe-nat-gateways-1

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
            #region ec2-

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
            #region ec2-describe-network-interface-attribute-1

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
            #region ec2-describe-network-interface-attribute-2

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
            #region ec2-describe-network-interface-attribute-3

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
            #region ec2-describe-network-interface-attribute-4

            var client = new AmazonEC2Client();
            var response = client.DescribeNetworkInterfaceAttribute(new DescribeNetworkInterfaceAttributeRequest 
            {
                Attribute = "sourceDestCheck",
                NetworkInterfaceId = "eni-686ea200"
            });

            string networkInterfaceId = response.NetworkInterfaceId;
            bool sourceDestCheck = response.SourceDestCheck;

            #endregion
        }

        public void EC2DescribeNetworkInterfaces()
        {
            #region ec2-describe-network-interfaces-1

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
            #region ec2-describe-regions-1

            var client = new AmazonEC2Client();
            var response = client.DescribeRegions(new DescribeRegionsRequest 
            {
            });

            List<Region> regions = response.Regions;

            #endregion
        }

        public void EC2DescribeRouteTables()
        {
            #region ec2-describe-route-tables-1

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

        public void EC2DescribeSecurityGroupReferences()
        {
            #region to-describe-security-group-references-1529354312088

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
            #region to-describe-a-security-group-1529354426314

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
            #region to-describe-a-tagged-security-group-1529354553880

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
            #region to-describe-snapshot-attributes-1472503199736

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
            #region to-describe-a-snapshot-1472503807850

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
            #region to-describe-snapshots-using-filters-1472503929793

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
            #region ec2-describe-spot-datafeed-subscription-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSpotDatafeedSubscription(new DescribeSpotDatafeedSubscriptionRequest 
            {
            });

            SpotDatafeedSubscription spotDatafeedSubscription = response.SpotDatafeedSubscription;

            #endregion
        }

        public void EC2DescribeSpotFleetInstances()
        {
            #region ec2-describe-spot-fleet-instances-1

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
            #region ec2-describe-spot-fleet-request-history-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSpotFleetRequestHistory(new DescribeSpotFleetRequestHistoryRequest 
            {
                SpotFleetRequestId = "sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE",
                StartTime = new DateTime(2015, 5, 26, 12, 0, 0, DateTimeKind.Utc)
            });

            List<HistoryRecord> historyRecords = response.HistoryRecords;
            string nextToken = response.NextToken;
            string spotFleetRequestId = response.SpotFleetRequestId;
            DateTime startTime = response.StartTime;

            #endregion
        }

        public void EC2DescribeSpotFleetRequests()
        {
            #region ec2-describe-spot-fleet-requests-1

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
            #region ec2-describe-spot-instance-requests-1

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
            #region ec2-describe-spot-price-history-1

            var client = new AmazonEC2Client();
            var response = client.DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest 
            {
                EndTime = new DateTime(2014, 1, 6, 8, 9, 10, DateTimeKind.Utc),
                InstanceTypes = new List<string> {
                    "m1.xlarge"
                },
                ProductDescriptions = new List<string> {
                    "Linux/UNIX (Amazon VPC)"
                },
                StartTime = new DateTime(2014, 1, 6, 7, 8, 9, DateTimeKind.Utc)
            });

            List<SpotPrice> spotPriceHistory = response.SpotPriceHistory;

            #endregion
        }

        public void EC2DescribeSubnets()
        {
            #region ec2-describe-subnets-1

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
            #region ec2-describe-tags-1

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
            #region to-describe-a-volume-attribute-1472505773492

            var client = new AmazonEC2Client();
            var response = client.DescribeVolumeAttribute(new DescribeVolumeAttributeRequest 
            {
                Attribute = "autoEnableIO",
                VolumeId = "vol-049df61146c4d7901"
            });

            bool autoEnableIO = response.AutoEnableIO;
            string volumeId = response.VolumeId;

            #endregion
        }

        public void EC2DescribeVolumes()
        {
            #region to-describe-all-volumes-1472506358883

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
            #region to-describe-volumes-that-are-attached-to-a-specific-instance-1472506613578

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
            #region to-describe-the-status-of-a-single-volume-1472507016193

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
            #region to-describe-the-status-of-impaired-volumes-1472507239821

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
            #region ec2-describe-vpc-attribute-1

            var client = new AmazonEC2Client();
            var response = client.DescribeVpcAttribute(new DescribeVpcAttributeRequest 
            {
                Attribute = "enableDnsSupport",
                VpcId = "vpc-a01106c2"
            });

            bool enableDnsSupport = response.EnableDnsSupport;
            string vpcId = response.VpcId;

            #endregion
        }

        public void EC2DescribeVpcAttribute()
        {
            #region ec2-describe-vpc-attribute-2

            var client = new AmazonEC2Client();
            var response = client.DescribeVpcAttribute(new DescribeVpcAttributeRequest 
            {
                Attribute = "enableDnsHostnames",
                VpcId = "vpc-a01106c2"
            });

            bool enableDnsHostnames = response.EnableDnsHostnames;
            string vpcId = response.VpcId;

            #endregion
        }

        public void EC2DescribeVpcs()
        {
            #region ec2-describe-vpcs-1

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
            #region ec2-detach-internet-gateway-1

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
            #region ec2-detach-network-interface-1

            var client = new AmazonEC2Client();
            var response = client.DetachNetworkInterface(new DetachNetworkInterfaceRequest 
            {
                AttachmentId = "eni-attach-66c4350a"
            });


            #endregion
        }

        public void EC2DetachVolume()
        {
            #region to-detach-a-volume-from-an-instance-1472507977694

            var client = new AmazonEC2Client();
            var response = client.DetachVolume(new DetachVolumeRequest 
            {
                VolumeId = "vol-1234567890abcdef0"
            });

            DateTime attachTime = response.AttachTime;
            string device = response.Device;
            string instanceId = response.InstanceId;
            string state = response.State;
            string volumeId = response.VolumeId;

            #endregion
        }

        public void EC2DisableVgwRoutePropagation()
        {
            #region ec2-disable-vgw-route-propagation-1

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
            #region ec2-disassociate-address-1

            var client = new AmazonEC2Client();
            var response = client.DisassociateAddress(new DisassociateAddressRequest 
            {
                AssociationId = "eipassoc-2bebb745"
            });


            #endregion
        }

        public void EC2DisassociateIamInstanceProfile()
        {
            #region to-disassociate-an-iam-instance-profile-1529355364478

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
            #region ec2-disassociate-route-table-1

            var client = new AmazonEC2Client();
            var response = client.DisassociateRouteTable(new DisassociateRouteTableRequest 
            {
                AssociationId = "rtbassoc-781d0d1a"
            });


            #endregion
        }

        public void EC2EnableVgwRoutePropagation()
        {
            #region ec2-enable-vgw-route-propagation-1

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
            #region to-enable-io-for-a-volume-1472508114867

            var client = new AmazonEC2Client();
            var response = client.EnableVolumeIO(new EnableVolumeIORequest 
            {
                VolumeId = "vol-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2GetConsoleOutput()
        {
            #region to-get-the-console-output-1529355683194

            var client = new AmazonEC2Client();
            var response = client.GetConsoleOutput(new GetConsoleOutputRequest 
            {
                InstanceId = "i-1234567890abcdef0"
            });

            string instanceId = response.InstanceId;
            string output = response.Output;
            DateTime timestamp = response.Timestamp;

            #endregion
        }

        public void EC2GetLaunchTemplateData()
        {
            #region to-get-the-launch-template-data-for-an-instance--1529356515702

            var client = new AmazonEC2Client();
            var response = client.GetLaunchTemplateData(new GetLaunchTemplateDataRequest 
            {
                InstanceId = "0123d646e8048babc"
            });

            ResponseLaunchTemplateData launchTemplateData = response.LaunchTemplateData;

            #endregion
        }

        public void EC2ModifyImageAttribute()
        {
            #region to-make-an-ami-public-1529357395278

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

        public void EC2ModifyImageAttribute()
        {
            #region to-grant-launch-permissions-1529357727906

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

        public void EC2ModifyInstanceAttribute()
        {
            #region to-modify-the-instance-type-1529357844378

            var client = new AmazonEC2Client();
            var response = client.ModifyInstanceAttribute(new ModifyInstanceAttributeRequest 
            {
                InstanceId = "i-1234567890abcdef0",
                InstanceType = <data>
            });


            #endregion
        }

        public void EC2ModifyInstanceAttribute()
        {
            #region to-enable-enhanced-networking-1529358279870

            var client = new AmazonEC2Client();
            var response = client.ModifyInstanceAttribute(new ModifyInstanceAttributeRequest 
            {
                EnaSupport = jsondata object,
                InstanceId = "i-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2ModifyLaunchTemplate()
        {
            #region to-change-the-default-version-of-a-launch-template-1529358440364

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
            #region ec2-modify-network-interface-attribute-1

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
            #region ec2-modify-network-interface-attribute-2

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
            #region ec2-modify-network-interface-attribute-3

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
            #region ec2-modify-network-interface-attribute-4

            var client = new AmazonEC2Client();
            var response = client.ModifyNetworkInterfaceAttribute(new ModifyNetworkInterfaceAttributeRequest 
            {
                NetworkInterfaceId = "eni-686ea200",
                SourceDestCheck = jsondata object
            });


            #endregion
        }

        public void EC2ModifySnapshotAttribute()
        {
            #region to-modify-a-snapshot-attribute-1472508385907

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

        public void EC2ModifySnapshotAttribute()
        {
            #region to-make-a-snapshot-public-1472508470529

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

        public void EC2ModifySpotFleetRequest()
        {
            #region ec2-modify-spot-fleet-request-1

            var client = new AmazonEC2Client();
            var response = client.ModifySpotFleetRequest(new ModifySpotFleetRequestRequest 
            {
                SpotFleetRequestId = "sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE",
                TargetCapacity = 20
            });

            bool return = response.Return;

            #endregion
        }

        public void EC2ModifySpotFleetRequest()
        {
            #region ec2-modify-spot-fleet-request-2

            var client = new AmazonEC2Client();
            var response = client.ModifySpotFleetRequest(new ModifySpotFleetRequestRequest 
            {
                ExcessCapacityTerminationPolicy = "NoTermination ",
                SpotFleetRequestId = "sfr-73fbd2ce-aa30-494c-8788-1cee4EXAMPLE",
                TargetCapacity = 10
            });

            bool return = response.Return;

            #endregion
        }

        public void EC2ModifySubnetAttribute()
        {
            #region ec2-modify-subnet-attribute-1

            var client = new AmazonEC2Client();
            var response = client.ModifySubnetAttribute(new ModifySubnetAttributeRequest 
            {
                MapPublicIpOnLaunch = jsondata object,
                SubnetId = "subnet-1a2b3c4d"
            });


            #endregion
        }

        public void EC2ModifyVolumeAttribute()
        {
            #region to-modify-a-volume-attribute-1472508596749

            var client = new AmazonEC2Client();
            var response = client.ModifyVolumeAttribute(new ModifyVolumeAttributeRequest 
            {
                AutoEnableIO = jsondata object,
                DryRun = true,
                VolumeId = "vol-1234567890abcdef0"
            });


            #endregion
        }

        public void EC2ModifyVpcAttribute()
        {
            #region ec2-modify-vpc-attribute-1

            var client = new AmazonEC2Client();
            var response = client.ModifyVpcAttribute(new ModifyVpcAttributeRequest 
            {
                EnableDnsSupport = jsondata object,
                VpcId = "vpc-a01106c2"
            });


            #endregion
        }

        public void EC2ModifyVpcAttribute()
        {
            #region ec2-modify-vpc-attribute-2

            var client = new AmazonEC2Client();
            var response = client.ModifyVpcAttribute(new ModifyVpcAttributeRequest 
            {
                EnableDnsHostnames = jsondata object,
                VpcId = "vpc-a01106c2"
            });


            #endregion
        }

        public void EC2MoveAddressToVpc()
        {
            #region ec2-move-address-to-vpc-1

            var client = new AmazonEC2Client();
            var response = client.MoveAddressToVpc(new MoveAddressToVpcRequest 
            {
                PublicIp = "54.123.4.56"
            });

            string status = response.Status;

            #endregion
        }

        public void EC2RebootInstances()
        {
            #region to-reboot-an-ec2-instance-1529358566382

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
            #region ec2-release-address-1

            var client = new AmazonEC2Client();
            var response = client.ReleaseAddress(new ReleaseAddressRequest 
            {
                AllocationId = "eipalloc-64d5890a"
            });


            #endregion
        }

        public void EC2ReplaceNetworkAclAssociation()
        {
            #region ec2-replace-network-acl-association-1

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
            #region ec2-replace-network-acl-entry-1

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
            #region ec2-replace-route-1

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
            #region ec2-replace-route-table-association-1

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
            #region ec2-request-spot-fleet-1

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
            #region ec2-request-spot-fleet-2

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
            #region ec2-request-spot-fleet-3

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
            #region ec2-request-spot-fleet-4

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
            #region ec2-request-spot-instances-1

            var client = new AmazonEC2Client();
            var response = client.RequestSpotInstances(new RequestSpotInstancesRequest 
            {
                InstanceCount = 5,
                LaunchSpecification = new RequestSpotLaunchSpecification {
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
            #region ec2-request-spot-instances-2

            var client = new AmazonEC2Client();
            var response = client.RequestSpotInstances(new RequestSpotInstancesRequest 
            {
                InstanceCount = 5,
                LaunchSpecification = new RequestSpotLaunchSpecification {
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
            #region to-reset-the-launchpermission-attribute-1529359519534

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
            #region to-reset-the-sourcedestcheck-attribute-1529359630708

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
            #region to-reset-a-snapshot-attribute-1472508825735

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
            #region to-launch-an-instance-1529360150806

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
            #region to-start-a-stopped-ec2-instance-1529358792730

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
            #region to-stop-a-running-ec2-instance-1529358905540

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
            #region to-terminate-an-ec2-instance-1529359350660

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
            #region ec2-unassign-private-ip-addresses-1

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
            #region to-update-an-outbound-security-group-rule-description-1529360481544

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
            #region to-update-an-inbound-security-group-rule-description-1529360820372

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

        
        # region ISample Members
        public virtual void Run()
        {

        }
        # endregion

    }
}