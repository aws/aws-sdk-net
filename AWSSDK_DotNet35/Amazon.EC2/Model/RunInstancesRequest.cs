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
    /// the user has not subscribed, <c>RunInstances</c> fails.</para>
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
        /// The ID of the AMI, which you can get by calling <a>DescribeImages</a>.
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
        /// The minimum number of instances to launch. If you specify a minimum that is more instances than Amazon EC2 can launch in the target
        /// Availability Zone, Amazon EC2 launches no instances. Constraints: Between 1 and the maximum number allowed for your account (the default for
        /// each account is 20, but this limit can be increased).
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
        /// The maximum number of instances to launch. If you specify more instances than Amazon EC2 can launch in the target Availability Zone, Amazon
        /// EC2 launches the largest possible number of instances above <c>MinCount</c>. Constraints: Between 1 and the maximum number allowed for your
        /// account (the default limit for each account is 20, but this limit can be increased).
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
        /// The name of the key pair. You can create a key pair using <a>CreateKeyPair</a> or <a>ImportKeyPair</a>. <important> If you launch an
        /// instance without specifying a key pair, you can't connect to the instance. </important>
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
        /// [EC2-Classic, default VPC] One or more security group names. For a nondefault VPC, you must use security group IDs instead. Default: Amazon
        /// EC2 uses the default security group.
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

        /// <summary>
        /// One or more security group IDs. You can create a security group using <a>CreateSecurityGroup</a>. Default: Amazon EC2 uses the default
        /// security group.
        ///  
        /// </summary>
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
        /// The Base64-encoded MIME user data for the instances.
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
        /// The instance type. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. Default: <c>m1.small</c>
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>t1.micro, m1.small, m1.medium, m1.large, m1.xlarge, m3.xlarge, m3.2xlarge, m2.xlarge, m2.2xlarge, m2.4xlarge, cr1.8xlarge, i2.xlarge, i2.2xlarge, i2.4xlarge, i2.8xlarge, hi1.4xlarge, hs1.8xlarge, c1.medium, c1.xlarge, c3.large, c3.xlarge, c3.2xlarge, c3.4xlarge, c3.8xlarge, cc1.4xlarge, cc2.8xlarge, g2.2xlarge, cg1.4xlarge</description>
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
        /// The placement for the instance.
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
        /// The ID of the kernel. <important> We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html#pv-grub-a-new-amazon-kernel-image"> PV-GRUB: A New Amazon
        /// Kernel Image</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. </important>
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
        /// The ID of the RAM disk.
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
        /// The block device mapping.
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
        /// The monitoring for the instance.
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
        /// [EC2-VPC] The ID of the subnet to launch the instance into.
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
        /// If you set this parameter to <c>true</c>, you can't terminate the instance using the Amazon EC2 console, CLI, or API; otherwise, you can. If
        /// you set this parameter to <c>true</c> and then later want to be able to terminate the instance, you must first change the value of the
        /// <c>disableApiTermination</c> attribute to <c>false</c> using <a>ModifyInstanceAttribute</a>. Alternatively, if you set
        /// <c>InstanceInitiatedShutdownBehavior</c> to <c>terminate</c>, you can terminate the instance by running the shutdown command from the
        /// instance. Default: <c>false</c>
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
        /// Indicates whether an instance stops or terminates when you initiate shutdown from the instance (using the operating system command for
        /// system shutdown). Default: <c>stop</c>
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
        /// 
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
        /// [EC2-VPC] The primary IP address. You must specify a value from the IP address range of the subnet. Only one private IP address can be
        /// designated as primary. Therefore, you can't specify this parameter if <c>PrivateIpAddresses.n.Primary</c> is set to <c>true</c> and
        /// <c>PrivateIpAddresses.n.PrivateIpAddress</c> is set to an IP address. Default: We select an IP address from the IP address range of the
        /// subnet.
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
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">How to Ensure Idempotency</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>. Constraints: Maximum 64 ASCII characters
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
        /// 
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
        /// One or more network interfaces.
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

        /// <summary>
        /// The IAM instance profile.
        ///  
        /// </summary>
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

        /// <summary>
        /// Indicates whether the instance is optimized for EBS I/O. This optimization provides dedicated throughput to Amazon EBS and an optimized
        /// configuration stack to provide optimal Amazon EBS I/O performance. This optimization isn't available with all instance types. Additional
        /// usage charges apply when using an EBS-optimized instance. Default: <c>false</c>
        ///  
        /// </summary>
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
    
