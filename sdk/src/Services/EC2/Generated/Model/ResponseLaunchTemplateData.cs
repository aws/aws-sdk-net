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
    /// The information for a launch template.
    /// </summary>
    public partial class ResponseLaunchTemplateData
    {
        private List<LaunchTemplateBlockDeviceMapping> _blockDeviceMappings = AWSConfigs.InitializeCollections ? new List<LaunchTemplateBlockDeviceMapping>() : null;
        private LaunchTemplateCapacityReservationSpecificationResponse _capacityReservationSpecification;
        private LaunchTemplateCpuOptions _cpuOptions;
        private CreditSpecification _creditSpecification;
        private bool? _disableApiStop;
        private bool? _disableApiTermination;
        private bool? _ebsOptimized;
        private List<ElasticGpuSpecificationResponse> _elasticGpuSpecifications = AWSConfigs.InitializeCollections ? new List<ElasticGpuSpecificationResponse>() : null;
        private List<LaunchTemplateElasticInferenceAcceleratorResponse> _elasticInferenceAccelerators = AWSConfigs.InitializeCollections ? new List<LaunchTemplateElasticInferenceAcceleratorResponse>() : null;
        private LaunchTemplateEnclaveOptions _enclaveOptions;
        private LaunchTemplateHibernationOptions _hibernationOptions;
        private LaunchTemplateIamInstanceProfileSpecification _iamInstanceProfile;
        private string _imageId;
        private ShutdownBehavior _instanceInitiatedShutdownBehavior;
        private LaunchTemplateInstanceMarketOptions _instanceMarketOptions;
        private InstanceRequirements _instanceRequirements;
        private InstanceType _instanceType;
        private string _kernelId;
        private string _keyName;
        private List<LaunchTemplateLicenseConfiguration> _licenseSpecifications = AWSConfigs.InitializeCollections ? new List<LaunchTemplateLicenseConfiguration>() : null;
        private LaunchTemplateInstanceMaintenanceOptions _maintenanceOptions;
        private LaunchTemplateInstanceMetadataOptions _metadataOptions;
        private LaunchTemplatesMonitoring _monitoring;
        private List<LaunchTemplateInstanceNetworkInterfaceSpecification> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<LaunchTemplateInstanceNetworkInterfaceSpecification>() : null;
        private LaunchTemplateNetworkPerformanceOptions _networkPerformanceOptions;
        private OperatorResponse _operator;
        private LaunchTemplatePlacement _placement;
        private LaunchTemplatePrivateDnsNameOptions _privateDnsNameOptions;
        private string _ramDiskId;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<LaunchTemplateTagSpecification> _tagSpecifications = AWSConfigs.InitializeCollections ? new List<LaunchTemplateTagSpecification>() : null;
        private string _userData;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateBlockDeviceMapping> BlockDeviceMappings
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
        /// Information about the Capacity Reservation targeting option.
        /// </para>
        /// </summary>
        public LaunchTemplateCapacityReservationSpecificationResponse CapacityReservationSpecification
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
        public LaunchTemplateCpuOptions CpuOptions
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
        /// The credit option for CPU usage of the instance.
        /// </para>
        /// </summary>
        public CreditSpecification CreditSpecification
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
        /// Indicates whether the instance is enabled for stop protection. For more information,
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
        /// If set to <c>true</c>, indicates that the instance cannot be terminated using the
        /// Amazon EC2 console, command line tool, or API.
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
        /// Indicates whether the instance is optimized for Amazon EBS I/O. 
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
        public List<ElasticGpuSpecificationResponse> ElasticGpuSpecifications
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
        public List<LaunchTemplateElasticInferenceAcceleratorResponse> ElasticInferenceAccelerators
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
        /// </para>
        /// </summary>
        public LaunchTemplateEnclaveOptions EnclaveOptions
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
        /// Indicates whether an instance is configured for hibernation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
        /// your Amazon EC2 instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public LaunchTemplateHibernationOptions HibernationOptions
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
        /// The IAM instance profile.
        /// </para>
        /// </summary>
        public LaunchTemplateIamInstanceProfileSpecification IamInstanceProfile
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
        /// The ID of the AMI or a Systems Manager parameter. The Systems Manager parameter will
        /// resolve to the ID of the AMI at instance launch.
        /// </para>
        ///  
        /// <para>
        /// The value depends on what you specified in the request. The possible values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If an AMI ID was specified in the request, then this is the AMI ID.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a Systems Manager parameter was specified in the request, and <c>ResolveAlias</c>
        /// was configured as <c>true</c>, then this is the AMI ID that the parameter is mapped
        /// to in the Parameter Store.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If a Systems Manager parameter was specified in the request, and <c>ResolveAlias</c>
        /// was configured as <c>false</c>, then this is the parameter value.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/create-launch-template.html#use-an-ssm-parameter-instead-of-an-ami-id">Use
        /// a Systems Manager parameter instead of an AMI ID</a> in the <i>Amazon EC2 User Guide</i>.
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
        public LaunchTemplateInstanceMarketOptions InstanceMarketOptions
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
        /// If you specify <c>InstanceRequirements</c>, you can't specify <c>InstanceTypes</c>.
        /// </para>
        /// </summary>
        public InstanceRequirements InstanceRequirements
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
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The ID of the kernel, if applicable.
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
        /// The name of the key pair.
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
        public List<LaunchTemplateLicenseConfiguration> LicenseSpecifications
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
        /// The maintenance options for your instance.
        /// </para>
        /// </summary>
        public LaunchTemplateInstanceMaintenanceOptions MaintenanceOptions
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
        public LaunchTemplateInstanceMetadataOptions MetadataOptions
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
        public LaunchTemplatesMonitoring Monitoring
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
        /// The network interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateInstanceNetworkInterfaceSpecification> NetworkInterfaces
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
        /// Contains the launch template settings for network performance options for your instance.
        /// </para>
        /// </summary>
        public LaunchTemplateNetworkPerformanceOptions NetworkPerformanceOptions
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
        public OperatorResponse Operator
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
        /// The placement of the instance.
        /// </para>
        /// </summary>
        public LaunchTemplatePlacement Placement
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
        /// The options for the instance hostname.
        /// </para>
        /// </summary>
        public LaunchTemplatePrivateDnsNameOptions PrivateDnsNameOptions
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
        /// The ID of the RAM disk, if applicable.
        /// </para>
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
        /// The security group IDs.
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
        /// The security group names.
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
        /// The tags that are applied to the resources that are created during instance launch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateTagSpecification> TagSpecifications
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
        /// The user data for the instance. 
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