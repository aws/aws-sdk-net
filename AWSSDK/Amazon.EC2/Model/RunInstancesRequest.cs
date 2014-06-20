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
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RunInstances operation.
    /// <para>Launches the specified number of instances using an AMI for which you have permissions.</para> <para>When you launch an instance, it
    /// enters the <c>pending</c> state. After the instance is ready for you, it enters the <c>running</c> state. To check the state of your
    /// instance, call DescribeInstances.</para> <para>If you don't specify a security group when launching an instance, Amazon EC2 uses the default
    /// security group. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Security
    /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>Linux instances have access to the public key of the key
    /// pair at boot. You can use this key to provide secure access to the instance. Amazon EC2 public images use this feature to provide secure
    /// access without passwords. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key
    /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>You can provide optional user data when launching an
    /// instance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html" >Instance
    /// Metadata</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If any of the AMIs have a product code attached for which
    /// the user has not subscribed, <c>RunInstances</c> fails.</para> <para>For more information about troubleshooting, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_InstanceStraightToTerminated.html" >What To Do If An Instance Immediately
    /// Terminates</a> , and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecting.html" >Troubleshooting
    /// Connecting to Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class RunInstancesRequest : EC2Request
    {    
        private string imageIdField;
        private Decimal? minCountField;
        private Decimal? maxCountField;
        private string keyNameField;
        private List<string> securityGroupField;
        private List<string> securityGroupIdField;
        private string userDataField;
        private string instanceTypeField;
        private Placement placementField;
        private string kernelIdField;
        private string ramdiskIdField;
        private List<BlockDeviceMapping> blockDeviceMappingField;
        private MonitoringSpecification monitoringField;
        private string subnetIdField;
        private bool? disableApiTerminationField;
        private string instanceInitiatedShutdownBehaviorField;
        private InstanceLicenseSpecification licenseField;
        private string privateIpAddressField;
        private string clientTokenField;
        private List<InstanceNetworkInterfaceSpecification> networkInterfaceSetField;
        private bool? ebsOptimizedField;
        private IAMInstanceProfile instanceProfileField;

        /// <summary>
        /// Unique ID of a machine image.
        /// </summary>
        [XmlElementAttribute(ElementName = "ImageId")]
        public string ImageId
        {
            get { return this.imageIdField; }
            set { this.imageIdField = value; }
        }

        /// <summary>
        /// Sets the unique ID of a machine image.
        /// </summary>
        /// <param name="imageId">Unique ID of a machine image,</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithImageId(string imageId)
        {
            this.imageIdField = imageId;
            return this;
        }

        /// <summary>
        /// Checks if ImageId property is set
        /// </summary>
        /// <returns>true if ImageId property is set</returns>
        public bool IsSetImageId()
        {
            return this.imageIdField != null;
        }

        /// <summary>
        /// Minimum number of instances to launch.
        /// If the value is more than Amazon EC2 can launch,
        /// no instances are launched at all.
        ///
        /// Constraints: Between 1 and the maximum number
        /// allowed for your account (default: 20).
        /// </summary>
        [XmlElementAttribute(ElementName = "MinCount")]
        public Decimal MinCount
        {
            get { return this.minCountField.GetValueOrDefault(); }
            set { this.minCountField = value; }
        }

        /// <summary>
        /// Sets the minimum number of instances to launch.
        /// </summary>
        /// <param name="minCount">Minimum number of instances to launch. If the
        /// value is more than Amazon
        /// EC2 can launch, no instances are launched at all.
        ///
        /// Constraints: Between 1 and the maximum number
        /// allowed for your account (default: 20).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithMinCount(Decimal minCount)
        {
            this.minCountField = minCount;
            return this;
        }

        /// <summary>
        /// Checks if MinCount property is set
        /// </summary>
        /// <returns>true if MinCount property is set</returns>
        public bool IsSetMinCount()
        {
            return this.minCountField.HasValue;
        }

        /// <summary>
        /// Maximum number of instances to launch.
        /// If the value is more than Amazon EC2 can launch, the largest possible
        /// number above minCount will be launched instead.
        ///
        /// Constraints:
        /// Between 1 and the maximum number allowed for your account
        /// (default: 20).
        /// </summary>
        [XmlElementAttribute(ElementName = "MaxCount")]
        public Decimal MaxCount
        {
            get { return this.maxCountField.GetValueOrDefault(); }
            set { this.maxCountField = value; }
        }

        /// <summary>
        /// Sets the maximum number of instances to launch.
        /// </summary>
        /// <param name="maxCount">Maximum number of instances to launch. If the
        /// value is more than Amazon
        /// EC2 can launch, the largest possible
        /// number above minCount will be launched instead.
        ///
        /// Constraints:
        /// Between 1 and the maximum number allowed for your account
        /// (default: 20).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithMaxCount(Decimal maxCount)
        {
            this.maxCountField = maxCount;
            return this;
        }

        /// <summary>
        /// Checks if MaxCount property is set
        /// </summary>
        /// <returns>true if MaxCount property is set</returns>
        public bool IsSetMaxCount()
        {
            return this.maxCountField.HasValue;
        }

        /// <summary>
        /// The name of the key pair to use.
        /// </summary>
        [XmlElementAttribute(ElementName = "KeyName")]
        public string KeyName
        {
            get { return this.keyNameField; }
            set { this.keyNameField = value; }
        }

        /// <summary>
        /// Sets the name of the key pair to use.
        /// </summary>
        /// <param name="keyName">The name of the key pair.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithKeyName(string keyName)
        {
            this.keyNameField = keyName;
            return this;
        }

        /// <summary>
        /// Checks if KeyName property is set
        /// </summary>
        /// <returns>true if KeyName property is set</returns>
        public bool IsSetKeyName()
        {
            return this.keyNameField != null;
        }

        /// <summary>
        /// Names of the security groups.
        /// </summary>
        [XmlElementAttribute(ElementName = "SecurityGroup")]
        public List<string> SecurityGroup
        {
            get
            {
                if (this.securityGroupField == null)
                {
                    this.securityGroupField = new List<string>();
                }
                return this.securityGroupField;
            }
            set { this.securityGroupField = value; }
        }

        /// <summary>
        /// Sets the names of the security groups.
        /// </summary>
        /// <param name="list">Names of the security group.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithSecurityGroup(params string[] list)
        {
            foreach (string item in list)
            {
                SecurityGroup.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SecurityGroup property is set
        /// </summary>
        /// <returns>true if SecurityGroup property is set</returns>
        public bool IsSetSecurityGroup()
        {
            return (SecurityGroup.Count > 0);
        }

        /// <summary>
        /// IDs of the security groups.
        /// </summary>
        [XmlElementAttribute(ElementName = "SecurityGroupId")]
        public List<string> SecurityGroupId
        {
            get
            {
                if (this.securityGroupIdField == null)
                {
                    this.securityGroupIdField = new List<string>();
                }
                return this.securityGroupIdField;
            }
            set { this.securityGroupIdField = value; }
        }

        /// <summary>
        /// Sets the IDs of the security groups.
        /// </summary>
        /// <param name="list">IDs of the security group.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithSecurityGroupId(params string[] list)
        {
            foreach (string item in list)
            {
                SecurityGroupId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if SecurityGroupId property is set
        /// </summary>
        /// <returns>true if SecurityGroupId property is set</returns>
        public bool IsSetSecurityGroupId()
        {
            return (SecurityGroupId.Count > 0);
        }

        /// <summary>
        /// MIME, Base64-encoded user data.
        /// </summary>
        [XmlElementAttribute(ElementName = "UserData")]
        public string UserData
        {
            get { return this.userDataField; }
            set { this.userDataField = value; }
        }

        /// <summary>
        /// Sets the MIME, Base64-encoded user data.
        /// </summary>
        /// <param name="userData">MIME, Base64-encoded user data.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithUserData(string userData)
        {
            this.userDataField = userData;
            return this;
        }

        /// <summary>
        /// Checks if UserData property is set
        /// </summary>
        /// <returns>true if UserData property is set</returns>
        public bool IsSetUserData()
        {
            return this.userDataField != null;
        }

        /// <summary>
        /// The instance type.
        ///
        /// Valid Values:
        /// m1.small | m1.medium | m1.large | m1.xlarge | c1.medium |
        /// c1.xlarge | m2.2xlarge | m2.4xlarge
        ///
        /// Default: m1.small
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceType")]
        public string InstanceType
        {
            get { return this.instanceTypeField; }
            set { this.instanceTypeField = value; }
        }

        /// <summary>
        /// Sets the instance type.
        /// </summary>
        /// <param name="instanceType">Specifies the instance type.
        ///
        /// Valid Values:
        /// m1.small | m1.medium | m1.large | m1.xlarge | c1.medium |
        /// c1.xlarge | m2.2xlarge | m2.4xlarge
        ///
        /// Default: m1.small</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithInstanceType(string instanceType)
        {
            this.instanceTypeField = instanceType;
            return this;
        }

        /// <summary>
        /// Checks if InstanceType property is set
        /// </summary>
        /// <returns>true if InstanceType property is set</returns>
        public bool IsSetInstanceType()
        {
            return this.instanceTypeField != null;
        }

        /// <summary>
        /// The placement constraints.
        /// </summary>
        [XmlElementAttribute(ElementName = "Placement")]
        public Placement Placement
        {
            get { return this.placementField; }
            set { this.placementField = value; }
        }

        /// <summary>
        /// Sets the placement constraints.
        /// </summary>
        /// <param name="placement">Specifies the placement constraints.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithPlacement(Placement placement)
        {
            this.placementField = placement;
            return this;
        }

        /// <summary>
        /// Checks if Placement property is set
        /// </summary>
        /// <returns>true if Placement property is set</returns>
        public bool IsSetPlacement()
        {
            return this.placementField != null;
        }

        /// <summary>
        /// The ID of the kernel with which to launch the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "KernelId")]
        public string KernelId
        {
            get { return this.kernelIdField; }
            set { this.kernelIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the kernel with which to launch the instance.
        /// </summary>
        /// <param name="kernelId">The ID of the kernel with which to launch the
        /// instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithKernelId(string kernelId)
        {
            this.kernelIdField = kernelId;
            return this;
        }

        /// <summary>
        /// Checks if KernelId property is set
        /// </summary>
        /// <returns>true if KernelId property is set</returns>
        public bool IsSetKernelId()
        {
            return this.kernelIdField != null;
        }

        /// <summary>
        /// The ID of the RAM disk with which to launch the instance.
        /// Some kernels require additional drivers at launch.
        /// Check the kernel requirements for information on whether you need
        /// to specify a RAM disk. To find kernel requirements, go to the
        /// Resource Center and search for the kernel ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "RamdiskId")]
        public string RamdiskId
        {
            get { return this.ramdiskIdField; }
            set { this.ramdiskIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the RAM disk with which to launch the instance.
        /// </summary>
        /// <param name="ramdiskId">The ID of the RAM disk with which to launch
        /// the instance. Some kernels
        /// require additional drivers at launch.
        /// Check the kernel requirements for
        /// information on whether you need
        /// to specify a RAM disk. To find kernel
        /// requirements, go to the
        /// Resource Center and search for the
        /// kernel ID.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithRamdiskId(string ramdiskId)
        {
            this.ramdiskIdField = ramdiskId;
            return this;
        }

        /// <summary>
        /// Checks if RamdiskId property is set
        /// </summary>
        /// <returns>true if RamdiskId property is set</returns>
        public bool IsSetRamdiskId()
        {
            return this.ramdiskIdField != null;
        }

        /// <summary>
        /// Block device mapping.
        /// </summary>
        [XmlElementAttribute(ElementName = "BlockDeviceMapping")]
        public List<BlockDeviceMapping> BlockDeviceMapping
        {
            get
            {
                if (this.blockDeviceMappingField == null)
                {
                    this.blockDeviceMappingField = new List<BlockDeviceMapping>();
                }
                return this.blockDeviceMappingField;
            }
            set { this.blockDeviceMappingField = value; }
        }

        /// <summary>
        /// Sets the block device mapping.
        /// </summary>
        /// <param name="list">Block device mapping.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithBlockDeviceMapping(params BlockDeviceMapping[] list)
        {
            foreach (BlockDeviceMapping item in list)
            {
                BlockDeviceMapping.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if BlockDeviceMapping property is set
        /// </summary>
        /// <returns>true if BlockDeviceMapping property is set</returns>
        public bool IsSetBlockDeviceMapping()
        {
            return (BlockDeviceMapping.Count > 0);
        }

        /// <summary>
        /// Monitoring for the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "Monitoring")]
        public MonitoringSpecification Monitoring
        {
            get { return this.monitoringField; }
            set { this.monitoringField = value; }
        }

        /// <summary>
        /// Sets the monitoring for the instance.
        /// </summary>
        /// <param name="monitoring">Enables monitoring for the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithMonitoring(MonitoringSpecification monitoring)
        {
            this.monitoringField = monitoring;
            return this;
        }

        /// <summary>
        /// Checks if Monitoring property is set
        /// </summary>
        /// <returns>true if Monitoring property is set</returns>
        public bool IsSetMonitoring()
        {
            return this.monitoringField != null;
        }

        /// <summary>
        /// The subnet ID within which to launch the instance(s) for Amazon
        /// Virtual Private Cloud.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubnetId")]
        public string SubnetId
        {
            get { return this.subnetIdField; }
            set { this.subnetIdField = value; }
        }

        /// <summary>
        /// Sets the subnet ID within which to launch the instance(s) for Amazon
        /// Virtual Private Cloud.
        /// </summary>
        /// <param name="subnetId">Specifies the subnet ID within which to launch
        /// the instance(s) for
        /// Amazon Virtual Private Cloud.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithSubnetId(string subnetId)
        {
            this.subnetIdField = subnetId;
            return this;
        }

        /// <summary>
        /// Checks if SubnetId property is set
        /// </summary>
        /// <returns>true if SubnetId property is set</returns>
        public bool IsSetSubnetId()
        {
            return this.subnetIdField != null;
        }

        /// <summary>
        /// Whether the instance can be terminated using the APIs.
        /// You must modify this attribute before you can terminate any "locked"
        /// instances from the APIs.
        /// </summary>
        [XmlElementAttribute(ElementName = "DisableApiTermination")]
        public bool DisableApiTermination
        {
            get { return this.disableApiTerminationField.GetValueOrDefault(); }
            set { this.disableApiTerminationField = value; }
        }

        /// <summary>
        /// Sets whether the instance can be terminated using the APIs.
        /// </summary>
        /// <param name="disableApiTermination">Specifies whether the instance can be
        /// terminated using the APIs. You must modify this attribute before
        /// you can terminate any "locked" instances from the APIs.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithDisableApiTermination(bool disableApiTermination)
        {
            this.disableApiTerminationField = disableApiTermination;
            return this;
        }

        /// <summary>
        /// Checks if DisableApiTermination property is set
        /// </summary>
        /// <returns>true if DisableApiTermination property is set</returns>
        public bool IsSetDisableApiTermination()
        {
            return this.disableApiTerminationField.HasValue;
        }

        /// <summary>
        /// Whether the instance's Amazon EBS volumes are stopped or terminated
        /// when the instance is shut down.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceInitiatedShutdownBehavior")]
        public string InstanceInitiatedShutdownBehavior
        {
            get { return this.instanceInitiatedShutdownBehaviorField; }
            set { this.instanceInitiatedShutdownBehaviorField = value; }
        }

        /// <summary>
        /// Sets whether the instance's Amazon EBS volumes are stopped or terminated
        /// when the instance is shut down.
        /// </summary>
        /// <param name="instanceInitiatedShutdownBehavior">Specifies whether the instance's Amazon EBS
        /// volumes are stopped or terminated when the instance is shut
        /// down.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithInstanceInitiatedShutdownBehavior(string instanceInitiatedShutdownBehavior)
        {
            this.instanceInitiatedShutdownBehaviorField = instanceInitiatedShutdownBehavior;
            return this;
        }

        /// <summary>
        /// Checks if InstanceInitiatedShutdownBehavior property is set
        /// </summary>
        /// <returns>true if InstanceInitiatedShutdownBehavior property is set</returns>
        public bool IsSetInstanceInitiatedShutdownBehavior()
        {
            return this.instanceInitiatedShutdownBehaviorField != null;
        }

        /// <summary>
        /// Active licenses in use and attached to an Amazon EC2 instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "License")]
        public InstanceLicenseSpecification License
        {
            get { return this.licenseField; }
            set { this.licenseField = value; }
        }

        /// <summary>
        /// Sets the active licenses in use and attached to an Amazon EC2 instance.
        /// </summary>
        /// <param name="license">Specifies active licenses in use and attached
        /// to an Amazon EC2 instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithLicense(InstanceLicenseSpecification license)
        {
            this.licenseField = license;
            return this;
        }

        /// <summary>
        /// Checks if License property is set
        /// </summary>
        /// <returns>true if License property is set</returns>
        public bool IsSetLicense()
        {
            return this.licenseField != null;
        }

        /// <summary>
        /// Private IP address for this instance.
        /// <remarks>
        /// If you're using Amazon Virtual Private Cloud, you can optionally use this
        /// parameter to assign the instance a specific available IP address from the
        /// subnet.
        /// </remarks>
        /// </summary>
        [XmlElementAttribute(ElementName = "PrivateIpAddress")]
        public string PrivateIpAddress
        {
            get { return this.privateIpAddressField; }
            set { this.privateIpAddressField = value; }
        }

        /// <summary>
        /// Sets the private IP address for this instance.
        /// </summary>
        /// <param name="privateIpAddress">If you're using Amazon Virtual Private Cloud,
        /// you can optionally use this
        /// parameter to assign the instance a
        /// specific available IP address from the
        /// subnet.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithPrivateIpAddress(string privateIpAddress)
        {
            this.privateIpAddressField = privateIpAddress;
            return this;
        }

        /// <summary>
        /// Checks if PrivateIpAddress property is set
        /// </summary>
        /// <returns>true if PrivateIpAddress property is set</returns>
        public bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddressField != null;
        }

        /// <summary>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of the request.
        /// </summary>
        [XmlElementAttribute(ElementName = "ClientToken")]
        public string ClientToken
        {
            get { return this.clientTokenField; }
            set { this.clientTokenField = value; }
        }

        /// <summary>
        /// Sets the unique, case-sensitive identifier to ensure idempotency of the request.
        /// </summary>
        /// <param name="clientToken">ClientToken property</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithClientToken(string clientToken)
        {
            this.clientTokenField = clientToken;
            return this;
        }

        /// <summary>
        /// Checks if ClientToken property is set
        /// </summary>
        /// <returns>true if ClientToken property is set</returns>
        public bool IsSetClientToken()
        {
            return this.clientTokenField != null;
        }

        /// <summary>
        /// A set of one or more existing network interfaces to attach to the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceSet")]
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaceSet
        {
            get
            {
                if (this.networkInterfaceSetField == null)
                {
                    this.networkInterfaceSetField = new List<InstanceNetworkInterfaceSpecification>();
                }
                return this.networkInterfaceSetField;
            }
            set { this.networkInterfaceSetField = value; }
        }

        /// <summary>
        /// Sets one or more existing network interfaces to attach to the instance.
        /// </summary>
        /// <param name="list">A set of one or more existing network interfaces to attach to the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithNetworkInterfaceSet(params InstanceNetworkInterfaceSpecification[] list)
        {
            foreach (InstanceNetworkInterfaceSpecification item in list)
            {
                this.NetworkInterfaceSet.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the NetworkInterfaceSet property is set
        /// </summary>
        /// <returns>true if the NetworkInterfaceSet property is set</returns>
        public bool IsSetNetworkInterfaceSet()
        {
            return (this.NetworkInterfaceSet.Count > 0);
        }

        /// <summary>
        /// Whether to use the EBS IOPS optimized option.
        /// </summary>
        [XmlElementAttribute(ElementName = "EbsOptimized")]
        public bool EbsOptimized
        {
            get { return this.ebsOptimizedField.GetValueOrDefault(); }
            set { this.ebsOptimizedField = value; }
        }

        /// <summary>
        /// Sets whether to use the EBS IOPS optimized option.
        /// </summary>
        /// <param name="ebsOptimized">Specifies whether to use the EBS
        /// IOPS optimized option.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithEbsOptimized(bool ebsOptimized)
        {
            this.ebsOptimizedField = ebsOptimized;
            return this;
        }

        /// <summary>
        /// Checks if EbsOptimized property is set
        /// </summary>
        /// <returns>true if EbsOptimized property is set</returns>
        public bool IsSetEbsOptimized()
        {
            return this.ebsOptimizedField.HasValue;
        }


        /// <summary>
        /// An Identity and Access Management Instance Profile to associate with the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceProfile")]
        public IAMInstanceProfile InstanceProfile
        {
            get { return this.instanceProfileField; }
            set { this.instanceProfileField = value; }
        }

        /// <summary>
        /// Sets an Identity and Access Management Instance Profile to associate with the instance.
        /// </summary>
        /// <param name="instanceProfile">
        /// An Identity and Access Management Instance Profile to associate with the instance.
        /// </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public RunInstancesRequest WithInstanceProfile(IAMInstanceProfile instanceProfile)
        {
            this.instanceProfileField = instanceProfile;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceProfile property is set
        /// </summary>
        /// <returns>true if the InstanceProfile property is set</returns>
        public bool IsSetInstanceProfile()
        {
            return this.instanceProfileField != null;
        }

    }
}
