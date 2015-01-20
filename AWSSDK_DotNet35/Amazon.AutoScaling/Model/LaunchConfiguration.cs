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

/*
 * Do not modify this file. This file is generated from the autoscaling-2011-01-01.normal.json service model.
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
    /// Describes a launch configuration.
    /// </summary>
    public partial class LaunchConfiguration
    {
        private bool? _associatePublicIpAddress;
        private List<BlockDeviceMapping> _blockDeviceMappings = new List<BlockDeviceMapping>();
        private string _classicLinkVPCId;
        private List<string> _classicLinkVPCSecurityGroups = new List<string>();
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
        private string _placementTenancy;
        private string _ramdiskId;
        private List<string> _securityGroups = new List<string>();
        private string _spotPrice;
        private string _userData;

        /// <summary>
        /// Gets and sets the property AssociatePublicIpAddress. 
        /// <para>
        /// Specifies whether the EC2 instances are associated with a public IP address (<code>true</code>)
        /// or not (<code>false</code>).
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
        /// A block device mapping that specifies how block devices are exposed to the instance.
        /// Each mapping is made up of a <code>virtualName</code> and a <code>deviceName</code>.
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
        /// The ID of a ClassicLink-enabled VPC to link your EC2-Classic instances to. This parameter
        /// can only be used if you are launching EC2-Classic instances. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
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
        /// The IDs of one or more security groups for the VPC specified in <code>ClassicLinkVPCId</code>.
        /// This parameter is required if <code>ClassicLinkVPCId</code> is specified, and cannot
        /// be used otherwise. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// Gets and sets the property CreatedTime. 
        /// <para>
        /// The creation date and time for the launch configuration.
        /// </para>
        /// </summary>
        public DateTime CreatedTime
        {
            get { return this._createdTime.GetValueOrDefault(); }
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
        /// Controls whether the instance is optimized for EBS I/O (<code>true</code>) or not
        /// (<code>false</code>).
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
        /// The name or Amazon Resource Name (ARN) of the instance profile associated with the
        /// IAM role for the instance.
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
        /// The ID of the Amazon Machine Image (AMI).
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
        /// Gets and sets the property InstanceMonitoring. 
        /// <para>
        /// Controls whether instances in this group are launched with detailed monitoring.
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
        /// The instance type for the EC2 instances.
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
        /// The ID of the kernel associated with the AMI.
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
        /// Gets and sets the property LaunchConfigurationARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the launch configuration.
        /// </para>
        /// </summary>
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
        /// The tenancy of the instance, either <code>default</code> or <code>dedicated</code>.
        /// An instance with <code>dedicated</code> tenancy runs in an isolated, single-tenant
        /// hardware and can only be launched in a VPC.
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
        /// The ID of the RAM disk associated with the AMI.
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
        /// The security groups to associate with the EC2 instances.
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
        /// The price to bid when launching Spot Instances.
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
        /// The user data available to the EC2 instances.
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