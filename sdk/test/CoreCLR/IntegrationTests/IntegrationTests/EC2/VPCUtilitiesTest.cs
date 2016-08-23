//using System;
//using System.Text;
//using System.Collections.Generic;
//using System.Linq;

//using Amazon.EC2;
//using Amazon.EC2.Model;
//using Amazon.EC2.Util;

//using System.Threading.Tasks;
//using Xunit;
//using Amazon.Util;
//using Amazon.DNXCore.IntegrationTests.IntegrationTests.EC2;

//namespace Amazon.DNXCore.IntegrationTests.EC2
//{
//    public class VPCUtilitiesTest : TestBase<AmazonEC2Client>
//    {
//        EC2TestHelper _helper;
//        private List<string> _vpcIds;

//        public VPCUtilitiesTest()
//            : base()
//        {
//            _vpcIds = new List<string>();
//            _helper = new EC2TestHelper(Client);
//        }

//        protected override void Dispose(bool disposing)
//        {
//            foreach (string vpcId in _vpcIds)
//            {
//                _helper.deleteTestVpcAsync(vpcId).Wait();
//            }
//        }

//        [Trait(CategoryAttribute, "EC2")]
//        [Fact]
//        public async Task LaunchNATTest()
//        {
//            CreateVpcResponse createVpcResponse = await Client.CreateVpcAsync(new CreateVpcRequest
//            {
//                CidrBlock = "10.0.0.0/16",
//            });
//            var newVpc = createVpcResponse.Vpc;
//            _vpcIds.Add(newVpc.VpcId);

//            CreateSubnetResponse createSubnetResponse = await Client.CreateSubnetAsync(new CreateSubnetRequest()
//            {
//                VpcId = newVpc.VpcId,
//                CidrBlock = "10.0.0.0/24"
//            });
//            var subnet = createSubnetResponse.Subnet;

//            CreateInternetGatewayResponse createInternetGatewayResponse = await Client.CreateInternetGatewayAsync(new CreateInternetGatewayRequest());
//            var gateway = createInternetGatewayResponse.InternetGateway;
//            await Client.AttachInternetGatewayAsync(new AttachInternetGatewayRequest() { VpcId = newVpc.VpcId, InternetGatewayId = gateway.InternetGatewayId });


//            var instance = await VPCUtilities.LaunchNATInstanceAsync(Client, new LaunchNATInstanceRequest() { SubnetId = subnet.SubnetId});
//            Assert.NotNull(instance);

//            Assert.NotNull(instance.PrivateIpAddress);
//        }

//        [Trait(CategoryAttribute, "EC2")]
//        [Fact]
//        public async Task LaunchVPCWithPublicSubnetTest()
//        {
//            var request = new LaunchVPCWithPublicSubnetRequest() { };
//            var response = await VPCUtilities.LaunchVPCWithPublicSubnetAsync(Client, request);

//            Assert.NotNull(response.VPC);
//            _vpcIds.Add(response.VPC.VpcId);

//            Assert.NotNull(response.InternetGateway);
//            Assert.NotNull(response.PublicSubnet);
//            Assert.NotNull(response.PublicSubnetRouteTable);

//            Assert.NotNull(response.PublicSubnetRouteTable.Routes.FirstOrDefault(x => x.GatewayId == response.InternetGateway.InternetGatewayId && x.DestinationCidrBlock == "0.0.0.0/0"));
//        }

//        [Trait(CategoryAttribute, "EC2")]
//        [Fact]
//        public async Task LaunchVPCWithPublicAndPrivateSubnetsTest()
//        {
//            var progress = ((VPCUtilities.Progress)(x => Console.WriteLine(x)));
//            var request = new LaunchVPCWithPublicAndPrivateSubnetsRequest() { ConfigureDefaultVPCGroupForNAT = true, ProgressCallback = progress};
//            var response = await VPCUtilities.LaunchVPCWithPublicAndPrivateSubnetsAsync(Client, request);
//            try
//            {
//                Assert.NotNull(response.VPC);
//                _vpcIds.Add(response.VPC.VpcId);
//                Assert.NotNull(response.InternetGateway);
//                Assert.NotNull(response.PublicSubnet);
//                Assert.NotNull(response.PublicSubnetRouteTable);

//                Assert.NotNull(response.PrivateSubnet);
//                Assert.NotNull(response.NATInstance);

//                Assert.NotNull(response.NATSecurityGroup);

//                var defaultGroup = await GetDefaultSecurityGroupAsync(Client, response.VPC.VpcId);

//                var permission = defaultGroup.IpPermissions.FirstOrDefault(x => x.UserIdGroupPairs.FirstOrDefault(y => y.GroupId == response.NATSecurityGroup.GroupId) != null);
//                Assert.NotNull(permission);
//            }
//            finally
//            {
//                for (int i = 0; i < 40; i++)
//                {
//                    try
//                    {
//                        if (response.NATInstance.InstanceId == InstanceStateName.Terminated)
//                            break;
//                    }
//                    catch { }
//                    AWSSDKUtils.Sleep(500);
//                }
//            }
//        }

//        private async Task<SecurityGroup> GetDefaultSecurityGroupAsync(IAmazonEC2 ec2Client, string vpcId)
//        {
//            var filters = new List<Filter>()
//            {
//                new Filter() { Name = "vpc-id", Values = new List<string>() { vpcId } },
//                new Filter() { Name = "group-name", Values = new List<string>() { "default" } }
//            };

//            var response = await Client.DescribeSecurityGroupsAsync(new DescribeSecurityGroupsRequest() { Filters = filters }).ConfigureAwait(false);
//            if (response.SecurityGroups.Count != 1)
//                return null;

//            return response.SecurityGroups[0];
//        }

//        /**
//         * Waits for the specified instance to transition to the specified state,
//         * otherwise throws a RuntimeException if this method gives up on the
//         * instance ever transitioning to that state.
//         *
//         * @param instanceId
//         *            The ID of the instance to wait for.
//         * @param state
//         *            The expected state for the instance to transition to.
//         *
//         * @throws Exception
//         *             If any problems were encountered while polling the instance's
//         *             state, or if this method gives up on the instance ever
//         *             transitioning to the expected state.
//         */
//        public async Task waitForInstanceToTransitionToStateAsync(string instanceId, InstanceStateName state)
//        {
//            Console.WriteLine("Waiting for instance " + instanceId + " to transition to " + state + "...");

//            int count = 0;
//            while (true)
//            {
//                AWSSDKUtils.Sleep(1000 * 5);

//                count++;
//                DescribeInstancesResponse describeInstanceResponse = await Client.DescribeInstancesAsync(
//                        new DescribeInstancesRequest { InstanceIds = new List<string> { instanceId } });
//                Instance runningInstance = describeInstanceResponse.Reservations[0].Instances[0];

//                if (runningInstance.State.Name == state) return;

//                if (count > 100)
//                {
//                    throw new Exception("Instance " + instanceId + " never transitioned to " + state);
//                }
//            }
//        }
//    }
//}
