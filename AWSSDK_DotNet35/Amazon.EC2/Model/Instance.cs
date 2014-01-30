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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes an instance.</para>
    /// </summary>
    public class Instance
    {
        
        private string instanceId;
        private string imageId;
        private InstanceState state;
        private string privateDnsName;
        private string publicDnsName;
        private string stateTransitionReason;
        private string keyName;
        private int? amiLaunchIndex;
        private List<ProductCode> productCodes = new List<ProductCode>();
        private InstanceType instanceType;
        private DateTime? launchTime;
        private Placement placement;
        private string kernelId;
        private string ramdiskId;
        private PlatformValues platform;
        private Monitoring monitoring;
        private string subnetId;
        private string vpcId;
        private string privateIpAddress;
        private string publicIpAddress;
        private StateReason stateReason;
        private ArchitectureValues architecture;
        private DeviceType rootDeviceType;
        private string rootDeviceName;
        private List<InstanceBlockDeviceMapping> blockDeviceMappings = new List<InstanceBlockDeviceMapping>();
        private VirtualizationType virtualizationType;
        private InstanceLifecycleType instanceLifecycle;
        private string spotInstanceRequestId;
        private InstanceLicense license;
        private string clientToken;
        private List<Tag> tags = new List<Tag>();
        private List<GroupIdentifier> securityGroups = new List<GroupIdentifier>();
        private bool? sourceDestCheck;
        private HypervisorType hypervisor;
        private List<InstanceNetworkInterface> networkInterfaces = new List<InstanceNetworkInterface>();
        private IamInstanceProfile iamInstanceProfile;
        private bool? ebsOptimized;
        private string sriovNetSupport;


        /// <summary>
        /// The ID of the instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The ID of the AMI used to launch the instance.
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
        /// The current state of the instance.
        ///  
        /// </summary>
        public InstanceState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The private DNS name assigned to the instance. This DNS name can only be used inside the Amazon EC2 network. This name is not available
        /// until the instance enters the <c>running</c> state.
        ///  
        /// </summary>
        public string PrivateDnsName
        {
            get { return this.privateDnsName; }
            set { this.privateDnsName = value; }
        }

        // Check to see if PrivateDnsName property is set
        internal bool IsSetPrivateDnsName()
        {
            return this.privateDnsName != null;
        }

        /// <summary>
        /// The public DNS name assigned to the instance. This name is not available until the instance enters the <c>running</c> state.
        ///  
        /// </summary>
        public string PublicDnsName
        {
            get { return this.publicDnsName; }
            set { this.publicDnsName = value; }
        }

        // Check to see if PublicDnsName property is set
        internal bool IsSetPublicDnsName()
        {
            return this.publicDnsName != null;
        }

        /// <summary>
        /// The reason for the most recent state transition. This might be an empty string.
        ///  
        /// </summary>
        public string StateTransitionReason
        {
            get { return this.stateTransitionReason; }
            set { this.stateTransitionReason = value; }
        }

        // Check to see if StateTransitionReason property is set
        internal bool IsSetStateTransitionReason()
        {
            return this.stateTransitionReason != null;
        }

        /// <summary>
        /// The name of the key pair, if this instance was launched with an associated key pair.
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
        /// The AMI launch index, which can be used to find this instance in the launch group.
        ///  
        /// </summary>
        public int AmiLaunchIndex
        {
            get { return this.amiLaunchIndex ?? default(int); }
            set { this.amiLaunchIndex = value; }
        }

        // Check to see if AmiLaunchIndex property is set
        internal bool IsSetAmiLaunchIndex()
        {
            return this.amiLaunchIndex.HasValue;
        }

        /// <summary>
        /// The product codes attached to this instance.
        ///  
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this.productCodes; }
            set { this.productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this.productCodes.Count > 0;
        }

        /// <summary>
        /// The instance type.
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
        /// The time the instance was launched.
        ///  
        /// </summary>
        public DateTime LaunchTime
        {
            get { return this.launchTime ?? default(DateTime); }
            set { this.launchTime = value; }
        }

        // Check to see if LaunchTime property is set
        internal bool IsSetLaunchTime()
        {
            return this.launchTime.HasValue;
        }

        /// <summary>
        /// The location where the instance launched.
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
        /// The kernel associated with this instance.
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
        /// The RAM disk associated with this instance.
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
        /// The value is <c>Windows</c> for Windows instances; otherwise blank.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>Windows</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public PlatformValues Platform
        {
            get { return this.platform; }
            set { this.platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this.platform != null;
        }

        /// <summary>
        /// The monitoring information for the instance.
        ///  
        /// </summary>
        public Monitoring Monitoring
        {
            get { return this.monitoring; }
            set { this.monitoring = value; }
        }

        // Check to see if Monitoring property is set
        internal bool IsSetMonitoring()
        {
            return this.monitoring != null;
        }

        /// <summary>
        /// The ID of the subnet in which the instance is running.
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
        /// The ID of the VPC in which the instance is running.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// The private IP address assigned to the instance.
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
        /// The public IP address assigned to the instance.
        ///  
        /// </summary>
        public string PublicIpAddress
        {
            get { return this.publicIpAddress; }
            set { this.publicIpAddress = value; }
        }

        // Check to see if PublicIpAddress property is set
        internal bool IsSetPublicIpAddress()
        {
            return this.publicIpAddress != null;
        }

        /// <summary>
        /// The reason for the most recent state transition.
        ///  
        /// </summary>
        public StateReason StateReason
        {
            get { return this.stateReason; }
            set { this.stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this.stateReason != null;
        }

        /// <summary>
        /// The architecture of the image.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>i386, x86_64</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public ArchitectureValues Architecture
        {
            get { return this.architecture; }
            set { this.architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this.architecture != null;
        }

        /// <summary>
        /// The root device type used by the AMI. The AMI can use an Amazon EBS volume or an instance store volume.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ebs, instance-store</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public DeviceType RootDeviceType
        {
            get { return this.rootDeviceType; }
            set { this.rootDeviceType = value; }
        }

        // Check to see if RootDeviceType property is set
        internal bool IsSetRootDeviceType()
        {
            return this.rootDeviceType != null;
        }

        /// <summary>
        /// The root device name (for example, <c>/dev/sda1</c>).
        ///  
        /// </summary>
        public string RootDeviceName
        {
            get { return this.rootDeviceName; }
            set { this.rootDeviceName = value; }
        }

        // Check to see if RootDeviceName property is set
        internal bool IsSetRootDeviceName()
        {
            return this.rootDeviceName != null;
        }

        /// <summary>
        /// Any block device mapping entries for the instance.
        ///  
        /// </summary>
        public List<InstanceBlockDeviceMapping> BlockDeviceMappings
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
        /// The virtualization type of the instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>hvm, paravirtual</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VirtualizationType VirtualizationType
        {
            get { return this.virtualizationType; }
            set { this.virtualizationType = value; }
        }

        // Check to see if VirtualizationType property is set
        internal bool IsSetVirtualizationType()
        {
            return this.virtualizationType != null;
        }

        /// <summary>
        /// Indicates whether this is a Spot Instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>spot</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceLifecycleType InstanceLifecycle
        {
            get { return this.instanceLifecycle; }
            set { this.instanceLifecycle = value; }
        }

        // Check to see if InstanceLifecycle property is set
        internal bool IsSetInstanceLifecycle()
        {
            return this.instanceLifecycle != null;
        }

        /// <summary>
        /// The ID of the Spot Instance request.
        ///  
        /// </summary>
        public string SpotInstanceRequestId
        {
            get { return this.spotInstanceRequestId; }
            set { this.spotInstanceRequestId = value; }
        }

        // Check to see if SpotInstanceRequestId property is set
        internal bool IsSetSpotInstanceRequestId()
        {
            return this.spotInstanceRequestId != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public InstanceLicense License
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
        /// The idempotency token you provided when you launched the instance.
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
        /// Any tags assigned to the instance.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

        /// <summary>
        /// One or more security groups for the instance.
        ///  
        /// </summary>
        public List<GroupIdentifier> SecurityGroups
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
        /// Specifies whether to enable an instance launched in a VPC to perform NAT. This controls whether source/destination checking is enabled on
        /// the instance. A value of <c>true</c> means checking is enabled, and <c>false</c> means checking is disabled. The value must be <c>false</c>
        /// for the instance to perform NAT. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT Instances</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i>.
        ///  
        /// </summary>
        public bool SourceDestCheck
        {
            get { return this.sourceDestCheck ?? default(bool); }
            set { this.sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this.sourceDestCheck.HasValue;
        }

        /// <summary>
        /// The hypervisor type of the instance.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ovm, xen</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public HypervisorType Hypervisor
        {
            get { return this.hypervisor; }
            set { this.hypervisor = value; }
        }

        // Check to see if Hypervisor property is set
        internal bool IsSetHypervisor()
        {
            return this.hypervisor != null;
        }

        /// <summary>
        /// [EC2-VPC] One or more network interfaces for the instance.
        ///  
        /// </summary>
        public List<InstanceNetworkInterface> NetworkInterfaces
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
        /// The IAM instance profile associated with the instance.
        ///  
        /// </summary>
        public IamInstanceProfile IamInstanceProfile
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
        /// configuration stack to provide optimal I/O performance. This optimization isn't available with all instance types. Additional usage charges
        /// apply when using an EBS Optimized instance.
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

        /// <summary>
        /// Specifies whether enhanced networking is enabled.
        ///  
        /// </summary>
        public string SriovNetSupport
        {
            get { return this.sriovNetSupport; }
            set { this.sriovNetSupport = value; }
        }

        // Check to see if SriovNetSupport property is set
        internal bool IsSetSriovNetSupport()
        {
            return this.sriovNetSupport != null;
        }
    }
}
