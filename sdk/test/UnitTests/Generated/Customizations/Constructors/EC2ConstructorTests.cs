/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the ec2-2016-04-01.normal.json service model.
 */
using System.Collections.Generic;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.EC2;
using Amazon.EC2.Model;

namespace AWSSDK_DotNet35.UnitTests.TestTools
{
    [TestClass]
    public class EC2ConstructorCustomizationsTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void AssociateAddressRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.AssociateAddressRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void AssociateDhcpOptionsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.AssociateDhcpOptionsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void AttachVolumeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.AttachVolumeRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void AttachVpnGatewayRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.AttachVpnGatewayRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void AuthorizeSecurityGroupIngressRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.AuthorizeSecurityGroupIngressRequest), new System.Type[] { typeof(string), typeof(List<IpPermission>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void BundleInstanceRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.BundleInstanceRequest), new System.Type[] { typeof(string), typeof(Storage), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CancelBundleTaskRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CancelBundleTaskRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CancelSpotInstanceRequestsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CancelSpotInstanceRequestsRequest), new System.Type[] { typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void ConfirmProductInstanceRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.ConfirmProductInstanceRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateCustomerGatewayRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateCustomerGatewayRequest), new System.Type[] { typeof(GatewayType), typeof(string), typeof(int), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateDhcpOptionsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateDhcpOptionsRequest), new System.Type[] { typeof(List<DhcpConfiguration>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateImageRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateImageRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateKeyPairRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateKeyPairRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreatePlacementGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreatePlacementGroupRequest), new System.Type[] { typeof(string), typeof(PlacementStrategy), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateSecurityGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateSecurityGroupRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateSnapshotRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateSnapshotRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateSpotDatafeedSubscriptionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateSpotDatafeedSubscriptionRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateSubnetRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateSubnetRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateTagsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateTagsRequest), new System.Type[] { typeof(List<string>), typeof(List<Tag>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateVolumeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateVolumeRequest), new System.Type[] { typeof(string), typeof(int), });
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateVolumeRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateVpcRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateVpcRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateVpnConnectionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateVpnConnectionRequest), new System.Type[] { typeof(string), typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void CreateVpnGatewayRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.CreateVpnGatewayRequest), new System.Type[] { typeof(GatewayType), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteCustomerGatewayRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteCustomerGatewayRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteDhcpOptionsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteDhcpOptionsRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteKeyPairRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteKeyPairRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeletePlacementGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeletePlacementGroupRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteSecurityGroupRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteSecurityGroupRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteSnapshotRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteSnapshotRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteSubnetRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteSubnetRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteTagsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteTagsRequest), new System.Type[] { typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteVolumeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteVolumeRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteVpcRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteVpcRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteVpnConnectionRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteVpnConnectionRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeleteVpnGatewayRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeleteVpnGatewayRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DeregisterImageRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DeregisterImageRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DescribeImageAttributeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DescribeImageAttributeRequest), new System.Type[] { typeof(string), typeof(ImageAttributeName), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DescribeInstanceAttributeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DescribeInstanceAttributeRequest), new System.Type[] { typeof(string), typeof(InstanceAttributeName), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DescribeSnapshotAttributeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DescribeSnapshotAttributeRequest), new System.Type[] { typeof(string), typeof(SnapshotAttributeName), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DescribeTagsRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DescribeTagsRequest), new System.Type[] { typeof(List<Filter>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DescribeVolumesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DescribeVolumesRequest), new System.Type[] { typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DetachVolumeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DetachVolumeRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DetachVpnGatewayRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DetachVpnGatewayRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void DisassociateAddressRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.DisassociateAddressRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void GetConsoleOutputRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.GetConsoleOutputRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void GetPasswordDataRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.GetPasswordDataRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void ImportKeyPairRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.ImportKeyPairRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void ModifyImageAttributeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.ModifyImageAttributeRequest), new System.Type[] { typeof(string), typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void ModifyInstanceAttributeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.ModifyInstanceAttributeRequest), new System.Type[] { typeof(string), typeof(InstanceAttributeName), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void ModifySnapshotAttributeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.ModifySnapshotAttributeRequest), new System.Type[] { typeof(string), typeof(SnapshotAttributeName), typeof(OperationType), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void MonitorInstancesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.MonitorInstancesRequest), new System.Type[] { typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void PurchaseReservedInstancesOfferingRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.PurchaseReservedInstancesOfferingRequest), new System.Type[] { typeof(string), typeof(int), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void RebootInstancesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.RebootInstancesRequest), new System.Type[] { typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void RegisterImageRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.RegisterImageRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void ReleaseAddressRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.ReleaseAddressRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void RequestSpotInstancesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.RequestSpotInstancesRequest), new System.Type[] { typeof(string), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void ResetImageAttributeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.ResetImageAttributeRequest), new System.Type[] { typeof(string), typeof(ResetImageAttributeName), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void ResetInstanceAttributeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.ResetInstanceAttributeRequest), new System.Type[] { typeof(string), typeof(InstanceAttributeName), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void ResetSnapshotAttributeRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.ResetSnapshotAttributeRequest), new System.Type[] { typeof(string), typeof(SnapshotAttributeName), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void RevokeSecurityGroupIngressRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.RevokeSecurityGroupIngressRequest), new System.Type[] { typeof(string), typeof(List<IpPermission>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void RunInstancesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.RunInstancesRequest), new System.Type[] { typeof(string), typeof(int), typeof(int), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void StartInstancesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.StartInstancesRequest), new System.Type[] { typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void StopInstancesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.StopInstancesRequest), new System.Type[] { typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void TerminateInstancesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.TerminateInstancesRequest), new System.Type[] { typeof(List<string>), });
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Constructors"), TestCategory("EC2")]
        public void UnmonitorInstancesRequestConstructorTests()
        {
            EnsureConstructorExists(typeof(Amazon.EC2.Model.UnmonitorInstancesRequest), new System.Type[] { typeof(List<string>), });
        }

        void EnsureConstructorExists(System.Type type, System.Type[] constructorParams)
        {
            Assert.IsNotNull(type.GetConstructor(constructorParams));
        }
    }
}