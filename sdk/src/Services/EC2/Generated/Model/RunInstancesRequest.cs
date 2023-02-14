/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

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
    /// You can specify a number of options, or leave the default options. The following rules
    /// apply:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// [EC2-VPC] If you don't specify a subnet ID, we choose a default subnet from your default
    /// VPC for you. If you don't have a default VPC, you must specify a subnet ID in the
    /// request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// [EC2-Classic] If don't specify an Availability Zone, we choose one for you.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Some instance types must be launched into a VPC. If you do not have a default VPC,
    /// or if you do not specify a subnet ID, the request fails. For more information, see
    /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-vpc.html#vpc-only-instance-types">Instance
    /// types available only in a VPC</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// [EC2-VPC] All instances have a network interface with a primary private IPv4 address.
    /// If you don't specify this address, we choose one from the IPv4 range of your subnet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Not all instance types support IPv6 addresses. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
    /// types</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you don't specify a security group ID, we use the default security group. For more
    /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
    /// groups</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If any of the AMIs have a product code attached for which the user has not subscribed,
    /// the request fails.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can create a <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
    /// template</a>, which is a resource that contains the parameters to launch an instance.
    /// When you launch an instance using <a>RunInstances</a>, you can specify the launch
    /// template instead of specifying the launch parameters.
    /// </para>
    ///  
    /// <para>
    /// To ensure faster instance launches, break up large requests into smaller batches.
    /// For example, create five separate launch requests for 100 instances each instead of
    /// one launch request for 500 instances.
    /// </para>
    ///  
    /// <para>
    /// An instance is ready for you to use when it's in the <code>running</code> state. You
    /// can check the state of your instance using <a>DescribeInstances</a>. You can tag instances
    /// and EBS volumes during launch, after launch, or both. For more information, see <a>CreateTags</a>
    /// and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
    /// your Amazon EC2 resources</a>.
    /// </para>
    ///  
    /// <para>
    /// Linux instances have access to the public key of the key pair at boot. You can use
    /// this key to provide secure access to the instance. Amazon EC2 public images use this
    /// feature to provide secure access without passwords. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
    /// pairs</a>.
    /// </para>
    ///  
    /// <para>
    /// For troubleshooting, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_InstanceStraightToTerminated.html">What
    /// to do if an instance immediately terminates</a>, and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecting.html">Troubleshooting
    /// connecting to your instance</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// We are retiring EC2-Classic. We recommend that you migrate from EC2-Classic to a VPC.
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
    /// from EC2-Classic to a VPC</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RunInstancesRequest : AmazonEC2Request
    {
        private string _additionalInfo;
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private CapacityReservationSpecification _capacityReservationSpecification;
        private string _clientToken;
        private CpuOptionsRequest _cpuOptions;
        private CreditSpecificationRequest _creditSpecification;
        private bool? _disableApiStop;
        private bool? _disableApiTermination;
        private bool? _ebsOptimized;
        private List<ElasticGpuSpecification> _elasticGpuSpecification = new List<ElasticGpuSpecification>();
        private List<ElasticInferenceAccelerator> _elasticInferenceAccelerators = new List<ElasticInferenceAccelerator>();
        private EnclaveOptionsRequest _enclaveOptions;
        private HibernationOptionsRequest _hibernationOptions;
        private IamInstanceProfileSpecification _iamInstanceProfile;
        private string _imageId;
        private ShutdownBehavior _instanceInitiatedShutdownBehavior;
        private InstanceMarketOptionsRequest _instanceMarketOptions;
        private InstanceType _instanceType;
        private int? _ipv6AddressCount;
        private List<InstanceIpv6Address> _ipv6Addresses = new List<InstanceIpv6Address>();
        private string _kernelId;
        private string _keyName;
        private LaunchTemplateSpecification _launchTemplate;
        private List<LicenseConfigurationRequest> _licenseSpecifications = new List<LicenseConfigurationRequest>();
        private InstanceMaintenanceOptionsRequest _maintenanceOptions;
        private int? _maxCount;
        private InstanceMetadataOptionsRequest _metadataOptions;
        private int? _minCount;
        private bool? _monitoring;
        private List<InstanceNetworkInterfaceSpecification> _networkInterfaces = new List<InstanceNetworkInterfaceSpecification>();
        private Placement _placement;
        private PrivateDnsNameOptionsRequest _privateDnsNameOptions;
        private string _privateIpAddress;
        private string _ramdiskId;
        private List<string> _securityGroupIds = new List<string>();
        private List<string> _securityGroups = new List<string>();
        private string _subnetId;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private string _userData;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RunInstancesRequest() { }

        /// <summary>
        /// Instantiates RunInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="imageId">The ID of the AMI. An AMI ID is required to launch an instance and must be specified here or in a launch template.</param>
        /// <param name="minCount">The minimum number of instances to launch. If you specify a minimum that is more instances than Amazon EC2 can launch in the target Availability Zone, Amazon EC2 launches no instances. Constraints: Between 1 and the maximum number you're allowed for the specified instance type. For more information about the default limits, and how to request an increase, see <a href="http://aws.amazon.com/ec2/faqs/#How_many_instances_can_I_run_in_Amazon_EC2">How many instances can I run in Amazon EC2</a> in the Amazon EC2 General FAQ.</param>
        /// <param name="maxCount">The maximum number of instances to launch. If you specify more instances than Amazon EC2 can launch in the target Availability Zone, Amazon EC2 launches the largest possible number of instances above <code>MinCount</code>. Constraints: Between 1 and the maximum number you're allowed for the specified instance type. For more information about the default limits, and how to request an increase, see <a href="http://aws.amazon.com/ec2/faqs/#How_many_instances_can_I_run_in_Amazon_EC2">How many instances can I run in Amazon EC2</a> in the Amazon EC2 FAQ.</param>
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
        /// The block device mapping, which defines the EBS volumes and instance store volumes
        /// to attach to the instance at launch. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html">Block
        /// device mappings</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// Information about the Capacity Reservation targeting option. If you do not specify
        /// this parameter, the instance's Capacity Reservation preference defaults to <code>open</code>,
        /// which enables it to run in any open Capacity Reservation that has matching attributes
        /// (instance type, platform, Availability Zone).
        /// </para>
        /// </summary>
        public CapacityReservationSpecification CapacityReservationSpecification
        {
            get { return this._capacityReservationSpecification; }
            set { this._capacityReservationSpecification = value; }
        }

        // Check to see if CapacityReservationSpecification property is set
        internal bool IsSetCapacityReservationSpecification()
        {
            return this._capacityReservationSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure the idempotency of the request.
        /// If you do not specify a client token, a randomly generated token is used for the request
        /// to ensure idempotency.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a>.
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
        /// Gets and sets the property CpuOptions. 
        /// <para>
        /// The CPU options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-optimize-cpu.html">Optimize
        /// CPU options</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public CpuOptionsRequest CpuOptions
        {
            get { return this._cpuOptions; }
            set { this._cpuOptions = value; }
        }

        // Check to see if CpuOptions property is set
        internal bool IsSetCpuOptions()
        {
            return this._cpuOptions != null;
        }

        /// <summary>
        /// Gets and sets the property CreditSpecification. 
        /// <para>
        /// The credit option for CPU usage of the burstable performance instance. Valid values
        /// are <code>standard</code> and <code>unlimited</code>. To change this attribute after
        /// launch, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyInstanceCreditSpecification.html">
        /// ModifyInstanceCreditSpecification</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <code>standard</code> (T2 instances) or <code>unlimited</code> (T3/T3a/T4g
        /// instances)
        /// </para>
        ///  
        /// <para>
        /// For T3 instances with <code>host</code> tenancy, only <code>standard</code> is supported.
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
        /// Gets and sets the property DisableApiStop. 
        /// <para>
        /// Indicates whether an instance is enabled for stop protection. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html#Using_StopProtection">Stop
        /// protection</a>. 
        /// </para>
        /// </summary>
        public bool DisableApiStop
        {
            get { return this._disableApiStop.GetValueOrDefault(); }
            set { this._disableApiStop = value; }
        }

        // Check to see if DisableApiStop property is set
        internal bool IsSetDisableApiStop()
        {
            return this._disableApiStop.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DisableApiTermination. 
        /// <para>
        /// If you set this parameter to <code>true</code>, you can't terminate the instance using
        /// the Amazon EC2 console, CLI, or API; otherwise, you can. To change this attribute
        /// after launch, use <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyInstanceAttribute.html">ModifyInstanceAttribute</a>.
        /// Alternatively, if you set <code>InstanceInitiatedShutdownBehavior</code> to <code>terminate</code>,
        /// you can terminate the instance by running the shutdown command from the instance.
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
        /// Indicates whether the instance is optimized for Amazon EBS I/O. This optimization
        /// provides dedicated throughput to Amazon EBS and an optimized configuration stack to
        /// provide optimal Amazon EBS I/O performance. This optimization isn't available with
        /// all instance types. Additional usage charges apply when using an EBS-optimized instance.
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
        /// Gets and sets the property ElasticGpuSpecification. 
        /// <para>
        /// An elastic GPU to associate with the instance. An Elastic GPU is a GPU resource that
        /// you can attach to your Windows instance to accelerate the graphics performance of
        /// your applications. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/elastic-graphics.html">Amazon
        /// EC2 Elastic GPUs</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public List<ElasticGpuSpecification> ElasticGpuSpecification
        {
            get { return this._elasticGpuSpecification; }
            set { this._elasticGpuSpecification = value; }
        }

        // Check to see if ElasticGpuSpecification property is set
        internal bool IsSetElasticGpuSpecification()
        {
            return this._elasticGpuSpecification != null && this._elasticGpuSpecification.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ElasticInferenceAccelerators. 
        /// <para>
        /// An elastic inference accelerator to associate with the instance. Elastic inference
        /// accelerators are a resource you can attach to your Amazon EC2 instances to accelerate
        /// your Deep Learning (DL) inference workloads.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify accelerators from different generations in the same request.
        /// </para>
        /// </summary>
        public List<ElasticInferenceAccelerator> ElasticInferenceAccelerators
        {
            get { return this._elasticInferenceAccelerators; }
            set { this._elasticInferenceAccelerators = value; }
        }

        // Check to see if ElasticInferenceAccelerators property is set
        internal bool IsSetElasticInferenceAccelerators()
        {
            return this._elasticInferenceAccelerators != null && this._elasticInferenceAccelerators.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        /// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
        /// For more information, see <a href="https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave.html">
        /// What is Amazon Web Services Nitro Enclaves?</a> in the <i>Amazon Web Services Nitro
        /// Enclaves User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't enable Amazon Web Services Nitro Enclaves and hibernation on the same instance.
        /// </para>
        /// </summary>
        public EnclaveOptionsRequest EnclaveOptions
        {
            get { return this._enclaveOptions; }
            set { this._enclaveOptions = value; }
        }

        // Check to see if EnclaveOptions property is set
        internal bool IsSetEnclaveOptions()
        {
            return this._enclaveOptions != null;
        }

        /// <summary>
        /// Gets and sets the property HibernationOptions. 
        /// <para>
        /// Indicates whether an instance is enabled for hibernation. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
        /// your instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't enable hibernation and Amazon Web Services Nitro Enclaves on the same instance.
        /// </para>
        /// </summary>
        public HibernationOptionsRequest HibernationOptions
        {
            get { return this._hibernationOptions; }
            set { this._hibernationOptions = value; }
        }

        // Check to see if HibernationOptions property is set
        internal bool IsSetHibernationOptions()
        {
            return this._hibernationOptions != null;
        }

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of an IAM instance profile.
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
        /// The ID of the AMI. An AMI ID is required to launch an instance and must be specified
        /// here or in a launch template.
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
        ///  
        /// <para>
        /// For <a>RunInstances</a>, persistent Spot Instance requests are only supported when
        /// <b>InstanceInterruptionBehavior</b> is set to either <code>hibernate</code> or <code>stop</code>.
        /// </para>
        /// </summary>
        public InstanceMarketOptionsRequest InstanceMarketOptions
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
        /// The instance type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Gets and sets the property Ipv6AddressCount. 
        /// <para>
        /// [EC2-VPC] The number of IPv6 addresses to associate with the primary network interface.
        /// Amazon EC2 chooses the IPv6 addresses from the range of your subnet. You cannot specify
        /// this option and the option to assign specific IPv6 addresses in the same request.
        /// You can specify this option if you've specified a minimum number of instances to launch.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this option and the network interfaces option in the same request.
        /// </para>
        /// </summary>
        public int Ipv6AddressCount
        {
            get { return this._ipv6AddressCount.GetValueOrDefault(); }
            set { this._ipv6AddressCount = value; }
        }

        // Check to see if Ipv6AddressCount property is set
        internal bool IsSetIpv6AddressCount()
        {
            return this._ipv6AddressCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Addresses. 
        /// <para>
        /// [EC2-VPC] The IPv6 addresses from the range of the subnet to associate with the primary
        /// network interface. You cannot specify this option and the option to assign a number
        /// of IPv6 addresses in the same request. You cannot specify this option if you've specified
        /// a minimum number of instances to launch.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this option and the network interfaces option in the same request.
        /// </para>
        /// </summary>
        public List<InstanceIpv6Address> Ipv6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if Ipv6Addresses property is set
        internal bool IsSetIpv6Addresses()
        {
            return this._ipv6Addresses != null && this._ipv6Addresses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The ID of the kernel.
        /// </para>
        ///  <important> 
        /// <para>
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html">PV-GRUB</a>
        /// in the <i>Amazon EC2 User Guide</i>.
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
        /// The name of the key pair. You can create a key pair using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateKeyPair.html">CreateKeyPair</a>
        /// or <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ImportKeyPair.html">ImportKeyPair</a>.
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
        /// Gets and sets the property LaunchTemplate. 
        /// <para>
        /// The launch template to use to launch the instances. Any parameters that you specify
        /// in <a>RunInstances</a> override the same parameters in the launch template. You can
        /// specify either the name or ID of a launch template, but not both.
        /// </para>
        /// </summary>
        public LaunchTemplateSpecification LaunchTemplate
        {
            get { return this._launchTemplate; }
            set { this._launchTemplate = value; }
        }

        // Check to see if LaunchTemplate property is set
        internal bool IsSetLaunchTemplate()
        {
            return this._launchTemplate != null;
        }

        /// <summary>
        /// Gets and sets the property LicenseSpecifications. 
        /// <para>
        /// The license configurations.
        /// </para>
        /// </summary>
        public List<LicenseConfigurationRequest> LicenseSpecifications
        {
            get { return this._licenseSpecifications; }
            set { this._licenseSpecifications = value; }
        }

        // Check to see if LicenseSpecifications property is set
        internal bool IsSetLicenseSpecifications()
        {
            return this._licenseSpecifications != null && this._licenseSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaintenanceOptions. 
        /// <para>
        /// The maintenance and recovery options for the instance.
        /// </para>
        /// </summary>
        public InstanceMaintenanceOptionsRequest MaintenanceOptions
        {
            get { return this._maintenanceOptions; }
            set { this._maintenanceOptions = value; }
        }

        // Check to see if MaintenanceOptions property is set
        internal bool IsSetMaintenanceOptions()
        {
            return this._maintenanceOptions != null;
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
        /// many instances can I run in Amazon EC2</a> in the Amazon EC2 FAQ.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html">Instance
        /// metadata and user data</a>.
        /// </para>
        /// </summary>
        public InstanceMetadataOptionsRequest MetadataOptions
        {
            get { return this._metadataOptions; }
            set { this._metadataOptions = value; }
        }

        // Check to see if MetadataOptions property is set
        internal bool IsSetMetadataOptions()
        {
            return this._metadataOptions != null;
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
        [AWSProperty(Required=true)]
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
        /// Specifies whether detailed monitoring is enabled for the instance.
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
        /// The network interfaces to associate with the instance. If you specify a network interface,
        /// you must specify any security groups and subnets as part of the network interface.
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
        /// Gets and sets the property PrivateDnsNameOptions. 
        /// <para>
        /// The options for the instance hostname. The default values are inherited from the subnet.
        /// </para>
        /// </summary>
        public PrivateDnsNameOptionsRequest PrivateDnsNameOptions
        {
            get { return this._privateDnsNameOptions; }
            set { this._privateDnsNameOptions = value; }
        }

        // Check to see if PrivateDnsNameOptions property is set
        internal bool IsSetPrivateDnsNameOptions()
        {
            return this._privateDnsNameOptions != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateIpAddress. 
        /// <para>
        /// [EC2-VPC] The primary IPv4 address. You must specify a value from the IPv4 address
        /// range of the subnet.
        /// </para>
        ///  
        /// <para>
        /// Only one private IP address can be designated as primary. You can't specify this option
        /// if you've specified the option to designate a private IP address as the primary IP
        /// address in a network interface specification. You cannot specify this option if you're
        /// launching more than one instance in the request.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this option and the network interfaces option in the same request.
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
        /// The ID of the RAM disk to select. Some kernels require additional drivers at launch.
        /// Check the kernel requirements for information about whether you need to specify a
        /// RAM disk. To find kernel requirements, go to the Amazon Web Services Resource Center
        /// and search for the kernel ID.
        /// </para>
        ///  <important> 
        /// <para>
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html">PV-GRUB</a>
        /// in the <i>Amazon EC2 User Guide</i>.
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
        /// The IDs of the security groups. You can create a security group using <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateSecurityGroup.html">CreateSecurityGroup</a>.
        /// </para>
        ///  
        /// <para>
        /// If you specify a network interface, you must specify any security groups as part of
        /// the network interface.
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
        /// [EC2-Classic, default VPC] The names of the security groups.
        /// </para>
        ///  
        /// <para>
        /// If you specify a network interface, you must specify any security groups as part of
        /// the network interface.
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
        ///  
        /// <para>
        /// If you specify a network interface, you must specify any subnets as part of the network
        /// interface.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the resources that are created during instance launch.
        /// </para>
        ///  
        /// <para>
        /// You can specify tags for the following resources only:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Instances
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Volumes
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Elastic graphics
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Spot Instance requests
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Network interfaces
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To tag a resource after it has been created, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_CreateTags.html">CreateTags</a>.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
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
        /// The user data script to make available to the instance. For more information, see
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/user-data.html">Run commands
        /// on your Linux instance at launch</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ec2-windows-user-data.html">Run
        /// commands on your Windows instance at launch</a>. If you are using a command line tool,
        /// base64-encoding is performed for you, and you can load the text from a file. Otherwise,
        /// you must provide base64-encoded text. User data is limited to 16 KB.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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