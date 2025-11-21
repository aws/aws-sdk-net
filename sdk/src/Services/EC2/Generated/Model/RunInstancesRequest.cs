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

#pragma warning disable CS0612,CS0618,CS1570
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
    /// If you don't specify a subnet ID, we choose a default subnet from your default VPC
    /// for you. If you don't have a default VPC, you must specify a subnet ID in the request.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All instances have a network interface with a primary private IPv4 address. If you
    /// don't specify this address, we choose one from the IPv4 range of your subnet.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Not all instance types support IPv6 addresses. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
    /// types</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you don't specify a security group ID, we use the default security group for the
    /// VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
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
    ///  <c>RunInstances</c> is subject to both request rate limiting and resource rate limiting.
    /// For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-throttling.html">Request
    /// throttling</a>.
    /// </para>
    ///  
    /// <para>
    /// An instance is ready for you to use when it's in the <c>running</c> state. You can
    /// check the state of your instance using <a>DescribeInstances</a>. You can tag instances
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
    /// </summary>
    public partial class RunInstancesRequest : AmazonEC2Request
    {
        private string _additionalInfo;
        private List<BlockDeviceMapping> _blockDeviceMappings = AWSConfigs.InitializeCollections ? new List<BlockDeviceMapping>() : null;
        private CapacityReservationSpecification _capacityReservationSpecification;
        private string _clientToken;
        private CpuOptionsRequest _cpuOptions;
        private CreditSpecificationRequest _creditSpecification;
        private bool? _disableApiStop;
        private bool? _disableApiTermination;
        private bool? _dryRun;
        private bool? _ebsOptimized;
        private List<ElasticGpuSpecification> _elasticGpuSpecification = AWSConfigs.InitializeCollections ? new List<ElasticGpuSpecification>() : null;
        private List<ElasticInferenceAccelerator> _elasticInferenceAccelerators = AWSConfigs.InitializeCollections ? new List<ElasticInferenceAccelerator>() : null;
        private bool? _enablePrimaryIpv6;
        private EnclaveOptionsRequest _enclaveOptions;
        private HibernationOptionsRequest _hibernationOptions;
        private IamInstanceProfileSpecification _iamInstanceProfile;
        private string _imageId;
        private ShutdownBehavior _instanceInitiatedShutdownBehavior;
        private InstanceMarketOptionsRequest _instanceMarketOptions;
        private InstanceType _instanceType;
        private int? _ipv6AddressCount;
        private List<InstanceIpv6Address> _ipv6Addresses = AWSConfigs.InitializeCollections ? new List<InstanceIpv6Address>() : null;
        private string _kernelId;
        private string _keyName;
        private LaunchTemplateSpecification _launchTemplate;
        private List<LicenseConfigurationRequest> _licenseSpecifications = AWSConfigs.InitializeCollections ? new List<LicenseConfigurationRequest>() : null;
        private InstanceMaintenanceOptionsRequest _maintenanceOptions;
        private int? _maxCount;
        private InstanceMetadataOptionsRequest _metadataOptions;
        private int? _minCount;
        private bool? _monitoring;
        private List<InstanceNetworkInterfaceSpecification> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<InstanceNetworkInterfaceSpecification>() : null;
        private InstanceNetworkPerformanceOptionsRequest _networkPerformanceOptions;
        private OperatorRequest _operator;
        private Placement _placement;
        private PrivateDnsNameOptionsRequest _privateDnsNameOptions;
        private string _privateIpAddress;
        private string _ramdiskId;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _subnetId;
        private List<TagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;
        private string _userData;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RunInstancesRequest() { }

        /// <summary>
        /// Instantiates RunInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="imageId">The ID of the AMI. An AMI ID is required to launch an instance and must be specified here or in a launch template.</param>
        /// <param name="minCount">The minimum number of instances to launch. If you specify a value that is more capacity than Amazon EC2 can provide in the target Availability Zone, Amazon EC2 does not launch any instances. Constraints: Between 1 and the quota for the specified instance type for your account for this Region. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-instance-quotas.html">Amazon EC2 instance type quotas</a>.</param>
        /// <param name="maxCount">The maximum number of instances to launch. If you specify a value that is more capacity than Amazon EC2 can launch in the target Availability Zone, Amazon EC2 launches the largest possible number of instances above the specified minimum count. Constraints: Between 1 and the quota for the specified instance type for your account for this Region. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-instance-quotas.html">Amazon EC2 instance type quotas</a>.</param>
        public RunInstancesRequest(string imageId, int? minCount, int? maxCount)
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this._blockDeviceMappings; }
            set { this._blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this._blockDeviceMappings != null && (this._blockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// Information about the Capacity Reservation targeting option. If you do not specify
        /// this parameter, the instance's Capacity Reservation preference defaults to <c>open</c>,
        /// which enables it to run in any open Capacity Reservation that has matching attributes
        /// (instance type, platform, Availability Zone, and tenancy).
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
        /// For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency in Amazon EC2 API requests</a>.
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
        /// are <c>standard</c> and <c>unlimited</c>. To change this attribute after launch, use
        /// <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_ModifyInstanceCreditSpecification.html">
        /// ModifyInstanceCreditSpecification</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/burstable-performance-instances.html">Burstable
        /// performance instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Default: <c>standard</c> (T2 instances) or <c>unlimited</c> (T3/T3a/T4g instances)
        /// </para>
        ///  
        /// <para>
        /// For T3 instances with <c>host</c> tenancy, only <c>standard</c> is supported.
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
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-stop-protection.html">Enable
        /// stop protection for your EC2 instances</a>.
        /// </para>
        /// </summary>
        public bool? DisableApiStop
        {
            get { return this._disableApiStop; }
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
        /// Indicates whether termination protection is enabled for the instance. The default
        /// is <c>false</c>, which means that you can terminate the instance using the Amazon
        /// EC2 console, command line tools, or API. You can enable termination protection when
        /// you launch an instance, while the instance is running, or while the instance is stopped.
        /// </para>
        /// </summary>
        public bool? DisableApiTermination
        {
            get { return this._disableApiTermination; }
            set { this._disableApiTermination = value; }
        }

        // Check to see if DisableApiTermination property is set
        internal bool IsSetDisableApiTermination()
        {
            return this._disableApiTermination.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the operation, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
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
        /// Default: <c>false</c> 
        /// </para>
        /// </summary>
        public bool? EbsOptimized
        {
            get { return this._ebsOptimized; }
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
        /// An elastic GPU to associate with the instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Elastic Graphics reached end of life on January 8, 2024.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Specifying Elastic Graphics accelerators is no longer supported on the RunInstances API.")]
        public List<ElasticGpuSpecification> ElasticGpuSpecification
        {
            get { return this._elasticGpuSpecification; }
            set { this._elasticGpuSpecification = value; }
        }

        // Check to see if ElasticGpuSpecification property is set
        internal bool IsSetElasticGpuSpecification()
        {
            return this._elasticGpuSpecification != null && (this._elasticGpuSpecification.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ElasticInferenceAccelerators. 
        /// <para>
        /// An elastic inference accelerator to associate with the instance.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Elastic Inference is no longer available.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Specifying Elastic Inference accelerators is no longer supported on the RunInstances API.")]
        public List<ElasticInferenceAccelerator> ElasticInferenceAccelerators
        {
            get { return this._elasticInferenceAccelerators; }
            set { this._elasticInferenceAccelerators = value; }
        }

        // Check to see if ElasticInferenceAccelerators property is set
        internal bool IsSetElasticInferenceAccelerators()
        {
            return this._elasticInferenceAccelerators != null && (this._elasticInferenceAccelerators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnablePrimaryIpv6. 
        /// <para>
        /// If you’re launching an instance into a dual-stack or IPv6-only subnet, you can enable
        /// assigning a primary IPv6 address. A primary IPv6 address is an IPv6 GUA address associated
        /// with an ENI that you have enabled to use a primary IPv6 address. Use this option if
        /// an instance relies on its IPv6 address not changing. When you launch the instance,
        /// Amazon Web Services will automatically assign an IPv6 address associated with the
        /// ENI attached to your instance to be the primary IPv6 address. Once you enable an IPv6
        /// GUA address to be a primary IPv6, you cannot disable it. When you enable an IPv6 GUA
        /// address to be a primary IPv6, the first IPv6 GUA will be made the primary IPv6 address
        /// until the instance is terminated or the network interface is detached. If you have
        /// multiple IPv6 addresses associated with an ENI attached to your instance and you enable
        /// a primary IPv6 address, the first IPv6 GUA address associated with the ENI becomes
        /// the primary IPv6 address.
        /// </para>
        /// </summary>
        public bool? EnablePrimaryIpv6
        {
            get { return this._enablePrimaryIpv6; }
            set { this._enablePrimaryIpv6 = value; }
        }

        // Check to see if EnablePrimaryIpv6 property is set
        internal bool IsSetEnablePrimaryIpv6()
        {
            return this._enablePrimaryIpv6.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        /// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
        /// For more information, see <a href="https://docs.aws.amazon.com/enclaves/latest/user/">Amazon
        /// Web Services Nitro Enclaves User Guide</a>.
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
        /// Indicates whether an instance is enabled for hibernation. This parameter is valid
        /// only if the instance meets the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/hibernating-prerequisites.html">hibernation
        /// prerequisites</a>. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
        /// your Amazon EC2 instance</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Default: <c>stop</c> 
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
        /// <b>InstanceInterruptionBehavior</b> is set to either <c>hibernate</c> or <c>stop</c>.
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
        /// The instance type. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/instance-types.html">Amazon
        /// EC2 Instance Types Guide</a>.
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
        /// The number of IPv6 addresses to associate with the primary network interface. Amazon
        /// EC2 chooses the IPv6 addresses from the range of your subnet. You cannot specify this
        /// option and the option to assign specific IPv6 addresses in the same request. You can
        /// specify this option if you've specified a minimum number of instances to launch.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this option and the network interfaces option in the same request.
        /// </para>
        /// </summary>
        public int? Ipv6AddressCount
        {
            get { return this._ipv6AddressCount; }
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
        /// The IPv6 addresses from the range of the subnet to associate with the primary network
        /// interface. You cannot specify this option and the option to assign a number of IPv6
        /// addresses in the same request. You cannot specify this option if you've specified
        /// a minimum number of instances to launch.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify this option and the network interfaces option in the same request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceIpv6Address> Ipv6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if Ipv6Addresses property is set
        internal bool IsSetIpv6Addresses()
        {
            return this._ipv6Addresses != null && (this._ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The name of the key pair. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-key-pairs.html">Create
        /// a key pair for your EC2 instance</a>.
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
        /// The launch template. Any additional parameters that you specify for the new instance
        /// overwrite the corresponding parameters included in the launch template.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LicenseConfigurationRequest> LicenseSpecifications
        {
            get { return this._licenseSpecifications; }
            set { this._licenseSpecifications = value; }
        }

        // Check to see if LicenseSpecifications property is set
        internal bool IsSetLicenseSpecifications()
        {
            return this._licenseSpecifications != null && (this._licenseSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// The maximum number of instances to launch. If you specify a value that is more capacity
        /// than Amazon EC2 can launch in the target Availability Zone, Amazon EC2 launches the
        /// largest possible number of instances above the specified minimum count.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Between 1 and the quota for the specified instance type for your account
        /// for this Region. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-instance-quotas.html">Amazon
        /// EC2 instance type quotas</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MaxCount
        {
            get { return this._maxCount; }
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
        /// The metadata options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-options.html">Configure
        /// the Instance Metadata Service options</a>.
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
        /// The minimum number of instances to launch. If you specify a value that is more capacity
        /// than Amazon EC2 can provide in the target Availability Zone, Amazon EC2 does not launch
        /// any instances.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Between 1 and the quota for the specified instance type for your account
        /// for this Region. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/instancetypes/ec2-instance-quotas.html">Amazon
        /// EC2 instance type quotas</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? MinCount
        {
            get { return this._minCount; }
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
        public bool? Monitoring
        {
            get { return this._monitoring; }
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
        /// The network interfaces to associate with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && (this._networkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NetworkPerformanceOptions. 
        /// <para>
        /// Contains settings for the network performance options for the instance.
        /// </para>
        /// </summary>
        public InstanceNetworkPerformanceOptionsRequest NetworkPerformanceOptions
        {
            get { return this._networkPerformanceOptions; }
            set { this._networkPerformanceOptions = value; }
        }

        // Check to see if NetworkPerformanceOptions property is set
        internal bool IsSetNetworkPerformanceOptions()
        {
            return this._networkPerformanceOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// Reserved for internal use.
        /// </para>
        /// </summary>
        public OperatorRequest Operator
        {
            get { return this._operator; }
            set { this._operator = value; }
        }

        // Check to see if Operator property is set
        internal bool IsSetOperator()
        {
            return this._operator != null;
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
        /// Applies only if creating a network interface, not attaching an existing one.
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
        /// The primary IPv4 address. You must specify a value from the IPv4 address range of
        /// the subnet.
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
        /// The IDs of the security groups.
        /// </para>
        ///  
        /// <para>
        /// If you specify a network interface, you must specify any security groups as part of
        /// the network interface instead of using this parameter.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// [Default VPC] The names of the security groups.
        /// </para>
        ///  
        /// <para>
        /// If you specify a network interface, you must specify any security groups as part of
        /// the network interface instead of using this parameter.
        /// </para>
        ///  
        /// <para>
        /// Default: Amazon EC2 uses the default security group.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups
        {
            get { return this._securityGroups; }
            set { this._securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this._securityGroups != null && (this._securityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet to launch the instance into.
        /// </para>
        ///  
        /// <para>
        /// If you specify a network interface, you must specify any subnets as part of the network
        /// interface instead of using this parameter.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && (this._tagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// The user data to make available to the instance. User data must be base64-encoded.
        /// Depending on the tool or SDK that you're using, the base64-encoding might be performed
        /// for you. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/user-data.html">Run
        /// commands at launch using instance user data</a>.
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