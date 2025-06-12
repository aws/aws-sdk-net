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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Describes a launch configuration.
    /// </summary>
    public partial class LaunchConfiguration
    {
        private bool? _associatePublicIpAddress;
        private List<BlockDeviceMapping> _blockDeviceMappings = AWSConfigs.InitializeCollections ? new List<BlockDeviceMapping>() : null;
        private string _classicLinkVPCId;
        private List<string> _classicLinkVPCSecurityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private DateTime? _createdTime;
        private bool? _ebsOptimized;
        private string _iamInstanceProfile;
        private string _imageId;
        private InstanceMonitoring _instanceMonitoring;
        private string _instanceType;
        private string _kernelId;
        private string _keyName;
        private string _launchConfigurationARN;
        private string _launchConfigurationName;
        private InstanceMetadataOptions _metadataOptions;
        private string _placementTenancy;
        private string _ramdiskId;
        private List<string> _securityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _spotPrice;
        private string _userData;

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
        public bool? AssociatePublicIpAddress
        {
            get { return this._associatePublicIpAddress; }
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
        /// The block device mapping entries that define the block devices to attach to the instances
        /// at launch. By default, the block devices specified in the block device mapping for
        /// the AMI are used. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html">Block
        /// device mappings</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
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
        /// Gets and sets the property ClassicLinkVPCId. 
        /// <para>
        /// Available for backward compatibility.
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
        /// Available for backward compatibility.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ClassicLinkVPCSecurityGroups
        {
            get { return this._classicLinkVPCSecurityGroups; }
            set { this._classicLinkVPCSecurityGroups = value; }
        }

        // Check to see if ClassicLinkVPCSecurityGroups property is set
        internal bool IsSetClassicLinkVPCSecurityGroups()
        {
            return this._classicLinkVPCSecurityGroups != null && (this._classicLinkVPCSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The creation date and time for the launch configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTime
        {
            get { return this._createdTime; }
            set { this._createdTime = value; }
        }

        // Check to see if CreatedTime property is set
        internal bool IsSetCreatedTime()
        {
            return this._createdTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        /// Specifies whether the launch configuration is optimized for EBS I/O (<c>true</c>)
        /// or not (<c>false</c>). For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-optimized.html">Amazon
        /// EBS-optimized instances</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Gets and sets the property IamInstanceProfile. 
        /// <para>
        /// The name or the Amazon Resource Name (ARN) of the instance profile associated with
        /// the IAM role for the instance. The instance profile contains the IAM role. For more
        /// information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/us-iam-role.html">IAM
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
        /// The ID of the Amazon Machine Image (AMI) to use to launch your EC2 instances. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/finding-an-ami.html">Find
        /// a Linux AMI</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The instance type for the instances. For information about available instance types,
        /// see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#AvailableInstanceTypes">Available
        /// instance types</a> in the <i>Amazon EC2 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// The name of the key pair.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Amazon
        /// EC2 key pairs and Amazon EC2 instances</a> in the <i>Amazon EC2 User Guide</i>.
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
        /// Gets and sets the property LaunchConfigurationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the launch configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string LaunchConfigurationARN
        {
            get { return this._launchConfigurationARN; }
            set { this._launchConfigurationARN = value; }
        }

        // Check to see if LaunchConfigurationARN property is set
        internal bool IsSetLaunchConfigurationARN()
        {
            return this._launchConfigurationARN != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        /// The name of the launch configuration.
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
        /// The metadata options for the instances. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/create-launch-config.html#launch-configurations-imds">Configure
        /// the instance metadata options</a> in the <i>Amazon EC2 Auto Scaling User Guide</i>.
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
        /// The tenancy of the instance, either <c>default</c> or <c>dedicated</c>. An instance
        /// with <c>dedicated</c> tenancy runs on isolated, single-tenant hardware and can only
        /// be launched into a VPC.
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
        /// The ID of the RAM disk associated with the AMI.
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
        /// group. For more information, see <a href="https://docs.aws.amazon.com/vpc/latest/userguide/vpc-security-groups.html">Control
        /// traffic to your Amazon Web Services resources using security groups</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i>.
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
        /// Gets and sets the property SpotPrice. 
        /// <para>
        /// The maximum hourly price to be paid for any Spot Instance launched to fulfill the
        /// request. Spot Instances are launched when the price you specify exceeds the current
        /// Spot price. For more information, see <a href="https://docs.aws.amazon.com/autoscaling/ec2/userguide/launch-template-spot-instances.html">Requesting
        /// Spot Instances for fault-tolerant and flexible applications</a> in the <i>Amazon EC2
        /// Auto Scaling User Guide</i>.
        /// </para>
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
        /// metadata and user data</a> in the <i>Amazon EC2 User Guide</i>. If you are using a
        /// command line tool, base64-encoding is performed for you, and you can load the text
        /// from a file. Otherwise, you must provide base64-encoded text. User data is limited
        /// to 16 KB.
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