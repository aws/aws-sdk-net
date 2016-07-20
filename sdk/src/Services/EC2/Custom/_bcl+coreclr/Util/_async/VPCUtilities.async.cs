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
using Amazon.Util;
using System.Globalization;
using System.Threading.Tasks;

namespace Amazon.EC2.Util
{
    /// <summary>
    /// This class has utility methods used for setting up a VPC.
    /// </summary>
    public static partial class VPCUtilities
    {
        
        /// <summary>
        /// Find the current VPC NAT image in the region for the AmazonEC2 client.
        /// </summary>
        /// <param name="ec2Client">The ec2client used to look up the image.</param>
        /// <returns>The image</returns>
        public static async Task<Image> FindNATImageAsync(IAmazonEC2 ec2Client)
        {
            if (ec2Client == null)
                throw new ArgumentNullException("ec2Client");

            List<Filter> filters = new List<Filter>()
            {
                new Filter(){Name = "architecture", Values = new List<string>(){"x86_64"}},
                new Filter(){Name = "name", Values = new List<string>(){"ami-vpc-nat-*.x86_64-ebs"}}
            };
            DescribeImagesResponse imageResponse = await ec2Client.DescribeImagesAsync(new DescribeImagesRequest() { Filters = filters }).ConfigureAwait(false);
            var image = imageResponse.Images.OrderByDescending(x => x.Name).FirstOrDefault();

            return image;
        }

        /// <summary>
        /// This method will look up the current VPC NAT ami in the region and create an instance in the subnet specified.
        /// </summary>
        /// <param name="ec2Client">The ec2client used to create the NAT instance</param>
        /// <param name="request">The properties used to launch the NAT instance.</param>
        /// <returns></returns>
        public static async Task<Instance> LaunchNATInstanceAsync(IAmazonEC2 ec2Client, LaunchNATInstanceRequest request)
        {
            if (ec2Client == null)
                throw new ArgumentNullException("ec2Client");
            if (request == null)
                throw new ArgumentNullException("request");
            if (string.IsNullOrEmpty(request.SubnetId))
                throw new InvalidOperationException("request.SubnetId is null");
            if (string.IsNullOrEmpty(request.InstanceType))
                throw new InvalidOperationException("request.InstanceType is null");

            List<Filter> filters = new List<Filter>()
            {
                new Filter(){Name = "architecture", Values = new List<string>(){"x86_64"}},
                new Filter(){Name = "name", Values = new List<string>(){"ami-vpc-nat-*.x86_64-ebs"}}
            };
            DescribeImagesResponse imageResponse = await ec2Client.DescribeImagesAsync(new DescribeImagesRequest() { Filters = filters }).ConfigureAwait(false);
            var image = await FindNATImageAsync(ec2Client).ConfigureAwait(false);
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
            RunInstancesResponse runResponse = await ec2Client.RunInstancesAsync(runRequest).ConfigureAwait(false);
            string instanceId = runResponse.Reservation.Instances[0].InstanceId;
            // Can't associated elastic IP address until the instance is available
            await WaitForInstanceToStartUpAsync(ec2Client, instanceId).ConfigureAwait(false);

            ModifyInstanceAttributeRequest modifyRequest = new ModifyInstanceAttributeRequest()
            {
                InstanceId = instanceId,
                Attribute = "sourceDestCheck",
                Value = "false"
            };
            await ec2Client.ModifyInstanceAttributeAsync(modifyRequest).ConfigureAwait(false);

            await ec2Client.CreateTagsAsync(new CreateTagsRequest()
            {
                Resources = new List<string>() { instanceId },
                Tags = new List<Tag>() { new Tag() { Key = "Name", Value = "NAT" } }
            }).ConfigureAwait(false);

            AllocateAddressResponse allocateAddressResponse = await ec2Client.AllocateAddressAsync(new AllocateAddressRequest() { Domain = "vpc" }).ConfigureAwait(false);
            var allocationId = allocateAddressResponse.AllocationId;
            await ec2Client.AssociateAddressAsync(new AssociateAddressRequest() { InstanceId = instanceId, AllocationId = allocationId }).ConfigureAwait(false);

            DescribeInstancesResponse describeInstancesResponse = await ec2Client.DescribeInstancesAsync(new DescribeInstancesRequest() { InstanceIds = new List<string>() { instanceId } }).ConfigureAwait(false);
            var instance = describeInstancesResponse.Reservations[0].Instances[0];

            return instance;
        }

        /// <summary>
        /// This method will create a VPC with a subnet that will have an internet gateway attached making instances available to the internet.
        /// </summary>
        /// <param name="ec2Client">The ec2client used to create the VPC</param>
        /// <param name="request">The properties used to create the VPC.</param>
        /// <returns>The response contains all the VPC objects that were created.</returns>
        public static async Task<LaunchVPCWithPublicSubnetResponse> LaunchVPCWithPublicSubnetAsync(IAmazonEC2 ec2Client, LaunchVPCWithPublicSubnetRequest request)
        {
            LaunchVPCWithPublicSubnetResponse response = new LaunchVPCWithPublicSubnetResponse();
            await LaunchVPCWithPublicSubnetAsync(ec2Client, request, response).ConfigureAwait(false);
            return response;
        }

        /// <summary>
        /// This method will create a VPC with a subnet that will have an internet gateway attached making instances available to the internet.
        /// </summary>
        /// <param name="ec2Client">The ec2client used to create the VPC</param>
        /// <param name="request">The properties used to create the VPC.</param>
        /// <param name="response">The response contains all the VPC objects that were created.</param>
        private static async Task LaunchVPCWithPublicSubnetAsync(IAmazonEC2 ec2Client, LaunchVPCWithPublicSubnetRequest request, LaunchVPCWithPublicSubnetResponse response)
        {
            CreateVpcResponse createVpcResponse = await ec2Client.CreateVpcAsync(new CreateVpcRequest()
            {
                CidrBlock = request.VPCCidrBlock,
                InstanceTenancy = request.InstanceTenancy
            }).ConfigureAwait(false);

            response.VPC = createVpcResponse.Vpc;
            WriteProgress(request.ProgressCallback, "Created vpc {0}", response.VPC.VpcId);

            var describeVPCRequest = new DescribeVpcsRequest() { VpcIds = new List<string>() { response.VPC.VpcId } };
            DescribeVpcsResponse describeVpcsResponse = await ec2Client.DescribeVpcsAsync(describeVPCRequest).ConfigureAwait(false);

            WaitTillTrue(((Func<bool>)(() => describeVpcsResponse.Vpcs.Count == 1)));

            if(!string.IsNullOrEmpty(request.VPCName))
            {
                await ec2Client.CreateTagsAsync(new CreateTagsRequest()
                {
                    Resources = new List<string>(){ response.VPC.VpcId}, 
                    Tags = new List<Tag>(){new Tag(){Key = "Name", Value = request.VPCName}}
                }).ConfigureAwait(false);
            }

            CreateSubnetResponse createSubnetResponse = await ec2Client.CreateSubnetAsync(new CreateSubnetRequest()
            {
                AvailabilityZone = request.PublicSubnetAvailabilityZone,
                CidrBlock = request.PublicSubnetCiderBlock,
                VpcId = response.VPC.VpcId
            }).ConfigureAwait(false);
            response.PublicSubnet = createSubnetResponse.Subnet;
            WriteProgress(request.ProgressCallback, "Created public subnet {0}", response.PublicSubnet.SubnetId);

            DescribeSubnetsResponse describeSubnetsResponse = await ec2Client.DescribeSubnetsAsync(new DescribeSubnetsRequest() { SubnetIds = new List<string>() { response.PublicSubnet.SubnetId } }).ConfigureAwait(false);

            WaitTillTrue(((Func<bool>)(() => (describeSubnetsResponse.Subnets.Count == 1))));

            await ec2Client.CreateTagsAsync(new CreateTagsRequest()
            {
                Resources = new List<string>() { response.PublicSubnet.SubnetId },
                Tags = new List<Tag>() { new Tag() { Key = "Name", Value = "Public" } }
            }).ConfigureAwait(false);

            CreateInternetGatewayResponse createInternetGatewayResponse = await ec2Client.CreateInternetGatewayAsync(new CreateInternetGatewayRequest() { }).ConfigureAwait(false);

            response.InternetGateway = createInternetGatewayResponse.InternetGateway;
            WriteProgress(request.ProgressCallback, "Created internet gateway {0}", response.InternetGateway.InternetGatewayId);

           await ec2Client.AttachInternetGatewayAsync(new AttachInternetGatewayRequest()
            {
                InternetGatewayId = response.InternetGateway.InternetGatewayId,
                VpcId = response.VPC.VpcId
            }).ConfigureAwait(false);
            WriteProgress(request.ProgressCallback, "Attached internet gateway to vpc");

            CreateRouteTableResponse createRouteTableResponse = await ec2Client.CreateRouteTableAsync(new CreateRouteTableRequest()
            {
                VpcId = response.VPC.VpcId
            }).ConfigureAwait(false);
            response.PublicSubnetRouteTable = createRouteTableResponse.RouteTable;
            WriteProgress(request.ProgressCallback, "Created route table {0}", response.PublicSubnetRouteTable.RouteTableId);

            var describeRouteTableRequest = new DescribeRouteTablesRequest() { RouteTableIds = new List<string>() { response.PublicSubnetRouteTable.RouteTableId } };
            DescribeRouteTablesResponse describeRouteTablesResponse = await ec2Client.DescribeRouteTablesAsync(describeRouteTableRequest).ConfigureAwait(false);
            WaitTillTrue(((Func<bool>)(() => (describeRouteTablesResponse.RouteTables.Count == 1))));

           await ec2Client.CreateTagsAsync(new CreateTagsRequest()
            {
                Resources = new List<string>() { response.PublicSubnetRouteTable.RouteTableId },
                Tags = new List<Tag>() { new Tag() { Key = "Name", Value = "Public" } }
            }).ConfigureAwait(false);

            await ec2Client.AssociateRouteTableAsync(new AssociateRouteTableRequest()
            {
                RouteTableId = response.PublicSubnetRouteTable.RouteTableId,
                SubnetId = response.PublicSubnet.SubnetId
            }).ConfigureAwait(false);
            WriteProgress(request.ProgressCallback, "Associated route table to public subnet");

            await ec2Client.CreateRouteAsync(new CreateRouteRequest()
            {
                DestinationCidrBlock = "0.0.0.0/0",
                GatewayId = response.InternetGateway.InternetGatewayId,
                RouteTableId = response.PublicSubnetRouteTable.RouteTableId
            }).ConfigureAwait(false);
            WriteProgress(request.ProgressCallback, "Added route for internet gateway to route table {0}", response.PublicSubnetRouteTable.RouteTableId);
            
            describeRouteTablesResponse = await ec2Client.DescribeRouteTablesAsync(describeRouteTableRequest).ConfigureAwait(false);
            response.PublicSubnetRouteTable = describeRouteTablesResponse.RouteTables[0];
        }

        /// <summary>
        /// This method will create a VPC, a public subnet, private subnet and a NAT EC2 instance to allow EC2 instances in the private
        /// subnet to establish outbound connections to the internet.
        /// </summary>
        /// <param name="ec2Client">The ec2client used to create the VPC</param>
        /// <param name="request">The properties used to create the VPC.</param>
        /// <returns>The response contains all the VPC objects that were created.</returns>
        public static async Task<LaunchVPCWithPublicAndPrivateSubnetsResponse> LaunchVPCWithPublicAndPrivateSubnetsAsync(IAmazonEC2 ec2Client, LaunchVPCWithPublicAndPrivateSubnetsRequest request)
        {
            LaunchVPCWithPublicAndPrivateSubnetsResponse response = new LaunchVPCWithPublicAndPrivateSubnetsResponse();

            await LaunchVPCWithPublicSubnetAsync(ec2Client, request, response).ConfigureAwait(false);

            CreateSubnetResponse createSubnetResponse = await ec2Client.CreateSubnetAsync(new CreateSubnetRequest()
            {
                AvailabilityZone = request.PrivateSubnetAvailabilityZone ?? response.PublicSubnet.AvailabilityZone,
                CidrBlock = request.PrivateSubnetCiderBlock,
                VpcId = response.VPC.VpcId
            }).ConfigureAwait(false);
            response.PrivateSubnet = createSubnetResponse.Subnet;
            WriteProgress(request.ProgressCallback, "Created private subnet {0}", response.PublicSubnet.SubnetId);


            DescribeSubnetsResponse describeSubnetsResponse = await ec2Client.DescribeSubnetsAsync(new DescribeSubnetsRequest() { SubnetIds = new List<string>() { response.PrivateSubnet.SubnetId } }).ConfigureAwait(false);
            WaitTillTrue(((Func<bool>)(() => (describeSubnetsResponse.Subnets.Count == 1))));

            await ec2Client.CreateTagsAsync(new CreateTagsRequest()
            {
                Resources = new List<string>() { response.PrivateSubnet.SubnetId },
                Tags = new List<Tag>() { new Tag() { Key = "Name", Value = "Private" } }
            }).ConfigureAwait(false);

            WriteProgress(request.ProgressCallback, "Launching NAT instance");
            response.NATInstance = await LaunchNATInstanceAsync(ec2Client, new LaunchNATInstanceRequest()
            {
                InstanceType = request.InstanceType,
                KeyName = request.KeyName,
                SubnetId = response.PublicSubnet.SubnetId
            }).ConfigureAwait(false);
            WriteProgress(request.ProgressCallback, "NAT instance is available");

            var defaultRouteTable = await GetDefaultRouteTableAsync(ec2Client, response.VPC.VpcId).ConfigureAwait(false);
            if (defaultRouteTable == null)
                throw new AmazonEC2Exception("No default route table found for VPC");
            await ec2Client.CreateRouteAsync(new CreateRouteRequest()
            {
                RouteTableId = defaultRouteTable.RouteTableId,
                DestinationCidrBlock = "0.0.0.0/0",
                InstanceId = response.NATInstance.InstanceId
            }).ConfigureAwait(false);
            WriteProgress(request.ProgressCallback, "Added route to the NAT instance in the default route table");

            if (request.ConfigureDefaultVPCGroupForNAT)
            {
                var defaultSecurityGroup = await GetDefaultSecurityGroupAsync(ec2Client, response.VPC.VpcId).ConfigureAwait(false);
                CreateSecurityGroupResponse createSecurityGroupResponse = await ec2Client.CreateSecurityGroupAsync(new CreateSecurityGroupRequest()
                {
                    VpcId = response.VPC.VpcId,
                    GroupName = "NATGroup",
                    Description = "Give EC2 Instances access through the NAT"
                }).ConfigureAwait(false);

                var groupId = createSecurityGroupResponse.GroupId;
                WriteProgress(request.ProgressCallback, "Created security group for NAT configuration");


                IpPermission spec = new IpPermission
                {
                    IpProtocol = "-1",
                    IpRanges = new List<string>{ "0.0.0.0/0"},
                    UserIdGroupPairs = new List<UserIdGroupPair>() { new UserIdGroupPair() { GroupId = groupId } }
                };

                await ec2Client.AuthorizeSecurityGroupIngressAsync(new AuthorizeSecurityGroupIngressRequest()
                {
                    IpPermissions = new List<IpPermission>() { spec },
                    GroupId = defaultSecurityGroup.GroupId
                }).ConfigureAwait(false);
                WriteProgress(request.ProgressCallback, "Added permission to the default security group {0} to allow traffic from security group {1}", defaultSecurityGroup.GroupId, groupId);

                DescribeSecurityGroupsResponse describeSecurityGroupsResponse = await ec2Client.DescribeSecurityGroupsAsync(new DescribeSecurityGroupsRequest()
                {
                    GroupIds = new List<string>() { groupId }
                }).ConfigureAwait(false);
                response.NATSecurityGroup = describeSecurityGroupsResponse.SecurityGroups[0];
            }

            return response;
        }

        private static async Task<RouteTable> GetDefaultRouteTableAsync(IAmazonEC2 ec2Client, string vpcId)
        {
            var filters = new List<Filter>() 
            { 
                new Filter() { Name = "vpc-id", Values = new List<string>() { vpcId } },
                new Filter() { Name = "association.main", Values = new List<string>() { "true" } } 
            };

            var response = await ec2Client.DescribeRouteTablesAsync(new DescribeRouteTablesRequest() { Filters = filters }).ConfigureAwait(false);
            if (response.RouteTables.Count != 1)
                return null;

            return response.RouteTables[0];
        }

        private static async Task<SecurityGroup> GetDefaultSecurityGroupAsync(IAmazonEC2 ec2Client, string vpcId)
        {
            var filters = new List<Filter>() 
            { 
                new Filter() { Name = "vpc-id", Values = new List<string>() { vpcId } },
                new Filter() { Name = "group-name", Values = new List<string>() { "default" } } 
            };

            var response = await ec2Client.DescribeSecurityGroupsAsync(new DescribeSecurityGroupsRequest() { Filters = filters }).ConfigureAwait(false);
            if (response.SecurityGroups.Count != 1)
                return null;

            return response.SecurityGroups[0];
        }


        private static async Task<Instance> WaitForInstanceToStartUpAsync(IAmazonEC2 ec2Client, string instanceId)
        {
            var describeRequest = new DescribeInstancesRequest() { InstanceIds = new List<string>() { instanceId } };
            for (int tries = 0; tries < 40; tries++)
            {
                AWSSDKUtils.Sleep(10 * 1000);

                var result = await ec2Client.DescribeInstancesAsync(describeRequest).ConfigureAwait(false);
                if (result.Reservations.Count != 1 && result.Reservations[0].Instances.Count != 1)
                    return null;

                Instance instance = result.Reservations[0].Instances[0];

                // Return the updated instance object if we're out of pending
                if (!instance.State.Name.Equals("pending"))
                {
                    return instance;
                }
            }

            return null;
        }

    }
}
