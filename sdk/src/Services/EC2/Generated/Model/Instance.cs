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
    /// Describes an instance.
    /// </summary>
    public partial class Instance
    {
        private int? _amiLaunchIndex;
        private ArchitectureValues _architecture;
        private List<InstanceBlockDeviceMapping> _blockDeviceMappings = new List<InstanceBlockDeviceMapping>();
        private BootModeValues _bootMode;
        private string _capacityReservationId;
        private CapacityReservationSpecificationResponse _capacityReservationSpecification;
        private string _clientToken;
        private CpuOptions _cpuOptions;
        private InstanceBootModeValues _currentInstanceBootMode;
        private bool? _ebsOptimized;
        private List<ElasticGpuAssociation> _elasticGpuAssociations = new List<ElasticGpuAssociation>();
        private List<ElasticInferenceAcceleratorAssociation> _elasticInferenceAcceleratorAssociations = new List<ElasticInferenceAcceleratorAssociation>();
        private bool? _enaSupport;
        private EnclaveOptions _enclaveOptions;
        private HibernationOptions _hibernationOptions;
        private HypervisorType _hypervisor;
        private IamInstanceProfile _iamInstanceProfile;
        private string _imageId;
        private string _instanceId;
        private InstanceLifecycleType _instanceLifecycle;
        private InstanceType _instanceType;
        private string _ipv6Address;
        private string _kernelId;
        private string _keyName;
        private DateTime? _launchTime;
        private List<LicenseConfiguration> _licenses = new List<LicenseConfiguration>();
        private InstanceMaintenanceOptions _maintenanceOptions;
        private InstanceMetadataOptionsResponse _metadataOptions;
        private Monitoring _monitoring;
        private List<InstanceNetworkInterface> _networkInterfaces = new List<InstanceNetworkInterface>();
        private string _outpostArn;
        private Placement _placement;
        private PlatformValues _platform;
        private string _platformDetails;
        private string _privateDnsName;
        private PrivateDnsNameOptionsResponse _privateDnsNameOptions;
        private string _privateIpAddress;
        private List<ProductCode> _productCodes = new List<ProductCode>();
        private string _publicDnsName;
        private string _publicIpAddress;
        private string _ramdiskId;
        private string _rootDeviceName;
        private DeviceType _rootDeviceType;
        private List<GroupIdentifier> _securityGroups = new List<GroupIdentifier>();
        private bool? _sourceDestCheck;
        private string _spotInstanceRequestId;
        private string _sriovNetSupport;
        private InstanceState _state;
        private StateReason _stateReason;
        private string _stateTransitionReason;
        private string _subnetId;
        private List<Tag> _tags = new List<Tag>();
        private string _tpmSupport;
        private string _usageOperation;
        private DateTime? _usageOperationUpdateTime;
        private VirtualizationType _virtualizationType;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property AmiLaunchIndex. 
        /// <para>
        /// The AMI launch index, which can be used to find this instance in the launch group.
        /// </para>
        /// </summary>
        public int AmiLaunchIndex
        {
            get { return this._amiLaunchIndex.GetValueOrDefault(); }
            set { this._amiLaunchIndex = value; }
        }

        // Check to see if AmiLaunchIndex property is set
        internal bool IsSetAmiLaunchIndex()
        {
            return this._amiLaunchIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Architecture. 
        /// <para>
        /// The architecture of the image.
        /// </para>
        /// </summary>
        public ArchitectureValues Architecture
        {
            get { return this._architecture; }
            set { this._architecture = value; }
        }

        // Check to see if Architecture property is set
        internal bool IsSetArchitecture()
        {
            return this._architecture != null;
        }

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// Any block device mapping entries for the instance.
        /// </para>
        /// </summary>
        public List<InstanceBlockDeviceMapping> BlockDeviceMappings
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
        /// Gets and sets the property BootMode. 
        /// <para>
        /// The boot mode that was specified by the AMI. If the value is <code>uefi-preferred</code>,
        /// the AMI supports both UEFI and Legacy BIOS. The <code>currentInstanceBootMode</code>
        /// parameter is the boot mode that is used to boot the instance at launch or start.
        /// </para>
        ///  <note> 
        /// <para>
        /// The operating system contained in the AMI must be configured to support the specified
        /// boot mode.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html">Boot
        /// modes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public BootModeValues BootMode
        {
            get { return this._bootMode; }
            set { this._bootMode = value; }
        }

        // Check to see if BootMode property is set
        internal bool IsSetBootMode()
        {
            return this._bootMode != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationId. 
        /// <para>
        /// The ID of the Capacity Reservation.
        /// </para>
        /// </summary>
        public string CapacityReservationId
        {
            get { return this._capacityReservationId; }
            set { this._capacityReservationId = value; }
        }

        // Check to see if CapacityReservationId property is set
        internal bool IsSetCapacityReservationId()
        {
            return this._capacityReservationId != null;
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// Information about the Capacity Reservation targeting option.
        /// </para>
        /// </summary>
        public CapacityReservationSpecificationResponse CapacityReservationSpecification
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
        /// The idempotency token you provided when you launched the instance, if applicable.
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
        /// The CPU options for the instance.
        /// </para>
        /// </summary>
        public CpuOptions CpuOptions
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
        /// Gets and sets the property CurrentInstanceBootMode. 
        /// <para>
        /// The boot mode that is used to boot the instance at launch or start. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ami-boot.html">Boot
        /// modes</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceBootModeValues CurrentInstanceBootMode
        {
            get { return this._currentInstanceBootMode; }
            set { this._currentInstanceBootMode = value; }
        }

        // Check to see if CurrentInstanceBootMode property is set
        internal bool IsSetCurrentInstanceBootMode()
        {
            return this._currentInstanceBootMode != null;
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether the instance is optimized for Amazon EBS I/O. This optimization
        /// provides dedicated throughput to Amazon EBS and an optimized configuration stack to
        /// provide optimal I/O performance. This optimization isn't available with all instance
        /// types. Additional usage charges apply when using an EBS Optimized instance.
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
        /// Gets and sets the property ElasticGpuAssociations. 
        /// <para>
        /// The Elastic GPU associated with the instance.
        /// </para>
        /// </summary>
        public List<ElasticGpuAssociation> ElasticGpuAssociations
        {
            get { return this._elasticGpuAssociations; }
            set { this._elasticGpuAssociations = value; }
        }

        // Check to see if ElasticGpuAssociations property is set
        internal bool IsSetElasticGpuAssociations()
        {
            return this._elasticGpuAssociations != null && this._elasticGpuAssociations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorAssociations. 
        /// <para>
        /// The elastic inference accelerator associated with the instance.
        /// </para>
        /// </summary>
        public List<ElasticInferenceAcceleratorAssociation> ElasticInferenceAcceleratorAssociations
        {
            get { return this._elasticInferenceAcceleratorAssociations; }
            set { this._elasticInferenceAcceleratorAssociations = value; }
        }

        // Check to see if ElasticInferenceAcceleratorAssociations property is set
        internal bool IsSetElasticInferenceAcceleratorAssociations()
        {
            return this._elasticInferenceAcceleratorAssociations != null && this._elasticInferenceAcceleratorAssociations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnaSupport. 
        /// <para>
        /// Specifies whether enhanced networking with ENA is enabled.
        /// </para>
        /// </summary>
        public bool EnaSupport
        {
            get { return this._enaSupport.GetValueOrDefault(); }
            set { this._enaSupport = value; }
        }

        // Check to see if EnaSupport property is set
        internal bool IsSetEnaSupport()
        {
            return this._enaSupport.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        /// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
        /// </para>
        /// </summary>
        public EnclaveOptions EnclaveOptions
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
        /// Indicates whether the instance is enabled for hibernation.
        /// </para>
        /// </summary>
        public HibernationOptions HibernationOptions
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
        /// Gets and sets the property Hypervisor. 
        /// <para>
        /// The hypervisor type of the instance. The value <code>xen</code> is used for both Xen
        /// and Nitro hypervisors.
        /// </para>
        /// </summary>
        public HypervisorType Hypervisor
        {
            get { return this._hypervisor; }
            set { this._hypervisor = value; }
        }

        // Check to see if Hypervisor property is set
        internal bool IsSetHypervisor()
        {
            return this._hypervisor != null;
        }

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM instance profile associated with the instance, if applicable.
        /// </para>
        /// </summary>
        public IamInstanceProfile IamInstanceProfile
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
        /// The ID of the AMI used to launch the instance.
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceLifecycle. 
        /// <para>
        /// Indicates whether this is a Spot Instance or a Scheduled Instance.
        /// </para>
        /// </summary>
        public InstanceLifecycleType InstanceLifecycle
        {
            get { return this._instanceLifecycle; }
            set { this._instanceLifecycle = value; }
        }

        // Check to see if InstanceLifecycle property is set
        internal bool IsSetInstanceLifecycle()
        {
            return this._instanceLifecycle != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
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
        /// Gets and sets the property Ipv6Address. 
        /// <para>
        /// The IPv6 address assigned to the instance.
        /// </para>
        /// </summary>
        public string Ipv6Address
        {
            get { return this._ipv6Address; }
            set { this._ipv6Address = value; }
        }

        // Check to see if Ipv6Address property is set
        internal bool IsSetIpv6Address()
        {
            return this._ipv6Address != null;
        }

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The kernel associated with this instance, if applicable.
        /// </para>
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
        /// The name of the key pair, if this instance was launched with an associated key pair.
        /// </para>
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
        /// Gets and sets the property LaunchTime. 
        /// <para>
        /// The time the instance was launched.
        /// </para>
        /// </summary>
        public DateTime LaunchTime
        {
            get { return this._launchTime.GetValueOrDefault(); }
            set { this._launchTime = value; }
        }

        // Check to see if LaunchTime property is set
        internal bool IsSetLaunchTime()
        {
            return this._launchTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Licenses. 
        /// <para>
        /// The license configurations for the instance.
        /// </para>
        /// </summary>
        public List<LicenseConfiguration> Licenses
        {
            get { return this._licenses; }
            set { this._licenses = value; }
        }

        // Check to see if Licenses property is set
        internal bool IsSetLicenses()
        {
            return this._licenses != null && this._licenses.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaintenanceOptions. 
        /// <para>
        /// Provides information on the recovery and maintenance options of your instance.
        /// </para>
        /// </summary>
        public InstanceMaintenanceOptions MaintenanceOptions
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
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the instance.
        /// </para>
        /// </summary>
        public InstanceMetadataOptionsResponse MetadataOptions
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
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// The monitoring for the instance.
        /// </para>
        /// </summary>
        public Monitoring Monitoring
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
        /// [EC2-VPC] The network interfaces for the instance.
        /// </para>
        /// </summary>
        public List<InstanceNetworkInterface> NetworkInterfaces
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
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Outpost.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The location where the instance launched, if applicable.
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
        /// Gets and sets the property Platform. 
        /// <para>
        /// The value is <code>Windows</code> for Windows instances; otherwise blank.
        /// </para>
        /// </summary>
        public PlatformValues Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property PlatformDetails. 
        /// <para>
        /// The platform details value for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/billing-info-fields.html">AMI
        /// billing information fields</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformDetails
        {
            get { return this._platformDetails; }
            set { this._platformDetails = value; }
        }

        // Check to see if PlatformDetails property is set
        internal bool IsSetPlatformDetails()
        {
            return this._platformDetails != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsName. 
        /// <para>
        /// (IPv4 only) The private DNS hostname name assigned to the instance. This DNS hostname
        /// can only be used inside the Amazon EC2 network. This name is not available until the
        /// instance enters the <code>running</code> state. 
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] The Amazon-provided DNS server resolves Amazon-provided private DNS hostnames
        /// if you've enabled DNS resolution and DNS hostnames in your VPC. If you are not using
        /// the Amazon-provided DNS server in your VPC, your custom domain name servers must resolve
        /// the hostname as appropriate.
        /// </para>
        /// </summary>
        public string PrivateDnsName
        {
            get { return this._privateDnsName; }
            set { this._privateDnsName = value; }
        }

        // Check to see if PrivateDnsName property is set
        internal bool IsSetPrivateDnsName()
        {
            return this._privateDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateDnsNameOptions. 
        /// <para>
        /// The options for the instance hostname.
        /// </para>
        /// </summary>
        public PrivateDnsNameOptionsResponse PrivateDnsNameOptions
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
        /// The private IPv4 address assigned to the instance.
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
        /// Gets and sets the property ProductCodes. 
        /// <para>
        /// The product codes attached to this instance, if applicable.
        /// </para>
        /// </summary>
        public List<ProductCode> ProductCodes
        {
            get { return this._productCodes; }
            set { this._productCodes = value; }
        }

        // Check to see if ProductCodes property is set
        internal bool IsSetProductCodes()
        {
            return this._productCodes != null && this._productCodes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PublicDnsName. 
        /// <para>
        /// (IPv4 only) The public DNS name assigned to the instance. This name is not available
        /// until the instance enters the <code>running</code> state. For EC2-VPC, this name is
        /// only available if you've enabled DNS hostnames for your VPC.
        /// </para>
        /// </summary>
        public string PublicDnsName
        {
            get { return this._publicDnsName; }
            set { this._publicDnsName = value; }
        }

        // Check to see if PublicDnsName property is set
        internal bool IsSetPublicDnsName()
        {
            return this._publicDnsName != null;
        }

        /// <summary>
        /// Gets and sets the property PublicIpAddress. 
        /// <para>
        /// The public IPv4 address, or the Carrier IP address assigned to the instance, if applicable.
        /// </para>
        ///  
        /// <para>
        /// A Carrier IP address only applies to an instance launched in a subnet associated with
        /// a Wavelength Zone.
        /// </para>
        /// </summary>
        public string PublicIpAddress
        {
            get { return this._publicIpAddress; }
            set { this._publicIpAddress = value; }
        }

        // Check to see if PublicIpAddress property is set
        internal bool IsSetPublicIpAddress()
        {
            return this._publicIpAddress != null;
        }

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The RAM disk associated with this instance, if applicable.
        /// </para>
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
        /// Gets and sets the property RootDeviceName. 
        /// <para>
        /// The device name of the root device volume (for example, <code>/dev/sda1</code>).
        /// </para>
        /// </summary>
        public string RootDeviceName
        {
            get { return this._rootDeviceName; }
            set { this._rootDeviceName = value; }
        }

        // Check to see if RootDeviceName property is set
        internal bool IsSetRootDeviceName()
        {
            return this._rootDeviceName != null;
        }

        /// <summary>
        /// Gets and sets the property RootDeviceType. 
        /// <para>
        /// The root device type used by the AMI. The AMI can use an EBS volume or an instance
        /// store volume.
        /// </para>
        /// </summary>
        public DeviceType RootDeviceType
        {
            get { return this._rootDeviceType; }
            set { this._rootDeviceType = value; }
        }

        // Check to see if RootDeviceType property is set
        internal bool IsSetRootDeviceType()
        {
            return this._rootDeviceType != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups for the instance.
        /// </para>
        /// </summary>
        public List<GroupIdentifier> SecurityGroups
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
        /// Gets and sets the property SourceDestCheck. 
        /// <para>
        /// Indicates whether source/destination checking is enabled.
        /// </para>
        /// </summary>
        public bool SourceDestCheck
        {
            get { return this._sourceDestCheck.GetValueOrDefault(); }
            set { this._sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this._sourceDestCheck.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SpotInstanceRequestId. 
        /// <para>
        /// If the request is a Spot Instance request, the ID of the request.
        /// </para>
        /// </summary>
        public string SpotInstanceRequestId
        {
            get { return this._spotInstanceRequestId; }
            set { this._spotInstanceRequestId = value; }
        }

        // Check to see if SpotInstanceRequestId property is set
        internal bool IsSetSpotInstanceRequestId()
        {
            return this._spotInstanceRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property SriovNetSupport. 
        /// <para>
        /// Specifies whether enhanced networking with the Intel 82599 Virtual Function interface
        /// is enabled.
        /// </para>
        /// </summary>
        public string SriovNetSupport
        {
            get { return this._sriovNetSupport; }
            set { this._sriovNetSupport = value; }
        }

        // Check to see if SriovNetSupport property is set
        internal bool IsSetSriovNetSupport()
        {
            return this._sriovNetSupport != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the instance.
        /// </para>
        /// </summary>
        public InstanceState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateReason. 
        /// <para>
        /// The reason for the most recent state transition.
        /// </para>
        /// </summary>
        public StateReason StateReason
        {
            get { return this._stateReason; }
            set { this._stateReason = value; }
        }

        // Check to see if StateReason property is set
        internal bool IsSetStateReason()
        {
            return this._stateReason != null;
        }

        /// <summary>
        /// Gets and sets the property StateTransitionReason. 
        /// <para>
        /// The reason for the most recent state transition. This might be an empty string.
        /// </para>
        /// </summary>
        public string StateTransitionReason
        {
            get { return this._stateTransitionReason; }
            set { this._stateTransitionReason = value; }
        }

        // Check to see if StateTransitionReason property is set
        internal bool IsSetStateTransitionReason()
        {
            return this._stateTransitionReason != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// [EC2-VPC] The ID of the subnet in which the instance is running.
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the instance.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TpmSupport. 
        /// <para>
        /// If the instance is configured for NitroTPM support, the value is <code>v2.0</code>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/nitrotpm.html">NitroTPM</a>
        /// in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string TpmSupport
        {
            get { return this._tpmSupport; }
            set { this._tpmSupport = value; }
        }

        // Check to see if TpmSupport property is set
        internal bool IsSetTpmSupport()
        {
            return this._tpmSupport != null;
        }

        /// <summary>
        /// Gets and sets the property UsageOperation. 
        /// <para>
        /// The usage operation value for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/billing-info-fields.html">AMI
        /// billing information fields</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public string UsageOperation
        {
            get { return this._usageOperation; }
            set { this._usageOperation = value; }
        }

        // Check to see if UsageOperation property is set
        internal bool IsSetUsageOperation()
        {
            return this._usageOperation != null;
        }

        /// <summary>
        /// Gets and sets the property UsageOperationUpdateTime. 
        /// <para>
        /// The time that the usage operation was last updated.
        /// </para>
        /// </summary>
        public DateTime UsageOperationUpdateTime
        {
            get { return this._usageOperationUpdateTime.GetValueOrDefault(); }
            set { this._usageOperationUpdateTime = value; }
        }

        // Check to see if UsageOperationUpdateTime property is set
        internal bool IsSetUsageOperationUpdateTime()
        {
            return this._usageOperationUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VirtualizationType. 
        /// <para>
        /// The virtualization type of the instance.
        /// </para>
        /// </summary>
        public VirtualizationType VirtualizationType
        {
            get { return this._virtualizationType; }
            set { this._virtualizationType = value; }
        }

        // Check to see if VirtualizationType property is set
        internal bool IsSetVirtualizationType()
        {
            return this._virtualizationType != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// [EC2-VPC] The ID of the VPC in which the instance is running.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}