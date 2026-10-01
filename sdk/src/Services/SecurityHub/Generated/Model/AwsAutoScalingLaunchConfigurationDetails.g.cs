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
    /// Details about a launch configuration.
    /// </summary>
    public partial class AwsAutoScalingLaunchConfigurationDetails
    {
        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// For Auto Scaling groups that run in a VPC, specifies whether to assign a public IP
        /// address to the group's instances.
        /// </para>
        /// </summary>
        public bool? AssociatePublicIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the AssociatePublicIpAddress property is set.
        /// </summary>
        internal bool IsSetAssociatePublicIpAddress() => this.AssociatePublicIpAddress.HasValue;

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// Specifies the block devices for the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsAutoScalingLaunchConfigurationBlockDeviceMappingsDetails> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsAutoScalingLaunchConfigurationBlockDeviceMappingsDetails>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClassicLinkVpcId. 
        /// <para>
        /// The identifier of a ClassicLink-enabled VPC that EC2-Classic instances are linked
        /// to.
        /// </para>
        /// </summary>
        public string ClassicLinkVpcId { get; set; }

        /// <summary>
        /// Checks to see if the ClassicLinkVpcId property is set.
        /// </summary>
        internal bool IsSetClassicLinkVpcId() => this.ClassicLinkVpcId != null;

        /// <summary>
        /// Gets and sets the property ClassicLinkVpcSecurityGroups. 
        /// <para>
        /// The identifiers of one or more security groups for the VPC that is specified in <c>ClassicLinkVPCId</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ClassicLinkVpcSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClassicLinkVpcSecurityGroups property is set.
        /// </summary>
        internal bool IsSetClassicLinkVpcSecurityGroups() => this.ClassicLinkVpcSecurityGroups != null && (this.ClassicLinkVpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The creation date and time for the launch configuration.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime != null;

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Whether the launch configuration is optimized for Amazon EBS I/O.
        /// </para>
        /// </summary>
        public bool? EbsOptimized { get; set; }

        /// <summary>
        /// Checks to see if the EbsOptimized property is set.
        /// </summary>
        internal bool IsSetEbsOptimized() => this.EbsOptimized.HasValue;

        /// <summary>
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The name or the ARN of the instance profile associated with the IAM role for the instance.
        /// The instance profile contains the IAM role.
        /// </para>
        /// </summary>
        public string IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The identifier of the Amazon Machine Image (AMI) that is used to launch EC2 instances.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceMonitoring. 
        /// <para>
        /// Indicates the type of monitoring for instances in the group.
        /// </para>
        /// </summary>
        public AwsAutoScalingLaunchConfigurationInstanceMonitoringDetails InstanceMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMonitoring property is set.
        /// </summary>
        internal bool IsSetInstanceMonitoring() => this.InstanceMonitoring != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for the instances.
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
        /// The identifier of the kernel associated with the AMI.
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
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration.
        /// </para>
        /// </summary>
        public string LaunchConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the LaunchConfigurationName property is set.
        /// </summary>
        internal bool IsSetLaunchConfigurationName() => this.LaunchConfigurationName != null;

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the instances.
        /// </para>
        /// </summary>
        public AwsAutoScalingLaunchConfigurationMetadataOptions MetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOptions property is set.
        /// </summary>
        internal bool IsSetMetadataOptions() => this.MetadataOptions != null;

        /// <summary>
        /// Gets and sets the property PlacementTenancy. 
        /// <para>
        /// The tenancy of the instance. An instance with <c>dedicated</c> tenancy runs on isolated,
        /// single-tenant hardware and can only be launched into a VPC.
        /// </para>
        /// </summary>
        public string PlacementTenancy { get; set; }

        /// <summary>
        /// Checks to see if the PlacementTenancy property is set.
        /// </summary>
        internal bool IsSetPlacementTenancy() => this.PlacementTenancy != null;

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The identifier of the RAM disk associated with the AMI.
        /// </para>
        /// </summary>
        public string RamdiskId { get; set; }

        /// <summary>
        /// Checks to see if the RamdiskId property is set.
        /// </summary>
        internal bool IsSetRamdiskId() => this.RamdiskId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// The security groups to assign to the instances in the Auto Scaling group.
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
        /// Gets and sets the property SpotPrice. 
        /// <para>
        /// The maximum hourly price to be paid for any Spot Instance that is launched to fulfill
        /// the request.
        /// </para>
        /// </summary>
        public string SpotPrice { get; set; }

        /// <summary>
        /// Checks to see if the SpotPrice property is set.
        /// </summary>
        internal bool IsSetSpotPrice() => this.SpotPrice != null;

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// The user data to make available to the launched EC2 instances. Must be base64-encoded
        /// text.
        /// </para>
        /// </summary>
        public string UserData { get; set; }

        /// <summary>
        /// Checks to see if the UserData property is set.
        /// </summary>
        internal bool IsSetUserData() => this.UserData != null;
    }
}
