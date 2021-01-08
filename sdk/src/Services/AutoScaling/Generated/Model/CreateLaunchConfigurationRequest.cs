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
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLaunchConfiguration operation.
    /// Creates a launch configuration.
    /// 
    ///  
    /// <para>
    /// If you exceed your maximum limit of launch configurations, the call fails. To query
    /// this limit, call the <a>DescribeAccountLimits</a> API. For information about updating
    /// this limit, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/as-account-limits.html">Amazon
    /// EC2 Auto Scaling service quotas</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/LaunchConfiguration.html">Launch
    /// configurations</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateLaunchConfigurationRequest : AmazonAutoScalingRequest
    {
        private bool? _associatePublicIpAddress;
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private string _classicLinkVPCId;
        private List<string> _classicLinkVPCSecurityGroups = new List<string>();
        private bool? _ebsOptimized;
        private string _iamInstanceProfile;
        private string _imageId;
        private string _instanceId;
        private InstanceMonitoring _instanceMonitoring;
        private string _instanceType;
        private string _kernelId;
        private string _keyName;
        private string _launchConfigurationName;
        private InstanceMetadataOptions _metadataOptions;
        private string _placementTenancy;
        private string _ramdiskId;
        private List<string> _securityGroups = new List<string>();
        private string _spotPrice;
        private string _userData;

        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// For Auto Scaling groups that are running in a virtual private cloud (VPC), specifies
        /// whether to assign a public IP address to the group's instances. If you specify <code>true</code>,
        /// each instance in the Auto Scaling group receives a unique public IP address. For more
        /// information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-in-vpc.html">Launching
        /// Auto Scaling instances in a VPC</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify this parameter, you must specify at least one subnet for <code>VPCZoneIdentifier</code>
        /// when you create your group.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the instance is launched into a default subnet, the default is to assign a public
        /// IP address, unless you disabled the option to assign a public IP address on the subnet.
        /// If the instance is launched into a nondefault subnet, the default is not to assign
        /// a public IP address, unless you enabled the option to assign a public IP address on
        /// the subnet.
        /// </para>
        ///  </note>
        /// </summary>
        public bool AssociatePublicIpAddress
        {
            get { return this._associatePublicIpAddress.GetValueOrDefault(); }
            set { this._associatePublicIpAddress = value; }
        }

        // Check to see if AssociatePublicIpAddress property is set
        internal bool IsSetAssociatePublicIpAddress()
        {
            return this._associatePublicIpAddress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BlockDeviceMappings. 
        /// <para>
        /// A block device mapping, which specifies the block devices for the instance. You can
        /// specify virtual devices and EBS volumes. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html">Block
        /// Device Mapping</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
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
        /// Gets and sets the property ClassicLinkVPCId. 
        /// <para>
        /// The ID of a ClassicLink-enabled VPC to link your EC2-Classic instances to. For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon EC2 User Guide for Linux Instances</i> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-in-vpc.html#as-ClassicLink">Linking
        /// EC2-Classic instances to a VPC</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter can only be used if you are launching EC2-Classic instances.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ClassicLinkVPCId
        {
            get { return this._classicLinkVPCId; }
            set { this._classicLinkVPCId = value; }
        }

        // Check to see if ClassicLinkVPCId property is set
        internal bool IsSetClassicLinkVPCId()
        {
            return this._classicLinkVPCId != null;
        }

        /// <summary>
        /// Gets and sets the property ClassicLinkVPCSecurityGroups. 
        /// <para>
        /// The IDs of one or more security groups for the specified ClassicLink-enabled VPC.
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon EC2 User Guide for Linux Instances</i> and <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-in-vpc.html#as-ClassicLink">Linking
        /// EC2-Classic instances to a VPC</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you specify the <code>ClassicLinkVPCId</code> parameter, you must specify this
        /// parameter.
        /// </para>
        /// </summary>
        public List<string> ClassicLinkVPCSecurityGroups
        {
            get { return this._classicLinkVPCSecurityGroups; }
            set { this._classicLinkVPCSecurityGroups = value; }
        }

        // Check to see if ClassicLinkVPCSecurityGroups property is set
        internal bool IsSetClassicLinkVPCSecurityGroups()
        {
            return this._classicLinkVPCSecurityGroups != null && this._classicLinkVPCSecurityGroups.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Specifies whether the launch configuration is optimized for EBS I/O (<code>true</code>)
        /// or not (<code>false</code>). The optimization provides dedicated throughput to Amazon
        /// EBS and an optimized configuration stack to provide optimal I/O performance. This
        /// optimization is not available with all instance types. Additional fees are incurred
        /// when you enable EBS optimization for an instance type that is not EBS-optimized by
        /// default. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSOptimized.html">Amazon
        /// EBS-Optimized Instances</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>false</code>.
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
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The name or the Amazon Resource Name (ARN) of the instance profile associated with
        /// the IAM role for the instance. The instance profile contains the IAM role.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/us-iam-role.html">IAM
        /// role for applications that run on Amazon EC2 instances</a> in the <i>Amazon EC2 Auto
        /// Scaling User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string IamInstanceProfile
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
        /// The ID of the Amazon Machine Image (AMI) that was assigned during registration. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/finding-an-ami.html">Finding
        /// an AMI</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify <code>InstanceId</code>, you must specify <code>ImageId</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-lc-with-instanceID.html">Creating
        /// a launch configuration using an EC2 instance</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify <code>InstanceId</code>, you must specify both <code>ImageId</code>
        /// and <code>InstanceType</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=19)]
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
        /// Gets and sets the property InstanceMonitoring. 
        /// <para>
        /// Controls whether instances in this group are launched with detailed (<code>true</code>)
        /// or basic (<code>false</code>) monitoring.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>true</code> (enabled).
        /// </para>
        ///  <important> 
        /// <para>
        /// When detailed monitoring is enabled, Amazon CloudWatch generates metrics every minute
        /// and your account is charged a fee. When you disable detailed monitoring, CloudWatch
        /// generates metrics every 5 minutes. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/latest/userguide/enable-as-instance-metrics.html">Configure
        /// Monitoring for Auto Scaling Instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  </important>
        /// </summary>
        public InstanceMonitoring InstanceMonitoring
        {
            get { return this._instanceMonitoring; }
            set { this._instanceMonitoring = value; }
        }

        // Check to see if InstanceMonitoring property is set
        internal bool IsSetInstanceMonitoring()
        {
            return this._instanceMonitoring != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceType. 
        /// <para>
        /// Specifies the instance type of the EC2 instance.
        /// </para>
        ///  
        /// <para>
        /// For information about available instance types, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#AvailableInstanceTypes">Available
        /// Instance Types</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        ///  
        /// <para>
        /// If you do not specify <code>InstanceId</code>, you must specify <code>InstanceType</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The ID of the kernel associated with the AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The name of the key pair. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
        /// EC2 Key Pairs</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration. This name must be unique per Region per account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string LaunchConfigurationName
        {
            get { return this._launchConfigurationName; }
            set { this._launchConfigurationName = value; }
        }

        // Check to see if LaunchConfigurationName property is set
        internal bool IsSetLaunchConfigurationName()
        {
            return this._launchConfigurationName != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// The metadata options for the instances. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-launch-config.html#launch-configurations-imds">Configuring
        /// the Instance Metadata Options</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        /// </summary>
        public InstanceMetadataOptions MetadataOptions
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
        /// Gets and sets the property PlacementTenancy. 
        /// <para>
        /// The tenancy of the instance. An instance with <code>dedicated</code> tenancy runs
        /// on isolated, single-tenant hardware and can only be launched into a VPC.
        /// </para>
        ///  
        /// <para>
        /// To launch dedicated instances into a shared tenancy VPC (a VPC with the instance placement
        /// tenancy attribute set to <code>default</code>), you must set the value of this parameter
        /// to <code>dedicated</code>.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>PlacementTenancy</code>, you must specify at least one subnet
        /// for <code>VPCZoneIdentifier</code> when you create your group.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/auto-scaling-dedicated-instances.html">Configuring
        /// instance tenancy with Amazon EC2 Auto Scaling</a> in the <i>Amazon EC2 Auto Scaling
        /// User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>default</code> | <code>dedicated</code> 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string PlacementTenancy
        {
            get { return this._placementTenancy; }
            set { this._placementTenancy = value; }
        }

        // Check to see if PlacementTenancy property is set
        internal bool IsSetPlacementTenancy()
        {
            return this._placementTenancy != null;
        }

        /// <summary>
        /// Gets and sets the property RamdiskId. 
        /// <para>
        /// The ID of the RAM disk to select.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property SecurityGroups. 
        /// <para>
        /// A list that contains the security groups to assign to the instances in the Auto Scaling
        /// group.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] Specify the security group IDs. For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic] Specify either the security group names or the security group IDs. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 Security Groups</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        public List<string> SecurityGroups
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
        /// Gets and sets the property SpotPrice. 
        /// <para>
        /// The maximum hourly price to be paid for any Spot Instance launched to fulfill the
        /// request. Spot Instances are launched when the price you specify exceeds the current
        /// Spot price. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/asg-launch-spot-instances.html">Requesting
        /// Spot Instances</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// When you change your maximum price by creating a new launch configuration, running
        /// instances will continue to run as long as the maximum price for those running instances
        /// is higher than the current Spot price.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string SpotPrice
        {
            get { return this._spotPrice; }
            set { this._spotPrice = value; }
        }

        // Check to see if SpotPrice property is set
        internal bool IsSetSpotPrice()
        {
            return this._spotPrice != null;
        }

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
        [AWSProperty(Max=21847)]
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