using System;
using System.Collections.Generic;
using Amazon.EC2;
using Amazon.EC2.Model;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests.EC2
{
    [TestClass]
    public class UnmarshallTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestDescribeImages()
        {
            const string payloadResponse = @"<?xml version='1.0' encoding='UTF-8'?>
<DescribeImagesResponse xmlns='http://ec2.amazonaws.com/doc/2014-06-15/'>
   <requestId>c8ed10b1-5ad2-40b0-b44e-da4c4183c026</requestId>
   <imagesSet>
       <item>
      <imageId>ami-1a2b3c4d</imageId>
      <imageLocation>amazon/getting-started</imageLocation>
      <imageState>available</imageState>
      <imageOwnerId>111122223333</imageOwnerId>
      <isPublic>true</isPublic>
      <architecture>i386</architecture>
      <imageType>machine</imageType>
      <kernelId>aki-1a2b3c4d</kernelId>
      <ramdiskId>ari-1a2b3c4d</ramdiskId>
      <imageOwnerAlias>amazon</imageOwnerAlias>
      <name>getting-started</name>
      <description>Image Description</description>
      <rootDeviceType>ebs</rootDeviceType>
      <rootDeviceName>/dev/sda</rootDeviceName>
      <blockDeviceMapping>
        <item>
          <deviceName>/dev/sda1</deviceName>
          <ebs>
            <snapshotId>snap-1a2b3c4d</snapshotId>
            <volumeSize>15</volumeSize>
            <deleteOnTermination>false</deleteOnTermination>
            <volumeType>standard</volumeType>
          </ebs>
        </item>
        <item>
          <deviceName>/dev/sdb</deviceName>
          <ebs>
            <snapshotId>snap-4a3b2c1d</snapshotId>
            <volumeSize>30</volumeSize>
            <deleteOnTermination>true</deleteOnTermination>
            <volumeType>gp2</volumeType>
          </ebs>
        </item>
      </blockDeviceMapping>
      <virtualizationType>paravirtual</virtualizationType>
      <tagSet/>
      <hypervisor>xen</hypervisor>
    </item>
   </imagesSet>
</DescribeImagesResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = DescribeImagesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeImagesResponse;

            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Images.Count);
            var image = result.Images[0];

            Assert.AreEqual("ami-1a2b3c4d", image.ImageId);
            Assert.AreEqual("amazon/getting-started", image.ImageLocation);
            Assert.AreEqual(ImageState.Available, image.State);

            Assert.AreEqual(2, image.BlockDeviceMappings.Count);

            Assert.AreEqual("/dev/sda1", image.BlockDeviceMappings[0].DeviceName);
            Assert.AreEqual("snap-1a2b3c4d", image.BlockDeviceMappings[0].Ebs.SnapshotId);
            Assert.AreEqual(15, image.BlockDeviceMappings[0].Ebs.VolumeSize);
            Assert.AreEqual(VolumeType.Standard, image.BlockDeviceMappings[0].Ebs.VolumeType);
            Assert.IsFalse(image.BlockDeviceMappings[0].Ebs.DeleteOnTermination);

            Assert.AreEqual(VolumeType.Gp2, image.BlockDeviceMappings[1].Ebs.VolumeType);
            Assert.IsTrue(image.BlockDeviceMappings[1].Ebs.DeleteOnTermination);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestDescribeSpotInstances()
        {
            const string payloadResponse = @"<?xml version='1.0' encoding='UTF-8'?>
<DescribeSpotInstanceRequestsResponse xmlns='http://ec2.amazonaws.com/doc/2014-06-15/'>
  <requestId>59dbff89-35bd-4eac-99ed-be587EXAMPLE</requestId>
  <spotInstanceRequestSet>     
    <item>
       <spotInstanceRequestId>sir-e1471206</spotInstanceRequestId>
       <spotPrice>0.09</spotPrice>
       <type>one-time</type>
       <state>active</state>
       <status>
         <code>PENDING_EVALUATION</code>
         <message>2012-13-09 08:31:26 +0000 : Your Spot request has been submitted for review, and is pending evaluation.</message>
       </status>
       <launchSpecification>
          <imageId>ami-1a2b3c4d</imageId>
          <keyName>MyKey</keyName>
          <groupSet>
             <item>
                <groupId>default</groupId>
             </item>
          </groupSet>
          <instanceType>m1.small</instanceType>
           <blockDeviceMapping>
               <item>
                   <deviceName>/dev/sda1</deviceName>
                   <ebs>
                       <deleteOnTermination>true</deleteOnTermination>
                       <volumeType>standard</volumeType>
                   </ebs>
               </item>
               <item>
                   <deviceName>/dev/sdb</deviceName>
                   <ebs>
                       <deleteOnTermination>false</deleteOnTermination>
                       <volumeType>io1</volumeType>
                       <iops>10</iops>
                   </ebs>
               </item>
               <item>
                   <deviceName>/dev/sdc</deviceName>
                   <ebs>
                       <snapshotId>snap-1a2b3c4d</snapshotId>
                       <volumeSize>12</volumeSize>
                       <deleteOnTermination>true</deleteOnTermination>
                       <volumeType>standard</volumeType>
                   </ebs>
               </item>
           </blockDeviceMapping>
          <monitoring>
             <enabled>false</enabled>
          </monitoring>
       </launchSpecification>
       <instanceId>i-1a2b3c4d</instanceId>
       <createTime>2010-09-13T23:50:44.000Z</createTime>
       <productDescription>Linux/UNIX</productDescription>
       <launchedAvailabilityZone>us-east-1c</launchedAvailabilityZone>
    </item>
  </spotInstanceRequestSet>
</DescribeSpotInstanceRequestsResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeSpotInstanceRequestsResponse;

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.SpotInstanceRequests);
            Assert.AreEqual(1, result.SpotInstanceRequests.Count);
            var spotInstanceRequest = result.SpotInstanceRequests[0];

            var blockDeviceMapping = spotInstanceRequest.LaunchSpecification.BlockDeviceMappings;
            Assert.AreEqual(3, blockDeviceMapping.Count);

            Assert.AreEqual(VolumeType.Standard, blockDeviceMapping[0].Ebs.VolumeType);
            Assert.AreEqual(VolumeType.Io1, blockDeviceMapping[1].Ebs.VolumeType);
            Assert.AreEqual(10, blockDeviceMapping[1].Ebs.Iops);
            Assert.AreEqual(VolumeType.Standard, blockDeviceMapping[2].Ebs.VolumeType);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestDescribeVolumes()
        {
            const string payloadResponse = @"<?xml version='1.0' encoding='UTF-8'?>
<DescribeVolumesResponse xmlns='http://ec2.amazonaws.com/doc/2014-06-15/'>
   <requestId>59dbff89-35bd-4eac-99ed-be587EXAMPLE</requestId> 
   <volumeSet>
      <item>
         <volumeId>vol-1a2b3c4d</volumeId>
         <size>80</size>
         <snapshotId/>
         <availabilityZone>us-east-1a</availabilityZone>
         <status>in-use</status>
         <createTime>2014-03-01T12:03:00.00Z</createTime>
         <attachmentSet>
            <item>
               <volumeId>vol-1a2b3c4d</volumeId>
               <instanceId>i-1a2b3c4d</instanceId>
               <device>/dev/sdh</device>
               <status>attached</status>
               <attachTime>2014-03-01T12:03:00.00Z</attachTime>
               <deleteOnTermination>false</deleteOnTermination>
            </item>
         </attachmentSet>
         <volumeType>standard</volumeType>
         <encrypted>true</encrypted>
      </item>
   </volumeSet>
</DescribeVolumesResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = DescribeVolumesResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVolumesResponse;


            Assert.IsNotNull(result);
            Assert.AreEqual(1, result.Volumes.Count);

            var vol = result.Volumes[0];

            Assert.AreEqual("vol-1a2b3c4d", vol.VolumeId);
            Assert.AreEqual(80, vol.Size);
            Assert.IsTrue(string.IsNullOrEmpty(vol.SnapshotId));
            Assert.AreEqual(VolumeType.Standard, vol.VolumeType);
            Assert.AreEqual(VolumeState.InUse, vol.State);

            Assert.AreEqual(1, vol.Attachments.Count);
            Assert.AreEqual("vol-1a2b3c4d", vol.Attachments[0].VolumeId);
            Assert.AreEqual("i-1a2b3c4d", vol.Attachments[0].InstanceId);
            Assert.IsFalse(vol.Attachments[0].DeleteOnTermination);

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestRegisterImage()
        {
            const string payloadResponse = @"<?xml version='1.0' encoding='UTF-8'?>
<RegisterImageResponse xmlns='http://ec2.amazonaws.com/doc/2014-06-15/'>
   <requestId>3b4de853-288e-4c0a-802a-4a7471ba2620</requestId>
   <imageId>ami-4af95e23</imageId>
</RegisterImageResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = RegisterImageResponseUnmarshaller.Instance.Unmarshall(context) as RegisterImageResponse;

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ImageId);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestRunInstances()
        {
            const string payloadResponse = @"<?xml version='1.0' encoding='UTF-8'?>
<RunInstancesResponse xmlns='http://ec2.amazonaws.com/doc/2014-06-15/'>
    <requestId>9a6bfb4a-1c38-408c-a6f9-b0f1a36db758</requestId>
    <reservationId>r-6e46e03a</reservationId>
    <ownerId>251839141158</ownerId>
    <groupSet/>
    <instancesSet>
        <item>
            <instanceId>i-ba7af9ee</instanceId>
            <imageId>ami-beb0caec</imageId>
            <instanceState>
                <code>0</code>
                <name>pending</name>
            </instanceState>
            <privateDnsName/>
            <dnsName/>
            <reason/>
            <amiLaunchIndex>0</amiLaunchIndex>
            <productCodes/>
            <instanceType>m1.large</instanceType>
            <launchTime>2012-06-04T23:12:12.000Z</launchTime>
            <placement>
                <availabilityZone>ap-southeast-1b</availabilityZone>
                <groupName/>
                <tenancy>default</tenancy>
            </placement>
            <kernelId>aki-aa225af8</kernelId>
            <monitoring>
                <state>disabled</state>
            </monitoring>
            <subnetId>subnet-a61dafcf</subnetId>
            <vpcId>vpc-c31dafaa</vpcId>
            <privateIpAddress>10.0.2.106</privateIpAddress>
            <sourceDestCheck>true</sourceDestCheck>
            <groupSet>
                <item>
                    <groupId>sg-188d9f74</groupId>
                    <groupName>default</groupName>
                </item>
            </groupSet>
            <stateReason>
                <code>pending</code>
                <message>pending</message>
            </stateReason>
            <architecture>x86_64</architecture>
            <rootDeviceType>ebs</rootDeviceType>
            <rootDeviceName>/dev/sda1</rootDeviceName>
            <blockDeviceMapping/>
            <virtualizationType>paravirtual</virtualizationType>
            <clientToken/>
            <hypervisor>xen</hypervisor>
            <networkInterfaceSet>
                <item>
                    <networkInterfaceId>eni-ffc37f96</networkInterfaceId>
                    <subnetId>subnet-a61dafcf</subnetId>
                    <vpcId>vpc-c31dafaa</vpcId>
                    <description/>
                    <ownerId>251839141158</ownerId>
                    <status>in-use</status>
                    <privateIpAddress>10.0.2.106</privateIpAddress>
                    <sourceDestCheck>true</sourceDestCheck>
                    <groupSet>
                        <item>
                            <groupId>sg-188d9f74</groupId>
                            <groupName>default</groupName>
                        </item>
                    </groupSet>
                    <attachment>
                        <attachmentId>eni-attach-d1d917b8</attachmentId>
                        <deviceIndex>0</deviceIndex>
                        <status>attaching</status>
                        <attachTime>2012-06-04T23:12:12.000Z</attachTime>
                        <deleteOnTermination>true</deleteOnTermination>
                    </attachment>
                    <privateIpAddressesSet>
                        <item>
                            <privateIpAddress>10.0.2.106</privateIpAddress>
                            <primary>true</primary>
                        </item>
                        <item>
                            <privateIpAddress>10.0.2.107</privateIpAddress>
                            <primary>false</primary>
                        </item>
                        <item>
                            <privateIpAddress>10.0.2.108</privateIpAddress>
                            <primary>false</primary>
                        </item>
                    </privateIpAddressesSet>
                </item>
            </networkInterfaceSet>
        </item>
    </instancesSet>
</RunInstancesResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = RunInstancesResponseUnmarshaller.Instance.Unmarshall(context)
                as RunInstancesResponse;

            Assert.AreEqual("r-6e46e03a", result.Reservation.ReservationId);
            Assert.AreEqual(0, result.Reservation.Groups.Count);

            Assert.AreEqual<int>(1, result.Reservation.Instances.Count);
            var instance = result.Reservation.Instances[0];
            Assert.AreEqual("i-ba7af9ee", instance.InstanceId);
            Assert.AreEqual("ami-beb0caec", instance.ImageId);
            Assert.AreEqual(0, instance.State.Code);
            Assert.AreEqual(InstanceStateName.Pending, instance.State.Name);

            Assert.AreEqual("ap-southeast-1b", instance.Placement.AvailabilityZone);
            Assert.AreEqual(Tenancy.Default, instance.Placement.Tenancy);
            Assert.IsTrue(string.IsNullOrEmpty(instance.Placement.GroupName));

            Assert.AreEqual(MonitoringState.Disabled, instance.Monitoring.State);
            Assert.IsTrue(instance.SourceDestCheck);

            Assert.AreEqual(1, instance.SecurityGroups.Count);
            Assert.AreEqual("sg-188d9f74", instance.SecurityGroups[0].GroupId);
            Assert.AreEqual("default", instance.SecurityGroups[0].GroupName);

            Assert.AreEqual("pending", instance.StateReason.Code);
            Assert.AreEqual("pending", instance.StateReason.Message);

            Assert.AreEqual(1, instance.NetworkInterfaces.Count);
            var netInt = instance.NetworkInterfaces[0];

            Assert.AreEqual("eni-ffc37f96", netInt.NetworkInterfaceId);
            Assert.AreEqual("10.0.2.106", netInt.PrivateIpAddress);
            Assert.IsTrue(netInt.SourceDestCheck);
            Assert.AreEqual(1, netInt.Groups.Count);
            Assert.AreEqual("sg-188d9f74", netInt.Groups[0].GroupId);
            Assert.AreEqual("default", netInt.Groups[0].GroupName);

            Assert.AreEqual("eni-attach-d1d917b8", netInt.Attachment.AttachmentId);
            Assert.IsTrue(netInt.Attachment.DeleteOnTermination);

            Assert.AreEqual(3, instance.NetworkInterfaces[0].PrivateIpAddresses.Count);
            Assert.AreEqual("10.0.2.106", netInt.PrivateIpAddresses[0].PrivateIpAddress);
            Assert.IsTrue(netInt.PrivateIpAddresses[0].Primary);

            Assert.AreEqual("10.0.2.108", netInt.PrivateIpAddresses[2].PrivateIpAddress);
            Assert.IsFalse(netInt.PrivateIpAddresses[2].Primary);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestDescribeImageAttribute()
        {
            const string payloadResponse = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<DescribeImageAttributeResponse xmlns=""http://ec2.amazonaws.com/doc/2014-06-15/"">
    <requestId>54dc1c70-e0ca-486d-acf1-f1dfb9b72280</requestId>
    <imageId>ami-ac1471c5</imageId>
    <launchPermission/>
</DescribeImageAttributeResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = DescribeImageAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeImageAttributeResponse;

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.ResponseMetadata);
            Assert.IsNotNull(result.ResponseMetadata.RequestId);
            Assert.IsNotNull(result.ImageAttribute);
            Assert.IsNotNull(result.ImageAttribute.ImageId);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestAssignPrivateIpAddresses()
        {
            const string payloadResponse = @"<?xml version='1.0' encoding='UTF-8'?>
<AssignPrivateIpAddressesResponse xmlns='http://ec2.amazonaws.com/doc/2014-06-15/'>
    <requestId>88d011c7-3265-4535-804f-76422b891c56</requestId>
    <return>true</return>
</AssignPrivateIpAddressesResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = AssignPrivateIpAddressesResponseUnmarshaller.Instance.Unmarshall(context)
                as AssignPrivateIpAddressesResponse;

            Assert.IsNotNull(result.ResponseMetadata.RequestId);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestUnassignPrivateIpAddresses()
        {
            const string payloadResponse = @"<?xml version='1.0' encoding='UTF-8'?>
<UnassignPrivateIpAddressesResponse xmlns='http://ec2.amazonaws.com/doc/2014-06-15/'>
    <requestId>88d011c7-3265-4535-804f-76422b891c56</requestId>
    <return>true</return>
</UnassignPrivateIpAddressesResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = UnassignPrivateIpAddressesResponseUnmarshaller.Instance.Unmarshall(context)
                as UnassignPrivateIpAddressesResponse;

            Assert.IsNotNull(result.ResponseMetadata.RequestId);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestCreateNetworkInterface()
        {
            const string payloadResponse = @"<?xml version='1.0' encoding='UTF-8'?>
<CreateNetworkInterfaceResponse xmlns='http://ec2.amazonaws.com/doc/2014-06-15/'>
    <requestId>a9565f4c-f928-4113-859b-905886d11658</requestId>
    <networkInterface>
        <networkInterfaceId>eni-1a2b3c4d</networkInterfaceId>
        <subnetId>subnet-1a2b3c4d</subnetId>
        <vpcId>vpc-1a2b3c4d</vpcId>
        <availabilityZone>ap-southeast-1b</availabilityZone>
        <description/>
        <ownerId>123456789123</ownerId>
        <requesterManaged>false</requesterManaged>
        <status>attaching</status>
        <macAddress>02:74:b0:78:bf:ab</macAddress>
        <privateIpAddress>10.0.2.130</privateIpAddress>
        <sourceDestCheck>true</sourceDestCheck>
        <groupSet>
            <item>
                <groupId>sg-1a2b3c4d</groupId>
                <groupName>default</groupName>
            </item>
        </groupSet>
        <tagSet/>
        <privateIpAddressesSet>
            <item>
                <privateIpAddress>10.0.2.130</privateIpAddress>
                <primary>true</primary>
            </item>
            <item>
                <privateIpAddress>10.0.2.133</privateIpAddress>
                <primary>false</primary>
            </item>
            <item>
                <privateIpAddress>10.0.2.132</privateIpAddress>
                <primary>false</primary>
            </item>
        </privateIpAddressesSet>
    </networkInterface>
</CreateNetworkInterfaceResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = CreateNetworkInterfaceResponseUnmarshaller.Instance.Unmarshall(context)
                as CreateNetworkInterfaceResponse;

            Assert.AreEqual(NetworkInterfaceStatus.Attaching, result.NetworkInterface.Status);
            Assert.AreEqual("02:74:b0:78:bf:ab", result.NetworkInterface.MacAddress);
            Assert.IsTrue(result.NetworkInterface.SourceDestCheck);

            Assert.AreEqual(1, result.NetworkInterface.Groups.Count);
            Assert.AreEqual("sg-1a2b3c4d", result.NetworkInterface.Groups[0].GroupId);
            Assert.AreEqual("default", result.NetworkInterface.Groups[0].GroupName);

            Assert.AreEqual(0, result.NetworkInterface.TagSet.Count);

            Assert.AreEqual(3, result.NetworkInterface.PrivateIpAddresses.Count);
            Assert.AreEqual("10.0.2.130", result.NetworkInterface.PrivateIpAddresses[0].PrivateIpAddress);
            Assert.IsTrue(result.NetworkInterface.PrivateIpAddresses[0].Primary);

            Assert.AreEqual("10.0.2.132", result.NetworkInterface.PrivateIpAddresses[2].PrivateIpAddress);
            Assert.IsFalse(result.NetworkInterface.PrivateIpAddresses[2].Primary);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestDescribeVolumeAttribute()
        {
            const string payloadResponse = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<DescribeVolumeAttributeResponse xmlns=""http://ec2.amazonaws.com/doc/2014-06-15/"">
   <requestId>1</requestId>
   <volumeId>123456</volumeId>
   <autoEnableIO>
      <value>true</value>
   </autoEnableIO>
</DescribeVolumeAttributeResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = DescribeVolumeAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVolumeAttributeResponse;

            Assert.AreEqual("1", result.ResponseMetadata.RequestId);
            Assert.AreEqual("123456", result.VolumeId);
            Assert.IsTrue(result.AutoEnableIO);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestModifyVolumeAttribute()
        {
            const string payloadResponse = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<ModifyVolumeAttributeResponse xmlns=""http://ec2.amazonaws.com/doc/2014-06-15/"">
<requestId>1</requestId>
<return>true</return>
</ModifyVolumeAttributeResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = ModifyVolumeAttributeResponseUnmarshaller.Instance.Unmarshall(context)
                as ModifyVolumeAttributeResponse;

            Assert.AreEqual("1", result.ResponseMetadata.RequestId);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestEnableVolumeIO()
        {
            const string payloadResponse = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<EnableVolumeIOResponse xmlns=""http://ec2.amazonaws.com/doc/2014-06-15/"">
   <requestId>1</requestId>
   <return>true</return>
</EnableVolumeIOResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = EnableVolumeIOResponseUnmarshaller.Instance.Unmarshall(context)
                as EnableVolumeIOResponse;

            Assert.AreEqual("1", result.ResponseMetadata.RequestId);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        public void TestDescribeVolumeStatus()
        {
            const string payloadResponse = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<DescribeVolumesStatusResponse xmlns='http://ec2.amazonaws.com/doc/2014-06-15/'>
   <requestId>5jkdf074-37ed-4004-8671-a78ee82bf1cbEXAMPLE</requestId>
   <volumeStatusSet>
    <item>
      <volumeId>vol-11111111</volumeId>
      <availabilityZone>us-east-1d</availabilityZone>
      <volumeStatus>
        <status>ok</status>
        <details>
          <item>
            <name>io-enabled</name>
            <status>passed</status>
          </item>
        </details>
      </volumeStatus>
    </item>
    <item>
      <volumeId>vol-22222222</volumeId>
      <availabilityZone>us-east-1d</availabilityZone>
      <volumeStatus>
        <status>impaired</status>
        <details>
          <item>
            <name>io-enabled</name>
            <status>failed</status>
          </item>
        </details>
      </volumeStatus>
      <eventsSet>
        <item>
          <eventId>evol-61a54008</eventId>
          <eventType>potential-data-inconsistency</eventType>
          <description>THIS IS AN EXAMPLE</description>
          <notBefore>2011-12-01T14:00:00.000Z</notBefore>
          <notAfter>2011-12-01T15:00:00.000Z</notAfter>
        </item>
      </eventsSet>
      <actionsSet>
        <item>
          <code>enable-volume-io</code>
          <eventId> evol-61a54008</eventId>
          <eventType>potential-data-inconsistency</eventType>
          <description>THIS IS AN EXAMPLE</description>          
        </item>
      </actionsSet>
    </item>
    </volumeStatusSet>
</DescribeVolumesStatusResponse>";

            UnmarshallerContext context = new EC2UnmarshallerContext(Utils.CreateStreamFromString(payloadResponse), false, new WebResponseData());
            var result = DescribeVolumeStatusResponseUnmarshaller.Instance.Unmarshall(context)
                as DescribeVolumeStatusResponse;

            Assert.AreEqual(2, result.VolumeStatuses.Count);

            var vol1 = result.VolumeStatuses[0];
            Assert.AreEqual("vol-11111111", vol1.VolumeId);
            Assert.AreEqual(VolumeStatusInfoStatus.Ok, vol1.VolumeStatus.Status);
            Assert.AreEqual(1, vol1.VolumeStatus.Details.Count);
            Assert.AreEqual(VolumeStatusName.IoEnabled, vol1.VolumeStatus.Details[0].Name);
            Assert.AreEqual("passed", vol1.VolumeStatus.Details[0].Status);

            var vol2 = result.VolumeStatuses[1];
            Assert.AreEqual(1, vol2.Events.Count);
            Assert.AreEqual("evol-61a54008", vol2.Events[0].EventId);
            Assert.AreEqual("potential-data-inconsistency", vol2.Events[0].EventType);

            Assert.AreEqual(1, vol2.Actions.Count);
            Assert.AreEqual("enable-volume-io", vol2.Actions[0].Code);
            Assert.AreEqual("THIS IS AN EXAMPLE", vol2.Actions[0].Description);
        }
    }
}
