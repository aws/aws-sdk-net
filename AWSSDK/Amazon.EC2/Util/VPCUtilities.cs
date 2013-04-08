/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2010-11-15
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using Amazon.EC2.Model;

namespace Amazon.EC2.Util
{
    /// <summary>
    /// This class has utility methods used for setting up a VPC.
    /// </summary>
    public static class VPCUtilities
    {
        /// <summary>
        /// A callback delegate used to get progress messages as the VPC environment is being created.
        /// </summary>
        public delegate void Progress(string message);

        /// <summary>
        /// This method will look up the current VPC NAT ami in the region and create an instance in the subnet specified.
        /// </summary>
        /// <param name="ec2Client">The ec2client used to create the NAT instance</param>
        /// <param name="request">The properties used to launch the NAT instance.</param>
        /// <returns></returns>
        public static RunningInstance LaunchNATInstance(AmazonEC2 ec2Client, LaunchNATInstanceRequest request)
        {
            if (ec2Client == null)
                throw new ArgumentNullException("ec2Client");
            if (request == null)
                throw new ArgumentNullException("request");
            if (string.IsNullOrEmpty(request.SubnetId))
                throw new ArgumentNullException("request.SubnetId");
            if (string.IsNullOrEmpty(request.InstanceType))
                throw new ArgumentNullException("request.InstanceType");

            List<Filter> filters = new List<Filter>()
            {
                new Filter(){Name = "architecture", Value = new List<string>(){"x86_64"}},
                new Filter(){Name = "name", Value = new List<string>(){"ami-vpc-nat-*.x86_64-ebs"}}
            };
            DescribeImagesResponse imageResponse = ec2Client.DescribeImages(new DescribeImagesRequest() { Filter = filters });
            var image = ImageUtilities.FindImage(ec2Client, ImageUtilities.VPC_NAT);
            if (image == null)
            {
                throw new AmazonEC2Exception("No NAT image found in this region");
            }

            RunInstancesRequest runRequest = new RunInstancesRequest()
            {
                InstanceType = request.InstanceType,
                KeyName = request.KeyName,
                ImageId = image.ImageId,
                MinCount = 1,
                MaxCount = 1,
                SubnetId = request.SubnetId
            };
            RunInstancesResponse runResponse = ec2Client.RunInstances(runRequest);
            string instanceId = runResponse.RunInstancesResult.Reservation.RunningInstance[0].InstanceId;
            // Can't associated elastic IP address until the instance is available
            WaitForInstanceToStartUp(ec2Client, instanceId);

            ModifyInstanceAttributeRequest modifyRequest = new ModifyInstanceAttributeRequest()
            {
                InstanceId = instanceId,
                Attribute = "sourceDestCheck",
                Value = "false"
            };
            ec2Client.ModifyInstanceAttribute(modifyRequest);

            ec2Client.CreateTags(new CreateTagsRequest()
            {
                ResourceId = new List<string>() { instanceId },
                Tag = new List<Tag>() { new Tag() { Key = "Name", Value = "NAT" } }
            });

            var allocationId = ec2Client.AllocateAddress(new AllocateAddressRequest() { Domain = "vpc" }).AllocateAddressResult.AllocationId;
            ec2Client.AssociateAddress(new AssociateAddressRequest() { InstanceId = instanceId, AllocationId = allocationId });

            var instance = ec2Client.DescribeInstances(new DescribeInstancesRequest() { InstanceId = new List<string>() { instanceId } }).DescribeInstancesResult.Reservation[0].RunningInstance[0];

            return instance;
        }


        /// <summary>
        /// This method will create a VPC with a subnet that will have an internet gateway attached making instances available to the internet.
        /// </summary>
        /// <param name="ec2Client">The ec2client used to create the VPC</param>
        /// <param name="request">The properties used to create the VPC.</param>
        /// <returns>The response contains all the VPC objects that were created.</returns>
        public static LaunchVPCWithPublicSubnetResponse LaunchVPCWithPublicSubnet(AmazonEC2 ec2Client, LaunchVPCWithPublicSubnetRequest request)
        {
            LaunchVPCWithPublicSubnetResponse response = new LaunchVPCWithPublicSubnetResponse();
            LaunchVPCWithPublicSubnet(ec2Client, request, response);
            return response;
        }

        /// <summary>
        /// This method will create a VPC with a subnet that will have an internet gateway attached making instances available to the internet.
        /// </summary>
        /// <param name="ec2Client">The ec2client used to create the VPC</param>
        /// <param name="request">The properties used to create the VPC.</param>
        /// <param name="response">The response contains all the VPC objects that were created.</param>
        private static void LaunchVPCWithPublicSubnet(AmazonEC2 ec2Client, LaunchVPCWithPublicSubnetRequest request, LaunchVPCWithPublicSubnetResponse response)
        {
            response.VPC = ec2Client.CreateVpc(new CreateVpcRequest()
            {
                CidrBlock = request.VPCCidrBlock,
                InstanceTenancy = request.InstanceTenancy
            }).CreateVpcResult.Vpc;
            WriteProgress(request.ProgressCallback, "Created vpc {0}", response.VPC.VpcId);

            var describeVPCRequest = new DescribeVpcsRequest() { VpcId = new List<string>() { response.VPC.VpcId } };
            WaitTillTrue(((Func<bool>)(() => ec2Client.DescribeVpcs(describeVPCRequest).DescribeVpcsResult.Vpc.Count == 1)));

            if(!string.IsNullOrEmpty(request.VPCName))
            {
                ec2Client.CreateTags(new CreateTagsRequest()
                {
                    ResourceId = new List<string>(){ response.VPC.VpcId}, 
                    Tag = new List<Tag>(){new Tag(){Key = "Name", Value = request.VPCName}}
                });
            }

            response.PublicSubnet = ec2Client.CreateSubnet(new CreateSubnetRequest()
            {
                AvailabilityZone = request.PublicSubnetAvailabilityZone,
                CidrBlock = request.PublicSubnetCiderBlock,
                VpcId = response.VPC.VpcId
            }).CreateSubnetResult.Subnet;
            WriteProgress(request.ProgressCallback, "Created public subnet {0}", response.PublicSubnet.SubnetId);

            WaitTillTrue(((Func<bool>)(() => (ec2Client.DescribeSubnets(new DescribeSubnetsRequest() { SubnetId = new List<string>() { response.PublicSubnet.SubnetId } }).DescribeSubnetsResult.Subnet.Count == 1))));

            ec2Client.CreateTags(new CreateTagsRequest()
            {
                ResourceId = new List<string>() { response.PublicSubnet.SubnetId },
                Tag = new List<Tag>() { new Tag() { Key = "Name", Value = "Public" } }
            });

            response.InternetGateway = ec2Client.CreateInternetGateway(new CreateInternetGatewayRequest()
            {
            }).CreateInternetGatewayResult.InternetGateway;
            WriteProgress(request.ProgressCallback, "Created internet gateway {0}", response.InternetGateway.InternetGatewayId);

            ec2Client.AttachInternetGateway(new AttachInternetGatewayRequest()
            {
                InternetGatewayId = response.InternetGateway.InternetGatewayId,
                VpcId = response.VPC.VpcId
            });
            WriteProgress(request.ProgressCallback, "Attached internet gateway to vpc");

            response.PublicSubnetRouteTable = ec2Client.CreateRouteTable(new CreateRouteTableRequest()
            {
                VpcId = response.VPC.VpcId
            }).CreateRouteTableResult.RouteTable;
            WriteProgress(request.ProgressCallback, "Created route table {0}", response.PublicSubnetRouteTable.RouteTableId);

            var describeRouteTableRequest = new DescribeRouteTablesRequest() { RouteTableId = new List<string>() { response.PublicSubnetRouteTable.RouteTableId } };
            WaitTillTrue(((Func<bool>)(() => (ec2Client.DescribeRouteTables(describeRouteTableRequest).DescribeRouteTablesResult.RouteTables.Count == 1))));

            ec2Client.CreateTags(new CreateTagsRequest()
            {
                ResourceId = new List<string>() { response.PublicSubnetRouteTable.RouteTableId },
                Tag = new List<Tag>() { new Tag() { Key = "Name", Value = "Public" } }
            });

            ec2Client.AssociateRouteTable(new AssociateRouteTableRequest()
            {
                RouteTableId = response.PublicSubnetRouteTable.RouteTableId,
                SubnetId = response.PublicSubnet.SubnetId
            });
            WriteProgress(request.ProgressCallback, "Associated route table to public subnet");

            ec2Client.CreateRoute(new CreateRouteRequest()
            {
                DestinationCidrBlock = "0.0.0.0/0",
                GatewayId = response.InternetGateway.InternetGatewayId,
                RouteTableId = response.PublicSubnetRouteTable.RouteTableId
            });
            WriteProgress(request.ProgressCallback, "Added route for internet gateway to route table {0}", response.PublicSubnetRouteTable.RouteTableId);

            response.PublicSubnetRouteTable = ec2Client.DescribeRouteTables(describeRouteTableRequest).DescribeRouteTablesResult.RouteTables[0];
        }

        /// <summary>
        /// This method will create a VPC, a public subnet, private subnet and a NAT EC2 instance to allow EC2 instances in the private
        /// subnet to establish outbound connections to the internet.
        /// </summary>
        /// <param name="ec2Client">The ec2client used to create the VPC</param>
        /// <param name="request">The properties used to create the VPC.</param>
        /// <returns>The response contains all the VPC objects that were created.</returns>
        public static LaunchVPCWithPublicAndPrivateSubnetsResponse LaunchVPCWithPublicAndPrivateSubnets(AmazonEC2 ec2Client, LaunchVPCWithPublicAndPrivateSubnetsRequest request)
        {
            LaunchVPCWithPublicAndPrivateSubnetsResponse response = new LaunchVPCWithPublicAndPrivateSubnetsResponse();

            LaunchVPCWithPublicSubnet(ec2Client, request, response);

            response.PrivateSubnet = ec2Client.CreateSubnet(new CreateSubnetRequest()
            {
                AvailabilityZone = request.PrivateSubnetAvailabilityZone ?? response.PublicSubnet.AvailabilityZone,
                CidrBlock = request.PrivateSubnetCiderBlock,
                VpcId = response.VPC.VpcId
            }).CreateSubnetResult.Subnet;
            WriteProgress(request.ProgressCallback, "Created private subnet {0}", response.PublicSubnet.SubnetId);

            WaitTillTrue(((Func<bool>)(() => (ec2Client.DescribeSubnets(new DescribeSubnetsRequest(){SubnetId = new List<string>(){response.PrivateSubnet.SubnetId}}).DescribeSubnetsResult.Subnet.Count == 1))));

            ec2Client.CreateTags(new CreateTagsRequest()
            {
                ResourceId = new List<string>() { response.PrivateSubnet.SubnetId },
                Tag = new List<Tag>() { new Tag() { Key = "Name", Value = "Private" } }
            });

            WriteProgress(request.ProgressCallback, "Launching NAT instance");
            response.NATInstance = LaunchNATInstance(ec2Client, new LaunchNATInstanceRequest()
            {
                InstanceType = request.InstanceType,
                KeyName = request.KeyName,
                SubnetId = response.PublicSubnet.SubnetId
            });
            WriteProgress(request.ProgressCallback, "NAT instance is available");

            var defaultRouteTable = GetDefaultRouteTable(ec2Client, response.VPC.VpcId);
            if (defaultRouteTable == null)
                throw new AmazonEC2Exception("No default route table found for VPC");
            ec2Client.CreateRoute(new CreateRouteRequest()
            {
                RouteTableId = defaultRouteTable.RouteTableId,
                DestinationCidrBlock = "0.0.0.0/0",
                InstanceId = response.NATInstance.InstanceId
            });
            WriteProgress(request.ProgressCallback, "Added route to the NAT instance in the default route table");

            if (request.ConfigureDefaultVPCGroupForNAT)
            {
                var defaultSecurityGroup = GetDefaultSecurityGroup(ec2Client, response.VPC.VpcId);
                var groupId = ec2Client.CreateSecurityGroup(new CreateSecurityGroupRequest()
                {
                    VpcId = response.VPC.VpcId,
                    GroupName = "NATGroup",
                    GroupDescription = "Give EC2 Instances access through the NAT"
                }).CreateSecurityGroupResult.GroupId;
                WriteProgress(request.ProgressCallback, "Created security group for NAT configuration");


                IpPermissionSpecification spec = new IpPermissionSpecification()
                {
                    IpProtocol = "-1",
                    IpRanges = new List<string>(){"0.0.0.0/0"},
                    Groups = new List<UserIdGroupPair>() { new UserIdGroupPair() { GroupId = groupId } }
                };

                ec2Client.AuthorizeSecurityGroupIngress(new AuthorizeSecurityGroupIngressRequest()
                {
                    IpPermissions = new List<IpPermissionSpecification>(){spec},
                    GroupId = defaultSecurityGroup.GroupId
                });
                WriteProgress(request.ProgressCallback, "Added permission to the default security group {0} to allow traffic from security group {1}", defaultSecurityGroup.GroupId, groupId);

                response.NATSecurityGroup = ec2Client.DescribeSecurityGroups(new DescribeSecurityGroupsRequest() 
                { 
                    GroupId = new List<string>(){ groupId }
                }).DescribeSecurityGroupsResult.SecurityGroup[0];
            }

            return response;
        }

        private static RouteTable GetDefaultRouteTable(AmazonEC2 ec2Client, string vpcId)
        {
            var filters = new List<Filter>() 
            { 
                new Filter() { Name = "vpc-id", Value = new List<string>() { vpcId } },
                new Filter() { Name = "association.main", Value = new List<string>() { "true" } } 
            };

            var response = ec2Client.DescribeRouteTables(new DescribeRouteTablesRequest() { Filter = filters });
            if (response.DescribeRouteTablesResult.RouteTables.Count != 1)
                return null;

            return response.DescribeRouteTablesResult.RouteTables[0];
        }

        private static SecurityGroup GetDefaultSecurityGroup(AmazonEC2 ec2Client, string vpcId)
        {
            var filters = new List<Filter>() 
            { 
                new Filter() { Name = "vpc-id", Value = new List<string>() { vpcId } },
                new Filter() { Name = "group-name", Value = new List<string>() { "default" } } 
            };

            var response = ec2Client.DescribeSecurityGroups(new DescribeSecurityGroupsRequest() { Filter = filters });
            if (response.DescribeSecurityGroupsResult.SecurityGroup.Count != 1)
                return null;

            return response.DescribeSecurityGroupsResult.SecurityGroup[0];
        }


        private static RunningInstance WaitForInstanceToStartUp(AmazonEC2 ec2Client, string instanceId)
        {
            var describeRequest = new DescribeInstancesRequest() { InstanceId = new List<string>() { instanceId } };
            for (int tries = 0; tries < 40; tries++)
            {
                Thread.Sleep(10 * 1000);

                var result = ec2Client.DescribeInstances(describeRequest).DescribeInstancesResult;
                if (result.Reservation.Count != 1 && result.Reservation[0].RunningInstance.Count != 1)
                    return null;

                RunningInstance instance = result.Reservation[0].RunningInstance[0];

                // Return the updated instance object if we're out of pending
                if (!instance.InstanceState.Name.Equals("pending"))
                {
                    return instance;
                }
            }

            return null;
        }

        private static void WaitTillTrue(Func<bool> func)
        {
            for(int i = 0; i < 40; i++)
            {
                try
                {
                    if (func())
                        return;
                }
                catch { }
                Thread.Sleep(1000);
            }
        }

        private static void WriteProgress(Progress callback, string message, params string[] args)
        {
            if (callback == null)
                return;

            callback(string.Format(message, args));
        }
    }
}
