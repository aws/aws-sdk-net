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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// The information to include in the launch template.
    /// </summary>
    public partial class RequestLaunchTemplateData
    {
        private List<LaunchTemplateBlockDeviceMappingRequest> _blockDeviceMappings = new List<LaunchTemplateBlockDeviceMappingRequest>();
        private CreditSpecificationRequest _creditSpecification;
        private bool? _disableApiTermination;
        private bool? _ebsOptimized;
        private List<ElasticGpuSpecification> _elasticGpuSpecifications = new List<ElasticGpuSpecification>();
        private LaunchTemplateIamInstanceProfileSpecificationRequest _iamInstanceProfile;
        private string _imageId;
        private ShutdownBehavior _instanceInitiatedShutdownBehavior;
        private LaunchTemplateInstanceMarketOptionsRequest _instanceMarketOptions;
        private InstanceType _instanceType;
        private string _kernelId;
        private string _keyName;
        private LaunchTemplatesMonitoringRequest _monitoring;
        private List<LaunchTemplateInstanceNetworkInterfaceSpecificationRequest> _networkInterfaces = new List<LaunchTemplateInstanceNetworkInterfaceSpecificationRequest>();
        private LaunchTemplatePlacementRequest _placement;
        private string _ramDiskId;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _securityGroups = new List<string>();
        private List<LaunchTemplateTagSpecificationRequest> _tagSpecifications = new List<LaunchTemplateTagSpecificationRequest>();
        private string _userData;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mapping.
        /// </para>
        ///  <important> 
        /// <para>
        /// Supplying both a snapshot ID and an encryption value as arguments for block-device
        /// mapping results in an error. This is because only blank volumes can be encrypted on
        /// start, and these are not created from a snapshot. If a snapshot is the basis for the
        /// volume, it contains data by definition and its encryption status cannot be changed
        /// using this action.
        /// </para>
        ///  </important>
        /// </summary>
        public List<LaunchTemplateBlockDeviceMappingRequest> BlockDeviceMappings
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
        /// Gets and sets the property CreditSpecification. 
        /// <para>
        /// The credit option for CPU usage of the instance. Valid for T2 instances only.
        /// </para>
        /// </summary>
        public CreditSpecificationRequest CreditSpecification
        {
            get { return this._creditSpecification; }
            set { this._creditSpecification = value; }
        }

        // Check to see if CreditSpecification property is set
        internal bool IsSetCreditSpecification()
        {
            return this._creditSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property DisableApiTermination. 
        /// <para>
        /// If set to <code>true</code>, you can't terminate the instance using the Amazon EC2
        /// console, CLI, or API. To change this attribute to <code>false</code> after launch,
        /// use <a>ModifyInstanceAttribute</a>.
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
        /// Indicates whether the instance is optimized for Amazon EBS I/O. This optimization
        /// provides dedicated throughput to Amazon EBS and an optimized configuration stack to
        /// provide optimal Amazon EBS I/O performance. This optimization isn't available with
        /// all instance types. Additional usage charges apply when using an EBS-optimized instance.
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
        /// Gets and sets the property ElasticGpuSpecifications. 
        /// <para>
        /// An elastic GPU to associate with the instance.
        /// </para>
        /// </summary>
        public List<ElasticGpuSpecification> ElasticGpuSpecifications
        {
            get { return this._elasticGpuSpecifications; }
            set { this._elasticGpuSpecifications = value; }
        }

        // Check to see if ElasticGpuSpecifications property is set
        internal bool IsSetElasticGpuSpecifications()
        {
            return this._elasticGpuSpecifications != null && this._elasticGpuSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM instance profile.
        /// </para>
        /// </summary>
        public LaunchTemplateIamInstanceProfileSpecificationRequest IamInstanceProfile
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
        /// The ID of the AMI, which you can get by using <a>DescribeImages</a>.
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
        /// Gets and sets the property InstanceMarketOptions. 
        /// <para>
        /// The market (purchasing) option for the instances.
        /// </para>
        /// </summary>
        public LaunchTemplateInstanceMarketOptionsRequest InstanceMarketOptions
        {
            get { return this._instanceMarketOptions; }
            set { this._instanceMarketOptions = value; }
        }

        // Check to see if InstanceMarketOptions property is set
        internal bool IsSetInstanceMarketOptions()
        {
            return this._instanceMarketOptions != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html">User
        /// Provided Kernels</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// If you do not specify a key pair, you can't connect to the instance unless you choose
        /// an AMI that is configured to allow users another way to log in.
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
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// The monitoring for the instance.
        /// </para>
        /// </summary>
        public LaunchTemplatesMonitoringRequest Monitoring
        {
            get { return this._monitoring; }
            set { this._monitoring = value; }
        }

        // Check to see if Monitoring property is set
        internal bool IsSetMonitoring()
        {
            return this._monitoring != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// One or more network interfaces.
        /// </para>
        /// </summary>
        public List<LaunchTemplateInstanceNetworkInterfaceSpecificationRequest> NetworkInterfaces
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
        public LaunchTemplatePlacementRequest Placement
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
        /// Gets and sets the property RamDiskId. 
        /// <para>
        /// The ID of the RAM disk.
        /// </para>
        ///  <important> 
        /// <para>
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html">User
        /// Provided Kernels</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public string RamDiskId
        {
            get { return this._ramDiskId; }
            set { this._ramDiskId = value; }
        }

        // Check to see if RamDiskId property is set
        internal bool IsSetRamDiskId()
        {
            return this._ramDiskId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// One or more security group IDs. You can create a security group using <a>CreateSecurityGroup</a>.
        /// You cannot specify both a security group ID and security name in the same request.
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
        /// you must use security group IDs instead. You cannot specify both a security group
        /// ID and security name in the same request.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the resources during launch. You can tag instances and volumes.
        /// The specified tags are applied to all instances or volumes that are created during
        /// launch.
        /// </para>
        /// </summary>
        public List<LaunchTemplateTagSpecificationRequest> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// The Base64-encoded user data to make available to the instance. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/user-data.html">Running
        /// Commands on Your Linux Instance at Launch</a> (Linux) and <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ec2-instance-metadata.html#instancedata-add-user-data">Adding
        /// User Data</a> (Windows).
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