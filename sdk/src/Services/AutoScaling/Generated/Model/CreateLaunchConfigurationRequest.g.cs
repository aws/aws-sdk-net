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
    /// Container for the parameters to the CreateLaunchConfiguration operation. Creates a
    /// launch configuration. <para> If you exceed your maximum limit of launch configurations,
    /// the call fails. To query this limit, call the <a href="https://docs.aws.amazon.com/autoscaling/ec2/APIReference/API_DescribeAccountLimits.html">DescribeAccountLimits</a>
    /// API. For information about updating this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/ec2-auto-scaling-quotas.html">Quotas
    /// for Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para> <para> For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/launch-configurations.html">Launch
    /// configurations</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. </para> <note>
    /// <para> Amazon EC2 Auto Scaling configures instances launched as part of an Auto Scaling
    /// group using either a launch template or a launch configuration. We strongly recommend
    /// that you do not use launch configurations. They do not provide full functionality
    /// for Amazon EC2 Auto Scaling or Amazon EC2. For information about using launch templates,
    /// see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/launch-templates.html">Launch
    /// templates</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>. </para> </note>
    /// </summary>
    public partial class CreateLaunchConfigurationRequest : AmazonAutoScalingRequest
    {
        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Specifies whether to assign a public IPv4 address to the group's instances. If the
        /// instance is launched into a default subnet, the default is to assign a public IPv4
        /// address, unless you disabled the option to assign a public IPv4 address on the subnet.
        /// If the instance is launched into a nondefault subnet, the default is not to assign
        /// a public IPv4 address, unless you enabled the option to assign a public IPv4 address
        /// on the subnet.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>true</c>, each instance in the Auto Scaling group receives a unique
        /// public IPv4 address. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-in-vpc.html">Provide
        /// network connectivity for your Auto Scaling instances using Amazon VPC</a> in the <i>Amazon
        /// EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify this property, you must specify at least one subnet for <c>VPCZoneIdentifier</c>
        /// when you create your group.
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
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Specifies whether the launch configuration is optimized for EBS I/O (<c>true</c>)
        /// or not (<c>false</c>). The optimization provides dedicated throughput to Amazon EBS
        /// and an optimized configuration stack to provide optimal I/O performance. This optimization
        /// is not available with all instance types. Additional fees are incurred when you enable
        /// EBS optimization for an instance type that is not EBS-optimized by default. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-optimized.html">Amazon
        /// EBS-optimized instances</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>false</c>.
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
        /// The ID of the Amazon Machine Image (AMI) that was assigned during registration. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/finding-an-ami.html">Find
        /// a Linux AMI</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>InstanceId</c>, an <c>ImageId</c> is not required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance to use to create the launch configuration. The new launch configuration
        /// derives attributes from the instance, except for the block device mapping.
        /// </para>
        ///  
        /// <para>
        /// To create a launch configuration with a block device mapping or override any other
        /// instance attributes, specify them as part of the same request.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-launch-config.html">Create
        /// a launch configuration</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 19)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property InstanceMonitoring. 
        /// <para>
        /// Controls whether instances in this group are launched with detailed (<c>true</c>)
        /// or basic (<c>false</c>) monitoring.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>true</c> (enabled).
        /// </para>
        ///  <important> 
        /// <para>
        /// When detailed monitoring is enabled, Amazon CloudWatch generates metrics every minute
        /// and your account is charged a fee. When you disable detailed monitoring, CloudWatch
        /// generates metrics every 5 minutes. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/latest/userguide/enable-as-instance-metrics.html">Configure
        /// monitoring for Auto Scaling instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public InstanceMonitoring InstanceMonitoring { get; set; }

        /// <summary>
        /// Checks to see if the InstanceMonitoring property is set.
        /// </summary>
        internal bool IsSetInstanceMonitoring() => this.InstanceMonitoring != null;

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Specifies the instance type of the EC2 instance. For information about available instance
        /// types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#AvailableInstanceTypes">Available
        /// instance types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>InstanceId</c>, an <c>InstanceType</c> is not required.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
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
        ///  <note> 
        /// <para>
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedKernels.html">User
        /// provided kernels</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </note>
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
        /// The name of the key pair. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
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
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration. This name must be unique per Region per account.
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
        /// be launched into a VPC. To launch dedicated instances into a shared tenancy VPC (a
        /// VPC with the instance placement tenancy attribute set to <c>default</c>), you must
        /// set the value of this property to <c>dedicated</c>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <c>PlacementTenancy</c>, you must specify at least one subnet for <c>VPCZoneIdentifier</c>
        /// when you create your group.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <c>default</c> | <c>dedicated</c> 
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
        /// The ID of the RAM disk to select.
        /// </para>
        ///  <note> 
        /// <para>
        /// We recommend that you use PV-GRUB instead of kernels and RAM disks. For more information,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UserProvidedKernels.html">User
        /// provided kernels</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        ///  </note>
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
        /// A list that contains the security group IDs to assign to the instances in the Auto
        /// Scaling group. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-security-groups.html">Control
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
        /// Spot price. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/launch-template-spot-instances.html">Request
        /// Spot Instances for fault-tolerant and flexible applications</a> in the <i>Amazon EC2
        /// Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Range: Minimum value of 0.001
        /// </para>
        ///  <note> 
        /// <para>
        /// When you change your maximum price by creating a new launch configuration, running
        /// instances will continue to run as long as the maximum price for those running instances
        /// is higher than the current Spot price.
        /// </para>
        ///  </note>
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
        /// metadata and user data</a> (Linux) and <a href="https://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ec2-instance-metadata.html">Instance
        /// metadata and user data</a> (Windows). If you are using a command line tool, base64-encoding
        /// is performed for you, and you can load the text from a file. Otherwise, you must provide
        /// base64-encoded text. User data is limited to 16 KB.
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
