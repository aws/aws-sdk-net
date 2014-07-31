/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AutoScaling.Model
{
    /// <summary>
    /// Container for the parameters to the CreateLaunchConfiguration operation.
    /// Creates a new launch configuration. The launch configuration name must be unique
    /// within the scope of the client's AWS account. The maximum limit of launch configurations,
    /// which by default is 100, must not yet have been met; otherwise, the call will fail.
    /// When created, the new launch configuration is available for immediate use.
    /// </summary>
    public partial class CreateLaunchConfigurationRequest : AmazonAutoScalingRequest
    {
        private bool? _associatePublicIpAddress;
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private bool? _ebsOptimized;
        private string _iamInstanceProfile;
        private string _imageId;
        private string _instanceId;
        private InstanceMonitoring _instanceMonitoring;
        private string _instanceType;
        private string _kernelId;
        private string _keyName;
        private string _launchConfigurationName;
        private string _placementTenancy;
        private string _ramdiskId;
        private List<string> _securityGroups = new List<string>();
        private string _spotPrice;
        private string _userData;


        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Used for Auto Scaling groups that launch instances into an Amazon Virtual Private
        /// Cloud (Amazon VPC). Specifies whether to assign a public IP address to each instance
        /// launched in a Amazon VPC. For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/autoscalingsubnets.html">Auto
        /// Scaling in Amazon Virtual Private Cloud</a>.
        /// </para>
        ///  
        /// <para>
        /// Default: If the instance is launched into a default subnet in a default VPC, the default
        /// is <code>true</code>. If the instance is launched into a nondefault subnet in a VPC,
        /// the default is <code>false</code>. For information about default VPC and VPC platforms,
        /// see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide//as-supported-platforms.html">Supported
        /// Platforms</a>.
        /// </para>
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
        ///  A list of mappings that specify how block devices are exposed to the instance. Each
        /// mapping is made up of a <i>VirtualName</i>, a <i>DeviceName</i>, and an <i>ebs</i>
        /// data structure that contains information about the associated Elastic Block Storage
        /// volume. For more information about Amazon EC2 BlockDeviceMappings, go to <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/index.html?block-device-mapping-concepts.html">
        /// Block Device Mapping</a> in the Amazon EC2 product documentation. 
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
        /// Gets and sets the property EbsOptimized. 
        /// <para>
        ///  Whether the instance is optimized for EBS I/O. The optimization provides dedicated
        /// throughput to Amazon EBS and an optimized configuration stack to provide optimal EBS
        /// I/O performance. This optimization is not available with all instance types. Additional
        /// usage charges apply when using an EBS Optimized instance. By default the instance
        /// is not optimized for EBS I/O. For information about EBS-optimized instances, go to
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#EBSOptimized">EBS-Optimized
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
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
        /// the IAM role for the instance.
        /// </para>
        ///  
        /// <para>
        /// Amazon EC2 instances launched with an IAM role will automatically have AWS security
        /// credentials available. You can use IAM roles with Auto Scaling to automatically enable
        /// applications running on your Amazon EC2 instances to securely access other AWS resources.
        /// For information on launching EC2 instances with an IAM role, go to <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/us-iam-role.html">Launching
        /// Auto Scaling Instances With an IAM Role</a> in the <i>Auto Scaling Developer Guide</i>.
        /// </para>
        /// </summary>
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
        ///  Unique ID of the Amazon Machine Image (AMI) you want to use to launch your EC2 instances.
        /// For information about finding Amazon EC2 AMIs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/finding-an-ami.html">Finding
        /// a Suitable AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// Gets and sets the property InstanceId. 
        /// <para>
        ///  The ID of the Amazon EC2 instance you want to use to create the launch configuration.
        /// Use this attribute if you want the launch configuration to derive its attributes from
        /// an EC2 instance. 
        /// </para>
        ///  
        /// <para>
        ///  When you use an instance to create a launch configuration, all you need to specify
        /// is the <code>InstanceId</code>. The new launch configuration, by default, derives
        /// all the attributes from the specified instance with the exception of <code>BlockDeviceMapping</code>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// If you want to create a launch configuration with <code>BlockDeviceMapping</code>
        /// or override any other instance attributes, specify them as part of the same request.
        /// </para>
        ///  
        /// <para>
        /// For more information on using an InstanceID to create a launch configuration, see
        /// <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/create-lc-with-instanceID.html">Create
        /// a Launch Configuration Using an Amazon EC2 Instance</a> in the <i>Auto Scaling Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
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
        /// Enables detailed monitoring if it is disabled. Detailed monitoring is enabled by default.
        /// </para>
        ///  
        /// <para>
        ///  When detailed monitoring is enabled, Amazon Cloudwatch will generate metrics every
        /// minute and your account will be charged a fee. When you disable detailed monitoring,
        /// by specifying <code>False</code>, Cloudwatch will generate metrics every 5 minutes.
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/as-instance-monitoring.html">Monitor
        /// Your Auto Scaling Instances</a>. For information about Amazon CloudWatch, see the
        /// <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/DeveloperGuide/Welcome.html">Amazon
        /// CloudWatch Developer Guide</a>. 
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
        ///  The instance type of the Amazon EC2 instance. For information about available Amazon
        /// EC2 instance types, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html#AvailableInstanceTypes">
        /// Available Instance Types</a> in the <i>Amazon Elastic Cloud Compute User Guide.</i>
        /// 
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
        ///  The ID of the kernel associated with the Amazon EC2 AMI. 
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
        ///  The name of the Amazon EC2 key pair. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/generating-a-keypair.html">Getting
        /// a Key Pair</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
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
        /// Gets and sets the property LaunchConfigurationName. 
        /// <para>
        ///  The name of the launch configuration to create. 
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PlacementTenancy. 
        /// <para>
        /// The tenancy of the instance. An instance with a tenancy of <code>dedicated</code>
        /// runs on single-tenant hardware and can only be launched in a VPC.
        /// </para>
        ///  
        /// <para>
        /// You must set the value of this parameter to <code>dedicated</code> if want to launch
        /// Dedicated Instances in a shared tenancy VPC (VPC with instance placement tenancy attribute
        /// set to <code>default</code>).
        /// </para>
        ///  
        /// <para>
        /// If you specify a value for this parameter, be sure to specify at least one VPC subnet
        /// using the <i>VPCZoneIdentifier</i> parameter when you create your Auto Scaling group.
        /// 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/autoscalingsubnets.html">Auto
        /// Scaling in Amazon Virtual Private Cloud</a> in the <i>Auto Scaling Developer Guide</i>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>default</code> | <code>dedicated</code>
        /// </para>
        /// </summary>
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
        ///  The ID of the RAM disk associated with the Amazon EC2 AMI. 
        /// </para>
        /// </summary>
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
        ///  The security groups with which to associate Amazon EC2 or Amazon VPC instances.
        /// </para>
        ///  
        /// <para>
        /// If your instances are launched in EC2, you can either specify Amazon EC2 security
        /// group names or the security group IDs. For more information about Amazon EC2 security
        /// groups, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/index.html?using-network-security.html">
        /// Using Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If your instances are launched within VPC, specify Amazon VPC security group IDs.
        /// For more information about Amazon VPC security groups, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/index.html?VPC_SecurityGroups.html">Security
        /// Groups</a> in the <i>Amazon Virtual Private Cloud User Guide</i>. 
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
        /// Spot market price. For more information on launching Spot Instances, see <a href="http://docs.aws.amazon.com/AutoScaling/latest/DeveloperGuide/US-SpotInstances.html">
        /// Using Auto Scaling to Launch Spot Instances</a> in the <i>Auto Scaling Developer Guide</i>.
        /// 
        /// </para>
        /// </summary>
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
        ///  The user data to make available to the launched Amazon EC2 instances. For more information
        /// about Amazon EC2 user data, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html#instancedata-user-data-retrieval">User
        /// Data Retrieval</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
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