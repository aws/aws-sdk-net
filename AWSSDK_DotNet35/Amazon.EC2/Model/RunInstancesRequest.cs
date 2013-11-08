/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RunInstances operation.
    /// <para> The RunInstances operation launches a specified number of instances. </para> <para> If Amazon EC2 cannot launch the minimum number
    /// AMIs you request, no instances launch. If there is insufficient capacity to launch the maximum number of AMIs you request, Amazon EC2
    /// launches as many as possible to satisfy the requested maximum values. </para> <para> Every instance is launched in a security group. If you
    /// do not specify a security group at launch, the instances start in your default security group. For more information on creating security
    /// groups, see CreateSecurityGroup. </para> <para> An optional instance type can be specified. For information about instance types, see
    /// Instance Types. </para> <para> You can provide an optional key pair ID for each image in the launch request (for more information, see
    /// CreateKeyPair). All instances that are created from images that use this key pair will have access to the associated public key at boot. You
    /// can use this key to provide secure access to an instance of an image on a per-instance basis. Amazon EC2 public images use this feature to
    /// provide secure access without passwords. </para> <para><b>IMPORTANT:</b> Launching public images without a key pair ID will leave them
    /// inaccessible. The public key material is made available to the instance at boot time by placing it in the openssh_id.pub file on a logical
    /// device that is exposed to the instance as /dev/sda2 (the ephemeral store). The format of this file is suitable for use as an entry within
    /// ~/.ssh/authorized_keys (the OpenSSH format). This can be done at boot (e.g., as part of rc.local) allowing for secure access without
    /// passwords. Optional user data can be provided in the launch request. All instances that collectively comprise the launch request have access
    /// to this data For more information, see Instance Metadata. </para> <para><b>NOTE:</b> If any of the AMIs have a product code attached for
    /// which the user has not subscribed, the RunInstances call will fail. </para> <para><b>IMPORTANT:</b> We strongly recommend using the 2.6.18
    /// Xen stock kernel with the c1.medium and c1.xlarge instances. Although the default Amazon EC2 kernels will work, the new kernels provide
    /// greater stability and performance for these instance types. For more information about kernels, see Kernels, RAM Disks, and Block Device
    /// Mappings. </para>
    /// </summary>
    public partial class RunInstancesRequest : AmazonEC2Request
    {
        private string imageId;
        private int? minCount;
        private int? maxCount;
        private string keyName;
        private List<string> securityGroups = new List<string>();
        private List<string> securityGroupIds = new List<string>();
        private string userData;
        private InstanceType instanceType;
        private Placement placement;
        private string kernelId;
        private string ramdiskId;
        private List<BlockDeviceMapping> blockDeviceMappings = new List<BlockDeviceMapping>();
        private bool? monitoring;
        private string subnetId;
        private bool? disableApiTermination;
        private ShutdownBehavior instanceInitiatedShutdownBehavior;
        private InstanceLicenseSpecification license;
        private string privateIpAddress;
        private string clientToken;
        private string additionalInfo;
        private List<InstanceNetworkInterfaceSpecification> networkInterfaces = new List<InstanceNetworkInterfaceSpecification>();
        private IamInstanceProfileSpecification iamInstanceProfile;
        private bool? ebsOptimized;


        /// <summary>
        /// Unique ID of a machine image, returned by a call to DescribeImages.
        ///  
        /// </summary>
        public string ImageId
        {
            get { return this.imageId; }
            set { this.imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this.imageId != null;
        }

        /// <summary>
        /// Minimum number of instances to launch. If the value is more than Amazon EC2 can launch, no instances are launched at all.
        ///  
        /// </summary>
        public int MinCount
        {
            get { return this.minCount ?? default(int); }
            set { this.minCount = value; }
        }

        // Check to see if MinCount property is set
        internal bool IsSetMinCount()
        {
            return this.minCount.HasValue;
        }

        /// <summary>
        /// Maximum number of instances to launch. If the value is more than Amazon EC2 can launch, the largest possible number above minCount will be
        /// launched instead. Between 1 and the maximum number allowed for your account (default: 20).
        ///  
        /// </summary>
        public int MaxCount
        {
            get { return this.maxCount ?? default(int); }
            set { this.maxCount = value; }
        }

        // Check to see if MaxCount property is set
        internal bool IsSetMaxCount()
        {
            return this.maxCount.HasValue;
        }

        /// <summary>
        /// The name of the key pair.
        ///  
        /// </summary>
        public string KeyName
        {
            get { return this.keyName; }
            set { this.keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this.keyName != null;
        }

        /// <summary>
        /// The names of the security groups into which the instances will be launched.
        ///  
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this.securityGroups; }
            set { this.securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this.securityGroups.Count > 0;
        }
        public List<string> SecurityGroupIds
        {
            get { return this.securityGroupIds; }
            set { this.securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this.securityGroupIds.Count > 0;
        }

        /// <summary>
        /// Specifies additional information to make available to the instance(s). This parameter must be passed as a Base64-encoded string.
        ///  
        /// </summary>
        public string UserData
        {
            get { return this.userData; }
            set { this.userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this.userData != null;
        }

        /// <summary>
        /// Specifies the instance type for the launched instances.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>t1.micro, m1.small, m1.medium, m1.large, m1.xlarge, m2.xlarge, m2.2xlarge, m2.4xlarge, m3.xlarge, m3.2xlarge, c1.medium, c1.xlarge, hi1.4xlarge, hs1.8xlarge, cc1.4xlarge, cc2.8xlarge, cg1.4xlarge, cr1.8xlarge</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// Specifies the placement constraints (Availability Zones) for launching the instances.
        ///  
        /// </summary>
        public Placement Placement
        {
            get { return this.placement; }
            set { this.placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this.placement != null;
        }

        /// <summary>
        /// The ID of the kernel with which to launch the instance.
        ///  
        /// </summary>
        public string KernelId
        {
            get { return this.kernelId; }
            set { this.kernelId = value; }
        }

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this.kernelId != null;
        }

        /// <summary>
        /// The ID of the RAM disk with which to launch the instance. Some kernels require additional drivers at launch. Check the kernel requirements
        /// for information on whether you need to specify a RAM disk. To find kernel requirements, go to the Resource Center and search for the kernel
        /// ID.
        ///  
        /// </summary>
        public string RamdiskId
        {
            get { return this.ramdiskId; }
            set { this.ramdiskId = value; }
        }

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this.ramdiskId != null;
        }

        /// <summary>
        /// Specifies how block devices are exposed to the instance. Each mapping is made up of a virtualName and a deviceName.
        ///  
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this.blockDeviceMappings; }
            set { this.blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this.blockDeviceMappings.Count > 0;
        }

        /// <summary>
        /// Enables monitoring for the instance.
        ///  
        /// </summary>
        public bool Monitoring
        {
            get { return this.monitoring ?? default(bool); }
            set { this.monitoring = value; }
        }

        // Check to see if Monitoring property is set
        internal bool IsSetMonitoring()
        {
            return this.monitoring.HasValue;
        }

        /// <summary>
        /// Specifies the subnet ID within which to launch the instance(s) for Amazon Virtual Private Cloud.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }

        /// <summary>
        /// Specifies whether the instance can be terminated using the APIs. You must modify this attribute before you can terminate any "locked"
        /// instances from the APIs.
        ///  
        /// </summary>
        public bool DisableApiTermination
        {
            get { return this.disableApiTermination ?? default(bool); }
            set { this.disableApiTermination = value; }
        }

        // Check to see if DisableApiTermination property is set
        internal bool IsSetDisableApiTermination()
        {
            return this.disableApiTermination.HasValue;
        }

        /// <summary>
        /// Specifies whether the instance's Amazon EBS volumes are stopped or terminated when the instance is shut down.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>stop, terminate</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ShutdownBehavior InstanceInitiatedShutdownBehavior
        {
            get { return this.instanceInitiatedShutdownBehavior; }
            set { this.instanceInitiatedShutdownBehavior = value; }
        }

        // Check to see if InstanceInitiatedShutdownBehavior property is set
        internal bool IsSetInstanceInitiatedShutdownBehavior()
        {
            return this.instanceInitiatedShutdownBehavior != null;
        }

        /// <summary>
        /// Specifies active licenses in use and attached to an Amazon EC2 instance.
        ///  
        /// </summary>
        public InstanceLicenseSpecification License
        {
            get { return this.license; }
            set { this.license = value; }
        }

        // Check to see if License property is set
        internal bool IsSetLicense()
        {
            return this.license != null;
        }

        /// <summary>
        /// If you're using Amazon Virtual Private Cloud, you can optionally use this parameter to assign the instance a specific available IP address
        /// from the subnet.
        ///  
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this.privateIpAddress; }
            set { this.privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddress != null;
        }

        /// <summary>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of the request. For more information, go to How to Ensure Idempotency in
        /// the Amazon Elastic Compute Cloud User Guide.
        ///  
        /// </summary>
        public string ClientToken
        {
            get { return this.clientToken; }
            set { this.clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this.clientToken != null;
        }

        /// <summary>
        /// Do not use. Reserved for internal use.
        ///  
        /// </summary>
        public string AdditionalInfo
        {
            get { return this.additionalInfo; }
            set { this.additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this.additionalInfo != null;
        }

        /// <summary>
        /// List of network interfaces associated with the instance.
        ///  
        /// </summary>
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces
        {
            get { return this.networkInterfaces; }
            set { this.networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this.networkInterfaces.Count > 0;
        }
        public IamInstanceProfileSpecification IamInstanceProfile
        {
            get { return this.iamInstanceProfile; }
            set { this.iamInstanceProfile = value; }
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this.iamInstanceProfile != null;
        }
        public bool EbsOptimized
        {
            get { return this.ebsOptimized ?? default(bool); }
            set { this.ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this.ebsOptimized.HasValue;
        }

    }
}
    
