/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para> The LaunchSpecificationType data type. </para>
    /// </summary>
    public class LaunchSpecification
    {
        
        private string imageId;
        private string keyName;
        private List<GroupIdentifier> allSecurityGroups = new List<GroupIdentifier>();
        private List<string> securityGroups = new List<string>();
        private string userData;
        private string addressingType;
        private InstanceType instanceType;
        private SpotPlacement placement;
        private string kernelId;
        private string ramdiskId;
        private List<BlockDeviceMapping> blockDeviceMappings = new List<BlockDeviceMapping>();
        private bool? monitoringEnabled;
        private string subnetId;
        private List<InstanceNetworkInterfaceSpecification> networkInterfaces = new List<InstanceNetworkInterfaceSpecification>();
        private IamInstanceProfileSpecification iamInstanceProfile;
        private bool? ebsOptimized;


        /// <summary>
        /// The AMI ID.
        ///  
        /// </summary>
        public string ImageId
        {
            get { return this.imageId; }
            set { this.imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this.imageId != null;
        }

        /// <summary>
        /// The name of the key pair.
        ///  
        /// </summary>
        public string KeyName
        {
            get { return this.keyName; }
            set { this.keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this.keyName != null;
        }
        public List<GroupIdentifier> AllSecurityGroups
        {
            get { return this.allSecurityGroups; }
            set { this.allSecurityGroups = value; }
        }

        // Check to see if AllSecurityGroups property is set
        internal bool IsSetAllSecurityGroups()
        {
            return this.allSecurityGroups.Count > 0;
        }
        public List<string> SecurityGroups
        {
            get { return this.securityGroups; }
            set { this.securityGroups = value; }
        }

        // Check to see if SecurityGroups property is set
        internal bool IsSetSecurityGroups()
        {
            return this.securityGroups.Count > 0;
        }

        /// <summary>
        /// Optional data, specific to a user's application, to provide in the launch request. All instances that collectively comprise the launch
        /// request have access to this data. User data is never returned through API responses.
        ///  
        /// </summary>
        public string UserData
        {
            get { return this.userData; }
            set { this.userData = value; }
        }

        // Check to see if UserData property is set
        internal bool IsSetUserData()
        {
            return this.userData != null;
        }

        /// <summary>
        /// Deprecated.
        ///  
        /// </summary>
        public string AddressingType
        {
            get { return this.addressingType; }
            set { this.addressingType = value; }
        }

        // Check to see if AddressingType property is set
        internal bool IsSetAddressingType()
        {
            return this.addressingType != null;
        }

        /// <summary>
        /// Specifies the instance type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>t1.micro, m1.small, m1.medium, m1.large, m1.xlarge, m2.xlarge, m2.2xlarge, m2.4xlarge, m3.xlarge, m3.2xlarge, c1.medium, c1.xlarge, hi1.4xlarge, hs1.8xlarge, cc1.4xlarge, cc2.8xlarge, cg1.4xlarge, cr1.8xlarge</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public InstanceType InstanceType
        {
            get { return this.instanceType; }
            set { this.instanceType = value; }
        }

        // Check to see if InstanceType property is set
        internal bool IsSetInstanceType()
        {
            return this.instanceType != null;
        }

        /// <summary>
        /// Defines a placement item.
        ///  
        /// </summary>
        public SpotPlacement Placement
        {
            get { return this.placement; }
            set { this.placement = value; }
        }

        // Check to see if Placement property is set
        internal bool IsSetPlacement()
        {
            return this.placement != null;
        }

        /// <summary>
        /// Specifies the ID of the kernel to select.
        ///  
        /// </summary>
        public string KernelId
        {
            get { return this.kernelId; }
            set { this.kernelId = value; }
        }

        // Check to see if KernelId property is set
        internal bool IsSetKernelId()
        {
            return this.kernelId != null;
        }

        /// <summary>
        /// Specifies the ID of the RAM disk to select. Some kernels require additional drivers at launch. Check the kernel requirements for information
        /// on whether or not you need to specify a RAM disk and search for the kernel ID.
        ///  
        /// </summary>
        public string RamdiskId
        {
            get { return this.ramdiskId; }
            set { this.ramdiskId = value; }
        }

        // Check to see if RamdiskId property is set
        internal bool IsSetRamdiskId()
        {
            return this.ramdiskId != null;
        }

        /// <summary>
        /// Specifies how block devices are exposed to the instance. Each mapping is made up of a virtualName and a deviceName.
        ///  
        /// </summary>
        public List<BlockDeviceMapping> BlockDeviceMappings
        {
            get { return this.blockDeviceMappings; }
            set { this.blockDeviceMappings = value; }
        }

        // Check to see if BlockDeviceMappings property is set
        internal bool IsSetBlockDeviceMappings()
        {
            return this.blockDeviceMappings.Count > 0;
        }

        /// <summary>
        /// Enables monitoring for the instance.
        ///  
        /// </summary>
        public bool MonitoringEnabled
        {
            get { return this.monitoringEnabled ?? default(bool); }
            set { this.monitoringEnabled = value; }
        }

        // Check to see if MonitoringEnabled property is set
        internal bool IsSetMonitoringEnabled()
        {
            return this.monitoringEnabled.HasValue;
        }

        /// <summary>
        /// Specifies the Amazon VPC subnet ID within which to launch the instance(s) for Amazon Virtual Private Cloud.
        ///  
        /// </summary>
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }
        public List<InstanceNetworkInterfaceSpecification> NetworkInterfaces
        {
            get { return this.networkInterfaces; }
            set { this.networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this.networkInterfaces.Count > 0;
        }
        public IamInstanceProfileSpecification IamInstanceProfile
        {
            get { return this.iamInstanceProfile; }
            set { this.iamInstanceProfile = value; }
        }

        // Check to see if IamInstanceProfile property is set
        internal bool IsSetIamInstanceProfile()
        {
            return this.iamInstanceProfile != null;
        }
        public bool EbsOptimized
        {
            get { return this.ebsOptimized ?? default(bool); }
            set { this.ebsOptimized = value; }
        }

        // Check to see if EbsOptimized property is set
        internal bool IsSetEbsOptimized()
        {
            return this.ebsOptimized.HasValue;
        }
    }
}
