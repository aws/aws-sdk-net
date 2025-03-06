using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

using Amazon.EC2;
using Amazon.EC2.Model;

using System.Threading.Tasks;
using Xunit;
using Amazon.Util;


namespace Amazon.DNXCore.IntegrationTests.IntegrationTests.EC2
{
    public class EC2TestHelper
    {
        private AmazonEC2Client _ec2Client;

        public EC2TestHelper(AmazonEC2Client client)
        {
            _ec2Client = client;
        }

        public async Task deleteSecurityGroupIPPermissionsAsync(string vpcId)
        {
            var describeResponse = await _ec2Client.DescribeSecurityGroupsAsync(new DescribeSecurityGroupsRequest{
                Filters = { new Filter("vpc-id", new List<string> { vpcId }) }
            });

            foreach (var group in describeResponse.SecurityGroups)
            {

                if (group.IpPermissions.Count != 0)
                {
                    await _ec2Client.RevokeSecurityGroupIngressAsync(new RevokeSecurityGroupIngressRequest
                    {
                        GroupId = group.GroupId,
                        IpPermissions = group.IpPermissions
                    });
                }
                if (group.IpPermissionsEgress.Count != 0)
                {
                    await _ec2Client.RevokeSecurityGroupEgressAsync(new RevokeSecurityGroupEgressRequest{
                        GroupId = group.GroupId,
                        IpPermissions = group.IpPermissionsEgress
                    });
                }
            }

            foreach (var group in describeResponse.SecurityGroups)
            {
                if (string.Compare(group.GroupName, "default") != 0)
                {
                    await _ec2Client.DeleteSecurityGroupAsync(new DeleteSecurityGroupRequest { GroupId = group.GroupId });
                }
            }
        }

        public async Task deleteNetworkInterfaces(string vpcId)
        {
            var descResponse = await _ec2Client.DescribeNetworkInterfacesAsync(new DescribeNetworkInterfacesRequest() { Filters = new List<Filter>() { new Filter() { Name = "vpc-id", Values = new List<string>() { vpcId } } } });

            foreach (var item in descResponse.NetworkInterfaces)
            {
                if (item.Attachment != null && !string.IsNullOrEmpty(item.Attachment.AttachmentId))
                {
                    await _ec2Client.DetachNetworkInterfaceAsync(new DetachNetworkInterfaceRequest() { AttachmentId = item.Attachment.AttachmentId, Force = true });
                }

                await _ec2Client.DeleteNetworkInterfaceAsync(new DeleteNetworkInterfaceRequest() { NetworkInterfaceId = item.NetworkInterfaceId });
            }
        }
        
        // cleans all subelements for a vpc, and then the vpc, created during a test
        public async Task deleteTestVpcAsync(Vpc vpc)
        {
            await deleteTestVpcAsync(vpc.VpcId);
        }

        public async Task deleteTestVpcAsync(string vpcid)
        {
            await terminateVPCInstanceAsync(vpcid);

            AWSSDKUtils.Sleep(1000);

            await disassociateAndDeleteDhcpOptionSet(vpcid);
            await deleteSubnetsAsync(vpcid);
            await detachAndDeleteInternetGatewaysAsync(vpcid);
            await disassociateAndDeleteRouteTables(vpcid);
            await deleteSecurityGroupIPPermissionsAsync(vpcid);
            await deleteNetworkInterfaces(vpcid);            
            await deleteNetworkAclAsync(vpcid);
            await deleteVpcAsync(vpcid);
        }

        public async Task disassociateAndDeleteDhcpOptionSet(string vpcid)
        {
            DescribeVpcsResponse response = await _ec2Client.DescribeVpcsAsync(new DescribeVpcsRequest {
                VpcIds = new List<string>{ vpcid }
            });
            string dhcpOptionsId = response.Vpcs[0].DhcpOptionsId;

            await _ec2Client.AssociateDhcpOptionsAsync(new AssociateDhcpOptionsRequest {
                VpcId = vpcid,
                DhcpOptionsId = "default"
            });

            await _ec2Client.DeleteDhcpOptionsAsync(new DeleteDhcpOptionsRequest{DhcpOptionsId = dhcpOptionsId});
        }

        /**
         * Deletes VPC by VPC Id
         * 
         * @param vpcId
         *            VPC id
         */
        public Task deleteVpcAsync(String vpcId)
        {
            return _ec2Client.DeleteVpcAsync(new DeleteVpcRequest{ VpcId = vpcId});
        }


        public async Task detachAndDeleteInternetGatewaysAsync(string vpcid)
        {
            var request = new DescribeInternetGatewaysRequest();
            var filter = new Filter { Name = "attachment.vpc-id" };
            filter.Values.Add(vpcid);
            request.Filters.Add(filter);

            var response = await _ec2Client.DescribeInternetGatewaysAsync(request);

            foreach (var gateway in response.InternetGateways)
            {
                await _ec2Client.DetachInternetGatewayAsync(new DetachInternetGatewayRequest {
                    InternetGatewayId = gateway.InternetGatewayId, VpcId = vpcid
                });
                await _ec2Client.DeleteInternetGatewayAsync(new DeleteInternetGatewayRequest {
                    InternetGatewayId = gateway.InternetGatewayId
                });
            }
        }

        // this expects that all instances have been terminated
        public async Task deleteSubnetsAsync(string vpcid)
        {
            var response = await _ec2Client.DescribeSubnetsAsync(new DescribeSubnetsRequest{
                Filters = { new Filter("vpc-id", new List<string> { vpcid })}
            });

            foreach (var subnet in response.Subnets)
            {
                await _ec2Client.DeleteSubnetAsync(new DeleteSubnetRequest { SubnetId = subnet.SubnetId });
            }
        }

        public async Task deleteNetworkAclAsync(string vpcid)
        {
            var describeResponse = await _ec2Client.DescribeNetworkAclsAsync(new DescribeNetworkAclsRequest{
                Filters = { new Filter("vpc-id", new List<string> {vpcid })}
            });

            foreach (var acl in describeResponse.NetworkAcls)
            {
                if (!acl.IsDefault.GetValueOrDefault())
                {
                    await _ec2Client.DeleteNetworkAclAsync(new DeleteNetworkAclRequest { NetworkAclId = acl.NetworkAclId });
                }
            }
        }

        public async Task terminateVPCInstanceAsync(string vpcid)
        {
            var ids = new List<string>();
            var response = await _ec2Client.DescribeInstancesAsync(new DescribeInstancesRequest {
                Filters = { new Filter("vpc-id", new List<string>{ vpcid })}
            });

            foreach (var reservation in response.Reservations)
            {
                foreach (var instance in reservation.Instances)
                {
                    if (!string.IsNullOrEmpty(instance.SubnetId))
                    {
                        await _ec2Client.TerminateInstancesAsync(new TerminateInstancesRequest { InstanceIds = new List<string> { instance.InstanceId } });
                        ids.Add(instance.InstanceId);
                    }
                }
            }

            foreach (var instanceId in ids)
            {
                await waitForInstanceToTransitionToStateAsync(instanceId, "terminated");
            }
        }
        
        public async Task disassociateAndDeleteRouteTables(string vpcid)
        {
            var response = await _ec2Client.DescribeRouteTablesAsync(new DescribeRouteTablesRequest{
                Filters = { new Filter("vpc-id", new List<string> { vpcid }) }
            });

            foreach (var table in response.RouteTables)
            {
                await disassociateAndDeleteRouteTableAsync(table);
            }
        }


        public async Task disassociateAndDeleteRouteTableAsync(RouteTable table)
        {
            bool isMain = false;
            foreach (var association in table.Associations)
            {
                if (!association.Main.GetValueOrDefault())
                {
                   await _ec2Client.DisassociateRouteTableAsync(new DisassociateRouteTableRequest { AssociationId = association.RouteTableAssociationId });
                }
                else
                {
                    isMain = true;
                }
            }

            foreach (var route in table.Routes)
            {
                if (route.GatewayId != "local")
                {
                    await _ec2Client.DeleteRouteAsync(new DeleteRouteRequest
                    {
                        RouteTableId = table.RouteTableId,
                        DestinationCidrBlock = route.DestinationCidrBlock
                    });
                }
            }

            if (!isMain)
            {
                await _ec2Client.DeleteRouteTableAsync(new DeleteRouteTableRequest { RouteTableId = table.RouteTableId });
            }
        }

        public async Task terminateInstanceAsync(string instanceId)
        {
            TerminateInstancesRequest request = new TerminateInstancesRequest {
                InstanceIds = new List<string> { instanceId }
            };
            await _ec2Client.TerminateInstancesAsync(request);
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
                Instance runningInstance = (await _ec2Client.DescribeInstancesAsync(
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
