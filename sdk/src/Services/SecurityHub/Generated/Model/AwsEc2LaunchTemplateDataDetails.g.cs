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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The information to include in an Amazon Elastic Compute Cloud (Amazon EC2) launch
    /// template.
    /// </summary>
    public partial class AwsEc2LaunchTemplateDataDetails
    {
        /// <summary>
        /// Gets and sets the property BlockDeviceMappingSet. 
        /// <para>
        ///  Information about a block device mapping for an Amazon EC2 launch template. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2LaunchTemplateDataBlockDeviceMappingSetDetails> BlockDeviceMappingSet { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2LaunchTemplateDataBlockDeviceMappingSetDetails>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappingSet property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappingSet() => this.BlockDeviceMappingSet != null && (this.BlockDeviceMappingSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        ///  Specifies an instance's Capacity Reservation targeting option. You can specify only
        /// one option at a time. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataCapacityReservationSpecificationDetails CapacityReservationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationSpecification property is set.
        /// </summary>
        internal bool IsSetCapacityReservationSpecification() => this.CapacityReservationSpecification != null;

        /// <summary>
        /// Gets and sets the property CpuOptions. 
        /// <para>
        ///  Specifies the CPU options for an instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-optimize-cpu.html">Optimize
        /// CPU options</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataCpuOptionsDetails CpuOptions { get; set; }

        /// <summary>
        /// Checks to see if the CpuOptions property is set.
        /// </summary>
        internal bool IsSetCpuOptions() => this.CpuOptions != null;

        /// <summary>
        /// Gets and sets the property CreditSpecification. 
        /// <para>
        ///  Specifies the credit option for CPU usage of a T2, T3, or T3a instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataCreditSpecificationDetails CreditSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CreditSpecification property is set.
        /// </summary>
        internal bool IsSetCreditSpecification() => this.CreditSpecification != null;

        /// <summary>
        /// Gets and sets the property DisableApiStop. 
        /// <para>
        ///  Indicates whether to enable the instance for stop protection. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html#Using_StopProtection">Enable
        /// stop protection</a> in the <i>Amazon EC2 User Guide</i>. 
        /// </para>
        /// </summary>
        public bool? DisableApiStop { get; set; }

        /// <summary>
        /// Checks to see if the DisableApiStop property is set.
        /// </summary>
        internal bool IsSetDisableApiStop() => this.DisableApiStop.HasValue;

        /// <summary>
        /// Gets and sets the property DisableApiTermination. 
        /// <para>
        ///  If you set this parameter to <c>true</c>, you can't terminate the instance using
        /// the Amazon EC2 console, CLI, or API. If set to <c>true</c>, you can. 
        /// </para>
        /// </summary>
        public bool? DisableApiTermination { get; set; }

        /// <summary>
        /// Checks to see if the DisableApiTermination property is set.
        /// </summary>
        internal bool IsSetDisableApiTermination() => this.DisableApiTermination.HasValue;

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        ///  Indicates whether the instance is optimized for Amazon EBS I/O. 
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;

        /// <summary>
        /// Gets and sets the property ElasticGpuSpecificationSet. 
        /// <para>
        ///  Provides details about Elastic Graphics accelerators to associate with the instance.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2LaunchTemplateDataElasticGpuSpecificationSetDetails> ElasticGpuSpecificationSet { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2LaunchTemplateDataElasticGpuSpecificationSetDetails>() : null;

        /// <summary>
        /// Checks to see if the ElasticGpuSpecificationSet property is set.
        /// </summary>
        internal bool IsSetElasticGpuSpecificationSet() => this.ElasticGpuSpecificationSet != null && (this.ElasticGpuSpecificationSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ElasticInferenceAcceleratorSet. 
        /// <para>
        ///  The Amazon Elastic Inference accelerator for the instance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2LaunchTemplateDataElasticInferenceAcceleratorSetDetails> ElasticInferenceAcceleratorSet { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2LaunchTemplateDataElasticInferenceAcceleratorSetDetails>() : null;

        /// <summary>
        /// Checks to see if the ElasticInferenceAcceleratorSet property is set.
        /// </summary>
        internal bool IsSetElasticInferenceAcceleratorSet() => this.ElasticInferenceAcceleratorSet != null && (this.ElasticInferenceAcceleratorSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        ///  Indicates whether the Amazon EC2 instance is enabled for Amazon Web Services Nitro
        /// Enclaves. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataEnclaveOptionsDetails EnclaveOptions { get; set; }

        /// <summary>
        /// Checks to see if the EnclaveOptions property is set.
        /// </summary>
        internal bool IsSetEnclaveOptions() => this.EnclaveOptions != null;

        /// <summary>
        /// Gets and sets the property HibernationOptions. 
        /// <para>
        ///  Specifies whether your Amazon EC2 instance is configured for hibernation. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataHibernationOptionsDetails HibernationOptions { get; set; }

        /// <summary>
        /// Checks to see if the HibernationOptions property is set.
        /// </summary>
        internal bool IsSetHibernationOptions() => this.HibernationOptions != null;

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        ///  The name or Amazon Resource Name (ARN) of an IAM instance profile. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataIamInstanceProfileDetails IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        ///  The ID of the Amazon Machine Image (AMI). 
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceInitiatedShutdownBehavior. 
        /// <para>
        ///  Provides the options for specifying the instance initiated shutdown behavior. 
        /// </para>
        /// </summary>
        public string InstanceInitiatedShutdownBehavior { get; set; }

        /// <summary>
        /// Checks to see if the InstanceInitiatedShutdownBehavior property is set.
        /// </summary>
        internal bool IsSetInstanceInitiatedShutdownBehavior() => this.InstanceInitiatedShutdownBehavior != null;

        /// <summary>
        /// Gets and sets the property InstanceMarketOptions. 
        /// <para>
        ///  Specifies the market (purchasing) option for an instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceMarketOptionsDetails InstanceMarketOptions { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMarketOptions property is set.
        /// </summary>
        internal bool IsSetInstanceMarketOptions() => this.InstanceMarketOptions != null;

        /// <summary>
        /// Gets and sets the property InstanceRequirements. 
        /// <para>
        ///  The attributes for the instance types. When you specify instance attributes, Amazon
        /// EC2 will identify instance types with these attributes. If you specify <c>InstanceRequirements</c>,
        /// you can't specify <c>InstanceType</c>. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataInstanceRequirementsDetails InstanceRequirements { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRequirements property is set.
        /// </summary>
        internal bool IsSetInstanceRequirements() => this.InstanceRequirements != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        ///  The instance type. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// types</a> in the <i>Amazon EC2 User Guide</i>. If you specify <c>InstanceType</c>,
        /// you can't specify <c>InstanceRequirements</c>. 
        /// </para>
        /// </summary>
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        ///  The ID of the kernel. 
        /// </para>
        /// </summary>
        public string KernelId { get; set; }

        /// <summary>
        /// Checks to see if the KernelId property is set.
        /// </summary>
        internal bool IsSetKernelId() => this.KernelId != null;

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        ///  The name of the key pair that allows users to connect to the instance. 
        /// </para>
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property LicenseSet. 
        /// <para>
        ///  Specifies a license configuration for an instance. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2LaunchTemplateDataLicenseSetDetails> LicenseSet { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2LaunchTemplateDataLicenseSetDetails>() : null;

        /// <summary>
        /// Checks to see if the LicenseSet property is set.
        /// </summary>
        internal bool IsSetLicenseSet() => this.LicenseSet != null && (this.LicenseSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaintenanceOptions. 
        /// <para>
        ///  The maintenance options of your instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataMaintenanceOptionsDetails MaintenanceOptions { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceOptions property is set.
        /// </summary>
        internal bool IsSetMaintenanceOptions() => this.MaintenanceOptions != null;

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        ///  The metadata options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html">Instance
        /// metadata and user data</a> in the <i>Amazon EC2 User Guide</i>. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataMetadataOptionsDetails MetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOptions property is set.
        /// </summary>
        internal bool IsSetMetadataOptions() => this.MetadataOptions != null;

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        ///  The monitoring for the instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataMonitoringDetails Monitoring { get; set; }

        /// <summary>
        /// Checks to see if the Monitoring property is set.
        /// </summary>
        internal bool IsSetMonitoring() => this.Monitoring != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceSet. 
        /// <para>
        ///  Specifies the parameters for a network interface that is attached to the instance.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails> NetworkInterfaceSet { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2LaunchTemplateDataNetworkInterfaceSetDetails>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaceSet property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceSet() => this.NetworkInterfaceSet != null && (this.NetworkInterfaceSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        ///  Specifies the placement of an instance. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataPlacementDetails Placement { get; set; }

        /// <summary>
        /// Checks to see if the Placement property is set.
        /// </summary>
        internal bool IsSetPlacement() => this.Placement != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsNameOptions. 
        /// <para>
        ///  The options for the instance hostname. 
        /// </para>
        /// </summary>
        public AwsEc2LaunchTemplateDataPrivateDnsNameOptionsDetails PrivateDnsNameOptions { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsNameOptions property is set.
        /// </summary>
        internal bool IsSetPrivateDnsNameOptions() => this.PrivateDnsNameOptions != null;

        /// <summary>
        /// Gets and sets the property RamDiskId. 
        /// <para>
        ///  The ID of the RAM disk. 
        /// </para>
        /// </summary>
        public string RamDiskId { get; set; }

        /// <summary>
        /// Checks to see if the RamDiskId property is set.
        /// </summary>
        internal bool IsSetRamDiskId() => this.RamDiskId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIdSet. 
        /// <para>
        ///  One or more security group IDs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIdSet { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIdSet property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIdSet() => this.SecurityGroupIdSet != null && (this.SecurityGroupIdSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroupSet. 
        /// <para>
        ///  One or more security group names. For a nondefault VPC, you must use security group
        /// IDs instead. You cannot specify both a security group ID and security name in the
        /// same request. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupSet { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupSet property is set.
        /// </summary>
        internal bool IsSetSecurityGroupSet() => this.SecurityGroupSet != null && (this.SecurityGroupSet.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        ///  The user data to make available to the instance. 
        /// </para>
        /// </summary>
        public string UserData { get; set; }

        /// <summary>
        /// Checks to see if the UserData property is set.
        /// </summary>
        internal bool IsSetUserData() => this.UserData != null;
    }
}
