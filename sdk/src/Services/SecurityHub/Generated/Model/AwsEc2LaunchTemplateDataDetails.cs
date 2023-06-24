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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The information to include in an Amazon Elastic Compute Cloud (Amazon EC2) launch
    /// template.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataDetails
    {
        private List<AwsEc2LaunchTemplateDataBlockDeviceMappingSetDetails> _blockDeviceMappingSet = new List<AwsEc2LaunchTemplateDataBlockDeviceMappingSetDetails>();
        private AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails _capacityReservationSpecification;
        private AwsEc2LaunchTemplateDataCpuOptionsDetails _cpuOptions;
        private AwsEc2LaunchTemplateDataCreditSpecificationDetails _creditSpecification;
        private bool? _disableApiStop;
        private bool? _disableApiTermination;
        private bool? _ebsOptimized;
        private List<AwsEc2LaunchTemplateDataElasticGpuSpecificationSetDetails> _elasticGpuSpecificationSet = new List<AwsEc2LaunchTemplateDataElasticGpuSpecificationSetDetails>();
        private List<AwsEc2LaunchTemplateDataElasticInferenceAcceleratorSetDetails> _elasticInferenceAcceleratorSet = new List<AwsEc2LaunchTemplateDataElasticInferenceAcceleratorSetDetails>();
        private AwsEc2LaunchTemplateDataEnclaveOptionsDetails _enclaveOptions;
        private AwsEc2LaunchTemplateDataHibernationOptionsDetails _hibernationOptions;
        private AwsEc2LaunchTemplateDataIamInstanceProfileDetails _iamInstanceProfile;
        private string _imageId;
        private string _instanceInitiatedShutdownBehavior;
        private AwsEc2LaunchTemplateDataInstanceMarketOptionsDetails _instanceMarketOptions;
        private AwsEc2LaunchTemplateDataInstanceRequirementsDetails _instanceRequirements;
        private string _instanceType;
        private string _kernelId;
        private string _keyName;
        private List<AwsEc2LaunchTemplateDataLicenseSetDetails> _licenseSet = new List<AwsEc2LaunchTemplateDataLicenseSetDetails>();
        private AwsEc2LaunchTemplateDataMaintenanceOptionsDetails _maintenanceOptions;
        private AwsEc2LaunchTemplateDataMetadataOptionsDetails _metadataOptions;
        private AwsEc2LaunchTemplateDataMonitoringDetails _monitoring;
        private List<AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails> _networkInterfaceSet = new List<AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails>();
        private AwsEc2LaunchTemplateDataPlacementDetails _placement;
        private AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetails _privateDnsNameOptions;
        private string _ramDiskId;
        private List<string> _securityGroupIdSet = new List<string>();
        private List<string> _securityGroupSet = new List<string>();
        private string _userData;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappingSet. 
        /// <para>
        ///  Information about a block device mapping for an Amazon EC2 launch template. 
        /// </para>
        /// </summary>
        public List<AwsEc2LaunchTemplateDataBlockDeviceMappingSetDetails> BlockDeviceMappingSet
        {
            get { return this._blockDeviceMappingSet; }
            set { this._blockDeviceMappingSet = value; }
        }

        // Check to see if BlockDeviceMappingSet property is set
        internal bool IsSetBlockDeviceMappingSet()
        {
            return this._blockDeviceMappingSet != null && this._blockDeviceMappingSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        ///  Specifies an instance's Capacity Reservation targeting option. You can specify only
        /// one option at a time. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails CapacityReservationSpecification
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
        ///  Specifies the CPU options for an instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-optimize-cpu.html">Optimize
        /// CPU options</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataCpuOptionsDetails CpuOptions
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
        ///  Specifies the credit option for CPU usage of a T2, T3, or T3a instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataCreditSpecificationDetails CreditSpecification
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
        ///  Indicates whether to enable the instance for stop protection. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html#Using_StopProtection">Enable
        /// stop protection</a> in the <i>Amazon EC2 User Guide</i>. 
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
        ///  If you set this parameter to <code>true</code>, you can't terminate the instance
        /// using the Amazon EC2 console, CLI, or API. If set to <code>true</code>, you can. 
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
        ///  Indicates whether the instance is optimized for Amazon EBS I/O. 
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
        /// Gets and sets the property ElasticGpuSpecificationSet. 
        /// <para>
        ///  Provides details about Elastic Graphics accelerators to associate with the instance.
        /// 
        /// </para>
        /// </summary>
        public List<AwsEc2LaunchTemplateDataElasticGpuSpecificationSetDetails> ElasticGpuSpecificationSet
        {
            get { return this._elasticGpuSpecificationSet; }
            set { this._elasticGpuSpecificationSet = value; }
        }

        // Check to see if ElasticGpuSpecificationSet property is set
        internal bool IsSetElasticGpuSpecificationSet()
        {
            return this._elasticGpuSpecificationSet != null && this._elasticGpuSpecificationSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorSet. 
        /// <para>
        ///  The Amazon Elastic Inference accelerator for the instance. 
        /// </para>
        /// </summary>
        public List<AwsEc2LaunchTemplateDataElasticInferenceAcceleratorSetDetails> ElasticInferenceAcceleratorSet
        {
            get { return this._elasticInferenceAcceleratorSet; }
            set { this._elasticInferenceAcceleratorSet = value; }
        }

        // Check to see if ElasticInferenceAcceleratorSet property is set
        internal bool IsSetElasticInferenceAcceleratorSet()
        {
            return this._elasticInferenceAcceleratorSet != null && this._elasticInferenceAcceleratorSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        ///  Indicates whether the Amazon EC2 instance is enabled for Amazon Web Services Nitro
        /// Enclaves. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataEnclaveOptionsDetails EnclaveOptions
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
        ///  Specifies whether your Amazon EC2 instance is configured for hibernation. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataHibernationOptionsDetails HibernationOptions
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
        ///  The name or Amazon Resource Name (ARN) of an IAM instance profile. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataIamInstanceProfileDetails IamInstanceProfile
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
        ///  The ID of the Amazon Machine Image (AMI). 
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
        ///  Provides the options for specifying the instance initiated shutdown behavior. 
        /// </para>
        /// </summary>
        public string InstanceInitiatedShutdownBehavior
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
        ///  Specifies the market (purchasing) option for an instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceMarketOptionsDetails InstanceMarketOptions
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
        ///  The attributes for the instance types. When you specify instance attributes, Amazon
        /// EC2 will identify instance types with these attributes. If you specify <code>InstanceRequirements</code>,
        /// you can't specify <code>InstanceType</code>. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsDetails InstanceRequirements
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
        ///  The instance type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>. If you specify <code>InstanceType</code>,
        /// you can't specify <code>InstanceRequirements</code>. 
        /// </para>
        /// </summary>
        public string InstanceType
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
        ///  The ID of the kernel. 
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
        ///  The name of the key pair that allows users to connect to the instance. 
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
        /// Gets and sets the property LicenseSet. 
        /// <para>
        ///  Specifies a license configuration for an instance. 
        /// </para>
        /// </summary>
        public List<AwsEc2LaunchTemplateDataLicenseSetDetails> LicenseSet
        {
            get { return this._licenseSet; }
            set { this._licenseSet = value; }
        }

        // Check to see if LicenseSet property is set
        internal bool IsSetLicenseSet()
        {
            return this._licenseSet != null && this._licenseSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaintenanceOptions. 
        /// <para>
        ///  The maintenance options of your instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataMaintenanceOptionsDetails MaintenanceOptions
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
        ///  The metadata options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html">Instance
        /// metadata and user data</a> in the <i>Amazon EC2 User Guide</i>. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataMetadataOptionsDetails MetadataOptions
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
        ///  The monitoring for the instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataMonitoringDetails Monitoring
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
        /// Gets and sets the property NetworkInterfaceSet. 
        /// <para>
        ///  Specifies the parameters for a network interface that is attached to the instance.
        /// 
        /// </para>
        /// </summary>
        public List<AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails> NetworkInterfaceSet
        {
            get { return this._networkInterfaceSet; }
            set { this._networkInterfaceSet = value; }
        }

        // Check to see if NetworkInterfaceSet property is set
        internal bool IsSetNetworkInterfaceSet()
        {
            return this._networkInterfaceSet != null && this._networkInterfaceSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        ///  Specifies the placement of an instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataPlacementDetails Placement
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
        ///  The options for the instance hostname. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetails PrivateDnsNameOptions
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
        ///  The ID of the RAM disk. 
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
        /// Gets and sets the property SecurityGroupIdSet. 
        /// <para>
        ///  One or more security group IDs. 
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIdSet
        {
            get { return this._securityGroupIdSet; }
            set { this._securityGroupIdSet = value; }
        }

        // Check to see if SecurityGroupIdSet property is set
        internal bool IsSetSecurityGroupIdSet()
        {
            return this._securityGroupIdSet != null && this._securityGroupIdSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupSet. 
        /// <para>
        ///  One or more security group names. For a nondefault VPC, you must use security group
        /// IDs instead. You cannot specify both a security group ID and security name in the
        /// same request. 
        /// </para>
        /// </summary>
        public List<string> SecurityGroupSet
        {
            get { return this._securityGroupSet; }
            set { this._securityGroupSet = value; }
        }

        // Check to see if SecurityGroupSet property is set
        internal bool IsSetSecurityGroupSet()
        {
            return this._securityGroupSet != null && this._securityGroupSet.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        ///  The user data to make available to the instance. 
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