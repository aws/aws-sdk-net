using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.EC2.Util;

using System.Threading.Tasks;
using Xunit;
using Amazon.Util;


namespace Amazon.DNXCore.IntegrationTests.IntegrationTests.EC2
{
    public class EC2TestHelper
    {

        private static AmazonEC2Client ec2Client;

        public EC2TestHelper()
        {
            AmazonEC2Config config = new AmazonEC2Config
            {
                RegionEndpoint = RegionEndpoint.USEast1
            };
            ec2Client = new AmazonEC2Client(config);
        }

        public async Task deleteSecurityGroupIPPermissionsAsync(string vpcId)
        {
            var vpcGroups = new HashSet<string>();
            var describResponse = await ec2Client.DescribeSecurityGroupsAsync(new DescribeSecurityGroupsRequest());

            foreach (var group in describResponse.SecurityGroups)
            {
                if (group.VpcId == vpcId)
                    vpcGroups.Add(group.GroupId);
            }

            foreach (var group in describResponse.SecurityGroups)
            {
                await deleteSecurityGroupIPPermissionsAsync(group.GroupId, group.IpPermissions, false, vpcGroups);
                await deleteSecurityGroupIPPermissionsAsync(group.GroupId, group.IpPermissionsEgress, true, vpcGroups);
            }
        }

        public async Task deleteSecurityGroupIPPermissionsAsync(string groupId, List<IpPermission> permissions, bool egress, HashSet<string> vpcGroupIds)
        {
            foreach (var permission in permissions)
            {
                foreach (var pair in permission.UserIdGroupPairs)
                {
                    if (!vpcGroupIds.Contains(pair.GroupId))
                        continue;

                    IpPermission spec = new IpPermission()
                    {
                        UserIdGroupPairs = new List<UserIdGroupPair>() { pair },
                        IpRanges = permission.IpRanges,
                        IpProtocol = permission.IpProtocol
                    };

                    try
                    {
                        if (egress)
                        {
                            var revokeRequest = new RevokeSecurityGroupEgressRequest()
                            {
                                GroupId = groupId,
                                IpPermissions = new List<IpPermission>() { spec }
                            };
                            await ec2Client.RevokeSecurityGroupEgressAsync(revokeRequest);
                        }
                        else
                        {
                            var revokeRequest = new RevokeSecurityGroupIngressRequest()
                            {
                                GroupId = groupId,
                                IpPermissions = new List<IpPermission>() { spec }
                            };

                            await ec2Client.RevokeSecurityGroupIngressAsync(revokeRequest);
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unable to delete security group {0}, exception {1}", groupId, e.Message);
                    }
                }
            }
        }

        public async Task deleteNetworkInterfaces(string vpcId)
        {
            try
            {
                var descResponse = await ec2Client.DescribeNetworkInterfacesAsync(new DescribeNetworkInterfacesRequest() { Filters = new List<Filter>() { new Filter() { Name = "vpc-id", Values = new List<string>() { vpcId } } } });

                foreach (var item in descResponse.NetworkInterfaces)
                {
                    if (item.Attachment != null && !string.IsNullOrEmpty(item.Attachment.AttachmentId))
                    {
                        try
                        {
                            await ec2Client.DetachNetworkInterfaceAsync(new DetachNetworkInterfaceRequest() { AttachmentId = item.Attachment.AttachmentId, Force = true });
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Unable to detach network interface {0}, exception {1}", item.Attachment.AttachmentId, e.Message);
                        }
                    }

                    try
                    {
                        await ec2Client.DeleteNetworkInterfaceAsync(new DeleteNetworkInterfaceRequest() { NetworkInterfaceId = item.NetworkInterfaceId });
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Unable to delete network interface {0}, exception {1}", item.NetworkInterfaceId, e.Message);
                    }
                }
            }
            catch (Exception e)
            {
               
            }
        }

        public async Task disassociateRouteTables(string vpcId)
        {
            try
            {
                var descResponse = await ec2Client.DescribeRouteTablesAsync(new DescribeRouteTablesRequest() { Filters = new List<Filter>() { new Filter() { Name = "vpc-id", Values = new List<string>() { vpcId } } } });

                foreach (var item in descResponse.RouteTables)
                {
                    foreach (var association in item.Associations)
                    {
                        try
                        {
                            if (!association.Main)
                            {
                                await ec2Client.DisassociateRouteTableAsync(new DisassociateRouteTableRequest() { AssociationId = association.RouteTableAssociationId });
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Unable to disassociate route table {0}, exception {1}", association.RouteTableAssociationId, e.Message);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to describe route table {0}, exception {1}", vpcId, e.Message);
            }
        }

        // cleans all subelements for a vpc, and then the vpc, created during a test
        public async Task deleteTestVpcAsync(Vpc vpc)
        {
            await deleteTestVpcAsync(vpc.VpcId);
        }

        public async Task deleteTestVpcAsync(string vpcid)
        {
            await terminateAllInstancesInVpcAsync(vpcid);
            AWSSDKUtils.Sleep(1000);
            await disassociateRouteTables(vpcid);
            await deleteSecurityGroupIPPermissionsAsync(vpcid);
            await deleteNetworkInterfaces(vpcid);
            await deleteVpcSecurityGroupsAsync(vpcid);
            await deleteInternetGatewaysAsync(vpcid);
            await deleteSubnetsAsync(vpcid);
            await deleteNetworkAclAsync(vpcid);
            await deleteRouteTablesAsync(vpcid);
            await deleteVpcAsync(vpcid);
        }

      

        /**
         * Deletes VPN gateway
         * 
         * @param vpnGatewayId
         *            id of the gateway to delete
         */
        public async Task deletVpnGatewayAsync(String vpnGatewayId)
        {
            DeleteVpnGatewayRequest request = new DeleteVpnGatewayRequest();
            request.VpnGatewayId = vpnGatewayId;

            await ec2Client.DeleteVpnGatewayAsync(request);
        }

        /**
         * Deletes VPN connection
         * 
         * @param vpnConnectionId
         *            vpn connection id
         */
        public async Task deleteVpnConnectionAsync(String vpnConnectionId)
        {
            DeleteVpnConnectionRequest request = new DeleteVpnConnectionRequest();
            request.VpnConnectionId = vpnConnectionId;

            await ec2Client.DeleteVpnConnectionAsync(request);
        }

        /**
         * Deletes VPC by VPC Id
         * 
         * @param vpcId
         *            VPC id
         */
        public async Task deleteVpcAsync(String vpcId)
        {
            try
            {
                DeleteVpcRequest request = new DeleteVpcRequest();
                request.VpcId = vpcId;
                await ec2Client.DeleteVpcAsync(request);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to delete test vpc {0}, exception {1}", vpcId, e.Message);
            }
        }

        public async Task deleteAllInternetGatewaysAsync()
        {
            var response = await ec2Client.DescribeInternetGatewaysAsync(new DescribeInternetGatewaysRequest());
            foreach (var gateway in response.InternetGateways)
            {
                try
                {
                    await deleteInternetGatewayAsync(gateway.InternetGatewayId);
                }
                catch { }
            }
        }

        public async Task deleteInternetGatewaysAsync(string vpcid)
        {
            var request = new DescribeInternetGatewaysRequest();
            var filter = new Filter { Name = "attachment.vpc-id" };
            filter.Values.Add(vpcid);
            request.Filters.Add(filter);

            var response = await ec2Client.DescribeInternetGatewaysAsync(request);
            foreach (var gateway in response.InternetGateways)
            {
                try
                {
                    await ec2Client.DetachInternetGatewayAsync(new DetachInternetGatewayRequest() { InternetGatewayId = gateway.InternetGatewayId, VpcId = vpcid });
                    await deleteInternetGatewayAsync(gateway.InternetGatewayId);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to delete gateway {0}, exception {1}", gateway.InternetGatewayId, e.Message);
                }
            }
        }

        public async Task deleteInternetGatewayAsync(string gatewayId)
        {
            await ec2Client.DeleteInternetGatewayAsync(new DeleteInternetGatewayRequest { InternetGatewayId = gatewayId });
        }

        public async Task deleteAllAddressAsync()
        {
            DescribeAddressesResponse desResult = await ec2Client.DescribeAddressesAsync(new DescribeAddressesRequest());
            foreach (var address in desResult.Addresses)
            {
                try
                {
                    if (string.IsNullOrEmpty(address.AssociationId))
                    {
                        await ec2Client.DisassociateAddressAsync(new DisassociateAddressRequest { PublicIp = address.PublicIp });
                    }
                    else
                    {
                        await ec2Client.DisassociateAddressAsync(new DisassociateAddressRequest { AssociationId = address.AssociationId });
                    }
                }
                catch { }

                try
                {
                    await ec2Client.ReleaseAddressAsync(new ReleaseAddressRequest { AllocationId = address.AllocationId });
                }
                catch { }
            }
        }

        /**
         * Describe VPC by VPC Id
         * 
         * @param vpcId
         *            VPC Id
         * @return DescribeVpcsResult
         */
        public async Task<DescribeVpcsResponse> describeVpcAsync(String vpcId)
        {
            List<String> ids = new List<String>();

            ids.Add(vpcId);

            return await describeVpcsAsync(ids);
        }

        /**
         * Describe VPC by list of VPC Ids
         * 
         * @param ids
         *            list of VPC ids
         * @return DescribeVpcsResult
         */
        public async Task<DescribeVpcsResponse> describeVpcsAsync(List<String> ids)
        {
            DescribeVpcsRequest request = new DescribeVpcsRequest();
            if (ids != null)
                request.VpcIds = ids;

            return await ec2Client.DescribeVpcsAsync(request);
        }

        public async Task deleteAllVpcSecurityGroupsAsync()
        {
            DescribeSecurityGroupsResponse desResults = await ec2Client.DescribeSecurityGroupsAsync(new DescribeSecurityGroupsRequest());
            foreach (SecurityGroup group in desResults.SecurityGroups)
            {
                if (!string.IsNullOrEmpty(group.VpcId))
                {
                    try
                    {
                        // avoid exception from trying to delete default group from messing up any
                        // genuine errors in test
                        if (group.GroupName != "default")
                            await ec2Client.DeleteSecurityGroupAsync(new DeleteSecurityGroupRequest { GroupId = group.GroupId });
                    }
                    catch { }
                }
            }
        }

        public async Task deleteVpcSecurityGroupsAsync(string vpcid)
        {
            var request = new DescribeSecurityGroupsRequest();
            var filter = new Filter { Name = "vpc-id" };
            filter.Values.Add(vpcid);
            request.Filters.Add(filter);

            DescribeSecurityGroupsResponse desResults = await ec2Client.DescribeSecurityGroupsAsync(request);
            foreach (var group in desResults.SecurityGroups)
            {
                try
                {
                    // avoid exception from trying to delete default group from messing up any
                    // genuine errors in test
                    if (group.GroupName != "default")
                        await ec2Client.DeleteSecurityGroupAsync(new DeleteSecurityGroupRequest { GroupId = group.GroupId });
                }
                catch { }
            }
        }

        /**
         * Deletes ALL Vpc
         * 
         */
        public async Task deleteAllVpcsAsync()
        {
            DescribeVpcsResponse describeResult = await describeVpcsAsync(null);
            foreach (Vpc vpc in describeResult.Vpcs)
            {
                try
                {
                    await deleteTestVpcAsync(vpc.VpcId);
                }
                catch { }
            }
        }

        public async Task deleteAllSubnetsAsync()
        {
            await deleteAllInstancesWithSubnetsAsync();
            foreach (var subnet in (await describeSubnetAsync(null)).Subnets)
            {
                await deleteSubnetAsync(subnet.SubnetId);
            }
        }

        // this expects that all instances have been terminated
        public async Task deleteSubnetsAsync(string vpcid)
        {
            var request = new DescribeSubnetsRequest();
            var filter = new Filter { Name = "vpc-id" };
            filter.Values.Add(vpcid);
            request.Filters.Add(filter);

            foreach (var subnet in (await ec2Client.DescribeSubnetsAsync(request)).Subnets)
            {
                try
                {
                    await deleteSubnetAsync(subnet.SubnetId);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to delete subnet {0}, exception {1}", subnet.SubnetId, e.Message);
                }
            }
        }


        public async Task deleteAllNetworkAclAsync()
        {
            DescribeNetworkAclsResponse describeResponse = await ec2Client.DescribeNetworkAclsAsync(new DescribeNetworkAclsRequest());
            foreach (NetworkAcl acl in describeResponse.NetworkAcls)
            {
                try
                {
                    await ec2Client.DeleteNetworkAclAsync(new DeleteNetworkAclRequest { NetworkAclId = acl.NetworkAclId });
                }
                catch { }
            }
        }

        public async Task deleteNetworkAclAsync(string vpcid)
        {
            var request = new DescribeNetworkAclsRequest();
            var filter = new Filter { Name = "vpc-id" };
            filter.Values.Add(vpcid);
            request.Filters.Add(filter);

            var describeResponse = await ec2Client.DescribeNetworkAclsAsync(request);
            foreach (var acl in describeResponse.NetworkAcls)
            {
                try
                {
                    await ec2Client.DeleteNetworkAclAsync(new DeleteNetworkAclRequest { NetworkAclId = acl.NetworkAclId });
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to delete network acl {0}, exception {1}", acl.NetworkAclId, e.Message);
                }
            }
        }


        public async Task deleteAllInstancesWithSubnetsAsync()
        {
            List<string> ids = new List<string>();
            foreach (var reservation in (await ec2Client.DescribeInstancesAsync(new DescribeInstancesRequest())).Reservations)
            {
                foreach (var instance in reservation.Instances)
                {
                    if (!string.IsNullOrEmpty(instance.SubnetId))
                    {
                        await ec2Client.TerminateInstancesAsync(new TerminateInstancesRequest { InstanceIds = new List<string> { instance.InstanceId } });
                        ids.Add(instance.InstanceId);
                    }
                }
            }

            foreach (string instanceId in ids)
            {
                await waitForInstanceToTransitionToStateAsync(instanceId, "terminated");
            }
        }

        public async Task terminateAllInstancesInVpcAsync(string vpcid)
        {
            var ids = new List<string>();
            var request = new DescribeInstancesRequest();
            var filter = new Filter { Name = "vpc-id" };
            filter.Values.Add(vpcid);
            request.Filters.Add(filter);

            foreach (var reservation in (await ec2Client.DescribeInstancesAsync(request)).Reservations)
            {
                foreach (var instance in reservation.Instances)
                {
                    if (!string.IsNullOrEmpty(instance.SubnetId))
                    {
                        await ec2Client.TerminateInstancesAsync(new TerminateInstancesRequest { InstanceIds = new List<string> { instance.InstanceId } });
                        ids.Add(instance.InstanceId);
                    }
                }
            }

            foreach (var instanceId in ids)
            {
                await waitForInstanceToTransitionToStateAsync(instanceId, "terminated");
            }
        }


        /**
         * Deletes subnet
         * 
         * @param subnetId
         *            subnet id
         */
        public async Task deleteSubnetAsync(String subnetId)
        {
            DeleteSubnetRequest request = new DeleteSubnetRequest();
            request.SubnetId = subnetId;
            await ec2Client.DeleteSubnetAsync(request);
        }

        public async Task deleteAllRouteTables()
        {
            foreach (var table in (await ec2Client.DescribeRouteTablesAsync(new DescribeRouteTablesRequest())).RouteTables)
            {
                try
                {
                    await deleteRouteTableAsync(table);
                }
                catch { }
            }
        }

        public async Task deleteRouteTablesAsync(string vpcid)
        {
            var request = new DescribeRouteTablesRequest();
            var filter = new Filter { Name = "vpc-id" };
            filter.Values.Add(vpcid);
            request.Filters.Add(filter);

            foreach (var table in (await ec2Client.DescribeRouteTablesAsync(request)).RouteTables)
            {
                try
                {
                    await deleteRouteTableAsync(table);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Unable to delete route table {0}, exception {1}", table.RouteTableId, e.Message);
                }
            }
        }


        public async Task deleteRouteTableAsync(RouteTable table)
        {
            foreach (var association in table.Associations)
            {
                if (!association.Main)
                {
                   await ec2Client.DisassociateRouteTableAsync(new DisassociateRouteTableRequest { AssociationId = association.RouteTableAssociationId });
                }
            }
            foreach (var route in table.Routes)
            {
                if (route.GatewayId != "local")
                {
                    await ec2Client.DeleteRouteAsync(new DeleteRouteRequest
                    {
                        RouteTableId = table.RouteTableId,
                        DestinationCidrBlock = route.DestinationCidrBlock
                    });
                }
            }
            await ec2Client.DeleteTagsAsync(new DeleteTagsRequest { Resources = new List<string> { table.RouteTableId } });

            await ec2Client.DeleteRouteTableAsync(new DeleteRouteTableRequest { RouteTableId = table.RouteTableId });
        }

      
        /**
         * Describes subnets
         * 
         * @param subnetId
         *            subnet id
         * @return DescribeSubnetsResult
         */
        public async Task<DescribeSubnetsResponse> describeSubnetAsync(String subnetId)
        {
            List<String> ids = new List<String>();

            ids.Add(subnetId);

            return await describeSubnetsAsync(ids);
        }

        /**
         * Describes subnets given the list of subnet ids
         * 
         * @param subnetIds
         *            subnet ids
         * @return DescribeSubnetsResult
         */
        public async Task<DescribeSubnetsResponse> describeSubnetsAsync(List<String> subnetIds)
        {
            DescribeSubnetsRequest request = new DescribeSubnetsRequest();
            request.SubnetIds = subnetIds;

            return await ec2Client.DescribeSubnetsAsync(request);
        }

        public async Task terminateInstanceAsync(string instanceId)
        {
            TerminateInstancesRequest request = new TerminateInstancesRequest { InstanceIds = new List<string> { instanceId } };
            await ec2Client.TerminateInstancesAsync(request);
        }

        /**
         * Waits for the specified instance to transition to the specified state,
         * otherwise throws a RuntimeException if this method gives up on the
         * instance ever transitioning to that state.
         *
         * @param instanceId
         *            The ID of the instance to wait for.
         * @param state
         *            The expected state for the instance to transition to.
         *
         * @throws Exception
         *             If any problems were encountered while polling the instance's
         *             state, or if this method gives up on the instance ever
         *             transitioning to the expected state.
         */
        public async Task waitForInstanceToTransitionToStateAsync(string instanceId, InstanceStateName state)
        {
            Console.WriteLine("Waiting for instance " + instanceId + " to transition to " + state + "...");

            int count = 0;
            while (true)
            {
                Thread.Sleep(1000 * 5);

                count++;
                Instance runningInstance = (await ec2Client.DescribeInstancesAsync(
                        new DescribeInstancesRequest { InstanceIds = new List<string> { instanceId } }))
                        .Reservations[0].Instances[0];

                if (runningInstance.State.Name == state) return;

                if (count > 100)
                {
                    throw new Exception("Instance " + instanceId + " never transitioned to " + state);
                }
            }
        }

    }
}
