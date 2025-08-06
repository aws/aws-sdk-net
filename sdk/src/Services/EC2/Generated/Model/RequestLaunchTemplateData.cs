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
    /// The information to include in the launch template.
    /// 
    ///  <note> 
    /// <para>
    /// You must specify at least one parameter for the launch template data.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class RequestLaunchTemplateData
    {
        private List<LaunchTemplateBlockDeviceMappingRequest> _blockDeviceMappings = AWSConfigs.InitializeCollections ? new List<LaunchTemplateBlockDeviceMappingRequest>() : null;
        private LaunchTemplateCapacityReservationSpecificationRequest _capacityReservationSpecification;
        private LaunchTemplateCpuOptionsRequest _cpuOptions;
        private CreditSpecificationRequest _creditSpecification;
        private bool? _disableApiStop;
        private bool? _disableApiTermination;
        private bool? _ebsOptimized;
        private List<ElasticGpuSpecification> _elasticGpuSpecifications = AWSConfigs.InitializeCollections ? new List<ElasticGpuSpecification>() : null;
        private List<LaunchTemplateElasticInferenceAccelerator> _elasticInferenceAccelerators = AWSConfigs.InitializeCollections ? new List<LaunchTemplateElasticInferenceAccelerator>() : null;
        private LaunchTemplateEnclaveOptionsRequest _enclaveOptions;
        private LaunchTemplateHibernationOptionsRequest _hibernationOptions;
        private LaunchTemplateIamInstanceProfileSpecificationRequest _iamInstanceProfile;
        private string _imageId;
        private ShutdownBehavior _instanceInitiatedShutdownBehavior;
        private LaunchTemplateInstanceMarketOptionsRequest _instanceMarketOptions;
        private InstanceRequirementsRequest _instanceRequirements;
        private InstanceType _instanceType;
        private string _kernelId;
        private string _keyName;
        private List<LaunchTemplateLicenseConfigurationRequest> _licenseSpecifications = AWSConfigs.InitializeCollections ? new List<LaunchTemplateLicenseConfigurationRequest>() : null;
        private LaunchTemplateInstanceMaintenanceOptionsRequest _maintenanceOptions;
        private LaunchTemplateInstanceMetadataOptionsRequest _metadataOptions;
        private LaunchTemplatesMonitoringRequest _monitoring;
        private List<LaunchTemplateInstanceNetworkInterfaceSpecificationRequest> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<LaunchTemplateInstanceNetworkInterfaceSpecificationRequest>() : null;
        private LaunchTemplateNetworkPerformanceOptionsRequest _networkPerformanceOptions;
        private OperatorRequest _operator;
        private LaunchTemplatePlacementRequest _placement;
        private LaunchTemplatePrivateDnsNameOptionsRequest _privateDnsNameOptions;
        private string _ramDiskId;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<LaunchTemplateTagSpecificationRequest> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<LaunchTemplateTagSpecificationRequest>() : null;
        private string _userData;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mapping.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateBlockDeviceMappingRequest> BlockDeviceMappings
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
        /// The Capacity Reservation targeting option. If you do not specify this parameter, the
        /// instance's Capacity Reservation preference defaults to <c>open</c>, which enables
        /// it to run in any open Capacity Reservation that has matching attributes (instance
        /// type, platform, Availability Zone).
        /// </para>
        /// </summary>
        public LaunchTemplateCapacityReservationSpecificationRequest CapacityReservationSpecification
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
        /// Gets and sets the property CpuOptions. 
        /// <para>
        /// The CPU options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-optimize-cpu.html">CPU
        /// options for Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public LaunchTemplateCpuOptionsRequest CpuOptions
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
        /// The credit option for CPU usage of the instance. Valid only for T instances.
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
        /// Indicates whether to enable the instance for stop protection. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-stop-protection.html">Enable
        /// stop protection for your EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Indicates whether the instance is optimized for Amazon EBS I/O. This optimization
        /// provides dedicated throughput to Amazon EBS and an optimized configuration stack to
        /// provide optimal Amazon EBS I/O performance. This optimization isn't available with
        /// all instance types. Additional usage charges apply when using an EBS-optimized instance.
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
        /// Gets and sets the property ElasticGpuSpecifications. 
        /// <para>
        /// Deprecated.
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
        public List<ElasticGpuSpecification> ElasticGpuSpecifications
        {
            get { return this._elasticGpuSpecifications; }
            set { this._elasticGpuSpecifications = value; }
        }

        // Check to see if ElasticGpuSpecifications property is set
        internal bool IsSetElasticGpuSpecifications()
        {
            return this._elasticGpuSpecifications != null && (this._elasticGpuSpecifications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ElasticInferenceAccelerators. <note> 
        /// <para>
        /// Amazon Elastic Inference is no longer available.
        /// </para>
        ///  </note> 
        /// <para>
        /// An elastic inference accelerator to associate with the instance. Elastic inference
        /// accelerators are a resource you can attach to your Amazon EC2 instances to accelerate
        /// your Deep Learning (DL) inference workloads.
        /// </para>
        ///  
        /// <para>
        /// You cannot specify accelerators from different generations in the same request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [Obsolete("Specifying Elastic Inference accelerators is no longer supported on the RunInstances API.")]
        public List<LaunchTemplateElasticInferenceAccelerator> ElasticInferenceAccelerators
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
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        /// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
        /// For more information, see <a href="https://docs.aws.amazon.com/enclaves/latest/user/nitro-enclave.html">What
        /// is Nitro Enclaves?</a> in the <i>Amazon Web Services Nitro Enclaves User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't enable Amazon Web Services Nitro Enclaves and hibernation on the same instance.
        /// </para>
        /// </summary>
        public LaunchTemplateEnclaveOptionsRequest EnclaveOptions
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
        /// </summary>
        public LaunchTemplateHibernationOptionsRequest HibernationOptions
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
        /// The ID of the AMI in the format <c>ami-0ac394d6a3example</c>.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can specify a Systems Manager parameter, using one of the following
        /// formats. The Systems Manager parameter will resolve to an AMI ID on launch.
        /// </para>
        ///  
        /// <para>
        /// To reference a public parameter:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>public-parameter</i> </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To reference a parameter stored in the same account:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-name</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-name:version-number</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-name:label</i> </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To reference a parameter shared from another Amazon Web Services account:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-ARN</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-ARN:version-number</i> </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>resolve:ssm:<i>parameter-ARN:label</i> </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-launch-template.html#use-an-ssm-parameter-instead-of-an-ami-id">Use
        /// a Systems Manager parameter instead of an AMI ID</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the launch template will be used for an EC2 Fleet or Spot Fleet, note the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Only EC2 Fleets of type <c>instant</c> support specifying a Systems Manager parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For EC2 Fleets of type <c>maintain</c> or <c>request</c>, or for Spot Fleets, you
        /// must specify the AMI ID.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        /// The attributes for the instance types. When you specify instance attributes, Amazon
        /// EC2 will identify instance types with these attributes.
        /// </para>
        ///  
        /// <para>
        /// You must specify <c>VCpuCount</c> and <c>MemoryMiB</c>. All other attributes are optional.
        /// Any unspecified optional attribute is set to its default.
        /// </para>
        ///  
        /// <para>
        /// When you specify multiple attributes, you get instance types that satisfy all of the
        /// specified attributes. If you specify multiple values for an attribute, you get instance
        /// types that satisfy any of the specified values.
        /// </para>
        ///  
        /// <para>
        /// To limit the list of instance types from which Amazon EC2 can identify matching instance
        /// types, you can use one of the following parameters, but not both in the same request:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>AllowedInstanceTypes</c> - The instance types to include in the list. All other
        /// instance types are ignored, even if they match your specified attributes.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ExcludedInstanceTypes</c> - The instance types to exclude from the list, even
        /// if they match your specified attributes.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you specify <c>InstanceRequirements</c>, you can't specify <c>InstanceType</c>.
        /// </para>
        ///  
        /// <para>
        /// Attribute-based instance type selection is only supported when using Auto Scaling
        /// groups, EC2 Fleet, and Spot Fleet to launch instances. If you plan to use the launch
        /// template in the <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-instance-wizard.html">launch
        /// instance wizard</a>, or with the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_RunInstances.html">RunInstances</a>
        /// API or <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-ec2-instance.html">AWS::EC2::Instance</a>
        /// Amazon Web Services CloudFormation resource, you can't specify <c>InstanceRequirements</c>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet-attribute-based-instance-type-selection.html">Specify
        /// attributes for instance type selection for EC2 Fleet or Spot Fleet</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-placement-score.html">Spot
        /// placement score</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceRequirementsRequest InstanceRequirements
        {
            get { return this._instanceRequirements; }
            set { this._instanceRequirements = value; }
        }

        // Check to see if InstanceRequirements property is set
        internal bool IsSetInstanceRequirements()
        {
            return this._instanceRequirements != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Amazon
        /// EC2 instance types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>InstanceType</c>, you can't specify <c>InstanceRequirements</c>.
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
        /// see <a href="https://docs.aws.amazon.com/linux/al2/ug/UserProvidedKernels.html">User
        /// provided kernels</a> in the <i>Amazon Linux 2 User Guide</i>.
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
        public List<LaunchTemplateLicenseConfigurationRequest> LicenseSpecifications
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
        /// The maintenance options for the instance.
        /// </para>
        /// </summary>
        public LaunchTemplateInstanceMaintenanceOptionsRequest MaintenanceOptions
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
        /// The metadata options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-options.html">Configure
        /// the Instance Metadata Service options</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public LaunchTemplateInstanceMetadataOptionsRequest MetadataOptions
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
        /// The network interfaces for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateInstanceNetworkInterfaceSpecificationRequest> NetworkInterfaces
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
        /// Contains launch template settings to boost network performance for the type of workload
        /// that runs on your instance.
        /// </para>
        /// </summary>
        public LaunchTemplateNetworkPerformanceOptionsRequest NetworkPerformanceOptions
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
        /// The entity that manages the launch template.
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
        /// Gets and sets the property PrivateDnsNameOptions. 
        /// <para>
        /// The options for the instance hostname. The default values are inherited from the subnet.
        /// </para>
        /// </summary>
        public LaunchTemplatePrivateDnsNameOptionsRequest PrivateDnsNameOptions
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
        /// Gets and sets the property RamDiskId. 
        /// <para>
        /// The ID of the RAM disk.
        /// </para>
        ///  <important> 
        /// <para>
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedkernels.html">User
        /// provided kernels</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// The names of the security groups. For a nondefault VPC, you must use security group
        /// IDs instead.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to the resources that are created during instance launch. These
        /// tags are not applied to the launch template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateTagSpecificationRequest> TagSpecifications
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
        /// The user data to make available to the instance. You must provide base64-encoded text.
        /// User data is limited to 16 KB. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/user-data.html">Run
        /// commands when you launch an EC2 instance with user data input</a> in the <i>Amazon
        /// EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you are creating the launch template for use with Batch, the user data must be
        /// provided in the <a href="https://cloudinit.readthedocs.io/en/latest/topics/format.html#mime-multi-part-archive">MIME
        /// multi-part archive format</a>. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/launch-templates.html#lt-user-data">Amazon
        /// EC2 user data in launch templates</a> in the <i>Batch User Guide</i>.
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