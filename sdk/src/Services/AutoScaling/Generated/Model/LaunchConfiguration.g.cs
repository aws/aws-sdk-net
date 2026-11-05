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

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a launch configuration.
    /// </summary>
    public partial class LaunchConfiguration
    {
        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Specifies whether to assign a public IPv4 address to the group's instances. If the
        /// instance is launched into a default subnet, the default is to assign a public IPv4
        /// address, unless you disabled the option to assign a public IPv4 address on the subnet.
        /// If the instance is launched into a nondefault subnet, the default is not to assign
        /// a public IPv4 address, unless you enabled the option to assign a public IPv4 address
        /// on the subnet. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-in-vpc.html">Provide
        /// network connectivity for your Auto Scaling instances using Amazon VPC</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
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
        /// The block device mapping entries that define the block devices to attach to the instances
        /// at launch. By default, the block devices specified in the block device mapping for
        /// the AMI are used. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html">Block
        /// device mappings</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings { get; set; } = AWSConfigs.InitializeCollections ? new List<BlockDeviceMapping>() : null;

        /// <summary>
        /// Checks to see if the BlockDeviceMappings property is set.
        /// </summary>
        internal bool IsSetBlockDeviceMappings() => this.BlockDeviceMappings != null && (this.BlockDeviceMappings.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ClassicLinkVPCId. 
        /// <para>
        /// Available for backward compatibility.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ClassicLinkVPCId { get; set; }

        /// <summary>
        /// Checks to see if the ClassicLinkVPCId property is set.
        /// </summary>
        internal bool IsSetClassicLinkVPCId() => this.ClassicLinkVPCId != null;

        /// <summary>
        /// Gets and sets the property ClassicLinkVPCSecurityGroups. 
        /// <para>
        /// Available for backward compatibility.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ClassicLinkVPCSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClassicLinkVPCSecurityGroups property is set.
        /// </summary>
        internal bool IsSetClassicLinkVPCSecurityGroups() => this.ClassicLinkVPCSecurityGroups != null && (this.ClassicLinkVPCSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The creation date and time for the launch configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTime property is set.
        /// </summary>
        internal bool IsSetCreatedTime() => this.CreatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Specifies whether the launch configuration is optimized for EBS I/O (<c>true</c>)
        /// or not (<c>false</c>). For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-optimized.html">Amazon
        /// EBS-optimized instances</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// The name or the Amazon Resource Name (ARN) of the instance profile associated with
        /// the IAM role for the instance. The instance profile contains the IAM role. For more
        /// information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/us-iam-role.html">IAM
        /// role for applications that run on Amazon EC2 instances</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string IamInstanceProfile { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfile property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfile() => this.IamInstanceProfile != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The ID of the Amazon Machine Image (AMI) to use to launch your EC2 instances. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/finding-an-ami.html">Find
        /// a Linux AMI</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceMonitoring. 
        /// <para>
        /// Controls whether instances in this group are launched with detailed (<c>true</c>)
        /// or basic (<c>false</c>) monitoring.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/latest/userguide/enable-as-instance-metrics.html">Configure
        /// monitoring for Auto Scaling instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceMonitoring InstanceMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMonitoring property is set.
        /// </summary>
        internal bool IsSetInstanceMonitoring() => this.InstanceMonitoring != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// The instance type for the instances. For information about available instance types,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#AvailableInstanceTypes">Available
        /// instance types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string InstanceType { get; set; }

        /// <summary>
        /// Checks to see if the InstanceType property is set.
        /// </summary>
        internal bool IsSetInstanceType() => this.InstanceType != null;

        /// <summary>
        /// Gets and sets the property KernelId. 
        /// <para>
        /// The ID of the kernel associated with the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
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
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
        /// EC2 key pairs and Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property LaunchConfigurationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the launch configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string LaunchConfigurationARN { get; set; }

        /// <summary>
        /// Checks to see if the LaunchConfigurationARN property is set.
        /// </summary>
        internal bool IsSetLaunchConfigurationARN() => this.LaunchConfigurationARN != null;

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string LaunchConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the LaunchConfigurationName property is set.
        /// </summary>
        internal bool IsSetLaunchConfigurationName() => this.LaunchConfigurationName != null;

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the instances. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-launch-config.html#launch-configurations-imds">Configure
        /// the instance metadata options</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceMetadataOptions MetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOptions property is set.
        /// </summary>
        internal bool IsSetMetadataOptions() => this.MetadataOptions != null;

        /// <summary>
        /// Gets and sets the property PlacementTenancy. 
        /// <para>
        /// The tenancy of the instance, either <c>default</c> or <c>dedicated</c>. An instance
        /// with <c>dedicated</c> tenancy runs on isolated, single-tenant hardware and can only
        /// be launched into a VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string PlacementTenancy { get; set; }

        /// <summary>
        /// Checks to see if the PlacementTenancy property is set.
        /// </summary>
        internal bool IsSetPlacementTenancy() => this.PlacementTenancy != null;

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The ID of the RAM disk associated with the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string RamdiskId { get; set; }

        /// <summary>
        /// Checks to see if the RamdiskId property is set.
        /// </summary>
        internal bool IsSetRamdiskId() => this.RamdiskId != null;

        /// <summary>
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list that contains the security groups to assign to the instances in the Auto Scaling
        /// group. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-security-groups.html">Control
        /// traffic to your Amazon Web Services resources using security groups</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i>.
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
        /// The maximum hourly price to be paid for any Spot Instance launched to fulfill the
        /// request. Spot Instances are launched when the price you specify exceeds the current
        /// Spot price. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/launch-template-spot-instances.html">Requesting
        /// Spot Instances for fault-tolerant and flexible applications</a> in the <i>Amazon EC2
        /// Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SpotPrice { get; set; }

        /// <summary>
        /// Checks to see if the SpotPrice property is set.
        /// </summary>
        internal bool IsSetSpotPrice() => this.SpotPrice != null;

        /// <summary>
        /// Gets and sets the property UserData. 
        /// <para>
        /// The user data to make available to the launched EC2 instances. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-metadata.html">Instance
        /// metadata and user data</a> in the <i>Amazon EC2 User Guide</i>. If you are using a
        /// command line tool, base64-encoding is performed for you, and you can load the text
        /// from a file. Otherwise, you must provide base64-encoded text. User data is limited
        /// to 16 KB.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 21847)]
        public string UserData { get; set; }

        /// <summary>
        /// Checks to see if the UserData property is set.
        /// </summary>
        internal bool IsSetUserData() => this.UserData != null;
    }
}
