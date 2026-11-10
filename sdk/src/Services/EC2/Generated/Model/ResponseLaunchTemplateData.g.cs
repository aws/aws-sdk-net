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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// The information for a launch template.
    /// </summary>
    public partial class ResponseLaunchTemplateData
    {
        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// The block device mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateBlockDeviceMapping> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<LaunchTemplateBlockDeviceMapping>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CapacityReservationSpecification. 
        /// <para>
        /// Information about the Capacity Reservation targeting option.
        /// </para>
        /// </summary>
        public LaunchTemplateCapacityReservationSpecificationResponse CapacityReservationSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CapacityReservationSpecification property is set.
        /// </summary>
        internal bool IsSetCapacityReservationSpecification() => this.CapacityReservationSpecification != null;

        /// <summary>
        /// Gets and sets the property CpuOptions. 
        /// <para>
        /// The CPU options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-optimize-cpu.html">CPU
        /// options for Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public LaunchTemplateCpuOptions CpuOptions { get; set; }

        /// <summary>
        /// Checks to see if the CpuOptions property is set.
        /// </summary>
        internal bool IsSetCpuOptions() => this.CpuOptions != null;

        /// <summary>
        /// Gets and sets the property CreditSpecification. 
        /// <para>
        /// The credit option for CPU usage of the instance.
        /// </para>
        /// </summary>
        public CreditSpecification CreditSpecification { get; set; }

        /// <summary>
        /// Checks to see if the CreditSpecification property is set.
        /// </summary>
        internal bool IsSetCreditSpecification() => this.CreditSpecification != null;

        /// <summary>
        /// Gets and sets the property DisableApiStop. 
        /// <para>
        /// Indicates whether the instance is enabled for stop protection. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-stop-protection.html">Enable
        /// stop protection for your EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// If set to <c>true</c>, indicates that the instance cannot be terminated using the
        /// Amazon EC2 console, command line tool, or API.
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
        /// Indicates whether the instance is optimized for Amazon EBS I/O. 
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ElasticGpuSpecificationResponse> ElasticGpuSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<ElasticGpuSpecificationResponse>() : null;

        /// <summary>
        /// Checks to see if the ElasticGpuSpecifications property is set.
        /// </summary>
        internal bool IsSetElasticGpuSpecifications() => this.ElasticGpuSpecifications != null && (this.ElasticGpuSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateElasticInferenceAcceleratorResponse> ElasticInferenceAccelerators { get; set; } = AWSConfigs.InitializeCollections ? new List<LaunchTemplateElasticInferenceAcceleratorResponse>() : null;

        /// <summary>
        /// Checks to see if the ElasticInferenceAccelerators property is set.
        /// </summary>
        internal bool IsSetElasticInferenceAccelerators() => this.ElasticInferenceAccelerators != null && (this.ElasticInferenceAccelerators.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EnclaveOptions. 
        /// <para>
        /// Indicates whether the instance is enabled for Amazon Web Services Nitro Enclaves.
        /// </para>
        /// </summary>
        public LaunchTemplateEnclaveOptions EnclaveOptions { get; set; }

        /// <summary>
        /// Checks to see if the EnclaveOptions property is set.
        /// </summary>
        internal bool IsSetEnclaveOptions() => this.EnclaveOptions != null;

        /// <summary>
        /// Gets and sets the property HibernationOptions. 
        /// <para>
        /// Indicates whether an instance is configured for hibernation. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Hibernate.html">Hibernate
        /// your Amazon EC2 instance</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public LaunchTemplateHibernationOptions HibernationOptions { get; set; }

        /// <summary>
        /// Checks to see if the HibernationOptions property is set.
        /// </summary>
        internal bool IsSetHibernationOptions() => this.HibernationOptions != null;

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The IAM instance profile.
        /// </para>
        /// </summary>
        public LaunchTemplateIamInstanceProfileSpecification IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;

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
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceInitiatedShutdownBehavior. 
        /// <para>
        /// Indicates whether an instance stops or terminates when you initiate shutdown from
        /// the instance (using the operating system command for system shutdown).
        /// </para>
        /// </summary>
        public ShutdownBehavior InstanceInitiatedShutdownBehavior { get; set; }

        /// <summary>
        /// Checks to see if the InstanceInitiatedShutdownBehavior property is set.
        /// </summary>
        internal bool IsSetInstanceInitiatedShutdownBehavior() => this.InstanceInitiatedShutdownBehavior != null;

        /// <summary>
        /// Gets and sets the property InstanceMarketOptions. 
        /// <para>
        /// The market (purchasing) option for the instances.
        /// </para>
        /// </summary>
        public LaunchTemplateInstanceMarketOptions InstanceMarketOptions { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMarketOptions property is set.
        /// </summary>
        internal bool IsSetInstanceMarketOptions() => this.InstanceMarketOptions != null;

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
        public InstanceRequirements InstanceRequirements { get; set; }

        /// <summary>
        /// Checks to see if the InstanceRequirements property is set.
        /// </summary>
        internal bool IsSetInstanceRequirements() => this.InstanceRequirements != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type.
        /// </para>
        /// </summary>
        public InstanceType InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The ID of the kernel, if applicable.
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
        /// The name of the key pair.
        /// </para>
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property LicenseSpecifications. 
        /// <para>
        /// The license configurations.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateLicenseConfiguration> LicenseSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<LaunchTemplateLicenseConfiguration>() : null;

        /// <summary>
        /// Checks to see if the LicenseSpecifications property is set.
        /// </summary>
        internal bool IsSetLicenseSpecifications() => this.LicenseSpecifications != null && (this.LicenseSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MaintenanceOptions. 
        /// <para>
        /// The maintenance options for your instance.
        /// </para>
        /// </summary>
        public LaunchTemplateInstanceMaintenanceOptions MaintenanceOptions { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceOptions property is set.
        /// </summary>
        internal bool IsSetMaintenanceOptions() => this.MaintenanceOptions != null;

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the instance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/configuring-instance-metadata-options.html">Configure
        /// the Instance Metadata Service options</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        public LaunchTemplateInstanceMetadataOptions MetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOptions property is set.
        /// </summary>
        internal bool IsSetMetadataOptions() => this.MetadataOptions != null;

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        /// The monitoring for the instance.
        /// </para>
        /// </summary>
        public LaunchTemplatesMonitoring Monitoring { get; set; }

        /// <summary>
        /// Checks to see if the Monitoring property is set.
        /// </summary>
        internal bool IsSetMonitoring() => this.Monitoring != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The network interfaces.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateInstanceNetworkInterfaceSpecification> NetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<LaunchTemplateInstanceNetworkInterfaceSpecification>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaces() => this.NetworkInterfaces != null && (this.NetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkPerformanceOptions. 
        /// <para>
        /// Contains the launch template settings for network performance options for your instance.
        /// </para>
        /// </summary>
        public LaunchTemplateNetworkPerformanceOptions NetworkPerformanceOptions { get; set; }

        /// <summary>
        /// Checks to see if the NetworkPerformanceOptions property is set.
        /// </summary>
        internal bool IsSetNetworkPerformanceOptions() => this.NetworkPerformanceOptions != null;

        /// <summary>
        /// Gets and sets the property Operator. 
        /// <para>
        /// The entity that manages the launch template.
        /// </para>
        /// </summary>
        public OperatorResponse Operator { get; set; }

        /// <summary>
        /// Checks to see if the Operator property is set.
        /// </summary>
        internal bool IsSetOperator() => this.Operator != null;

        /// <summary>
        /// Gets and sets the property Placement. 
        /// <para>
        /// The placement of the instance.
        /// </para>
        /// </summary>
        public LaunchTemplatePlacement Placement { get; set; }

        /// <summary>
        /// Checks to see if the Placement property is set.
        /// </summary>
        internal bool IsSetPlacement() => this.Placement != null;

        /// <summary>
        /// Gets and sets the property PrivateDnsNameOptions. 
        /// <para>
        /// The options for the instance hostname.
        /// </para>
        /// </summary>
        public LaunchTemplatePrivateDnsNameOptions PrivateDnsNameOptions { get; set; }

        /// <summary>
        /// Checks to see if the PrivateDnsNameOptions property is set.
        /// </summary>
        internal bool IsSetPrivateDnsNameOptions() => this.PrivateDnsNameOptions != null;

        /// <summary>
        /// Gets and sets the property RamDiskId. 
        /// <para>
        /// The ID of the RAM disk, if applicable.
        /// </para>
        /// </summary>
        public string RamDiskId { get; set; }

        /// <summary>
        /// Checks to see if the RamDiskId property is set.
        /// </summary>
        internal bool IsSetRamDiskId() => this.RamDiskId != null;

        /// <summary>
        /// Gets and sets the property SecondaryInterfaces. 
        /// <para>
        /// The secondary interfaces associated with the launch template.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateInstanceSecondaryInterfaceSpecification> SecondaryInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<LaunchTemplateInstanceSecondaryInterfaceSpecification>() : null;

        /// <summary>
        /// Checks to see if the SecondaryInterfaces property is set.
        /// </summary>
        internal bool IsSetSecondaryInterfaces() => this.SecondaryInterfaces != null && (this.SecondaryInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The security group IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security group names.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroups property is set.
        /// </summary>
        internal bool IsSetSecurityGroups() => this.SecurityGroups != null && (this.SecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags that are applied to the resources that are created during instance launch.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<LaunchTemplateTagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<LaunchTemplateTagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// The user data for the instance. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string UserData { get; set; }

        /// <summary>
        /// Checks to see if the UserData property is set.
        /// </summary>
        internal bool IsSetUserData() => this.UserData != null;
    }
}
