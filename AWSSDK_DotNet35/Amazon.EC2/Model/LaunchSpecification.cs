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
    /// <para>Describes the launch specification of a Spot Instance.</para>
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
        /// The ID of the AMI.
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

        /// <summary>
        /// One or more security groups.
        ///  
        /// </summary>
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

        /// <summary>
        /// One or more security groups.
        ///  
        /// </summary>
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
        /// The Base64-encoded MIME user data to make available to the instances.
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
        /// <p/>
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
        /// The instance type.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>t1.micro, m1.small, m1.medium, m1.large, m1.xlarge, m3.xlarge, m3.2xlarge, m2.xlarge, m2.2xlarge, m2.4xlarge, cr1.8xlarge, i2.xlarge, i2.2xlarge, i2.4xlarge, i2.8xlarge, hi1.4xlarge, hs1.8xlarge, c1.medium, c1.xlarge, c3.large, c3.xlarge, c3.2xlarge, c3.4xlarge, c3.8xlarge, cc1.4xlarge, cc2.8xlarge, g2.2xlarge, cg1.4xlarge</description>
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
        /// The placement information for the instance.
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
        /// The ID of the kernel.
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
        /// The ID of the RAM disk.
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
        /// One or more block device mapping entries.
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
        /// Enables monitoring for the instance. Default: Disabled
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
        /// The ID of the subnet in which to launch the Spot Instance.
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

        /// <summary>
        /// One or more network interfaces.
        ///  
        /// </summary>
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

        /// <summary>
        /// The IAM instance profile.
        ///  
        /// </summary>
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

        /// <summary>
        /// Indicates whether the instance is optimized for EBS I/O. This optimization provides dedicated throughput to Amazon EBS and an optimized
        /// configuration stack to provide optimal EBS I/O performance. This optimization isn't available with all instance types. Additional usage
        /// charges apply when using an EBS Optimized instance. Default: <c>false</c>
        ///  
        /// </summary>
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
