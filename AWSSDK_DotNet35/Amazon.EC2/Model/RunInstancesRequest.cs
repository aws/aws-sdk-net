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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Launches the specified number of instances using an AMI for which you have permissions.
    /// 
    ///  
    /// <para>
    /// When you launch an instance, it enters the <code>pending</code> state. After the instance
    /// is ready for you, it enters the <code>running</code> state. To check the state of
    /// your instance, call <a>DescribeInstances</a>.
    /// </para>
    ///  
    /// <para>
    /// If you don't specify a security group when launching an instance, Amazon EC2 uses
    /// the default security group. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
    /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    ///  
    /// <para>
    /// Linux instances have access to the public key of the key pair at boot. You can use
    /// this key to provide secure access to the instance. Amazon EC2 public images use this
    /// feature to provide secure access without passwords. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
    /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    ///  
    /// <para>
    /// You can provide optional user data when launching an instance. For more information,
    /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html">Instance
    /// Metadata</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    ///  
    /// <para>
    /// If any of the AMIs have a product code attached for which the user has not subscribed,
    /// <code>RunInstances</code> fails.
    /// </para>
    ///  
    /// <para>
    /// T2 instance types can only be launched into a VPC. If you do not have a default VPC,
    /// or if you do not specify a subnet ID in the request, <code>RunInstances</code> fails.
    /// </para>
    ///  
    /// <para>
    /// For more information about troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_InstanceStraightToTerminated.html">What
    /// To Do If An Instance Immediately Terminates</a>, and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecting.html">Troubleshooting
    /// Connecting to Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide
    /// for Linux</i>.
    /// </para>
    /// </summary>
    public partial class RunInstancesRequest : AmazonEC2Request
    {
        private string _additionalInfo;
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private string _clientToken;
        private bool? _disableApiTermination;
        private bool? _ebsOptimized;
        private IamInstanceProfileSpecification _iamInstanceProfile;
        private string _imageId;
        private ShutdownBehavior _instanceInitiatedShutdownBehavior;
        private InstanceType _instanceType;
        private string _kernelId;
        private string _keyName;
        private int? _maxCount;
        private int? _minCount;
        private bool? _monitoring;
        private List<InstanceNetworkInterfaceSpecification> _networkInterfaces = new List<InstanceNetworkInterfaceSpecification>();
        private Placement _placement;
        private string _privateIpAddress;
        private string _ramdiskId;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _securityGroups = new List<string>();
        private string _subnetId;
        private string _userData;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RunInstancesRequest() { }

        /// <summary>
        /// Instantiates RunInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="imageId">The ID of the AMI, which you can get by calling <a>DescribeImages</a>.</param>
        /// <param name="minCount">The minimum number of instances to launch. If you specify a minimum that is more instances than Amazon EC2 can launch in the target Availability Zone, Amazon EC2 launches no instances. Constraints: Between 1 and the maximum number you're allowed for the specified instance type. For more information about the default limits, and how to request an increase, see <a href="http://aws.amazon.com/ec2/faqs/#How_many_instances_can_I_run_in_Amazon_EC2">How many instances can I run in Amazon EC2</a> in the Amazon EC2 General FAQ.</param>
        /// <param name="maxCount">The maximum number of instances to launch. If you specify more instances than Amazon EC2 can launch in the target Availability Zone, Amazon EC2 launches the largest possible number of instances above <code>MinCount</code>. Constraints: Between 1 and the maximum number you're allowed for the specified instance type. For more information about the default limits, and how to request an increase, see <a href="http://aws.amazon.com/ec2/faqs/#How_many_instances_can_I_run_in_Amazon_EC2">How many instances can I run in Amazon EC2</a> in the Amazon EC2 General FAQ.</param>
        public RunInstancesRequest(string imageId, int minCount, int maxCount)
        {
            _imageId = imageId;
            _minCount = minCount;
            _maxCount = maxCount;
        }

        /// <summary>
        /// Gets and sets the property AdditionalInfo. 
        /// <para>
        /// Reserved.
        /// </para>
        /// </summary>
        public string AdditionalInfo
        {
            get { return this._additionalInfo; }
            set { this._additionalInfo = value; }
        }

        // Check to see if AdditionalInfo property is set
        internal bool IsSetAdditionalInfo()
        {
            return this._additionalInfo != null;
        }

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mapping.
        /// </para>
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && this._blockDeviceMappings.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">How
        /// to Ensure Idempotency</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Maximum 64 ASCII characters
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property DisableApiTermination. 
        /// <para>
        /// If you set this parameter to <code>true</code>, you can't terminate the instance using
        /// the Amazon EC2 console, CLI, or API; otherwise, you can. If you set this parameter
        /// to <code>true</code> and then later want to be able to terminate the instance, you
        /// must first change the value of the <code>disableApiTermination</code> attribute to
        /// <code>false</code> using <a>ModifyInstanceAttribute</a>. Alternatively, if you set
        /// <code>InstanceInitiatedShutdownBehavior</code> to <code>terminate</code>, you can
        /// terminate the instance by running the shutdown command from the instance.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code>
        /// </para>
        /// </summary>
        public bool DisableApiTermination
        {
            get { return this._disableApiTermination.GetValueOrDefault(); }
            set { this._disableApiTermination = value; }
        }

        // Check to see if DisableApiTermination property is set
        internal bool IsSetDisableApiTermination()
        {
            return this._disableApiTermination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether the instance is optimized for EBS I/O. This optimization provides
        /// dedicated throughput to Amazon EBS and an optimized configuration stack to provide
        /// optimal Amazon EBS I/O performance. This optimization isn't available with all instance
        /// types. Additional usage charges apply when using an EBS-optimized instance.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code>
        /// </para>
        /// </summary>
        public bool EbsOptimized
        {
            get { return this._ebsOptimized.GetValueOrDefault(); }
            set { this._ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this._ebsOptimized.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM instance profile.
        /// </para>
        /// </summary>
        public IamInstanceProfileSpecification IamInstanceProfile
        {
            get { return this._iamInstanceProfile; }
            set { this._iamInstanceProfile = value; }
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this._iamInstanceProfile != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the AMI, which you can get by calling <a>DescribeImages</a>.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceInitiatedShutdownBehavior. 
        /// <para>
        /// Indicates whether an instance stops or terminates when you initiate shutdown from
        /// the instance (using the operating system command for system shutdown).
        /// </para>
        ///  
        /// <para>
        /// Default: <code>stop</code>
        /// </para>
        /// </summary>
        public ShutdownBehavior InstanceInitiatedShutdownBehavior
        {
            get { return this._instanceInitiatedShutdownBehavior; }
            set { this._instanceInitiatedShutdownBehavior = value; }
        }

        // Check to see if InstanceInitiatedShutdownBehavior property is set
        internal bool IsSetInstanceInitiatedShutdownBehavior()
        {
            return this._instanceInitiatedShutdownBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>m1.small</code>
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this._instanceType; }
            set { this._instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this._instanceType != null;
        }

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The ID of the kernel.
        /// </para>
        ///  <important> 
        /// <para>
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html">
        /// PV-GRUB</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public string KernelId
        {
            get { return this._kernelId; }
            set { this._kernelId = value; }
        }

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this._kernelId != null;
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the key pair. You can create a key pair using <a>CreateKeyPair</a> or
        /// <a>ImportKeyPair</a>.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you launch an instance without specifying a key pair, you can't connect to the
        /// instance.
        /// </para>
        ///  </important>
        /// </summary>
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCount. 
        /// <para>
        /// The maximum number of instances to launch. If you specify more instances than Amazon
        /// EC2 can launch in the target Availability Zone, Amazon EC2 launches the largest possible
        /// number of instances above <code>MinCount</code>.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Between 1 and the maximum number you're allowed for the specified instance
        /// type. For more information about the default limits, and how to request an increase,
        /// see <a href="http://aws.amazon.com/ec2/faqs/#How_many_instances_can_I_run_in_Amazon_EC2">How
        /// many instances can I run in Amazon EC2</a> in the Amazon EC2 General FAQ.
        /// </para>
        /// </summary>
        public int MaxCount
        {
            get { return this._maxCount.GetValueOrDefault(); }
            set { this._maxCount = value; }
        }

        // Check to see if MaxCount property is set
        internal bool IsSetMaxCount()
        {
            return this._maxCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinCount. 
        /// <para>
        /// The minimum number of instances to launch. If you specify a minimum that is more instances
        /// than Amazon EC2 can launch in the target Availability Zone, Amazon EC2 launches no
        /// instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Between 1 and the maximum number you're allowed for the specified instance
        /// type. For more information about the default limits, and how to request an increase,
        /// see <a href="http://aws.amazon.com/ec2/faqs/#How_many_instances_can_I_run_in_Amazon_EC2">How
        /// many instances can I run in Amazon EC2</a> in the Amazon EC2 General FAQ.
        /// </para>
        /// </summary>
        public int MinCount
        {
            get { return this._minCount.GetValueOrDefault(); }
            set { this._minCount = value; }
        }

        // Check to see if MinCount property is set
        internal bool IsSetMinCount()
        {
            return this._minCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// The monitoring for the instance.
        /// </para>
        /// </summary>
        public bool Monitoring
        {
            get { return this._monitoring.GetValueOrDefault(); }
            set { this._monitoring = value; }
        }

        // Check to see if Monitoring property is set
        internal bool IsSetMonitoring()
        {
            return this._monitoring.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// One or more network interfaces.
        /// </para>
        /// </summary>
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && this._networkInterfaces.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The placement for the instance.
        /// </para>
        /// </summary>
        public Placement Placement
        {
            get { return this._placement; }
            set { this._placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this._placement != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// [EC2-VPC] The primary IP address. You must specify a value from the IP address range
        /// of the subnet.
        /// </para>
        ///  
        /// <para>
        /// Only one private IP address can be designated as primary. Therefore, you can't specify
        /// this parameter if <code>PrivateIpAddresses.n.Primary</code> is set to <code>true</code>
        /// and <code>PrivateIpAddresses.n.PrivateIpAddress</code> is set to an IP address. 
        /// </para>
        ///  
        /// <para>
        /// Default: We select an IP address from the IP address range of the subnet.
        /// </para>
        /// </summary>
        public string PrivateIpAddress
        {
            get { return this._privateIpAddress; }
            set { this._privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this._privateIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The ID of the RAM disk.
        /// </para>
        ///  <important> 
        /// <para>
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html">
        /// PV-GRUB</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public string RamdiskId
        {
            get { return this._ramdiskId; }
            set { this._ramdiskId = value; }
        }

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this._ramdiskId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// One or more security group IDs. You can create a security group using <a>CreateSecurityGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: Amazon EC2 uses the default security group.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// [EC2-Classic, default VPC] One or more security group names. For a nondefault VPC,
        /// you must use security group IDs instead.
        /// </para>
        ///  
        /// <para>
        /// Default: Amazon EC2 uses the default security group.
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && this._securityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// [EC2-VPC] The ID of the subnet to launch the instance into.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// The Base64-encoded MIME user data for the instances.
        /// </para>
        /// </summary>
        public string UserData
        {
            get { return this._userData; }
            set { this._userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this._userData != null;
        }

    }
}